using System.Web.Mvc;
using GGZY.Framework.Controllers;
using GGZY.Services.Infrastructure.Model.BigData;

namespace GGZY.BigData.GCJS.Controllers
{
    /// <summary>
    /// 工程领域监察大数据服务系统-综合统计-投标人情况
    /// </summary>
    public class StatisticsTenderController:BaseController
    {
        #region 工程领域监察大数据服务系统-综合统计-投标人情况

        /// <summary>
        /// 工程领域监察大数据服务系统-综合统计-投标人情况
        /// </summary>
        public ActionResult ProjectCountRank(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsTenderService.ProjectCountRank(search);
            return JResult(r);
        }

        #endregion

        #region 投标人项目金额分布

        /// <summary>
        /// 投标人项目金额分布
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult ProjectAmountDistribution_ActiveCount(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsTenderService.ProjectAmountDistribution_ActiveCount(search);
            return JResult(r);
        }

        #endregion

        #region 投标人情况-总数|新增数|活跃数|总次数

        /// <summary>
        /// 投标人情况-总数|新增数|活跃数|总次数
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult UserCount(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsTenderService.UserCount(search);
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
            var r = Jd.StatisticsTenderService.RegionChart(search);
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
            var r = Jd.StatisticsTenderService.Grade(search);
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
            var r = Jd.StatisticsTenderService.Capital(search);
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
            var r = Jd.StatisticsTenderService.Nature(search);
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
            var r = Jd.StatisticsTenderService.Participation(search);
            return JResult(r);
        }

        #endregion

        #region 详情

        #region 投标人信息

        /// <summary>
        /// 投标人信息
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>

        public ActionResult TENDER_INFO(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsTenderService.TENDER_INFO(search);
            return JResult(r);

        }

        #endregion

        #region 主要项目区域

        /// <summary>
        /// 主要项目区
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>

        public ActionResult TENDER_INFO_AREA(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsTenderService.TENDER_INFO_AREA(search);
            return JResult(r);
        }

        #endregion

        #region 当前时间段内中标  次

        /// <summary>
        /// 当前时间段内中标  次
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>

        public ActionResult TENDER_WIN_COUNT(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsTenderService.TENDER_WIN_COUNT(search);
            return JResult(new{ TENDER_WIN_COUNT =r});
        }

        #endregion

        #region 投标及中标情况
        /// <summary>
        /// TENDER_CHART_WIN,TENDER_CHART_TOUBIAO 投标及中标情况
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult TENDER_CHART_WIN_AND_TOUBIAO(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsTenderService.TENDER_CHART_WIN_AND_TOUBIAO(search);
            return JResult(r);
        }

        #endregion

        #region 投标项目地区分布图
        /// <summary>
        /// 
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult TENDER_AREA(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsTenderService.TENDER_AREA(search);
            return JResult(r);
        }

        #endregion

        #region 投标参与度分析（代理）
        /// <summary>
        /// 投标参与度分析（代理）
        /// 指投标人投标的项目与招标代理机构发出的项目关系性排行，分析投标人与招标代理的紧密度
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult TENDER_PROXY(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsTenderService.TENDER_PROXY(search);
            return JResult(r);
        }
        #endregion

        #region 投标参与排行
        /// <summary>
        /// 投标参与排行
        /// 根据投标人经常参与的招标人频率的的业主排行，分析投标企业招标人之间的紧密性
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult TENDER_TENDERER(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsTenderService.TENDER_TENDERER(search);
            return JResult(r);
        }
        #endregion

        #region 投标参与度排行（专家）
        /// <summary>
        /// 投标参与度排行（专家）
        /// 指投标人投标的项目与评标专家评的项目一致的评标专家排行，分析投标人与评标专家的紧密度
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult TENDER_EXPERT(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsTenderService.TENDER_EXPERT(search);
            return JResult(r);
        }
        #endregion

        #region 中标参与分析（代理）
        /// <summary>
        /// 中标参与分析（代理）
        /// 指投标人中标的项目与招标代理机构发出的项目关系性排行，分析中标人与招标人之间的紧密度
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult TENDER_PROXY_WIN(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsTenderService.TENDER_PROXY_WIN(search);
            return JResult(r);
        }
        #endregion

        #region 中标参与分析（招标人）
        /// <summary>
        /// 中标参与分析（招标人）
        /// 对投标人中标的项目主要是业主单位进行排行，分析中标人与投标人的紧密度
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult TENDER_TENDERER_WIN(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsTenderService.TENDER_TENDERER_WIN(search);
            return JResult(r);
        }
        #endregion

        #region 中标参与度分析
        /// <summary>
        /// 中标参与度分析
        /// 指投标人中标的项目中出现评标专家较多的评标专家占比，分析中标人与评标专家的紧密度
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult TENDER_EXPERT_WIN(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsTenderService.TENDER_EXPERT_WIN(search);
            return JResult(r);
        }
        #endregion

        #region 中标参与度分析（投标人）
        /// <summary>
        /// 中标参与度分析（投标人）
        /// 指投标人中标时一起参与投标的企业排行情况，分析中标人与关联投标人的紧密度 
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult TENDER_OTHER_WIN(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsTenderService.TENDER_OTHER_WIN(search);
            return JResult(r);
        }
        #endregion

        #region 共同参与投标分析
        /// <summary>
        /// TENDER_INFO,TENDER_OTHER
        /// 共同参与投标分析
        /// 指投标人与投标人之间共同参与投标项目企业排行情况，分析投标企业间的紧密度
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult TENDER_INFO_TENDER_OTHER(StatisticsBidderSearchModel search)
        {
            var r = Jd.StatisticsTenderService.TENDER_INFO_TENDER_OTHER(search);
            return JResult(r);
        }
        #endregion


        #endregion
    }
}