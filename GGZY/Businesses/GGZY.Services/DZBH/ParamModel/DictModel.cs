using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.DZBH.ParamModel
{
    public static class DictModel
    {
        public static Dictionary<string, string> StatusDict =>
            new Dictionary<string, string>()
            {
                {"1","暂存" },
                {"2","待审核" },
                {"3","待支付" },
                {"4","审核不通过" },
                {"5","投保合同待签订" },
                {"6","保函待开具" },
                {"9","其他" },
                {"10","完成" },
            };
        public static Dictionary<string, string> ProjectTypeDict =>
            new Dictionary<string, string>()
            {
                {"A01","房建" },
                {"A02","市政" },
                {"A03","公路" },
                {"A04","铁路" },
                {"A05","民航" },
                {"A06","水运" },
                {"A07","水利" },
                {"A08","能源" },
                {"A09","邮电通信" },
                {"A10","桥梁" },
                {"A11","城市轨道" },
                {"A12","矿产冶金" },
                {"A13","信息网络" },
                {"A14","工业制造" },
                {"A97","海洋渔港项目" },
                {"A98","园林绿化" },
                {"A99","其他" },
            };
    }
}
