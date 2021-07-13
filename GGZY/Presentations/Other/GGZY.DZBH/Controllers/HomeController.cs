using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GGZY.DZBH.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string tenderprojectcode, string systemno)
        {
            string p = "";
            if (!string.IsNullOrEmpty(tenderprojectcode) && !string.IsNullOrEmpty(systemno))
            {
                p = $"?tenderprojectcode={tenderprojectcode}&systemno={systemno}";
            }
            else if (!string.IsNullOrEmpty(tenderprojectcode))
            {
                p = $"?tenderprojectcode={tenderprojectcode}";
            }
            else if (!string.IsNullOrEmpty(systemno))
            {
                p = $"?systemno={systemno}";
            }

            return Redirect("/bh/adminV/#/dashboard" + p);
        }
    }
}