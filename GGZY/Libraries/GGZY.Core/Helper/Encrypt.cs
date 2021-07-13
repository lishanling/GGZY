using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using GGZY.Core.Log;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace GGZY.Core.Helper
{
    public class Encrypt
    {
        #region MD5加密
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="str">要进行加密字符串</param>
        /// <param name="code">16或32</param>
        /// <returns></returns>
        public static string MD5(string str, int code)
        {
            if (code == 16) //16位MD5加密（取32位加密的9~25字符） 
            {
#pragma warning disable CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
                return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5").ToLower().Substring(8, 16);
#pragma warning restore CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            }
            if (code == 32) //32位加密 
            {
#pragma warning disable CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
                return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5").ToLower();
#pragma warning restore CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            }
            return "00000000000000000000000000000000";
        }
        #endregion

        #region Base64加密
        /// <summary>
        /// Base64加密
        /// </summary>
        /// <param name="Message"></param>
        /// <returns></returns>
        public static string Base64Code(string Message)
        {
            char[] Base64Code = new char[]{'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T',
                                        'U','V','W','X','Y','Z','a','b','c','d','e','f','g','h','i','j','k','l','m','n',
                                        'o','p','q','r','s','t','u','v','w','x','y','z','0','1','2','3','4','5','6','7',
                                        '8','9','+','/','='};
            byte empty = (byte)0;
            System.Collections.ArrayList byteMessage = new System.Collections.ArrayList(System.Text.Encoding.Default.GetBytes(Message));
            System.Text.StringBuilder outmessage;
            int messageLen = byteMessage.Count;
            //将字符分成3个字节一组，如果不足，则以0补齐
            int page = messageLen / 3;
            int use = 0;
            if ((use = messageLen % 3) > 0)
            {
                for (int i = 0; i < 3 - use; i++)
                    byteMessage.Add(empty);
                page++;
            }
            //将3个字节的每组字符转换成4个字节一组的。3个一组，一组一组变成4个字节一组
            //方法是：转换成ASCII码，按顺序排列24 位数据，再把这24位数据分成4组，即每组6位。再在每组的的最高位前补两个0凑足一个字节。
            outmessage = new System.Text.StringBuilder(page * 4);
            for (int i = 0; i < page; i++)
            {
                //取一组3个字节的组
                byte[] instr = new byte[3];
                instr[0] = (byte)byteMessage[i * 3];
                instr[1] = (byte)byteMessage[i * 3 + 1];
                instr[2] = (byte)byteMessage[i * 3 + 2];
                //六个位为一组，补0变成4个字节
                int[] outstr = new int[4];
                //第一个输出字节：取第一输入字节的前6位，并且在高位补0，使其变成8位（一个字节）
                outstr[0] = instr[0] >> 2;
                //第二个输出字节：取第一输入字节的后2位和第二个输入字节的前4位（共6位），并且在高位补0，使其变成8位（一个字节）
                outstr[1] = ((instr[0] & 0x03) << 4) ^ (instr[1] >> 4);
                //第三个输出字节：取第二输入字节的后4位和第三个输入字节的前2位（共6位），并且在高位补0，使其变成8位（一个字节）
                if (!instr[1].Equals(empty))
                    outstr[2] = ((instr[1] & 0x0f) << 2) ^ (instr[2] >> 6);
                else
                    outstr[2] = 64;
                //第四个输出字节：取第三输入字节的后6位，并且在高位补0，使其变成8位（一个字节）
                if (!instr[2].Equals(empty))
                    outstr[3] = (instr[2] & 0x3f);
                else
                    outstr[3] = 64;
                outmessage.Append(Base64Code[outstr[0]]);
                outmessage.Append(Base64Code[outstr[1]]);
                outmessage.Append(Base64Code[outstr[2]]);
                outmessage.Append(Base64Code[outstr[3]]);
            }
            return outmessage.ToString();
        }
        #endregion

        #region Base64解密
        /// <summary>
        /// Base64解密
        /// </summary>
        /// <param name="Message"></param>
        /// <returns></returns>
        public static string Base64Decode(string Message)
        {
            if ((Message.Length % 4) != 0)
            {
                throw new ArgumentException("不是正确的BASE64编码，请检查。", "Message");
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(Message, "^[A-Z0-9/+=]*$", System.Text.RegularExpressions.RegexOptions.IgnoreCase))
            {
                throw new ArgumentException("包含不正确的BASE64编码，请检查。", "Message");
            }
            string Base64Code = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/=";
            int page = Message.Length / 4;
            System.Collections.ArrayList outMessage = new System.Collections.ArrayList(page * 3);
            char[] message = Message.ToCharArray();
            for (int i = 0; i < page; i++)
            {
                byte[] instr = new byte[4];
                instr[0] = (byte)Base64Code.IndexOf(message[i * 4]);
                instr[1] = (byte)Base64Code.IndexOf(message[i * 4 + 1]);
                instr[2] = (byte)Base64Code.IndexOf(message[i * 4 + 2]);
                instr[3] = (byte)Base64Code.IndexOf(message[i * 4 + 3]);
                byte[] outstr = new byte[3];
                outstr[0] = (byte)((instr[0] << 2) ^ ((instr[1] & 0x30) >> 4));
                if (instr[2] != 64)
                {
                    outstr[1] = (byte)((instr[1] << 4) ^ ((instr[2] & 0x3c) >> 2));
                }
                else
                {
                    outstr[2] = 0;
                }
                if (instr[3] != 64)
                {
                    outstr[2] = (byte)((instr[2] << 6) ^ instr[3]);
                }
                else
                {
                    outstr[2] = 0;
                }
                outMessage.Add(outstr[0]);
                if (outstr[1] != 0)
                    outMessage.Add(outstr[1]);
                if (outstr[2] != 0)
                    outMessage.Add(outstr[2]);
            }
            byte[] outbyte = (byte[])outMessage.ToArray(Type.GetType("System.Byte"));
            return System.Text.Encoding.Default.GetString(outbyte);
        }
        #endregion


        public static string strIV = "u-name_+";
        #region des加密
        
#pragma warning disable CS1572 // XML 注释中有“_strQ”的 param 标记，但是没有该名称的参数
/// <summary>
        /// 加密
        /// </summary>
        /// <param name="_strQ"></param>
        /// <returns></returns>
#pragma warning disable CS1573 // 参数“strKey”在“Encrypt.DESEncrypt(string, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
#pragma warning disable CS1573 // 参数“strQ”在“Encrypt.DESEncrypt(string, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
        public static string DESEncrypt(string strQ, string strKey)
#pragma warning restore CS1572 // XML 注释中有“_strQ”的 param 标记，但是没有该名称的参数
#pragma warning restore CS1573 // 参数“strQ”在“Encrypt.DESEncrypt(string, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
#pragma warning restore CS1573 // 参数“strKey”在“Encrypt.DESEncrypt(string, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
        {

            byte[] buffer = Encoding.UTF8.GetBytes(strQ);
            MemoryStream ms = new MemoryStream();
            DESCryptoServiceProvider tdes = new DESCryptoServiceProvider();
            CryptoStream encStream = new CryptoStream(ms, tdes.CreateEncryptor(Encoding.UTF8.GetBytes(strKey), Encoding.UTF8.GetBytes(strIV)), CryptoStreamMode.Write);
            encStream.Write(buffer, 0, buffer.Length);
            encStream.FlushFinalBlock();
            return Convert.ToBase64String(ms.ToArray());
        }
        #endregion

        #region des解密
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="_strQ"></param>
        /// <returns></returns>
#pragma warning disable CS1573 // 参数“strKey”在“Encrypt.DESDecrypt(string, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
        public static string DESDecrypt(string _strQ, string strKey)
#pragma warning restore CS1573 // 参数“strKey”在“Encrypt.DESDecrypt(string, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
        {
            try
            {
                byte[] buffer = Convert.FromBase64String(_strQ);
                MemoryStream ms = new MemoryStream();
                DESCryptoServiceProvider tdes = new DESCryptoServiceProvider();
                CryptoStream encStream = new CryptoStream(ms, tdes.CreateDecryptor(Encoding.UTF8.GetBytes(strKey), Encoding.UTF8.GetBytes(strIV)), CryptoStreamMode.Write);
                encStream.Write(buffer, 0, buffer.Length);
                encStream.FlushFinalBlock();
                return Encoding.UTF8.GetString(ms.ToArray());
            }
            catch (Exception e)
            {
               Logger.Error($"DES解密失败:{_strQ}",e);
               throw new Exception($"参数{_strQ}异常",e);
            }
        }
        #endregion

        #region 获取文件md5
        /// <summary>
        /// 获取文件的MD5
        /// </summary>
        /// <param name="fileName">文件路径</param>
        /// <returns></returns>
        public static string GetFileMD5(string fileName)
        {
            try
            {
                FileStream file = new FileStream(fileName, FileMode.Open);
                System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] retVal = md5.ComputeHash(file);
                file.Close();

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("GetMD5HashFromFile() fail,error:" + ex.Message);
            }
        }
        #endregion

        #region RSA加密
        /// <summary>
        /// 使用base64公钥进行加密
        /// </summary>
        /// <param name="content"></param>
        /// <param name="pubKey"></param>
        /// <returns></returns>
        public static string RSAEncrypt(string content, string pubKey)
        {
            string key = PemToRSAKey(pubKey, false);
            return RSAEncryptXml(content, key);
        }

        
#pragma warning disable CS1572 // XML 注释中有“msg”的 param 标记，但是没有该名称的参数
/// <summary>
        /// RSA加密
        /// </summary>
        /// <param name="msg">加密内容</param>
        /// <param name="pubKey">公钥（xml格式）</param>
        /// <returns></returns>
#pragma warning disable CS1573 // 参数“content”在“Encrypt.RSAEncryptXml(string, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
        public static string RSAEncryptXml(string content, string pubKey)
#pragma warning restore CS1572 // XML 注释中有“msg”的 param 标记，但是没有该名称的参数
#pragma warning restore CS1573 // 参数“content”在“Encrypt.RSAEncryptXml(string, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
        {
            string encryptedMsg = string.Empty;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(pubKey);
                byte[] encryptedData = rsa.Encrypt(Encoding.UTF8.GetBytes(content), false);
                encryptedMsg = Convert.ToBase64String(encryptedData);
            }

            return encryptedMsg;
        }
        #endregion

        #region RSA解密
        /// <summary>
        /// 使用base64私钥解密
        /// </summary>
        /// <param name="content"></param>
        /// <param name="priKey"></param>
        /// <returns></returns>
        public static string RSADecrypt(string content, string priKey)
        {
            string key = PemToRSAKey(priKey, true);
            return RSADecryptXml(content, key);
        }
        /// <summary>
        /// RSA解密
        /// </summary>
        /// <param name="content">解密内容</param>
        /// <param name="priKey">私钥（xml格式）</param>
        /// <returns></returns>
        public static string RSADecryptXml(string content, string priKey)
        {
            string decryptedContent = string.Empty;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(priKey);
                byte[] decryptedData = rsa.Decrypt(Convert.FromBase64String(content), false);
                decryptedContent = Encoding.GetEncoding("gb2312").GetString(decryptedData);
            }
            return decryptedContent;
        }
        #endregion

        #region RSA密钥转换
        /// <summary>
        /// C#xml密钥转base64密钥
        /// </summary>
        /// <param name="RSAKey"></param>
        /// <param name="isPrivateKey"></param>
        /// <returns></returns>
        public static string RSAKeyToPem(string RSAKey, bool isPrivateKey)
        {
            string pemKey = string.Empty;
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(RSAKey);
            RSAParameters rsaPara = new RSAParameters();
            RsaKeyParameters key = null;
            if (isPrivateKey)
            {
                rsaPara = rsa.ExportParameters(true);
                key = new RsaPrivateCrtKeyParameters(
                        new BigInteger(1, rsaPara.Modulus), new BigInteger(1, rsaPara.Exponent), new BigInteger(1, rsaPara.D),
                        new BigInteger(1, rsaPara.P), new BigInteger(1, rsaPara.Q), new BigInteger(1, rsaPara.DP), new BigInteger(1, rsaPara.DQ),
                        new BigInteger(1, rsaPara.InverseQ));
            }
            else
            {
                rsaPara = rsa.ExportParameters(false);
                key = new RsaKeyParameters(false,
                    new BigInteger(1, rsaPara.Modulus),
                    new BigInteger(1, rsaPara.Exponent));
            }

            using (TextWriter sw = new StringWriter())
            {
                var pemWriter = new Org.BouncyCastle.OpenSsl.PemWriter(sw);
                pemWriter.WriteObject(key);
                pemWriter.Writer.Flush();
                pemKey = sw.ToString();
            }
            return pemKey;
        }
        /// <summary>
        /// base64密钥转xml密钥
        /// </summary>
        /// <param name="pemKey"></param>
        /// <param name="isPrivateKey"></param>
        /// <returns></returns>
        public static string PemToRSAKey(string pemKey, bool isPrivateKey)
        {
            string rsaKey = string.Empty;
            object pemObject = null;
            RSAParameters rsaPara = new RSAParameters();
            using (StringReader sReader = new StringReader(pemKey))
            {
                Org.BouncyCastle.OpenSsl.PemReader pemReader = new Org.BouncyCastle.OpenSsl.PemReader(sReader);
                pemObject = pemReader.ReadObject();
            }
            //RSA私钥
            if (isPrivateKey)
            {
                //RsaPrivateCrtKeyParameters key = (RsaPrivateCrtKeyParameters)(((AsymmetricCipherKeyPair)pemObject).Private);
                RsaPrivateCrtKeyParameters key = (RsaPrivateCrtKeyParameters)pemObject;
                rsaPara = new RSAParameters
                {
                    Modulus = key.Modulus.ToByteArrayUnsigned(),
                    Exponent = key.PublicExponent.ToByteArrayUnsigned(),
                    D = key.Exponent.ToByteArrayUnsigned(),
                    P = key.P.ToByteArrayUnsigned(),
                    Q = key.Q.ToByteArrayUnsigned(),
                    DP = key.DP.ToByteArrayUnsigned(),
                    DQ = key.DQ.ToByteArrayUnsigned(),
                    InverseQ = key.QInv.ToByteArrayUnsigned(),
                };
            }
            //RSA公钥
            else
            {
                RsaKeyParameters key = (RsaKeyParameters)pemObject;
                rsaPara = new RSAParameters
                {
                    Modulus = key.Modulus.ToByteArrayUnsigned(),
                    Exponent = key.Exponent.ToByteArrayUnsigned(),
                };
            }
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.ImportParameters(rsaPara);
            using (StringWriter sw = new StringWriter())
            {
                sw.Write(rsa.ToXmlString(isPrivateKey ? true : false));
                rsaKey = sw.ToString();
            }
            return rsaKey;
        }
        #endregion

        #region DES文件加密
        private static byte[] desIv = new byte[] { 0xF, 0x56, 0x52, 0xCD, 0xFF, 0x3F, 0x5D, 0x4 };
        /// <summary>
        /// des文件加密
        /// </summary>
        /// <param name="inFilePath">加密文件地址</param>
        /// <param name="outFilePath">加密后的文件地址</param>
        /// <param name="desKeyStr">密钥</param>
        public static void DESEncryptFile(string inFilePath, string outFilePath, string desKeyStr)
        {
            byte[] desKey = System.Text.Encoding.UTF8.GetBytes(desKeyStr.Substring(0, 8));
            FileStream ins = new FileStream(inFilePath, FileMode.Open, FileAccess.Read);
            FileStream outs = new FileStream(outFilePath, FileMode.OpenOrCreate, FileAccess.Write);
            outs.SetLength(0);
            byte[] buffer = new byte[1024 * 512];
            long readLen = 0;
            long totlen = ins.Length;
            int len;
            DES des = new DESCryptoServiceProvider();
            CryptoStream encStream = new CryptoStream(outs, des.CreateEncryptor(desKey, desIv), CryptoStreamMode.Write);
            while (readLen < totlen)
            {
                len = ins.Read(buffer, 0, buffer.Length);
                encStream.Write(buffer, 0, len);
                readLen += len;
            }
            encStream.Close();
            outs.Close();
            ins.Close();
        }

        #endregion

        #region DES文件解密
        /// <summary>
        /// DES问解密
        /// </summary>
        /// <param name="inFilePath">需要解密的文件地址</param>
        /// <param name="outFilePath">解密后的文件地址</param>
        /// <param name="desKeyStr">密钥</param>
        public static void DESDecryptFile(string inFilePath, string outFilePath, string desKeyStr)
        {
            byte[] desKey = System.Text.Encoding.UTF8.GetBytes(desKeyStr.Substring(0, 8));
            FileStream ins = new FileStream(inFilePath, FileMode.Open, FileAccess.Read);
            FileStream outs = new FileStream(outFilePath, FileMode.OpenOrCreate, FileAccess.Write);
            outs.SetLength(0);
            byte[] buffer = new byte[1024 * 512];
            long readLen = 0;
            long totlLen = ins.Length;
            int len;
            DES des = new DESCryptoServiceProvider();
            CryptoStream dencStream = new CryptoStream(outs, des.CreateDecryptor(desKey, desIv), CryptoStreamMode.Write);
            while (readLen < totlLen)
            {
                len = ins.Read(buffer, 0, buffer.Length);
                dencStream.Write(buffer, 0, len);
                readLen += len;
            }
            dencStream.Close();
            outs.Close();
            ins.Close();
        }
        #endregion

    }
}
