using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类SECTION。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public partial class SECTION : FwEntity
    {

        #region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public partial class _
        {
            /// <summary>
            /// 标段合同估算价万元
            /// </summary>
            public readonly static Field CONTRACT_RECKON_PRICE_W = new Field("(CASE TO_CHAR(\"SECTION\".\"PRICE_UNIT\") WHEN '1' THEN CONTRACT_RECKON_PRICE ELSE CONTRACT_RECKON_PRICE/10000 END)", "", "标段合同估算价万元");
        }
        #endregion
    }
}