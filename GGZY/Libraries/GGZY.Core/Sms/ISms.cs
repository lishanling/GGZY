using System;
using GGZY.Core.Models;

namespace GGZY.Core.Sms
{
    public interface ISms
    {
        #region Property


        /// <summary>
        /// 手机号
        /// </summary>
         string Mobile { get; set; }
        /// <summary>
        /// 短信内容
        /// </summary>
         string Content { get; set; }
        /// <summary>
        /// 内容前缀
        /// </summary>
         string Prefix { get; set; }
        /// <summary>
        /// 内容后缀
        /// </summary>
         string Suffix { get; set; }

        /// <summary>
        /// 图片验证码
        /// </summary>
        string ImgCode { get; set; }

        #endregion

        #region Method
        /// <summary>
        /// 校验
        /// </summary>
        /// <param name="checkImgCodeFun">验证图片验证码</param>
        /// <param name="checkContentFun">验证短信内容</param>
        /// <returns></returns>
        GeneralResult Validate(Func<string, bool> checkImgCodeFun = null,
            Func<string, bool> checkContentFun = null);

        /// <summary>
        /// 发送短信
        /// </summary>
        /// <returns></returns>
        GeneralResult SendSms();



        #endregion

    }
}