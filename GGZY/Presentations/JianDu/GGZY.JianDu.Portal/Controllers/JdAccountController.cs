using System;
using System.Web.Mvc;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Framework.Controllers;
using GGZY.Services.Infrastructure.Model;

namespace GGZY.JianDu.Portal.Controllers
{
    [AllowAnonymous]
    public class JdAccountController:BaseController
    {
        #region 处长门户登录
      
        public ActionResult SignIn(LoginModel model)
        {
            var r = model.Validate(CheckCode, RsaToMd5);
            if (r.Success)
            {
                r = Fw.UnifyUserService.CzSignIn(model);
            }
            return JResult(r);
        }
        /// <summary>
        /// 监督平台处长门户CA登录
        /// </summary>
        /// <returns></returns>
        public ActionResult CaSignIn(CertificateAuthorityModel ca)
        {
            var r = Fw.UnifyUserService.CzCaSignIn(ca);
            return JResult(r);
        }



        #endregion


        #region 闽政通
        /// <summary>
        /// 手机号码认证
        /// </summary>
        /// <param name="mobile"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public ActionResult MztAuthorize(string mobile, string pwd)
        {
            var r = new GeneralResult();
            var validateSecret =CommonUtils.Md5Str($"MZT_{DateTime.Today:yyyyMMdd}_{mobile}");
            if (validateSecret.Equals(pwd,StringComparison.CurrentCultureIgnoreCase))
            {
                var mztIdentity = Jd.TUserService.GetCustomAuthenticationIdentity(mobile);
                if (mztIdentity != null)
                {
                    TokenManager.CreateToken(mztIdentity);
                    r.SetSuccess(new { Token = mztIdentity.Ticket });
                }
                else
                {
                    r.SetUnauthorized("用户不存在");
                }
            }
            else
            {
                r.SetUnauthorized("用户不存在");
            }

            return JResult(r);
        }

        #endregion
    }
}