using System.Collections.Generic;
using Newtonsoft.Json;

namespace GGZY.Services.Infrastructure.Model.BigData
{
    public class PieSeries:IChartSeries
    {
        public PieSeries() : this(string.Empty)
        {

        }

        public PieSeries(string name)
        {
            Name = name;
            Data = new List<PieSeriesData>();
        }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("data")]
        public List<PieSeriesData> Data { get; set; }
    }
}