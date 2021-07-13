using GGZY.Core.Authentication.Jwt;
using GGZY.Core.Cache;
using GGZY.Framework.Models;
using GGZY.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Http;
using GGZY.Core.Authentication;
using GGZY.Core.Authentication.FormsCookie;

namespace GGZY.Framework.Controllers
{
    /// <summary>
    /// 用于webApi的基类
    /// </summary>
    public class BaseApiController: ApiController
    {
        #region Properties

        private JwtTokenManager _tokenManager = null;


        /// <summary>
        /// 全局缓存
        /// </summary>
        public ICacheManager Cache => GlobalCache.Instance;
        /// <summary>
        /// 身份认证管理器
        /// </summary>
        public JwtTokenManager TokenManager => _tokenManager ?? (_tokenManager = new JwtTokenManager());

        /// <summary>
        /// 公共资源服务-业务工厂
        /// </summary>
        public ServicesFactoryFw Fw => ServicesFactory.GGZYFW;

        /// <summary>
        /// 公共资源监督-业务工厂
        /// </summary>
        public ServicesFactoryJd Jd => ServicesFactory.GGZYJD;


        /// <summary>
        /// 当前登录用户
        /// </summary>
        protected CustomAuthenticationIdentity Identity => User.AuthorizeFormsIdentityUser();
        #endregion
    }
}