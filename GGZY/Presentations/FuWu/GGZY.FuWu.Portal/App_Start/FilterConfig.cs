using System.Web;
using System.Web.Mvc;
using GGZY.Framework.Infrastructure.Filters;
using GGZY.Services.Infrastructure.Helper;

namespace GGZY.FuWu.Portal
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleErrorAttribute());
            filters.Add(new PortalFilter(ConfigHelper.AppSettings.FW_PORTAL_SIGN_KEY));
            filters.Add(new SqlFilter());
            filters.Add(new EncryptFilter(ConfigHelper.APP_KEY_GGZYFW));
        }
    }
}
