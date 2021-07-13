using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{

    public partial class UNIFY_APP
    {
        

        #region
        /// <summary>
        /// 验证当前App信息有效性
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            return !string.IsNullOrWhiteSpace(APPKEY) && !string.IsNullOrWhiteSpace(APPNAME) && !string.IsNullOrWhiteSpace(HOSTURL) && !string.IsNullOrWhiteSpace(SSOURL) && !string.IsNullOrWhiteSpace(OAUTHURL);
        }
        #endregion

    }
}