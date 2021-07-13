using System;
using Aspose.Words.Lists;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Web;
using GGZY.Core.Extensions;

namespace GGZY.Core.Models
{
    public class UploadRes
    {
        [JsonProperty("result")]
        public bool Result { get; set; }
        [JsonProperty("msg")]
        public string Msg { get; set; }
        [JsonProperty("data")]
        public UploadResData Data { get; set; }

        public UEditorUploadRes ToUEditorUploadRes(string contentType="",int? contentLength=null)
        {
            var res = new UEditorUploadRes
            {
                Error = Msg,
                Original = Data?.Name,
                Title = Data?.Name,
                Url = Data?.Url,
                FullUrl = Data?.FullUrl,
                Md5 = Data?.Md5,
                State = Result ? UEditorUploadRes .SUCCESS: UEditorUploadRes.UNKNOWEROR,
                ContentType = contentType,
                ContentLength=contentLength
            };
            return res;
        }
    }

    public class UploadResData
    {
        private string _FULL_URL;

        [JsonProperty("new_id")]
        public string new_id { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("md5")]
        public string Md5 { get; set; }

        [JsonProperty("full_url")]
        public string FullUrl
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(_FULL_URL))
                {
                    if (!_FULL_URL.StartsWith("http", StringComparison.CurrentCultureIgnoreCase))
                    {
                        var applicationPath = HttpContext.Current?.Request.ApplicationPath?.TrimStart('/');//虚拟应用程序根路径
                        if (string.IsNullOrWhiteSpace(applicationPath))
                        {
                            _FULL_URL = $"/{applicationPath}/{_FULL_URL.TrimStart('/')}";
                        }
                    }
                }
                return _FULL_URL;
            }
            set => _FULL_URL = value;
        }

        [JsonIgnore]
        public string ContentType {
            get
            {
                var mime = FullUrl.ContentType();
                if (string.IsNullOrWhiteSpace(mime))
                {
                    mime = FileType.ContentType();
                }

                return mime;

            } }
        [JsonIgnore]
        public string FileType { get; set; }

    }

    /// <summary>
    /// 项目备案附件信息
    /// </summary>
    public class UploadResData_Review:UploadResData
    {
        public string AOBJTYPE { get; set; }
        /// <summary>
        /// 住建备案  1:招标条件备案 2:招标文件备案
        /// </summary>
        public decimal? CATEGORY { get; set; }

        public int AID { get; set; }
        /// <summary>
        /// 附件类型编码
        /// </summary>
        public string ATTFILE_TYPECODE { get; set; }
        /// <summary>
        /// 附件类型名称
        /// </summary>
        public string ATTFILE_TYPENAME { get; set; }
        /// <summary>
        /// 标段包编号
        /// </summary>
        public string BID_SECTION_CODE { get; set; }
        /// <summary>
        /// 是否完整，审核时使用
        /// </summary>
        public int IS_INTACT { get; set; }

        public string DESCRIPTION { get; set; }

    }
    /// <summary>
    /// 项目备案附件信息-客户端请求保存
    /// </summary>
    public class UploadResData_ReviewRequest : UploadResData
    {
        public string BID_SECTION_CODE { get; set; }
        public string TYPE { get; set; }
        public string TITLE { get; set; }
        public string DESCRIPTION { get; set; }
        public decimal? CATEGORY { get; set; }
        /// <summary>
        /// 是否完整，审核时使用
        /// </summary>
        public string IS_INTACT { get; set; }
        public List<UploadResData> ATTACHMENTS { get; set; }
    }
    public class UEditorUploadRes
    {
        public const string SUCCESS = "SUCCESS";
        public const string UNKNOWEROR = "UNKNOWERROR";
        [JsonProperty("error")]
        public string Error { get; set; }
        [JsonProperty("original")]
        public string Original { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("full_url")]
        public string FullUrl { get; set; }

        [JsonProperty("md5")]
        public string Md5 { get; set; }
        [JsonProperty("type")]
        public string ContentType { get; set; }
        [JsonProperty("size")]
        public int? ContentLength { get; set; }


    }
}

/*
{
  "result": true,
  "msg": "",
  "data": {
    "new_id": "5e8fed3ffaae153518695248",
    "id": "5e8fe71efaae15351869523f",
    "name": "abc.gif",
    "url": "/file/getcontent/5e8fe71efaae15351869523f.gif",
    "md5": "7267909A64C4573650F95B8543F818FB"
  }
}
 */
