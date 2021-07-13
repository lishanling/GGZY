using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 住建流程可选项配置
    /// </summary>
    public class AUDIT_OPTIONS
    {
        public string post_url { get; set; }
        public List<Dictionary<string, object>> config;
    }

    public class AUDIT_OPTION_TEXTVALUE
    {
        public string TEXT { get; set; }
        public string VALUE { get; set; }
        public string CHECKED { get; set; }
    }
}
