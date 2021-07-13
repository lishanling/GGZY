using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTSsoJycenterController:BaseController
    {
        /// <summary>
        /// 读取T_SSO_JYCENTER列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTSsoJycenters(T_SSO_JYCENTER model, SearchCondition condition)
        {
            var result = Fw.TSsoJycenterService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_SSO_JYCENTER明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTSsoJycenter(decimal ID)
        
        {
            var result = Fw.TSsoJycenterService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_SSO_JYCENTER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTSsoJycenter(T_SSO_JYCENTER model)
        {
            var result = Fw.TSsoJycenterService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_SSO_JYCENTER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTSsoJycenter(T_SSO_JYCENTER model)
        {
            var result = Fw.TSsoJycenterService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_SSO_JYCENTER信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTSsoJycenter(string ids)
        {
            var result = Fw.TSsoJycenterService.Delete(ids);
            return JResult(result); 
        }
    }
}