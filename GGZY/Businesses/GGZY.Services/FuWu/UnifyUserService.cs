using System;
using System.Collections.Generic;
using System.Linq;
using GGZY.Core.Authentication;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model;
using GGZYFW.DbEntity;
using Dos.ORM;

namespace GGZY.Services.FuWu
{
    public partial class UnifyUserService
    {
        #region 登录|注册
        /// <summary>
        /// 登录 
        /// </summary>
        /// <param name="model">用户名 model.NAME 密码 model.PWD </param>
        /// <returns>登录身份令牌凭证</returns>
        public GeneralResult SignIn(LoginModel model)
        {
            var r = new GeneralResult();
            //Logger.Debug(model.Serializer());
            var user = FirstOrNull(UNIFY_USER._.NAME == model.Name && (UNIFY_USER._.PWD == model.Pwd || UNIFY_USER._.PWD == model.Pwd.ToLower()));
            if (user == null)
            {
                var signResult = Fw.VUnifyUserService.SignIn(model);
                if (signResult.Success)
                {
                    var unifyUser = signResult.TData;
                    user = this.AddUser(unifyUser.USERNAME, unifyUser.PASSWORD, unifyUser.ID.ToString(), unifyUser.APPKEY);//, ConfigHelper.APP_KEY_PINGBIAO

                }
                else
                {
                    r.SetFail(signResult.Msg);
                }
                //r = FwSignIn(model);
                //if (!r.Success)
                //{
                //    r = JdSignIn(model);
                //}
            }
            if (user != null)
            {
                var identity = CreateToken(user);

                var token = identity.Ticket;
                var ticket = Guid.NewGuid().ToString("N");
                Cache.Set(ticket, token, 2);
                if (!string.IsNullOrWhiteSpace(model.redirect_url))
                {
                    r.SetSuccess(new
                    {
                        Url = $"{model.redirect_url}?ticket={ticket}",
                        Token = token,
                    });
                }
                else if (!string.IsNullOrWhiteSpace(model.client_id))
                {
                    var app = Fw.UnifyAppService
                        .FromWhere(UNIFY_APP._.APPKEY == model.client_id || UNIFY_APP._.MGUID == model.client_id)
                        .InnerJoin<UNIFY_AUTHS>(UNIFY_AUTHS._.APPGUID == UNIFY_APP._.MGUID &&
                                                UNIFY_AUTHS._.USERGUID == user.MGUID)
                        .Select(UNIFY_APP._.All).ToFirst();
                    if (app != null)
                    {
                        r.SetSuccess(new { Url = $"{app.SSOURL}?ticket={ticket}", Token = token });
                    }
                    else
                    {
                        r.SetSuccess(new { Token = token });
                    }
                }
                else
                {
                    r.SetSuccess(new { Token =token });
                }

                //r.SetSuccessT(identity);
            }
            return r;
        }

        public GeneralResult CaSignIn(CertificateAuthorityModel ca)
        {
            var r = Fw.TUserService.CaSignIn(ca);
            if (r.Success)
            {
                //var user = r.Data as GGZYJD.DbEntity.T_USER;
                var pwd = CommonUtils.Md5Str(string.IsNullOrWhiteSpace(ca.Data.SGD_EXT_ORGANIZATIONCODE) ? ca.Data.SGD_GET_CERT_SUBJECT_CN : ca.Data.SGD_EXT_ORGANIZATIONCODE);
                var unifyUser = FirstOrNull(UNIFY_USER._.NAME == ca.Data.SGD_GET_CERT_SUBJECT_CN && (UNIFY_USER._.PWD == pwd||UNIFY_USER._.PWD== ca.Data.SGD_EXT_ORGANIZATIONCODE));
                if (unifyUser == null)
                {
                    var appUid = r.TData.ID?.ToString();
                    unifyUser = this.AddUser(ca.Data.SGD_GET_CERT_SUBJECT_CN, pwd, appUid, ConfigHelper.APP_KEY_GGZYFW);
                   
                }
                var identity = CreateToken(unifyUser);
                var token = identity.Ticket;
                var ticket = Guid.NewGuid().ToString("N");
                Cache.Set(ticket, token, 2);
                if (!string.IsNullOrWhiteSpace(ca.redirect_url))
                {
                    r.SetSuccess(new
                    {
                        Url = $"{ca.redirect_url}?ticket={ticket}",
                        Token = token,
                    });
                }
                else if (!string.IsNullOrWhiteSpace(ca.client_id))
                {
                    var app = Fw.UnifyAppService
                        .FromWhere(UNIFY_APP._.APPKEY == ca.client_id || UNIFY_APP._.MGUID == ca.client_id)
                        .InnerJoin<UNIFY_AUTHS>(UNIFY_AUTHS._.APPGUID == UNIFY_APP._.MGUID &&
                                                UNIFY_AUTHS._.USERGUID == unifyUser.MGUID)
                        .Select(UNIFY_APP._.All).ToFirst();
                    if (app != null)
                    {
                        r.SetSuccess(new { Url = $"{app.SSOURL}?ticket={ticket}", Token = token });
                    }
                    else
                    {
                        r.SetSuccess(new { Token = token });
                    }
                }
                else
                {
                    r.SetSuccess(new { Token = token });
                }
                r.SetSuccess(new { Token = identity.Ticket });
            }
            return r;
        }
        /// <summary>
        /// 第一次使用从未绑定过任何应用
        /// </summary>
        /// <param name="appKey"></param>
        /// <param name="appUid"></param>
        /// <param name="userGuid"></param>
        /// <returns></returns>
        public string CreateUser(string appKey, string appUid, string userGuid)
        {

            if (string.IsNullOrWhiteSpace(userGuid))
            {
                switch (appKey)
                {
                    case ConfigHelper.APP_KEY_GGZYJD:
                        var findJdUserResult = Jd.TUserService.ViewByPk(Convert.ToDecimal(appUid));
                        if (findJdUserResult.Success)
                        {
                            var jdUser = findJdUserResult.Data as GGZYJD.DbEntity.T_USER;
                            userGuid = AddUser(jdUser?.USERNAME, jdUser?.PASSWORD, appUid, ConfigHelper.APP_KEY_GGZYJD, appKey)?.MGUID;
                        }
                        break;
                    //case ConfigHelper.APP_KEY_BAOHAN:
                    //case ConfigHelper.APP_KEY_GGZYFW:
                    default:
                        var findFwUserResult = Fw.TUserService.ViewByPk(Convert.ToDecimal(appUid));
                        if (findFwUserResult.Success)
                        {
                            var fwUser = findFwUserResult.Data as T_USER;
                            userGuid = Fw.UnifyUserService.AddUser(fwUser?.USERNAME, fwUser?.PASSWORD, appUid, ConfigHelper.APP_KEY_GGZYFW, appKey)?.MGUID;
                        }
                        break;
                }
            }
            return userGuid;
        }
        /// <summary>
        /// 生成票据
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        protected CustomAuthenticationIdentity CreateToken(UNIFY_USER user)
        {
            var identity = new CustomAuthenticationIdentity
            {
                Ticket = Guid.NewGuid().ToString("N"),
                TimeStamp = DateTime.Now.ToString("yyyyMMddHHmmss"),
                Id = user.MGUID,
                Name = user.NAME,
                LoginName = user.NAME
            };
            TokenManager.CreateToken(identity);
            return identity;
        }
        ///// <summary>
        ///// 监督平台登录
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //public GeneralResult JdSignIn(LoginModel model)
        //{
        //    var r = Jd.TUserService.SignIn(model);
        //    if (r.Success)
        //    {
        //        var jdUser = r.TData;
        //        var user = this.AddUser(jdUser.USERNAME, jdUser.PASSWORD, jdUser.ID.ToString(), ConfigHelper.APP_KEY_GGZYJD);//, ConfigHelper.APP_KEY_PINGBIAO
        //        var identity = CreateToken(user);
        //        r.SetSuccess(new { Token = identity.Ticket });
        //    }
        //    return r;
        //}
        ///// <summary>
        ///// 服务平台个人用户登录
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //public GeneralResult FwSignIn(LoginModel model)
        //{
        //    var r = Fw.TUserService.SignIn(model);
        //    if (r.Success)
        //    {
        //        var fwUser = r.TData;
        //        var user = this.AddUser(fwUser.USERNAME, fwUser.PASSWORD, fwUser.ID.ToString(), ConfigHelper.APP_KEY_GGZYFW, ConfigHelper.APP_KEY_BAOHAN);
        //        var identity = CreateToken(user);
        //        r.SetSuccess(new { Token = identity.Ticket });
        //    }
        //    return r;
        //}

        /// <summary>
        /// 用户认证
        /// </summary>
        /// <param name="token">登录身份令牌凭证</param>
        /// <param name="appid">应用id</param>
        /// <returns>返回应用ID所对应的用户唯一标识（UID）</returns>
        public GeneralResult Auth(string token, string appid)
        {

            var r = new GeneralResult();
            var checkResult = TokenManager.CheckToken(token);
            if (checkResult.Success)
            {
                var appUid = FromWhere(UNIFY_USER._.MGUID == checkResult.TData.Id)
                    .InnerJoin<UNIFY_AUTHS>(UNIFY_AUTHS._.USERGUID == UNIFY_USER._.MGUID)
                    .InnerJoin<UNIFY_APP>(UNIFY_APP._.MGUID == UNIFY_AUTHS._.APPGUID && UNIFY_APP._.APPKEY == appid)
                    .Select(UNIFY_AUTHS._.APPUID).ToFirst<string>();
                if (string.IsNullOrWhiteSpace(appUid))
                {
                    r.SetFail("当前账号不存在");
                }
                else
                {
                    r.SetSuccess(appUid);
                }
            }
            else
            {
                r.SetFail(checkResult.Msg);
            }
            return r;
        }

        /// <summary>
        /// 添加统一用户
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="pwd"></param>
        /// <param name="appUid"></param>
        /// <param name="appType"></param>
        /// <param name="appKey"></param>
        /// <returns></returns>
        public UNIFY_USER AddUser(string userName, string pwd, string appUid, string appType, string appKey = "")
        {
            UNIFY_USER existUser = null;
            var apps = Fw.UnifyAppService.FindAppByAppType(appType);
            var appIds = apps.Select(c => c.MGUID).Distinct().ToList();
            var auths = Fw.UnifyAuthsService.FindList(UNIFY_AUTHS._.APPUID == appUid);
            var auth = auths.FirstOrDefault(c => appIds.Exists(appGuid => appGuid == c.APPGUID));
            var createBy = $"{appType}:{appUid}";
            if (auth != null)
            {
                existUser = FirstOrNull(c => c.MGUID == auth.USERGUID);
            }
            else
            {
                //auth = auths.FirstOrDefault(c => c.APPGUID.NotIn(appIds));
                auth = auths.FirstOrDefault(c => appIds.Any(o => o != c.APPGUID));
                if (auth != null)
                {
                    existUser = FirstOrNull(c => c.MGUID == auth.USERGUID && c.CREATEDBY == (createBy));
                }

            }
            if (existUser == null)
            {
                UNIFY_USER user = new UNIFY_USER
                {
                    MGUID = Guid.NewGuid().ToString(),
                    NAME = userName,
                    PWD = pwd,
                    TYPE = 0,
                    STATE = 0,
                    CREATEDBY = createBy,
                    CREATEDTIME = DateTime.Now,
                    UPDATEDBY = appUid,
                    UPDATEDTIME = DateTime.Now,
                };
                Insert(user);
                if (!string.IsNullOrWhiteSpace(appKey))
                {
                    apps = apps.FindAll(c => c.APPKEY == appKey);
                }
                foreach (var app in apps)
                {
                    if (app.IS_AUTO_AUTH == 1)
                    {
                        Fw.UnifyAuthsService.SetOAuth(app.MGUID, appUid, user.MGUID);
                    }
                   
                }
                return user;
            }

            return existUser;
        }


        public GeneralResult Register(RegisterModel model)
        {
            var r = new GeneralResult();
            switch (model.RegisterType)
            {
                case RegisterModel.FW_PERSON:
                    r = Fw.TUserService.RegisterPersonalUser(model);
                    break;
                case RegisterModel.FW_COMPANY:
                    var r1 = Fw.TUserService.RegisterCompanyUserByTrans(model);
                    if (r1.Success && r1.State == "1")//state=1 恭喜您！注册成功。您可以选择下方登入公共服务平台，或关闭浏览公共服务平台其他内容。
                    {//state=2 注册信息已经成功提交！请等待管理员审核。我们会在2个工作日内完成验证，并以短信的方式回复验证结果到注册手机上，请注意查收！
                        var identity = CreateToken(new UNIFY_USER { MGUID = r1.TData.ID?.ToString(), NAME = r1.TData.MANAGE_NAME });
                        r.SetSuccess(new { Token = identity.Ticket });
                    }
                    else
                    {
                        r = r1;
                    }
                    break;
                case RegisterModel.FW_AGENCY:
                    r = Fw.TUserService.RegisterAgencyUser(model);
                    break;
                case RegisterModel.JD_MEMBER:
                    r = Jd.TUserService.RegisterUserMember(model);
                    break;
                default:
                    r.SetFail("参数错误");
                    break;
            }
            return r;
        }


        #endregion


        #region 监督平台处长门户登录
        /// <summary>
        /// 监督平台处长门户登录 
        /// </summary>
        /// <param name="model">用户名 model.NAME 密码 model.PWD </param>
        /// <returns>登录身份令牌凭证</returns>
        public GeneralResult CzSignIn(LoginModel model)
        {
            var r = new GeneralResult();
            //Logger.Debug(model.Serializer());
            var user = FirstOrNull(UNIFY_USER._.NAME == model.Name && (UNIFY_USER._.PWD == model.Pwd || UNIFY_USER._.PWD == model.Pwd.ToLower()));
            if (user == null)//当前账号统一用户未绑定
            {
                var signResult = Fw.VUnifyUserService.SignIn(model);
                if (signResult.Success)
                {
                    var unifyUser = signResult.TData;
                    user = this.AddUser(unifyUser.USERNAME, unifyUser.PASSWORD, unifyUser.ID.ToString(), unifyUser.APPKEY);
                }
                else
                {
                    r.SetFail(signResult.Msg);
                }
            }
            if (user != null)//当前账号统一用户已绑定
            {
                var app = Fw.UnifyAppService
                    .FromWhere(UNIFY_APP._.APPKEY == ConfigHelper.APP_KEY_GGZYJD)
                    .InnerJoin<UNIFY_AUTHS>(UNIFY_AUTHS._.APPGUID == UNIFY_APP._.MGUID &&
                                            UNIFY_AUTHS._.USERGUID == user.MGUID)
                    .Select(UNIFY_APP._.All).ToFirst();
                if (app == null)
                {
                    r.SetFail("当前账号没有访问权限");
                }
                else
                {
                    var identity = CreateToken(user);
                    var token = identity.Ticket;
                    var ticket = Guid.NewGuid().ToString("N");
                    Cache.Set(ticket, token, 2);
                    r.SetSuccess(new { Url = $"{app.SSOURL}?ticket={ticket}", Token = token });
                }

                //r.SetSuccessT(identity);
            }
            return r;
        }

        /// <summary>
        /// 监督平台处长门户CA登录
        /// </summary>
        /// <param name="ca"></param>
        /// <returns></returns>
        public GeneralResult CzCaSignIn(CertificateAuthorityModel ca)
        {
            var r = Fw.TUserService.CaSignIn(ca);
            if (r.Success)
            {
                //var user = r.Data as GGZYJD.DbEntity.T_USER;
              
                var pwd = CommonUtils.Md5Str(string.IsNullOrWhiteSpace(ca.Data.SGD_EXT_ORGANIZATIONCODE) ? ca.Data.SGD_GET_CERT_SUBJECT_CN : ca.Data.SGD_EXT_ORGANIZATIONCODE);
                var unifyUser = FirstOrNull(UNIFY_USER._.NAME == ca.Data.SGD_GET_CERT_SUBJECT_CN && (UNIFY_USER._.PWD == pwd || UNIFY_USER._.PWD == ca.Data.SGD_EXT_ORGANIZATIONCODE));
                if (unifyUser == null)
                {
                    var appUid = ca.Data.USER_ID.ToString();
                    unifyUser = this.AddUser(ca.Data.SGD_GET_CERT_SUBJECT_CN, ca.Data.SGD_EXT_ORGANIZATIONCODE, appUid, ConfigHelper.APP_KEY_GGZYFW);
                    Fw.UnifyAuthsService.SetOAuth(ConfigHelper.APP_KEY_GGZYFW, appUid, unifyUser.MGUID);
                }
                var app = Fw.UnifyAppService
                    .FromWhere(UNIFY_APP._.APPKEY == ConfigHelper.APP_KEY_GGZYJD)
                    .InnerJoin<UNIFY_AUTHS>(UNIFY_AUTHS._.APPGUID == UNIFY_APP._.MGUID &&
                                            UNIFY_AUTHS._.USERGUID == unifyUser.MGUID)
                    .Select(UNIFY_APP._.All).ToFirst();
                if (app == null)
                {
                    r.SetFail("当前CA没有范围权限");
                }
                else
                {
                    var identity = CreateToken(unifyUser);
                    var token = identity.Ticket;
                    var ticket = Guid.NewGuid().ToString("N");
                    Cache.Set(ticket, token, 2);
                    r.SetSuccess(new { Token = token });
                }
            }
            return r;
        }
        #endregion

        #region 统一用户后台用户管理




        #endregion

        #region 当前登录用户修改密码

        public GeneralResult ChangePwd(ProfileModel model)
        {
            var r = new GeneralResult();
            if ((JdUser != null && JdUser.PASSWORD == model.OldPwd) ||
                (FwUser != null && FwUser.PASSWORD == model.OldPwd))
            {
                //todo
            }
            else
            {
                r.SetFail("密码错误，请输入正确的密码！");
            }
            return r;
        }

        #endregion


        #region 统一用户角色菜单

        public List<GeneralMenu> UserMenus(int jdUid = 0)
        {
            var r = new List<GeneralMenu>();
            var jdUser = JdUser;
            var fwUser = FwUser;
            if (jdUser != null || fwUser != null)
            {
                r = Cache.Get($"MENUS:{Identity.Id}", () =>
                {
                    var allMenus = Jd.TUserMenuV2Service.EnableMenu().FindAll(c => c.MODULE == "user");
                    var roleMenus = allMenus;//999 账号管理 消息管理 基本资料
                    if (jdUser != null)
                    {
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
                    }
                    if (fwUser != null)
                    {
                        //TODO
                    }
                    var userMenus = roleMenus.Select(c =>
                    {
                        var m = c.ConvertTo<GeneralMenu>();
                        m.CHILDREN_TOTAL = roleMenus.Count(o => o.PARENT_ID == c.MENU_ID); //该菜单下子级菜单数的合计
                        return m;
                    }).ToList();
                    return userMenus;
                });
            }
            return r;
        }

        #endregion

    }
}