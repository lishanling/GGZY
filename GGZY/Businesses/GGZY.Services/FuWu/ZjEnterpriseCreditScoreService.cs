using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ZjEnterpriseCreditScoreService 
    {
        /// <summary>
        /// 住建厅信用分
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult PageTable(ZJ_ENTERPRISE_CREDIT_SCORE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            if (!string.IsNullOrWhiteSpace(search.KeyWord))
            {
                condition.And(ZJ_ENTERPRISE_CREDIT_SCORE._.BODY_NAME.Contain(search.KeyWord)
                              ||ZJ_ENTERPRISE_CREDIT_SCORE._.BODY_CODE.Contain(search));
            }
            if (search.BeginTime.HasValue)
            {
                var bTime = search.BeginTime.Value;
                condition.And(ZJ_ENTERPRISE_CREDIT_SCORE._.DATA_TIMESTAMP >= bTime);
            }
            if (search.EndTime.HasValue)
            {
                var bTime = search.EndTime.Value;
                condition.And(ZJ_ENTERPRISE_CREDIT_SCORE._.DATA_TIMESTAMP <= bTime);
            }
            var count = Count(condition);
            var pageList = PageList(condition, search, ZJ_ENTERPRISE_CREDIT_SCORE._.DATA_TIMESTAMP.Desc)
                .ToPageTableResult(search,count,c=>new
                {
                    NAME=c.BODY_NAME,
                    CODE=c.BODY_CODE,
                    SCORE=c.CREDIT_SCORE,
                    TM=c.DATA_TIMESTAMP
                });


            return pageList;
        }
    }
}