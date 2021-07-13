using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using GGZY.Core.Helper;
using GGZY.Core.Log;
using GGZY.Core.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NPOI.SS.Formula.Functions;
using DecimalConverter = GGZY.Core.Infrastructure.DecimalConverter;

namespace GGZY.Core.Extensions
{
    public static class ObjectExtensions
    {
        public static PropertyInfo[] GetPropertyInfos(this object obj)
        {
            return obj.GetType().GetProperties();
        }

        public static PropertyInfo GetPropertyInfo(this object obj, string propertyName)
        {
            return obj.GetPropertyInfos().FirstOrDefault(c => c.Name == propertyName);
        }

        public static T GetPropertyValue<T>(this object obj, string propertyName)
        {
            var property = obj.GetPropertyInfo(propertyName);
            if (property != null)
            {
                var val = property.GetValue(obj);
                if (val != null)
                {
                    return (T)val;
                }
            }
            return default;
        }
        /// <summary>
        /// 获取当前对象obj属性propertyName 值
        /// </summary>
        /// <param name="obj">对象</param>
        /// <param name="propertyName">属性名</param>
        /// <returns></returns>
        public static string PropertyToString(this object obj, string propertyName)
        {
            var property = obj.GetPropertyInfo(propertyName);
            if (property != null)
            {
                var val = property.GetValue(obj);
                if (val != null)
                {
                    return val.ToString();
                }
            }
            return string.Empty;
        }
        /// <summary>
        /// JSON 序列化
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string Serializer(this object obj)
        {
            return obj.Serializer(NullValueHandling.Include, Formatting.Indented);
        }


        /// <summary>
        /// JSON 序列化
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="nullValueHandling">空值序列化配置</param>
        /// <param name="formatting">格式化</param>
        /// <returns></returns>
        public static string Serializer(this object obj, NullValueHandling nullValueHandling, Formatting formatting)
        {
            string serialize;
            if (obj is string)
            {
                serialize = obj.ToString();
            }
            else
            {

                JsonSerializerSettings setting = new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    Formatting = formatting,
                    NullValueHandling = nullValueHandling,
                    //ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver(),
                    Converters = new List<JsonConverter>
                    {
                        new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" },
                        new DecimalConverter()
                    }
                };
                serialize = JsonConvert.SerializeObject(obj, null, setting);
            }

            //serialize = serialize.Replace(@"\""", "'");
            return serialize;
        }

        /// <summary>
        /// 转化CSV单元格值 ,替换成，
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string CsvValue(this object obj)
        {
            var v = string.Empty;
            if (obj != null)
            {
                v = obj.ToString().Replace(",", "，");
            }

            return v;
        }
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string DesEncrypt(this object obj)
        {
            try
            {
                if (obj == null || string.IsNullOrWhiteSpace(obj.ToString()))
                {
                    return String.Empty;
                }
                var s = obj?.ToString();
                var objType = obj?.GetType();
                if (!string.IsNullOrWhiteSpace(s) && s.EndsWith(".0") && (objType == typeof(decimal?) || objType == typeof(decimal)))
                {
                    s = s.Substring(0, s.Length - 2);
                }

                var secret = Encrypt.DESEncrypt(s, Encrypt.strIV);
                var encode = HttpUtility.UrlEncode(secret)?.Replace("+", "%2B");
                return encode;
            }
            catch (Exception e)
            {
                return obj?.ToString();
            }
        }
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string DesDecrypt(this object obj)
        {
            try
            {
                if (obj == null || string.IsNullOrWhiteSpace(obj.ToString()))
                {
                    return String.Empty;
                }
                var decode = HttpUtility.UrlDecode(obj?.ToString().Replace(" ", "+").Replace("+", "%2B"));
                var decrypt = Encrypt.DESDecrypt(decode, Encrypt.strIV);
                return decrypt;
            }
            catch (Exception e)
            {
                return obj?.ToString();
            }
        }
        /// <summary>
        /// 类型转换
        /// </summary>
        /// <typeparam name="T">目标对象</typeparam>
        /// <param name="from">来源对象</param>
        /// <param name="propDics">属性映射字典</param>
        /// <param name="exceptProperties">排除映射的属性</param>
        /// <returns></returns>
        public static T ConvertTo<T>(this object from, Dictionary<string, string> propDics = null, params string[] exceptProperties)
        {
            T to = Activator.CreateInstance<T>();
            if (from != null)
            {
                if (exceptProperties == null)
                    exceptProperties = new string[0];
                var fromProps = TypeDescriptor.GetProperties(from);
                var toProps = TypeDescriptor.GetProperties(to);
                foreach (PropertyDescriptor fromProp in fromProps)
                {
                    if (!exceptProperties.Contains(fromProp.Name))
                    {
                        var toProp = toProps.Find(fromProp.Name, true);
                        if (propDics != null && propDics.ContainsKey(fromProp.Name))
                        {
                            toProp = toProps.Find(propDics[fromProp.Name], true);
                        }
                        if (toProp != null && !toProp.IsReadOnly)
                        {
                            bool isTypeMap = toProp.PropertyType.IsAssignableFrom(fromProp.PropertyType);
                            bool isNullableTypeMap = !isTypeMap && Nullable.GetUnderlyingType(fromProp.PropertyType) == toProp.PropertyType;
                            if (isTypeMap || isNullableTypeMap)//类型匹配
                            {
                                object obj1 = fromProp.GetValue(from);
                                //object obj2 = toProp.GetValue(to);
                                //if ((isTypeMap || obj1 != null && isNullableTypeMap) && (obj1 != obj2 && (!(toProp.PropertyType == typeof(DateTime)) || !obj1.Equals(DateTime.MinValue))))
                                //    toProp.SetValue(to, obj1);
                                toProp.SetValue(to, obj1);
                            }
                        }
                    }
                }


            }
            return to;
        }

        public static string To16String(this Guid guid, bool? toUpper = null)
        {
            var bs = guid.ToByteArray();
            long i = bs.Aggregate<byte, long>(1, (current, b) => current * ((int)b + 1));
            var r = $"{(i - DateTime.Now.Ticks):x}";
            if (toUpper.HasValue)
            {
                r = toUpper.Value ? r.ToUpper() : r.ToLower();
            }

            r = r.PadRight(16, r.LastOrDefault());
            return r;
        }
        public static string To19String(this Guid guid)
        {
            return guid.To19Digital().ToString();
        }
        public static Int64 To19Digital(this Guid guid)
        {
            return BitConverter.ToInt64(guid.ToByteArray(), 0);
        }

        public static string Md5Param(this object obj)
        {
            StringBuilder query = new StringBuilder();
            var s = string.Empty;
            if (obj != null)
            {
                var type = obj.GetType();
                var properties = type.GetProperties().OrderBy(c => c.Name).ToList();
                foreach (PropertyInfo info in properties)
                {
                    try
                    {
                        var v = info.GetValue(obj);
                        if (v != null)
                        {
                            query.Append(info.Name).Append(v);
                        }
                    }
                    catch (Exception e)
                    {
                        Logger.Error(e.Message,e);
                    }
                }
                s = CommonUtils.Md5Str(query.ToString());
            }
            return s;
        }
    }
}