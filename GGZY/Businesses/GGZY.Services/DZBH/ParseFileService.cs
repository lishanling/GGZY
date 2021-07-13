using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;
using Dos.ORM;
using GGZY.Core.Helper;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Model;
using GGZYFW.DbEntity;
using Newtonsoft.Json;

namespace GGZY.Services.DZBH
{

    public class ParseFileService : BaseService
    {
        private string baseUrl = AppSettingUtils.GetString("baseUrl");
        public override DbSession GetDbSession()
        {
            return DbContext.Fw;
        }
        /// <summary>
        /// 获取短信验证码
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public GeneralResult GetSmsCode(string orderId)
        {
            var r = new GeneralResult();


            //判断是否有保函
            var obj = DbContext.Fw.From<BH_SEND_APPLICATION_FORM>()
                .Where((BH_SEND_APPLICATION_FORM._.ORDER_ID == orderId))
                .Select(BH_SEND_APPLICATION_FORM._.BIDDER_CONTACT_TEL)
                .ToDataTable();
            if (obj.Rows.Count > 0)
            {
                var tel = obj.Rows[0][0].ToString();
                if (tel.Length == 11)
                {
                    //发送短信
                    string code = CreateRandomCode(6);
                    string msg = $"验证码: {code}，10分钟内输入有效，仅用于查询电子保函信息，请勿告知他人。工作人员不会向您索取。";
                    SmsModel sms = new SmsModel { Mobile = tel, Content = msg, Suffix = "福建省电子保函对接服务平台", Code = code };
                    r = sms.SendSms();
                    //判断图片验证码

                    return r;
                }
            }
            r.SetFail("短信发送失败");
            return r;
        }

        public GeneralResult GetFileAndParse(string url, string path, string orderId, string validateCode)
        {
            var r = new GeneralResult();
            string filePath = "";
            //如果是order_id则先判断是否开标再解析
            if (!string.IsNullOrEmpty(orderId))
            {
                BH_SEND_APPLICATION_FORM application = DbContext.Fw.From<BH_SEND_APPLICATION_FORM>()
                    .Where(BH_SEND_APPLICATION_FORM._.ORDER_ID == orderId)
                    .Select(BH_SEND_APPLICATION_FORM._.TENDER_PROJECT_CODE, BH_SEND_APPLICATION_FORM._.ORDER_ID,
                        BH_SEND_APPLICATION_FORM._.BIDDER_CONTACT_TEL).ToFirstDefault();
                //订单号查不到则返回
                if (application == null)
                {
                    r.SetFail("未查询到该订单号相关电子保函信息");
                    return r;
                }
                //判断是否已开标
                string kbsql =
                    $"select  to_char(bid_open_time,'yyyy-mm-dd hh24:mi:ss') time from tender_ann_qua_inquery_ann where tender_project_code = '{application.TENDER_PROJECT_CODE}' and notice_send_time = (select max(notice_send_time) from tender_ann_qua_inquery_ann where tender_project_code = '{application.TENDER_PROJECT_CODE}' group by tender_project_code)";
                DataTable bkDt = DbContext.Fw.FromSql(kbsql).ToDataTable();
                if (bkDt.Rows.Count == 0)
                {
                    r.SetFail("未查询到该项目开标时间");
                    return r;
                }
                //未开标则返回短信验证码手机
                if (DateTimeHelper.ToDateTime(bkDt.Rows[0][0].ToString(), "yyyy-MM-dd HH:mm:ss") > DateTime.Now)
                {
                    //未开标且未提供短信验证码
                    if (string.IsNullOrEmpty(validateCode))
                    {
                        r.SetSuccess(new
                        {
                            status = 1,
                            orderId = orderId,
                            telphone = application.BIDDER_CONTACT_TEL.Substring(0, 3) + "****" + application.BIDDER_CONTACT_TEL.Substring(7, 4)
                        });
                        return r;
                    }
                    else
                    {
                        //验证短信验证码
                        r = SmsModel.ValidateMobileCode(application.BIDDER_CONTACT_TEL, validateCode);
                        if (r.Success)
                        {
                            //下载文件并解析
                            filePath = DownloadOfd(orderId, out url);
                        }
                        else
                        {
                            return r;
                        }
                    }

                }
                //已开标则下载文件并解析
                else
                {
                    filePath = DownloadOfd(orderId, out url);
                }
            }
            //如果是地址则先下载文件
            else if (!string.IsNullOrEmpty(url))
            {
                string savePath = AppDomain.CurrentDomain.BaseDirectory + "\\download\\";
                string saveUrl = WebUtils.Download(url, savePath);
                filePath = saveUrl;
            }
            else if (!string.IsNullOrEmpty(path))
            {
                filePath = AppDomain.CurrentDomain.BaseDirectory + path;
            }

            if (string.IsNullOrEmpty(filePath))
            {
                r.SetFail("未查询到订单号相关的电子保函信息");
                return r;
            }
            //如果是odf文件使用ofd的解析方式
            if (filePath.EndsWith(".ofd"))
            {
                return PraseOfd(url);
            }

            //解压
            Logger.Debug($"解压文件地址：{filePath}");
            r = UnZipFile(filePath);
            if (r.Success)
            {
                //提取数据
                return PraseFileInfo(r.Data.ToString());
            }
            r.SetFail("解析失败");
            return r;
        }
        /// <summary>
        /// 解析ofd文件
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public GeneralResult PraseOfd(string url)
        {
            var r = new GeneralResult();
            //解析附件
            OfdApiService ofdS = new OfdApiService();
            var validate = ofdS.Validate(url);
            var files = ofdS.GetFiles(url);
            var htmlUrl = ofdS.GetHtml(url);
            var xml = files.FirstOrDefault(e => e.GetStringValue("fileType").Contains("xml") && e.GetStringValue("fileName").Contains("结构化数据文件"));
            if (xml != null)
            {
                string xmlStr = new WebUtils().DoGet(xml.GetStringValue("fileUrl"), null);
                //xml字符串中的招标公告地址TENDER_NOTICE_URL和TENDER_FILE_URL可能存在特殊字符，先取出来进行替换成urlencode再解析
                string noticeUrl = getXmlValue(xmlStr, "TENDER_NOTICE_URL");
                if (!string.IsNullOrEmpty(noticeUrl))
                {
                    xmlStr = xmlStr.Replace(noticeUrl, HttpUtility.UrlEncode(noticeUrl));
                }
                string fileUrl = getXmlValue(xmlStr, "TENDER_FILE_URL");
                if (!string.IsNullOrEmpty(noticeUrl))
                {
                    xmlStr = xmlStr.Replace(fileUrl, HttpUtility.UrlEncode(fileUrl));
                }

                //解析xml
                XmlDocument xd = new XmlDocument();
                xd.LoadXml(xmlStr);
                string json = JsonConvert.SerializeXmlNode(xd);
                var htmlurlBuild = new StringBuilder(htmlUrl);
                htmlUrl = htmlurlBuild.Replace("http://220.160.52.12:8001/", "https://ggzyfw.fujian.gov.cn/", 0, 26).ToString();
                r.SetSuccess(new
                {
                    validate,
                    json,
                    pdfUrl = htmlUrl
                });
                return r;

            }
            r.SetFail("解析失败");
            return r;
        }

        /// <summary>
        /// 解压电子保函文件
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public GeneralResult UnZipFile(string filePath)
        {
            var result = new GeneralResult();
            //计算md5作为唯一标识
            string md5 = Encrypt.GetFileMD5(filePath);
            //创建解压目录文件夹
            string directoryName = $"{AppDomain.CurrentDomain.BaseDirectory}\\ParseFile\\{md5}";
            if (!Directory.Exists(directoryName))
            {
                Directory.CreateDirectory(directoryName);
            }
            else if (new DirectoryInfo(directoryName).GetDirectories().Length > 0)
            {
                result.SetSuccess(md5);
                return result;
            }
            //解压文件到目录
            //CompressUtils.Decompress(filePath, directoryName);
            ZipHelper.UnRarOrZip(directoryName, filePath, false, "");
            result.SetSuccess(md5);

            return result;
        }
        /// <summary>
        /// 根据md5获取解压后的数据
        /// </summary>
        /// <param name="md5"></param>
        /// <returns></returns>
        public GeneralResult PraseFileInfo(string md5)
        {
            var r = new GeneralResult();
            string directoryName = $"{AppDomain.CurrentDomain.BaseDirectory}\\ParseFile\\{md5}";
            string pdfFilePath = "";
            string xmlFilePath = "";
            string pdfUrl = "";
#pragma warning disable CS0219 // 变量“isEdc”已被赋值，但从未使用过它的值
            bool isEdc = false;
#pragma warning restore CS0219 // 变量“isEdc”已被赋值，但从未使用过它的值
            string edcFilePath = "";
            //遍历文件夹找出pdf文件和xml文件
            DirectoryInfo folder;
            string path = "";
            DirectoryInfo rootFolder = new DirectoryInfo(directoryName);
            if (rootFolder.GetDirectories().Length > 0)
            {
                folder = rootFolder.GetDirectories()[0];
                path = $"{md5}/{folder.Name}";
            }
            else
            {
                folder = rootFolder;
                path = $"{md5}";
            }
            foreach (FileInfo file in folder.GetFiles())
            {
                if (file.Name.Contains(".pdf"))
                {
                    pdfFilePath = file.FullName;
                    pdfUrl = $"/ParseFile/{path}/{file.Name}";
                }
                if (file.Name.Contains(".xml"))
                {
                    xmlFilePath = file.FullName;
                }

                if (file.Name.Contains(".edc"))
                {
                    isEdc = true;
                    edcFilePath = file.FullName;
                }
            }
            //解析xml
            /*if (isEdc && !string.IsNullOrEmpty(edcFilePath))
            {
                //从edc中解析出xml
                string xml = GetXmlFromEdc(edcFilePath);
                XmlDocument xd = new XmlDocument();
                xd.LoadXml(xml);
                string json = JsonConvert.SerializeXmlNode(xd);
                r.SetSuccess(new
                {
                    json,
                    pdfUrl
                });
            }*/
            if (!string.IsNullOrEmpty(xmlFilePath))
            {
                XmlDocument xd = new XmlDocument();
                xd.Load(xmlFilePath);
                string json = JsonConvert.SerializeXmlNode(xd);
                r.SetSuccess(new
                {
                    json,
                    pdfUrl
                });
            }
            else
            {
                r.SetFail("解析失败");
            }
            return r;
        }

        private string GetXmlFromEdc(string edcFilePath)
        {
            //todo:凯特edc解析xml
            //EDCSVR_COMLib.EDCSvrJob edc = new EDCSvrJobClass();
            //return edc.GetExtXml(edcFilePath);
            return "";
        }

        private string DownloadOfd(string orderId, out string url)
        {
            string filePath = "";
            var gurantee = DbContext.Fw.From<BH_GUARANTEE_RESULT>()
                .Where(BH_GUARANTEE_RESULT._.ORDER_ID == orderId).ToFirstDefault();
            if (gurantee != null)
            {
                //下载保函文件
                string savePath = AppDomain.CurrentDomain.BaseDirectory + "\\download\\";
                string saveUrl = WebUtils.DownloadOfd(gurantee.GUARANTEE_URL, savePath, orderId + ".ofd", false);
                filePath = saveUrl;
                url = $"{baseUrl}/download/{orderId}.ofd";
            }
            else
            {
                url = "";
            }

            return filePath;

        }
        private string CreateRandomCode(int codeCount)
        {
            string allChar = "0,1,2,3,4,5,6,7,8,9";
            string[] allCharArray = allChar.Split(',');
            string randomCode = "";
            int temp = -1;

            Random rand = new Random();
            for (int i = 0; i < codeCount; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(i * temp * ((int)DateTime.Now.Ticks));
                }
                int t = rand.Next(9);
                if (temp == t)
                {
                    return CreateRandomCode(codeCount);
                }
                temp = t;
                randomCode += allCharArray[t];
            }
            return randomCode;
        }
        /// <summary>
        /// 通过字符串截取的方式获取xml对应属性的值，因为值里面带等号无法转载
        /// </summary>
        /// <param name="xml"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        private string getXmlValue(string xml, string name)
        {
            string value = "";
            int index = xml.IndexOf(name + "=\"", StringComparison.Ordinal);
            if (index > 0)
            {
                int start = index + name.Length + 2;
                string tempXml = xml.Substring(start, xml.Length - start - 1);
                value = tempXml.Substring(0, tempXml.IndexOf("\"", StringComparison.Ordinal));
            }

            return value;
        }
    }
}
