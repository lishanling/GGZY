using System;
using System.Collections.Generic;
using Dos.ORM;

namespace GGZY.Services.Infrastructure.Model.BigData
{
    public class StatisticsBidderDataSummaryModel
    {
        public StatisticsBidderDataSummaryModel()
        {
            //this.ACTIVE_COUNT = 0;
            this.CHART_DATA=new List<PieSeriesData>();
        }
        public Int64 ACTIVE_COUNT { get; set; }
        public decimal? TOTAL_AMOUNT { get; set; }
        public Int64 TOTAL_COUNT { get; set; }
        public string  TOTAL_AMOUNT_TEXT => TOTAL_AMOUNT?.ToString("#0.000");
        public List<PieSeriesData> CHART_DATA { get; set; }
    }
    public class StatisticsBidderDataSourceModel
    {
        public string Name { get; set; }
        public decimal? Amount { get; set; }
        public Int64 Value { get; set; }
    }


}