using System.Web;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Framework.Infrastructure.Filters;

namespace GGZY.BigData.GCJS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new SqlFilter());
        }
    }
}
