using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTUserMenuController:BaseController
    {
        /// <summary>
        /// 读取T_USER_MENU列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTUserMenus(T_USER_MENU model, SearchCondition condition)
        {
            var result = Fw.TUserMenuService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_USER_MENU明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTUserMenu(decimal ID)
        
        {
            var result = Fw.TUserMenuService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_USER_MENU信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTUserMenu(T_USER_MENU model)
        {
            var result = Fw.TUserMenuService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_USER_MENU信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTUserMenu(T_USER_MENU model)
        {
            var result = Fw.TUserMenuService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_USER_MENU信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTUserMenu(string ids)
        {
            var result = Fw.TUserMenuService.Delete(ids);
            return JResult(result); 
        }
    }
}