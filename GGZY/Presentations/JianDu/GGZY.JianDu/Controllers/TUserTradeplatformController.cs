using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using GGZYJD.DbEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GGZY.JianDu.Controllers
{
    public class TUserTradeplatformController : BaseController
    {
        public ActionResult PageTable(T_USER_TRADEPLATFORM model, SearchCondition search)
        {
            if(String.IsNullOrEmpty(HttpContext.Request.Params["PageSize"]))
            {
                search.PageSize = 99;
            }
            var result = Jd.TUserTradeplatformService.PageTable(model, search);
            return JResult(result);
        }
    }
}