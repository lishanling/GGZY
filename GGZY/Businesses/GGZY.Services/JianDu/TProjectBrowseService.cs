using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TProjectBrowseService 
    {
        public PageTableResult PageTable(T_PROJECT_BROWSE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, T_PROJECT_BROWSE._.BROWSE_NUM.Desc).ToPageTableResult(search,count);
            return pageList;
        }
    }
}