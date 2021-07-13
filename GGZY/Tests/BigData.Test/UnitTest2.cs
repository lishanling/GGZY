using System;
using System.Collections.Generic;
using GGZY.Core.Converters;
using GGZY.Core.Extensions;
using GGZY.Services.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BigData.Test
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void GetBidderTop10()
        {
            List<string> l = new List<string>()
            {
                "cc",
                "feif"
            };
            var r = ServicesFactory.GGZYJD.CorrelationService.GetBidderTop10(l);
            Console.Write(r.Data.Serializer());
        }
        [TestMethod]
        public void GetTendererTop10()
        {
            List<string> l = new List<string>()
            {
                "cc",
                "feif"
            };
            var r = ServicesFactory.GGZYJD.CorrelationService.GetTendererTop10(l);
            Console.Write(r.Data.Serializer());
        }
        [TestMethod]
        public void GetTenderAgentTop10()
        {
            List<string> l = new List<string>()
            {
                "cc",
                "feif"
            };
            var r = ServicesFactory.GGZYJD.CorrelationService.GetTenderAgentTop10(l);
            Console.Write(r.Data.Serializer());
        }
        [TestMethod]
        public void GetTheSameMacFromBidders()
        {
            List<string> l = new List<string>()
            {
                "cc",
                "feif"
            };
            var r = ServicesFactory.GGZYJD.CorrelationService.GetTheSameMacFromBidders(l);
            Console.Write(r.Data.Serializer());
        }
        [TestMethod]
        public void GetMainUserIdByChidUsr()
        {
            List<string> l = new List<string>()
            {
                "cc",
                "feif"
            };
            var r = ServicesFactory.GGZYJD.TUserBindAccountService.GetMainUserIdByChidUsr(81);
            Console.Write(r.Serializer());
        }
        [TestMethod]
        public void GetConfig()
        {
            var r = ServicesFactory.GGZYJD.CorrelationService.GetConfig("招标项目", 1);
            Console.Write(r.Data.Serializer());
        }
        [TestMethod]
        public void GetTenderBidderList()
        {
            var r = ServicesFactory.GGZYJD.CorrelationService.GetTenderBidderList(2, 10, "", "");
            Console.Write(r.Serializer());
        }
        [TestMethod]
        public void GetTenderListByBidderList()
        {
            List<string> l = new List<string>()
            {
                "cc",
                "feif"
            };
            var r = ServicesFactory.GGZYJD.CorrelationService.GetTenderListByBidderList(2, 10, l);
            Console.Write(r.Serializer());
        }
        [TestMethod]
        public void GetWinTenderListByBidderList()
        {
            List<string> l = new List<string>()
            {
                "cc",
                "feif"
            };
            var r = ServicesFactory.GGZYJD.CorrelationService.GetWinTenderListByBidderList(1, 10, l);
            Console.Write(r.Serializer());
        }
        [TestMethod]
        public void GetTheSameTenderByBidderList()
        {
            List<string> l = new List<string>()
            {
                "cc",
                "feif"
            };
            var r = ServicesFactory.GGZYJD.CorrelationService.GetTheSameTenderByBidderList(1, 10, l);
            Console.Write(r.Serializer());
        }
    }
}
