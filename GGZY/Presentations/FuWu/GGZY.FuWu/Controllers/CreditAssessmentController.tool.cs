using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdCreditAssessmentController:BaseController
    {
        /// <summary>
        /// 读取CREDIT_ASSESSMENT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadCreditAssessments(CREDIT_ASSESSMENT model, SearchCondition condition)
        {
            var result = Fw.CreditAssessmentService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取CREDIT_ASSESSMENT明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadCreditAssessment(decimal ID)
        
        {
            var result = Fw.CreditAssessmentService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建CREDIT_ASSESSMENT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateCreditAssessment(CREDIT_ASSESSMENT model)
        {
            var result = Fw.CreditAssessmentService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新CREDIT_ASSESSMENT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateCreditAssessment(CREDIT_ASSESSMENT model)
        {
            var result = Fw.CreditAssessmentService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除CREDIT_ASSESSMENT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteCreditAssessment(string ids)
        {
            var result = Fw.CreditAssessmentService.Delete(ids);
            return JResult(result); 
        }
    }
}