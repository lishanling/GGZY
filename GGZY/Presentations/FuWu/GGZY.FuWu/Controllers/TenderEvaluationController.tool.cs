using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTenderEvaluationController:BaseController
    {
        /// <summary>
        /// 读取TENDER_EVALUATION列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTenderEvaluations(TENDER_EVALUATION model, SearchCondition condition)
        {
            var result = Fw.TenderEvaluationService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TENDER_EVALUATION明细
        /// </summary>
      /// <param name="M_ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTenderEvaluation(decimal M_ID)
        
        {
            var result = Fw.TenderEvaluationService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TENDER_EVALUATION信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTenderEvaluation(TENDER_EVALUATION model)
        {
            var result = Fw.TenderEvaluationService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TENDER_EVALUATION信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTenderEvaluation(TENDER_EVALUATION model)
        {
            var result = Fw.TenderEvaluationService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TENDER_EVALUATION信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTenderEvaluation(string ids)
        {
            var result = Fw.TenderEvaluationService.Delete(ids);
            return JResult(result); 
        }
    }
}