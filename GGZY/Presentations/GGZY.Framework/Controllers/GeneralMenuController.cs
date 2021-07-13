using System.Collections.Generic;
using System.Web.Mvc;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using GGZY.Services.Infrastructure.Extensions;

namespace GGZY.Framework.Controllers
{
    /// <summary>
    /// 通用菜单
    /// </summary>
    public class GeneralMenuController:BaseController
    {
        #region Authorize

        /// <summary>
        /// 根据权限获取菜单列表，等同于根据当前账号的权限获取对应的导航菜单数据。
        /// </summary>
        /// <returns></returns>
        [Route("Account/Menu")]
        [Route("menu/method/get.menu.auth.list")]
        public ActionResult GetMenuAuthList(GeneralMenu model)
        {
            List<GeneralMenu> menus;
            switch (model.MODULE?.ToLower())
            {
                //case "fw"://统一用户
                //    //menus = FwUser.UserMenus();
                //    break;
                case "user"://统一用户
                    menus = Fw.UnifyUserService.UserMenus();
                    break;
                case "jd"://监督平台后台
                    menus = JdUser.UserMenus();
                    break;
                case "bigdata"://标前标中标后大数据分析系统(工程领域大数据)
                    menus = Jd.TUserMenuV2Service.UserMenus(JdUser?.ID,model.MODULE);
                    break;
                default:
                    menus = Jd.TUserMenuV2Service.UserMenus();
                    break;
            }
           
            return JResult(menus);
        }

        #endregion

        #region 菜单CURD

        /// <summary>
        /// 获取菜单列表。
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("menu/method/get.menu.list")]
        [Route("GeneralMenu/GetMenuList")]
        public ActionResult GetMenuList(GeneralMenu model)
        {
            if (model.IsGGZYFW)
            {
                //todo
            }
            var r = Jd.TUserMenuV2Service.FindMenuList(model);
            return JResult(r);
        }
        /// <summary>
        /// 添加一个菜单。
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("menu/method/add.menu.item")]
        [Route("GeneralMenu/AddMenuItem")]
        public ActionResult AddMenuItem(GeneralMenu model)
        {
            var r = Jd.TUserMenuV2Service.AddMenuItem(model);
            return JResult(r);
        }
        /// <summary>
        /// 获取一个菜单。
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("menu/method/get.menu.item")]
        [Route("GeneralMenu/GetMenuItem")]
        public ActionResult GetMenuItem(GeneralMenu model)
        {
            var r = Jd.TUserMenuV2Service.GetMenuItem(model);
            return JResult(r);
        }
        /// <summary>
        /// 编辑一个菜单。
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("menu/method/set.menu.item")]
        [Route("GeneralMenu/SetMenuItem")]
        public ActionResult SetMenuItem(GeneralMenu model)
        {
            var r = Jd.TUserMenuV2Service.SetMenuItem(model);
            return JResult(r);
        }
        /// <summary>
        /// 删除一个菜单。
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("menu/method/del.menu.item")]
        [Route("GeneralMenu/DelMenuItem")]
        public ActionResult DelMenuItem(GeneralMenu model)
        {
            var r = Jd.TUserMenuV2Service.DelMenuItem(model);
            return JResult(r);
        }
        /// <summary>
        /// 设置菜单状态。
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("menu/method/set.menu.status")]
        [Route("GeneralMenu/SetMenuStatus")]
        public ActionResult SetMenuStatus(GeneralMenu model)
        {
            var r = Jd.TUserMenuV2Service.SetMenuStatus(model);
            return JResult(r);
        }

        /// <summary>
        /// 设置菜单排序。
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("menu/method/set.menu.sort")]
        [Route("GeneralMenu/SetMenuSort")]
        public ActionResult SetMenuSort(GeneralMenu model)
        {
            var r = Jd.TUserMenuV2Service.SetMenuSort(model);
            return JResult(r);
        }
        /// <summary>
        /// 菜单初始化
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("menu/method/set.menu.init")]
        [Route("GeneralMenu/SetMenuInit")]
        public ActionResult SetMenuInit(GeneralMenu model)
        {
            var r = Jd.TUserMenuV2Service.InitialMenu();
            return JResult(r);
        }

        #endregion
    }
}