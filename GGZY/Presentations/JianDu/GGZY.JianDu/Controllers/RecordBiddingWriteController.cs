using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;
using System.Collections.Generic;
using GGZY.JianDu.Models;
using System.Linq;

namespace GGZY.JianDu.Controllers
{
    public partial class JdRecordBiddingWriteController
    {
        /// <summary>
        /// 保存或提交
        /// </summary>
        /// <param name="review"></param>
        /// <param name="record_biddoc"></param>
        /// <param name="attachments"></param>
        /// <returns></returns>
        public ActionResult SaveOrSubmit(RECORD_REVIEW review,RECORD_BIDDING_WRITE_REQUEST bidding_write, List<RECORD_SECTION_INFO_REQUEST> record_section_infos)
        {
            //
            //TODO:逻辑复杂，等待重构
            //
            GeneralResult r = new GeneralResult();

            var tender_project_code = review.TENDER_PROJECT_CODE;
            var review_type = review.REVIEW_TYPE;
            var isSingle = Jd.RecordReviewService.CheckIsSingleByReviewType(tender_project_code, review_type, bidding_write.RECORD_ID);
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
            if (record_section_infos.Where(w => String.IsNullOrWhiteSpace(w.BID_SECTION_CODE)).Any())
            {
                r.SetFail("标段包编号不能为空");
                return JResult(r);
            }
            List<RECORD_SECTION_INFO> records = new List<RECORD_SECTION_INFO>();
            List<UploadResData_ReviewRequest> attachments = new List<UploadResData_ReviewRequest>();
            if(null !=bidding_write.ATTACHMENTS && bidding_write.ATTACHMENTS.Any())
            {
                attachments = bidding_write.ATTACHMENTS;
            }


            record_section_infos.ForEach(e => {
                var entity = new RECORD_SECTION_INFO
                {
                    ID = e.ID,
                    RECORD_ID = e.RECORD_ID,
                    ENTERPRISE_NOTICE_CODE = e.ENTERPRISE_NOTICE_CODE,
                    DEPARTMENT_NOTICE_CODE = e.DEPARTMENT_NOTICE_CODE,
                    WIN_BID_DATE = e.WIN_BID_DATE,
                    BID_AMOUNT = e.BID_AMOUNT,
                    WIN_BIDDER_NAME = e.WIN_BIDDER_NAME,
                    WIN_BIDDER_CODE = e.WIN_BIDDER_CODE,
                    PROJECT_LEADER_NAME = e.PROJECT_LEADER_NAME,
                    PROJECT_LEADER_CODE = e.PROJECT_LEADER_CODE,
                    WIN_BIDDER_WAY = e.WIN_BIDDER_WAY,
                    BID_EVALUATE_INFO = e.BID_EVALUATE_INFO,
                    OTHER_EVALUATE_RECORD = e.OTHER_EVALUATE_RECORD,
                    WIN_BIDDER_PUBLIC = e.WIN_BIDDER_PUBLIC,
                    WIN_BID_INFO = e.WIN_BID_INFO,
                    CREATE_TM = e.CREATE_TM,
                    CREATOR = e.CREATOR,
                    BID_SECTION_CODE = e.BID_SECTION_CODE,
                    BID_SECTION_NAME = e.BID_SECTION_NAME,
                };
                records.Add(entity);
                if (e.ATTACHMENTS != null && e.ATTACHMENTS.Any())
                {
                    e.ATTACHMENTS.ForEach(attachment => {
                        attachment.BID_SECTION_CODE = e.BID_SECTION_CODE;
                    });
                    attachments.AddRange(e.ATTACHMENTS);
                }
            });

            var data = Jd.RecordBiddingWriteService.SaveOrSubmit(tender_project, review, bidding_write,records, attachments);
            return JResult(data);
        }
    }
}