using System.Collections.Generic;
using Newtonsoft.Json;

namespace GGZY.Services.Infrastructure.Model.BigData
{
    public class LineBarSeries: IChartSeries
    {
        public LineBarSeries():this(string.Empty)
        {
           
        }

        public LineBarSeries(string name):this(name,string.Empty)
        {
           
        }
        public LineBarSeries(string name,string type)
        {
            Name = name;
            Type = string.Empty;
            Data = new List<decimal?>();
        }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("data")]
        public List<decimal?> Data { get; set; }
    }
}