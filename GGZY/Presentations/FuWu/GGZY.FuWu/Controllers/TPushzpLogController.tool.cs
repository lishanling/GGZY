using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTPushzpLogController:BaseController
    {
        /// <summary>
        /// 读取T_PUSHZP_LOG列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTPushzpLogs(T_PUSHZP_LOG model, SearchCondition condition)
        {
            var result = Fw.TPushzpLogService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_PUSHZP_LOG明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTPushzpLog(decimal ID)
        
        {
            var result = Fw.TPushzpLogService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_PUSHZP_LOG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTPushzpLog(T_PUSHZP_LOG model)
        {
            var result = Fw.TPushzpLogService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_PUSHZP_LOG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTPushzpLog(T_PUSHZP_LOG model)
        {
            var result = Fw.TPushzpLogService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_PUSHZP_LOG信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTPushzpLog(string ids)
        {
            var result = Fw.TPushzpLogService.Delete(ids);
            return JResult(result); 
        }
    }
}