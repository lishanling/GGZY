using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GGZY.Framework.Controllers;
using GGZY.Services.BigData;
using GGZY.Services.Infrastructure.Model.BigData;

namespace GGZY.BigData.Controllers
{
    public class BigDataController : BaseController
    {
        #region 首页

        public ActionResult GetData(BigDataSearchModel search)
        {
            return JResult(Jd.BigDataMainService.GetData(search));
        }
        public ActionResult ShouYeJiaoYiE(BigDataSearchModel search)
        {
            return JResult(Jd.BigDataMainService.ShouYeJiaoYiE(search));
        }
        public ActionResult ShouYeQuShi(BigDataSearchModel search)
        {
            return JResult(Jd.BigDataMainService.ShouYeQuShi(search));
        }

        #endregion
        
        #region 工程建设-代理

        public ActionResult GCJSProxyRank(BigDataSearchModel search)
        {
            return JResult(Jd.BigDataMainService.GCJSProxyRank(search));
        }

        public ActionResult GCJSProxyMiddle(BigDataSearchModel search)
        {
            return JResult(Jd.BigDataMainService.GCJSProxyMiddle(search));
        }
        public ActionResult GCJSProxyAreaCount(BigDataSearchModel search)
        {
            return JResult(Jd.BigDataMainService.GCJSProxyAreaCount(search));
        }
        public ActionResult GCJSProxyAreaChart(BigDataSearchModel search)
        {
            return JResult(Jd.BigDataMainService.GCJSProxyAreaChart(search));
        }
        public ActionResult GCJSProxyLevelCount(BigDataSearchModel search)
        {
            return JResult(Jd.BigDataMainService.GCJSProxyLevelCount(search));
        }

        #endregion

    }
}