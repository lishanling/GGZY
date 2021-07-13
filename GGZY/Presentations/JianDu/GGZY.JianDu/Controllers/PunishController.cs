using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Dos.ORM;
using GGZY.Core.Helper;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;

namespace GGZY.JianDu.Controllers
{
    public class PunishController : BaseController
    {
        [AllowAnonymous]
        // GET: Punish
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Check(string code, string name, SearchCondition search)
        {
            return JResult(Jd.PunishService.Check(code, name, search), false);
        }
    }
}