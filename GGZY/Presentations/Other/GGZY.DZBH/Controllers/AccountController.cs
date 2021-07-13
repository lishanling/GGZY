using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Extensions;

namespace GGZY.DZBH.Controllers
{
    public class AccountController : BaseController
    {

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult GetUserInfo()
        {
            if (Identity != null && Identity.FwUser() != null)
            {
                return JResult(new
                {
                    Identity.FwUser().ID,
                    Identity.FwUser().USERNAME,
                    Identity.FwUser().LEGAL_NAME,
                    Identity.FwUser().BASIC_ACCOUNT_NO,
                    Identity.FwUser().BASIC_BANK,
                    Identity.FwUser().LEGAL_CODE,
                    Identity.FwUser().LEGAL_CONTACT,
                    Identity.FwUser().LEGAL_CONTACT_PHONE,
                    Identity.FwUser().LEGAL_UNIT_ADDRESS,
                });
            }

            return JResult("请登录");

        }
    }
}