using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TSsoInfoService 
    {
        /// <summary>
        /// 获取T_SSO_INFO信息
        /// </summary>
        /// <param name="redirect_uri"></param>
        /// <param name="client_id"></param>
        /// <returns></returns>
        public T_SSO_INFO GetSsoInfo(string redirect_uri, string client_id)
        {
            var redirect_uri_upper = redirect_uri.ToUpper();
            return FirstOrNull((T_SSO_INFO._.REDIRECT_URI == redirect_uri ||
                                T_SSO_INFO._.REDIRECT_URI == redirect_uri_upper)&&T_SSO_INFO._.CLIENT_ID==client_id);
        }
    }
}