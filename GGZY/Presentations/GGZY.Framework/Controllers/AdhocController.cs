using System.Collections.Generic;
using System.Web.Mvc;
using GGZY.Core.Models;

namespace GGZY.Framework.Controllers
{
    /// <summary>
    /// 即席|智库
    /// </summary>
#if DEBUG
    [AllowAnonymous]
#endif
    public class AdhocController : BaseController
    {
        public ActionResult Index()
        {
            return View("GenTable");
        }

        public ActionResult GenTable(SearchCondition condition)
        {
            var r = Jd.CommonService.GeneralTable(condition, out int total).ToBootstrapTableList(total);
            return JResult(r, false);
        }

        public ActionResult GenColumn(string id)
        {
            var dt = Jd.CommonService.GeneralColumn(id);
            return View(dt);
        }

        public ActionResult GenSearch(List<NameValueModel> dic, SearchCondition search)
        {
            var r = Jd.CommonService.GenSearch(dic, search, out int total).ToBootstrapTableList(total);
            return JResult(r, false);
        }

        public ActionResult GenDetail(NameValueModel search)
        {
            var r = Jd.CommonService.GenDetail(search);
            return View(r);
        }

    }
}