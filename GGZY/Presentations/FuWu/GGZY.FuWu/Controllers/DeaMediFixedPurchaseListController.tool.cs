using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdDeaMediFixedPurchaseListController:BaseController
    {
        /// <summary>
        /// 读取DEA_MEDI_FIXED_PURCHASE_LIST列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadDeaMediFixedPurchaseLists(DEA_MEDI_FIXED_PURCHASE_LIST model, SearchCondition condition)
        {
            var result = Fw.DeaMediFixedPurchaseListService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取DEA_MEDI_FIXED_PURCHASE_LIST明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadDeaMediFixedPurchaseList(decimal M_ID)
        
        {
            var result = Fw.DeaMediFixedPurchaseListService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建DEA_MEDI_FIXED_PURCHASE_LIST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateDeaMediFixedPurchaseList(DEA_MEDI_FIXED_PURCHASE_LIST model)
        {
            var result = Fw.DeaMediFixedPurchaseListService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新DEA_MEDI_FIXED_PURCHASE_LIST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateDeaMediFixedPurchaseList(DEA_MEDI_FIXED_PURCHASE_LIST model)
        {
            var result = Fw.DeaMediFixedPurchaseListService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除DEA_MEDI_FIXED_PURCHASE_LIST信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteDeaMediFixedPurchaseList(string ids)
        {
            var result = Fw.DeaMediFixedPurchaseListService.Delete(ids);
            return JResult(result); 
        }
    }
}