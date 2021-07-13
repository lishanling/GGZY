using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYFW.DbEntity;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdTAfcProjectController
    {
        #region 注册用户项目报建

        public ActionResult ProjectReportBuilder(T_AFC_PROJECT model, SearchCondition search)
        {
            var r = Jd.TAfcProjectService.ProjectReportBuild(model, search);
            return JResult(r);
        }
        public ActionResult ProjectReportBuildDetail(string mid)
        {
            var r = Jd.TAfcProjectService.ProjectReportBuildDetail(mid);
            return JResult(r);
        }
        public ActionResult ProjectReportBuildDetailByCode(string tenderProjectCode)
        {
            var r = Jd.TAfcProjectService.ProjectReportBuildDetailByCode(tenderProjectCode);
            return JResult(r);
        }
        /// <summary>
        /// 报建项目删除
        /// </summary>
        /// <param name="mid"></param>
        /// <returns></returns>
        public ActionResult DeleteAfcProject(string mid)
        {
            var r = Jd.TAfcProjectService.DeleteAfcProject(mid);
            return JResult(r);
        }

        

        /// <summary>
        /// 预览
        /// </summary>
        /// <param name="entity">实时预览，为保存到数据库</param>
        /// <returns></returns>
        public ActionResult PreviewAfcProject(TAfcProjectModel entity)
        {
            var r = string.IsNullOrWhiteSpace(entity.MID) ? 
                Jd.TAfcProjectService.AfcProjectStream(entity) : 
                Jd.TAfcProjectService.PreviewAfcProject(entity.MID);
            return JResult(r);
        }

        /// <summary>
        /// 【项目报建】撤回[初建/待审查]
        /// </summary>
        /// <param name="mid">实时预览，为保存到数据库</param>
        /// <returns></returns>
        public ActionResult Revoke(string mid)
        {
            var r = Jd.TAfcProjectService.Revoke(mid);
            return JResult(r);
        }
        /// <summary>
        /// 使用投资在线平台项目代码绑定报建信息到本账号(住建)
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CheckProjectFromTZZXPT(TAfcProjectModel model)
        {
            var r = Jd.TAfcProjectService.CheckProjectFromTZZXPT(model);
            return JResult(r);
        }
        /// <summary>
        /// 使用投资在线平台项目代码绑定报建信息到本账号(住建)
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult BindProjectFromTZZXPT(TAfcProjectModel model)
        {
            var r = Jd.TAfcProjectService.BindProjectFromTZZXPT(model);
            return JResult(r);
        }
        /// <summary>
        /// 解除绑定
        /// </summary>
        /// <param name="mid"></param>
        /// <returns></returns>
        public ActionResult UnBindProjectOfTZZXPT(string mid)
        {
            var r = Jd.TAfcProjectService.UnBindProjectOfTZZXPT(mid);
            return JResult(r);
        }
        /// <summary>
        /// 通过统一代码查询项目信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CheckTzCodeFromTZZXPT(TAfcProjectModel model)
        {
            var r = Jd.TAfcProjectService.CheckTzCodeFromTZZXPT(model);
            return JResult(r);
        }
        /// <summary>
        /// 项目报建流程状态
        /// </summary>
        /// <param name="mid"></param>
        /// <returns></returns>
        public ActionResult ProjectReportBuildProcess(string mid)
        {
            var r = Jd.TAfcLogService.ProjectReportBuildProcess(mid,
                id => Url.RouteUrl("FileContent", new { id = id, Pt = "Jd", fType = "Sys" }));
            return JResult(r);
        }
        /// <summary>
        /// 项目报建流程状态
        /// </summary>
        /// <param name="jdTenderProjectCode"></param>
        /// <returns></returns>
        public ActionResult GetAFC_Logs(string jdTenderProjectCode)
        {
            var r = Jd.TAfcLogService.GetAFC_Logs(jdTenderProjectCode);
            return JResult(r);
        }

        /// <summary>
        /// 项目报建
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Save(TAfcProjectModel model)
        {
            GeneralResult r;
            r = string.IsNullOrWhiteSpace(model.MID) ? Jd.TAfcProjectService.ProjectReportBuild(model) : Jd.TAfcProjectService.ProjectReportReBuild(model);
            return JResult(r);
        }
        /// <summary>
        /// 获取审查单位接口
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult FindSpDepartment(T_USER_DEPARTMENT model, SearchCondition search)
        {
            model.ISBJ = 1;
            var r = Jd.TUserDepartmentService.FindSpDepartment(model, search);
            return JResult(r);
        }
        /// <summary>
        /// 项目报建变更
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Change(TAfcProjectModel model)
        {
            var r = Jd.TAfcProjectService.ProjectReportBuildChange(model);
            return JResult(r);
        }
        /// <summary>
        /// 设置重新推送报建信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult ReSendAfcProject(TAfcProjectModel model)
        {
            var r = Jd.TTuisongService.ReSendAfcProject(model);
            return JResult(r);
        }

        #endregion

        #region 审批单位
        /// <summary>
        /// 报建列表 type 2 待办 3 已办
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult ProjectReportBuild4Approval(TAfcProjectModel model, SearchCondition search)
        {
            var r = Jd.TAfcProjectService.ProjectReportBuild4Approval(model, search);
            return JResult(r);
        } 
        /// <summary>
        /// 报建列表 type 2 待办 3 已办
        /// </summary>
        /// <returns></returns>
        public ActionResult ProjectReportBuild4ApprovalCount()
        {
            var r = Jd.TAfcProjectService.ProjectReportBuild4ApprovalCount();
            return JResult(r);
        }
        /// <summary>
        /// 报建作废
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Voided(TAfcProjectModel model)
        {
            var r = Jd.TAfcProjectService.ProjectReportBuildVoided(model);
            return JResult(r);
        }
        /// <summary>
        /// 审批
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Approval(TAfcProjectModel model)
        {
            var r = Jd.TAfcProjectService.ProjectReportBuildApproval(model);
            return JResult(r);
        }
        /// <summary>
        /// 变更审批
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult ChangeApproval(TAfcProjectModel model)
        {
            var r = Jd.TAfcProjectService.ProjectReportBuildChangeApproval(model);
            return JResult(r);
        }


        #region 交易数据

        public ActionResult PageList(MV_TJ_ALLCREATE_XZJD model, SearchCondition search)
        {
            var r = Fw.MvTjAllcreateXzjdService.PageDataTable(model, search);
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
            var r = Fw.MvTjAllcreateXzjdService.GetProcess(model);
            return JResult(r);
        }

        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 项目进场 
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public ActionResult GCJS_XMJC(string projectCode)
        {
            var r = Fw.MvTjAllcreateXzjdService.GCJS_XMJC_ProjectInfo(projectCode, ids => Fw.CommonService.Attachments(ids, "Att", (type, id) => CommonAttachmentBuilder(id, fType: type)));
            return JResult(r);
        }


        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 招标公告 
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public ActionResult GCJS_ZBGG(string projectCode)
        {
            var r = Fw.MvTjAllcreateXzjdService.GCJS_ZBGG(projectCode, ids => Fw.CommonService.Attachments(ids, "Att", (type, id) => CommonAttachmentBuilder(id, fType: type)));
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
        /// <returns></returns>
        public ActionResult GCJS_KB(string projectCode)
        {
            var r = Fw.MvTjAllcreateXzjdService.GCJS_KB(projectCode, "HT");
            return JResult(r);
        }


        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 评标
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public ActionResult GCJS_PB(string projectCode)
        {
            var r = Fw.MvTjAllcreateXzjdService.GCJS_PB(projectCode, "HT");
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

        #region 矿业权-探矿
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
        /// 标前详情
        /// </summary>
        /// <param name="tenderProjectCode"></param>
        /// <returns></returns>
        public ActionResult BeforeDetail(string tenderProjectCode)
        {
            var r = Jd.TAfcFixedService.BeforeDetail(tenderProjectCode);
            return JResult(r);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tenderProjectCode"></param>
        /// <returns></returns>
        public ActionResult AfterDetail(string tenderProjectCode)
        {
            var r = Jd.TAfcFixedService.AfterDetail(tenderProjectCode);
            return JResult(r);
        }
        #endregion
        #endregion


        #region 【报建审查】消息提醒方法
        /// <summary>
        /// 新报建项目消息
        /// </summary>
        /// <returns></returns>
        public ActionResult ProjectNewCount()
        {
            var c = Jd.TAfcProjectService.ProjectNewCount();
            return JResult(new {Count = c});
        }

        /// <summary>
        /// 旧报建项目消息（快过期提醒：超过第二个工作日的前15时，即下午3点）==>获取将超期数据统计（提交日期大于前两个工作日，小于前一个工作日）
        /// </summary>
        /// <returns></returns>
        public ActionResult ProjectExpiringSoon()
        {
            var c = Jd.TAfcProjectService.ProjectExpiringSoon();
            return JResult(new { Count = c });
        }

        /// <summary>
        /// 过期报建项目消息（过期提醒：超过两个工作日）==>DATA_TIMESTAMP 比2个工作日前的日期更早
        /// </summary>
        /// <returns></returns>
        public ActionResult ProjectExpired()
        {
            var c = Jd.TAfcProjectService.ProjectExpired();
            return JResult(new { Count = c });
        }
        #endregion


        #region 监督首页

        public ActionResult GetBJ_Data(MonitorHomePageModel model)
        {
            var r = Jd.TAfcProjectService.GetBJ_Data(model);
            return JResult(r);
        }

        #endregion

        #region 报建审查
        /// <summary>
        /// 数量统计
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult ProjectCount(TAfcProjectStatisticsModel model)
        {
            var r = Jd.TAfcProjectService.ProjectCount(model);
            return JResult(r);
        }
        /// <summary>
        /// 根据类型统计
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult ProjectGroupByType(TAfcProjectStatisticsModel model)
        {
            var r = Jd.TAfcProjectService.ProjectGroupByType(model);
            return JResult(r);
        }
        /// <summary>
        /// 根据地区统计
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult ProjectGroupByRegion(TAfcProjectStatisticsModel model)
        {
            var r = Jd.TAfcProjectService.ProjectGroupByRegion(model);
            return JResult(r);
        }
        #endregion

    }
}