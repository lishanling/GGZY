using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GGZY.YDPB.Models
{
    /// <summary>
    /// 响应信息
    /// </summary>
    public class apiResult
    {
        /// <summary>
        /// 执行结果 true/false
        /// </summary>
        public bool result { get; set; }
        /// <summary>
        /// 执行结果说明
        /// </summary>
        public string msg { get; set; }
        /// <summary>
        /// 返回数据
        /// </summary>
        public object data { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_data"></param>
        public apiResult(object _data)
        {
            result = true;
            msg = "成功";
            data = _data;
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_result"></param>
        /// <param name="_msg"></param>
        /// <param name="_data"></param>
        public apiResult(bool _result,string _msg,dynamic _data)
        {
            result = _result;
            msg = _msg;
            data = _data;
        }
    }


    /// <summary>
    /// 响应信息
    /// </summary>
    public class apiResult<T>
    {
        /// <summary>
        /// 执行结果 true/false
        /// </summary>
        public bool result { get; set; }
        /// <summary>
        /// 执行结果说明
        /// </summary>
        public string msg { get; set; }
        /// <summary>
        /// 返回数据
        /// </summary>
        public dynamic data { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_data"></param>
        public apiResult(T _data)
        {
            result = true;
            msg = "成功";
            data = _data;
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_result"></param>
        /// <param name="_msg"></param>
        /// <param name="_data"></param>
        public apiResult(bool _result, string _msg, dynamic _data)
        {
            result = _result;
            msg = _msg;
            data = _data;
        }
    }
}