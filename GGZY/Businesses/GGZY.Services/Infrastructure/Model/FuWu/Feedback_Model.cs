using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.Infrastructure.Model.FuWu
{
    public partial class Feedback_Model
    {
        /// <summary>
        /// M_ID
        /// </summary>
        public string M_ID { get; set; }
        /// <summary>
        /// 监督点名称
        /// </summary>
        public string SP_NAME { get; set; }
        /// <summary>
        /// 监督规则
        /// </summary>
        public string SP_POINT_RULE { get; set; }
        /// <summary>
        /// 招标项目名称
        /// </summary>
        public string TENDER_PROJECT_NAME { get; set; }
        /// <summary>
        /// 招标项目编号
        /// </summary>
        public string TENDER_PROJECT_CODE { get; set; }
        /// <summary>
        /// 审查单位ID
        /// </summary>
        public string APPROVAL_DEPID { get; set; }
        /// <summary>
        /// 审查单位名称
        /// </summary>
        public string APPROVAL_NAME { get; set; }
        /// <summary>
        /// 审查单位电话
        /// </summary>
        public string APPROVAL_PHONE { get; set; }
        /// <summary>
        /// 预警内容
        /// </summary>
        public string CONTENT { get; set; }
    }
}
