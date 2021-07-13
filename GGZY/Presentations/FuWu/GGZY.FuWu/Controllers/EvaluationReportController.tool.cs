using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdEvaluationReportController:BaseController
    {
        /// <summary>
        /// 读取EVALUATION_REPORT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadEvaluationReports(EVALUATION_REPORT model, SearchCondition condition)
        {
            var result = Fw.EvaluationReportService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取EVALUATION_REPORT明细
        /// </summary>
      /// <param name="M_ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadEvaluationReport(decimal M_ID)
        
        {
            var result = Fw.EvaluationReportService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建EVALUATION_REPORT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateEvaluationReport(EVALUATION_REPORT model)
        {
            var result = Fw.EvaluationReportService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新EVALUATION_REPORT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateEvaluationReport(EVALUATION_REPORT model)
        {
            var result = Fw.EvaluationReportService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除EVALUATION_REPORT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteEvaluationReport(string ids)
        {
            var result = Fw.EvaluationReportService.Delete(ids);
            return JResult(result); 
        }
    }
}