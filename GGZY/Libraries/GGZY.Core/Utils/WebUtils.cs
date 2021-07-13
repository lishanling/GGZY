using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web;
using GGZY.Core.Extensions;
using GGZY.Core.Log;
using GGZY.Core.Models;

namespace GGZY.Core.Utils
{
    public partial class WebUtils
    {
        private int _timeout = 100000;
        private string _contentType = "application/x-www-form-urlencoded;charset=utf-8";
        private bool _urlEncode = true;

        public WebUtils()
        {
            Headers = new Dictionary<string, string>();
        }
        public string ContentType
        {
            get => _contentType;
            set => _contentType = value;
        }

        public Dictionary<string, string> Headers { get; set; }

        public bool UrlEncode
        {
            get => _urlEncode;
            set => _urlEncode = value;
        }

        public bool DoLog { get; set; } = false;
        /// <summary>
        /// 请求与响应的超时时间
        /// </summary>
        public int Timeout
        {
            get { return _timeout; }
            set { _timeout = value; }
        }

        /// <summary>
        /// 执行HTTP POST请求。
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="parameters">请求参数</param>
        /// <returns>HTTP响应</returns>
        public String DoPost(String url, IDictionary<String, String> parameters)
        {
            HttpWebRequest req = GetWebRequest(url, "POST");
            req.ContentType = ContentType;

            Byte[] postData = Encoding.UTF8.GetBytes(BuildQuery(parameters, UrlEncode));
            Stream reqStream = req.GetRequestStream();
            reqStream.Write(postData, 0, postData.Length);
            reqStream.Close();

            HttpWebResponse rsp = (HttpWebResponse)req.GetResponse();
            Encoding encoding = Encoding.UTF8;
            if (rsp != null && !string.IsNullOrWhiteSpace(rsp.CharacterSet))
            {
                encoding = Encoding.GetEncoding(rsp.CharacterSet);
            }

            return GetResponseAsString(rsp, encoding);
        }

        public String DoPost(String url, string inputStream)
        {
            HttpWebRequest req = GetWebRequest(url, "POST");
            req.ContentType = ContentType;

            Byte[] postData = Encoding.UTF8.GetBytes(inputStream);
            Stream reqStream = req.GetRequestStream();
            reqStream.Write(postData, 0, postData.Length);
            reqStream.Close();

            HttpWebResponse rsp = (HttpWebResponse)req.GetResponse();
            Encoding encoding = Encoding.UTF8;
            if (rsp != null && !string.IsNullOrWhiteSpace(rsp.CharacterSet))
            {
                encoding = Encoding.GetEncoding(rsp.CharacterSet);
            }

            return GetResponseAsString(rsp, encoding);
        }

        public T DoPost<T>(String url, string inputStream)
        {
            HttpWebRequest req = GetWebRequest(url, "POST");
            req.ContentType = ContentType;

            Byte[] postData = Encoding.UTF8.GetBytes(inputStream);
            Stream reqStream = req.GetRequestStream();
            reqStream.Write(postData, 0, postData.Length);
            reqStream.Close();

            HttpWebResponse rsp = (HttpWebResponse)req.GetResponse();
            Encoding encoding = Encoding.UTF8;
            if (rsp != null && !string.IsNullOrWhiteSpace(rsp.CharacterSet))
            {
                encoding = Encoding.GetEncoding(rsp.CharacterSet);
            }

            var rspStr = GetResponseAsString(rsp, encoding);
            return rspStr.DeserializeObject<T>();
        }
        /// <summary>
        /// 执行带文件上传的HTTP POST请求。
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="textParams">请求文本参数</param>
        /// <param name="fileParams">请求文件参数</param>
        /// <returns>HTTP响应</returns>
        public string DoPost(string url, IDictionary<string, string> textParams, IDictionary<string, FileItem> fileParams)
        {
            // 如果没有文件参数，则走普通POST请求
            if (fileParams == null || fileParams.Count == 0)
            {
                return DoPost(url, textParams);
            }

            string boundary = DateTime.Now.Ticks.ToString("X"); // 随机分隔线

            HttpWebRequest req = GetWebRequest(url, "POST");
            req.ContentType = "multipart/form-data;charset=utf-8;boundary=" + boundary;

            Stream reqStream = req.GetRequestStream();
            byte[] itemBoundaryBytes = Encoding.UTF8.GetBytes("\r\n--" + boundary + "\r\n");
            byte[] endBoundaryBytes = Encoding.UTF8.GetBytes("\r\n--" + boundary + "--\r\n");

            if (textParams != null)
            {
                // 组装文本请求参数
                string textTemplate = "Content-Disposition:form-data;name=\"{0}\"\r\nContent-Type:text/plain\r\n\r\n{1}";
                using (var textEnum = textParams.GetEnumerator())
                {
                    while (textEnum.MoveNext())
                    {
                        string textEntry = string.Format(textTemplate, textEnum.Current.Key, textEnum.Current.Value);
                        byte[] itemBytes = Encoding.UTF8.GetBytes(textEntry);
                        reqStream.Write(itemBoundaryBytes, 0, itemBoundaryBytes.Length);
                        reqStream.Write(itemBytes, 0, itemBytes.Length);
                    }
                }
            }

            if (fileParams != null)
            {
                // 组装文件请求参数
                string fileTemplate = "Content-Disposition:form-data;name=\"{0}\";filename=\"{1}\"\r\nContent-Type:{2}\r\n\r\n";
                using (IEnumerator<KeyValuePair<string, FileItem>> fileEnum = fileParams.GetEnumerator())
                {
                    while (fileEnum.MoveNext())
                    {
                        string key = fileEnum.Current.Key;
                        FileItem fileItem = fileEnum.Current.Value;
                        string fileEntry = string.Format(fileTemplate, key, fileItem.GetFileName(), fileItem.GetMimeType());
                        byte[] itemBytes = Encoding.UTF8.GetBytes(fileEntry);
                        reqStream.Write(itemBoundaryBytes, 0, itemBoundaryBytes.Length);
                        reqStream.Write(itemBytes, 0, itemBytes.Length);

                        byte[] fileBytes = fileItem.GetContent();
                        reqStream.Write(fileBytes, 0, fileBytes.Length);
                    }
                }

            }


            reqStream.Write(endBoundaryBytes, 0, endBoundaryBytes.Length);
            reqStream.Close();

            HttpWebResponse rsp = (HttpWebResponse)req.GetResponse();
            Encoding encoding = Encoding.GetEncoding(rsp.CharacterSet);
            return GetResponseAsString(rsp, encoding);
        }

        /// <summary>
        /// 执行HTTP GET请求。
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="parameters">请求参数</param>
        /// <returns>HTTP响应</returns>
        public String DoGet(String url, IDictionary<String, String> parameters)
        {
            if (parameters != null && parameters.Count > 0)
            {
                if (url.Contains("?"))
                {
                    url = url + "&" + BuildQuery(parameters, UrlEncode);
                }
                else
                {
                    url = url + "?" + BuildQuery(parameters, UrlEncode);
                }
            }

            Console.WriteLine(url);
            HttpWebRequest req = GetWebRequest(url, "GET");
            req.ContentType = ContentType;

            HttpWebResponse rsp = (HttpWebResponse)req.GetResponse();
            Encoding encoding = string.IsNullOrWhiteSpace(rsp?.CharacterSet) ? Encoding.UTF8 : Encoding.GetEncoding(rsp.CharacterSet);
            return GetResponseAsString(rsp, encoding);
        }

        public String DoGet(String url, String refUrl, CookieContainer cookies, IDictionary<String, String> parameters)
        {
            if (parameters != null && parameters.Count > 0)
            {
                if (url.Contains("?"))
                {
                    url = url + "&" + BuildQuery(parameters, UrlEncode);
                }
                else
                {
                    url = url + "?" + BuildQuery(parameters, UrlEncode);
                }
            }

            HttpWebRequest req = GetWebRequest(url, "GET");
            req.ContentType = ContentType;
            HttpWebResponse rsp = (HttpWebResponse)req.GetResponse();
            Encoding encoding = Encoding.GetEncoding(rsp.CharacterSet);
            return GetResponseAsString(rsp, encoding);
        }
        /// <summary>
        /// 文件下载
        /// </summary>
        /// <param name="url">下载地址</param>
        /// <param name="saveDir">保存本地路径</param>
        /// <param name="parameters">下载参数，可空</param>
        public string Download(string url, string saveDir, IDictionary<String, String> parameters = null)
        {
            string saveFileFullPath = string.Empty;
            HttpWebResponse rsp = null;
            try
            {
                if (parameters != null && parameters.Count > 0)
                {
                    if (url.Contains("?"))
                    {
                        url = url + "&" + BuildQuery(parameters, UrlEncode);
                    }
                    else
                    {
                        url = url + "?" + BuildQuery(parameters, UrlEncode);
                    }
                }
                HttpWebRequest req = GetWebRequest(url, "GET");
                req.ContentType = ContentType;
                rsp = (HttpWebResponse)req.GetResponse();
                if (!Directory.Exists(saveDir))
                {
                    Directory.CreateDirectory(saveDir);
                }
                //application/zip;charset=UTF-8
                var extension = rsp.ContentType.Split(';')[0].Split('/').LastOrDefault();
                saveFileFullPath = $"{saveDir}/{Guid.NewGuid():N}.{extension}";
                // 以字符流的方式读取HTTP响应
                using (FileStream fs = new FileStream(saveFileFullPath, FileMode.Create))
                {
                    var stream = rsp.GetResponseStream();

                    byte[] buf = new Byte[stream.Length];
                    stream.Read(buf, 0, buf.Length);
                    stream.Seek(0, SeekOrigin.Begin);
                    fs.Write(buf, 0, buf.Length);
                    fs.Close();
                }

            }
#pragma warning disable CS0168 // 声明了变量“e”，但从未使用过
            catch (Exception e)
#pragma warning restore CS0168 // 声明了变量“e”，但从未使用过
            {
                Logger.Error($"文件下载失败");
            }
            finally
            {
                // 释放资源
                rsp?.Close();
            }

            return saveFileFullPath;
        }

        public static string Download(string address, string saveDir)
        {
            if (!Directory.Exists(saveDir))
            {
                Directory.CreateDirectory(saveDir);
            }
            var sourceFileName = $"{saveDir}/{Guid.NewGuid():N}";
            WebClient webClient = new WebClient();
            var filenameTag = "filename";
            webClient.DownloadFile(address, sourceFileName);
            var contentDisposition = webClient.ResponseHeaders["Content-Disposition"];
            if (!string.IsNullOrWhiteSpace(contentDisposition))
            //if(address.LastIndexOf(".") > 0)
            {
                var idx = contentDisposition.LastIndexOf("=", StringComparison.CurrentCultureIgnoreCase) + 1;
                if (idx > -1)
                {
                    var filename = HttpUtility.UrlDecode(contentDisposition.Substring(idx).Replace(filenameTag, "").Replace("\"", ""));
                    var destFileName = $"{saveDir}/{filename}";
                    if (File.Exists(destFileName))
                    {
                        File.Delete(destFileName);
                    }
                    Console.WriteLine(sourceFileName.Md5HashFromFile());
                    File.Move(sourceFileName, destFileName);
                    Console.WriteLine(destFileName.Md5HashFromFile());
                    return destFileName;
                }
            }
            else
            {
                var destFileName = $"{sourceFileName}{address.Extension()}";
                File.Move(sourceFileName, destFileName);
                return destFileName;

            }
            return sourceFileName;
        }
        /// <summary>
        /// 下载ofd电子保函专用，以订单号为文件名，后缀名固定为ofd，存在的话根据isdelete是否删除
        /// </summary>
        /// <param name="address"></param>
        /// <param name="saveDir"></param>
        /// <param name="fileName"></param>
        /// <param name="isDelete"></param>
        /// <returns></returns>
        public static string DownloadOfd(string address, string saveDir, string fileName, bool isDelete = true)
        {
            if (!Directory.Exists(saveDir))
            {
                Directory.CreateDirectory(saveDir);
            }
            var sourceFileName = $"{saveDir}/{fileName}";
            if (File.Exists(sourceFileName))
            {
                if (isDelete)
                {
                    File.Delete(sourceFileName);
                }
                else
                {
                    return sourceFileName;
                }
            }

            if (address.StartsWith("https"))
            {
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                WebRequest wrq = WebRequest.Create(address);
                wrq.PreAuthenticate = true;
                WebResponse wrs = wrq.GetResponse();
                Stream st = wrs.GetResponseStream(); //从WEB请求创建流（读）  
                Stream so = new System.IO.FileStream(sourceFileName, System.IO.FileMode.Append, System.IO.FileAccess.Write, System.IO.FileShare.Write); //创建文件流（写）    
                long totalDownloadedByte = 0; //下载文件大小    
                byte[] by = new byte[1024];
                int osize = st.Read(by, 0, (int)by.Length); //读流    
                while (osize > 0)
                {
                    totalDownloadedByte += osize; //更新文件大小    
                    so.Write(by, 0, osize); //写流  
                    osize = st.Read(by, 0, (int)by.Length); //读流    
                }
                so.Close(); //关闭流    
                st.Close(); //关闭流    
            }
            else
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile(address, sourceFileName);
            }
            return sourceFileName;

        }

        public HttpWebRequest GetWebRequest(String url, String method)
        {
            if (DoLog)
            {
                Logger.Debug($"Url:{url},Method:{method}");
            }
            HttpWebRequest req;
            if (url.ToLower().StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Ssl3;
                req = WebRequest.Create(url) as HttpWebRequest;
                req.ProtocolVersion = HttpVersion.Version10;

            }
            else
            {
                req = WebRequest.Create(url) as HttpWebRequest;
            }
            req.ServicePoint.Expect100Continue = false;
            req.Method = method;
            req.KeepAlive = true;
            req.UserAgent = "Public Resources Trading Electronic Public Service Platform  DOTNET V1.0 By Zhou";
            req.Timeout = _timeout;
            foreach (var header in Headers)
            {
                req.Headers.Add(header.Key, header.Value);
            }
            return req;
        }
        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true; //总是接受 
        }
        /// <summary>
        /// 把响应流转换为文本。
        /// </summary>
        /// <param name="rsp">响应流对象</param>
        /// <param name="encoding">编码方式</param>
        /// <returns>响应文本</returns>
        public String GetResponseAsString(HttpWebResponse rsp, Encoding encoding)
        {
            Stream stream = null;
            StreamReader reader = null;

            try
            {
                // 以字符流的方式读取HTTP响应
                stream = rsp.GetResponseStream();
                reader = new StreamReader(stream, encoding);
                var result = reader.ReadToEnd();
                if (DoLog)
                {
                    Logger.Debug($"Response:{result}");
                }

                return result;
            }
            finally
            {
                // 释放资源
                if (reader != null) reader.Close();
                if (stream != null) stream.Close();
                if (rsp != null) rsp.Close();
            }
        }

        /// <summary>
        /// 组装GET请求URL。
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="parameters">请求参数</param>
        /// <returns>带参数的GET请求URL</returns>
        public String BuildGetUrl(String url, IDictionary<String, String> parameters)
        {
            if (parameters != null && parameters.Count > 0)
            {
                if (url.Contains("?"))
                {
                    url = url + "&" + BuildQuery(parameters, UrlEncode);
                }
                else
                {
                    url = url + "?" + BuildQuery(parameters, UrlEncode);
                }
            }
            return url;
        }

        /// <summary>
        /// 组装普通文本请求参数。
        /// </summary>
        /// <param name="parameters">Key-Value形式请求参数字典</param>
        /// <param name="urlEncode"></param>
        /// <returns>URL编码后的请求数据</returns>
        public String BuildQuery(IDictionary<String, String> parameters, bool urlEncode)
        {
            StringBuilder postData = new StringBuilder();
            bool hasParam = false;

            IEnumerator<KeyValuePair<String, String>> dem = parameters.GetEnumerator();
            while (dem.MoveNext())
            {
                String name = dem.Current.Key;
                String value = dem.Current.Value;
                // 忽略参数名或参数值为空的参数
                if (!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(value))
                {
                    if (hasParam)
                    {
                        postData.Append("&");
                    }

                    postData.Append(name);
                    postData.Append("=");
                    if (urlEncode)
                    {
                        var encodeValue = HttpUtility.UrlEncode(value);//.Replace("+", "%2B");
                        postData.Append(encodeValue);
                    }
                    else
                    {
                        postData.Append(value);
                    }

                    hasParam = true;
                }
            }
            var query = postData.ToString();
            if (DoLog)
            {
                Logger.Debug($"Parameters:{query}");
            }

            return query;
        }

        #region 获取客户端相关信息
        /// <summary>
        /// 获取客户端提交的Form Data 以及 Querystring
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public Dictionary<string, string> GetRequestData(HttpContext context)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            for (int i = 0; i < context.Request.Form.AllKeys.Length; i++)
            {
                if (!dict.ContainsKey(context.Request.Form.AllKeys[i]))
                {
                    dict.Add(context.Request.Form.AllKeys[i], context.Request.Form[i].ToString().Trim());
                    continue;
                }
                dict[context.Request.Form.AllKeys[i]] = context.Request.Form[i].ToString().Trim();
            }

            for (int i = 0; i < context.Request.QueryString.AllKeys.Length; i++)
            {
                if (!dict.ContainsKey(context.Request.Form.AllKeys[i]))
                {
                    dict.Add(context.Request.QueryString.AllKeys[i], context.Request.QueryString[i].ToString().Trim());
                    continue;
                }
                dict[context.Request.QueryString.AllKeys[i]] = context.Request.QueryString[i].ToString().Trim();
            }
            return dict;
        }
        #endregion

        #region REST
        /// <summary>
        /// RESTFUL 用POST Method 发起GET请求 坑
        /// </summary>
        /// <param name="url"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public String RestGetByPost(string url, IDictionary<string, string> parameters)
        {

            if (parameters != null && parameters.Count > 0)
            {
                if (url.Contains("?"))
                {
                    url = url + "&" + BuildQuery(parameters, UrlEncode);
                }
                else
                {
                    url = url + "?" + BuildQuery(parameters, UrlEncode);
                }
            }
            HttpWebRequest req = GetWebRequest(url, "POST");
            req.ContentType = ContentType;

            //Byte[] postData = Encoding.UTF8.GetBytes(BuildQuery(parameters));
            //Stream reqStream = req.GetRequestStream();
            //reqStream.Write(postData, 0, postData.Length);
            //reqStream.Close();

            HttpWebResponse rsp = (HttpWebResponse)req.GetResponse();
            Encoding encoding = Encoding.GetEncoding(rsp.CharacterSet);
            return GetResponseAsString(rsp, encoding);
        }
        #endregion
    }
}