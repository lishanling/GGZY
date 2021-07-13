using System;
using GGZY.Core.Extensions;
using GGZY.Services.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DZBHTestProject
{
    [TestClass]
    public class UnitTest7
    {
        //private string url = "http://114.115.162.77/bh/file/%E7%A6%8F%E5%BB%BA%E7%9C%81%E4%BD%8F%E5%BB%BA%E6%8A%95%E6%A0%87%E4%BF%9D%E5%87%BD%E6%A0%BC%E5%BC%8F%E6%96%87%E4%BB%B6%EF%BC%88%E6%8B%85%E4%BF%9D%EF%BC%89.ofd";
        //private string url = "http://114.115.162.77/bh/file/%E5%87%AF%E7%89%B9OFD%E7%AD%BE%E7%AB%A0%E6%96%87%E4%BB%B6.ofd";
        //private string url = "http://114.115.162.77/bh/file/%E9%87%91%E8%9E%8D%E6%9C%BA%E6%9E%84%E7%94%B5%E5%AD%90%E4%BF%9D%E5%87%BD%E6%96%87%E4%BB%B6.ofd";
        //private string url = "http://114.115.162.77/bh/file/%E4%B8%89%E6%98%8E%E8%A7%A6%E7%BD%91%E7%94%B5%E5%AD%90%E4%BF%9D%E5%87%BD%E6%96%87%E4%BB%B6.ofd";
        //private string url = "http://114.115.162.77/bh/file/%E5%9B%BD%E5%AF%BF%E7%94%B5%E5%AD%90%E4%BF%9D%E5%87%BD.ofd";
        //private string url = "http://114.115.162.77/bh/file/314b2732bb064573a964112700de6399.ofd";
        //private string url = "http://114.115.162.77/bh/file/%E6%97%A0%E6%AF%94%E6%AC%A2.ofd";
        //private string url = "http://114.115.162.77/bh/file/test.ofd";
        //private string url = "http://114.115.162.77/bh/file/chuwang.ofd";
        //private string url = "http://114.115.162.77/bh/file/%E8%A7%A6%E7%BD%912.ofd";
        //private string url = "http://114.115.162.77/bh/file/%E6%8C%AF%E5%85%B4%E7%94%B5%E5%AD%90%E4%BF%9D%E5%87%BD.ofd";
        //private string url = "http://120.24.78.89:30001/szx/guarantee/downloadOfd/FJ35012120201028000002";
        //private string url = "https://ggzyfw.fj.gov.cn/cfs/file/getcontent/5f9b8175b4afb33768aab145.ofd";
        //private string url = "https://ggzyfw.fj.gov.cn/cfs/files/63/82/5f9b8175b4afb33768aab145.ofd";
        //private string url = "http://114.115.162.77/bh/file/dzbh.ofd";
        //private string url = "http://114.115.162.77:8066/file/getcontent/5fd31630faae15504ce9c6da.ofd";
        //private string url = "http://114.115.162.77:8066/file/getcontent/5fe4652ffaae1547e4d32c9d.ofd";
        private string url = "http://114.115.162.77:8066/file/getcontent/5fea9076faae153d9c56acc2.ofd";
        


        [TestMethod]
        public void TestMethod1()
        {
            var r = ServicesFactory.GGZYFW.OfdApiService.Validate(url);
            Console.WriteLine(r);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var r = ServicesFactory.GGZYFW.OfdApiService.GetFiles(url);
            Console.WriteLine(r);
        }
        [TestMethod]
        public void TestMethod12()
        {
            var r = ServicesFactory.GGZYFW.OfdApiService.GetHtml(url);
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TestMethod3()
        {
            //url = "http://114.115.162.77:8066/file/getcontent/5fc74bdcfaae154ed8a59095.ofd";
            //url = "http://114.115.162.77:8066/file/getcontent/5efc39e9faae153ad8dc4a60.ofd";
            var r = ServicesFactory.GGZYFW.ParseFileService.GetFileAndParse(url, "","","");
            Console.WriteLine(r.Serializer());
        }
    }
}
