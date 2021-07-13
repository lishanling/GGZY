using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdRecordReviewController:BaseController
    {
        /// <summary>
        /// 读取RECORD_REVIEW列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadRecordReviews(RECORD_REVIEW model, SearchCondition condition)
        {
            var result = Jd.RecordReviewService.PageList(model, condition).ToPageTableResult(condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取RECORD_REVIEW明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadRecordReview(decimal ID)
        
        {
            var result = Jd.RecordReviewService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建RECORD_REVIEW信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateRecordReview(RECORD_REVIEW model)
        {
            var result = Jd.RecordReviewService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新RECORD_REVIEW信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateRecordReview(RECORD_REVIEW model)
        {
            var result = Jd.RecordReviewService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除RECORD_REVIEW信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteRecordReview(string ids)
        {
            var result = Jd.RecordReviewService.Delete(ids);
            return JResult(result); 
        }
    }
}