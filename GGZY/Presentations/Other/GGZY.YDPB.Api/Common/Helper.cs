using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace GGZY.YDPB.Api.Common
{
    public static class Helper
    {
        public static string CreateToken(this string message, string secret="12345678")
        {
            secret = secret ?? "";
            var encoding = new System.Text.ASCIIEncoding();
            byte[] keyByte = encoding.GetBytes(secret);
            byte[] messageBytes = encoding.GetBytes(message);
            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
                return Convert.ToBase64String(hashmessage).Replace("+", "_").Replace("/", "_").Replace("=", "_");
            }
        }

        public static DateTime ToDateTimeFromFormat(this string strTime,string format="yyyyMMddHHmmss")
        {
            if(String.IsNullOrEmpty(strTime))
            {
                return DateTime.MinValue;
            }
            System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(@"\d{14}");
            DateTime dt = DateTime.MinValue;
            if(format == "yyyyMMddHHmmss")
            {
                if(! reg.IsMatch(strTime))
                {
                    return dt;
                }
                DateTime.TryParse(String.Concat(strTime.Substring(0,4),"-",strTime.Substring(4,2),"-",strTime.Substring(6,2),
                    " ",strTime.Substring(8,2),":",strTime.Substring(10,2),":",strTime.Substring(12,2)), out dt);
                return dt;
            }
            DateTime.TryParse(strTime, out dt);
            return dt;
        }
    }
}