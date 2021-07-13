using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using GGZY.DataV4Service.Extend;

namespace GGZY.DataV4Service.Sms
{
    public class SmsChinaWJ : ISmsClass
    {
        public SmsChinaWJ(string sysName) : base(sysName)
        {
            SMS_PLATFORM = "中国网建";
        }
        private static string User
        {
            get
            {
                return WebUtil.SMS.SmsWjUid;
            }
        }

        private static string Key
        {
            get
            {
                return WebUtil.SMS.SmsWjKey;
            }
        }

        //短信发送数量  大于0
        private enum ChinaWjReturn
        {
            没有该用户账户 = -1,
            接口密钥不正确 = -2,
            MD5接口密钥加密不正确 = -21,
            短信数量不足 = -3,
            该用户被禁用 = -11,
            短信内容出现非法字符 = -14,
            手机号格式不正确 = -4,
            手机号码为空 = -41,
            短信内容为空 = -42,
            短信签名格式不正确 = -51,
            IP限制 = -6
        };

        protected override SmsReturnJson SendSms(string phone, string content)
        {
            try
            {
                string url = "http://utf8.sms.webchinese.cn";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "Post";
                request.ContentType = "application/x-www-form-urlencoded";

                var buffer = new StringBuilder();
                buffer.AppendFormat("Uid={0}", User);
                buffer.AppendFormat("&Key={0}", Key);
                buffer.AppendFormat("&smsMob={0}", phone);
                buffer.AppendFormat("&smsText={0}", HttpUtility.UrlEncode(content, Encoding.UTF8));
                byte[] data = Encoding.UTF8.GetBytes(buffer.ToString());
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
                var response = (HttpWebResponse)request.GetResponse();
                var sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                string message = sr.ReadToEnd();
                sr.Close();
                string rs = "";
                if (message.ToInt() < 0)
                {
                    rs = Enum.GetName(typeof(ChinaWjReturn), message.ToInt());
                }
                else
                {
                    rs = "成功发送【" + message + "】条短信";
                }
                SmsReturnJson smsJson = new SmsReturnJson();
                smsJson.SmsStatus = message;
                smsJson.SmsText = rs;
                return smsJson;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}