using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdProductEqpController:BaseController
    {
        /// <summary>
        /// 读取PRODUCT_EQP列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadProductEqps(PRODUCT_EQP model, SearchCondition condition)
        {
            var result = Fw.ProductEqpService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PRODUCT_EQP明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadProductEqp(decimal ID)
        
        {
            var result = Fw.ProductEqpService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PRODUCT_EQP信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateProductEqp(PRODUCT_EQP model)
        {
            var result = Fw.ProductEqpService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PRODUCT_EQP信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateProductEqp(PRODUCT_EQP model)
        {
            var result = Fw.ProductEqpService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PRODUCT_EQP信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteProductEqp(string ids)
        {
            var result = Fw.ProductEqpService.Delete(ids);
            return JResult(result); 
        }
    }
}