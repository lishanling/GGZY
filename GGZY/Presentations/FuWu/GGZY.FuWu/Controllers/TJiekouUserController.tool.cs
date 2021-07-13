using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTJiekouUserController:BaseController
    {
        /// <summary>
        /// 读取T_JIEKOU_USER列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTJiekouUsers(T_JIEKOU_USER model, SearchCondition condition)
        {
            var result = Fw.TJiekouUserService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_JIEKOU_USER明细
        /// </summary>
      /// <param name="SYSTEM_NO"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTJiekouUser(string SYSTEM_NO)
        
        {
            var result = Fw.TJiekouUserService.ViewByPk(SYSTEM_NO);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_JIEKOU_USER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTJiekouUser(T_JIEKOU_USER model)
        {
            var result = Fw.TJiekouUserService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_JIEKOU_USER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTJiekouUser(T_JIEKOU_USER model)
        {
            var result = Fw.TJiekouUserService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_JIEKOU_USER信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTJiekouUser(string ids)
        {
            var result = Fw.TJiekouUserService.Delete(ids);
            return JResult(result); 
        }
    }
}