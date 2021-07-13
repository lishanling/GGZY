using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using GGZY.Core.Authentication;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Framework.Controllers;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Model;
using GGZYFW.DbEntity;
using Newtonsoft.Json;

namespace GGZY.Auth.Controllers
{

    public class AccountController : BaseController
    {

        #region 内部登录

        /// <summary>
        /// 账号登录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult SignIn(LoginModel model)
        {
            var r = model.Validate(CheckCode, RsaToMd5);
            if (r.Success)
            {
                r = Fw.UnifyUserService.SignIn(model);
                //if (!string.IsNullOrWhiteSpace(client_id)&&r.Success)
                //{
                //    var app = Fw.UnifyAppService.FindAppByAppIdOrAppKey(client_id);
                //    if (app!=null)
                //    {
                //        var token = r.Data.PropertyToString("Token");
                //        var ticket = Guid.NewGuid().ToString("N");
                //        Cache.Set(ticket, token, 2);
                //        r.SetSuccess(new { Url = $"{app.SSOURL}?ticket={ticket}",Token=token });
                //        //return Redirect(url);
                //    }
                //}
            }
            return JResult(r);
        }
        [AllowAnonymous]
        public ActionResult GetRandomForSign()
        {

            var r = Fw.TUserService.GetRandomForSign();
            return JResult(r);
        }

        /// <summary>
        /// CA登录
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult CaSignIn(CertificateAuthorityModel ca)
        {
            var r = Fw.UnifyUserService.CaSignIn(ca);
            return JResult(r);
        }
        /// <summary>
        /// 检测CA是否已经注册
        /// </summary>
        /// <param name="ca"></param>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult IsCaRegisted(CertificateAuthorityModel ca)
        {
            var r = Fw.UnifyUserService.CaSignIn(ca);
            if (!r.Success && r.Data != null)
            {
                r.SetSuccess(r.Data);
            }
            return JResult(r);
        }
        
        #endregion

       

        #region OAuth 认证

        public ActionResult OAuth(string id)
        {
            var r = Fw.UnifyAppService.ViewByPk(id);
            if (r.Success)
            {
                var app = r.Data as UNIFY_APP;
                var redirectUrl = Request.Url?.AbsolutePath.Replace(Request.Url?.PathAndQuery, "");
                redirectUrl = HttpUtility.HtmlEncode($"{redirectUrl}/Account/OAuthCallback");
                var state = Guid.NewGuid().ToString("N");
                Cache.Set(state, Token, 5);
                var appSecret = CommonUtils.Md5Str(state);
                var url = $"{app.OAUTHURL}?AppId={id}&RedirectUrl={redirectUrl}&State={state}&AppSecret={appSecret}";
                r.SetSuccess(new { Url = url });
                //return Redirect(url);
            }
            return JResult(r);

        }


        /// <summary>
        /// OAuth认证回调
        /// </summary>
        /// <param name="appid">应用appkey</param>
        /// <param name="state"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult OAuthCallbackObsolete(string appid, string state, string code)
        {
            var r = new GeneralResult();
            //if (Cache.IsSet(state) && Cache.IsSet(code))
            //{
            //    var ticket = Cache.Get<string>(state);
            //    var checkTokenRsp = TokenManager.CheckToken(ticket);
            //    if (checkTokenRsp.Success)
            //    {
            //        var checkCodeRsp = TokenManager.CheckToken(code);//TODO 按照OAUTH2 这里正确的应该是使用CODE调用接口返回ACCESS_TOKEN,在通过ACCESS_TOKEN和APPID获取对应的授权信息，这里直接解析code获取对应的用户信息
            //        if (checkCodeRsp.Success)
            //        {
            //            r = Fw.UnifyAuthsService.SetOAuth(appid, checkCodeRsp.TData.Id, checkTokenRsp.TData.Id);
            //            if (r.Success)
            //            {
            //                Cache.Remove(state);
            //                r.SetSuccess(new { Token = checkTokenRsp.TData.Ticket });
            //            }
            //        }
            //        else
            //        {
            //            r.SetFail(checkCodeRsp.Msg);
            //        }
            //    }
            //    else
            //    {
            //        r.SetFail(checkTokenRsp.Msg);
            //    }
            //}
            //else
            //{
            //    r.SetFail($"参数无效");
            //}
            return JResult(r);
        }

        [AllowAnonymous]
        public ActionResult OAuthCallback(string appid, string state, string code)
        {
            var redirectUrl = Request.Url?.AbsolutePath.Replace(Request.Url?.PathAndQuery, "");
            redirectUrl = HttpUtility.HtmlEncode($"{redirectUrl}/Account/OAuthCallback");
            var r = Fw.UnifyAuthsService.SetPrimaryOAuth(appid, state, code, redirectUrl);
            return JResult(r);
        }

        #endregion

        #region 账号注册

        [AllowAnonymous]
        public ActionResult CreateTempCode(string countyCode,string type)
        {
          var  r = Jd.TUserExtendService.CreateTempCode(countyCode,type);
        return JResult(r);
    }
        [AllowAnonymous]
        public ActionResult Register(RegisterModel model)
        {
            var r = model.Validate();
            if (r.Success)
            {
                r = Fw.UnifyUserService.Register(model);
            }
            return JResult(r);
        }

        #endregion


        
    }
}