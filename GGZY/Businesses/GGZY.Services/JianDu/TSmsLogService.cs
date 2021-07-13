using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TSmsLogService
    {
        #region 处长门户 项目监督 短信通知汇总
        /// <summary>
        /// 处长门户 项目监督 短信通知汇总 行业主管
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult HySmsPageList(SearchCondition search)
        {
            var condition = new WhereClipBuilder(T_SMS_LOG._.TEL_PHONE == JdUser?.PHONE || T_SMS_LOG._.TEL_PHONE == JdUser?.TELPHONE);
            condition.And(T_SMS_LOG._.SMS_CONTENT.Contain("<报建>您有") ||
                          T_SMS_LOG._.SMS_CONTENT.Contain("<备案>您有一条") ||
                          T_SMS_LOG._.SMS_CONTENT.Contain("<投诉>您有") ||

                          T_SMS_LOG._.SMS_CONTENT.Contain("您有一个招标计划登记超期未处理") ||
                          T_SMS_LOG._.SMS_CONTENT.Contain("您有一个招标备案超期未处理") ||
                          T_SMS_LOG._.SMS_CONTENT.Contain("您有一个投诉超期未处理") ||
                          T_SMS_LOG._.SMS_CONTENT.Contain("您有一个异常监督点超期未处理")||

                          T_SMS_LOG._.SMS_CONTENT.Contain("报建超期未审查")||
                          T_SMS_LOG._.SMS_CONTENT.Contain("报建快要超期")
                          );
            var query = FromWhere(condition.ToWhereClip());
            var count = query.Count();
            if (count > 0)
            {
                var list = query.OrderBy(T_SMS_LOG._.SEND_TM.Desc)
                    .Page(search.PageSize, search.PageNo)
                    .ToList();
                var plist = list.ToPageTableResult(search, count);
                return plist;
            }

            return search.ToPageTableResult();
        }

        /// <summary>
        /// 处长门户 项目监督 短信通知汇总 纪委监委
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult JwSmsPageList(SearchCondition search)
        {
            var condition = new WhereClipBuilder(T_SMS_LOG._.TEL_PHONE == JdUser?.PHONE || T_SMS_LOG._.TEL_PHONE == JdUser?.TELPHONE);
            condition.And(T_SMS_LOG._.SMS_CONTENT.Contain("您有一个监察事项超期未处理") 
            );
            var query = FromWhere(condition.ToWhereClip());
            var count = query.Count();
            if (count > 0)
            {
                var list = query.OrderBy(T_SMS_LOG._.SEND_TM.Desc)
                    .Page(search.PageSize, search.PageNo)
                    .ToList();
                var plist = list.ToPageTableResult(search, count);
                return plist;
            }

            return search.ToPageTableResult();
        }

        /// <summary>
        /// 处长门户 项目监督 短信通知汇总 公安
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult GaSmsPageList(SearchCondition search)
        {
            var condition = new WhereClipBuilder(T_SMS_LOG._.TEL_PHONE == JdUser?.PHONE || T_SMS_LOG._.TEL_PHONE == JdUser?.TELPHONE);
            condition.And(T_SMS_LOG._.SMS_CONTENT.Contain("您有一个移送事项超期未处理")
            );
            var query = FromWhere(condition.ToWhereClip());
            var count = query.Count();
            if (count > 0)
            {
                var list = query.OrderBy(T_SMS_LOG._.SEND_TM.Desc)
                    .Page(search.PageSize, search.PageNo)
                    .ToList();
                var plist = list.ToPageTableResult(search, count);
                return plist;
            }

            return search.ToPageTableResult();
        }
        #endregion
    }
}