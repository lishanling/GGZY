using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdStockTradeResultPreController:BaseController
    {
        /// <summary>
        /// 读取STOCK_TRADE_RESULT_PRE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadStockTradeResultPres(STOCK_TRADE_RESULT_PRE model, SearchCondition condition)
        {
            var result = Fw.StockTradeResultPreService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取STOCK_TRADE_RESULT_PRE明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadStockTradeResultPre(decimal M_ID)
        
        {
            var result = Fw.StockTradeResultPreService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建STOCK_TRADE_RESULT_PRE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateStockTradeResultPre(STOCK_TRADE_RESULT_PRE model)
        {
            var result = Fw.StockTradeResultPreService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新STOCK_TRADE_RESULT_PRE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateStockTradeResultPre(STOCK_TRADE_RESULT_PRE model)
        {
            var result = Fw.StockTradeResultPreService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除STOCK_TRADE_RESULT_PRE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteStockTradeResultPre(string ids)
        {
            var result = Fw.StockTradeResultPreService.Delete(ids);
            return JResult(result); 
        }
    }
}