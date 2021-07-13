using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Collections;
using System.Web.UI;
using System.IO;
using System.Text;


namespace GGZY.DataV4Service
{
    /// <summary>
    /// Web项目开发 常用方法
    /// </summary>
    public class WebUtil
    {
        public static string ClientIP
        {
            get
            {
                string result = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                if (null == result || result == String.Empty)
                {
                    result = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
                }

                if (null == result || result == String.Empty)
                {
                    result = HttpContext.Current.Request.UserHostAddress;
                }
                return result;
            }
        }

        public static string Port
        {
            get
            {
                return HttpContext.Current.Request.ServerVariables["REMOTE_PORT"];
            }
        }

        /// <summary>
        /// 获取客户端IP
        /// </summary>
        public static string IP
        {
            get
            {
                return HttpContext.Current.Request.UserHostAddress;
            }
        }
        /// <summary>
        /// 获取WebConfig文件指定的AppSetting值
        /// </summary>
        /// <param name="Key"></param>
        /// <returns></returns>
        public static string GetAppSetting(string Key)
        {
            if (System.Configuration.ConfigurationManager.AppSettings[Key] == null)
            {
                return "";
            }
            return System.Configuration.ConfigurationManager.AppSettings[Key].ToString().Trim();
        }
        public static class SMS
        {
            /// <summary>
            /// 中国网建UID
            /// </summary>
            public static string SmsWjUid
            {
                get
                {
                    return GetAppSetting("SmsWjUid");
                }
            }
            /// <summary>
            /// 中国网建接口Key
            /// </summary>
            public static string SmsWjKey
            {
                get
                {
                    return GetAppSetting("SmsWjKey");
                }
            }
        }


    }

}
