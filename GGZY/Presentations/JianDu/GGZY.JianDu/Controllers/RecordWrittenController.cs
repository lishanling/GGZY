using System;
using System.Web.Mvc;
using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;
using System.Collections.Generic;
using System.Linq;
using GGZY.JianDu.Models;

namespace GGZY.JianDu.Controllers
{
    /// <summary>
    /// 招标投标情况书面报告-交通
    /// </summary>
    public partial class JdRecordWrittenController
    {
       
        /// <summary>
        /// 保存或提交
        /// </summary>
        /// <param name="review"></param>
        /// <param name="record_biddoc"></param>
        /// <param name="attachments"></param>
        /// <returns></returns>
        public ActionResult SaveOrSubmit(RECORD_REVIEW review, List<RECORD_WRITTEN_REQUEST> record_writtens)
        {
            //
            //TODO:逻辑复杂，等待重构
            //
            GeneralResult r = new GeneralResult();

            var tender_project_code = review.TENDER_PROJECT_CODE;
            var review_type = review.REVIEW_TYPE;
            var isSingle = Jd.RecordReviewService.CheckIsSingleByReviewType(tender_project_code, review_type,review.ID);
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
            if (record_writtens.Where(w=>String.IsNullOrWhiteSpace(w.BID_SECTION_CODE)).Any())
            {
                r.SetFail("标段包编号不能为空");
                return JResult(r);
            }
            List<RECORD_WRITTEN> records = new List<RECORD_WRITTEN>();
            List<UploadResData_ReviewRequest> attachments = new List<UploadResData_ReviewRequest>();
            record_writtens.ForEach(e => {
                var entity = new RECORD_WRITTEN {
                    BID_SECTION_CODE = e.BID_SECTION_CODE,
                    ID = e.ID,
                    RECORD_ID = e.RECORD_ID,
                    WIN_UNIT_CODE = e.WIN_UNIT_CODE,
                    WIN_UNIT_CREDIT_GRADE = e.WIN_UNIT_CREDIT_GRADE,
                    WIN_UNIT_NAME = e.WIN_UNIT_NAME
                };
                records.Add(entity);
                if (e.ATTACHMENTS !=null && e.ATTACHMENTS.Any())
                {
                    e.ATTACHMENTS.ForEach(attachment => {
                        attachment.BID_SECTION_CODE = e.BID_SECTION_CODE;
                    });
                    attachments.AddRange(e.ATTACHMENTS);
                }
            });

            var data = Jd.RecordWrittenService.SaveOrSubmit(tender_project, review, records, attachments);
            return JResult(data);
        }
    }
}