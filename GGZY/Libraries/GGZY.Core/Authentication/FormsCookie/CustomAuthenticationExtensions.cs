using System.Security.Principal;
using System.Web;
using System.Web.Security;
using Newtonsoft.Json;

namespace GGZY.Core.Authentication.FormsCookie
{
    public static class CustomAuthenticationExtensions
    {
        #region FormsAuthentication

        public static CustomAuthenticationIdentity AuthorizeFormsIdentityUser(this IPrincipal user)
        {
            var identity = user.Identity as CustomAuthenticationIdentity;
            return identity;
            //var identity= user.AuthorizeFormsIdentityUser<CustomAuthenticationIdentity>();
            //return identity;
        }

        public static TModel AuthorizeFormsIdentityUser<TModel>(this IPrincipal user)
        {
            return user.Identity.FormsIdentityUser<TModel>();
        }
        public static TModel FormsIdentityUser<TModel>(this IIdentity identity)
        {
            if (identity.IsAuthenticated)
            {
                var s = HttpUtility.UrlDecode(((FormsIdentity) identity).Ticket.UserData);
                return JsonConvert.DeserializeObject<TModel>(s);
            }
               
            return default(TModel);
        }

        #endregion
        

    }
}
