using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using GGZY.Core.Authentication.FormsCookie;
using GGZY.Core.Extensions;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Framework.Models;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Helper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GGZY.Framework.Infrastructure.Filters
{
    /// <summary>
    /// 门户网站接口验证
    /// </summary>
    public class PortalFilter : ActionFilterAttribute
    {
        private string secret = String.Empty;

        public PortalFilter(string _secret)
        {
            this.secret = _secret;
        }
        /// <summary>
        /// 门户接口请求过滤器
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
#if !DEBUG
            var r = ValidateSign(filterContext);
            if (!r.Success)
            {//签名验证失败
                filterContext.Result = new CustomResult() { Data = r };
                return;
            }
            filterContext.ActionParameters["Server-Sign"] = r.Data;
            //r = ValidateRequest(filterContext);
            //if (!r.Success)
            //{//请求头验证失败
            //    filterContext.Result = new CustomResult() { Data = r };
            //    return;
            //}
#endif
            base.OnActionExecuting(filterContext);
        }

        /// <summary>
        /// 签名验证
        /// </summary>
        /// <param name="filterContext"></param>
        /// <returns></returns>
        protected GeneralResult ValidateSign(ActionExecutingContext filterContext)
        {
            var r = new GeneralResult();

            var unFilter = typeof(PortalUnFilterAttribute);
            var unFilterAction = filterContext.ActionDescriptor.GetCustomAttributes(unFilter, true).Any();
            var unFilterCtrl = filterContext.ActionDescriptor.ControllerDescriptor.GetCustomAttributes(unFilter, true)
                .Any();
            var allowAnonymous = typeof(AllowAnonymousAttribute);
            var allowAnonymousAction = filterContext.ActionDescriptor.GetCustomAttributes(allowAnonymous, true).Any();
            var allowAnonymousCtrl = filterContext.ActionDescriptor.ControllerDescriptor.GetCustomAttributes(allowAnonymous, true)
                .Any();
            var noSignParm = filterContext.HttpContext.Request.Params["no_sign"];
            bool noSign = !string.IsNullOrWhiteSpace(noSignParm) &&
                          noSignParm.StartsWith(DateTime.Now.ToString("yyyyMMddHH"), StringComparison.CurrentCultureIgnoreCase);
            var isFilter = !unFilterAction && !unFilterCtrl && !noSign&&(allowAnonymousAction||allowAnonymousCtrl);
            var inputStream = filterContext.HttpContext.Request.InputStream.StreamToString(false);
            //if (!string.IsNullOrWhiteSpace(inputStream)&&isFilter)
            if (isFilter)
            {
                try
                {
                    var dic = new Dictionary<string, string>();
                    var ts = "";
                    if (!string.IsNullOrWhiteSpace(inputStream))
                    {
                        var jObject = JObject.Parse(inputStream);
                        foreach (var item in jObject)
                        {
                            var v = item.Value?.ToString();
                            if (!string.IsNullOrWhiteSpace(v))
                            {
                                var v1 = JsonConvert.SerializeObject(item.Value).TrimStart('"').TrimEnd('"');// Regex.Replace(v, "\\r", "");
                                if (item.Key.Equals("ts", StringComparison.CurrentCultureIgnoreCase))
                                {
                                    ts = v1;
                                }

                                dic.Add(item.Key, v1);
                            }
                        }
                    }
                    if (string.IsNullOrWhiteSpace(ts))
                    {
                        r.SetFail("错误的请求");
                    }
                    else
                    {
                        var d = CommonUtils.TimeStampToDateTime(ts);
                        if ((DateTime.Now - d).Duration().TotalSeconds > 30 * 60)
                        {
                            r.SetFail($"接口请求超时");
                        }
                        else
                        {
                            var sign = CommonUtils.SignRequest(dic, secret, false);
                            var s = filterContext.HttpContext.Request.Headers.Get("portal-sign");
                            if (!sign.Equals(s, StringComparison.CurrentCultureIgnoreCase))
                            {
                                r.SetFail("检测到恶意请求");
                            }
                            else
                            {
                                r.SetSuccess(sign);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    r.SetFailEx("参数校验错误", $"计算签名值异常,{e.Message};[{inputStream}]", e);
                }
            }
            else
            {
                r.SetSuccess();
            }
            return r;
        }
        /// <summary>
        /// 验证请求头
        /// </summary>
        /// <param name="filterContext"></param>
        /// <returns></returns>
        protected GeneralResult ValidateRequest(ActionExecutingContext filterContext)
        {//todo 添加 User-Agent Origin Host 验证
            var r = new GeneralResult();
            var portal = ConfigHelper.AppSettings.Portal.TrimStart('~');
            var request = filterContext.HttpContext.Request;
            if (request.UrlReferrer == null
                || request.UrlReferrer.ToString().IndexOf(portal, StringComparison.CurrentCultureIgnoreCase) == -1)
            {
                r.SetFailEx("请求源非法", $"{request.UrlReferrer?.ToString()}");
                return r;
            }

            r.SetSuccess();
            return r;
        }
        /// <summary>
        /// IP地址
        /// </summary>
        protected string InternetProtocol(ActionExecutingContext filterContext)
        {
            var ipAddress = "";
            var request = filterContext.HttpContext.Request;
            var forwardedHttpHeader = ConfigHelper.AppSettings.ForwardedHTTPheader;
            var forwardedHttpHeaders = forwardedHttpHeader.Split(',').Distinct().ToList();
            string xff = request.ServerVariables.AllKeys
                .Where(x =>
                    (forwardedHttpHeaders.Exists(f => f.Equals(x, StringComparison.InvariantCultureIgnoreCase))
                     && !string.IsNullOrWhiteSpace(request.ServerVariables[x])
                     && request.ServerVariables[x] != "::1"
                     && request.ServerVariables[x] != "127.0.0.1"))
                .Select(k => request.ServerVariables[k])
                .FirstOrDefault();
            if (string.IsNullOrWhiteSpace(xff))
            {
                xff = request.Headers.AllKeys
                    .Where(x =>
                        (forwardedHttpHeaders.Exists(f => f.Equals(x, StringComparison.InvariantCultureIgnoreCase))
                         && !string.IsNullOrWhiteSpace(request.Headers[x])
                         && request.Headers[x] != "::1"
                         && request.Headers[x] != "127.0.0.1"))
                    .Select(k => request.Headers[k])
                    .FirstOrDefault();
            }

            if (!string.IsNullOrWhiteSpace(xff))
            {
                ipAddress = xff.Split(',').FirstOrDefault();
            }
            if (string.IsNullOrWhiteSpace(ipAddress))
            {
                ipAddress = request.UserHostAddress;
            }
            //some validation
            if (ipAddress == "::1")
                ipAddress = "127.0.0.1";
            //remove port
            if (!String.IsNullOrWhiteSpace(ipAddress))
            {
                int index = ipAddress.IndexOf(":", StringComparison.InvariantCultureIgnoreCase);
                if (index > 0)
                    ipAddress = ipAddress.Substring(0, index);
            }
            return ipAddress;
        }
    }
}