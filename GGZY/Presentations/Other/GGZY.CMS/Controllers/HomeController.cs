using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using GGZY.Core.Authentication;
using GGZY.Core.Authentication.FormsCookie;
using GGZY.Framework.Controllers;
using GGZY.Services.Infrastructure.Model;

namespace GGZY.CMS.Controllers
{

    public class HomeController : BaseAjaxController
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View("Dashboard");
                //return RedirectToAction("Dashboard", "Home");
            }

            return View("Login");
            //return RedirectToAction("Login", "Home");
        }
     
        [AllowAnonymous, HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [AllowAnonymous, ValidateAntiForgeryToken, HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (username == "strong")
            {
                var r = Fw.VUnifyUserService.SignIn(new LoginModel { Name = username, Pwd = password });
                if (r.Success)
                {
                    var identity = new CustomAuthenticationIdentity
                    {
                        Ticket = Guid.NewGuid().ToString("N"),
                        TimeStamp = DateTime.Now.ToString("yyyyMMddHHmmss"),
                        Id = r.TData.ID?.ToString(),
                        Name = username,
                        LoginName = username,
                    };
                    TokenManager.CreateToken(identity);
                    // identity.Ticket

                    new CustomAuthentication().SetCookie(FormsAuthentication.FormsCookieName, identity.Ticket);
                    return RedirectToAction("Dashboard", "Home");
                }
            }
            return RedirectToAction("Login", "Home");
        }

        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult SignOut()
        {
            new CustomAuthentication().SignOut();
            TokenManager.DeleteToken(Identity.Ticket);
            //new CustomAuthentication().SetCookie(FormsAuthentication.FormsCookieName,string.Empty);
            return RedirectToAction("Login", "Home");
        }

        public ActionResult AdminIndex()
        {
            return View();
            // return Redirect("/admin/index.html#adminIndex");
        }
    }
}