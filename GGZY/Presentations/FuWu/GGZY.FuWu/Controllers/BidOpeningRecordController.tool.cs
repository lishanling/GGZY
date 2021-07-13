using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdBidOpeningRecordController:BaseController
    {
        /// <summary>
        /// 读取BID_OPENING_RECORD列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadBidOpeningRecords(BID_OPENING_RECORD model, SearchCondition condition)
        {
            var result = Fw.BidOpeningRecordService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取BID_OPENING_RECORD明细
        /// </summary>
      /// <param name="M_ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadBidOpeningRecord(decimal M_ID)
        
        {
            var result = Fw.BidOpeningRecordService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建BID_OPENING_RECORD信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateBidOpeningRecord(BID_OPENING_RECORD model)
        {
            var result = Fw.BidOpeningRecordService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新BID_OPENING_RECORD信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateBidOpeningRecord(BID_OPENING_RECORD model)
        {
            var result = Fw.BidOpeningRecordService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除BID_OPENING_RECORD信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteBidOpeningRecord(string ids)
        {
            var result = Fw.BidOpeningRecordService.Delete(ids);
            return JResult(result); 
        }
    }
}