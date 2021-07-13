using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdProjectPerformanceController:BaseController
    {
        /// <summary>
        /// 读取PROJECT_PERFORMANCE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadProjectPerformances(PROJECT_PERFORMANCE model, SearchCondition condition)
        {
            var result = Fw.ProjectPerformanceService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PROJECT_PERFORMANCE明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadProjectPerformance(decimal ID)
        
        {
            var result = Fw.ProjectPerformanceService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PROJECT_PERFORMANCE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateProjectPerformance(PROJECT_PERFORMANCE model)
        {
            var result = Fw.ProjectPerformanceService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PROJECT_PERFORMANCE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateProjectPerformance(PROJECT_PERFORMANCE model)
        {
            var result = Fw.ProjectPerformanceService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PROJECT_PERFORMANCE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteProjectPerformance(string ids)
        {
            var result = Fw.ProjectPerformanceService.Delete(ids);
            return JResult(result); 
        }
    }
}