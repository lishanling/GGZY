using System.Collections.Generic;
using System.Data;

namespace GGZY.Services.FuWu
{
    public partial class BidEvaluationExpertService 
    {
        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 评标 评标专家列表
        /// </summary>
        /// <param name="projectCode"></param>
        /// <param name="bidSectionCode"></param>
        /// <returns></returns>
        public List<object> JD_GCJS_PB_BidEvaluationExpert(string projectCode, string bidSectionCode)
        {
            var obj = FromSql(@"
                SELECT T.EXPERT_NAME,
                       T.EXPERT_TYPE,
                       T1.TEXT                AS EXPERT_TYPE_TEXT,
                       T.ID_CARD_TYPE,
                       T2.TEXT                AS ID_CARD_TYPE_TEXT,
                       T.ID_CARD,
                       T.EXPERT_CHECK_IN_TIME,
                       IS_CHAIR_MAN,
                       T3.TEXT                AS IS_CHAIR_MAN_TEXT
                  FROM BID_EVALUATION_EXPERT T
                       LEFT JOIN SYS_DIC T1 ON T.EXPERT_TYPE = T1.VALUE AND T1.TYPE = 2007
                       LEFT JOIN SYS_DIC T2 ON T.ID_CARD_TYPE = T2.VALUE AND T2.TYPE = 7
                       LEFT JOIN SYS_DIC T3 ON T.IS_CHAIR_MAN = T3.VALUE AND T3.TYPE = 2003
                 WHERE T.TENDER_PROJECT_CODE =:tender_project_code AND T.BID_SECTION_CODE=:bid_section_code
                 ORDER BY T.EXPERT_NAME")
                .AddInParameter(":tender_project_code", DbType.AnsiString, projectCode)
                .AddInParameter(":bid_section_code", DbType.AnsiString, bidSectionCode)
                .ToList<object>();
            return obj;
        }

    }
}