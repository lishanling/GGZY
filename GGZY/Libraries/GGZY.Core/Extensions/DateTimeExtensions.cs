using System;

namespace GGZY.Core.Extensions
{
    public static  class DateTimeExtensions
    {
        public static string ToFormatTimestamp(this DateTime? date, string format="yyyyMMddHHmmss")
        {
            var r = string.Empty;
            if (date.HasValue)
            {
                r = date.Value.ToString(format);
            }
            return r;
        }
    }
}