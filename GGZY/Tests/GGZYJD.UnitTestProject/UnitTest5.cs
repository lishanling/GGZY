using System;
using System.Text.RegularExpressions;
using System.Threading;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.BigData.Scheduler;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYFW.DbEntity;
using GGZYJD.DbEntity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GGZYJD.UnitTestProject
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void PageDataTable()
        {
            var r = ServicesFactory.GGZYFW.MvTjAllresultXzjdService.PageDataTable(new MV_TJ_ALLRESULT_XZJD(), new SearchCondition
            {
                BeginTime=DateTime.Today.AddMonths(-1),
                EndTime=DateTime.Today.AddDays(1)
            });
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TenderAnnQuaInqueryAnnPageDataTable()
        {
          var r=  ServicesFactory.GGZYFW.MvTjAllcreateXzjdService.TenderAnnQuaInqueryAnnPageDataTable(new MV_TJ_ALLCREATE_XZJD(), new SearchCondition
          {
              BeginTime = DateTime.Today.AddMonths(-1),
              EndTime = DateTime.Today.AddDays(1)
          });
          Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void DailyStatDetail()
        {
          var r=  ServicesFactory.GGZYFW.MvTjAllcreateXzjdService.DailyStatDetail(new MV_TJ_ALLCREATE_XZJD(), new SearchCondition
          {
              BeginTime = DateTime.Today.AddMonths(-1),
              EndTime = DateTime.Today.AddDays(1)
          });
          Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void CreatePageDataTable()
        {
          var r=  ServicesFactory.GGZYFW.MvTjAllcreateXzjdService.PageDataTable(new MV_TJ_ALLCREATE_XZJD(), new SearchCondition
          {
              BeginTime = DateTime.Today.AddMonths(-1),
              EndTime = DateTime.Today.AddDays(1)
          });
          Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TradeInfoStat()
        {
          var r=  ServicesFactory.GGZYFW.MvTjAllcreateXzjdService.TradeInfoStat(new MV_TJ_ALLCREATE_XZJD(), new SearchCondition
          {
              BeginTime = DateTime.Today.AddMonths(-1),
              EndTime = DateTime.Today.AddDays(1)
          });
          Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void JdPortalProjectTypeTreeTestMethod1()
        {
          var r=  ServicesFactory.GGZYFW.MvTjAllcreateXzjdService.JdPortalProjectTypeTree(new SearchCondition());
          Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TestMethod1()
        {
            var service = new TenderStatistics();
            service.FiveYearsProjectData();
        }
        [TestMethod]
        public void SuperviseItem()
        {
            var r = ServicesFactory.GGZYJD.TSuperviseService.SuperviseItem(new TSuperviseModel { M_ID = "4967832f-bdf6-4b35-a0cb-9d46beb1e719" });
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void SuperviseLog()
        {
            var r = ServicesFactory.GGZYJD.TSuperviseService.SuperviseLog(new TSuperviseModel { M_ID = "bac32ff8-a336-4f82-bb12-a09114bc8a0e" });
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void SuperviseFeedback()
        {
            var r = ServicesFactory.GGZYJD.TSuperviseService.SuperviseFeedback(new TSuperviseModel { M_ID = "bac32ff8-a336-4f82-bb12-a09114bc8a0e" });
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void SuperviseForward()
        {
            using (DbBatch batch = DbSession.Default.BeginBatchConnection())
            {

                batch.Insert(new Entity());
            }
            var r = ServicesFactory.GGZYJD.TSuperviseService.SuperviseForward(new TSuperviseModel { M_ID = "bac32ff8-a336-4f82-bb12-a09114bc8a0e" });
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void SuperviseInfo()
        {
           var r= ServicesFactory.GGZYJD.TSuperviseService.SuperviseInfo(new TSuperviseModel{M_ID = "bac32ff8-a336-4f82-bb12-a09114bc8a0e" });
           Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void SupervisionIssued()
        {
           var r= ServicesFactory.GGZYJD.TSuperviseService.SupervisionIssued(new TSuperviseModel(), new SearchCondition());
           Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void AfcProjectSuperviseList()
        {
           var r= ServicesFactory.GGZYJD.TSuperviseResultService.AfcProjectSuperviseList(new TSuperviseResultSearchModel
            {
                PageSize=10,
                PageNo=1
            });
           Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void AfcProjectSuperviseTask()
        {
            ServicesFactory.GGZYJD.TSuperviseResultService.AfcProjectSuperviseTask(20);
        }
        [TestMethod]
        public void ZxtsSuperviseTask()
        {
            ServicesFactory.GGZYJD.TSuperviseResultService.ZxtsSuperviseTask(50);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var s = "ORA-12899: 列 \"GXDZJG_FZ\".\"MAINFEST_FILE\".\"BID_SECTION_CODE\" 的值太大 (实际值: 27, 最大值: 23)ORA-12s99: 列 \"DZJYPT\".\"MAINFEST_FILE\".\"BID_SECTION_CODE\" 的值太大 (实际值: 27, 最大值: 23)";
            var regex = new Regex("(ORA-\\S*:)|\"[A-Z|_]*\"\\.", RegexOptions.IgnoreCase);
            //Console.WriteLine(regex.Replace(s,""));
           
            for (var i = 0; i < 10; i++)
            {
                Logger.Debug(s);
                Logger.Info(s);
                Logger.Warn(s);
                Logger.Error(s);
                Logger.Fatal(s);
            }
            
        }

    }
}
