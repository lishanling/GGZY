using System;
using System.Collections.Generic;
using GGZY.Core.Authentication;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYFW.DbEntity;

namespace GGZY.Services.Infrastructure.Extensions
{
    public static class JdUserExtensions
    {
        #region 监督平台用户扩展信息

        /// <summary>
        /// 监督平台用户信息
        /// </summary>
        /// <param name="identity"></param>
        /// <returns></returns>
        public static JdUserModel JdUser(this CustomAuthenticationIdentity identity)
        {
            if (identity.AuthenticationType.IndexOf("MZT", StringComparison.CurrentCultureIgnoreCase) > -1)
            {
                return GlobalCache.Instance.Get($"{ConfigHelper.APP_KEY_GGZYJD}_{identity.Ticket}", () =>
                {
                    var jdUid = identity.Id.ToNullableDecimal();
                    var jdUser = ServicesFactory.GGZYJD.TUserService.JdUserInfo(jdUid);
                    return jdUser;
                });
            }

            if (identity.AuthenticationType.IndexOf("SMRZ", StringComparison.CurrentCultureIgnoreCase) > -1)
            {
                return GlobalCache.Instance.Get($"{ConfigHelper.APP_KEY_GGZYJD}_{identity.Ticket}", () =>
                {
                    var jdUid = DbContext.Fw.From<MZTUSER>().Where(MZTUSER._.USER_ID == identity.MztId)
                        .Select(MZTUSER._.JDUSERID).ToScalar<decimal>();
                    var jdUser = ServicesFactory.GGZYJD.TUserService.JdUserInfo(jdUid);
                    return jdUser;
                });
            }

            return GlobalCache.Instance.Get($"{ConfigHelper.APP_KEY_GGZYJD}_{identity.Ticket}", () =>
            {
                var jdUid = ServicesFactory.GGZYFW.UnifyUserService.FromWhere(UNIFY_USER._.MGUID == identity.Id)
                    .InnerJoin<UNIFY_AUTHS>(UNIFY_AUTHS._.USERGUID == UNIFY_USER._.MGUID)
                    .InnerJoin<UNIFY_APP>(UNIFY_APP._.MGUID == UNIFY_AUTHS._.APPGUID && (UNIFY_APP._.APPTYPE == ConfigHelper.APP_KEY_GGZYJD))
                    .Select(UNIFY_AUTHS._.APPUID).ToScalar<decimal>();
                var jdUser = ServicesFactory.GGZYJD.TUserService.JdUserInfo(jdUid);
                return jdUser;
            });
        }

        public static List<GeneralMenu> UserMenus(this JdUserModel jdUser)
        {
            return ServicesFactory.GGZYJD.TUserMenuV2Service.UserMenus();
        }
        /// <summary>
        /// 权限
        /// </summary>
        /// <param name="jdUser"></param>
        /// <param name="ctrl"></param>
        /// <param name="act"></param>
        /// <returns></returns>
        public static bool HasPermission(this JdUserModel jdUser, string ctrl, string act)
        {
            var enableMenu = ServicesFactory.GGZYJD.TUserMenuV2Service.EnableMenu();
            var url = $"{ctrl}/{act}";
            if (enableMenu.Exists(c => string.Compare(c.URL, url, StringComparison.CurrentCultureIgnoreCase) == 0))//是否有权限控制 是
            {
                if (!jdUser.UserMenus().Exists(c => string.Compare(c.URL, url, StringComparison.CurrentCultureIgnoreCase) != 0))// 是否有权限
                {
                    return false;
                }
            }
            return true;

        }

        public static CustomAuthenticationIdentity CustomAuthenticationIdentity(this JdUserModel jdUser)
        {
            var identity = new CustomAuthenticationIdentity
            {
                Ticket = Guid.NewGuid().ToString("N"),
                Id = jdUser.ID?.ToString(),
                Name = jdUser.MANAGE_NAME,
                LoginName = jdUser.USERNAME,
                AuthenticationType = "MZT"
            };
            return identity;
        }
        #endregion
    }
}