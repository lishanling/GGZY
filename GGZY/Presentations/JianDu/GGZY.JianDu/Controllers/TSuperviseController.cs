using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZY.Services.JianDu;
using GGZYFW.DbEntity;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class TSuperviseController : BaseController
    {
        #region 首页

        #region 首页 待办事项统计

        public ActionResult DaiBanCount(JDHomePageModel model, SearchCondition search)
        {
            var afcProject = Jd.TSuperviseResultService.DaiBanCount(model, search);
            return JResult(afcProject);
        }

        #endregion

        #region 首页 督查情况 总体统计

        public ActionResult DuChaCount(JDHomePageModel model, SearchCondition search)
        {
            var afcProject = Jd.TSuperviseResultService.DuChaCount(model, search);
            return JResult(afcProject);
        }

        #endregion

        #region 首页 督查事项类型分布统计

        public ActionResult DuChaProject(JDHomePageModel model, SearchCondition search)
        {
            var afcProject = Jd.TSuperviseResultService.DuChaProject(model, search);
            return JResult(afcProject);
        }

        #endregion

        #region 首页 督查归属地分布统计

        public ActionResult DuChaRegion(JDHomePageModel model, SearchCondition search)
        {
            var afcProject = Jd.TSuperviseResultService.DuChaRegion(model, search);
            return JResult(afcProject);
        }

        #endregion

        #region 首页 上级督查情况 总体统计
        //[Obsolete]
        public ActionResult UpDuChaCount(JDHomePageModel model, SearchCondition search)
        {
            var afcProject = Jd.TSuperviseResultService.UpDuChaCount(model, search);
            return JResult(afcProject);
        }

        #endregion

        #region 首页 上级督查情况 总体统计
        //[Obsolete]
        public ActionResult UpDuChaProject(JDHomePageModel model, SearchCondition search)
        {
            var afcProject = Jd.TSuperviseResultService.UpDuChaProject(model, search);
            return JResult(afcProject);
        }

        #endregion

        #region 首页 智能检查点

        public ActionResult JCCount(JDHomePageModel model, SearchCondition search)
        {
            var afcProject = Jd.TSuperviseResultService.JCCount(model, search);
            return JResult(afcProject);
        }

        #endregion

        #region 首页 上各地区红灯预警总数分布统计

        public ActionResult RedLedCount(JDHomePageModel model, SearchCondition search)
        {
            var afcProject = Jd.TSuperviseResultService.RedLedCount(model, search);
            return JResult(afcProject);
        }

        #endregion

        #region 首页 时限监督类型分布统计

        public ActionResult TimeProjectCount(JDHomePageModel model, SearchCondition search)
        {
            var afcProject = Jd.TSuperviseResultService.TimeProjectCount(model, search);
            return JResult(afcProject);
        }

        #endregion

        #region 首页 异常项目统计

        public ActionResult RedProjectCount(JDHomePageModel model, SearchCondition search)
        {
            var afcProject = Jd.TSuperviseResultService.RedProjectCount(model, search);
            return JResult(afcProject);
        }

        #endregion

        #region 首页 各地区监督点异常项目总数

        public ActionResult AreaRedProjectCount(JDHomePageModel model, SearchCondition search)
        {
            var afcProject = Jd.TSuperviseResultService.AreaRedProjectCount(model, search);
            return JResult(afcProject);
        }

        #endregion

        #region 首页 异常项目类型分布统计
        public ActionResult RedProject(JDHomePageModel model, SearchCondition search)
        {
            var afcProject = Jd.TSuperviseResultService.RedProject(model, search);
            return JResult(afcProject);
        }

        #endregion

        #region 首页  移送事项统计
        public ActionResult SendProjectCount(JDHomePageModel model, SearchCondition search)
        {
            var afcProject = Jd.TSuperviseResultService.SendProjectCount(model, search);
            return JResult(afcProject);
        }
        #endregion

        #region 首页  移送事项类型统计
        public ActionResult SendProjectType(JDHomePageModel model, SearchCondition search)
        {
            var afcProject = Jd.TSuperviseResultService.SendProjectType(model, search);
            return JResult(afcProject);
        }
        #endregion

        #region 首页 移送事项地区分布统计
        public ActionResult SendProjectArea(JDHomePageModel model, SearchCondition search)
        {
            var afcProject = Jd.TSuperviseResultService.SendProjectArea(model, search);
            return JResult(afcProject);
        }

        #endregion

        #region  首页 处罚记录数统计
        public ActionResult CFRecord(JDHomePageModel model, SearchCondition search)
        {
            var afcProject = Jd.TSuperviseResultService.CFRecord(model, search);
            return JResult(afcProject);
        }
        #endregion

        #region 首页  处罚记录各地区分布
        public ActionResult CFRecordCount(JDHomePageModel model, SearchCondition search)
        {
            var afcProject = Jd.TSuperviseResultService.CFRecordCount(model, search);
            return JResult(afcProject);
        }

        #endregion


        #endregion

        #region 智能监察


        #region 招标计划

        public ActionResult AfcCount(TSuperviseResultSearchModel model)
        {
            var afcProject = Jd.TSuperviseResultService.AfcProjectSuperviseCount(model);
            return JResult(afcProject);
        }

        public ActionResult AfcList(TSuperviseResultSearchModel model)
        {
            var page = Jd.TSuperviseResultService.AfcProjectSuperviseList(model);
            return JResult(page);
        }
        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult AfcExport(TSuperviseResultSearchModel model)
        {
            var page = Jd.TSuperviseResultService.AfcExport(model);
            return JResult(page);
        }
        public ActionResult AfcDetail(TSuperviseResultModel model)
        {
            var r = Jd.TSuperviseResultService.AfcProjectSuperviseDetail(model);
            return JResult(r);
        }

        public ActionResult AfcSupervise(TSuperviseModel model)
        {
            var r = Jd.TSuperviseResultService.AfcSupervise(model);
            return JResult(r);
        }

        /// <summary>
        /// 招标计划-检查点-红灯变更为绿灯
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult AfcChange(TSuperviseResultLogModel model)
        {
            var r = Jd.TSuperviseResultService.SuperviseChange(model);
            return JResult(r);
        }

        #endregion

        #region 招标项目
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult TenderProjectSupervise(TSuperviseModel model)
        {
            var r = Jd.TSuperviseResultService.TenderProjectSupervise(model);
            return JResult(r);
        }

        #endregion

        #region 投诉处理

        public ActionResult ComplaintCount(TSuperviseResultSearchModel model)
        {
            var afcProject = Jd.TSuperviseResultService.ZxtsSuperviseCount(model);
            return JResult(afcProject);
        }

        public ActionResult ComplaintList(TSuperviseResultSearchModel model)
        {
            var page = Jd.TSuperviseResultService.ZxtsSuperviseList(model);
            return JResult(page);
        }
        public ActionResult ZxtsExport(TSuperviseResultSearchModel model)
        {
            var page = Jd.TSuperviseResultService.ZxtsExport(model);
            return JResult(page);
        }

        public ActionResult ComplaintDetail(TSuperviseResultModel model)
        {
            var r = Jd.TSuperviseResultService.ZxtsSuperviseDetail(model);
            return JResult(r);
        }

        public ActionResult ComplaintSupervise(TSuperviseModel model)
        {
            var r = Jd.TSuperviseResultService.ZxtsSupervise(model);
            return JResult(r);
        }
        /// <summary>
        /// 招标计划-检查点-红灯变更为绿灯
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>ComplaintDetail
        public ActionResult ComplaintChange(TSuperviseResultLogModel model)
        {
            var r = Jd.TSuperviseResultService.SuperviseChange(model);
            return JResult(r);
        }

        #endregion

        #region 招标备案

        public ActionResult ReviewCount(TSuperviseResultSearchModel model)
        {
            var afcProject = Jd.TSuperviseResultService.ReviewSuperviseCount(model);
            return JResult(afcProject);
        }

        public ActionResult ReviewList(TSuperviseResultSearchModel model)
        {
            var page = Jd.TSuperviseResultService.ReviewSuperviseList(model);
            return JResult(page);
        }
        /// <summary>
        /// 招标备案-导出
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult ZbbaExport(TSuperviseResultSearchModel model)
        {
            var page = Jd.TSuperviseResultService.ZbbaExport(model);
            return JResult(page);
        }

        public ActionResult ReviewDetail(TSuperviseResultModel model)
        {
            var r = Jd.TSuperviseResultService.ReviewSuperviseDetail(model);
            return JResult(r);
        }

        public ActionResult ReviewSupervise(TSuperviseModel model)
        {
            var r = Jd.TSuperviseResultService.ReviewSupervise(model);
            return JResult(r);
        }
        /// <summary>
        /// 招标计划-检查点-红灯变更为绿灯
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult ReviewChange(TSuperviseResultLogModel model)
        {
            var r = Jd.TSuperviseResultService.SuperviseChange(model);
            return JResult(r);
        }

        #endregion

        #region 监督点

        public ActionResult PointCount(TSuperviseResultSearchModel model)
        {
            var afcProject = Jd.TSuperviseResultService.PointSuperviseCount(model);
            return JResult(afcProject);
        }

        public ActionResult PointList(TSuperviseResultSearchModel model)
        {
            var page = Jd.TSuperviseResultService.PointSuperviseList(model);
            return JResult(page);
        }
        /// <summary>
        /// 监督点处理-导出
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult PointExport(TSuperviseResultSearchModel model)
        {
            var page = Jd.TSuperviseResultService.PointExport(model);
            return JResult(page);
        }

        public ActionResult PointDetail(TSuperviseResultModel model)
        {
            var r = Jd.TSuperviseResultService.PointSuperviseDetail(model);
            return JResult(r);
        }

        public ActionResult PointSupervise(TSuperviseModel model)
        {
            var r = Jd.TSuperviseResultService.PointSupervise(model);
            return JResult(r);
        }
        public ActionResult BdViolationRecordSupervise(TSuperviseModel model)
        {
            var r = Jd.TSuperviseResultService.BdViolationRecordSupervise(model);
            return JResult(r);
        }
        public ActionResult BdViolationEntitySupervise(TSuperviseModel model)
        {
            var r = Jd.TSuperviseResultService.BdViolationEntitySupervise(model);
            return JResult(r);
        }
        /// <summary>
        /// 招标计划-检查点-红灯变更为绿灯
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult PointChange(TSuperviseResultLogModel model)
        {
            var r = Jd.TSuperviseResultService.SuperviseChange(model);
            return JResult(r);
        }
        #endregion


        #region 督查对象接口

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
        #endregion

        #endregion

        #region 督查情况

        #region 已发督查

        /// <summary>
        /// 已发督查
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult SupervisionIssued(TSuperviseModel model, SearchCondition search)
        {
            var r = Jd.TSuperviseService.SupervisionIssued(model, search);
            return JResult(r);
        }
        /// <summary>
        /// 已发督查-导出
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult YfdcExport(TSuperviseModel model, SearchCondition search)
        {
            var r = Jd.TSuperviseService.YfdcExport(model, search);
            return JResult(r);
        }

        #endregion

        #region 上级督查

        /// <summary>
        /// 上级督查
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult SuperiorInspector(TSuperviseModel model, SearchCondition search)
        {
            var r = Jd.TSuperviseService.SuperiorInspector(model, search);
            return JResult(r);
        }
        /// <summary>
        /// 上级督查-导出
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult SjdcExport(TSuperviseModel model, SearchCondition search)
        {
            var r = Jd.TSuperviseService.SjdcExport(model, search);
            return JResult(r);
        }
        
        #endregion

        #region 督查抄送

        /// <summary>
        /// 督察抄送
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult SupervisionCC(TSuperviseModel model, SearchCondition search)
        {
            var r = Jd.TSuperviseService.SupervisionCC(model, search);
            return JResult(r);
        }
        /// <summary>
        /// 督察抄送-导出
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult DccsExport(TSuperviseModel model, SearchCondition search)
        {
            var r = Jd.TSuperviseService.DccsExport(model, search);
            return JResult(r);
        }
        

        #endregion

        #region 详情
        #region 督查来源

        /// <summary>
        /// 督查来源
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult SuperviseForward(TSuperviseModel model)
        {
            var r = Jd.TSuperviseService.SuperviseForward(model);
            return JResult(r);
        }
        #endregion

        #region 督查信息
        /// <summary>
        /// 督查信息
        /// </summary>
        /// <param name="searchModel"></param>
        /// <returns></returns>
        public ActionResult SuperviseInfo(TSuperviseModel searchModel)
        {
            var r = Jd.TSuperviseService.SuperviseInfo(searchModel);
            return JResult(r);
        }

        #endregion

        #region 督查事项
        /// <summary>
        /// 督查事项
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// </remarks>
        public ActionResult SuperviseItem(TSuperviseModel model)
        {
            var r = Jd.TSuperviseService.SuperviseItem(model);
            return JResult(r);
        }

        #endregion

        #region 反馈记录
        /// <summary>
        /// 反馈记录
        /// </summary>
        /// <param name="searchModel"></param>
        /// <returns></returns>
        public ActionResult SuperviseFeedback(TSuperviseModel searchModel)
        {
            var r = Jd.TSuperviseService.SuperviseFeedback(searchModel);
            return JResult(r);
        }

        #endregion

        #region 操作记录
        /// <summary>
        /// 操作记录
        /// </summary>
        /// <param name="searchModel"></param>
        /// <returns></returns>
        public ActionResult SuperviseLog(TSuperviseModel searchModel)
        {
            var r = Jd.TSuperviseService.SuperviseLog(searchModel);
            return JResult(r);
        }

        #endregion
        #endregion

        #region 督察反馈

        public ActionResult Feedback(TSuperviseFeedbackModel model)
        {
            var r = Jd.TSuperviseService.Feedback(model);
            return JResult(r);
        }

        #endregion

        #region 转发督查

        public ActionResult Forward(TSuperviseModel model)
        {
            var r = Jd.TSuperviseService.Forward(model);
            return JResult(r);
        }

        #endregion    

        #region 处罚记录

        #region 处罚记录列表查询接口


        public ActionResult CFSearchList(T_PUNISH model, SearchCondition search)
        {
            var page = Jd.TPunishService.CFSearchList(model, search);
            return JResult(page);
        }
        /// <summary>
        /// 处罚记录-导出
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult CFSearchExport(T_PUNISH model, SearchCondition search)
        {
            var page = Jd.TPunishService.CFSearchExport(model, search);
            return JResult(page);
        }

        #endregion

        #region  行政处罚-新增处罚记录接口
        public ActionResult AddCFRecord(TPunishModel model)
        {
            var page = Jd.TPunishService.AddCFRecord(model);
            return JResult(page);
        }


        #endregion

        #region  行政处罚-新增处罚记录 —处罚对象查询接口    关联项目-弹窗

        public ActionResult CFProject(GGZYJD.DbEntity.TENDER_PROJECT model  , SearchCondition search)
        {
            var page = Jd.TPunishService.CFProject(model , search);
            return JResult(page);
        }

        #endregion

        #region  行政处罚-新增处罚记录 —处罚对象查询接口   处罚对象—选择弹窗

        public ActionResult CFPeople(TTPunishModel model, SearchCondition search)
        {
            var page = Jd.TPunishService.CFPeople(model, search);
            return JResult(page);
        }

        #endregion

        #region  行政处罚-处罚记录详情处罚信息接口
        public ActionResult CFDetailed(TPunisnDataModel searchModel, SearchCondition search)
        {
            var page = Jd.TPunishService.CFDetailed(searchModel, search);
            return JResult(page);
        }


        #endregion

        #region  行政处罚-处罚记录详情抄送接口
        public ActionResult CFDetailedRecored(TCopySendModel searchModel, SearchCondition search)
        {
            var page = Jd.TPunishService.CFDetailedRecored(searchModel,search);
            return JResult(page);
        }


        #endregion

        #endregion

        #endregion

        #region 行政监督信息

        #region 招标计划列表查询

        public ActionResult SearchList(TAfcProjectModel model, SearchCondition search)
        {

            var page = Jd.TSuperviseResultService.AfcSearchList(model, search);
            return JResult(page);

        }
        public ActionResult AfcSearchExport(TAfcProjectModel model, SearchCondition search)
        {

            var page = Jd.TSuperviseResultService.AfcSearchExport(model, search);
            return JResult(page);

        }
        #endregion

        #region 招标项目列表查询

        public ActionResult ReviewSearchList(ReviewSuperviseProjectModel model, SearchCondition search)
        {

            var page = Jd.TSuperviseResultService.ReviewSuperviseSearchList(model, search);
            return JResult(page);

        }
        public ActionResult ReviewSuperviseSearchExport(ReviewSuperviseProjectModel model, SearchCondition search)
        {

            var page = Jd.TSuperviseResultService.ReviewSuperviseSearchExport(model, search);
            return JResult(page);

        }
        #endregion

        #region 招标项目审查弹窗

        public ActionResult RecordDepidWindow(T_USER_DEPARTMENT model, SearchCondition search)
        {

            var page = Jd.TSuperviseResultService.RecordDepid(model, search);
            return JResult(page);

        }
        #endregion

        #region 投诉信息列表查询
        public ActionResult ZxtsSuperviseSearchList(XinPtZxtsModel model, SearchCondition search)
        {

            var page = Jd.TSuperviseResultService.ZxtsSuperviseSearchList(model, search);
            return JResult(page);

        }
        public ActionResult ZxtsSuperviseSearchExport(XinPtZxtsModel model, SearchCondition search)
        {

            var page = Jd.TSuperviseResultService.ZxtsSuperviseSearchExport(model, search);
            return JResult(page);

        }
        #endregion

        #region 招投标过程监管 监督点统计
        public ActionResult PointJDCount(JDCount_Model model, SearchCondition search)
        {
            var afcProject = Jd.TSuperviseResultService.PointJDCount(model, search);
            return JResult(afcProject);
        }
        #endregion

        #region  招投标过程监管 监督点列表查询
        public ActionResult PointSearchList(JDCount_Model model, SearchCondition search)
        {

            var page = Jd.TSuperviseResultService.PointSearchList(model, search);
            return JResult(page);

        }
        public ActionResult PointSearchExport(JDCount_Model model, SearchCondition search)
        {

            var page = Jd.TSuperviseResultService.PointSearchExport(model, search);
            return JResult(page);

        }


        #endregion

        #region 招投标过程监管 项目监督点统计

        public ActionResult ProjectPointJDCount(XinWarnResultModel model, SearchCondition search)
        {
            var afcProject = Jd.TSuperviseResultService.ProjectPointJDCount(model, search);
            return JResult(afcProject);
        }

        #endregion

        #region 招投标过程监管 项目监督列表
        public ActionResult ProjectPointSearchList(XinWarnResultModel model, SearchCondition search)
        {

            var page = Jd.TSuperviseResultService.ProjectPointSearchList(model, search);
            return JResult(page);

        }
        public ActionResult ProjectPointSearchExport(XinWarnResultModel model, SearchCondition search)
        {

            var page = Jd.TSuperviseResultService.ProjectPointSearchExport(model, search);
            return JResult(page);

        }

        #endregion

        #region 联动监督对比接口

        #region 联动监督对比数据查询接口、

        //public ActionResult JDCompare(JDCompareModel model, SearchCondition search)
        //{
        //    var page = Jd.TSuperviseResultService.JDCompare(model, search);
        //    return JResult(page);
        //}

        #region 联动监督对比项目查询接口
        public ActionResult JDCompareRecord(BD_VIOLATION_RECORD_REQUEST model, SearchCondition search)
        {
            var data = Fw.BdViolationRecordService.List(search, model.AREA_CODE, model.POINT_CODE,
                model.DATETIME_START, model.DATETIME_END, model.STATE,
                model.TENDER_PROJECT_CODE, model.TENDER_PROJECT_NAME, model.TENDER_PROJECT_TYPE);
            return JResult(data);
        }
        #endregion

        #region 联动监督对比主体查询接口
        public ActionResult JDCompareEntity(BD_VIOLATION_ENTITY_REQUEST model, SearchCondition search)
        {
            var data = Fw.BdViolationEntityService.List(search, model.AREA_CODE, model.POINT_CODE,
                model.DATETIME_START, model.DATETIME_END, model.STATE,
                model.ENTITY_CODE, model.ENTITY_NAME, model.ENTITY_TYPE);
            return JResult(data);
        }
        #endregion

        #endregion

        #region 疑似违规点返回
        public ActionResult List(string code = "")
        {
            //var r = Jd.TSuperviseResultService.TreeList(code);
            var r = Fw.BdViolationPointService.TreeList(code);
            return JResult(r);

        }
        #endregion

        #region 联动监督对比数据  主体详情接口
        public ActionResult JDCompareDetail(string id= "")
        {
            var data = Fw.BdViolationEntityService.Detail(id);
            return JResult(data);
        }
        #endregion

        #region 联动监督记录数据  记录详情接口
        public ActionResult JDCompareDetailRecord(string id = "")
        {
            var data = Fw.BdViolationRecordService.Detail(id);
            return JResult(data);
        }
        #endregion

        #region 联动监督对比记录调查结果弹窗接口
        public ActionResult Add(BD_INQUIRE_RECORD record, List<UploadResData> attachments)
        {
            var r = new GeneralResult();
            if (null == record)
            {
                r.SetFail("调查结果不能为空");
                return JResult(r);
            }

            List<GGZYFW.DbEntity.SYS_ATTACHMENT> files = new List<GGZYFW.DbEntity.SYS_ATTACHMENT>();
            if (attachments != null)
            {
                attachments.ForEach(e =>
                {
                    files.Add(e.FwSysAttachment(JdUser?.ID));
                });
            }
            record.ID = Guid.NewGuid().ToString().ToLower();
            record.OPERATION_USER = JdUser?.ID;
            record.OPERATION_DEPT = JdUser?.UserDepartment?.DEPID;
            record.OPERATION_TIME = DateTime.Now;
            r = Fw.BdInquireRecordService.Add(record, files);
            return JResult(r);
        }
        #endregion

        #endregion

        #endregion

        #region 处罚信息

        #region 处罚记录
        public ActionResult CFSearchRecordList(TPunisnDataModel model, SearchCondition search)
        {
            var page = Jd.TPunishService.CFSearchRecordList(model, search);
            return JResult(page);
        }
        /// <summary>
        /// 处罚记录-导出
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult CFSearchRecordExport(TPunisnDataModel model, SearchCondition search)
        {
            var page = Jd.TPunishService.CFSearchRecordExport(model, search);
            return JResult(page);
        }
        #endregion

        #region 下级被处罚抄送
        public ActionResult DownCFList(TCopySendModel model, SearchCondition search)
        {
            var page = Jd.TPunishService.DownCFList(model, search);
            return JResult(page);
        }
        public ActionResult DownCFExport(TCopySendModel model, SearchCondition search)
        {
            var page = Jd.TPunishService.DownCFExport(model, search);
            return JResult(page);
        }
        #endregion

        #region 处罚来源
        public ActionResult CFSource(TTPunishModel model, SearchCondition search)
        {
            var page = Jd.TPunishService.CFSource(model, search);
            return JResult(page);
        }
        #endregion

        #endregion

        #region 查询条件
        /// <summary>
        /// 监督点名称
        /// </summary>
        /// <returns></returns>
        public ActionResult SpName()
        {
            var r = Fw.WarnExpressionService.SpName();
            return JResult(r);
        }
        /// <summary>
        /// 监督方式
        /// </summary>
        /// <returns></returns>
        public ActionResult SpWay()
        {
            var r = Fw.WarnExpressionService.SpWay();
            return JResult(r);
        } 
        /// <summary>
        /// 监督点所属流程
        /// </summary>
        /// <returns></returns>
        public ActionResult SpFlow()
        {
            var r = Fw.WarnExpressionService.SpFlow();
            return JResult(r);
        }
        /// <summary>
        /// 监督类型
        /// </summary>
        /// <returns></returns>
        public ActionResult SpType()
        {
            var r = Fw.WarnExpressionService.SpType();
            return JResult(r);
        }

        #endregion

        #region 首页
        /// <summary>
        /// 上级督察情况统计
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpCount(TAfcProjectStatisticsModel model)
        {
            var r = Jd.TSuperviseService.UpCount(model);
            return JResult(r);
        }
        /// <summary>
        /// 上级督察情况统计根据类型
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpGroupByType(TAfcProjectStatisticsModel model)
        {
            var r = Jd.TSuperviseService.UpGroupByType(model);
            return JResult(r);
        }
        /// <summary>
        /// 监督点-预警统计
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult PointAlarmCount(TAfcProjectStatisticsModel model)
        {
            var page = Jd.TSuperviseResultService.PointAlarmCount(model);
            return JResult(page);
        }
        /// <summary>
        /// 监督点-根据类型
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult PointGroupByType(TAfcProjectStatisticsModel model)
        {
            var page = Jd.TSuperviseResultService.PointGroupByType(model);
            return JResult(page);
        }
        /// <summary>
        /// 监督点根据归属地
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult PointGroupByRegion(TAfcProjectStatisticsModel model)
        {
            var page = Jd.TSuperviseResultService.PointGroupByRegion(model);
            return JResult(page);
        }
        #endregion
    }
}