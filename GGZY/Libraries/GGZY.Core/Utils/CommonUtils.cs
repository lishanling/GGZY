using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;

namespace GGZY.Core.Utils
{
    public abstract class CommonUtils
    {

        private const string DATE_TIME_FORMAT = "yyyy-MM-dd HH:mm:ss";

        /// <summary>
        /// 格式化日期
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static String FormatDateTime(DateTime dateTime)
        {
            return dateTime.ToString(DATE_TIME_FORMAT, System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        /// <summary>
        /// 给请求签名。
        /// </summary>
        /// <param name="parameters">所有字符型的请求参数</param>
        /// <param name="secret">签名密钥</param>
        /// <returns>签名</returns>
        public static string SignRequest(IDictionary<string, string> parameters, string secret)
        {
            return SignRequest(parameters, secret, true);
        }

        /// <summary>
        /// 给请求签名。
        /// </summary>
        /// <param name="parameters">所有字符型的请求参数</param>
        /// <param name="secret">签名密钥</param>
        /// <param name="qhs">是否前后都加密钥进行签名</param>
        /// <returns>签名</returns>
        public static string SignRequest(IDictionary<string, string> parameters, string secret, bool qhs)
        {
            // 第一步：把字典按Key的字母顺序排序
            IDictionary<string, string> sortedParams = new SortedDictionary<string, string>(parameters);
            IEnumerator<KeyValuePair<string, string>> dem = sortedParams.GetEnumerator();

            // 第二步：把所有参数名和参数值串在一起
            StringBuilder query = new StringBuilder(secret);
            while (dem.MoveNext())
            {
                string key = dem.Current.Key;
                string value = dem.Current.Value;
                if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
                {
                    query.Append(key).Append(value);
                }
            }

            if (qhs)
            {
                query.Append(secret);
            }

            // 第三步：使用MD5加密
            //MD5 md5 = MD5.Create();
            //Byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(query.ToString()));

            // 第四步：把二进制转化为大写的十六进制
            //StringBuilder result = new StringBuilder();
            //for (int i = 0; i < bytes.Length; i++)
            //{
            //    string hex = bytes[i].ToString("X");
            //    if (hex.Length == 1)
            //    {
            //        result.Append("0");
            //    }
            //    result.Append(hex);
            //}
            //return result.ToString();
            Console.WriteLine(query.ToString());
            var md5Str = Md5Str(query.ToString());
            return md5Str;
        }

        public static string Md5Stream(Stream s)
        {
            MD5 md5 = MD5.Create();
            Byte[] bytes = md5.ComputeHash(s);
            var hexStr = BytesToHexString(bytes);
            return hexStr;
        }
        public static string Md5Str(string query)
        {
            MD5 md5 = MD5.Create();
            Byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(query));
            var hexStr = BytesToHexString(bytes);
            return hexStr;
        }

        /// <summary>
        /// 把二进制转化为大写的十六进制
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string BytesToHexString(byte[] bytes)
        {
            StringBuilder result = new StringBuilder();
            foreach (var t in bytes)
            {
                result.Append(t.ToString("X2"));
            }
            return result.ToString();
        }
        /// <summary>
        /// 字符串转16进制字节数组
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static byte[] HexStringToBytes(string hex)
        {
            if (hex.Length == 0)
            {
                return new byte[] { 0 };
            }

            if (hex.Length % 2 == 1)
            {
                hex = "0" + hex;
            }

            byte[] result = new byte[hex.Length / 2];

            for (int i = 0; i < hex.Length / 2; i++)
            {
                result[i] = byte.Parse(hex.Substring(2 * i, 2), System.Globalization.NumberStyles.AllowHexSpecifier);
            }

            return result;
        }
        /// <summary>
        /// 解释回调参数为键值对（采用GBK字符集编码）。
        /// </summary>
        /// <param name="topParams">经过BASE64和URL编码的字符串</param>
        /// <returns>键值对</returns>
        public static IDictionary<string, string> DecodeParams(string topParams)
        {
            return DecodeParams(topParams, Encoding.GetEncoding("GBK"));
        }

        /// <summary>
        /// 解释回调参数为键值对。
        /// </summary>
        /// <param name="topParams">经过BASE64和URL编码的字符串</param>
        /// <param name="encoding">字符集编码</param>
        /// <returns>键值对</returns>
        public static IDictionary<string, string> DecodeParams(string topParams, Encoding encoding)
        {
            if (string.IsNullOrEmpty(topParams))
            {
                return null;
            }

            Byte[] buffer = Convert.FromBase64String(Uri.UnescapeDataString(topParams));
            string originParams = encoding.GetString(buffer);
            return SplitUrlQuery(originParams);
        }

        /// <summary>
        /// 拆分Url Query
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static IDictionary<string, string> SplitUrlQuery(string query)
        {
            IDictionary<string, string> result = new Dictionary<string, string>();

            string[] pairs = query.Split(new char[] { '&' });
            if (pairs != null && pairs.Length > 0)
            {
                foreach (string pair in pairs)
                {
                    string[] oneParam = pair.Split(new char[] { '=' }, 2);
                    if (oneParam != null && oneParam.Length == 2)
                    {
                        result.Add(oneParam[0], oneParam[1]);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// 清除字典中值为空的项。
        /// </summary>
        /// <param name="dict">待清除的字典</param>
        /// <returns>清除后的字典</returns>
        public static IDictionary<string, T> CleanupDictionary<T>(IDictionary<string, T> dict)
        {
            IDictionary<string, T> newDict = new Dictionary<string, T>(dict.Count);
            IEnumerator<KeyValuePair<string, T>> dem = dict.GetEnumerator();

            while (dem.MoveNext())
            {
                string name = dem.Current.Key;
                T value = dem.Current.Value;
                if (value != null)
                {
                    newDict.Add(name, value);
                }
            }

            return newDict;
        }

        /// <summary>
        /// 获取文件的真实后缀名。目前只支持JPG, GIF, PNG, BMP四种图片文件。
        /// </summary>
        /// <param name="fileData">文件字节流</param>
        /// <returns>JPG, GIF, PNG or null</returns>
        public static string GetFileSuffix(Byte[] fileData)
        {
            if (fileData == null || fileData.Length < 10)
            {
                return null;
            }

            if (fileData[0] == 'G' && fileData[1] == 'I' && fileData[2] == 'F')
            {
                return "GIF";
            }
            else if (fileData[1] == 'P' && fileData[2] == 'N' && fileData[3] == 'G')
            {
                return "PNG";
            }
            else if (fileData[6] == 'J' && fileData[7] == 'F' && fileData[8] == 'I' && fileData[9] == 'F')
            {
                return "JPG";
            }
            else if (fileData[0] == 'B' && fileData[1] == 'M')
            {
                return "BMP";
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取文件的真实媒体类型。目前只支持JPG, GIF, PNG, BMP四种图片文件。
        /// </summary>
        /// <param name="fileData">文件字节流</param>
        /// <returns>媒体类型</returns>
        public static string GetMimeType(Byte[] fileData)
        {
            string suffix = GetFileSuffix(fileData);
            string mimeType;

            switch (suffix)
            {
                case "JPG":
                    mimeType = "image/jpeg";
                    break;
                case "GIF":
                    mimeType = "image/gif";
                    break;
                case "PNG":
                    mimeType = "image/png";
                    break;
                case "BMP":
                    mimeType = "image/bmp";
                    break;
                default:
                    mimeType = "application/octet-stream";
                    break;
            }

            return mimeType;
        }

        /// <summary>
        /// 根据文件后缀名获取文件的媒体类型。
        /// </summary>
        /// <param name="fileName">带后缀的文件名或文件全名</param>
        /// <returns>媒体类型</returns>
        public static string GetMimeType(string fileName)
        {
            string mimeType;
            fileName = fileName.ToLower();

            if (fileName.EndsWith(".bmp", StringComparison.CurrentCulture))
            {
                mimeType = "image/bmp";
            }
            else if (fileName.EndsWith(".gif", StringComparison.CurrentCulture))
            {
                mimeType = "image/gif";
            }
            else if (fileName.EndsWith(".jpg", StringComparison.CurrentCulture) ||
                     fileName.EndsWith(".jpeg", StringComparison.CurrentCulture))
            {
                mimeType = "image/jpeg";
            }
            else if (fileName.EndsWith(".png", StringComparison.CurrentCulture))
            {
                mimeType = "image/png";
            }
            else
            {
                mimeType = "application/octet-stream";
            }

            return mimeType;
        }

        /// <summary>
        /// 获取JsonConverter
        /// </summary>
        /// <returns></returns>
        public static JsonConverter[] GetJsonConverters()
        {
            List<JsonConverter> list = new List<JsonConverter> { };
            return list.ToArray();
        }

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="sSource"></param>
        /// <param name="sPublicKey"></param>
        /// <returns></returns>
        public static string EncryptString(string sSource, string sPublicKey)
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] DataToEncrypt = ByteConverter.GetBytes(sSource);
            try
            {
                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
                byte[] bytes_public_Key = Convert.FromBase64String(sPublicKey);
                RSA.ImportCspBlob(bytes_public_Key);
                byte[] bytes_Cypher_Text = RSA.Encrypt(DataToEncrypt, false);
                string str_Cypher_Text = Convert.ToBase64String(bytes_Cypher_Text);
                return str_Cypher_Text;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="secret"></param>
        /// <param name="privateKey"></param>
        /// <returns></returns>
        public static string DecryptString(string secret, string privateKey)
        {
            try
            {
                UnicodeEncoding ByteConverter = new UnicodeEncoding();

                byte[] DataToDecrypt = Convert.FromBase64String(secret);

                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
                byte[] bytes_private_Key = Convert.FromBase64String(privateKey);
                RSA.ImportCspBlob(bytes_private_Key);

                byte[] bytes_Plain_Text = RSA.Decrypt(DataToDecrypt, false);
                string str_Plain_Text = ByteConverter.GetString(bytes_Plain_Text);
                return str_Plain_Text;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return secret;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="time">当前时间</param>
        /// <param name="isMilliseconds">是否返回毫秒 默认false</param>
        /// <returns></returns>
        public static Int64 ToUnixTimeStamp(DateTime? time=null ,bool isMilliseconds=false)
        {
            DateTime dateTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            if (!time.HasValue)
            {
                time = DateTime.Now;
            }

            if (isMilliseconds)
            {
                return (Int64)(time.Value - dateTime).TotalMilliseconds;
            }
            return (Int64)(time.Value - dateTime).TotalSeconds;
        }

        /// <summary>        
        /// 时间戳转为C#格式时间)        
        /// </summary>        
        /// <param name="timeStamp">秒</param>        
        /// <returns></returns>        
        public static DateTime TimeStampToDateTime(string timeStamp)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dtStart.Add(toNow);
        }

    }
}