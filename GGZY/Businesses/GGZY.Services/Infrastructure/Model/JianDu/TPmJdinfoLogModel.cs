using System;
using System.Data;


namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 实体类T_PM_JDINFO_LOG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class TPmJdinfoLogModel
    {
        #region Model


        /// <summary>
        /// ID
        /// </summary>
        public decimal? ID { get; set; }
        /// <summary>
        /// 招标项目编号
        /// </summary>
        public string TENDER_PROJECT_CODE { get; set; }
        /// <summary>
        /// 监督点ID
        /// </summary>
        public decimal? MPID { get; set; }
        /// <summary>
        /// 操作人
        /// </summary>
        public string U_ID { get; set; }
        /// <summary>
        /// 旧预警等级
        /// </summary>
        public string LEVEL_TYPE_OLD { get; set; }
        /// <summary>
        /// 新预警等级
        /// </summary>
        public string LEVEL_TYPE { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string REMARK { get; set; }
        /// <summary>
        /// 记录时间
        /// </summary>
        public DateTime? TM { get; set; }
        /// <summary>
        /// 业务流水号
        /// </summary>
        public string BUSINESSID { get; set; }
        #endregion


    }
}