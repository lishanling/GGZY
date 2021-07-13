﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GGZY.BigData.GCJS
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
            routes.MapRoute(
                name: "FileContent",
                url: "FileContent/{pt}/{fType}/{id}",
                defaults: new { controller = "File", action = "Content", id = UrlParameter.Optional, pt = UrlParameter.Optional, fType = UrlParameter.Optional }
            );
        }
    }
}
