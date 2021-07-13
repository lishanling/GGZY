using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdSysUserroleController:BaseController
    {
        /// <summary>
        /// 读取SYS_USERROLE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadSysUserroles(SYS_USERROLE model, SearchCondition condition)
        {
            var result = Fw.SysUserroleService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取SYS_USERROLE明细
        /// </summary>
      /// <param name="ROLEID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadSysUserrole(decimal ROLEID)
        
        {
            var result = Fw.SysUserroleService.ViewByPk(ROLEID);
            return JResult(result);
        }
        /// <summary>
        /// 创建SYS_USERROLE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateSysUserrole(SYS_USERROLE model)
        {
            var result = Fw.SysUserroleService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新SYS_USERROLE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateSysUserrole(SYS_USERROLE model)
        {
            var result = Fw.SysUserroleService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除SYS_USERROLE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteSysUserrole(string ids)
        {
            var result = Fw.SysUserroleService.Delete(ids);
            return JResult(result); 
        }
    }
}