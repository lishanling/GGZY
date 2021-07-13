using System;
using GGZYFW.DbEntity;

namespace GGZY.Services.Infrastructure.Model.FuWu
{
    public class FwWarnResultExpressionModel
    {
        public string M_ID { get; set; }
        /// <summary>
        /// 招标项目编号
        /// </summary>
        public string TENDER_PROJECT_CODE { get; set; }
        /// <summary>
        /// 项目编号
        /// </summary>
        public string PROJECT_CODE { get; set; }
        /// <summary>
        /// 标段编号
        /// </summary>
        public string BID_SECTION_CODE { get; set; }
        /// <summary>
        /// 状态（0未监督 1绿 2黄 3红）
        /// </summary>
        public string RESULT_STATUS { get; set; }

        /// <summary>
        /// 状态（0未监督 1绿 2黄 3红）
        /// </summary>
        public string RESULT_STATUS_TEXT =>
            RESULT_STATUS == "0" ? "未监督" :
            RESULT_STATUS == "1" ? "绿" :
            RESULT_STATUS == "2" ? "黄" :
            RESULT_STATUS == "3" ? "红" : "";
        /// <summary>
        /// 处理状态 1:待处理 2：已发出预警信息，3：已反馈，未修正， 4：超期未修正
        /// </summary>
        public string OPERATE_STATUS { get; set; }
        /// <summary>
        /// 处理状态 1:待处理 2：已发出预警信息，3：已反馈，未修正， 4：超期未修正
        /// </summary>
        public string OPERATE_STATUS_TEXT =>
            OPERATE_STATUS == "1" ? "待处理" :
            OPERATE_STATUS == "2" ? "已发出预警信息" :
            OPERATE_STATUS == "3" ? "已反馈，未修正" :
            OPERATE_STATUS == "4" ? "超期未修正" : "";
        /// <summary>
        /// 项目所在地区
        /// </summary>
        public string REGION_CODE { get; set; }
        /// <summary>
        /// 招标项目类型，区分住建水利交通
        /// </summary>
        public string TENDER_PROJECT_TYPE { get; set; }
        /// <summary>
        /// 监督点数据
        /// </summary>
        public string CONTENT { get; set; }
        /// <summary>
        /// 监督时间
        /// </summary>
        public DateTime? SP_TIME { get; set; }
        /// <summary>
        /// 时间戳
        /// </summary>
        public DateTime? DATA_TIMESTAMP { get; set; }
        /// <summary>
        /// 处理时限
        /// </summary>
        public DateTime? DEAL_LIMIT_TIME { get; set; }
        /// <summary>
        /// 最后处理时间
        /// </summary>
        public DateTime? LAST_RECORD_TIME { get; set; }
        /// <summary>
        /// 对应的监督点id
        /// </summary>
        public decimal? SP_ID { get; set; }
        /// <summary>
        /// 监督点名称
        /// </summary>
        public string SP_NAME { get; set; }
        /// <summary>
        /// 节点名称
        /// </summary>
        public string SP_NODE_NAME { get; set; }
        /// <summary>
        /// 所属环节
        /// </summary>
        public string SP_FLOW_NAME { get; set; }
        /// <summary>
        /// 监督类型
        /// </summary>
        public string SP_TYPE { get; set; }
        /// <summary>
        /// 监督方式
        /// </summary>
        public string SP_WAY { get; set; }
        /// <summary>
        /// 监督点规则描述
        /// </summary>
        public string SP_POINT_RULE { get; set; }
        /// <summary>
        /// 监督点大分类
        /// </summary>
        public string SP_POINT_TYPE { get; set; }
        /// <summary>
        /// 预警状态（1绿 2黄 3红）
        /// </summary>
        public string SP_STATUS { get; set; }
        /// <summary>
        /// 预警状态（1绿 2黄 3红）
        /// </summary>
        public string SP_STATUS_TEXT =>
            RESULT_STATUS == "1" ? "绿" :
            RESULT_STATUS == "2" ? "黄" :
            RESULT_STATUS == "3" ? "红" : "";

    }
}