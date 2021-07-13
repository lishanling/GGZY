using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Helper;
using GGZY.Core.Log;
using GGZY.Core.Utils;
using Newtonsoft.Json;

namespace GGZY.Services.DZBH
{
    public class BhSendService<T> where T : class
    {
        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="url">发送地址</param>
        /// <param name="systemNo">系统编码</param>
        /// <param name="secret">密钥</param>
        /// <param name="time">当前时间</param>
        /// <param name="dataKey">数据唯一标识</param>
        /// <param name="obj">数据列表</param>
        /// <param name="cols">字段列表</param>
        public BhSendService(string url, string systemNo, string secret, string time, string dataKey, T obj, List<string> cols = null)
        {
            _url = url;
            _system_no = systemNo;
            _data_key = dataKey;
            _secret = secret;
            _time = time;
            _obj = obj;
            _cols = cols;
        }
        private string _url { get; set; }
        private string _system_no { get; set; }
        private string _data_key { get; set; }
        private string _secret { get; set; }
        private string _time { get; set; }
        private T _obj { get; set; }
        private List<string> _cols { get; set; }

        /// <summary>
        /// 发送数据
        /// </summary>
        /// <returns></returns>
        public string Send()
        {
            string result = "";
            string data = CreateJson();
            string validate = TokenHelper.CreateValidation_Json(_system_no, _secret, _time, data);
            Logger.Debug($"data={data}&validate={validate}");
            Dictionary<string, string> postData = new Dictionary<string, string>()
            {
                { "validation",validate},
                { "data",data},
            };
            if ("8897,35040052".Contains(_system_no))
            {
                Dictionary<string, string> heads = new Dictionary<string, string>()
                {
                    { "transcode","insure"},
                };
                result = new WebUtils() { Headers = heads }.DoPost(_url, postData);
            }
            else
            {
                result = new WebUtils().DoPost(_url, postData);

            }




            return result;

        }
        /// <summary>
        /// 创建xml
        /// </summary>
        /// <returns></returns>
        private string CreateJson()
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            result.Add("SYSTEM_NO", _system_no);
            result.Add("DATA_KEY", _data_key);
            List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();

            Dictionary<string, object> instance = new Dictionary<string, object>();

            foreach (var p in _obj.GetType().GetProperties())
            {
                if (!p.Name.StartsWith("M_") && !p.Name.StartsWith("ID"))
                {
                    if (_cols != null && _cols.Count > 0 && !_cols.Contains(p.Name))
                    {
                        continue;
                    }
                    if (!instance.ContainsKey(p.Name))
                    {
                        if (p.GetValue(_obj) == null)
                        {
                            Logger.Debug("获取出错：" + p.Name);
                        }
                        switch (p.PropertyType.FullName)
                        {
                            case "System.String":
                                instance.Add(p.Name, p.GetValue(_obj)?.ToString());
                                break;
                            case "System.Decimal":
                            case "System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]":
                                instance.Add(p.Name, decimal.Parse(p.GetValue(_obj).ToString(), System.Globalization.NumberStyles.Float));
                                break;
                            case "System.Int32":
                            case "System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]":
                                instance.Add(p.Name, int.Parse(p.GetValue(_obj).ToString(), null));
                                break;
                            case "System.Double":
                            case "System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]":
                                instance.Add(p.Name, decimal.Parse(p.GetValue(_obj).ToString(), System.Globalization.NumberStyles.Float));
                                break;
                            case "System.DateTime":
                            case "System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]":
                                instance.Add(p.Name, DateTime.Parse(p.GetValue(_obj).ToString()).ToString("yyyyMMddHHmmss"));
                                break;
                            default:
                                instance.Add(p.Name, p.GetValue(_obj).ToString());
                                break;
                        }
                    }

                }
            }

            result.Add("DATA", instance);
            return JsonConvert.SerializeObject(result);
        }
    }
}
