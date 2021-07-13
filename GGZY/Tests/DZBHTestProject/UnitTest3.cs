using System;
using GGZY.Core.Extensions;
using GGZY.Core.Qywx;
using GGZY.Services.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DZBHTestProject
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            var r = ServicesFactory.GGZYFW.ParseFileService.GetSmsCode("FJ35042120200330000001");
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TestMethod2()
        {
            var r = ServicesFactory.GGZYFW.ParseFileService.GetFileAndParse("","", "2019081200000001", "673921");
            Console.WriteLine(r.Serializer());
        }
    }
}
