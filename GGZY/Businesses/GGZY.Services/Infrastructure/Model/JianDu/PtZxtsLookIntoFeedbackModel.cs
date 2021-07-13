using System;
using System.Data;


namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 实体类PT_ZXTS_LOOK_INTO_FEEDBACK。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class PtZxtsLookIntoFeedbackModel
    {
        #region Model


        /// <summary>
        /// 主键，唯一标识
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 调查取证编号
        /// </summary>
        public string LOOK_ID { get; set; }
        /// <summary>
        /// 调查取证反馈码
        /// </summary>
        public string FEEDBACK_CODE { get; set; }
        /// <summary>
        /// 调查对象
        /// </summary>
        public string LOOK_NAME { get; set; }
        /// <summary>
        /// 调查对象类型
        /// </summary>
        public string LOOK_OBJECT_TYPE { get; set; }
        /// <summary>
        /// 调查对象项目角色
        /// </summary>
        public string LOOK_PROJECT_TYPE { get; set; }
        /// <summary>
        /// 调查对象联系电话
        /// </summary>
        public string LOOK_CONTRACT { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public decimal? STATUS { get; set; }
        /// <summary>
        /// 附件集合
        /// </summary>
        public string FEEDBACK_AIDS { get; set; }
        /// <summary>
        /// 调查取证反馈内容
        /// </summary>
        public string FEEDBACK_CONTENT { get; set; }
        /// <summary>
        /// 发起调查时间
        /// </summary>
        public DateTime? LOOK_TIME { get; set; }
        /// <summary>
        /// 反馈时间
        /// </summary>
        public DateTime? FEEDBACK_TIME { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string CREATEDBY { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CREATEDTIME { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public string UPDATEDBY { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? UPDATEDTIME { get; set; }
        #endregion


    }
}