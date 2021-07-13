using System;
using System.Collections.Generic;
using GGZY.Core.Extensions;
using GGZY.Core.Helper;
using GGZY.Core.Log;
using GGZY.Core.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace DZBHTestProject
{
    [TestClass]
    public class UnitTest10
    {
        [TestMethod]
        public void TestMethod1()
        {
            //通过订单编号和保函编号查询电子保函验真信息接口
            //国寿
            var url = "http://cloud.fj.chinalife-p.com.cn/TBFront/FjzjBzbxTBS.servlet";
            string systemno = "8897";
            string secret = "12345678";
            var p = new
            {
                ORDER_IDS = "FJ35042120200330000001"
            };

            var dataObj = new
            {
                SYSTEM_NO = systemno,
                DATA_KEY = Guid.NewGuid().ToString("n"),
                DATA = p
            };
            var now = DateTime.Now.ToString("yyyyMMddHHmmss");
            var data = JsonConvert.SerializeObject(dataObj);
#pragma warning disable CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            string text = systemno + now + System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(data, "MD5");
#pragma warning restore CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            string Token = TokenHelper.CreateToken(text, secret);
            string validition = "{\"SYSTEM_NO\":\"" + systemno + "\",\"TOKEN\":\"" + Token + "\",\"TIME\":\"" + now + "\"}";
            Dictionary<string, string> postData = new Dictionary<string, string>()
            {
                { "validation",validition},
                { "data",data},
            };
            Dictionary<string, string> heads = new Dictionary<string, string>()
            {
                { "transcode","queryByOrder"}
            };
            var result = new WebUtils() { Headers = heads }.DoPost(url, postData);
            Console.WriteLine(result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //通过投保人名称和招标项目编号查询电子保函验真信息接口
            //国寿
            var url = "http://cloud.fj.chinalife-p.com.cn/TBFront/FjzjBzbxTBS.servlet";
            string key = "12345678";        //密钥
            string platcode = "8891";        //交易平台编码
            string ee = DateTime.Now.ToString("yyyyMMddHHmmss");

            var checkdata = new
            {
                BIDDER_NAME = "福建中球建设工程有限公司",
                TENDER_PROJECT_CODE = "E3504219400202018001",
            };
            var dataObj = new
            {
                SYSTEM_NO = platcode,
                DATA_KEY = Guid.NewGuid().ToString("N"),
                DATA = checkdata
            };
            var data = dataObj.Serializer();
#pragma warning disable CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            string text = platcode + ee + System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(data, "MD5");
#pragma warning restore CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            string Token = TokenHelper.CreateToken(text, key);
            string validition = "{\"SYSTEM_NO\":\"" + platcode + "\",\"TOKEN\":\"" + Token + "\",\"TIME\":\"" + ee + "\"}";
            Dictionary<string, string> postData = new Dictionary<string, string>()
            {
                { "validation",validition},
                { "data",data},
            };
            Dictionary<string, string> heads = new Dictionary<string, string>()
            {
                { "transcode","queryByProject"}
            };
            Logger.Debug($"测试查询接口：data={data}&validate={validition}");
            string result = new WebUtils() { Headers = heads }.DoPost(url, postData);

            Console.WriteLine(result); ;

        }
        [TestMethod]
        public void TestMethod3()
        {
            //电子保函数据获取接口
            //国寿
            var url = "http://cloud.fj.chinalife-p.com.cn/TBFront/FjzjBzbxTBS.servlet";
            string key = "12345678";        //密钥
            string platcode = "8891";        //交易平台编码
            string ee = DateTime.Now.ToString("yyyyMMddHHmmss");

            var checkdata = new
            {
                ORDER_ID = "FJ35042120200330000001",
                GUARANTEE_NO = "6618072020350194004073"
            };
            var dataObj = new
            {
                SYSTEM_NO = platcode,
                DATA_KEY = Guid.NewGuid().ToString("N"),
                DATA = checkdata
            };
            var data = dataObj.Serializer();
#pragma warning disable CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            string text = platcode + ee + System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(data, "MD5");
#pragma warning restore CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            string Token = TokenHelper.CreateToken(text, key);
            string validition = "{\"SYSTEM_NO\":\"" + platcode + "\",\"TOKEN\":\"" + Token + "\",\"TIME\":\"" + ee + "\"}";
            Dictionary<string, string> postData = new Dictionary<string, string>()
            {
                { "validation",validition},
                { "data",data},
            };
            Dictionary<string, string> heads = new Dictionary<string, string>()
            {
                { "transcode","queryDetail"}
            };
            Logger.Debug($"测试查询接口：data={data}&validate={validition}");
            string result = new WebUtils() { Headers = heads }.DoPost(url, postData);

            Console.WriteLine(result); ;

        }
        [TestMethod]
        public void TestMethod4()
        {
            //理赔申请接口
            //国寿
            var url = "http://cloud.fj.chinalife-p.com.cn/TBFront/FjzjBzbxTBS.servlet";
            string key = "12345678";        //密钥
            string platcode = "8891";        //交易平台编码
            string ee = DateTime.Now.ToString("yyyyMMddHHmmss");

            var checkdata = new
            {
                ORDER_ID = "FJ35042120200330000001",
                GUARANTEE_NO = "6618072020350194004073",
                GUARANTEE_URL = "http://cloud.fj.chinalife-p.com.cn/TBFront/dataDownload.action?fileName=6618072020350194004073&transCode=P221101fjzjtOFD&visitorCode=1C458677A70ACDECC1B8730D54CD9B04",
                GUARANTEE_MD5 = "00EBF43EA9176FDF94DB4858660B8AED",
                CLAIM_NAME = "索赔人名称",
                CLAIM_CREDIT_CODE = "123456789123456789",
                CLAIM_TEL = "15505911111",
                CLAIM_EMAIL = "123@qq.com",
                CLAIM_AMOUNT = "300000",
                CLAIM_REASON = "围串标没收保证金",
                CLIAM_ATTACHMENT_URL = "",
                CLIAM_ATTACHMENT_MD5 = "",
            };
            var dataObj = new
            {
                SYSTEM_NO = platcode,
                DATA_KEY = Guid.NewGuid().ToString("N"),
                DATA = checkdata
            };
            var data = dataObj.Serializer();
#pragma warning disable CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            string text = platcode + ee + System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(data, "MD5");
#pragma warning restore CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            string Token = TokenHelper.CreateToken(text, key);
            string validition = "{\"SYSTEM_NO\":\"" + platcode + "\",\"TOKEN\":\"" + Token + "\",\"TIME\":\"" + ee + "\"}";
            Dictionary<string, string> postData = new Dictionary<string, string>()
            {
                { "validation",validition},
                { "data",data},
            };
            Dictionary<string, string> heads = new Dictionary<string, string>()
            {
                { "transcode","claim"}
            };
            Logger.Debug($"测试查询接口：data={data}&validate={validition}");
            string result = new WebUtils() { Headers = heads }.DoPost(url, postData);

            Console.WriteLine(result); ;

        }

        [TestMethod]
        public void TestMethod5()
        {
            var x = decimal.Parse("2.54", System.Globalization.NumberStyles.Float);
            Console.WriteLine(x);
        }
    }
}
