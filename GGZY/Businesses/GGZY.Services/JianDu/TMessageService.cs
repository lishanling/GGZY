using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TMessageService
    {
        /// <summary>
        /// 查询【调阅申请】
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult SearchDYSQ(T_MESSAGE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            if (search.BeginTime.HasValue)
            {
                condition.And(T_MESSAGE._.TM >= search.BeginTime);
            }
            if (search.EndTime.HasValue)
            {
                condition.And(T_MESSAGE._.TM <= search.EndTime);
            }

            if (JdUser != null)
            {
                condition.And(T_MSG_STATE._.U_ID == JdUser.ID);
            }

            var query = FromWhere(condition.ToWhereClip())
                .InnerJoin<T_MSG_STATE>(T_MSG_STATE._.MID == T_MESSAGE._.ID && T_MSG_STATE._.ISDEL != 1)
                .LeftJoin<SYS_PUBLICTYPEINFO>(SYS_PUBLICTYPEINFO._.TYPEVALUE == T_MSG_STATE._.ISREAD &&
                                              SYS_PUBLICTYPEINFO._.SIGN == 900);
            var total = query.Count();
            var list = query.Page(search.PageSize, search.PageNo)
                .OrderBy(T_MESSAGE._.TM.Desc)
                .Select(T_MESSAGE._.ID, T_MESSAGE._.TM, T_MESSAGE._.TITLE, SYS_PUBLICTYPEINFO._.TYPENAME)
                .ToList<object>();
            var pageList = list.ToPageTableResult(search, total);
            return pageList;
        }

        /// <summary>
        /// 监督后台-通知信息 详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public object DYSQ_Detail(string id)
        {
            var jdUserId = JdUser.ID;
            var obj = FromWhere(T_MSG_STATE._.U_ID == jdUserId && T_MESSAGE._.ID == id)
                .InnerJoin<T_MSG_STATE>(T_MSG_STATE._.MID == T_MESSAGE._.ID && T_MSG_STATE._.ISDEL != 1)
                .ToFirst<object>();
            Update<T_MSG_STATE>(new Dictionary<Field, object>()
                {
                    {T_MSG_STATE._.ISREAD, 1},
                    {T_MSG_STATE._.READ_TM, DateTime.Now},
                }, T_MSG_STATE._.MID == id && T_MSG_STATE._.U_ID == jdUserId && T_MSG_STATE._.ISREAD != 1);
            return obj;
        }
    }
}