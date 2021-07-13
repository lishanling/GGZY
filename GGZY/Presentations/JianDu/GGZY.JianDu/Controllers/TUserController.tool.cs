using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
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
            var result = Jd.TUserService.PageTable(model, condition);           
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
            var result = Jd.TUserService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_USER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTUser(T_USER model)
        {
            var result = Jd.TUserService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_USER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTUser(T_USER model)
        {
            var result = Jd.TUserService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_USER信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTUser(string ids)
        {
            var result = Jd.TUserService.Delete(ids);
            return JResult(result); 
        }
    }
}