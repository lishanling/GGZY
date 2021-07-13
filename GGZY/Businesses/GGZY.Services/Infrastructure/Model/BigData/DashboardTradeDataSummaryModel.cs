using System;

namespace GGZY.Services.Infrastructure.Model.BigData
{
    public class DashboardTradeDataSummaryModel
    {
        public Int64 TOTAL_COUNT { get; set; }

        public decimal AMOUNT { get; set; }

        public decimal JIEYUE_AMOUNT { get; set; }

        public string AMOUNT_TEXT => (AMOUNT / 10000).ToString("#0.000");
        public string JIEYUE_AMOUNT_TEXT => (JIEYUE_AMOUNT / 10000).ToString("#0.000");
    }
}