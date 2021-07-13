using Dos.ORM;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ViolatingLawsRulesInfoService
    {
        public PageTableResult FindViolatingLawsRulesInfoPageListByLegalCode(SearchCondition search)
        {
            var condition = VIOLATING_LAWS_RULES_INFO._.BODY_CODE == search.KeyWord &&
                            VIOLATING_LAWS_RULES_INFO._.SCOPE == 1;
            var count = Count(condition);
            var pageList = FromWhere(condition)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "1008" &&
                                   SYS_DIC._.VALUE == VIOLATING_LAWS_RULES_INFO._.VIOLATING_TYPE)
                .OrderBy(VIOLATING_LAWS_RULES_INFO._.VIOLATING_TIME.Desc)
                .Page(search.PageSize, search.PageNo)
                .Select(
                    VIOLATING_LAWS_RULES_INFO._.VIOLATING_NAME,
                    VIOLATING_LAWS_RULES_INFO._.VIOLATING_TIME,
                    VIOLATING_LAWS_RULES_INFO._.BODY_NAME,
                    SYS_DIC._.TEXT.As("VIOLATING_TYPE"),
                    VIOLATING_LAWS_RULES_INFO._.M_ID
                ).ToList().ToPageTableResult(search, count);
            return pageList;
        }
    }
}