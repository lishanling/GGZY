using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using System.Web.Routing;

namespace GGZY.FuWu
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();//启用Attribute路由
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
