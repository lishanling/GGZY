using System.Collections.Generic;
using System.Web.Mvc;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Model;
using GGZYFW.DbEntity;

namespace GGZY.Framework.Controllers
{
    /// <summary>
    /// 身份信息
    /// </summary>
    public partial class IdentityController : BaseController
    {
        /// <summary>
        /// 身份信息
        /// </summary>
        /// <returns></returns>
        [Route("Account/Profile")]
        public ActionResult Profiles()
        {
            if (IsJdRequest)
            {
                return JResult(JdUser);
            }
            if (IsFwRequest)
            {
                return JResult(FwUser);
            }
            //if (JdUser != null)
            //{
            //    return JResult(JdUser);
            //}
            //if (FwUser != null)
            //{
            //    return JResult(FwUser);
            //}
            return JResult(new
            {
                USERNAME = Identity.Name,
                LOGINNAME = Identity.LoginName,
                ID = Identity.Id
            });
        }

        #region 用户管理

        [Route("Account/UserList")]
        public ActionResult UserList(V_UNIFY_USER model, SearchCondition condition)
        {
            var s = Fw.VUnifyUserService.PageTable(model, condition);
            return JResult(s);
        }
        /// <summary>
        /// 设置用户
        /// </summary>
        /// <param name="userGroup"></param>
        /// <returns></returns>
        [Route("Account/SetUserRoles")]
        public ActionResult SetUserRoles(UserGroup userGroup)
        {
            Jd.TUserService.SetUserRoles(userGroup);
            return JResult(true);
        }

        #endregion
    }
}