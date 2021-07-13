using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using System.Web.Security;
using GGZY.Core.Authentication;
using GGZY.Core.Authentication.FormsCookie;
using GGZY.Core.Authentication.Jwt;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Framework.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model;
using GGZY.Services.Infrastructure.Model.FuWu;
using GGZY.Services.Infrastructure.Model.JianDu;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GGZY.Framework.Controllers
{
    /// <summary>
    /// 基础Controller
    /// </summary>
    public partial class BaseController : Controller
    {
        #region Properties
        /// <summary>
        /// 身份认证管理器
        /// </summary>
        private JwtTokenManager _tokenManager = null;


        /// <summary>
        /// 全局缓存
        /// </summary>
        public ICacheManager Cache => GlobalCache.Instance;
        /// <summary>
        /// 身份认证管理器
        /// </summary>
        public JwtTokenManager TokenManager => _tokenManager ?? (_tokenManager = new JwtTokenManager());

        /// <summary>
        /// 当前登录用户
        /// </summary>
        protected CustomAuthenticationIdentity Identity => User.AuthorizeFormsIdentityUser();
        protected FwUserModel FwUser => Identity?.FwUser();
        protected JdUserModel JdUser => Identity?.JdUser();
        /// <summary>
        /// 公共资源服务-业务工厂
        /// </summary>
        public ServicesFactoryFw Fw => ServicesFactory.GGZYFW;

        /// <summary>
        /// 公共资源监督-业务工厂
        /// </summary>
        public ServicesFactoryJd Jd => ServicesFactory.GGZYJD;


        /// <summary>
        /// 招标采购-业务工厂
        /// </summary>
        public ServicesFactoryJh ZBCG => ServicesFactory.ZBCG;
        /// <summary>
        /// 身份标识票据
        /// </summary>
        public string Token { get; set; }
        /// <summary>
        /// 当前主机地址
        /// </summary>
        protected string Host
        {
            get
            {
                var host = ConfigHelper.AppSettings.Host;
                if (string.IsNullOrWhiteSpace(host) && Request.Url != null)
                {
                    host = Request.Url.Authority;
                    if (!Request.IsLocal || Request.Url.ToString().IndexOf("114.115.162.77") > -1)
                    {
                        host = host.Replace($":{Request.Url.Port}", "");
                    }
                    host = Request.Url.ToString().StartsWith("https") ? $"https://{host}" : $"http://{host}";
                }
                return host;
            }
        }

        /// <summary>
        /// 是否来自监督平台的请求
        /// </summary>
        protected bool IsJdRequest =>
            Request.Url?.ToString().IndexOf("ggzyjd", StringComparison.CurrentCultureIgnoreCase) > -1 ||//生产环境域名
            Request.Url?.ToString().IndexOf("jdportal", StringComparison.CurrentCultureIgnoreCase) > -1 ||//测试环境门户二级站点路径
            Request.Url?.ToString().IndexOf("bigdata", StringComparison.CurrentCultureIgnoreCase) > -1 ||//大数据
            Request.Url?.ToString().IndexOf("BDGCJS", StringComparison.CurrentCultureIgnoreCase) > -1 ||//大数据
            Request.Url?.ToString().IndexOf("/jd/", StringComparison.CurrentCultureIgnoreCase) > -1;//测试站点后台二级站点路径


        /// <summary>
        /// 是否来自服务平台的请求
        /// </summary>
        protected bool IsFwRequest =>
            Request.Url?.ToString().IndexOf("ggzyfw", StringComparison.CurrentCultureIgnoreCase) > -1 ||//生产环境域名
            Request.Url?.ToString().IndexOf("fwportal", StringComparison.CurrentCultureIgnoreCase) > -1 ||//测试环境门户二级站点路径
            Request.Url?.ToString().IndexOf("/fw/", StringComparison.CurrentCultureIgnoreCase) > -1;//测试站点后台二级站点路径





       
        #endregion


        #region 身份验证

        /// <summary>
        /// 身份验证
        /// </summary>
        /// <param name="filterContext"></param>
        protected override void OnAuthorization(AuthorizationContext filterContext)
        {
            //var controller = (filterContext.RouteData.Values["controller"] ?? "").ToString();
            //var action = (filterContext.RouteData.Values["action"] ?? "").ToString();
            var result = new GeneralResult();
            var authorization = filterContext.RequestContext.HttpContext.Request.Headers.Get("Authorization");
            Token = authorization;
            //var cookieValue= Request.Cookies[FormsAuthentication.FormsCookieName]?.Value;
            //if (string.IsNullOrWhiteSpace(Token))
            //{
            //    Token = cookieValue;
            //}
            if (!string.IsNullOrWhiteSpace(Token))
            {
                var checkResult = TokenManager.CheckToken(Token);
                if (checkResult.Success)
                {
                    var identity = checkResult.TData;
                    filterContext.HttpContext.User = new CustomAuthenticationPrincipal(identity);
                    result.SetSuccess();
                }
                else
                {
                    result = checkResult;
                }
            }
            else
            {
                result.SetUnauthorized("身份未认证,请先登录");
            }
            if (!AllowAnonymous(filterContext))
            {
                if (!result.Success)
                {
                    // filterContext.Result = JResult(result);
                    filterContext.Result = JResult(result);
                    return;
                }
            }
            base.OnAuthorization(filterContext);
            //if (Request.InputStream.Length > 0)
            //{
            //    Request.InputStream.Dispose();
            //    using (StreamWriter sw = new StreamWriter(Request.InputStream))
            //    {
            //        sw.Write(InputStream);
            //        sw.Flush();
            //        Request.InputStream.Seek(0, SeekOrigin.Begin);
            //    }
            //}



        }

        /// <summary>
        /// 允许匿名用户
        /// </summary>
        /// <param name="actionContext"></param>
        /// <returns></returns>
        private static bool AllowAnonymous(AuthorizationContext actionContext)
        {
            var allowanonymous = true;
#if !DEBUG
            var typeOfAllowAnonymous = new AllowAnonymousAttribute().GetType();
            var allowAnonymousStr = actionContext.RequestContext.HttpContext.Request["AllowAnonymous"];
            allowanonymous = actionContext.ActionDescriptor.GetCustomAttributes(typeOfAllowAnonymous, true).Any()
                               || actionContext.ActionDescriptor.ControllerDescriptor.GetCustomAttributes(typeOfAllowAnonymous, true).Any()
                               || (!string.IsNullOrWhiteSpace(allowAnonymousStr) && allowAnonymousStr == DateTime.Now.ToString("yyyyMMddHHmm"));
#endif
            return allowanonymous;
        }


        #endregion



      


    }
}