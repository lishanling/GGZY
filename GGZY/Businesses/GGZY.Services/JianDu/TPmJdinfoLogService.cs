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
    public partial class TPmJdinfoLogService 
    {
        /// <summary>
        /// 根据项目编号和监督点id，获取项目监督点的动态
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<TPmJdinfoLogModel> GetPMLog(TMpPlanInfoModel model)
        {
            var where = T_PM_JDINFO_LOG._.TENDER_PROJECT_CODE == model.CODE && T_PM_JDINFO_LOG._.MPID == model.ID;
            var query = FromWhere(where)
                .LeftJoin<T_USER>(T_USER._.ID == T_PM_JDINFO_LOG._.U_ID);
           // var count=
            var list = query
                .OrderBy(T_PM_JDINFO_LOG._.TM.Desc)
                .Select(
                    T_PM_JDINFO_LOG._.All, T_USER._.MANAGE_NAME.As("U_ID_NAME")
                ).ToList<TPmJdinfoLogModel>();
            //model.TENDER_PROJECT_CODE
            return list;
        }

    }
}