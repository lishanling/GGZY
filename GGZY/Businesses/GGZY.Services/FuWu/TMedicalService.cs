using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TMedicalService 
    {
        public object PageDataTable(T_MEDICAL model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, T_MEDICAL._.DIRCODE.Asc)
                .ToPageTableResult(search,count);
            return pageList;
        }
    }
}