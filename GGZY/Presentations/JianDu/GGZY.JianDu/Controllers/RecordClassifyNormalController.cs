using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;
using System.Collections.Generic;

namespace GGZY.JianDu.Controllers
{
    public partial class JdRecordClassifyNormalController
    {
        /// <summary>
        /// 保存或提交
        /// </summary>
        /// <param name="review"></param>
        /// <param name="record_biddoc"></param>
        /// <param name="attachments"></param>
        /// <returns></returns>
        [ValidateInput(false)]
        public ActionResult SaveOrSubmit(RECORD_REVIEW review, RECORD_CLASSIFY_NORMAL record_biddoc,
            List<UploadResData_ReviewRequest> attachments)
        {
            GeneralResult r = new GeneralResult();

            var tender_project_code = review.TENDER_PROJECT_CODE;
            var review_type = review.REVIEW_TYPE;
            var isSingle = Jd.RecordReviewService.CheckIsSingleByReviewType(tender_project_code, review_type,record_biddoc.RECORD_ID);
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
            var data = Jd.RecordClassifyNormalService.SaveOrSubmit(tender_project, review, record_biddoc, attachments);
            return JResult(data);
        }
    }
}