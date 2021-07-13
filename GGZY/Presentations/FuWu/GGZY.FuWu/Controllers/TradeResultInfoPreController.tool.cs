using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTradeResultInfoPreController:BaseController
    {
        /// <summary>
        /// 读取TRADE_RESULT_INFO_PRE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTradeResultInfoPres(TRADE_RESULT_INFO_PRE model, SearchCondition condition)
        {
            var result = Fw.TradeResultInfoPreService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TRADE_RESULT_INFO_PRE明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTradeResultInfoPre(decimal M_ID)
        
        {
            var result = Fw.TradeResultInfoPreService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TRADE_RESULT_INFO_PRE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTradeResultInfoPre(TRADE_RESULT_INFO_PRE model)
        {
            var result = Fw.TradeResultInfoPreService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TRADE_RESULT_INFO_PRE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTradeResultInfoPre(TRADE_RESULT_INFO_PRE model)
        {
            var result = Fw.TradeResultInfoPreService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TRADE_RESULT_INFO_PRE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTradeResultInfoPre(string ids)
        {
            var result = Fw.TradeResultInfoPreService.Delete(ids);
            return JResult(result); 
        }
    }
}