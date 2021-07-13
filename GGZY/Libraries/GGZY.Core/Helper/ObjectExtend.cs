using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Collections;
using System.Reflection;
using GGZY.Core.Extensions;
using Newtonsoft.Json;

namespace GGZY.Core.Helper
{
    public static class ObjectExtend
    {
        /// <summary>
        /// 防注入
        /// </summary>
        /// <param name="sqlText"></param>
        /// <returns></returns>
        public static string ToClearSql(this string sqlText)
        {
            if (sqlText == null)
            {
                return null;
            }
            if (sqlText == "")
            {
                return "";
            }
            //sqlText = sqlText.Replace("[", "");//去除%
            //sqlText = sqlText.Replace("]", "");//去除%
            //sqlText = sqlText.Replace(",", "");//去除,
            sqlText = sqlText.Replace("<", "");//去除<
            sqlText = sqlText.Replace(">", "");//去除>
            //sqlText = sqlText.Replace("--", "");//去除--
            sqlText = sqlText.Replace("'", "");//去除'
            //sqlText = sqlText.Replace("\"", "");//去除"
            //sqlText = sqlText.Replace("=", "");//去除=
            //sqlText = sqlText.Replace("%", "");//去除%
            //sqlText = sqlText.Replace(" ", "");//去除空格
            sqlText = sqlText.Replace("script", "");//防XSS
            sqlText = sqlText.Replace("javascript", "");//防XSS
            sqlText = sqlText.FilterSql();
            return sqlText.Trim();
        }


        /// <summary>
        /// 字符串转int
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int ToInt(this string str)
        {
            return int.Parse(str);
        }

        /// <summary>
        /// 字符串转Decimal
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static decimal ToDecimal(this string str)
        {
            return decimal.Parse(str);
        }

        /// <summary>
        /// 字符串转double
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static double ToDouble(this string str)
        {
            return double.Parse(str);
        }


        /// <summary>
        /// 获取小数后几位
        /// </summary>
        /// <param name="d"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static decimal ToRound(this decimal d,int length = 2)
        {
            return Math.Round(d, length);
        }
        /// <summary>
        /// 字符串转DateTime
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DateTime ToDateTime(this string str)
        {
            return DateTime.Parse(str);
        }

        /// <summary>
        /// 时间转字符串，并设置显示格式
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
#pragma warning disable CS1573 // 参数“Format”在“ObjectExtend.ToFormat(DateTime, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
        public static string ToFormat(this DateTime dt, string Format)
#pragma warning restore CS1573 // 参数“Format”在“ObjectExtend.ToFormat(DateTime, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
        {
            return dt.ToString(Format, System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        /// <summary>
        /// 时间转字符串，并设置显示格式
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
#pragma warning disable CS1573 // 参数“Format”在“ObjectExtend.ToFormat(DateTime?, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
        public static string ToFormat(this DateTime? dt, string Format)
#pragma warning restore CS1573 // 参数“Format”在“ObjectExtend.ToFormat(DateTime?, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
        {
            if (dt == null)
            {
                return "";
            }
            else
            {
                return Convert.ToDateTime(dt).ToFormat(Format);
            }
        }

        /// <summary>
        /// 判断是否为数字类型
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsDouble(this string str)
        {
            try
            {
                double db = Convert.ToDouble(str);
                return true;
            }
            catch { }
            return false;
        }

        /// <summary>
        /// 判断是否为时间类型
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsDateTime(this string str)
        {
            try
            {
                DateTime db = Convert.ToDateTime(str);
                return true;
            }
            catch { }
            return false;
        }


        public static string ToJson(this Hashtable ht)
        {
            return JsonConvert.SerializeObject(ht);
        }

        public static Dictionary<string, object> ToDict<T>(this T obj)
        {
            Dictionary<string, object> instance = new Dictionary<string, object>();

            Type t = obj.GetType(); // 获取对象对应的类， 对应的类型

            PropertyInfo[] pi = t.GetProperties(BindingFlags.Public | BindingFlags.Instance); // 获取当前type公共属性

            foreach (PropertyInfo p in pi)
            {
                switch (p.PropertyType.FullName)
                {
                    case "System.String":
                        instance.Add(p.Name, p.GetValue(obj)?.ToString() ?? "");
                        break;
                    case "System.Decimal":
                    case "System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]":
                        instance.Add(p.Name, decimal.Parse(p.GetValue(obj)?.ToString() ?? "", null));
                        break;
                    case "System.Int32":
                    case "System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]":
                        instance.Add(p.Name, int.Parse(p.GetValue(obj)?.ToString() ?? "", null));
                        break;
                    case "System.Double":
                    case "System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]":
                        instance.Add(p.Name, double.Parse(p.GetValue(obj)?.ToString() ?? "", null));
                        break;
                    case "System.DateTime":
                    case "System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]":
                        instance.Add(p.Name, p.GetValue(obj) != null ? DateTime.Parse(p.GetValue(obj).ToString()).ToString("yyyy-MM-dd HH:mm:ss") : "");
                        break;
                    default:
                        instance.Add(p.Name, p.GetValue(obj)?.ToString());
                        break;
                }
            }
            return instance;
        }


    }
}





