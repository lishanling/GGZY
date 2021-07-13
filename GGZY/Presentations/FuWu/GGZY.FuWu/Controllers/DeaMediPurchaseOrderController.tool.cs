using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdDeaMediPurchaseOrderController:BaseController
    {
        /// <summary>
        /// 读取DEA_MEDI_PURCHASE_ORDER列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadDeaMediPurchaseOrders(DEA_MEDI_PURCHASE_ORDER model, SearchCondition condition)
        {
            var result = Fw.DeaMediPurchaseOrderService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取DEA_MEDI_PURCHASE_ORDER明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadDeaMediPurchaseOrder(decimal M_ID)
        
        {
            var result = Fw.DeaMediPurchaseOrderService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建DEA_MEDI_PURCHASE_ORDER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateDeaMediPurchaseOrder(DEA_MEDI_PURCHASE_ORDER model)
        {
            var result = Fw.DeaMediPurchaseOrderService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新DEA_MEDI_PURCHASE_ORDER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateDeaMediPurchaseOrder(DEA_MEDI_PURCHASE_ORDER model)
        {
            var result = Fw.DeaMediPurchaseOrderService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除DEA_MEDI_PURCHASE_ORDER信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteDeaMediPurchaseOrder(string ids)
        {
            var result = Fw.DeaMediPurchaseOrderService.Delete(ids);
            return JResult(result); 
        }
    }
}