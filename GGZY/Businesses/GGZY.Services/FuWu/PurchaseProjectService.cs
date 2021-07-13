using System.Data;

namespace GGZY.Services.FuWu
{
    public partial class PurchaseProjectService 
    {
        /// <summary>
        /// 监督平台门户 项目监督信息 政府采购 项目进场 项目信息
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public object JD_ZFCG_XMJC_PurchaseProject(string projectCode)
        {
            var obj = FromSql(
                    @"SELECT T.PURCHASE_PROJECT_CODE, T.PURCHASE_PROJECT_NAME,T.CREATE_TIME,T.TENDER_PROJECT_TYPE,T1.TEXT AS TENDER_PROJECT_TYPE_TEXT, T.PROGRAM_BUDGET,T.PURCHASER_NAME
                                    ,T.PURCHASER_MODE,T2.TEXT PURCHASER_MODE_TEXT,T.PURCHASER_ORGANIZE_FORM,T3.TEXT AS PURCHASER_ORGANIZE_FORM_TEXT,T.PURCHASER_CONTENT
                                    ,T.PURCHASER_AGENCY_NAME,T.PURCHASER_AGENCY_CONNECTOR,T.PURCHASER_AGENCY_INFORMATION,T.UNIT_BUDGET,T4.TEXT UNIT_BUDGET_TEXT,T.PURCHASE_SECTION_CODE,T.PURCHASE_SECTION_NAME
                                    FROM PURCHASE_PROJECT T 
                                    LEFT JOIN sys_dic T1 ON T1.type=2002 and T1.VALUE = T.TENDER_PROJECT_TYPE
                                    LEFT JOIN sys_dic T2 ON T2.type=43 and T2.VALUE = T.PURCHASER_MODE
                                    LEFT JOIN sys_dic T3 ON T3.type=44 AND T3.value5 ='政府采购' and T3.VALUE = T.PURCHASER_ORGANIZE_FORM
                                    LEFT JOIN sys_dic T4 ON T4.type=18 and T4.VALUE = T.UNIT_BUDGET
                           WHERE T.PURCHASE_PROJECT_CODE =:purchase_project_code ")
                .AddInParameter(":purchase_project_code", DbType.AnsiString, projectCode)
                .ToFirst<object>();
            return obj;
        }
	}
}