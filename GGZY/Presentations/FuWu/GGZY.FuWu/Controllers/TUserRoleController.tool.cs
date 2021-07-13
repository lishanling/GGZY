using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTUserroleController:BaseController
    {
        /// <summary>
        /// 读取T_USERROLE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTUserroles(T_USERROLE model, SearchCondition condition)
        {
            var result = Fw.TUserroleService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_USERROLE明细
        /// </summary>
      /// <param name="ROLEID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTUserrole(decimal ROLEID)
        
        {
            var result = Fw.TUserroleService.ViewByPk(ROLEID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_USERROLE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTUserrole(T_USERROLE model)
        {
            var result = Fw.TUserroleService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_USERROLE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTUserrole(T_USERROLE model)
        {
            var result = Fw.TUserroleService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_USERROLE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTUserrole(string ids)
        {
            var result = Fw.TUserroleService.Delete(ids);
            return JResult(result); 
        }
    }
}