using System;
using System.Collections.Generic;
using GGZY.Core.Extensions;
using GGZY.Core.Utils;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model.BigData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GGZYJD.UnitTestProject
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void JieYueAmount()
        {
            var r = ServicesFactory.GGZYJD.DashboardService.JieYueAmount(new EngineerSearchModel
            {
                //AREACODE = "350000",
                BeginTime = new DateTime(2018, 4, 1),
                EndTime = new DateTime(2020, 4, 30),
            });
            //Console.WriteLine(JsonConvert.SerializeObject(r));
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TradeTypeTest()
        {
            var r = ServicesFactory.GGZYJD.DashboardService.TradeType(new EngineerSearchModel
            {
                //AREACODE = "350000",
                BeginTime = new DateTime(2019, 1, 1),
                EndTime = new DateTime(2019, 12, 31),
            });
            //Console.WriteLine(JsonConvert.SerializeObject(r));
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TradeMethodTest()
        {
            var r = ServicesFactory.GGZYJD.DashboardService.TradeMethod(new EngineerSearchModel
            {
                //AREACODE = "350000",
                //BeginTime = new DateTime(2019, 1, 1),
                //EndTime = new DateTime(2019, 12, 31),
            });
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TradeDataSummaryTest()
        {
            var r = ServicesFactory.GGZYJD.DashboardService.TradeDataSummary(new EngineerSearchModel
            {
                AREACODE = "350000",
                BeginTime = new DateTime(2019, 1, 1),
                EndTime = new DateTime(2019, 12, 31),
            });
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TradeAmountRankTest()
        {
            var r = ServicesFactory.GGZYJD.DashboardService.TradeRank(new EngineerSearchModel
            {
                //AREACODE = "350000",
                //BeginTime = new DateTime(2020, 1, 1),
                //EndTime = DateTime.Today,
                //Type = "1"
            });
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void ProjectAmountDistribution_ActiveCount_EXPERT()
        {
            var search = new StatisticsBidderSearchModel()
            {
                //AREACODE = "350100",
                BeginTime = new DateTime(2019, 1, 1),
                EndTime = new DateTime(2019, 12, 31),
                //LEGAL_NAME = "福建", LEGAL_CODE = "12350000"
            };
            var activeCount = ServicesFactory.GGZYJD.StatisticsExpertService.ProjectAmountDistribution_ActiveCount(search);
            Console.WriteLine(activeCount.Serializer());

        }
        [TestMethod]
        public void Participation_Expert()
        {
            var r = ServicesFactory.GGZYJD.StatisticsExpertService.Participation(new StatisticsBidderSearchModel()
            {
                //AREACODE = "350100",
                BeginTime = new DateTime(2019, 1, 1),
                EndTime = new DateTime(2019, 12, 31),
                // LEGAL_NAME = "许",
                //LEGAL_CODE = "9135070256732601XB"
                //PageNo = 33,
            });
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void UserCount_Expert()
        {
            var r = ServicesFactory.GGZYJD.StatisticsExpertService.UserCount(new StatisticsBidderSearchModel()
            {
                //AREACODE = "350100",
                //BeginTime = DateTime.Today.AddYears(-1),
                //EndTime = DateTime.Today,
                //// LEGAL_NAME = "许",
                ////LEGAL_CODE = "9135070256732601XB"
                //PageNo = 33,
            });
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void ProjectCountRankTest_Expert()
        {
            var r = ServicesFactory.GGZYJD.StatisticsExpertService.ProjectCountRank(new StatisticsBidderSearchModel()
            {
                //AREACODE = "350100",
                BeginTime = DateTime.Today.AddYears(-5),
                EndTime = DateTime.Today,
                // LEGAL_NAME = "许",
                //LEGAL_CODE = "9135070256732601XB"
                PageNo = 33,
            });
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void RegionChart_TENDER()
        {
            var search = new StatisticsBidderSearchModel()
            {
                //AREACODE = "350000",
                BeginTime = new DateTime(2019, 1, 1),
                EndTime = new DateTime(2019, 12, 31),
                //LEGAL_NAME = "福建", LEGAL_CODE = "12350000"
            };
            var activeCount = ServicesFactory.GGZYJD.StatisticsTenderService.RegionChart(search);
            Console.WriteLine(activeCount.Serializer());

        }
        [TestMethod]
        public void TENDER_AREA_TEST()
        {
            var search = new StatisticsBidderSearchModel()
            {
                //AREACODE = "350000",
                BeginTime = new DateTime(2019, 1, 1),
                EndTime = new DateTime(2019, 12, 31),
                //LEGAL_NAME = "福建", LEGAL_CODE = "12350000"
                KeyWord = "福建南剑发展有限公司"
            };
            var activeCount = ServicesFactory.GGZYJD.StatisticsTenderService.TENDER_AREA(search);
            Console.WriteLine(activeCount.Serializer());

        }
        [TestMethod]
        public void TENDER_WIN_COUNT_TEST()
        {
            var search = new StatisticsBidderSearchModel()
            {
                //AREACODE = "350000",
                BeginTime = new DateTime(2019, 1, 1),
                EndTime = new DateTime(2019, 12, 31),
                //LEGAL_NAME = "福建", LEGAL_CODE = "12350000"
                KeyWord = "福建南剑发展有限公司"
            };
            var activeCount = ServicesFactory.GGZYJD.StatisticsTenderService.TENDER_WIN_COUNT(search);
            Console.WriteLine(activeCount.Serializer());

        }
        [TestMethod]
        public void TENDER_INFO_TEST()
        {
            var search = new StatisticsBidderSearchModel()
            {
                //AREACODE = "350000",
                BeginTime = new DateTime(2019, 1, 1),
                EndTime = new DateTime(2019, 12, 31),
                //LEGAL_NAME = "福建", LEGAL_CODE = "12350000"
                KeyWord="福建南剑发展有限公司"
            };
            var activeCount = ServicesFactory.GGZYJD.StatisticsTenderService.TENDER_INFO(search);
            Console.WriteLine(activeCount.Serializer());

        }
        [TestMethod]
        public void Participation_TENDER()
        {
            var search = new StatisticsBidderSearchModel()
            {
                //AREACODE = "350000",
                BeginTime = new DateTime(2019, 1, 1),
                EndTime = new DateTime(2019, 12, 31),
                //LEGAL_NAME = "福建", LEGAL_CODE = "12350000"
            };
            var activeCount = ServicesFactory.GGZYJD.StatisticsTenderService.Participation(search);
            Console.WriteLine(activeCount.Serializer());

        }
        [TestMethod]
        public void Capital_TENDER()
        {
            var search = new StatisticsBidderSearchModel()
            {
                //AREACODE = "350000",
                BeginTime = new DateTime(2019, 1, 1),
                EndTime = new DateTime(2019, 12, 31),
                //LEGAL_NAME = "福建", LEGAL_CODE = "12350000"
            };
            var activeCount = ServicesFactory.GGZYJD.StatisticsTenderService.Capital(search);
            Console.WriteLine(activeCount.Serializer());

        }
        [TestMethod]
        public void Grade_TENDER()
        {
            var search = new StatisticsBidderSearchModel()
            {
                //AREACODE = "350000",
                BeginTime = new DateTime(2019, 1, 1),
                EndTime = new DateTime(2019, 12, 31),
                //LEGAL_NAME = "福建", LEGAL_CODE = "12350000"
            };
            var activeCount = ServicesFactory.GGZYJD.StatisticsTenderService.Grade(search);
            Console.WriteLine(activeCount.Serializer());

        }
        [TestMethod]
        public void UserCount_TENDER()
        {
            var search = new StatisticsBidderSearchModel()
            {
                //AREACODE = "350000",
                BeginTime = new DateTime(2019, 1, 1),
                EndTime = new DateTime(2019, 12, 31),
                //LEGAL_NAME = "福建", LEGAL_CODE = "12350000"
            };
            var activeCount = ServicesFactory.GGZYJD.StatisticsTenderService.UserCount(search);
            Console.WriteLine(activeCount.Serializer());

        }
        [TestMethod]
        public void ProjectAmountDistribution_ActiveCount_TENDER()
        {
            var search = new StatisticsBidderSearchModel()
            {
                //AREACODE = "350100",
                BeginTime = new DateTime(2019, 1, 1),
                EndTime = new DateTime(2019, 12, 31),
                //LEGAL_NAME = "福建", LEGAL_CODE = "12350000"
            };
            var activeCount = ServicesFactory.GGZYJD.StatisticsTenderService.ProjectAmountDistribution_ActiveCount(search);
            Console.WriteLine(activeCount.Serializer());

        }
        [TestMethod]
        public void ProjectCountRankTest_Tender()
        {
            var r = ServicesFactory.GGZYJD.StatisticsTenderService.ProjectCountRank(new StatisticsBidderSearchModel()
            {
                //AREACODE = "350100",
                BeginTime = DateTime.Today.AddYears(-5),
                EndTime = DateTime.Today,
                //LEGAL_NAME = "福建",
                //LEGAL_CODE = "9135070256732601XB"
            });
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void ProjectAmountDistribution_ActiveCount_AGENCY()
        {
            var search = new StatisticsBidderSearchModel()
            {
                //AREACODE = "350100",
                BeginTime = new DateTime(2019, 1, 1),
                EndTime = new DateTime(2019, 12, 31),
                //LEGAL_NAME = "福建", LEGAL_CODE = "12350000"
            };
            var activeCount = ServicesFactory.GGZYJD.StatisticsAgencyService.ProjectAmountDistribution_ActiveCount(search);
            Console.WriteLine(activeCount.Serializer());

        }
        [TestMethod]
        public void Participation_Agency()
        {
            var r = ServicesFactory.GGZYJD.StatisticsAgencyService.Participation(new StatisticsBidderSearchModel()
            {
                //AREACODE = "350100",
                BeginTime = new DateTime(2019, 1, 1),
                EndTime = new DateTime(2019, 12, 31),
                //LEGAL_NAME = "福建",
                //LEGAL_CODE = "12350000"
            });
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void ProjectCountRankTest_Agency()
        {
            var r = ServicesFactory.GGZYJD.StatisticsAgencyService.ProjectCountRank(new StatisticsBidderSearchModel()
            {
                AREACODE = "350100",
                //BeginTime = new DateTime(2015,7,9),
                //EndTime = DateTime.Today,
                LEGAL_NAME = "福建",
                //LEGAL_CODE = "12350000"
            });
            Console.WriteLine(r.Serializer());
        }

        [TestMethod]
        public void ProjectAmountDistribution_ActiveCount_Bidder()
        {
            var search = new StatisticsBidderSearchModel()
            {
                //AREACODE = "350100",
                BeginTime = new DateTime(2019, 1, 1),
                EndTime = new DateTime(2019, 12, 31),
                //LEGAL_NAME = "福建", LEGAL_CODE = "12350000"
            };
            var activeCount = ServicesFactory.GGZYJD.StatisticsBidderService.ProjectAmountDistribution_ActiveCount(search);
            Console.WriteLine(activeCount.Serializer());

        }
        [TestMethod]
        public void TENDERER_WIN_BIDDER_Test()
        {
            var search = new StatisticsBidderSearchModel()
            {
                //AREACODE = "350100",
                BeginTime = new DateTime(2000, 1, 1),
                EndTime = new DateTime(2020, 12, 31),
                //LEGAL_NAME = "福建", LEGAL_CODE = "12350000"
                KeyWord = "江苏国泰测试用单位(请勿删除)"
            };

            var r = ServicesFactory.GGZYJD.StatisticsBidderService.TENDERER_WIN_BIDDER(search);
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TENDERER_CHART_INFO_Test()
        {
            var search = new StatisticsBidderSearchModel()
            {
                //AREACODE = "350100",
                BeginTime = new DateTime(2000, 1, 1),
                EndTime = new DateTime(2020, 12, 31),
                //LEGAL_NAME = "福建", LEGAL_CODE = "12350000"
                KeyWord = "江苏国泰测试用单位(请勿删除)"
            };

            var r = ServicesFactory.GGZYJD.StatisticsBidderService.TENDERER_CHART_INFO(search);
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TENDERER_INFO_Test()
        {
            var search = new StatisticsBidderSearchModel()
            {
                //AREACODE = "350100",
                BeginTime = new DateTime(2000, 1, 1),
                EndTime = new DateTime(2020, 12, 31),
                //LEGAL_NAME = "福建", LEGAL_CODE = "12350000"
                KeyWord = "江苏国泰测试用单位(请勿删除)"
            };

            var r = ServicesFactory.GGZYJD.StatisticsBidderService.TENDERER_INFO(search);
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TENDERER_AREA_Test()
        {
            var search = new StatisticsBidderSearchModel()
            {
                //AREACODE = "350100",
                BeginTime = new DateTime(2000, 1, 1),
                EndTime = new DateTime(2020, 12, 31),
                //LEGAL_NAME = "福建", LEGAL_CODE = "12350000"
                KeyWord = "江苏国泰测试用单位(请勿删除)"
            };

            var r = ServicesFactory.GGZYJD.StatisticsBidderService.TENDERER_AREA(search);
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TENDERER_EXPERT_Test()
        {
            var search = new StatisticsBidderSearchModel()
            {
                //AREACODE = "350100",
                BeginTime = new DateTime(2000, 1, 1),
                EndTime = new DateTime(2020, 12, 31),
                //LEGAL_NAME = "福建", LEGAL_CODE = "12350000"
                KeyWord = "江苏国泰测试用单位(请勿删除)"
            };

            var r = ServicesFactory.GGZYJD.StatisticsBidderService.TENDERER_EXPERT(search);
            Console.WriteLine(r.Serializer());
            var r2 = ServicesFactory.GGZYJD.StatisticsBidderService.TENDERER_EXPERT_RATE(search);
            Console.WriteLine(r2.Serializer());
        }
        [TestMethod]
        public void TENDERER_BIDDER_DIAG_Test()
        {
            var search = new StatisticsBidderSearchModel()
            {
                //AREACODE = "350100",
                BeginTime = new DateTime(2000, 1, 1),
                EndTime = new DateTime(2020, 12, 31),
                //LEGAL_NAME = "福建", LEGAL_CODE = "12350000"
                KeyWord = "江苏国泰测试用单位(请勿删除)"
            };

            var r = ServicesFactory.GGZYJD.StatisticsBidderService.TENDERER_BIDDER_DIAG(search);
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TENDERER_PROXY_Test()
        {
            var search = new StatisticsBidderSearchModel()
            {
                //AREACODE = "350100",
                BeginTime = new DateTime(2000, 1, 1),
                EndTime = new DateTime(2020, 12, 31),
                //LEGAL_NAME = "福建", LEGAL_CODE = "12350000"
                KeyWord = "江苏国泰测试用单位(请勿删除)"
            };

            var r = ServicesFactory.GGZYJD.StatisticsBidderService.TENDERER_PROXY(search);
            Console.WriteLine(r.Serializer());
           var r1 = ServicesFactory.GGZYJD.StatisticsBidderService.TENDERER_PROXY_RATE(search);
            Console.WriteLine(r1.Serializer());
        }
        [TestMethod]
        public void Participation_Bidder()
        {
            var search = new StatisticsBidderSearchModel()
            {
                //AREACODE = "350100",
                BeginTime = new DateTime(2019, 1, 1),
                EndTime = new DateTime(2019, 12, 31),
                //LEGAL_NAME = "福建", LEGAL_CODE = "12350000"
            };

            var r = ServicesFactory.GGZYJD.StatisticsBidderService.Participation(search);
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void ProjectCountRankTest_Bidder()
        {
            var search = new StatisticsBidderSearchModel()
            {
                //AREACODE = "350100",
                BeginTime = new DateTime(2015, 1, 1),
                EndTime = DateTime.Today
                //LEGAL_NAME = "福建", LEGAL_CODE = "12350000"
            };

            var r = ServicesFactory.GGZYJD.StatisticsBidderService.ProjectCountRank(search);
            Console.WriteLine(r.Serializer());
        }

        [TestMethod]
        public void PortalFilterTest()
        {
            #region inputStream

            var inputStream = @"{
	""COMPLAINT_TYPE"": ""2"",
	""COMPLAINT_LEGAL_ISWT"": 0,
	""COMPLAINT_ISAGENCY"": 0,
	""respondents"": [
		{
			""NAME"": ""博思软件"",
			""TYPE"": ""1"",
			""CODE"": ""123456789012345678"",
			""CONTACT"": ""张三"",
			""CONTACT_PHONE"": ""17759121608"",
			""ADRESS"": ""福建省福州市高新区"",
			""title"": ""编辑"",
			""id"": ""0.8fw3he890gd""
		},
		{
			""NAME"": ""星网锐捷"",
			""TYPE"": ""2"",
			""CODE"": ""123456789012345678"",
			""CONTACT"": ""李四"",
			""CONTACT_PHONE"": ""19959125221"",
			""ADRESS"": ""福建省福州市马尾区"",
			""title"": ""添加"",
			""id"": ""0.6usvv2qe3zh""
		}
	],
	""YYZM_AIDS"": ""278038d889144f368c71382f558b4a85"",
	""TSS_AIDS"": {},
	""COMPLAINT_ROLE"": ""项目测试"",
	""COMPLAINT_NAME"": ""张传稀"",
	""COMPLAINT_CODE"": ""352225199006060575"",
	""COMPLAINT_PHONE"": ""18610293812"",
	""COMPLAINT_EMAIL"": ""389005743@qq.com"",
	""COMPLAINT_DNAME"": ""四创科技"",
	""COMPLAINT_ZW"": ""测试工程师"",
	""COMPLAINT_ADRESS"": ""福建省福州市鼓楼区"",
	""COMPLAINT_PC"": ""100010"",
	""TENDER_PROJECT_CODE"": ""E473501211712180002004"",
	""TENDER_PROJECT_NAME"": ""测试普通住建项目（石狮住建）"",
	""TENDER_CLASS"": ""A01"",
	""ACCEPT_DEPID"": ""388"",
	""ACCEPT_DEPID_TEXT"": ""石狮市交建局"",
	""COMPLAINT_SX"": ""1"",
	""COMPLAINT_TITLE"": ""ZCX测试投诉标题0708001"",
	""COMPLAINT_CONTENT"": ""zcx测试投诉标题zcx测试投诉标题zcx测试投诉标题zcx测试投诉标题zcx测试投诉标题zcx测试投诉标题zcx测试投诉标题zcx测试投诉标题zcx测试投诉标题zcx测试投诉标题zcx测试投诉标题zcx测试投诉标题zcx测试投诉标题zcx测试投诉标题zcx测试投诉标题"",
	""ZMCL_AIDS"": ""d1364c7dc18d44198c11fbb61fe3dee2"",
	""FR_SFZ_AIDS"": [
		{
			""new_id"": ""5ea93b37faae152db4658fb2"",
			""id"": ""5f057ee6faae1526384001d3"",
			""name"": ""法人身份证扫描件.pdf"",
			""url"": ""/file/getcontent/5ea93b37faae152db4658fb2.pdf"",
			""md5"": ""4EF93BDA83A99B9411D65C0089B80F84"",
			""uid"": 1594195690206,
			""status"": ""success"",
			""type"": ""FR_SFZ_AIDS"",
			""Guid"": ""cccfb44eae684a66b89c991d7953b1b4"",
			""signUrl"": ""/JdPortal/FileContent/Jd/Sys/cccfb44eae684a66b89c991d7953b1b4""
		}
	],
	""OTHER_AIDS"": ""532ee8951a7148168c5e6dcbdd6694c8"",
	""SFZ_AIDS"": ""cccfb44eae684a66b89c991d7953b1b4"",
	""ts"": 1594195865789
}";

            #endregion

            inputStream = @"{""PROJECT_CATEGORY"":""1"",""PLATFORM_CODE"":"""",""PROJECT_TYPE"":""A01"",""timeType"":"""",""BeginTime"":""2020-07-07 00:00:00"",""EndTime"":""2020-08-13 23:59:59"",""createTime"":[""2020-07-06T16:00:00.000Z"",""2020-08-13T15:59:59.000Z""],""pageNo"":1,""pageSize"":10,""total"":54,""ts"":1594806302001}";

            var dic = new Dictionary<string, string>();
            var jObject = JObject.Parse(inputStream);
            var ts = "";
            foreach (var item in jObject)
            {
                var v = item.Value?.ToString();
                if (!string.IsNullOrWhiteSpace(v))
                {
                    var v1 = JsonConvert.SerializeObject(item.Value).TrimStart('"').TrimEnd('"');// Regex.Replace(v, "\\r", "");
                    if (item.Key.Equals("ts", StringComparison.CurrentCultureIgnoreCase))
                    {
                        ts = v1;
                    }

                    dic.Add(item.Key, v1);
                }

            }
            var fwSign = CommonUtils.SignRequest(dic, ConfigHelper.AppSettings.FW_PORTAL_SIGN_KEY, false);
            Console.WriteLine(fwSign);
            Console.WriteLine();
            var jdSign = CommonUtils.SignRequest(dic, ConfigHelper.AppSettings.JD_PORTAL_SIGN_KEY, false);
            Console.WriteLine(jdSign);
        }
    }
}
