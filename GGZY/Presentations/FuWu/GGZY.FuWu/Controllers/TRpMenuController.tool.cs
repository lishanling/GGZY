using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTRpMenuController:BaseController
    {
        /// <summary>
        /// 读取T_RP_MENU列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTRpMenus(T_RP_MENU model, SearchCondition condition)
        {
            var result = Fw.TRpMenuService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_RP_MENU明细
        /// </summary>
      /// <param name="MENU_CODE"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTRpMenu(string MENU_CODE)
        
        {
            var result = Fw.TRpMenuService.ViewByPk(MENU_CODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_RP_MENU信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTRpMenu(T_RP_MENU model)
        {
            var result = Fw.TRpMenuService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_RP_MENU信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTRpMenu(T_RP_MENU model)
        {
            var result = Fw.TRpMenuService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_RP_MENU信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTRpMenu(string ids)
        {
            var result = Fw.TRpMenuService.Delete(ids);
            return JResult(result); 
        }
    }
}