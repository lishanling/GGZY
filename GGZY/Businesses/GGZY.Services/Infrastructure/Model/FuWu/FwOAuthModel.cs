using System;
using System.Text;
using GGZY.Core.Algorithms;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.Services.Infrastructure.Model.FuWu
{
    /// <summary>
    /// 服务平台第三方登录实体类
    /// </summary>
    public class FwOAuthModel
    {

        #region 属性
        /// <summary>
        /// 当前登录用户ID
        /// </summary>
        public decimal? guid { get; set; }
        /// <summary>
        /// 登录名
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 密码（密文）
        /// </summary>
        public string pwd { get; set; }
        /// <summary>
        /// 验证码
        /// </summary>
        public string img_code { get; set; }

        /// <summary>
        /// client_id
        /// </summary>
        public string client_id { get; set; }
        /// <summary>
        /// redirect_uri [授权后的回调地址,需与注册应用里的回调地址一致]
        /// </summary>
        public string redirect_uri { get; set; }
        /// <summary>
        /// state 可选
        /// </summary>
        public string state { get; set; }
        /// <summary>
        /// response_type [此值固定为 code]
        /// </summary>
        public string response_type { get; set; }
        /// <summary>
        /// grant_type [此值固定为 authorization_code]
        /// </summary>
        public string grant_type { get; set; }
        /// <summary>
        /// code [第二步请求回来的code]
        /// </summary>
        public string code { get; set; }
        /// <summary>
        /// access_token
        /// </summary>
        public string access_token { get; set; }
        /// <summary>
        /// client_secret
        /// </summary>
        public string client_secret { get; set; }

        #endregion

        #region 方法

        public LoginModel ToLoginModel()
        {
            return new LoginModel
            {
                Id = name,
                Code = this.img_code,
                Name = this.name,
                Md5Pwd = pwd,
                Pwd=pwd,
            };
        }
        /// <summary>
        /// 验证授权参数
        /// </summary>
        /// <returns></returns>
        public GeneralResult Validate()
        {
            var r = new GeneralResult();
            if (string.IsNullOrWhiteSpace(response_type) || !response_type.Equals("code", StringComparison.CurrentCultureIgnoreCase))
            {
                r.SetFail("response_type必须为code");
            }
            else if (string.IsNullOrWhiteSpace(client_id))
            {
                r.SetFail("client_id非空");
            }
            else if (string.IsNullOrWhiteSpace(redirect_uri))
            {
                r.SetFail("redirect_uri非空");
            }
            //else if (string.IsNullOrWhiteSpace(client_secret))
            //{
            //    r.SetFail("client_secret非空");
            //}
            else
            {
                r.SetSuccess();
            }

            return r;
        }

        #region 第二步 获取Code

        /// <summary>
        /// 第二步 获取Code
        /// </summary>
        /// <param name="getSsoInfo">
        /// 读取T_SSO_INFO信息
        /// redirect_uri client_id
        /// </param>
        /// <returns></returns>
        public GeneralResult GetAuthorizeCode(Func<string, string, T_SSO_INFO> getSsoInfo)
        {
            var r = new GeneralResult();
            try
            {
                if (!response_type.Equals("code"))
                {
                    r.SetFail("response_type必须为code");
                }
                else
                {
                    var model = getSsoInfo(redirect_uri, client_id);
                    if (model != null)
                    {
                        //var token = GetToken($"{model.CLIENT_ID}{DateTime.Now:yyyyMMddHHmmssfff}");
                        code = GetToken($"{model.CLIENT_ID}{DateTime.Now:yyyyMMddHHmmssfff}");// Guid.NewGuid().ToString("N");//作为换取ACCESS_TOKEN的code使用
                        //var data = new
                        //{
                        //    uid = "", //TODO
                        //    client_id,
                        //    redirect_uri,
                        //    client_secret
                        //};
                        this.client_secret = model.CLIENT_SECRET;
                        GlobalCache.Instance.Set(code, this, 5);
                        r.SetSuccess(model);
                    }
                    else
                    {
                        r.SetFail("非法的client_id或者redirect_uri");
                    }
                }
            }
            catch (Exception e)
            {
                r.SetFail(e.Message);
            }
            return r;
        }


        #endregion

        #region 第三步 code 换 access_token

        /// <summary>
        /// 第三步 code 换 access_token
        /// </summary>
        /// <param name="getAuthorizationInfo">
        /// 读取 T_SSO_AUTHORIZATION 信息
        /// client_id user_id
        /// </param>
        /// <returns></returns>
        public GeneralResult<T_SSO_AUTHORIZATION> GetAccessToken(Func<string, decimal?, T_SSO_AUTHORIZATION> getAuthorizationInfo)
        {
            var r = new GeneralResult<T_SSO_AUTHORIZATION>();
            //if (string.IsNullOrWhiteSpace(response_type) || !response_type.Equals("code", StringComparison.CurrentCultureIgnoreCase))
            //{
            //    r.SetFail("response_type必须为code");
            //}
            
            
            if (string.IsNullOrWhiteSpace(grant_type)||!grant_type.Equals("authorization_code"))
            {
                r.SetFail("grant_type必须为authorization_code");
            }
            else if (string.IsNullOrWhiteSpace(client_id))
            {
                r.SetFail("client_id非空");
            }
            else if (string.IsNullOrWhiteSpace(redirect_uri))
            {
                r.SetFail("redirect_uri非空");
            }
            else if (string.IsNullOrWhiteSpace(client_secret))
            {
                r.SetFail("client_secret非空");
            }
            else
            {
                var cache = GlobalCache.Instance.Get<FwOAuthModel>(code);
                if (cache == null)
                {
                    r.SetFail("无效的code");
                }
                else
                {
                    if (!client_id.Equals(cache.client_id) || !redirect_uri.Equals(cache.redirect_uri) ||
                        !client_secret.Equals(cache.client_secret))
                    {
                        Logger.Error(new
                        {
                            m= "GetAccessToken",
                            P =this,
                            C=cache
                        }.Serializer());
                        
                        r.SetFail("非法的请求！");
                    }
                    else
                    {
                        var model = getAuthorizationInfo(client_id, cache.guid);
                        r.SetSuccessT(model);
                    }
                }

            }
            return r;
        }

        #endregion

        #region 第四步 通过access_token获取授权信息 

        /// <summary>
        /// 通过access_token获取授权信息
        /// </summary>
        /// <param name="authorizationFun">认证信息 access_token</param>
        /// <param name="authenticatedUserFunc">用户信息 uid</param>
        /// <param name="authenticatedUserLegalFunc">企业信息 uid</param>
        /// <returns></returns>
        public GeneralResult AuthorizeInfo(Func<string, T_SSO_AUTHORIZATION> authorizationFun,
            Func<decimal?, T_USER> authenticatedUserFunc, Func<decimal?, LEGAL_PERSON_BASE> authenticatedUserLegalFunc)
        {
            var r = new GeneralResult();
            try
            {
                var authorization = authorizationFun.Invoke(access_token);
                if (authorization != null)
                {
                    var legal = authenticatedUserLegalFunc.Invoke(authorization.USER_ID);
                    var user = authenticatedUserFunc.Invoke(authorization.USER_ID);
                    if (user != null)
                    {
                        r.SetSuccess(new
                        {
                            status = 1,
                            user_name = user.USERNAME,
                            real_name = user.MANAGE_NAME,
                            tel_phone = user.ZP_PHONE,
                            ca_info = string.IsNullOrWhiteSpace(user.CA_INFO) ? "{}" : user.CA_INFO,
                            legal_code = legal?.LEGAL_CODE ?? "",
                            legal_name = (legal?.LEGAL_NAME ?? "").TrimEnd('_'),//深圳CA很多用户的末尾带了下划线，在这边返回企业名称给交易平台的地方去掉这个下划线
                        });
                    }
                    else
                    {
                        r.SetSuccess(new
                        {
                            status = 1,
                            legal_code = legal?.LEGAL_CODE ?? "",
                            legal_name = (legal?.LEGAL_NAME ?? "").TrimEnd('_'),//深圳CA很多用户的末尾带了下划线，在这边返回企业名称给交易平台的地方去掉这个下划线
                        });
                    }
                }
                else
                {
                    r.SetFail("access_token无效");
                }
            }
            catch (Exception e)
            {
                r.SetFail(e.Message);
            }
            return r;
        }
        #endregion

        #region MyRegion

        public const string key = "B.KFnyx3";
        public string GetToken(string strSign)
        {
            IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
            var byteSign = Encoding.UTF8.GetBytes(strSign);
            return JwtBase64UrlEncoder.Encode(algorithm.Sign(Encoding.UTF8.GetBytes(key), byteSign));
        }

        #endregion
        #endregion
    }
}