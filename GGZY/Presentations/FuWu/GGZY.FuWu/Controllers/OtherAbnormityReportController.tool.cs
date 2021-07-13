using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdOtherAbnormityReportController:BaseController
    {
        /// <summary>
        /// 读取OTHER_ABNORMITY_REPORT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadOtherAbnormityReports(OTHER_ABNORMITY_REPORT model, SearchCondition condition)
        {
            var result = Fw.OtherAbnormityReportService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取OTHER_ABNORMITY_REPORT明细
        /// </summary>
      /// <param name="M_ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadOtherAbnormityReport(decimal M_ID)
        
        {
            var result = Fw.OtherAbnormityReportService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建OTHER_ABNORMITY_REPORT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateOtherAbnormityReport(OTHER_ABNORMITY_REPORT model)
        {
            var result = Fw.OtherAbnormityReportService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新OTHER_ABNORMITY_REPORT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateOtherAbnormityReport(OTHER_ABNORMITY_REPORT model)
        {
            var result = Fw.OtherAbnormityReportService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除OTHER_ABNORMITY_REPORT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteOtherAbnormityReport(string ids)
        {
            var result = Fw.OtherAbnormityReportService.Delete(ids);
            return JResult(result); 
        }
    }
}