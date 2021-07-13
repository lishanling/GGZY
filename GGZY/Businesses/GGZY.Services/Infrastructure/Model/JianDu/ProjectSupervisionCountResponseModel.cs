using Newtonsoft.Json;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 项目处理信息汇总
    /// </summary>
    public class ProjectSupervisionCountResponseModel
    {
        /// <summary>
        /// 事项类型
        /// </summary>
        public string Label { get; set; }
        /// <summary>
        /// 处理总数(个)
        /// </summary>
        public int DoneCount { get; set; }
        /// <summary>
        /// 待办(个)
        /// </summary>
        public int? UndoCount { get; set; }
    }

    /// <summary>
    /// 项目交易数据统计
    /// </summary>
    public class ProjectSupervisionTradeCountResponseModel
    {
        /// <summary>
        /// 行业类型
        /// </summary>
        public string Label { get; set; }
        /// <summary>
        /// 今日新增项目数（个）
        /// </summary>
        public int TodayAdd { get; set; }
        /// <summary>
        /// 今日交易项目金额
        /// </summary>
        [JsonIgnore]
        public decimal? TodayAmount { get; set; }

        /// <summary>
        /// 今日交易项目金额
        /// </summary>
        [JsonProperty("TodayAmount")]
        public string TodayAmountStr => TodayAmount?.ToString("#.##");
        /// <summary>
        /// 交易项目总数（个）
        /// </summary>
        public int AllTradeCount { get; set; }
        /// <summary>
        /// 交易项目总金额
        /// </summary>
        [JsonIgnore]
        public decimal? AllAmount { get; set; }

        /// <summary>
        /// 交易项目总金额
        /// </summary>
        [JsonProperty("AllAmount")]
        public string AllAmountStr => AllAmount?.ToString("#.##");
    }
}

