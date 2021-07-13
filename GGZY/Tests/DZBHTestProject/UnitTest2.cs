using System;
using System.Web.Mvc;
using GGZY.Core.Extensions;
using GGZY.Core.Helper;
using GGZY.DZBH.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DZBHTestProject
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestCheckDataById()
        {
            string key = "12345678";        //密钥
            string platcode = "8888";        //交易平台编码
            string ee = DateTime.Now.ToString("yyyyMMddHHmmss");

            /*var checkdata = new
            {
                ORDER_ID = "FJ2002212141001286",
                GUARANTEE_NO = "PBAQ20193303Q000E02131",
                MESSAGE_TOKEN = "474823"
            };*/
            var checkdata = new
            {
                ORDER_ID = "FJ35042120200317000006",
                GUARANTEE_NO = "PBAQ20193303Q000E02133",
                MESSAGE_TOKEN = "474823"
            };
            var dataObj = new
            {
                SYSTEM_NO = "8888",
                DATA_KEY = "112312323123123123",
                DATA = checkdata
            };
            var data = dataObj.Serializer();
#pragma warning disable CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            string text = platcode + ee + System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(data, "MD5");
#pragma warning restore CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            string Token = TokenHelper.CreateToken(text, key);
            string validition = "{\"SYSTEM_NO\":\"" + platcode + "\",\"TOKEN\":\"" + Token + "\",\"TIME\":\"" + ee + "\"}" ;
            GetDataController gdc = new GetDataController();
            ContentResult s = gdc.CheckDataById(validition, data) as ContentResult;
            Console.Write(s.Content.Serializer());
        }
        [TestMethod]
        public void TestCheckDataByBidderName()
        {
            string key = "12345678";        //密钥
            string platcode = "8888";        //交易平台编码
            string ee = DateTime.Now.ToString("yyyyMMddHHmmss");

            var checkdata = new
            {
                TENDER_PROJECT_CODE = "E3500000001001043001",
                BIDDER_NAME = "测试投标人Y",
            };
            var dataObj = new
            {
                SYSTEM_NO = "8888",
                DATA_KEY = "112312323123123123",
                DATA = checkdata
            };
            var data = dataObj.Serializer();
            data =
                "{SYSTEM_NO:'8888',DATA_KEY:'1302da9d-c986-460b-93a0-45e8875427a5',DATA:{ TENDER_PROJECT_CODE:'E3500000001001043001',BIDDER_NAME:'测试投标人Y'}}";
#pragma warning disable CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            string text = platcode + ee + System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(data, "MD5");
#pragma warning restore CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            string Token = TokenHelper.CreateToken(text, key);
            string validition = "{\"SYSTEM_NO\":\"" + platcode + "\",\"TOKEN\":\"" + Token + "\",\"TIME\":\"" + ee + "\"}";
            GetDataController gdc = new GetDataController();
            ContentResult s = gdc.CheckDataByBidderName(validition, data) as ContentResult;
            Console.Write(s.Content.Serializer());
        }

        [TestMethod]
        public void TestSendToken()
        {
            string key = "12345678";        //密钥
            string platcode = "8888";        //交易平台编码
            string ee = DateTime.Now.ToString("yyyyMMddHHmmss");

            var checkdata = new
            {
                ORDER_ID = "FJ35042120200330000001",
                GUARANTEE_NO = "G200417153313421596",
            };
            var dataObj = new
            {
                SYSTEM_NO = "8888",
                DATA_KEY = "112312323123123123",
                DATA = checkdata
            };
            var data = dataObj.Serializer();
#pragma warning disable CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            string text = platcode + ee + System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(data, "MD5");
#pragma warning restore CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            string Token = TokenHelper.CreateToken(text, key);
            string validition = "{\"SYSTEM_NO\":\"" + platcode + "\",\"TOKEN\":\"" + Token + "\",\"TIME\":\"" + ee + "\"}";
            GetDataController gdc = new GetDataController();
            ContentResult s = gdc.SendMessageToken(validition, data) as ContentResult;
            Console.Write(s.Content.Serializer());
        }
    }
}
