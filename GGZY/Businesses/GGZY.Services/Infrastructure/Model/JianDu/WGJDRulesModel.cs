using System;
using GGZY.Core.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public partial class WGJDRuleModel
    {
        public List<UploadResData> FILES_ATTACHMENT { get; set; }

        /// <summary>
        /// 主键ID 自增
        /// </summary>
        public decimal? ID { get; set; }
        /// <summary>
        /// 附件
        /// </summary>
        public string GUIDS { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string STATE { get; set; }
        /// <summary>
        /// 处理时间
        /// </summary>
        public string OPERATION_TIME { get; set; }
        /// <summary>
        /// 处理人
        /// </summary>
        public string OPERATION_USER { get; set; }
        /// <summary>
        /// 违规行为ID
        /// </summary>
        public string VIOLATION_RECORD_ID { get; set; }
        /// <summary>
        /// 记录内容
        /// </summary>
        public string DESCRIPTION { get; set; }
    }
}
