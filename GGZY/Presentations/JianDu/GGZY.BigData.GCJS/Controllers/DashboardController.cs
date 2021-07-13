using System.Web.Mvc;
using GGZY.Framework.Controllers;
using GGZY.Services.Infrastructure.Model.BigData;

namespace GGZY.BigData.GCJS.Controllers
{

    public class DashboardController:BaseController
    {
        #region 交易排行

        /// <summary>
        /// 交易排行-交易额|交易数
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult TradeRank(EngineerSearchModel search)
        {
            var r = Jd.DashboardService.TradeRank(search);
            return JResult(r);
        }

        #endregion

        #region 交易数据统计

        /// <summary>
        /// 交易数据统计
        /// </summary>
        /// <param name="search">AREACODE BeginTime EndTime</param>
        /// <returns></returns>
        public ActionResult TradeDataSummary(EngineerSearchModel search)
        {
            var r = Jd.DashboardService.TradeDataSummary(search);
            return JResult(r);
        }

        #endregion

        #region 交易方式占比

        /// <summary>
        /// 交易方式占比
        /// </summary>
        /// <param name="search">AREACODE BeginTime EndTime</param>
        /// <returns></returns>
        public ActionResult TradeMethod(EngineerSearchModel search)
        {
            var r = Jd.DashboardService.TradeMethod(search);
            return JResult(r);
        }

        #endregion

        #region 交易类型分布

        /// <summary>
        /// 交易类型分布
        /// </summary>
        /// <param name="search">AREACODE BeginTime EndTime</param>
        /// <returns></returns>
        public object TradeType(EngineerSearchModel search)
        {
            var r = Jd.DashboardService.TradeType(search);
            return JResult(r);
        }

        #endregion

        #region 节约额分布情况
        /// <summary>
        /// 节约额分布情况
        /// </summary>
        /// <param name="search">AREACODE BeginTime EndTime</param>
        /// <returns></returns>
        public object JieYueAmount(EngineerSearchModel search)
        {
            var r = Jd.DashboardService.JieYueAmount(search);
            return JResult(r);
        }

        #endregion

        #region 当前登录账号-组织机构-归属地树
        /// <summary>
        /// 当前登录账号-组织机构-归属地树
        /// </summary>
        /// <returns></returns>
        public ActionResult DepRegionTree()
        {
            var r = Jd.SysAreaQuanguoService.DepRegionTree();
            return JResult(r);
        }

        #endregion

    }
}