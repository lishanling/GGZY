using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using Aspose.Words;
using Dos.ORM;
using GGZY.Core.Algorithms;
using GGZY.Core.Extensions;
using GGZY.Core.Helper;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Services.Base;
using GGZY.Services.DZBH.ParamModel;
using GGZYFW.DbEntity;

namespace GGZY.Services.DZBH
{
    public class BhSignService : BaseService
    {
        public GeneralResult CreateApplicationPdf(BH_SEND_APPLICATION_FORM model, string temPath)
        {
            var r = new GeneralResult();
            //验证模板是否存在
            temPath = AppDomain.CurrentDomain.BaseDirectory + temPath;
            if (!File.Exists(temPath))
            {
                r.SetFail("模板不存在");
                return r;
            }
            try
            {
                AsposeWord word = new AsposeWord(temPath);
                NodeCollection allTables = word.doc.GetChildNodes(NodeType.Table, true);
                foreach (var p in model.GetPropertyInfos())
                {
                    word.ReplaceText("{" + p.Name + "}", p.GetValue(model)?.ToString());
                }
                //项目类型、大写、小写
                word.ReplaceText("{TENDER_PROJECT_TYPE_TEXT}", GetProjectType(model.TENDER_PROJECT_TYPE));
                word.ReplaceText("{AMOUNT_DAXIE}", NumberHelper.CmycurD(model.BID_BOND));
                word.ReplaceText("{AMOUNT_XIAOXIE}", model.BID_BOND.ToString());
                //处理附件
                word.ReplaceText("{TENDER_FILE}", GetFileInfo(model.TENDER_FILE_AIDS));
                word.ReplaceText("{BUSINESS_LICENSE}", GetFileInfo(model.BUSINESS_LICENSE_AIDS));
                word.ReplaceText("{QUALFICATION_FILE}", GetFileInfo(model.QUALFICATION_FILE_AIDS));

                word.ReplaceText("{TIME}", DateTime.Now.ToString("yyyy年MM月dd日"));
                word.ReplaceText("{BIDDER_NAME}", model.BIDDER_NAME);

                string FileName = Guid.NewGuid().ToString("N");//DateTime.Now.ToString("yyyyMMddHHmmssffff");
                string url = "/File/SIGN/SQD/SOURCE/" + DateTime.Now.ToString("yyyyMM") + "/" + FileName + ".pdf";
                string saveUrl = AppDomain.CurrentDomain.BaseDirectory + url;
                string dir = Path.GetDirectoryName(url);
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                word.SaveAs(saveUrl, "pdf");
                //插入附件到数据库
                var attachment = new BH_SIGN_ATTACHMENT()
                {
                    GUID = Guid.NewGuid().ToString("N"),
                    SOURCE_PDF_URL = url,
                    CREATE_TIME = DateTime.Now,
                    SOURCE_PDF_FILENAME = FileName + ".pdf",
                    OVER_TIME = DateTime.Now.AddMinutes(10),
                    SOURCE_PDF_MD5 = Encrypt.GetFileMD5(saveUrl).ToUpper(),
                    ORDER_ID = model.ORDER_ID
                };
                DbContext.Fw.Insert(attachment);
                r.SetSuccess(new { id = attachment.GUID, url = url });
            }
            catch (Exception e)
            {
                r.SetFail(e.Message);
                Logger.Error("生成pdf失败", e);
            }

            return r;
        }

        private string GetFileInfo(string modelAids)
        {
            var model = DbContext.Fw.From<BH_ATTACHMENT>().Where(BH_ATTACHMENT._.ID == modelAids).ToFirst();
            if (model != null)
            {
                return $"{model.NAME} MD5:{model.MD5.ToUpper()}";
            }

            return "";
        }

        private string GetProjectType(string modelTenderProjectType)
        {
            var m = DbContext.Fw.From<SYS_DIC>()
                .Where((SYS_DIC._.VALUE == modelTenderProjectType).And(SYS_DIC._.TYPE == 2002)).ToFirst();
            if (m != null)
            {
                return m.TEXT;
            }

            return "其他";
        }

        public GeneralResult CreateSignUrl(string attachmentId)
        {
            var r = new GeneralResult();
            var aModel = DbContext.Fw.From<BH_SIGN_ATTACHMENT>().Where(BH_SIGN_ATTACHMENT._.GUID == attachmentId).ToFirst();
            if (aModel != null)
            {
                //组建参数
                string baseUrl = AppSettingUtils.GetString("baseUrl");
                string uploadUrl = baseUrl + "/BhSign/UpLoadSign";
                string loadUrl = baseUrl + aModel.SOURCE_PDF_URL;
                string param = aModel.GUID;
                Dictionary<string, string> sendParam = new Dictionary<string, string>();
                sendParam.Add("params", param);
                sendParam.Add("is_auto_close", "1");
                sendParam.Add("url", loadUrl);
                sendParam.Add("upload_url", uploadUrl);
                sendParam.Add("is_edit", "1");
                sendParam.Add("is_edit_old", "0");
                sendParam.Add("is_upload_pdf", "1");
                sendParam.Add("is_view", "0");
                string base64Param = Encrypt.Base64Code(sendParam.Serializer());
                r.SetSuccess(new { url = "FJGGFWCAUU://" + base64Param });
            }
            else
            {
                r.SetFail("数据不存在");
            }

            return r;
        }
        public GeneralResult UpLoadSign(HttpFileCollectionBase files, SignParamModel param)
        {
            var r = new GeneralResult();
            //验证合法性
            var aModel = DbContext.Fw.From<BH_SIGN_ATTACHMENT>().Where(BH_SIGN_ATTACHMENT._.GUID == param.@params)
                .First();
            if (aModel == null)
            {
                r.SetFail("数据不存在");
                return r;
            }
            if (aModel.OVER_TIME < DateTime.Now)
            {
                r.SetFail("签章已超时");
                return r;
            }

            if (files.Count == 0)
            {
                r.SetFail("未上传文件");
                return r;
            }
            //保存附件和签章信息
            string signInfo =
                ("{pc_info:" + param.pc_info + ",file_info:" + param.file_info + ",ca_info:" + param.file_info + "}")
                .ToClearSql();
            aModel.SIGN_INFO = signInfo;
            if (files.Count > 0 && files.AllKeys.Contains("pdf"))
            {
                //Logger.Debug("开始保存附件");
                //保存pdf文件
                HttpPostedFileBase file = files.Get("pdf");
                string url = "/File/SIGN/SQD/PDF/" + file.FileName;
                string path = AppDomain.CurrentDomain.BaseDirectory + url;

                file.SaveAs(path);
                string md5 = Encrypt.GetFileMD5(path).ToUpper();

                aModel.SIGN_PDF_FILENAME = file.FileName;
                aModel.SIGN_PDF_URL = url;
                aModel.SIGN_PDF_MD5 = md5;
                Logger.Debug("附件保存成功");
                //保存原文件
                if (files.Count > 1)
                {
                    HttpPostedFileBase file1 = files.GetKey(0) == "pdf" ? files[1] : files[0];
                    string url1 = "/File/SIGN/SQD/OTHER/" + file1.FileName;
                    string path1 = AppDomain.CurrentDomain.BaseDirectory + url;

                    file.SaveAs(path1);
                    string md51 = Encrypt.GetFileMD5(path1).ToUpper();

                    aModel.SIGN_SOURCE_FILE_FILENAME = file1.FileName;
                    aModel.SIGN_SOURCE_FILE_URL = url1;
                    aModel.SIGN_SOURCE_FILE_MD5 = md51;
                }
                //如果只有一个文件，则也视为签章原文件
                else
                {
                    aModel.SIGN_SOURCE_FILE_FILENAME = file.FileName;
                    aModel.SIGN_SOURCE_FILE_URL = url;
                    aModel.SIGN_SOURCE_FILE_MD5 = md5;
                }
            }
            //福建CA修改
            else if (files.Count == 1 && files.AllKeys.Contains("file"))
            {
                //保存pdf文件
                HttpPostedFileBase file = files.Get("file");
                string url = "/File/SIGN/SQD/PDF/" + file.FileName;
                string path = AppDomain.CurrentDomain.BaseDirectory + url;
                file.SaveAs(path);
                string md5 = Encrypt.GetFileMD5(path).ToUpper();

                aModel.SIGN_PDF_FILENAME = file.FileName;
                aModel.SIGN_PDF_URL = url;
                aModel.SIGN_PDF_MD5 = md5;
                //福建CA的原文件就是pdf
                aModel.SIGN_SOURCE_FILE_FILENAME = file.FileName;
                aModel.SIGN_SOURCE_FILE_URL = url;
                aModel.SIGN_SOURCE_FILE_MD5 = md5;
            }
            //Logger.Debug("开始更新数据");
            aModel.SIGN_TIME = DateTime.Now;
            //更新信息
            DbContext.Fw.Update(aModel);
            r.SetSuccess("签章成功");
            return r;
        }

        public GeneralResult GetSignResult(string id)
        {
            var r = new GeneralResult();
            //验证合法性
            var aModel = DbContext.Fw.From<BH_SIGN_ATTACHMENT>().Where(BH_SIGN_ATTACHMENT._.GUID == id).ToFirst();
            if (aModel == null)
            {
                r.SetFail("数据不存在");
                return r;
            }
            if (string.IsNullOrEmpty(aModel.SIGN_PDF_URL))
            {
                r.SetFail("签章未成功");
                return r;
            }
            r.SetSuccess(new
            {
                id = aModel.GUID,
                url = aModel.SIGN_PDF_URL
            });

            return r;
        }
        public override DbSession GetDbSession()
        {
            return DbContext.Fw;
        }
    }
}
