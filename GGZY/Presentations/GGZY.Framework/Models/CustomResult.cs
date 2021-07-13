using System;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Core.Utils;

namespace GGZY.Framework.Models
{
    /// <summary>
    /// 自定义返回结果
    /// </summary>
    public class CustomResult : ActionResult
    {
        /// <summary>
        /// 当前响应HTTP MIME类型
        /// </summary>
        public string ContentType { get; set; } = "application/json";
        /// <summary>
        /// 当前响应的内容编码
        /// </summary>
        public Encoding ContentEncoding { get; set; } = Encoding.UTF8;
        /// <summary>
        /// 数据对象实体
        /// </summary>
        public object Data { get; set; }
        /// <summary>
        /// 使用通用结构返回结果对象
        /// </summary>
        public bool UseGeneralResult { get; set; } = true;
        /// <summary>
        /// 默认返回值 成功
        /// </summary>
        public bool Success { get; set; } = true;

        private string SKey { get; set; }

        private string Iv { get; set; }
        /// <summary>
        /// 执行返回结果
        /// </summary>
        /// <param name="context"></param>
        public override void ExecuteResult(ControllerContext context)
        {
            // context.HttpContext.Request.

            HttpResponseBase response = context.HttpContext.Response;
            response.ContentType = ContentType;
            response.ContentEncoding = ContentEncoding;
            response.Headers.Remove("Server");
            response.Headers.Remove("X-AspNet-Version");
            response.Headers.Remove("X-AspNetMvc-Version");
            response.Headers.Remove("X-Powered-By");
            SKey = context.Controller.TempData["SKey"]?.ToString();
            Iv = context.Controller.TempData["Iv"]?.ToString();
            string jsonStr = string.Empty;
            if (UseGeneralResult)
            {
                var result = new GeneralResult();
                if (Data is Exception e)
                {
                    result.SetException(e.Message, e);
                }
                else if (Data is GeneralResult generalResult)
                {
                    result = generalResult;
                }
                else if (!Success && Data is string msg)
                {
                    result.SetFail(msg);
                }
                else
                {
                    result.SetSuccess(Data);
                }
#if !DEBUG
                if (result.Success && !string.IsNullOrWhiteSpace(SKey)&&!string.IsNullOrWhiteSpace(Iv))
                {
                    var source = result.Data.Serializer();
                    var encode = AESEncryptUtils.EncryptByAES(source, SKey,Iv);
                    result.SetSuccess(encode);
                }
#endif
                jsonStr = result.Serializer();
                //response.Write(jsonStr);
            }
            else
            {
                jsonStr = Data.Serializer();
#if !DEBUG
                if (!string.IsNullOrWhiteSpace(SKey) && !string.IsNullOrWhiteSpace(Iv))
                {
                    jsonStr = AESEncryptUtils.EncryptByAES(jsonStr, SKey, Iv);
                }
#endif

            }
            response.Headers.Add("content-encoding", "gzip");
            using (var stream = new GZipStream(response.OutputStream, CompressionMode.Compress))
            {
                byte[] jsonBuffer = Encoding.UTF8.GetBytes(jsonStr);
                stream.Write(jsonBuffer, 0, jsonBuffer.Length);
                //stream.Close();
            }

            //response.Write(jsonStr);
        }
    }
}