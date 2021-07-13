using System;
using System.Collections.Generic;
using System.Web;
using GGZY.Core.Extensions;
using GGZY.Core.Helper;
using GGZY.Core.Log;
using GGZY.Core.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace DZBHTestProject
{
    [TestClass]
    public class UnitTest8
    {
        [TestMethod]
        public void TestMethod1()
        {
            //通过订单编号和保函编号查询电子保函验真信息接口
            //触网
            //var url = "http://120.24.78.89:30001/szx/guarantee/CheckDataByOrderAndGuarantee";
            //汇友
            //var url = "http://211.159.241.25:7000/HYPICCoreInterf/smQueryByOrderAndPolicyNoServlet";
            //振兴
            //var url = "http://fujianbh.com/manager/api/remote/authenticity";
            //国资担保
            var url = "http://101.201.127.167:8181/gd/api/searchByOG";
            //太平洋
            //var url = "http://api.zhongtongbao.com.cn/index/center/checkOrderNumber";
            
            string systemno = "8895";
            string secret = "12345678";
            var p = new
            {
                ORDER_IDS = "FJ35042120200409000006"
            };

            var dataObj = new
            {
                SYSTEM_NO = systemno,
                DATA_KEY = Guid.NewGuid().ToString("n"),
                DATA = p
            };
            var now = DateTime.Now.ToString("yyyyMMddHHmmss");
            var data = JsonConvert.SerializeObject(dataObj);
            string text = systemno + now + System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(data, "MD5");
            string Token = TokenHelper.CreateToken(text, secret);
            string validition = "{\"SYSTEM_NO\":\"" + systemno + "\",\"TOKEN\":\"" + Token + "\",\"TIME\":\"" + now + "\"}";
            Dictionary<string, string> postData = new Dictionary<string, string>()
            {
                { "validation",validition},
                { "data",data},
            };
            var result = new WebUtils().DoPost(url, postData);
            Console.WriteLine(result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //通过投保人名称和招标项目编号查询电子保函验真信息接口
            //触网
            //var url = "http://120.24.78.89:30001/szx/guarantee/CheckDataByBidderAndProject";
            //汇友
            //var url = "http://211.159.241.25:7000/HYPICCoreInterf/smQueryByAppliAndItemIdServlet";
            //振兴
            //var url = "http://fujianbh.com/manager/api/remote/bidder";
            //国资担保
            var url = "http://101.201.127.167:8181/gd/api/searchByTB";
            //太平洋
            //var url = "http://api.zhongtongbao.com.cn/index/center/checkOrderName";
            string key = "12345678";        //密钥
            string platcode = "8895";        //交易平台编码
            string ee = DateTime.Now.ToString("yyyyMMddHHmmss");

            var checkdata = new
            {
                BIDDER_NAME = "福建中球建设工程有限公司",
                TENDER_PROJECT_CODE = "E3504219400202007001",
            };
            var dataObj = new
            {
                SYSTEM_NO = platcode,
                DATA_KEY = Guid.NewGuid().ToString("N"),
                DATA = checkdata
            };
            var data = JsonConvert.SerializeObject(dataObj);
            string text = platcode + ee + System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(data, "MD5");
            string Token = TokenHelper.CreateToken(text, key);
            string validition = "{\"SYSTEM_NO\":\"" + platcode + "\",\"TOKEN\":\"" + Token + "\",\"TIME\":\"" + ee + "\"}";
            Dictionary<string, string> postData = new Dictionary<string, string>()
            {
                { "validation",validition},
                { "data",data},
            };
            Logger.Debug($"测试查询接口：data={data}&validate={validition}");
            string result = new WebUtils().DoPost(url, postData);

            Console.WriteLine(result); ;

        }
        [TestMethod]
        public void TestMethod3()
        {
            //电子保函数据获取接口
            //触网
            //var url = "http://120.24.78.89:30001/szx/guarantee/getGuarantee";
            //汇友
            //var url = "http://211.159.241.25:7000/HYPICCoreInterf/smGetPolicyInfoServlet";
            //振兴
            //var url = "http://fujianbh.com/manager/api/remote/get";
            //国资担保
            var url = "http://101.201.127.167:8181/gd/api/getBhInfo";
            //太平洋
            //var url = "http://api.zhongtongbao.com.cn/index/center/getDetail";
            string key = "12345678";        //密钥
            string platcode = "8895";        //交易平台编码
            string ee = DateTime.Now.ToString("yyyyMMddHHmmss");

            var checkdata = new
            {
                ORDER_ID = "FJ35042120200409000006"
            };
            var dataObj = new
            {
                SYSTEM_NO = platcode,
                DATA_KEY = Guid.NewGuid().ToString("N"),
                DATA = checkdata
            };
            var data = JsonConvert.SerializeObject(dataObj);
            string text = platcode + ee + System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(data, "MD5");
            string Token = TokenHelper.CreateToken(text, key);
            string validition = "{\"SYSTEM_NO\":\"" + platcode + "\",\"TOKEN\":\"" + Token + "\",\"TIME\":\"" + ee + "\"}";
            Dictionary<string, string> postData = new Dictionary<string, string>()
            {
                { "validation",validition},
                { "data",data},
            };
            Logger.Debug($"测试查询接口：data={data}&validate={validition}");
            string result = new WebUtils().DoPost(url, postData);

            Console.WriteLine(result); ;

        }
        [TestMethod]
        public void TestMethod4()
        {
            //理赔申请接口
            //触网
            //var url = "http://120.24.78.89:30001/szx/guarantee/claims";
            //汇友
            //var url = "http://211.159.241.25:7000/HYPICCoreInterf/smClaimServlet";
            //振兴
            //var url = "http://fujianbh.com/manager/api/remote/claim";
            //国资担保
            var url = "http://101.201.127.167:8181/gd/api/suopei";
            //太平洋
            //var url = "http://api.zhongtongbao.com.cn/index/center/reqCompensation";
            string key = "12345678";        //密钥
            string platcode = "8895";        //交易平台编码
            string ee = DateTime.Now.ToString("yyyyMMddHHmmss");

            var checkdata = new
            {
                ORDER_ID = "FJ35042120200409000006",
                GUARANTEE_NO = "GD2020121410312971f00296",
                GUARANTEE_URL = "http://192.168.3.166:8080/gd//uApi/downFile?orderid=FJ35042120200409000006&fileType=6",
                GUARANTEE_MD5 = "15975F08136736AC95C5FE47019B6255",
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
            var data = JsonConvert.SerializeObject(dataObj);
            string text = platcode + ee + System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(data, "MD5");
            string Token = TokenHelper.CreateToken(text, key);
            string validition = "{\"SYSTEM_NO\":\"" + platcode + "\",\"TOKEN\":\"" + Token + "\",\"TIME\":\"" + ee + "\"}";
            Dictionary<string, string> postData = new Dictionary<string, string>()
            {
                { "validation",validition},
                { "data",data},
            };
            Logger.Debug($"测试查询接口：data={data}&validate={validition}");
            string result = new WebUtils().DoPost(url, postData);

            Console.WriteLine(result);

        }

        [TestMethod]
        public void TestMethod5()
        {
            string text = "888920201207220830706A25E1F65AF75A034CFA59C39C3E0C";
            string key = "12345678";
            string Token = TokenHelper.CreateToken(text, key);
            Console.WriteLine(text);
        }
    }
}
