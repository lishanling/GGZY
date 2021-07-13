using System.Web.Mvc;
using GGZY.Framework.Controllers;

namespace GGZY.BigData.GCJS.Controllers
{
    [AllowAnonymous]
    public class HomeController:BaseController
    {
        public ActionResult Index()
        {
            return Redirect("~/admin/index.html");
        }
    }
}