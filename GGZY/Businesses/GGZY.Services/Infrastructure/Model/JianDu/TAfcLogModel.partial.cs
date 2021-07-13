using System;
using System.Collections.Generic;
using GGZY.Core.Models;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public partial class TAfcLogModel
    {
        public string MID { get; set; }
        public string PROJECT_TYPE_NAME { get; set; }
        public string REGION_CITY_NAME { get; set; }

        public string REGION_COUNTY_NAME { get; set; }
        public string REGION => $"{REGION_CITY_NAME}{REGION_COUNTY_NAME}";

        public string APPROVAL_STATE_NAME { get; set; }
        public string ISMAJOR_NAME { get; set; }
        public string IS_DJZ_NAME { get; set; }
        public string RECORDER_TACHE_NAME { get; set; }
        public string TENDER_ORGANIZE_FORM_NAME { get; set; }
        public string APPROVAL_STATE_TACHE_NAME => $"{APPROVAL_STATE_NAME}({RECORDER_TACHE_NAME})";
        public string APPROVAL_DEPNAME { get; set; }
        public string OPRATION { get; set; }

        public bool IsV9527 => (!string.IsNullOrWhiteSpace(APPROVAL_LEVEL) || APPROVAL_DATE.HasValue ||
                                GOVERNMENT_INVEST_FINANCE.HasValue);
        /// <summary>
        /// 推送数量
        /// </summary>
        public int SendCount { get; set; }

        
        public string RECORDER_UID_NAME { get; set; }
        
        public string RECORDER_OPERATION_NAME { get; set; }
        /// <summary>
        /// 附件地址
        /// </summary>
        public List<UploadResData> Attachments { get; set; }
    }
}