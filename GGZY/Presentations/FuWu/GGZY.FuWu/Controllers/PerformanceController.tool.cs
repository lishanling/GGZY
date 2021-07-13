using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdPerformanceController:BaseController
    {
        /// <summary>
        /// 读取PERFORMANCE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadPerformances(PERFORMANCE model, SearchCondition condition)
        {
            var result = Fw.PerformanceService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PERFORMANCE明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadPerformance(decimal M_ID)
        
        {
            var result = Fw.PerformanceService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PERFORMANCE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreatePerformance(PERFORMANCE model)
        {
            var result = Fw.PerformanceService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PERFORMANCE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdatePerformance(PERFORMANCE model)
        {
            var result = Fw.PerformanceService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PERFORMANCE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeletePerformance(string ids)
        {
            var result = Fw.PerformanceService.Delete(ids);
            return JResult(result); 
        }
    }
}