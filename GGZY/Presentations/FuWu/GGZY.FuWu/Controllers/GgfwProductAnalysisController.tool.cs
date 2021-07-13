using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdGgfwProductAnalysisController:BaseController
    {
        /// <summary>
        /// 读取GGFW_PRODUCT_ANALYSIS列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadGgfwProductAnalysiss(GGFW_PRODUCT_ANALYSIS model, SearchCondition condition)
        {
            var result = Fw.GgfwProductAnalysisService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取GGFW_PRODUCT_ANALYSIS明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadGgfwProductAnalysis(decimal ID)
        
        {
            var result = Fw.GgfwProductAnalysisService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建GGFW_PRODUCT_ANALYSIS信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateGgfwProductAnalysis(GGFW_PRODUCT_ANALYSIS model)
        {
            var result = Fw.GgfwProductAnalysisService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新GGFW_PRODUCT_ANALYSIS信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateGgfwProductAnalysis(GGFW_PRODUCT_ANALYSIS model)
        {
            var result = Fw.GgfwProductAnalysisService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除GGFW_PRODUCT_ANALYSIS信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteGgfwProductAnalysis(string ids)
        {
            var result = Fw.GgfwProductAnalysisService.Delete(ids);
            return JResult(result); 
        }
    }
}