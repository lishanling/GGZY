using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dos.ORM;
using GGZY.Core.Helper;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Extensions;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class RecordBiddingWriteService 
    {
        /// <summary>
        /// 详情
        /// </summary>
        /// <param name="record_id">备案记录ID</param>
        /// <returns></returns>
        public GeneralResult Detail(int record_id, Func<string, string> urlBuilder,string bid_section_code="")
        {
            var r = new GeneralResult();
            r.SetSuccess();

            var condition = new WhereClipBuilder();
            condition.And(RECORD_BIDDING_WRITE._.RECORD_ID == record_id);
            var entity = FirstOrNull(condition);
            if (null == entity)
            {
                r.SetFail("招标投标情况书面报告备案 记录不存在.未找到 RECORD_BIDDING_WRITE 信息");
                return r;
            }

            var conditionInstance = new WhereClipBuilder();
            conditionInstance.And(REVIEW_INSTANCE._.BA_ID == record_id);

            var reviewInstance = Jd.ReviewInstanceService.FindList(conditionInstance, REVIEW_INSTANCE._.ID.Desc).ToList();
           

            var sections = Jd.RecordSectionInfoService.List(record_id, bid_section_code);
            var atts = Jd.RecordReviewService.GetReviewAttachment(record_id, urlBuilder);
            var data = entity.ToBindDicDictionary();
            List<dynamic> secInfos = new List<dynamic>();
            sections.ForEach(e => {
                var dic = e.ToBindDicDictionary();
                var attachments = atts.Where(w => w.BID_SECTION_CODE == e.BID_SECTION_CODE).ToList();
                dic.Add("ATTACHMENTS", attachments);
                secInfos.Add(dic);
            });
            data.Add("RECORD_SECTION_INFOS", secInfos);
            data.Add("INSTANCE_ID", reviewInstance.FirstOrDefault()?.ID);
            data.Add("INSTANCE_END_ID", reviewInstance.Where(w => w.IS_END == 1).FirstOrDefault()?.ID);
            data.Add("ATTACHMENTS", atts.Where(w=>String.IsNullOrWhiteSpace(w.BID_SECTION_CODE)));
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
        public GeneralResult SaveOrSubmit(TENDER_PROJECT tender_project, RECORD_REVIEW review, 
            RECORD_BIDDING_WRITE biddoc,List<RECORD_SECTION_INFO> sections,
            List<UploadResData_ReviewRequest> attachments)
        {
            var r = new GeneralResult();
            if (review.REVIEW_TYPE == "MT104" || review.REVIEW_TYPE == "MZ104")
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
                    review.ID = Jd.RecordReviewService.CreateOrUpdate(tran, review, now,
                        tender_project.TENDER_PROJECT_TYPE,
                        attachments,
                        sections.Select(t => t.BID_SECTION_CODE).ToList()
                        );
                    
                    if (!isUpdate)
                    {
                        biddoc.RECORD_ID = review.ID;
                        biddoc.ID = 0;
                        biddoc.CREATE_TM = now;
                        biddoc.CREATOR = JdUser?.ID;
                        tran.Insert<RECORD_BIDDING_WRITE>(biddoc);

                        sections.ForEach(e => {
                            e.RECORD_ID = review.ID;
                            e.ID = 0;
                            tran.Insert<RECORD_SECTION_INFO>(e);
                        });
                    }
                    else
                    {
                        biddoc.AttachAll();
                        tran.Update<RECORD_BIDDING_WRITE>(biddoc);
                        sections.ForEach(e => {
                            e.RECORD_ID = biddoc.RECORD_ID;
                            tran.Update<RECORD_SECTION_INFO>(e);
                        });                        
                    }

                    var data = new
                    {
                        RECORD_REVIEW = review,
                        RECORD_BIDDING_WRITE = biddoc,
                        RECORD_ATTACHMENT = attachments,
                        RECORD_SECTION_INFOS = sections
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
                    var requestid = Guid.NewGuid().ToString();
                    LoggerR.Error("logid:" + requestid + ",招标投标情况书面报告备案提交失败:" + ex.Message
                        + Logger.GetRequestMessage(HttpContext.Current), ex);
                    r.SetException("招标投标情况书面报告备案提交失败:" + ex.Message + "logid:" + requestid, ex);
                    return r;
                }
            }
        }
    }
}