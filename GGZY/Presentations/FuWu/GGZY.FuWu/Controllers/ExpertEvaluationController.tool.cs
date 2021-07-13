using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdExpertEvaluationController:BaseController
    {
        /// <summary>
        /// 读取EXPERT_EVALUATION列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadExpertEvaluations(EXPERT_EVALUATION model, SearchCondition condition)
        {
            var result = Fw.ExpertEvaluationService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取EXPERT_EVALUATION明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadExpertEvaluation(decimal M_ID)
        
        {
            var result = Fw.ExpertEvaluationService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建EXPERT_EVALUATION信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateExpertEvaluation(EXPERT_EVALUATION model)
        {
            var result = Fw.ExpertEvaluationService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新EXPERT_EVALUATION信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateExpertEvaluation(EXPERT_EVALUATION model)
        {
            var result = Fw.ExpertEvaluationService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除EXPERT_EVALUATION信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteExpertEvaluation(string ids)
        {
            var result = Fw.ExpertEvaluationService.Delete(ids);
            return JResult(result); 
        }
    }
}