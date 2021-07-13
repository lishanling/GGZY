using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GGZY.Core.Authentication;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYFW.DbEntity;

namespace GGZY.Services.Infrastructure.Extensions
{
    public static class MztUserExtensions
    {
        public static MZTUSER MztUser(this CustomAuthenticationIdentity identity)
        {
            if (identity.AuthenticationType.IndexOf("SMRZ", StringComparison.CurrentCultureIgnoreCase) > -1)
            {
                return GlobalCache.Instance.Get($"{ConfigHelper.APP_KEY_GGZYJD}_SMRZ_{identity.Ticket}",
                    () => DbContext.Fw.From<MZTUSER>().Where(MZTUSER._.USER_ID == identity.MztId).ToFirst());
            }
            else
            {
                return GlobalCache.Instance.Get($"{ConfigHelper.APP_KEY_GGZYJD}_SMRZ_{identity.Ticket}",
                    () =>
                    {
                        var jdUid = ServicesFactory.GGZYFW.UnifyUserService.FromWhere(UNIFY_USER._.MGUID == identity.Id)
                            .InnerJoin<UNIFY_AUTHS>(UNIFY_AUTHS._.USERGUID == UNIFY_USER._.MGUID)
                            .InnerJoin<UNIFY_APP>(UNIFY_APP._.MGUID == UNIFY_AUTHS._.APPGUID &&
                                                  (UNIFY_APP._.APPTYPE == ConfigHelper.APP_KEY_GGZYJD))
                            .Select(UNIFY_AUTHS._.APPUID).ToScalar<decimal>();
                        return DbContext.Fw.From<MZTUSER>().Where(MZTUSER._.JDUSERID == jdUid).ToFirst();
                    });

            }

        }
    }
}
