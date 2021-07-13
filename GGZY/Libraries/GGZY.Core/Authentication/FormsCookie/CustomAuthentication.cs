using System;
using System.Web;
using System.Web.Security;
using Newtonsoft.Json;

namespace GGZY.Core.Authentication.FormsCookie
{
    /// <summary>
    /// 自定义身份验证服务
    /// </summary>
    public class CustomAuthentication : IAuthentication
    {

        public CustomAuthentication()
        {
        }
        /// <summary>
        /// 签出
        /// </summary>
        public void SignOut()
        {
            FormsAuthentication.SignOut();
        }

        /// <summary>
        /// 签入
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="userName"></param>
        /// <param name="userDataViewModel"></param>
        /// <param name="expires"></param>
        public void SignIn<T>(string userName, T userDataViewModel, DateTime? expires = null)
        {
            DateTime expiration = DateTime.Now.AddMinutes(60);
            if (expires.HasValue)
                expiration = expires.Value;
            //FormsAuthentication.SetAuthCookie(userName, true);
            FormsAuthentication.Initialize();
            string userData = JsonConvert.SerializeObject(userDataViewModel);
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(2, userName, DateTime.Now, expiration, false, userData, FormsAuthentication.FormsCookiePath);
            var encTicket = FormsAuthentication.Encrypt(ticket);
            this.SetCookieItem(FormsAuthentication.FormsCookieName, encTicket, expiration, false);
        }

        public void SetCookie(string cookieName, string cookie, DateTime? expires = null)
        {
            DateTime expiration = DateTime.Now.AddMinutes(60);
            if (expires.HasValue)
                expiration = expires.Value;
            this.SetCookieItem(cookieName, cookie, expiration, false);
        }

        /// <summary>
        /// 设置Cookie
        /// </summary>
        /// <param name="name">cookie 键</param>
        /// <param name="value">cookie 值</param>
        /// <param name="expires">过期时间</param>
        /// <param name="urlEncode">encode编码</param>
        private void SetCookieItem(string name, string value, DateTime? expires = null, bool urlEncode = false)
        {
            string str = urlEncode ? HttpUtility.UrlEncode(value) : value;
            HttpCookie cookie = new HttpCookie(name, str)
            {
                Path = FormsAuthentication.FormsCookiePath,
                HttpOnly = true,
                Secure = FormsAuthentication.RequireSSL
            };

            if (expires.HasValue)
            {
                cookie.Expires = expires.Value;
            }
            HttpContext.Current.Response.Cookies.Add(cookie);
        }


    }



}
