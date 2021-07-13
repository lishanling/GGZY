using System;
using System.Data;


namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 实体类PT_ZXTS_LOG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class PtZxtsLogModel
    {
        #region Model


        /// <summary>
        /// ID
        /// </summary>
        public decimal? ID { get; set; }
        /// <summary>
        /// 在线投诉ID
        /// </summary>
        public decimal? TS_ID { get; set; }
        /// <summary>
        /// 记录人
        /// </summary>
        public decimal? RECORDER_UID { get; set; }
        /// <summary>
        /// 记录-操作人名称
        /// </summary>
        public string RECORDER_UNAME { get; set; }
        /// <summary>
        /// 记录-操作人单位
        /// </summary>
        public decimal? RECORDER_DEPID { get; set; }
        /// <summary>
        /// 记录时间
        /// </summary>
        public DateTime? RECORDER_TM { get; set; }
        /// <summary>
        /// 记录-操作（1提交投诉2撤销投诉3驳回投诉4受理5申请撤诉6不予撤诉7同意撤诉8不予处理9已处理10延迟处理type=75）
        /// </summary>
        public string RECORDER_OPERATION { get; set; }
        /// <summary>
        /// 记录-相关意见
        /// </summary>
        public string RECORDER_REMARK { get; set; }
        /// <summary>
        /// 记录-附件
        /// </summary>
        public string RECORDER_AIDS { get; set; }
        #endregion


    }
}