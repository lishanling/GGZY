using System.Collections.Generic;
using Newtonsoft.Json;

namespace GGZY.Services.Infrastructure.Model.BigData
{
    public class ChartOptionModel
    {
        public ChartOptionModel()
        {
            XAxis=new ChartxAxis();
            Series=new List<IChartSeries>();
        }
        [JsonProperty("xAixs")]
        public ChartxAxis XAxis { get; set; }
        [JsonProperty("series")]
        public List<IChartSeries> Series { get; set; }
    }
   

}