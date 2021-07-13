using System;

namespace GGZY.Core.Authentication.Jwt
{
    public class JwtConstants
    {
        public static String JwtSecret = "FjGgFwJYJ5Qv2WF4lA6jPl5GKuAG";
        public static String Authorization = "X-AUTH-TOKEN";
        public static String CurrentUserName = "CURRENT_TOKEN_USER_NAME";
        public static String CurrentTokenClaims = "CURRENT_TOKEN_CLAIMS";
        /// <summary>
        /// 过期时间 分
        /// </summary>
        public static int TokenExpires = 2 * 60;
    }
}