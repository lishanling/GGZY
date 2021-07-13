using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdPurchaseContractController:BaseController
    {
        /// <summary>
        /// 读取PURCHASE_CONTRACT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadPurchaseContracts(PURCHASE_CONTRACT model, SearchCondition condition)
        {
            var result = Fw.PurchaseContractService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PURCHASE_CONTRACT明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadPurchaseContract(decimal M_ID)
        
        {
            var result = Fw.PurchaseContractService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PURCHASE_CONTRACT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreatePurchaseContract(PURCHASE_CONTRACT model)
        {
            var result = Fw.PurchaseContractService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PURCHASE_CONTRACT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdatePurchaseContract(PURCHASE_CONTRACT model)
        {
            var result = Fw.PurchaseContractService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PURCHASE_CONTRACT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeletePurchaseContract(string ids)
        {
            var result = Fw.PurchaseContractService.Delete(ids);
            return JResult(result); 
        }
    }
}