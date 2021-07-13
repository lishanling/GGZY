using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
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
            var result = Fw.ProjectService.PageList(model, condition);           
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
            var result = Fw.ProjectService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PROJECT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateProject(PROJECT model)
        {
            var result = Fw.ProjectService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PROJECT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateProject(PROJECT model)
        {
            var result = Fw.ProjectService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PROJECT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteProject(string ids)
        {
            var result = Fw.ProjectService.Delete(ids);
            return JResult(result); 
        }
    }
}