using System.Collections.Generic;
using System.Data;

namespace GGZY.Services.FuWu
{
    public partial class StockListingPubInfoService 
    {
        /// <summary>
        /// 监督平台门户 项目监督信息 国有产权 股权   挂牌披露  挂牌披露信息(股权类类)
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public List<object> JD_GYCQ_GQ_StockListingPubInfo(string projectCode)
        {
            var obj = FromSql(
                    @"SELECT PROJECT_NAME,PROJECT_CODE,PROJECT_CLASSIFY_CODE,B.TEXT AS PROJECT_CLASSIFY_CODE_TEXT
                                ,SELLER_NAME,SELLER_CODE,SELLER_TYPE,D.TEXT AS SELLER_TYPE_TEXT,SELLER_ROLE,E.TEXT AS SELLER_ROLE_TEXT,AUTHORIZE_UNIT,TOTAL_PERCENT
                                ,A.PROJECT_PRICE,A.PRICE_UNIT ,G.TEXT AS PRICE_UNIT_TEXT,PUBLISH_DURATION,PUBLISH_DATE,PRE_EXCHANGE_TYPE,H.TEXT AS PRE_EXCHANGE_TYPE_TEXT
                                ,POST_PONE,I.TEXT AS POST_PONE_TEXT,MANAGEMENT_INTENT,J.TEXT AS MANAGEMENT_INTENT_TEXT,GIVEUP_PRIORITY,K.TEXT AS GIVEUP_PRIORITY_TEXT
                                ,IMPORTANT_INFO,PROJECT_URL,BUYER_POSTULATE,OTHER_CONDITIONS
                            FROM STOCK_LISTING_PUB_INFO A
                            LEFT JOIN SYS_DIC B ON A.PROJECT_CLASSIFY_CODE = B.VALUE AND B.TYPE=2002
                            LEFT JOIN SYS_DIC D ON A.SELLER_TYPE = D.VALUE AND D.TYPE=1004
                            LEFT JOIN SYS_DIC E ON A.SELLER_ROLE = E.VALUE AND E.TYPE=26
                            LEFT JOIN SYS_DIC G ON A.PRICE_UNIT =G.VALUE AND G.TYPE =18
                            LEFT JOIN SYS_DIC H ON A.PRE_EXCHANGE_TYPE =H.VALUE AND H.TYPE =23 and H.value5='国有产权（股权类）'
                            LEFT JOIN SYS_DIC I ON A.POST_PONE = I.VALUE AND I.TYPE =28
                            LEFT JOIN SYS_DIC J ON A.MANAGEMENT_INTENT = J.VALUE AND J.TYPE =28
                            LEFT JOIN SYS_DIC K ON A.GIVEUP_PRIORITY = K.VALUE AND K.TYPE =28
                           WHERE A.PROJECT_CODE =:project_code ")
                .AddInParameter(":project_code", DbType.AnsiString, projectCode)
                .ToList<object>();
            return obj;
        }
    }
}