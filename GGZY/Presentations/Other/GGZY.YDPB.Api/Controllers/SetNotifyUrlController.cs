using GGZY.Core.Models;
using GGZY.YDPB.Api.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GGZY.YDPB.Api.Controllers
{
    public class SetNotifyUrlController : BaseApiController
    {
        [HttpPost]
        public GeneralResult Index([FromBody]RequestModel dic)
        {
            GeneralResult result = new GeneralResult();
            var dataStr = JsonConvert.SerializeObject(dic.data);

            ApplyModel apply = Newtonsoft.Json.JsonConvert.DeserializeObject<ApplyModel>(dataStr);

            string url = apply.NOTIFY_URL;
            string area_code = apply.AREA_CODE;

            return Jd.TradeCenterService.I_Set_Notify_Url(area_code,url);
        }
    }
}