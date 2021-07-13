using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdSysMenuController:BaseController
    {
        /// <summary>
        /// 读取SYS_MENU列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadSysMenus(SYS_MENU model, SearchCondition condition)
        {
            var result = Fw.SysMenuService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取SYS_MENU明细
        /// </summary>
      /// <param name="MENUID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadSysMenu(decimal MENUID)
        
        {
            var result = Fw.SysMenuService.ViewByPk(MENUID);
            return JResult(result);
        }
        /// <summary>
        /// 创建SYS_MENU信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateSysMenu(SYS_MENU model)
        {
            var result = Fw.SysMenuService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新SYS_MENU信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateSysMenu(SYS_MENU model)
        {
            var result = Fw.SysMenuService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除SYS_MENU信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteSysMenu(string ids)
        {
            var result = Fw.SysMenuService.Delete(ids);
            return JResult(result); 
        }
    }
}