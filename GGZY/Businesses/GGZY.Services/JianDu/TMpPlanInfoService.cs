using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TMpPlanInfoService
    {
        #region 监督服务-监督点统计

        public TMpPlanInfoModel GetMpPlanInfo(TMpPlanInfoModel model)
        {
            var m = FromWhere(T_MP_PLAN_INFO._.ID == model.ID)
                 .LeftJoin<T_PM_JDINFO>(T_PM_JDINFO._.MPID == T_MP_PLAN_INFO._.ID &&
                                        T_PM_JDINFO._.TENDER_PROJECT_CODE == model.CODE)
                 .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "51" && SYS_DIC._.VALUE == T_MP_PLAN_INFO._.KIND)
                 .OrderBy(T_MP_PLAN_INFO._.ID.Asc)
                 .Select(
                     T_MP_PLAN_INFO._.All
                     , T_PM_JDINFO._.BUSINESSID.As("JDINFO_BUSINESSID")
                     , T_PM_JDINFO._.LEVEL_TYPE.As("JDINFO_LEVEL_TYPE")
                     , SYS_DIC._.TEXT.As("KIND_TEXT")
                     )
                 .ToFirst<TMpPlanInfoModel>();
            return m;
        }

        #endregion
    }
}