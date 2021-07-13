using System;
using System.Collections.Generic;
using GGZY.Core.Converters;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.DZBH.ParamModel;
using GGZYFW.DbEntity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DZBHTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateApplicationPdf()
        {
            var m = DbContext.Fw.From<BH_SEND_APPLICATION_FORM>().Where(BH_SEND_APPLICATION_FORM._.M_ID == 146).First();
            var r = ServicesFactory.GGZYFW.BhSignService.CreateApplicationPdf(m, "/SignTemp/SQDTEMP.docx");
            Console.Write(r.Serializer());
        }
        [TestMethod]
        public void CreateSignUrl()
        {
            var r = ServicesFactory.GGZYFW.BhSignService.CreateSignUrl("a90599531bab46d5b821fbe1a6ab84c8");
            Console.Write(r.Serializer());
        }

        [TestMethod]
        public void GetSignResult()
        {
            var r = ServicesFactory.GGZYFW.BhSignService.GetSignResult("a90599531bab46d5b821fbe1a6ab84c8");
            Console.Write(r.Serializer());
        }

        [TestMethod]
        public void GetChengBaoTree()
        {
            GeneralResult result = ServicesFactory.GGZYFW.DZBHService.GetChengBaoTree("3504");
            Console.Write(result.Data.Serializer());
        }
        [TestMethod]
        public void ViewByPk()
        {
            GeneralResult result = ServicesFactory.GGZYFW.DZBHService.ViewByPk(702);
            Console.Write(result.Data.Serializer());
        }
        [TestMethod]
        public void add()
        {
            var m = DbContext.Fw.From<BH_SEND_APPLICATION_FORM>().Where(BH_SEND_APPLICATION_FORM._.M_ID == 23).First();
            var r = ServicesFactory.GGZYFW.DZBHService.Add(m, "2", new List<BH_ATTACHMENT>(), new List<BH_ATTACHMENT>(), new List<BH_ATTACHMENT>(), "");
        }
        [TestMethod]
        public void GetIndexCount()
        {
            var r = ServicesFactory.GGZYFW.DZBHService.GetIndexCount();
            Console.Write(r.Serializer());
        }
        [TestMethod]
        public void List()
        {
            ListSearchModel s = new ListSearchModel()
            {
                PageSize = 10,
                PageNo = 1,

            };
            var r = ServicesFactory.GGZYFW.DZBHService.List(s);
            Console.Write(r.Serializer());
        }

        [TestMethod]
        public void SendToChengBao()
        {
            ServicesFactory.GGZYFW.DZBHService.SendToChengBao(221);
        }
        [TestMethod]
        public void JumpToChengBao()
        {
            var url = ServicesFactory.GGZYFW.DZBHService.JumpToChengBao(122, out string result);
            Console.WriteLine(url);
        }
        [TestMethod]
        public void CheckOrder()
        {
            Console.WriteLine(ServicesFactory.GGZYFW.DZBHService.CheckOrder("PBAQ20203303Q000E01060", "2"));
        }

    }
}
