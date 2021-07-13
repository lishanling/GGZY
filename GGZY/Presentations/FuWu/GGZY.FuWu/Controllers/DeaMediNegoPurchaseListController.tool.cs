using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdDeaMediNegoPurchaseListController:BaseController
    {
        /// <summary>
        /// 读取DEA_MEDI_NEGO_PURCHASE_LIST列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadDeaMediNegoPurchaseLists(DEA_MEDI_NEGO_PURCHASE_LIST model, SearchCondition condition)
        {
            var result = Fw.DeaMediNegoPurchaseListService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取DEA_MEDI_NEGO_PURCHASE_LIST明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadDeaMediNegoPurchaseList(decimal M_ID)
        
        {
            var result = Fw.DeaMediNegoPurchaseListService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建DEA_MEDI_NEGO_PURCHASE_LIST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateDeaMediNegoPurchaseList(DEA_MEDI_NEGO_PURCHASE_LIST model)
        {
            var result = Fw.DeaMediNegoPurchaseListService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新DEA_MEDI_NEGO_PURCHASE_LIST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateDeaMediNegoPurchaseList(DEA_MEDI_NEGO_PURCHASE_LIST model)
        {
            var result = Fw.DeaMediNegoPurchaseListService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除DEA_MEDI_NEGO_PURCHASE_LIST信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteDeaMediNegoPurchaseList(string ids)
        {
            var result = Fw.DeaMediNegoPurchaseListService.Delete(ids);
            return JResult(result); 
        }
    }
}