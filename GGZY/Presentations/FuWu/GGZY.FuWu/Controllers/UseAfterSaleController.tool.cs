using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdUseAfterSaleController:BaseController
    {
        /// <summary>
        /// 读取USE_AFTER_SALE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadUseAfterSales(USE_AFTER_SALE model, SearchCondition condition)
        {
            var result = Fw.UseAfterSaleService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取USE_AFTER_SALE明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadUseAfterSale(decimal ID)
        
        {
            var result = Fw.UseAfterSaleService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建USE_AFTER_SALE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateUseAfterSale(USE_AFTER_SALE model)
        {
            var result = Fw.UseAfterSaleService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新USE_AFTER_SALE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateUseAfterSale(USE_AFTER_SALE model)
        {
            var result = Fw.UseAfterSaleService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除USE_AFTER_SALE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteUseAfterSale(string ids)
        {
            var result = Fw.UseAfterSaleService.Delete(ids);
            return JResult(result); 
        }
    }
}