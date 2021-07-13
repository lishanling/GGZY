using System.Web.Mvc;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using GGZY.Services.Infrastructure.Model.BigData;

namespace GGZY.BigData.GCJS.Controllers
{
    /// <summary>
    /// 工程领域监察大数据服务系统-综合统计-招标人情况
    /// </summary>
    public class StatisticsBidderController : BaseController
    {
        #region 工程领域监察大数据服务系统-综合统计-招标人情况

        /// <summary>
        /// 工程领域监察大数据服务系统-综合统计-招标人情况
        /// </summary>
        public ActionResult ProjectCountRank(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsBidderService.ProjectCountRank(search);
            return JResult(r);
        }

        #endregion

        #region 项目金额分布——活跃招标人

        /// <summary>
        /// 项目金额分布——活跃招标人
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult ProjectAmountDistribution_ActiveCount(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsBidderService.ProjectAmountDistribution_ActiveCount(search);
            return JResult(r);
        }

        #endregion

        #region 招标人分析-总数|新增数|活跃数|总次数

        /// <summary>
        /// 招标人分析-总数|新增数|活跃数|总次数
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult UserCount(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsBidderService.UserCount(search);
            return JResult(r);
        }

        #endregion

        #region 省份占比
        /// <summary>
        /// 省份占比
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult RegionChart(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsBidderService.RegionChart(search);
            return JResult(r);
        }
        #endregion

        #region 等级分布
        /// <summary>
        /// 等级分布
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult Grade(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsBidderService.Grade(search);
            return JResult(r);
        }

        #endregion

        #region 注册资本
        /// <summary>
        /// 注册资本
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult Capital(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsBidderService.Capital(search);
            return JResult(r);
        }

        #endregion

        #region 招标人性质
        /// <summary>
        /// 招标人性质
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult Nature(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsBidderService.Nature(search);
            return JResult(r);
        }

        #endregion

        #region 参与招标情况
        /// <summary>
        /// 参与招标情况
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult Participation(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsBidderService.Participation(search);
            return JResult(r);
        }

        #endregion

        #region 详情

        public ActionResult TENDERER_INFO(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsBidderService.TENDERER_INFO(search);
            return JResult(r);
        }
        public ActionResult TENDERER_CHART_INFO(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsBidderService.TENDERER_CHART_INFO(search);
            return JResult(r);
        }
        public ActionResult TENDERER_AREA(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsBidderService.TENDERER_AREA(search);
            return JResult(r);
        }
        public ActionResult TENDERER_PROXY(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsBidderService.TENDERER_PROXY(search);
            return JResult(r);
        }
        public ActionResult TENDERER_PROXY_RATE(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsBidderService.TENDERER_PROXY_RATE(search);
            return JResult(r);
        }
        public ActionResult TENDERER_BIDDER_DIAG(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsBidderService.TENDERER_BIDDER_DIAG(search);
            return JResult(r);
        }
        public ActionResult TENDERER_WIN_BIDDER(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsBidderService.TENDERER_WIN_BIDDER(search);
            return JResult(r);
        }
        public ActionResult TENDERER_EXPERT(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsBidderService.TENDERER_EXPERT(search);
            return JResult(r);
        }
        public ActionResult TENDERER_EXPERT_RATE(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsBidderService.TENDERER_EXPERT_RATE(search);
            return JResult(r);
        }

        #endregion
    }
}