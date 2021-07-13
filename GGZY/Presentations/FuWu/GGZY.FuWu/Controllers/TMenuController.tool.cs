using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTMenuController:BaseController
    {
        /// <summary>
        /// 读取T_MENU列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTMenus(T_MENU model, SearchCondition condition)
        {
            var result = Fw.TMenuService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_MENU明细
        /// </summary>
      /// <param name="MENUID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTMenu(decimal MENUID)
        
        {
            var result = Fw.TMenuService.ViewByPk(MENUID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_MENU信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTMenu(T_MENU model)
        {
            var result = Fw.TMenuService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_MENU信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTMenu(T_MENU model)
        {
            var result = Fw.TMenuService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_MENU信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTMenu(string ids)
        {
            var result = Fw.TMenuService.Delete(ids);
            return JResult(result); 
        }
    }
}