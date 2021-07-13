using System;
using System.Data;


namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 实体类PT_COMPLAIN。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class PtComplainModel
    {
        #region Model


        /// <summary>
        /// 
        /// </summary>
        public decimal? ID { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string TITLE { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public string TYPE { get; set; }
        /// <summary>
        /// 来源
        /// </summary>
        public string SOURCES { get; set; }
        /// <summary>
        /// 发布日期
        /// </summary>
        public DateTime? TM { get; set; }
        /// <summary>
        /// 发布人员ID
        /// </summary>
        public decimal? USER_ID { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string CONTENTS { get; set; }
        /// <summary>
        /// 附件
        /// </summary>
        public string AIDS { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime? CREATE_TM { get; set; }
        /// <summary>
        /// 在线投诉(PT_ZXTS)ID
        /// </summary>
        public decimal? TS_ID { get; set; }
        /// <summary>
        /// 是否公开
        /// </summary>
        public decimal? IS_PUBLIC { get; set; }
        #endregion


    }
}