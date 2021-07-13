using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using GGZY.Core.Algorithms;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Helper;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Services.DZBH.ParamModel;
using GGZY.Services.Infrastructure.Helper;
using GGZYFW.DbEntity;
using KTPKIAPPCOMCLNTLib;

namespace GGZY.Services.Infrastructure.Model
{
    /// <summary>
    /// CA证书
    /// </summary>
    public class CertificateAuthorityModel
    {
        private const string SecretKey = "au%GUIWnq5Gin]fO1fBt^~P1seCNUX@H";

        public CertificateAuthorityModel()
        {
            this.Data = new CAINFO();
        }

        #region 属性
        /// <summary>
        /// 签名后的数据 s
        /// </summary>
        public string SignData { get; set; }
        /// <summary>
        /// 签名后的数据 z
        /// </summary>
        public string CertData { get; set; }
        /// <summary>
        /// 签名后的数据 r
        /// </summary>
        public string SrcData { get; set; }
        /// <summary>
        /// 签名后的数据
        /// </summary>
        public string SessionId { get; set; }

        public string client_id { get; set; }
        public string redirect_url { get; set; }
        #endregion

        public CAINFO Data { get; set; }



        #region 方法


        #region 公有方法


        /// <summary>
        /// 获取证书信息
        /// </summary>
        /// <returns></returns>
        public GeneralResult GetCaInfo()
        {
            var r = new GeneralResult();
            if (!CheckSign())
            {
                r.SetFail("无效请求");
            }
            else
            {
                int iError = 0;
                string strError = string.Empty;
                SOFInterfaceClass objSOF = new SOFInterfaceClass();
                var strServer = ConfigHelper.AppSettings.CAServerIp;
                objSOF.SOF_PKIOpen(strServer, ref iError);
                if (iError != 0)
                {
                    objSOF.SOF_GetLastErrorString(ref strError);
                    r.SetFail(strError);
                    return r;
                }

                var strAppweb = ConfigHelper.AppSettings.CAWebAppName;
                objSOF.SOF_SetWebAppName(strAppweb, ref iError);
                if (iError != 0)
                {
                    objSOF.SOF_GetLastErrorString(ref strError);
                    r.SetFail(strError);
                    return r;
                }
                objSOF.SOF_ValidateCert(CertData, ref iError);
                if (iError != 0)
                {
                    objSOF.SOF_GetLastErrorString(ref strError);
                    r.SetFail(strError);
                    return r;
                }

                objSOF.SOF_VerifySignedData(CertData, SrcData, SignData, ref iError);
                if (iError != 0)
                {
                    objSOF.SOF_GetLastErrorString(ref strError);
                    r.SetFail(strError);
                    return r;
                }

                //var dic = new Dictionary<string, string>();
                var properties = Data.GetType().GetProperties();
                var certs = Enum.GetValues(typeof(CertSign)).Cast<CertSign>().ToList();
                foreach (CertSign suit in certs)
                {
                    string strCertUserName = string.Empty;
                    objSOF.SOF_GetCertInfo(CertData, (int)suit, ref strCertUserName);
                    var property = properties.FirstOrDefault(c => c.Name == suit.ToString());
                    if (property != null)
                    {
                        property.SetValue(Data, strCertUserName);
                    }
                }
                //foreach (CertSign suit in Enum.GetValues(typeof(CertSign)))
                //{
                //    string strCertUserName = string.Empty;
                //    objSOF.SOF_GetCertInfo(CertData, (int)suit, ref strCertUserName);
                //    var key = Enum.GetName(typeof(CertSign), suit);
                //    dic.Add(key, strCertUserName);
                //}
                r.SetSuccess(this.Data);
            }
            return r;
        }

        /// <summary>
        /// 生成签名
        /// </summary>
        /// <returns></returns>
        public string GetRandom()
        {
            string random = GlobalCache.Instance.Get<string>(SessionId);
            string ip = GetIP();
            string useragent = HttpContext.Current.Request.ServerVariables["HTTP_USER_AGENT"];
            string data = random + SessionId + ip + useragent + "1a";
            return Sign(data);
        }
        /// <summary>
        /// 查询所持CA类型
        /// </summary>
        /// <returns></returns>
        public GeneralResult CheckCaType()
        {
            var r = this.GetCaInfo();
            if (r.Success)
            {
                //SGD_GET_CERT_ISSUER_CN 证书颁发者通用名称(CN)
                // SGD_GET_CERT_SERIAL 证书序列号

                if (!string.IsNullOrWhiteSpace(Data.SGD_GET_CERT_ISSUER_CN) && Data.SGD_GET_CERT_ISSUER_CN.Contains("SZCA"))//2、包含SZCA查询深圳给的接口 [接口暂未提供,直接默认匹配成功]
                {
                    r.SetSuccess(new { Type = "SZCA" });
                }
                else if (!string.IsNullOrWhiteSpace(Data.SGD_GET_CERT_ISSUER_CN) && Data.SGD_GET_CERT_ISSUER_CN.IndexOf("CFCA",
                             StringComparison.CurrentCultureIgnoreCase) > -1) //3、包含CFCA查询凯特给的接口
                {
                    r = CheckCFCA();
                }
                else if (!string.IsNullOrWhiteSpace(Data.SGD_GET_CERT_ISSUER_CN) && Data.SGD_GET_CERT_ISSUER_CN.IndexOf("Shouzhong",
                             StringComparison.CurrentCultureIgnoreCase) > -1)//4、包含Shouzhong 先查询恒瑞通接口，没有再查询首众接口
                {
                    r = CheckHRT();
                }
                else if (!string.IsNullOrWhiteSpace(Data.SGD_GET_CERT_ISSUER_CN) && Data.SGD_GET_CERT_ISSUER_CN.IndexOf("FJCA",
                             StringComparison.CurrentCultureIgnoreCase) > -1)//5、包含FJCA,先查询FJCA接口，根据其返回确定是福建CA还是凯特的（因为福建CA和凯特现在都是电子信息集团的），没有再查询首众接口（因为首众也有福建CA给的证书）
                {
                    r = CheckFJCA();
                }
                else
                {
                    r.SetFail($"您所持的CA无法识别\r\n证书颁发者通用名称:{Data.SGD_GET_CERT_ISSUER_CN} 证书序列号:{Data.SGD_GET_CERT_SERIAL}");
                }
            }

            return r;
        }

        #region CA客户端签章 1 签章URL唤起签章客户端 2 签章客户端签章成功后 回调上传签章后的文件 3

        /// <summary>
        /// 初始化签章客户端的链接
        /// </summary>
        /// <param name="signType">签章类型 FJGGFWCAU 签章（旧版）FJGGFWCAUU 签章（统一CA）</param>
        /// <param name="callbackUrl">签章成功后回调地址,用于上传签章后的附件信息</param>
        /// <param name="fileUrl">待签章附件地址</param>
        /// <param name="param">额外参数，签章成功后回调回来</param>
        /// <returns></returns>
        public static Tuple<string, string> CaClientSignFunc(string signType, string callbackUrl, string fileUrl, string fileName, Dictionary<string, object> param = null)
        {
            var guid = Guid.NewGuid().ToString("N");
            //if (param == null)
            //{
            //    param = new Dictionary<string, object>();
            //}
            //if (!param.ContainsKey("T"))
            //{
            //    var t = $"{Environment.TickCount}_{guid}";
            //    var secret = t.DesEncrypt();//HttpUtility.UrlDecode(Encrypt.DESEncrypt(t, Encrypt.strIV);
            //    param.Add("T", secret);
            //}
            var t = CommonUtils.ToUnixTimeStamp();
            var url = fileUrl.StartsWith("http") ? fileUrl : $"{ConfigHelper.AppSettings.UploadHost}{fileUrl}";
            if (fileUrl.StartsWith("http"))
            {
                url = fileUrl;
            }
            else
            {
                if (fileUrl.IndexOf("/file/getcontent", StringComparison.CurrentCultureIgnoreCase) > -1)//统一文件服务器
                {
                    url = $"{ConfigHelper.AppSettings.UploadHost}{fileUrl}";
                }
                else
                {
                    var requestUrl = HttpContext.Current?.Request.Url?.ToString();
                    if (!string.IsNullOrWhiteSpace(requestUrl))
                    {

                        if (requestUrl.IndexOf(ConfigHelper.AppSettings.GGZYFWHOST, StringComparison.CurrentCultureIgnoreCase) > -1 || requestUrl.IndexOf(ConfigHelper.AppSettings.FJGGZYFWHOST, StringComparison.CurrentCultureIgnoreCase) > -1)
                        {
                            url = $"{ConfigHelper.AppSettings.FJGGZYFWHOST}{fileUrl}";
                        }
                        else if (requestUrl.IndexOf(ConfigHelper.AppSettings.GGZYJDHOST, StringComparison.CurrentCultureIgnoreCase) > -1 || requestUrl.IndexOf(ConfigHelper.AppSettings.FJGGZYJDHOST, StringComparison.CurrentCultureIgnoreCase) > -1)
                        {
                            url = $"{ConfigHelper.AppSettings.FJGGZYJDHOST}{fileUrl}";
                        }
                        else if (requestUrl.IndexOf(ConfigHelper.AppSettings.TestHost, StringComparison.CurrentCultureIgnoreCase) > -1)
                        {
                            url = $"{ConfigHelper.AppSettings.TestHost}{fileUrl}";
                        }
                    }
                }


            }

            //url = "http://114.115.162.77/Jd/FileContent/Jd/Sys/b8b15518063c47659923741ef8de5329";
            //url = "http://114.115.162.77:8066/file/getcontent/5ef16f66faae15155ccc84fe.pdf";
            if (string.IsNullOrWhiteSpace(fileName))
            {
                fileName = url.FileName();
            }
            var fileExtensions = url.Extension();
            fileName = fileName.FileNameWithoutExtension();
            var unifyCa = new
            {
                is_auto_close = "1",
                is_edit = "1",
                is_edit_old = "0",
                is_upload_pdf = "1",
                is_view = "0",
                url,
                upload_url = $"{callbackUrl}?guid={guid}&pre_name={fileName}&suf_name={fileExtensions}",
                @params = $"{t}",
            };
            //GlobalCache.Instance.Set(guid, url, 60);
            var message = unifyCa.Serializer();
            Logger.Info($"SIGN MESSAGE {message}");
            string base64Param = Encrypt.Base64Code(message);
            var signUrl = $"{signType}://{base64Param}";
            return Tuple.Create(signUrl, guid);
        }
        /// <summary>
        /// CA客户端签章成功后 回调方法
        /// </summary>
        /// <param name="files">签章成功后的附件信息</param>
        /// <param name="model">CA客户端返回的参数</param>
        /// <returns></returns>
        public static GeneralResult<UploadResData> CaClientSignCallbackFunc(HttpFileCollectionBase files, SignParamModel model, string pre_name, string suf_name)
        {
            var r = new GeneralResult<UploadResData>();
            if (!string.IsNullOrWhiteSpace(model.@params)) //启动CA客户端时, 传递给CA客户端的params
            {
                HttpPostedFileBase file = null;
                if (CommonUtils.ToUnixTimeStamp() - Convert.ToInt32(model.@params) > 60 * 60)
                {
                    r.SetFail("Token过期");
                }
                else if (files.Count > 0 && files.AllKeys.Contains("pdf"))
                {
                    file = files.Get("pdf");
                }
                else if (files.Count == 1 && files.AllKeys.Contains("file"))//福建CA修改
                {
                    file = files.Get("file");
                }
                else if (files.Count > 0)
                {
                    file = files[0];
                }
                else
                {
                    r.SetFailEx("签章附件信息错误", $"FileAllKey:{files.AllKeys.Serializer()}");
                }

                if (file != null)
                {
                    var fileName = file.FileName;
                    if (fileName.IndexOf(".", StringComparison.CurrentCulture) == -1
                        && !string.IsNullOrWhiteSpace(pre_name)
                        && !string.IsNullOrWhiteSpace(suf_name))
                    {
                        fileName = $"{pre_name}.{suf_name}";
                    }
                    var d = FileHelper.Uploader.UploadStream(fileName, file.InputStream);
                    if (d.Result)
                    {
                        r.SetSuccessT(d.Data);
                    }
                    else
                    {
                        r.SetFail(d.Msg);
                    }
                }
            }
            else
            {
                r.SetFail("非法参数");
            }
            return r;
        }

        public static GeneralResult<List<UploadResData>> CaClientDecodeCallbackFunc(HttpFileCollectionBase files)
        {
            var r = new GeneralResult<List<UploadResData>>();
            if (files.Count > 0)
            {
                var data = new List<UploadResData>();
                foreach (HttpPostedFileBase file in files)
                {
                    var d = FileHelper.Uploader.UploadStream(file.FileName, file.InputStream);
                    if (d.Result)
                    {
                        data.Add(d.Data);
                    }
                }
                r.SetSuccess(data);
            }
            else
            {
                r.SetFailEx("解密附件信息错误", $"FileAllKey:{files.AllKeys.Serializer()}");
            }
            return r;
        }
        #endregion
        #endregion

        #region 私有方法

        bool CheckSign()
        {
            if (GlobalCache.Instance.IsSet(SessionId))
            {
                var random = GetRandom();
                GlobalCache.Instance.Remove(SessionId);
                return random == SrcData;
            }
            return false;
        }

        /// <summary>
        /// 获取客户端IP地址
        /// </summary>
        /// <returns>若失败则返回回送地址</returns>
        string GetIP()
        {
            string userHostAddress = HttpContext.Current.Request.UserHostAddress;

            if (string.IsNullOrEmpty(userHostAddress))
            {
                userHostAddress = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }

            //最后判断获取是否成功，并检查IP地址的格式（检查其格式非常重要）
            if (!string.IsNullOrEmpty(userHostAddress) && IsIP(userHostAddress))
            {
                return userHostAddress;
            }
            return "127.0.0.1";
        }

        /// <summary>
        /// 检查IP地址格式
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        bool IsIP(string ip)
        {
            return Regex.IsMatch(ip, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$");
        }

        string Sign(string data)
        {
            IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
            var byteSign = Encoding.UTF8.GetBytes(data);
            return JwtBase64UrlEncoder.Encode(algorithm.Sign(Encoding.UTF8.GetBytes(SecretKey), byteSign));
        }

        #endregion

        #region CA检测

        /// <summary>
        /// 3、包含CFCA查询凯特给的接口
        /// </summary>
        protected GeneralResult CheckCFCA()
        {
            var r = new GeneralResult();
            try
            {
                string baseUrl = "http://www.fjdzyz.com:8081/WebFp/querySealLow/getSealState";
                string secretKey = "0AC2C385ACA144E2815BCDB5A4561221";
                string token = DateTime.Now.ToString("yyyyMMddHHmmss");
                string pwd = $"{CertData}{token}{secretKey}";
                string secret = CommonUtils.Md5Str(pwd);
                string id = HttpUtility.UrlEncode(CertData);
                string postString = $"id={id}&token={token}&secret={secret}";
                var rsp = new WebUtils().DoPost<CARsp>(baseUrl, postString);//{"status":"0","msg":"该请求已过期"}
                //context.Response.Write(s);
                if (rsp.status == "0")
                {
                    r.SetFail(rsp.msg);
                }
                else
                {
                    r.SetSuccess(new { Type = "CFCA" });
                }

            }
            catch (Exception e)
            {
                r.SetFail($"CheckCFCA 异常:{e.Message}", e);
            }

            return r;
        }

        /// <summary>
        /// 4、包含Shouzhong 先查询恒瑞通接口，没有再查询首众接口
        /// </summary>
        protected GeneralResult CheckHRT()
        {
            var r = new GeneralResult();
            try
            {
                string urlFormat = "http://106.14.157.58:8083/certApp/biz/cert/query?id={0}&token={1}&secret=ucs@nd$admin";
                string token = DateTime.Now.ToString("yyyyMMddHHmmss");
                string url = string.Format(urlFormat, Data.SGD_GET_CERT_SERIAL, token);
                WebClient webClient = new WebClient() { Encoding = Encoding.UTF8 };
                var s = webClient.DownloadString(url);
                var rsp = s.DeserializeObject<CARsp>();
                if (rsp.status == "1")//{"status":"0","msg":"未查到此证书信息！"}
                {
                    r.SetSuccess(new { Type = "HRT" });
                }
                else
                {
                    r.SetFail(rsp.msg);
                    r = CheckShouZhong();
                }

            }
            catch (Exception e)
            {
                r.SetFail($"CheckHRT 异常:{e.Message}", e);
            }

            return r;
        }

        /// <summary>
        /// 5、包含FJCA,先查询FJCA接口，根据其返回确定是福建CA还是凯特的（因为福建CA和凯特现在都是电子信息集团的），没有再查询首众接口（因为首众也有福建CA给的证书）
        /// </summary>
        /// <returns></returns>
        protected GeneralResult CheckFJCA()
        {
            var r = new GeneralResult();
            try
            {
                string baseUrl = "http://ra.ruizhengtong.com/rzt/caCertType/queryType";
                string certId = Data.SGD_GET_CERT_SERIAL;
                string timeStamp = DateTime.Now.ToString("yyyyMMddHHmmss");
                string secretKey = "Ggzyjypt2019";
                string pwd = $"{certId}+{timeStamp}+{secretKey}";
                string secret = CommonUtils.Md5Str(pwd);
                string postString = new
                {
                    certId,
                    timeStamp,
                    secret,
                }.Serializer();
                var s = new WebUtils().DoPost(baseUrl, postString);
                var rsp = s.DeserializeObject<FjCaRsp>();
                if (rsp.code == "0000")
                {
                    if (rsp.data.status == "1")//1瑞术发放福建CA印章；
                    {
                        r.SetSuccess(new { Type = "FJCA" });
                    }
                    else if (rsp.data.status == "2")//2瑞术发放凯特印章；
                    {
                        r.SetSuccess(new { Type = "FJCA_CFCA" });
                    }
                    else
                    {
                        r.SetFail(rsp.msg);
                        r = CheckShouZhong();
                    }
                }
                else
                {
                    r.SetFail(rsp.msg);
                    r = CheckShouZhong();
                }
            }
            catch (Exception e)
            {
                r.SetFail($"CheckFJCA 异常:{e.Message}", e);
            }

            return r;
        }

        /// <summary>
        /// 是否为首众
        /// </summary>
        protected GeneralResult CheckShouZhong()
        {
            var r = new GeneralResult();
            try
            {
                string urlFormat = "http://ra-cloud.okap.com/service/diplomacy/isoc?id={0}&token={1}&secret={2}";
                string pfxFileName = HttpContext.Current.Server.MapPath("~/Infrastructure/shouzhong.pfx");
                if (!System.IO.File.Exists(pfxFileName))
                {
                    pfxFileName = ConfigHelper.AppSettings.ShouZhongPfx; ;
                }
                string unSignToken = DateTime.Now.ToString("yyyyMMddHHmmss");
                string url = string.Empty;
                var privateCert = new X509Certificate2(pfxFileName, "111111", X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.Exportable);
                RSACryptoServiceProvider privateKey = (RSACryptoServiceProvider)privateCert.PrivateKey;
                // 获取私钥 
                RSACryptoServiceProvider privateKey1 = new RSACryptoServiceProvider();
                privateKey1.ImportParameters(privateKey.ExportParameters(true));
                byte[] data = Encoding.UTF8.GetBytes(unSignToken);
                byte[] signature = privateKey1.SignData(data, "SHA256");
                //对签名密文进行Base64编码 
                var secret = Convert.ToBase64String(signature).Replace("/", "_").Replace("+", "-").TrimEnd('=');
                url = string.Format(urlFormat, Data.SGD_GET_CERT_SERIAL, unSignToken, secret);
                WebClient webClient = new WebClient();
                var s = webClient.DownloadString(url);
                var rsp = s.DeserializeObject<CARsp>();
                if (rsp.status == "1")//{"status":"0","msg":"未查到此证书信息！"}
                {
                    r.SetSuccess(new { Type = "SHOUZHONG" });
                }
                else
                {
                    r.SetFail(rsp.msg);
                }
            }
            catch (Exception e)
            {
                r.SetFail($"CheckShouZhong 异常:{e.Message}", e);
            }

            return r;
        }

        #endregion

        #endregion
    }
}

public enum CertSign : byte  //用于标识需提取的证书信息
{
    SGD_GET_CERT_VERSION = 0x00000001,//证书版本
    SGD_GET_CERT_SERIAL = 0x00000002,//证书序列号
    SGD_GET_CERT_SIGNALG = 0x00000003,//证书签名算法标识
    SGD_GET_CERT_ISSUER_C = 0x00000004,//证书颁发者国家(C)
    SGD_GET_CERT_ISSUER_O = 0x00000005,//证书颁发者组织名(O)
    SGD_GET_CERT_ISSUER_OU = 0x00000006,//证书颁发者部门名(OU)
    SGD_GET_CERT_ISSUER_S = 0x00000007,//证书颁发者所在的省、自治区、直辖市(S)
    SGD_GET_CERT_ISSUER_CN = 0x00000008,//证书颁发者通用名称(CN)
    SGD_GET_CERT_ISSUER_L = 0x00000009,//证书颁发者所在的城市、地区(L)
    SGD_GET_CERT_ISSUER_E = 0x00000010,//证书颁发者Email
    SGD_GET_CERT_NOTBEFORE = 0x00000011,//证书有效期：起始日期
    SGD_GET_CERT_AFTER = 0x00000012,//证书有效期：终止日期
    SGD_GET_CERT_SUBJECT_C = 0x00000013,//证书拥有者国家(C )
    SGD_GET_CERT_SUBJECT_O = 0x00000014,//证书拥有者组织名(O)
    SGD_GET_CERT_SUBJECT_OU = 0x00000015,//证书拥有者部门名(OU)
    SGD_GET_CERT_SUBJECT_S = 0x00000016,//证书拥有者所在的省、自治区、直辖市(S)
    SGD_GET_CERT_SUBJECT_CN = 0x00000081,//企业名称
    SGD_GET_CERT_SUBJECT_CN_TY = 0x00000017,//证书拥有者通用名称(CN)
    SGD_GET_CERT_SUBJECT_L = 0x00000018,//证书拥有者所在的城市、地区(L)
    SGD_GET_CERT_SUBJECT_E = 0x00000019,//证书拥有者Email
    SGD_GET_CERT_ISSUER_DN = 0x00000020,//证书颁发者DN
    SGD_GET_CERT_SUBJECT_DN = 0x00000021,//证书拥有者DN
    SGD_GET_CERT_DER_PUBKEY = 0x00000022,//证书公钥信息
    SGD_GET_CERT_DER_EXTENSIONS = 0x00000023,//证书扩展项信息
    SGD_EXT_AUTHORITYKEYIDENTIFIER = 0x00000024,//颁发者密钥标识符
    SGD_EXT_SUBJECTKEYIDENTIFIER = 0x00000025,//证书持有者密钥标识符
    SGD_EXT_KEYUSAGE = 0x00000026,    //密钥用途
    SGD_EXT_PRIVATEKEYUSAGEPERIO = 0x00000027,//私钥有效期
    SGD_EXT_CERTIFICATEPOLICIES = 0x00000028,//证书策略
    SGD_EXT_POLICYMAPPINGS = 0x00000029,//策略映射
    SGD_EXT_BASICCONSTRAINTS = 0x00000030,//基本限制
    SGD_EXT_POLICYCONSTRAINTS = 0x00000031,//策略限制
    SGD_EXT_EXTKEYUSAGE = 0x00000032,//扩展密钥用途
    SGD_EXT_CRLDISTRIBUTIONPO = 0x00000033,//CRL发布点
    SGD_EXT_NETSCAPE_CERT_TYPE = 0x00000034,//netscape属性
    SGD_EXT_CERT_UNIQUEID = 0x00000035,//证书实体唯一标识
    SGD_EXT_IDENTIFYCARDNUMBER = 0x00000036,//个人身份证号码
    SGD_EXT_INURANCENUMBER = 0x00000037,//个人社会保险号
    SGD_EXT_ICREGISTRATIONNUMBER = 0x00000038,//企业工商注册号
    SGD_EXT_ORGANIZATIONCODE = 0x00000039,//企业组织机构代码
    SGD_EXT_TAXATIONNUMBER = 0x00000040 //税务登记证号
}

public class CARsp
{
    public string status { get; set; }
    public string msg { get; set; }
}

public class FjCaRsp
{
    public string code { get; set; }
    public string msg { get; set; }
    public CARsp data { get; set; }
}

/*
 #region 证书属性
        /// <summary>
        /// 0x00000001,//证书版本
        /// </summary>
        public string SGD_GET_CERT_VERSION { get; set; }
        /// <summary>
        /// 0x00000002,//证书序列号
        /// </summary>
        public string SGD_GET_CERT_SERIAL { get; set; }
        /// <summary>
        /// 0x00000003,//证书签名算法标识
        /// </summary>
        public string SGD_GET_CERT_SIGNALG { get; set; }
        /// <summary>
        /// 0x00000004,//证书颁发者国家(C)
        /// </summary>
        public string SGD_GET_CERT_ISSUER_C { get; set; }
        /// <summary>
        /// 0x00000005,//证书颁发者组织名(O)
        /// </summary>
        public string SGD_GET_CERT_ISSUER_O { get; set; }
        /// <summary>
        /// 0x00000006,//证书颁发者部门名(OU)
        /// </summary>
        public string SGD_GET_CERT_ISSUER_OU { get; set; }
        /// <summary>
        /// 0x00000007,//证书颁发者所在的省、自治区、直辖市(S)
        /// </summary>
        public string SGD_GET_CERT_ISSUER_S { get; set; }
        /// <summary>
        /// 0x00000008,//证书颁发者通用名称(CN)
        /// </summary>
        public string SGD_GET_CERT_ISSUER_CN { get; set; }
        /// <summary>
        /// 0x00000009,//证书颁发者所在的城市、地区(L)
        /// </summary>
        public string SGD_GET_CERT_ISSUER_L { get; set; }
        /// <summary>
        /// 0x00000010,//证书颁发者Email
        /// </summary>
        public string SGD_GET_CERT_ISSUER_E { get; set; }
        /// <summary>
        /// 0x00000011,//证书有效期：起始日期
        /// </summary>
        public string SGD_GET_CERT_NOTBEFORE { get; set; }
        /// <summary>
        /// 0x00000012,//证书有效期：终止日期
        /// </summary>
        public string SGD_GET_CERT_AFTER { get; set; }
        /// <summary>
        /// 0x00000013,//证书拥有者国家(C )
        /// </summary>
        public string SGD_GET_CERT_SUBJECT_C { get; set; }
        /// <summary>
        /// 0x00000014,//证书拥有者组织名(O)
        /// </summary>
        public string SGD_GET_CERT_SUBJECT_O { get; set; }
        /// <summary>
        /// 0x00000015,//证书拥有者部门名(OU)
        /// </summary>
        public string SGD_GET_CERT_SUBJECT_OU { get; set; }
        /// <summary>
        /// 0x00000016,//证书拥有者所在的省、自治区、直辖市(S)
        /// </summary>
        public string SGD_GET_CERT_SUBJECT_S { get; set; }
        /// <summary>
        /// 0x00000081,//企业名称
        /// </summary>
        public string SGD_GET_CERT_SUBJECT_CN { get; set; }
        /// <summary>
        /// 0x00000017,//证书拥有者通用名称(CN)
        /// </summary>
        public string SGD_GET_CERT_SUBJECT_CN_TY { get; set; }
        /// <summary>
        /// 0x00000018,//证书拥有者所在的城市、地区(L)
        /// </summary>
        public string SGD_GET_CERT_SUBJECT_L { get; set; }
        /// <summary>
        /// 0x00000019,//证书拥有者Email
        /// </summary>
        public string SGD_GET_CERT_SUBJECT_E { get; set; }
        /// <summary>
        /// 0x00000020,//证书颁发者DN
        /// </summary>
        public string SGD_GET_CERT_ISSUER_DN { get; set; }
        /// <summary>
        /// 0x00000021,//证书拥有者DN
        /// </summary>
        public string SGD_GET_CERT_SUBJECT_DN { get; set; }
        /// <summary>
        /// 0x00000022,//证书公钥信息
        /// </summary>
        public string SGD_GET_CERT_DER_PUBKEY { get; set; }
        /// <summary>
        /// 0x00000023,//证书扩展项信息
        /// </summary>
        public string SGD_GET_CERT_DER_EXTENSIONS { get; set; }
        /// <summary>
        /// 0x00000024,//颁发者密钥标识符
        /// </summary>
        public string SGD_EXT_AUTHORITYKEYIDENTIFIER { get; set; }
        /// <summary>
        /// 0x00000025,//证书持有者密钥标识符
        /// </summary>
        public string SGD_EXT_SUBJECTKEYIDENTIFIER { get; set; }
        /// <summary>
        /// 0x00000026,    //密钥用途
        /// </summary>
        public string SGD_EXT_KEYUSAGE { get; set; }
        /// <summary>
        /// 0x00000027,//私钥有效期
        /// </summary>
        public string SGD_EXT_PRIVATEKEYUSAGEPERIO { get; set; }
        /// <summary>
        /// 0x00000028,//证书策略
        /// </summary>
        public string SGD_EXT_CERTIFICATEPOLICIES { get; set; }
        /// <summary>
        /// 0x00000029,//策略映射
        /// </summary>
        public string SGD_EXT_POLICYMAPPINGS { get; set; }
        /// <summary>
        /// 0x00000030,//基本限制
        /// </summary>
        public string SGD_EXT_BASICCONSTRAINTS { get; set; }
        /// <summary>
        /// 0x00000031,//策略限制
        /// </summary>
        public string SGD_EXT_POLICYCONSTRAINTS { get; set; }
        /// <summary>
        /// 0x00000032,//扩展密钥用途
        /// </summary>
        public string SGD_EXT_EXTKEYUSAGE { get; set; }
        /// <summary>
        /// 0x00000033,//CRL发布点
        /// </summary>
        public string SGD_EXT_CRLDISTRIBUTIONPO { get; set; }
        /// <summary>
        /// 0x00000034,//netscape属性
        /// </summary>
        public string SGD_EXT_NETSCAPE_CERT_TYPE { get; set; }
        /// <summary>
        /// 0x00000035,//证书实体唯一标识
        /// </summary>
        public string SGD_EXT_CERT_UNIQUEID { get; set; }
        /// <summary>
        /// 0x00000036,//个人身份证号码
        /// </summary>
        public string SGD_EXT_IDENTIFYCARDNUMBER { get; set; }
        /// <summary>
        /// 0x00000037,//个人社会保险号
        /// </summary>
        public string SGD_EXT_INURANCENUMBER { get; set; }
        /// <summary>
        /// 0x00000038,//企业工商注册号
        /// </summary>
        public string SGD_EXT_ICREGISTRATIONNUMBER { get; set; }
        /// <summary>
        /// 0x00000039,//企业组织机构代码
        /// </summary>
        public string SGD_EXT_ORGANIZATIONCODE { get; set; }
        /// <summary>
        /// 0x00000040 //税务登记证号
        /// </summary>
        public string SGD_EXT_TAXATIONNUMBER { get; set; }

        #endregion
 */
