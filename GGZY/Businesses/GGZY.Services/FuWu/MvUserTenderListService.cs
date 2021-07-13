using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class MvUserTenderListService
    {
        /// <summary>
        /// 中标率排名
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult WinRatePageList(MV_USER_TENDER_LIST model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, MV_USER_TENDER_LIST._.RATE.Desc&& MV_USER_TENDER_LIST._.WIN_COUNT.Desc && MV_USER_TENDER_LIST._.COUNT.Desc).ToPageTableResult(search,count);
            return pageList;
        }/// <summary>
        /// 中标率排名
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult BidCountPageList(MV_USER_TENDER_LIST model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, MV_USER_TENDER_LIST._.COUNT.Desc && MV_USER_TENDER_LIST._.WIN_COUNT.Desc ).ToPageTableResult(search, count);
            return pageList;
        }
    }
}