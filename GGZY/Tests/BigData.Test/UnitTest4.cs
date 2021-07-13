using System;
using GGZY.Core.Extensions;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Model.BigData;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BigData.Test
{
    /// <summary>
    /// 监察点分析单元测试
    /// </summary>
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod1()
        {
            StatisticsSupervisionSearchModel s = new StatisticsSupervisionSearchModel()
            {
                BeginTime = new DateTime(2018, 1, 1),
                EndTime = new DateTime(2021, 1, 1),
                RegionCode = "350100",
                TenderType = "A01",
                TimeType = "2"
            };
            var r = ServicesFactory.GGZYJD.StatisticsSupervisionService.SupervisionCount(s);
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TestMethod2()
        {
            StatisticsSupervisionSearchModel s = new StatisticsSupervisionSearchModel()
            {
                BeginTime = new DateTime(2018, 1, 1),
                EndTime = new DateTime(2021, 1, 1),
                RegionCode = "350100",
                TenderType = "A01",
                TimeType = "2"
            };
            var r = ServicesFactory.GGZYJD.StatisticsSupervisionService.SupervisionExceptionRank(s);
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TestMethod3()
        {
            StatisticsSupervisionSearchModel s = new StatisticsSupervisionSearchModel()
            {
                BeginTime = new DateTime(2018, 1, 1),
                EndTime = new DateTime(2021, 1, 1),
                RegionCode = "350100",
                TenderType = "A01",
                TimeType = "2"
            };
            var r = ServicesFactory.GGZYJD.StatisticsSupervisionService.SupervisionTimeAnalyze(s);
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TestMethod4()
        {
            StatisticsSupervisionSearchModel s = new StatisticsSupervisionSearchModel()
            {
                /*BeginTime = new DateTime(2018, 1, 1),
                EndTime = new DateTime(2021, 1, 1),
                RegionCode = "350100",
                TenderType = "A01",
                TimeType = "2"*/
            };
            var r = ServicesFactory.GGZYJD.StatisticsSupervisionService.SupervisionPie(s);
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TestMethod5()
        {
            StatisticsSupervisionSearchModel s = new StatisticsSupervisionSearchModel()
            {
                BeginTime = new DateTime(2018, 1, 1),
                EndTime = new DateTime(2021, 1, 1),
                RegionCode = "350100",
                TenderType = "A01",
                TimeType = "2"
            };
            var r = ServicesFactory.GGZYJD.StatisticsSupervisionService.SuspectCount(s);
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TestMethod6()
        {
            StatisticsSupervisionSearchModel s = new StatisticsSupervisionSearchModel()
            {
                BeginTime = new DateTime(2018, 1, 1),
                EndTime = new DateTime(2021, 1, 1),
               
            };
            var r = ServicesFactory.GGZYJD.StatisticsSupervisionService.SuspectRank(s);
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TestMethod7()
        {
            StatisticsSupervisionSearchModel s = new StatisticsSupervisionSearchModel()
            {
                BeginTime = new DateTime(2018, 1, 1),
                EndTime = new DateTime(2021, 1, 1),
                RegionCode = "350100",
                TenderType = "A01",
                TimeType = "2"
            };
            var r = ServicesFactory.GGZYJD.StatisticsSupervisionService.SuspectTimeAnalyze(s);
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TestMethod8()
        {
            StatisticsSupervisionSearchModel s = new StatisticsSupervisionSearchModel()
            {
                /*BeginTime = new DateTime(2018, 1, 1),
                EndTime = new DateTime(2021, 1, 1),*/
            };
            var r = ServicesFactory.GGZYJD.StatisticsSupervisionService.SuspectPie(s);
            Console.WriteLine(r.Serializer());
        }

        [TestMethod]
        public void TestMethod9()
        {
            StatisticsSupervisionSearchModel s = new StatisticsSupervisionSearchModel()
            {
                /*BeginTime = new DateTime(2018, 1, 1),
                EndTime = new DateTime(2021, 1, 1),
                RegionCode = "350100",
                TenderType = "A01",
                TimeType = "2"*/
            };
            var r = ServicesFactory.GGZYJD.StatisticsSupervisionService.DepartmentCyjdxmsRank(s);
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TestMethod91()
        {
            StatisticsSupervisionSearchModel s = new StatisticsSupervisionSearchModel()
            {
                /*BeginTime = new DateTime(2018, 1, 1),
                EndTime = new DateTime(2021, 1, 1),
                RegionCode = "350100",
                TenderType = "A01",
                TimeType = "2"*/
            };
            var r = ServicesFactory.GGZYJD.StatisticsSupervisionService.DepartmentYcxmsRank(s);
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TestMethod92()
        {
            StatisticsSupervisionSearchModel s = new StatisticsSupervisionSearchModel()
            {/*
                BeginTime = new DateTime(2018, 1, 1),
                EndTime = new DateTime(2021, 1, 1),
                RegionCode = "350100",
                TenderType = "A01",
                TimeType = "2"*/
            };
            var r = ServicesFactory.GGZYJD.StatisticsSupervisionService.DepartmentFcyjsRank(s);
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TestMethod93()
        {
            StatisticsSupervisionSearchModel s = new StatisticsSupervisionSearchModel()
            {
                /*BeginTime = new DateTime(2018, 1, 1),
                EndTime = new DateTime(2021, 1, 1),
                RegionCode = "350100",
                TenderType = "A01",
                TimeType = "2"*/
            };
            var r = ServicesFactory.GGZYJD.StatisticsSupervisionService.DepartmentYjxmblRank(s);
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TestMethod94()
        {
            StatisticsSupervisionSearchModel s = new StatisticsSupervisionSearchModel()
            {
                /*BeginTime = new DateTime(2018, 1, 1),
                EndTime = new DateTime(2021, 1, 1),
                RegionCode = "350100",
                TenderType = "A01",
                TimeType = "2"*/
            };
            var r = ServicesFactory.GGZYJD.StatisticsSupervisionService.DepartmentYswgdRank(s);
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TestMethod95()
        {
            StatisticsSupervisionSearchModel s = new StatisticsSupervisionSearchModel()
            {
                /*BeginTime = new DateTime(2018, 1, 1),
                EndTime = new DateTime(2021, 1, 1),
                RegionCode = "350100",
                TenderType = "A01",
                TimeType = "2"*/

            };
            var r = ServicesFactory.GGZYJD.StatisticsSupervisionService.DepartmentDcjgRank(s);
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TestMethod96()
        {
            StatisticsSupervisionSearchModel s = new StatisticsSupervisionSearchModel()
            {
                BeginTime = new DateTime(2018, 1, 1),
                EndTime = new DateTime(2021, 1, 1),
                RegionCode = "350100",
                TenderType = "A01",
                TimeType = "2"
            };
            var r = ServicesFactory.GGZYJD.StatisticsSupervisionService.SurveyCount(s);
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TestMethod97()
        {
            StatisticsSupervisionSearchModel s = new StatisticsSupervisionSearchModel()
            {
                /*BeginTime = new DateTime(2018, 1, 1),
                EndTime = new DateTime(2021, 1, 1),
                RegionCode = "350100",
                TenderType = "A01",
                TimeType = "2"*/
            };
            var r = ServicesFactory.GGZYJD.StatisticsSupervisionService.ProjectConditionCount(s);
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TestMethod98()
        {
            StatisticsSupervisionSearchModel s = new StatisticsSupervisionSearchModel()
            {
                /*BeginTime = new DateTime(2018, 1, 1),
                EndTime = new DateTime(2021, 1, 1),
                RegionCode = "350100",
                TenderType = "A01",
                TimeType = "2"*/
            };
            var r = ServicesFactory.GGZYJD.StatisticsSupervisionService.ProjectTop10(s);
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TestMethod99()
        {
            StatisticsSupervisionSearchModel s = new StatisticsSupervisionSearchModel()
            {
                /*BeginTime = new DateTime(2018, 1, 1),
                EndTime = new DateTime(2021, 1, 1),
                RegionCode = "350100",
                TenderType = "A01",
                TimeType = "2"*/
            };
            var r = ServicesFactory.GGZYJD.StatisticsSupervisionService.SubjectTop10(s);
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TestMethod991()
        {
            var r = ServicesFactory.GGZYJD.StatisticsSupervisionService.DepartmentCount();
            Console.WriteLine(r.Serializer());
        }
    }
}
