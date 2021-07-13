using System;
using System.Security.Principal;
using GGZY.Core.Extensions;
using Newtonsoft.Json;

namespace GGZY.Core.Authentication
{
    /// <summary>
    /// 自定义标识对象
    /// </summary>
    public class CustomAuthenticationIdentity : IIdentity
    {
        private string _AUTHENTICATION_TYPE = "Forms";

        public CustomAuthenticationIdentity()
        {
            //IsAuthenticated = true;
            //AuthenticationType = "Forms";
        }
        public CustomAuthenticationIdentity(string name) : this()
        {
            this.Name = name;
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string Name { get; set; }

        public string AuthenticationType
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_AUTHENTICATION_TYPE))
                {
                    return "Forms";
                }
                return _AUTHENTICATION_TYPE;
            }
            set => _AUTHENTICATION_TYPE = value;
        }

        public bool IsAuthenticated { get; set; } = true;

        /// <summary>
        /// 用户ID
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 闽政通实名认证的id
        /// </summary>
        public string MztId { get; set; }
        /// <summary>
        /// 登录名
        /// </summary>
        public string LoginName { get; set; }
       
        /// <summary>
        /// 身份认证Token
        /// </summary>
        public string Token { get; set; }
        /// <summary>
        /// 认证时间戳
        /// </summary>
        public string TimeStamp { get; set; }


       

        public string Ticket { get; set; }

        public override string ToString()
        {
            return this.Serializer();
        }

        public string TokenCacheKey => $"Ticket:{Ticket}";
    }
}