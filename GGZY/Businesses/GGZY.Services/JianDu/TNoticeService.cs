using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TNoticeService
    {
        #region 监督平台-审批用户-通知
        /// <summary>
        /// 获取平台通知分页列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult NoticePublish(T_NOTICE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            if (search.BeginTime.HasValue)
            {
                condition.And(T_NOTICE._.TM >= search.BeginTime);
            }
            if (search.EndTime.HasValue)
            {
                condition.And(T_NOTICE._.TM <= search.EndTime);
            }
            condition.And(T_NOTICE._.STATE == 1);
            var query = FromWhere(condition.ToWhereClip());
            var total = query.Count();
            var list = query.OrderBy(T_NOTICE._.TM.Desc)
                .Page(search.PageSize, search.PageNo)
                .Select(T_NOTICE._.ID, T_NOTICE._.TITLE, T_NOTICE._.TM)
                .ToList<object>();
            var pageList = list.ToPageTableResult(search, total);
            return pageList;
        }
        /// <summary>
        /// 获取平台通知文章内容
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public object NoticePublishContent(string id)
        {
            return FromWhere(T_NOTICE._.ID == id)
                .Select(T_NOTICE._.ID, T_NOTICE._.TITLE, T_NOTICE._.TM, T_NOTICE._.CONTENTS).ToFirst<object>();
        }
        #endregion

        #region 监督平台-管理后台-工作台公告
        /// <summary>
        /// 公告列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult NoticePageTable(T_NOTICE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            if (search.BeginTime.HasValue)
            {
                condition.And(T_NOTICE._.TM >= search.BeginTime);
            }
            if (search.EndTime.HasValue)
            {
                condition.And(T_NOTICE._.TM <= search.EndTime);
            }
            var query = FromWhere(condition.ToWhereClip())
                .LeftJoin<SYS_USER>(SYS_USER._.U_ID == T_NOTICE._.U_ID)
                .LeftJoin<SYS_PUBLICTYPEINFO>(SYS_PUBLICTYPEINFO._.SIGN == "900" && SYS_PUBLICTYPEINFO._.TYPEVALUE == T_NOTICE._.STATE)
                .LeftJoin<SYS_PUBLICTYPEINFO>(SYS_PUBLICTYPEINFO._.SIGN == "900" && SYS_PUBLICTYPEINFO._.TYPEVALUE == T_NOTICE._.ISTOP);
            var total = query.Count();
            var list = query.OrderBy(T_NOTICE._.TM.Desc)
                .Page(search.PageSize, search.PageNo)
                .Select(T_NOTICE._.ID, T_NOTICE._.TITLE, T_NOTICE._.TM, T_NOTICE._.STATE, T_NOTICE._.ISTOP
                    , SYS_USER._.REALNAME
                    , SYS_PUBLICTYPEINFO._.TYPENAME.As("STATE_TEXT")
                    , new Field("TYPENAME", "SYS_PUBLICTYPEINFO2").As("ISTOP_TEXT")
                    )
                .ToList<object>();
            var pageList = list.ToPageTableResult(search, total);
            return pageList;
        }
        /// <summary>
        /// 新增公告
        /// </summary>
        /// <param name="notice"></param>
        /// <returns></returns>
        public GeneralResult CreateNotice(T_NOTICE notice)
        {
            notice.ID = 0;
            notice.U_ID = JdUser.ID;
            notice.TM = DateTime.Now;
            return this.Add(notice);
        }
        /// <summary>
        /// 编辑公告
        /// </summary>
        /// <param name="notice"></param>
        /// <returns></returns>
        public GeneralResult UpdateNotice(T_NOTICE notice)
        {
            notice.U_ID = JdUser.ID;
            notice.TM = DateTime.Now;
            return this.Edit(notice);
        }
        #endregion
    }
}

