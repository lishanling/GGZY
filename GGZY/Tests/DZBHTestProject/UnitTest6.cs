using System;
using System.Net;
using GGZY.Core.Utils;
using GGZY.Services.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DZBHTestProject
{
    [TestClass]
    public class UnitTest6
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = ServicesFactory.GGZYFW.ParseFileService.UnZipFile(@"C:\Users\86155\Desktop\电子保函\电子保函文件示例.zip");
            Console.WriteLine(a.Data);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var a = ServicesFactory.GGZYFW.ParseFileService.PraseFileInfo("a0fc4314db5963a18167d49c81322ac2");
            Console.WriteLine(a);
        }
        [TestMethod]
        public void TestMethod3()
        {
            CompressUtils.Decompress(@"C:\Users\86155\Desktop\电子保函\电子保函文件示例.zip",
                AppDomain.CurrentDomain.BaseDirectory + "ParseFile");
        }
        [TestMethod]
        public void TestMethod4()
        {
            /*var xml =
                ServicesFactory.GGZYFW.ParseFileService.GetFileAndParse(
                    "http://114.115.162.77/bh/download/46ff85482da44e8f87324c4abec9b619.zip", "");*/
            /*var xml =
                ServicesFactory.GGZYFW.ParseFileService.GetFileAndParse(
                    "http://110.89.45.4:7581/epoint-financeplatform-web/rest/file/download?fileguid=9f34764f-565e-4b15-b139-16b819b95038", "");
            Console.WriteLine(xml.Data);*/
        }

        [TestMethod]
        public void TestMethod5()
        {
            string url =
                "http://110.89.45.4:7581/epoint-financeplatform-web/rest/file/download?fileguid=9f34764f-565e-4b15-b139-16b819b95038";
            WebClient wb = new WebClient();
            byte[] b = wb.DownloadData(url);
        }


    }
}
