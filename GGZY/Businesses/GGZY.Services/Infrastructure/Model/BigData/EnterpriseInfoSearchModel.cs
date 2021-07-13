using GGZY.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.Infrastructure.Model.BigData
{
   public class EnterpriseInfoSearchModel : SearchCondition
    {
        /// <summary>
        /// 页码 从1开始
        /// </summary>
        public int PageNo { get; set; } = 1;
        /// <summary>
        /// 页大小
        /// </summary>
        public int PageSize { get; set; } = 10;
        /// <summary>
        /// cpu序列号
        /// </summary>
        public string CPU_ID { get; set; }
        /// <summary>
        /// 硬盘序列号
        /// </summary>
        public string HDISK { get; set; }
        /// <summary>
        /// 网卡地址
        /// </summary>
        public string MAC_ADDRESS { get; set; }
        /// <summary>
        /// 企业名称
        /// </summary>
        public string BIDDER_NAME { get; set; }
        /// <summary>
        /// 统一信用代码
        /// </summary>
        public string BIDDER_ORG_CODE { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string BID_MANAGER { get; set; }
        /// <summary>
        /// 身份信息
        /// </summary>
        public string PM_CODE { get; set; }

    }
}
