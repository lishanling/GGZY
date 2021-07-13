using System.Data;

namespace GGZY.Services.FuWu
{
    public partial class BidDealAnnounceService 
    {
        /// <summary>
        /// 监督平台门户 项目监督信息 政府采购 结果公告
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public object JD_ZFCG_JGGG_bidDealAnnounce(string projectCode)
        {
            var obj = FromSql(
                    @"SELECT T.PURCHASE_PROJECT_CODE,T.PURCHASE_PROJECT_NAME,T.WIN_BID_BULLETIN_TITLE,T.WIN_BID_BULLETIN_START_TIME
                                    ,T.WIN_BID_PRICE,T.PRICE_UNIT,T1.TEXT AS PRICE_UNIT_TEXT,T.WINNINGBIDDER_NAME,T.URL,T.M_ID,T.WIN_BID_BULLETIN_CONTENT
                                    FROM BID_DEAL_ANNOUNCE T
                                    LEFT JOIN SYS_DIC T1 ON T.PRICE_UNIT = T1.VALUE and t1.type =18
                           WHERE T.PURCHASE_PROJECT_CODE =:project_code ")
                .AddInParameter(":project_code", DbType.AnsiString, projectCode)
                .First<object>();
            return obj;
        }

    }
}