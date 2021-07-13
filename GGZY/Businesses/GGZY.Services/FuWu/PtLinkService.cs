using System.Collections.Generic;
using System.Linq;
using GGZY.Core.Cache;
using GGZY.Services.Infrastructure.Helper;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class PtLinkService 
    {
        //SELECT TITLE,ADDRESS FROM PT_LINK WHERE TYPE=#value#  ORDER BY ORDERID,ID
        public List<object> Link(PT_LINK model)
        {
            return FindList(PT_LINK._.TYPE == model.TYPE, PT_LINK._.ORDERID.Asc && PT_LINK._.ID.Asc).ToList<object>();
            //var links = Cache.Get<List<object>>($"{ConfigHelper.APP_KEY_GGZYFW}::PT:LINK:{model.TYPE}",
            //    ConfigHelper.AppSettings.FW_PT_LINK_CACHE_MINITE,
            //    () => FindList(PT_LINK._.TYPE == model.TYPE, PT_LINK._.ORDERID.Asc && PT_LINK._.ID.Asc).ToList<object>());
            //return links;
        }
    }
}