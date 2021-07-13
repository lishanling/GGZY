using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GGZY.Core.Models
{
    public class Visit
    {
        private string _TEXT;
        /// <summary>
        /// 缓存时间 到明天0点
        /// </summary>
        public int CacheTime = Convert.ToInt32((DateTime.Today.AddDays(1) - DateTime.Now).TotalMinutes);

        /// <summary>
        /// 访问次数
        /// </summary>
        public int VisitCount { get; set; }
        /// <summary>
        /// 访问时间 毫秒
        /// </summary>
        public Int64 VisitTickCount { get; set; }
        /// <summary>
        /// ip地址
        /// </summary>
        [JsonIgnore]
        public string IpAddress
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_TEXT))
                {

                    if (HttpContext.Current == null)
                    {
                        return _TEXT;
                    }
                    var forwardedHttpHeader = AppSettingUtils.GetString("ForwardedHTTPheader", "HTTP_X_FORWARDED_FOR,REMOTE_ADDR,HTTP_X_REAL_IP,X-Real-IP,X-FORWARDED-FOR");
                    var forwardedHttpHeaders = forwardedHttpHeader.Split(',').Distinct().ToList();
                    string xff = HttpContext.Current.Request.ServerVariables.AllKeys
                        .Where(x =>
                            (forwardedHttpHeaders.Exists(f => f.Equals(x, StringComparison.InvariantCultureIgnoreCase)) && !string.IsNullOrWhiteSpace(HttpContext.Current.Request.ServerVariables[x])))
                        .Select(k => HttpContext.Current.Request.ServerVariables[k])
                        .FirstOrDefault();
                    if (string.IsNullOrWhiteSpace(xff))
                    {
                        xff = HttpContext.Current.Request.Headers.AllKeys
                            .Where(x =>
                                (forwardedHttpHeaders.Exists(f => f.Equals(x, StringComparison.InvariantCultureIgnoreCase)) && !string.IsNullOrWhiteSpace(HttpContext.Current.Request.Headers[x])))
                            .Select(k => HttpContext.Current.Request.Headers[k])
                            .FirstOrDefault();
                    }

                    if (!string.IsNullOrWhiteSpace(xff))
                    {
                        _TEXT = xff.Split(',').FirstOrDefault();
                    }
                    if (string.IsNullOrWhiteSpace(_TEXT))
                    {
                        _TEXT = HttpContext.Current.Request.UserHostAddress;
                    }
                    //some validation
                    if (_TEXT == "::1")
                        _TEXT = "127.0.0.1";
                    //remove port
                    if (!String.IsNullOrWhiteSpace(_TEXT))
                    {
                        int index = _TEXT.IndexOf(":", StringComparison.InvariantCultureIgnoreCase);
                        if (index > 0)
                            _TEXT = _TEXT.Substring(0, index);
                    }
                }
                return _TEXT;
            }
            set => _TEXT = value;
        }

        private string _InputStream;

        private string _signRequest;
        [JsonIgnore]
        public string InputStream
        {
            get
            {
                if (string.IsNullOrWhiteSpace(this._InputStream))
                    this._InputStream = HttpContext.Current.Request.InputStream.StreamToString(false);
                return this._InputStream;
            }
            set { _InputStream = value; }
        }
        /// <summary>
        /// 参数签名
        /// </summary>
        [JsonIgnore]
        public string SignRequest
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_signRequest))
                {

                    #region 计算参数签名值
                    //var dic = HttpContext.Current.Request.Params.AllKeys.Where(key => !string.IsNullOrWhiteSpace(HttpContext.Current.Request.Params[key])
                    //                                              && !key.Equals("pagesize", StringComparison.CurrentCultureIgnoreCase)
                    //                                              && !key.Equals("pageno", StringComparison.CurrentCultureIgnoreCase))
                    //    .ToDictionary(c => c, c => HttpContext.Current.Request.Params[c]);
                    var dic =new Dictionary<string, string>();
                    try
                    {
                        if (!string.IsNullOrWhiteSpace(InputStream))
                        {
                            JObject jObject = JObject.Parse(InputStream);
                            foreach (var item in jObject)
                            {
                                if (!dic.ContainsKey(item.Key) && !item.Key.Equals("pagesize", StringComparison.CurrentCultureIgnoreCase) && !item.Key.Equals("pageno", StringComparison.CurrentCultureIgnoreCase))
                                {
                                    dic.Add(item.Key, item.Value?.ToString());
                                }
                            }
                        }
                    }
#pragma warning disable CS0168 // 声明了变量“e”，但从未使用过
                    catch (Exception e)
#pragma warning restore CS0168 // 声明了变量“e”，但从未使用过
                    {

                    }

                    _signRequest = CommonUtils.SignRequest(dic, "Request");
                    #endregion
                }
                return _signRequest;
            }
            set { _signRequest = value; }
        }
        /// <summary>
        /// 第一次访问时间戳
        /// </summary>
        public Int64 FirstVisitTimestamp { get; set; }
        /// <summary>
        /// 是否锁定
        /// </summary>
        public bool IsLock { get; set; }
        #region method
        /// <summary>
        /// 请求限制 反爬虫
        /// 是否开启校验 默认true  要关闭限制在config文件中 appSettings 设置 visit_validate=false
        /// 频率限制 默认100毫秒 需要修改频率 在config文件中 appSettings 设置 visit_frequency_milliseconds=100
        /// 一段时间内频繁请求，视为爬虫工具，直接禁IP请求1天
        /// </summary>
        /// <returns></returns>
        public GeneralResult Validate()
        {
            var r = new GeneralResult();
            if (HttpContext.Current != null)
            {
                var cacheKey = $"{IpAddress}{HttpContext.Current.Request.RawUrl.Replace("/",":")}";
                if (!string.IsNullOrWhiteSpace(SignRequest))
                {
                    cacheKey = $"{IpAddress}{HttpContext.Current.Request.RawUrl.Replace("/", ":")}:{SignRequest}";
                }
                if (GlobalCache.Instance.IsSet(cacheKey))
                {
                    var visited = GlobalCache.Instance.Get<Visit>(cacheKey);
                    var nowTicks = CommonUtils.ToUnixTimeStamp(DateTime.Now, true);//秒
                    var validateIpAddress = AppSettingUtils.GetBoolean("visit_validate", true);
                    if (validateIpAddress)
                    {
                        var visitFrequencySeconds = AppSettingUtils.GetInt("visit_frequency_milliseconds", 100);
                        if (visitFrequencySeconds <= 0)
                        {
                            r.SetFail("禁止访问");
                        }
                        else
                        {
                            var visitFrequency = (nowTicks - visited.VisitTickCount);
                            var accessVisitCount = (nowTicks - visited.FirstVisitTimestamp) / visitFrequencySeconds;//与第一次请求相隔 时间  内允许请求最大次数
                            if (visited.IsLock)
                            {
                                r.SetFail($"请求异常，IP地址已锁定【{IpAddress}】");
                            }
                            else if (visitFrequency < visitFrequencySeconds)
                            {
                                r.SetFailEx("请求频繁，请稍后重试", $"CommonUtils.ToUnixTimeStamp() - visited.VisitTickCount=({nowTicks}-{visited.VisitTickCount})={visitFrequency}<{visitFrequencySeconds}");
                            }
                            else if (visited.VisitCount > Math.Max(100, accessVisitCount))
                            {//如 前面100次请求不做处理 超过100次请求后 如2分钟120秒 允许请求最大次数为 120次 当超过120次 则认为是爬虫工具
                                visited.IsLock = true;
                            }
                            else
                            {
                                visited.IsLock = false;
                                r.SetSuccess();
                            }

                        }
                    }
                    else
                    {
                        r.SetSuccess();
                    }
                    visited.VisitCount++;
                    visited.VisitTickCount = nowTicks;
                    GlobalCache.Instance.Set(cacheKey, visited, CacheTime);
                }
                else
                {
                    GlobalCache.Instance.Set(cacheKey, this, CacheTime);
                    r.SetSuccess();
                }
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