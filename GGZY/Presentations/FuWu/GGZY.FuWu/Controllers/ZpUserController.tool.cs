using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdZpUserController:BaseController
    {
        /// <summary>
        /// 读取ZP_USER列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadZpUsers(ZP_USER model, SearchCondition condition)
        {
            var result = Fw.ZpUserService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取ZP_USER明细
        /// </summary>
      /// <param name="ZP_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadZpUser(decimal ZP_ID)
        
        {
            var result = Fw.ZpUserService.ViewByPk(ZP_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建ZP_USER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateZpUser(ZP_USER model)
        {
            var result = Fw.ZpUserService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新ZP_USER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateZpUser(ZP_USER model)
        {
            var result = Fw.ZpUserService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除ZP_USER信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteZpUser(string ids)
        {
            var result = Fw.ZpUserService.Delete(ids);
            return JResult(result); 
        }
    }
}