using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TUserTradeplatformService 
    {
        public PageTableResult PageTable(T_USER_TRADEPLATFORM model, SearchCondition search)
        {
            var condition = PageTableConditionBuilder(model, search);
            var count = Count(condition);
            var pageList = PageList(condition, search, T_USER_TRADEPLATFORM._.AREACODE.Asc).ToPageTableResult(search, count, c =>
                new
                {
                    c.ID,
                    ORGANNO = c.PLATFORM_CODE,
                    LEGALNAME = c.SYSTEM_NAME,
                    LEGALCONTACT = c.CONTACT_NAME,
                    AREACODE =c.AREACODE,
                    RoleType = 99
                });


            return pageList;
        }

        public int Count(T_USER_TRADEPLATFORM model, SearchCondition search)
        {
            var condition = PageTableConditionBuilder(model, search);
            return Count(condition);
        }
        protected WhereClipBuilder PageTableConditionBuilder(T_USER_TRADEPLATFORM model, SearchCondition search)
        {
            var condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(search.KeyWord))
            {
                condition.And(T_USER_TRADEPLATFORM._.SYSTEM_NAME.Contain(search.KeyWord)
                              || T_USER_TRADEPLATFORM._.PLATFORM_CODE.Contain(search.KeyWord));
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(model.SYSTEM_NAME))
                {
                    condition.And(T_USER_TRADEPLATFORM._.SYSTEM_NAME.Contain(model.SYSTEM_NAME));
                }

                if (!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
                {
                    condition.And(T_USER_TRADEPLATFORM._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
                }
            }

            return condition;
        }
    }

}