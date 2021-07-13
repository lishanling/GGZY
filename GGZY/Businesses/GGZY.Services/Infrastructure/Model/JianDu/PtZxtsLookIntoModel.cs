using System;
using System.Data;


namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 实体类PT_ZXTS_LOOK_INTO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class PtZxtsLookIntoModel
    {
        #region Model


        /// <summary>
        /// 主键，唯一标识
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 投诉编号
        /// </summary>
        public string TS_CODE { get; set; }
        /// <summary>
        /// 调查内容
        /// </summary>
        public string LOOK_CONTENT { get; set; }
        /// <summary>
        /// 附件集合
        /// </summary>
        public string LOOK_AIDS { get; set; }
        /// <summary>
        /// 调查发起时间
        /// </summary>
        public DateTime? LOOK_TIME { get; set; }
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