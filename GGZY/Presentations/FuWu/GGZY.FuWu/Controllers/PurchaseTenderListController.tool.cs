using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdPurchaseTenderListController:BaseController
    {
        /// <summary>
        /// 读取PURCHASE_TENDER_LIST列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadPurchaseTenderLists(PURCHASE_TENDER_LIST model, SearchCondition condition)
        {
            var result = Fw.PurchaseTenderListService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PURCHASE_TENDER_LIST明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadPurchaseTenderList(decimal M_ID)
        
        {
            var result = Fw.PurchaseTenderListService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PURCHASE_TENDER_LIST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreatePurchaseTenderList(PURCHASE_TENDER_LIST model)
        {
            var result = Fw.PurchaseTenderListService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PURCHASE_TENDER_LIST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdatePurchaseTenderList(PURCHASE_TENDER_LIST model)
        {
            var result = Fw.PurchaseTenderListService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PURCHASE_TENDER_LIST信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeletePurchaseTenderList(string ids)
        {
            var result = Fw.PurchaseTenderListService.Delete(ids);
            return JResult(result); 
        }
    }
}