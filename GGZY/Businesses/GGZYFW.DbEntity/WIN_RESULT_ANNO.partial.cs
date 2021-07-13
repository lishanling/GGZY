using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类WIN_RESULT_ANNO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public partial class WIN_RESULT_ANNO
    {

        #region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public partial class _
        {
            /// <summary>
            /// 中标金额
            /// </summary>
            public readonly static Field BID_AMOUNT_W = new Field("(CASE TO_CHAR(\"WIN_RESULT_ANNO\".\"PRICE_UNIT\") WHEN '1' THEN BID_AMOUNT ELSE BID_AMOUNT/10000 END)", "", "中标金额");
        }
        #endregion
    }
}