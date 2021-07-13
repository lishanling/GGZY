using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;
using System.Linq;
using System.Collections.Generic;

namespace GGZY.JianDu.Controllers
{
    public partial class JdRecordBiddocNormalController
    {
        /// <summary>
        /// 保存或提交
        /// </summary>
        /// <param name="review"></param>
        /// <param name="record_biddoc"></param>
        /// <param name="attachments"></param>
        /// <returns></returns>
        [ValidateInput(false)]
        public ActionResult SaveOrSubmit(RECORD_REVIEW review, RECORD_BIDDOC_NORMAL record_biddoc, 
            List<UploadResData_ReviewRequest> attachments)
        {
            GeneralResult r = new GeneralResult();

            var tender_project_code = review.TENDER_PROJECT_CODE;
            var review_type = review.REVIEW_TYPE;
            var isSingle = Jd.RecordReviewService.CheckIsSingleByReviewType(tender_project_code, review_type,record_biddoc.RECORD_ID);
            if(! isSingle.Success)
            {
                return JResult(isSingle);
            }
            var isTrueReviewType = Jd.RecordReviewService.CheckIsTrueReviewType(tender_project_code, review_type);
            if(! isTrueReviewType)
            {
                r.SetFail("招标项目信息的招标项目类型与备案类型编码不一致，请重试.");
                return JResult(r);
            }
            var tender_project = Jd.TenderProjectService.FirstOrNull(TENDER_PROJECT._.TENDER_PROJECT_CODE == tender_project_code);
            if(null == tender_project)
            {
                r.SetFail("招标项目信息不存在或已删除");
                return JResult(r);
            }

            if (null != record_biddoc && record_biddoc.RECORD_ID.HasValue && record_biddoc.RECORD_ID > 0)
            {
                var record_review = Jd.RecordReviewService.FirstOrNull(RECORD_REVIEW._.ID == record_biddoc.RECORD_ID);
                if (null == record_review)
                {
                    r.SetFail("备案记录不存在或已删除");
                    return JResult(r);
                }
                if (record_review.TENDER_PROJECT_CODE != review.TENDER_PROJECT_CODE)
                {
                    r.SetFail("备案记录对应招标项目编号不一致");
                    return JResult(r);
                }
                if (record_review.REVIEW_TYPE != review.REVIEW_TYPE)
                {
                    r.SetFail("备案记录对应备案类型不一致");
                    return JResult(r);
                }
                record_review.REVIEW_STATUS = review.REVIEW_STATUS;
                review = record_review;
            }

            var data = Jd.RecordBiddocNormalService.SaveOrSubmit(tender_project,review, record_biddoc, attachments);
            return JResult(data);
        }

       
    }
}