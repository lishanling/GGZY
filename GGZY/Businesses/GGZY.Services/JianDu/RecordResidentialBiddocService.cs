using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using Dos.ORM;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Extensions;
using GGZYJD.DbEntity;
using TzCodeService;

namespace GGZY.Services.JianDu
{
    /// <summary>
    /// 澄清修改备案-住建
    /// </summary>
    public partial class RecordResidentialBiddocService 
    {
        /// <summary>
        /// 澄清修改备案记录
        /// </summary>
        /// <param name="record_id">备案记录ID</param>
        /// <returns></returns>
        public GeneralResult Detail(int record_id,Func<string,string> urlBuilder)
        {
            var r = new GeneralResult();
            r.SetSuccess();

            var condition = new WhereClipBuilder();
            condition.And(RECORD_RESIDENTIAL_BIDDOC._.RECORD_ID == record_id);
            var entity = FirstOrNull(condition);
            var data = new Dictionary<string, object>();
           
            var conditionInstance = new WhereClipBuilder();
            conditionInstance.And(REVIEW_INSTANCE._.BA_ID == record_id);

            var reviewInstance = Jd.ReviewInstanceService.FindList(conditionInstance, REVIEW_INSTANCE._.ID.Desc).ToList();
            var atts = Jd.RecordReviewService.GetReviewAttachment(record_id, urlBuilder);
            
            data = null == entity ? data : entity.ToBindDicDictionary();
            data.Add("INSTANCE_END_ID", reviewInstance.Where(w => w.IS_END == 1).FirstOrDefault()?.ID);
            data.Add("INSTANCE_ID", reviewInstance.FirstOrDefault()?.ID);
            data.Add("ATTACHMENTS1", atts.Where(w=>w.CATEGORY == 1).ToList());
            data.Add("ATTACHMENTS", atts.Where(w=>w.CATEGORY == 2).ToList());
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
        public GeneralResult SaveOrSubmit(TENDER_PROJECT tender_project, RECORD_REVIEW review, RECORD_RESIDENTIAL_BIDDOC biddoc, List<UploadResData_ReviewRequest> attachments)
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
                        tran.Insert<RECORD_RESIDENTIAL_BIDDOC>(biddoc);
                    }
                    else
                    {
                        var condtion = new WhereClipBuilder();
                        condtion.And(RECORD_RESIDENTIAL_BIDDOC._.RECORD_ID == review.ID);
                        var model = FirstOrNull<RECORD_RESIDENTIAL_BIDDOC>(condtion.ToWhereClip()) ;
                        if (null == model)
                        {
                            tran.Rollback();
                            r.SetFail("招标文件备案 RECORD_RESIDENTIAL_BIDDOC 记录不存在.");
                            return r;
                        }
                        model.Attach();
                        if (review.REVIEW_STATUS == "0" || review.REVIEW_STATUS == "1" || review.REVIEW_STATUS =="8" || review.REVIEW_STATUS == "4")
                        {
                            model.Update(biddoc);
                        }
                        tran.Update<RECORD_RESIDENTIAL_BIDDOC>(model);
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
                    LoggerR.Error("招标文件备案 提交失败:" + ex.Message, ex);
                    r.SetException("招标文件备案 提交失败:" + ex.Message, ex);
                    return r;
                }
            }
        }
    }
}