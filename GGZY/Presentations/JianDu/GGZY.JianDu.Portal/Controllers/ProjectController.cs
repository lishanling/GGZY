using System;
using System.Web.Mvc;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using GGZYFW.DbEntity;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Portal.Controllers
{
    [AllowAnonymous]
    public class ProjectController : BaseController
    {

        #region 监督门户-项目信息-类型

        public ActionResult JdPortalProjectTypeTree(SearchCondition search)
        {
            var r = Fw.MvTjAllcreateXzjdService.JdPortalProjectTypeTree(search);
            return JResult(r);
        }

        #endregion
        /// <summary>
        /// 热点项目
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult HotPageList(T_PROJECT_BROWSE model, SearchCondition search)
        {
            //MV_TJ_ALLCREATE_XZJD
            var r = Jd.TProjectBrowseService.PageTable(model, search);
            return JResult(r);
        }

        public ActionResult PageList(MV_TJ_ALLCREATE_XZJD model, SearchCondition search)
        {
            var r = Fw.MvTjAllcreateXzjdService.PageDataTable(model, search);
            return JResult(r);
        }

        /// <summary>
        /// 今日项目情况
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult DailyStatDetail(MV_TJ_ALLCREATE_XZJD model, SearchCondition search)
        {
            var r = Fw.MvTjAllcreateXzjdService.DailyStatDetail(model, search);
            return JResult(r);
        }


        /// <summary>
        /// 项目走势
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult StatTrend(MV_TJ_ALLCREATE_XZJD model, SearchCondition search)
        {
            var r = Fw.MvTjAllcreateXzjdService.StatTrend(model, search);
            return JResult(r);
        }

        #region 工程建设详情页

        /// <summary>
        /// 项目基础信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult BaseInfo(MV_TJ_ALLCREATE_XZJD model)
        {
            var r = Fw.MvTjAllcreateXzjdService.ProjectBaseInfo(model);
            return JResult(r);
        }

        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 项目进场 
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public ActionResult GCJS_XMJC(string projectCode)
        {//todo 附件处理
            var r = Fw.MvTjAllcreateXzjdService.GCJS_XMJC_ProjectInfo(projectCode);
            return JResult(r);
        }


        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 招标公告 
        /// </summary>
        /// <param name="projectCode"></param>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        public ActionResult GCJS_ZBGG(string projectCode, string sourceType)
        {
            var r = Fw.MvTjAllcreateXzjdService.GCJS_ZBGG(projectCode);
            return JResult(r);
        }

        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 投标报名
        /// </summary>
        /// <param name="projectCode"></param>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        public ActionResult GCJS_TBBM(string projectCode, string sourceType)
        {
            var r = Fw.MvTjAllcreateXzjdService.GCJS_TBBM(projectCode, sourceType);
            return JResult(r);
        }
        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 开标 投标人特征码|开标记录 
        /// </summary>
        /// <param name="projectCode"></param>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        public ActionResult GCJS_KB(string projectCode, string sourceType)
        {
            var r = Fw.MvTjAllcreateXzjdService.GCJS_KB(projectCode, sourceType);
            return JResult(r);
        }


        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 评标
        /// </summary>
        /// <param name="projectCode"></param>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        public ActionResult GCJS_PB(string projectCode, string sourceType)
        {
            var r = Fw.MvTjAllcreateXzjdService.GCJS_PB(projectCode, sourceType);
            return JResult(r);
        }

        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 结果公告
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public ActionResult GCJS_JGGG(string projectCode)
        {
            var r = Fw.MvTjAllcreateXzjdService.GCJS_JGGG(projectCode);
            return JResult(r);
        }
        #endregion

        #region 政府采购

        /// <summary>
        /// 监督平台门户 项目监督信息 政府采购 项目进场
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public ActionResult ZFCG_XMJC(string projectCode)
        {
            var r = Fw.MvTjAllcreateXzjdService.ZFCG_XMJC(projectCode);
            return JResult(r);
        }
        /// <summary>
        /// 监督平台门户 项目监督信息 政府采购 采购公告
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public ActionResult ZFCG_CGGG(string projectCode)
        {
            var r = Fw.MvTjAllcreateXzjdService.ZFCG_CGGG(projectCode);
            return JResult(r);
        }

        /// <summary>
        /// 监督平台门户 项目监督信息 政府采购 结果公告
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public ActionResult ZFCG_JGGG(string projectCode)
        {
            var r = Fw.MvTjAllcreateXzjdService.ZFCG_JGGG(projectCode);
            return JResult(r);
        }
        #endregion


        #region 土地使用权

        /// <summary>
        /// 监督平台门户 项目监督信息 土地使用权 成交行为信息
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public ActionResult TDSYQ_CJXWBG(string projectCode)
        {
            var r = Fw.MvTjAllcreateXzjdService.TDSYQ_CJXWBG(projectCode);
            return JResult(r);
        }

        /// <summary>
        /// 监督平台门户 项目监督信息 土地使用权 成交宗地信息
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public ActionResult TDSYQ_CJZDS(string projectCode)
        {
            var r = Fw.MvTjAllcreateXzjdService.TDSYQ_CJZDS(projectCode);
            return JResult(r);
        }
        #endregion


        #region 矿业权
        /// <summary>
        /// 监督平台门户 项目监督信息 土地使用权  招拍挂出让公告  
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public ActionResult KYQ_ZPGCRGG(string projectCode)
        {
            var r = Fw.MvTjAllcreateXzjdService.KYQ_ZPGCRGG(projectCode);
            return JResult(r);
        }
        /// <summary>
        /// 监督平台门户 项目监督信息 土地使用权  结果公示  
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public ActionResult KYQ_JGGS(string projectCode)
        {
            var r = Fw.MvTjAllcreateXzjdService.KYQ_JGGS(projectCode);
            return JResult(r);
        }
        #endregion


        #region 矿业权
        /// <summary>
        /// 监督平台门户 项目监督信息 土地使用权  探矿矿权交易电子挂牌  
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public ActionResult KYQ_TK_CRGG(string projectCode)
        {
            var r = Fw.MvTjAllcreateXzjdService.KYQ_TK_CRGG(projectCode);
            return JResult(r);
        }
        /// <summary>
        /// 监督平台门户 项目监督信息 土地使用权  探矿矿权交易结果公示  
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public ActionResult KYQ_TK_JGGS(string projectCode)
        {
            var r = Fw.MvTjAllcreateXzjdService.KYQ_TK_JGGS(projectCode);
            return JResult(r);
        }
        #endregion

        #region 国有产权 实物

        /// <summary>
        /// 监督平台门户 项目监督信息 国有产权 实物   挂牌披露  挂牌披露信息(实物资产类)
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public ActionResult GYCQ_SW_GPPL(string projectCode)
        {
            var r = Fw.MvTjAllcreateXzjdService.GYCQ_SW_GPPL(projectCode);
            return JResult(r);
        }
        /// <summary>
        /// 监督平台门户 项目监督信息 国有产权 实物   交易结果  交易结果信息(实物资产类)
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public ActionResult GYCQ_SW_JYJG(string projectCode)
        {
            var r = Fw.MvTjAllcreateXzjdService.GYCQ_SW_JYJG(projectCode);
            return JResult(r);
        }
        #endregion

        #region 国有产权 股权

        /// <summary>
        /// 监督平台门户 项目监督信息 国有产权 股权   挂牌披露  挂牌披露信息(股权类)
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public ActionResult GYCQ_GQ_GPPL(string projectCode)
        {
            var r = Fw.MvTjAllcreateXzjdService.GYCQ_GQ_GPPL(projectCode);
            return JResult(r);
        }
        /// <summary>
        /// 监督平台门户 项目监督信息 国有产权 股权    交易结果  交易结果信息(股权类)
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public ActionResult GYCQ_GQ_JYJG(string projectCode)
        {
            var r = Fw.MvTjAllcreateXzjdService.GYCQ_GQ_JYJG(projectCode);
            return JResult(r);
        }
        #endregion

        /// <summary>
        /// 站点选择插件（招标项目）
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult TenderProjectPageTable(GGZYJD.DbEntity.TENDER_PROJECT model, SearchCondition search)
        {
            var r = Jd.TenderProjectService.PageTable(model, search);
            return JResult(r);
        }

        #region
        /// <summary>
        /// 闽政通-首页-交易信息统计
        /// 招标公告项目
        /// 开评标项目
        /// 中标金额
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult TradeInfoStat(MV_TJ_ALLCREATE_XZJD model, SearchCondition search)
        {
            var r = Fw.MvTjAllcreateXzjdService.TradeInfoStat(model, search);
            return JResult(r);
        }
        public ActionResult TenderAnnQuaInqueryAnnPageDataTable(MV_TJ_ALLCREATE_XZJD model, SearchCondition search)
        {
            var r = Fw.MvTjAllcreateXzjdService.TenderAnnQuaInqueryAnnPageDataTable(model, search);
            return JResult(r);
        }
        public ActionResult ResultPageList(MV_TJ_ALLRESULT_XZJD model, SearchCondition search)
        {
            var r = Fw.MvTjAllresultXzjdService.PageDataTable(model, search);
            return JResult(r);
        }
        #endregion
    }
}