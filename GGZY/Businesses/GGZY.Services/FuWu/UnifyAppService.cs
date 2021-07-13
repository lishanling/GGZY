using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Infrastructure.Model;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class UnifyAppService
    {
        public List<LabelValueModel> AppDic()
        {
            return FindAll().Select(c => new LabelValueModel { Id=c.MGUID,Label = c.APPNAME, Value = c.APPKEY }).ToList();
        }

        /// <summary>
        /// 添加应用
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult CreateApplication(UNIFY_APP model)
        {
            var r = new GeneralResult();
            if (model.Validate())
            {
                var entity = FirstOrNull(c => c.APPKEY == model.APPKEY);
                if (entity == null)
                {
                    model.MGUID = Guid.NewGuid().ToString();
                    //app.APPKEY = ConfigHelper.APP_KEY_GGZYFW;
                    //app.APPNAME = "公共资源服务";
                    //app.APPICON = String.Empty;
                    //app.SORT = 20;
                    //app.APPTYPE = String.Empty;
                    //app.TARGET = string.Empty;
                    model.CREATEDBY = "SYSTEM";
                    model.CREATEDTIME = DateTime.Now;
                    model.UPDATEDBY = "SYSTEM";
                    model.UPDATEDTIME = DateTime.Now;
                    Insert(model);
                    r.SetSuccess();
                }
                else
                {
                    r.SetFail($"应用Key[{model.APPKEY}]已存在");
                }
            }
            else
            {
                r.SetFail($"参数错误");
            }

            return r;
        }

        /// <summary>
        /// 更新应用
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult UpdateApplication(UNIFY_APP model)
        {
            var r = new GeneralResult();
            if (model.Validate())
            {
                var entity = FirstOrNull(c => c.MGUID == model.MGUID);
                if (entity == null)
                {
                    r.SetFail($"未找到对应的应用", new Exception($"MGUID={model.MGUID}"));
                }
                else
                {
                    var uniqueAppKeyEntity = FirstOrNull(c => c.MGUID != model.MGUID && c.APPKEY == model.APPKEY);
                    if (uniqueAppKeyEntity == null)
                    {
                        entity.Attach();
                        entity.APPKEY = model.APPKEY;
                        entity.APPNAME = model.APPNAME;
                        entity.APPICON = model.APPICON;
                        entity.SORT = model.SORT;
                        entity.APPTYPE = model.APPTYPE;
                        entity.HOSTURL = model.HOSTURL;
                        entity.SSOURL = model.SSOURL;
                        entity.OAUTHURL = model.OAUTHURL;
                        entity.APPTYPE = model.APPTYPE;
                        entity.IS_AUTO_AUTH = model.IS_AUTO_AUTH;
                        //model.CREATEDBY = "SYSTEM";
                        //model.CREATEDTIME = DateTime.Now;
                        entity.UPDATEDBY = "SYSTEM";
                        entity.UPDATEDTIME = DateTime.Now;
                        Update(model);
                        r.SetSuccess();
                    }
                    else
                    {
                        r.SetFail($"应用Key[{model.APPKEY}]已存在");
                    }
                }
            }
            else
            {
                r.SetFail($"参数错误");
            }
            return r;
        }

        /// <summary>
        /// 验证App有效性
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult CheckApplication(ExternalLoginModel model)
        {
            var r = new GeneralResult();
            //var app = FirstOrNull(c => c.APPKEY == model.AppId && c.TARGET == model.RedirectUrl);
            var app = FirstOrNull(c => c.APPKEY == model.AppId);
            if (app == null)
            {
                r.SetFail($"参数错误");
            }
            else
            {
                r.SetSuccess(app);
            }
            return r;
        }
        /// <summary>
        /// 验证自有App有效性
        /// </summary>
        /// <param name="appid">应用ID=>appkey</param>
        /// <param name="redirectUrl">回调地址=>redirectUrl</param>
        /// <returns></returns>
        public GeneralResult CheckPrimaryApp(string appid, string redirectUrl)
        {
            return FindAppByAppKey(appid);//todo validate redirectUrl
        }
        /// <summary>
        /// 按照appkey查找app
        /// </summary>
        /// <param name="appkey"></param>
        /// <returns></returns>
        public GeneralResult<UNIFY_APP> FindAppByAppKey(string appkey)
        {
            var r = new GeneralResult<UNIFY_APP>();
            var app = FirstOrNull(c => c.APPKEY == appkey);
            if (app == null)
            {
                r.SetFail($"参数错误");
            }
            else
            {
                r.SetSuccess(app);
            }
            return r;
        }

        /// <summary>
        /// 未授权应用列表
        /// </summary>
        /// <returns></returns>
        public List<UnifyUserAppAuth> UnAuthApp(string userGuid = "")
        {
            if (string.IsNullOrWhiteSpace(userGuid))
            {
                userGuid = Identity.Id;
            }
            var list = FromWhere(
                    UNIFY_APP._.MGUID.SubQueryNotIn(
                  Fw.UnifyAuthsService
                      .FromWhere(UNIFY_AUTHS._.USERGUID == userGuid)
                      .Select(UNIFY_AUTHS._.APPGUID))
                    )
                .Select(
                          UNIFY_APP._.MGUID.As("Id"),
                          UNIFY_APP._.APPNAME.As("Name"),
                          UNIFY_APP._.APPICON.As("Icon"),
                          UNIFY_APP._.SORT.As("Sort")
                      ).ToList<UnifyUserAppAuth>();
            return list;
        }
        /// <summary>
        /// 通过appid或者appkey查找app信息
        /// </summary>
        /// <param name="idKey"></param>
        /// <returns></returns>
        public List<UNIFY_APP> FindAppByAppIdOrAppKeys(params string[] idKey)
        {
            return FindList(UNIFY_APP._.APPKEY.In(idKey) || UNIFY_APP._.MGUID.In(idKey));
        }
        /// <summary>
        /// 通过APPTYPE查找app信息
        /// </summary>
        /// <param name="appType">应用来源类型（GGZYFW或者GGZYJD）</param>
        /// <returns></returns>
        public List<UNIFY_APP> FindAppByAppType(string appType)
        {
            return FindList(UNIFY_APP._.APPTYPE == appType);
        }


        /// <summary>
        /// 通过appid或者appkey查找app信息
        /// </summary>
        /// <param name="idKey"></param>
        /// <returns></returns>
        public UNIFY_APP FindAppByAppIdOrAppKey(params string[] idKey)
        {
            return FindAppByAppIdOrAppKeys(idKey).FirstOrDefault();
        }
        /// <summary>
        /// 获取平台用户(未)授权app信息
        /// </summary>
        /// <param name="appUid">平台用户id</param>
        /// <param name="appType">平台idKey</param>
        /// <returns></returns>
        public object FindAppByAppUid(string appUid, string appType)
        {
            var allApps = FindAll();
            var app = allApps.FindAll(c=>c.APPTYPE==appType);
            var appIds = app.Select(c => c.MGUID).Distinct().ToList();
            var auth = Fw.UnifyAuthsService.FirstOrNull(UNIFY_AUTHS._.APPUID == appUid && UNIFY_AUTHS._.APPGUID.In(appIds));


            if (auth != null)
            {
                var auths = Fw.UnifyAuthsService.AuthApp(auth.USERGUID);
                var unAuths = new List<UnifyUserAppAuth>();
                var unAuthApps = allApps.FindAll(u => auths.Select(c => c.Id).All(o => o != u.MGUID)).ToList();
                foreach (var unifyApp in unAuthApps)
                {
                    var unAuth = new UnifyUserAppAuth
                    {
                        Id=unifyApp.MGUID,
                        Name = unifyApp.APPNAME,
                        UserGuid = auth.USERGUID,
                        Icon=unifyApp.APPICON,
                        Sort = unifyApp.SORT,
                        AppKey = unifyApp.APPKEY,
                        AppType = unifyApp.APPTYPE,
                    };
                    if (auths.Exists(c => c.AppType == unifyApp.APPTYPE)|| unifyApp.APPTYPE==appType)//已授权
                    {
                        unAuth.AppUid = appUid;
                    }
                    unAuths.Add(unAuth);
                }
                return new
                {
                    USERGUID = auth.USERGUID,
                    UnAuth = unAuths,
                    Auth = auths
                };
            }
            
            return new
            {
                USERGUID = string.Empty,
                UnAuth = allApps.Select(c => new UnifyUserAppAuth
                {
                    Id = c.MGUID,
                    Name = c.APPNAME,
                    Icon = c.APPICON,
                    Sort = c.SORT,
                    UserGuid = String.Empty,
                    AppUid = c.APPTYPE==appType?appUid: String.Empty,
                    AppKey = c.APPKEY,
                    AppType=c.APPTYPE
                }
                ).ToList(),
                Auth = new List<UnifyUserAppAuth>()
            };
        }

    }
}