using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.BigData.Model
{
    public class CorrelationConfigModel
    {
        public string name { get; set; }
        public List<RuleModel> ruleList { get; set; }

    }

    public class RuleModel
    {
        public string id { get; set; }
        public string ruleName { get; set; }
        public string @operator { get; set; }
        public int number { get; set; }
        public string remark { get; set; }
    }
}
