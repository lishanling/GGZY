using System;
using GGZY.Core.Cache;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using JWT;
using JWT.Algorithms;
using JWT.Builder;
using Newtonsoft.Json;

namespace GGZY.Core.Authentication.Jwt
{
    public class JwtTokenManager
    {
       
        public string CreateToken(CustomAuthenticationIdentity identity)
        {
            var jwtToken = GlobalCache.Instance.Get<string>(identity.TokenCacheKey, JwtConstants.TokenExpires, () =>
            {
                string token = new JwtBuilder()
                    .WithAlgorithm(new HMACSHA256Algorithm()) // 使用算法
                    .WithSecret(JwtConstants.JwtSecret) // 使用秘钥
                    //.AddClaim("exp", DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds())
                    .AddClaim("Id", identity.Id)
                    .AddClaim("Name", identity.Name)
                    .AddClaim("LoginName", identity.LoginName)
                    .AddClaim("Ticket", identity.Ticket)
                    .AddClaim("TimeStamp", identity.TimeStamp)
                    .AddClaim("AuthenticationType", identity.AuthenticationType)
                    .AddClaim("MztId", identity.MztId)
                    .Encode();
                return token;
            });
            identity.Token = jwtToken;
            return jwtToken;
        }

        public GeneralResult<CustomAuthenticationIdentity> CheckToken(string ticket)
        {
            var result=new GeneralResult<CustomAuthenticationIdentity>();
            var tokenCacheKey = $"Ticket:{ticket}";
            if (GlobalCache.Instance.IsSet(tokenCacheKey))
            {
                var authorization = GlobalCache.Instance.Get<string>(tokenCacheKey);
                var tokenResult = GetToken(authorization);
                if (tokenResult.Success)
                {
                    var identity = tokenResult.TData;
                    var tokenExpires = AppSettingUtils.GetInt("tokenExpires", JwtConstants.TokenExpires);
                    GlobalCache.Instance.Set(tokenCacheKey, authorization, tokenExpires);
                    identity.Ticket = ticket;
                    result.SetSuccessT(identity);
                }
                else
                {
                    result.SetFail(tokenResult.Msg);
                }
            }
            else
            {
                result.SetTimeout("长时间未进行有效操作，请重新进行身份认证!");
            }

            return result;
        }

        public void DeleteToken(string ticket)
        {
            var tokenCacheKey = $"Ticket:{ticket}";
            if (GlobalCache.Instance.IsSet(tokenCacheKey))
            {
                var authorization = GlobalCache.Instance.Get<string>(tokenCacheKey);
                var tokenResult = GetToken(authorization);
                if (tokenResult.Success)
                {
                    var identity = tokenResult.TData;
                    GlobalCache.Instance.Remove(identity.TokenCacheKey);
                }
            }
        }

        protected GeneralResult<CustomAuthenticationIdentity> GetToken(string authorization)
        {
            var result=new GeneralResult<CustomAuthenticationIdentity>();
            try
            {
                string json = new JwtBuilder()
                    .WithAlgorithm(new HMACSHA256Algorithm()) // 使用算法
                    .WithSecret(JwtConstants.JwtSecret)
                    .MustVerifySignature()
                    .Decode(authorization);

                var data = JsonConvert.DeserializeObject<CustomAuthenticationIdentity>(json);
                data.Token = authorization;
                result.SetSuccessT(data);
            }
            catch (TokenExpiredException)
            {
                result.SetFail("签名已过期");
            }
            catch (SignatureVerificationException)
            {
                result.SetFail("签名无效");
            }
            catch (Exception e)
            {
                result.SetException($"签名解析失败:{e.Message}",e);
            }

            return result;
        }
    }
}