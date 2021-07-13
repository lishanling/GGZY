using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdRecordBiddingWriteController:BaseController
    {
        /// <summary>
        /// 读取RECORD_BIDDING_WRITE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadRecordBiddingWrites(RECORD_BIDDING_WRITE model, SearchCondition condition)
        {
            var result = Jd.RecordBiddingWriteService.PageList(model, condition).ToPageTableResult(condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取RECORD_BIDDING_WRITE明细
        /// </summary>
      /// <param name="RECORD_ID">备案主表ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadRecordBiddingWrite(decimal RECORD_ID)
        
        {
            var result = Jd.RecordBiddingWriteService.ViewByPk(RECORD_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建RECORD_BIDDING_WRITE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateRecordBiddingWrite(RECORD_BIDDING_WRITE model)
        {
            var result = Jd.RecordBiddingWriteService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新RECORD_BIDDING_WRITE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateRecordBiddingWrite(RECORD_BIDDING_WRITE model)
        {
            var result = Jd.RecordBiddingWriteService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除RECORD_BIDDING_WRITE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteRecordBiddingWrite(string ids)
        {
            var result = Jd.RecordBiddingWriteService.Delete(ids);
            return JResult(result); 
        }
    }
}