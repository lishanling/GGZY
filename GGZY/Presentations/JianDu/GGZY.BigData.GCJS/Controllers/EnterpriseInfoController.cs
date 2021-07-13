using GGZY.Framework.Controllers;
using GGZY.Services.Infrastructure.Model.BigData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GGZY.BigData.GCJS.Controllers
{
    public class EnterpriseInfoController : BaseController
    {
        #region 
        /// <summary>
        /// 软硬件统计分析
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult EnterpriseInfoSame(EnterpriseInfoSearchModel search)
        {
            var r = Fw.EnterpriseInfoService.EnterpriseInfoSame(search);
            return JResult(r);
        }
        public ActionResult EnterpriseInfoSameDetail(EnterpriseInfoSearchModel search)
        {
            var r = Fw.EnterpriseInfoService.EnterpriseInfoSameDetail(search);
            return JResult(r);
        }
        public ActionResult EnterpriseInfoOverlap(EnterpriseInfoSearchModel search)
        {
            var r = Fw.EnterpriseInfoService.EnterpriseInfoOverlap(search);
            return JResult(r);
        }
        public ActionResult EnterpriseInfoOverlapDetail(EnterpriseInfoSearchModel search)
        {
            var r = Fw.EnterpriseInfoService.EnterpriseInfoOverlapDetail(search);
            return JResult(r);
        }
        public ActionResult EnterpriseInfoUsered(EnterpriseInfoSearchModel search)
        {
            var r = Fw.EnterpriseInfoService.EnterpriseInfoUsered(search);
            return JResult(r);
        }
        public ActionResult EnterpriseInfoUseredDetail(EnterpriseInfoSearchModel search)
        {
            var r = Fw.EnterpriseInfoService.EnterpriseInfoUseredDetail(search);
            return JResult(r);
        }
        public ActionResult PersonInfo(EnterpriseInfoSearchModel search)
        {
            var r = Fw.EnterpriseInfoService.PersonInfo(search);
            return JResult(r);
        }
        public ActionResult PersonInfoDetail(EnterpriseInfoSearchModel search)
        {
            var r = Fw.EnterpriseInfoService.PersonInfoDetail(search);
            return JResult(r);
        }
        #endregion
    }
}