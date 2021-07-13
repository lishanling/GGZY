using System;

namespace GGZY.Core.Authentication.FormsCookie
{
    public interface IAuthentication
    {

       void SignIn<T>(string userName, T userDataViewModel, DateTime? expires = null);

       void SignOut();

        void SetCookie(string cookieName, string value, DateTime? expires = null);
    }
}