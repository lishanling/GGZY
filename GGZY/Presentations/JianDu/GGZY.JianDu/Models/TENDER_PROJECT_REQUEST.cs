using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GGZY.JianDu.Models
{
    public class TENDER_PROJECT_REQUEST
    {
        /// <summary>
        /// 招标项目名称
        /// </summary>
        public string TENDER_PROJECT_NAME { get; set; }
        /// <summary>
        /// 招标项目编号
        /// </summary>
        public string TENDER_PROJECT_CODE { get; set; }
        /// <summary>
        /// 备案类型
        /// </summary>
        public string REVIEW_TYPE { get; set; }
        /// <summary>
        /// 节点名称
        /// </summary>
        public string NODE_NAME { get; set; }
        /// <summary>
        /// 备案状态
        /// </summary>
        public int? REVIEW_STATUS { get; set; }
        /// <summary>
        /// 是否签收
        /// </summary>
        public int? Is_SIGN { get; set; }
        /// <summary>
        /// 是否签章
        /// </summary>
        public int? IS_SIGNUP { get; set; }

        /// <summary>
        /// 审查归属
        /// </summary>
        public int? REVIEW_ASCRIPTION { get; set; }
    }
}