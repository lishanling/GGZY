using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TAfcLogService
    {

        /// <summary>
        /// 项目报建维护-报建项目日志列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult AfcLogPageTable(T_AFC_LOG model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var total = Count(condition.ToWhereClip());
            var pagelist = FromWhere(condition.ToWhereClip())
                .LeftJoin<T_USER>(T_USER._.ID == T_AFC_LOG._.U_ID)//报建用户
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == T_AFC_LOG._.APPROVAL_DEPID)//审查用户
                .Select(T_AFC_LOG._.All, T_USER._.USERNAME.As("U_ID_NAME"), T_USER_DEPARTMENT._.DNAME.As("APPROVAL_DEPNAME"))
                .Page(search.PageSize, search.PageNo)
                .ToList<TAfcLogModel>()
                .ToPageTableResult(search, total, c => {
                    c.MID = c.ID?.ToString().DesEncrypt();
                    return c;
                });
            return pagelist;
        }
        /// <summary>
        /// 更新报建用户信息和审查单位信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult UpdateAfcLogInfo(T_AFC_LOG model)
        {
            var r = new GeneralResult();
            var entity = FirstOrNull(T_AFC_LOG._.ID == model.ID);
            if (entity != null)
            {
                entity.Attach();
                entity.U_ID = model.U_ID;
                entity.APPROVAL_DEPID = model.APPROVAL_DEPID;
                entity.DEP_NAME = model.DEP_NAME;
                entity.JS_DEP = model.JS_DEP;
                Update(entity);
                r.SetSuccess();
            }
            else
            {
                r.SetFail("未找到对应的报建信息");
            }

            return r;
        }
    }
}