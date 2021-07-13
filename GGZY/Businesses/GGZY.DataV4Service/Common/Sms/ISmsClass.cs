using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace GGZY.DataV4Service.Sms
{
    public abstract partial class ISmsClass
    {
        protected string SMS_PLATFORM = "";//SMS_PLATFORM 短信平台
        protected string SYSNAME = "";
        protected string Signature = WebUtil.GetAppSetting("SmsSignature");
        public ISmsClass(string sysName)
        {
            SYSNAME = sysName;
        }

        /// <summary>
        /// 发送短信底层实现方法
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        protected abstract SmsReturnJson SendSms(string phone, string content);

        protected class SmsReturnJson
        {
            private string _SmsStatus = "";

            public string SmsStatus
            {
                get
                {
                    return _SmsStatus;
                }

                set
                {
                    _SmsStatus = value;
                }
            }

            public string SmsText
            {
                get
                {
                    return _SmsText;
                }

                set
                {
                    _SmsText = value;
                }
            }

            private string _SmsText = "";

        }

        /// <summary>
        /// 【无限制】发送短信
        /// </summary>
        /// <param name="phone">手机号码，支持多个手机号，用英文逗号隔开</param>
        /// <param name="content">短信内容，最多300个字符</param>
        /// <returns>返回json格式的字符串 如{SmsStatus:1,SmsText:"成功发送1条短信"}</returns>
        public string SendNoLimit(string phone, string content)
        {
            if (content.Substring(content.Length - 1) != "】")
            {//内容中加入了签名 不默认加配置的签名
                content = content + Signature;
            }
            try
            {
                SmsReturnJson json = SendSms(phone, content);
                return JsonConvert.SerializeObject(json);
            }
            catch (Exception e)
            {
                //LogHelper.WriteErrLog(e);
                Logger.StrongLogger.Error("", "", e.Message, e);
                throw e;
            }
            //return null;
        }
    }
}