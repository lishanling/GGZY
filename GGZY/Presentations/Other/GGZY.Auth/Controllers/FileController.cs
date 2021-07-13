using System;
using System.IO;
using System.Web.Mvc;
using GGZY.Core.Cache;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Framework.Controllers;
using GGZY.Services.Infrastructure.Model;

namespace GGZY.Auth.Controllers
{
    [AllowAnonymous]
    public class FileController:BaseController
    {
        public ActionResult Upload(UploadModel model)
        {
            var r = new GeneralResult();
            var file = Request.Files[0];
            if (file == null)
            {
                r.SetFail("请选择上传文件");
            }
            else
            {
            }
            return JResult(r);
        }
        public ActionResult Upload()
        {
            var result = new GeneralResult();

            var file = Request.Files[0];
            if (file == null)
            {
                result.SetFail("请选择上传文件");
            }
            else
            {
                var key = Guid.NewGuid().ToString();
                var fileId = Cache.Get<string>(key, () =>
                {
                    string temp = AppSettingUtils.GetString("temp", @"D:\EpFileDataToolSource\PublicServicePlatform");
                    var tempPath = $"{temp}/{DateTime.Today:yyyyMMdd}";
                    if (!Directory.Exists(tempPath)) //本地服务器是否存在给定路径？不存在，创建
                    {
                        Directory.CreateDirectory(tempPath);
                    }

                    var fileName = $"{key}_{file.FileName}";
                    var fullPath = $"{tempPath}/{fileName}";
                    file.SaveAs(fullPath); //保存本地文件
                    return fullPath;
                });

                result.SetSuccess(new { FileId = key });
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        
    }
}