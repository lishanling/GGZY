using System.Data;

namespace GGZY.Services.FuWu
{
    public partial class DealLandInfoService 
    {
        /// <summary>
        /// 监督平台门户 项目监督信息 土地使用权 成交宗地信息
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public object JD_TDSYQ_DealLandInfo(string projectCode)
        {
            var obj = FromSql(
                    @"SELECT DEAL_LAND_CODE,DEAL_ANNOUNCEMENT_GUID,UNIFIED_DEAL_CODE,INVEST_PROJECT_CODE,LAND_CODE,LAND_AREA,LAND_USAGE,
                                LEND_AGE_LIMIT,LAND_POSITION,DEAL_PRICE,LENDING_NAME,PRICE_UNIT,B.TEXT AS PRICE_UNIT_TEXT
                                FROM DEAL_LAND_INFO A
                                LEFT JOIN SYS_DIC B ON B.TYPE =18 AND A.PRICE_UNIT=B.VALUE
                           WHERE A.DEAL_ANNOUNCEMENT_GUID =:project_code ")
                .AddInParameter(":project_code", DbType.AnsiString, projectCode)
                .First<object>();
            return obj;
        }
    }
}