using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class MvJyxxHistoryService : BaseServiceT<MV_JYXX_HISTORY>
    {
        #region Utils
        protected WhereClipBuilder ConditionBuilder(MV_JYXX_HISTORY model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.KIND))
            {
                condition.And(MV_JYXX_HISTORY._.KIND.Contain(model.KIND));
            }
            if (!string.IsNullOrWhiteSpace(model.TITLE))
            {
                condition.And(MV_JYXX_HISTORY._.TITLE.Contain(model.TITLE));
            }
            if (!string.IsNullOrWhiteSpace(model.GGTYPE))
            {
                condition.And(MV_JYXX_HISTORY._.GGTYPE.Contain(model.GGTYPE));
            }
            if (!string.IsNullOrWhiteSpace(model.NAME))
            {
                condition.And(MV_JYXX_HISTORY._.NAME.Contain(model.NAME));
            }
            if (model.M_ID != null)
            {
                condition.And(MV_JYXX_HISTORY._.M_ID == (model.M_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
            {
                condition.And(MV_JYXX_HISTORY._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.PLATFORM_NAME))
            {
                condition.And(MV_JYXX_HISTORY._.PLATFORM_NAME.Contain(model.PLATFORM_NAME));
            }
            if (model.TM1 != null)
            {
                condition.And(MV_JYXX_HISTORY._.TM1 == (model.TM1));
            }
            if (!string.IsNullOrWhiteSpace(model.PROCODE))
            {
                condition.And(MV_JYXX_HISTORY._.PROCODE.Contain(model.PROCODE));
            }
            if (!string.IsNullOrWhiteSpace(model.AREACODE))
            {
                condition.And(MV_JYXX_HISTORY._.AREACODE.Contain(model.AREACODE));
            }
            if (!string.IsNullOrWhiteSpace(model.AREANAME))
            {
                condition.And(MV_JYXX_HISTORY._.AREANAME.Contain(model.AREANAME));
            }
            if (!string.IsNullOrWhiteSpace(model.PROTYPE_TEXT))
            {
                condition.And(MV_JYXX_HISTORY._.PROTYPE_TEXT.Contain(model.PROTYPE_TEXT));
            }
            if (!string.IsNullOrWhiteSpace(model.PROTYPE))
            {
                condition.And(MV_JYXX_HISTORY._.PROTYPE.Contain(model.PROTYPE));
            }
            if (!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
            {
                condition.And(MV_JYXX_HISTORY._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
            }
            if (model.M_TM != null)
            {
                condition.And(MV_JYXX_HISTORY._.M_TM == (model.M_TM));
            }
            if (!string.IsNullOrWhiteSpace(model.M_PROJECT_TYPE))
            {
                condition.And(MV_JYXX_HISTORY._.M_PROJECT_TYPE.Contain(model.M_PROJECT_TYPE));
            }
            if (model.TM != null)
            {
                condition.And(MV_JYXX_HISTORY._.TM == (model.TM));
            }
            return condition;
        }
        #endregion
    }
}
