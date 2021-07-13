using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdExpertBidEvaluationController:BaseController
    {
        /// <summary>
        /// 读取EXPERT_BID_EVALUATION列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadExpertBidEvaluations(EXPERT_BID_EVALUATION model, SearchCondition condition)
        {
            var result = Fw.ExpertBidEvaluationService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取EXPERT_BID_EVALUATION明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadExpertBidEvaluation(decimal M_ID)
        
        {
            var result = Fw.ExpertBidEvaluationService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建EXPERT_BID_EVALUATION信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateExpertBidEvaluation(EXPERT_BID_EVALUATION model)
        {
            var result = Fw.ExpertBidEvaluationService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新EXPERT_BID_EVALUATION信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateExpertBidEvaluation(EXPERT_BID_EVALUATION model)
        {
            var result = Fw.ExpertBidEvaluationService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除EXPERT_BID_EVALUATION信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteExpertBidEvaluation(string ids)
        {
            var result = Fw.ExpertBidEvaluationService.Delete(ids);
            return JResult(result); 
        }
    }
}