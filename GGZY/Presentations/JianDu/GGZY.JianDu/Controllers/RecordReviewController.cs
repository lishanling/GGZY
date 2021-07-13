using System;
using System.Web.Mvc;
using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;
using System.Linq;
using System.Collections.Generic;
using GGZY.Services.Base;
using Dos.ORM;
using GGZY.Services.Extensions;
using GGZY.Core.Extensions;

namespace GGZY.JianDu.Controllers
{
    public partial class JdRecordReviewController
    {
        /// <summary>
        /// 根据招标项目编号获取招标备案类型列表(TAB选项卡)
        /// </summary>
        /// <param name="tender_project_code">招标项目编号</param>
        /// <returns></returns>
        public ActionResult GetRecordReviewTypeList(string tender_project_code)
        {
            GeneralResult r = new GeneralResult();
            if (String.IsNullOrEmpty(tender_project_code))
            {
                r.SetFail("招标项目编号不能为空");
                return JResult(r);
            }
            var tender_project = Jd.TenderProjectService.FirstOrNull(TENDER_PROJECT._.TENDER_PROJECT_CODE == tender_project_code);
            if (null == tender_project)
            {
                r.SetFail("招标项目不存在或已删除");
                return JResult(r);
            }
            var data = Jd.SysDicService.GetRecordReviewTypeList(tender_project_code);
            r.SetSuccess(data);
            return JResult(r);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tender_project_code">招标项目编号</param>
        /// <param name="search">搜索分页条件</param>
        /// <param name="review_type">备案类型，可为空</param>
        /// <returns></returns>
        public ActionResult List(string tender_project_code, SearchCondition search, string review_type = "")
        {
            GeneralResult r = new GeneralResult();
            if (String.IsNullOrEmpty(tender_project_code))
            {
                r.SetFail("招标项目编号不能为空");
                return JResult(r);
            }

            var tender_project = Jd.TenderProjectService.FirstOrNull(TENDER_PROJECT._.TENDER_PROJECT_CODE == tender_project_code);
            if(null == tender_project)
            {
                r.SetFail("招标项目不存在/已删除");
                return JResult(r);
            }
            //住建
            if(tender_project.RTYPE =="MZ" || tender_project.RTYPE =="MT")
            {
                var data = Jd.RecordReviewService.List_ZJ(tender_project_code, search, review_type);
                r.SetSuccess(data);
                return JResult(r);
            }
            if (true)
            {
                var data = Jd.RecordReviewService.List(tender_project_code, search, review_type);
                r.SetSuccess(data);
                return JResult(r);
            }
        }

        public ActionResult Detail(int record_id, string bid_section_code = "")
        {
            GeneralResult r = new GeneralResult();
            var record_review = Jd.RecordReviewService.FirstOrNull(RECORD_REVIEW._.ID == record_id);
            if (null == record_review)
            {
                r.SetFail("备案记录不存在.未找到 RECORD_REVIEW 信息");
                return JResult(r);
            }
            
            switch (record_review.REVIEW_TYPE)
            {
                case "MS101"://招标文件备案-通用
                case "MY101"://渔港
                case "MJ101"://交通
                case "MN101"://农业
                case "MG101"://工业
                case "MT101"://住建-市政
                case "MC101":
                    r = Jd.RecordBiddocNormalService.Detail(record_id, record_review.REVIEW_TYPE, id => CommonAttachmentBuilder(id, "Jd", "Sys"));
                    break;
                case "MZ101"://住建
                    r = Jd.RecordResidentialBiddocService.Detail(record_id, id => CommonAttachmentBuilder(id, "Jd", "Sys"));
                    break;
                case "MC102"://澄清修改备案-通用
                case "MS102"://澄清修改备案-水利
                case "MY102":
                case "MJ102"://补疑书备案-交通
                case "MN102":
                case "MG102":
                case "MT102":
                    r = Jd.RecordClassifyNormalService.Detail(record_id, id => CommonAttachmentBuilder(id, "Jd", "Sys"));
                    break;
                case "MZ102":
                    r = Jd.RecordClassifyService.Detail(record_id, id => CommonAttachmentBuilder(id, "Jd", "Sys"));
                    break;
                case "MC103"://澄清修改备案-通用
                case "MS103"://异议处理结果备案-水利
                case "MY103":
                case "MJ103":
                case "MN103":
                case "MG103":
                case "MT103":
                case "MZ103":
                    r = Jd.RecordHandleResultService.Detail(record_id, id => CommonAttachmentBuilder(id, "Jd", "Sys"));
                    break;
                case "MC104"://招标投标过程备案材料备案-通用
                case "MS104"://招标投标过程备案材料备案
                case "MN104":
                case "MG104":
                case "MY104":
                    r = Jd.RecordReviewService.Detail(record_id, id => CommonAttachmentBuilder(id, "Jd", "Sys"), record_review.REVIEW_TYPE);
                    break;
                case "MC105"://合同备案-通用
                case "MS105"://合同备案-水利
                case "MY105":
                case "MJ105":
                case "MN105":
                case "MG105":
                    r = Jd.RecordContractService.Detail(record_id, id => CommonAttachmentBuilder(id, "Jd", "Sys"));
                    break;
                //case "MZ102"://澄清修改备案-住建
                //    r = Jd.RecordResidentialBiddocService.Detail(record_id);
                //    break;
                case "MJ104"://招标投情况书面报告备案
                    r = Jd.RecordWrittenService.Detail(record_id, id => CommonAttachmentBuilder(id, "Jd", "Sys"), bid_section_code);
                    break;
                case "MT104":
                case "MZ104":
                    r = Jd.RecordBiddingWriteService.Detail(record_id,id=>CommonAttachmentBuilder(id,"Jd", "Sys"), bid_section_code);
                    break;
                default:
                    r.SetFail("未处理的备案类型");
                    break;
            }
            if (r.Success && r.Data is Dictionary<string, object>)
            {
                decimal? INSTANCE_END_ID = null;
                var dic = (Dictionary<string, object>)r.Data;
                if(dic != null && dic.ContainsKey("INSTANCE_END_ID") && dic["INSTANCE_END_ID"] !=null)
                {
                    INSTANCE_END_ID = Convert.ToDecimal(dic["INSTANCE_END_ID"]);
                }
                var REVIEW_STATUS_TEXT = GetReviewStatusText(record_review);
                var category = record_review.REVIEW_TYPE.Substring(0, 2);
                var review_dic = record_review.ToDictionary();
                var flow = Jd.RecordReviewService.GetFlow(record_review);
                var tender_project = Jd.TenderProjectService.FirstOrNull(TENDER_PROJECT._.TENDER_PROJECT_CODE ==
                    record_review.TENDER_PROJECT_CODE);

                var credit_deduction = Jd.RecordCreditDeductionService.GetCreditDetailList(record_id.ToString());

                review_dic.Add("REVIEW_STATUS_TEXT", REVIEW_STATUS_TEXT);
                dic.Add("REVIEW_CATEGORY",("MZ" == category || "MT" == category)?"住建":"非住建");
                dic.Add("RECORD_REVIEW", review_dic);
                dic.Add("BUTTONS", Jd.RecordReviewService.GetButtons(record_review, flow, INSTANCE_END_ID));
                dic.Add("STATES", Jd.RecordReviewService.GetStates(record_review));
                dic.Add("FLOW", flow);
                dic.Add("CREDITS", credit_deduction.Data);
                dic.Add("TENDER_PROJECT",new {
                    tender_project.TENDER_PROJECT_CODE,
                    tender_project.TENDER_PROJECT_NAME,
                    tender_project.TENDERER_NAME,
                    tender_project.TENDERER_CONTRACT,
                    tender_project.TENDERER_PHONE,
                    tender_project.TENDER_AGENCY_NAME,
                    tender_project.TENDER_AGENT_CONTRACT,
                    tender_project.TENDER_AGENT_PHONE
                });
            }

            return JResult(r);
        }
        /// <summary>
        /// 根据招标项目备案信息获取备案状态
        /// </summary>
        /// <param name="record_review"></param>
        /// <returns></returns>
        protected string GetReviewStatusText(RECORD_REVIEW record_review)
        {
            string REVIEW_STATUS_TEXT = "";
            if (record_review.REVIEW_TYPE.StartsWith("MZ") || record_review.REVIEW_TYPE.StartsWith("MT"))
            {
                if (record_review.REVIEW_TYPE.Contains("103") &&
                record_review.REVIEW_STATUS != "0")
                {
                    return "";
                }
                REVIEW_STATUS_TEXT = Jd.SysDicService.FromWhere(SYS_DIC._.TYPE == "3032"
                  && new WhereClip("INSTR(SYS_DIC.VALUE," + record_review.REVIEW_STATUS + ")>0"))
                  .Select(t => t.TEXT).First<string>();
                return REVIEW_STATUS_TEXT;
            }
            REVIEW_STATUS_TEXT = Jd.SysDicService.FromWhere(SYS_DIC._.TYPE == "3028"
             && new WhereClip("INSTR(SYS_DIC.VALUE," + record_review.REVIEW_STATUS + ")>0"))
             .Select(t => t.TEXT).First<string>();
            return REVIEW_STATUS_TEXT;
        }

        /// <summary>
        /// 获取住建下一步骤处理流程
        /// </summary>
        /// <param name="record_id">备案记录ID</param>
        /// <param name="flow_id">流程ID</param>
        /// <returns></returns>
        public ActionResult GetNextFlow(int record_id,int flow_id)
        {
            var r = Jd.RecordReviewService.GetNextFlow(record_id,flow_id);
            return JResult(r);
        }

        /// <summary>
        /// 签收以及审查
        /// </summary>
        /// <param name="action"></param>
        /// <param name="RECORD_ID"></param>
        /// <param name="record_attachments"></param>
        /// <param name="REMARK"></param>
        /// <returns></returns>
        public ActionResult Audit(string ACTION,string type,int RECORD_ID, List<RECORD_ATTACHMENT> RECORD_ATTACHMENTS, string REMARK="")
        {
            GeneralResult r = new GeneralResult();
            var actionParameter = ACTION.ToUpper();
            if ("SUBMIT_AUDIT" == ACTION || "FALLBACK" == ACTION)
            {
                actionParameter =String.Concat(ACTION.ToUpper(), type);
            }
            switch(actionParameter)
            {
                case "RECEIVE"://
                case "RECEIVE_COMMON":
                    r = Jd.RecordReviewService.Audit(RECORD_ID, "", REMARK, 1, "", 8, RECORD_ATTACHMENTS, id => CommonAttachmentBuilder(id, "Jd", "Sys"));
                    break;
                //case "RECEIVE_COMMON":
                //    r = Jd.RecordReviewService.Audit(RECORD_ID, "", REMARK, 1, "", 1, RECORD_ATTACHMENTS, id => CommonAttachmentBuilder(id, "Jd", "Sys"));
                //    break;
                case "FALLBACK2"://签收退回->非本部门监管
                    r = Jd.RecordReviewService.Audit(RECORD_ID, "2", REMARK, 0, "", 2, RECORD_ATTACHMENTS, id => CommonAttachmentBuilder(id, "Jd", "Sys"));
                    break;
                case "FALLBACK3"://签收退回->非本部门监管
                    r = Jd.RecordReviewService.Audit(RECORD_ID, "3", REMARK, 0, "", 3, RECORD_ATTACHMENTS, id => CommonAttachmentBuilder(id, "Jd", "Sys"));
                    break;
                case "SUBMIT_AUDIT5"://审查未发现问题
                    r = Jd.RecordReviewService.Audit(RECORD_ID,"5", "", null, REMARK, 5, RECORD_ATTACHMENTS, id => CommonAttachmentBuilder(id, "Jd", "Sys"));
                    break;
                case "SUBMIT_AUDIT6"://审查发现问题
                    r = Jd.RecordReviewService.Audit(RECORD_ID, "6", "", null, REMARK, 6, RECORD_ATTACHMENTS, id => CommonAttachmentBuilder(id, "Jd", "Sys"));
                    break;
                case "SAVE_REMARK"://审查意见修改
                    r = Jd.RecordReviewService.Audit(RECORD_ID, "", "", null, REMARK, 9, RECORD_ATTACHMENTS, id => CommonAttachmentBuilder(id, "Jd", "Sys"));
                    break;
                case "SIGN_UP":
                    r.SetFail("正在对接中……");
                    break;
                default:
                    r.SetFail("参数信息有误,请稍后重试");
                    break;
            }
            return JResult(r);
        }

        /// <summary>
        /// 签章成功后，保存签章信息
        /// </summary>
        /// <param name="RECORD_ID">备案记录Id</param>
        /// <param name="GUID">签章文件GUID</param>
        /// <returns></returns>
        public ActionResult SaveSignUp(int RECORD_ID, string GUID,string file_guid)
        {
            var r = Jd.RecordReviewService.SaveSignUp(RECORD_ID, GUID, file_guid);
            return JResult(r);
        }

        public ActionResult SubmitAudit(YW_FLOW_SUBMIT entity,REVIEW_LOG logs, List<RECORD_ATTACHMENT> RECORD_ATTACHMENTS,
            List<RECORD_CREDIT_DEDUCTION> CREDITS)
        {
            //
            //TODO:统一事务处理
            //
            if(null == RECORD_ATTACHMENTS)
            {
                RECORD_ATTACHMENTS = new List<RECORD_ATTACHMENT>();
            }
            var r = new GeneralResult();
            var review = Jd.RecordReviewService.FirstOrNull(RECORD_REVIEW._.ID == entity.RECORD_ID);
            if(null == review)
            {
                r.SetFail("备案记录不存在");
                return JResult(r);
            }

            if(null != CREDITS && CREDITS.Any())
            {
                CREDITS.ForEach(e => {
                    e.REVIEW_ID = review.ID.ToString();
                    e.REVIEW_CODE = review.REVIEW_CODE;
                    e.CREATOR = JdUser?.ID;
                });
            }

            string DYLX = entity.DYLX;

            r = Jd.RecordReviewService.SubmitAudit(entity, logs);

            if(DYLX == "5" && ! new List<string> { "101","102"}.Contains((review.REVIEW_TYPE.Substring(2,3))))
            {
                DYLX = "8";
            }

            if(r.Success)
            {
                switch (DYLX)
                {
                    case "8":
                        r = Jd.RecordReviewService.Audit(entity.RECORD_ID, DYLX, logs.C2, 1, logs.C2, Convert.ToInt32(DYLX), RECORD_ATTACHMENTS, id => CommonAttachmentBuilder(id, "Jd", "Sys"));
                        break;
                    case "2":
                    case "3":
                    case "6":
                    case "9":
                        if(DYLX =="6" || DYLX =="9")
                        {
                            Jd.RecordCreditDeductionService.CreateOrSave(CREDITS,entity.RECORD_ID);
                        }
                        r = Jd.RecordReviewService.Audit(entity.RECORD_ID, DYLX, logs.C2, 0, logs.C2, Convert.ToInt32(DYLX), RECORD_ATTACHMENTS, id => CommonAttachmentBuilder(id, "Jd", "Sys"));
                        break;
                    case "5":
                        
                        r = Jd.RecordReviewService.Audit(entity.RECORD_ID, DYLX, logs.C2, 1, logs.C2, Convert.ToInt32(DYLX), RECORD_ATTACHMENTS, id => CommonAttachmentBuilder(id, "Jd", "Sys"));
                        break;
                    default:
                        break;
                }
            }
            return JResult(r);
        }

        /// <summary>
        /// 签收/审查动作
        /// </summary>
        /// <param name="review"></param>
        /// <param name="state"></param>
        /// <param name="record_attachments"></param>
        /// <returns></returns>
        private ActionResult Audit(RECORD_REVIEW review, int state, List<RECORD_ATTACHMENT> record_attachments)
        {
            GeneralResult r = new GeneralResult();

            var data = Jd.RecordReviewService.Audit(review.ID, review.REVIEW_STATUS,
                review.REVIEW_COMMENT, review.IS_SIGN, review.REVIEW_COMMENT, state, record_attachments,
                id => CommonAttachmentBuilder(id, "Jd", "Sys"));
            r.SetSuccess(data);
            return JResult(r);
        }

        /// <summary>
        /// 保存或提交
        /// </summary>
        /// <param name="review"></param>
        /// <param name="record_biddoc"></param>
        /// <param name="attachments"></param>
        /// <returns></returns>
        //[ValidateInput(false)]
        public ActionResult SaveOrSubmit(RECORD_REVIEW review, int? RECORD_ID,
            List<UploadResData_ReviewRequest> attachments)
        {
            GeneralResult r = new GeneralResult();

            var tender_project_code = review.TENDER_PROJECT_CODE;
            var review_type = review.REVIEW_TYPE;
            var isSingle = Jd.RecordReviewService.CheckIsSingleByReviewType(tender_project_code, review_type, RECORD_ID);
            if (!isSingle.Success)
            {
                return JResult(isSingle);
            }
            var isTrueReviewType = Jd.RecordReviewService.CheckIsTrueReviewType(tender_project_code, review_type);
            if (!isTrueReviewType)
            {
                r.SetFail("招标项目信息的招标项目类型与备案类型编码不一致，请重试.");
                return JResult(r);
            }
            var tender_project = Jd.TenderProjectService.FirstOrNull(TENDER_PROJECT._.TENDER_PROJECT_CODE == tender_project_code);
            if (null == tender_project)
            {
                r.SetFail("招标项目信息不存在或已删除");
                return JResult(r);
            }
            review.ID = RECORD_ID;
            if (tender_project.RTYPE == "MZ" || tender_project.RTYPE == "MT")
            {
                //住建行业
                var data_zj = Jd.RecordReviewService.SaveOrSubmit_ZJ(tender_project, review, attachments);
                return JResult(data_zj);
            }
            var data = Jd.RecordReviewService.SaveOrSubmit(tender_project, review, attachments);
            return JResult(data);
        }
        /// <summary>
        /// 根据招标项目编号获取招标文件备案信息
        /// </summary>
        /// <param name="tender_project_code"></param>
        /// <returns></returns>
        public ActionResult GetBiddoc(string tender_project_code)
        {
            var data = Jd.RecordReviewService.GetBiddoc(tender_project_code);
            return JResult(data);
        }
        /// <summary>
        /// 删除备案记录
        /// </summary>
        /// <param name="record_id"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Delete(int record_id)
        {
            GeneralResult r = new GeneralResult();
            var record_review = Jd.RecordReviewService.FirstOrNull(RECORD_REVIEW._.ID == record_id);
            if (null == record_review)
            {
                r.SetFail("记录不存在.未找到 RECORD_REVIEW 信息");
                return JResult(r);
            }
            if (record_review.CREATOR != JdUser?.ID)
            {
                r.SetFail("操作失败:非法授权");
                return JResult(r);
            }
            if (record_review.REVIEW_STATUS != "0")
            {
                r.SetFail("操作失败:已提交备案，删除失败");
                return JResult(r);
            }
            int rows = Jd.RecordReviewService.Delete(RECORD_REVIEW._.ID == record_id);
            if (rows == 0)
            {
                r.SetFail("操作失败:备案记录不存在或已被删除");
                return JResult(r);
            }
            r.SetSuccess(new
            {
                RECORD_ID = record_id
            });
            return JResult(r);
        }

        /// <summary>
        /// 撤回备案
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Retract(int record_id = 0)
        {
            GeneralResult r = new GeneralResult();
            if (record_id == 0)
            {
                r.SetFail("操作失败:record_id 错误");
                return JResult(r);
            }
            r = Jd.RecordReviewService.Retract(record_id);
            return JResult(r);
        }
        /// <summary>
        /// 交易资料-招标备案
        /// </summary>
        /// <param name="tenderProjectCode"></param>
        /// <returns></returns>
        public ActionResult GetRecordListByCode(string tenderProjectCode)
        {
            return JResult(Jd.RecordReviewService.GetRecordListByCode(tenderProjectCode));
        }


        /// <summary>
        /// 交易资料-标签计数
        /// </summary>
        /// <param name="tenderProjectCode"></param>
        /// <param name="tenderProjectCodeOld"></param>
        /// <returns></returns>
        public ActionResult GetProcessDataCount(string tenderProjectCode,string tenderProjectCodeOld)
        {
            return JResult(Jd.RecordReviewService.GetProcessDataCount(tenderProjectCode, tenderProjectCodeOld));
        }
    }
}