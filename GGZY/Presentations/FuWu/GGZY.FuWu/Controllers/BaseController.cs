using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GGZY.Core.Authentication;
using GGZY.Core.Authentication.FormsCookie;
using GGZY.Core.Authentication.Jwt;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.FuWu.Models;
using GGZY.Services.Base;

namespace GGZY.FuWu.Controllers
{
    public class BaseController : Controller
    {
        #region Properties

        private ITokenManager _tokenManager = null;


        /// <summary>
        /// 全局缓存
        /// </summary>
        public ICacheManager Cache
        {
            get { return GlobalCache.Instance; }
        }

        public ITokenManager TokenManager
        {
            get { return _tokenManager ?? (_tokenManager = new JwtTokenManager(Cache)); }
        }



        protected CustomAuthenticationIdentity Identity => User.AuthorizeFormsIdentityUser();

        /// <summary>
        /// 公共资源服务-业务工厂
        /// </summary>
        public ServicesFactoryFw Fw => ServicesFactoryFw.Instance;

        /// <summary>
        /// 公共资源监督-业务工厂
        /// </summary>
        public ServicesFactoryJd Jd => ServicesFactoryJd.Instance;

        #endregion


        #region 身份验证


        protected override void OnAuthorization(AuthorizationContext filterContext)
        {
            var controller = (filterContext.RouteData.Values["controller"] ?? "").ToString();
            var action = (filterContext.RouteData.Values["action"] ?? "").ToString();
            if (!AllowAnonymous(filterContext))
            {
                var token = filterContext.RequestContext.HttpContext.Request.Headers.Get("Authorization");

                var result = new GeneralResult();
                if (!string.IsNullOrWhiteSpace(token))
                {
                    var checkResult = TokenManager.CheckToken(token);
                    if (checkResult.Success)
                    {
                        var identity = checkResult.Data;
                        object dbUser = null;
                        if (dbUser == null)
                        {
                            result.SetFail($"当前账号不存在");
                        }
                        //else if (dbUser.STATUS != (int)YesNoType.Yes)
                        //{
                        //    result.SetFail($"当前账号已停用");
                        //}
                        //else
                        //{
                        //    var roleIds = dbUser.ROLEIDS.Split(',');
                        //    var rolePermission =
                        //        ServicesFactory.MgrRoleMenuService.RoleMenus(roleIds);
                        //    var allPermissions = ServicesFactory.MgrMenuService.FindAll();
                        //    var enableMenus = allPermissions.FindAll(c => c.ENABLED == (int)YesNoType.Yes);
                        //    var roleMenus = enableMenus.FindAll(c => rolePermission.Any(r => r.MENUID == c.ID));
                        //    if (enableMenus.Exists(c => c.CONTROLLER_NAME == controller && c.ACTION_NAME == action) && !roleMenus.Exists(c => c.CONTROLLER_NAME == controller && c.ACTION_NAME == action))
                        //    {
                        //        result.SetFail($"当前账号无此权限");
                        //    }
                        //    else
                        //    {
                        //        result.SetSuccess();
                        //    }
                        //}

                        if (result.Success && identity is CustomAuthenticationIdentity iUsr)
                        {
                            filterContext.HttpContext.User = new CustomAuthenticationPrincipal(iUsr);
                        }
                        else
                        {
                            filterContext.Result = JResult(result);
                        }
                        return;
                    }
                    else
                    {
                        filterContext.Result = JResult(result);
                        return;
                    }
                }
                else
                {
                    result.SetUnauthorized("身份未认证,请先登录");
                    filterContext.Result = JResult(result);
                    return;
                }
            }

            base.OnAuthorization(filterContext);
        }

        private static bool AllowAnonymous(AuthorizationContext actionContext)
        {
#if DEBUG
            return true;
#endif
            var typeOfAllowAnonymous = new AllowAnonymousAttribute().GetType();
            var allowAnonymous = actionContext.RequestContext.HttpContext.Request["AllowAnonymous"];
            return actionContext.ActionDescriptor.GetCustomAttributes(typeOfAllowAnonymous, true).Any()
                   || actionContext.ActionDescriptor.ControllerDescriptor.GetCustomAttributes(typeOfAllowAnonymous, true).Any()
                || (!string.IsNullOrWhiteSpace(allowAnonymous) && allowAnonymous == DateTime.Now.ToString("yyyyMMddHHmm"));
        }


        #endregion


        /// <summary>
        /// JSON 格式化结果
        /// </summary>
        /// <param name="data">结果对象</param>
        /// <param name="useGeneralResult">true使用统一结构返回结果 false 使用自定义结构返回结果</param>
        /// <returns></returns>
        protected CustomResult JResult(object data, bool useGeneralResult = true)
        {
            return new CustomResult() { Data = data, UseGeneralResult = useGeneralResult };
        }


        
    }
}