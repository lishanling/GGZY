using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TFraudService 
    {
        public PageTableResult PageTable(T_FRAUD model, SearchCondition search)
        {
            //model.STATE = "3";//3 已发布 2 审核不通过 1 待审核
            var condition = ConditionBuilder(model);

            var count = Count(condition);
            var pageList = FromWhere(condition.ToWhereClip())
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "56" && SYS_DIC._.VALUE == T_FRAUD._.STATE)
                .Select(
                    T_FRAUD._.ID,
                    T_FRAUD._.TITLE,
                    T_FRAUD._.COMMIT_TIME,
                    T_FRAUD._.AUDIT_TIME
                ).ToList().ToPageTableResult(search, count);
            return pageList;
        }

        public PageTableResult CompanyIllegal(T_FRAUD model, SearchCondition search)
        {
            model.STATE = "3";//3 已发布 2 审核不通过 1 待审核
            model.TITLE=String.Empty;
            var condition = ConditionBuilder(model);
            if (!string.IsNullOrWhiteSpace(search.KeyWord))
            {
                condition.And(T_FRAUD._.TITLE.Contain(search.KeyWord)||T_FRAUD._.COMPANY_NAME.Contain(search.KeyWord));
            }
            if (search.BeginTime.HasValue)
            {
                var bTime = search.BeginTime.Value;
                condition.And(T_FRAUD._.AUDIT_TIME >= bTime);
            }
            if (search.EndTime.HasValue)
            {
                var bTime = search.EndTime.Value;
                condition.And(T_FRAUD._.AUDIT_TIME <= bTime);
            }
            var count = Count(condition);
            var pageList = PageList(condition, search, T_FRAUD._.AUDIT_TIME.Desc&&T_FRAUD._.COMMIT_TIME.Desc)
                .ToPageTableResult(search, count,c => new
                {
                    ID=c.ID.DesEncrypt(),
                    c.TITLE,
                    TM = c.AUDIT_TIME ?? c.COMMIT_TIME,
                    //c.ATTACHMENT
                    c.ENFORCEMENT_UNIT
                });

            return pageList;
        }
    }
}