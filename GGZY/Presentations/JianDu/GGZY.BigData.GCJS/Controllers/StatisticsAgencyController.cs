using System.Web.Mvc;
using GGZY.Framework.Controllers;
using GGZY.Services.Infrastructure.Model.BigData;

namespace GGZY.BigData.GCJS.Controllers
{
    public class StatisticsAgencyController:BaseController
    {
        #region 项目总量排行

        public ActionResult ProjectCountRank(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsAgencyService.ProjectCountRank(search);
            return JResult(r);
        }


        #endregion

        #region 招标代理项目金额分布

        /// <summary>
        /// 招标代理项目金额分布
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult ProjectAmountDistribution_ActiveCount(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsAgencyService.ProjectAmountDistribution_ActiveCount(search);
            return JResult(r);
        }

        #endregion

        #region 代理机构分析-总数|新增数|活跃数|总次数

        /// <summary>
        /// 代理机构分析-总数|新增数|活跃数|总次数
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult UserCount(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsAgencyService.UserCount(search);
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
            var r = Jd.StatisticsAgencyService.RegionChart(search);
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
            var r = Jd.StatisticsAgencyService.Grade(search);
            return JResult(r);
        }

        #endregion

        #region 企业性质
        /// <summary>
        /// 企业性质
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult Nature(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsAgencyService.Nature(search);
            return JResult(r);
        }

        #endregion

        #region 代理项目资金规模占比
        /// <summary>
        /// 企业性质
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult CapitalScale(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsAgencyService.CapitalScale(search);
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
            var r = Jd.StatisticsAgencyService.Capital(search);
            return JResult(r);
        }

        #endregion

        #region 参与招标情况
        /// <summary>
        /// 参与招标情况
        /// </summary>
        /// <returns></returns>
        public ActionResult Participation(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsAgencyService.Participation(search);
            return JResult(r);
        }

        #endregion

        #region 详情接口

        #region AGENCY_INFO 招标代理信息

        /// <summary>
        /// AGENCY_INFO
        /// 招标代理信息
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>

        public ActionResult AGENCY_INFO(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsAgencyService.AGENCY_INFO(search);
            return JResult(r);
        }

        #endregion

        #region AGENCY_CHART_INFO 代理情况

        /// <summary>
        /// AGENCY_CHART_INFO
        /// 代理情况
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>

        public ActionResult AGENCY_CHART_INFO(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsAgencyService.AGENCY_CHART_INFO(search);
            return JResult(r);
        }

        #endregion

        #region AGENCY_AREA 代理项目地区分布图

        /// <summary>
        /// AGENCY_AREA
        /// 代理项目地区分布图
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>

        public ActionResult AGENCY_AREA(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsAgencyService.AGENCY_AREA(search);
            return JResult(r);
        }

        #endregion

        #region PROXY_TENDERER 受委托排行 指承接业主项目业务情况排行，分析招标代理机构与招标人之间的紧密度

        /// <summary>
        /// PROXY_TENDERER
        /// 受委托排行
        /// 指承接业主项目业务情况排行，分析招标代理机构与招标人之间的紧密度
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult PROXY_TENDERER(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsAgencyService.PROXY_TENDERER(search);
            return JResult(r);
        }

        #endregion

        #region PROXY_TENDERER_RATE 受委托招标占比分析 指招标代理承接业主业务占所有承接招标项目的比值，展示排行前5名所占比重

        /// <summary>
        /// PROXY_TENDERER_RATE
        /// 受委托招标占比分析
        /// 指招标代理承接业主业务占所有承接招标项目的比值，展示排行前5名所占比重
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult PROXY_TENDERER_RATE(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsAgencyService.PROXY_TENDERER_RATE(search);
            return JResult(r);
        }

        #endregion

        #region PROXY_BIDDER_DIAG 投标参与排行 指招标代理发出的项目经常参与的投标的企业排行，通过投标企业的活跃度分析招标代理机构与投标人的紧密度

        /// <summary>
        /// PROXY_BIDDER_DIAG
        /// 投标参与排行
        /// 指招标代理发出的项目经常参与的投标的企业排行，通过投标企业的活跃度分析招标代理机构与投标人的紧密度
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult PROXY_BIDDER_DIAG(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsAgencyService.PROXY_BIDDER_DIAG(search);
            return JResult(r);
        }

        #endregion

        #region PROXY_WIN_BIDDER 中标企业排行 指招标人发出的项目中标率较高的企业占招标人所发项目的占比情况，分析招标代理机构与中标单位之间的紧密度

        /// <summary>
        /// PROXY_WIN_BIDDER
        /// 中标企业排行
        /// 指招标人发出的项目中标率较高的企业占招标人所发项目的占比情况，分析招标代理机构与中标单位之间的紧密度
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult PROXY_WIN_BIDDER(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsAgencyService.PROXY_WIN_BIDDER(search);
            return JResult(r);
        }

        #endregion

        #region PROXY_EXPERT 评标专家参与排行 指招标代理机构发出的项目出现频次较多的评标专家排行，分析招标人与评标专家的紧密度

        /// <summary>
        /// PROXY_EXPERT
        /// 评标专家参与排行
        /// 指招标代理机构发出的项目出现频次较多的评标专家排行，分析招标人与评标专家的紧密度
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult PROXY_EXPERT(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsAgencyService.PROXY_EXPERT(search);
            return JResult(r);
        }

        #endregion

        #region PROXY_EXPERT_RATE 正常项目专家参与排行 指招标代理机构发出的完成招投标环节的项目（已发出中标结果公示项目，流标及终止项目不计在内），出现频次较高的评标专家占所有评标专家的比值

        /// <summary>
        /// PROXY_EXPERT_RATE
        /// 正常项目专家参与排行
        /// 指招标代理机构发出的完成招投标环节的项目（已发出中标结果公示项目，流标及终止项目不计在内），出现频次较高的评标专家占所有评标专家的比值
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult PROXY_EXPERT_RATE(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsAgencyService.PROXY_EXPERT_RATE(search);
            return JResult(r);
        }

        #endregion

        #endregion
    }
}