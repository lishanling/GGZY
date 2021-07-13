using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace GGZY.Core.Utils
{
    public class DESEncryptUtils
    {
        public static string Encode(string source, string _DESKey)
        {
            StringBuilder stringBuilder = new StringBuilder();
            using (DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider())
            {
                byte[] bytes1 = Encoding.ASCII.GetBytes(_DESKey);
                byte[] bytes2 = Encoding.ASCII.GetBytes(_DESKey);
                byte[] bytes3 = Encoding.UTF8.GetBytes(source);
                cryptoServiceProvider.Mode = CipherMode.CBC;
                cryptoServiceProvider.Key = bytes1;
                cryptoServiceProvider.IV = bytes2;
                string str = "";
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, cryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(bytes3, 0, bytes3.Length);
                        cryptoStream.FlushFinalBlock();
                        str = Convert.ToBase64String(memoryStream.ToArray());
                    }
                }
                return str;
            }
        }

        public static string Decode(string source, string sKey)
        {
            byte[] buffer = Convert.FromBase64String(source);
            using (DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider())
            {
                cryptoServiceProvider.Key = Encoding.ASCII.GetBytes(sKey);
                cryptoServiceProvider.IV = Encoding.ASCII.GetBytes(sKey);
                MemoryStream memoryStream = new MemoryStream();
                using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, cryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cryptoStream.Write(buffer, 0, buffer.Length);
                    cryptoStream.FlushFinalBlock();
                    cryptoStream.Close();
                }
                string str = Encoding.UTF8.GetString(memoryStream.ToArray());
                memoryStream.Close();
                return str;
            }
        }
    }

    public class AESEncryptUtils
    {
        /// <summary>
        /// 默认密钥-密钥的长度必须是32
        /// </summary>
        private const string PublicKey = "1234567890123456";

        /// <summary>
        /// 默认向量
        /// </summary>
        private const string Iv = "abcdefghijklmnop";
        /// <summary>  
        /// AES加密算法  
        /// </summary>  
        /// <param name="input">明文字符串</param>  
        /// <returns>字符串</returns>  
#pragma warning disable CS1573 // 参数“key”在“AESEncryptUtils.EncryptByAES(string, string, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
#pragma warning disable CS1573 // 参数“iv”在“AESEncryptUtils.EncryptByAES(string, string, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
        public static string EncryptByAES(string input, string key, string iv)
#pragma warning restore CS1573 // 参数“iv”在“AESEncryptUtils.EncryptByAES(string, string, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
#pragma warning restore CS1573 // 参数“key”在“AESEncryptUtils.EncryptByAES(string, string, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }
            using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
            {
                rijndaelManaged.Mode = CipherMode.CBC;
                rijndaelManaged.Padding = PaddingMode.PKCS7;
                rijndaelManaged.FeedbackSize = 128;

                rijndaelManaged.Key = Encoding.UTF8.GetBytes(key);
                rijndaelManaged.IV = Encoding.UTF8.GetBytes(iv);

                ICryptoTransform encryptor = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(input);
                        }
                        byte[] bytes = msEncrypt.ToArray();
                        return Convert.ToBase64String(bytes);
                    }
                }
            }
        }

        /// <summary>  
        /// AES解密  
        /// </summary>  
        /// <param name="input">密文字节数组</param>  
        /// <returns>返回解密后的字符串</returns>  
#pragma warning disable CS1573 // 参数“key”在“AESEncryptUtils.DecryptByAES(string, string, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
#pragma warning disable CS1573 // 参数“iv”在“AESEncryptUtils.DecryptByAES(string, string, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
        public static string DecryptByAES(string input, string key, string iv)
#pragma warning restore CS1573 // 参数“iv”在“AESEncryptUtils.DecryptByAES(string, string, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
#pragma warning restore CS1573 // 参数“key”在“AESEncryptUtils.DecryptByAES(string, string, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }
            var buffer = Convert.FromBase64String(input);
            using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
            {
                rijndaelManaged.Mode = CipherMode.CBC;
                rijndaelManaged.Padding = PaddingMode.PKCS7;
                rijndaelManaged.FeedbackSize = 128;

                rijndaelManaged.Key = Encoding.UTF8.GetBytes(key);
                rijndaelManaged.IV = Encoding.UTF8.GetBytes(iv);

                ICryptoTransform decryptor = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
                using (MemoryStream msEncrypt = new MemoryStream(buffer))
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srEncrypt = new StreamReader(csEncrypt))
                        {
                            return srEncrypt.ReadToEnd();
                        }
                    }
                }
            }
        }

    }
}
