using System;
using System.Web.Mvc;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using GGZY.Framework.Models;
using GGZY.Services.Infrastructure.Model;
using GGZY.Services.Infrastructure.Model.FuWu;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Portal.Controllers
{
    /// <summary>
    /// 第三方授权请求相关接口
    /// 1 第三方发起授权请求
    /// 2 返回第三方code
    /// 3 第三方通过code获取access_token
    /// 4 第三方通过access_token获取授权用户相关信息
    /// </summary>
    [AllowAnonymous, PortalUnFilter]
    public class LoginController: BaseController
    {
        #region 第三方交易平台登录

        [Route("Login/LoginPage")]
        [Route("Login/LoginPage.aspx")]
        [Route("Website/Login/LoginPage.aspx")]
        public ActionResult LoginPage(FwOAuthModel model)
        {
            var r = model.Validate();
            if (!r.Success)
            {
                return JResult(r);
            }
            return View(model);
        }

        #region 获取code
        /// <summary>
        /// 账号密码登录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult SsoSignIn(FwOAuthModel model)
        {
            var loginModel = model.ToLoginModel();
            var r = loginModel.Validate(CheckCode, null);
            if (r.Success)
            {
                var signInResult = Fw.TUserService.SignIn(loginModel);
                if (signInResult.Success)
                {
                    model.guid = signInResult.TData.ID;
                    var authorizeCodeResult= model.GetAuthorizeCode(Fw.TSsoInfoService.GetSsoInfo);
                    if (authorizeCodeResult.Success)
                    {
                        r.SetSuccess(new
                        {
                            location_url= $"{model.redirect_uri}?code={model.code}&state={model.state}"
                        });
                    }
                    else
                    {
                        r.SetFail(authorizeCodeResult.Msg);
                    }
                }
                else
                {
                    r.SetFail(signInResult.Msg);
                }
            }
            return JResult(r);
        }
        /// <summary>
        /// CA登录
        /// </summary>
        /// <param name="ca"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult CaSignIn(CertificateAuthorityModel ca, FwOAuthModel model)
        {
            var r = Fw.TUserService.CaSignIn(ca);
            if (r.Success)
            {
                model.guid = r.TData.ID;
                var authorizeCodeResult = model.GetAuthorizeCode(Fw.TSsoInfoService.GetSsoInfo);
                if (authorizeCodeResult.Success)
                {
                    r.SetSuccess(new
                    {
                        location_url = $"{model.redirect_uri}?code={model.code}&state={model.state}"
                    });
                }
                else
                {
                    r.SetFail(authorizeCodeResult.Msg);
                }
            }
            return JResult(r);
        }

        #endregion

        #region T_SSO_AUTHORIZATION

        [Route("SSO/OAuth2/Handler")]
        [Route("SSO/OAuth2/Handler.ashx")]
        public ActionResult SsoOAuth2Handler(FwOAuthModel model, string flag)
        {
            if (!string.IsNullOrWhiteSpace(flag))
            {
                if (flag.Equals("GetAccessToken", StringComparison.CurrentCultureIgnoreCase))
                {
                    return GetAccessToken(model, flag);
                }
                if (flag.Equals("GetUser", StringComparison.CurrentCultureIgnoreCase))
                {
                    return AuthorizeInfo(model, flag);
                }
            }

            return FResult("参数错误");
        }
        /// <summary>
        /// code 换 access_token
        /// </summary>
        /// <param name="model"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        [Route("Login/GetAccessToken")]
        [Route("SSO/OAuth2/Handler/{flag:regex(GetAccessToken)}")]
        public ActionResult GetAccessToken(FwOAuthModel model,string flag)
        {
            //return Content(flag);
            var r = model.GetAccessToken(Fw.TSsoAuthorizationService.GetAuthorizationInfo);
            if (r.Success)
            {
                return JResult(new
                {
                    status =1,
                    access_token =r.TData.ACCESS_TOKEN,
                    expires=1440//1天
                }, false);
            }
            return JResult(new
            {
                status = 0,msg=r.Msg
            }, false);
        }
        /// <summary>
        /// access_token 换取用户授权信息
        /// </summary>
        /// <param name="model"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        [Route("Login/AuthorizeInfo")]
        [Route("SSO/OAuth2/Handler/{flag:regex(GetUser)}")]
        public ActionResult AuthorizeInfo(FwOAuthModel model, string flag)
        {
            var r = model.AuthorizeInfo(Fw.TSsoAuthorizationService.AuthorizationInfo, Fw.TUserService.FindUserByUid, Fw.LegalPersonBaseService.LegalPersonByUid);
            if (r.Success)
            {
                return JResult(r.Data, false);
            }

            return JResult(new
            {
                status = 0,
                msg = r.Msg,
            }, false);
        }

        #endregion
        

        #endregion

        #region 站内登录

        public ActionResult SignIn(LoginModel model)
        {
            model.client_id = "GGZYFW";
            var r = model.Validate(CheckCode, null);
            if (r.Success)
            {
                r = Fw.UnifyUserService.SignIn(model);
            }
            return JResult(r);
        }

        #endregion
    }
}