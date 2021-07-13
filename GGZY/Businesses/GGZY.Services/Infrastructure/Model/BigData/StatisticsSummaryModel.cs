using System;

namespace GGZY.Services.Infrastructure.Model.BigData
{
    public class StatisticsSummaryModel
    {
        /// <summary>
        /// 总数
        /// </summary>
        public Int64 TOTAL_COUNT { get; set; } = 0;
        /// <summary>
        /// 新增
        /// </summary>
        public Int64? ADD_COUNT { get; set; } = 0;
        /// <summary>
        /// 活跃
        /// </summary>
        public Int64 ACTIVE_COUNT { get; set; } = 0;
        /// <summary>
        /// 总次数
        /// </summary>
        public Int64 PROJECT_COUNT { get; set; } = 0;
    }
}