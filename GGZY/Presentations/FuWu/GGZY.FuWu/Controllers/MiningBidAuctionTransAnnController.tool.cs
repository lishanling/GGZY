using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdMiningBidAuctionTransAnnController:BaseController
    {
        /// <summary>
        /// 读取MINING_BID_AUCTION_TRANS_ANN列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadMiningBidAuctionTransAnns(MINING_BID_AUCTION_TRANS_ANN model, SearchCondition condition)
        {
            var result = Fw.MiningBidAuctionTransAnnService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取MINING_BID_AUCTION_TRANS_ANN明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadMiningBidAuctionTransAnn(decimal M_ID)
        
        {
            var result = Fw.MiningBidAuctionTransAnnService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建MINING_BID_AUCTION_TRANS_ANN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateMiningBidAuctionTransAnn(MINING_BID_AUCTION_TRANS_ANN model)
        {
            var result = Fw.MiningBidAuctionTransAnnService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新MINING_BID_AUCTION_TRANS_ANN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateMiningBidAuctionTransAnn(MINING_BID_AUCTION_TRANS_ANN model)
        {
            var result = Fw.MiningBidAuctionTransAnnService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除MINING_BID_AUCTION_TRANS_ANN信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteMiningBidAuctionTransAnn(string ids)
        {
            var result = Fw.MiningBidAuctionTransAnnService.Delete(ids);
            return JResult(result); 
        }
    }
}