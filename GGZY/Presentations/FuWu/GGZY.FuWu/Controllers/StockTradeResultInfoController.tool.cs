using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdStockTradeResultInfoController:BaseController
    {
        /// <summary>
        /// 读取STOCK_TRADE_RESULT_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadStockTradeResultInfos(STOCK_TRADE_RESULT_INFO model, SearchCondition condition)
        {
            var result = Fw.StockTradeResultInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取STOCK_TRADE_RESULT_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadStockTradeResultInfo(decimal M_ID)
        
        {
            var result = Fw.StockTradeResultInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建STOCK_TRADE_RESULT_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateStockTradeResultInfo(STOCK_TRADE_RESULT_INFO model)
        {
            var result = Fw.StockTradeResultInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新STOCK_TRADE_RESULT_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateStockTradeResultInfo(STOCK_TRADE_RESULT_INFO model)
        {
            var result = Fw.StockTradeResultInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除STOCK_TRADE_RESULT_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteStockTradeResultInfo(string ids)
        {
            var result = Fw.StockTradeResultInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}