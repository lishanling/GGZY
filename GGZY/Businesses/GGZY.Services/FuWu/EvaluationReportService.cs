using System.Collections.Generic;
using System.Data;

namespace GGZY.Services.FuWu
{
    public partial class EvaluationReportService
    {
        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 评标 评标报告数据
        /// </summary>
        /// <param name="projectCode"></param>
        /// <param name="bidSectionCode"></param>
        /// <returns></returns>
        public List<object> JD_GCJS_PB_EvaluationReport(string projectCode, string bidSectionCode)
        {
            var obj=FromSql(@"
                SELECT T.NOTICE_NAME,
                       T.SUBMIT_TIME,
                       T.END_TIME,
                       T.URL,
                       T.EVALUATION_CONTENT,
                       T.EVALUATION_RESULT,
                       T1.TEXT EVALUATION_RESULT_TEXT
                  FROM EVALUATION_REPORT T
                       LEFT JOIN SYS_DIC T1 ON T.EVALUATION_RESULT = T1.VALUE AND T1.TYPE = 14
                 WHERE T.TENDER_PROJECT_CODE =:tender_project_code AND T.BID_SECTION_CODE=:bid_section_code")
                .AddInParameter(":tender_project_code", DbType.AnsiString, projectCode)
                .AddInParameter(":bid_section_code", DbType.AnsiString, bidSectionCode)
                .ToList<object>();
            return obj;
        }
	}
}