using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TUserRoleV2Service
    {
        /// <summary>
        /// 监督平台用户角色组权限设置
        /// </summary>
        /// <param name="group"></param>
        /// <param name="auth"></param>
        /// <returns></returns>
        public GeneralResult SaveAuthGroupItem(GeneralAuthGroup group, GeneralAuthRule auth)
        {
            var r = new GeneralResult();
            if (string.IsNullOrWhiteSpace(group.GROUP_ID))
            {
                if (Exists(T_USER_ROLE_V2._.NAME == group.NAME))
                {
                    r.SetFail($"用户组 {group.NAME} 已存在");
                }
                else
                {
                    using (var dbTrans=GetDbSession().BeginTransaction())
                    {
                        var role = group.ConvertTo<T_USER_ROLE_V2>();
                        role.GROUP_ID = Guid.NewGuid().To19String();
                        role.CREATEDBY = JdUser?.ID?.ToString();
                        role.CREATEDTIME = DateTime.Now;
                        role.UPDATEDBY = role.CREATEDBY;
                        role.UPDATEDTIME = role.UPDATEDTIME;
                        dbTrans.Insert(role);

                        auth.NAME = group.NAME;
                        auth.RULE_ID = role.GROUP_ID;

                        var entity = new T_USER_POPEDOM_V2
                        {
                            RULE_ID=Guid.NewGuid().To19String(),
                            NAME=group.NAME,
                            GROUP_ID=role.GROUP_ID,
                            LOG_AUTH = auth.LOG_AUTH_STR,
                            MENU_AUTH = auth.MENU_AUTH_STR,
                            MODULE = string.IsNullOrWhiteSpace(auth.MODULE)?"GGZYJD_ADMIN":auth.MODULE,
                            UPDATEDBY = JdUser?.ID?.ToString(),
                            UPDATEDTIME = DateTime.Now,
                            CREATEDBY = JdUser?.ID?.ToString(),
                            CREATEDTIME = DateTime.Now,
                        };
                        dbTrans.Insert(entity);
                        dbTrans.Commit();
                        r.SetSuccess();
                    }
                }
            }
            else
            {
                var role = FirstOrNull(T_USER_ROLE_V2._.GROUP_ID == group.GROUP_ID);
                if (role == null)
                {
                    r.SetFail($"用户组不存在");
                }
                else if (Exists(T_USER_ROLE_V2._.NAME == group.NAME && T_USER_ROLE_V2._.GROUP_ID != role.GROUP_ID))
                {
                    r.SetFail($"用户组 {group.NAME} 已存在");
                }
                else
                {
                    using (var dbTrans=GetDbSession().BeginTransaction())
                    {

                        role.Attach();
                        role.NAME = group.NAME;
                        role.DESCRIPTION = group.DESCRIPTION;
                        role.SORT = group.SORT;
                        role.STATUS = group.STATUS;
                        role.UPDATEDBY = role.CREATEDBY;
                        role.UPDATEDTIME = role.UPDATEDTIME;
                        dbTrans.Update(role);

                        dbTrans.Delete<T_USER_POPEDOM_V2>(T_USER_POPEDOM_V2._.GROUP_ID == role.GROUP_ID);
                        var entity = new T_USER_POPEDOM_V2
                        {
                            RULE_ID = Guid.NewGuid().To19String(),
                            NAME = group.NAME,
                            GROUP_ID = role.GROUP_ID,
                            LOG_AUTH = auth.LOG_AUTH_STR,
                            MENU_AUTH = auth.MENU_AUTH_STR,
                            MODULE = string.IsNullOrWhiteSpace(auth.MODULE) ? "GGZYJD_ADMIN" : auth.MODULE,
                            UPDATEDBY = JdUser?.ID?.ToString(),
                            UPDATEDTIME = DateTime.Now,
                            CREATEDBY = JdUser?.ID?.ToString(),
                            CREATEDTIME = DateTime.Now,
                        };
                        dbTrans.Insert(entity);
                        dbTrans.Commit();
                        r.SetSuccess();
                    }
                }
            }
            return r;
        }

        /// <summary>
        /// 添加一个用户组
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public GeneralResult AddAuthGroupItem(GeneralAuthGroup group)
        {
            var r = new GeneralResult();
            if (Exists(T_USER_ROLE_V2._.NAME == group.NAME))
            {
                r.SetFail($"用户组 {group.NAME} 已存在");
            }
            else
            {
                var role = group.ConvertTo<T_USER_ROLE_V2>();
                role.GROUP_ID = BitConverter.ToInt64(Guid.NewGuid().ToByteArray(), 0).ToString();
                role.CREATEDBY = JdUser?.ID?.ToString();
                role.CREATEDTIME = DateTime.Now;
                role.UPDATEDBY = role.CREATEDBY;
                role.UPDATEDTIME = role.UPDATEDTIME;
                Insert(role);
                r.SetSuccess();
            }
            return r;
        }

        public PageTableResult GetAuthGroupList(GeneralAuthGroup group, SearchCondition search)
        {
            var model = group.ConvertTo<T_USER_ROLE_V2>();
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            if (count > 0)
            {
                var list = FromWhere(condition.ToWhereClip())
                    .OrderBy(T_USER_ROLE_V2._.SORT.Desc)
                    .Page(search.PageSize, search.PageNo)
                    .ToList<GeneralAuthGroup>();
                var groupIds = list.Select(c => c.GROUP_ID).ToList();
                var rules = Jd.TUserPopedomV2Service.FindList(T_USER_POPEDOM_V2._.GROUP_ID.In(groupIds));
              
                foreach (var data in list)
                {
                    var authRules = rules.FindAll(c => c.GROUP_ID == data.GROUP_ID);
                    var logAuth = string.Join(",", authRules.Select(c => c.LOG_AUTH))
                        .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();
                    var menuAuth = string.Join(",", authRules.Select(c => c.MENU_AUTH))
                        .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();
                    data.LOG_AUTH_ARRAY = logAuth;
                    data.MENU_AUTH_ARRAY = menuAuth;
                }

                var plist = list.ToPageTableResult(search, count);
                return plist;
            }

            return search.ToPageTableResult();
        }

        /// <summary>
        /// 编辑一个用户组
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public GeneralResult SetAuthGroupItem(GeneralAuthGroup group)
        {
            var r = new GeneralResult();
            var role = FirstOrNull(T_USER_ROLE_V2._.GROUP_ID == group.GROUP_ID);
            if (role == null)
            {
                r.SetFail($"用户组不存在");
            }
            else if (Exists(T_USER_ROLE_V2._.NAME == group.NAME && T_USER_ROLE_V2._.GROUP_ID != role.GROUP_ID))
            {
                r.SetFail($"用户组 {group.NAME} 已存在");
            }
            else
            {
                role.Attach();
                role.NAME = group.NAME;
                role.DESCRIPTION = group.DESCRIPTION;
                role.SORT = group.SORT;
                role.STATUS = group.STATUS;
                role.UPDATEDBY = role.CREATEDBY;
                role.UPDATEDTIME = role.UPDATEDTIME;
                Update(role);
                r.SetSuccess();
            }
            return r;
        }
        /// <summary>
        /// 获取一个用户组
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public GeneralResult GetAuthGroupItem(GeneralAuthGroup group)
        {
            var r = ViewByPk(group.GROUP_ID);
            if (r.Success)
            {
                var data = r.Data.ConvertTo<GeneralAuthGroup>();
                var groupId = data.GROUP_ID;
                var rules = Jd.TUserPopedomV2Service.FindList(T_USER_POPEDOM_V2._.GROUP_ID == groupId);
                var logAuth = string.Join(",", rules.Select(c => c.LOG_AUTH))
                    .Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();
                var menuAuth = string.Join(",", rules.Select(c => c.MENU_AUTH))
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();
                data.LOG_AUTH_ARRAY = logAuth;
                data.MENU_AUTH_ARRAY = menuAuth;
                r.SetSuccess(data);
            }
            return r;
        }
        /// <summary>
        /// 删除一个用户组
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public GeneralResult DelAuthGroupItem(GeneralAuthGroup group)
        {
            var r = Delete(group.GROUP_ID);
            return r;
        }
        /// <summary>
        /// 设置用户组状态
        /// </summary>
        /// <param name="group"></param>
        public void SetAuthGroupStatus(GeneralAuthGroup group)
        {
            var ids = group.GROUP_ID.Replace("[", "").Replace("]", "");
            var idArr = ids.Split(',');
            Update(T_USER_ROLE_V2._.STATUS, group.STATUS, T_USER_ROLE_V2._.GROUP_ID.In(idArr));
        }
        /// <summary>
        /// 设置用户组排序
        /// </summary>
        /// <param name="group"></param>
        public void SetAuthGroupSort(GeneralAuthGroup group)
        {
            Update(T_USER_ROLE_V2._.SORT, group.SORT, T_USER_ROLE_V2._.GROUP_ID == group.GROUP_ID);
        }
        /// <summary>
        /// 查找对应角色id的角色信息
        /// </summary>
        /// <param name="roleIds"></param>
        /// <returns></returns>
        public List<T_USER_ROLE_V2> FindUserRoles(string roleIds = "")
        {
            if (string.IsNullOrWhiteSpace(roleIds))
            {
                roleIds = JdUser.ROLEIDS;
            }

            var roleIdList = roleIds?.Split(',').Where(c => !string.IsNullOrWhiteSpace(c)).ToList();
            if (roleIdList != null && roleIdList.Any())
            {
                var roles = FindList(T_USER_ROLE_V2._.GROUP_ID.In(roleIdList));
                return roles;
            }
            return new List<T_USER_ROLE_V2>();
        }
    }
}