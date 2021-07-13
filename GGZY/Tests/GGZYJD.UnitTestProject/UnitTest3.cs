using System;
using System.Collections.Generic;
using System.Data;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace GGZYJD.UnitTestProject
{
    [TestClass]
    public class UnitTest3
    {

        [TestMethod]
        public void GetZXTS_DataTest()
        {
          var r=  ServicesFactory.GGZYJD.PtZxtsService.GetZXTS_Data(new MonitorHomePageModel()
          {
              REGION_CODE = "35",
              HY_TYPE = "1"
          });
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void GetBJ_DataTest()
        {
          var r=  ServicesFactory.GGZYJD.TAfcProjectService.GetBJ_Data(new MonitorHomePageModel()
          {
              REGION_CODE = "35",
              //HY_TYPE = "1"
              BeginTime=new DateTime(2020,8,1),
              EndTime = DateTime.Now
          });
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void SqlToPageTableTest()
        {
            int total;
            var r = DbSession.Default.FromSql("SELECT * FROM SYS_DIC WHERE ID LIKE :ID ORDER BY ID DESC")
                .AddInParameter(":ID", DbType.AnsiString, "%10%").Page(10, 1)
                .ToPageTable(out total);
            Console.WriteLine(total);
            Console.WriteLine(r.Serializer());
        }

        [TestMethod]
        public void TableNameTest()
        {
           var r = DbSession.Default.FromTable("SYS_DIC").Where(new Field("TYPE").Contain("23")).OrderBy(new Field("TYPE").Asc).Page(10, 1).ToList<object>();
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TestMethod1()
        {
            var r = ServicesFactory.GGZYJD.TAfcProjectService.ProjectReportBuildDetailByCode("E503501211712180004001");
            Console.WriteLine(JsonConvert.SerializeObject(r));
        }
        [TestMethod]
        public void TestMethod2()
        {
            var r = ServicesFactory.GGZYJD.RecordReviewService.GetRecordListByCode("E473503022005130004001");
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TestMethod3()
        {
            var r = ServicesFactory.GGZYJD.RecordReviewService.GetProcessDataCount("E503501211712180004001", "E3500000001001175001");
            Console.WriteLine(JsonConvert.SerializeObject(r));
        }
        [TestMethod]
        public void TestMethod4()
        {
            var r = ServicesFactory.GGZYJD.TMultimediaDataService.GetList("A3505040502889901001");
            Console.WriteLine(JsonConvert.SerializeObject(r));
        }
        [TestMethod]
        public void TestMethod5()
        {
            var r = ServicesFactory.GGZYJD.TMultimediaDataService.GetUrlParam("462");
            Console.WriteLine(JsonConvert.SerializeObject(r));
        }

        [TestMethod]
        public void TestMethod6()
        {
            CreditSearchModel c = new CreditSearchModel()
            {
                PageNo = 1,
                PageSize = 10,
                BeginTM = new DateTime(2018, 1, 1),
                EndTM = new DateTime(2018, 12, 4),
            };
            var r = ServicesFactory.GGZYJD.RecordCreditDeductionService.GetCreditList(c);
            Console.WriteLine(JsonConvert.SerializeObject(r));
        }
        [TestMethod]
        public void TestMethod7()
        {
            var r = ServicesFactory.GGZYJD.RecordCreditDeductionService.GetCreditDetailList("4369");
            Console.WriteLine(JsonConvert.SerializeObject(r));
        }

        [TestMethod]
        public void TestMethod8()
        {
            var r = ServicesFactory.GGZYJD.RecordCreditDeductionService.GetDetail("A01201904000006");
            Console.WriteLine(JsonConvert.SerializeObject(r));
        }

        [TestMethod]
        public void TestMethod9()
        {
            var r = ServicesFactory.GGZYJD.TUserBindAccountService.GetAccountList();
            Console.WriteLine(JsonConvert.SerializeObject(r));
        }
        [TestMethod]
        public void TestMethod10()
        {
            List<T_USER_BIND_ACCOUNT> list = new List<T_USER_BIND_ACCOUNT>()
            {
                new T_USER_BIND_ACCOUNT()
                {
                    CREDIT_CODE = "Y1350102J20030301D",
                    MAIN_U_ID = 81,
                    CHILD_U_ID = 901,
                    REMARK = "备注1"
                },
                new T_USER_BIND_ACCOUNT()
                {
                    CREDIT_CODE = "Y1350102J20030301D",
                    MAIN_U_ID = 81,
                    CHILD_U_ID = 81,
                    REMARK = "备注1"
                },
                new T_USER_BIND_ACCOUNT()
                {
                    CREDIT_CODE = "Y1350102J20030301D",
                    MAIN_U_ID = 81,
                    CHILD_U_ID = 82,
                    REMARK = "备注3"
                },
            };
            var r = ServicesFactory.GGZYJD.TUserBindAccountService.Add(list);
            Console.WriteLine(JsonConvert.SerializeObject(r));
        }
        [TestMethod]
        public void TestMethod11()
        {
            var r = ServicesFactory.GGZYJD.TUserBindAccountService.GetList();
            Console.WriteLine(JsonConvert.SerializeObject(r));
        }
    }
}
