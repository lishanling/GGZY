using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTYcLogController:BaseController
    {
        /// <summary>
        /// 读取T_YC_LOG列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTYcLogs(T_YC_LOG model, SearchCondition condition)
        {
            var result = Fw.TYcLogService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_YC_LOG明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTYcLog(decimal ID)
        
        {
            var result = Fw.TYcLogService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_YC_LOG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTYcLog(T_YC_LOG model)
        {
            var result = Fw.TYcLogService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_YC_LOG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTYcLog(T_YC_LOG model)
        {
            var result = Fw.TYcLogService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_YC_LOG信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTYcLog(string ids)
        {
            var result = Fw.TYcLogService.Delete(ids);
            return JResult(result); 
        }
    }
}