using System.Data;

namespace GGZY.Services.FuWu
{
    public partial class DealBehaviorInfoService 
    {
        /// <summary>
        /// 监督平台门户 项目监督信息 土地使用权 成交行为信息
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public object JD_TDSYQ_DealBehabiorInfo(string projectCode)
        {
            var obj = FromSql(
                    @"SELECT A.ANNOUNCEMENT_GUID,A.ANNOUNCEMENT_TITLE,A.UNIFIED_DEAL_CODE,A.ANNOUNCEMENT_TYPE,A.PUBLISHING_TIME,A.URL,A.END_DATE,A.ANNOUNCEMENT_START_TIME,A.ANNOUNCEMENT_DEADLINE
                            ,LISTING_START_TIME,LISTING_DEADLINE,LISTING_TYPE,SUPPLY_TYPE,FIELD_NUM,ANNOUNCEMENT_UNIT,LIAISON_UNIT,UNIT_ADDRESS,ZIP_CODE,CONTACT_PERSON,CONTACT_NUMBER,EMAIL,CANCEL_REASON
                            ,CHANGE_TIME,RETREAT_TIME,CREATE_TIME,LAND_DISTRICT,ANNOUNCEMENT_CONNECT,B.TEXT AS ANNOUNCEMENT_TYPE_TEXT,C.TEXT AS LISTING_TYPE_TEXT,D.TEXT AS SUPPLY_TYPE_TEXT,AREA.AREANAME
                            FROM DEAL_BEHAVIOR_INFO A
                            LEFT JOIN SYS_DIC B ON A.ANNOUNCEMENT_TYPE= B.VALUE AND B.TYPE =20
                            LEFT JOIN SYS_DIC C ON A.LISTING_TYPE= C.VALUE AND C.TYPE =7001
                            LEFT JOIN SYS_DIC D ON A.SUPPLY_TYPE= D.VALUE AND D.TYPE =7002
                            LEFT JOIN  sys_area_quanguo AREA ON A.LAND_DISTRICT = AREA.AREACODE
                           WHERE A.ANNOUNCEMENT_GUID =:project_code ")
                .AddInParameter(":project_code", DbType.AnsiString, projectCode)
                .First<object>();
            return obj;
        }
    }
}