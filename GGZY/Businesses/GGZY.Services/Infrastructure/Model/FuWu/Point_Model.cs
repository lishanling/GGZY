using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.Infrastructure.Model.FuWu
{
    
    public partial class Point_Model
    {

        /// <summary>
        /// M_ID
        /// </summary>
        public string M_ID { get; set; }

        /// <summary>
        /// 监督点名称
        /// </summary>
        public string SP_NAME { get; set; }
        /// <summary>
        /// 监督方式
        /// </summary>
        public string SP_WAY { get; set; }

        /// <summary>
        /// 监督点类型
        /// </summary>
        public string SP_TYPE { get; set; }

        /// <summary>
        /// 监督时间
        /// </summary>
        public DateTime? SP_TIME { get; set; }

        /// <summary>
        /// 所属环节（当前环节）
        /// </summary>
        public string SP_FLOW_NAME { get; set; }

        /// <summary>
        /// 状态（0未监督 1绿 2黄 3红）
        /// </summary>
        public string RESULT_STATUS { get; set; }

        /// <summary>
        /// 招标项目名称
        /// </summary>
        public string TENDER_PROJECT_NAME { get; set; }


        /// <summary>
        /// 招标项目编号
        /// </summary>
        public string TENDER_PROJECT_CODE { get; set; }

        /// <summary>
        /// 审查单位ID
        /// </summary>
        public string APPROVAL_DEPID { get; set; }
        

        /// <summary>
        /// 预警内容
        /// </summary>
        public string REMARK { get; set; }
    }
}
