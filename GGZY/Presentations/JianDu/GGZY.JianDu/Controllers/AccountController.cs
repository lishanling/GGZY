using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using GGZY.Core.Authentication;
using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Services.Infrastructure.Model;
using GGZYFW.DbEntity;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
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
        public ActionResult OAuth2(ExternalLoginModel model)
        {
            var r = Fw.UnifyAppService.CheckApplication(model);
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
                r = Fw.UnifyAppService.CheckApplication(model);
                if (r.Success)
                {
                    var result = Jd.TUserService.SignIn(model);
                    if (result.Success)
                    {
                        var tUser = result.TData;
                        var code = Guid.NewGuid().ToString("N");
                        TokenManager.CreateToken(new CustomAuthenticationIdentity
                        {
                            Ticket = code,
                            TimeStamp = DateTime.Now.ToString("yyyyMMddHHmmss"),
                            Id = tUser.ID.ToString(),
                            Name = tUser.USERNAME,
                            LoginName = tUser.USERNAME
                        });
                        Cache.Set(model.State, code, 5);
                        r.SetSuccess();
                    }
                    else
                    {
                        r = result;
                    }
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
            var r = Fw.UnifyAppService.CheckApplication(model);
            if (r.Success)
            {
                if (Cache.IsSet(model.State))
                {
                    var code = Cache.Get<string>(model.State);
                    var url = $"{model.RedirectUrl}?state={model.State}&code={code}";
                    return Redirect(url);
                }
            }
            return Redirect($"{model.RedirectUrl}?state={model.State}");
        }

        #endregion


    }
}