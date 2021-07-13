using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GGZY.BigData.GCJS.Models
{
    /// <summary>
    /// 疑似违规主体请求
    /// </summary>
    public class BD_VIOLATION_ENTITY_REQUEST
    {/// <summary>
     /// 招标项目代码
     /// </summary>
        public string ENTITY_CODE { get; set; }
        /// <summary>
        /// 主体名称
        /// </summary>
        public string ENTITY_NAME { get; set; }
        /// <summary>
        /// 主体编码
        /// </summary>
        public string AREA_CODE { get; set; }

        public DateTime? DATETIME_START { get; set; }

        public DateTime? DATETIME_END { get; set; }
        /// <summary>
        /// 疑似违规点代码
        /// </summary>
        public string POINT_CODE { get; set; }
        /// <summary>
        /// 主体类型
        /// </summary>
        public decimal ENTITY_TYPE { get; set; }

        public decimal? STATE { get; set; }

    }
}