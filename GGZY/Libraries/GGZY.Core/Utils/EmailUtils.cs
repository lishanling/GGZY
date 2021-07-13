using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GGZY.Core.Extensions;
using GGZY.Core.Log;

namespace GGZY.Core.Utils
{
    public class EmailUtils
    {
        /// <summary>
        /// 发送邮件,邮箱必须开通smtp
        /// </summary>
        /// <param name="strTo">收件人邮箱</param>
        /// <param name="strBody">邮件内容</param>
        /// <param name="strSubject">邮件标题</param>
        /// <param name="emailSendCallback">邮件发送回调</param>
        /// <returns>返回是否发送成功</returns>
        public static bool SendEmail(string strTo, string strBody, string strSubject,Action<Exception> emailSendCallback=null)
        {
            string sHos = AppSettingUtils.GetString("EmailSmtp", "smtp.163.com"); //根据发送邮箱地址获取你的smtp主机 
            string strFrom = AppSettingUtils.GetString("FromEmailAccount", "pspforstrong@163.com"); //发件人邮箱 
            string pwd = AppSettingUtils.GetString("FromEmailPWD", "strong9889"); //发件人邮箱密码 
            if (string.IsNullOrEmpty(sHos))
            {
                return false;
            }
            System.Net.Mail.MailAddress fromEmail = new System.Net.Mail.MailAddress(strFrom);//发件人的地址
            System.Net.Mail.MailAddress toEmail = new System.Net.Mail.MailAddress(strTo);//收件人地址
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage(fromEmail, toEmail);
            mail.Body = strBody;
            mail.Subject = strSubject;
            mail.IsBodyHtml = true;//邮件内容支持网页格式
            mail.BodyEncoding = Encoding.UTF8;
            mail.Priority = System.Net.Mail.MailPriority.Normal;
            System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient();
            smtpClient.Host = sHos;//这里设置成你的smtp主机名或者ip地址
            try
            {
                //设置邮箱端口，pop3端口:110, smtp端口是:25 
                smtpClient.Port = AppSettingUtils.GetInt("EmailPort", 25);
            }
            catch (Exception)
            {
                Logger.Error($"邮箱端口错误");
                return false;
            }
            smtpClient.UseDefaultCredentials = false;
            smtpClient.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new System.Net.NetworkCredential(strFrom, pwd);//你的用户名和密码


            new Thread(o =>
                {
                    try
                    {
                        smtpClient.Send(mail);
                        emailSendCallback?.Invoke(null);
                    }
                    catch (Exception e)
                    {
                        Logger.Error($"邮件发送错误", e);
                        emailSendCallback?.Invoke(e);
                    }

                })
            { IsBackground = true }.Start();

            return true;
        }
    }
}
/*
<!-- 用户注册：发送方邮箱，邮箱必须开通smtp -->
<add key = "FromEmailAccount" value="pspforstrong@163.com" />
<!-- 用户注册：发送方邮箱密码，邮箱必须开通smtp -->
<add key = "FromEmailPWD" value="strong9889" />
<!-- 用户注册：发送方邮箱smtp主机 -->
<add key = "EmailSmtp" value="smtp.163.com" />
<!-- 用户注册：发送方邮箱端口 -->
<add key = "EmailPort" value="25" />
*/
