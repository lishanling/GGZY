using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Enums.Jd;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;


namespace GGZY.Services.JianDu
{
    public partial class TUserMenuService 
    {
        public List<object> UserMenus(int jdUid = 0)
        {
            var jdUser=Identity?.JdUser();
#if DEBUG
            jdUser = Jd.TUserService.FirstOrNull(T_USER._.ID == jdUid)?.ConvertTo<JdUserModel>();
#endif
            var r = GlobalCache.Instance.Get($"{ConfigHelper.APP_KEY_GGZYJD}:MENUS:{jdUser.ID}", () =>
            {
                var allMenus = FindList(T_USER_MENU._.IS_EANBLED == 1, T_USER_MENU._.ORDER_BY.Asc);
                if (jdUser.TYPE != (int)JdTUserType.BaoJianBeiAnYongHu)//报建备案用户
                {
                    allMenus.RemoveAll(c => c.ID == 67);//基本资料
                }

                var roleMenus = allMenus.FindAll(c => c.ISURL == 0 || c.PID == 999);//999 账号管理 消息管理 基本资料
                if (jdUser.ID != 0 && jdUser.ID != 1)
                {
                    var userPopedoms = Jd.TUserPopedomService.FindUserPopedomsByRoleids(jdUser.ROLEIDS);
                    var roleMenuIds = userPopedoms.Select(c => c.MENU_ID).Distinct().ToList();
                    roleMenus.AddRange(allMenus.FindAll(c=>roleMenuIds.Exists(m=>m==c.ID)));
                }
                else
                {
                    roleMenus = allMenus;
                }

                var userMenus = roleMenus.Select(c =>
                {
                    var childrenTotal = roleMenus.Count(o => o.PID == c.ID);
                    var level = 0;
                    var pid = c.PID;
                    while (roleMenus.Exists(o=>o.ID==pid))
                    {
                        level++;
                        pid = roleMenus.FirstOrDefault(o => o.ID == pid)?.PID;
                    }
                    object m = new GeneralMenu
                    {
                        MENU_ID= c.ID?.ToString(),//菜单编号
                        PARENT_ID = c.PID?.ToString(),//菜单上级编号
                        NAME = c.NAME,//菜单名称
                        ALIAS = c.NAME,//todo add 菜单别名
                        ICON = c.IMG,// 菜单图标
                        REMARK = string.Empty,//todo add 菜单备注
                        MODULE = string.Empty,//todo add 所属模块
                        TYPE = c.ISURL,//链接类型 0=模块 1=外链
                        URL = c.URL,//链接地址
                        PARAMS = string.Empty,//todo add 链接参数
                        TARGET = c.IS_OPENPAGE==1?"_blank":"_self",// 打开方式
                        IS_NAVI= c.ISURL==1?0:1,//是否属于导航菜单 0=否 1=是
                        SORT = c.ORDER_BY,//菜单排序值
                        STATUS = c.IS_EANBLED,//菜单状态 0=禁用 1=启用
                        CHILDREN_TOTAL = childrenTotal,//该菜单下子级菜单数的合计
                        LEVEL= level,//该菜单的层级深度
                    };
                    return m;
                }).ToList();
                return userMenus;
            });
            return r;
        }
	}
}