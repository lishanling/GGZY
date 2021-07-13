using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.Infrastructure.Model.BigData
{
    public class EnterpriseInfoSameDetailModel
    {
        /// <summary>
        /// 企业名称
        /// </summary>
        public string BIDDER_NAME { get; set; }
        /// <summary>
        /// 统一信用代码
        /// </summary>
        public string BIDDER_ORG_CODE { get; set; }
        /// <summary>
        /// 招标项目编号
        /// </summary>
        public string TENDER_PROJECT_CODE { get; set; }
        /// <summary>
        /// 招标项目名称
        /// </summary>
        public string TENDER_PROJECT_NAME { get; set; }
        /// <summary>
        /// 项目开标时间
        /// </summary>
        public DateTime OPEN_TIME { get; set; }
        /// <summary>
        /// 地区
        /// </summary>

        public string REGION_CODE { get; set; }
        /// <summary>
        /// 是否中标
        /// </summary>

        public int ISWIN { get; set; }
        /// <summary>
        /// 投标时间
        /// </summary>

        public DateTime CHECKIN_TIME { get; set; }

    }
}
