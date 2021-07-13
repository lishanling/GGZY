using System;
using System.IO;
using GGZY.Core.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PullData.Helper;
using PullData.Model;

namespace PullData.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //string companyName = "91350100488100688N";
            string companyName = "91440300MA5DAJ3J91";
            //string companyName = "91350212562842576W";
            Main m = new Main();
            PoorCreditResult c = m.CheckOrg(companyName);
          
            Console.Write(c.Content);
            Console.WriteLine(c.Result.Serializer());
        }
        [TestMethod]
        public void TestMethod2()
        {
            string idCardNo = "350322199108031059";
            string name = "350322199108031059";
            Main m = new Main();
            PoorCreditResult c = m.CheckPerson(idCardNo, name);
            Console.Write(c.Message);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Main m = new Main();
            Result c = m.SubmitPunishment("", "测试", "测试", "测试", "测试", "", "");
        }
        [TestMethod]
        public void TestMethod4()
        {
            StreamReader sr = new StreamReader("d:\\testtext\\backlist.txt");
            string xml = sr.ReadToEnd();
            sr.Close();
            PoorCreditResult pr = XmlHelper.XmlToResult(xml);
        }
    }
}
