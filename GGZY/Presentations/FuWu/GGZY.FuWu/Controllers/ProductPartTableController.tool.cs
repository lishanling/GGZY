using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdProductPartTableController:BaseController
    {
        /// <summary>
        /// 读取PRODUCT_PART_TABLE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadProductPartTables(PRODUCT_PART_TABLE model, SearchCondition condition)
        {
            var result = Fw.ProductPartTableService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PRODUCT_PART_TABLE明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadProductPartTable(decimal ID)
        
        {
            var result = Fw.ProductPartTableService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PRODUCT_PART_TABLE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateProductPartTable(PRODUCT_PART_TABLE model)
        {
            var result = Fw.ProductPartTableService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PRODUCT_PART_TABLE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateProductPartTable(PRODUCT_PART_TABLE model)
        {
            var result = Fw.ProductPartTableService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PRODUCT_PART_TABLE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteProductPartTable(string ids)
        {
            var result = Fw.ProductPartTableService.Delete(ids);
            return JResult(result); 
        }
    }
}