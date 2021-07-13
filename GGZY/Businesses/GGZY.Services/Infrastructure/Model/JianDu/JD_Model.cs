using System;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    #region 模型
    /// <summary>
    /// 监督点模型
    /// </summary>
    public partial class JD_Model
    {
        /// <summary>
        /// 监督点统计个数接口模型
        /// </summary>

        /// <summary>
        /// M_ID
        /// </summary>
        public decimal? M_ID { get; set; }

        /// <summary>
        /// 监督点名称
        /// </summary>
        public string SP_NAME { get; set; }


        /// <summary>
        /// 监督点类型
        /// </summary>
        public string SP_TYPE { get; set; }

        /// <summary>
        /// 监督时间
        /// </summary>
        public DateTime? SP_TIME { get; set; }

        /// <summary>
        /// 监督方式
        /// </summary>
        public string SP_WAY { get; set; }

        /// <summary>
        /// 地区
        /// </summary>
        public string REGION_CODE { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        public string TENDER_PROJECT_TYPE { get; set; }

        /// <summary>
        /// 所属环节
        /// </summary>
        public string SP_FLOW_NAME { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public string SP_STATUS { get; set; }

        /// <summary>
        /// 招标项目名称
        /// </summary>
        public string TENDER_PROJECT_NAME { get; set; }
        /// <summary>
        /// 审查单位ID
        /// </summary>
        public string APPROVAL_DEPID { get; set; }
        /// <summary>
        /// 审查单位名称
        /// </summary>
        public string APPROVAL_NAME { get; set; }

        /// <summary>
        /// 业务类型(用于返回G01 G02)
        /// </summary>
        // public string TENDER_PROJECT_TYPE { get; set; }

    }
    

    #endregion
}