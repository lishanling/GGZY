using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTServiceLogController:BaseController
    {
        /// <summary>
        /// 读取T_SERVICE_LOG列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTServiceLogs(T_SERVICE_LOG model, SearchCondition condition)
        {
            var result = Fw.TServiceLogService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_SERVICE_LOG明细
        /// </summary>
      /// <param name="TM">时间</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTServiceLog(DateTime? TM)
        
        {
            var result = Fw.TServiceLogService.ViewByPk(TM);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_SERVICE_LOG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTServiceLog(T_SERVICE_LOG model)
        {
            var result = Fw.TServiceLogService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_SERVICE_LOG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTServiceLog(T_SERVICE_LOG model)
        {
            var result = Fw.TServiceLogService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_SERVICE_LOG信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTServiceLog(string ids)
        {
            var result = Fw.TServiceLogService.Delete(ids);
            return JResult(result); 
        }
    }
}