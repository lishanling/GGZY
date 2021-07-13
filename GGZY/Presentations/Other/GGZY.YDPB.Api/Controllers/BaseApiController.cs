using GGZY.Core.Cache;
using GGZY.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GGZY.YDPB.Api.Controllers
{
    [Common.ApiAuthorizeFilter]
    public class BaseApiController : ApiController
    {
        /// <summary>
        /// 全局缓存
        /// </summary>
        public ICacheManager Cache => GlobalCache.Instance;

        /// <summary>
        /// 公共资源服务-业务工厂
        /// </summary>
        public ServicesFactoryFw Fw => ServicesFactory.GGZYFW;

        /// <summary>
        /// 公共资源监督-业务工厂
        /// </summary>
        public ServicesFactoryJd Jd => ServicesFactory.GGZYJD;
    }
}
