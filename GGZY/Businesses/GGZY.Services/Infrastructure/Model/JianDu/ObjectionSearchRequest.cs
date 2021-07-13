using System;
using GGZY.Core.Models;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 监督平台门户 异议处理结果公示 查询参数对象
    /// </summary>
    public class ObjectionSearchRequest:SearchCondition
    {
        /// <summary>
        /// 类型
        /// </summary>
        public string TenderProjectType { get; set; }
       
        /// <summary>
        /// 公示开始时间
        /// </summary>
        public DateTime? GsBeginTime { get; set; }
        /// <summary>
        /// 公示结束时间
        /// </summary>
        public DateTime? GsEndTime { get; set;  }
    }
}