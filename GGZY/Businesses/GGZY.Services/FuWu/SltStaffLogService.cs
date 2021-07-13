using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class SltStaffLogService 
    {
        public BootstrapTableResult<SLT_STAFF_LOG> PageList(SLT_STAFF_LOG model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            if (search.BeginTime.HasValue)
            {
                var bTime = search.BeginTime.Value.ToString("yyyyMMddHHmmss");
                condition.And(SLT_STAFF_LOG._.SYNCTIME >= bTime);
            }
            if (search.EndTime.HasValue)
            {
                var bTime = search.EndTime.Value.ToString("yyyyMMddHHmmss");
                condition.And(SLT_STAFF_LOG._.SYNCTIME <= bTime);
            }
            var count = Count(condition);
            var pageList = PageList(condition, search, SLT_STAFF_LOG._.SYNCTIME.Desc).ToBootstrapTableList(count);
            return pageList;
        }
    }
}