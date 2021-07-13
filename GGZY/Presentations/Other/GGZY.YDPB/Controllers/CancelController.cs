using GGZY.Core.Models;
using GGZY.Framework.Infrastructure.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GGZY.YDPB.Controllers
{
    public class CancelController : BaseController
    {
        [ApiAuthorizationFilter(Roles = "agency")]
        [HttpPost]
        public GeneralResult Index([FromBody] dynamic dic)
        {
            return Jd.YdpbEvalApplyService.Cancel(dic);
        }
        [ApiAuthorizationFilter(Roles = "tradingCenter")]
        [Route("api/cancel/audit")]
        [HttpPost]
        public GeneralResult Audit([FromBody] dynamic dic)
        {
            return Jd.YdpbEvalApplyService.AuditCancel(dic);
        }

    }
}
