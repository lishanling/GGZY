using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using GGZY.Framework.Models;
using GGZY.Services.Infrastructure.Model;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Portal.Controllers
{
    [AllowAnonymous]
    public class ComplaintController: BaseController
    {
        public ActionResult PageList(PT_COMPLAIN model, SearchCondition search)
        {
            var r = Jd.PtComplainService.PageDataTable(model, search);
            return JResult(r);
        }
        /// <summary>
        /// 投诉详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Detail(string id)
        {
            var decimalId = id.DesDecrypt().ToNullableDecimal();
            var r = Jd.PtComplainService.ViewByPk(decimalId);
            if (r.Success && r.Data is PT_COMPLAIN model)
            {
                
                //var attachments = model.AIDS?.Split(',').Where(c => !string.IsNullOrWhiteSpace(c))
                //    .Select(c =>CommonAttachmentBuilder(c,"Jd"))
                //    .ToList();
                var attachments = Jd.CommonService.Attachments(model.AIDS, "Sys",true);
                var d = new
                {
                    model.TITLE,
                    model.SOURCES,
                    model.TM,
                    model.CONTENTS,
                    Attachments=attachments
                };
                return JResult(d);
            }

            return JResult(r);
        }


        public ActionResult ValidateComplaintCode(string code, string mobile, string mobileValidateCode)
        {
            var r = SmsModel.ValidateMobileCode(mobile, mobileValidateCode);
            if (r.Success)
            {
                var entity = Jd.PtZxtsService.ExistByCodeNMobile(code, mobile);
                if (entity==null)
                {
                    r.SetFail("未找到对应的投诉信息");
                }
                else
                {
                    r = Jd.PtZxtsService.OnlineComplaint(code, mobile, 
                        attachmentGuid =>CommonAttachmentBuilder(attachmentGuid,"Jd"));
                }
            }

            return JResult(r);
        }
        /// <summary>
        /// 在线投诉信息详情
        /// </summary>
        /// <param name="code"></param>
        /// <param name="mobile"></param>
        /// <returns>
        /// STATE  1: // 待签收(可【撤销】) 2:// 待受理(可【申请撤诉】) 4: // 待处理(可【申请撤诉】)
        /// </returns>
        public ActionResult OnlineComplaint(string code, string mobile)
        {
            var r = Jd.PtZxtsService.OnlineComplaint(code, mobile,
                attachmentGuid=>CommonAttachmentBuilder(attachmentGuid,"Jd"));
            return JResult(r);
        }

        #region 调查取证

        /// <summary>
        /// 反馈码查询详情接口
        /// </summary>
        /// <param name="feedbackCode"></param>
        /// <returns></returns>
        public ActionResult FeedbackDetail(string feedbackCode)
        {
            var result = Jd.PtZxtsLookIntoService.LookIntoDetail(feedbackCode, guid => CommonAttachmentBuilder(guid, "Jd", "Sys"));
            return JResult(result);
        }
        /// <summary>
        /// 提交反馈
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Feedback(PtZxtsLookIntoFeedbackModel model)
        {
            var result = Jd.PtZxtsLookIntoService.Feedback(model);
            return JResult(result);
        }

        //public ActionResult CheckOnlineComplaint(string cxCode)
        //{
        //    var result = Jd.PtZxtsLookIntoService.ComplaintDetail(cxCode,((type, id) => CommonAttachmentBuilder(id, "Jd", "Sys")));
        //    return JResult(result);
        //}

        public ActionResult CheckPublicComplaint(string cxCode)
        {
            var result = Jd.PtZxtsLookIntoService.PublicComplaintDetail(cxCode, ((type, id) => CommonAttachmentBuilder(id, "Jd", "Sys")));
            return JResult(result);
        }

        #endregion

        /// <summary>
        /// 撤销
        /// </summary>
        /// <param name="code">投诉编号</param>
        /// <param name="mobile">电话号码</param>
        /// <param name="remark">撤销原由</param>
        /// <returns></returns>
        public ActionResult OnlineComplaintRevoke(string code, string mobile, string remark)
        {
            var r = Jd.PtZxtsService.OnlineComplaintRevoke(code, mobile,remark);
            return JResult(r);
        }

        /// <summary>
        /// 申请撤诉
        /// </summary>
        /// <param name="code">投诉编号</param>
        /// <param name="mobile">电话号码</param>
        /// <param name="remark">撤销原由</param>
        /// <param name="revokeAttachments">书面撤诉原由附件</param>
        /// <param name="otherAttachements">其他附件</param>
        /// <returns></returns>
        [PortalUnFilter]
        public ActionResult SQCS(string code, string mobile, string remark,
            List<UploadResData> revokeAttachments, List<UploadResData> otherAttachements)
        {
            var r = Jd.PtZxtsService.OnlineComplaintSQCS(code, mobile, remark,revokeAttachments,otherAttachements);
            return JResult(r);
        }

        /// <summary>
            /// 在线投诉书
            /// </summary>
            /// <param name="complaint">投诉主体信息</param>
            /// <param name="respondents">被投诉人</param>
            /// <returns></returns>
            [PortalUnFilter]
            public ActionResult OnlineComplaintLetter(PT_ZXTS complaint, List<PT_ZXTS_BTSR> respondents)
        {
            var r = Jd.PtZxtsService.OnlineComplaintLetter(complaint, respondents);
            return JResult(r);
        }

        /// <summary>
        /// 提交在线投诉信息
        /// </summary>
        /// <param name="complaint">投诉主体信息</param>
        /// <param name="respondents">被投诉人</param>
        /// <param name="mobileValidateCode">短信验证码</param>
        /// <returns></returns>
        [PortalUnFilter]
        public ActionResult SaveOnlineComplaint(PT_ZXTS complaint, List<PT_ZXTS_BTSR> respondents, string mobileValidateCode)
        {
            var mobile = complaint.COMPLAINT_PHONE;
            if (complaint.COMPLAINT_TYPE == "1")
            {
                mobile = complaint.COMPLAINT_CONTACT_PHONE;
            }

            var r = SmsModel.ValidateMobileCode(mobile, mobileValidateCode);
            if (r.Success)
            {
                 r = Jd.PtZxtsService.SaveOnlineComplaint(complaint, respondents);
            }

            return JResult(r);
        }

        [PortalUnFilter]
        public ActionResult MztSaveOnlineComplaint(PtZxtsModel complaint, List<PT_ZXTS_BTSR> respondents, string mobileValidateCode)
        {
            var mobile = complaint.COMPLAINT_PHONE;
            if (complaint.COMPLAINT_TYPE == "1")
            {
                mobile = complaint.COMPLAINT_CONTACT_PHONE;
            }

            var r = SmsModel.ValidateMobileCode(mobile, mobileValidateCode);
            if (r.Success)
            {
                complaint.TYPE = "3"; //闽政通
                r = Jd.PtZxtsService.SaveComplaint(complaint, respondents);
            }

            return JResult(r);
        }
    }
}