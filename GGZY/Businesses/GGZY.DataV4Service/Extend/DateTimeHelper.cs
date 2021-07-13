using System;
using System.Globalization;
using Microsoft.SqlServer.Server;

namespace GGZY.DataV4Service.Extend
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
            catch (Exception ex)
            {
            }
            return dt;
        }
    }
}