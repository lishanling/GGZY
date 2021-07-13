using System;
using System.Linq;
using System.Web.Mvc;
using GGZY.Framework.Models;
using GGZY.Services.Infrastructure.Helper;

namespace GGZY.Framework.Infrastructure.Filters
{
    public class EncryptFilter : ActionFilterAttribute
    {
        public EncryptFilter(string type)
        {
            this.Type = type;
        }
        private string Type { get; set; }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var unFilter = typeof(PortalUnEncryptFilterAttribute);
            var unFilterAction = filterContext.ActionDescriptor.GetCustomAttributes(unFilter, true).Any();
            var unFilterCtrl = filterContext.ActionDescriptor.ControllerDescriptor.GetCustomAttributes(unFilter, true)
                .Any();
            var unSecretTag = filterContext.HttpContext.Request.Params["no_encryption"];
            bool noEncryption = !string.IsNullOrWhiteSpace(unSecretTag) &&
                                unSecretTag.Equals(DateTime.Now.ToString("yyyyMMdd"), StringComparison.CurrentCultureIgnoreCase);
            
            if (!noEncryption&&!unFilterAction&&!unFilterCtrl)
            {
                switch (Type)
                {
                    case ConfigHelper.APP_KEY_GGZYJD:
                     
                        filterContext.Controller.TempData["SKey"] = ConfigHelper.AppSettings.JD_PORTAL_ASC_KEY;
                        filterContext.Controller.TempData["Iv"] = ConfigHelper.AppSettings.JD_PORTAL_ASC_IV;
                      
                        break;
                    case ConfigHelper.APP_KEY_GGZYFW:
                        filterContext.Controller.TempData["SKey"] = ConfigHelper.AppSettings.FW_PORTAL_ASC_KEY;
                        filterContext.Controller.TempData["Iv"] = ConfigHelper.AppSettings.FW_PORTAL_ASC_IV;
                        break;
                }
            }
            base.OnActionExecuting(filterContext);
        }
    }
}