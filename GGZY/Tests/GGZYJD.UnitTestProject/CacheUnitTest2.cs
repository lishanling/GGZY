using System;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GGZYJD.UnitTestProject
{
    [TestClass]
    public class CacheUnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            var now = DateTime.Now;
            GlobalCache.Instance.Get<string>($"{now:yyyyMMddHHmmss}", () => now.ToString("yyyyMMddHHmmss"));
            var allCache = GlobalCache.Instance.AllCaches();
            Console.WriteLine(allCache.Serializer());
        }
    }
}
