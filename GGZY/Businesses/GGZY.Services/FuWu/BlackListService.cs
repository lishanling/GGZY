using Dos.ORM;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class BlackListService 
    {
        public PageTableResult FindBlackListByLegalCode(SearchCondition search)
        {
            var con = BLACK_LIST._.SCOPE == 1 && BLACK_LIST._.BODY_CODE == search.KeyWord;
            var count = Count(con);
            var pageList = FromWhere(con)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "2001" && SYS_DIC._.VALUE == BLACK_LIST._.BODY_TYPE)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "26" && SYS_DIC._.VALUE == BLACK_LIST._.BODY_ROLE)
                .OrderBy(BLACK_LIST._.RECORD_DATE.Desc)
                .Select(
                    BLACK_LIST._.BODY_NAME,
                    SYS_DIC._.TEXT.As("BODY_TYPE"),
                    new Field("TEXT", "SYS_DIC2").As("BODY_ROLE"),
                    BLACK_LIST._.M_ID,
                    BLACK_LIST._.RECORD_DATE
                ).Page(search.PageSize, search.PageNo)
                .ToList().ToPageTableResult(search, count);
            return pageList;
        }
	}
}