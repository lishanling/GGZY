using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdProductAnalysisController:BaseController
    {
        /// <summary>
        /// 读取PRODUCT_ANALYSIS列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadProductAnalysiss(PRODUCT_ANALYSIS model, SearchCondition condition)
        {
            var result = Fw.ProductAnalysisService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PRODUCT_ANALYSIS明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadProductAnalysis(decimal ID)
        
        {
            var result = Fw.ProductAnalysisService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PRODUCT_ANALYSIS信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateProductAnalysis(PRODUCT_ANALYSIS model)
        {
            var result = Fw.ProductAnalysisService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PRODUCT_ANALYSIS信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateProductAnalysis(PRODUCT_ANALYSIS model)
        {
            var result = Fw.ProductAnalysisService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PRODUCT_ANALYSIS信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteProductAnalysis(string ids)
        {
            var result = Fw.ProductAnalysisService.Delete(ids);
            return JResult(result); 
        }
    }
}