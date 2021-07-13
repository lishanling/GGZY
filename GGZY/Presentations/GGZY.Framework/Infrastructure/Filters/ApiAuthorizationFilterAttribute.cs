using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using GGZY.Core.Authentication;
using GGZY.Core.Authentication.Jwt;
using GGZY.Core.Cache;
using GGZY.Core.Models;
using System.Configuration;
using GGZY.Core.Authentication.FormsCookie;
using GGZY.Core.Utils;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Extensions;

namespace GGZY.Framework.Infrastructure.Filters
{
    /// <summary>
    /// 自定义身份认证
    /// </summary>
    public class ApiAuthorizationFilterAttribute : AuthorizeAttribute
    {
        /// <summary>
        /// 身份认证管理器
        /// </summary>
        protected JwtTokenManager _tokenManager = null;
        
        /// <summary>
        /// 身份认证管理器
        /// </summary>
        protected JwtTokenManager TokenManager => _tokenManager ?? (_tokenManager = new JwtTokenManager());
        /// <summary>
        /// 身份授权认证
        /// </summary>
        /// <param name="actionContext"></param>
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var result = new GeneralResult();
            var parameter = actionContext.Request.Headers.Authorization?.Parameter
                            ?? actionContext.Request.Headers.Authorization?.Scheme;
            if (!string.IsNullOrWhiteSpace(parameter))
            {
                var checkResult = TokenManager.CheckToken(parameter);
                if (checkResult.Success)
                {
                    var identity = checkResult.TData;
                    actionContext.ControllerContext.RequestContext.Principal = new CustomAuthenticationPrincipal(identity);
                    result.SetSuccess();

                    if(null == identity)
                    {
                        result.SetFail("登录信息失效/未登录");
                    }

                    if (!String.IsNullOrEmpty(Roles))
                    {
                        bool IsAuthorized = false;
                        var roles = Roles.Split(',');
                        foreach (var role in roles)
                        {
                            if (identity.FwUser().GetRoleName().Contains(role))
                            {
                                IsAuthorized = true;
                                break;
                                
                            }
                        }
                        if (!IsAuthorized)
                        {
                            result.SetFail("角色认证失败,允许用户角色:" + Roles + ",当前登录用户角色:"+ Newtonsoft.Json.JsonConvert.SerializeObject(identity.FwUser().GetRoleName())+",当前请求地址:" + actionContext.Request.RequestUri);
                        }
                    }
                }
                else
                {
                    result = checkResult;
                }
            }
            else
            {
                result.Data = AppSettingUtils.GetString("unify_login_url", "https://ggzyfw.fujian.gov.cn/OAuth/admin/index.html#/login?client_id=YDPB"); ;
                result.SetFail("身份未认证,请先登录");
            }
            
            if (!AllowAnonymous(actionContext))
            {
                if (!result.Success)
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK, result);
                }
                else
                {
                    base.IsAuthorized(actionContext);
                }

            }
        }
        /// <summary>
        /// 允许匿名用户
        /// </summary>
        /// <param name="actionContext"></param>
        /// <returns></returns>
        private static bool AllowAnonymous(HttpActionContext actionContext)
        {
            var allowanonymous = true;
            //#if !DEBUG
            allowanonymous = actionContext.ActionDescriptor.GetCustomAttributes<AllowAnonymousAttribute>(true).Any()
                            || actionContext.ActionDescriptor.ControllerDescriptor.GetCustomAttributes<AllowAnonymousAttribute>(true).Any()
                            || (actionContext.Request.Properties.ContainsKey("AllowAnonymous") && DateTime.Now.ToString("yyyyMMddHHmm") == actionContext.Request.Properties["AllowAnonymous"]?.ToString());
            //#endif
            return allowanonymous;
        }
    }
}