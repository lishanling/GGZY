using System.Web;

namespace GGZY.Services.Infrastructure.Model
{
    public class ExternalLoginModel:LoginModel
    {
        private string _REDIRECT_URL;
        public string AppId { get; set; }

        public string RedirectUrl
        {
            get => HttpUtility.UrlDecode(_REDIRECT_URL);
            set => _REDIRECT_URL = value;
        }

        public string State { get; set; }

        /// <summary>
        /// App 校验
        /// </summary>
        /// <returns></returns>
        public bool ValidateApplication()
        {
            return true;
        }
    }
}