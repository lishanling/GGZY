using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTenderAbnormityReportController:BaseController
    {
        /// <summary>
        /// 读取TENDER_ABNORMITY_REPORT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTenderAbnormityReports(TENDER_ABNORMITY_REPORT model, SearchCondition condition)
        {
            var result = Fw.TenderAbnormityReportService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TENDER_ABNORMITY_REPORT明细
        /// </summary>
      /// <param name="M_ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTenderAbnormityReport(decimal M_ID)
        
        {
            var result = Fw.TenderAbnormityReportService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TENDER_ABNORMITY_REPORT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTenderAbnormityReport(TENDER_ABNORMITY_REPORT model)
        {
            var result = Fw.TenderAbnormityReportService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TENDER_ABNORMITY_REPORT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTenderAbnormityReport(TENDER_ABNORMITY_REPORT model)
        {
            var result = Fw.TenderAbnormityReportService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TENDER_ABNORMITY_REPORT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTenderAbnormityReport(string ids)
        {
            var result = Fw.TenderAbnormityReportService.Delete(ids);
            return JResult(result); 
        }
    }
}