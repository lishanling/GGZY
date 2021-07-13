using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using GGZY.Core.Log;
using Newtonsoft.Json;

namespace GGZY.Core.Models
{
    /// <summary>
    /// 返回信息
    /// </summary>
    public class GeneralResult
    {
        private string _MSG;

        /// <summary>
        /// 执行结果代码
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// 是否执行成功
        /// </summary>

        public bool Success { get; set; }
        /// <summary>
        /// 服务端返回数据
        /// </summary>
        public virtual object Data { get; set; }

        /// <summary>
        /// 执行结果描述
        /// </summary>
        public string Msg
        {
            get
            {
                if (!string.IsNullOrEmpty(_MSG))
                {
                    var regex = new Regex("(ORA-\\S*:)|\"[A-Z|_]*\"\\.", RegexOptions.IgnoreCase);
                    _MSG = regex.Replace(_MSG, "");
                    return HttpUtility.HtmlEncode(_MSG.Replace("\"", " "));
                }

                return _MSG;

            }
            set => _MSG = value;
        }
#if !DEBUG
        [JsonIgnore]
#endif
        public string Exception { get; set; }

    }

    public class GeneralResult<T> : GeneralResult
    {
        [JsonIgnore]
        public T TData { get; set; }

    }

    public static class GeneralResultExtensions
    {
        public static void SetSuccess(this GeneralResult result, object data = null, string msg = "操作成功")
        {
            result.State = GeneralResultState.Okay;
            result.Success = true;
            result.Data = data;
            result.Msg = msg;
        }


        public static void SetFail(this GeneralResult result, string msg, Exception e = null, object data = null)
        {
            result.State = GeneralResultState.BadRequest;
            result.Success = false;
            result.Data = data;
            result.Msg = msg;
            result.Exception = e?.ToString();
            if (e != null && e is NullReferenceException)
            {
                result.Msg = "请求的对象不存在";
            }
            Logger.Error(msg, e);
        }

        public static void SetFailEx(this GeneralResult result, string msg, string ex, Exception e = null)
        {
            result.SetFail(msg, new Exception(ex, e));
        }
        /// <summary>
        /// 服务端异常
        /// </summary>
        /// <param name="result"></param>
        /// <param name="msg"></param>
        /// <param name="e"></param>
#pragma warning disable CS1573 // 参数“requestid”在“GeneralResultExtensions.SetException(GeneralResult, string, Exception, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
        public static void SetException(this GeneralResult result, string msg, Exception e = null, string requestid = "")
#pragma warning restore CS1573 // 参数“requestid”在“GeneralResultExtensions.SetException(GeneralResult, string, Exception, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
        {
            result.State = GeneralResultState.InternalServerError;
            result.Success = false;
            if (!String.IsNullOrEmpty(requestid))
            {
                result.Data = new { requestid = requestid };
            }
            result.Msg = msg;
            result.Exception = e?.ToString();
            if (e != null)
            {

                if (e is NullReferenceException)
                {//代码不健壮 出现未将对象引用到对象实例的空指针
                    result.Msg = "请求的对象不存在";
                }
                else if (e is HttpRequestValidationException)
                {//从客户端(a=\"<ScRiPt >alert(/xss/...\")中检测到有潜在危险的 Request.QueryString 值
                    result.Msg = "从客户端中检测到有潜在危险的参数值";
                }
                else if (e is HttpException)
                {//访问了不存在的控制器或者方法
                    result.Msg = "请求的方法不存在";
                }
            }
            Logger.Fatal(msg, e);
        }
        /// <summary>
        /// 身份未认证
        /// </summary>
        /// <param name="result"></param>
        /// <param name="msg"></param>
        /// <param name="e"></param>
        public static void SetUnauthorized(this GeneralResult result, string msg, Exception e = null)
        {
            result.State = GeneralResultState.Unauthorized;
            result.Success = false;
            result.Data = null;
            result.Msg = msg;
            result.Exception = e?.ToString();
        }
        /// <summary>
        /// 超时
        /// </summary>
        /// <param name="result"></param>
        /// <param name="msg"></param>
        /// <param name="e"></param>
        public static void SetTimeout(this GeneralResult result, string msg = "请求超时", Exception e = null)
        {
            result.State = GeneralResultState.RequestTimeout;
            result.Success = false;
            //result.Data = null;
            result.Msg = msg;
            result.Exception = e?.ToString();
        }

        public static void SetSuccessT<T>(this GeneralResult<T> result, T data, string msg = "操作成功")
        {
            result.TData = data;
            result.SetSuccess(data, msg);
        }

        //public static void SetFail<T>(this GeneralResult<T> result, string msg, Exception e = null)
        //{
        //    result.State = GeneralResultState.BadRequest;
        //    result.Success = false;
        //    //result.Data = default(T);
        //    result.Msg = msg;
        //    result.Exception = e?.ToString();
        //    Logger.Error(msg, e);
        //}

        ///// <summary>
        ///// 服务端异常
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="result"></param>
        ///// <param name="msg"></param>
        ///// <param name="e"></param>
        //public static void SetException<T>(this GeneralResult<T> result, string msg, Exception e = null)
        //{
        //    result.State = GeneralResultState.InternalServerError;
        //    result.Success = false;
        //    //result.Data = default(T);
        //    result.Msg = msg;
        //    result.Exception = e?.ToString();
        //    Logger.Fatal(msg, e);
        //}

        //public static void SetTimeout<T>(this GeneralResult<T> result, string msg = "请求超时", Exception e = null)
        //{
        //    result.State = GeneralResultState.RequestTimeout;
        //    result.Success = false;
        //    //result.Data = null;
        //    result.Msg = msg;
        //    result.Exception = e?.ToString();
        //}
    }

    public class GeneralResultState
    {
        /// <summary>
        /// 成功
        /// </summary>
        public const string Okay = "200";
        /// <summary>
        /// 请求错误
        /// </summary>
        public const string BadRequest = "400";
        /// <summary>
        /// 未授权认证
        /// </summary>
        public const string Unauthorized = "401";
        /// <summary>
        /// 不可接受
        /// </summary>
        public const string NotAcceptable = "406";

        /// <summary>
        /// 请求超时
        /// </summary>
        public const string RequestTimeout = "408";

        /// <summary>
        /// 服务器错误
        /// </summary>
        public const string InternalServerError = "500";
    }

}