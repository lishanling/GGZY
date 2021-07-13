using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GGZY.Core.Models;

namespace GGZY.Services.DZBH.ParamModel
{
    /// <summary>
    /// 首页和列表的搜索字段
    /// </summary>
    public class ListSearchModel : SearchCondition
    {
        public string OrderId { get; set; }
        public string GuranteeNo { get; set; }
        public string Status { get; set; }
        public DateTime StartOpenTime { get; set; }
        public DateTime EndOpenTime { get; set; }
        public string TenderProjectCode { get; set; }
        public string TenderProjectName { get; set; }
        public string SectionCode { get; set; }
        public string SectionName { get; set; }
    }
}
