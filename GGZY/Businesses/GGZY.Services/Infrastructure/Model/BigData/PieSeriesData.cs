using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace GGZY.Services.Infrastructure.Model.BigData
{
    /// <summary>
    /// 统计图表-饼图数据结构
    /// </summary>
    public class PieSeriesData
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("value")]
        public decimal? Value { get; set; }
    }
}