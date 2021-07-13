using System;
using System.Web.Mvc;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Helper;
using GGZYFW.DbEntity;

namespace GGZY.Framework.Controllers
{
    /// <summary>
    /// 外部认证
    /// </summary>
    [AllowAnonymous]
    public class ExternalController : BaseController
    {
        /// <summary>
        /// 认证跳转
        /// </summary>
        /// <returns></returns>
        public ActionResult OAuth()
        {
            var oauthUrl = ConfigHelper.AppSettings.UNIFY_LOGIN_URL;
            return JResult(new { Url = oauthUrl });
        }


        #region 1 SSO登录到其他应用

        /// <summary>
        /// 应用跳转(SSO登录到对应平台)
        /// </summary>
        [Route("Account/ExternalLogin")]
        [Route("External/ExternalLogin")]
        [Route("External/Login")]
        public ActionResult ExternalLogin(string id)
        {
            var r = new GeneralResult();
            var app = Fw.UnifyAppService.FindAppByAppIdOrAppKey(id);
            if (app != null)
            {

                var ticket = Guid.NewGuid().ToString("N");
                Cache.Set(ticket, Token, 2);
                r.SetSuccess(new { Url = $"{app.SSOURL}?ticket={ticket}" });
                //return Redirect(url);
            }
            else
            {
                r.SetFail("未找到对应的授权应用信息");
            }
            return JResult(r);
        }



        #endregion

        #region 2 SSO
        /// <summary>
        /// 单点登录
        /// </summary>
        /// <param name="ticket"></param>
        /// <returns></returns>

        public ActionResult SingleSignOn(string ticket)
        {
            var r = new GeneralResult();
            if (Cache.IsSet(ticket))
            {
                var token = Cache.Get<string>(ticket);
                //Cache.Remove(ticket);
                var rsp = TokenManager.CheckToken(token);
                if (rsp.Success)
                {
                    return JResult(new { Token = rsp.TData.Ticket });
                }
                return JResult(rsp);
            }
            r.SetFail("凭证失效或不正确");

            return JResult(r);
        }

        #endregion

        #region 3 退出登录

        /// <summary>
        /// 退出登录
        /// </summary>
        /// <returns></returns>
        [Route("Account/SignOut")]
        [Route("External/SignOut")]
        public ActionResult SignOut()
        {
            Cache.RemoveByPattern($"{ConfigHelper.APP_KEY_GGZYJD}:MENUS");
            Cache.Remove($"{ConfigHelper.APP_KEY_GGZYJD}_{Token}");
            Cache.RemoveByPattern($"{ConfigHelper.APP_KEY_GGZYFW}:MENUS");
            Cache.RemoveByPattern("MENUS");
            TokenManager.DeleteToken(Token);
            var oauthUrl = ConfigHelper.AppSettings.UNIFY_LOGIN_URL;
            var r = new GeneralResult();
            r.SetSuccess(new { Url = oauthUrl }, "注销成功");
            return JResult(r);
        }

        #endregion

        /// <summary>
        /// 解锁web端访问
        /// </summary>
        /// <returns></returns>
        [Route("Client/Validate")]
        public ActionResult Validate(string imgCode)
        {
            if (CheckCode(imgCode))
            {

            }
            return JResult(new { });
        }
        /// <summary>
        /// 获取已绑定账号的用户名
        /// </summary>
        /// <returns></returns>
        public ActionResult GetOldUser()
        {
            var r = new GeneralResult();
            r.SetSuccess(Identity.JdUser().DEPARTID == 658 ? "未绑定旧账号" : Identity.JdUser().USERNAME);

            return JResult(r);
        }
    }
}