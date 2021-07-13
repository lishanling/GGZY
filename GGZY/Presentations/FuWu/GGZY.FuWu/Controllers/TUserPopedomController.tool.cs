using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTUserPopedomController:BaseController
    {
        /// <summary>
        /// 读取T_USER_POPEDOM列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTUserPopedoms(T_USER_POPEDOM model, SearchCondition condition)
        {
            var result = Fw.TUserPopedomService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_USER_POPEDOM明细
        /// </summary>
      /// <param name="ID">权限ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTUserPopedom(decimal ID)
        
        {
            var result = Fw.TUserPopedomService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_USER_POPEDOM信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTUserPopedom(T_USER_POPEDOM model)
        {
            var result = Fw.TUserPopedomService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_USER_POPEDOM信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTUserPopedom(T_USER_POPEDOM model)
        {
            var result = Fw.TUserPopedomService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_USER_POPEDOM信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTUserPopedom(string ids)
        {
            var result = Fw.TUserPopedomService.Delete(ids);
            return JResult(result); 
        }
    }
}