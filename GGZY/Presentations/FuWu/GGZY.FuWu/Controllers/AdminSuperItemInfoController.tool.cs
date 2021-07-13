using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdAdminSuperItemInfoController:BaseController
    {
        /// <summary>
        /// 读取ADMIN_SUPER_ITEM_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadAdminSuperItemInfos(ADMIN_SUPER_ITEM_INFO model, SearchCondition condition)
        {
            var result = Fw.AdminSuperItemInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取ADMIN_SUPER_ITEM_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadAdminSuperItemInfo(decimal M_ID)
        
        {
            var result = Fw.AdminSuperItemInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建ADMIN_SUPER_ITEM_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateAdminSuperItemInfo(ADMIN_SUPER_ITEM_INFO model)
        {
            var result = Fw.AdminSuperItemInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新ADMIN_SUPER_ITEM_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateAdminSuperItemInfo(ADMIN_SUPER_ITEM_INFO model)
        {
            var result = Fw.AdminSuperItemInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除ADMIN_SUPER_ITEM_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteAdminSuperItemInfo(string ids)
        {
            var result = Fw.AdminSuperItemInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}