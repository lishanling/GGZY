using System;
using System.Web.Mvc;
using GGZY.Core.Authentication;
using GGZY.Core.ExternalAuthentication;
using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZY.Services.Infrastructure.Model;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class AccountController : BaseController
    {
        #region OAuth2

        /// <summary>
        /// 认证校验
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult OAuth2(ExternalAuth model)
        {
            //var r = model.GetAuthorizeCode(Fw.UnifyAppService.CheckPrimaryApp);
            //var r = Fw.UnifyAppService.CheckApplication(model);
            var r = Fw.UnifyAppService.CheckPrimaryApp(model.AppId, model.RedirectUrl);
            return JResult(r);
        }

        /// <summary>
        /// 外部登录
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult ExternalLogin(ExternalLoginModel model)
        {
            var r = model.Validate(CheckCode, RsaToMd5);
            if (r.Success)
            {
                var result = Fw.TUserService.SignIn(model);
                if (result.Success)
                {
                    var tUser = result.TData;
                    //var code = Guid.NewGuid().ToString("N");
                    //TokenManager.CreateToken(new CustomAuthenticationIdentity
                    //{
                    //    Ticket = code,
                    //    TimeStamp = DateTime.Now.ToString("yyyyMMddHHmmss"),
                    //    Id = tUser.ID.ToString(),
                    //    Name = tUser.USERNAME,
                    //    LoginName = tUser.USERNAME
                    //});
                    Cache.Set(model.State, tUser.ID, 5);
                    r.SetSuccess();
                }
                else
                {
                    r = result;
                }
            }
            return JResult(r);
        }
        /// <summary>
        /// OAuth 客户端认证页面
        /// </summary>
        [AllowAnonymous]
        public ActionResult ExternalLoginCallback(ExternalLoginModel model)
        {
            var r = new GeneralResult();
            if (Cache.IsSet(model.State))
            {
                var uid = Cache.Get<string>(model.State);
                var external = new ExternalAuth
                {
                    AppId = model.AppId,
                    State = model.State,
                    RedirectUrl = model.RedirectUrl,
                    Uid = uid,
                    ResponseType = "code",
                };
                r = external.GetAuthorizeCode(Fw.UnifyAppService.CheckPrimaryApp);
            }
            else
            {
                r.SetFail($"认证过期");
            }
            return JResult(r);
            //return Redirect($"{model.RedirectUrl}?state={model.State}");
        }

        [AllowAnonymous]
        public ActionResult GetAccessToken(ExternalAuth model)
        {
            var r = model.GetAccessToken();
            return JResult(r);
        }

        [AllowAnonymous]
        public ActionResult AuthorizeInfo(ExternalAuth model)
        {
            var r = model.AuthorizeInfo(null);
            return JResult(r);
        }
        #endregion



    }
}