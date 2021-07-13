using System.Collections.Generic;
using System.Data;

namespace GGZY.Services.FuWu
{
    public partial class WinResultAnnoService 
    {
        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 结果公告 中标结果公示信息
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public object JD_GCJS_JGGG_WinResultAnno(string projectCode)
        {

            var obj = FromSql(@"
                SELECT T.NOTICE_NAME,
                       T.NOTICE_SEND_TIME,
                       T.NOTICE_MEDIA,
                       T.BULLETIN_DUTY,
                       T.EXAMINER_NAME,
                       T.WIN_BIDDER_NAME,
                       T.WIN_BIDDER_CODE,
                       T.BID_AMOUNT,
                       T2.TEXT AS PRICE_UNIT,
                       T.URL,
                       T1.TEXT AS NOTICE_NATURE,
                       T.NOTICE_CONTENT
                  FROM WIN_RESULT_ANNO T
                       LEFT JOIN SYS_DIC T1 ON T.NOTICE_NATURE = T1.VALUE AND T1.TYPE = 20
                       LEFT JOIN SYS_DIC T2 ON T.PRICE_UNIT = T2.VALUE AND T2.TYPE = 18
                 WHERE T.TENDER_PROJECT_CODE = :tender_project_code AND T.BULLETIN_TYPE = '3'")
                .AddInParameter(":tender_project_code", DbType.AnsiString, projectCode)
                .ToFirst<object>();
            return obj;
        }
    }
}