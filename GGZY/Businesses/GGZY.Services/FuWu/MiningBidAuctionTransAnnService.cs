using System.Data;

namespace GGZY.Services.FuWu
{
    public partial class MiningBidAuctionTransAnnService 
    {
        /// <summary>
        /// 监督平台门户 项目监督信息 土地使用权  招拍挂出让公告  采矿矿权交易电子挂牌
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public object JD_KYQ_MiningBidAuctionTransAnn(string projectCode)
        {
            var obj = FromSql(
                    @"SELECT A.NA_APP_NAME,URL,IN_BUY_KIND,B.TEXT AS IN_BUY_KIND_TEXT,IN_MINE_COME,C.TEXT AS IN_MINE_COME_TEXT
                            ,QT_PLAN_YEARS,QT_TOTAL_AREA,NA_GEOGRAPHY_POSITION,NA_AREA_COORDINATE,PUB_SERVICE_PLAT_CODE
                            FROM MINING_BID_AUCTION_TRANS_ANN A
                            LEFT JOIN SYS_DIC B ON A.IN_BUY_KIND = B.VALUE AND B.TYPE =40
                            LEFT JOIN SYS_DIC C ON A.IN_BUY_KIND =C.VALUE AND C.TYPE =8001
                           WHERE A.NA_APP_NAME =:project_code ")
                .AddInParameter(":project_code", DbType.AnsiString, projectCode)
                .First<object>();
            return obj;
        }
    }
}