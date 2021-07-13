using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdTAfcProjectController:BaseController
    {
        /// <summary>
        /// 读取T_AFC_PROJECT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTAfcProjects(T_AFC_PROJECT model, SearchCondition condition)
        {
            var result = Jd.TAfcProjectService.PageList(model, condition).ToPageTableResult(condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_AFC_PROJECT明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTAfcProject(decimal ID)
        
        {
            var result = Jd.TAfcProjectService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_AFC_PROJECT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTAfcProject(T_AFC_PROJECT model)
        {
            var result = Jd.TAfcProjectService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_AFC_PROJECT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTAfcProject(T_AFC_PROJECT model)
        {
            var result = Jd.TAfcProjectService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_AFC_PROJECT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTAfcProject(string ids)
        {
            var result = Jd.TAfcProjectService.Delete(ids);
            return JResult(result); 
        }
    }
}