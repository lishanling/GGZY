using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Authentication;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class VUnifyUserService
    {
        public GeneralResult<V_UNIFY_USER> SignIn(LoginModel model)
        {
            var r = new GeneralResult<V_UNIFY_USER>();
            var entities = FindList(V_UNIFY_USER._.USERNAME == model.Name &&
                                    (V_UNIFY_USER._.PASSWORD == model.Pwd ||
                                     V_UNIFY_USER._.PASSWORD == model.Pwd.ToLower()), V_UNIFY_USER._.APPKEY.Asc);
            if (entities.Any())
            {
                //只允许strong账号登录 //TODO 这个业务应该在对应的登录接口使用
                //if (entities.First().USERNAME != "strong")
                //{
                //    r.SetFail("用户名或者密码错误");
                //    return r;
                //}
                var entity = entities.FirstOrDefault(c => c.APPKEY == ConfigHelper.APP_KEY_GGZYFW) ?? entities.FirstOrDefault(c => c.APPKEY == ConfigHelper.APP_KEY_GGZYJD);
                if (entity.APPKEY == ConfigHelper.APP_KEY_GGZYJD)
                {
                    r.SetSuccessT(entity);
                }
                else if (entity.IS_ENABLE != 1)
                {
                    r.SetFail("该用户被禁用，请联系平台管理员！");
                }
                else
                {
                    var user = Fw.TUserService.FirstOrNull(T_USER._.ID == entity.ID);
                    if (user.ROLEIDS == ConfigHelper.AppSettings.AGNET_ROLEID && user.IS_AUDIT != 1)
                    {
                        r.SetFail("该用户还未审核通过，请联系平台管理员！");
                    }
                    else
                    {
                        user.Attach();
                        if (string.IsNullOrWhiteSpace(user.SESSION_ID))
                        {
                            user.SESSION_ID = Guid.NewGuid().ToString();
                        }
                        user.AAAA = model.TruePwd;
                        user.CA_INFO = string.Empty;
                        Fw.TUserService.Update(entity);
                        r.SetSuccessT(entity);
                    }
                }
            }
            else
            {
                r.SetFail("用户名或者密码错误");
            }

            return r;
        }

        public PageTableResult PageTable(V_UNIFY_USER model, SearchCondition search)
        {
            var appKey = model.APPKEY;

            if (model.APPKEY != ConfigHelper.APP_KEY_GGZYFW && model.APPKEY != ConfigHelper.APP_KEY_GGZYJD)
            {
                model.APPKEY = String.Empty;
            }
            var condition = ConditionBuilder(model);
            var query = FromWhere(condition.ToWhereClip());
            if (appKey != ConfigHelper.APP_KEY_GGZYFW && appKey != ConfigHelper.APP_KEY_GGZYJD&&!string.IsNullOrWhiteSpace(appKey))
            {
                query.InnerJoin<UNIFY_AUTHS>(UNIFY_AUTHS._.APPUID == V_UNIFY_USER._.ID &&
                                             V_UNIFY_USER._.APPKEY == ConfigHelper.APP_KEY_GGZYFW)
                    .InnerJoin<UNIFY_APP>(UNIFY_APP._.MGUID == UNIFY_AUTHS._.APPGUID
                                          && UNIFY_APP._.APPKEY == appKey);
            }
            var count =query.Count();
            //var pageList = PageList(condition, search, V_UNIFY_USER._.APPKEY.Asc && V_UNIFY_USER._.ID.Desc)
            //    .ToDataTableResult(search, count);
            var selectField = model.GetFields().Where(c => c.FieldName != "PASSWORD").ToArray();
            var pageList = query.OrderBy(V_UNIFY_USER._.APPKEY.Asc && V_UNIFY_USER._.ID.Desc)
                .Page(search.PageSize, search.PageNo).Select(selectField)
                .ToList().ToPageTableResult(search, count);
            return pageList;
        }
    }
}