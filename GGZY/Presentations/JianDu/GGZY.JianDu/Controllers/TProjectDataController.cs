using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Infrastructure.Model.FuWu;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZY.Services.JianDu;
using GGZYFW.DbEntity;


namespace GGZY.JianDu.Controllers
{
    public partial class JdTProjectDataController
    {
        #region 监督服务

        #region 项目查询
        /// <summary>
        /// 项目查询
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult GetProjectList_GGFW(MV_TJ_ALLCREATE_XZJD model, SearchCondition search)
        {
            var r = Fw.MvTjAllcreateXzjdService.GetProjectList_GGFW(model, search);
            return JResult(r);
        }

        #endregion
        #region 监督服务-公告公示(旧:交易监督-公告公示)

        public ActionResult GetGGGSList_GGFW(MvGgxxXzjdModel model, SearchCondition search)
        {
            var r = Fw.MvGgxxXzjdService.GetGGGSList_GGFW(model, search);
            return JResult(r);
        }
        public ActionResult GetGGGSList_GGFWExport(MvGgxxXzjdModel model, SearchCondition search)
        {
            var r = Fw.MvGgxxXzjdService.GetGGGSList_GGFWExport(model, search);
            return JResult(r);
        }

        public ActionResult GetGGGSList_GGFW_Stat(MvGgxxXzjdModel model, SearchCondition search)
        {
            var r = Fw.MvGgxxXzjdService.GetGGGSList_GGFW_Stat(model, search);
            return JResult(r);
        }
        public ActionResult GetGGGSList_GGFW_Chart(MvGgxxXzjdModel model, SearchCondition search)
        {
            var r = Fw.MvGgxxXzjdService.GetGGGSList_GGFW_Chart(model, search);
            return JResult(r);
        }
        #endregion

        #region 项目监督
        /// <summary>
        /// 项目查询
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult ProjectSearch(TProjectDataModel model, SearchCondition search)
        {
            var r = Jd.TProjectDataService.ProjectSearch(model, search);
            return JResult(r);
        }

        #endregion

        #region 监督点统计

        #region 监督点列表

        /// <summary>
        /// 获取监督点列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult GetProjectMP_List(TProjectDataModel model, SearchCondition search)
        {
            var r = Jd.TProjectDataService.GetProjectMP_List(model, search);
            return JResult(r);
        }
        /// <summary>
        /// 获取监督点列表计数
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult GetProjectMP_Count(TProjectDataModel model, SearchCondition search)
        {
            var r = Jd.TProjectDataService.GetProjectMP_Count(model, search);
            return JResult(r);
        }

        #region 列表查询条件

        public ActionResult FjRegion()
        {
            var regions = Jd.SysAreaService.FuJianRegion();
            //if (!regions.Exists(c => c.Label.Contains("全部") || c.Label.Contains("所有")))
            //{
            //    regions.Insert(0, new LabelValueModel { Label = "所有", Value = String.Empty });
            //}
            return JResult(regions);
        }
        /// <summary>
        /// 获取工程建设监督点ztree数据
        /// </summary>
        /// <returns></returns>
        public ActionResult GetMPZtree()
        {
            var r = Jd.TProjectDataService.GetMPZtree();
            return JResult(r);
        }
        /// <summary>
        /// 行业类型
        /// </summary>
        /// <returns></returns>
        public ActionResult HyTypes()
        {
            var allHy = Jd.SysDicService.FindDictionaryTextValue("33");
            if (!string.IsNullOrWhiteSpace(JdUser?.HY_TYPE) && JdUser.HY_TYPE != "-1")
            {
                var hyList = JdUser.HY_TYPE.Split(',').ToList();
                allHy = allHy.FindAll(c => hyList.Contains(c.Value)).ToList();
            }
            return JResult(allHy);
        }

        /// <summary>
        /// 监督点状态
        /// </summary>
        /// <returns></returns>
        public ActionResult LevelType()
        {
            var levelTypes = Jd.SysDicService.FindDictionaryTextValue("54");
            if (!levelTypes.Exists(c => c.Value == "未启动"))
            {
                levelTypes.Add(new LabelValueModel { Label = "未启动", Value = "0" });
            }
            //if (!levelTypes.Exists(c => c.Label.Contains("全部") || c.Label.Contains("所有")))
            //{
            //    levelTypes.Insert(0, new LabelValueModel { Label = "所有", Value = String.Empty });
            //}
            return JResult(levelTypes);
        }
        #endregion

        #endregion

        #region 监督点信息（详情）
        /// <summary>
        /// 获取监督点信息
        /// </summary>
        /// <param name="model">id code</param>
        /// <returns></returns>
        public ActionResult GetMpPlanInfo(TMpPlanInfoModel model)
        {
            var r = Jd.TMpPlanInfoService.GetMpPlanInfo(model);
            return JResult(r);
        }
        /// <summary>
        /// 监督点内容
        /// /Member/XMCX/ProcessHtml/FJ00111001/MPContent/MP_2_3.aspx
        /// id code businessid
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult GetTpDataInfo(TTpDataModel model)
        {
            var r = Jd.TTpDataService.GetTpDataInfo(model);
            return JResult(r);
        }
        /// <summary>
        /// 监督点动态 获取监督项目监督点的操作日志 
        /// </summary>
        /// <param name="model">id code</param>
        /// <returns></returns>
        public ActionResult GetPMLog(TMpPlanInfoModel model)
        {
            var r = Jd.TPmJdinfoLogService.GetPMLog(model);
            return JResult(r);
        }

        #endregion
        #endregion

        #endregion

        #region  招投标过程监管(新) 

        #region 招投标过程监管 监督点统计（新）
        /// <summary>
        /// 监督点统计
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult GetProjectMP_Count_V2(JD_Model model, SearchCondition search)
        {
            var afcProject = Jd.TProjectDataService.PointJDCount(model, search);
            return JResult(afcProject);
        }
        #endregion

        #region 招投标过程监管—监督点列表查询（新）
        /// <summary>
        /// 监督点列表查询
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult GetProjectMP_List_V2(JD_Model model, SearchCondition search)
        {

            var page = Jd.TProjectDataService.PointList(model, search);
            return JResult(page);

        }
        public ActionResult Sxjd(ProjectSupervisionResponseHyModel model, SearchCondition search)
        {
            var r = Jd.TProjectDataService.Sxjd(model, search);
            return JResult(r);
        }
        #endregion

        #region 招投标过程监管—详情通用（新）
        /// <summary>
        /// 详情通用
        /// </summary>
        /// <param name="m_id"></param>
        /// <returns></returns>
        public ActionResult WarnResultDetail(WARN_RESULT model)
        {

            var r = Fw.WarnResultService.WarnResultDetails(model);
            return JResult(r);
        }

        /// <summary>
        /// 投标人名单详情
        /// </summary>
        /// <param name="m_id"></param>
        /// <returns></returns>
        /// 
        public ActionResult TBMD(string bidder_section_code)
        {
            var r = Fw.TenderListService.Collections(bidder_section_code);
            return JResult(r);
        }
        #endregion

        #region 招投标过程监管—项目统计（新）
        /// <summary>
        /// 项目统计
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult ProjectPointJDCount(Project_Model model, SearchCondition search)
        {
            var afcProject = Jd.TProjectDataService.ProjectJDCount(model, search);
            return JResult(afcProject);
        }

        #endregion

        #region 招投标过程监管 项目监督列表（新）
        public ActionResult ProjectSearch_V2(Project_Model model, SearchCondition search)
        {

            var page = Jd.TProjectDataService.ProjectList(model, search);
            return JResult(page);

        }

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
        /// <summary>
        /// 监督状态
        /// </summary>
        /// <returns></returns>
        public ActionResult SpStatus()
        {
            var r = Fw.WarnResultService.SpStatus();
            return JResult(r);
        }
        #endregion

        #region 预警处理（新）
        /// <summary>
        /// 预警处理查询
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult EarlyWarnProcess(Early_Model model, SearchCondition search)
        {

            var page = Fw.WarnResultService.WarnProcess(model, search);
            return JResult(page);

        }
        //待处理
        public ActionResult FeedBackCount()
        {

            var page = Fw.WarnResultService.FeedBackCount();
            return JResult(page);

        }

        #endregion



        /// <summary>
        /// 预警处理-查看反馈
        /// </summary>
        /// <param name="m_id"></param>
        /// <returns></returns>
        public ActionResult SeeFeedback(string m_id)
        {
            var see = Fw.WarnResultService.SeeFeedback(m_id);
            return JResult(see);
        }

        /// <summary>
        /// 监督点总数
        /// </summary>
        /// <param name="tender_project_code"></param>
        /// <returns></returns>
        public ActionResult pointCount(string tender_project_code, string type, SearchCondition search)
        {

            var page = Fw.WarnResultService.pointCount(tender_project_code, type, search);
            return JResult(page);

        }


        /// <summary>
        /// 已阅读接口
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Read(Point_Model model)
        {

            var page = Fw.WarnResultService.Read(model);
            return JResult(page);

        }
        /// <summary>
        /// 监督日志
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Monitoring_Log(string tender_project_code, SearchCondition search)
        {

            var page = Fw.WarnResultService.Monitoring_Log(tender_project_code, search);
            return JResult(page);

        }

        
        /// <summary>
        /// 红灯变更
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult SuperviseChange(Traffic_Light_Change_Model model)
        {

            var page = Fw.WarnResultService.SuperviseChange(model);

            return JResult(page);

        }


        /// <summary>
        /// 联系人
        /// </summary>
        /// <param name="m_id"></param>
        /// <returns></returns>
        public ActionResult Contacts(string m_id)
        {

            var page = Fw.WarnResultService.Contacts(m_id);
            return JResult(page);

        }

        /// <summary>
        /// 增加自定义模板
        /// </summary>
        /// <param name="m_id"></param>
        /// <returns></returns>
        public ActionResult templateAdd(Template_Model model)
        {

            var page = Fw.WarnTemplateService.templateAdd(model);
            return JResult(page);

        }
        /// <summary>
        /// 删除自定义模板
        /// </summary>
        /// <param name="m_id"></param>
        /// <returns></returns>
        public ActionResult templateDelete(Template_Model model)
        {

            var page = Fw.WarnTemplateService.templateDelete(model);
            return JResult(page);

        }
        /// <summary>
        /// 修改自定义模板
        /// </summary>
        /// <param name="m_id"></param>
        /// <returns></returns>
        public ActionResult templateUpdate(Template_Model model)
        {

            var page = Fw.WarnTemplateService.templateUpdate(model);
            return JResult(page);

        }
        /// <summary>
        /// 查看模板
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult templateSee(Template_Model model, SearchCondition search)
        {

            var page = Fw.WarnTemplateService.templateSee(model,search);
            return JResult(page);

        }

        /// <summary>
        /// 发送插入数据库
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult earlyWarnRecord(Template_Model model)
        {
            
            var page = Fw.WarnResultService.earlyWarnRecord(model);
            return JResult(page);

        }
        /// <summary>
        /// 发送插入短信
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult sendMsgYJ(Template_Model model)
        {

            var page = Fw.WarnResultService.sendMsgYJ(model);
            return JResult(page);

        }


        #endregion

        #region 项目详情-监察痕迹-监督预警
        /// <summary>
        /// 监察痕迹-监督预警
        /// </summary>
        /// <param name="fwTenderProjectCode"></param>
        /// <returns></returns>
        public ActionResult GetMP_Logs(string fwTenderProjectCode)
        {
            var r = Fw.WarnRecordService.GetMP_Logs(fwTenderProjectCode);
            return JResult(r);
        }

        #endregion

        #region 项目详情-项目监督

        /// <summary>
        /// 获取tab页面树状结构数据,根据监督项目ID【包含监督点信息】
        /// </summary>
        /// <returns></returns>
        public ActionResult GetPSTabList()
        {
            var r = Fw.WarnExpressionService.GetPSTabList();
            return JResult(r);
        }

        #endregion

        #region 审批单位首页-项目监督预警
        public ActionResult ProjectAlarmCount(TAfcProjectStatisticsModel model)
        {

            var page = Fw.WarnResultService.ProjectAlarmCount(model);
            return JResult(page);

        }
        public ActionResult ProjectGroupByType(TAfcProjectStatisticsModel model)
        {

            var page = Fw.WarnResultService.ProjectGroupByType(model);
            return JResult(page);

        }
        public ActionResult ProjectGroupByRegion(TAfcProjectStatisticsModel model)
        {

            var page = Fw.WarnResultService.ProjectGroupByRegion(model);
            return JResult(page);

        }
        #endregion
    }
}