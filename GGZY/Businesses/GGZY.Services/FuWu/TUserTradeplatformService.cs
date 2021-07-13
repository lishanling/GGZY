using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;

namespace GGZY.Services.FuWu
{
    public partial class TUserTradeplatformService
    {
        /// <summary>
        /// 获取所有交易平台信息
        /// </summary>
        /// <returns></returns>
        public List<object> TradePlatforms()
        {
            var all = FromWhere(T_USER_TRADEPLATFORM._.IS_THREE!="1").Select(T_USER_TRADEPLATFORM._.PLATFORM_CODE, T_USER_TRADEPLATFORM._.SYSTEM_NAME)
                .ToList<object>();
            return all;
        }

        public PageTableResult PageTable(T_USER_TRADEPLATFORM model, SearchCondition search)
        {
            var condition = PageTableConditionBuilder(model, search);
            var count = Count(condition);
            var pageList = PageList(condition, search, T_USER_TRADEPLATFORM._.ID.Desc).ToPageTableResult(search, count, c =>
                new
                {
                    c.ID,
                    ORGANNO = c.PLATFORM_CODE,
                    LEGALNAME = c.SYSTEM_NAME,
                    LEGALCONTACT = c.CONTACT_NAME,
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