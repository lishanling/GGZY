using System;
using System.Collections.Generic;
using System.Linq;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Services.Infrastructure.Model;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class UnifyAuthsService
    {
        /// <summary>
        /// 添加平台授权认证信息
        /// </summary>
        /// <param name="appKey">应用KEY</param>
        /// <param name="appUid">服务平台用户ID</param>
        /// <param name="userGuid">统一用户ID</param>
        public GeneralResult SetOAuth(string appKey, string appUid, string userGuid)
        {
            var r = new GeneralResult();
            var app = Fw.UnifyAppService.FindAppByAppIdOrAppKey(appKey);
            if (app == null)
            {
                r.SetFail($"应用唯一标识无效");
            }
            else
            {
                var entity = FirstOrNull(UNIFY_AUTHS._.APPGUID == app.MGUID && UNIFY_AUTHS._.APPUID == appUid);
                if (entity == null)
                {
                    var auth = new UNIFY_AUTHS
                    {
                        MGUID = Guid.NewGuid().ToString(),
                        USERGUID = userGuid,
                        APPGUID = app.MGUID,
                        APPUID = appUid,
                        CREATEDBY = appUid,
                        CREATEDTIME = DateTime.Now,
                        UPDATEDBY = userGuid,
                        UPDATEDTIME = DateTime.Now,
                    };
                    Insert(auth);
                    r.SetSuccess();
                }
                else if (entity.USERGUID != userGuid)
                {
                    r.SetFail($"当前应用已授权绑定其他账号,不允许再次授权", new Exception($"{app.APPNAME}已授权给{entity.MGUID},当前授权用户为{appUid}"));
                }
                else
                {
                    r.SetSuccess();
                }
            }
            return r;
        }
        //todo
        public GeneralResult RemoveOAuth(string appKey, string appUid, string userGuid)
        {
            var r = new GeneralResult();
            Delete(UNIFY_AUTHS._.APPGUID == appKey && UNIFY_AUTHS._.USERGUID == userGuid && UNIFY_AUTHS._.APPUID == appUid);

            var authApp = AuthApp(userGuid);
            //authApp.FirstOrDefault()?.AppKey
            if (!authApp.Any())
            {
                var rsp = Fw.UnifyUserService.ViewByPk(userGuid);
                if (rsp.Success)
                {
                    var u = rsp.Data;
                    var delRsp = Fw.UnifyUserService.Delete(userGuid);
                    if (delRsp.Success)
                    {
                        Logger.Warn($"用户{u.Serializer()}解除绑定所有App，删除统一注册用户信息");
                    }
                }
            }
            //var fwApp = authApp.FirstOrDefault(c => c.Id == appKey && c.AppKey == ConfigHelper.APP_KEY_GGZYFW);
            //if (fwApp == null)
            //{

            //}
            //else
            //{

            //}

            return r;
        }
        /// <summary>
        /// 应用授权
        /// </summary>
        /// <param name="appid">应用id</param>
        /// <param name="state">状态编码</param>
        /// <param name="code">授权编码</param>
        /// <param name="redirectUrl">回调地址</param>
        /// <returns></returns>
        public GeneralResult SetPrimaryOAuth(string appid, string state, string code, string redirectUrl)
        {
            var r = new GeneralResult();
            if (Cache.IsSet(state) && !string.IsNullOrWhiteSpace(code))
            {
                var findRsp = Fw.UnifyAppService.FindAppByAppKey(appid);
                if (findRsp.Success)
                {
                    WebUtils webUtils = new WebUtils();
                    var appSecret = CommonUtils.Md5Str(state);

                    #region code 获取 access_token

                    var rsp = webUtils.DoPost($"{findRsp.TData.HOSTURL}/Account/GetAccessToken", new Dictionary<string, string>
                    {
                        {"grant_type","authorization_code" },
                        {"code",code },
                        {"client_id",appid },
                        {"redirect_uri",redirectUrl },
                        {"client_secret",appSecret },
                    });
                    r = rsp.DeserializeObject<GeneralResult>();

                    #endregion
                    if (r.Success)
                    {

                        #region access_token 获取授权用户信息

                        rsp = webUtils.DoPost($"{findRsp.TData.HOSTURL}/Account/AuthorizeInfo", new Dictionary<string, string>
                        {
                            {"access_token",r.Data.ToString() }
                        });
                        r = rsp.DeserializeObject<GeneralResult>();

                        #endregion
                        if (r.Success)
                        {
                            #region 第三方应用授权信息绑定到统一用户

                            var ticket = Cache.Get<string>(state);
                            var checkTokenRsp = TokenManager.CheckToken(ticket);
                            if (checkTokenRsp.Success)
                            {
                                r = SetOAuth(appid, r.Data.ToString(), checkTokenRsp.TData.Id);
                            }
                            else
                            {
                                r.SetFail(checkTokenRsp.Msg);
                            }

                            #endregion
                        }
                    }
                }
            }
            else
            {
                r.SetFail("参数错误");
            }
            return r;
        }

        /// <summary>
        /// 已授权应用列表
        /// </summary>
        /// <returns></returns>
        public List<UnifyUserAppAuth> AuthApp(string userGuid = "")
        {
            if (string.IsNullOrWhiteSpace(userGuid))
            {
                userGuid = Identity.Id;
            }
            var list = FromWhere(UNIFY_AUTHS._.USERGUID == userGuid)
                .OrderBy(UNIFY_APP._.SORT)
                .InnerJoin<UNIFY_APP>(UNIFY_APP._.MGUID == UNIFY_AUTHS._.APPGUID)
                .Select(
                    UNIFY_APP._.MGUID.As("Id"),
                    UNIFY_APP._.APPNAME.As("Name"),
                    UNIFY_APP._.APPICON.As("Icon"),
                    UNIFY_APP._.SORT.As("Sort"),
                    UNIFY_AUTHS._.APPUID.As("AppUid"),
                    UNIFY_AUTHS._.USERGUID.As("UserGuid"),
                    UNIFY_APP._.APPKEY.As("AppKey"),
            UNIFY_APP._.APPTYPE.As("AppType")
                    ).ToList<UnifyUserAppAuth>();
            return list;
        }





    }
}