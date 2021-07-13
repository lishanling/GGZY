using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GGZY.JianDu.Models
{
    public class RECORD_CREDIT_DEDUCTION_REQUEST
    {
        /// <summary>
        /// 备案ID
        /// </summary>
        public decimal? RECORD_ID { get; set; }
        /// <summary>
        /// 备案创建人
        /// </summary>
        public decimal? CREATOR { get; set; }         
        /// <summary>
        /// 时间搜索-季度
        /// </summary>
        public int? TIMERANGE { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? BeginTM { get; set; }         
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? EndTM { get; set; }
        /// <summary>
        /// 问题属性
        /// </summary>
        public string PROBLEM_ATTRIBUTE { get; set; }
        /// <summary>
        /// 备案环节
        /// </summary>
        public string REVIEW_TYPE { get; set; }
        /// <summary>
        /// 备案部门
        /// </summary>
        public decimal? RECORD_DEPID { get; set; }    
        /// <summary>
        /// 招标项目类型  SYS_DIC=>ID 2002
        /// </summary>
        public string TENDER_PROJECT_TYPE { get; set; }
    }
}