using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 流程记录人员-非数据库
    /// </summary>
    public class YW_FLOW_USER
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int USER_ID { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string MANAGE_NAME { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string DNAME { get; set; }
        /// <summary>
        /// 部门ID
        /// </summary>
        public int DEPID { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string TELPHONE { get; set; }
        public int IS_MAIN { get; set; }
        public int IS_SELECT { get; set; }
    }
}
