using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using GGZY.Core.Extensions;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZY.Framework.Models;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model;

namespace GGZY.Framework.Controllers
{
    /// <summary>
    /// 文件
    /// </summary>
    [AllowAnonymous,PortalUnFilter]
    public class FileController : BaseController
    {
        /// <summary>
        /// 附件下载|预览
        /// </summary>
        /// <param name="id">附件唯一标识</param>
        /// <param name="pt">平台 监督平台 服务平台</param>
        /// <param name="fType">附件分类 系统附件 CDN附件 项目附件</param>
        /// <returns></returns>
        public ActionResult Content(string id, string pt, string fType)
        {
            var file = string.Empty;
            if (string.Compare(pt, "jd", StringComparison.CurrentCultureIgnoreCase) == 0)
            {
                file = Jd.CommonService.Attachment(id, fType);
            }
            else if (string.Compare(pt, "fw", StringComparison.CurrentCultureIgnoreCase) == 0)
            {
                file = Fw.CommonService.Attachment(id, fType);
            }
            else if (string.Compare(pt, "temp", StringComparison.CurrentCultureIgnoreCase) == 0)
            {
                file = Cache.Get<string>(id);
            }
            if (string.IsNullOrWhiteSpace(file))
            {
                file = "FILE_NOT_FUNND";
            }

            if (file.StartsWith("http"))
            {
                return Redirect(file);
            }
            if (string.IsNullOrWhiteSpace(file) || file == "FILE_NOT_FUNND" || !System.IO.File.Exists(file))
            {
                Logger.Error($"附件 /{pt}/{fType}/{id} 未找到 [{file}]");
            }
            string contentType = file.ContentType();
            return File(file, contentType);
        }
        /// <summary>
        /// 获取监督平台通用系统附件
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult JdSysContents(string id)
        {
            return Contents(id, "Jd", "Sys");
        }
        [NonAction]
        public ActionResult Contents(string id, string pt, string fType)
        {
            var r = new List<UploadResData>();
            if (string.Compare(pt, "jd", StringComparison.CurrentCultureIgnoreCase) == 0)
            {
                Jd.CommonService.Attachments(id, fType, true);
            }
            return JResult(r);
        }
        /// <summary>
        /// UEditor 文件上传
        /// </summary>
        /// <returns></returns>
        [PortalUnEncryptFilter]
        public ActionResult Upload()
        {
            var ueRes = new UploadRes();
            if (Request.Files.Count > 0)
            {
                var file = Request.Files[0];
                if (file != null)
                {
                    ueRes = FileHelper.Uploader.UploadStream(file.FileName, file.InputStream);
                  
                }
                else
                {
                    ueRes.Result = false;
                    ueRes.Msg = "上传文件为空";
                    Logger.Error("上传文件为空");
                }
            }
            else
            {
                ueRes.Result = false;
                ueRes.Msg = "上传文件为空";
                Logger.Error("上传文件为空");
            }

            return JResult(ueRes,false);
        }

        /// <summary>
        /// UEditor 文件上传
        /// </summary>
        /// <returns></returns>
        public ActionResult UEditorUpload()
        {
            var contentType = "text/html;charset=UTF-8;";//防止前端生成pre 标签
            string actionName = Request.QueryString["action"];
            if (!string.IsNullOrWhiteSpace(actionName)&&actionName == "config")
            {
                var config = Server.MapPath($"~/Infrastructure/Config/ueditor_config.json");
                var content = System.IO.File.ReadAllText(config);
                var configContent = content.Replace("common_upload_host", ConfigHelper.AppSettings.UploadHost);
                return Content(configContent, contentType);
            }
            else
            {
                var ueRes = new UEditorUploadRes();
                if (Request.Files.Count > 0)
                {
                    var file = Request.Files[0];
                    if (file != null)
                    {
                        var d = FileHelper.Uploader.UploadStream(file.FileName, file.InputStream);
                        ueRes = d.ToUEditorUploadRes(file.ContentType, file.ContentLength);
                        //return JResult(ueRes, false);

                    }
                }
                else
                {
                    ueRes.State = UEditorUploadRes.UNKNOWEROR;
                    ueRes.Error = "上传文件为空";
                }

                var content = ueRes.Serializer();
                return Content(content, contentType);
            }
            //return JResult(ueRes, false);
        }
    }
}