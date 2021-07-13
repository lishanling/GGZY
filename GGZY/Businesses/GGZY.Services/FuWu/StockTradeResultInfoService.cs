using System.Data;

namespace GGZY.Services.FuWu
{
    public partial class StockTradeResultInfoService 
    {
        /// <summary>
        /// 监督平台门户 项目监督信息 国有产权 股权 交易结果  交易结果信息(股权类)
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public object JD_GYCQ_GQ_StockTradeResultInfo(string projectCode)
        {
            var obj = FromSql(
                    @"SELECT A.PROJECT_NAME,A.PROJECT_CODE,A.EXCHANGE_TYPE,B.TEXT AS EXCHANGE_TYPE_TEXT,A.SELLER_NAME,A.SELLER_CODE,A.SELLER_TYPE,C.TEXT AS SELLER_TYPE_TEXT
                            ,A.SELLER_ROLE,D.TEXT AS SELLER_ROLE_TEXT,A.OBJECT_EVALUATE_VALUE,A.TRADE_VALUE,A.PRICE_UNIT,E.TEXT AS PRICE_UNIT_TEXT,A.TRADE_DATE,A.PROJECT_URL
                            ,A.PUB_SERVICE_PLAT_CODE
                            FROM STOCK_TRADE_RESULT_INFO A 
                            LEFT JOIN SYS_DIC B ON A.EXCHANGE_TYPE =B.VALUE AND B.TYPE =23 AND B.VALUE5 ='国有产权（股权类）'
                            LEFT JOIN SYS_DIC C ON A.SELLER_TYPE = C.VALUE AND C.TYPE =1004
                            LEFT JOIN SYS_DIC D ON A.SELLER_ROLE = D.VALUE AND D.TYPE =26
                            LEFT JOIN SYS_DIC E ON A.SELLER_ROLE =E.VALUE AND E.TYPE =18
                           WHERE A.PROJECT_CODE =:project_code ")
                .AddInParameter(":project_code", DbType.AnsiString, projectCode)
                .First<object>();
            return obj;
        }
    }
}