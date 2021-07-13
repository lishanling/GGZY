using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Core.Helper
{
    public class TokenHelper
    {
        /// <summary>
        /// 创建token用于验证
        /// </summary>
        /// <param name="message"></param>
        /// <param name="secret"></param>
        /// <returns></returns>
        public static string CreateToken(string message, string secret)
        {
            secret = secret ?? "";
            var encoding = new System.Text.UTF8Encoding();
            byte[] keyByte = encoding.GetBytes(secret);
            byte[] messageBytes = encoding.GetBytes(message);
            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
                return Convert.ToBase64String(hashmessage).Replace("+", "_").Replace("/", "_").Replace("=", "_");
            }
        }
        /// <summary>
        /// 创建验证字符串
        /// </summary>
        /// <param name="system_no">系统编码</param>
        /// <param name="key">对应密钥</param>
        /// <param name="time">时间</param>
        /// <returns></returns>
        public static string CreateValidation(string system_no, string key, string time)
        {
#pragma warning disable CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            string text = system_no + DateTime.Now.ToString("yyyyMMddHHmmss") + System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(system_no, "MD5");
#pragma warning restore CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            string Token = CreateToken(text, key);

            string validition = "<?xml version='1.0' encoding='utf-8'?><DATA><TOKEN>" + Token + "</TOKEN><SYSTEM_NO>" + system_no + "</SYSTEM_NO><TIME>" + time + "</TIME></DATA>";
            return validition;
        }
        public static string CreateValidation_Json(string system_no, string key, string time, string data)
        {
#pragma warning disable CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            string text = system_no + time + System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(data, "MD5");
#pragma warning restore CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            string Token = CreateToken(text, key);

            string validition = "{\"SYSTEM_NO\":\"" + system_no + "\",\"TOKEN\":\"" + Token + "\",\"TIME\":\"" + time + "\"}";
            return validition;
        }

        /// <summary>
        /// RSA解开信封，再DES文件解密
        /// </summary>
        /// <param name="inFilePath">待解密文件</param>
        /// <param name="outFilePath">解密后文件</param>
        /// <param name="xinfeng">信封</param>
        /// <returns></returns>
        public static string DecryptFile(string inFilePath, string outFilePath, string xinfeng)
        {
            string priKey =
                @"-----BEGIN PRIVATE KEY-----
MIICdwIBADANBgkqhkiG9w0BAQEFAASCAmEwggJdAgEAAoGBANF8dgR35+XjBs3Y
rnKbDJxF65BUzLppVofvY1+gCg86ta7/H5VtTVq2moy//k0B3rVuA5uk5s6GQeIq
PJOef3oVoAfB5T4cQwNnUdl6iKGAlr8krE7El0HY8xzztbHAJ0MQqMsZJR6w063b
Xf8By7vgflU4soJ5vkrMy4PjhLUdAgMBAAECgYATf5YsjEyVZTA48LYsDKp70TY/
1OTJZQyc0ndZazgEet52T2DNM8NDckOoXiZ5XHcyQ+8qCYtCJdT0DCJfSx1qQHwi
Mx9CKRTTYS+XTutnlzU7uOtxdoOJWXBHzzuHMp2YONqC0/wvelFW3tJgLvW/lPrN
YITD8aeGgVHPGzfSAQJBAPD8hn3HZGgNa7W/nYwgUHv8YSrp9t6N25lgfApYsmH6
GtMXmNT61qPllu4KtRu5Xiox4pHkVdDkBhi4TlumeT0CQQDeiYpcu2zpIW3PU8Qi
qzDYaz2nidbkpt2641Izls9vbwKz98cPqeJigkSUo2djOIiScUe0pgjNTWtyFuJk
filhAkEAh652fqzcEGW2Bj+bkcDD7/r6LnJKZ6XRRXr4e87SqK1rmvyHNSsB3Iew
wdfPfouQxAsQOPopgxJPiG2E2L9TNQJAZsqhXrQ0WntWfa3zqw/oQA9JK1pAKN3r
DahzD+FZb9+XIAoTqOiP6XDCvOW9m9dBPmOU+5y19B8OwmRPrpuYAQJBAJ2IzgBM
UFVLykNomSTXs5vPZC3f13rq/qDcsBLw3CZaYp+p6x9XZsVYr8rmDY3B0bX1r/r5
ascFGUNrY+K6vpU=
-----END PRIVATE KEY-----";
            string key = Encrypt.RSADecrypt(xinfeng, priKey);
            Encrypt.DESDecryptFile(inFilePath, outFilePath, key);
            return key;
        }
        /// <summary>
        /// DES文件加密，并返回信封
        /// </summary>
        /// <param name="inFilePath">加密文件</param>
        /// <param name="outFilePath">最后生成的文件</param>
        /// <param name="key">加密密钥</param>
        /// <returns>信封</returns>
        public static string EncryptFile(string inFilePath, string outFilePath, string key)
        {
            string rsaPubKey =
                @"-----BEGIN PUBLIC KEY-----
            MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDRfHYEd+fl4wbN2K5ymwycReuQ
            VMy6aVaH72NfoAoPOrWu/x+VbU1atpqMv/5NAd61bgObpObOhkHiKjyTnn96FaAH
            weU+HEMDZ1HZeoihgJa/JKxOxJdB2PMc87WxwCdDEKjLGSUesNOt213/Acu74H5V
            OLKCeb5KzMuD44S1HQIDAQAB
                 -----END PUBLIC KEY-----";
            //生成des密钥
            Encrypt.DESEncryptFile(inFilePath, outFilePath, key);

            string xinfeng = Encrypt.RSAEncrypt(key, rsaPubKey);
            return xinfeng;
        }
    }
}
