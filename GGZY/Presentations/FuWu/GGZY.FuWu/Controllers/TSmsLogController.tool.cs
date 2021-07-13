using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTSmsLogController:BaseController
    {
        /// <summary>
        /// 读取T_SMS_LOG列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTSmsLogs(T_SMS_LOG model, SearchCondition condition)
        {
            var result = Fw.TSmsLogService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_SMS_LOG明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTSmsLog(decimal ID)
        
        {
            var result = Fw.TSmsLogService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_SMS_LOG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTSmsLog(T_SMS_LOG model)
        {
            var result = Fw.TSmsLogService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_SMS_LOG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTSmsLog(T_SMS_LOG model)
        {
            var result = Fw.TSmsLogService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_SMS_LOG信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTSmsLog(string ids)
        {
            var result = Fw.TSmsLogService.Delete(ids);
            return JResult(result); 
        }
    }
}