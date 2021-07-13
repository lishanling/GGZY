using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.Infrastructure.Model.BigData
{
    public class StatisticsSupervisionSearchModel
    {
        public string TenderType { get; set; }
        public string RegionCode { get; set; }
        public string TimeType { get; set; } //1按月 2按季 3按年
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
