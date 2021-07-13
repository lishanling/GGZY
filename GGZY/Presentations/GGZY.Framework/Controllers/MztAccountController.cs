using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GGZY.Core.Authentication;
using GGZY.Core.Authentication.Jwt;
using GGZY.Core.Cache;
using GGZY.Core.Utils;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model;
using GGZYFW.DbEntity;
using GGZYJD.DbEntity;
using Newtonsoft.Json;

namespace GGZY.Framework.Controllers
{
    public class MztAccountController : Controller
    {
        /// <summary>
        /// 登录地址
        /// </summary>
        /// <returns></returns>
        public ActionResult Login(string redirect, string token)
        {
            //判断是否已登录，已登录不跳到闽政通
            if (!string.IsNullOrWhiteSpace(token))
            {
                var checkResult = new JwtTokenManager().CheckToken(token);
                if (checkResult.Success)
                {
                    var ticket = Guid.NewGuid().ToString("N");
                    GlobalCache.Instance.Set(ticket, token, 2);
                    return Redirect($"/jd/#/?ticket={ticket}");
                }
            }

            //判断闽政通那边是否已登录，如果已登录直接返回ticket到前端，未登录则跳转到闽政通进行登录
            //第一步先跳转到闽政通查看是否信任传递
            AppSettings app = new AppSettings();
            string t = Guid.NewGuid().ToString("N");
            GlobalCache.Instance.Set($"MZT_LOGIN_REDIRECT_{t}", redirect, 2);

            var url = $"{app.MZT_CHECK_URL}?checkbackurl={app.MZT_CHECK_BACK_URL}?t={t}&callerCode={app.MZT_CODE}";
            return Redirect(url);
        }
        /// <summary>
        /// 信任传递回调地址
        /// </summary>
        /// <param name="trustticket"></param>
        /// <param name="loginflag"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public ActionResult CheckBack(string trustticket, string loginflag, string t)
        {
            AppSettings app = new AppSettings();
            string redirect = GlobalCache.Instance.Get<string>($"MZT_LOGIN_REDIRECT_{t}");
            //判断闽政通返回的是否已登录
            if (!string.IsNullOrEmpty(trustticket) && !string.IsNullOrEmpty(loginflag) && "true".Equals(loginflag))
            {
                int isFirst, isZhuCe = 0;
                //换取用户信息并生成token跳转到前端
                string token = CheckToken(trustticket, out isFirst, out isZhuCe);
                if (!string.IsNullOrEmpty(token))
                {
                    if (string.IsNullOrEmpty(redirect) || redirect == "null")
                    {
                        return Redirect($"/jd/#/?ticket={token}&isFirst={isFirst}");
                    }

                    string redirect1 = HttpUtility.UrlEncode(redirect);
                    string redirect2 = HttpUtility.UrlDecode(redirect);
                    if (isFirst == 1)
                    {
                        redirect1 = isZhuCe == 1 && redirect1.Contains("jdportal") ? redirect1.Replace("jdportal", "jd") : redirect1;
                        return Redirect($"{app.MZT_FRONT_URL}?ticket={token}&isFirst={isFirst}&redirect={redirect1}");
                    }
                    else
                    {
                        string wh = redirect2.Contains("?") ? "&" : "?";
                        return Redirect($"{redirect2}{wh}ticket={token}&isFirst={isFirst}");
                    }
                }
            }

            //跳转到闽政通登录页面
            var url = $"{app.MZT_LOGIN_URL}?returnurl={app.MZT_LOGIN_BACK_URL}?t={t}&callerCode={app.MZT_CODE}";
            return Redirect(url);


        }
        /// <summary>
        /// 登录回调地址
        /// </summary>
        /// <param name="trustticket"></param>
        /// <param name="loginflag"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public ActionResult LoginBack(string trustticket, string t)
        {
            AppSettings app = new AppSettings();
            //判断闽政通返回的是否已登录
            if (!string.IsNullOrEmpty(trustticket))
            {
                //换取用户信息并生成token跳转到前端
                int isFirst = 0, isZhuCe = 0;
                string token = CheckToken(trustticket, out isFirst, out isZhuCe);
                if (!string.IsNullOrEmpty(token))
                {
                    string redirect = GlobalCache.Instance.Get<string>($"MZT_LOGIN_REDIRECT_{t}");

                    if (string.IsNullOrEmpty(redirect) || redirect == "null")
                    {
                        return Redirect($"/jd/admin/index.html?ticket={token}&isFirst={isFirst}");
                    }

                    string redirect1 = HttpUtility.UrlEncode(redirect);
                    string redirect2 = HttpUtility.UrlDecode(redirect);
                    if (isFirst == 1)
                    {
                        redirect1 = isZhuCe == 1 && redirect1.Contains("jdportal") ? redirect1.Replace("jdportal", "jd") : redirect1;
                        return Redirect($"{app.MZT_FRONT_URL}?ticket={token}&isFirst={isFirst}&redirect={redirect1}");
                    }
                    else
                    {
                        string wh = redirect2.Contains("?") ? "&" : "?";
                        return Redirect($"{redirect2}{wh}ticket={token}&isFirst={isFirst}");
                    }
                }

            }
            //跳转到闽政通登录页面
            return Content("登录失败，请重新登录");
        }
        /// <summary>
        /// 登出
        /// </summary>
        /// <returns></returns>
        public ActionResult Logout(string token, string redirect)
        {
            AppSettings app = new AppSettings();
            //删除登录缓存
            new JwtTokenManager().DeleteToken(token);
            string t = Guid.NewGuid().ToString("N");
            GlobalCache.Instance.Set($"MZT_LOGOUT_REDIRECT_{t}", redirect, 2);
            //跳转到实名认证登出页面
            var url = $"{app.MZT_LOGOUT_URL}?uitype=5&callerCode={app.MZT_CODE}&returnurl={app.MZT_LOGOUT_BACK_URL}?t={t}";
            return Redirect(url);
        }
        /// <summary>
        /// 登出回调地址
        /// </summary>
        /// <returns></returns>
        public ActionResult LogoutBack(string t)
        {
            string redirect = GlobalCache.Instance.Get<string>($"MZT_LOGOUT_REDIRECT_{t}");
            if (!string.IsNullOrEmpty(redirect) && redirect != "null")
            {
                redirect = HttpUtility.UrlDecode(redirect);
                return Redirect(redirect);
            }
            return Redirect("/jdportal");
        }
        /// <summary>
        /// 注册跳转
        /// </summary>
        /// <returns></returns>
        public ActionResult Register()
        {
            AppSettings app = new AppSettings();
            var url = $"{app.MZT_REGISTER_URL}?callerCode={app.MZT_CODE}&returnurl={app.MZT_REGISTER_BACK_URL}";
            return Redirect(url);
        }
        /// <summary>
        /// 注册回调地址
        /// </summary>
        /// <returns></returns>
        public ActionResult RegisterBack()
        {
            return Content("注册成功");
        }
        /// <summary>
        /// 跳转到用户中心
        /// </summary>
        /// <param name="ticket"></param>
        /// <returns></returns>
        public ActionResult GoCenter()
        {
            AppSettings app = new AppSettings();
            var url = $"{app.MZT_USERCENTER_URL}";
            return Redirect(url);
        }

        public ActionResult DeleteMztUser()
        {
            DbContext.Fw.DeleteAll<MZTUSER>();
            return Content("删除成功");
        }

        /// <summary>
        /// 获取并验证闽政通那边的用户信息
        /// </summary>
        /// <param name="trustticket"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        private string CheckToken(string trustticket, out int isFirst, out int isZhuCe)
        {
            isFirst = 0; isZhuCe = 0;
            string token = "";
            AppSettings app = new AppSettings();
            //发送请求获取用户信息
            var sendParam = new Dictionary<string, string>()
            {
                {"POSTPARAM_JSON",JsonConvert.SerializeObject(new
                {
                    INVOKESERVICE_CODE = "103",
                    INVOKECALLER_CODE = app.MZT_CODE,
                    TRUST_TICKET = trustticket

                })}
            };
            string result = new WebUtils().DoPost(app.MZT_GETUSER_URL, sendParam);
            Dictionary<string, object> resDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(result);
            if ("true".Equals(resDict["success"].ToString().ToLower()))
            {
                //判断数据是否已存在该用户信息
                Dictionary<string, object> dataDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(resDict["data"].ToString());
                string userid = dataDict.ContainsKey("USER_ID") ? dataDict["USER_ID"].ToString() : "";
                string userToken = dataDict.ContainsKey("USER_TOKEN") ? dataDict["USER_TOKEN"].ToString() : "";
                if (!string.IsNullOrEmpty(userid))
                {
                    MZTUSER dbUser = DbContext.Fw.From<MZTUSER>().Where(MZTUSER._.USER_ID == userid).ToFirst();

                    MZTUSER user;
                    GGZYJD.DbEntity.T_USER tuser = new GGZYJD.DbEntity.T_USER();
                    //将返回的用户信息转换为业务系统的用户,目前只有监督平台用户，后续其他业务系统加入再优化
                    //数据库没有用户信息，或用户信息7天没更新了，从闽政通获取用户信息进行更新
                    if (dbUser == null)
                    {
                        user = GetUserFromMzt(userid, userToken);
                        if (user != null)
                        {
                            user.CREATE_TIME = DateTime.Now;
                            user.MODIFY_TIME = DateTime.Now;
                            DbContext.Fw.Insert(user);
                            tuser = RegisterTuser(user);
                            isFirst = 1;
                        }

                    }
                    //查看最近更新时间，如果超过一周未更新则进行更新
                    else if ((DateTime.Now - dbUser.MODIFY_TIME)?.TotalDays > 7)
                    {
                        user = GetUserFromMzt(userid, userToken);
                        user.MODIFY_TIME = DateTime.Now;
                        user.FWUSERID = dbUser.FWUSERID;
                        user.JDUSERID = dbUser.JDUSERID;
                        DbContext.Fw.Update(user);
                        tuser = DbContext.Jd.From<GGZYJD.DbEntity.T_USER>()
                            .Where(GGZYJD.DbEntity.T_USER._.ID == dbUser.JDUSERID).ToFirst();
                    }
                    else
                    {
                        user = dbUser;
                        tuser = DbContext.Jd.From<GGZYJD.DbEntity.T_USER>()
                            .Where(GGZYJD.DbEntity.T_USER._.ID == dbUser.JDUSERID).ToFirst();
                    }
                    if (tuser.TYPE == 3)
                    {
                        isZhuCe = 1;
                    }
                    if (user != null)
                    {
                        //设置token
                        var identity = CreateToken(user);
                        var cacheToken = identity.Ticket;
                        var ticket = Guid.NewGuid().ToString("N");
                        GlobalCache.Instance.Set(ticket, cacheToken, 2);
                        token = ticket;
                    }
                }
            }

            return token;
        }
        /// <summary>
        /// 根据用户id从闽政通获取数据
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        private MZTUSER GetUserFromMzt(string userid, string userToken)
        {
            AppSettings app = new AppSettings();
            //发送请求获取用户信息
            var sendParam = new Dictionary<string, string>()
            {
                {"POSTPARAM_JSON",JsonConvert.SerializeObject(new
                {
                    INVOKESERVICE_CODE = "033",
                    INVOKECALLER_CODE = app.MZT_CODE,
                    USER_TOKEN = userToken,
                    USER_ID = userid

                })}
            };
            string result = new WebUtils().DoPost(app.MZT_GETUSER_URL, sendParam);
            Dictionary<string, object> resDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(result);
            if ("true".Equals(resDict["success"].ToString().ToLower()))
            {
                return JsonConvert.DeserializeObject<MZTUSER>(resDict["data"].ToString());
            }

            return null;
        }
        /// <summary>
        /// 根据闽政通用户信息注册新的用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private GGZYJD.DbEntity.T_USER RegisterTuser(MZTUSER user)
        {
            GGZYJD.DbEntity.T_USER tuser;
            using (var trans = DbContext.Jd.BeginTransaction())
            {
                tuser = new GGZYJD.DbEntity.T_USER()
                {
                    ID = 0,
                    USERNAME = user.USER_ACCOUNT ?? user.USER_MOBILE,
                    PASSWORD = "afdd0b4ad2ec172c586e2150770fbf9e",//默认密码：Aa123456
                    EMAIL = user.LEGALPERSON_EMAIL,
                    REG_TM = DateTime.Now,
                    TYPE = 3,
                    ROLEIDS = "8",
                    IS_ENABLE = 1,
                    MANAGE_NAME = user.USER_NAME ?? user.USER_MOBILE,
                    TELPHONE = user.USER_MOBILE,
                    DEPARTID = 658,
                    CREATETIME = DateTime.Now,
                    ISSENDMSG = 0,
                    ISPUSHMSG = 0,
                    ISSENDMSG_BJ = 0,
                    IS_SEND_MSG = 0
                };
                int i = trans.Insert(tuser);
                tuser.ID = i;
                //添加extend
                T_USER_EXTEND userex = new T_USER_EXTEND()
                {
                    ID = 0,
                    U_ID = i,
                    DEP_NAME = "实名认证登录自动注册",
                    DEP_KIND = "1",
                    UNIFIED_CREDIT_CODE = user.USER_IDCARD,
                    ORGAN_CODE = user.LEGALPERSON_ZZJGDM,
                    PROV_CODE = user.LEGALPERSON_ZPROCODE ?? user.POPULATION_CPROCODE,
                    CITY_CODE = user.LEGALPERSON_ZCITYCODE ?? user.POPULATION_CCITYCODE,
                    COUNTY_CODE = user.LEGALPERSON_ZAREACODE ?? user.POPULATION_CAREACODE,
                    POSTAL_CODE = user.LEGALPERSON_ZIPCODE,
                    ADDRESS = user.LEGALPERSON_ZADDRESS ?? user.POPULATION_JZDZ,
                    CONTACTS = user.LEGALPERSON_NAME ?? user.USER_NAME,
                    CONTACTS_PHONE = user.USER_MOBILE,
                    ACCOUNT_TYPE = "1,2,3",
                    IDCARD = user.USER_IDCARD
                };
                trans.Insert(userex);

                #region 设置角色信息(注册用户)

                var zcyhRoleName = ConfigHelper.AppSettings.ZhuCeYongHu;
                var registerUserRole = trans.From<T_USER_ROLE_V2>().Where(T_USER_ROLE_V2._.NAME == zcyhRoleName).ToFirst();
                if (registerUserRole != null)
                {
                    var groupRole = new T_GENERAL_ATTRIBUTE_V2
                    {
                        MGUID = Guid.NewGuid().ToString("N"),
                        ENTITYNAME = nameof(GGZYJD.DbEntity.T_USER),
                        ENTITYID = tuser.ID?.ToString(),
                        KEY = UserGroup.USER_GROUP_ID,
                        OBJECTID = ConfigHelper.APP_KEY_GGZYJD,
                        REMARK = $"公共资源监督平台用户角色分组{DateTime.Now:yyyyMMddHHmmss}",
                        VALUE = registerUserRole.GROUP_ID,
                    };
                    trans.Insert(groupRole);
                }
                #endregion

                DbContext.Fw.Update<MZTUSER>(MZTUSER._.JDUSERID, i, MZTUSER._.USER_ID == user.USER_ID);
                trans.Commit();

            }
            return tuser;
        }
        /// <summary>
        /// 生成票据返回给前端
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private CustomAuthenticationIdentity CreateToken(MZTUSER user)
        {
            var uid = ServicesFactory.GGZYFW.UnifyUserService.FromWhere(UNIFY_AUTHS._.APPUID == user.JDUSERID)
                .InnerJoin<UNIFY_AUTHS>(UNIFY_AUTHS._.USERGUID == UNIFY_USER._.MGUID)
                .InnerJoin<UNIFY_APP>(UNIFY_APP._.MGUID == UNIFY_AUTHS._.APPGUID &&
                                      (UNIFY_APP._.APPTYPE == ConfigHelper.APP_KEY_GGZYJD))
                .Select(UNIFY_USER._.MGUID).ToScalar<string>();
            var identity = new CustomAuthenticationIdentity
            {
                Ticket = Guid.NewGuid().ToString("N"),
                TimeStamp = DateTime.Now.ToString("yyyyMMddHHmmss"),
                Id = uid,
                MztId = user.USER_ID,
                Name = user.USER_NAME,
                LoginName = user.USER_ACCOUNT,
                AuthenticationType = "SMRZ"
            };
            new JwtTokenManager().CreateToken(identity);
            return identity;
        }
    }
}