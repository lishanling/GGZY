using GGZY.Core.Models;
using GGZY.YDPB.Api.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GGZY.YDPB.Api.Controllers
{
    public class HallController : BaseApiController
    {
        [Route("api/hall")]
        [HttpPost]
        public GeneralResult Detail()
        {
            return Jd.TradeCenterService.I_ListAll();
        }
       
    }
}
