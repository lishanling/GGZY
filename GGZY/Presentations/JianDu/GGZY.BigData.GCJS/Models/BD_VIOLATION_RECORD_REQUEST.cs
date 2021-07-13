using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GGZY.BigData.GCJS.Models
{
    public class BD_VIOLATION_RECORD_REQUEST
    {
        /// <summary>
        /// 招标项目代码
        /// </summary>
        public string TENDER_PROJECT_CODE { get; set; }
        /// <summary>
        /// 招标项目名称
        /// </summary>
        public string TENDER_PROJECT_NAME { get; set; }
        /// <summary>
        /// 行业类型
        /// </summary>
        public string TENDER_PROJECT_TYPE { get; set; }
        /// <summary>
        /// 地区编码
        /// </summary>
        public string AREA_CODE { get; set; }

        public DateTime? DATETIME_START { get; set; }

        public DateTime? DATETIME_END { get; set; }
        /// <summary>
        /// 疑似违规点代码
        /// </summary>
        public string POINT_CODE { get; set; }

        public decimal? STATE { get; set; }

    }
}