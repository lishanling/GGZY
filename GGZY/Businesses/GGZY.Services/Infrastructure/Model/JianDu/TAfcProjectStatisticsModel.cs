using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 查询报建审批Model
    /// </summary>
    [Serializable]
    public partial class TAfcProjectStatisticsModel
    {
        /// <summary>
        /// 工程类别
        /// </summary>
        public string PROJECT_TYPE { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? BeginTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// 地区
        /// </summary>
        public string REGION_CODE { get; set; }
        /// <summary>
        /// 日期类型 today week month year
        /// </summary>
        public string TimType { get; set; }

        public List<string> TENDER_PROJECT_TYPES =>
            PROJECT_TYPE?.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries).ToList();
    }
}
