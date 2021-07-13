using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Extensions;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TUserPopedomService
    {
        /// <summary>
        /// 查找对应角色id的角色信息
        /// </summary>
        /// <param name="roleIds"></param>
        /// <returns></returns>
        public List<T_USER_POPEDOM> FindUserPopedomsByRoleids(string roleIds = "")
        {
            if (string.IsNullOrWhiteSpace(roleIds))
            {
                roleIds = JdUser.ROLEIDS;
            }

            var roleIdList = roleIds?.Split(',').Where(c => !string.IsNullOrWhiteSpace(c)).ToList();
            if (roleIdList != null && roleIdList.Any())
            {
                var roles = FindList(T_USER_POPEDOM._.ROLE_ID.In(roleIdList));
                return roles;
            }
            return new List<T_USER_POPEDOM>();
        }
    }
}