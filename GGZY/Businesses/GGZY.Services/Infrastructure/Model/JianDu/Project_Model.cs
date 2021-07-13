using System;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 项目模型
    /// </summary>
    public partial class Project_Model
    {
        //  行政监督-招投标项目监督新建模型

        /// <summary>
        /// M_ID
        /// </summary>
        public string M_ID { get; set; }

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
        /// 地区
        /// </summary>
        public string REGION_CODE { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        public string TENDER_PROJECT_TYPE { get; set; }

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
        /// 代理机构自己的交易编码
        /// </summary>
        public string TENDER_PROJECT_CODE_OLD1 { get; set; }

        /// <summary>
        /// 招标项目编号
        /// </summary>
        public string TENDER_PROJECT_CODE { get; set; }

        /// <summary>
        /// 审查单位ID
        /// </summary>
        public string APPROVAL_DEPID { get; set; }
        /// <summary>
        /// 审查单位名称
        /// </summary>
        public string APPROVAL_NAME { get; set; }

        /// <summary>
        /// 正常监督点
        /// </summary>
        public int NORMAL { get; set; }

        /// <summary>
        /// 异常监督点
        /// </summary>
        public int STRANG { get; set; }
        /// <summary>
        /// 监督点总数 
        /// </summary>
        public int ALL { get; set; }
        /// <summary>
        /// 黄灯监督点总数 
        /// </summary>
        public int WARNING { get; set; }
        /// <summary>
        /// 业务类型(用于返回G01 G02)
        /// </summary>
        public string G_TENDER_PROJECT_TYPE { get; set; }


    }
}