using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdProductComponentDataController:BaseController
    {
        /// <summary>
        /// 读取PRODUCT_COMPONENT_DATA列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadProductComponentDatas(PRODUCT_COMPONENT_DATA model, SearchCondition condition)
        {
            var result = Fw.ProductComponentDataService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PRODUCT_COMPONENT_DATA明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadProductComponentData(decimal ID)
        
        {
            var result = Fw.ProductComponentDataService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PRODUCT_COMPONENT_DATA信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateProductComponentData(PRODUCT_COMPONENT_DATA model)
        {
            var result = Fw.ProductComponentDataService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PRODUCT_COMPONENT_DATA信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateProductComponentData(PRODUCT_COMPONENT_DATA model)
        {
            var result = Fw.ProductComponentDataService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PRODUCT_COMPONENT_DATA信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteProductComponentData(string ids)
        {
            var result = Fw.ProductComponentDataService.Delete(ids);
            return JResult(result); 
        }
    }
}