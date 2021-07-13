using System.Collections.Generic;
using System.Data;

namespace GGZY.Services.FuWu
{
    public partial class ListingPubInfoService 
    {
        /// <summary>
        /// 监督平台门户 项目监督信息 国有产权 实物   挂牌披露  挂牌披露信息(实物资产类)
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public List<object> JD_GYCQ_SW_ListingPubInfo(string projectCode)
        {
            var obj = FromSql(
                    @"SELECT PROJECT_NAME,PROJECT_CODE,PROJECT_CLASSIFY_CODE,B.TEXT AS PROJECT_CLASSIFY_CODE_TEXT,A.PROJECT_TYPE,C.TEXT AS PROJECT_TYPE_TEXT
                                ,SELLER_NAME,SELLER_CODE,SELLER_TYPE,D.TEXT AS SELLER_TYPE_TEXT,SELLER_ROLE,E.TEXT AS SELLER_ROLE_TEXT,A.ZONE,F.AREANAME AS ZONE_NAME
                                ,A.PROJECT_PRICE,A.PRICE_UNIT ,G.TEXT AS PRICE_UNIT_TEXT,PUBLISH_DURATION,PUBLISH_DATE,PRE_EXCHANGE_TYPE,H.TEXT AS PRE_EXCHANGE_TYPE_TEXT
                                ,POST_PONE,I.TEXT AS POST_PONE_TEXT,PROJECT_URL,PUB_SERVICE_PLAT_CODE,TRANSFER_NOTES
                            FROM LISTING_PUB_INFO A
                            LEFT JOIN SYS_DIC B ON A.PROJECT_CLASSIFY_CODE = B.VALUE AND B.TYPE=2002
                            LEFT JOIN SYS_DIC C ON A.PROJECT_TYPE =C.VALUE AND C.TYPE =22
                            LEFT JOIN SYS_DIC D ON A.SELLER_TYPE = D.VALUE AND D.TYPE=1004
                            LEFT JOIN SYS_DIC E ON A.SELLER_ROLE = E.VALUE AND E.TYPE=26
                            LEFT JOIN SYS_AREA_QUANGUO F ON A.ZONE = F.AREACODE
                            LEFT JOIN SYS_DIC G ON A.PRICE_UNIT =G.VALUE AND G.TYPE =18
                            LEFT JOIN SYS_DIC H ON A.PRE_EXCHANGE_TYPE =H.VALUE AND H.TYPE =23 and H.value5='国有产权（实物资产类）'
                            LEFT JOIN SYS_DIC I ON A.POST_PONE = I.VALUE AND I.TYPE =28
                           WHERE A.PROJECT_CODE =:project_code ")
                .AddInParameter(":project_code", DbType.AnsiString, projectCode)
                .ToList<object>();
            return obj;
        }
    }
}