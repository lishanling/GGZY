using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace GGZY.Core.Extensions
{
    public static class StringExtension
    {
        /// <summary>
        /// 时间格式字符串转换为可空DataTime
        /// </summary>
        /// <param name="timeString"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static DateTime? ToNullableDateTime(this string timeString,params string[] format )
        {
            if (format == null||format.Length==0)
            {
                format=new []{ "yyyyMMddHHmmss" };
            }

            foreach (var s in format)
            {
                if (DateTime.TryParseExact(timeString,s, System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None,
                    out DateTime date))
                {
                    return date;
                }
            }
           
            return null;
        }
        /// <summary>
        /// 时间格式字符串转换为DateTime类型
        /// </summary>
        /// <param name="timeString"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static DateTime ToDateTime(this string timeString, string format = "yyyyMMddHHmmss")
        {
            var dt = timeString.ToNullableDateTime(format) ?? new DateTime(1970, 1, 1);
            return dt;
        }

        /// <summary>
        /// 从起始位置截取不超过最大长度字符串
        /// </summary>
        /// <param name="sourceString">原始字符串</param>
        /// <param name="maxLength">最大长度</param>
        /// <param name="fromBegin">从开始位置向后</param>
        /// <returns></returns>
        public static string MaxSubString(this string sourceString, int maxLength,bool fromBegin=true)
        {
            var r = string.Empty;
            if (!string.IsNullOrWhiteSpace(sourceString))
            {
                var length = sourceString.Length;
                maxLength = Math.Min(length, maxLength);
                var startIndex = 0;
                if (!fromBegin)
                {
                    startIndex = length - maxLength;
                }
                r = sourceString.Substring(startIndex, maxLength);
            }

            return r;
        }

        /// <SUMMARY>
        /// 判断字符串是否可以转化为数字
        /// </SUMMARY>
        /// <PARAM name="str">要检查的字符串</PARAM>
        /// <PARAM name="r"></PARAM>
        /// <RETURNS>true:可以转换为数字；false:不是数字</RETURNS>
        public static bool IsDigital(this string str, out decimal r)
        {
            return decimal.TryParse(str, System.Globalization.NumberStyles.Float,
                 System.Globalization.NumberFormatInfo.InvariantInfo, out r);
        }
        public static decimal? ToNullableDecimal(this string digitalString)
        {
            if (string.IsNullOrWhiteSpace(digitalString))
            {
                return null;
            }
            if (decimal.TryParse(digitalString, NumberStyles.Float, CultureInfo.InvariantCulture, out decimal num))
            {
                return num;
            }

            return null;
        }
        /// <summary>
        /// 可空十进制数转字符串
        /// </summary>
        /// <param name="digital"></param>
        /// <returns></returns>
        public static string ToDecimalString(this decimal? digital)
        {
            if (digital.HasValue)
            {
                return digital.Value.ToString(CultureInfo.InvariantCulture);
            }

            return String.Empty;
        }
        public static string FirstUpperStr(this string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            if (s.Length > 1)
            {
                return char.ToUpper(s[0]) + s.Substring(1).ToLower();
            }
            return char.ToUpper(s[0]).ToString();
        }
        public static string FriendlyStr(this string name)
        {
            string[] nameSlices = name.Split('_');
            return nameSlices.Aggregate("", (current, nameSlice) => current + FirstUpperStr(nameSlice));
        }
        /// <summary>
        /// SQL 注入过滤
        /// </summary>
        /// <param name="sqlString"></param>
        /// <returns></returns>
        public static string FilterSql(this string sqlString)
        {
            if (string.IsNullOrWhiteSpace(sqlString))
            {
                return "";
            }
            sqlString = sqlString.Replace("'", "''");
            sqlString = sqlString.Replace(";", "");
            sqlString = sqlString.Replace("(", "（");
            sqlString = sqlString.Replace(")", "）");
            sqlString = sqlString.Replace("0x", "0 x");
            sqlString = sqlString.FilterSqlKey();
            return sqlString;
        }
        /// <summary>
        /// SQL 注入过滤(剔除关键字)
        /// </summary>
        /// <param name="sqlString"></param>
        /// <returns></returns>
        public static string FilterSqlKey(this string sqlString)
        {
            if (string.IsNullOrWhiteSpace(sqlString))
            {
                return "";
            }
            var regex = new Regex("\\b(and |or |exec |execute |insert |select |delete |union |update |alter |create |drop |count |\\* |chr |char |limit |asc |mid |'%|%'|substring |master |truncate |declare |xp_cmdshell |xp_ |sp_ |restore |backup |net +user |net +localgroup +administrators| and| or| exec| execute| insert| select| delete| union| update| alter| create| drop| count|\\*| chr| char| limit| asc| mid| substring| master| truncate| declare| xp_cmdshell| xp_| sp_| restore| backup| net +user| net +localgroup +administrators|select|from)\\b", RegexOptions.IgnoreCase);
            sqlString = regex.Replace(sqlString, "");
            return sqlString;
        }

        public static bool CheckSqlStr(this string inputString, string sqlStr = "")
        {
            if (string.IsNullOrWhiteSpace(sqlStr))
            {
                sqlStr = "and |or |exec |execute |insert |select |delete |union |update |alter |create |drop |count |\\* |chr |char |limit |asc |mid |'%|%'|substring |master |truncate |declare |xp_cmdshell |xp_ |sp_ |restore |backup |net +user |net +localgroup +administrators| and| or| exec| execute| insert| select| delete| union| update| alter| create| drop| count|\\*| chr| char| limit| asc| mid| substring| master| truncate| declare| xp_cmdshell| xp_| sp_| restore| backup| net +user| net +localgroup +administrators";
            }
            try
            {
                inputString = inputString.Trim();
                if (!string.IsNullOrWhiteSpace(inputString))
                {
                    string pattern = "\\b(" + sqlStr + ")\\b";
                    Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
                    if (regex.IsMatch(inputString.ToLower()))
                    {
                        bool result = false;
                        return result;
                    }
                }
            }
            catch
            {
                bool result = false;
                return result;
            }
            return true;
        }
        /// <summary>
        /// 反序列话JSON字符串为JSON对象
        /// </summary>
        /// <typeparam name="T">反序列话对象类型</typeparam>
        /// <param name="jsonStr">JSON格式字符串</param>
        /// <returns></returns>
        public static T DeserializeObject<T>(this string jsonStr)
        {
            return JsonConvert.DeserializeObject<T>(jsonStr);
        }
        /// <summary>
        /// 脱敏
        /// </summary>
        /// <param name="source">未脱敏字符串 如张三丰 13523764531</param>
        /// <returns>脱敏字符串  如张*丰 135****4531</returns>
        public static string Desensitization(this string source)
        {
            if (!string.IsNullOrWhiteSpace(source))
            {
                var length = source.Length;
                if (length < 3 && length > 0)
                    source = $"{source[0]}*";
                else if (length >= 3 && length < 11)
                    source = $"{source[0]}*{source.Substring(2)}";
                else if (length == 11) source = $"{source.Substring(0, 3)}****{source.Substring(7, 4)}";
                else if (length == 18) source = $"{source.Substring(0, 3)}*******{source.Substring(14, 4)}";
            }

            return source;
        }
    }
}