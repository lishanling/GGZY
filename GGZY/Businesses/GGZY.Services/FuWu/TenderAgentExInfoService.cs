using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TenderAgentExInfoService 
    {
        /// <summary>
        /// 招标代理机构
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult FindTenderAgentExInfoByBodyCode(SearchCondition search)
        {
            var con = TENDER_AGENT_EX_INFO._.LEGAL_CODE == search.KeyWord;
            var count = Count(con);
            var pageList = FromWhere(con)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "17" && SYS_DIC._.VALUE == TENDER_AGENT_EX_INFO._.QUAL_LEVEL)
                .Select(
                    SYS_DIC._.TEXT.As("QUAL_LEVEL"),
                    TENDER_AGENT_EX_INFO._.QUAL_NAME,
                    TENDER_AGENT_EX_INFO._.QUAL_TYPE,
                    TENDER_AGENT_EX_INFO._.QUAL_CERT_NO,
                    TENDER_AGENT_EX_INFO._.QUAL_CERT_END_DATE
                )
                .OrderBy(TENDER_AGENT_EX_INFO._.QUAL_NAME.Asc)
                .Page(search.PageSize, search.PageNo)
                .ToList().ToPageTableResult(search, count);
            return pageList;
        }
	}
}