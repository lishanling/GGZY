using System.Collections.Generic;
using System.IO;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Core.Utils;

namespace GGZY.Services.Infrastructure.Helper
{
    public class FileHelper
    {
        /// <summary>
        /// 文件上传器
        /// </summary>
        public static UploaderModel Uploader => UploaderModel.Instance;

    }

    public class UploaderModel
    {
        private static UploaderModel _instance;
        /// <summary>
        /// 文件上传器
        /// </summary>
        public static UploaderModel Instance => _instance ?? (_instance = new UploaderModel());

        private readonly WebUtils webUtils = new WebUtils();
        private readonly string uploadUrl = ConfigHelper.AppSettings.UploadUrl;

        /// <summary>
        /// 将文件（流信息）上传到统一文件服务器
        /// </summary>
        /// <param name="fileName">文件名称,如 a.jpg</param>
        /// <param name="stream">文件流</param>
        /// <returns></returns>
        public UploadRes UploadStream(string fileName, Stream stream)
        {
            var res = webUtils.DoPost(uploadUrl, null, new Dictionary<string, FileItem>
            {
                {"file",new FileItem(fileName, stream) }
            });
            var r= res.DeserializeObject<UploadRes>();
            if (r.Result)
            {
                r.Data.FullUrl = $"{ConfigHelper.AppSettings.UploadHost}{r.Data.Url}";
            }

            return r;
        }
        /// <summary>
        /// 将文件（路径）上传到统一文件服务器
        /// </summary>
        /// <param name="fullPath">文件全路径 如 C:\a.jpg</param>
        /// <param name="removeLocal">上传成功后 是否删除本地文件 true 删除 false 不删除 默认false</param>
        /// <returns></returns>
        public UploadRes UploadFilePath(string fullPath, bool removeLocal = false)
        {
            var res = webUtils.DoPost(uploadUrl, null, new Dictionary<string, FileItem>
            {
                {"file",new FileItem(fullPath) }
            });
            var r = res.DeserializeObject<UploadRes>();
            if (r.Result)
            {
                r.Data.FullUrl = $"{ConfigHelper.AppSettings.UploadHost}{r.Data.Url}";
                if (removeLocal)
                {
                    File.Delete(fullPath);
                }
            }
            return r;
        }
        /// <summary>
        /// 将文件（字节信息）上传到统一文件服务器
        /// </summary>
        /// <param name="fileName">文件名称</param>
        /// <param name="content">文件字节信息</param>
        /// <returns></returns>
        public UploadRes UploadContent(string fileName, byte[] content)
        {
            var res = webUtils.DoPost(uploadUrl, null, new Dictionary<string, FileItem>
            {
                {"file",new FileItem(fileName,content) }
            });
            var r = res.DeserializeObject<UploadRes>();
            if (r.Result)
            {
                r.Data.FullUrl = $"{ConfigHelper.AppSettings.UploadHost}{r.Data.Url}";
            }
            return r;
        }
    }
}