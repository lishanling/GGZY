using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TUserMenuV2Service
    {
        private string ENABLE_MENU_CACHE_KEY = $"{ConfigHelper.APP_KEY_GGZYJD}:MENUS:ENABLE";
        /// <summary>
        /// 可用菜单
        /// </summary>
        /// <returns></returns>
        public List<T_USER_MENU_V2> EnableMenu()
        {
            return Cache.Get(ENABLE_MENU_CACHE_KEY, ()=>
            {
                //var enables = FromWhere(T_USER_MENU_V2._.STATUS == 1)
                //    .OrderBy(T_USER_MENU_V2._.SORT.Asc)
                //    .Select(T_USER_MENU_V2._.URL
                //        , T_USER_MENU_V2._.NAME
                //        , T_USER_MENU_V2._.ICON
                //        , T_USER_MENU_V2._.ISSHOW
                //        , T_USER_MENU_V2._.MENU_ID
                //        , T_USER_MENU_V2._.PARENT_ID
                //        , T_USER_MENU_V2._.MENU_LEVEL
                //        , T_USER_MENU_V2._.TYPE
                //        , T_USER_MENU_V2._.IS_NAVI
                //        )
                //    .ToList();
                var enables = FindList(T_USER_MENU_V2._.STATUS == 1, T_USER_MENU_V2._.SORT.Asc);
                return enables;
            });
        }
        public List<GeneralMenu> UserMenus(decimal? jdUid = null,string module="jd")
        {
            if (!jdUid.HasValue)
            {
                jdUid = JdUser?.ID;
            }
            var r = Cache.Get($"{ConfigHelper.APP_KEY_GGZYJD}:MENUS:{jdUid}:{module}", () =>
            {
                var allMenus = EnableMenu().FindAll(c=>c.MODULE==module);
                var roleMenus = allMenus;//999 账号管理 消息管理 基本资料
                var roles = Jd.TUserRoleV2Service.FindUserRoles(JdUser.ROLEIDS);
                var groupids = roles.FindAll(c => c.STATUS == 1 && c.IS_DELETE != 1).Select(c => c.GROUP_ID)
                    .ToList();
                var rules = Jd.TUserPopedomV2Service.FindUserRules(groupids);

                var roleMenuIds = rules.Where(c => !string.IsNullOrWhiteSpace(c.MENU_AUTH)).Select(c => c.MENU_AUTH).ToList();
                var userMenuIds = new List<string>();
                foreach (var rmid in roleMenuIds)
                {
                    userMenuIds.AddRange(rmid.Split(','));
                }
                roleMenus = allMenus.FindAll(c => userMenuIds.Exists(m => m == c.MENU_ID));
                var userMenus = roleMenus.Select(c =>
                {
                    //var m = new GeneralMenu
                    //{
                    //    MENU_ID = c.MENU_ID, //菜单编号
                    //    PARENT_ID = c.PARENT_ID, //菜单上级编号
                    //    NAME = c.NAME, //菜单名称
                    //    ALIAS = c.ALIAS, //
                    //    ICON = c.ICON, // 菜单图标
                    //    REMARK = c.REMARK, //
                    //    MODULE = c.MODULE, //
                    //    TYPE = c.TYPE, //链接类型 0=模块 1=外链
                    //    URL = c.URL, //链接地址
                    //    PARAMS = c.PARAMS, //
                    //    TARGET = c.TARGET, // 打开方式
                    //    IS_NAVI = c.IS_NAVI, //是否属于导航菜单 0=否 1=是
                    //    SORT = c.SORT, //菜单排序值
                    //    STATUS = c.STATUS, //菜单状态 0=禁用 1=启用
                    //    CHILDREN_TOTAL = roleMenus.Count(o => o.PARENT_ID == c.MENU_ID), //该菜单下子级菜单数的合计
                    //    LEVEL = c.MENU_LEVEL, //该菜单的层级深度
                    //};
                    var m = c.ConvertTo<GeneralMenu>();
                    m.CHILDREN_TOTAL = roleMenus.Count(o => o.PARENT_ID == c.MENU_ID); //该菜单下子级菜单数的合计
                    return m;
                }).ToList();
                return userMenus;
            });
            return r;
        }

        #region 菜单CURD

        /// <summary>
        /// 获取菜单列表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<GeneralMenu> FindMenuList(GeneralMenu model)
        {
            var entity = model.ConvertTo<T_USER_MENU_V2>();
            var condition = ConditionBuilder(entity);
            var allMenus = FindList(condition, T_USER_MENU_V2._.SORT.Asc);
            var generalMenus = allMenus.Select(c =>
            {
                var m = c.ConvertTo<GeneralMenu>();
              
                m.CHILDREN_TOTAL = allMenus.Count(o => o.PARENT_ID == c.MENU_ID);//该菜单下子级菜单数的合计
                return m;
            }).ToList();
            return generalMenus;
        }

        /// <summary>
        /// 添加一个菜单
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult AddMenuItem(GeneralMenu model)
        {
            GeneralResult result = new GeneralResult();
            try
            {
                var entity = model.ConvertTo<T_USER_MENU_V2>();
                entity.MENU_ID = Guid.NewGuid().ToString();
                entity.CREATEDBY = Identity?.JdUser()?.ID?.ToString();
                entity.CREATEDTIME = DateTime.Now;
                entity.UPDATEDBY = Identity?.JdUser()?.ID?.ToString();
                entity.UPDATEDTIME = DateTime.Now;
                Insert(entity);
                result.SetSuccess(entity.ConvertTo<GeneralMenu>());
                Cache.Remove(ENABLE_MENU_CACHE_KEY);
                Cache.RemoveByPattern($"{ConfigHelper.APP_KEY_GGZYJD}:MENUS");
                Cache.RemoveByPattern($"{ConfigHelper.APP_KEY_GGZYFW}:MENUS");
                Cache.RemoveByPattern($"MENUS");
            }
            catch (Exception e)
            {
                result.SetException($"添加菜单异常:{e.Message}", e);
            }
            return result;
        }

        /// <summary>
        /// 获取一个菜单
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult GetMenuItem(GeneralMenu model)
        {
            GeneralResult result = new GeneralResult();
            try
            {
                var entity = FirstOrNull(c => c.MENU_ID == model.MENU_ID);
                if (entity == null)
                {
                    result.SetFail("未找到对应的菜单");
                }
                else
                {
                    result.SetSuccess(entity.ConvertTo<GeneralMenu>());
                }
            }
            catch (Exception e)
            {
                result.SetException($"获取菜单异常:{e.Message}", e);
            }
            return result;
        }

        /// <summary>
        /// 编辑一个菜单
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult SetMenuItem(GeneralMenu model)
        {
            GeneralResult result = new GeneralResult();
            try
            {
                var entity = FirstOrNull(c => c.MENU_ID == model.MENU_ID);
                entity.Attach();
                entity.MENU_ID = model.MENU_ID;
                entity.PARENT_ID = model.PARENT_ID;
                entity.NAME = model.NAME;
                entity.ALIAS = model.ALIAS;
                entity.ICON = model.ICON;
                entity.REMARK = model.REMARK;
                entity.MODULE = model.MODULE;
                entity.TYPE = model.TYPE;
                entity.URL = model.URL;
                entity.PARAMS = model.PARAMS;
                entity.TARGET = model.TARGET;
                entity.IS_NAVI = model.IS_NAVI;
                entity.SORT = model.SORT;
                entity.STATUS = model.STATUS;
                entity.MENU_LEVEL = model.MENU_LEVEL;
                entity.CHILDREN_TOTAL = model.CHILDREN_TOTAL;
                entity.ISSHOW = model.ISSHOW;
                entity.UPDATEDBY = Identity?.JdUser()?.ID?.ToString();
                entity.UPDATEDTIME = DateTime.Now;
                Update(entity);
                result.SetSuccess(entity.ConvertTo<GeneralMenu>());
                Cache.Remove(ENABLE_MENU_CACHE_KEY);
                Cache.RemoveByPattern($"{ConfigHelper.APP_KEY_GGZYJD}:MENUS");
                Cache.RemoveByPattern($"{ConfigHelper.APP_KEY_GGZYFW}:MENUS");
                Cache.RemoveByPattern($"MENUS");
            }
            catch (Exception e)
            {
                result.SetException($"编辑菜单异常:{e.Message}", e);
            }
            return result;
        }


        /// <summary>
        /// 删除一个菜单
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult DelMenuItem(GeneralMenu model)
        {
            GeneralResult result = new GeneralResult();
            try
            {
                if (!string.IsNullOrWhiteSpace(model.MENU_ID))
                {
                    var entity = FirstOrNull(T_USER_MENU_V2._.PARENT_ID == model.MENU_ID);
                    if (entity != null)
                    {
                        result.SetFail($"当前菜单含有下级菜单，不允许删除");
                    }
                    else
                    {
                        Delete(T_USER_MENU_V2._.MENU_ID.SelectIn(model.MENU_ID));
                        result.SetSuccess(model.MENU_ID);
                        Cache.Remove(ENABLE_MENU_CACHE_KEY);
                        Cache.RemoveByPattern($"{ConfigHelper.APP_KEY_GGZYJD}:MENUS");
                        Cache.RemoveByPattern($"{ConfigHelper.APP_KEY_GGZYFW}:MENUS");
                        Cache.RemoveByPattern($"MENUS");
                    }
                }
                else
                {
                    result.SetFail($"请选择要删除的记录");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                result.SetFail(e.Message, e);
            }
            return result;
        }

        /// <summary>
        /// 设置菜单状态
        /// </summary>
        /// <param name="model"></param>
        public bool SetMenuStatus(GeneralMenu model)
        {
            var r = Update(T_USER_MENU_V2._.STATUS, model.STATUS, T_USER_MENU_V2._.MENU_ID == model.MENU_ID);

            Cache.Remove(ENABLE_MENU_CACHE_KEY);
            Cache.RemoveByPattern($"{ConfigHelper.APP_KEY_GGZYJD}:MENUS");
            Cache.RemoveByPattern($"{ConfigHelper.APP_KEY_GGZYFW}:MENUS");
            Cache.RemoveByPattern($"MENUS");
            return r > 0;
        }
        /// <summary>
        /// 设置菜单排序
        /// </summary>
        /// <param name="model"></param>
        public bool SetMenuSort(GeneralMenu model)
        {
            var r = Update(T_USER_MENU_V2._.SORT, model.SORT, T_USER_MENU_V2._.MENU_ID == model.MENU_ID);

            Cache.Remove(ENABLE_MENU_CACHE_KEY);
            Cache.RemoveByPattern($"{ConfigHelper.APP_KEY_GGZYJD}:MENUS");
            Cache.RemoveByPattern($"{ConfigHelper.APP_KEY_GGZYFW}:MENUS");
            Cache.RemoveByPattern($"MENUS");
            return r > 0;
        }
        #endregion

        /// <summary>
        /// 初始化旧菜单数据到新菜单表
        /// </summary>
        public GeneralResult InitialMenu()
        {
            GeneralResult result = new GeneralResult();
            var count = Count(WhereClip.All);
            if (count == 0)
            {
                var roleMenus = Jd.TUserMenuService.FindAll();
                var userMenus = roleMenus.Select(c =>
                {
                    var childrenTotal = roleMenus.Count(o => o.PID == c.ID);
                    var level = 0;
                    var pid = c.PID;
                    while (roleMenus.Exists(o => o.ID == pid))
                    {
                        level++;
                        pid = roleMenus.FirstOrDefault(o => o.ID == pid)?.PID;
                    }
                    T_USER_MENU_V2 m = new T_USER_MENU_V2
                    {
                        MENU_ID = c.ID?.ToString(),//菜单编号
                        PARENT_ID = c.PID?.ToString(),//菜单上级编号
                        NAME = c.NAME,//菜单名称
                        ALIAS = c.NAME,//todo add 菜单别名
                        ICON = c.IMG,// 菜单图标
                        REMARK = string.Empty,//todo add 菜单备注
                        MODULE = string.Empty,//todo add 所属模块
                        TYPE = c.ISURL,//链接类型 0=模块 1=外链
                        URL = c.URL,//链接地址
                        PARAMS = string.Empty,//todo add 链接参数
                        TARGET = c.IS_OPENPAGE == 1 ? "_blank" : "_self",// 打开方式
                        IS_NAVI = c.ISURL == 1 ? 0 : 1,//是否属于导航菜单 0=否 1=是
                        SORT = c.ORDER_BY,//菜单排序值
                        STATUS = c.IS_EANBLED,//菜单状态 0=禁用 1=启用
                        CHILDREN_TOTAL = childrenTotal,//该菜单下子级菜单数的合计
                        MENU_LEVEL = level,//该菜单的层级深度
                        ISSHOW = 1,
                        CREATEDBY = "Initial",
                        CREATEDTIME = DateTime.Now,
                        UPDATEDTIME = DateTime.Now,
                        UPDATEDBY = "Initial",
                    };
                    return m;
                }).ToList();
                Insert(userMenus);
                result.SetSuccess($"原有数据{count}，初始化成功:{userMenus.Count}条");
            }
            else
            {
                result.SetFail($"请勿重复初始化数据");
            }
            return result;
        }

    }
}