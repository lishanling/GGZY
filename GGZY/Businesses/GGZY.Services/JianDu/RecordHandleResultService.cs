﻿using System;
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
    /// 异议处理结果备案
    /// </summary>
    public partial class RecordHandleResultService 
    {
        /// <summary>
        /// 详情
        /// </summary>
        /// <param name="record_id">备案记录ID</param>
        /// <returns></returns>
        public GeneralResult Detail(int record_id,Func<string,string> urlBuilder)
        {
            var r = new GeneralResult();
            r.SetSuccess();

            var condition = new WhereClipBuilder();
            condition.And(RECORD_HANDLE_RESULT._.RECORD_ID == record_id);
            var entity = FirstOrNull(condition);
            if (null == entity)
            {
                r.SetFail("异议处理结果备案 记录不存在.未找到 RECORD_HANDLE_RESULT 信息");
                return r;
            }

            var conditionInstance = new WhereClipBuilder();
            conditionInstance.And(REVIEW_INSTANCE._.BA_ID == record_id);

            var reviewInstance = Jd.ReviewInstanceService.FindList(conditionInstance, REVIEW_INSTANCE._.ID.Desc).ToList();
            var atts = Jd.RecordReviewService.GetReviewAttachment(record_id, urlBuilder);
            var data = entity.ToBindDicDictionary();
            data.Add("INSTANCE_END_ID", reviewInstance.Where(w => w.IS_END == 1).FirstOrDefault()?.ID);
            data.Add("INSTANCE_ID", reviewInstance.FirstOrDefault()?.ID);

            data.Add("ATTACHMENTS", atts);
            r.SetSuccess(data);
            return r;
        }


        /// <summary>
        /// 异议处理结果备案
        /// </summary>
        /// <param name="tender_project"></param>
        /// <param name="review"></param>
        /// <param name="biddoc"></param>
        /// <param name="attachments"></param>
        /// <returns></returns>
        public GeneralResult SaveOrSubmit(TENDER_PROJECT tender_project, RECORD_REVIEW review, RECORD_HANDLE_RESULT biddoc, List<UploadResData_ReviewRequest> attachments)
        {
            var r = new GeneralResult();
            if (tender_project.RTYPE == "MZ" || tender_project.RTYPE == "MT")
            {
                r = Jd.RecordReviewService.CheckDepartMent(review, tender_project);
                if (!r.Success)
                {
                    return r;
                }
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
                        tran.Insert<RECORD_HANDLE_RESULT>(biddoc);
                    }
                    else
                    {
                        var model = FirstOrNull(RECORD_HANDLE_RESULT._.RECORD_ID == review.ID);
                        if (null == model)
                        {
                            tran.Rollback();
                            r.SetFail("异议处理结果备案 RECORD_HANDLE_RESULT 记录不存在.");
                            return r;
                        }
                        model.Attach();
                        if (review.REVIEW_STATUS == "0" || review.REVIEW_STATUS == "1")
                        {
                            model.Update(biddoc);
                        }
                        tran.Update<RECORD_HANDLE_RESULT>(model);
                    }
                    var data = new
                    {
                        RECORD_REVIEW = review,
                        RECORD_CLASSIFY_NORMAL = biddoc,
                        RECORD_ATTACHMENT = attachments
                    };
                    Jd.RecordReviewService.SaveRecordAndLog(tran, review, attachments, now, data,r.Data);
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
                    LoggerR.Error("异议处理结果备案提交失败:" + ex.Message, ex);
                    r.SetException("异议处理结果备案提交失败:" + ex.Message, ex);
                    return r;
                }
            }
        }
    }
}