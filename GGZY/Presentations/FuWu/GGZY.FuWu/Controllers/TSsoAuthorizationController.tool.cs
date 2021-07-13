using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTSsoAuthorizationController:BaseController
    {
        /// <summary>
        /// 读取T_SSO_AUTHORIZATION列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTSsoAuthorizations(T_SSO_AUTHORIZATION model, SearchCondition condition)
        {
            var result = Fw.TSsoAuthorizationService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_SSO_AUTHORIZATION明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTSsoAuthorization(decimal ID)
        
        {
            var result = Fw.TSsoAuthorizationService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_SSO_AUTHORIZATION信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTSsoAuthorization(T_SSO_AUTHORIZATION model)
        {
            var result = Fw.TSsoAuthorizationService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_SSO_AUTHORIZATION信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTSsoAuthorization(T_SSO_AUTHORIZATION model)
        {
            var result = Fw.TSsoAuthorizationService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_SSO_AUTHORIZATION信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTSsoAuthorization(string ids)
        {
            var result = Fw.TSsoAuthorizationService.Delete(ids);
            return JResult(result); 
        }
    }
}