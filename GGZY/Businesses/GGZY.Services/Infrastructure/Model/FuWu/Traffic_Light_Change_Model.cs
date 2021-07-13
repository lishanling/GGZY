using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.Infrastructure.Model.FuWu
{
    /// <summary>
    /// 招投标过程监督，红绿灯变更
    /// </summary>
    public partial class Traffic_Light_Change_Model
    {
          /// <summary>
            /// M_ID
            /// </summary>
            public string M_ID { get; set; }
            /// <summary>
            /// 状态（0未监督 1绿 2黄 3红）
            /// </summary>
            public string RESULT_STATUS { get; set; }
            /// <summary>
            /// 预警内容
            /// </summary>
            public string REMARK { get; set; }
      
    }
}
