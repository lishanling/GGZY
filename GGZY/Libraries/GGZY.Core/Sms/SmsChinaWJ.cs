using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Core.Utils;

namespace GGZY.Core.Sms
{
    public class SmsChinaWJ :SmsCommon
    {


        #region Config
        protected override string SmsServerUrl => AppSettingUtils.GetString("sms_server_url", "http://utf8.sms.webchinese.cn");

        /// <summary>
        /// 中国网建UID
        /// </summary>
        protected string User => AppSettingUtils.GetString("SmsWjUid", "福建省公共资源交易公共服务平台有限公司");

        /// <summary>
        /// 中国网建接口Key
        /// </summary>
        protected override string Key => AppSettingUtils.GetString("sms_appid", "83044aab58dbae7aa1f5");

        #endregion

       

        #region Method

        
        /// <summary>
        /// 发送短信
        /// </summary>
        /// <returns></returns>
        public override GeneralResult SendSms()
        {
            var sendResult = new GeneralResult();
            try
            {
                var dic = new Dictionary<string, string>
                {
                    {"Uid", User},
                    {"Key", Key},
                    {"smsMob", Mobile},
                    {"smsText", $"{Prefix}{Content}{Suffix}"},
                };
                var body = new WebUtils().DoPost(SmsServerUrl, dic);
                var rspCode = body.ToNullableDecimal();
                if (rspCode.HasValue)
                {
                    if (rspCode.Value < 0)
                    {
                        var rspCodeType = (SmsChinaWjResponCode)Enum.Parse(typeof(SmsChinaWjResponCode), body);
                        sendResult.SetFail(rspCodeType.Description());
                    }
                    else
                    {
                        sendResult.SetSuccess(rspCode);
                    }
                }
                else
                {
                    sendResult.SetFail(body);
                }
            }
            catch (Exception e)
            {
                sendResult.SetException($"发送短信异常,{e.Message}", e);
            }
            return sendResult;
        }



        #endregion


    }

    public enum SmsChinaWjResponCode
    {
        [Display(Name="没有该用户账户")]
        NoAccount=-1,
        [Display(Name = "接口密钥不正确")]
        KeyError = -2,
        [Display(Name = "MD5接口密钥加密不正确")]
        Md5KeyError = -21,
        [Display(Name = "短信数量不足")]
        LastSmsCountWarn = -3,
        [Display(Name = "该用户被禁用")]
        UserDeny = -11,
        [Display(Name = "短信内容出现非法字符")]
        ContentInvalid = -14,
        [Display(Name = "手机号格式不正确")]
        PhoneNumberFormatError = -4,
        [Display(Name = "手机号码为空")]
        PhoneNumberEmpty = -41,
        [Display(Name = "短信内容为空")]
        ContentEmpty = -42,
        [Display(Name = "短信签名格式不正确")]
        SignatureFormatError = -51,
        [Display(Name = "IP限制")]
        IpLimit =-6,
    }
}