using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdSysUserController:BaseController
    {
        /// <summary>
        /// 读取SYS_USER列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadSysUsers(SYS_USER model, SearchCondition condition)
        {
            var result = Fw.SysUserService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取SYS_USER明细
        /// </summary>
      /// <param name="U_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadSysUser(decimal U_ID)
        
        {
            var result = Fw.SysUserService.ViewByPk(U_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建SYS_USER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateSysUser(SYS_USER model)
        {
            var result = Fw.SysUserService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新SYS_USER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateSysUser(SYS_USER model)
        {
            var result = Fw.SysUserService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除SYS_USER信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteSysUser(string ids)
        {
            var result = Fw.SysUserService.Delete(ids);
            return JResult(result); 
        }
    }
}