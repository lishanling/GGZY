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
    public class QueryController : BaseApiController
    {
        [HttpPost]
        public GeneralResult Index([FromBody] RequestModel dic)
        {
            GeneralResult result = new GeneralResult();
            var dataStr = JsonConvert.SerializeObject(dic.data);

            ApplyModel apply = Newtonsoft.Json.JsonConvert.DeserializeObject<ApplyModel>(dataStr);

            string tender_project_code = apply.TENDER_PROJECT_CODE;
            string area_code = apply.AREA_CODE;
            string series_number = apply.SERIES_NUMBER;
            return Jd.YdpbEvalApplyService.I_Query(series_number,tender_project_code, area_code);

        }
    }
}
