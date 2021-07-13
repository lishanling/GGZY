using System;
using Dos.ORM;

namespace GGZY.Services.Infrastructure.Model.BigData
{
    /// <summary>
    /// 工程领域监察大数据服务系统-综合统计-招标人情况-招标人项目总量排行
    /// </summary>
    public class StatisticsBidderRankModel
    {
        public string LEGAL_NAME { get; set; }
        public Int64? COUNT { get; set; }
        public Int64? WIN_COUNT { get; set; }
        public string LEGAL_CODE { get; set; } = "-";

        public string AREANAME { get; set; } = "-";

        public string RATE
        {
            get
            {
                var r = "-";
                if (WIN_COUNT.HasValue && COUNT.HasValue && COUNT > 0)
                {
                    r = ((double)WIN_COUNT.Value / COUNT.Value).ToString("P");
                }
                return r;
            }
        }
    }

    public class V_TENDER_PROJECT_WIN_RESULT
    {
        /// <summary>
        /// 招标人名称
        /// </summary>
        public readonly static Field LEGAL_NAME = new Field("LEGAL_NAME", "V_TENDER_PROJECT_WIN_RESULT", "招标人名称");

        /// <summary>
        /// 成交数量
        /// </summary>
        public readonly static Field WIN_COUNT = new Field("WIN_COUNT", "V_TENDER_PROJECT_WIN_RESULT", "成交数量");
    }

}