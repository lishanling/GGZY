using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTUserController:BaseController
    {
        /// <summary>
        /// 读取T_USER列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTUsers(T_USER model, SearchCondition condition)
        {
            var result = Fw.TUserService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_USER明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTUser(decimal ID)
        
        {
            var result = Fw.TUserService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_USER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTUser(T_USER model)
        {
            var result = Fw.TUserService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_USER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTUser(T_USER model)
        {
            var result = Fw.TUserService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_USER信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTUser(string ids)
        {
            var result = Fw.TUserService.Delete(ids);
            return JResult(result); 
        }
    }
}