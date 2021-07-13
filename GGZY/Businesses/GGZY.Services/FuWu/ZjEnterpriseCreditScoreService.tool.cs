using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ZjEnterpriseCreditScoreService : BaseServiceT<ZJ_ENTERPRISE_CREDIT_SCORE>
    {
        #region 接口实现

        public List<ZJ_ENTERPRISE_CREDIT_SCORE> FindList(ZJ_ENTERPRISE_CREDIT_SCORE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZJ_ENTERPRISE_CREDIT_SCORE> PageList(ZJ_ENTERPRISE_CREDIT_SCORE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, ZJ_ENTERPRISE_CREDIT_SCORE._.UPDATE_TIME.Desc).ToBootstrapTableList(count);


            return pageList;
        }




        #endregion

        #region Utils
        protected WhereClipBuilder ConditionBuilder(ZJ_ENTERPRISE_CREDIT_SCORE model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.BODY_CODE))
            {
                condition.And(ZJ_ENTERPRISE_CREDIT_SCORE._.BODY_CODE.Contain(model.BODY_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.BODY_NAME))
            {
                condition.And(ZJ_ENTERPRISE_CREDIT_SCORE._.BODY_NAME.Contain(model.BODY_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.BODY_TYPE))
            {
                condition.And(ZJ_ENTERPRISE_CREDIT_SCORE._.BODY_TYPE.Contain(model.BODY_TYPE));
            }
            if (!string.IsNullOrWhiteSpace(model.BODY_ROLE))
            {
                condition.And(ZJ_ENTERPRISE_CREDIT_SCORE._.BODY_ROLE.Contain(model.BODY_ROLE));
            }
            if (model.CREDIT_SCORE != null)
            {
                condition.And(ZJ_ENTERPRISE_CREDIT_SCORE._.CREDIT_SCORE == (model.CREDIT_SCORE));
            }
            if (!string.IsNullOrWhiteSpace(model.SYEAR))
            {
                condition.And(ZJ_ENTERPRISE_CREDIT_SCORE._.SYEAR.Contain(model.SYEAR));
            }
            if (!string.IsNullOrWhiteSpace(model.QUARTER))
            {
                condition.And(ZJ_ENTERPRISE_CREDIT_SCORE._.QUARTER.Contain(model.QUARTER));
            }
            if (!string.IsNullOrWhiteSpace(model.MONTH))
            {
                condition.And(ZJ_ENTERPRISE_CREDIT_SCORE._.MONTH.Contain(model.MONTH));
            }
            if (!string.IsNullOrWhiteSpace(model.RANK))
            {
                condition.And(ZJ_ENTERPRISE_CREDIT_SCORE._.RANK.Contain(model.RANK));
            }
            if (!string.IsNullOrWhiteSpace(model.CREDIT_TYPE))
            {
                condition.And(ZJ_ENTERPRISE_CREDIT_SCORE._.CREDIT_TYPE.Contain(model.CREDIT_TYPE));
            }
            if (!string.IsNullOrWhiteSpace(model.INDUSTRIES_TYPE))
            {
                condition.And(ZJ_ENTERPRISE_CREDIT_SCORE._.INDUSTRIES_TYPE.Contain(model.INDUSTRIES_TYPE));
            }
            if (model.UPDATE_TIME != null)
            {
                condition.And(ZJ_ENTERPRISE_CREDIT_SCORE._.UPDATE_TIME == (model.UPDATE_TIME));
            }
            if (!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
            {
                condition.And(ZJ_ENTERPRISE_CREDIT_SCORE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
            }
            if (!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
            {
                condition.And(ZJ_ENTERPRISE_CREDIT_SCORE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
            }
            if (model.DATA_TIMESTAMP != null)
            {
                condition.And(ZJ_ENTERPRISE_CREDIT_SCORE._.DATA_TIMESTAMP == (model.DATA_TIMESTAMP));
            }
            if (model.M_ID != null)
            {
                condition.And(ZJ_ENTERPRISE_CREDIT_SCORE._.M_ID == (model.M_ID));
            }
            return condition;
        }
        #endregion
    }
}