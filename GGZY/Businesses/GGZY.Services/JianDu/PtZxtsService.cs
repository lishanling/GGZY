using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using Aspose.Words;
using Aspose.Words.Tables;
using Dos.ORM;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Helper;
using GGZY.Core.Models;
using GGZY.Core.Sms;
using GGZY.Core.Utils;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    /// <summary>
    /// TODO  门户提交投诉 3个工作日未受理，自动受理（不管是否签收有经办人） 这个时候 HANDLE_UID=-1
    /// 受理后30个工作日处理 必须人工 不可系统自动处理
    /// </summary>
    public partial class PtZxtsService
    {
        #region 提交投诉

        /// <summary>
        /// 提交在线投诉信息
        /// </summary>
        /// <param name="ts">投诉主体信息</param>
        /// <param name="respondents">被投诉人</param>
        /// <returns></returns>
        public GeneralResult SaveComplaint(PtZxtsModel ts, List<PT_ZXTS_BTSR> respondents)
        {

            ts.SetAids();
            var complaint = ts.ConvertTo<PT_ZXTS>();
            var r = ValidateComplaintParameter(complaint, respondents);
            if (r.Success)
            {
                var complaintCode = CreateComplaintCode();
                Task.Run(() =>
                {
                    #region 添加数据到数据库

                    DateTime now = DateTime.Now;

                    complaint.ID = 0;
                    complaint.CODE = complaintCode;
                    complaint.STATE = "1"; //待受理
                    complaint.SIGN_STATE = "1"; //签收状态（改为待签收）
                    complaint.CREATE_TM = now;
                    complaint.DATA_TIMESTAMP = now;
                    complaint.OVER_TM = Jd.THolidayService.OverTime(now);
                    using (var trans = GetDbSession().BeginTransaction())
                    {
                        trans.Insert(ts.ATTACHMENTS);
                        var tsid = trans.Insert(complaint);
                        respondents = respondents.Select(c =>
                        {
                            c.ID = 0;
                            c.TS_ID = tsid;
                            return c;
                        }).ToList();
                        trans.Insert(respondents);
                        trans.Insert(new PT_ZXTS_LOG
                        {
                            ID = 0,
                            TS_ID = tsid,
                            RECORDER_UNAME = "投诉人",
                            RECORDER_OPERATION = "1", //操作：1.提交投诉
                            RECORDER_TM = now
                        });

                        #region 部门短信提醒

                        var msg = ConfigHelper.AppSettings.SmsZXTS_SIGN;
                        if (!string.IsNullOrWhiteSpace(msg))
                        {
                            var obj = FromSql(@"
            SELECT WM_CONCAT(A.TELPHONE) AS TELPHONES 
              FROM T_USER A
                   LEFT JOIN PT_ZXTS_DEPCONFIG B ON A.ID=B.USER_ID AND A.DEPARTID=B.DEP_ID
             WHERE IS_SEND_MSG=1 AND IS_ENABLE=1 AND TYPE=0 AND DEPARTID=:depid")
                                .AddInParameter(":depid", DbType.AnsiString, complaint.ACCEPT_DEPID).ToFirst<object>();
                            if (obj != null&&obj is EntityUtils.FastExpando dataDic&& dataDic.Data.ContainsKey("TELPHONES"))
                            {
                                
                                var phones = dataDic.Data["TELPHONES"]?.ToString();
                                msg = string.Format(msg, complaint.TENDER_PROJECT_NAME);
                                if (!string.IsNullOrWhiteSpace(phones))
                                {
                                    DateTime dTime = Jd.THolidayService.GetWorkDate(DateTime.Now, 0);
                                    if (dTime.Date != DateTime.Now.Date)
                                    {
                                        dTime = DateTime.Parse(dTime.ToString("yyyy-MM-dd 09:00:00"));
                                    }

                                    foreach (string p in phones.Split(','))
                                    {
                                        var model = new T_SMS_SEND
                                        {
                                            ID=0,
                                            MODULE_NAME = "在线投诉模块",
                                            OPER_BY = JdUser?.ID,
                                            RETRY = 0,
                                            STATUS = 0,
                                            TEL_PHONE = p,
                                            SMS_CONTENT = msg,
                                            YJ_SEND_TM = dTime
                                        };
                                        trans.Insert(model);
                                    }
                                }
                            }
                        }

                        #endregion

                        trans.Commit();
                    }


                    #endregion

                    #region 发送邮件

                    string email = complaint.COMPLAINT_TYPE == "1"
                        ? complaint.COMPLAINT_CONTACT_EMAIL
                        : complaint.COMPLAINT_EMAIL;

                    string body = "亲爱的用户：您好！<br />";
                    body += "&nbsp;&nbsp;您现在“福建省公共资源交易电子行政监督平台”提交了一个投诉。<br />";
                    body += "&nbsp;&nbsp;投诉编号为：" + complaint.CODE + ",我们将尽快处理您的投诉，请耐心等待，不要重复提交。感谢您的支持！";
                    EmailUtils.SendEmail(email, body, "福建省公共资源交易电子行政监督平台");

                    #endregion
                });


                r.SetSuccess(new { CODE = complaintCode });

            }

            return r;
        }

        #endregion

        #region 门户 Portal

        public PT_ZXTS ExistByCodeNMobile(string code, string mobile)
        {
            var entity = Cache.Get($"{ConfigHelper.APP_KEY_GGZYJD}:PT:PT_ZXTS:{mobile}_{code}",
                () => FirstOrNull(PT_ZXTS._.CODE == code &&
                                  ((PT_ZXTS._.COMPLAINT_TYPE == "1" && PT_ZXTS._.COMPLAINT_CONTACT_PHONE == mobile)
                                   || (PT_ZXTS._.COMPLAINT_TYPE == "2" && PT_ZXTS._.COMPLAINT_PHONE == mobile))));
            return entity;
        }
        /// <summary>
        /// 在线投诉信息详情
        /// </summary>
        /// <param name="code"></param>
        /// <param name="mobile"></param>
        /// <param name="urlBuilder"></param>
        /// <returns></returns>
        public GeneralResult OnlineComplaint(string code, string mobile, Func<string, string> urlBuilder = null)
        {
            var r = new GeneralResult();
            if (Cache.IsSet($"{ConfigHelper.APP_KEY_GGZYJD}:PT:PT_ZXTS:{mobile}_{code}"))
            {
                var obj = FromSql(@"
                SELECT A.CODE,
                       A.STATE AS STATE,
                       B.TEXT AS STATE_TEXT,
                       TO_CHAR(A.CREATE_TM, 'yyyy-mm-dd hh24:mi:ss') CREATE_TM,
                       A.COMPLAINT_TYPE AS COMPLAINT_TYPE,                       
                       G.TEXT AS COMPLAINT_TYPE_TEXT,
                       A.COMPLAINT_ROLE,
                       A.COMPLAINT_NAME,                       
                       A.COMPLAINT_CODE,
                       A.COMPLAINT_ADRESS,
                       A.COMPLAINT_DNAME,
                       A.COMPLAINT_ZW,
                       A.COMPLAINT_FAX,
                       A.COMPLAINT_PC,
                       A.COMPLAINT_CONTACT,
                       A.COMPLAINT_PHONE,
                       A.COMPLAINT_EMAIL,
                       A.COMPLAINT_CONTACT_IDCARD,
                       A.COMPLAINT_CONTACT_PHONE,
                       A.COMPLAINT_CONTACT_EMAIL,
                       A.COMPLAINT_LEGAL,
                       A.COMPLAINT_LEGAL_IDCARD,
                       A.COMPLAINT_LEGAL_PHONE,
                       A.COMPLAINT_LEGAL_ISWT,
                       (CASE A.COMPLAINT_LEGAL_ISWT WHEN 1 THEN '是' ELSE '否' END) COMPLAINT_LEGAL_ISWT_TEXT,
                       A.COMPLAINT_BWTR,
                       A.COMPLAINT_BWTR_IDCARD,
                       A.COMPLAINT_BWTR_BMZW,
                       A.COMPLAINT_BWTR_PHONE,
                       A.COMPLAINT_ISAGENCY,
                       (CASE A.COMPLAINT_ISAGENCY WHEN '1' THEN '是' ELSE '否' END) COMPLAINT_ISAGENCY_TEXT,
                       A.COMPLAINT_AGENCY,
                       A.COMPLAINT_AGENCY_CODE,
                       A.COMPLAINT_AGENCY_FAX,
                       A.COMPLAINT_AGENCY_PC,
                       A.COMPLAINT_AGENCY_LXR,
                       A.COMPLAINT_AGENCY_PHONE,
                       A.COMPLAINT_AGENCY_ADRESS,
                       A.TENDER_PROJECT_CODE,
                       A.TENDER_PROJECT_NAME,
                       A.TENDER_CLASS,
                       L.TEXT AS TENDER_CLASS_TEXT,
                       A.COMPLAINT_SX AS COMPLAINT_SX,
                       I.TEXT AS COMPLAINT_SX_TEXT,
                       A.COMPLAINT_TITLE,
                       A.COMPLAINT_CONTENT,
                       A.TSS_AIDS,
                       A.YYZM_AIDS,
                       A.OTHER_AIDS,
                       A.ZMCL_AIDS,
                       A.FR_SFZ_AIDS,
                       A.WTR_SFZ_AIDS,
                       A.SQWTS_AIDS,
                       A.WTDLHT_AIDS,
                       A.AGENCY_CODE_AIDS,
                       A.AGENCY_SFZ_AIDS2,
                       A.SFZ_AIDS,
                       A.ACCEPT_DEPID AS ACCEPT_DEPID,
                       H.DNAME AS ACCEPT_DEPID_TEXT,
                       A.SIGN_STATE,
                       F.TEXT AS SIGN_STATE_TEXT,
                       A.SIGN_UID,
                       A.SIGN_AIDS,
                       J.MANAGE_NAME AS SIGN_UID_TEXT,
                       TO_CHAR(A.SIGN_TM, 'yyyy-mm-dd hh24:mi:ss') SIGN_TM,
                       A.SIGN_REMARK,
                       A.ACCEPT_STATE,
                       D.TEXT AS ACCEPT_STATE_TEXT,
                       A.ACCEPT_UID,
                       K.MANAGE_NAME AS ACCEPT_UID_TEXT,
                       TO_CHAR(A.ACCEPT_TM, 'yyyy-mm-dd hh24:mi:ss') ACCEPT_TM,
                       A.ACCEPT_REMARK,
                       A.ACCEPT_AIDS,
                       A.SCCZWT,
                       A.ACCEPT_TZS,
                       A.HANDLE_STATE,
                       E.TEXT AS HANDLE_STATE_TEXT,
                       TO_CHAR(A.HANDLE_TM, 'yyyy-mm-dd hh24:mi:ss') HANDLE_TM,
                       A.HANDLE_REMARK,
                       A.HANDLE_UID,
                       A.HANDLE_JL,
                       C.TEXT AS HANDLE_JL_TEXT,
                       A.HANDLE_AIDS,
                       A.HANDLE_JDS HANDLE_JDS,
                       A.IS_DELAY,
                      (CASE A.IS_DELAY WHEN '1' THEN '是' ELSE '否' END) IS_DELAY_TEXT,
                       A.DELAY_UID,
                       A.DELAY_AIDS,
                       TO_CHAR(A.DELAY_TM, 'yyyy-mm-dd') DELAY_TM,
                       TO_CHAR(A.OVER_TM, 'yyyy-mm-dd') OVER_TM,
                       A.DELAY_SMS,
                       A.REVOKE_YJS
                  FROM PT_ZXTS A
                       LEFT JOIN (SELECT TEXT,VALUE FROM SYS_DIC WHERE TYPE=72) B ON A.STATE=B.VALUE
                       LEFT JOIN (SELECT TEXT,VALUE FROM SYS_DIC WHERE TYPE=81) C ON A.HANDLE_JL=C.VALUE
                       LEFT JOIN (SELECT TEXT,VALUE FROM SYS_DIC WHERE TYPE=80) F ON A.SIGN_STATE=F.VALUE
                       LEFT JOIN (SELECT TEXT,VALUE FROM SYS_DIC WHERE TYPE=73) D ON A.ACCEPT_STATE=D.VALUE
                       LEFT JOIN (SELECT TEXT,VALUE FROM SYS_DIC WHERE TYPE=74) E ON A.HANDLE_STATE=E.VALUE
                       LEFT JOIN (SELECT TEXT,VALUE FROM SYS_DIC WHERE TYPE=71) G ON A.COMPLAINT_TYPE=G.VALUE
                       LEFT JOIN (SELECT DEPID,DNAME FROM T_USER_DEPARTMENT) H ON H.DEPID=A.ACCEPT_DEPID
                       LEFT JOIN (SELECT TEXT,VALUE FROM SYS_DIC WHERE TYPE=82) I ON I.VALUE=A.COMPLAINT_SX
                       LEFT JOIN (SELECT ID,USERNAME,MANAGE_NAME FROM T_USER) J ON J.ID=A.SIGN_UID
                       LEFT JOIN (SELECT ID,USERNAME,MANAGE_NAME FROM T_USER) K ON K.ID=A.ACCEPT_UID
                       LEFT JOIN (SELECT TEXT,VALUE FROM SYS_DIC WHERE TYPE=85) L ON L.VALUE=A.TENDER_CLASS
                 WHERE CODE =:code")
                    .AddInParameter(":code", DbType.AnsiString, code).First<dynamic>();
                if (obj == null)
                {
                    r.SetFail($"未找到投诉编号未{code}的投诉信息");
                }
                else
                {//被投诉人信息
                    var btsr = FromSql(@"SELECT NAME,
                           A.TYPE,
                           C.TEXT AS TYPE_TEXT,
                           A.CODE,
                           A.ADRESS,
                           A.CONTACT,
                           A.CONTACT_PHONE
                           FROM PT_ZXTS_BTSR A 
                           INNER JOIN PT_ZXTS B ON A.TS_ID=B.ID
                           LEFT JOIN (SELECT VALUE,TEXT FROM SYS_DIC WHERE TYPE=84) C ON C.VALUE=A.TYPE
                           WHERE B.CODE=:code")
                        .AddInParameter(":code", DbType.AnsiString, code).ToList<object>();
                    var btns = new List<string>();


                    string state = obj.STATE;
                    if (state == "1") // 待签收(可【撤销】)
                    {
                        btns.Add("REVOKE");
                    }

                    if (state == "2" || state == "4")// 待受理(可【申请撤诉】) 待处理(可【申请撤诉】)
                    {
                        btns.Add("SQCS");
                    }

                    //obj.STATE_TEXT = PT_ZXTS.StateText(state);
                    if (urlBuilder != null)
                    {
                        obj.HANDLE_JDS_ATTACHMENT = Jd.SysAttachmentService.FindAttachment(obj.HANDLE_JDS, urlBuilder);//处理决定书
                        obj.ACCEPT_TZS_ATTACHMENT = Jd.SysAttachmentService.FindAttachment(obj.ACCEPT_TZS, urlBuilder);//不予受理通知书
                        obj.DELAY_SMS_ATTACHMENT = Jd.SysAttachmentService.FindAttachment(obj.DELAY_SMS, urlBuilder);//延期说明书
                        obj.REVOKE_YJS_ATTACHMENT = Jd.SysAttachmentService.FindAttachment(obj.REVOKE_YJS, urlBuilder);//投诉撤回意见书
                        obj.YYZM_AIDS_ATTACHMENT = Jd.SysAttachmentService.FindAttachment(obj.YYZM_AIDS, urlBuilder);//异议证明文件
                        obj.ZMCL_AIDS_ATTACHMENT = Jd.SysAttachmentService.FindAttachment(obj.ZMCL_AIDS, urlBuilder);//有效线索相关证明材料
                        obj.FR_SFZ_AIDS_ATTACHMENT = Jd.SysAttachmentService.FindAttachment(obj.FR_SFZ_AIDS, urlBuilder);//法人身份证扫描件
                        obj.WTR_SFZ_AIDS_ATTACHMENT = Jd.SysAttachmentService.FindAttachment(obj.WTR_SFZ_AIDS, urlBuilder);//被授权委托人身份扫描件
                        obj.SQWTS_AIDS_ATTACHMENT = Jd.SysAttachmentService.FindAttachment(obj.SQWTS_AIDS, urlBuilder);//授权委托书
                        obj.WTDLHT_AIDS_ATTACHMENT = Jd.SysAttachmentService.FindAttachment(obj.WTDLHT_AIDS, urlBuilder);//委托代理合同
                        obj.AGENCY_CODE_AIDS_ATTACHMENT = Jd.SysAttachmentService.FindAttachment(obj.AGENCY_CODE_AIDS, urlBuilder);//委托代理机构统一社会信用代码证
                        obj.AGENCY_SFZ_AIDS2_ATTACHMENT = Jd.SysAttachmentService.FindAttachment(obj.AGENCY_SFZ_AIDS2, urlBuilder);//委托代理联系人身份证扫描件
                        obj.SFZ_AIDS_ATTACHMENT = Jd.SysAttachmentService.FindAttachment(obj.SFZ_AIDS, urlBuilder);//身份证复印件
                        obj.OTHER_AIDS_ATTACHMENT = Jd.SysAttachmentService.FindAttachment(obj.OTHER_AIDS, urlBuilder);//其他材料
                        obj.TSS_AIDS_ATTACHMENT = Jd.SysAttachmentService.FindAttachment(obj.TSS_AIDS, urlBuilder);//投诉书
                    }
                    var logs = FromSql(@"
                SELECT ROW_NUMBER() OVER(ORDER BY A.RECORDER_TM DESC) AS RN,
                       A.RECORDER_DEPID,(SELECT DNAME FROM T_USER_DEPARTMENT WHERE DEPID =  A.RECORDER_DEPID) RECORDER_DEPNAME,
                       A.RECORDER_UNAME,
                       TO_CHAR(A.RECORDER_TM,'yyyy-mm-dd hh24:mi:ss') AS RECORDER_TM,
                       C.TEXT AS RECORDER_OPERATION,
                       A.RECORDER_REMARK,
                       A.RECORDER_AIDS
                  FROM PT_ZXTS_LOG A
                       INNER JOIN PT_ZXTS B ON A.TS_ID=B.ID
                       LEFT JOIN (SELECT TEXT,VALUE FROM SYS_DIC WHERE TYPE=75) C ON A.RECORDER_OPERATION=C.VALUE
                 WHERE B.CODE =:code")
                        .AddInParameter(":code", DbType.AnsiString, code).ToList<dynamic>();
                    obj.Logs = logs;
                    obj.Button = btns;
                    obj.BTSR = btsr;
                    r.SetSuccess((object)obj);
                }
            }
            else
            {
                r.SetFail("您没有查看该投诉信息的权限或查询已过期，请重新发起查询");
            }
            return r;
        }
        /// <summary>
        /// 撤销
        /// </summary>
        /// <param name="code">投诉编号</param>
        /// <param name="mobile">电话号码</param>
        /// <param name="remark">撤销原由</param>
        /// <returns></returns>
        public GeneralResult OnlineComplaintRevoke(string code, string mobile, string remark)
        {

            var r = new GeneralResult();
            if (Cache.IsSet($"{ConfigHelper.APP_KEY_GGZYJD}:PT:PT_ZXTS:{mobile}_{code}"))
            {
                var obj = FirstOrNull(PT_ZXTS._.CODE == code);

                if (obj == null) { r.SetFail($"未找到投诉编号未{code}的投诉信息"); }
                else if (obj.STATE != "1") { r.SetFail("当前该投诉无法撤销，请刷新页面！"); }
                else if (string.IsNullOrWhiteSpace(remark)) { r.SetFail("请填写撤销原由！"); }
                else
                {
                    using (var trans = GetDbSession().BeginTransaction())
                    {
                        var now = DateTime.Now;

                        #region 添加投诉申请

                        trans.Insert(new PT_ZXTS_REVOKE
                        {
                            ID = 0,
                            TS_ID = obj.ID,
                            TYPE = "1", //1:撤销；2:申请撤诉；
                            TM = now,
                            REMARK = remark
                        });

                        #endregion

                        #region 修改在线投诉状态

                        obj.Attach();
                        obj.STATE = "9";//9:撤销投诉
                        obj.DATA_TIMESTAMP = now;
                        trans.Update(obj);

                        #endregion

                        #region 添加操作记录

                        trans.Insert(new PT_ZXTS_LOG
                        {
                            ID = 0,
                            TS_ID = obj.ID,
                            RECORDER_UNAME = "投诉人",
                            RECORDER_OPERATION = "9",//操作：9:撤销投诉
                            RECORDER_REMARK = remark,
                            RECORDER_TM = now
                        });

                        #endregion

                        #region 发送短信

                        var msgFormat = ConfigHelper.AppSettings.SmsZXTS_CX;
                        var content = string.Format(msgFormat, obj.TENDER_PROJECT_NAME, "撤销");
                        var users = Jd.TUserService.FindSendMsgByDepartId(obj.ACCEPT_DEPID);
                        if (users.Any())
                        {
                            var dTime = Jd.THolidayService.GetWorkDate(DateTime.Now, 0);
                            if (dTime.Date != DateTime.Now.Date)
                            {
                                dTime = DateTime.Parse(dTime.ToString("yyyy-MM-dd 09:00:00"));
                            }

                            var smsSend = users.Select(c => new T_SMS_SEND
                            {
                                ID = 0,
                                MODULE_NAME = "在线投诉模块",
                                OPER_BY = JdUser?.ID,
                                RETRY = 0,
                                STATUS = 0,
                                TEL_PHONE = c.TELPHONE,
                                SMS_CONTENT = content,
                                YJ_SEND_TM = dTime,
                            }).ToList();
                            trans.Insert(smsSend);
                        }

                        #endregion

                        trans.Commit();
                    }

                    r.SetSuccess();
                }
            }
            else
            {
                r.SetFail("您没有查看该投诉信息的权限或查询已过期，请重新发起查询");
            }
            return r;
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
        public GeneralResult OnlineComplaintSQCS(string code, string mobile, string remark, List<UploadResData> revokeAttachments, List<UploadResData> otherAttachements)
        {
            var r = new GeneralResult();
            if (Cache.IsSet($"{ConfigHelper.APP_KEY_GGZYJD}:PT:PT_ZXTS:{mobile}_{code}"))
            {
                var model = FirstOrNull(PT_ZXTS._.CODE == code);

                if (model == null) { r.SetFail($"未找到投诉编号未{code}的投诉信息"); }
                else if (model.STATE != "4" && model.STATE != "2") { r.SetFail("当前该投诉无法申请撤诉，请刷新页面！"); }
                else if (string.IsNullOrWhiteSpace(remark)) { r.SetFail("请填写撤销原由！"); }
                else if (revokeAttachments == null || !revokeAttachments.Any()) { r.SetFail("请上传书面撤诉原由附件！"); }
                //else if (otherAttachements==null||!otherAttachements.Any()) { r.SetFail("请上传其他附件！"); }
                else
                {
                    using (var trans = GetDbSession().BeginTransaction())
                    {
                        var now = DateTime.Now;

                        #region 附件处理

                        var revokeSysAttachment = revokeAttachments.Select(c =>
                            c.JdSysAttachment(JdUser?.ID, Jd.SysAttachmentService.MaxOrderId)).ToList();
                        trans.Insert(revokeSysAttachment);
                        var revokeAids = string.Join(",", revokeSysAttachment.Select(c => c.GUID));
                        var otherAids = string.Empty;
                        if (otherAttachements != null && otherAttachements.Any())
                        {
                            var otherSysAttachment = otherAttachements.Select(c =>
                                c.JdSysAttachment(JdUser?.ID, Jd.SysAttachmentService.MaxOrderId)).ToList();
                            trans.Insert(otherSysAttachment);
                            otherAids = string.Join(",", otherSysAttachment.Select(c => c.GUID));
                        }

                        #endregion
                        #region 添加投诉申请

                        trans.Insert(new PT_ZXTS_REVOKE
                        {
                            ID = 0,
                            TS_ID = model.ID,
                            TYPE = "2", //1:撤销；2:申请撤诉；
                            TM = now,
                            REMARK = remark,
                            REVOKE_AIDS = revokeAids,
                            OTHER_AIDS = otherAids,
                            APPROVAL_STATE = 1, //审查状态：1.待审查 2.同意撤回 3.不予撤回
                        });

                        #endregion

                        #region 修改在线投诉状态

                        model.Attach();
                        model.STATE = "6";//9:申请撤诉
                        model.DATA_TIMESTAMP = now;
                        trans.Update(model);

                        #endregion

                        #region 添加操作记录
                        var recordAids = $"{revokeAids}{(string.IsNullOrWhiteSpace(otherAids) ? "" : "," + otherAids)}";
                        trans.Insert(new PT_ZXTS_LOG
                        {
                            ID = 0,
                            TS_ID = model.ID,
                            RECORDER_UNAME = "投诉人",
                            RECORDER_OPERATION = "6",//操作：9:撤销投诉
                            RECORDER_REMARK = remark,
                            RECORDER_TM = now,
                            RECORDER_AIDS = recordAids
                        });

                        #endregion

                        #region 发送短信

                        SendMsgTs(model, trans, "撤销投诉");

                        #endregion

                        trans.Commit();
                    }

                    r.SetSuccess();
                }
            }
            else
            {
                r.SetFail("您没有查看该投诉信息的权限或查询已过期，请重新发起查询");
            }
            return r;
        }
        /// <summary>
        /// 在线投诉【审查人员】待受理、待处理的短信
        /// </summary>
        /// <param name="model"></param>
        /// <param name="trans"></param>
        /// <param name="op"></param>
        protected void SendMsgTs(PT_ZXTS model, DbTrans trans, string op)
        {
            var msgFormat = ConfigHelper.AppSettings.SmsZXTS_OP;
            var content = string.Format(msgFormat, model.TENDER_PROJECT_NAME, op);
            List<T_USER> users = null;
            if (model.ACCEPT_STATE == "1")//受理时提交"申请撤诉",发送短信到受理人
            {
                users = Jd.TUserService.FindSendMsgByUid(model.ACCEPT_UID);
            }

            if (model.HANDLE_STATE == "1")//处理时提交"申请撤诉"
            {
                if (model.HANDLE_UID == -1)
                {
                    users = Jd.TUserService.FindSendMsgByDepartId(model.ACCEPT_DEPID);
                }
                else
                {
                    users = Jd.TUserService.FindSendMsgByUid(model.ACCEPT_UID);
                }
            }
            if (users != null && users.Any())
            {
                var dTime = Jd.THolidayService.GetWorkDate(DateTime.Now, 0);
                if (dTime.Date != DateTime.Now.Date)
                {
                    dTime = DateTime.Parse(dTime.ToString("yyyy-MM-dd 09:00:00"));
                }

                var smsSend = users.Select(c => new T_SMS_SEND
                {
                    ID = 0,
                    MODULE_NAME = "在线投诉模块",
                    OPER_BY = JdUser?.ID,
                    RETRY = 0,
                    STATUS = 0,
                    TEL_PHONE = c.TELPHONE,
                    SMS_CONTENT = content,
                    YJ_SEND_TM = dTime,
                }).ToList();
                trans.Insert(smsSend);
            }
        }

        /// <summary>
        /// 在线投诉【审查人员】签收、受理、不予受理、处理、不予撤诉、同意撤诉的短信
        /// </summary>
        /// <param name="model"></param>
        /// <param name="trans"></param>
        /// <param name="op"></param>
        protected void SendMsgTSR(PT_ZXTS model, DbTrans trans, string op)
        {
            if (string.IsNullOrWhiteSpace(model.ACCEPT_DEPID)) return;
            var msgFormat = ConfigHelper.AppSettings.SmsZXTS_TSR;
            var acceptDepartment = Jd.TUserDepartmentService.FirstOrNull(T_USER_DEPARTMENT._.DEPID == model.ACCEPT_DEPID);
            var dName = string.Empty;
            if (acceptDepartment != null)
            {
                dName = acceptDepartment.DNAME;
            }
            var content = string.Format(msgFormat, model.TENDER_PROJECT_NAME, model.CODE, dName, op);
            var phone = model.COMPLAINT_TYPE == "1" ? model.COMPLAINT_CONTACT_PHONE : model.COMPLAINT_TYPE == "2" ? model.COMPLAINT_PHONE : "";
            if (!string.IsNullOrWhiteSpace(phone))
            {
                var dTime = Jd.THolidayService.GetWorkDate(DateTime.Now, 0);
                if (dTime.Date != DateTime.Now.Date)
                {
                    dTime = DateTime.Parse(dTime.ToString("yyyy-MM-dd 09:00:00"));
                }
                var smsSend = new T_SMS_SEND
                {
                    ID = 0,
                    MODULE_NAME = "在线投诉模块",
                    OPER_BY = JdUser?.ID,
                    RETRY = 0,
                    STATUS = 0,
                    TEL_PHONE = phone,
                    SMS_CONTENT = content,
                    YJ_SEND_TM = dTime,
                };
                trans.Insert(smsSend);
            }


        }

        /// <summary>
        /// 在线投诉书
        /// </summary>
        /// <param name="complaint">投诉主体信息</param>
        /// <param name="respondents">被投诉人</param>
        /// <returns></returns>
        public GeneralResult OnlineComplaintLetter(PT_ZXTS complaint, List<PT_ZXTS_BTSR> respondents)
        {
            var r = new GeneralResult();
            try
            {
                var tempPath = HttpContext.Current.Server.MapPath($"~/Infrastructure/Templates/投诉书模板.docx");
                if (!File.Exists(tempPath))
                {
                    r.SetFail($"未找到投诉书模板");
                }
                else
                if (respondents == null || !respondents.Any())
                {
                    r.SetFail("请添加被投诉人信息");
                }
                else
                {
                    var word = new AsposeWord(tempPath);
                    NodeCollection allTables = word.doc.GetChildNodes(NodeType.Table, true);

                    #region 投诉人为法人

                    if (complaint.COMPLAINT_TYPE == "1")//投诉人为法人
                    {
                        (allTables[1] as Aspose.Words.Tables.Table)?.Remove();//拿到第2个表格，自然人信息的

                        //法人 移除多余附件
                        Cell cell = word.GetFirstCellByText("{SFZ_AIDS}");
                        cell.ParentRow.Remove();
                        if (complaint.COMPLAINT_LEGAL_ISWT != 1)//非委托人
                        {
                            cell = word.GetFirstCellByText("被委托人姓名：{COMPLAINT_BWTR}");
                            cell.ParentRow.Remove();
                            cell = word.GetFirstCellByText("{WTR_SFZ_AIDS}");
                            cell.ParentRow.Remove();
                            //word.ReplaceText("被委托人姓名：{COMPLAINT_BWTR}", "");
                            //word.ReplaceText("被委托人身份证号：{COMPLAINT_BWTR_IDCARD}", "");
                            //word.ReplaceText("所在部门与职务：{COMPLAINT_BWTR_BMZW}", "");
                            //word.ReplaceText("手机号码：{COMPLAINT_BWTR_PHONE}", "");
                        }

                        if (complaint.COMPLAINT_ISAGENCY != "1")//非委托代理机构投诉
                        {
                            cell = word.GetFirstCellByText("委托代理机构名称：{COMPLAINT_AGENCY}");
                            cell.ParentRow.Remove();
                            cell = word.GetFirstCellByText("{WTDLHT_AIDS}");
                            cell.ParentRow.Remove();
                            //word.ReplaceText("委托代理机构名称：{COMPLAINT_AGENCY}", "");
                            //word.ReplaceText("委托代理机构统一社会信用代码证：{COMPLAINT_AGENCY_CODE}", "");
                            //word.ReplaceText("委托代理机构地址：{COMPLAINT_AGENCY_ADRESS}", "");
                            //word.ReplaceText("委托代理机构邮编：{COMPLAINT_AGENCY_PC}", "");
                            //word.ReplaceText("委托代理机构联系人：{COMPLAINT_AGENCY_LXR}", "");
                            //word.ReplaceText("委托代理机构手机：{COMPLAINT_AGENCY_PHONE}", "");
                        }
                    }

                    #endregion

                    #region 投诉人不为法人

                    else
                    {
                        (allTables[0] as Aspose.Words.Tables.Table)?.Remove();//拿到第一个表格，法人信息
                        //自然人 移除多余附件
                        Cell cell = word.GetFirstCellByText("{FR_SFZ_AIDS}");
                        cell.ParentRow.Remove();
                        cell = word.GetFirstCellByText("{WTR_SFZ_AIDS}");//授权委托人相关附件
                        cell.ParentRow.Remove();
                        cell = word.GetFirstCellByText("{WTDLHT_AIDS}"); //委托代理机构相关附件
                        cell.ParentRow.Remove();
                        //titleCell = word.GetFirstCellByText("{LEGAL}");//获取标题所在单元格
                        //word.ReplaceText(titleCell.ParentRow.Range, "{LEGAL}", "");
                    }

                    #endregion

                    #region 替换模板信息

                    string[] aidCols = new string[] { "YYZM_AIDS", "ZMCL_AIDS", "FR_SFZ_AIDS", "WTR_SFZ_AIDS", "SQWTS_AIDS", "WTDLHT_AIDS", "AGENCY_CODE_AIDS", "AGENCY_SFZ_AIDS2", "SFZ_AIDS", "OTHER_AIDS" };
                    var properties = complaint.GetPropertyInfos();
                    for (int i = 0; i < allTables.Count; i++)//循环获取模板中的所有表格，完成替换
                    {
                        //Aspose.Words.Tables.Table table = allTables[i] as Aspose.Words.Tables.Table;
                        //Cell cell = table.Rows[0].Cells[0];
                        //string Text = cell.GetText();
                        foreach (var info in properties)
                        {
                            var key = info.Name;
                            var value = info.GetValue(complaint, null) == null ? String.Empty : info.GetValue(complaint, null).ToString();
                            if (key == "COMPLAINT_CONTENT")
                            {
                                word.ReplaceHtml($"{{{key}}}", value);
                            }
                            else if (aidCols.Contains(key))
                            {
                                var htmlBuilder = new StringBuilder();
                                var attachments = Jd.SysAttachmentService.FindFileCenterAttachmentsByGuids(value);
                                if (attachments != null && attachments.Any())
                                {
                                    foreach (var attachment in attachments)
                                    {
                                        var fileName = attachment.FILETILE ?? attachment.FILETYPE;
                                        htmlBuilder.Append($@"<div title='{fileName}'>");
                                        htmlBuilder.Append($@"<a target='_blank' href='{attachment.FILEPATH}'>{fileName}</a>");
                                        if (!string.IsNullOrWhiteSpace(attachment.MD5))
                                        {
                                            htmlBuilder.Append($"[MD5:{attachment.MD5}]");
                                        }

                                        htmlBuilder.Append("</div>");
                                    }
                                }
                                var html = htmlBuilder.ToString();
                                word.ReplaceHtml($"{{{key}}}", html);
                            }
                            else
                            {
                                word.ReplaceText($"{{{key}}}", value);
                            }
                        }
                    }

                    #endregion

                    #region 被投诉人

                    var dt = respondents.ToDataTable();
                    dt.TableName = "BTSR";
                    word.doc.MailMerge.ExecuteWithRegions(dt);

                    word.ReplaceText("{TIME}", DateTime.Now.ToString("yyyy年MM月dd日"));
                    word.ReplaceText("{COMPLAINT_NAME}", complaint.COMPLAINT_NAME);

                    #endregion

                    #region 生成在线投诉

                    using (Stream ms = new MemoryStream())
                    {
                        word.doc.Save(ms, SaveFormat.Pdf);
                        ms.Seek(0, SeekOrigin.Begin);
                        var uploadResult = FileHelper.Uploader.UploadStream($"{Guid.NewGuid():N}.pdf", ms);
                        if (uploadResult.Result)
                        {
                            uploadResult.Data.Url =
                                uploadResult.Data.Url.Replace(ConfigHelper.AppSettings.UploadHost, "");
                            r.SetSuccess(uploadResult.Data);
                        }
                        else
                        {
                            r.SetFail(uploadResult.Msg);
                        }
                    }
                    #endregion
                }
            }
            catch (Exception e)
            {
                r.SetException($"生成在线投诉书异常,{e.Message}", e);
            }

            return r;
        }
        /// <summary>
        /// 提交在线投诉信息
        /// </summary>
        /// <param name="complaint">投诉主体信息</param>
        /// <param name="respondents">被投诉人</param>
        /// <returns></returns>
        public GeneralResult SaveOnlineComplaint(PT_ZXTS complaint, List<PT_ZXTS_BTSR> respondents)
        {
            complaint.TYPE = "1"; //投诉类型
            var r = ValidateComplaintParameter(complaint, respondents);
            if (r.Success)
            {
                var complaintCode = CreateComplaintCode();
                Task.Run(() =>
                {
                    #region 添加数据到数据库

                    DateTime now = DateTime.Now;

                    complaint.ID = 0;
                    complaint.CODE = complaintCode;
                    complaint.STATE = "1"; //待受理
                    complaint.TYPE = "1"; //投诉类型
                    complaint.SIGN_STATE = "1"; //签收状态（改为待签收）
                    complaint.CREATE_TM = now;
                    complaint.DATA_TIMESTAMP = now;
                    complaint.OVER_TM = Jd.THolidayService.OverTime(now);
                    using (var trans = GetDbSession().BeginTransaction())
                    {
                        var tsid = trans.Insert(complaint);
                        respondents = respondents.Select(c =>
                        {
                            c.ID = 0;
                            c.TS_ID = tsid;
                            return c;
                        }).ToList();
                        trans.Insert(respondents);
                        trans.Insert(new PT_ZXTS_LOG
                        {
                            ID = 0,
                            TS_ID = tsid,
                            RECORDER_UNAME = "投诉人",
                            RECORDER_OPERATION = "1", //操作：1.提交投诉
                            RECORDER_TM = now
                        });

                        #region 部门短信提醒

                        var msg = ConfigHelper.AppSettings.SmsZXTS_SIGN;
                        if (!string.IsNullOrWhiteSpace(msg))
                        {
                            var obj = FromSql(@"
            SELECT WM_CONCAT(A.TELPHONE) AS TELPHONES 
              FROM T_USER A
                   LEFT JOIN PT_ZXTS_DEPCONFIG B ON A.ID=B.USER_ID AND A.DEPARTID=B.DEP_ID
             WHERE IS_SEND_MSG=1 AND IS_ENABLE=1 AND TYPE=0 AND DEPARTID=:depid")
                                .AddInParameter(":depid", DbType.AnsiString, complaint.ACCEPT_DEPID).ToFirst<object>();
                            if (obj != null && obj is EntityUtils.FastExpando dataDic && dataDic.Data.ContainsKey("TELPHONES"))
                            {
                                var phones = dataDic.Data["TELPHONES"]?.ToString();
                                msg = string.Format(msg, complaint.TENDER_PROJECT_NAME);
                                if (!string.IsNullOrWhiteSpace(phones))
                                {
                                    DateTime dTime = Jd.THolidayService.GetWorkDate(DateTime.Now, 0);
                                    if (dTime.Date != DateTime.Now.Date)
                                    {
                                        dTime = DateTime.Parse(dTime.ToString("yyyy-MM-dd 09:00:00"));
                                    }

                                    foreach (string p in phones.Split(','))
                                    {
                                        var model = new T_SMS_SEND
                                        {
                                            ID=0,
                                            MODULE_NAME = "在线投诉模块",
                                            OPER_BY = JdUser?.ID,
                                            RETRY = 0,
                                            STATUS = 0,
                                            TEL_PHONE = p,
                                            SMS_CONTENT = msg,
                                            YJ_SEND_TM = dTime
                                        };
                                        trans.Insert(model);
                                    }
                                }
                            }
                        }

                        #endregion

                        trans.Commit();
                    }


                    #endregion

                    #region 发送邮件

                    string email = complaint.COMPLAINT_TYPE == "1"
                        ? complaint.COMPLAINT_CONTACT_EMAIL
                        : complaint.COMPLAINT_EMAIL;

                    string body = "亲爱的用户：您好！<br />";
                    body += "&nbsp;&nbsp;您现在“福建省公共资源交易电子行政监督平台”提交了一个投诉。<br />";
                    body += "&nbsp;&nbsp;投诉编号为：" + complaint.CODE + ",我们将尽快处理您的投诉，请耐心等待，不要重复提交。感谢您的支持！";
                    EmailUtils.SendEmail(email, body, "福建省公共资源交易电子行政监督平台");

                    #endregion
                });


                r.SetSuccess(new { CODE = complaintCode });

            }

            return r;
        }
        /// <summary>
        /// 参数校验
        /// </summary>
        /// <param name="complaint"></param>
        /// <param name="respondents"></param>
        /// <returns></returns>
        protected GeneralResult ValidateComplaintParameter<T>( T complaint, List<PT_ZXTS_BTSR> respondents)
        {
            var r = new GeneralResult();
            if (respondents == null || !respondents.Any())
            {
                r.SetFail($"请添加被投诉人信息");
            }
            else
            {
                r.SetSuccess();
                #region 需要验证的字段集合

                string[] cols=new String[]{};
                var type = complaint.PropertyToString("TYPE");//1 线上 2 线下 3 闽政通
                var complaintType = complaint.PropertyToString("COMPLAINT_TYPE");//1 法人 2 自然人
                if ( type== "1") //线上
                {
                    if (complaintType == "1")
                    {
                        cols = new[]
                        {
                        "COMPLAINT_ROLE","COMPLAINT_TYPE",
                        "COMPLAINT_CODE",
                        "COMPLAINT_DNAME",
                        "COMPLAINT_ADRESS",
                        "COMPLAINT_PC",
                        "COMPLAINT_CONTACT",
                        "COMPLAINT_CONTACT_IDCARD",
                        "COMPLAINT_CONTACT_PHONE",
                        "COMPLAINT_CONTACT_EMAIL",
                        "COMPLAINT_LEGAL",
                        "COMPLAINT_LEGAL_IDCARD",
                        "COMPLAINT_LEGAL_PHONE",
                        "COMPLAINT_LEGAL_ISWT",
                        "COMPLAINT_ISAGENCY",
                        "TENDER_PROJECT_NAME",
                        "TENDER_PROJECT_CODE",
                        "TENDER_CLASS",
                        "COMPLAINT_SX",
                        "COMPLAINT_TITLE",
                        "COMPLAINT_CONTENT",
                        "TSS_AIDS",
                        "YYZM_AIDS",
                        "FR_SFZ_AIDS",
                        "ZMCL_AIDS",
                        "ACCEPT_DEPID"
                    };
                    }
                    else
                    {
                        cols = new string[] {
                        "COMPLAINT_NAME",
                        "COMPLAINT_TYPE" ,
                        "COMPLAINT_CODE" ,
                        "COMPLAINT_PHONE" ,
                        "COMPLAINT_EMAIL",
                        "COMPLAINT_DNAME",
                        //"COMPLAINT_ZW",
                        "COMPLAINT_ADRESS",
                        "COMPLAINT_PC",
                        "TENDER_PROJECT_NAME",
                        "TENDER_PROJECT_CODE",
                        "TENDER_CLASS",
                        "COMPLAINT_SX",
                        "COMPLAINT_TITLE",
                        "COMPLAINT_CONTENT",
                        "TSS_AIDS",
                        "YYZM_AIDS",
                        "ZMCL_AIDS",
                        "ACCEPT_DEPID"};
                    }
                }
                else if (type == "3") //闽政通
                {
                    if (complaintType == "2") //自然人
                    {
                        cols = new string[] {
                            "COMPLAINT_NAME",
                            "COMPLAINT_TYPE" ,
                            "COMPLAINT_CODE" ,
                            "COMPLAINT_PHONE" ,
                            "COMPLAINT_EMAIL",
                            "COMPLAINT_DNAME",
                            //"COMPLAINT_ZW",
                            "COMPLAINT_ADRESS",
                            "COMPLAINT_PC",
                            "TENDER_PROJECT_NAME",
                            "TENDER_PROJECT_CODE",
                            "TENDER_CLASS",
                            "COMPLAINT_SX",
                            "COMPLAINT_TITLE",
                            "COMPLAINT_CONTENT",
                            //"TSS_AIDS",//闽政通不生成投诉书
                            "YYZM_AIDS",
                            "ZMCL_AIDS",
                            "ACCEPT_DEPID"};
                    }
                }
                else
                {
                    cols = new[] { "COMPLAINT_ROLE", "COMPLAINT_DNAME", "CREATE_TM", "TENDER_PROJECT_NAME", "TENDER_CLASS", "COMPLAINT_SX", "COMPLAINT_TITLE", "COMPLAINT_CONTENT" };
                }

                #endregion

                var props = complaint.GetPropertyInfos();
                foreach (var col in cols)
                {
                    if (col != "OTHER_AIDS")
                    {
                        var prop = props.FirstOrDefault(c => c.Name == col);
                        if (prop == null)
                        {
                            r.SetFailEx($"数据不完整", $"未找到属性{col}");
                            break;
                        }
                        var v = prop.GetValue(complaint, null)?.ToString();
                        if (string.IsNullOrWhiteSpace(v))
                        {
                            r.SetFailEx($"数据不完整", $"属性{col}值为空 {v}");
                            break;
                        }
                    }
                }
            }
            return r;
        }

        /// <summary>
        /// 生成投诉编号
        /// </summary>
        /// <returns></returns>

        public string CreateComplaintCode(string codeType = "")
        {
            var dailyComplaintCodeKey = !string.IsNullOrWhiteSpace(codeType) ? $"DAILY:COMPLAINT:CODE:{codeType}" : $"DAILY:COMPLAINT:CODE";

            var codeIdxStr = Cache.Get(dailyComplaintCodeKey, (int)(DateTime.Today.AddDays(1).AddSeconds(-1) - DateTime.Now).TotalMinutes, () => "-1");
            var codeIdx = Convert.ToInt32(codeIdxStr) + 1;
            Cache.Set(dailyComplaintCodeKey, codeIdx, (int)(DateTime.Today.AddDays(1).AddSeconds(-1) - DateTime.Now).TotalMinutes);
            var complaintCode = codeIdx.ToString().PadLeft(4, '0');
            var code = $"{codeType}{DateTime.Today:yyyyMMdd}{complaintCode}";
            return code;
        }

        #endregion

        #region 后台


        #region (线上线下)在线投诉处理（线上:通过门户网站在线提交,TYPE=1 线下:线下收到投诉材料在后台录入,TYPE=2）

        /// <summary>
        /// (线上线下)在线投诉信息处理 计数接口
        /// </summary>
        /// <returns></returns>
        public List<PtZxtsCountModel> ComplaintCount()
        {
            var jdUserId = JdUser.ID;//  781;// 
            var departmentId = JdUser.DEPARTID;//  388;// 
            var onlineWhereClip = (PT_ZXTS._.ACCEPT_DEPID == departmentId && PT_ZXTS._.TYPE == "1");
            var outlineWhereClip = (PT_ZXTS._.CREATE_UID == jdUserId && PT_ZXTS._.TYPE == "2");
            var all = new List<PtZxtsCountModel>
            {
                new PtZxtsCountModel
                {
                    Label = "全部",
                    Count = "0",
                    SearchType = ""
                }
            };

            #region 待受理

            var dsl = FromWhere(onlineWhereClip && PT_ZXTS._.STATE == "2" && PT_ZXTS._.ACCEPT_UID == jdUserId)
                .Select(new Field("'DSL'").As("SearchType"), new Field("'待受理'").As("Label"),
                    PT_ZXTS._.ID.Count().As("Count"));

            #endregion

            #region 待处理

            var dcl = FromWhere(
                    (onlineWhereClip &&
                     (PT_ZXTS._.STATE == "4" || PT_ZXTS._.STATE.In('6', '7') && PT_ZXTS._.HANDLE_STATE == "1") &&
                     (PT_ZXTS._.HANDLE_UID == jdUserId ||
                      (PT_ZXTS._.HANDLE_UID == -1 && PT_ZXTS_DEPCONFIG._.USER_ID == jdUserId))) ||
                    (outlineWhereClip && PT_ZXTS._.STATE == "0"))
                .LeftJoin<PT_ZXTS_DEPCONFIG>(PT_ZXTS_DEPCONFIG._.DEP_ID == PT_ZXTS._.ACCEPT_DEPID &&
                                             PT_ZXTS_DEPCONFIG._.USER_ID == jdUserId)
                .Select(new Field("'DCL'").As("SearchType"), new Field("'待处理'").As("Label"),
                    PT_ZXTS._.ID.Count().As("Count"));

            #endregion

            #region 即将到期未处理

            var jjdqwcl = FromWhere(onlineWhereClip && (PT_ZXTS._.STATE == "4" ||
                                                        (PT_ZXTS._.STATE.In('6', '7') && PT_ZXTS._.HANDLE_STATE == "1"))
                                                    && (PT_ZXTS._.HANDLE_UID == jdUserId ||
                                                        (PT_ZXTS._.HANDLE_UID == -1 &&
                                                         PT_ZXTS_DEPCONFIG._.USER_ID == jdUserId))
                                                    && PT_ZXTS._.OVER_TM.IsNotNull() && "OVER_TM>=SYSDATE" &&
                                                    "OVER_TM<=SYSDATE+7")
                .LeftJoin<PT_ZXTS_DEPCONFIG>(PT_ZXTS_DEPCONFIG._.DEP_ID == PT_ZXTS._.ACCEPT_DEPID &&
                                             PT_ZXTS_DEPCONFIG._.USER_ID == jdUserId)
                .Select(new Field("'JJDQWCL'").As("SearchType"), new Field("'即将到期未处理'").As("Label"),
                    PT_ZXTS._.ID.Count().As("Count"));

            #endregion

            #region 投诉人申请撤诉

            var tsrsqcs = FromWhere(onlineWhereClip && PT_ZXTS._.STATE == "6" &&
                                    (PT_ZXTS._.HANDLE_UID == jdUserId ||
                                     (PT_ZXTS._.HANDLE_UID.Nvl(-1) == "-1" && PT_ZXTS_DEPCONFIG._.USER_ID == jdUserId)))
                .LeftJoin<PT_ZXTS_DEPCONFIG>(PT_ZXTS_DEPCONFIG._.DEP_ID == PT_ZXTS._.ACCEPT_DEPID &&
                                             PT_ZXTS_DEPCONFIG._.USER_ID == jdUserId)
                .Select(new Field("'TSRSQCS'").As("SearchType"), new Field("'投诉人申请撤诉'").As("Label"),
                    PT_ZXTS._.ID.Count().As("Count"));

            #endregion

            var obj = FromWhere().InnerJoin<PT_ZXTS_DEPCONFIG>(onlineWhereClip && PT_ZXTS._.STATE == "1" && PT_ZXTS_DEPCONFIG._.USER_ID == jdUserId && PT_ZXTS_DEPCONFIG._.DEP_ID == PT_ZXTS._.ACCEPT_DEPID)
                .Select(new Field("'DQS'").As("SearchType"), new Field("'待签收'").As("Label"), PT_ZXTS._.ID.Count().As("Count"))
                .UnionAll(dsl)//待受理
                .UnionAll(dcl)//待处理
                .UnionAll(jjdqwcl)//即将到期未处理
                .UnionAll(tsrsqcs)//投诉人申请撤诉
                .ToList<PtZxtsCountModel>();
            all.AddRange(obj);
            //all.RemoveAll(c => c.Count == "0" && (c.SearchType == "DCL" || c.SearchType == "DSL"));
            if (!Jd.PtZxtsDepconfigService.HasReceiptPermission())
            {
                all.RemoveAll(c => c.SearchType == "DQS");
            }
            return all;
        }

        /// <summary>
        /// (线上线下)在线投诉信息处理 列表接口
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult ComplaintPageList(PtZxtsModel model, SearchCondition search)
        {
            var condition = model.ConditionBuilder(search);// new WhereClipBuilder();

            //STATE 状态（1待签收，2待受理，3不予受理，4待处理，5已处理，6申请撤诉，7不予撤诉，8同意撤诉，9撤销 type=72）
            //HANDLE_STATE 处理状态(1待处理2已处理type=74)
            #region 用户过滤

            var jdUserId = JdUser.ID;//  781;//882
            var departmentId = JdUser.DEPARTID;//  388;// 
            if (jdUserId != 1)//id=1 strong 账号
            {
                var onlineWhereClip = (PT_ZXTS._.ACCEPT_DEPID == departmentId && (PT_ZXTS._.TYPE == "1"|| PT_ZXTS._.TYPE == "3"));//线上投诉
                var outlineWhereClip = (PT_ZXTS._.CREATE_UID == jdUserId && PT_ZXTS._.TYPE == "2");//线下投诉
                if (model.DaiBan)
                {
                    condition.And(onlineWhereClip && ((PT_ZXTS._.STATE == "1" && PT_ZXTS_DEPCONFIG._.USER_ID == jdUserId)
                                                    || (PT_ZXTS._.STATE == "2" && PT_ZXTS._.ACCEPT_UID == jdUserId)
                                                    || (PT_ZXTS._.STATE.In('6', '7') && PT_ZXTS._.ACCEPT_STATE == "1" &&
                                                        PT_ZXTS._.ACCEPT_UID == jdUserId)));//||outlineWhereClip&&(PT_ZXTS._.STATE == "0")
                }

                else if (model.ZaiBan || model.DaiChuLi)
                {
                    condition.And(onlineWhereClip && (PT_ZXTS._.STATE == "4" || PT_ZXTS._.STATE.In('6', '7') && PT_ZXTS._.HANDLE_STATE == "1") && (PT_ZXTS._.HANDLE_UID == jdUserId || (PT_ZXTS._.HANDLE_UID == -1 && PT_ZXTS_DEPCONFIG._.USER_ID == jdUserId)));//0 暂存
                    condition.Or(outlineWhereClip && PT_ZXTS._.STATE == "0");
                }

                else if (model.YiBan)
                {
                    condition.And(onlineWhereClip && (PT_ZXTS._.STATE == "9" || (PT_ZXTS._.STATE.In('3', '5', '8') && (PT_ZXTS._.SIGN_UID == jdUserId || PT_ZXTS._.ACCEPT_UID == jdUserId || PT_ZXTS._.HANDLE_UID == jdUserId))));
                    condition.Or(outlineWhereClip && PT_ZXTS._.STATE.In("3", "5"));
                }
                else if (model.DaiQianShou)
                {
                    condition.And(onlineWhereClip && PT_ZXTS._.STATE == "1" && PT_ZXTS_DEPCONFIG._.USER_ID == jdUserId);
                }

                else if (model.DaiShouLi)
                {
                    condition.And(onlineWhereClip && PT_ZXTS._.STATE == "2" && PT_ZXTS._.ACCEPT_UID == jdUserId);
                }

                else if (model.JiJiangDaoQiWeiChuLi)
                {
                    condition.And(onlineWhereClip && (PT_ZXTS._.STATE == "4" ||
                                   (PT_ZXTS._.STATE.In('6', '7') && PT_ZXTS._.HANDLE_STATE == "1"))
                                  && (PT_ZXTS._.HANDLE_UID == jdUserId ||
                                      (PT_ZXTS._.HANDLE_UID == -1 && PT_ZXTS_DEPCONFIG._.USER_ID == jdUserId))
                                  && PT_ZXTS._.OVER_TM.IsNotNull() && "OVER_TM>=SYSDATE" && "OVER_TM<=SYSDATE+7");
                }

                else if (model.TouSuRenShenQingCheSu)
                {
                    condition.And(onlineWhereClip && PT_ZXTS._.STATE == "6" && (PT_ZXTS._.HANDLE_UID == jdUserId || (PT_ZXTS._.HANDLE_UID.Nvl(-1) == "-1" && PT_ZXTS_DEPCONFIG._.USER_ID == jdUserId)));
                }

                else
                {

                    switch (model.STATE)
                    {
                        case "3"://不予受理
                            outlineWhereClip.And(PT_ZXTS._.STATE == "3");
                            break;
                        case "4"://待处理
                            outlineWhereClip.And(PT_ZXTS._.STATE == "0");
                            break;
                        case "5"://已处理
                            outlineWhereClip.And(PT_ZXTS._.STATE == "5");
                            break;
                        case "6":
                            //condition.And(PT_ZXTS._.HANDLE_UID == jdUserId || (PT_ZXTS._.HANDLE_UID == -1 && PT_ZXTS_DEPCONFIG._.USER_ID == jdUserId));
                            break;
                    }
                    condition.And(onlineWhereClip || outlineWhereClip);
                }
            }

            //var c1 = model.ConditionBuilder(search);
            //condition.And(c1.ToWhereClip());
            #endregion

            var query = FromWhere(condition.ToWhereClip())
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "72" && SYS_DIC._.VALUE == PT_ZXTS._.STATE)
                .LeftJoin<PT_ZXTS_DEPCONFIG>(PT_ZXTS_DEPCONFIG._.DEP_ID == PT_ZXTS._.ACCEPT_DEPID && PT_ZXTS_DEPCONFIG._.USER_ID == jdUserId)
                .LeftJoin<PT_ZXTS_LOG>(PT_ZXTS_LOG._.TS_ID == PT_ZXTS._.ID && PT_ZXTS_LOG._.RECORDER_TM == PT_ZXTS._.DATA_TIMESTAMP);
            var total = query.Count();
            var page = query.OrderBy(PT_ZXTS._.CREATE_TM.Desc)
                .Page(search.PageSize, search.PageNo)
                .Select(
                    PT_ZXTS._.All, SYS_DIC._.TEXT.As("STATE_TEXT"),
                    new Field("(CASE WHEN SYSDATE>OVER_TM THEN 'FONTC-RED' ELSE '' END)").As("IS_OVERTIME_TEXT"),
                    PT_ZXTS_LOG._.RECORDER_UNAME
                )
                .ToList<PtZxtsModel>()
                .ToPageTableResult(search, total);
            return page;
        }
        #endregion

        /// <summary>
        /// 投诉信息
        /// </summary>
        /// <param name="code"></param>
        /// <param name="urlBuilder"></param>
        /// <returns></returns>
        public GeneralResult<PtZxtsModel> ComplaintDetail(string code, Func<string, string, string> urlBuilder = null)
        {
            var r = new GeneralResult<PtZxtsModel>();
            var jdUserId = JdUser?.ID;
            var jdUserDepartId = JdUser?.DEPARTID;
            #region 投诉信息

            var obj = FromWhere(PT_ZXTS._.CODE == code)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "72" && SYS_DIC._.VALUE == PT_ZXTS._.STATE)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "81" && SYS_DIC._.VALUE == PT_ZXTS._.HANDLE_JL)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "80" && SYS_DIC._.VALUE == PT_ZXTS._.SIGN_STATE)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "73" && SYS_DIC._.VALUE == PT_ZXTS._.ACCEPT_STATE)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "74" && SYS_DIC._.VALUE == PT_ZXTS._.HANDLE_STATE)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "71" && SYS_DIC._.VALUE == PT_ZXTS._.COMPLAINT_TYPE)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "82" && SYS_DIC._.VALUE == PT_ZXTS._.COMPLAINT_SX)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "83" && SYS_DIC._.VALUE == PT_ZXTS._.TENDER_CLASS)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "84" && SYS_DIC._.VALUE == PT_ZXTS._.COMPLAINT_ROLE)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "85" && SYS_DIC._.VALUE == PT_ZXTS._.TENDER_CLASS)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == PT_ZXTS._.ACCEPT_DEPID)
                .LeftJoin<T_USER>(T_USER._.ID == PT_ZXTS._.SIGN_UID)
                .LeftJoin<T_USER>(T_USER._.ID == PT_ZXTS._.ACCEPT_UID)
                //.LeftJoin<TENDER_PROJECT>(PT_ZXTS._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                //.LeftJoin<T_USER_EXTEND>(T_USER_EXTEND._.U_ID == TENDER_PROJECT._.M_CREATOR)
                //.LeftJoin<PROJECT>(PROJECT._.PROJECT_CODE == TENDER_PROJECT._.PROJECT_CODE)
                //.LeftJoin<T_AFC_PROJECT>(T_AFC_PROJECT._.CODE == PROJECT._.CONSTRUCTION_ID)
                //.LeftJoin<PT_ZXTS_DEPCONFIG>(PT_ZXTS_DEPCONFIG._.DEP_ID==PT_ZXTS._.ACCEPT_DEPID)
                .Select(
                    SYS_DIC._.TEXT.As("STATE_TEXT"),
                    new Field("TEXT", "SYS_DIC2").As("HANDLE_JL_TEXT"),
                    new Field("TEXT", "SYS_DIC3").As("SIGN_STATE_TEXT"),
                    new Field("TEXT", "SYS_DIC4").As("ACCEPT_STATE_TEXT"),
                    new Field("TEXT", "SYS_DIC5").As("HANDLE_STATE_TEXT"),
                    new Field("TEXT", "SYS_DIC6").As("COMPLAINT_TYPE_TEXT"),
                    new Field("TEXT", "SYS_DIC7").As("COMPLAINT_SX_TEXT"),
                    new Field("TEXT", "SYS_DIC8").As("TENDER_CLASS_TEXT_83"),
                    new Field("TEXT", "SYS_DIC9").As("COMPLAINT_ROLE_TEXT"),
                    new Field("TEXT", "SYS_DIC10").As("TENDER_CLASS_TEXT_85"),
                    T_USER_DEPARTMENT._.DNAME.As("ACCEPT_DEPID_TEXT"),
                    T_USER._.MANAGE_NAME.As("SIGN_UID_TEXT"),
                    new Field("MANAGE_NAME", "T_USER2").As("ACCEPT_UID_TEXT"),
                    //TENDER_PROJECT._.M_CREATOR.As("DLJG_UID"),
                    //T_USER_EXTEND._.DEP_NAME.As("DLJG_NAME"),
                    //T_AFC_PROJECT._.U_ID.As("JSDW_UID"),
                    //T_AFC_PROJECT._.DEP_NAME.As("JSDW_NAME"),
                    PT_ZXTS._.All)
                .ToFirst<PtZxtsModel>();

            #endregion

            if (obj != null)
            {

                #region 附件

                if (urlBuilder != null)
                {
                    obj.HANDLE_JDS_ATTACHMENT = Jd.CommonService.Attachments(obj.HANDLE_JDS, "Sys", true);//处理决定书
                    obj.ACCEPT_TZS_ATTACHMENT = Jd.CommonService.Attachments(obj.ACCEPT_TZS, "Sys", true);//不予受理通知书
                    obj.DELAY_SMS_ATTACHMENT = Jd.CommonService.Attachments(obj.DELAY_SMS, "Sys", true);//延期说明书
                    obj.REVOKE_YJS_ATTACHMENT = Jd.CommonService.Attachments(obj.REVOKE_YJS, "Sys", true);//投诉撤回意见书
                    obj.YYZM_AIDS_ATTACHMENT = Jd.CommonService.Attachments(obj.YYZM_AIDS, "Sys", true);//异议证明文件
                    obj.ZMCL_AIDS_ATTACHMENT = Jd.CommonService.Attachments(obj.ZMCL_AIDS, "Sys", true);//有效线索相关证明材料
                    obj.FR_SFZ_AIDS_ATTACHMENT = Jd.CommonService.Attachments(obj.FR_SFZ_AIDS, "Sys", true);//法人身份证扫描件
                    obj.WTR_SFZ_AIDS_ATTACHMENT = Jd.CommonService.Attachments(obj.WTR_SFZ_AIDS, "Sys", true);//被授权委托人身份扫描件
                    obj.SQWTS_AIDS_ATTACHMENT = Jd.CommonService.Attachments(obj.SQWTS_AIDS, "Sys", true);//授权委托书
                    obj.WTDLHT_AIDS_ATTACHMENT = Jd.CommonService.Attachments(obj.WTDLHT_AIDS, "Sys", true);//委托代理合同
                    obj.AGENCY_CODE_AIDS_ATTACHMENT = Jd.CommonService.Attachments(obj.AGENCY_CODE_AIDS, "Sys", true);//委托代理机构统一社会信用代码证
                    obj.AGENCY_SFZ_AIDS2_ATTACHMENT = Jd.CommonService.Attachments(obj.AGENCY_SFZ_AIDS2, "Sys", true);//委托代理联系人身份证扫描件
                    obj.SFZ_AIDS_ATTACHMENT = Jd.CommonService.Attachments(obj.SFZ_AIDS, "Sys", true);//身份证复印件
                    obj.OTHER_AIDS_ATTACHMENT = Jd.CommonService.Attachments(obj.OTHER_AIDS, "Sys", true);//其他材料
                    obj.TSS_AIDS_ATTACHMENT = Jd.CommonService.Attachments(obj.TSS_AIDS, "Sys", true);//投诉书
                }

                #endregion

                #region 操作按钮

                if (obj.Button == null)
                {
                    obj.Button = new List<string>();
                }
                if (obj.TYPE == "1"|| obj.TYPE == "3")//线上投诉
                {
                    if (obj.ACCEPT_DEPID == jdUserDepartId?.ToString())
                    {
                        switch (obj.STATE)//状态（1待签收，2待受理，3不予受理，4待处理，5已处理，6申请撤诉，7不予撤诉，8同意撤诉，9撤销 type=72）
                        {
                            case "1"://待签收
                                if (Jd.PtZxtsDepconfigService.HasReceiptPermission())//是否具有签收权限
                                {
                                    obj.Button.Add("DSL");//待受理 2 选择经办人
                                }
                                break;
                            case "2"://待受理(可【申请撤诉】)
                                if (obj.ACCEPT_UID == jdUserId)
                                {
                                    obj.Button.Add("BYSL");//不予受理 3
                                    obj.Button.Add("DCL");//待处理 4
                                }

                                break;
                            case "4"://4待处理(可【申请撤诉】)
                                if (obj.HANDLE_UID == jdUserId || obj.HANDLE_UID == -1)
                                {
                                    obj.Button.Add("YCL");//5已处理
                                    obj.Button.Add("YQCL");//10 延期处理 
                                    obj.Button.Add("DCJL");//调查记录
                                    obj.Button.Add("DCQZ");//调查取证
                                }
                                break;
                            case "6"://6申请撤诉
                                if (obj.HANDLE_UID == jdUserId ||
                                    ((!obj.HANDLE_UID.HasValue || obj.HANDLE_UID == -1) && Jd.PtZxtsDepconfigService.HasReceiptPermission()))
                                {
                                    obj.Button.Add("BYCS");//7不予撤诉
                                    obj.Button.Add("TYCS");//8同意撤诉
                                }
                                break;
                            case "7"://不予撤诉
                                if (obj.ACCEPT_STATE == "1")//待受理
                                {
                                    if (obj.ACCEPT_UID == jdUserId)
                                    {
                                        obj.Button.Add("BYSL");//不予受理 3
                                        obj.Button.Add("DCL");//待处理 4
                                    }

                                }
                                else if (obj.HANDLE_STATE == "1") //待处理
                                {
                                    if (obj.HANDLE_UID == jdUserId || obj.HANDLE_UID == -1)
                                    {
                                        obj.Button.Add("YCL");//5已处理
                                        obj.Button.Add("YQCL");//10 延期处理
                                        obj.Button.Add("DCJL");//调查记录
                                        obj.Button.Add("DCQZ");//调查取证
                                    }

                                }
                                break;
                        }
                    }

                }

                if (obj.TYPE == "2" && obj.CREATE_UID == jdUserId)//线下投诉//暂存
                {
                    if (obj.STATE == "0")//提交
                    {
                        obj.Button.Add("XXCL");//处理 5
                        obj.Button.Add("XXBYSL");//不予受理 3
                    }
                    if (obj.STATE == "-1")//暂存 （可以再次编辑保存）
                    {
                        obj.Button.Add("SAVE");//暂存 -1
                        obj.Button.Add("SUBMIT");//提交 0
                    }
                }


                #endregion

                obj.BTSR = Jd.PtZxtsBtsrService.GetBtsrByTsId(obj.ID);
                obj.Logs = Jd.PtZxtsLogService.GetPtZxtsLogByTsId(obj.ID);

                #region 流程

                var signProcess = new LabelValueModel
                {
                    Id = "SIGN_STATE",
                    Label = obj.SIGN_STATE_TEXT,
                    Value = string.IsNullOrWhiteSpace(obj.SIGN_STATE) ? "0" : obj.SIGN_STATE
                };
                var acceptProcess = new LabelValueModel
                {
                    Id = "ACCEPT_STATE",
                    Label = obj.ACCEPT_STATE_TEXT,
                    Value = string.IsNullOrWhiteSpace(obj.ACCEPT_STATE) ? "0" : obj.ACCEPT_STATE
                };
                if (obj.TYPE == "2")
                {
                    signProcess.Value = "2";
                    acceptProcess.Value = "2";
                }
                var publish = new LabelValueModel { Id = "IS_PUBLIC", Label = "未发布(不公开)", Value = "0" };
                var ptComplaint = Jd.PtComplainService.FirstOrNull(PT_COMPLAIN._.TS_ID == obj.ID);
                if (ptComplaint != null && ptComplaint.IS_PUBLIC.HasValue && ptComplaint.IS_PUBLIC.Value == 1)
                {

                    publish.Label = "已发布";
                    publish.Value = "1";
                }

                var handleProcess =
                    new LabelValueModel
                    {
                        Id = "HANDLE_STATE",
                        Label = obj.HANDLE_STATE_TEXT,
                        Value = string.IsNullOrWhiteSpace(obj.HANDLE_STATE) ? "0" : obj.HANDLE_STATE
                    };
                //if (obj.HANDLE_STATE!="1"&&obj.HANDLE_STATE!="2")
                //{
                //    handleProcess.Label = obj.STATE_TEXT;
                //}
                obj.Processes = new List<LabelValueModel>
                {
                    signProcess,
                    acceptProcess,
                    handleProcess,
                    publish
                };

                #endregion
                r.SetSuccessT(obj);
            }
            else
            {
                r.SetFail("未找到对应的投诉信息");
            }
            return r;
        }



        /// <summary>
        /// 距离最后处理时间还有多少个工作日
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public GeneralResult ComplaintOverTimeWorkDayCount(string code)
        {
            var r = new GeneralResult();
            var dbEntity = FirstOrNull(PT_ZXTS._.CODE == code);
            if (dbEntity != null)
            {
                if (dbEntity.OVER_TM.HasValue && (dbEntity.STATE == "4" || ((dbEntity.STATE == "6" || dbEntity.STATE == "7") && dbEntity.HANDLE_STATE == "1")))
                {
                    var date = DateTime.Today;
                    var hTm = dbEntity.OVER_TM.Value;
                    int count = 0;
                    while (date <= hTm)
                    {
                        hTm = hTm.AddDays(-1);
                        if (Jd.THolidayService.IsWorkTime(hTm)) count++;
                    }
                    r.SetSuccess(new { Count = count });
                }
                else
                {
                    r.SetSuccess(new { Count = 0 });
                }
            }
            else
            {
                r.SetFail("未找到投诉信息");
            }

            return r;
        }
        #region 线下投诉

        /// <summary>
        /// 提交在线投诉信息(线下)
        /// </summary>
        /// <param name="complaint">投诉主体信息</param>
        /// <param name="respondents">被投诉人</param>
        /// <returns></returns>
        public GeneralResult SaveOutlineComplaint(PT_ZXTS complaint, List<PT_ZXTS_BTSR> respondents)
        {
            complaint.TYPE = "2"; //投诉类型
            var r = ValidateComplaintParameter(complaint, respondents);
            if (r.Success)
            {
                if (complaint.STATE != "-1" && complaint.STATE != "0")//-1 暂存(可编辑修改) 0 提交（）
                {
                    r.SetFail("非法请求");
                    return r;
                }
                var complaintCode = CreateComplaintCode();
                var jdUserDepartId = JdUser?.DEPARTID?.ToString();
                var jdUserId = JdUser?.ID;
                Task.Run(() =>
                {
                    #region 添加数据到数据库

                    DateTime now = DateTime.Now;

                    complaint.ID = 0;
                    complaint.CODE = complaintCode;
                    complaint.STATE = complaint.STATE; //暂存
                    complaint.TYPE = "2"; //投诉类型
                    complaint.ACCEPT_DEPID = jdUserDepartId;
                    if (complaint.STATE == "0")//已提交
                    {
                        //70、*红圈处 - 如为线下的投诉，则该状态文字描述应为：“待处理（线下）”
                        //*蓝圈处 - 当为线下的投诉，则状态应处于“待处理
                        complaint.ACCEPT_STATE = "2";
                        complaint.HANDLE_UID = jdUserId;
                        complaint.HANDLE_STATE = "1";
                    }

                    complaint.CREATE_UID = jdUserId;
                    complaint.CREATE_DEPID = complaint.ACCEPT_DEPID;
                    complaint.DATA_TIMESTAMP = now;
                    complaint.COMPLAINT_CONTENT = HttpUtility.HtmlDecode(complaint.COMPLAINT_CONTENT);
                    using (var trans = GetDbSession().BeginTransaction())
                    {
                        var tsid = trans.Insert(complaint);
                        respondents = respondents.Select(c =>
                        {
                            c.ID = 0;
                            c.TS_ID = tsid;
                            return c;
                        }).ToList();
                        trans.Insert(respondents);
                        //trans.Insert(new PT_ZXTS_LOG
                        //{
                        //    ID = 0,
                        //    TS_ID = tsid,
                        //    RECORDER_UNAME = "投诉人",
                        //    RECORDER_OPERATION = "1", //操作：1.提交投诉
                        //    RECORDER_TM = now
                        //});
                        trans.Commit();
                    }
                    #endregion
                });
                r.SetSuccess(new { CODE = complaintCode });
            }
            return r;
        }
        public GeneralResult ReSaveOutlineComplaint(PT_ZXTS complaint, List<PT_ZXTS_BTSR> respondents)
        {
            complaint.TYPE = "2"; //投诉类型
            var r = ValidateComplaintParameter(complaint, respondents);
            if (r.Success)
            {
                if (complaint.STATE != "-1" && complaint.STATE != "0")//-1 暂存(可编辑修改) 0 提交（）
                {
                    r.SetFail("非法请求");
                    return r;
                }
                var jdUserDepartId = JdUser?.DEPARTID?.ToString();
                var jdUserId = JdUser?.ID;
                var dbEntity = FirstOrNull(PT_ZXTS._.CODE == complaint.CODE && PT_ZXTS._.STATE == "-1" && PT_ZXTS._.TYPE == "2");//线下暂存
                if (dbEntity == null)
                {
                    r.SetFail("未找到对应的投诉信息");
                    return r;
                }
                #region 添加数据到数据库

                DateTime now = DateTime.Now;
                dbEntity.Attach();

                #region 属性赋值
                dbEntity.COMPLAINT_TYPE = complaint.COMPLAINT_TYPE;
                dbEntity.COMPLAINT_NAME = complaint.COMPLAINT_NAME;
                dbEntity.COMPLAINT_CODE = complaint.COMPLAINT_CODE;
                dbEntity.COMPLAINT_DNAME = complaint.COMPLAINT_DNAME;
                dbEntity.COMPLAINT_ADRESS = complaint.COMPLAINT_ADRESS;
                dbEntity.COMPLAINT_ZW = complaint.COMPLAINT_ZW;
                dbEntity.COMPLAINT_FAX = complaint.COMPLAINT_FAX;
                dbEntity.COMPLAINT_PC = complaint.COMPLAINT_PC;
                dbEntity.COMPLAINT_CONTACT = complaint.COMPLAINT_CONTACT;
                dbEntity.COMPLAINT_PHONE = complaint.COMPLAINT_PHONE;
                dbEntity.COMPLAINT_EMAIL = complaint.COMPLAINT_EMAIL;
                dbEntity.COMPLAINT_CONTACT_IDCARD = complaint.COMPLAINT_CONTACT_IDCARD;
                dbEntity.COMPLAINT_CONTACT_PHONE = complaint.COMPLAINT_CONTACT_PHONE;
                dbEntity.COMPLAINT_CONTACT_EMAIL = complaint.COMPLAINT_CONTACT_EMAIL;
                dbEntity.COMPLAINT_LEGAL = complaint.COMPLAINT_LEGAL;
                dbEntity.COMPLAINT_LEGAL_IDCARD = complaint.COMPLAINT_LEGAL_IDCARD;
                dbEntity.COMPLAINT_LEGAL_PHONE = complaint.COMPLAINT_LEGAL_PHONE;
                dbEntity.COMPLAINT_LEGAL_ISWT = complaint.COMPLAINT_LEGAL_ISWT;
                dbEntity.COMPLAINT_BWTR = complaint.COMPLAINT_BWTR;
                dbEntity.COMPLAINT_BWTR_IDCARD = complaint.COMPLAINT_BWTR_IDCARD;
                dbEntity.COMPLAINT_BWTR_BMZW = complaint.COMPLAINT_BWTR_BMZW;
                dbEntity.COMPLAINT_BWTR_PHONE = complaint.COMPLAINT_BWTR_PHONE;
                dbEntity.COMPLAINT_ISAGENCY = complaint.COMPLAINT_ISAGENCY;
                dbEntity.COMPLAINT_AGENCY = complaint.COMPLAINT_AGENCY;
                dbEntity.COMPLAINT_AGENCY_CODE = complaint.COMPLAINT_AGENCY_CODE;
                dbEntity.COMPLAINT_AGENCY_FAX = complaint.COMPLAINT_AGENCY_FAX;
                dbEntity.COMPLAINT_AGENCY_PC = complaint.COMPLAINT_AGENCY_PC;
                dbEntity.COMPLAINT_AGENCY_LXR = complaint.COMPLAINT_AGENCY_LXR;
                dbEntity.COMPLAINT_AGENCY_PHONE = complaint.COMPLAINT_AGENCY_PHONE;
                dbEntity.COMPLAINT_AGENCY_ADRESS = complaint.COMPLAINT_AGENCY_ADRESS;
                dbEntity.TENDER_PROJECT_CODE = complaint.TENDER_PROJECT_CODE;
                dbEntity.TENDER_PROJECT_NAME = complaint.TENDER_PROJECT_NAME;
                dbEntity.TENDER_CLASS = complaint.TENDER_CLASS;
                dbEntity.COMPLAINT_SX = complaint.COMPLAINT_SX;
                dbEntity.COMPLAINT_TITLE = complaint.COMPLAINT_TITLE;
                dbEntity.TSS_AIDS = complaint.TSS_AIDS;
                dbEntity.YYZM_AIDS = complaint.YYZM_AIDS;
                dbEntity.ZMCL_AIDS = complaint.ZMCL_AIDS;
                dbEntity.OTHER_AIDS = complaint.OTHER_AIDS;
                dbEntity.FR_SFZ_AIDS = complaint.FR_SFZ_AIDS;
                dbEntity.WTR_SFZ_AIDS = complaint.WTR_SFZ_AIDS;
                dbEntity.SQWTS_AIDS = complaint.SQWTS_AIDS;
                dbEntity.WTDLHT_AIDS = complaint.WTDLHT_AIDS;
                dbEntity.AGENCY_CODE_AIDS = complaint.AGENCY_CODE_AIDS;
                dbEntity.AGENCY_SFZ_AIDS2 = complaint.AGENCY_SFZ_AIDS2;
                dbEntity.SFZ_AIDS = complaint.SFZ_AIDS;
                dbEntity.CREATE_TM = complaint.CREATE_TM;
                dbEntity.ACCEPT_DEPID = complaint.ACCEPT_DEPID;
                dbEntity.SIGN_STATE = complaint.SIGN_STATE;
                dbEntity.SIGN_UID = complaint.SIGN_UID;
                dbEntity.SIGN_TM = complaint.SIGN_TM;
                dbEntity.SIGN_REMARK = complaint.SIGN_REMARK;
                dbEntity.ACCEPT_STATE = complaint.ACCEPT_STATE;
                dbEntity.ACCEPT_UID = complaint.ACCEPT_UID;
                dbEntity.ACCEPT_TM = complaint.ACCEPT_TM;
                dbEntity.ACCEPT_REMARK = complaint.ACCEPT_REMARK;
                dbEntity.ACCEPT_AIDS = complaint.ACCEPT_AIDS;
                dbEntity.SCCZWT = complaint.SCCZWT;
                dbEntity.ACCEPT_TZS = complaint.ACCEPT_TZS;
                dbEntity.HANDLE_STATE = complaint.HANDLE_STATE;
                dbEntity.HANDLE_UID = complaint.HANDLE_UID;
                dbEntity.HANDLE_TM = complaint.HANDLE_TM;
                dbEntity.HANDLE_JL = complaint.HANDLE_JL;
                dbEntity.HANDLE_REMARK = complaint.HANDLE_REMARK;
                dbEntity.HANDLE_AIDS = complaint.HANDLE_AIDS;
                dbEntity.HANDLE_JDS = complaint.HANDLE_JDS;
                dbEntity.IS_DELAY = complaint.IS_DELAY;
                dbEntity.DELAY_UID = complaint.DELAY_UID;
                dbEntity.DELAY_REMARK = complaint.DELAY_REMARK;
                dbEntity.DELAY_AIDS = complaint.DELAY_AIDS;
                dbEntity.DELAY_TM = complaint.DELAY_TM;
                //dbEntity.OVER_TM = complaint.OVER_TM;
                dbEntity.DATA_TIMESTAMP = complaint.DATA_TIMESTAMP;
                dbEntity.SIGN_AIDS = complaint.SIGN_AIDS;
                dbEntity.DELAY_SMS = complaint.DELAY_SMS;
                dbEntity.REVOKE_YJS = complaint.REVOKE_YJS;
                dbEntity.COMPLAINT_ROLE = complaint.COMPLAINT_ROLE;
                dbEntity.CREATE_UID = complaint.CREATE_UID;
                dbEntity.CREATE_DEPID = complaint.CREATE_DEPID;
                dbEntity.COMPLAINT_CONTENT = complaint.COMPLAINT_CONTENT;



                #endregion

                dbEntity.STATE = complaint.STATE; //暂存
                complaint.TYPE = "2"; //投诉类型
                dbEntity.ACCEPT_DEPID = jdUserDepartId;
                dbEntity.CREATE_UID = jdUserId;
                dbEntity.CREATE_DEPID = complaint.ACCEPT_DEPID;
                dbEntity.DATA_TIMESTAMP = now;
                dbEntity.COMPLAINT_CONTENT = HttpUtility.HtmlDecode(complaint.COMPLAINT_CONTENT);
                using (var trans = GetDbSession().BeginTransaction())
                {
                    trans.Update(dbEntity);
                    trans.Delete<PT_ZXTS_BTSR>(PT_ZXTS_BTSR._.TS_ID == dbEntity.ID);
                    respondents = respondents.Select(c =>
                    {
                        c.ID = 0;
                        c.TS_ID = dbEntity.ID;
                        return c;
                    }).ToList();
                    trans.Insert(respondents);
                    trans.Commit();
                }
                #endregion
                r.SetSuccess(new { CODE = complaint.CODE });
            }
            return r;
        }
        /// <summary>
        /// 处理线下投诉书
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult ChuLiOutlineComplaint(TouSuChuLiJueDingShuModel model)
        {
            var r = new GeneralResult();
            if (!model.HANDLE_TM.HasValue || string.IsNullOrWhiteSpace(model.HANDLE_JL) ||
                model.HANDLE_JDS_ATTACHMENTS == null || !model.HANDLE_JDS_ATTACHMENTS.Any() || model.STATE != "5")
            {
                r.SetFail("数据不完整");
            }
            else
            {
                var dbEntity = FirstOrNull(PT_ZXTS._.CODE == model.CODE);
                if (dbEntity != null)
                {
                    using (var trans = GetDbSession().BeginTransaction())
                    {
                        #region 更新投诉信息

                        var handleJdsAttachments = model.HANDLE_JDS_ATTACHMENTS.Select(c => c.JdSysAttachment(JdUser.ID)).ToList();
                        dbEntity.Attach();
                        dbEntity.STATE = model.STATE;//5 已处理
                        dbEntity.HANDLE_STATE = "2";//已处理
                        dbEntity.HANDLE_TM = model.HANDLE_TM;
                        dbEntity.HANDLE_JL = model.HANDLE_JL;
                        dbEntity.HANDLE_JDS = string.Join(",", handleJdsAttachments.Select(c => c.GUID));
                        dbEntity.DATA_TIMESTAMP = DateTime.Now;
                        trans.Update(dbEntity);
                        trans.Insert(handleJdsAttachments);

                        #endregion

                        #region 添加操作记录

                        var log = new PT_ZXTS_LOG
                        {
                            ID = 0,
                            TS_ID = dbEntity.ID,
                            RECORDER_UID = JdUser.ID,
                            RECORDER_UNAME = JdUser.MANAGE_NAME,
                            RECORDER_DEPID = JdUser.DEPARTID,
                            RECORDER_OPERATION = dbEntity.STATE,
                            //RECORDER_REMARK = model.re
                            RECORDER_AIDS = dbEntity.HANDLE_JDS,
                            RECORDER_TM = dbEntity.DATA_TIMESTAMP
                        };
                        trans.Insert(log);

                        #endregion

                        #region 添加发布信息

                        var complaint = new PT_COMPLAIN
                        {
                            ID = 0,
                            TYPE = "1",
                            USER_ID = JdUser.ID,
                            CREATE_TM = dbEntity.DATA_TIMESTAMP,
                            SOURCES = JdUser.UserDepartment?.DNAME,
                            AIDS = dbEntity.HANDLE_JDS,
                            TS_ID = dbEntity.ID,
                            TITLE = model.TITLE,
                            TM = model.PUBLISH_TIME,
                            CONTENTS = model.CONTENTS,
                            IS_PUBLIC = model.IS_PUBLIC
                        };
                        trans.Insert(complaint);

                        #endregion
                        trans.Commit();
                    }
                    r.SetSuccess(model);
                }
                else
                {
                    r.SetFail($"未找到对应编号为{model.CODE}的投诉消息");
                }
            }

            return r;
        }


        /// <summary>
        /// 不予受理线下投诉书
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult BuShouLiOutlineComplaint(BuYuShouLiTongZhiShuModel model)
        {
            var r = new GeneralResult();
            if (!model.ACCEPT_TM.HasValue || string.IsNullOrWhiteSpace(model.SCCZWT) || string.IsNullOrWhiteSpace(model.REMARK) ||
                model.ACCEPT_TZS_ATTACHMENT == null || !model.ACCEPT_TZS_ATTACHMENT.Any() || model.STATE != "3")
            {
                r.SetFail("数据不完整");
            }
            else
            {
                var dbEntity = FirstOrNull(PT_ZXTS._.CODE == model.CODE);
                if (dbEntity != null)
                {
                    using (var trans = GetDbSession().BeginTransaction())
                    {
                        #region 更新投诉信息

                        var attachments = model.ACCEPT_TZS_ATTACHMENT.Select(c => c.JdSysAttachment(JdUser.ID)).ToList();
                        dbEntity.Attach();
                        dbEntity.STATE = model.STATE;//"3"; //不予受理
                        dbEntity.HANDLE_STATE = "3";//不予受理
                        dbEntity.ACCEPT_TM = model.ACCEPT_TM;
                        dbEntity.ACCEPT_REMARK = model.REMARK;
                        dbEntity.SCCZWT = model.SCCZWT;
                        dbEntity.ACCEPT_UID = JdUser.ID;
                        dbEntity.ACCEPT_TZS = model.ACCEPT_TZS;// string.Join(",", attachments.Select(c => c.GUID));
                        dbEntity.DATA_TIMESTAMP = DateTime.Now;
                        trans.Update(dbEntity);
                        trans.Insert(attachments);

                        #endregion

                        #region 添加操作记录

                        var log = new PT_ZXTS_LOG
                        {
                            ID = 0,
                            TS_ID = dbEntity.ID,
                            RECORDER_UID = JdUser.ID,
                            RECORDER_UNAME = JdUser.MANAGE_NAME,
                            RECORDER_DEPID = JdUser.DEPARTID,
                            RECORDER_OPERATION = dbEntity.STATE,
                            RECORDER_REMARK = model.REMARK,
                            RECORDER_AIDS = dbEntity.ACCEPT_TZS,
                            RECORDER_TM = dbEntity.DATA_TIMESTAMP
                        };
                        trans.Insert(log);

                        #endregion

                        #region 添加发布信息

                        var complaint = new PT_COMPLAIN
                        {
                            ID = 0,
                            TYPE = "1",
                            USER_ID = JdUser.ID,
                            CREATE_TM = dbEntity.DATA_TIMESTAMP,
                            SOURCES = JdUser.UserDepartment?.DNAME,
                            AIDS = dbEntity.ACCEPT_TZS,
                            TS_ID = dbEntity.ID,
                            TM = dbEntity.DATA_TIMESTAMP,
                            IS_PUBLIC = model.IS_PUBLIC,
                            TITLE = $"{dbEntity.COMPLAINT_TITLE}不予受理通知书",
                            CONTENTS = TsContentBuilder(dbEntity, model),
                        };
                        trans.Insert(complaint);

                        #endregion
                        trans.Commit();
                    }
                    r.SetSuccess(model);
                }
                else
                {
                    r.SetFail($"未找到对应编号为{model.CODE}的投诉消息");
                }
            }

            return r;
        }


        #endregion

        #region 线上投诉
        /// <summary>
        /// 签收 （选择经办人）
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult Receipt(PtZxtsModel model)
        {
            var r = new GeneralResult();
            var dbEntity = FirstOrNull(PT_ZXTS._.CODE == model.CODE);
            if (dbEntity != null)
            {
                if (dbEntity.STATE != "1" || model.STATE != "2")
                {
                    r.SetFailEx("非法请求", "当前该投诉已非‘待签收’状态 或 当前操作非‘待受理’");
                    return r;
                }

                if (dbEntity.ACCEPT_DEPID != JdUser.DEPARTID?.ToString())
                {
                    r.SetFail("该投诉非本部门的投诉，无权进行操作");
                    return r;
                }
                if (!Jd.PtZxtsDepconfigService.HasReceiptPermission())
                {
                    r.SetFail("当前用户没有权限签收(选择经办人)");
                    return r;
                }
                using (var trans = GetDbSession().BeginTransaction())
                {
                    #region 更新签收信息
                    //签收，修改受理状态，指定受理人
                    DateTime now = DateTime.Now;
                    dbEntity.Attach();
                    dbEntity.STATE = "2";//待受理
                    dbEntity.SIGN_STATE = "2"; //已签收
                    dbEntity.SIGN_UID = JdUser.ID;
                    dbEntity.SIGN_TM = now;
                    dbEntity.SIGN_REMARK = HttpUtility.HtmlDecode(model.SIGN_REMARK);
                    dbEntity.DATA_TIMESTAMP = now;
                    dbEntity.ACCEPT_STATE = "1"; //待受理
                    dbEntity.ACCEPT_UID = model.ACCEPT_UID;//指定受理人
                    trans.Update(dbEntity);
                    #endregion

                    #region 添加操作记录

                    var log = new PT_ZXTS_LOG
                    {
                        ID = 0,
                        TS_ID = dbEntity.ID,
                        RECORDER_UID = JdUser.ID,
                        RECORDER_UNAME = JdUser.MANAGE_NAME,
                        RECORDER_DEPID = JdUser.DEPARTID,
                        RECORDER_OPERATION = dbEntity.STATE,
                        RECORDER_REMARK = dbEntity.SIGN_REMARK,
                        RECORDER_AIDS = String.Empty,
                        RECORDER_TM = dbEntity.DATA_TIMESTAMP
                    };
                    trans.Insert(log);

                    #endregion

                    #region 通知短信

                    SendMsgTs(dbEntity, trans, "待受理");//签收，发送短信提醒到指定受理人
                    SendMsgTSR(dbEntity, trans, "签收");//签收，发送短信提醒到投诉人

                    #endregion
                    trans.Commit();
                }
                r.SetSuccess();
            }
            else
            {
                r.SetFail($"未找到对应编号为{model.CODE}的投诉消息");
            }

            return r;
        }
        /// <summary>
        /// 不予受理
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult UnAccepted(BuYuShouLiTongZhiShuModel model)
        {
            var r = new GeneralResult();
            var dbEntity = FirstOrNull(PT_ZXTS._.CODE == model.CODE);
            if (dbEntity != null)
            {
                #region 校验

                if ((dbEntity.STATE != "2" && dbEntity.STATE != "7") || model.STATE != "3")
                {
                    r.SetFailEx("非法请求", "当前该投诉已非‘待受理’状态 或 当前操作非‘不予受理’");
                    return r;
                }

                if (dbEntity.ACCEPT_DEPID != JdUser.DEPARTID?.ToString())
                {
                    r.SetFail("当前该投诉非本部门的投诉，无权进行操作");
                    return r;
                }
                if (dbEntity.ACCEPT_STATE == "1") //待受理
                {
                    if (dbEntity.ACCEPT_UID != JdUser.ID)
                    {
                        r.SetFail("您非该投诉的受理人，无权进行操作");
                        return r;
                    }
                }

                #endregion
                using (var trans = GetDbSession().BeginTransaction())
                {
                    var attachments = model.ACCEPT_TZS_ATTACHMENT.Select(c => c.JdSysAttachment(JdUser.ID)).ToList();
                    trans.Insert(attachments);

                    #region 更新投诉信息
                    DateTime now = DateTime.Now;
                    dbEntity.Attach();
                    dbEntity.ACCEPT_STATE = "3"; //不予受理
                    dbEntity.ACCEPT_TM = now;
                    dbEntity.STATE = "3"; //不予受理
                    //dbEntity.HANDLE_STATE=
                    dbEntity.DATA_TIMESTAMP = now;
                    dbEntity.ACCEPT_REMARK = HttpUtility.HtmlDecode(model.REMARK);
                    dbEntity.SCCZWT = model.SCCZWT; //
                    dbEntity.ACCEPT_TZS = model.ACCEPT_TZS;
                    trans.Update(dbEntity);
                    #endregion

                    #region 添加发布信息

                    var complaint = new PT_COMPLAIN
                    {
                        ID = 0,
                        TYPE = "1",
                        USER_ID = JdUser.ID,
                        CREATE_TM = dbEntity.DATA_TIMESTAMP,
                        SOURCES = JdUser.UserDepartment?.DNAME,
                        AIDS = dbEntity.HANDLE_JDS,
                        TS_ID = dbEntity.ID,
                        TM = dbEntity.DATA_TIMESTAMP,
                        IS_PUBLIC = model.IS_PUBLIC,
                        TITLE = $"{dbEntity.COMPLAINT_TITLE}不予受理通知书",
                        CONTENTS = TsContentBuilder(dbEntity, model),
                    };
                    trans.Insert(complaint);

                    #endregion

                    #region 添加操作记录

                    var log = new PT_ZXTS_LOG
                    {
                        ID = 0,
                        TS_ID = dbEntity.ID,
                        RECORDER_UID = JdUser.ID,
                        RECORDER_UNAME = JdUser.MANAGE_NAME,
                        RECORDER_DEPID = JdUser.DEPARTID,
                        RECORDER_OPERATION = dbEntity.STATE,
                        RECORDER_REMARK = model.REMARK,
                        RECORDER_AIDS = dbEntity.ACCEPT_TZS,
                        RECORDER_TM = dbEntity.DATA_TIMESTAMP
                    };
                    trans.Insert(log);

                    #endregion

                    #region 通知短信


                    SendMsgTSR(dbEntity, trans, "驳回投诉");//不予受理，发送短信提醒到投诉人
                                                        //设置关联的交易数据重新进行监督;
                    SetTP_DATA(dbEntity, trans);
                    #endregion
                    trans.Commit();
                }
                r.SetSuccess();
            }
            else
            {
                r.SetFail($"未找到对应编号为{model.CODE}的投诉消息");
            }

            return r;
        }

        /// <summary>
        /// 设置关联的交易数据重新进行监督
        /// </summary>
        /// <param name="model"></param>
        /// <param name="trans"></param>
        private void SetTP_DATA(PT_ZXTS model, DbTrans trans)
        {
            string code = model.TENDER_PROJECT_CODE;
            var project = Jd.TenderProjectService.FirstOrNull(TENDER_PROJECT._.TENDER_PROJECT_CODE == code);
            if (project != null)
            {
                if (!string.IsNullOrWhiteSpace(project.TENDER_PROJECT_CODE_OLD1))
                {
                    string pCode = project.TENDER_PROJECT_CODE_OLD1;

                    //string updateStr = string.Format(@"
                    //UPDATE T_PROJECT_DATA
                    //   SET IS_FINISH = 0,
                    //       START_TM  = TO_DATE('{0}', 'yyyy-MM-dd HH24:mi:ss')
                    // WHERE BUSINESSID = '{1}'
                    //   AND TP_CODE = '{2}'", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), pCode, "FJ00111001");
                    trans.Update<T_PROJECT_DATA>(new[] { T_PROJECT_DATA._.IS_FINISH, T_PROJECT_DATA._.START_TM },
                        new object[] { 0, DateTime.Now },
                        T_PROJECT_DATA._.BUSINESSID == pCode && T_PROJECT_DATA._.TP_CODE == "FJ00111001");
                }
            }
        }
        /// <summary>
        /// 受理
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult Accepted(PtZxtsModel model)
        {
            var r = new GeneralResult();
            var dbEntity = FirstOrNull(PT_ZXTS._.CODE == model.CODE);
            if (dbEntity != null)
            {
                #region 校验

                if ((dbEntity.STATE != "2" && dbEntity.STATE != "7") || model.STATE != "4")
                {
                    r.SetFailEx("非法请求", "当前该投诉已非‘待签收’状态 或 当前操作非‘待受理’");
                    return r;
                }

                if (dbEntity.ACCEPT_DEPID != JdUser.DEPARTID?.ToString())
                {
                    r.SetFail("当前该投诉非本部门的投诉，无权进行操作");
                    return r;
                }
                if (dbEntity.ACCEPT_UID != JdUser.ID)
                {
                    r.SetFail("非该投诉的受理人，无权进行操作");
                    return r;
                }

                #endregion
                using (var trans = GetDbSession().BeginTransaction())
                {
                    #region 更新签收信息

                    DateTime now = DateTime.Now;
                    dbEntity.Attach();
                    dbEntity.STATE = "4"; //待处理
                                          //dbEntity.SIGN_UID = JdUser.ID;
                    dbEntity.ACCEPT_STATE = "2"; //已受理
                    dbEntity.ACCEPT_TM = now;
                    dbEntity.ACCEPT_REMARK = HttpUtility.HtmlDecode(model.ACCEPT_REMARK);
                    dbEntity.DATA_TIMESTAMP = now;
                    dbEntity.HANDLE_STATE = "1"; //待处理
                    dbEntity.HANDLE_UID = model.HANDLE_UID;

                    dbEntity.OVER_TM = Jd.THolidayService.OverTime(dbEntity.CREATE_TM.Value, 30);//受理要计算 最后处理时间（计算出提交投诉后30个工作日所在的日期）
                    trans.Update(dbEntity);
                    #endregion

                    #region 添加操作记录

                    var log = new PT_ZXTS_LOG
                    {
                        ID = 0,
                        TS_ID = dbEntity.ID,
                        RECORDER_UID = JdUser.ID,
                        RECORDER_UNAME = JdUser.MANAGE_NAME,
                        RECORDER_DEPID = JdUser.DEPARTID,
                        RECORDER_OPERATION = dbEntity.STATE,
                        RECORDER_REMARK = dbEntity.ACCEPT_REMARK,
                        RECORDER_AIDS = String.Empty,
                        RECORDER_TM = dbEntity.DATA_TIMESTAMP
                    };
                    trans.Insert(log);

                    #endregion

                    #region 通知短信

                    SendMsgTs(dbEntity, trans, "待处理");//受理，发送短信提醒到指定处理人
                    SendMsgTSR(dbEntity, trans, "受理");//受理，发送短信提醒到投诉人
                    SetTP_DATA(dbEntity, trans);
                    #endregion
                    trans.Commit();
                }
                r.SetSuccess();
            }
            else
            {
                r.SetFail($"未找到对应编号为{model.CODE}的投诉消息");
            }

            return r;
        }

        /// <summary>
        /// 投诉处理代理机构 建设单位信息
        /// </summary>
        /// <param name="tsCode"></param>
        /// <returns></returns>
        public PtZxtsHandleModel FindOnlineComplaintHandler(string tsCode)
        {
            var dbModel = FromWhere(PT_ZXTS._.CODE == tsCode)
                .InnerJoin<TENDER_PROJECT>(PT_ZXTS._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                .LeftJoin<T_USER_EXTEND>(T_USER_EXTEND._.U_ID == TENDER_PROJECT._.M_CREATOR)
                .LeftJoin<PROJECT>(PROJECT._.PROJECT_CODE == TENDER_PROJECT._.PROJECT_CODE)
                .LeftJoin<T_AFC_PROJECT>(T_AFC_PROJECT._.CODE == PROJECT._.CONSTRUCTION_ID)
                .Select(
                    TENDER_PROJECT._.M_CREATOR.As("DLJG_UID"),
                    T_USER_EXTEND._.DEP_NAME.As("DLJG_NAME"),
                    T_AFC_PROJECT._.U_ID.As("JSDW_UID"),
                    T_AFC_PROJECT._.DEP_NAME.As("JSDW_NAME"),
                    PT_ZXTS._.CODE,
                    PT_ZXTS._.COMPLAINT_NAME,
                    PT_ZXTS._.COMPLAINT_DNAME,
                    PT_ZXTS._.TYPE
                )
                .ToFirst<PtZxtsHandleModel>();
            return dbModel;
        }
        /// <summary>
        /// 处理
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult Handle(PtZxtsHandleModel model)
        {
            var r = new GeneralResult();
            var dbEntity = FirstOrNull(PT_ZXTS._.CODE == model.CODE);
            if (dbEntity != null)
            {
                #region 校验

                if (dbEntity.STATE != "4" && !(dbEntity.STATE == "7" && dbEntity.HANDLE_STATE == "1"))
                {
                    r.SetFailEx("非法请求", "当前该投诉不可处理");
                    return r;
                }

                if (dbEntity.ACCEPT_DEPID != JdUser.DEPARTID?.ToString())
                {
                    r.SetFail("当前该投诉非本部门的投诉，无权进行操作");
                    return r;
                }
                if (dbEntity.HANDLE_UID != JdUser.ID && dbEntity.HANDLE_UID != -1)
                {
                    r.SetFail("非该投诉的处理人，无权进行操作");
                    return r;
                }

                #endregion
                using (var trans = GetDbSession().BeginTransaction())
                {
                    var attachments = model.HANDLE_JDS_ATTACHMENTS.Select(c => c.JdSysAttachment(JdUser.ID)).ToList();
                    trans.Insert(attachments);
                    #region 更新处理信息

                    DateTime now = DateTime.Now;
                    dbEntity.Attach();
                    dbEntity.STATE = "5"; //已处理
                    dbEntity.HANDLE_STATE = "2"; //已受理
                    dbEntity.HANDLE_TM = now;
                    if (dbEntity.HANDLE_UID == -1)//处理人为-1系统，说明是自动受理的，把当前用户设为处理人
                    {
                        dbEntity.HANDLE_UID = JdUser.ID;
                    }

                    dbEntity.DATA_TIMESTAMP = now;
                    dbEntity.HANDLE_JDS = model.HANDLE_JDS;
                    trans.Update(dbEntity);
                    #endregion

                    #region 添加发布信息

                    var ptComplaint = new PT_COMPLAIN
                    {
                        ID = 0,
                        TITLE = model.TITLE,
                        TYPE = "1",
                        TM = model.PUBLISH_TIME,
                        USER_ID = JdUser.ID,
                        CONTENTS = model.CONTENT,
                        AIDS = model.HANDLE_JDS,
                        CREATE_TM = now,
                        TS_ID = dbEntity.ID,
                        SOURCES = JdUser.UserDepartment?.DNAME,
                        IS_PUBLIC = model.IS_PUBLIC,
                    };
                    ptComplaint.ID = trans.Insert(ptComplaint);

                    #endregion

                    #region 添加操作记录

                    var log = new PT_ZXTS_LOG
                    {
                        ID = 0,
                        TS_ID = dbEntity.ID,
                        RECORDER_UID = JdUser.ID,
                        RECORDER_UNAME = JdUser.MANAGE_NAME,
                        RECORDER_DEPID = JdUser.DEPARTID,
                        RECORDER_OPERATION = dbEntity.STATE,
                        RECORDER_REMARK = model.CONTENT,
                        RECORDER_AIDS = model.HANDLE_JDS,
                        RECORDER_TM = dbEntity.DATA_TIMESTAMP
                    };
                    trans.Insert(log);

                    #endregion

                    #region 通知短信


                    SendMsgTSR(dbEntity, trans, "处理");//处理，发送短信提醒到投诉人
                    SetTP_DATA(dbEntity, trans);

                    #region 在线投诉【报建备案人员】处理的短信

                    var msg = ConfigHelper.AppSettings.SmsZXTS_BJBA;
                    if (!string.IsNullOrWhiteSpace(msg) && (model.DLJG_UID.HasValue || model.JSDW_UID.HasValue))
                    {
                        var users = Jd.TUserService.FindSendMsgByUid(model.DLJG_UID, model.JSDW_UID);
                        if (users.Any())
                        {
                            var telPhones = users.FindAll(c => !string.IsNullOrWhiteSpace(c.TELPHONE)).ToList();
                            if (telPhones.Any())
                            {
                                var dep = Jd.TUserDepartmentService.FirstOrNull(
                                    T_USER_DEPARTMENT._.DEPID == dbEntity.ACCEPT_DEPID);
                                var dName = dep == null ? string.Empty : dep.DNAME;
                                var content = string.Format(msg, dbEntity.TENDER_PROJECT_NAME, dName, "处理");
                                var sms = telPhones.Select(c => new T_SMS_SEND
                                {
                                    MODULE_NAME = "在线投诉模块",
                                    OPER_BY = JdUser.ID,
                                    RETRY = 0,
                                    TEL_PHONE = c.TELPHONE,
                                    SMS_CONTENT = content,
                                }).ToList();
                                trans.Insert(sms);
                            }

                        }
                    }

                    #endregion

                    #endregion

                    #region 抄送

                    if (model.ChaoSong != null && model.ChaoSong.Any())
                    {
                        var cxCode = $"TS{Guid.NewGuid().To16String(true)}"; //CreateComplaintCode("TS");

                        #region 查询码

                        var lookIntoChk = new PT_ZXTS_LOOK_INTO_CHK
                        {
                            ID = Guid.NewGuid().ToString(),
                            CX_CODE = cxCode,
                            TS_CODE = dbEntity.CODE,
                            EXPIREDTIME = now.AddMonths(6),
                            CREATEDBY = JdUser.ID?.ToString(),
                            UPDATEDBY = JdUser.ID?.ToString(),
                            CREATEDTIME = now,
                            UPDATEDTIME = now,
                            COMPLAINT_PUBLISH_ID = ptComplaint.ID?.ToString()
                        };
                        trans.Insert(lookIntoChk);

                        #endregion
                        var publicMsgFormat = ConfigHelper.AppSettings.SmsZXTS_DCQZ_CS_PUBLIC;
                        var publicContent = string.Format(publicMsgFormat, dbEntity.COMPLAINT_TITLE);//公开短信内容
                        var tsrMsgFormat = ConfigHelper.AppSettings.SmsZXTS_DCQZ_CS_TSR;
                        var tsrContent = string.Format(tsrMsgFormat, dbEntity.COMPLAINT_TITLE, dbEntity.CODE);//投诉人短信
                        var msgFormat = ConfigHelper.AppSettings.SmsZXTS_DCQZ_CS;
                        var content = string.Format(msgFormat, dbEntity.COMPLAINT_TITLE, cxCode);//非投诉人短信
                        Task.Run(() =>
                        {
                            var sms = new SmsCommon();

                            var mobiles = new List<string>();

                            #region 抄送人员

                            var lookIntos = Jd.PtZxtsLookIntoService.FeedbackListByTsCode(dbEntity.CODE);
                            var tsr = lookIntos.FindAll(c => c.IsTsr && !string.IsNullOrWhiteSpace(c.LOOK_CONTRACT));
                            var zbr = lookIntos.FindAll(c => c.IsZbr && !string.IsNullOrWhiteSpace(c.LOOK_CONTRACT));
                            var btsr = lookIntos.FindAll(c => c.IsBtsr && !string.IsNullOrWhiteSpace(c.LOOK_CONTRACT));
                            var dljg = lookIntos.FindAll(c => c.IsDljg && !string.IsNullOrWhiteSpace(c.LOOK_CONTRACT));
                            var qt = lookIntos.FindAll(c => c.IsQt && !string.IsNullOrWhiteSpace(c.LOOK_CONTRACT));

                            #endregion

                            #region 抄送人员号码

                            if (model.ToZbr)
                            {
                                mobiles.AddRange(zbr.Select(c => c.LOOK_CONTRACT));
                            }
                            if (model.ToBtsr)
                            {
                                mobiles.AddRange(btsr.Select(c => c.LOOK_CONTRACT));
                            }
                            if (model.ToDljg)
                            {
                                mobiles.AddRange(dljg.Select(c => c.LOOK_CONTRACT));
                            }
                            if (model.ToQt)
                            {
                                mobiles.AddRange(qt.Select(c => c.LOOK_CONTRACT));
                            }

                            #endregion

                            #region 抄送 fast fast biu~biu~biu~ （￣︶￣）↗　

                            if (model.IS_PUBLIC == 1)
                            {
                                if (model.ToTsr)
                                {
                                    mobiles.AddRange(tsr.Select(c => c.LOOK_CONTRACT));
                                }
                                sms.Content = publicContent;
                                sms.Mobile = string.Join(",", mobiles.Distinct());
                            }
                            else
                            {
                                if (model.ToTsr)
                                {
                                    sms.Content = tsrContent;
                                    sms.Mobile = string.Join(",", tsr.Select(c => c.LOOK_CONTRACT).Distinct());
                                    if (!string.IsNullOrWhiteSpace(sms.Mobile))
                                    {
                                        sms.SendSms();
                                    }
                                }
                                sms.Content = content;
                                sms.Mobile = string.Join(",", mobiles.Distinct());
                            }
                            if (!string.IsNullOrWhiteSpace(sms.Mobile))
                            {
                                sms.SendSms();
                            }

                            #endregion

                        });
                    }

                    #endregion
                    trans.Commit();
                }
                r.SetSuccess();
            }
            else
            {
                r.SetFail($"未找到对应编号为{model.CODE}的投诉消息");
            }
            return r;
        }

        /// <summary>
        /// 延迟处理
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult Delay(PtZxtsModel model)
        {
            var r = new GeneralResult();
            var dbEntity = FirstOrNull(PT_ZXTS._.CODE == model.CODE);
            if (dbEntity != null)
            {
                #region 校验

                if ((dbEntity.STATE != "4" && !(dbEntity.STATE == "7" && dbEntity.HANDLE_STATE == "1")) || model.STATE != "10")
                {
                    r.SetFailEx("非法请求", "当前该投诉不可处理");
                    return r;
                }
                if (dbEntity.ACCEPT_DEPID != JdUser.DEPARTID?.ToString())
                {
                    r.SetFail("当前该投诉非本部门的投诉，无权进行操作");
                    return r;
                }
                if (dbEntity.HANDLE_UID != JdUser.ID && dbEntity.HANDLE_UID != -1)
                {
                    r.SetFail("非该投诉的处理人，无权进行操作");
                    return r;
                }

                #endregion
                using (var trans = GetDbSession().BeginTransaction())
                {
                    var attachments = model.DELAY_SMS_ATTACHMENT.Select(c => c.JdSysAttachment(JdUser.ID)).ToList();
                    trans.Insert(attachments);
                    #region 更新处理信息

                    DateTime now = DateTime.Now;
                    dbEntity.Attach();
                    dbEntity.IS_DELAY = "1";
                    if (dbEntity.HANDLE_UID == -1)//处理人为-1系统，说明是自动受理的，把当前用户设为处理人
                    {
                        dbEntity.HANDLE_UID = JdUser.ID;
                    }
                    dbEntity.DATA_TIMESTAMP = now;
                    dbEntity.DELAY_UID = JdUser.ID;
                    dbEntity.DELAY_REMARK = model.DELAY_REMARK;
                    dbEntity.DELAY_TM = model.DELAY_TM;
                    dbEntity.OVER_TM = model.DELAY_TM;
                    dbEntity.DELAY_SMS = string.Join(",", attachments.Select(c => c.GUID));
                    trans.Update(dbEntity);
                    #endregion


                    #region 添加操作记录

                    var log = new PT_ZXTS_LOG
                    {
                        ID = 0,
                        TS_ID = dbEntity.ID,
                        RECORDER_UID = JdUser.ID,
                        RECORDER_UNAME = JdUser.MANAGE_NAME,
                        RECORDER_DEPID = JdUser.DEPARTID,
                        RECORDER_OPERATION = dbEntity.STATE,
                        RECORDER_REMARK = model.DELAY_REMARK,
                        RECORDER_AIDS = dbEntity.DELAY_SMS,
                        RECORDER_TM = dbEntity.DATA_TIMESTAMP
                    };
                    trans.Insert(log);

                    #endregion

                    trans.Commit();
                }
                r.SetSuccess();
            }
            else
            {
                r.SetFail($"未找到对应编号为{model.CODE}的投诉消息");
            }
            return r;
        }
        /// <summary>
        /// 撤诉
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult RevokeApproval(PtZxtsModel model)
        {
            var r = new GeneralResult();
            var dbEntity = FirstOrNull(PT_ZXTS._.CODE == model.CODE);
            if (dbEntity != null)
            {
                #region 校验

                if (dbEntity.STATE != "6" || (model.STATE != "7" && model.STATE != "8"))
                {
                    r.SetFail("非法请求");
                    return r;
                }


                #endregion
                var revoke = Jd.PtZxtsRevokeService.FindLastRevokeByTsId(dbEntity.ID);
                if (revoke == null)
                {
                    r.SetFail("未找到撤诉申请消息");
                    return r;
                }
                using (var trans = GetDbSession().BeginTransaction())
                {

                    #region 更新处理信息

                    DateTime now = DateTime.Now;
                    dbEntity.Attach();
                    dbEntity.DATA_TIMESTAMP = now;
                    dbEntity.STATE = model.STATE;
                    if (dbEntity.HANDLE_STATE == "1" && dbEntity.HANDLE_UID == -1)//处理人为-1系统，说明是自动受理的，把当前用户设为处理人
                    {
                        dbEntity.HANDLE_UID = JdUser.ID;
                    }
                    #endregion
                    if (model.STATE == "8")
                    {
                        var attachments = model.REVOKE_YJS_ATTACHMENT.Select(c => c.JdSysAttachment(JdUser.ID)).ToList();
                        trans.Insert(attachments);
                        dbEntity.REVOKE_YJS = string.Join(",", attachments.Select(c => c.GUID));
                    }
                    trans.Update(dbEntity);


                    revoke.Attach();
                    revoke.APPROVAL_UID = JdUser.ID;
                    revoke.APPROVAL_STATE = model.STATE == "7" ? 3 : 2;
                    revoke.REMARK = model.HANDLE_REMARK;
                    revoke.APPROVAL_TM = now;
                    trans.Update(revoke);
                    #region 添加操作记录

                    var log = new PT_ZXTS_LOG
                    {
                        ID = 0,
                        TS_ID = dbEntity.ID,
                        RECORDER_UID = JdUser.ID,
                        RECORDER_UNAME = JdUser.MANAGE_NAME,
                        RECORDER_DEPID = JdUser.DEPARTID,
                        RECORDER_OPERATION = dbEntity.STATE,
                        RECORDER_REMARK = model.HANDLE_REMARK,
                        RECORDER_AIDS = dbEntity.REVOKE_YJS,
                        RECORDER_TM = dbEntity.DATA_TIMESTAMP
                    };
                    trans.Insert(log);

                    #endregion

                    if (model.STATE == "7")
                    {
                        SendMsgTSR(dbEntity, trans, "不予撤诉");//不予撤诉，发送短信提醒到投诉人
                    }
                    if (model.STATE == "8")
                    {
                        SendMsgTSR(dbEntity, trans, "同意撤诉");//同意撤诉，发送短信提醒到投诉人
                    }
                    trans.Commit();
                }
                r.SetSuccess();
            }
            else
            {
                r.SetFail($"未找到对应编号为{model.CODE}的投诉消息");
            }
            return r;
        }
        #endregion



        #region 线上线下投诉附件生成


        /// <summary>
        /// 生成线下_投诉处理决定书
        /// </summary>
        /// <param name="complaint"></param>
        /// <returns></returns>
        public GeneralResult Create_TSCLJDS(TouSuChuLiJueDingShuModel complaint)
        {
            var r = new GeneralResult();
            var dbModel = FromWhere(PT_ZXTS._.CODE == complaint.CODE).First<PtZxtsModel>();
            if (dbModel != null)
            {
                var fileName = "投诉处理决定书";
                if (dbModel.TYPE == "2")
                {
                    fileName = $"线下_{fileName}";
                }
                var fullPath =
                    HttpContext.Current?.Server.MapPath($"~/Infrastructure/Templates/TSCL/{fileName}.doc");
                if (!File.Exists(fullPath))
                {
                    r.SetFailEx($"获取文件模板失败", $"{fullPath}");
                    return r;
                }
                var word = new AsposeWord(fullPath);

                if (dbModel.COMPLAINT_TYPE == "1")
                {
                    dbModel.COMPLAINT_NAME = dbModel.COMPLAINT_DNAME;
                }
                #region 模板生成

                word.ReplaceText("{TITLE}", complaint.TITLE);
                word.ReplaceText("{CODE}", complaint.CODE);
                word.ReplaceHtml("{CONTENT}", complaint.CONTENTS);
                word.ReplaceText("{DNAME}", JdUser?.UserDepartment?.DNAME ?? String.Empty);
                word.ReplaceText("{YYYY}", complaint.Year);
                word.ReplaceText("{MM}", complaint.Month);
                word.ReplaceText("{DD}", complaint.Day);
                foreach (var prop in dbModel.GetPropertyInfos())
                {
                    var valStr = string.Empty;
                    var val = prop.GetValue(dbModel);
                    if (val != null)
                    {
                        valStr = HttpUtility.HtmlDecode(val.ToString());
                        if (prop.PropertyType == typeof(DateTime?) || prop.PropertyType == typeof(DateTime))
                        {
                            valStr = Convert.ToDateTime(val).ToString("yyyy年MM月dd日");
                        }

                        if (prop.Name.IndexOf("phone", StringComparison.CurrentCultureIgnoreCase) > -1)
                        {
                            valStr = Regex.Replace(valStr, "(\\d{3})\\d{4}(\\d{4})", "$1****$2");
                        }
                    }
                    word.ReplaceText($"{{{prop.Name}}}", valStr);
                }


                #endregion

                using (var ms = new MemoryStream())
                {
                    word.doc.Save(ms, SaveFormat.Pdf);
                    ms.Seek(0, SeekOrigin.Begin);
                    var uploadRes = FileHelper.Uploader.UploadStream($"{fileName}_{complaint.CODE}.pdf", ms);
                    if (uploadRes.Result)
                    {
                        r.SetSuccess(uploadRes.Data);
                    }
                    else
                    {
                        r.SetFail(uploadRes.Msg);
                    }
                }
            }
            else
            {
                r.SetFail($"未找到对应编号为{complaint.CODE}的投诉消息");
            }
            return r;
        }
        /// <summary>
        /// 生成线下_不予受理通知书
        /// </summary>
        /// <param name="complaint"></param>
        /// <returns></returns>
        public GeneralResult Create_BYSLTZS(BuYuShouLiTongZhiShuModel complaint)
        {
            var r = new GeneralResult();
            var dbModel = FromWhere(PT_ZXTS._.CODE == complaint.CODE).First<PtZxtsModel>();
            if (dbModel != null)
            {

                var fileName = $"{dbModel.COMPLAINT_TYPE_TEXT}_不予受理通知书_{complaint.TYPE_TEXT}";
                if (dbModel.TYPE == "2")
                {
                    fileName = $"线下_{fileName}";
                }
                var fullPath =
                    HttpContext.Current?.Server.MapPath($"~/Infrastructure/Templates/TSCL/{fileName}.doc");
                if (!File.Exists(fullPath))
                {
                    r.SetFailEx($"获取文件模板失败", $"{fullPath}");
                    return r;
                }
                var word = new AsposeWord(fullPath);
                if (dbModel.COMPLAINT_TYPE == "1")
                {
                    dbModel.COMPLAINT_NAME = dbModel.COMPLAINT_DNAME;
                }
                #region 模板生成

                dbModel.SCCZWT = complaint.SCCZWT;
                foreach (var prop in dbModel.GetPropertyInfos())
                {
                    var valStr = string.Empty;
                    var val = prop.GetValue(dbModel);
                    if (val != null)
                    {
                        valStr = HttpUtility.HtmlDecode(val.ToString());
                        if (prop.PropertyType == typeof(DateTime?) || prop.PropertyType == typeof(DateTime))
                        {
                            valStr = Convert.ToDateTime(val).ToString("yyyy年MM月dd日");
                        }

                        if (prop.Name.IndexOf("phone", StringComparison.CurrentCultureIgnoreCase) > -1)
                        {
                            valStr = Regex.Replace(valStr, "(\\d{3})\\d{4}(\\d{4})", "$1****$2");
                        }
                    }
                    word.ReplaceText($"{{{prop.Name}}}", valStr);
                }
                foreach (var prop in complaint.GetPropertyInfos())
                {
                    var valStr = string.Empty;
                    var val = prop.GetValue(complaint);
                    if (val != null)
                    {
                        valStr = HttpUtility.HtmlDecode(val.ToString());
                        if (prop.PropertyType == typeof(DateTime?) || prop.PropertyType == typeof(DateTime))
                        {
                            valStr = Convert.ToDateTime(val).ToString("yyyy年MM月dd日");
                        }

                        if (prop.Name.IndexOf("phone", StringComparison.CurrentCultureIgnoreCase) > -1)
                        {
                            valStr = Regex.Replace(valStr, "(\\d{3})\\d{4}(\\d{4})", "$1****$2");
                        }
                    }
                    word.ReplaceText($"{{{prop.Name}}}", valStr);
                }

                var now = DateTime.Now;
                //word.ReplaceText("{TITLE}", complaint.TITLE);
                //word.ReplaceHtml("{CONTENT}", complaint.CONTENTS);
                word.ReplaceText("{DNAME}", JdUser?.UserDepartment?.DNAME ?? String.Empty);
                word.ReplaceText("{YYYY}", now.ToString("yyyy"));
                word.ReplaceText("{MM}", now.ToString("MM"));
                word.ReplaceText("{DD}", now.ToString("dd"));



                #endregion

                using (var ms = new MemoryStream())
                {
                    word.doc.Save(ms, SaveFormat.Pdf);
                    ms.Seek(0, SeekOrigin.Begin);
                    var uploadRes = FileHelper.Uploader.UploadStream($"{fileName}_{complaint.CODE}.pdf", ms);
                    if (uploadRes.Result)
                    {
                        r.SetSuccess(uploadRes.Data);
                    }
                    else
                    {
                        r.SetFail(uploadRes.Msg);
                    }
                }

            }
            else
            {
                r.SetFail($"未找到对应编号为{complaint.CODE}的投诉消息");
            }
            return r;
        }

        /// <summary>
        /// 生成延迟处理说明书
        /// </summary>
        /// <param name="complaint"></param>
        /// <returns></returns>
        public GeneralResult CreateDelayLetter(PtZxtsModel complaint)
        {
            var r = new GeneralResult();
            var dbModel = FromWhere(PT_ZXTS._.CODE == complaint.CODE).First<PtZxtsModel>();
            if (dbModel != null)
            {

                var fileName = $"{dbModel.COMPLAINT_TYPE_TEXT}_投诉延期处理说明书";
                var fullPath =
                    HttpContext.Current?.Server.MapPath($"~/Infrastructure/Templates/TSCL/{fileName}.doc");
                if (!File.Exists(fullPath))
                {
                    r.SetFailEx($"获取文件模板失败", $"{fullPath}");
                    return r;
                }
                var word = new AsposeWord(fullPath);
                if (dbModel.COMPLAINT_TYPE == "1")
                {
                    dbModel.COMPLAINT_NAME = dbModel.COMPLAINT_DNAME;
                }
                #region 模板生成
                foreach (var prop in dbModel.GetPropertyInfos())
                {
                    var valStr = string.Empty;
                    var val = prop.GetValue(dbModel);
                    if (val != null)
                    {
                        valStr = HttpUtility.HtmlDecode(val.ToString());
                        if (prop.PropertyType == typeof(DateTime?) || prop.PropertyType == typeof(DateTime))
                        {
                            valStr = Convert.ToDateTime(val).ToString("yyyy年MM月dd日");
                        }

                        if (prop.Name.IndexOf("phone", StringComparison.CurrentCultureIgnoreCase) > -1)
                        {
                            valStr = Regex.Replace(valStr, "(\\d{3})\\d{4}(\\d{4})", "$1****$2");
                        }
                    }
                    word.ReplaceText($"{{{prop.Name}}}", valStr);
                }


                var now = DateTime.Now;
                //word.ReplaceText("{TITLE}", complaint.TITLE);
                word.ReplaceHtml("{REMARK}", complaint.DELAY_REMARK);
                word.ReplaceText("{DNAME}", JdUser?.UserDepartment?.DNAME ?? String.Empty);
                word.ReplaceText("{YYYY}", now.ToString("yyyy"));
                word.ReplaceText("{MM}", now.ToString("MM"));
                word.ReplaceText("{DD}", now.ToString("dd"));



                #endregion

                using (var ms = new MemoryStream())
                {
                    word.doc.Save(ms, SaveFormat.Pdf);
                    ms.Seek(0, SeekOrigin.Begin);
                    var uploadRes = FileHelper.Uploader.UploadStream($"{fileName}_{complaint.CODE}.pdf", ms);
                    if (uploadRes.Result)
                    {
                        r.SetSuccess(uploadRes.Data);
                    }
                    else
                    {
                        r.SetFail(uploadRes.Msg);
                    }
                }

            }
            else
            {
                r.SetFail($"未找到对应编号为{complaint.CODE}的投诉消息");
            }
            return r;
        }


        /// <summary>
        /// 生成投诉撤回意见书
        /// </summary>
        /// <param name="complaint"></param>
        /// <returns></returns>
        public GeneralResult CreateRevokeOpinionLetter(PtZxtsModel complaint)
        {
            var r = new GeneralResult();
            var dbModel = FromWhere(PT_ZXTS._.CODE == complaint.CODE).First<PtZxtsModel>();
            if (dbModel != null)
            {

                var fileName = $"{dbModel.COMPLAINT_TYPE_TEXT}_投诉撤回意见书";
                var fullPath =
                    HttpContext.Current?.Server.MapPath($"~/Infrastructure/Templates/TSCL/{fileName}.doc");
                if (!File.Exists(fullPath))
                {
                    r.SetFailEx($"获取文件模板失败", $"{fullPath}");
                    return r;
                }
                var word = new AsposeWord(fullPath);
                if (dbModel.COMPLAINT_TYPE == "1")
                {
                    dbModel.COMPLAINT_NAME = dbModel.COMPLAINT_DNAME;
                }
                #region 模板生成
                foreach (var prop in dbModel.GetPropertyInfos())
                {
                    var valStr = string.Empty;
                    var val = prop.GetValue(dbModel);
                    if (val != null)
                    {
                        valStr = HttpUtility.HtmlDecode(val.ToString());
                        if (prop.PropertyType == typeof(DateTime?) || prop.PropertyType == typeof(DateTime))
                        {
                            valStr = Convert.ToDateTime(val).ToString("yyyy年MM月dd日");
                        }

                        if (prop.Name.IndexOf("phone", StringComparison.CurrentCultureIgnoreCase) > -1)
                        {
                            valStr = Regex.Replace(valStr, "(\\d{3})\\d{4}(\\d{4})", "$1****$2");
                        }
                    }
                    word.ReplaceText($"{{{prop.Name}}}", valStr);
                }

                var revoke = Jd.PtZxtsRevokeService.FindLastRevokeByTsId(dbModel.ID);
                var now = DateTime.Now;
                var sqRemark = string.Empty;
                if (revoke != null && !string.IsNullOrWhiteSpace(revoke.REMARK))
                {
                    sqRemark = revoke.REMARK;
                }
                word.ReplaceText("{SQ_REMARK}", sqRemark);
                word.ReplaceText("{REMARK}", complaint.HANDLE_REMARK);
                word.ReplaceText("{DNAME}", JdUser?.UserDepartment?.DNAME ?? String.Empty);
                word.ReplaceText("{YYYY}", now.ToString("yyyy"));
                word.ReplaceText("{MM}", now.ToString("MM"));
                word.ReplaceText("{DD}", now.ToString("dd"));



                #endregion

                using (var ms = new MemoryStream())
                {
                    word.doc.Save(ms, SaveFormat.Pdf);
                    ms.Seek(0, SeekOrigin.Begin);
                    var uploadRes = FileHelper.Uploader.UploadStream($"{fileName}_{complaint.CODE}.pdf", ms);
                    if (uploadRes.Result)
                    {
                        r.SetSuccess(uploadRes.Data);
                    }
                    else
                    {
                        r.SetFail(uploadRes.Msg);
                    }
                }

            }
            else
            {
                r.SetFail($"未找到对应编号为{complaint.CODE}的投诉消息");
            }
            return r;
        }

        protected string TsContentBuilder(PT_ZXTS dbEntity, BuYuShouLiTongZhiShuModel model)
        {
            var dbModel = dbEntity.ConvertTo<PtZxtsModel>();
            var fullPath = HttpContext.Current?.Server.MapPath($"~/Infrastructure/Templates/TSCL/{dbModel.COMPLAINT_TYPE_TEXT}_不予受理通知书_{model.TYPE_TEXT}.txt"); ;
            if (dbModel.COMPLAINT_TYPE == "1")
            {
                dbModel.COMPLAINT_NAME = dbModel.COMPLAINT_DNAME;
            }

            if (!string.IsNullOrWhiteSpace(fullPath) && File.Exists(fullPath))
            {
                var tmpStr = File.ReadAllText(fullPath);
                foreach (var prop in dbModel.GetPropertyInfos())
                {
                    var valStr = string.Empty;
                    var val = prop.GetValue(dbModel);
                    if (val != null)
                    {
                        valStr = HttpUtility.HtmlDecode(val.ToString());
                        if (prop.PropertyType == typeof(DateTime?) || prop.PropertyType == typeof(DateTime))
                        {
                            valStr = Convert.ToDateTime(val).ToString("yyyy年MM月dd日");
                        }

                        if (prop.Name.IndexOf("phone", StringComparison.CurrentCultureIgnoreCase) > -1)
                        {
                            valStr = Regex.Replace(valStr, "(\\d{3})\\d{4}(\\d{4})", "$1****$2");
                        }
                    }
                    tmpStr = tmpStr.Replace($"{{{prop.Name}}}", valStr);
                }
                foreach (var prop in model.GetPropertyInfos())
                {
                    var valStr = string.Empty;
                    var val = prop.GetValue(model);
                    if (val != null)
                    {
                        valStr = HttpUtility.HtmlDecode(val.ToString());
                        if (prop.PropertyType == typeof(DateTime?) || prop.PropertyType == typeof(DateTime))
                        {
                            valStr = Convert.ToDateTime(val).ToString("yyyy年MM月dd日");
                        }

                        if (prop.Name.IndexOf("phone", StringComparison.CurrentCultureIgnoreCase) > -1)
                        {
                            valStr = Regex.Replace(valStr, "(\\d{3})\\d{4}(\\d{4})", "$1****$2");
                        }
                    }
                    tmpStr = tmpStr.Replace($"{{{prop.Name}}}", valStr);
                }

                var now = DateTime.Now;
                tmpStr = tmpStr.Replace("{DNAME}", JdUser?.UserDepartment?.DNAME ?? String.Empty);
                tmpStr = tmpStr.Replace("{YYYY}", now.ToString("yyyy"));
                tmpStr = tmpStr.Replace("{MM}", now.ToString("MM"));
                tmpStr = tmpStr.Replace("{DD}", now.ToString("dd"));
                return tmpStr;
            }

            return "";
        }
        #endregion


        #endregion

        #region 监督点统计

        public List<PtZxtsModel> FindZxtsByTsIds(List<string> idList)
        {
            var list = new List<PtZxtsModel>();
            if (idList != null && idList.Any(c => !string.IsNullOrWhiteSpace(c)))
            {
                var tsIds = idList.Where(c => !string.IsNullOrWhiteSpace(c)).Distinct().ToList();
                list = FromWhere(PT_ZXTS._.ID.In(tsIds))
                    .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == PT_ZXTS._.ACCEPT_DEPID)
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == 72 && SYS_DIC._.VALUE == PT_ZXTS._.STATE)
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == 73 && SYS_DIC._.VALUE == PT_ZXTS._.ACCEPT_STATE)
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == 72 && SYS_DIC._.VALUE == PT_ZXTS._.HANDLE_STATE)
                    .Select(PT_ZXTS._.All
                        , T_USER_DEPARTMENT._.DNAME
                        , SYS_DIC._.TEXT.As("STATE_TEXT")
                        , new Field("TEXT", "SYS_DIC2").As("ACCEPT_STATE_TEXT")
                        , new Field("TEXT", "SYS_DIC3").As("HANDLE_STATE_TEXT"))
                    .ToList<PtZxtsModel>();
            }

            return list;
        }

        #endregion

        #region 监督首页-在线投诉

        public object GetZXTS_Data(MonitorHomePageModel model)
        {
            #region 查询条件

            var whereBuilder = new WhereClipBuilder(PT_ZXTS._.STATE != 9 && PT_ZXTS._.TYPE != 1);
            if (model.BeginTime.HasValue)
            {
                whereBuilder.And(PT_ZXTS._.CREATE_TM >= model.BeginTime);
            }
            if (model.EndTime.HasValue)
            {
                whereBuilder.And(PT_ZXTS._.CREATE_TM <= model.EndTime);
            }

            if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
            {
                if (model.REGION_CODE.Equals("3501"))
                {
                    whereBuilder.And(TENDER_PROJECT._.REGION_CODE.BeginWith(model.REGION_CODE) && TENDER_PROJECT._.REGION_CODE != "350128");
                }
                else
                {
                    whereBuilder.And(TENDER_PROJECT._.REGION_CODE.BeginWith(model.REGION_CODE));
                }
            }

            var kinds = JdUser?.UserDepartment?.HY_TYPE_LIST;
            if (kinds != null && kinds.Any())
            {
                whereBuilder.And(SYS_DIC._.VALUE.In(kinds));
            }

            if (!string.IsNullOrWhiteSpace(model.HY_TYPE))
            {
                whereBuilder.And(SYS_DIC._.VALUE == model.HY_TYPE);
            }

            #endregion

            var query = FromWhere(whereBuilder.ToWhereClip())
                .InnerJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == PT_ZXTS._.TENDER_PROJECT_CODE)
                //.LeftJoin<SYS_DIC>(SYS_DIC._.TYPE==76&&(SYS_DIC._.VALUE1==TENDER_PROJECT._.RTYPE||SYS_DIC._.VALUE1=="MZ"))
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == 76 && SYS_DIC._.VALUE1 == new Field("(CASE TENDER_PROJECT.RTYPE WHEN 'MT' THEN 'MZ' ELSE TENDER_PROJECT.RTYPE END)"))
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == 72 && SYS_DIC._.VALUE == PT_ZXTS._.STATE);

            #region 状态统计 GZGK_MANAGE.Get_ZXTS_ZT

            var state=query.Select(
                PT_ZXTS._.All.Count().As("ZS_NUM")
                ,new Field("(CASE WHEN PT_ZXTS.STATE IN ('1','2','4','6','7') THEN 1 ELSE 0 END)").Sum().Nvl(0).As("DB_NUM")
                , new Field("(CASE WHEN PT_ZXTS.STATE IN ('3','5','8') THEN 1 ELSE 0 END)").Sum().Nvl(0).As("YB_NUM"))
                .ToFirst<MonitorHomePageSummaryStatisticsModel>();

            #endregion

            #region  列表 GZGK_MANAGE.Get_ZXTS_List

            var list= FromWhere(whereBuilder.ToWhereClip())
                .InnerJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == PT_ZXTS._.TENDER_PROJECT_CODE)
                //.LeftJoin<SYS_DIC>(SYS_DIC._.TYPE==76&&(SYS_DIC._.VALUE1==TENDER_PROJECT._.RTYPE||SYS_DIC._.VALUE1=="MZ"))
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == 76 && SYS_DIC._.VALUE1 == new Field("(CASE TENDER_PROJECT.RTYPE WHEN 'MT' THEN 'MZ' ELSE TENDER_PROJECT.RTYPE END)"))
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == 72 && SYS_DIC._.VALUE == PT_ZXTS._.STATE)
                .Select(
                PT_ZXTS._.CODE
                ,TENDER_PROJECT._.TENDER_PROJECT_NAME
                ,PT_ZXTS._.STATE
                ,new Field("TEXT","SYS_DIC2").As("STATE_TEXT")
                ,new Field("(CASE PT_ZXTS.COMPLAINT_TYPE WHEN '1' THEN PT_ZXTS.COMPLAINT_DNAME ELSE PT_ZXTS.COMPLAINT_NAME END)").As("COMPLAINT_NAME")
                ,PT_ZXTS._.COMPLAINT_CONTENT)
                .ToList<PtZxtsModel>();

            #endregion
            var reg = new Regex(@"(<[^>]*>)|(&nbsp;?)|(\s)", RegexOptions.IgnoreCase);
            return new
            {
                stateData=new List<LabelValueModel>
                {
                    new LabelValueModel{Label = "投诉总数",Value = state.ZS_NUM.ToString()},
                    new LabelValueModel{Label = "待办投诉",Value = state.DB_NUM.ToString()},
                    new LabelValueModel{Label = "已办投诉",Value = state.YB_NUM.ToString()},
                },
                listData=list.Select(c=>new{
                    c.CODE,
                    c.COMPLAINT_NAME,
                    c.TENDER_PROJECT_NAME,
                    c.STATE,
                    c.STATE_TEXT,
                    COMPLAINT_CONTENT= reg.Replace(c.COMPLAINT_CONTENT, "")
                }).ToList()
            };
        }

        #endregion

        #region 处长门户
        /// <summary>
        /// 纪委监委 发起督查 在线投诉细项
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult PtZxtsSuperviseItem(TSuperviseModel model)
        {
            var r = new GeneralResult();
            var dbModel = FromWhere(PT_ZXTS._.ID == model.ENTITY_ID)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == PT_ZXTS._.ACCEPT_DEPID)
                .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == PT_ZXTS._.TENDER_PROJECT_CODE)
                .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == TENDER_PROJECT._.REGION_CODE)
                //.LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "2002" && SYS_DIC._.VALUE == TENDER_PROJECT._.TENDER_PROJECT_TYPE) //工程类别
                .Select(
                    PT_ZXTS._.ACCEPT_DEPID.As("DEPID"),
                    T_USER_DEPARTMENT._.DNAME.As("SCDW"),
                    PT_ZXTS._.TENDER_PROJECT_CODE.As("BH"),
                    PT_ZXTS._.TENDER_PROJECT_NAME.As("MC"),
                    SYS_AREA_QUANGUO._.AREANAME.As("DQ"),
                    //SYS_DIC._.TEXT.As("TYPE_TEXT"),
                    new Field("'投诉处理'").As("SXLX")
                    ).ToFirst<object>();
            if (dbModel != null)
            {
                r.SetSuccess(dbModel);
            }
            else
            {
                r.SetFail("未找到对应的投诉信息");
            }
            return r;
        }

        #endregion

        #region 审批单位-首页在线投诉
        /// <summary>
        ///  首页项目监督预警统计-预警计数接口
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<LabelValueModel<int>> ONLineCount(TAfcProjectStatisticsModel model)
        {
            var condition = new WhereClipBuilder();
            var departRootAreaCode = JdUser?.UserDepartment?.RootAreaCode;//默认归属地
            var hyList = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;//默认行业
            if (!string.IsNullOrWhiteSpace(departRootAreaCode) && hyList != null && hyList.Any())
            {
                var pcode = departRootAreaCode.PadRight(6, '0');
                condition.And(PT_ZXTS._.REGION_CODE.BeginWith(departRootAreaCode));//当前账号 归属地
                condition.And(PT_ZXTS._.TENDER_PROJECT_TYPE.In(hyList));//当前账号 行业
                if (!string.IsNullOrEmpty(model.PROJECT_TYPE))
                {
                    var projectType = model.PROJECT_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    condition.And(WARN_RESULT._.TENDER_PROJECT_TYPE.In(projectType));// 01 02 03 TENDER_PROJECT(A01,A02) PT_ZXTS  RECORD_REVIEW 
                }
                if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
                {
                    pcode = model.REGION_CODE.PadRight(6, '0');
                    if (model.REGION_CODE.Length < 6)
                    {
                        condition.And(WARN_RESULT._.REGION_CODE.BeginWith(model.REGION_CODE));
                        if (model.REGION_CODE == "35" || model.REGION_CODE == "3501")
                        {
                            condition.And(WARN_RESULT._.REGION_CODE != "350128");//平潭综合试验区 350100 福州市
                        }
                    }
                    else
                    {
                        condition.And(WARN_RESULT._.REGION_CODE == model.REGION_CODE);
                    }
                }
            }
            if (model.BeginTime != null)
            {
                condition.And(WARN_RESULT._.SP_TIME >= model.BeginTime);
            }
            if (model.EndTime != null)
            {
                condition.And(WARN_RESULT._.SP_TIME <= model.EndTime);
            }
            //RESULT_STATUS
            //处理状态OPERATE_STATUS 1:待处理 2：已发出预警信息 3： 已反馈  4：反馈已读  5：已办结 
            var con = condition.ToWhereClip();
            var result = Fw.WarnResultService.FromWhere(con);
            var total = result.Where(p => p.RESULT_STATUS == "2" || p.RESULT_STATUS == "3").Select(WARN_RESULT._.TENDER_PROJECT_CODE).Distinct().Count();//异常监督点数 红灯+黄灯
            var sended = result.GroupBy(WARN_RESULT._.TENDER_PROJECT_CODE, WARN_RESULT._.OPERATE_STATUS).Where(p => p.OPERATE_STATUS == "2").Count();//发出预警数
            var responsed = result.GroupBy(WARN_RESULT._.TENDER_PROJECT_CODE, WARN_RESULT._.OPERATE_STATUS).Where(p => p.OPERATE_STATUS == "3").Count();//已反馈
            var overted = sended - responsed;//未反馈
            return new List<LabelValueModel<int>>
            {
                new LabelValueModel<int>{Label = "项目异常总数",Value = total},
                new LabelValueModel<int>{Label = "发出预警数",Value = sended},
                new LabelValueModel<int>{Label = "预警已反馈数",Value = responsed},
                new LabelValueModel<int>{Label = "预警未反馈数",Value = overted},
            };
        }
        #endregion
    }
}