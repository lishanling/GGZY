using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdProjectAlertingInfoController:BaseController
    {
        /// <summary>
        /// 读取PROJECT_ALERTING_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadProjectAlertingInfos(PROJECT_ALERTING_INFO model, SearchCondition condition)
        {
            var result = Fw.ProjectAlertingInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PROJECT_ALERTING_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadProjectAlertingInfo(decimal M_ID)
        
        {
            var result = Fw.ProjectAlertingInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PROJECT_ALERTING_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateProjectAlertingInfo(PROJECT_ALERTING_INFO model)
        {
            var result = Fw.ProjectAlertingInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PROJECT_ALERTING_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateProjectAlertingInfo(PROJECT_ALERTING_INFO model)
        {
            var result = Fw.ProjectAlertingInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PROJECT_ALERTING_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteProjectAlertingInfo(string ids)
        {
            var result = Fw.ProjectAlertingInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}