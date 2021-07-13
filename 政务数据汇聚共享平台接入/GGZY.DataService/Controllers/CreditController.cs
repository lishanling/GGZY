using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GGZY.DataService.Controllers
{
    public class CreditController : Controller
    {
        // GET: Credit
        public ActionResult Index()
        {
            AppV1 a = new AppV1();
            a.BeginLogin("!23");
            return null;
        }
    }
}