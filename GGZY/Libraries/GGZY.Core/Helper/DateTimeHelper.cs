using System;
using System.Globalization;
using Microsoft.SqlServer.Server;

namespace GGZY.Core.Helper
{
    public class DateTimeHelper
    {
        public static DateTime ToDateTime(string value,string format)
        {
            var dt = DateTime.MinValue;
            try
            {
                dt = DateTime.ParseExact(value, format, CultureInfo.CurrentCulture);
            }
#pragma warning disable CS0168 // 声明了变量“ex”，但从未使用过
            catch (Exception ex)
#pragma warning restore CS0168 // 声明了变量“ex”，但从未使用过
            {
            }
            return dt;
        }
    }
}