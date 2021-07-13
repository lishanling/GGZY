using System;
using System.Collections.Generic;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace GGZY.Core.Sms
{
    /// <summary>
    /// Mobile Content 必填
    /// </summary>
    public class SmsCommon : ISms
    {
        #region Config

        protected virtual string Key => AppSettingUtils.GetString("sms_appid", "FJGGFW");
        protected virtual string SmsServerUrl => AppSettingUtils.GetString("sms_server_url", "http://114.115.162.77/Api/Send");
        

        #endregion

        #region Properties

        /// <summary>
        /// 手机号
        /// </summary>
        public virtual string Mobile { get; set; }
        /// <summary>
        /// 短信内容
        /// </summary>
        public virtual string Content { get; set; }

        /// <summary>
        /// 内容前缀
        /// </summary>
        public virtual string Prefix { get; set; } = "【行政监督平台】";
        /// <summary>
        /// 内容后缀
        /// </summary>
        public virtual string Suffix { get; set; }
        /// <summary>
        /// 图片验证码
        /// </summary>
        public virtual string ImgCode { get; set; }

        #endregion

        #region 方法
        /// <summary>
        /// 校验
        /// </summary>
        /// <param name="checkImgCodeFun">验证图片验证码</param>
        /// <param name="checkContentFun">验证短信内容</param>
        /// <returns></returns>
        public virtual GeneralResult Validate(Func<string, bool> checkImgCodeFun = null,
            Func<string, bool> checkContentFun = null)
        {
            var r = new GeneralResult();
            var checkImg = checkImgCodeFun?.Invoke(ImgCode);
            var checkContent = checkContentFun?.Invoke(Content);
            if (string.IsNullOrWhiteSpace(Mobile) || string.IsNullOrWhiteSpace(Content))
            {
                r.SetFail($"参数错误");
            }
            else if (checkImg.HasValue && !checkImg.Value)
            {
                r.SetFail($"图片验证码不正确");
            }
            else if (checkContent.HasValue && !checkContent.Value)
            {
                r.SetFail($"内容含有敏感信息，发送失败");
            }
            else
            {
                r.SetSuccess();
            }
            return r;
        }
        /// <summary>
        /// 发送短信
        /// </summary>
        /// <returns></returns>
        public virtual GeneralResult SendSms()
        {
            var sendResult = new GeneralResult();
            try
            {
                if (Content.IndexOf("【",StringComparison.CurrentCulture) == -1)
                {
                    Content = $"{Prefix}{Content}{Suffix}";
                }
                var dic = new Dictionary<string, string>
                {
                    {"AppId", Key},
                    {"Phone", Mobile},
                    {"Content", Content},
                    {"callback", ""},
                };
                var body = new WebUtils().DoPost(SmsServerUrl, dic);
                var rsp = body.DeserializeObject<SendResult>();
                if (rsp.Success)
                {
                    sendResult.SetSuccess(rsp.Data, rsp.Msg);
                }
                else
                {
                    sendResult.SetFail(rsp.Msg);
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

    public class SendResult
    {
        [JsonProperty("result")]
        public bool Success { get; set; }
        [JsonProperty("msg")]
        public string Msg { get; set; }
        [JsonProperty("json")]
        public Dictionary<string, string> Data { get; set; }
    }
}