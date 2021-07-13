using System;
using GGZY.Core.Extensions;
using GGZY.Core.Models;

namespace GGZY.Services.Infrastructure.Model
{
    /// <summary>
    /// 用户登录
    /// </summary>
    public class LoginModel
    {
        #region 属性

        public string Id { get; set; }

        /// <summary>
        /// 登录名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 密码（密文）
        /// </summary>
        public string Pwd { get; set; }

        public string RsaPwd { get; set; }
        public string TruePwd { get; set; }
        public string Md5Pwd { get; set; }
        /// <summary>
        /// 验证码
        /// </summary>
        public string Code { get; set; }

        public string client_id { get; set; }
        public string redirect_url { get; set; }

        #endregion

        #region 方法

        /// <summary>
        /// 登录校验
        /// </summary>
        /// <param name="checkCode">验证码校验</param>
        /// <param name="rsa2Md5">转RSA加密为MD5加密</param>
        /// <returns></returns>
        public GeneralResult Validate(Func<string, bool> checkCode, Func<LoginModel, bool> rsa2Md5)
        {
            var r = new GeneralResult();
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Pwd) || string.IsNullOrWhiteSpace(Code) || string.IsNullOrWhiteSpace(Id))
            {
                r.SetFailEx("参数错误",this.Serializer());
            }
            else if (!checkCode(Code))
            {
                r.SetFail("验证码错误");
            }
            else if (rsa2Md5!=null&&!rsa2Md5(this))
            {
                r.SetFail("会话过期");
            }
            else
            {
                r.SetSuccess();
            }
            return r;
        }

        #endregion
    }
}