using GGZY.Core.Models;
using GGZY.YDPB.Api.Common;
using GGZY.YDPB.Api.Models;
using GGZYJD.DbEntity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GGZY.YDPB.Api.Controllers
{
    public class NotifyController : BaseApiController
    {

        // POST api/<controller>
        public GeneralResult Post([FromBody]RequestModel dic)
        {
            var result = new GeneralResult();
            if (null == dic)
            {
                result.SetFail("参数解析失败，请检查提交报文格式是否正确");
                return result;
            }
            var model = new ApplyModel();
            var dataStr = JsonConvert.SerializeObject(dic.data);
            ApplyModel apply = Newtonsoft.Json.JsonConvert.DeserializeObject<ApplyModel>(dataStr);

            var SERIES_NUMBER = apply.SERIES_NUMBER;
            var STATUS = apply.STATUS;
            var AREA_CODE = apply.AREA_CODE;
            var CENTER_NAME = apply.CENTER_NAME;
            var SEAT_NUMBER = apply.SEAT_NUMBER;
            var EVAL_ROOM_NAME = apply.EVAL_ROOM_NAME;
            var EVAL_ROOM_ADDR = apply.EVAL_ROOM_ADDR;
            var REMARK = apply.REMARK;
            return Jd.YdpbEvalApplyService.I_Audit(SERIES_NUMBER, STATUS, AREA_CODE, CENTER_NAME, EVAL_ROOM_NAME, EVAL_ROOM_ADDR, SEAT_NUMBER, REMARK);
        }
    }
}