using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TendererExInfoService 
    {
        /// <summary>
        /// 投标人
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult FindTendererExInfoByBodyCode(SearchCondition search)
        {
            var con = TENDERER_EX_INFO._.LEGAL_CODE == search.KeyWord;
            var count = Count(con);
            var pageList = FromWhere(con)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "17" && SYS_DIC._.VALUE == TENDERER_EX_INFO._.QUAL_LEVEL)
                .Select(
                    SYS_DIC._.TEXT.As("QUAL_LEVEL"),
                    TENDERER_EX_INFO._.QUAL_NAME,
                    TENDERER_EX_INFO._.QUAL_TYPE,
                    TENDERER_EX_INFO._.QUAL_CERT_NO,
                    TENDERER_EX_INFO._.QUAL_CERT_END_DATE
                )
                .OrderBy(TENDERER_EX_INFO._.QUAL_NAME.Asc)
                .Page(search.PageSize, search.PageNo)
                .ToList().ToPageTableResult(search, count);
            return pageList;
        }
    }
}