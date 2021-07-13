using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using System.Xml;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;

namespace GGZY.DataService.Controllers
{
    /// <summary>
    /// 福建省政务数据汇聚共享平台
    /// </summary>
    public class ConvergenceServiceController : Controller
    {
        private string senderID = "3500000000000002_00004";
        private string userName = "fgwjypt_hjjkdy";
        private string password = "idj@1030";
        // GET: ConvergenceService
        /// <summary>
        /// 用户登录认证，返回GUID。GUID机制：空闲半小时自动过期
        /// </summary>
        /// <returns></returns>
        private string Authentication()
        {
          
            ConvergenceService.Authentication service = new ConvergenceService.Authentication();
            var dicStr = service.loginByAccount(userName, password);
            var dic = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, object>>(dicStr);
            return dic["data"].ToString();
        }
        /// <summary>
        /// 户籍人口统计
        /// </summary>
        /// <returns></returns>
        public ActionResult PublicSecurityDepartment()
        {
            var guid = Authentication();
            ConvergenceService.PublicSecurityDepartment service = new ConvergenceService.PublicSecurityDepartment();
            var result =service.householdRegistrationStatistics(guid, senderID, "张三", "123456789123456789", "接口联调", "127.0.0.1",
                "00-15-5D-C9-F3-1E", "201901", "350102");
            return Content(result);
        }
        /// <summary>
        /// 根据企业全称查询法人姓名和身份证号码（编号：I040104）
        /// </summary>
        /// <returns></returns>
        public ActionResult EnterpInfo()
        {
            var guid = Authentication();
            ConvergenceService.EnterpInfo service = new ConvergenceService.EnterpInfo();
            var result = service.queryByCnname(guid,"四创科技有限公司");
            return Content(result);
        }
        /// <summary>
        /// 根据企业全称查询企业基本信息
        /// </summary>
        /// <returns></returns>
        public ActionResult queryByEnterp()
        {
            var guid = Authentication();
            ConvergenceService.EnterpInfo service = new ConvergenceService.EnterpInfo();
            var result = service.queryByEnterp(guid, "四创科技有限公司");
            return Content(result);
        }
        /// <summary>
        /// 验证身份证号码和姓名是否匹配（编号：I010101）
        /// </summary>
        /// <returns></returns>
        public ActionResult IDCheck()
        {
            var guid = Authentication();
            ConvergenceService.PersonInfo.IDInfo service = new ConvergenceService.PersonInfo.IDInfo();
            var result = service.match(guid, "350101199304075012", "张三");
            return Content(result);
        }
        /// <summary>
        /// 4.4.2.1 根据社会组织全称查询社会组织信息  编号：I030201
        /// </summary>
        /// <returns></returns>
        public ActionResult queryByOrgan()
        {
            var guid = Authentication();
            ConvergenceService.Social.SocialOrganInfo service = new ConvergenceService.Social.SocialOrganInfo();
            var result =service.queryByOrgan(guid, "福建省登山协会");
            return Content(result);
        }
        /// <summary>
        /// 6、	根据单位全称查询事业单位基本信息（编号：I080102）
        /// </summary>
        /// <returns></returns>
        public ActionResult queryByMc()
        {
            var guid = Authentication();
            ConvergenceService.PublicInstitutionInfo service = new ConvergenceService.PublicInstitutionInfo();
            var result = service.queryByMc(guid, senderID, "中共诏安县委党史研究室");
            return Content(result);
        }
        /// <summary>
        /// 根据单位全称、缴交月份查询员工养老保险缴交信息
        /// </summary>
        /// <returns></returns>
        public ActionResult queryPayByOrganMonth(string keyword= "四创科技有限公司",string time= "201912")
        {
            var guid = Authentication();
            ConvergenceService.OldageInsurance service = new ConvergenceService.OldageInsurance();
            var result = service.queryPayByOrganMonth(guid, keyword, time);
            return Content(result);
        }
        /// <summary>
        /// 8、	根据身份证号码、缴交月份查询个人养老保险缴交信息（编号：I020102）：用于查询单人是否属于某一公司。
        /// </summary>
        /// <returns></returns>
        public ActionResult queryPayByIDMonth(string idCard = "350322199108031059", string month="201912")
        {
            var guid = Authentication();
            ConvergenceService.OldageInsurance service = new ConvergenceService.OldageInsurance();
            var result = service.queryPayByIDMonth(guid, idCard, month);
            return Content(result);
        }
        ///// <summary>
        ///// 获取国标SM4 GUID
        ///// </summary>
        ///// <returns></returns>
        //public string CegnGuid()
        //{
        //    CegnQuery.Authentication service = new CegnQuery.Authentication();
        //    //service.RequestEncoding = Encoding.GetEncoding("GBK");

        //    var strSecret =service.GetSecretKey(userName, password);
        //    if(strSecret.Contains("ERR:"))
        //    {
        //        throw new Exception("国家接口-获取SM4密钥失败:" + strSecret);
        //    }
        //    XmlDocument doc = new XmlDocument();
        //    doc.LoadXml(strSecret);
        //    var node = doc.SelectSingleNode("SecretKey");
        //    if(null == node)
        //    {
        //        throw new Exception("国家接口-获取SM4密钥失败:返回XML解析失败，未找到 SecretKey 节点。接口返回数据："+strSecret);
        //    }
        //    var secretKey = node.InnerText;
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
        //    sb.AppendLine("<root>");
        //    sb.AppendLine("	<username>" + userName + "</username>");
        //    sb.AppendLine("	<password>" + password + "</password>");
        //    sb.AppendLine("	<logintime>"+DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+"</logintime>");
        //    sb.AppendLine("</root>");


        //    var strXml = sb.ToString();

        //    byte[] byteArray = System.Text.Encoding.GetEncoding("gbk").GetBytes(strXml);
        //    var base64Str =Convert.ToBase64String(byteArray);
        //    KYSharp.SM.SM4Utils sm4 = new KYSharp.SM.SM4Utils();
        //    sm4.secretKey = secretKey;
        //    sm4.hexString = false;
        //    var inputStr =sm4.Encrypt_ECB(base64Str);
        //    var str = service.LoginByAccount(inputStr);

        //    //var source = sm4.Decrypt_ECB(inputStr);
        //    return str;
        //}
    }
}