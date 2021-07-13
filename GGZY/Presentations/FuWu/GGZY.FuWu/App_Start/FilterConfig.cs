using System.Web;
using System.Web.Mvc;using GGZY.Framework.Controllers;

namespace GGZY.FuWu
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
