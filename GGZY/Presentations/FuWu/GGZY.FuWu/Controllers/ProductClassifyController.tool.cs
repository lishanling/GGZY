using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdProductClassifyController:BaseController
    {
        /// <summary>
        /// 读取PRODUCT_CLASSIFY列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadProductClassifys(PRODUCT_CLASSIFY model, SearchCondition condition)
        {
            var result = Fw.ProductClassifyService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PRODUCT_CLASSIFY明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadProductClassify(decimal ID)
        
        {
            var result = Fw.ProductClassifyService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PRODUCT_CLASSIFY信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateProductClassify(PRODUCT_CLASSIFY model)
        {
            var result = Fw.ProductClassifyService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PRODUCT_CLASSIFY信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateProductClassify(PRODUCT_CLASSIFY model)
        {
            var result = Fw.ProductClassifyService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PRODUCT_CLASSIFY信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteProductClassify(string ids)
        {
            var result = Fw.ProductClassifyService.Delete(ids);
            return JResult(result); 
        }
    }
}