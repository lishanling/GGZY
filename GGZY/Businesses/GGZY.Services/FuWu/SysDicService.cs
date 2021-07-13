using System.Collections.Generic;
using System.Linq;
using GGZY.Core.Cache;
using GGZY.Core.Models;
using GGZY.Services.Infrastructure.Helper;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class SysDicService 
    {
        #region FindDictionaryTextValue 1 2 3 4 5 

        /// <summary>
        /// 按照TYPE
        /// </summary>
        /// <param name="type"></param>
        /// <param name="pid"></param>
        /// <param name="vIndex"></param>
        /// <returns></returns>
        public List<LabelValueModel> FindDictionaryTextValue(string type,int?pid=null,int vIndex=0)
        {
            var dics = FindDicByType(type,pid).Select(c => new LabelValueModel
            {
                Id = c.ID?.ToString(),
                Label = c.TEXT,
                Value =vIndex==1?c.VALUE1 : vIndex ==2 ? c.VALUE2 : vIndex ==3 ? c.VALUE3 : vIndex == 4 ? c.VALUE4 : vIndex == 5 ? c.VALUE5:c.VALUE,
            }).ToList();
            return dics;
        }

        #endregion

        /// <summary>
        /// 按照TYPE
        /// </summary>
        /// <param name="type"></param>
        /// <param name="pid"></param>
        /// <returns></returns>
        public List<SYS_DIC> FindDicByType(string type,int?pid=null)
        {
            var dics = Cache.Get($"{ConfigHelper.APP_KEY_GGZYJD}:SYS_DIC:TYPE_{type}",
                () =>
                {
                    var sysDics = FindList(SYS_DIC._.TYPE == type).ToList();
                    return sysDics;
                }).OrderBy(od => od.ORDER_ID).ThenBy(od => od.VALUE).ToList();
            if (pid.HasValue)
            {
                dics = dics.FindAll(c => c.PID == pid);
            }
            return dics;
        }
    }
}