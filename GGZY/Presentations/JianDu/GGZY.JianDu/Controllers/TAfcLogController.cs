using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdTAfcLogController
    {

        public ActionResult ProjectReportBuilder(T_AFC_LOG model, SearchCondition search)
        {
            var r = Jd.TAfcLogService.ProjectReportBuildSearch(model, search);
            return JResult(r);
        }
        public ActionResult ProjectReportBuildDetail(string mid)
        {
            var r = Jd.TAfcProjectService.ProjectReportBuildDetail(mid);
            return JResult(r);
        }
    }
}