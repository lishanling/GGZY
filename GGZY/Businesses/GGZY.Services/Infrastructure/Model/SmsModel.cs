using System;
using System.Collections.Generic;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZY.Core.Sms;
using GGZY.Core.Utils;

namespace GGZY.Services.Infrastructure.Model
{
    public class SmsModel : SmsCommon
    {

        #region Config

        public const string REGISTER_KEY = "register";
        public const string DEFAULT_KEY = "default";
        public int CountDown => AppSettingUtils.GetInt("countdown", 1*60);

        private Dictionary<string, string> SmsTemplate => new Dictionary<string, string>
        {
            {REGISTER_KEY,"验证码:{0},{1}分钟内有效,仅限于账号注册,请勿告知他人。工作人员不会向您索取。" },
            {DEFAULT_KEY,"验证码:{0},{1}分钟内有效,仅限于当前操作,请勿告知他人。工作人员不会向您索取。" },
        };

        #endregion

        #region Properties

        public string ContentKey { get; set; } = DEFAULT_KEY;

        public string Code { get;  set; }


        public Int64 Ticks { get; set; }

        public Int32 Count { get; set; }


        private string CacheKey => $"{ContentKey}_{Mobile}";

        public override string Prefix { get; set; } = "【公共服务平台】";

        #endregion

        #region Method

        /// <summary>
        /// 发送前验证
        /// </summary>
        /// <param name="checkImgCode">验证图片验证码</param>
        /// <param name="checkContent">验证短信内容(关键字)</param>
        /// <returns></returns>
        public override GeneralResult Validate(Func<string, bool> checkImgCode = null, Func<string, bool> checkContent = null)
        {
            ContentBuilder();
            var r = base.Validate(checkImgCode, checkContent);
            if (r.Success)
            {
                if (GlobalCache.Instance.IsSet(CacheKey))
                {
                    var cache = GlobalCache.Instance.Get<SmsModel>(CacheKey);
                    var ticksNow = CommonUtils.ToUnixTimeStamp();
                    var countdown =ticksNow  - cache.Ticks;
                    if (countdown <= CountDown)
                    {
                        r.SetFailEx($"短信发送频繁，请稍后重试",$"CommonUtils.ToUnixTimeStamp() - cache.Ticks={ticksNow}-{cache.Ticks}={countdown}<={CountDown}");
                    }
                    else if (cache.Count > AppSettingUtils.GetInt("mobileCodeMaxCount", 30))
                    {
                        r.SetFail($"短信发送次数已达上限,请明天再来");
                    }
                    else
                    {
                        r.SetSuccess();
                    }
                }
                else
                {
                    r.SetSuccess();
                }
            }
            return r;
        }
        /// <summary>
        /// 短信发送
        /// </summary>
        /// <returns></returns>
        public override GeneralResult SendSms()
        {
            var r = base.SendSms();
            if (r.Success)
            {
                var cacheTime = (int)(DateTime.Today.AddDays(1) - DateTime.Now).TotalMinutes;// CountDown / 60;
                if (GlobalCache.Instance.IsSet(CacheKey))
                {
                    var cache = GlobalCache.Instance.Get<SmsModel>(CacheKey);
                    cache.Count++;
                    cache.ImgCode = ImgCode;
                    cache.Code = Code;
                    cache.Ticks =CommonUtils.ToUnixTimeStamp();
                    cache.Content=Content;
                    GlobalCache.Instance.Set(CacheKey, cache, cacheTime);
                }
                else
                {
                    this.Count = 1;
                    this.Ticks = CommonUtils.ToUnixTimeStamp();
                    GlobalCache.Instance.Set(CacheKey, this, cacheTime);
                }
                r.SetSuccess(new { CountDown });
            }
            return r;
        }

        /// <summary>
        /// 验证短信验证码
        /// </summary>
        /// <param name="mobile">手机号码</param>
        /// <param name="mobileCode">手机短信验证码</param>
        /// <param name="imgCode">图片验证码</param>
        /// <returns></returns>
        public static GeneralResult ValidateMobileCode(string mobile, string mobileCode, string imgCode="",string contentKey=DEFAULT_KEY)
        {
            var r = new GeneralResult();
            if (GlobalCache.Instance.IsSet($"{contentKey}_{mobile}"))
            {
                var cacheModel = GlobalCache.Instance.Get<SmsModel>($"{contentKey}_{mobile}");
              
                if (!string.IsNullOrWhiteSpace(imgCode)&&cacheModel.ImgCode != imgCode)
                {
                    r.SetFail($"图形验证码不正确");
                }
                else if (mobileCode != cacheModel.Code)
                {
                    r.SetFail($"短信验证码不正确");
                }
                else if (CommonUtils.ToUnixTimeStamp() - cacheModel.Ticks >= cacheModel.CountDown)
                {
                    r.SetFail($"短信验证码已过期");
                }
                else
                {
                    r.SetSuccess();
                }
                if (!r.Success)
                {
                    var curTickCount = CommonUtils.ToUnixTimeStamp();
                    Logger.Info($"mobile:{mobile},mobileCode:{mobileCode},UnixTimeStamp-Ticks={curTickCount}-{cacheModel.Ticks}={curTickCount - cacheModel.Ticks},{cacheModel.Serializer()}");
                }
            }
            else
            {
                r.SetFail($"短信验证码不正确或已过期");
            }

            return r;
        }
        /// <summary>
        /// 内容构建
        /// </summary>
        protected void ContentBuilder()
        {
            if (string.IsNullOrWhiteSpace(Content))
            {
                if (string.IsNullOrWhiteSpace(ContentKey))
                {
                    ContentKey = DEFAULT_KEY;
                }
                var contentFormat = AppSettingUtils.GetString(ContentKey, SmsTemplate[ContentKey]);
                Code = new ValidateCodeUtils().CreateRandomCode(6, ValidateCodeUtils.Digital);
                Content = string.Format(contentFormat, Code, CountDown / 60);
            }
        }
       

        #endregion
    }
}