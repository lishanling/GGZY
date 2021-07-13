using System.Web.Mvc;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using GGZYFW.DbEntity;

namespace GGZY.CMS.Controllers
{
    //[AllowAnonymous]
    public class SltStaffLogController : BaseAjaxController
    {
        public ActionResult List()
        {
            return View();
        }

        /// <summary>
        /// 读取SLT_SCORE_LOG列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadSltStaffLogs(SLT_STAFF_LOG model, SearchCondition condition)
        {
            var result = Fw.SltStaffLogService.PageList(model, condition);
            return JResult(result,false);
        }

    }
}