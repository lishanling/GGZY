using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdProductDataController:BaseController
    {
        /// <summary>
        /// 读取PRODUCT_DATA列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadProductDatas(PRODUCT_DATA model, SearchCondition condition)
        {
            var result = Fw.ProductDataService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PRODUCT_DATA明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadProductData(decimal ID)
        
        {
            var result = Fw.ProductDataService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PRODUCT_DATA信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateProductData(PRODUCT_DATA model)
        {
            var result = Fw.ProductDataService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PRODUCT_DATA信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateProductData(PRODUCT_DATA model)
        {
            var result = Fw.ProductDataService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PRODUCT_DATA信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteProductData(string ids)
        {
            var result = Fw.ProductDataService.Delete(ids);
            return JResult(result); 
        }
    }
}