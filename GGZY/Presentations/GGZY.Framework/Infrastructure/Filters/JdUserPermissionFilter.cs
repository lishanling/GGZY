using System.Web.Mvc;
using GGZY.Core.Authentication.FormsCookie;
using GGZY.Framework.Models;
using GGZY.Services.Infrastructure.Extensions;

namespace GGZY.Framework.Infrastructure.Filters
{
    /// <summary>
    /// 监督平台后台用户权限过滤器
    /// </summary>
    public class JdUserPermissionFilter:ActionFilterAttribute
    {
        /// <summary>
        /// 在方法执行前校验权限
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var jdUser = filterContext.HttpContext.User.AuthorizeFormsIdentityUser()?.JdUser();
            if (jdUser != null)
            {
                var ctrl = (filterContext.RouteData.Values["controller"] ?? "").ToString();
                var act = (filterContext.RouteData.Values["action"] ?? "").ToString();
                if (!jdUser.HasPermission(ctrl, act))
                {
                    filterContext.Result =   new CustomResult() { Data = "(´･ω･`) 对不起，您没有当前操作的的权限哦", UseGeneralResult = true,Success = false};
                }
            }
            base.OnActionExecuting(filterContext);
        }
    }
}