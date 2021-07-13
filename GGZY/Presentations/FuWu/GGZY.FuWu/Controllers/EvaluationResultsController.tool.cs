using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdEvaluationResultsController:BaseController
    {
        /// <summary>
        /// 读取EVALUATION_RESULTS列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadEvaluationResultss(EVALUATION_RESULTS model, SearchCondition condition)
        {
            var result = Fw.EvaluationResultsService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取EVALUATION_RESULTS明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadEvaluationResults(decimal ID)
        
        {
            var result = Fw.EvaluationResultsService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建EVALUATION_RESULTS信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateEvaluationResults(EVALUATION_RESULTS model)
        {
            var result = Fw.EvaluationResultsService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新EVALUATION_RESULTS信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateEvaluationResults(EVALUATION_RESULTS model)
        {
            var result = Fw.EvaluationResultsService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除EVALUATION_RESULTS信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteEvaluationResults(string ids)
        {
            var result = Fw.EvaluationResultsService.Delete(ids);
            return JResult(result); 
        }
    }
}