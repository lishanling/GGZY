using System.Data;

namespace GGZY.Services.FuWu
{
    public partial class ExplorBidAucTransResAnnService 
    {
        /// <summary>
        /// 监督平台门户 项目监督信息 土地使用权  结果公示  探矿矿权交易电子挂牌
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public object JD_KYQ_ExplorBidAucTransResAnn(string projectCode)
        {
            var obj = FromSql(
                    @"SELECT A.NA_APP_NAME,A.URL,A.IN_BUY_KIND,B.TEXT AS IN_BUY_KIND_TEXT,QT_PLAN_YEARS,QT_TOTAL_AREA,NA_GEOGRAPHY_POSITION
                            ,NA_PUBLIC_BIDDER,BIDDER_TYPE,C.TEXT AS BIDDER_TYPE_TEXT,BIDDER_CODE,BIDDER_ROLE,D.TEXT AS BIDDER_ROLE_TEXT
                            ,QT_PUBLIC_PRICE,NA_REG_ADDRESS,NA_TD_ADDRESS,DT_BUY_DATE,IN_COST_STYLE,E.TEXT AS IN_COST_STYLE_TEXT,DT_COST_DATE,NA_AREA_COORDINATE
                            ,PUB_SERVICE_PLAT_CODE
                            FROM EXPLOR_BID_AUC_TRANS_RES_ANN A
                            LEFT JOIN SYS_DIC B ON A.IN_BUY_KIND = B.VALUE AND B.TYPE=40
                            LEFT JOIN SYS_DIC C ON A.BIDDER_TYPE = C.VALUE AND B.TYPE=1004
                            LEFT JOIN SYS_DIC D ON A.BIDDER_ROLE = D.VALUE AND D.TYPE=26
                            LEFT JOIN SYS_DIC E ON A.IN_COST_STYLE = E.VALUE AND E.TYPE=3000
                           WHERE A.NA_APP_NAME =:project_code ")
                .AddInParameter(":project_code", DbType.AnsiString, projectCode)
                .First<object>();
            return obj;
        }
    }
}