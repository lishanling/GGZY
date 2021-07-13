using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTSignLogController:BaseController
    {
        /// <summary>
        /// 读取T_SIGN_LOG列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTSignLogs(T_SIGN_LOG model, SearchCondition condition)
        {
            var result = Fw.TSignLogService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_SIGN_LOG明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTSignLog(string ID)
        
        {
            var result = Fw.TSignLogService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_SIGN_LOG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTSignLog(T_SIGN_LOG model)
        {
            var result = Fw.TSignLogService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_SIGN_LOG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTSignLog(T_SIGN_LOG model)
        {
            var result = Fw.TSignLogService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_SIGN_LOG信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTSignLog(string ids)
        {
            var result = Fw.TSignLogService.Delete(ids);
            return JResult(result); 
        }
    }
}