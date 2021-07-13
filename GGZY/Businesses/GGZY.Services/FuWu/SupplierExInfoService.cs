using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class SupplierExInfoService 
    {
        /// <summary>
        /// 供应商
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult FindSupplierExInfoByBodyCode(SearchCondition search)
        {
            var con = SUPPLIER_EX_INFO._.LEGAL_CODE == search.KeyWord;
            var count = Count(con);
            var pageList = FromWhere(con)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "17" && SYS_DIC._.VALUE == SUPPLIER_EX_INFO._.QUAL_LEVEL)
                .Select(
                    SYS_DIC._.TEXT.As("QUAL_LEVEL"),
                    SUPPLIER_EX_INFO._.QUAL_NAME,
                    SUPPLIER_EX_INFO._.QUAL_TYPE,
                    SUPPLIER_EX_INFO._.QUAL_CERT_NO,
                    SUPPLIER_EX_INFO._.QUAL_CERT_END_DATE
                )
                .OrderBy(SUPPLIER_EX_INFO._.QUAL_NAME.Asc)
                .Page(search.PageSize, search.PageNo)
                .ToList().ToPageTableResult(search, count);
            return pageList;
        }
    }
}