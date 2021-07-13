using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdPurchaseProjectController:BaseController
    {
        /// <summary>
        /// 读取PURCHASE_PROJECT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadPurchaseProjects(PURCHASE_PROJECT model, SearchCondition condition)
        {
            var result = Fw.PurchaseProjectService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PURCHASE_PROJECT明细
        /// </summary>
      /// <param name="M_ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadPurchaseProject(decimal M_ID)
        
        {
            var result = Fw.PurchaseProjectService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PURCHASE_PROJECT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreatePurchaseProject(PURCHASE_PROJECT model)
        {
            var result = Fw.PurchaseProjectService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PURCHASE_PROJECT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdatePurchaseProject(PURCHASE_PROJECT model)
        {
            var result = Fw.PurchaseProjectService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PURCHASE_PROJECT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeletePurchaseProject(string ids)
        {
            var result = Fw.PurchaseProjectService.Delete(ids);
            return JResult(result); 
        }
    }
}