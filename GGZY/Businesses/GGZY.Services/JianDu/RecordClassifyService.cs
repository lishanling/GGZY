using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Extensions;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    /// <summary>
    /// 住建澄清修改备案
    /// </summary>
    public partial class RecordClassifyService 
    {
        /// <summary>
        /// 住建-澄清修改备案详情
        /// </summary>
        /// <returns></returns>
        public GeneralResult Detail(int record_id, Func<string, string> urlBuilder)
        {
            var r = new GeneralResult();
            r.SetSuccess();

            var condition = new WhereClipBuilder();
            condition.And(RECORD_CLASSIFY._.RECORD_ID == record_id);
            var record_biddoc = FirstOrNull(condition);
            if (null == record_biddoc)
            {
                r.SetFail("澄清修改备案记录不存在.未找到 RECORD_CLASSIFY 信息");
                return r;
            }

            var conditionInstance = new WhereClipBuilder();
            conditionInstance.And(REVIEW_INSTANCE._.BA_ID == record_id);

            var reviewInstance = Jd.ReviewInstanceService.FindList(conditionInstance, REVIEW_INSTANCE._.ID.Desc).ToList();
            var atts = Jd.RecordReviewService.GetReviewAttachment(record_id, urlBuilder);
            var data = record_biddoc.ToBindDicDictionary();
            data.Add("INSTANCE_END_ID", reviewInstance.Where(w => w.IS_END == 1).FirstOrDefault()?.ID);
            data.Add("INSTANCE_ID", reviewInstance.FirstOrDefault()?.ID);
            data.Add("ATTACHMENTS", atts);
            r.SetSuccess(data);
            return r;
        }


        /// <summary>
        /// 提交或暂存
        /// </summary>
        /// <param name="review"></param>
        /// <param name="biddoc"></param>
        /// <param name="state_type">0 :暂存 1：送审</param>
        /// <returns></returns>
        public GeneralResult SaveOrSubmit(TENDER_PROJECT tender_project, RECORD_REVIEW review, RECORD_CLASSIFY biddoc, List<UploadResData_ReviewRequest> attachments)
        {
            var r = Jd.RecordReviewService.CheckDepartMent(review, tender_project);
            if (!r.Success)
            {
                return r;
            }
            var now = Jd.CommonService.GetDBDateTime();

            var db = GetDbSession();
            using (var tran = db.BeginTransaction())
            {
                try
                {
                    review.ID = biddoc.RECORD_ID;
                    var isUpdate = review.ID.HasValue && review.ID > 0;
                    Jd.RecordReviewService.CreateOrUpdate(tran, review, now, tender_project.TENDER_PROJECT_TYPE, attachments);
                    biddoc.RECORD_ID = review.ID;
                    if (!isUpdate)
                    {
                        biddoc.ID = 0;
                        biddoc.CREATE_TM = now;
                        biddoc.CREATOR = JdUser?.ID;
                        tran.Insert<RECORD_CLASSIFY>(biddoc);
                    }
                    else
                    {
                        var condtion = new WhereClipBuilder();
                        condtion.And(RECORD_CLASSIFY._.RECORD_ID == review.ID);
                        var model = FirstOrNull<RECORD_CLASSIFY>(condtion.ToWhereClip());
                        if (null == model)
                        {
                            tran.Rollback();
                            r.SetFail("澄清修改备案 RECORD_CLASSIFY 记录不存在.");
                            return r;
                        }
                        model.Attach();
                        if (review.REVIEW_STATUS == "0" || review.REVIEW_STATUS == "1")
                        {
                            model.Update(biddoc);
                        }
                        tran.Update<RECORD_CLASSIFY>(model);
                    }
                    var data = new
                    {
                        RECORD_REVIEW = review,
                        RECORD_BIDDOC_NORMAL = biddoc,
                        RECORD_ATTACHMENT = attachments
                    };
                    Jd.RecordReviewService.SaveRecordAndLog(tran, review, attachments, now, data, r.Data);
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
                    LoggerR.Error("澄清修改备案 提交失败:" + ex.Message, ex);
                    r.SetException("澄清修改备案 提交失败:" + ex.Message, ex);
                    return r;
                }
            }
        }
    }
}