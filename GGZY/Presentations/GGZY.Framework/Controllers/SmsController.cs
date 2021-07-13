using System.Web.Mvc;
using GGZY.Services.Infrastructure;
using GGZY.Services.Infrastructure.Model;

namespace GGZY.Framework.Controllers
{
    /// <summary>
    /// 短信
    /// </summary>
    [AllowAnonymous]
    public class SmsController:BaseController
    {
        /// <summary>
        /// 短信验证码发送
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult SendCode(SmsModel model)
        {
            var r = model.Validate(CheckCode);
            if (r.Success)
            {
                r = model.SendSms();
            }
            return JResult(r);
        }
    }
}