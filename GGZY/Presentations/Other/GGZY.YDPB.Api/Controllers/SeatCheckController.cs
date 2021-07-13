using GGZY.Core.Models;
using GGZY.YDPB.Api.Common;
using GGZY.YDPB.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GGZY.YDPB.Api.Controllers
{
    public class SeatCheckController : BaseApiController
    {
        [HttpPost]
        public GeneralResult Index([FromBody]RequestModel dic)
        {
            GeneralResult result = new GeneralResult();
            if(null == dic.data)
            {
                result.SetFail("数据集信息缺失");
                return result;
            }
            if(!(dic.data.ContainsKey("AREA_CODE") && dic.data.ContainsKey("BID_EVAL_START_TIME") 
                && dic.data.ContainsKey("BID_EVAL_END_TIME") && dic.data.ContainsKey("SEAT_COUNT")))
            {
                result.SetFail("输入参数信息缺失");
                return result;
            }
            var areacode = dic.data["AREA_CODE"].ToString();
            var bidEvalStart = dic.data["BID_EVAL_START_TIME"].ToString().ToDateTimeFromFormat();
            var bidEvalEnd = dic.data["BID_EVAL_END_TIME"].ToString().ToDateTimeFromFormat();
            var count = Convert.ToInt32(dic.data["SEAT_COUNT"]);

            if(DateTime.MinValue.Equals(bidEvalStart) || DateTime.MinValue.Equals(bidEvalEnd))
            {
                result.SetFail("预计评标开始时间/结束时间 错误");
                return result;
            }

            return Jd.YdpbEvalRoomService.I_Seat_Check(areacode,count,bidEvalStart,bidEvalEnd);
        }
    }
}
