using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdSysLogController:BaseController
    {
        /// <summary>
        /// 读取SYS_LOG列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadSysLogs(SYS_LOG model, SearchCondition condition)
        {
            var result = Fw.SysLogService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取SYS_LOG明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadSysLog(decimal ID)
        
        {
            var result = Fw.SysLogService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建SYS_LOG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateSysLog(SYS_LOG model)
        {
            var result = Fw.SysLogService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新SYS_LOG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateSysLog(SYS_LOG model)
        {
            var result = Fw.SysLogService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除SYS_LOG信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteSysLog(string ids)
        {
            var result = Fw.SysLogService.Delete(ids);
            return JResult(result); 
        }
    }
}