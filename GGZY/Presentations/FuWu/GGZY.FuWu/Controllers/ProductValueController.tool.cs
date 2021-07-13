using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdProductValueController:BaseController
    {
        /// <summary>
        /// 读取PRODUCT_VALUE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadProductValues(PRODUCT_VALUE model, SearchCondition condition)
        {
            var result = Fw.ProductValueService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PRODUCT_VALUE明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadProductValue(decimal ID)
        
        {
            var result = Fw.ProductValueService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PRODUCT_VALUE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateProductValue(PRODUCT_VALUE model)
        {
            var result = Fw.ProductValueService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PRODUCT_VALUE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateProductValue(PRODUCT_VALUE model)
        {
            var result = Fw.ProductValueService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PRODUCT_VALUE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteProductValue(string ids)
        {
            var result = Fw.ProductValueService.Delete(ids);
            return JResult(result); 
        }
    }
}