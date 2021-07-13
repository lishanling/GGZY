using System;
using System.Data;


namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 实体类T_SUPERVISE_LOG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class TSuperviseResultLogModel
    {
        #region Model


        /// <summary>
        /// 
        /// </summary>
        public string M_ID { get; set; }
        /// <summary>
        /// 实体对象名称T_AFC_PROJECT PT_ZXTS
        /// </summary>
        public string ENTITY_TYPE_NAME { get; set; }
        /// <summary>
        /// 实体记录主键值
        /// </summary>
        public decimal? ENTITY_ID { get; set; }
        /// <summary>
        /// 实体记录归属地
        /// </summary>
        public string ENTITY_REGION_CODE { get; set; }
        /// <summary>
        /// 实体记录行业
        /// </summary>
        public string ENTITY_TENDER_PROJECT_TYPE { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public decimal? STATUS { get; set; }
        /// <summary>
        /// 监察名称
        /// </summary>
        public string SUPERVISE_NAME { get; set; }
        /// <summary>
        /// 监察类型
        /// </summary>
        public string SUPERVISE_TYPE { get; set; }
        /// <summary>
        /// 监察方式
        /// </summary>
        public string SUPERVISE_WAY { get; set; }
        /// <summary>
        /// 督察时间
        /// </summary>
        public DateTime? SUPERVISE_TIME { get; set; }
        /// <summary>
        /// 监察规则
        /// </summary>
        public string SUPERVISE_REMARK { get; set; }
        /// <summary>
        /// 监察人员id
        /// </summary>
        public string SUPERVISE_OP_ID { get; set; }
        /// <summary>
        /// 监察人员名称
        /// </summary>
        public string SUPERVISE_OP_NAME { get; set; }
        /// <summary>
        /// 监察人员部门id
        /// </summary>
        public string SUPERVISE_DEP_ID { get; set; }
        /// <summary>
        /// 监察人员部门名称
        /// </summary>
        public string SUPERVISE_DEP_NAME { get; set; }
        /// <summary>
        /// 督查主键
        /// </summary>
        public string SUPERVISE_ID { get; set; }
        #endregion
        /// <summary>
        /// 实体记录招标项目编号
        /// </summary>
        public string ENTITY_TENDER_PROJECT_CODE { get; set; }
        /// <summary>
        /// 实体记录招标项目名称
        /// </summary>
        public string ENTITY_TENDER_PROJECT_NAME { get; set; }

    }
}