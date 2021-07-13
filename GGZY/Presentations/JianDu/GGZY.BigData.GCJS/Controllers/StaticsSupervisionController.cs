using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GGZY.Framework.Controllers;
using GGZY.Services.Infrastructure.Model.BigData;

namespace GGZY.BigData.GCJS.Controllers
{
    public class StaticsSupervisionController : BaseController
    {
        // GET: StaticsSupervision
        public ActionResult SupervisionCount(StatisticsSupervisionSearchModel search)
        {
            var r = Jd.StatisticsSupervisionService.SupervisionCount(search);
            return JResult(r);
        }
        public ActionResult SupervisionExceptionRank(StatisticsSupervisionSearchModel search)
        {
            var r = Jd.StatisticsSupervisionService.SupervisionExceptionRank(search);
            return JResult(r);
        }
        public ActionResult SupervisionTimeAnalyze(StatisticsSupervisionSearchModel search)
        {
            var r = Jd.StatisticsSupervisionService.SupervisionTimeAnalyze(search);
            return JResult(r);
        }
        public ActionResult SupervisionPie(StatisticsSupervisionSearchModel search)
        {
            var r = Jd.StatisticsSupervisionService.SupervisionPie(search);
            return JResult(r);
        }
        public ActionResult SuspectCount(StatisticsSupervisionSearchModel search)
        {
            var r = Jd.StatisticsSupervisionService.SuspectCount(search);
            return JResult(r);
        }
        public ActionResult SuspectRank(StatisticsSupervisionSearchModel search)
        {
            var r = Jd.StatisticsSupervisionService.SuspectRank(search);
            return JResult(r);
        }
        public ActionResult SuspectTimeAnalyze(StatisticsSupervisionSearchModel search)
        {
            var r = Jd.StatisticsSupervisionService.SuspectTimeAnalyze(search);
            return JResult(r);
        }
        public ActionResult SuspectPie(StatisticsSupervisionSearchModel search)
        {
            var r = Jd.StatisticsSupervisionService.SuspectPie(search);
            return JResult(r);
        }
        public ActionResult DepartmentCyjdxmsRank(StatisticsSupervisionSearchModel search)
        {
            var r = Jd.StatisticsSupervisionService.DepartmentCyjdxmsRank(search);
            return JResult(r);
        }
        public ActionResult DepartmentYcxmsRank(StatisticsSupervisionSearchModel search)
        {
            var r = Jd.StatisticsSupervisionService.DepartmentYcxmsRank(search);
            return JResult(r);
        }
        public ActionResult DepartmentFcyjsRank(StatisticsSupervisionSearchModel search)
        {
            var r = Jd.StatisticsSupervisionService.DepartmentFcyjsRank(search);
            return JResult(r);
        }
        public ActionResult DepartmentYjxmblRank(StatisticsSupervisionSearchModel search)
        {
            var r = Jd.StatisticsSupervisionService.DepartmentYjxmblRank(search);
            return JResult(r);
        }
        public ActionResult DepartmentYswgdRank(StatisticsSupervisionSearchModel search)
        {
            var r = Jd.StatisticsSupervisionService.DepartmentYswgdRank(search);
            return JResult(r);
        }
        public ActionResult DepartmentDcjgRank(StatisticsSupervisionSearchModel search)
        {
            var r = Jd.StatisticsSupervisionService.DepartmentDcjgRank(search);
            return JResult(r);
        }
        public ActionResult DepartmentCount()
        {
            var r = Jd.StatisticsSupervisionService.DepartmentCount();
            return JResult(r);
        }
        public ActionResult SurveyCount(StatisticsSupervisionSearchModel search)
        {
            var r = Jd.StatisticsSupervisionService.SurveyCount(search);
            return JResult(r);
        }
        public ActionResult ProjectConditionCount(StatisticsSupervisionSearchModel search)
        {
            var r = Jd.StatisticsSupervisionService.ProjectConditionCount(search);
            return JResult(r);
        }
        public ActionResult ProjectTop10(StatisticsSupervisionSearchModel search)
        {
            var r = Jd.StatisticsSupervisionService.ProjectTop10(search);
            return JResult(r);
        }
        public ActionResult SubjectTop10(StatisticsSupervisionSearchModel search)
        {
            var r = Jd.StatisticsSupervisionService.SubjectTop10(search);
            return JResult(r);
        }

    }
}