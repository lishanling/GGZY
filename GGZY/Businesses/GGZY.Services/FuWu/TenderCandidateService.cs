using System.Collections.Generic;
using System.Data;

namespace GGZY.Services.FuWu
{
    public partial class TenderCandidateService
    {
        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 评标 中标候选人列表
        /// </summary>
        /// <param name="projectCode"></param>
        /// <param name="bidSectionCode"></param>
        /// <returns></returns>
        public List<object> JD_GCJS_PB_TenderCandidate(string projectCode, string bidSectionCode)
        {
            var obj = FromSql(@"
                SELECT T.WIN_CANDIDATE_NAME,
                       T.WIN_CANDIDATE_ORDER,
                       T.BID_PRICE,
                       T.EVALUATION_PRICE,
                       T.WIN_PRICE,
                       T.PRICE_UINT,
                       T1.TEXT AS PRICE_UINT_TEXT,
                       T2.TEXT AS IS_FLOAT_RATE,
                       T.EVALUATION_RESULT
                  FROM TENDER_CANDIDATE T 
                       LEFT JOIN sys_dic T1 ON T.PRICE_UINT = T1.VALUE AND T1.TYPE = 18
                       LEFT JOIN sys_dic T2 ON T2.TYPE = 2003 AND T.IS_FLOAT_RATE = T2.VALUE
                 WHERE T.TENDER_PROJECT_CODE =:tender_project_code AND T.BID_SECTION_CODE=:bid_section_code
                 ORDER BY T.WIN_CANDIDATE_ORDER")
                .AddInParameter(":tender_project_code", DbType.AnsiString, projectCode)
                .AddInParameter(":bid_section_code", DbType.AnsiString, bidSectionCode)
                .ToList<object>();
            return obj;
        }
    }
}