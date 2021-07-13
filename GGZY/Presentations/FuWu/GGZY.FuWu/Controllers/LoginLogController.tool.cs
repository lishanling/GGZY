using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdLoginLogController:BaseController
    {
        /// <summary>
        /// 读取LOGIN_LOG列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadLoginLogs(LOGIN_LOG model, SearchCondition condition)
        {
            var result = Fw.LoginLogService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取LOGIN_LOG明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadLoginLog(decimal ID)
        
        {
            var result = Fw.LoginLogService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建LOGIN_LOG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateLoginLog(LOGIN_LOG model)
        {
            var result = Fw.LoginLogService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新LOGIN_LOG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateLoginLog(LOGIN_LOG model)
        {
            var result = Fw.LoginLogService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除LOGIN_LOG信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteLoginLog(string ids)
        {
            var result = Fw.LoginLogService.Delete(ids);
            return JResult(result); 
        }
    }
}