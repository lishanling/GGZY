using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdDeaMediNetPurchaseListController:BaseController
    {
        /// <summary>
        /// 读取DEA_MEDI_NET_PURCHASE_LIST列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadDeaMediNetPurchaseLists(DEA_MEDI_NET_PURCHASE_LIST model, SearchCondition condition)
        {
            var result = Fw.DeaMediNetPurchaseListService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取DEA_MEDI_NET_PURCHASE_LIST明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadDeaMediNetPurchaseList(decimal M_ID)
        
        {
            var result = Fw.DeaMediNetPurchaseListService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建DEA_MEDI_NET_PURCHASE_LIST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateDeaMediNetPurchaseList(DEA_MEDI_NET_PURCHASE_LIST model)
        {
            var result = Fw.DeaMediNetPurchaseListService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新DEA_MEDI_NET_PURCHASE_LIST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateDeaMediNetPurchaseList(DEA_MEDI_NET_PURCHASE_LIST model)
        {
            var result = Fw.DeaMediNetPurchaseListService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除DEA_MEDI_NET_PURCHASE_LIST信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteDeaMediNetPurchaseList(string ids)
        {
            var result = Fw.DeaMediNetPurchaseListService.Delete(ids);
            return JResult(result); 
        }
    }
}