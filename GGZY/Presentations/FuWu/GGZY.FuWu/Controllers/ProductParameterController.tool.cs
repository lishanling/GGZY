using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdProductParameterController:BaseController
    {
        /// <summary>
        /// 读取PRODUCT_PARAMETER列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadProductParameters(PRODUCT_PARAMETER model, SearchCondition condition)
        {
            var result = Fw.ProductParameterService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PRODUCT_PARAMETER明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadProductParameter(decimal ID)
        
        {
            var result = Fw.ProductParameterService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PRODUCT_PARAMETER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateProductParameter(PRODUCT_PARAMETER model)
        {
            var result = Fw.ProductParameterService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PRODUCT_PARAMETER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateProductParameter(PRODUCT_PARAMETER model)
        {
            var result = Fw.ProductParameterService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PRODUCT_PARAMETER信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteProductParameter(string ids)
        {
            var result = Fw.ProductParameterService.Delete(ids);
            return JResult(result); 
        }
    }
}