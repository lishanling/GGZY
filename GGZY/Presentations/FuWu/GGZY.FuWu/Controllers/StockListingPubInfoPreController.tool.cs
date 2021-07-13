using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdStockListingPubInfoPreController:BaseController
    {
        /// <summary>
        /// 读取STOCK_LISTING_PUB_INFO_PRE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadStockListingPubInfoPres(STOCK_LISTING_PUB_INFO_PRE model, SearchCondition condition)
        {
            var result = Fw.StockListingPubInfoPreService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取STOCK_LISTING_PUB_INFO_PRE明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadStockListingPubInfoPre(decimal M_ID)
        
        {
            var result = Fw.StockListingPubInfoPreService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建STOCK_LISTING_PUB_INFO_PRE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateStockListingPubInfoPre(STOCK_LISTING_PUB_INFO_PRE model)
        {
            var result = Fw.StockListingPubInfoPreService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新STOCK_LISTING_PUB_INFO_PRE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateStockListingPubInfoPre(STOCK_LISTING_PUB_INFO_PRE model)
        {
            var result = Fw.StockListingPubInfoPreService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除STOCK_LISTING_PUB_INFO_PRE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteStockListingPubInfoPre(string ids)
        {
            var result = Fw.StockListingPubInfoPreService.Delete(ids);
            return JResult(result); 
        }
    }
}