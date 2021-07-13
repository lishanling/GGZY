using System;
using System.Linq;
using System.Security.Policy;
using System.Web;
using GGZY.Core.Authentication;
using GGZY.Core.Authentication.FormsCookie;
using GGZY.Core.Authentication.Jwt;
using GGZY.Core.Cache;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Model.FuWu;
using GGZY.Services.Infrastructure.Model.JianDu;

namespace GGZY.Services.Base
{
    public partial class BaseService
    {
        protected void SetIdentity(CustomAuthenticationIdentity identity)
        {
            this._identity=identity;
        }
        /// <summary>
        /// 公共资源服务-业务工厂
        /// </summary>
        protected ServicesFactoryFw Fw => ServicesFactory.GGZYFW;

        /// <summary>
        /// 公共资源监督-业务工厂
        /// </summary>
        protected ServicesFactoryJd Jd => ServicesFactory.GGZYJD;
        /// <summary>
        /// 招标采购-业务工厂
        /// </summary>
        protected ServicesFactoryJh ZBCG => ServicesFactory.ZBCG;

        /// <summary>
        /// 全局缓存
        /// </summary>
        protected ICacheManager Cache => GlobalCache.Instance;

        private JwtTokenManager _tokenManager = null;
        protected JwtTokenManager TokenManager
        {
            get { return _tokenManager ?? (_tokenManager = new JwtTokenManager()); }
        }

        private CustomAuthenticationIdentity _identity;
        /// <summary>
        /// 当前登录用户
        /// </summary>
        protected CustomAuthenticationIdentity Identity
        {
            get
            {
                if (_identity != null)
                {
                    return _identity;
                }
                CustomAuthenticationIdentity identity = _identity;

                try
                {
                    if (HttpContext.Current!=null&&HttpContext.Current.User.Identity.IsAuthenticated)
                    {
                        identity = HttpContext.Current.User.AuthorizeFormsIdentityUser();
                    }

                }
                catch (Exception)
                {
                    identity = _identity;
                    //Logger.Error($"BaseServer:Identity 错误{e.Message}", e);
                }

                return identity;
            }
            set { _identity = value; }
        }

        protected FwUserModel FwUser => Identity?.FwUser();
        /// <summary>
        ///  当前登录账号
        /// </summary>
        protected JdUserModel JdUser => Identity?.JdUser();
        protected string OBJECT_NOT_EXIST = "对象不存在或者已删除";

        
        protected string CommonAttachmentBuilder(object id, string pt = "Fw", string fType = "Sys")
        {
            var url = string.Empty;
            if (id != null)
            {
                var attachmentId = id.ToString();
                if (attachmentId.Contains("."))
                {
                    id = attachmentId.Split('.').FirstOrDefault();
                }
                // url = Url.RouteUrl("FileContent", new { id = id, Pt = pt, fType = fType });
                var applicationPath = HttpContext.Current?.Request.ApplicationPath?.TrimStart('/');
                url = string.IsNullOrWhiteSpace(applicationPath) ? $"/FileContent/{pt}/{fType}/{id}" : $"/{applicationPath}/FileContent/{pt}/{fType}/{id}";
            }
            return url;
        }
    }
}
