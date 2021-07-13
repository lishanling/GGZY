using System;
using System.Collections.Generic;
using System.Web.Mvc;
using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdPtZxtsController
    {
        #region (线上线下)在线投诉处理（线上:通过门户网站在线提交,TYPE=1 线下:线下收到投诉材料在后台录入,TYPE=2）
        /// <summary>
        /// 是否具有签收权限
        /// </summary>
        /// <returns></returns>
        public ActionResult HasReceipt()
        {
            var r = Jd.PtZxtsDepconfigService.HasReceiptPermission();
            return JResult(r);
        }
        /// <summary>
        /// (线上线下)在线投诉信息处理 计数接口
        /// </summary>
        /// <returns></returns>
        public ActionResult ComplaintCount()
        {
            var result = Jd.PtZxtsService.ComplaintCount();
            return JResult(result);
        }

        /// <summary>
        /// (线上线下)在线投诉信息处理 列表接口
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult ComplaintPageList(PtZxtsModel model, SearchCondition search)
        {
            var result = Jd.PtZxtsService.ComplaintPageList(model, search);
            return JResult(result);
        }
        /// <summary>
        /// (线上线下)在线投诉信息处理 详情接口
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public ActionResult ComplaintDetail(string code)
        {
            var result = Jd.PtZxtsService.ComplaintDetail(code, ((type, id) => CommonAttachmentBuilder(id, "Jd", type)));
            return JResult(result);
        }
        /// <summary>
        /// 距离最后处理时间还有多少个工作日
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public ActionResult ComplaintOverTimeWorkDayCount(string code)
        {
            var result = Jd.PtZxtsService.ComplaintOverTimeWorkDayCount(code);
            return JResult(result);
        }
        #region 线下投诉

        /// <summary>
        /// 提交在线投诉信息(线下)
        /// </summary>
        /// <param name="complaint">投诉主体信息</param>
        /// <param name="respondents">被投诉人</param>
        /// <returns></returns>
        public ActionResult SaveOutlineComplaint(PT_ZXTS complaint, List<PT_ZXTS_BTSR> respondents)
        {
            var result = string.IsNullOrWhiteSpace(complaint.CODE)
                ? Jd.PtZxtsService.SaveOutlineComplaint(complaint, respondents)
                : Jd.PtZxtsService.ReSaveOutlineComplaint(complaint, respondents);
            return JResult(result);
        }

        /// <summary>
        /// 生成线下_投诉处理决定书
        /// </summary>
        /// <param name="complaint"></param>
        /// <returns></returns>
        public ActionResult Create_TSCLJDS(TouSuChuLiJueDingShuModel complaint)
        {
            var result = Jd.PtZxtsService.Create_TSCLJDS(complaint);
            return JResult(result);
        }
        /// <summary>
        /// 处理线下投诉书
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult ChuLiOutlineComplaint(TouSuChuLiJueDingShuModel model)
        {
            var result = Jd.PtZxtsService.ChuLiOutlineComplaint(model);
            return JResult(result);
        }
        /// <summary>
        /// 生成线下_不予受理通知书
        /// </summary>
        /// <param name="complaint"></param>
        /// <returns></returns>
        public ActionResult Create_BYSLTZS(BuYuShouLiTongZhiShuModel complaint)
        {
            var result = Jd.PtZxtsService.Create_BYSLTZS(complaint);
            return JResult(result);
        }
        /// <summary>
        /// 不予受理线下投诉书
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult BuShouLiOutlineComplaint(BuYuShouLiTongZhiShuModel model)
        {
            var result = Jd.PtZxtsService.BuShouLiOutlineComplaint(model);
            return JResult(result);
        }

        #endregion

        #region 线上投诉 
        /// <summary>
        /// 签收（选择经办人）
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Receipt(PtZxtsModel model)
        {
            var r = Jd.PtZxtsService.Receipt(model);
            return JResult(r);
        }
        /// <summary>
        /// 不予受理
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UnAccepted(BuYuShouLiTongZhiShuModel model)
        {
            var r = Jd.PtZxtsService.UnAccepted(model);
            return JResult(r);
        }
        /// <summary>
        /// 受理
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Accepted(PtZxtsModel model)
        {
            var r = Jd.PtZxtsService.Accepted(model);
            return JResult(r);
        }
        /// <summary>
        /// 投诉处理代理机构 建设单位信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult FindOnlineComplaintHandler(PtZxtsModel model)
        {
            var r = Jd.PtZxtsService.FindOnlineComplaintHandler(model.CODE);
            return JResult(r);
        }
        /// <summary>
        /// 处理
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Handle(PtZxtsHandleModel model)
        {
            var r = Jd.PtZxtsService.Handle(model);
            return JResult(r);
        }
        /// <summary>
        /// 延迟处理
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Delay(PtZxtsModel model)
        {
            var r = Jd.PtZxtsService.Delay(model);
            return JResult(r);
        }
        /// <summary>
        /// 撤诉
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult RevokeApproval(PtZxtsModel model)
        {
            var r = Jd.PtZxtsService.RevokeApproval(model);
            return JResult(r);
        }

        /// <summary>
        /// 生成延迟处理说明书
        /// </summary>
        /// <param name="complaint"></param>
        /// <returns></returns>
        public ActionResult CreateDelayLetter(PtZxtsModel complaint)
        {
            var result = Jd.PtZxtsService.CreateDelayLetter(complaint);
            return JResult(result);
        }
        /// <summary>
        /// 生成投诉撤回意见书
        /// </summary>
        /// <param name="complaint"></param>
        /// <returns></returns>
        public ActionResult CreateRevokeOpinionLetter(PtZxtsModel complaint)
        {
            var result = Jd.PtZxtsService.CreateRevokeOpinionLetter(complaint);
            return JResult(result);
        }
        #endregion


        #region 调查取证
        /// <summary>
        /// 调查取证 列表接口
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult LookIntoPageList(PtZxtsLookIntoModel model, SearchCondition search)
        {
            var result = Jd.PtZxtsLookIntoService.LookIntoPageList(model,search);
            return JResult(result);
        }
        /// <summary>
        /// 调查取证（反馈）记录接口
        /// </summary>
        /// <param name="tsCode"></param>
        /// <returns></returns>
        public ActionResult FeedbackListByTsCode(string tsCode)
        {
            var result = Jd.PtZxtsLookIntoService.FeedbackListByTsCode(tsCode);
            return JResult(result);
        }
        /// <summary>
        /// 调查取证（反馈）记录接口
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult FeedbackList(string id)
        {
            var result = Jd.PtZxtsLookIntoService.FeedbackList(id);
            return JResult(result);
        }
        /// <summary>
        /// 调查取证（反馈）记录详情接口
        /// </summary>
        /// <param name="feedbackId"></param>
        /// <returns></returns>
        public ActionResult FeedbackDetail(string feedbackId)
        {
            var result = Jd.PtZxtsLookIntoService.FeedbackDetail(feedbackId, guid=>CommonAttachmentBuilder(guid,"Jd","Sys"));
            return JResult(result);
        }
        /// <summary>
        /// 调查取证 调查对象接口
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public ActionResult ComplaintLookIntoUsers(string code)
        {
            var result = Jd.PtZxtsLookIntoService.ComplaintLookIntoUsers(code);
            return JResult(result);
        }
        /// <summary>
        /// 调查取证 提交接口
        /// </summary>
        /// <param name="lookInto"></param>
        /// <param name="feedback"></param>
        /// <returns></returns>
        public ActionResult LookInto(PtZxtsLookIntoModel lookInto, List<PtZxtsLookIntoFeedbackModel> feedback)
        {
            var result = Jd.PtZxtsLookIntoService.LookInto(lookInto, feedback);
            return JResult(result);
        }
        #endregion

        #endregion

        #region 监督服务-监察痕迹-投诉处理
        /// <summary>
        /// 通过招标项目编号查找投诉操作记录
        /// </summary>
        /// <param name="jdTenderProjectCode">监督平台招标项目编号</param>
        /// <returns></returns>
        public ActionResult GetTS_Logs(string jdTenderProjectCode)
        {
            var r = Jd.PtZxtsLogService.GetPtZxtsLogByTenderProjectCode(jdTenderProjectCode);
            return JResult(r);
        }

        #endregion

        #region 监督首页-在线投诉

        public ActionResult GetZXTS_Data(MonitorHomePageModel model)
        {
            var r = Jd.PtZxtsService.GetZXTS_Data(model);
            return JResult(r);
        }

        #endregion
    }
}