using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Dos.ORM;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Extensions;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    /// <summary>
    /// 招标投标情况书面报告备案记录
    /// </summary>
    public partial class RecordWrittenService 
    {
        /// <summary>
        /// 详情
        /// </summary>
        /// <param name="record_id">备案记录ID</param>
        /// <returns></returns>
        public GeneralResult Detail(int record_id,Func<string,string> urlBuilder,string bid_section_code="")
        {
            var r = new GeneralResult();
            r.SetSuccess();

            var condition = new WhereClipBuilder();
            condition.And(RECORD_WRITTEN._.RECORD_ID == record_id);
            if(! String.IsNullOrWhiteSpace(bid_section_code))
            {
                condition.And(RECORD_WRITTEN._.BID_SECTION_CODE == bid_section_code);
            }
            var list = FindList(condition);
            if (! list.Any())
            {
                r.SetFail("招标投标情况书面报告备案记录不存在.未找到 RECORD_WRITTEN 信息");
                return r;
            }

            var conditionInstance = new WhereClipBuilder();
            conditionInstance.And(REVIEW_INSTANCE._.BA_ID == record_id);

            var reviewInstance = Jd.ReviewInstanceService.FindList(conditionInstance, REVIEW_INSTANCE._.ID.Desc).ToList();
            var atts = Jd.RecordReviewService.GetReviewAttachment(record_id, urlBuilder, bid_section_code);
            var data = new Dictionary<string, object>();
            data.Add("INSTANCE_END_ID", reviewInstance.Where(w => w.IS_END == 1).FirstOrDefault()?.ID);
            data.Add("INSTANCE_ID", reviewInstance.FirstOrDefault()?.ID);

            var entities = new List<Dictionary<string, object>>();
            list.ForEach(e => {
                var dic = e.ToBindDicDictionary();
                var attr = atts.Where(w => w.BID_SECTION_CODE == e.BID_SECTION_CODE).ToList();
                dic.Add("ATTACHMENTS", attr);
                entities.Add(dic);
            });
            data.Add("RECORD_WRITTENS", entities);
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
        public GeneralResult SaveOrSubmit(TENDER_PROJECT tender_project, RECORD_REVIEW review, List<RECORD_WRITTEN> biddocs, List<UploadResData_ReviewRequest> attachments)
        {
            var r = new GeneralResult();
            r.SetFail("操作失败");

            var now = Jd.CommonService.GetDBDateTime();

            var db = GetDbSession();
            using (var tran = db.BeginTransaction())
            {
                try
                {
                    if (biddocs.Any())
                    {
                        review.ID = biddocs.First()?.RECORD_ID;

                        var isUpdate = review.ID.HasValue && review.ID > 0;
                        review.ID =Jd.RecordReviewService.CreateOrUpdate(tran, review, now, 
                            tender_project.TENDER_PROJECT_TYPE, 
                            attachments,
                            biddocs.Select(t=>t.BID_SECTION_CODE).ToList()
                            );
                        foreach (var biddoc in biddocs)
                        {
                            biddoc.RECORD_ID = review.ID;
                            if (!isUpdate)
                            {
                                biddoc.ID = 0;
                                biddoc.CREATE_TM = now;
                                biddoc.CREATOR = JdUser?.ID;
                                tran.Insert<RECORD_WRITTEN>(biddoc);
                            }
                            else
                            {
                                biddoc.AttachAll();
                                tran.Update<RECORD_WRITTEN>(biddoc);
                            }
                        }
                    }
                    var data = new
                    {
                        RECORD_REVIEW = review,
                        RECORD_BIDDOC_NORMAL = biddocs,
                        RECORD_ATTACHMENT = attachments
                    };
                    Jd.RecordReviewService.SaveRecordAndLog(tran, review, attachments, now, data);
                    tran.Commit();
                    r.SetSuccess(new { 
                        RECORD_ID=review.ID
                    });
                    Jd.RecordReviewService.Notify(review.ID);
                    return r;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    var requestid = Guid.NewGuid().ToString();
                    LoggerR.Error("logid:" + requestid +",招标投标情况书面报告备案提交失败:" + ex.Message
                        + Logger.GetRequestMessage(HttpContext.Current), ex);
                    r.SetException("招标投标情况书面报告备案提交失败:" + ex.Message + "logid:" + requestid, ex);
                    return r;
                }
            }
        }
    }
}