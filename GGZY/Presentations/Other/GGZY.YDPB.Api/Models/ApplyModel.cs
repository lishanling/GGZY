using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GGZY.YDPB.Api.Models
{
    public class ApplyModel
    {
        public string AREA_CODE { get; set; }
        public string CENTER_NAME { get; set; }
        public string TENDER_PROJECT_NAME { get; set; }
        public string TENDER_PROJECT_CODE { get; set; }
        public string TENDER_AGENCY_NAME { get; set; }
        public string TENDER_AGENCY_CODE { get; set; }
        public string TENDER_AGENT_CONTRACT { get; set; }
        public string TENDER_AGENT_PHONE { get; set; }
        public string BID_EVAL_START_TIME { get; set; }
        public string BID_EVAL_END_TIME { get; set; }
        public string EVAL_ROOM_NAME { get; set; }
        public string EVAL_ROOM_ADDR { get; set; }
        public List<string> SEAT_NUMBER { get; set; }
        public List<ApplyDetail> SUB_DETAIL { get; set; }

        public string ORIGINAL_SERIES_NUMBER{get;set;}
       /// <summary>
       /// 申请单编号
       /// </summary>
        public string SERIES_NUMBER { get; set; }

        public string REMARK { get; set; }

        public string NOTIFY_URL { get; set; }
        /// <summary>
        /// 分会场审批状态
        /// </summary>
        public int? STATUS { get; set; }

    }
    public class ApplyDetail
    {
        public string AREA_CODE { get; set; }
        public string CENTER_NAME { get; set; }
        public int SEAT_COUNT { get; set; }
    }
}