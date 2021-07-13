using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Extensions;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TUserPopedomV2Service
    {
        /// <summary>
        /// 查找对应角色id的角色信息
        /// </summary>
        /// <param name="roleIdList"></param>
        /// <returns></returns>
        public List<T_USER_POPEDOM_V2> FindUserRules(List<string> roleIdList)
        {

            var roles = FindList(T_USER_POPEDOM_V2._.GROUP_ID.In(roleIdList) );
            return roles;
        }


        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult AddAuthRuleItem(GeneralAuthRule model)
        {
            var result = new GeneralResult();
            try
            {
                model.RULE_ID = Guid.NewGuid().ToString(); 
                var entity = model.ConvertTo<T_USER_POPEDOM_V2>();
                entity.LOG_AUTH = model.LOG_AUTH_STR;
                entity.MENU_AUTH = model.MENU_AUTH_STR;
                entity.UPDATEDBY = Identity?.JdUser()?.ID?.ToString();
                entity.UPDATEDTIME = DateTime.Now;
                entity.CREATEDBY = Identity?.JdUser()?.ID?.ToString();
                entity.CREATEDTIME = DateTime.Now;
                entity.MODULE = "GGZYJD_ADMIN";
                entity.RULE_ID = model.RULE_ID;
                Insert(entity);
                result.SetSuccess(model);
            }
            catch (Exception e)
            {
                result.SetFail(e.Message, e);
            }
            return result;
        }

        /// <summary>
        /// 编辑一条规则。
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult SetAuthRuleItem(GeneralAuthRule model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.RULE_ID);
                if (viewResult.Success && viewResult.Data is T_USER_POPEDOM_V2 entity)
                {
                    entity.Attach();
                    entity.GROUP_ID = model.GROUP_ID;
                    entity.CREATEDBY = Identity?.JdUser()?.ID?.ToString();
                    entity.CREATEDTIME = DateTime.Now;
                    entity.REMARK = model.REMARK;
                    entity.POWER = model.POWER;
                    entity.MODULE = model.MODULE;
                    entity.NAME = model.NAME;
                    entity.LOG_AUTH = model.LOG_AUTH_STR;
                    entity.MENU_AUTH = model.MENU_AUTH_STR;
                    entity.SORT = model.SORT;
                    Update(entity);
                    result.SetSuccess(model);
                }
                else
                {
                    result.SetFail(viewResult.Msg);
                }
            }
            catch (Exception e)
            {
                result.SetFail(e.Message, e);
            }
            return result;
        }


        /// <summary>
        /// 获取一条规则。
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult GetAuthRuleItem(GeneralAuthRule model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.RULE_ID);
                if (viewResult.Success && viewResult.Data is T_USER_POPEDOM_V2 entity)
                {
                    model = ToGeneralAuthRule(entity, model);
                    result.SetSuccess(entity);
                }
                else
                {
                    result.SetFail(viewResult.Msg);
                }
            }
            catch (Exception e)
            {
                result.SetFail(e.Message, e);
            }
            return result;
        }

        /// <summary>
        /// 获取规则列表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<GeneralAuthRule> GetAuthRuleList(GeneralAuthRule model)
        {
            var entity = model.ConvertTo<T_USER_POPEDOM_V2>();
            var ls=FindList(entity).Select(c=>ToGeneralAuthRule(c)).ToList();
            return ls;
        }
        /// <summary>
        /// 设置规则排序
        /// </summary>
        /// <param name="model"></param>
        public bool SetAuthRuleSort(GeneralAuthRule model)
        {
           var r= Update(T_USER_POPEDOM_V2._.SORT, model.SORT, T_USER_POPEDOM_V2._.RULE_ID == model.RULE_ID);
           return r > 0;
        }



        public GeneralResult Initial()
        {
            var r = new GeneralResult();
            var count = Count(WhereClip.All);
            if (count == 0)
            {
                var userPopedom = Jd.TUserPopedomService.FindAll();

                var roleids = userPopedom.Select(c => c.ROLE_ID).ToList();
                var roles = Jd.TUserRoleService.FindList(T_USER_ROLE._.ID.In(roleids)).ToList();
                var entities = roles
                    .Select(c =>
                    {
                        var roleMenus = userPopedom.FindAll(o => o.ROLE_ID == c.ID);
                        var m = new T_USER_POPEDOM_V2
                        {
                            RULE_ID = Guid.NewGuid().ToString(),
                            NAME = c.NAME,
                            MENU_AUTH = string.Join(",", roleMenus.Select(o => o.MENU_ID)),
                            GROUP_ID = c.ID?.ToString(),
                            CREATEDBY = "Initial",
                            CREATEDTIME = DateTime.Now,
                            UPDATEDBY = "Initial",
                            UPDATEDTIME = DateTime.Now,
                            REMARK = c.REMARK,
                            POWER = string.Join(",", roleMenus.Select(o => o.POWER).Distinct()),
                            MODULE = "GGZYJD_ADMIN",
                            SORT = 1,
                            LOG_AUTH = String.Empty,
                        };
                        return m;
                    }).ToList();
                Insert(entities);
                r.SetSuccess($"原有数据{count}，初始化成功:{entities.Count}条");
            }
            else
            {
                r.SetFail($"请勿重复初始化数据");
            }

            return r;
        }

        protected GeneralAuthRule ToGeneralAuthRule(T_USER_POPEDOM_V2 entity,GeneralAuthRule model = null)
        {
            if (model == null)
            {
                model = entity.ConvertTo<GeneralAuthRule>();
            }
            model.LOG_AUTH = entity.LOG_AUTH?.Split(',').ToList();
            model.MENU_AUTH = entity.MENU_AUTH?.Split(',').ToList();
            return model;
        }
    }
}