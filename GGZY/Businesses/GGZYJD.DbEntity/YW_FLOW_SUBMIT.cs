using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZYJD.DbEntity
{
    public class YW_FLOW_SUBMIT
    {
        /// <summary>
        /// 备案记录ID
        /// </summary>
        public int RECORD_ID { get; set; }
        /// <summary>
        /// 流程记录ID
        /// </summary>
        public int? INSTANCE_ID { get; set; }

        /// <summary>
        /// 下一步骤流程ID
        /// </summary>
        public int? NEXT_NODE_ID { get; set; }
        /// <summary>
        /// 下一步骤处理人ID
        /// </summary>
        public string NEXT_NODE_USERID { get; set; }
        /// <summary>
        /// 牵头人
        /// </summary>
        public string NEXT_NODE_LEADER { get; set; }
        /// <summary>
        /// 退回操作类型 100 退回到上一步 2：不属于本部门监管 3：备案资料不完整,8:招标条件备案  已签收
        /// </summary>
        public string DYLX { get; set; }
    }
}
