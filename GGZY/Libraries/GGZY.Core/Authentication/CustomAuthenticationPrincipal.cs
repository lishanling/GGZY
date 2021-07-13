using System.Security.Principal;

namespace GGZY.Core.Authentication
{
    public class CustomAuthenticationPrincipal: IPrincipal
    {
        public CustomAuthenticationPrincipal(IIdentity identity)
        {
            Identity = identity;
        }
        public bool IsInRole(string role)
        {
            return true;
        }

        public IIdentity Identity { get; private set; }
    }
}