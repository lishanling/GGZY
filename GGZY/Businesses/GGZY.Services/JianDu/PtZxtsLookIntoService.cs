using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aspose.Words.Lists;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Core.Sms;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class PtZxtsLookIntoService
    {
        /// <summary>
        /// 调查取证列表接口
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult LookIntoPageList(PtZxtsLookIntoModel model, SearchCondition search)
        {
            var condition = model.ConditionBuilder();
            #region STATUS

            if (model.STATUS.HasValue)
            {
                switch (model.STATUS)
                {
                    case 1://已反馈
                        condition.And(V_ZXTS_LOOK_INTO_FEEDBACKCOUNT._.FEEDBACK_COUNT == V_ZXTS_LOOK_INTO_COUNT._.LOOK_COUNT);
                        break;
                    case 0://未反馈
                        condition.And(V_ZXTS_LOOK_INTO_FEEDBACKCOUNT._.FEEDBACK_COUNT.IsNull());
                        break;
                    default://部分反馈
                        condition.And(V_ZXTS_LOOK_INTO_FEEDBACKCOUNT._.FEEDBACK_COUNT < V_ZXTS_LOOK_INTO_COUNT._.LOOK_COUNT && V_ZXTS_LOOK_INTO_FEEDBACKCOUNT._.FEEDBACK_COUNT > 0);
                        break;
                }
            }

            #endregion

            if (!string.IsNullOrWhiteSpace(model.COMPLAINT_TITLE))
            {
                condition.And(PT_ZXTS._.COMPLAINT_TITLE.Contain(model.COMPLAINT_TITLE));
            }
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
            {
                condition.And(PT_ZXTS._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
            }

            var jdUserId = JdUser.ID;
            condition.And(PT_ZXTS_LOOK_INTO._.CREATEDBY==jdUserId);
            var query = FromWhere(condition.ToWhereClip())
                .LeftJoin<PT_ZXTS>(PT_ZXTS._.CODE == PT_ZXTS_LOOK_INTO._.TS_CODE)
                .LeftJoinTmp<V_ZXTS_LOOK_INTO_COUNT>(FromWhere<PT_ZXTS_LOOK_INTO_FEEDBACK>()
                        .GroupBy(PT_ZXTS_LOOK_INTO_FEEDBACK._.LOOK_ID)
                        .Select(PT_ZXTS_LOOK_INTO_FEEDBACK._.FEEDBACK_CODE.Distinct().Count().As("LOOK_COUNT"),
                            PT_ZXTS_LOOK_INTO_FEEDBACK._.LOOK_ID),
                    V_ZXTS_LOOK_INTO_COUNT._.LOOK_ID == PT_ZXTS_LOOK_INTO._.ID)
                .LeftJoinTmp<V_ZXTS_LOOK_INTO_FEEDBACKCOUNT>(
                    FromWhere<PT_ZXTS_LOOK_INTO_FEEDBACK>(PT_ZXTS_LOOK_INTO_FEEDBACK._.STATUS == 1)
                        .GroupBy(PT_ZXTS_LOOK_INTO_FEEDBACK._.LOOK_ID)
                        .Select(PT_ZXTS_LOOK_INTO_FEEDBACK._.FEEDBACK_CODE.Distinct().Count().As("FEEDBACK_COUNT"),
                            PT_ZXTS_LOOK_INTO_FEEDBACK._.LOOK_ID),
                    V_ZXTS_LOOK_INTO_FEEDBACKCOUNT._.LOOK_ID == PT_ZXTS_LOOK_INTO._.ID)
                .Select(PT_ZXTS_LOOK_INTO._.All,
                    PT_ZXTS._.COMPLAINT_TITLE, PT_ZXTS._.TENDER_PROJECT_NAME, PT_ZXTS._.STATE.As("PT_ZXTS_STATE"),
                    PT_ZXTS._.HANDLE_UID.As("PT_ZXTS_HANDLE_UID"), PT_ZXTS._.HANDLE_STATE.As("PT_ZXTS_HANDLE_STATE"),
                    V_ZXTS_LOOK_INTO_COUNT._.LOOK_COUNT,
                    V_ZXTS_LOOK_INTO_FEEDBACKCOUNT._.FEEDBACK_COUNT.Nvl(0).As("FEEDBACK_COUNT"));
            var total = query.Count();
            var list = query.OrderBy(PT_ZXTS_LOOK_INTO._.LOOK_TIME.Desc)
                .Page(search.PageSize, search.PageNo)
                .ToList<PtZxtsLookIntoModel>();
            var plist = list.ToPageTableResult(search, total, c =>
            {
                c.Button= new List<string>();
                if (c.PT_ZXTS_STATE == 4 && (c.PT_ZXTS_HANDLE_UID == jdUserId || c.PT_ZXTS_HANDLE_UID == -1))
                {
                    c.Button.Add("DCQZ");
                }
                if (c.PT_ZXTS_STATE == 7 && c.PT_ZXTS_HANDLE_STATE == 1 && (c.PT_ZXTS_HANDLE_UID == jdUserId || c.PT_ZXTS_HANDLE_UID == -1))
                {
                    c.Button.Add("DCQZ");
                }
                c.Button.Add("DCJL");
                return c;
            });
            return plist;
        }

        /// <summary>
        /// 调查取证（反馈）记录接口
        /// </summary>
        /// <param name="lookId"></param>
        /// <returns></returns>
        public List<PtZxtsLookIntoFeedbackModel> FeedbackList(string lookId)
        {
            return FromWhere<PT_ZXTS_LOOK_INTO_FEEDBACK>(PT_ZXTS_LOOK_INTO_FEEDBACK._.LOOK_ID == lookId)
                .OrderBy(PT_ZXTS_LOOK_INTO_FEEDBACK._.UPDATEDTIME.Desc)
                .ToList<PtZxtsLookIntoFeedbackModel>();
        }
        /// <summary>
        /// 调查取证（反馈）记录接口
        /// </summary>
        /// <param name="tsCode"></param>
        /// <returns></returns>
        public List<PtZxtsLookIntoFeedbackModel> FeedbackListByTsCode(string tsCode)
        {
            var list = FromWhere(PT_ZXTS_LOOK_INTO._.TS_CODE == tsCode)
                   .LeftJoin<PT_ZXTS_LOOK_INTO_FEEDBACK>(PT_ZXTS_LOOK_INTO_FEEDBACK._.LOOK_ID == PT_ZXTS_LOOK_INTO._.ID)
                   .OrderBy(PT_ZXTS_LOOK_INTO_FEEDBACK._.FEEDBACK_TIME.Desc && PT_ZXTS_LOOK_INTO_FEEDBACK._.LOOK_TIME.Desc)
                   .Select(PT_ZXTS_LOOK_INTO_FEEDBACK._.All)
                   .ToList<PtZxtsLookIntoFeedbackModel>();
            return list;
        }
        /// <summary>
        /// 调查取证（反馈）记录详情接口
        /// </summary>
        /// <param name="feedbackId"></param>
        /// <param name="urlBuilder"></param>
        /// <returns></returns>
        public GeneralResult FeedbackDetail(string feedbackId, Func<string, string> urlBuilder = null)
        {
            var r = new GeneralResult();
            var feedback = FromWhere<PT_ZXTS_LOOK_INTO_FEEDBACK>(PT_ZXTS_LOOK_INTO_FEEDBACK._.ID == feedbackId)
                .ToFirst<PtZxtsLookIntoFeedbackModel>();
            if (feedback != null)
            {
                var lookInto = FromWhere(PT_ZXTS_LOOK_INTO._.ID == feedback.LOOK_ID)
                    .LeftJoin<T_USER>(T_USER._.ID == PT_ZXTS_LOOK_INTO._.CREATEDBY)
                    .Select(PT_ZXTS_LOOK_INTO._.All, T_USER._.USERNAME.As("CREATOR"))
                    .ToFirst<PtZxtsLookIntoModel>();
                if (urlBuilder != null)
                {
                    feedback.FEEDBACK_AIDS_ATTACHMENTS = Jd.CommonService.Attachments(feedback.FEEDBACK_AIDS, "Sys",true);
                    lookInto.LOOK_AIDS_ATTACHMENTS = Jd.CommonService.Attachments(lookInto.LOOK_AIDS, "Sys",true);
                }
                r.SetSuccess(new
                {
                    LOOK_INTO = lookInto,
                    FEEDBACK = feedback
                });
            }
            else
            {
                r.SetFail("未找到对应的调查反馈记录");
            }
            return r;
        }

        /// <summary>
        /// 调查取证（反馈）记录详情接口
        /// </summary>
        /// <param name="feedbackCode"></param>
        /// <param name="urlBuilder"></param>
        /// <returns></returns>
        public GeneralResult LookIntoDetail(string feedbackCode, Func<string, string> urlBuilder = null)
        {
            var r = new GeneralResult();
            var feedback = FromWhere<PT_ZXTS_LOOK_INTO_FEEDBACK>(PT_ZXTS_LOOK_INTO_FEEDBACK._.FEEDBACK_CODE == feedbackCode)
                .ToFirst<PtZxtsLookIntoFeedbackModel>();
            if (feedback != null)
            {
                var lookInto = FromWhere(PT_ZXTS_LOOK_INTO._.ID == feedback.LOOK_ID)
                    .LeftJoin<T_USER>(T_USER._.ID == PT_ZXTS_LOOK_INTO._.CREATEDBY)
                    .Select(PT_ZXTS_LOOK_INTO._.All, T_USER._.USERNAME.As("CREATOR"))
                    .ToFirst<PtZxtsLookIntoModel>();
                var zxts = Jd.PtZxtsService.FirstOrNull(PT_ZXTS._.CODE == lookInto.TS_CODE);
                if (urlBuilder != null)
                {
                    feedback.FEEDBACK_AIDS_ATTACHMENTS = Jd.CommonService.Attachments(feedback.FEEDBACK_AIDS, "Sys",true);
                    lookInto.LOOK_AIDS_ATTACHMENTS = Jd.CommonService.Attachments(lookInto.LOOK_AIDS, "Sys",true);
                }
                r.SetSuccess(new
                {
                    LOOK_INTO = lookInto,
                    ONLINE_COMPLAINT = new
                    {
                        zxts.TENDER_PROJECT_NAME,
                        zxts.TENDER_PROJECT_CODE,
                        feedback.LOOK_NAME,
                    }
                    // FEEDBACK = feedback
                });
            }
            else
            {
                r.SetFail("未找到对应的调查反馈记录");
            }
            return r;
        }

        #region 调查取证
        /// <summary>
        /// 调查取证 调查对象接口
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public List<object> ComplaintLookIntoUsers(string code)
        {
            var r = new List<PtZxtsLookIntoFeedbackModel>();
            var complaint = Jd.PtZxtsService.FromWhere(PT_ZXTS._.CODE == code)
                .InnerJoin<TENDER_PROJECT>(PT_ZXTS._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                .LeftJoin<T_USER_EXTEND>(T_USER_EXTEND._.U_ID == TENDER_PROJECT._.M_CREATOR)
                .LeftJoin<PROJECT>(PROJECT._.PROJECT_CODE == TENDER_PROJECT._.PROJECT_CODE)
                .LeftJoin<T_AFC_PROJECT>(T_AFC_PROJECT._.CODE == PROJECT._.CONSTRUCTION_ID)
                .Select(
                    TENDER_PROJECT._.M_CREATOR.As("DLJG_UID"),
                    T_USER_EXTEND._.DEP_NAME.As("DLJG_NAME"),
                    T_AFC_PROJECT._.U_ID.As("JSDW_UID"),
                    //T_AFC_PROJECT._.MANAGER_PHONE
                    T_AFC_PROJECT._.DEP_NAME.As("JSDW_NAME"),
                    PT_ZXTS._.All)
                .ToFirst<PtZxtsModel>();
            if (complaint != null)
            {
                #region 招标人


                var users = Jd.TUserService.FindSendMsgByUid(complaint.DLJG_UID, complaint.JSDW_UID);
                r.AddRange(users.Select(c =>
                   new PtZxtsLookIntoFeedbackModel
                   {
                       LOOK_NAME = c.USERNAME,
                       LOOK_CONTRACT = c.TELPHONE,
                       LOOK_OBJECT_TYPE = c.ID == complaint.DLJG_UID ? "代理机构" : "招标人",
                       LOOK_PROJECT_TYPE = c.ID == complaint.DLJG_UID ? "代理机构" : "建设单位",
                   }));

                #endregion

                #region 投诉人

                r.Add(new PtZxtsLookIntoFeedbackModel
                {
                    LOOK_NAME = complaint.COMPLAINT_TYPE == "1" ? $"{complaint.COMPLAINT_DNAME}" : $"{complaint.COMPLAINT_NAME}",
                    LOOK_CONTRACT = complaint.COMPLAINT_TYPE == "1" ? complaint.COMPLAINT_CONTACT_PHONE : complaint.COMPLAINT_PHONE,
                    LOOK_OBJECT_TYPE = "投诉人",
                    LOOK_PROJECT_TYPE = "投诉人",
                });

                #endregion

                #region 被投诉人

                var btsr = Jd.PtZxtsBtsrService.GetBtsrByTsId(complaint.ID);
                r.AddRange(btsr.Select(c =>
                    new PtZxtsLookIntoFeedbackModel
                    {
                        LOOK_NAME = c.NAME,
                        LOOK_CONTRACT = c.CONTACT_PHONE,
                        LOOK_OBJECT_TYPE = "被投诉人",
                        LOOK_PROJECT_TYPE = c.TYPE_TEXT
                    }));

                #endregion
            }

            var result = r.GroupBy(c => c.LOOK_OBJECT_TYPE).Select(c => (object)new
            {
                label = c.Key,
                children = c.Select(child => (object)new
                {
                    label = string.IsNullOrWhiteSpace(child.LOOK_CONTRACT) ? child.LOOK_NAME : $"{child.LOOK_NAME}({child.LOOK_CONTRACT})",
                    child.LOOK_NAME,
                    child.LOOK_CONTRACT,
                    child.LOOK_OBJECT_TYPE,
                    child.LOOK_PROJECT_TYPE
                })
            }).ToList();
            return result;

        }

        public GeneralResult LookInto(PtZxtsLookIntoModel lookInto, List<PtZxtsLookIntoFeedbackModel> feedback)
        {
            var r = new GeneralResult();

            #region 校验

            //if (lookInto.LOOK_AIDS_ATTACHMENTS == null || !lookInto.LOOK_AIDS_ATTACHMENTS.Any())
            //{
            //    r.SetFail("请上传附件");
            //    return r;
            //}
            if (string.IsNullOrWhiteSpace(lookInto.LOOK_CONTENT))
            {
                r.SetFail("请填写调查内容");
                return r;
            }

            if (feedback == null || !feedback.Any())
            {
                r.SetFail("请选择调查对象");
                return r;
            }


            #endregion
            var jdUserId = JdUser?.ID;
            var complaint = Jd.PtZxtsService.FirstOrNull(PT_ZXTS._.CODE == lookInto.TS_CODE && (PT_ZXTS._.HANDLE_UID == jdUserId || PT_ZXTS._.HANDLE_UID == "-1"));
            if (complaint == null)
            {
                r.SetFail("未找到对应的投诉信息");
                return r;
            }
            using (var trans = GetDbSession().BeginTransaction())
            {
                var now = DateTime.Now;

                #region 调查情况
                if(lookInto.LOOK_AIDS_ATTACHMENTS!=null&& lookInto.LOOK_AIDS_ATTACHMENTS.Any())
                {
                    var atts = lookInto.LOOK_AIDS_ATTACHMENTS.Select(c => c.JdSysAttachment(jdUserId)).ToList();
                    trans.Insert(atts);
                    lookInto.LOOK_AIDS = string.Join(",", lookInto.LOOK_AIDS_ATTACHMENTS.Select(c => c.Id));
                }
                var dbModel = lookInto.ConvertTo<PT_ZXTS_LOOK_INTO>();
                dbModel.ID = BitConverter.ToInt64(Guid.NewGuid().ToByteArray(), 0).ToString();
                dbModel.CREATEDBY = jdUserId?.ToString();
                dbModel.LOOK_TIME = now;
                dbModel.CREATEDTIME = dbModel.LOOK_TIME;
                dbModel.UPDATEDBY = dbModel.CREATEDBY;
                dbModel.UPDATEDTIME = dbModel.LOOK_TIME;
                trans.Insert(dbModel);

                #endregion

                #region 调查对象

                var dbModels = feedback.Select(c =>
                {
                    var m = c.ConvertTo<PT_ZXTS_LOOK_INTO_FEEDBACK>();
                    m.ID = Guid.NewGuid().ToString("N");
                    m.CREATEDBY = dbModel.CREATEDBY;
                    m.CREATEDTIME = now;
                    m.LOOK_TIME = now;
                    m.UPDATEDBY = dbModel.CREATEDBY;
                    m.UPDATEDTIME = now;
                    m.STATUS = 0;
                    m.LOOK_ID = dbModel.ID;
                    m.FEEDBACK_CODE = $"QZ{Guid.NewGuid().To16String(true)}";// Jd.PtZxtsService.CreateComplaintCode("QZ");
                    m.FEEDBACK_CONTENT = String.Empty;
                    m.FEEDBACK_AIDS = String.Empty;
                    return m;
                }).ToList();
                trans.Insert(dbModels);

                #endregion

                #region 发送短信
                var msgFormat = ConfigHelper.AppSettings.SmsZXTS_DCQZ;
                Task.Run(() =>
                {
                    foreach (var item in dbModels)
                    {
                        var sms = new SmsCommon
                        {
                            Mobile = item.LOOK_CONTRACT,
                            Content = string.Format(msgFormat, complaint.TENDER_PROJECT_NAME, item.FEEDBACK_CODE)
                        };
                        sms.SendSms();
                    }
                });
                //var smsSend = dbModels.Select(c => new T_SMS_SEND
                //{
                //    ID = 0,
                //    MODULE_NAME = "在线投诉模块",
                //    OPER_BY = jdUserId,
                //    RETRY = 0,
                //    STATUS = 0,
                //    TEL_PHONE = c.LOOK_CONTRACT,
                //    SMS_CONTENT = string.Format(msgFormat, complaint.TENDER_PROJECT_NAME, c.FEEDBACK_CODE),
                //    YJ_SEND_TM = DateTime.Now.AddMinutes(2),
                //}).ToList();
                //trans.Insert(smsSend);
                #endregion

                trans.Commit();
                r.SetSuccess();
            }
            return r;
        }
        #endregion

        public GeneralResult Feedback(PtZxtsLookIntoFeedbackModel model)
        {
            var r = new GeneralResult();

            #region 校验

            //if (model.FEEDBACK_AIDS_ATTACHMENTS == null || !model.FEEDBACK_AIDS_ATTACHMENTS.Any())
            //{
            //    r.SetFail("请上传附件");
            //    return r;
            //}
            if (string.IsNullOrWhiteSpace(model.FEEDBACK_CONTENT))
            {
                r.SetFail("请填写调查内容");
                return r;
            }


            #endregion
            var jdUserId = JdUser?.ID;
            var dbEntity = FirstOrNull<PT_ZXTS_LOOK_INTO_FEEDBACK>(PT_ZXTS_LOOK_INTO_FEEDBACK._.FEEDBACK_CODE == model.FEEDBACK_CODE);
            if (dbEntity == null)
            {
                r.SetFail("未找到对应的投诉调查反馈信息");
                return r;
            }
            using (var trans = GetDbSession().BeginTransaction())
            {
                model.SetAids();
                if (model.FEEDBACK_AIDS_ATTACHMENTS != null && model.FEEDBACK_AIDS_ATTACHMENTS.Any())
                {
                    var atts = model.FEEDBACK_AIDS_ATTACHMENTS.Select(c => c.JdSysAttachment(jdUserId)).ToList();
                    trans.Insert(atts);
                }
               
                if (dbEntity.STATUS == 0)//未反馈
                {
                    dbEntity.Attach();
                    dbEntity.STATUS = 1;
                    dbEntity.UPDATEDBY = dbEntity.LOOK_NAME;
                    dbEntity.UPDATEDTIME = DateTime.Now;
                    dbEntity.FEEDBACK_CONTENT = model.FEEDBACK_CONTENT;
                    dbEntity.FEEDBACK_AIDS = model.FEEDBACK_AIDS;
                    dbEntity.FEEDBACK_TIME = DateTime.Now;
                    trans.Update(dbEntity);
                }
                else
                {
                    var dbModel = model.ConvertTo<PT_ZXTS_LOOK_INTO_FEEDBACK>();
                    dbModel.ID = Guid.NewGuid().ToString("N");
                    dbModel.STATUS = 1;
                    dbModel.CREATEDBY = dbEntity.LOOK_NAME;
                    dbModel.CREATEDTIME = DateTime.Now;
                    dbModel.UPDATEDBY = dbEntity.LOOK_NAME;
                    dbModel.UPDATEDTIME = dbModel.CREATEDTIME;
                    dbModel.FEEDBACK_CONTENT = model.FEEDBACK_CONTENT;
                    dbModel.FEEDBACK_AIDS = model.FEEDBACK_AIDS;
                    dbModel.FEEDBACK_TIME = dbModel.CREATEDTIME;
                    dbModel.LOOK_ID = dbEntity.LOOK_ID;
                    dbModel.FEEDBACK_CODE = dbEntity.FEEDBACK_CODE;
                    dbModel.LOOK_NAME = dbEntity.LOOK_NAME;
                    dbModel.LOOK_OBJECT_TYPE = dbEntity.LOOK_OBJECT_TYPE;
                    dbModel.LOOK_PROJECT_TYPE = dbEntity.LOOK_PROJECT_TYPE;
                    dbModel.LOOK_CONTRACT = dbEntity.LOOK_CONTRACT;
                    dbModel.LOOK_TIME = dbEntity.LOOK_TIME;
                    trans.Insert(dbModel);
                }
                trans.Commit();
                r.SetSuccess();
            }
            return r;
        }


        public GeneralResult<PtZxtsModel> ComplaintDetail(string cxCode, Func<string, string, string> urlBuilder = null)
        {
            var r = new GeneralResult<PtZxtsModel>();
            var chk = FirstOrNull<PT_ZXTS_LOOK_INTO_CHK>(PT_ZXTS_LOOK_INTO_CHK._.CX_CODE == cxCode);
            if (chk == null)
            {
                r.SetFail("未找到对应的查询码信息");
                return r;
            }
            if (!chk.EXPIREDTIME.HasValue || chk.EXPIREDTIME.Value < DateTime.Now)
            {
                r.SetFail("查询码已过期");
                return r;
            }

            r = Jd.PtZxtsService.ComplaintDetail(chk.TS_CODE, urlBuilder);

            return r;
        }

        public GeneralResult<object> PublicComplaintDetail(string cxCode, Func<string, string, string> urlBuilder)
        {
            var r = new GeneralResult<object>();
            var chk = FirstOrNull<PT_ZXTS_LOOK_INTO_CHK>(PT_ZXTS_LOOK_INTO_CHK._.CX_CODE == cxCode);
            if (chk == null)
            {
                r.SetFail("未找到对应的查询码信息");
                return r;
            }
            if (!chk.EXPIREDTIME.HasValue || chk.EXPIREDTIME.Value < DateTime.Now)
            {
                r.SetFail("查询码已过期");
                return r;
            }
            var model = Jd.PtComplainService.FirstOrNull(PT_COMPLAIN._.ID == chk.COMPLAINT_PUBLISH_ID);
            if (model != null)
            {

                var attachments = model.AIDS?.Split(',').Where(c => !string.IsNullOrWhiteSpace(c))
                    .Select(c => urlBuilder(c, "Jd"))
                    .ToList();
                var d = new
                {
                    model.TITLE,
                    model.SOURCES,
                    model.TM,
                    model.CONTENTS,
                    Attachments = attachments
                };
                r.SetSuccess(d);
            }
            else
            {
                r.SetFail("未找到对应的投诉信息");
            }

            return r;
        }

    }
}