using System.Web.Mvc;
using GGZY.Framework.Controllers;
using GGZY.Services.Infrastructure.Model.BigData;

namespace GGZY.BigData.GCJS.Controllers
{
    /// <summary>
    /// 工程领域监察大数据服务系统-综合统计-评标专家
    /// </summary>
    public class StatisticsExpertController:BaseController
    {
        #region 专家参与项目总量排行

        /// <summary>
        /// 专家参与项目总量排行
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult ProjectCountRank(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsExpertService.ProjectCountRank(search);
            return JResult(r);
        }

        #endregion

        #region 评标专家项目金额分布

        /// <summary>
        /// 评标专家项目金额分布
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult ProjectAmountDistribution_ActiveCount(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsExpertService.ProjectAmountDistribution_ActiveCount(search);
            return JResult(r);
        }

        #endregion

        #region 评标专家分析-总数|新增数|活跃数|总次数

        /// <summary>
        /// 评标专家分析-总数|新增数|活跃数|总次数
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult UserCount(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsExpertService.UserCount(search);
            return JResult(r);
        }

        #endregion


        #region 专家年龄
        /// <summary>
        /// 专家年龄
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult Age(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsExpertService.Age(search);
            return JResult(r);
        }

        #endregion

        #region 专家专业占比
        /// <summary>
        /// 专家专业占比
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult Major(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsExpertService.Major(search);
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
            var r = Jd.StatisticsExpertService.Participation(search);
            return JResult(r);
        }

        #endregion

        #region 详情

        #region 评标参与排行（代理机构）
        /// <summary>
        /// 评标参与排行（代理机构）指评标专家参评的标与招标代理代理的招标项目相关联的招标代理机构排行，分析评标专家与招标代理机构的紧密度
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult EXPERT_AGENCY(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsExpertService.EXPERT_AGENCY(search);
            return JResult(r);
        }
        #endregion

        #region 评标参与排行（招标人）
        /// <summary>
        /// 评标参与排行（招标人）指评标专家参评的标与招标人发出的招标项目相关联的招标人排行，分析评标专家与招标人的紧密度
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult EXPERT_TENDERER(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsExpertService.EXPERT_TENDERER(search);
            return JResult(r);
        }
        #endregion

        #region 评标参与排行（投标人）
        /// <summary>
        /// 评标参与排行（投标人）指评标专家参评的标与投标人参与的项目相关联的投标企业排行，分析评标专家与投标人的紧密度
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult EXPERT_BIDDER(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsExpertService.EXPERT_BIDDER(search);
            return JResult(r);
        }
        #endregion

        #region 中标情况分析
        /// <summary>
        /// 中标情况分析 指评标专家参评的标与中标人中标的招标项目相关联的招标人前5名占正常项目占比情况（有中标结果）
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult EXPERT_WIN_BIDDER(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsExpertService.EXPERT_WIN_BIDDER(search);
            return JResult(r);
        }
        #endregion

        #region 评标专家信息
        /// <summary>
        /// 评标专家信息
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult EXPERT_INFO(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsExpertService.EXPERT_INFO(search);
            return JResult(r);
        }
        #endregion

        #region 专家评标项目情况
        /// <summary>
        /// 专家评标项目情况
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult EXPERT_CHART_INFO(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsExpertService.EXPERT_CHART_INFO(search);
            return JResult(r);
        }
        #endregion


        #region 评标项目地区分布图

        /// <summary>
        /// 评标项目地区分布图
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>

        public ActionResult EXPERT_AREA(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsExpertService.EXPERT_AREA(search);
            return JResult(r);
        }

        #endregion


        #endregion
    }
}