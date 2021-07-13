using System.Data;

namespace GGZY.Services.FuWu
{
    public partial class BidDocCharactCodeService 
    {
        /// <summary>
        /// 监督平台门户  项目监督信息 >> 详细信息 开标 特征码
        /// </summary>
        /// <param name="tenderProjectCode"></param>
        /// <returns></returns>
        public object JD_GCJS_KB_BidDocCharactCode(string tenderProjectCode)
        {
            var obj = FromSql(@"
                WITH TB AS(
                SELECT TENDER_PROJECT_CODE,
                       BID_SECTION_CODE
                  FROM BID_DOC_CHARACT_CODE
                 WHERE TENDER_PROJECT_CODE=:tender_project_code
                 GROUP BY TENDER_PROJECT_CODE,BID_SECTION_CODE
                )
                SELECT A.BID_SECTION_CODE,
                       B.BID_SECTION_NAME
                  FROM TB A 
                       LEFT JOIN SECTION B ON A.TENDER_PROJECT_CODE=B.TENDER_PROJECT_CODE AND A.BID_SECTION_CODE=B.BID_SECTION_CODE")
                .AddInParameter(":tender_project_code", DbType.AnsiString, tenderProjectCode)
                .ToFirst<object>();
            return obj;
        }

        /// <summary>
        /// 监督平台门户  项目监督信息 >> 详细信息 开标 特征码列表
        /// </summary>
        /// <param name="tenderProjectCode"></param>
        /// <param name="bidSectionCode"></param>
        /// <returns></returns>
        public object JD_GCJS_KB_BidDocCharactCodeList(string tenderProjectCode,string bidSectionCode)
        {
            var obj = FromSql(@"
                SELECT BIDDER_NAME,
                       BID_DOCUMENT_NAME,
                       NET_ID,
                       MAC_ADDRESS,
                       CPU_ID,
                       TENDER_DOCUMENTS_URL
                  FROM BID_DOC_CHARACT_CODE
                 WHERE TENDER_PROJECT_CODE=:tender_project_code 
                       AND BID_SECTION_CODE=:bid_section_code")
                .AddInParameter(":tender_project_code", DbType.AnsiString, tenderProjectCode)
                .AddInParameter(":bid_section_code", DbType.AnsiString, tenderProjectCode)
                .ToFirst<object>();
            return obj;
        }
    }
}