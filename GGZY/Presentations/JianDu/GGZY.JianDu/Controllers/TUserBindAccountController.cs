using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GGZY.Framework.Controllers;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public class JdTUserBindAccountController : BaseController
    {
        // GET: TUserBindAccount
        public ActionResult GetAccountList()
        {
            return JResult(Jd.TUserBindAccountService.GetAccountList());
        }
        public ActionResult GetList()
        {
            return JResult(Jd.TUserBindAccountService.GetList());
        }
        public ActionResult Add(List<T_USER_BIND_ACCOUNT> accountList)
        {
            return JResult(Jd.TUserBindAccountService.Add(accountList));
        }
        public ActionResult MztBindOldJdUser(string username, string password)
        {
            return JResult(Jd.TUserBindAccountService.MztBindOldJdUser(username, password));
        }
    }
}