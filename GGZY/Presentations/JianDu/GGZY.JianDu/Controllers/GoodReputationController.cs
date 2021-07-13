using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using GGZY.Core.Cache;
using GGZY.Core.Helper;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Framework.Controllers;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Helper;
using GGZYJD.DbEntity;
using Newtonsoft.Json;
using System.Xml;
using GGZY.Services.Infrastructure.Extensions;

namespace GGZY.JianDu.Controllers
{

    [AllowAnonymous]
    public class GoodReputationController : BaseController
    {
        // GET: GoodReputation
        public ActionResult GetHcpUrl(string goodtempid, int afcId, int isBaoJian = 1)
        {
            var r = new GeneralResult();
            var goodTemp = DbContext.Jd.FirstOrNull<GOOD_TEMP_PARAM>(GOOD_TEMP_PARAM._.ID == goodtempid);
            if (goodTemp == null)
            {
                r.SetSuccess(new { msg = "未找到事项编码id" });
                return JResult(r);
            }
            var app = new AppSettings();

            //获取token
            string token = GlobalCache.Instance.Get("HCP_TOKEN", 60, () => GetToken(app));
            if (string.IsNullOrEmpty(token))
            {
                r.SetSuccess(new { msg = "获取token失败" });
                return JResult(r);
            }
            var goodInfo = DbContext.Jd.FirstOrNull<GOOD_ITEM_INFO>(GOOD_ITEM_INFO._.ITEM_CODE == goodTemp.SWB_ITEMCODE);
            if (goodInfo == null)
            {
                r.SetSuccess(new { msg = "获取省网事项信息失败" });
                return JResult(r);
            }
            //组建xml去获取评价地址
            //记录日志
            var now = DateTime.Now;
            var sendLog = new GOOD_GET_URL_LOG()
            {
                ID = 0,
                SYSNO = app.HCP_SYS_NO,
                CREATE_TIME = DateTime.Now,
                BUSINESSCODE = goodTemp.SWB_ITEMCODE,
                BUSINESSNAME = goodInfo.ITEM_NAME,
                PROJECTNO = Guid.NewGuid().ToString("N"),
                PROSTATUS = 1,
                REGIONCODE = goodTemp.SWB_AREACODE ?? goodInfo.AREA_CODE,
                ACCEPTDATE = now,
                USERPROP = 2,
                USERNAME = Identity?.MztUser().USER_NAME ?? "杨善峰",
                USERPAGETYPE = "001",
                CERTKEY = Identity?.MztUser().USER_IDCARD ?? "350322199108031055",
                HANDLEUSERPAGETYPE = "111",
                HANDLEUSERPAGECODE = Identity?.MztUser().LEGALPERSON_IDCARD ?? Identity.JdUser().COMPANY_CODE ?? "350322199108031055",
                HANDLEUSERNAME = Identity?.MztUser().LEGALPERSON_NAME ?? Identity.JdUser().MANAGE_NAME ?? "杨善峰",
                RESULTDATE = null,
                SERVICETIME = now,
                EVALUATETYPE = 1,
                PROJECTNAME = isBaoJian == 1 ? "项目报建" : "招标备案",
                NODENAME = isBaoJian == 1 ? "项目报建" : "招标备案",
                CONTACTMOBILE = Identity?.MztUser().USER_MOBILE ?? "15505911111",
                PF = 1,
                TYPE = 1,
                BACKURL = app.HCP_BACK_URL,
                CUSTOMFIELDS = afcId.ToString(),
                PF5URLTYPE = 1,
                TEMP_ID = goodTemp.ID,
                AFC_ID = afcId
            };
            sendLog.ID = DbContext.Jd.Insert(sendLog);
            //生成xml
            string xmlHeadStr = "<?xml version=\"1.0\" encoding=\"GB2312\"?>";
            string xmlstr = $@"
{xmlHeadStr}
<Case>
	<sysNO>{sendLog.SYSNO}</sysNO>
	<businessCode>{sendLog.BUSINESSCODE}</businessCode>
	<businessName>{sendLog.BUSINESSNAME}</businessName>
	<projectNo>{sendLog.PROJECTNO}</projectNo>
<proStatus>{sendLog.PROSTATUS}</proStatus>
	<projectName>{sendLog.PROJECTNAME}</projectName>
	<nodeName>{sendLog.NODENAME}</nodeName>
	<regionCode>{sendLog.REGIONCODE}</regionCode>
	<acceptDate></acceptDate>
	<userProp>{sendLog.USERPROP}</userProp>
	<userName>{sendLog.USERNAME}</userName>
	<userPageType>{sendLog.USERPAGETYPE}</userPageType>
	<certKey>{sendLog.CERTKEY}</certKey>
	<handleUserName>{sendLog.HANDLEUSERNAME}</handleUserName>
	<handleUserPageType>{sendLog.HANDLEUSERPAGETYPE}</handleUserPageType>
	<handleUserPageCode>{sendLog.HANDLEUSERPAGECODE}</handleUserPageCode>
	<resultDate></resultDate>
	<serviceTime>{sendLog.SERVICETIME.Value:yyyy-MM-dd HH:mm:ss}</serviceTime>
	<evaluateType>{sendLog.EVALUATETYPE}</evaluateType>
	<pf>{sendLog.PF}</pf>
	<type>{sendLog.TYPE}</type>
	<contactMobile>{sendLog.CONTACTMOBILE}</contactMobile>
	<backUrl>{sendLog.BACKURL}</backUrl>
	<customFields>测试：{sendLog.CUSTOMFIELDS}</customFields>
    <pf5urltype>1</pf5urltype>
</Case>";
            //加密
            Sm4 sm4 = new Sm4();
            string sendxmlStr = sm4.Encrpty(xmlstr, app.HCP_PRIVATE_KEY);
            string soapuiUrl = "<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:web=\"http://webServiceInterface.cms.linewell.com\">";
            string sendContent = $@"
{soapuiUrl}
<soapenv:Header>
	<Authorization>Basic {token}</Authorization>
</soapenv:Header>
<soapenv:Body>
      <web:getSaveEvaluationUrl>
		<appKey>{app.HCP_PUBLIC_KEY}</appKey>
		<xmlStr>{sendxmlStr}</xmlStr>
    </web:getSaveEvaluationUrl>
   </soapenv:Body>
</soapenv:Envelope>";
            //发送数据
            var post = new WebUtils() { ContentType = "application/xml" };
            var result = post.DoPost(app.HCP_GET_URL, sendContent);
            sendLog.RESULT = result;
            Regex reg = new Regex("<return>.*</return>");
            var match = reg.Match(result);
            if (match.Success)
            {
                var v = match.Value;
                XmlDocument xd = new XmlDocument();
                xd.LoadXml(v.Replace("&lt;", "<").Replace("&gt;", ">").Replace("<return>", "").Replace("</return>", ""));
                var resultUrl = xd.SelectSingleNode("/Case/data/url")?.InnerText;
                if (!string.IsNullOrWhiteSpace(resultUrl))
                {
                    sendLog.RESULT_URL = resultUrl;
                    r.SetSuccess(new { resultUrl });
                }
                else
                {
                    r.SetSuccess(new { msg = "获取评价地址出错" });
                }

            }

            DbContext.Jd.Update(sendLog);
            return JResult(r);
        }
        /// <summary>
        /// 获取服务器授权token
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        private string GetToken(AppSettings app)
        {
            string token = "";
            string timestamp = CommonUtils.ToUnixTimeStamp(DateTime.Now, true).ToString();
            string sign = Encrypt.MD5($"{app.HCP_PRIVATE_KEY}{timestamp}", 32).ToUpper();
            Dictionary<string, string> sendP = new Dictionary<string, string>()
            {
                {"app_key",app.HCP_PUBLIC_KEY },
                {"timestamp",timestamp },
                {"sign",sign },
            };
            var result = new WebUtils().DoGet(app.HCP_TOKEN_URL, sendP);
            var resultDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(result);
            token = resultDict.ContainsKey("access_token") ? resultDict["access_token"].ToString() : "";
            return token;
        }

        public ActionResult Redirect(GOOD_TEMP_PARAM p)
        {
            //记录登录信息
            p.ID = 0;
            p.CREATE_TIME = DateTime.Now;
            int id = DbContext.Jd.Insert(p);

            //先跳转到闽政通进行登录
            string redirect = $"/Jd/admin/index.html#/projectCreate/add?goodtempid={id}";
            redirect = HttpUtility.UrlEncode(redirect);
            return Redirect($"/Jd/MztAccount/Login?redirect={redirect}");
        }
    }
}