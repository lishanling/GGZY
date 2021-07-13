using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Models;

namespace GGZY.Core.ExternalAuthentication
{
    /// <summary>
    /// 外部认证
    /// </summary>
    public class ExternalAuth
    {
        #region Properties

        private string _APP_ID;
        private string _STATE;
        private string _REDIRECT_URL;
        private string _RESPONSE_TYPE = "code";
        private string _CODE;
        private string _ACCESS_TOKEN;
        private string _CLIENT_SECRET;
        private string _GRANT_TYPE = "authorization_code";

        #region MyRegion


        public string AppId
        {
            get => _APP_ID;
            set => _APP_ID = value;
        }

        public string State
        {
            get => _STATE;
            set => _STATE = value;
        }

        public string RedirectUrl
        {
            get => _REDIRECT_URL;
            set => _REDIRECT_URL = value;
        }

        /// <summary>
        /// response_type [此值固定为 code]
        /// </summary>
        public string ResponseType
        {
            get => _RESPONSE_TYPE;
            set => _RESPONSE_TYPE = value;
        }
        /// <summary>
        /// grant_type [此值固定为 authorization_code]
        /// </summary>
        public string GrantType
        {
            get => _GRANT_TYPE;
            set => _GRANT_TYPE = value;
        }

        /// <summary>
        /// code [第二步请求回来的code]
        /// </summary>
        public string Code
        {
            get => _CODE;
            set => _CODE = value;
        }
        public string AccessToken
        {
            get => _ACCESS_TOKEN;
            set => _ACCESS_TOKEN = value;
        }

        public string AppSecret
        {
            get => _CLIENT_SECRET;
            set => _CLIENT_SECRET = value;
        }

        #endregion

        #region MyRegion

        public string client_id
        {
            get => _APP_ID;
            set => _APP_ID = value;
        }

        //public string state
        //{
        //    get => _STATE;
        //    set => _STATE = value;
        //}


        public string redirect_uri
        {
            get => _REDIRECT_URL;
            set => _REDIRECT_URL = value;
        }
        /// <summary>
        /// response_type [此值固定为 code]
        /// </summary>
        public string response_type
        {
            get => _RESPONSE_TYPE;
            set => _RESPONSE_TYPE = value;
        }
        /// <summary>
        /// grant_type [此值固定为 authorization_code]
        /// </summary>
        public string grant_type
        {
            get => _GRANT_TYPE;
            set => _GRANT_TYPE = value;
        }
        ///// <summary>
        ///// code [第二步请求回来的code]
        ///// </summary>
        //public string code
        //{
        //    get => _code;
        //    set => _code = value;
        //}

        public string access_token
        {
            get => _ACCESS_TOKEN;
            set => _ACCESS_TOKEN = value;
        }

        public string client_secret
        {
            get => _CLIENT_SECRET;
            set => _CLIENT_SECRET = value;
        }

        #endregion

        /// <summary>
        /// 回调地址
        /// </summary>
        public string CallBackUrl => $"{RedirectUrl}?code={Code}&state={State}";

        /// <summary>
        /// 登录用户认证信息 => 用户ID
        /// </summary>
        public string Uid { get; set; }

        public DateTime? CreateTime { get; set; }
        public DateTime? ExpireTime { get; set; }

        #endregion

        #region Method
        /// <summary>
        /// 获取OAuth认证Code
        /// </summary>
        /// <param name="validateExternalAuthInfo">验证参数有效性</param>
        /// <returns></returns>
        public GeneralResult GetAuthorizeCode(Func<string, string, GeneralResult> validateExternalAuthInfo)
        {
            var r = new GeneralResult<string>();
            if (ResponseType != "code")
            {
                r.SetFail("响应类型错误");
            }
            else
            {

                if (validateExternalAuthInfo != null)
                {
                    var validateRsp = validateExternalAuthInfo(AppId, RedirectUrl);
                    if (validateRsp.Success)
                    {

                        AccessToken = Guid.NewGuid().ToString("N");
                        Code = Guid.NewGuid().ToString("N");
                        GlobalCache.Instance.Set(Code, this, 5);
                        r.SetSuccess(new { Url = CallBackUrl });
                    }
                    else
                    {
                        r.SetFail($"应用ID或者回调地址非法");
                    }
                }
                else
                {
                    AccessToken = Guid.NewGuid().ToString("N");
                    Code = Guid.NewGuid().ToString("N");
                    GlobalCache.Instance.Set(Code, this, 5);
                    r.SetSuccess(new { Url = CallBackUrl });
                }

            }
            return r;
        }

        /// <summary>
        /// Code 换取 访问令牌 ACCESS_TOKEN
        /// </summary>
        /// <returns></returns>
        public GeneralResult GetAccessToken()
        {
            var r = new GeneralResult();
            if (GrantType != "authorization_code")
            {
                r.SetFail($"授权类型错误");
            }
            else if (!GlobalCache.Instance.IsSet(Code))
            {
                r.SetFail($"无效的授权编码");
            }
            else
            {
                var cache = GlobalCache.Instance.Get<ExternalAuth>(Code);
                if (client_id != cache.client_id || redirect_uri != cache.redirect_uri ||
                    client_secret != cache.client_secret & State != cache.State)
                {
                    r.SetFailEx($"非法的请求", this.Serializer());
                }
                else
                {
                    GlobalCache.Instance.Remove(Code);
                    CreateTime = DateTime.Now;
                    ExpireTime = CreateTime.Value.AddDays(1);
                    if (GlobalCache.Instance.IsSet(cache.AccessToken))
                    {
                        cache.ExpireTime = ExpireTime;
                        GlobalCache.Instance.Set(cache.AccessToken, cache, 24 * 60);
                    }
                    else
                    {
                        GlobalCache.Instance.Set(cache.AccessToken, this, 24 * 60);
                    }
                    r.SetSuccess(cache.AccessToken);
                }
            }

            return r;
        }

        /// <summary>
        /// 获取授权用户信息
        /// </summary>
        /// <param name="authorizeFunc">获取授权用户信息</param>
        /// <returns></returns>
        public GeneralResult AuthorizeInfo(Func<string, GeneralResult> authorizeFunc)
        {
            var r = new GeneralResult();
            if (GlobalCache.Instance.IsSet(AccessToken))
            {
                var cache = GlobalCache.Instance.Get<ExternalAuth>(AccessToken);
                if (authorizeFunc != null)
                {
                    r = authorizeFunc(cache.Uid);
                }
                else
                {
                    r.SetSuccess(cache.Uid);
                }                
            }
            else
            {
                r.SetFail($"访问令牌无效或者已过期");
            }
            return r;
        }
        #endregion
    }
}