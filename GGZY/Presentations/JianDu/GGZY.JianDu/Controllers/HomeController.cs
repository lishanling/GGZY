using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Services.Infrastructure.Helper;

namespace GGZY.JianDu.Controllers
{
    [AllowAnonymous]
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var portal = ConfigHelper.AppSettings.Admin;
            var path = Server.MapPath(portal);
            if (System.IO.File.Exists(path))
            {
                return Redirect(portal);
            }
            return Content("");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}