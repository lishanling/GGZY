using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdBidDealAnnounceController:BaseController
    {
        /// <summary>
        /// 读取BID_DEAL_ANNOUNCE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadBidDealAnnounces(BID_DEAL_ANNOUNCE model, SearchCondition condition)
        {
            var result = Fw.BidDealAnnounceService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取BID_DEAL_ANNOUNCE明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadBidDealAnnounce(decimal M_ID)
        
        {
            var result = Fw.BidDealAnnounceService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建BID_DEAL_ANNOUNCE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateBidDealAnnounce(BID_DEAL_ANNOUNCE model)
        {
            var result = Fw.BidDealAnnounceService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新BID_DEAL_ANNOUNCE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateBidDealAnnounce(BID_DEAL_ANNOUNCE model)
        {
            var result = Fw.BidDealAnnounceService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除BID_DEAL_ANNOUNCE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteBidDealAnnounce(string ids)
        {
            var result = Fw.BidDealAnnounceService.Delete(ids);
            return JResult(result); 
        }
    }
}