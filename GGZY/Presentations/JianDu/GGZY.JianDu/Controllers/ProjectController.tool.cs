using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;
using System.Collections.Generic;
using System.Linq;

namespace GGZY.JianDu.Controllers
{
    public partial class JdProjectController:BaseController
    {
        /// <summary>
        /// 读取PROJECT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadProjects(PROJECT model, SearchCondition condition)
        {
            var result = Jd.ProjectService.PageList(model, condition).ToPageTableResult(condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PROJECT明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadProject(decimal M_ID)
        
        {
            var result = Jd.ProjectService.ViewByPk(M_ID);
            return JResult(result);
        }
  
        /// <summary>
        /// 更新PROJECT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateProject(PROJECT model)
        {
            var result = Jd.ProjectService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PROJECT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteProject(string ids)
        {
            var result = Jd.ProjectService.Delete(ids);
            return JResult(result); 
        }
    }
}