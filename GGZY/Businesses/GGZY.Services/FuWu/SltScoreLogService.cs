using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class SltScoreLogService 
    {
        public BootstrapTableResult<SLT_SCORE_LOG> PageList(SLT_SCORE_LOG model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            if (search.BeginTime.HasValue)
            {
                var bTime = search.BeginTime.Value.ToString("yyyyMMddHHmmss");
                condition.And(SLT_SCORE_LOG._.SYNCTIME>=bTime);
            }
            if (search.EndTime.HasValue)
            {
                var bTime = search.EndTime.Value.ToString("yyyyMMddHHmmss");
                condition.And(SLT_SCORE_LOG._.SYNCTIME <= bTime);
            }
            var count = Count(condition);
            var pageList = PageList(condition, search, SLT_SCORE_LOG._.SYNCTIME.Desc).ToBootstrapTableList(count);
            return pageList;
        }
        /// <summary>
        /// 监督平台门户 信用公示
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult PageTable(SLT_SCORE_LOG model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            if (!string.IsNullOrWhiteSpace(search.KeyWord))
            {
                condition.And(SLT_SCORE_LOG._.NAME.Contain(search.KeyWord)||SLT_SCORE_LOG._.CODE.Contain(search.KeyWord));
            }
            if (search.BeginTime.HasValue)
            {
                var bTime = search.BeginTime.Value.ToString("yyyyMMddHHmmss");
                condition.And(SLT_SCORE_LOG._.SYNCDATA >= bTime);
            }
            if (search.EndTime.HasValue)
            {
                var bTime = search.EndTime.Value.ToString("yyyyMMddHHmmss");
                condition.And(SLT_SCORE_LOG._.SYNCDATA <= bTime);
            }
            var count = Count(condition);
            var pageList = PageList(condition, search, SLT_SCORE_LOG._.SYNCTIME.Desc&SLT_SCORE_LOG._.NAME.Asc)
                .ToPageTableResult(search,count,c => new
            {
                NAME = c.NAME,
                CODE = c.CODE,
                SCORE = c.SCORE,
                TM = c.SYNCDATA.ToNullableDateTime("yyyyMMdd")
            });
            return pageList;
        }
    }
}