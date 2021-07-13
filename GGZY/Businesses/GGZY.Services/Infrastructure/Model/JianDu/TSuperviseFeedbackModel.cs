using System;
using System.Data;


namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 实体类T_SUPERVISE_FEEDBACK。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class TSuperviseFeedbackModel
    {
        #region Model


        /// <summary>
        /// 主键
        /// </summary>
        public string M_ID { get; set; }
        /// <summary>
        /// 督查主键
        /// </summary>
        public string SUPERVISE_ID { get; set; }
        /// <summary>
        /// 反馈内容
        /// </summary>
        public string CONTENT { get; set; }
        /// <summary>
        /// 督查人
        /// </summary>
        public string OP_ID { get; set; }
        /// <summary>
        /// 督查人员名称
        /// </summary>
        public string OP_NAME { get; set; }
        /// <summary>
        /// 督查人员部门id
        /// </summary>
        public string DEP_ID { get; set; }
        /// <summary>
        /// 督查人员部门名称
        /// </summary>
        public string DEP_NAME { get; set; }
        /// <summary>
        /// 督查对象
        /// </summary>
        public string OBJ { get; set; }
        /// <summary>
        /// 督查对象名称
        /// </summary>
        public string OBJ_NAME { get; set; }
        /// <summary>
        /// 督查对象部门id
        /// </summary>
        public string OBJ_DEP_ID { get; set; }
        /// <summary>
        /// 督查对象部门名称
        /// </summary>
        public string OBJDEP_NAME { get; set; }
        /// <summary>
        /// 督查码
        /// </summary>
        public string CODE { get; set; }
        /// <summary>
        /// 实体主键
        /// </summary>
        public string ENTITY_ID { get; set; }
        /// <summary>
        /// 实体对象名称T_AFC_PROJECT PT_ZXTS
        /// </summary>
        public string ENTITY_TYPE_NAME { get; set; }
        /// <summary>
        /// 反馈附件
        /// </summary>
        public string FILES { get; set; }
        /// <summary>
        /// 反馈时间
        /// </summary>
        public DateTime? TIME { get; set; }
        #endregion


    }
}