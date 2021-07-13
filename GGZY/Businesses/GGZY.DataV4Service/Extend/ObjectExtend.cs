using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace GGZY.DataV4Service.Extend
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
            sqlText = sqlText.Replace("<", "&lt;");//去除<
            sqlText = sqlText.Replace(">", "&gt;");//去除>
            //sqlText = sqlText.Replace("--", "");//去除--
            sqlText = sqlText.Replace("'", "&quot;");//去除'
            //sqlText = sqlText.Replace("\"", "");//去除"
            //sqlText = sqlText.Replace("=", "");//去除=
            //sqlText = sqlText.Replace("%", "");//去除%
            //sqlText = sqlText.Replace(" ", "");//去除空格
            sqlText = sqlText.Replace("script", "");//防XSS
            sqlText = sqlText.Replace("javascript", "");//防XSS

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
        public static string ToFormat(this DateTime dt, string Format)
        {
            return dt.ToString(Format, System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        /// <summary>
        /// 时间转字符串，并设置显示格式
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string ToFormat(this DateTime? dt, string Format)
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

    }
}





