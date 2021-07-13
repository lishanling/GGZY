using GGZY.Framework.Infrastructure.Filters;
using GGZY.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GGZY.YDPB.Controllers
{
    public class HomeController : Controller
    {
        [ApiAuthorizationFilter]
        public ActionResult Index()
        {
            //return Content(Session["userid"].ToString());
            return new RedirectResult("./admin/index.html");
        }
        [Route("api/hall/test")]
        public string test()
        {
            return GGZY.Core.Utils.CommonUtils.Md5Str("");
        }
    }
}
