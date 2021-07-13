using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTUserTradeplatformController:BaseController
    {
        /// <summary>
        /// 读取T_USER_TRADEPLATFORM列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTUserTradeplatforms(T_USER_TRADEPLATFORM model, SearchCondition condition)
        {
            var result = Fw.TUserTradeplatformService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_USER_TRADEPLATFORM明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTUserTradeplatform(decimal ID)
        
        {
            var result = Fw.TUserTradeplatformService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_USER_TRADEPLATFORM信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTUserTradeplatform(T_USER_TRADEPLATFORM model)
        {
            var result = Fw.TUserTradeplatformService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_USER_TRADEPLATFORM信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTUserTradeplatform(T_USER_TRADEPLATFORM model)
        {
            var result = Fw.TUserTradeplatformService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_USER_TRADEPLATFORM信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTUserTradeplatform(string ids)
        {
            var result = Fw.TUserTradeplatformService.Delete(ids);
            return JResult(result); 
        }
    }
}