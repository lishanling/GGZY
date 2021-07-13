using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using GGZY.Core.Helper;
using PullData.Credit;
using PullData.Helper;
using PullData.Model;

namespace PullData
{
    public class Main
    {
        private const string _USERNAME = "lhjc_test";
        private const string _PASSWORD = "1234@qwe";
        /*private const string _USERNAME = "ggzy_lhjc";
        private const string _PASSWORD = "lhjc_8715";*/
        /// <summary>
        /// 登录系统
        /// </summary>
        /// <returns></returns>
        private string Login()
        {
            //登录
            AppV1 app = new AppV1();
            string loginXml = app.BeginLogin(_USERNAME);
            Dictionary<string, string> loginDict = XmlHelper.FromXmlToDict(loginXml);
            if (loginDict.ContainsKey("Code") && loginDict["Code"].ToString() == "00")
            {
                string salt = loginDict.ContainsKey("Content") ? loginDict["Content"].ToString() : "";
                if (!string.IsNullOrEmpty(salt))
                {
                    RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                    StreamReader sr =
                        new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "\\Cert\\Passport加密公钥.xml");
                    string rsaXml = sr.ReadToEnd();
                    sr.Close();
                    rsa.FromXmlString(rsaXml);
                    string plainText = $"{_PASSWORD}|{salt}";
                    byte[] plainData = Encoding.UTF8.GetBytes(plainText);
                    byte[] cipherData = rsa.Encrypt(plainData, false);
                    string cipherText = Convert.ToBase64String(cipherData);
                    string endLoginXml = app.EndLogin(_USERNAME, salt, cipherText);
                    Dictionary<string, string> endLoginDict = XmlHelper.FromXmlToDict(endLoginXml);
                    if (endLoginDict.ContainsKey("Code") && endLoginDict["Code"].ToString() == "00")
                    {
                        string token = endLoginDict.ContainsKey("Content") ? endLoginDict["Content"].ToString() : "";
                        return token;
                    }
                }
            }

            return "";
        }
        /// <summary>
        /// 验证企业
        /// </summary>
        /// <param name="companyId">企业的统一社会信用代码</param>
        /// <returns></returns>
        public PoorCreditResult CheckOrg(string companyId)
        {
            AppV1 app = new AppV1();
            string xml = app.GeneralOrgCheck(Login(), companyId, "");
            PoorCreditResult result = XmlHelper.XmlToResult(xml);
            return result;
        }
        /// <summary>
        /// 验证个人
        /// </summary>
        /// <param name="idCardNo">身份证</param>
        /// <param name="name">姓名</param>
        /// <returns></returns>
        public PoorCreditResult CheckPerson(string idCardNo, string name)
        {
            AppV1 app = new AppV1();
            string xml = app.GeneralIndividualCheck(Login(), name, "1", idCardNo, "");
            PoorCreditResult result = XmlHelper.XmlToResult(xml);
            return result;
        }
        /// <summary>
        /// 反馈惩戒
        /// </summary>
        /// <param name="ticket">查验返回的票据</param>
        /// <param name="org">单位名称</param>
        /// <param name="biz">办理事项名称</param>
        /// <param name="measure">实施惩戒情况</param>
        /// <param name="amountInvolved">涉及的金额</param>
        /// <param name="actualOrgUser">实际提交这条惩戒信息的惩戒实施机构单位的统一社会信用代码</param>
        /// <returns></returns>
        public Result SubmitPunishment(string ticket, string org, string biz, string measureName, string measure, string amountInvolved, string actualOrgUser)
        {
            string token = Login(); //示例值
            ticket = "F7B5A57504D945C383C3A81EF8E947EB"; //示例值
            AppV1 app = new AppV1();
            string time = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            string message =
                $"method=SubmitPunishment&token={token}&ticket={ticket}&org={org}&biz={biz}&timestamp={time}";
            string xml = app.SubmitPunishment(token, ticket, org, biz, measureName, measure, amountInvolved, actualOrgUser, time, Sign(message));
            //string xml = app.SubmitPunishment(token, ticket, org, biz, measure, amountInvolved, actualOrgUser, time, Sign(message));
            Result result = XmlHelper.DeSerialize<Result>(xml, Encoding.UTF8);
            return result;
        }
        /// <summary>
        /// 撤销惩戒
        /// </summary>
        /// <param name="id">要撤销的惩戒信息的 ID</param>
        /// <param name="reason">撤销原因</param>
        /// <returns></returns>
        public Result RevokePunishment(string id, string reason)
        {
            string token = Login(); //示例值
            id = "276731628D3F418F9F2187F9041F939B"; //示例值
            AppV1 app = new AppV1();
            string time = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            string message =
                $"method=RevokePunishment&token={token}&id={id}&timestamp={time}";
            string xml = app.RevokePunishment(token, id, reason, time, Sign(message));
            Result result = XmlHelper.DeSerialize<Result>(xml, Encoding.UTF8);
            return result;
        }
        /// <summary>
        /// 签名
        /// </summary>
        /// <param name="message">要签名的信息</param>
        /// <returns></returns>
        public string Sign(string message)
        {
            byte[] messageData = Encoding.UTF8.GetBytes(message);
            //包含签名私钥的RSA算法实例；
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
#pragma warning disable CS0219 // 变量“pubKey”已被赋值，但从未使用过它的值
            string pubKey = @"-----BEGIN PUBLIC KEY-----
MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDif5hw0vXhyJx5YMPfXAsA1Iko
1CXSefLDGpg85BpmeJ1XNmaNoDFjU0CshpSRtX9RSLe4egw81YZ5iO1IZwkVeZtk
ULcAAfzImPAav2Qlk3f7W27ePU4ZWj1zC9ygzAKKXxCqWEtSHgOcJmDI9gMphhME
opj7iXe3tqEfuHmsiwIDAQAB
-----END PUBLIC KEY-----";
#pragma warning restore CS0219 // 变量“pubKey”已被赋值，但从未使用过它的值
            string priKey = @"-----BEGIN PRIVATE KEY-----
MIICdwIBADANBgkqhkiG9w0BAQEFAASCAmEwggJdAgEAAoGBAOJ/mHDS9eHInHlg
w99cCwDUiSjUJdJ58sMamDzkGmZ4nVc2Zo2gMWNTQKyGlJG1f1FIt7h6DDzVhnmI
7UhnCRV5m2RQtwAB/MiY8Bq/ZCWTd/tbbt49ThlaPXML3KDMAopfEKpYS1IeA5wm
YMj2AymGEwSimPuJd7e2oR+4eayLAgMBAAECgYBwNQv9INXE9BBopUKEHeIpmCEX
A/p0ygs1ErDGwa4+g5RXB1FI6kptTWolzko94S9gwmiZ0ITNgm6rOOVsT/cUKH5T
91xEIMxzPzPPct9gd/PUCe/OPVKYLR8fVuG9k918KjatPaV6AJymsGwD23JnV0e6
Sk3sGezpQuMeuaKYiQJBAP8RDNNu1A9EmYwG0JApzol/pSahSiFDlx7QGg81GV7I
TsWFOlYVXORN0ACJJOCEebJGGLFrDHJXj2ccMKB4WxUCQQDjU8hFHaDtrSsONjvS
FagX6onGippCPq3quPfkUiW6RUeEK315OmZfm5v2YqJgjq3bzZpnX3K28/oLH1Ty
AVEfAkBFqXdyS4OZQ+gXyUivBuwEu5r0aPqhCR+956ImYx8xts1kvtVG64C6TdIw
Q0SSGTxPhzt5QT5eADIHPDi/qv9dAkEAn+gLdDLHROkO5ExaAAmj2E7u424T3I1i
oT3DgiQWzdR13g8JkAD4ikBXkRUIy4sR2Q/jkNufQfqU5MYBZspuWQJBAJUI5jgV
MhqLlq9GhorloSbkWYZIS0QB/ypQHeXZKisNVYLcjsMVA8IROHXxKTgB2pVoFPnK
0e/I7euIeXD8kQE=
-----END PRIVATE KEY-----";
            string priXmlKey = Encrypt.PemToRSAKey(priKey, true);
            rsa.FromXmlString(priXmlKey);
            HashAlgorithm hashAlgorithm = new SHA256Managed();
            byte[] signatureData = rsa.SignData(messageData, hashAlgorithm);
            string signature = Convert.ToBase64String(signatureData);
            return signature;
        }
    }
}
