using System.Collections.Generic;
using System.Data;

namespace GGZY.Services.FuWu
{
    public partial class BidOpeningRecordService 
    {
        /// <summary>
        /// 监督平台门户  项目监督信息 >> 详细信息 开标 开标记录
        /// </summary>
        /// <param name="tenderProjectCode"></param>
        /// <returns></returns>
        public object JD_GCJS_KB_BidOpeningRecord(string tenderProjectCode)
        {
            var obj = FromSql(@"
                SELECT T.TENDER_PROJECT_CODE,
                       P.TENDER_PROJECT_NAME,
                       PRO.PROJECT_NAME,
                       T.BID_OPENING_ACTOR,
                       T.BID_OPENING_ADDRESS,
                       T.BID_OPENING_TIME,
                       T.URL,
                       T.BID_OPENING_CONTENT
                  FROM BID_OPENING_RECORD T
                       LEFT JOIN TENDER_PROJECT P ON T.TENDER_PROJECT_CODE = P.TENDER_PROJECT_CODE
                       LEFT JOIN PROJECT PRO ON P.PROJECT_CODE = PRO.PROJECT_CODE
                 WHERE T.TENDER_PROJECT_CODE = :tender_project_code")
                .AddInParameter(":tender_project_code", DbType.AnsiString, tenderProjectCode)
                .ToFirst<object>();
            return obj;
        }
    }
}