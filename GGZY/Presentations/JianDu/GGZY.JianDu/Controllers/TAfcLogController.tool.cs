using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdTAfcLogController:BaseController
    {
        /// <summary>
        /// 读取T_AFC_LOG列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTAfcLogs(T_AFC_LOG model, SearchCondition condition)
        {
            var result = Jd.TAfcLogService.PageList(model, condition).ToPageTableResult(condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_AFC_LOG明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTAfcLog(decimal ID)
        
        {
            var result = Jd.TAfcLogService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_AFC_LOG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTAfcLog(T_AFC_LOG model)
        {
            var result = Jd.TAfcLogService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_AFC_LOG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTAfcLog(T_AFC_LOG model)
        {
            var result = Jd.TAfcLogService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_AFC_LOG信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTAfcLog(string ids)
        {
            var result = Jd.TAfcLogService.Delete(ids);
            return JResult(result); 
        }
    }
}