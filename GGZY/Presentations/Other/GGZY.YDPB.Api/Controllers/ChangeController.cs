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
    /// <summary>
    /// 申请单变更
    /// </summary>
    public class ChangeController : BaseApiController
    {
 
        [HttpPost]
        public GeneralResult Index([FromBody] RequestModel dic)
        {
            GeneralResult result = new GeneralResult();
            var dataStr = JsonConvert.SerializeObject(dic.data);

            ApplyModel apply = Newtonsoft.Json.JsonConvert.DeserializeObject<ApplyModel>(dataStr);
            YDPB_EVAL_APPLY entity = new YDPB_EVAL_APPLY();
            entity.APPLY_TYPE = 0;
            entity.BID_EVAL_END_TIME = apply.BID_EVAL_END_TIME.ToDateTimeFromFormat();
            entity.BID_EVAL_START_TIME = apply.BID_EVAL_START_TIME.ToDateTimeFromFormat();
            entity.TENDER_PROJECT = apply.TENDER_PROJECT_NAME;
            entity.TENDER_PROJECT_CODE = apply.TENDER_PROJECT_CODE;
            entity.TENDER_AGENCY_NAME = apply.TENDER_AGENCY_NAME;
            entity.TENDER_AGENCY_CODE = apply.TENDER_AGENCY_CODE;
            entity.TENDER_AGENT_CONTRACT = apply.TENDER_AGENT_CONTRACT;
            entity.TENDER_AGENT_PHONE = apply.TENDER_AGENT_PHONE;
            entity.F_SERIES_NUMBER = apply.ORIGINAL_SERIES_NUMBER;
            entity.REMARK = apply.REMARK;


            List<YDPB_EVAL_APPLY_DETAIL> details = new List<YDPB_EVAL_APPLY_DETAIL>();

            var mainDetail = new YDPB_EVAL_APPLY_DETAIL();
            mainDetail.EXPERT_COUNT = apply.SEAT_NUMBER.Count();
            mainDetail.IS_MAIN = 1;
            mainDetail.STATUS = 1;
            mainDetail.AREA_CODE = apply.AREA_CODE;
            mainDetail.CENTER_NAME = apply.CENTER_NAME;
            details.Add(mainDetail);

            apply.SUB_DETAIL.ForEach(e => {
                var detail = new YDPB_EVAL_APPLY_DETAIL();
                detail.EXPERT_COUNT = e.SEAT_COUNT;
                detail.AREA_CODE = e.AREA_CODE;
                detail.CENTER_NAME = e.CENTER_NAME;
                detail.IS_MAIN = 0;
                details.Add(detail);
            });

            YDPB_EVAL_ROOM_SEAT_RECORD seat = new YDPB_EVAL_ROOM_SEAT_RECORD();
            seat.EVAL_ROOM_NAME = apply.EVAL_ROOM_NAME;
            seat.END_TIME = entity.BID_EVAL_END_TIME;
            seat.START_TIME = entity.BID_EVAL_START_TIME;
            return Jd.YdpbEvalApplyService.I_Change(entity, details, seat, apply.SEAT_NUMBER);
        }   
    }
}