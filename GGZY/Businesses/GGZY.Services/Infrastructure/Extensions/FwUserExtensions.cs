using System;
using System.Collections.Generic;
using System.Linq;
using GGZY.Core.Authentication;
using GGZY.Core.Cache;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model.FuWu;
using GGZYFW.DbEntity;

namespace GGZY.Services.Infrastructure.Extensions
{
    public static class FwUserExtensions
    {
        #region 服务平台用户扩展信息

        /// <summary>
        /// 服务平台用户信息
        /// </summary>
        /// <param name="identity"></param>
        /// <returns></returns>
        public static FwUserModel FwUser(this CustomAuthenticationIdentity identity)
        {
            return GlobalCache.Instance.Get($"{ConfigHelper.APP_KEY_GGZYFW}_{identity.Ticket}", () =>
            {
                var selectFiled = new LEGAL_PERSON_BASE().GetFields().ToList();
                selectFiled.RemoveAll(c => c.Name == "IS_DELETE");
                selectFiled.Add(T_USER._.All);
                var fwUser = ServicesFactory.GGZYFW.UnifyUserService.FromWhere(UNIFY_USER._.MGUID == identity.Id)
                    .InnerJoin<UNIFY_AUTHS>(UNIFY_AUTHS._.USERGUID == UNIFY_USER._.MGUID)
                    .InnerJoin<UNIFY_APP>(UNIFY_APP._.MGUID == UNIFY_AUTHS._.APPGUID && UNIFY_APP._.APPTYPE == ConfigHelper.APP_KEY_GGZYFW)
                    .InnerJoin<T_USER>(T_USER._.ID == UNIFY_AUTHS._.APPUID)
                    .LeftJoin<LEGAL_PERSON_BASE>(T_USER._.ID == LEGAL_PERSON_BASE._.M_USER_ID)
                    .Select(selectFiled.ToArray()).ToFirst<FwUserModel>();
                return fwUser;
            });
        }
        /// <summary>
        /// 当前登录用户角色
        /// </summary>
        /// <returns></returns>
        public static List<UserRole> GetRoles(this FwUserModel user)
        {
            List<UserRole> roleArray = new List<UserRole>();
            if (null == user)
            {
                return roleArray;
            }
            var roles = user.ROLEIDS.Split(',');
            foreach (var r in roles)
            {
                switch (r)
                {
                    case "26":
                        roleArray.Add(UserRole.tradingCenter);
                        break;
                    case "11":
                        roleArray.Add(UserRole.agency);
                        break;
                    default:
                        break;
                }
            }
            return roleArray;
        }

        /// <summary>
        /// 当前登录用户角色名称
        /// </summary>
        /// <returns></returns>
        public static List<string> GetRoleName(this FwUserModel user)
        {
            List<string> roleArray = new List<string>();
            if (null == user || String.IsNullOrWhiteSpace(user.ROLEIDS))
            {
                return roleArray;
            }
            var roles = user.ROLEIDS.Split(',');
            foreach (var r in roles)
            {
                switch (r)
                {
                    case "26":
                        roleArray.Add(UserRole.tradingCenter.ToString());
                        break;
                    case "11":
                        roleArray.Add(UserRole.agency.ToString());
                        break;
                    default:
                        break;
                }
            }
            return roleArray;
        }

        #endregion
    }
}