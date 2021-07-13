using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TJyptAccessService 
    {
        /// <summary>
        /// 福建交易平台列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public object TradePlatformAccessList(T_JYPT_ACCESS model ,SearchCondition search)
        {
            //case "0": status_text = "对接中"; break;
            //case "1": status_text = "对接暂停"; break;
            //case "2": status_text = "对接完成"; break;
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, T_JYPT_ACCESS._.ID.Desc).ToPageTableResult(search,count);
            return pageList;
        }
    }
}