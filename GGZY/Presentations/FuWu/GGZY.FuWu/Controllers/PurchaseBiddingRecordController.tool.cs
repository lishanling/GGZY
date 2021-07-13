using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdPurchaseBiddingRecordController:BaseController
    {
        /// <summary>
        /// 读取PURCHASE_BIDDING_RECORD列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadPurchaseBiddingRecords(PURCHASE_BIDDING_RECORD model, SearchCondition condition)
        {
            var result = Fw.PurchaseBiddingRecordService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PURCHASE_BIDDING_RECORD明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadPurchaseBiddingRecord(decimal M_ID)
        
        {
            var result = Fw.PurchaseBiddingRecordService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PURCHASE_BIDDING_RECORD信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreatePurchaseBiddingRecord(PURCHASE_BIDDING_RECORD model)
        {
            var result = Fw.PurchaseBiddingRecordService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PURCHASE_BIDDING_RECORD信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdatePurchaseBiddingRecord(PURCHASE_BIDDING_RECORD model)
        {
            var result = Fw.PurchaseBiddingRecordService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PURCHASE_BIDDING_RECORD信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeletePurchaseBiddingRecord(string ids)
        {
            var result = Fw.PurchaseBiddingRecordService.Delete(ids);
            return JResult(result); 
        }
    }
}