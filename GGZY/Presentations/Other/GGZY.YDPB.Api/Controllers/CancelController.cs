using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GGZY.Core.Models;
using GGZY.YDPB.Api.Common;
using GGZY.YDPB.Api.Models;
using GGZYJD.DbEntity;
using Newtonsoft.Json;

namespace GGZY.YDPB.Api.Controllers
{
    public class CancelController : BaseApiController
    {
        
        // POST api/<controller>
        [HttpPost]
        public GeneralResult Index([FromBody]RequestModel dic)
        {
            GeneralResult result = new GeneralResult();
            var dataStr = JsonConvert.SerializeObject(dic.data);

            ApplyModel apply = Newtonsoft.Json.JsonConvert.DeserializeObject<ApplyModel>(dataStr);

            YDPB_EVAL_APPLY entity = new YDPB_EVAL_APPLY();
            entity.F_SERIES_NUMBER = apply.ORIGINAL_SERIES_NUMBER;
            entity.APPLY_TYPE = 1;
            entity.TENDER_PROJECT = apply.TENDER_PROJECT_NAME;
            entity.TENDER_PROJECT_CODE = apply.TENDER_PROJECT_CODE;
            entity.TENDER_AGENCY_NAME = apply.TENDER_AGENCY_NAME;
            entity.TENDER_AGENCY_CODE = apply.TENDER_AGENCY_CODE;
            entity.TENDER_AGENT_CONTRACT = apply.TENDER_AGENT_CONTRACT;
            entity.TENDER_AGENT_PHONE = apply.TENDER_AGENT_PHONE;
            entity.REMARK = apply.REMARK;
            return Jd.YdpbEvalApplyService.I_Cancel(entity);
        }
    }
}