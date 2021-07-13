using System.Web.Mvc;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Portal.Controllers
{
    /// <summary>
    /// 处长门户 项目监督
    /// </summary>
    public class ProjectSupervisionController : BaseController
    {
        #region 行业部门
        /// <summary>
        ///  处长门户 项目监督 类型
        /// </summary>
        /// <returns></returns>
        public ActionResult ProjectSupervisionHyType()
        {
            var r = Jd.ProjectSupervisionService.ProjectSupervisionHyType();
            return JResult(r);
        }
        /// <summary>
        ///  处长门户 项目监督 列表接口
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult HyProjectSupervisions(ProjectSupervisionRequestModel model)
        {
            var r = Jd.ProjectSupervisionService.HyProjectSupervisions(model);
            return JResult(r);
        }
        /// <summary>
        /// 处长门户 项目监督  项目处理信息汇总
        /// </summary>
        /// <returns></returns>
        public ActionResult HyProjectSupervisionCount()
        {
            var r = Jd.ProjectSupervisionService.HyProjectSupervisionCount();
            return JResult(r);
        }
        /// <summary>
        /// 处长门户 项目监督  项目交易数据统计
        /// </summary>
        /// <returns></returns>
        public ActionResult ProjectSupervisionTradeCount()
        {
            var r = Jd.ProjectSupervisionService.ProjectSupervisionTradeCount();
            return JResult(r);
        }
        /// <summary>
        /// 处长门户 项目监督 标后监管系统
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult HyAfterSupervisions(SearchCondition search)
        {
            var r = Jd.ProjectSupervisionService.HyAfterSupervisions(search);
            return JResult(r);
        }
        /// <summary>
        /// 处长门户 项目监督 短信通知汇总
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult HySmsPageList(SearchCondition search)
        {
            var r = Jd.TSmsLogService.HySmsPageList(search);
            return JResult(r);
        }


        #region 详情

        public ActionResult HyProjectDetail(ProjectSupervisionResponseHyModel model)
        {
            var r = Jd.ProjectSupervisionService.HyProjectDetail(model);
            return JResult(r);
        }

        public ActionResult Sxjd(ProjectSupervisionResponseHyModel model, SearchCondition search)
        {
            var r = Jd.ProjectSupervisionService.Sxjd(model, search);
            return JResult(r);
        }
        public ActionResult IllegalBigData(ProjectSupervisionResponseHyModel model, SearchCondition search)
        {
            var r = Jd.ProjectSupervisionService.IllegalBigData(model, search);
            return JResult(r);
        }
        public ActionResult TsJbYy(ProjectSupervisionResponseHyModel model, SearchCondition search)
        {
            var r = Jd.ProjectSupervisionService.TsJbYy(model, search);
            return JResult(r);
        }
        public ActionResult OtherInfoTips(string tenderProjectCode, SearchCondition search)
        {
            var r = Jd.ProjectSupervisionService.OtherInfoTips(tenderProjectCode, search);
            return JResult(r);
        }

        public ActionResult HandleItems(ProjectSupervisionResponseHyModel model, SearchCondition search)
        {
            var r = Jd.ProjectSupervisionService.HandleItems(model, search);
            return JResult(r);
        }

        #endregion
        #endregion

        #region 纪委
        public ActionResult JwProjectSupervisions(ProjectSupervisionRequestModel model)
        {
            var r = Jd.ProjectSupervisionService.JwProjectSupervisions(model);
            return JResult(r);
        }


        /// <summary>
        /// 项目处理信息汇总
        /// </summary>
        /// <returns></returns>
        public ActionResult JwProjectSupervisionCount()
        {
            var r = Jd.ProjectSupervisionService.JwProjectSupervisionCount();
            return JResult(r);
        }

        /// <summary>
        /// 处长门户 项目监督 标后监管系统
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult JwAfterSupervisions(SearchCondition search)
        {
            var r = Jd.ProjectSupervisionService.JwAfterSupervisions(search);
            return JResult(r);
        }

        /// <summary>
        /// 处长门户 项目监督 短信通知汇总
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult JwSmsPageList(SearchCondition search)
        {
            var r = Jd.TSmsLogService.JwSmsPageList(search);
            return JResult(r);
        }

        #region 详情

        /// <summary>
        /// 处长门户 项目监督 项目信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult JwProjectDetail(ProjectSupervisionResponseHyModel model)
        {
            var r = Jd.ProjectSupervisionService.JwProjectDetail(model);
            return JResult(r);
        }
        /// <summary>
        /// 处长门户 项目监督 监督再监督
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult JdzJd(ProjectSupervisionResponseHyModel model, SearchCondition search)
        {
            var r = Jd.ProjectSupervisionService.JdzJd(model, search);
            return JResult(r);
        }

        /// <summary>
        /// 处长门户 项目监督 行业部门移送的公职人员信息
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult TransferStaff(ProjectSupervisionResponseHyModel model, SearchCondition search)
        {
            var r = Jd.ProjectSupervisionService.TransferStaff(model, search);
            return JResult(r);
        }
        /// <summary>
        /// 处长门户 项目监督 12388纪委监委平台举报信息
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult Report12388(ProjectSupervisionResponseHyModel model, SearchCondition search)
        {
            var r = Jd.ProjectSupervisionService.Report12388(model, search);
            return JResult(r);
        }
        /// <summary>
        /// 处长门户 项目监督 处理事项
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult JwHandleItems(ProjectSupervisionResponseHyModel model, SearchCondition search)
        {
            var r = Jd.ProjectSupervisionService.JwHandleItems(model, search);
            return JResult(r);
        }
        #region 督查对象接口 督查 变更 详情

        /// <summary>
        /// 招标计划登记 招标备案 投诉处理 监督点处理 督查细项
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult SuperviseItem(TSuperviseModel model)
        {
            var r = Jd.TSuperviseResultService.SuperviseItem(model);
            return JResult(r);
        }
        /// <summary>
        /// 督查
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Supervise(TSuperviseModel model)
        {
            var r = Jd.TSuperviseResultService.Supervise(model);
            return JResult(r);
        }
        /// <summary>
        /// 督查对象接口
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult FindJwChildrenDepartment(T_USER_DEPARTMENT model, SearchCondition search)
        {
            var r = Jd.TUserDepartmentService.FindJwChildrenDepId(model, search);
            return JResult(r);
        }
        /// <summary>
        /// 检查点-红灯变更为绿灯
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult SuperviseChange(TSuperviseResultLogModel model)
        {
            var r = Jd.TSuperviseResultService.SuperviseChange(model);
            return JResult(r);
        }


        /// <summary>
        /// 监察详情
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult SuperviseDetail(TSuperviseResultModel model)
        {
            var r = Jd.TSuperviseResultService.SuperviseDetail(model);
            return JResult(r);
        }
        #endregion


        #endregion

        #endregion

        #region 公安

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult GaProjectSupervisions(ProjectSupervisionRequestModel model)
        {
            var r = Jd.ProjectSupervisionService.GaProjectSupervisions(model);
            return JResult(r);
        }

        /// <summary>
        /// 项目处理信息汇总
        /// </summary>
        /// <returns></returns>
        public ActionResult GaProjectSupervisionCount()
        {
            var r = Jd.ProjectSupervisionService.GaProjectSupervisionCount();
            return JResult(r);
        }

        /// <summary>
        /// 处长门户 项目监督 标后监管系统
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult GaAfterSupervisions(SearchCondition search)
        {
            var r = Jd.ProjectSupervisionService.GaAfterSupervisions(search);
            return JResult(r);
        }

        /// <summary>
        /// 处长门户 项目监督 短信通知汇总
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult GaSmsPageList(SearchCondition search)
        {
            var r = Jd.TSmsLogService.GaSmsPageList(search);
            return JResult(r);
        }

        #region 公安 详情

        #region 行业监督部门移送的信息
        /// <summary>
        /// 行业监督部门移送的信息
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult DepTransRecord(SearchCondition search)
        {
            var r = Jd.ProjectSupervisionService.DepTransRecord(search);
            return JResult(r);
        }

        #endregion

        #region 0591-87094240公安平台举报信息

        /// <summary>
        /// 0591-87094240公安平台举报信息
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult PolicePlatformReport(SearchCondition search)
        {
            var r = Jd.ProjectSupervisionService.PolicePlatformReport(search);
            return JResult(r);
        }

        #endregion

        #region 公安其他渠道掌握的信息

        /// <summary>
        /// 公安其他渠道掌握的信息
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult PoliceOtherChannelInfo(SearchCondition search)
        {
            var r = Jd.ProjectSupervisionService.PoliceOtherChannelInfo(search);
            return JResult(r);
        }

        #endregion

        #region 项目监督 纪委监委 处理项目及事项 详情 处理事项
        /// <summary>
        /// 项目监督 纪委监委 处理项目及事项 详情 处理事项
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult GaHandleItems(SearchCondition search)
        {
            var r = Jd.ProjectSupervisionService.GaHandleItems(search);
            return JResult(r);
        }
        #endregion

        #region 项目监督 公安 处理项目及事项 项目信息
        /// <summary>
        /// 项目监督 公安 处理项目及事项 项目信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult GaProjectDetail(ProjectSupervisionResponseHyModel model)
        {
            var r = Jd.ProjectSupervisionService.GaProjectDetail(model);
            return JResult(r);
        }
        #endregion

        #endregion
        #endregion


        #region 闽政通

        #region 行业主管
        /// <summary>
        /// 项目监督 行业主管 待处理 已处理 超期未处理 统计
        /// </summary>
        /// <returns></returns>
        public ActionResult MztHyProjectSupervisionCount()
        {
            var r = Jd.ProjectSupervisionService.MztHyProjectSupervisionCount();
            return JResult(r);
        }


        /// <summary>
        /// 监督点信息
        /// </summary>
        /// <param name="m_id"></param>
        /// <returns></returns>
        public ActionResult WarnResultDetail(string m_id)
        {
            var r = Fw.WarnResultService.WarnResultDetail(m_id);
            return JResult(r);
        }
        #endregion


        #region 纪委监委

        /// <summary>
        /// 项目监督 纪委监委 处理项目及事项 列表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult MztJwProjectSupervisions(ProjectSupervisionRequestModel model)
        {

            var r = Jd.ProjectSupervisionService.MztJwProjectSupervisions(model);
            return JResult(r);
        }

        /// <summary>
        /// 闽政通 项目监督 待处理事项 已处理事项
        /// </summary>
        /// <returns></returns>
        public ActionResult MztJwProjectSupervisionCount()
        {
            var r = Jd.ProjectSupervisionService.MztJwProjectSupervisionCount();
            return JResult(r);
        }

        /// <summary>
        /// 闽政通 项目监督 待处理事项 已处理事项
        /// </summary>
        /// <returns></returns>
        public ActionResult TransRecordDetail(string id)
        {
            var r = Jd.JcTransRecordService.TransRecordDetail(id);
            return JResult(r);
        }
        #endregion

        #endregion
    }
}