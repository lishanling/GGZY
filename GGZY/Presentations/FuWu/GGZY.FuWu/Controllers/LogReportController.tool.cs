using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdLogReportController:BaseController
    {
        /// <summary>
        /// 读取LOG_REPORT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadLogReports(LOG_REPORT model, SearchCondition condition)
        {
            var result = Fw.LogReportService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取LOG_REPORT明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadLogReport(decimal ID)
        
        {
            var result = Fw.LogReportService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建LOG_REPORT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateLogReport(LOG_REPORT model)
        {
            var result = Fw.LogReportService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新LOG_REPORT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateLogReport(LOG_REPORT model)
        {
            var result = Fw.LogReportService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除LOG_REPORT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteLogReport(string ids)
        {
            var result = Fw.LogReportService.Delete(ids);
            return JResult(result); 
        }
    }
}