using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using Dos.ORM;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZY.Core.Sms;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Helper;
using GGZYJD.DbEntity;
using Newtonsoft.Json;
using GGZY.Core.Extensions;
using System.Web;
using System.Collections;
using GGZY.Services.JianDu.Record_Review_Doc;
using System.Data;
using PullData.ConvergenceService;
using GGZY.Core.Helper;
using System.ComponentModel;
using GGZY.Services.Extensions;
using System.Text.RegularExpressions;

namespace GGZY.Services.JianDu
{
    public partial class RecordReviewService
    {
        /// <summary>
        /// 判断招标文件备案、书面情况备案是否 是唯一的
        /// </summary>
        /// <param name="TENDER_PROJECT_CODE">招标项目编号</param>
        /// <param name="REVIEW_TYPE">备案类型 SYS_DIC Type:3021</param>
        public GeneralResult CheckIsSingleByReviewType(string TENDER_PROJECT_CODE, string REVIEW_TYPE, decimal? RECORD_ID)
        {
            var result = new GeneralResult();
            result.SetSuccess();
            //101 招标文件备案 104 招标投标情况书面报告备案
            if (!(new string[] { "101", "104" }).Contains(REVIEW_TYPE.Substring(2, 3)))
            {
                return result;
            }
            var condition = new WhereClipBuilder();
            condition.And(RECORD_REVIEW._.TENDER_PROJECT_CODE == TENDER_PROJECT_CODE);
            condition.And(RECORD_REVIEW._.REVIEW_TYPE == REVIEW_TYPE);
            if (RECORD_ID.HasValue && RECORD_ID > 0)
            {
                condition.And(RECORD_REVIEW._.ID != (int)RECORD_ID);
            }
            var data = FromWhere(condition.ToWhereClip())
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "3021" && RECORD_REVIEW._.REVIEW_TYPE == SYS_DIC._.VALUE)
                .Select(
                    new Field("TEXT", "SYS_DIC").As("REVIEW_TYPE")).First();
            if (null == data)
            {
                return result;
            }
            result.SetFail(data.REVIEW_TYPE + " 只允许一条记录");
            return result;
        }

        /// <summary>
        /// 判断提交时的模板与当前招标项目中的备案类型是否 相同
        /// </summary>
        /// <param name="TENDER_PROJECT_CODE">招标项目编号</param>
        /// <param name="REVIEW_TYPE">备案类型编码</param>
        /// <returns></returns>
        public bool CheckIsTrueReviewType(string TENDER_PROJECT_CODE, string REVIEW_TYPE)
        {
            var condition = new WhereClipBuilder();
            condition.And(TENDER_PROJECT._.TENDER_PROJECT_CODE == TENDER_PROJECT_CODE);
            condition.And(TENDER_PROJECT._.RTYPE == REVIEW_TYPE.Substring(0, 2));

            var count = Count<TENDER_PROJECT>(condition.ToWhereClip());

            return count > 0;
        }
        /// <summary>
        /// 生成备案编号
        /// </summary>
        /// <param name="tender_project_type">招标项目类型代码</param>
        /// <returns></returns>
        public string CreateReviewCode(string tender_project_type)
        {
            if (String.IsNullOrWhiteSpace(tender_project_type) || tender_project_type.Length < 3)
            {
                throw new Exception("生成备案编号失败: 招标项目类型代码不能为空或小于3位");
            }
            var currentCode = FromSql("select REVIEW_CODE from RECORD_REVIEW where id = (select max(ID) FROM RECORD_REVIEW)").ToScalar<string>();
            var REVIEW_CODE = DateTime.Now.ToString("yyyyMM");
            if (String.IsNullOrWhiteSpace(currentCode))
            {
                return tender_project_type.Substring(0, 3) + REVIEW_CODE + "000001";
            }
            //每个月从1开始重新计数
            if (currentCode.Substring(3, 6) != DateTime.Now.ToString("yyyyMM"))
            {
                return tender_project_type.Substring(0, 3) + REVIEW_CODE + "000001";
            }
            var seq = currentCode.Substring(9, currentCode.Length - 9);
            if (String.IsNullOrWhiteSpace(seq))
            {
                return tender_project_type.Substring(0, 3) + REVIEW_CODE + "000001";
            }
            REVIEW_CODE += (int.Parse(seq) + 1).ToString().PadLeft(6, '0');
            return tender_project_type.Substring(0, 3) + REVIEW_CODE;
        }


        /// <summary>
        /// 备案主表新增或更新记录
        /// </summary>
        /// <param name="tran"></param>
        /// <param name="review">Record_Review</param>
        /// <param name="now"></param>
        /// <param name="tender_project_type">招标项目类型</param>
        /// <returns></returns>
        public int CreateOrUpdate(DbTrans tran, RECORD_REVIEW review, DateTime now, string tender_project_type,
            List<UploadResData_ReviewRequest> attachments)
        {
            //添加操作
            if (!review.ID.HasValue || review.ID == 0)
            {


                if (review.REVIEW_STATUS == "1")
                {
                    review.COMMIT_TIME = now;
                    review.IS_SIGN = 0;
                    //MZ102,MT102:住建-澄清修改备案
                    if (new string[] { "MZ102", "MT102" }.Contains(review.REVIEW_TYPE))
                    {
                        review.REVIEW_STATUS = "4";
                    }
                }
                review.REVIEW_CODE = CreateReviewCode(tender_project_type);
                review.CREATE_TM = now;
                review.CREATOR = Identity?.JdUser()?.ID;
                review.ID = tran.Insert<RECORD_REVIEW>(review);

                Jd.RecordAttachmentService.Insert(tran, review.ID, attachments);
                return (int)review.ID;
            }
            //更新操作
            if (true)
            {
                Jd.RecordAttachmentService.Update(tran, review.ID, attachments);
                if (review.REVIEW_STATUS == "1" || review.REVIEW_STATUS =="4")
                {
                    review.Attach();
                    review.REVIEW_STATUS = review.REVIEW_STATUS;
                    review.COMMIT_TIME = now;

                    if(! review.REVIEW_STATUS.StartsWith("MT") && !review.REVIEW_STATUS.StartsWith("MZ"))
                    {
                        review.IS_SIGN = 0;
                        review.SIGN_COMMENT = "";
                    }
                    return tran.Update<RECORD_REVIEW>(review);
                    //review.IS_SIGN = 0;
                }
                return (int)review.ID;
                
            }

        }

        public GeneralResult Retract(int record_id)
        {
            GeneralResult r = new GeneralResult();
            var record_review = Jd.RecordReviewService.FirstOrNull(RECORD_REVIEW._.ID == record_id);
            if (null == record_review)
            {
                r.SetFail("记录不存在.未找到 RECORD_REVIEW 信息");
                return r;
            }
            if (record_review.CREATOR != JdUser?.ID)
            {
                r.SetFail("操作失败:非法授权");
                return r;
            }
            if (record_review.REVIEW_STATUS == "1" && record_review.IS_SIGN.HasValue && (int)record_review.IS_SIGN == 1)
            {
                r.SetFail("操作失败:已签收记录暂不支持撤回操作");
                return r;
            }
            if (!((record_review.REVIEW_STATUS == "1")
                || (record_review.REVIEW_TYPE.Substring(2, 3) == "101" && record_review.REVIEW_STATUS == "4")
                || (record_review.REVIEW_TYPE.Substring(2, 3) == "102" && record_review.REVIEW_STATUS == "4")
                ))
            {
                r.SetFail("操作失败:当前状态暂不支持撤回操作");
                return r;
            }

            var now = Jd.CommonService.GetDBDateTime();
            record_review.Attach();
           
            if (record_review.REVIEW_STATUS == "4" && record_review.REVIEW_TYPE.Substring(2, 3) == "101")
            {
                record_review.REVIEW_STATUS = "8";
            }
            else
            {
                record_review.IS_SIGN = 0;
                record_review.REVIEW_STATUS = "0";
                record_review.SIGN_TIME = null;
                record_review.REVIEW_TIME = null;
            }

            OPERTION_RECORD history = new OPERTION_RECORD();
            history.RECORD_ID = record_review.ID;
            history.OPERATION_PERSON = JdUser.ID;
            history.DEPID = JdUser.DEPARTID;
            history.OPERATION_BEHAVIOR = 10;//撤回
            history.CREATOR = JdUser.ID;
            history.INSTANCE_ID = -1;
            history.CREATE_TM = now;
            history.OPERATION_TIME = now;


            var db = GetDbSession();
            using (var tran = db.BeginTransaction())
            {
                try
                {
                    tran.Update<RECORD_REVIEW>(record_review);
                    tran.Insert<OPERTION_RECORD>(history);
                    tran.Delete<REVIEW_INSTANCE>(REVIEW_INSTANCE._.BA_ID == record_id && REVIEW_INSTANCE._.IS_END == 0 && (REVIEW_INSTANCE._.MAIN_ID == "4" || REVIEW_INSTANCE._.MAIN_ID == "5"));
                    tran.Commit();
                    r.SetSuccess();
                    return r;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    var requestid = Guid.NewGuid().ToString();
                    LoggerR.Error("logid:" + requestid + ",撤回备案 失败:" + ex.Message
                        + Logger.GetRequestMessage(HttpContext.Current), ex);

                    r.SetException("操作失败:" + ex.Message + ",请求id:" + requestid, ex);
                    return r;
                }
            }
        }

        /// <summary>
        /// 备案主表新增或更新记录
        /// </summary>
        /// <param name="tran"></param>
        /// <param name="review">Record_Review</param>
        /// <param name="now"></param>
        /// <param name="tender_project_type">招标项目类型</param>
        /// <returns></returns>
        public int CreateOrUpdate(DbTrans tran, RECORD_REVIEW review, DateTime now, string tender_project_type,
            List<UploadResData_ReviewRequest> attachments, List<string> bid_section_codes)
        {

            //添加操作
            if (!review.ID.HasValue)
            {
                if (review.REVIEW_STATUS == "1")
                {
                    review.COMMIT_TIME = now;
                    review.IS_SIGN = 0;
                    //MZ102,MT102:住建-澄清修改备案
                    if ((new string[] { "MZ102", "MT102" }).Contains(review.REVIEW_TYPE))
                    {
                        review.REVIEW_STATUS = "4";
                    }
                    if (! (review.REVIEW_TYPE.StartsWith("MZ") || review.REVIEW_TYPE.StartsWith("MT")) 
                        &&( review.REVIEW_TYPE.EndsWith("102") || review.REVIEW_TYPE.EndsWith("103") ||
                           review.REVIEW_TYPE.EndsWith("105")))
                    {
                        review.IS_SIGN = 1;
                    }
                }
                review.REVIEW_CODE = CreateReviewCode(tender_project_type);
                review.CREATE_TM = now;
                review.CREATOR = Identity?.JdUser()?.ID;
                review.ID = tran.Insert<RECORD_REVIEW>(review);

                foreach (var bid_section_code in bid_section_codes)
                {
                    Jd.RecordAttachmentService.Insert(tran, review.ID,
                       attachments.Where(w => w.BID_SECTION_CODE == bid_section_code).ToList(), bid_section_code);
                }
                if(attachments.Where(w => !bid_section_codes.Contains(w.BID_SECTION_CODE)).Any())
                {
                    Jd.RecordAttachmentService.Insert(tran, review.ID,
                           attachments.Where(w => ! bid_section_codes.Contains(w.BID_SECTION_CODE)).ToList());
                }
                return (int)review.ID;
            }

            //更新操作
            if (true)
            {
                foreach (var bid_section_code in bid_section_codes)
                {
                    Jd.RecordAttachmentService.Update(tran, review.ID,
                       attachments.Where(w => w.BID_SECTION_CODE == bid_section_code).ToList(), bid_section_code);
                }
                if (attachments.Where(w => !bid_section_codes.Contains(w.BID_SECTION_CODE)).Any())
                {
                    Jd.RecordAttachmentService.Update(tran, review.ID,
                           attachments.Where(w => !bid_section_codes.Contains(w.BID_SECTION_CODE)).ToList());
                }
                if (review.REVIEW_STATUS == "1")
                {
                    review.Attach();
                    review.COMMIT_TIME = now;
                    tran.Update<RECORD_REVIEW>(review);
                }
                return (int)review.ID;
            }

        }

        /// <summary>
        /// 通用类型备案提交（只有附件信息）
        /// </summary>
        /// <param name="review"></param>
        /// <param name="biddoc"></param>
        /// <param name="state_type">0 :暂存 1：送审</param>
        /// <returns></returns>
        public GeneralResult SaveOrSubmit(TENDER_PROJECT tender_project, RECORD_REVIEW review, List<UploadResData_ReviewRequest> attachments)
        {
            var r = new GeneralResult();
            r.SetSuccess();


            var now = Jd.CommonService.GetDBDateTime();

            var db = GetDbSession();
            using (var tran = db.BeginTransaction())
            {
                try
                {
                    var isUpdate = review.ID.HasValue && review.ID > 0;
                    CreateOrUpdate(tran, review, now, tender_project.TENDER_PROJECT_TYPE, attachments);
                    var data = new
                    {
                        RECORD_REVIEW = review,
                        RECORD_ATTACHMENT = attachments
                    };
                    Jd.RecordReviewService.SaveRecordAndLog(tran, review, attachments, now, data);
                    tran.Commit();
                    r.SetSuccess(new
                    {
                        RECORD_ID = review.ID
                    });
                    Jd.RecordReviewService.Notify(review.ID);
                    return r;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    LoggerR.Error("备案提交失败:" + ex.Message, ex);
                    r.SetException("提交失败:" + ex.Message, ex);
                    return r;
                }
            }
        }


        /// <summary>
        /// 住建行业类型备案提交（只有附件信息）
        /// </summary>
        /// <param name="review"></param>
        /// <param name="biddoc"></param>
        /// <param name="state_type">0 :暂存 1：送审</param>
        /// <returns></returns>
        public GeneralResult SaveOrSubmit_ZJ(TENDER_PROJECT tender_project, RECORD_REVIEW review, List<UploadResData_ReviewRequest> attachments)
        {
            var r = CheckDepartMent(review, tender_project);
            if (!r.Success)
            {
                return r;
            }
            var dept_info = r.Data;
            var now = Jd.CommonService.GetDBDateTime();
            var db = GetDbSession();
            using (var tran = db.BeginTransaction())
            {
                try
                {
                    var isUpdate = review.ID.HasValue && review.ID > 0;
                    CreateOrUpdate(tran, review, now, tender_project.TENDER_PROJECT_TYPE, attachments);
                    var data = new
                    {
                        RECORD_REVIEW = review,
                        RECORD_ATTACHMENT = attachments
                    };
                    Jd.RecordReviewService.SaveRecordAndLog(tran, review, attachments, now, data, dept_info);
                    tran.Commit();
                    r.SetSuccess(new
                    {
                        RECORD_ID = review.ID
                    });
                    Jd.RecordReviewService.Notify(review.ID);
                    return r;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    LoggerR.Error("备案提交失败:" + ex.Message, ex);
                    r.SetException("提交失败:" + ex.Message, ex);
                    return r;
                }
            }
        }


        /// <summary>
        /// 住建行业，根据审查类型，检测部门信息是否一致
        /// </summary>
        /// <param name="review"></param>
        /// <param name="tender_project"></param>
        /// <returns></returns>
        public GeneralResult CheckDepartMent(RECORD_REVIEW review, TENDER_PROJECT tender_project)
        {
            int sc_type = 11;//审核类型，review_main表的sc_type
            if ("MZ102" == review?.REVIEW_TYPE || "MT102" == review?.REVIEW_TYPE || review.REVIEW_STATUS =="4")
            {
                //澄清修改  直接到审核流程
                sc_type = 21;
            }

            var node_id = Jd.ReviewNodeService.GetBySCType(sc_type)?.ID;//审查节点ID
            var dept_id = int.Parse(tender_project.RECORD_DEPID);//备案部门ID
            var depConfigList = Jd.ReviewDepconfigService.FindList(REVIEW_DEPCONFIG._.NODE_ID == node_id
                && REVIEW_DEPCONFIG._.IS_SELECT == 1
                && REVIEW_DEPCONFIG._.DEP_ID == dept_id);
            if (!depConfigList.Any())
            {
                return getDepMsg(dept_id);
            }
            GeneralResult r = new GeneralResult();
            r.SetSuccess(new
            {
                node_id = node_id,
                dept_id = dept_id,
                dept_config = depConfigList
            });
            r.Success = true;
            return r;
        }
        /// <summary>
        /// 根据部门ID，获取该部门未设置默认接收人提示信息
        /// </summary>
        /// <param name="DEP_ID"></param>
        /// <returns></returns>
        private GeneralResult getDepMsg(int DEP_ID)
        {
            var r = new GeneralResult();
            var phone = FirstOrNull<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == DEP_ID)?.PHONE;
            if (String.IsNullOrWhiteSpace(phone))
            {
                phone = "暂无电话";
            }
            r.SetFail("该主管部门未设置默认备案接收人，无法提交，请联系相关主管部门!联系方式:" + phone);
            return r;
        }
        /// <summary>
        /// 保存操作记录以及操作日志
        /// </summary>
        /// <param name="tran">事务tran</param>
        /// <param name="review">record_review</param>
        /// <param name="attachments">附件信息</param>
        /// <param name="now">数据库当前时间</param>
        /// <param name="data">数据内容和附件内容字符串</param>
        public void SaveRecordAndLog(DbTrans tran, RECORD_REVIEW review,
            List<UploadResData_ReviewRequest> attachments, DateTime now,
            dynamic data, dynamic dept_info = null)
        {
            decimal? instanceid = -1;
            if ((review.REVIEW_TYPE.StartsWith("MZ") || review.REVIEW_TYPE.StartsWith("MT"))
                && review.REVIEW_TYPE.Substring(2, 3) != "103" && (review.REVIEW_STATUS == "1" ||
                review.REVIEW_STATUS == "4"))
            {
                //异议处理不需要操作
                var condition = new WhereClipBuilder();
                condition.And(REVIEW_NODE._.ID == dept_info?.node_id);
                REVIEW_NODE rnModel = Jd.ReviewNodeService.FirstOrNull(condition.ToWhereClip());
                REVIEW_INSTANCE insModel = new REVIEW_INSTANCE();
                insModel.BA_ID = review.ID;
                insModel.CREATE_BY = JdUser?.ID;
                insModel.CREATE_TM = now;
                insModel.IS_END = 0;
                insModel.MAIN_ID = rnModel.MAIN_ID.Value;
                insModel.NOW_NODE = rnModel?.ID;
                insModel.TIMEOUT = Jd.THolidayService.GetWorkDate(now, !rnModel.TIMEOUT.HasValue ? 0 : (int)rnModel.TIMEOUT.Value);
                insModel.STAFF = "";
                insModel.TENDER_PROJECT_CODE = review.TENDER_PROJECT_CODE;
                List<string> nowUsers = new List<string>();
                if (dept_info != null)
                {
                    foreach (REVIEW_DEPCONFIG m in (List<REVIEW_DEPCONFIG>)dept_info?.dept_config)
                    {
                        nowUsers.Add(m.USER_ID.ToString());
                    }
                }
                insModel.NOW_USERS = string.Join(",", nowUsers.ToArray());
                insModel.ID = tran.Insert<REVIEW_INSTANCE>(insModel);
                instanceid = insModel.ID;

            }

            //送审,保存操作记录
            if (review.REVIEW_STATUS == "1" || review.REVIEW_STATUS == "4")
            {
                OPERTION_RECORD record = new OPERTION_RECORD();
                record.RECORD_ID = review.ID;
                record.OPERATION_BEHAVIOR = 1;
                record.DEPID = Identity?.JdUser().DEPARTID;
                record.OPERATION_TIME = now;
                record.CREATE_TM = now;
                record.OPERATION_PERSON = JdUser?.ID;
                record.CREATOR = Identity?.JdUser().ID;
                record.INSTANCE_ID = instanceid;
                record.ID = tran.Insert(record);

                RECORD_LOG record_log = new RECORD_LOG();
                record_log.BA_ID = review.ID.ToString();
                record_log.TENDER_PROJECT_CODE = review.TENDER_PROJECT_CODE;
                record_log.SUBMIT_PERSON = Identity?.JdUser()?.ID.ToString();
                record_log.SUBMIT_DEPID = Identity?.JdUser()?.DEPARTID.ToString();
                record_log.CREATE_TIME = now;
                record_log.ATTCHAMENT = JsonConvert.SerializeObject(attachments);
                record_log.OPER_ID = record.ID.ToString();
                record_log.DATA_AND_ATT = JsonConvert.SerializeObject(data);
                record_log.ID = tran.Insert<RECORD_LOG>(record_log);
            }
        }



        /// <summary>
        /// 备案提醒
        /// </summary>
        /// <param name="RECORD_ID"></param>
        public void Notify(decimal? RECORD_ID)
        {
            try
            {
                string sqlStr = @"select r.create_tm, P.TENDER_PROJECT_NAME,P.RECORD_DEPID,SD.TEXT REVIEW_TYPE_TEXT,
                      (SELECT listagg(TELPHONE,',') within group(order by DEPARTID) FROM T_USER WHERE  IS_SEND_MSG=1 and IS_ENABLE=1 and  TYPE=0 and    DEPARTID = P.RECORD_DEPID) TELPHONES
                    , R.CREATOR  ,U.DEPARTID,(CASE  WHEN E.DEP_NAME IS NOT NULL THEN  E.DEP_NAME ELSE (SELECT DNAME FROM T_USER_DEPARTMENT WHERE DEPID = U.DEPARTID )  END ) DEPNAME
                from RECORD_REVIEW R
                LEFT JOIN TENDER_PROJECT P ON R.TENDER_PROJECT_CODE = P.TENDER_PROJECT_CODE
                LEFT JOIN T_USER U ON R.CREATOR = U.ID
                LEFT JOIN T_USER_EXTEND E ON E.U_ID = R.CREATOR
                LEFT JOIN SYS_DIC SD ON SD.TYPE =3021 AND SD.VALUE = R.REVIEW_TYPE
               where R.ID = " + RECORD_ID;

                var data = FromSql(sqlStr).ToFirst<dynamic>();
                if (null == data)
                {
                    Logger.Warn("发送短信提醒失败：未找到接收人手机号码配置");
                    return;
                }

                if (data.TELPHONES == null || String.IsNullOrWhiteSpace(data.TELPHONES.ToString()))
                {
                    Logger.Warn("发送短信提醒失败：未找到接收人手机号码配置");
                    return;
                }

                var contentTemplate = ConfigHelper.AppSettings.SmsRecordSubmitContext;
                var msg = string.Format(contentTemplate, data.TENDER_PROJECT_NAME?.ToString(),
                    data.REVIEW_TYPE_TEXT?.ToString(), data.DEPNAME?.ToString());
                var smsModel = new SmsCommon
                {
                    Mobile = data["TELPHONES"].ToString(),
                    Content = msg
                };
                smsModel.SendSms();
            }
            catch (Exception ex)
            {
                Logger.Warn("发送短信提醒失败："+ex.Message,ex);
            }
        }
        /// <summary>
        /// 根据招标项目编号、备案类型查询某项目指定备案类型的备案列表数据
        /// </summary>
        /// <param name="TENDER_PROJECT_CODE">招标项目编号</param>
        /// <param name="search"></param>
        /// <param name="review_type">备案类型，为空则查询所有类型</param>
        /// <returns></returns>
        public PageTableResult List(string TENDER_PROJECT_CODE, SearchCondition search, string review_type = "")
        {
            var condition = new WhereClipBuilder();
            condition.And(RECORD_REVIEW._.TENDER_PROJECT_CODE == TENDER_PROJECT_CODE);
            if (JdUser.ROLEIDS_TEXT.Contains("注册用户"))
            {
                condition.And(RECORD_REVIEW._.CREATOR == JdUser?.ID);
            }
            if (!String.IsNullOrWhiteSpace(review_type))
            {
                condition.And(RECORD_REVIEW._.REVIEW_TYPE == review_type);
            }
            var query = FromWhere(condition.ToWhereClip());
            var count = query.Count();
            //SYS_DIC._.TYPE == "3032" 非住建-备案状态 3032：住建备案状态
            //SYS_DIC._.TYPE == "3028" 非住建-备案状态
            var datas = query
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "3021" && SYS_DIC._.VALUE == RECORD_REVIEW._.REVIEW_TYPE)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "3032" && new WhereClip("INSTR(SYS_DIC.VALUE,REVIEW_STATUS)>0"))
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "3028" && new WhereClip("INSTR(SYS_DIC.VALUE,REVIEW_STATUS)>0"))
                .OrderBy(RECORD_REVIEW._.CREATE_TM.Desc)
                .Page(search.PageSize, search.PageNo)
                .Select(
                    RECORD_REVIEW._.ID,
                    RECORD_REVIEW._.REVIEW_CODE,
                    RECORD_REVIEW._.REVIEW_TYPE,
                    SYS_DIC._.TEXT.As("REVIEW_TYPE_TEXT"),
                    RECORD_REVIEW._.COMMIT_TIME,
                    RECORD_REVIEW._.CREATE_TM,
                    new Field("NVL(RECORD_REVIEW.IS_SUBMIT_AGAIN, 0)").As("IS_SUBMIT_AGAIN"),
                    RECORD_REVIEW._.REVIEW_STATUS,
                    new Field("CASE  WHEN INSTR(REVIEW_TYPE,'MT')>0 OR INSTR(REVIEW_TYPE,'MZ')>0 THEN SYS_DIC2.TEXT ELSE SYS_DIC3.TEXT END").As("REVIEW_STATUS_TEXT"),
                    RECORD_REVIEW._.SIGN_COMMENT,
                    RECORD_REVIEW._.REVIEW_COMMENT,
                    RECORD_REVIEW._.AMENDMENT_OPINION,
                    RECORD_REVIEW._.CREATOR,
                    new Field("NVL(RECORD_REVIEW.IS_SIGN, 0)").As("IS_SIGN")
                ).ToList<dynamic>();
            var pageList = datas.Select(t => new
            {
                ID = t.ID,
                REVIEW_CODE = t.REVIEW_CODE,
                REVIEW_TYPE = t.REVIEW_TYPE,
                REVIEW_TYPE_TEXT = t.REVIEW_TYPE_TEXT,
                COMMIT_TIME = t.COMMIT_TIME,
                CREATE_TM = t.CREATE_TM,
                IS_SUBMIT_AGAIN = t.IS_SUBMIT_AGAIN,
                REVIEW_STATUS = t.REVIEW_STATUS,
                REVIEW_STATUS_TEXT = t.REVIEW_STATUS_TEXT,// t.REVIEW_TYPE.StartWith("MZ") || t.REVIEW_TYPE.StartWith("MT")?t.REVIEW_STATUS_TEXT: t.REVIEW_STATUS_TEXT_COMMON,
                PROCESS_STATUS = GET_PROCESS_STATUS(Convert.ToInt32(t.REVIEW_STATUS)),
                SIGN_COMMENT = t.SIGN_COMMENT,
                REVIEW_COMMENT = t.REVIEW_COMMENT,
                AMENDMENT_OPINION = t.AMENDMENT_OPINION,
                IS_SIGN = (t.REVIEW_TYPE.ToString().EndsWith("103") || t.REVIEW_TYPE.ToString().EndsWith("105")) ? null:t.IS_SIGN,
                BUTTONS = GetButtons(new RECORD_REVIEW() { REVIEW_TYPE = t.REVIEW_TYPE,
                    IS_SIGN = t.IS_SIGN,
                    REVIEW_STATUS = t.REVIEW_STATUS, CREATOR = t.CREATOR })
            }).ToPageTableResult(search, count);
            return pageList;
        }

        /// <summary>
        /// 根据招标项目编号、备案类型查询某项目指定备案类型的备案列表数据
        /// </summary>
        /// <param name="TENDER_PROJECT_CODE">招标项目编号</param>
        /// <param name="search"></param>
        /// <param name="review_type">备案类型，为空则查询所有类型</param>
        /// <returns></returns>
        public PageTableResult List_ZJ(string TENDER_PROJECT_CODE, SearchCondition search, string review_type = "")
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(SELECT T1.*");
            sb.AppendLine("  FROM (SELECT NVL(REVIEW_INSTANCE.IS_END, 0) AS IS_END,");
            sb.AppendLine("               RECORD_REVIEW.ID,");
            sb.AppendLine("               REVIEW_INSTANCE.ID AS REVIEW_INSTANCE_ID,");
            sb.AppendLine("               RECORD_REVIEW.TENDER_PROJECT_CODE,");
            sb.AppendLine("               RECORD_REVIEW.REVIEW_CODE,");
            sb.AppendLine("               RECORD_REVIEW.REVIEW_TYPE,");
            sb.AppendLine("               NVL(REVIEW_NODE.NODE_NAME,'接收') AS NODE_NAME,");
            sb.AppendLine("               SYS_DIC.TEXT AS REVIEW_TYPE_TEXT,");
            sb.AppendLine("               RECORD_REVIEW.COMMIT_TIME,");
            sb.AppendLine("               RECORD_REVIEW.CREATE_TM,");
            sb.AppendLine("               NVL(RECORD_REVIEW.IS_SUBMIT_AGAIN, 0) AS IS_SUBMIT_AGAIN,");
            sb.AppendLine("               RECORD_REVIEW.REVIEW_STATUS,");
            sb.AppendLine("               RECORD_REVIEW.SIGN_COMMENT,");
            sb.AppendLine("               RECORD_REVIEW.REVIEW_COMMENT,");
            sb.AppendLine("               RECORD_REVIEW.AMENDMENT_OPINION,");
            sb.AppendLine("               RECORD_REVIEW.CREATOR,");
            sb.AppendLine("               NVL(RECORD_REVIEW.IS_SIGN, 0) AS IS_SIGN,");
            sb.AppendLine("               ROW_NUMBER() OVER(PARTITION BY RECORD_REVIEW.ID ORDER BY NVL(REVIEW_INSTANCE.ID,0) DESC) RNN");
            sb.AppendLine("          FROM RECORD_REVIEW");
            sb.AppendLine("          LEFT OUTER JOIN REVIEW_INSTANCE");
            sb.AppendLine("            ON (REVIEW_INSTANCE.BA_ID = RECORD_REVIEW.ID)");
            sb.AppendLine("          LEFT OUTER JOIN REVIEW_NODE");
            sb.AppendLine("            ON ((REVIEW_INSTANCE.MAIN_ID = REVIEW_NODE.MAIN_ID) AND");
            sb.AppendLine("               (REVIEW_INSTANCE.NOW_NODE = REVIEW_NODE.ID))");
            sb.AppendLine("          LEFT OUTER JOIN SYS_DIC");
            sb.AppendLine("            ON ((SYS_DIC.TYPE = '3021') AND");
            sb.AppendLine("               (SYS_DIC.VALUE = RECORD_REVIEW.REVIEW_TYPE))");
            sb.AppendLine("                                                     ) T1");
            sb.AppendLine(" WHERE T1.RNN = 1)TRESULT");
            

            var condition = new WhereClipBuilder();
            
            condition.And(new Field("TENDER_PROJECT_CODE", "TRESULT") == TENDER_PROJECT_CODE);
            if (JdUser.ROLEIDS_TEXT.Contains("注册用户"))
            {
                condition.And(new Field("CREATOR", "TRESULT") == JdUser?.ID);
            }
            if (!String.IsNullOrWhiteSpace(review_type))
            {
                condition.And(new Field("REVIEW_TYPE", "TRESULT") == review_type);
            }

            var query = FromTable(sb.ToString());
            var count = query.Where(condition.ToWhereClip()).Count();

            var datas = query
                .Where(condition.ToWhereClip())
                .OrderBy(new Field("CREATE_TM").Desc)
                .Page(search.PageSize, search.PageNo)
                .Select(
                    new Field("IS_END"),
                    new Field("ID"),
                    new Field("REVIEW_INSTANCE_ID"),
                    new Field("REVIEW_CODE"),
                    new Field("REVIEW_TYPE"),
                    new Field("NODE_NAME"),
                    new Field("REVIEW_TYPE_TEXT"),
                    new Field("COMMIT_TIME"),
                    new Field("CREATE_TM"),
                    new Field("IS_SUBMIT_AGAIN"),
                    new Field("REVIEW_STATUS"),
                    new Field("SIGN_COMMENT"),
                    new Field("REVIEW_COMMENT"),
                    new Field("AMENDMENT_OPINION"),
                    new Field("CREATOR"),
                    new Field("IS_SIGN")
                ).ToList<dynamic>();
            var pageList = datas.Select(t => new
            {
                ID = t.ID,
                REVIEW_CODE = t.REVIEW_CODE,
                REVIEW_TYPE = t.REVIEW_TYPE,
                REVIEW_TYPE_TEXT = t.REVIEW_TYPE_TEXT,
                COMMIT_TIME = t.COMMIT_TIME,
                CREATE_TM = t.CREATE_TM,
                IS_SUBMIT_AGAIN = t.IS_SUBMIT_AGAIN,
                REVIEW_STATUS = t.REVIEW_STATUS,
                REVIEW_STATUS_TEXT = GetReViewStatusText(t.REVIEW_STATUS.ToString(), t.REVIEW_TYPE.ToString(),
                t.NODE_NAME.ToString(), t.IS_END.ToString()),
                PROCESS_STATUS = GET_PROCESS_STATUS(Convert.ToInt32(t.REVIEW_STATUS)),
                SIGN_COMMENT = t.SIGN_COMMENT,
                REVIEW_COMMENT = t.REVIEW_COMMENT,
                AMENDMENT_OPINION = t.AMENDMENT_OPINION,
                IS_SIGN = t.IS_SIGN,
                BUTTONS = GetButtons(new RECORD_REVIEW() { REVIEW_TYPE=t.REVIEW_TYPE,  REVIEW_STATUS = t.REVIEW_STATUS, CREATOR = t.CREATOR },null,t.REVIEW_INSTANCE_ID)
            }).ToPageTableResult(search, count);
            return pageList;
        }
        /// <summary>
        /// 列表、闽政通等用于根据审批状态显示不通颜色
        /// </summary>
        /// <param name="REVIEW_STATUS"></param>
        /// <returns></returns>
        public int GET_PROCESS_STATUS(int REVIEW_STATUS)
        {
            /*
             PROCESS_STATUS 值说明
             0 暂存，未提交，
             1 已提交，流程审批中
             2 审批不通过
             4 审批通过
             */

            switch (REVIEW_STATUS)
            {
                case 0:
                    return 0;
                case 5:
                    return 4;
                case 2:
                case 3:
                case 6:
                    return 2;
                default:
                    return 1;
            }
        }

        /// <summary>
        /// 解析列表中显示的签收审查状态中文描述名称
        /// </summary>
        /// <param name="REVIEW_STATUS">备案状态值</param>
        /// <param name="REVIEW_TYPE">备案类型</param>
        /// <param name="NODE_NAME">节点名称</param>
        /// <param name="IS_END">节点是否已处理</param>
        /// <returns></returns>
        protected string GetReViewStatusText(string REVIEW_STATUS,string REVIEW_TYPE,string NODE_NAME,string IS_END)
        {
            if(JdUser.ROLEIDS_TEXT.Contains("注册用户"))
            {
                if (REVIEW_TYPE.EndsWith("103") && REVIEW_STATUS !="0")
                {
                    return "已备案";
                }
                switch (REVIEW_STATUS)
                {
                    case "0":
                        return "暂存";
                    case "1":
                        return "待签收";
                    case "4":
                        return "未提意见";
                    case "8":
                        return "已签收";
                    case "2":
                    case "3":
                        return "退回";
                    case "6":
                        return "需整改";
                    case "5":
                        return "未发现问题";
                    
                }
            }

            if ("0" == REVIEW_STATUS)
            {
                return "暂存";
            }
            if (REVIEW_TYPE.EndsWith("103"))
            {
                return "已备案";
            }
            if (new List<string> { "2", "3", "6" }.Contains(REVIEW_STATUS))
            {
                return "退回";
            }
            if (IS_END =="1")
            {
                return "已" + NODE_NAME;
            }
            return "待" + NODE_NAME;
        }
        /// <summary>
        /// 无基础数据类型备案的详情接口
        /// </summary>
        /// <param name="record_id"></param>
        /// <returns></returns>
        public GeneralResult Detail(int record_id,Func<string,string> urlBuilder, string review_type="")
        {
            var r = new GeneralResult();
            var conditionInstance = new WhereClipBuilder();
            conditionInstance.And(REVIEW_INSTANCE._.BA_ID == record_id);


            var reviewInstance = Jd.ReviewInstanceService.FindList(conditionInstance, REVIEW_INSTANCE._.ID.Desc).ToList();
            var atts = Jd.RecordReviewService.GetReviewAttachment(record_id, urlBuilder);
            var data = new Dictionary<string,object>();
            data.Add("INSTANCE_END_ID", reviewInstance.Where(w => w.IS_END == 1).FirstOrDefault()?.ID);
            data.Add("INSTANCE_ID", reviewInstance.FirstOrDefault()?.ID);
            data.Add("ATTACHMENTS", atts);
            r.SetSuccess(data);
            return r;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="record_id"></param>
        /// <param name="review_status"></param>
        /// <param name="SIGN_COMMENT"></param>
        /// <param name="is_sign"></param>
        /// <param name="REVIEW_INFO"></param>
        /// <param name="state">操作按钮类型，2,3退回、5审查通过、8签收、6审查不通过、8、签收、9整改意见</param>
        /// <param name="attas"></param>
        /// <returns></returns>
        public GeneralResult Audit(decimal? record_id, string review_status,
            string SIGN_COMMENT, decimal? is_sign, string REVIEW_INFO, int state, List<RECORD_ATTACHMENT> attas,
            Func<string, string> urlBuilder)
        {
            //操作按钮类型，2,3退回、5审查通过、8签收、6审查不通过、9整改意见

            GeneralResult r = new GeneralResult();
            var record_review = FirstOrNull(RECORD_REVIEW._.ID == record_id);
            if (null == record_review)
            {
                r.SetFail("记录不存在.未找到 RECORD_REVIEW 信息");
                return r;
            }
            var now = Jd.CommonService.GetDBDateTime();

            var operation = new OPERTION_RECORD();
            operation.RECORD_ID = record_review.ID;
            operation.OPERATION_TIME = now;
            operation.OPERATION_PERSON = JdUser?.ID;
            operation.DEPID = JdUser?.DEPARTID;
            operation.OPERATION_BEHAVIOR = state;
            operation.CREATE_TM = now;
            operation.CREATOR = JdUser?.ID;

            if (new int[] { 2, 3 }.Contains(state)
                && (new string[] { "0,2,3,5,6" }.Contains(record_review.REVIEW_STATUS) || (record_review.IS_SIGN == 1 && record_review.REVIEW_STATUS == "1")))
            {
                r.SetFail("操作失败:重复处理，请刷新重试");
                return r;
            }
            if (new int[] { 5, 6, 8 }.Contains(state)
                && new string[] { "0,2,3,5,6" }.Contains(record_review.REVIEW_STATUS))
            {
                r.SetFail("操作失败:重复处理，请刷新重试");
                return r;
            }

            record_review.Attach();
            //if (String.IsNullOrWhiteSpace(review_status))
            //{
            //    r.SetFail("操作失败:review_status 不能为空");
            //    return r;
            //}

            if (is_sign.HasValue)
            {
                record_review.IS_SIGN = is_sign;
            }

            switch (state)
            {
                case 2:
                case 3://签收退回
                case 8://签收
                    record_review.SIGN_PERSON = JdUser?.ID?.ToString();
                    record_review.SIGN_TIME = now;
                    record_review.SIGN_COMMENT = SIGN_COMMENT;

                    operation.REVIEW_OPINION = SIGN_COMMENT;
                    break;
                case 5:
                case 6:
                    record_review.REVIEW_PERSON = JdUser?.ID?.ToString();
                    record_review.REVIEW_TIME = now;
                    record_review.REVIEW_COMMENT = REVIEW_INFO;

                    //水利未点签收直接审查的话，则系统自动签收
                    if (record_review.IS_SIGN == 0)
                    {
                        record_review.IS_SIGN = 1;
                        record_review.SIGN_PERSON = JdUser?.ID?.ToString();
                        record_review.SIGN_TIME = now.AddMilliseconds(-1);
                        record_review.SIGN_COMMENT = SIGN_COMMENT;
                    }

                    operation.REVIEW_OPINION = REVIEW_INFO;
                    break;
                case 9:
                    record_review.ADJUST_PERSON = JdUser?.ID?.ToString();
                    record_review.ADJUST_TIME = now;
                    record_review.AMENDMENT_OPINION = REVIEW_INFO;

                    operation.REVIEW_OPINION = REVIEW_INFO;
                    break;
            }
            // 9为审查意见修改，不变更备案状态
            if (!String.IsNullOrWhiteSpace(review_status) && review_status !="9")
            {
                record_review.REVIEW_STATUS = review_status;
            }

            var db = GetDbSession();
            using (var tran = db.BeginTransaction())
            {
                try
                {
                    tran.Update<RECORD_REVIEW>(record_review);


                    string sql = "UPDATE RECORD_ATTACHMENT SET IS_INTACT=:IS_INTACT,IS_READ_ONLY=:IS_READ_ONLY WHERE ATTFILE_TYPECODE = :ATTFILE_TYPECODE And RECORD_ID= :RECORD_ID";
                    foreach (var attr in attas)
                    {
                        tran.FromSql(sql)
                            .AddInParameter(":IS_INTACT", DbType.String, attr.IS_INTACT)
                            .AddInParameter(":IS_READ_ONLY", DbType.String, attr.IS_INTACT)
                            .AddInParameter(":ATTFILE_TYPECODE", DbType.String, attr.ATTFILE_TYPECODE)
                            .AddInParameter(":RECORD_ID", DbType.String, record_id)
                            .ExecuteNonQuery();
                    }

                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    var requestid = Guid.NewGuid().ToString();
                    LoggerR.Error("logid:" + requestid + ",备案签收/审批失败:" + ex.Message
                        + Logger.GetRequestMessage(HttpContext.Current), ex);
                    r.SetException("备案签收/审批失败:" + ex.Message + "logid:" + requestid, ex);
                    return r;
                }
            }

            try
            {
                Hashtable Ht = new Hashtable();
                var guidStr = Guid.NewGuid().ToString("N");
                if (record_review.REVIEW_TYPE.StartsWith("MT") || record_review.REVIEW_TYPE.StartsWith("MZ"))
                {
                    if ((new List<int> { 2, 3, 5, 6, 8,9 }).Contains(state))
                    {
                        var Create = BuildFactory.ZJ_CreateRep(state.ToString(), record_review.REVIEW_TYPE, (int)record_id, now.ToString("yyyyMMddHHmmssss"));
                        Ht = Create.ReplaceWord(guidStr);
                    }
                }
                else
                {
                    BuildDoc Create =
                    BuildFactory.CreateRep(state.ToString(), record_review.REVIEW_TYPE, (int)record_id);
                    Ht = Create.ReplaceWord(guidStr);
                }
                object data = null;
                if (Ht.Keys.Count > 0)
                {
                    SYS_ATTACHMENT amodel = new SYS_ATTACHMENT();
                    amodel.AID = 0;
                    amodel.GUID = guidStr;
                    amodel.FILETYPE = ".pdf";
                    amodel.FILEPATH = Ht["URL"].ToString();
                    amodel.ORDERID = 0;
                    amodel.FILETILE = Ht["SAVENAME"].ToString();
                    amodel.REMARK = Ht["SAVENAME"].ToString() + ".pdf";
                    amodel.CREATETIME = DateTime.Now;
                    amodel.AID = Jd.SysAttachmentService.Insert<SYS_ATTACHMENT>(amodel);

                    operation.ATTACHMENT_ID = amodel.GUID;

                    Jd.OpertionRecordService.Insert<OPERTION_RECORD>(operation);

                    data = new
                    {
                        FILETILE = Ht["SAVENAME"].ToString() + ".pdf",
                        FILEPATH = urlBuilder?.Invoke(amodel.GUID),
                        full_url = urlBuilder?.Invoke(amodel.GUID),
                        GUID = amodel.GUID
                    };
                }
                //tran.Commit();
                //
                //TODO:发送短信
                //
                r.SetSuccess(data);
                return r;
            }
            catch(Exception ex)
            {
                Logger.Error("生成签收单/整改单失败:" + ex.Message, ex);
                r.SetFail("生成签收单/整改单发生异常");
                return r;
            }
        }

        /// <summary>
        /// 保存签章信息
        /// </summary>
        /// <param name="RECORD_ID">备案记录ID</param>
        /// <param name="GUID">签章附件id</param>
        /// <param name="file_guid">签章前的文件GUID</param>
        /// <returns></returns>
        public GeneralResult SaveSignUp(int RECORD_ID, string guid,string file_guid)
        {
            var r = new GeneralResult();
            if (String.IsNullOrEmpty(guid))
            {
                r.SetFail("签章信息更新失败:签章ID错误");
                return r;
            }

            var attachment = Jd.SysAttachmentService.FirstOrNull(SYS_ATTACHMENT._.GUID == guid);
            if (null == attachment)
            {
                r.SetFail("签章信息更新失败:签章文件不存在");
                return r;
            }
            if ("已签章" != attachment.CONVERTREMARK)
            {
                r.SetFail("签章信息更新失败:非签章文件GUID信息，请核查");
                return r;
            }
            var record = Jd.OpertionRecordService.FirstOrNull(OPERTION_RECORD._.RECORD_ID == RECORD_ID
                && (OPERTION_RECORD._.ATTACHMENT_ID == file_guid || OPERTION_RECORD._.ATTACHMENT_ID == attachment.GUID));
            if (null == record)
            {
                r.SetFail("签章信息更新失败:操作记录不存在或已删除");
                return r;
            }
            if (record.DEPID != JdUser.DEPARTID && !JdUser.UserDepartment.OTHERIDS.Contains(record.DEPID.ToString()))
            {
                r.SetFail("签章信息更新失败:越权失败");
                return r;
            }

            var atta_old = Jd.SysAttachmentService.FirstOrNull(SYS_ATTACHMENT._.GUID == record.ATTACHMENT_ID);
            if(null == atta_old)
            {
                r.SetFail("签章信息更新失败:签章前文件信息不存在");
                return r;
            }
            if ("已签章" == atta_old.CONVERTREMARK)
            {
                r.SetFail("签章信息更新失败:重复签章");
                return r;
            }

            var now = Jd.CommonService.GetDBDateTime();
            record.Attach();
            record.ATTACHMENT_ID = guid;
            record.OPERATION_TIME = now;


            attachment.Attach();
            attachment.FILETYPE = atta_old.FILETYPE;
            attachment.FILETILE = atta_old.FILETILE;
            attachment.CONVERTDATETIME = now;
            attachment.SIGN_INFO1 = atta_old.GUID;

            var db = GetDbSession();
            using (var tran = db.BeginTransaction())
            {
                try
                {
                    tran.Update<OPERTION_RECORD>(record);
                    tran.Update<SYS_ATTACHMENT>(attachment);
                    tran.Commit();

                    r.SetSuccess();
                    return r;
                }
                catch(Exception ex)
                {
                    tran.Rollback();
                    var requestid = Guid.NewGuid().ToString();
                    LoggerR.Error("logid:" + requestid + ",签章信息更新失败:" + ex.Message
                        + Logger.GetRequestMessage(HttpContext.Current), ex);
                    r.SetException("签章信息更新失败:"+ex.Message + ",logid:"+requestid,ex);
                    return r;
                }
            } 
           
        }

        /// <summary>
        /// 详情页面 状态栏
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Dictionary<string, string>> GetStates(RECORD_REVIEW review)
        {
            List<Dictionary<string, string>> dynamics = new List<Dictionary<string, string>>();
            if (!review.REVIEW_TYPE.StartsWith("MZ") && !review.REVIEW_TYPE.StartsWith("MT"))
            {
                //只有招标文件备案 才有签收 审查完整流程，其余只有一个步骤的，则不显示 顶部状态
                if(! review.REVIEW_TYPE.EndsWith("101"))
                {
                    return dynamics;
                }

                dynamics.Add(new Dictionary<string, string>()
                {
                    {"TYPE","SIGN_STATUS" },
                    {"DESCRIPTION",  "签收状态" },
                    {"TEXT", review.IS_SIGN == 1 ? "已签收" : "待签收" },
                    {"VALUE",review.IS_SIGN.HasValue ? review.IS_SIGN.Value.ToString() : "0" }
                });

                dynamics.Add(new Dictionary<string, string>()
                {
                    {"TYPE","AUDIT_STATUS" },
                    {"DESCRIPTION",  "审查状态" },
                    {"TEXT", review.REVIEW_STATUS =="1"?"待审查":(review.REVIEW_STATUS =="5"?"审查，已通过":"审查，未通过")},
                    {"VALUE", review.REVIEW_STATUS.ToString()  =="1" ?"0":"1"}
                });
                return dynamics;
            }

            //澄清修改备案  不需要显示状态
            if(review.REVIEW_TYPE.EndsWith("103"))
            {
                return dynamics;
            }
            //三级审查节点
            Dictionary<string, string> flow3 = new Dictionary<string, string>() {
                {"接收","RECEIVE_STATUS"},
                {"初审","AUDIT_FIRST_STATUS"},
                {"复审","AUDIT_SENCOND_STATUS"},
                {"签发","ISSUE_STATUS"},
                {"发出意见书","SUBMISSION_STATUS"},
            };

            var entities = FromWhere<REVIEW_INSTANCE>()
                .InnerJoin<REVIEW_NODE>(REVIEW_INSTANCE._.NOW_NODE == REVIEW_NODE._.ID)
                .LeftJoin<REVIEW_LOG>(REVIEW_INSTANCE._.ID == REVIEW_LOG._.SL_ID)
                .Where(REVIEW_INSTANCE._.BA_ID == review.ID)
                .OrderBy(REVIEW_LOG._.ID)
                .Select(
                    REVIEW_INSTANCE._.ID,
                    REVIEW_INSTANCE._.MAIN_ID,
                    REVIEW_NODE._.NODE_NAME,
                    REVIEW_LOG._.OPERNAME,
                    REVIEW_INSTANCE._.IS_END
                ).ToList<dynamic>();

            //已接收
            if(entities.Where(w=>w.NODE_NAME == "初审" && w.MAIN_ID !=1).Any())
            {
                var main_id = entities.Where(w => w.NODE_NAME == "初审" && w.MAIN_ID != 1).FirstOrDefault().MAIN_ID;
                var node_second = Jd.ReviewNodeService.FirstOrNull(REVIEW_NODE._.MAIN_ID == main_id && REVIEW_NODE._.NODE_NAME == "复审");
                if(null == node_second)
                {
                    flow3.Remove("复审");
                }
            }
            else
            {
                flow3.Remove("复审");
            }
             
            foreach (var node in flow3)
            {
                var flows = entities.Where(w => w.NODE_NAME == node.Key).ToList();
                if (!flows.Any())
                {
                    dynamics.Add(new Dictionary<string, string>()
                    {
                        { "TYPE",node.Value},
                        { "DESCRIPTION",  String.Concat(node.Key, "状态") },
                        { "TEXT", String.Concat("未", node.Key) },
                        { "VALUE","-1"}
                    });
                    continue;
                }

                foreach (var f in flows)
                {
                    if (!dynamics.Where(w => w["TYPE"] == node.Value).Any())
                    {
                        dynamics.Add(new Dictionary<string, string>(){
                        { "TYPE",node.Value},
                        { "DESCRIPTION",  String.Concat(node.Key, "状态") },
                        { "TEXT", GetStateText(f) },
                        { "VALUE",f.IS_END == 0?"0":
                            (null != f.OPERNAME && (f?.OPERNAME?.ToString()?.Contains("退回") || f?.OPERNAME?.ToString()?.Contains("退还"))?"2":"1")}
                    });
                        continue;
                    }
                    var dynamicData = dynamics.Where(w => w["TYPE"] == node.Value).FirstOrDefault();
                    dynamicData["TEXT"] = GetStateText(f);
                    dynamicData["VALUE"] = f.IS_END == 0 ? "0" :
                            (null != f.OPERNAME && (f?.OPERNAME?.ToString()?.Contains("退回") || f?.OPERNAME?.ToString()?.Contains("退还")) ? "2" : "1");
                    continue;
                }
            }

            return dynamics;
        }
        /// <summary>
        /// 获取备案详情页流程进度条显示文字信息
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private string GetStateText(dynamic data)
        {
            if (data.IS_END == 0)
            {
                return String.Concat("待",data.NODE_NAME);
            }

            if (data.NODE_NAME =="接收")
            {
                if (data.OPERNAME.ToString().Contains("退回") || data.OPERNAME.ToString().Contains("退还"))
                {
                    return String.Concat(data.NODE_NAME, ",被退回");
                }
                return String.Concat("已接收");
            }
            if (data.NODE_NAME == "发出意见书")
            {
                if (data.OPERNAME.ToString().Contains("退回") || data.OPERNAME.ToString().Contains("退还"))
                {
                    return String.Concat(data.NODE_NAME, ",未通过");
                }
                return String.Concat("已", data.NODE_NAME);
            }

            if (null != data.OPERNAME && (data.OPERNAME.ToString().Contains("退回") || data.OPERNAME.ToString().Contains("退还")))
            {
                return String.Concat(data.NODE_NAME,",未通过");
            }
           
            return String.Concat(data.NODE_NAME, ",已通过");
        }
        /// <summary>
        /// 获取备案流程可操作按钮
        /// </summary>
        /// <param name="review"></param>
        /// <returns></returns>
        public List<string> GetButtons(RECORD_REVIEW review,Dictionary<string,object> flow=null,decimal? REVIEW_INSTANCE_ID = null)
        {
            List<Enum> buttons = new List<Enum>();
            //签收退回或需整改状态下 以及暂存状态，则可以编辑以及提交备案
            var enableEdit = new string[] { "0", "2", "3", "6" };
            buttons.Add(EnumReviewButton.HISTORY);
            buttons.Add(EnumReviewButton.VIEW);
            if (null == JdUser || null == JdUser.ROLEIDS_TEXT)
            {
                return buttons.GetName();
            }
            if (JdUser.ROLEIDS_TEXT.Contains("注册用户"))
            {
                if (enableEdit.Contains(review.REVIEW_STATUS) && review.CREATOR == JdUser.ID)
                {
                    if (new List<string> { "0", "2", "3", "6" }.Contains((review.REVIEW_STATUS)))
                    {
                        buttons.Add(EnumReviewButton.DELETE);
                        buttons.Add(EnumReviewButton.SAVE);
                    }
                    buttons.Add(EnumReviewButton.SUBMIT);
                }
                //水利，招标文件备案，审查之前可以无限提交备案
                if(!buttons.Contains(EnumReviewButton.SUBMIT) &&
                    review.REVIEW_STATUS =="1" && (review.REVIEW_TYPE.Contains("101")
                    || review.REVIEW_TYPE.Contains("104"))&&
                    (! review.REVIEW_TYPE.StartsWith("MZ") && !review.REVIEW_TYPE.StartsWith("MT")))
                {
                    buttons.Add(EnumReviewButton.SUBMIT);
                }
                //未签收，且 REVIEW_STATUS 为 1或者 4，且有流程的未开始正式走流程签收，则可以撤回
                var enableCancel = new string[] { "1", "4"};
                if (enableCancel.Contains(review.REVIEW_STATUS) && review.CREATOR == JdUser.ID
                    && review.IS_SIGN.Value !=1 && ! REVIEW_INSTANCE_ID.HasValue)
                {
                    //提交与撤回按钮互斥
                    if(buttons.Contains(EnumReviewButton.SUBMIT))
                    {
                        buttons.Remove(EnumReviewButton.SUBMIT);
                    }
                    buttons.Add(EnumReviewButton.CANCEL);
                }
               
                //列表中 增加  招标文件详情
                if ((review.REVIEW_TYPE =="MZ101" || review.REVIEW_TYPE =="MT101") && review.REVIEW_STATUS =="8")
                {
                    buttons.Add(EnumZJReviewButton.TENDER_FILE_SAVE);
                    buttons.Add(EnumReviewButton.SUBMIT);
                }
                //需整改状态 则列表中显示 重新备案 按钮
                if(new List<string> {"2", "3", "6" }.Contains(review.REVIEW_STATUS))
                {
                    buttons.Add(EnumReviewButton.SUBMIT_AGAIN);
                }
                return buttons.GetName();
            }

            var tenderproject = Jd.TenderProjectService.FirstOrNull(TENDER_PROJECT._.TENDER_PROJECT_CODE == review.TENDER_PROJECT_CODE);
            if (null == tenderproject)
            {
                return buttons.GetName();
            }
            if (String.IsNullOrWhiteSpace(tenderproject.RECORD_DEPID))
            {
                return buttons.GetName();
            }

            

            var rtype = tenderproject.RTYPE;
            var reviewTypeNo = review.REVIEW_TYPE.Replace(rtype, "");
            var status = Convert.ToInt32(review.REVIEW_STATUS);
            var t_record_id = Convert.ToDecimal(tenderproject.RECORD_DEPID);
            if (t_record_id != JdUser.DEPARTID
                && (null == JdUser.UserDepartment.OTHERIDS
                || !JdUser.UserDepartment.OTHERIDS.Contains(tenderproject.RECORD_DEPID)))
            {
                return buttons.GetName();
            }

            buttons.Add(EnumReviewButton.SIGNUP);

            if (! "MT".Equals(rtype) && !"MZ".Equals(rtype))
            {
                if (status == (int)EnumOperation.提交
                    && !(new List<string>() { "102", "103", "105" }).Contains(reviewTypeNo))
                {
                    if (review.IS_SIGN != 1)
                    {
                        buttons.Add(EnumReviewButton.RECEIVE_COMMON);
                        buttons.Add(EnumReviewButton.FALLBACK);
                    }
                }
                //if (status == (int)EnumOperation.提交 && review.IS_SIGN == 1 && reviewTypeNo == "101")
                //{
                //    buttons.Add(EnumReviewButton.SUBMIT_AUDIT);
                //    //buttons.Add(EnumReviewButton.FALLBACK);
                //}
                //澄清修改 提交后直接审查，
                //其他材料签收后直接可审查
                //合同备案、异议处理 则不用审查
                if ((status == (int)EnumOperation.提交 && reviewTypeNo == "101" && review.IS_SIGN ==1)
                    || (status == (int)EnumOperation.提交 && reviewTypeNo == "102"))
                {
                    buttons.Add(EnumReviewButton.SUBMIT_AUDIT);
                }

                if (status == (int)EnumOperation.未发现问题 || status == (int)EnumOperation.需整改)
                {
                    buttons.Add(EnumReviewButton.SAVE_REMARK);
                }
                return buttons.GetName();
            }


            if(status ==6 && REVIEW_INSTANCE_ID.HasValue)
            {
                var instance = Jd.ReviewInstanceService.FirstOrNull(REVIEW_INSTANCE._.ID == REVIEW_INSTANCE_ID.Value);
                if (null != instance && instance.STAFF.Split(new char[] { ',', '|'}).Contains(JdUser.ID.ToString()))
                {
                    buttons.Add(EnumZJReviewButton.SAVE_FLOW_REMARK);
                }
            }

            if(flow !=null && flow.ContainsKey("CURRENT_NODE"))
            {
                var node_name = ((dynamic)flow["CURRENT_NODE"]).NODE_NAME;
                var node_leader = ((dynamic)flow["CURRENT_NODE"]).NODE_LEADER;
                var is_multi = ((dynamic)flow["CURRENT_NODE"]).IS_MULTI;
                switch (node_name)
                {
                    case "接收":
                        buttons.Add(EnumZJReviewButton.RECEIVE);
                        break;
                    case "初审":
                        if(is_multi ==1 && ! String.IsNullOrWhiteSpace(node_leader) && node_leader !=JdUser?.ID?.ToString())
                        {
                            buttons.Add(EnumZJReviewButton.AUDIT_FIRST_COMMON);
                            break;
                        }
                        buttons.Add(EnumZJReviewButton.AUDIT_FIRST);
                        break;
                    case "复审":
                        buttons.Add(EnumZJReviewButton.AUDIT_SENCOND);
                        break;
                    case "签发":
                        buttons.Add(EnumZJReviewButton.ISSUE);
                        break;
                    case "发出意见书":
                        if(review.IS_SIGN !=1 && (new List<string> { "101", "104" }).Contains(review.REVIEW_TYPE.Substring(2,3)) && review.REVIEW_STATUS !="4")
                        {
                            //招标条件备案
                            buttons.Add(EnumZJReviewButton.SUBMISSION_TENDER_CONDITION);
                            break;
                        }
                        buttons.Add(EnumZJReviewButton.SUBMISSION);
                        break;
                }
            }
            //审批单位
            return buttons.GetName();
        }

        /// <summary>
        /// 根据备案ID获取相关附件
        /// </summary>
        /// <returns></returns>
        public IEnumerable<dynamic> GetReviewAttachment(int record_id, Func<string, string> urlBuilder, string bid_section_code = "")
        {

            StringBuilder sbAttachmentsSql = new StringBuilder(record_id);
            sbAttachmentsSql.AppendLine("SELECT T.ATTFILE_TYPECODE,d.text as ATTFILE_TYPENAME,att.guid as id,t.description,NVL(t.CATEGORY,'') AS CATEGORY,");
            sbAttachmentsSql.AppendLine(" nvl(T.BID_SECTION_CODE,'') as BID_SECTION_CODE,att.filetile as name,att.filepath as url,att.md5,att.AOBJTYPE,att.AID");
            sbAttachmentsSql.AppendLine(" FROM RECORD_ATTACHMENT T ");
            sbAttachmentsSql.AppendLine(" LEFT JOIN SYS_DIC d ON  d.type='3024' and d.value =t.ATTFILE_TYPECODE");
            sbAttachmentsSql.AppendLine(" left join sys_attachment att on att.guid is not null and NVL(instr(',' || t.guids || ',',',' || att.guid || ','),0) != 0");
            sbAttachmentsSql.AppendLine(" where T.Record_Id=" + record_id);
            if (!String.IsNullOrWhiteSpace(bid_section_code))
            {
                sbAttachmentsSql.AppendLine(" And BID_SECTION_CODE='" + bid_section_code + "'");
            }
            sbAttachmentsSql.AppendLine(" Order by att.aid ");

            var attachments = FromSql(sbAttachmentsSql.ToString()).ToList<UploadResData_Review>();

            var atts = attachments.GroupBy(g => new { g.ATTFILE_TYPECODE, g.ATTFILE_TYPENAME, g.BID_SECTION_CODE, g.DESCRIPTION,g.IS_INTACT,g.CATEGORY })
                .OrderBy(od=>od.Key.ATTFILE_TYPECODE.Replace("MZ104_F08", "MZ104_F091")
                .Replace("MT104_F08", "MT104_F091")) //旧系统配置顺序的坑，招投标书面情况报告顺序处理
                .Select(t => new
                {
                    TYPE = t.Key.ATTFILE_TYPECODE,
                    TITLE = t.Key.ATTFILE_TYPENAME,
                    DESCRIPTION = t.Key.DESCRIPTION,
                    BID_SECTION_CODE = t.Key.BID_SECTION_CODE,
                    IS_INTACT = t.Where(w => w.AID != 0).Any()?1:0,
                    CATEGORY = t.Key.CATEGORY,
                    ATTACHMENTS = t.Where(w => w.AID != 0).OrderBy(od => od.AID).Select(x => new
                    {
                        full_url = urlBuilder?.Invoke(x.Id),
                        url = x.Url,
                        id = x.Id,
                        name = x.Name,
                        md5 = x.Md5
                    })
                }).ToList();
            return atts;
        }
        /// <summary>
        /// 根据招标项目编号获取备案列表
        /// </summary>
        /// <param name="tenderProjectCdoe"></param>
        /// <returns></returns>
        public GeneralResult GetRecordListByCode(string tenderProjectCdoe)
        {
            var r = new GeneralResult();
            var list = FromWhere<RECORD_REVIEW>(RECORD_REVIEW._.TENDER_PROJECT_CODE == tenderProjectCdoe && RECORD_REVIEW._.REVIEW_STATUS != "0")
                .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == RECORD_REVIEW._.TENDER_PROJECT_CODE)
                .LeftJoin<SYS_DIC>(SYS_DIC._.VALUE == RECORD_REVIEW._.REVIEW_TYPE && SYS_DIC._.TYPE == "3021")
                .LeftJoin<SYS_DIC>(SYS_DIC._.VALUE == RECORD_REVIEW._.REVIEW_STATUS && SYS_DIC._.TYPE == "3028")
                .LeftJoin<SYS_DIC>(SYS_DIC._.VALUE == RECORD_REVIEW._.REVIEW_STATUS && SYS_DIC._.TYPE == "3032")
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == TENDER_PROJECT._.RECORD_DEPID)
                .Select(
                    RECORD_REVIEW._.ID,
                    RECORD_REVIEW._.REVIEW_CODE,
                    RECORD_REVIEW._.COMMIT_TIME,
                    RECORD_REVIEW._.REVIEW_STATUS,
                    RECORD_REVIEW._.REVIEW_TIME,
                    RECORD_REVIEW._.IS_SIGN,
                    RECORD_REVIEW._.REVIEW_TYPE,
                    TENDER_PROJECT._.RECORD_DEPID,
                    TENDER_PROJECT._.RTYPE,
                    SYS_DIC._.TEXT.As("REVIEW_TYPE_TEXT"),
                    new Field("TEXT", "SYS_DIC2").As("REVIEW_STATUS_TEXT_SL"),
                    new Field("TEXT", "SYS_DIC3").As("REVIEW_STATUS_TEXT_ZJ"),
                    T_USER_DEPARTMENT._.DNAME.As("RECORD_DEP_TEXT")).ToDataTable().ToDictionary();
            var result = list.Select(e => new
            {
                ID = e.GetStringValue("ID"),
                REVIEW_CODE = e.GetStringValue("REVIEW_CODE"),
                REVIEW_TYPE_TEXT = e.GetStringValue("REVIEW_TYPE_TEXT"),
                REVIEW_TYPE = e.GetStringValue("REVIEW_TYPE"),
                COMMIT_TIME = e.GetStringValue("COMMIT_TIME"),
                RECORD_DEPID = e.GetStringValue("RECORD_DEPID"),
                RECORD_DEP_TEXT = e.GetStringValue("RECORD_DEP_TEXT"),
                REVIEW_TIME = e.GetStringValue("REVIEW_TIME"),
                REVIEW_STATUS = e.GetStringValue("REVIEW_STATUS"),
                REVIEW_STATUS_TEXT = "MZ,MT".Contains(e.GetStringValue("RTYPE"))
                    ? e.GetStringValue("REVIEW_STATUS_TEXT_ZJ")
                    : e.GetStringValue("REVIEW_STATUS_TEXT_SL"), //区分住建和其他的状态
                IS_SIGN = e.GetStringValue("IS_SIGN") == "1" ? "是" : "否",

            });
            r.SetSuccess(result);
            return r;
        }

        #region 行政监督交易资料-过程资料-页签个数

        public GeneralResult GetProcessDataCount(string tenderProjectCode, string tenderProjcetCodeOld)
        {
            var r = new GeneralResult();
            var count1 = FromSql($@"select 'ZBJH' TYPE,count(1) count from t_afc_project a
left join project b on a.code = b.construction_id
left join tender_project c on b.project_code = c.project_code
where c.tender_project_code = '{tenderProjectCode}'
union all 
select 'ZBBA' TYPE,COUNT(1) count FROM RECORD_REVIEW 
WHERE REVIEW_STATUS <> 0 AND Tender_project_code = '{tenderProjectCode}'").ToDataTable();
            var count2 = DbContext.Fw.FromSql(
                $@"select 'XMRC' TYPE,COUNT(1) count from tender_project where tender_project_code = '{tenderProjcetCodeOld}'
UNION ALL 
select 'ZBGG' TYPE,COUNT(1) count from TENDER_ANN_QUA_INQUERY_ANN where tender_project_code = '{tenderProjcetCodeOld}' AND NOTICE_NATURE IN ('1', '2') and BULLETIN_TYPE='1' and m_status = '2'
UNION ALL 
select 'TBBM' TYPE,COUNT(1) count from TENDER_LIST where tender_project_code = '{tenderProjcetCodeOld}' 
UNION ALL 
select 'KB' TYPE,COUNT(1) count from BID_OPENING_RECORD where tender_project_code = '{tenderProjcetCodeOld}'
UNION ALL 
select 'PB' TYPE,COUNT(1) count from EVALUATION_REPORT where tender_project_code = '{tenderProjcetCodeOld}'
UNION ALL 
select 'JGGG' TYPE,COUNT(1) count from WIN_RESULT_ANNO where tender_project_code = '{tenderProjcetCodeOld}' AND BULLETIN_TYPE ='3' and m_status = '2'").ToDataTable();
            count1.Merge(count2);
            r.SetSuccess(count1);
            return r;
        }


        #endregion

        /// <summary>
        /// 根据备案记录信息查询审核流程基本信息
        /// </summary>
        /// <param name="review"></param>
        /// <returns></returns>
        public Dictionary<string, object> GetFlow(RECORD_REVIEW review)
        {
            
            var dic = new Dictionary<string, object>();

            if(null == JdUser || String.IsNullOrWhiteSpace(JdUser.ROLEIDS_TEXT))
            {
                return dic;
            }

            if (JdUser.ROLEIDS_TEXT.Contains("注册用户"))
            {
                return dic;
            }

            if ("MZ"!=review.REVIEW_TYPE.Substring(0,2) && "MT" != review.REVIEW_TYPE.Substring(0, 2))
            {
                return dic;
            }
            var instance = Jd.ReviewInstanceService
               .FindList(REVIEW_INSTANCE._.BA_ID == review.ID && REVIEW_INSTANCE._.IS_END == 0,
               REVIEW_INSTANCE._.ID.Desc).FirstOrDefault();
            if(null == instance)
            {
                return dic;
            }
        
            var current_node = Jd.ReviewNodeService.FirstOrNull(REVIEW_NODE._.ID == instance.NOW_NODE);
            var dept_id = FromWhere<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == instance.TENDER_PROJECT_CODE)
                .Select(TENDER_PROJECT._.RECORD_DEPID).ToScalar<int>();
            var current_flowusers = instance.NOW_USERS?.Split(',').Distinct().ToList();
            var current_flowusers_leader = instance.QTR;
            if (current_flowusers==null||!current_flowusers.Where(w=>w==JdUser?.ID?.ToString()).Any())
            {
                return dic;
            }
            
            var next_node = Jd.ReviewNodeService.FirstOrNull(REVIEW_NODE._.PREV_NODE == instance.NOW_NODE);
            var review_main = Jd.ReviewMainService.FirstOrNull(REVIEW_MAIN._.ID == current_node.MAIN_ID);
            var oplog = GetOperLog(review.ID.Value);
            //string return_type = "";
            var review_mains = new List<REVIEW_MAIN>();
            if (next_node == null && review_main != null && review_main.SC_TYPE.Value > 10)
            { //11 21类型为接收流程，接收流程默认 接收完之后去指定下个流程
                //return_type = "审查机制";
                review_mains = Jd.ReviewMainService.FindList(REVIEW_MAIN._.IS_ENABLE == 1 &&
                    REVIEW_MAIN._.SC_TYPE == review_main.SC_TYPE.ToString().Substring(0, 1));
            }
            else
            {
                review_mains.Add(review_main);
            }

            var IS_FINISH = true;
            var IS_FINISH_REMARK = "";
            //非牵头人未全部提意见，则给与提示
            if(current_flowusers.Count() >1)
            {
                var otherusers = current_flowusers.Remove(JdUser?.ID.ToString());
                var users = Jd.TUserService.FindList(T_USER._.ID.In(current_flowusers));
                if(users.Count() >0)
                {
                    IS_FINISH = false;
                    IS_FINISH_REMARK = $"{current_node.NODE_NAME}【{String.Join("，",users.Select(t=>t.MANAGE_NAME))}】 未审核";
                }
            }

            var ATTRIBUTES = new List<string>();
            try
            {
                Regex reg = new Regex(@"onChangeFunc\s*:\s*\w+,");
                current_node.ATTRIBUTES = reg.Replace(current_node.ATTRIBUTES, "");
                var config =JsonConvert.DeserializeObject<AUDIT_OPTIONS>(current_node.ATTRIBUTES);
                var controls =config.config.Where(w => w.ContainsKey("control") && w["control"].ToString() == "CheckBox")
                    .FirstOrDefault();
                if(null != controls && controls.ContainsKey("options"))
                {
                    var options = JsonConvert.DeserializeObject<Dictionary<string, object>>(controls["options"]?.ToString());
                    var option_data = JsonConvert.DeserializeObject<List< AUDIT_OPTION_TEXTVALUE>>(options["initData"].ToString());
                    ATTRIBUTES = option_data.Select(t => t.TEXT).ToList();
                }
                
            }
#pragma warning disable CS0168 // 声明了变量“ex”，但从未使用过
            catch(Exception ex)
#pragma warning restore CS0168 // 声明了变量“ex”，但从未使用过
            {
                //ATTRIBUTES = current_node.ATTRIBUTES.Replace("\t","").Replace("\n","");
            }
            dic.Add("FLOW_MAIN", review_mains.OrderBy(od => od.ORDERID).Select(t => new {
                FLOW_NAME = t.NAME,
                FLOW_ID = t.ID,
            }));
            dic.Add("CURRENT_NODE", new
            {
                NODE_ID = current_node.ID,
                NODE_NAME = current_node.NODE_NAME,
                OPTIONS = ATTRIBUTES,
                FLOW_USER = JdUser?.MANAGE_NAME,
                NODE_LEADER = current_flowusers_leader,
                IS_MULTI =1,
                IS_FINISH = IS_FINISH,
                IS_FINISH_REMARK = IS_FINISH_REMARK
            });;
            if(review_mains.Any() && review_mains.Count ==1 && review_main.ID != review_mains.First().ID)
            {
                var next_node_result = GetNextFlow((int)review.ID, (int)review_mains.First().ID);
                if(null != next_node_result && next_node_result.Success)
                {
                    dic.Add("NEXT_NODE", next_node_result.Data);
                }
                dic.Add("OPER_LOG", oplog);
                return dic;
            }

            if (null != next_node)
            {
                var opers = Jd.ReviewOpersService.FirstOrNull(REVIEW_OPERS._.NODE_ID == next_node.ID
                       && REVIEW_OPERS._.TENDER_PROJECT_CODE == review.TENDER_PROJECT_CODE 
                       && REVIEW_OPERS._.BA_ID == review.ID);
                var flowUsers = GetFlowUser(next_node.OPER_USE_NODE.HasValue ? next_node.OPER_USE_NODE : next_node.ID, Convert.ToDecimal(dept_id));
                foreach (var flowuser in flowUsers)
                {
                    if (opers != null && opers.OPERS.Split(',').Contains(flowuser.USER_ID.ToString()))
                    {
                        flowuser.IS_SELECT = 1;
                    }
                }


                dic.Add("NEXT_NODE", new
                {
                    RETURN_TYPE = "审查节点",
                    FLOW_ID = review_main.ID,
                    RECORD_ID = instance.BA_ID,
                    NODE_ID = next_node.ID,
                    NODE_NAME = next_node.NODE_NAME,
                    IS_MULTI = next_node.IS_MULTI,
                    FLOW_USER = flowUsers
                });
            }
            dic.Add("OPER_LOG", oplog);
            return dic;
        }

        /// <summary>
        /// 获取审批流程信息
        /// </summary>
        /// <param name="record_id"></param>
        /// <param name="flow_id">record_main id</param>
        /// <returns></returns>
        public GeneralResult GetNextFlow(int record_id,int flow_id)
        {
            var r = new GeneralResult();
            var dics = new List<Dictionary<string, object>>();
            var instance = Jd.ReviewInstanceService
                .FirstOrNull(REVIEW_INSTANCE._.BA_ID == record_id && REVIEW_INSTANCE._.IS_END == 0);
            var review = Jd.RecordReviewService.FirstOrNull(RECORD_REVIEW._.ID == record_id);
 
            var next_node = Jd.ReviewNodeService.FirstOrNull(REVIEW_NODE._.PREV_NODE == -1 && REVIEW_NODE._.MAIN_ID == flow_id);

            var review_main = Jd.ReviewMainService.FirstOrNull(REVIEW_MAIN._.ID == flow_id);

            var dept_id = FromWhere<TENDER_PROJECT>().Select(TENDER_PROJECT._.RECORD_DEPID).
                Where(TENDER_PROJECT._.TENDER_PROJECT_CODE == review.TENDER_PROJECT_CODE).ToScalar<int>();
            var TENDER_PROJECT_CODE = review.TENDER_PROJECT_CODE;
            string return_type = "审查节点";
            if(next_node !=null)
            {
                var opers = Jd.ReviewOpersService.FirstOrNull(REVIEW_OPERS._.NODE_ID == next_node.ID
                    && REVIEW_OPERS._.TENDER_PROJECT_CODE == review.TENDER_PROJECT_CODE);
                var flowUsers = GetFlowUser(next_node.OPER_USE_NODE.HasValue?next_node.OPER_USE_NODE: next_node.ID, Convert.ToDecimal(dept_id));
                foreach(var flowuser in flowUsers)
                {
                    if(opers!=null && opers.OPERS.Split(',').Contains(flowuser.USER_ID.ToString()))
                    {
                        flowuser.IS_SELECT = 1;
                    }
                }
                r.SetSuccess(new {
                    RETURN_TYPE = return_type,
                    FLOW_ID = review_main.ID,
                    RECORD_ID =record_id,
                    NODE_ID = next_node.ID,
                    NODE_NAME = next_node.NODE_NAME,
                    IS_MULTI = next_node.IS_MULTI,
                    FLOW_USER = flowUsers
                });
                return r;
            }
            r.SetFail("下一步骤为空，流程未处理");
            return r;
        }

        /// <summary>
        /// 流程审批操作
        /// </summary>
        /// <param name="request">客户端提交数据</param>
        /// <returns></returns>
        public GeneralResult SubmitAudit(YW_FLOW_SUBMIT request,REVIEW_LOG review_log)
        {
            var r = new GeneralResult();
            var instance = Jd.ReviewInstanceService.FirstOrNull(REVIEW_INSTANCE._.ID == request.INSTANCE_ID);
            if(null == instance)
            {
                r.SetFail("操作失败：未找到流程记录信息");
                return r;
            }

            string DYLX = request.DYLX;

            if (review_log.OPERNAME.Contains("上一步") || review_log.OPERNAME.Contains("退回"))
            {
                request.DYLX = "100";
            }

            //已办人员信息处理
            List<string> staff = String.IsNullOrEmpty(instance.STAFF) ? new List<string>() 
                : instance.STAFF.Split(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries).ToList();
            staff.Add(JdUser?.ID.ToString());
            instance.STAFF = String.Join(",",staff);

            //当前处理人信息
            List<string> now_users = String.IsNullOrEmpty(instance.NOW_USERS) ? new List<string>()
                 : instance.NOW_USERS.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            if(now_users.Contains(JdUser?.ID.ToString()))
            {
                now_users.Remove(JdUser?.ID.ToString());
            }
            instance.NOW_USERS = String.Join(",", now_users);

            string smsType = "";//下一步
            string stepName = "";
            string operUser = "";

            var now = Jd.CommonService.GetDBDateTime();
            var node = Jd.ReviewNodeService.FirstOrNull(REVIEW_NODE._.ID == instance.NOW_NODE);
            var next_node = Jd.ReviewNodeService.FirstOrNull(REVIEW_NODE._.ID == request.NEXT_NODE_ID);
            var db = GetDbSession();
            using (var tran = db.BeginTransaction())
            {
                try
                {
                    if(null != next_node && (String.IsNullOrEmpty(request.DYLX) || request.DYLX =="101"))
                    {
                        smsType = "NEXT";//下一步
                        stepName = next_node.NODE_NAME;
                        operUser = request.NEXT_NODE_USERID;

                        //下一步骤流程存在
                        var review = Jd.RecordReviewService.FirstOrNull(RECORD_REVIEW._.ID == instance.BA_ID);
                        if(review == null)
                        {
                            tran.Rollback();
                            r.SetFail("备案记录不存在或已删除");
                            return r;
                        }
                        //是否招标文件备案
                        var isTenderFileReview = review.REVIEW_TYPE.Contains("101");

                        instance.IS_END = 1;
                        REVIEW_INSTANCE newinstance = new REVIEW_INSTANCE();
                        newinstance.IS_END = 0;
                        newinstance.BA_ID = instance.BA_ID;
                        newinstance.CREATE_BY = JdUser?.ID;
                        newinstance.CREATE_TM = now;
                        newinstance.MAIN_ID = next_node.MAIN_ID;
                        newinstance.NOW_NODE = request.NEXT_NODE_ID;
                        newinstance.NOW_USERS = request.NEXT_NODE_USERID;
                        newinstance.QTR = request.NEXT_NODE_LEADER;
                        newinstance.TENDER_PROJECT_CODE = instance.TENDER_PROJECT_CODE;
                        newinstance.TIMEOUT = Jd.THolidayService.GetWorkDate(now, next_node.TIMEOUT.HasValue ? (int)next_node.TIMEOUT.Value : 0);
                        tran.Insert<REVIEW_INSTANCE>(newinstance);


                        if (isTenderFileReview)
                        {
                            tran.Delete<REVIEW_OPERS>(REVIEW_OPERS._.TENDER_PROJECT_CODE == instance.TENDER_PROJECT_CODE
                                    && REVIEW_OPERS._.NODE_ID == request.NEXT_NODE_ID);

                            REVIEW_OPERS opers = new REVIEW_OPERS();
                            opers.BA_ID = instance.BA_ID;
                            opers.NODE_ID = request.NEXT_NODE_ID;
                            opers.TENDER_PROJECT_CODE = instance.TENDER_PROJECT_CODE;
                            opers.OPERS = request.NEXT_NODE_USERID;
                            opers.QTR = request.NEXT_NODE_LEADER;

                            tran.Insert<REVIEW_OPERS>(opers);
                            
                        }    
                    }
                    else
                    {
                        if(request.DYLX =="100" && node.PREV_NODE !=-1)
                        {
                            //退回
                            var prev_node = Jd.ReviewNodeService.FirstOrNull(REVIEW_NODE._.ID == node.PREV_NODE);
                            var prev_node_prev = Jd.ReviewNodeService.FirstOrNull(REVIEW_NODE._.ID == prev_node?.ID);
                            decimal? instanceId = instance.ID;
                            if (null == prev_node_prev)
                            {
                                //如果没有上上节点 则说明是从上一个流程 提交下来的 即 接收流程
                                prev_node_prev = Jd.ReviewNodeService.FirstOrNull(REVIEW_NODE._.ID == prev_node.PREV_MAIN_NODE);

                                instanceId = FromWhere<REVIEW_INSTANCE>(REVIEW_INSTANCE._.BA_ID == instance.BA_ID
                                    && REVIEW_INSTANCE._.NOW_NODE == prev_node_prev.ID
                                    && REVIEW_INSTANCE._.IS_END == 1)
                                    .Select(REVIEW_INSTANCE._.ID)
                                    .OrderBy(REVIEW_INSTANCE._.ID)
                                    .ToFirst<REVIEW_INSTANCE>()?.ID;
                                    
                            }

                            if(null != prev_node_prev)
                            {
                                var current_instance = FromWhere<REVIEW_INSTANCE>(REVIEW_INSTANCE._.BA_ID == instance.BA_ID
                                && REVIEW_INSTANCE._.IS_END == 1)
                                .OrderBy(REVIEW_INSTANCE._.ID.Desc).ToFirst();

                                if (null != current_instance)
                                {
                                    next_node = Jd.ReviewNodeService.FirstOrNull(REVIEW_NODE._.MAIN_ID == current_instance.MAIN_ID
                                        && REVIEW_NODE._.ID == current_instance.NOW_NODE);

                                    //当前审批事项标记已办
                                    instance.IS_END = 1;
                                    //新增一条 REVIEW_INSTANCE 记录
                                    smsType = "BACK";

                                    if (!new List<string> { "2", "3", "6" }.Contains(DYLX))
                                    {
                                        var dept_cofnigs = Jd.ReviewDepconfigService.FindList(REVIEW_DEPCONFIG._.NODE_ID == current_instance.NOW_NODE
                                            && REVIEW_DEPCONFIG._.IS_SELECT == 1
                                            && REVIEW_DEPCONFIG._.DEP_ID == JdUser?.DEPARTID);
                                        var staffs = current_instance.STAFF.Split('|');


                                        List<string> dept_users = new List<string>();
                                        foreach (var dept_config in dept_cofnigs)
                                        {
                                            dept_users.Add(dept_config.USER_ID.ToString());
                                        }

                                        REVIEW_INSTANCE newinstance = new REVIEW_INSTANCE();
                                        newinstance.ID = 0;
                                        newinstance.IS_END = 0;
                                        newinstance.BA_ID = current_instance.BA_ID;
                                        newinstance.CREATE_BY = JdUser?.ID;
                                        newinstance.CREATE_TM = now;
                                        newinstance.MAIN_ID = current_instance.MAIN_ID;
                                        newinstance.NOW_NODE = current_instance.NOW_NODE;
                                        newinstance.NOW_USERS = String.Join(",", dept_users);
                                        newinstance.QTR = "";
                                        newinstance.STAFF = "";
                                        newinstance.TENDER_PROJECT_CODE = current_instance.TENDER_PROJECT_CODE;
                                        newinstance.TIMEOUT = Jd.THolidayService.GetWorkDate(now, next_node.TIMEOUT.HasValue ? (int)next_node.TIMEOUT.Value : 0);


                                        tran.Insert<REVIEW_INSTANCE>(newinstance);

                                        request.INSTANCE_ID = (int)newinstance.ID;

                                      
                                        operUser = newinstance.NOW_USERS;
                                    }

                                }
                            }
                            
                        }
                        else if(request.DYLX !="102" && node.PREV_NODE ==-1 && node.PREV_MAIN_NODE.HasValue)
                        {
                            var current_instance = FromWhere<REVIEW_INSTANCE>(REVIEW_INSTANCE._.BA_ID == instance.BA_ID
                                && REVIEW_INSTANCE._.NOW_NODE == node.PREV_MAIN_NODE
                                && REVIEW_INSTANCE._.IS_END == 1)
                                .OrderBy(REVIEW_INSTANCE._.ID.Desc)
                                .ToFirst();
                            if(null != current_instance)
                            {
                                next_node = Jd.ReviewNodeService.FirstOrNull(REVIEW_NODE._.MAIN_ID == current_instance.MAIN_ID
                                    && REVIEW_NODE._.ID == current_instance.NOW_NODE);

                                //当前审批事项标记已办
                                instance.IS_END = 1;
                                smsType = "BACK";

                                //新增一条 REVIEW_INSTANCE 记录

                                if (!new List<string> { "2", "3", "6" }.Contains(DYLX))
                                {
                                    var dept_cofnigs = Jd.ReviewDepconfigService.FindList(REVIEW_DEPCONFIG._.NODE_ID == node.PREV_MAIN_NODE
                                    && REVIEW_DEPCONFIG._.IS_SELECT == 1
                                    && REVIEW_DEPCONFIG._.DEP_ID == JdUser?.DEPARTID);
                                    var staffs = current_instance.STAFF.Split('|');


                                    List<string> dept_users = new List<string>();
                                    foreach (var dept_config in dept_cofnigs)
                                    {
                                        dept_users.Add(dept_config.USER_ID.ToString());
                                    }

                                    REVIEW_INSTANCE newinstance = new REVIEW_INSTANCE();
                                    newinstance.ID = 0;
                                    newinstance.IS_END = 0;
                                    newinstance.BA_ID = current_instance.BA_ID;
                                    newinstance.CREATE_BY = JdUser?.ID;
                                    newinstance.CREATE_TM = now;
                                    newinstance.MAIN_ID = current_instance.MAIN_ID;
                                    newinstance.NOW_NODE = current_instance.NOW_NODE;
                                    newinstance.NOW_USERS = String.Join(",", dept_users);
                                    newinstance.QTR = "";
                                    newinstance.STAFF = "";
                                    newinstance.TENDER_PROJECT_CODE = current_instance.TENDER_PROJECT_CODE;
                                    newinstance.TIMEOUT = Jd.THolidayService.GetWorkDate(now, next_node.TIMEOUT.HasValue ? (int)next_node.TIMEOUT.Value : 0);


                                    tran.Insert<REVIEW_INSTANCE>(newinstance);

                                    request.INSTANCE_ID = (int)newinstance.ID;
                                  
                                    operUser = newinstance.NOW_USERS;
                                }
                            }
                        }else if(request.DYLX =="102")
                        {
                            //非牵头人，什么都不用做
                        }
                        else
                        {
                            //没有下一步  结束
                            instance.IS_END = 1;
                        }
                    }
                    review_log.C3 = JdUser?.ID.ToString();
                    review_log.ID = 0;
                    review_log.OPER_TM = now;
                    review_log.SL_ID = instance.ID;
                    review_log.USER_ID = JdUser?.ID;
                    tran.Insert<REVIEW_LOG>(review_log);

                    tran.Update<REVIEW_INSTANCE>(instance);

                    switch (smsType)
#pragma warning disable CS1522 // 空的 switch 块
                    {
#pragma warning restore CS1522 // 空的 switch 块
                        //case "NEXT": SendNextMsg((int)now_instance.BA_ID, operUser, stepName); break;
                        //case "BACK": SendBackMsg((int)now_instance.BA_ID, operUser); break;
                    }
                    tran.Commit();
                    r.SetSuccess();
                    return r;

                }
                catch(Exception ex)
                {
                    tran.Rollback();
                    var requestid = Guid.NewGuid().ToString();
                    LoggerR.Error("logid:" + requestid + ",备案签收/审批 失败:" + ex.Message
                        + Logger.GetRequestMessage(HttpContext.Current), ex);

                    r.SetException("操作失败:" + ex.Message + ",请求id:" + requestid, ex);
                    return r;
                }
            }

        }

        /// <summary>
        /// 获取流程某个步骤审批人员
        /// </summary>
        /// <returns></returns>
        private List<YW_FLOW_USER> GetFlowUser(decimal? node_id,decimal? dept_id)
        {
            var flow_users = FromWhere<REVIEW_DEPCONFIG>()
                .LeftJoin<T_USER>(REVIEW_DEPCONFIG._.USER_ID == T_USER._.ID)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER._.DEPARTID == T_USER_DEPARTMENT._.DEPID)
                .Where(REVIEW_DEPCONFIG._.NODE_ID == node_id && REVIEW_DEPCONFIG._.DEP_ID == dept_id)
                .ToList<YW_FLOW_USER>();
            return flow_users;
        }

        /// <summary>
        /// 获取审批记录
        /// </summary>
        /// <param name="SL_ID"></param>
        /// <returns></returns>
        private IEnumerable<dynamic> GetOperLog(decimal SL_ID)
        {
            //
            //TODO:重构
            //
            string sql = string.Format(@"SELECT A.ID,
                                               B.NODE_NAME,
                                               B.IS_MULTI,
                                               OPERNAME,
                                               OPER_TM,
                                               C1,
                                               C2,
                                               C3,
                                               C4,
                                               C5,
                                               DATA_DIC,
                                               B.ATTRIBUTES,
                                               C.MANAGE_NAME,
                                               CASE WHEN B.IS_MULTI = '1' AND C3 IS NULL AND D.NOW_NODE <> A.NODE_ID then '1' else '0' END ISHIDE,
                                               case
                                                 when B.IS_MULTI = 1 and C3 is not null then
                                                  '（牵头人意见汇总）'
                                                 else
                                                  ' '
                                               end as ISQTR
                                          FROM REVIEW_LOG A
                                          INNER JOIN REVIEW_NODE B
                                            ON A.NODE_ID = B.ID
                                          LEFT JOIN T_USER C
                                            ON A.USER_ID = C.ID
                                          LEFT JOIN REVIEW_INSTANCE D
                                            ON A.SL_ID=D.ID
                                         WHERE D.BA_ID = '{0}' order by oper_tm desc", SL_ID);

            return FromSql(sql).ToList<dynamic>();
        }

        /// <summary>
        /// 根据招标项目编号，获取招标文件信息
        /// </summary>
        /// <param name="tender_project_code">招标项目编号</param>
        /// <returns></returns>
        public GeneralResult GetBiddoc(string tender_project_code)
        {
            var r = new GeneralResult();
            if(String.IsNullOrEmpty(tender_project_code))
            {
                r.SetFail("招标文件编号不能为空");
                return r;
            }
            var tender_project = FirstOrNull<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == tender_project_code);
            if(null == tender_project)
            {
                r.SetFail("招标项目信息不存在或已删除");
                return r;
            }
            var rtype = tender_project.RTYPE;
            var record_review = FirstOrNull<RECORD_REVIEW>(RECORD_REVIEW._.TENDER_PROJECT_CODE == tender_project_code
                    && RECORD_REVIEW._.REVIEW_TYPE == String.Concat(rtype, "101"));
            if(null == record_review)
            {
                r.SetFail("招标文件备案不存在");
                return r;
            }
            if(rtype == "MZ")
            {
                var data = FirstOrNull<RECORD_RESIDENTIAL_BIDDOC>(RECORD_RESIDENTIAL_BIDDOC._.RECORD_ID == record_review.ID);
                if(null == data)
                {
                    r.SetFail("招标文件备案信息不存在");
                    return r;
                }
                var dic = data.ToBindDicDictionary();
                dic.Remove("ID");
                dic.Remove("RECORD_ID");
                r.SetSuccess(dic);
                return r;
            }

            if(true)
            {
                var data = FirstOrNull<RECORD_BIDDOC_NORMAL>(RECORD_BIDDOC_NORMAL._.RECORD_ID == record_review.ID);
                if (null == data)
                {
                    r.SetFail("招标文件备案信息不存在");
                    return r;
                }
                var dic = data.ToBindDicDictionary();
                dic.Remove("ID");
                dic.Remove("RECORD_ID");
                r.SetSuccess(dic);
                return r;
            }
        }
    }
}