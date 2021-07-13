using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdStockListingPubInfoController:BaseController
    {
        /// <summary>
        /// 读取STOCK_LISTING_PUB_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadStockListingPubInfos(STOCK_LISTING_PUB_INFO model, SearchCondition condition)
        {
            var result = Fw.StockListingPubInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取STOCK_LISTING_PUB_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadStockListingPubInfo(decimal M_ID)
        
        {
            var result = Fw.StockListingPubInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建STOCK_LISTING_PUB_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateStockListingPubInfo(STOCK_LISTING_PUB_INFO model)
        {
            var result = Fw.StockListingPubInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新STOCK_LISTING_PUB_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateStockListingPubInfo(STOCK_LISTING_PUB_INFO model)
        {
            var result = Fw.StockListingPubInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除STOCK_LISTING_PUB_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteStockListingPubInfo(string ids)
        {
            var result = Fw.StockListingPubInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}