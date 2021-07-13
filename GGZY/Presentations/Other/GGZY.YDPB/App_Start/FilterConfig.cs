using System.Web;
using System.Web.Mvc;
using GGZY.Framework.Infrastructure.Filters;

namespace GGZY.YDPB
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleErrorAttribute());
            filters.Add(new SqlFilter());
        }
    }
}
