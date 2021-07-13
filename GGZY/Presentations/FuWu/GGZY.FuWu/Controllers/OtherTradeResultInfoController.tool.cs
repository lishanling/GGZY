using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdOtherTradeResultInfoController:BaseController
    {
        /// <summary>
        /// 读取OTHER_TRADE_RESULT_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadOtherTradeResultInfos(OTHER_TRADE_RESULT_INFO model, SearchCondition condition)
        {
            var result = Fw.OtherTradeResultInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取OTHER_TRADE_RESULT_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadOtherTradeResultInfo(decimal M_ID)
        
        {
            var result = Fw.OtherTradeResultInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建OTHER_TRADE_RESULT_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateOtherTradeResultInfo(OTHER_TRADE_RESULT_INFO model)
        {
            var result = Fw.OtherTradeResultInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新OTHER_TRADE_RESULT_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateOtherTradeResultInfo(OTHER_TRADE_RESULT_INFO model)
        {
            var result = Fw.OtherTradeResultInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除OTHER_TRADE_RESULT_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteOtherTradeResultInfo(string ids)
        {
            var result = Fw.OtherTradeResultInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}