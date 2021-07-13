using System;
using System.Data;


namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 实体类PT_ZXTS_BTSR。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class PtZxtsBtsrModel
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
        /// 名称
        /// </summary>
        public string NAME { get; set; }
        /// <summary>
        /// 类型（1招标人，2招标代理机构，3投标人，4评标委员会，5其他 type=84）
        /// </summary>
        public string TYPE { get; set; }
        /// <summary>
        /// 代码（统一社会信用代码）
        /// </summary>
        public string CODE { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string ADRESS { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>
        public string CONTACT { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string CONTACT_PHONE { get; set; }
        #endregion


    }
}