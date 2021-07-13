using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdProductMaterialController:BaseController
    {
        /// <summary>
        /// 读取PRODUCT_MATERIAL列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadProductMaterials(PRODUCT_MATERIAL model, SearchCondition condition)
        {
            var result = Fw.ProductMaterialService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PRODUCT_MATERIAL明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadProductMaterial(decimal ID)
        
        {
            var result = Fw.ProductMaterialService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PRODUCT_MATERIAL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateProductMaterial(PRODUCT_MATERIAL model)
        {
            var result = Fw.ProductMaterialService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PRODUCT_MATERIAL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateProductMaterial(PRODUCT_MATERIAL model)
        {
            var result = Fw.ProductMaterialService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PRODUCT_MATERIAL信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteProductMaterial(string ids)
        {
            var result = Fw.ProductMaterialService.Delete(ids);
            return JResult(result); 
        }
    }
}