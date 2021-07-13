using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTBaseTradeCenterController:BaseController
    {
        /// <summary>
        /// 读取T_BASE_TRADE_CENTER列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTBaseTradeCenters(T_BASE_TRADE_CENTER model, SearchCondition condition)
        {
            var result = Fw.TBaseTradeCenterService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_BASE_TRADE_CENTER明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTBaseTradeCenter(decimal ID)
        
        {
            var result = Fw.TBaseTradeCenterService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_BASE_TRADE_CENTER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTBaseTradeCenter(T_BASE_TRADE_CENTER model)
        {
            var result = Fw.TBaseTradeCenterService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_BASE_TRADE_CENTER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTBaseTradeCenter(T_BASE_TRADE_CENTER model)
        {
            var result = Fw.TBaseTradeCenterService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_BASE_TRADE_CENTER信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTBaseTradeCenter(string ids)
        {
            var result = Fw.TBaseTradeCenterService.Delete(ids);
            return JResult(result); 
        }
    }
}