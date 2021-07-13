using System;
using Dos.ORM;

namespace GGZY.Services.Infrastructure.Model.BigData
{
    public class DashboardTradeRankModel
    {
#pragma warning disable CS0169 // 从不使用字段“DashboardTradeRankModel._AMOUNT”
        private decimal? _AMOUNT;
#pragma warning restore CS0169 // 从不使用字段“DashboardTradeRankModel._AMOUNT”
        public string AREANAME { get; set; }

        public decimal? AMOUNT { get; set; }

        public Int64? TOTAL_COUNT { get; set; }


        public string AMOUNT_TEXT => AMOUNT.HasValue ? (AMOUNT.Value / 10000).ToString("#0.000") : "0";

        public string TOTAL_COUNT_TEXT => TOTAL_COUNT.HasValue ? TOTAL_COUNT.Value.ToString() : "0";

    }

    public class V_TRADE_RANK
    {
        /// <summary>
        /// 归属地编号
        /// </summary>
        public readonly static Field AREACODE = new Field("AREACODE", "V_TRADE_RANK", "归属地编号");

        /// <summary>
        /// 归属地名称
        /// </summary>
        public readonly static Field AMOUNT = new Field("AMOUNT", "V_TRADE_RANK", "归属地名称");
        /// <summary>
        /// 交易数
        /// </summary>
        public readonly static Field TOTAL_COUNT = new Field("TOTAL_COUNT", "V_TRADE_RANK", "归属地编号");
    }
}