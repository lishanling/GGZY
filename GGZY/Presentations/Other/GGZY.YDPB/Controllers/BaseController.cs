using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Configuration;
using GGZY.Framework.Infrastructure.Filters;
using GGZY.Services;
using GGZY.Services.Base;

namespace GGZY.YDPB.Controllers
{
    [ApiAuthorizationFilter]
    public class BaseController: GGZY.Framework.Controllers.BaseApiController
    {
        public string BaseUrl = ConfigurationManager.AppSettings["unify_login_url"].ToString();
        
    }
}