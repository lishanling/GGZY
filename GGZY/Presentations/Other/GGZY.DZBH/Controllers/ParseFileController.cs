using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GGZY.Core.Cache;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Framework.Controllers;
using GGZY.Services.Base;

namespace GGZY.DZBH.Controllers
{
    public class ParseFileController : BaseController
    {
        // GET: ParseFile
        [AllowAnonymous]
        public ActionResult Parse(string url, string path, string orderId, string validateCode)
        {

            if (!string.IsNullOrEmpty(url) && !url.StartsWith("http"))
            {
                url = AppSettingUtils.GetString("FileServerUrl") + url;
            }
            var result = Cache.Get($"{url};{path}:{orderId}",
                () => ServicesFactory.GGZYFW.ParseFileService.GetFileAndParse(url, path, orderId, validateCode));
            return JResult(result);

        }
        [AllowAnonymous]
        public ActionResult GetSmsCode(string orderId, string imgCode)
        {

            bool r = CheckCode(imgCode);
            if (r)
            {
                return JResult(ServicesFactory.GGZYFW.ParseFileService.GetSmsCode(orderId));
            }
            else
            {
                var result = new GeneralResult();
                result.SetFail("图片验证码错误");
                return JResult(result);
            }

        }

    }
}