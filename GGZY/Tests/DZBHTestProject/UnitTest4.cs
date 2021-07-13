using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using GGZY.Core.Converters;
using GGZY.Core.Extensions;
using GGZY.Core.Helper;
using GGZY.Core.Log;
using GGZY.Core.Utils;
using GGZY.DZBH.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace DZBHTestProject
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod1()
        {
            string key = "12345678";        //密钥
            string platcode = "8888";        //交易平台编码
            string ee = DateTime.Now.ToString("yyyyMMddHHmmss");

            var checkdata = new
            {
                ORDER_IDS = "",
                GUARANTEE_NOS = "PBAQ20203303Q000E01060",
            };
            var dataObj = new
            {
                SYSTEM_NO = "8888",
                DATA_KEY = "112312323123123123",
                DATA = checkdata
            };
            var data = JsonConvert.SerializeObject(dataObj);
#pragma warning disable CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            string text = platcode + ee + System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(data, "MD5");
#pragma warning restore CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            string Token = TokenHelper.CreateToken(text, key);
            string validition = "{\"SYSTEM_NO\":\"" + platcode + "\",\"TOKEN\":\"" + Token + "\",\"TIME\":\"" + ee + "\"}";
            Dictionary<string, string> postData = new Dictionary<string, string>()
            {
                { "validation",HttpUtility.UrlEncode(validition)},
                { "data",HttpUtility.UrlEncode(data)},
            };
            Logger.Debug($"测试查询接口：data={data}&validate={validition}");
            string url = "http://118.190.36.90:5078/api/ResourceCenter/GuaranteeByOrderIdsAndPolicyNos";
            string result = new WebUtils().DoPost(url, postData);

            Console.WriteLine(result); ;

        }
        [TestMethod]
        public void TestMethod2()
        {
            string key = "12345678";        //密钥
            string platcode = "8888";        //交易平台编码
            string ee = DateTime.Now.ToString("yyyyMMddHHmmss");

            var checkdata = new
            {
                BIDDER_NAME = "123",
                TENDER_PROJECT_CODE = "E3504219400030007001",
            };
            var dataObj = new
            {
                SYSTEM_NO = "8888",
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
                { "validation",HttpUtility.UrlEncode(validition)},
                { "data",HttpUtility.UrlEncode(data)},
            };
            Logger.Debug($"测试查询接口：data={data}&validate={validition}");
            string url = "http://118.190.36.90:5078/api/ResourceCenter/GuaranteeByNameAndCode";
            string result = new WebUtils().DoPost(url, postData);

            Console.WriteLine(result); ;

        }
       
    }
}
