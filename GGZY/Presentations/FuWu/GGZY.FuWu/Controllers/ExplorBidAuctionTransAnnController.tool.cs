using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdExplorBidAuctionTransAnnController:BaseController
    {
        /// <summary>
        /// 读取EXPLOR_BID_AUCTION_TRANS_ANN列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadExplorBidAuctionTransAnns(EXPLOR_BID_AUCTION_TRANS_ANN model, SearchCondition condition)
        {
            var result = Fw.ExplorBidAuctionTransAnnService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取EXPLOR_BID_AUCTION_TRANS_ANN明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadExplorBidAuctionTransAnn(decimal M_ID)
        
        {
            var result = Fw.ExplorBidAuctionTransAnnService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建EXPLOR_BID_AUCTION_TRANS_ANN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateExplorBidAuctionTransAnn(EXPLOR_BID_AUCTION_TRANS_ANN model)
        {
            var result = Fw.ExplorBidAuctionTransAnnService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新EXPLOR_BID_AUCTION_TRANS_ANN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateExplorBidAuctionTransAnn(EXPLOR_BID_AUCTION_TRANS_ANN model)
        {
            var result = Fw.ExplorBidAuctionTransAnnService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除EXPLOR_BID_AUCTION_TRANS_ANN信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteExplorBidAuctionTransAnn(string ids)
        {
            var result = Fw.ExplorBidAuctionTransAnnService.Delete(ids);
            return JResult(result); 
        }
    }
}