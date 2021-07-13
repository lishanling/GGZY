using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.DZBH.ParamModel
{
    /// <summary>
    /// 修改状态的入参
    /// </summary>
    public class ChangeStatusModel
    {
        public string ORDER_ID { get; set; }
        public string GUARANTEE_NO { get; set; }
        public string STATUS { get; set; }
        public string REMARK { get; set; }
    }
}
