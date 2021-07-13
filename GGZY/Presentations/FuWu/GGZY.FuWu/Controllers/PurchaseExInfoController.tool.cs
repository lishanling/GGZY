using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdPurchaseExInfoController:BaseController
    {
        /// <summary>
        /// 读取PURCHASE_EX_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadPurchaseExInfos(PURCHASE_EX_INFO model, SearchCondition condition)
        {
            var result = Fw.PurchaseExInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PURCHASE_EX_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadPurchaseExInfo(decimal M_ID)
        
        {
            var result = Fw.PurchaseExInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PURCHASE_EX_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreatePurchaseExInfo(PURCHASE_EX_INFO model)
        {
            var result = Fw.PurchaseExInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PURCHASE_EX_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdatePurchaseExInfo(PURCHASE_EX_INFO model)
        {
            var result = Fw.PurchaseExInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PURCHASE_EX_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeletePurchaseExInfo(string ids)
        {
            var result = Fw.PurchaseExInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}