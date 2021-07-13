using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTradeResultInfoController:BaseController
    {
        /// <summary>
        /// 读取TRADE_RESULT_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTradeResultInfos(TRADE_RESULT_INFO model, SearchCondition condition)
        {
            var result = Fw.TradeResultInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TRADE_RESULT_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTradeResultInfo(decimal M_ID)
        
        {
            var result = Fw.TradeResultInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TRADE_RESULT_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTradeResultInfo(TRADE_RESULT_INFO model)
        {
            var result = Fw.TradeResultInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TRADE_RESULT_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTradeResultInfo(TRADE_RESULT_INFO model)
        {
            var result = Fw.TradeResultInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TRADE_RESULT_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTradeResultInfo(string ids)
        {
            var result = Fw.TradeResultInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}