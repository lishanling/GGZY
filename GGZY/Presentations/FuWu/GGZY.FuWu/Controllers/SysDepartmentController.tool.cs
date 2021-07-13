using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdSysDepartmentController:BaseController
    {
        /// <summary>
        /// 读取SYS_DEPARTMENT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadSysDepartments(SYS_DEPARTMENT model, SearchCondition condition)
        {
            var result = Fw.SysDepartmentService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取SYS_DEPARTMENT明细
        /// </summary>
      /// <param name="DEPID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadSysDepartment(decimal DEPID)
        
        {
            var result = Fw.SysDepartmentService.ViewByPk(DEPID);
            return JResult(result);
        }
        /// <summary>
        /// 创建SYS_DEPARTMENT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateSysDepartment(SYS_DEPARTMENT model)
        {
            var result = Fw.SysDepartmentService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新SYS_DEPARTMENT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateSysDepartment(SYS_DEPARTMENT model)
        {
            var result = Fw.SysDepartmentService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除SYS_DEPARTMENT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteSysDepartment(string ids)
        {
            var result = Fw.SysDepartmentService.Delete(ids);
            return JResult(result); 
        }
    }
}