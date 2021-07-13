using System.Collections.Generic;
using Newtonsoft.Json;

namespace GGZY.Services.Infrastructure.Model.BigData
{
    /// <summary>
    /// 横(X)轴
    /// </summary>
    public class ChartxAxis
    {
        public ChartxAxis()
        {
            Data=new List<string>();
        }
        [JsonProperty("data")]
        public List<string> Data { get; set; }
    }
}