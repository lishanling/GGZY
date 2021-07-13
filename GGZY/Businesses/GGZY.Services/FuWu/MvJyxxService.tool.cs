using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class MvJyxxService : BaseServiceT<MV_JYXX>
    {
        #region Utils
        protected WhereClipBuilder ConditionBuilder(MV_JYXX model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.KIND))
            {
                condition.And(MV_JYXX._.KIND.Contain(model.KIND));
            }
            if (!string.IsNullOrWhiteSpace(model.TITLE))
            {
                condition.And(MV_JYXX._.TITLE.Contain(model.TITLE));
            }
            if (!string.IsNullOrWhiteSpace(model.GGTYPE))
            {
                condition.And(MV_JYXX._.GGTYPE.Contain(model.GGTYPE));
            }
            if (!string.IsNullOrWhiteSpace(model.NAME))
            {
                condition.And(MV_JYXX._.NAME.Contain(model.NAME));
            }
            if (model.M_ID != null)
            {
                condition.And(MV_JYXX._.M_ID == (model.M_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
            {
                condition.And(MV_JYXX._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.PLATFORM_NAME))
            {
                condition.And(MV_JYXX._.PLATFORM_NAME.Contain(model.PLATFORM_NAME));
            }
            if (model.TM1 != null)
            {
                condition.And(MV_JYXX._.TM1 == (model.TM1));
            }
            if (!string.IsNullOrWhiteSpace(model.PROCODE))
            {
                condition.And(MV_JYXX._.PROCODE.Contain(model.PROCODE));
            }
            if (!string.IsNullOrWhiteSpace(model.AREACODE))
            {
                condition.And(MV_JYXX._.AREACODE.Contain(model.AREACODE));
            }
            if (!string.IsNullOrWhiteSpace(model.AREANAME))
            {
                condition.And(MV_JYXX._.AREANAME.Contain(model.AREANAME));
            }
            if (!string.IsNullOrWhiteSpace(model.PROTYPE_TEXT))
            {
                condition.And(MV_JYXX._.PROTYPE_TEXT.Contain(model.PROTYPE_TEXT));
            }
            if (!string.IsNullOrWhiteSpace(model.PROTYPE))
            {
                condition.And(MV_JYXX._.PROTYPE.Contain(model.PROTYPE));
            }
            if (!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
            {
                condition.And(MV_JYXX._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
            }
            if (model.M_TM != null)
            {
                condition.And(MV_JYXX._.M_TM == (model.M_TM));
            }
            if (!string.IsNullOrWhiteSpace(model.M_PROJECT_TYPE))
            {
                condition.And(MV_JYXX._.M_PROJECT_TYPE.Contain(model.M_PROJECT_TYPE));
            }
            if (model.TM != null)
            {
                condition.And(MV_JYXX._.TM == (model.TM));
            }
            return condition;
        }
        #endregion
    }
}