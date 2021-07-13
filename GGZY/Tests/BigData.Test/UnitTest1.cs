using System;
using GGZY.Core.Converters;
using GGZY.Core.Extensions;
using GGZY.Services.Base;
using GGZY.Services.BigData;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BigData.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int cout = 0;
            try
            {
                foreach (var tuple in ServicesFactory.GGZYJD.BigDataMainService.sqlTuple)
                {
                    if ("GCJS_LeftAmountCount_sheng,GCJS_LeftJieYue_sheng,CQ_List_AmountCount_sheng".Contains(tuple.Item1))
                    {
                        continue;
                    }
                    BigDataSearchModel bdsm = new BigDataSearchModel
                    {
                        BeginTime = new DateTime(2018, 1, 1), EndTime = new DateTime(2020, 1, 1)
                    };
                    switch (tuple.Item1)
                    {
                        case "CQ_List_AmountCount":
                            bdsm.type = "sw";
                            bdsm.pareacode = "350100";
                            break;
                        case "CQ_Chart_RateType":
                        case "CQ_Chart_RateJYType":
                        case "CQ_Value_AmountCount":
                        case "CQ_Table_AmountCount_Plan":
                        case "CQ_Chart_JiaoYiByDate":
                        case "GCJS_LeftAmountCount":
                        case "GCJS_LeftJieYue":
                        case "GCJS_ChartType":
                        case "GCJS_JiaoYeMethod":
                        case "GCJS_ChartJieYue_Month":
                        case "GCJS_ChartJieYue_Day":
                        case "CQ_Value_Rate":
                            bdsm.pareacode = "350100";
                            break;
                        case "EXPERT_CHART_INFO":
                        case "EXPERT_TENDERER":
                        case "EXPERT_WIN_BIDDER":
                        case "EXPERT_AREA":
                        case "EXPERT_AGENCY":
                        case "EXPERT_BIDDER":
                        case "TENDER_CHART_TOUBIAO":
                        case "TENDER_AREA":
                        case "TENDER_PROXY":
                        case "TENDER_PROXY_WIN":
                        case "TENDER_TENDERER":
                        case "TENDER_TENDERER_WIN":
                        case "TENDER_EXPERT":
                        case "TENDER_EXPERT_WIN":
                        case "TENDER_OTHER":
                        case "TENDER_OTHER_WIN":
                        case "TENDER_WIN_COUNT":
                        case "TENDER_CHART_WIN":
                        case "AGENCY_CHART_INFO":
                        case "AGENCY_AREA":
                        case "PROXY_TENDERER":
                        case "PROXY_WIN_BIDDER":
                        case "PROXY_EXPERT":
                        case "PROXY_BIDDER_DIAG":
                        case "TENDERER_CHART_INFO":
                        case "TENDERER_AREA":
                        case "TENDERER_PROXY":
                        case "TENDERER_WIN_BIDDER":
                        case "TENDERER_EXPERT":
                        case "TENDERER_BIDDER_DIAG":
                            bdsm.code = "913506026919213696";
                            break;
                        case "EXPERT_INFO":
                        case "TENDER_INFO":
                        case "TENDERER_INFO":
                        case "TENDERER_INFO_MODE":
                        case "TENDERER_INFO_TYPE":
                        case "TENDERER_INFO_AREA":
                        case "TENDERER_INFO_MAX":
                            bdsm.BeginTime = DateTime.MinValue;
                            bdsm.EndTime = DateTime.MinValue;
                            bdsm.code = "16253627-9";
                            break;
                        case "TENDER_INFO_TYPE":
                        case "TENDER_INFO_AREA":
                        case "TENDER_INFO_MAX":
                        case "AGENCY_INFO_TYPE":
                            bdsm.BeginTime = DateTime.MinValue;
                            bdsm.EndTime = DateTime.MinValue;
                            bdsm.code = "913501000503462372";
                            break;
                        case "USER_TENDER_LIST_OLD":
                        case "USER_TENDERER_LIST":
                        case "USER_EXPERT_LIST":
                        case "USER_AGENCY_LIST":
                            bdsm.pageindex = 1;
                            bdsm.pagesize = 10;
                            bdsm.name = "福州";
                            bdsm.AREACODE = "350100";
                            bdsm.code = "110203222841";
                            break;
                        case "USER_TENDER_LIST":
                            bdsm.BeginTime = DateTime.MinValue;
                            bdsm.EndTime = DateTime.MinValue;
                            bdsm.pageindex = 1;
                            bdsm.pagesize = 10;
                            bdsm.name = "福州";
                            bdsm.AREACODE = "350100";
                            bdsm.code = "110203222841";
                            break;
                        case "WIN_BIDDER_LIST":
                        case "TENDER_BIDDER_LIST":
                            bdsm.pageindex = 1;
                            bdsm.pagesize = 10;
                            bdsm.biddername = "福州";
                            break;
                        case "GCJSLY_Total":
                        case "GCJSLY_TotalAmountCount":
                        case "GCJSLY_Rank":
                        case "GCJSLY_Chart_AmountCount":
                        case "GCJSLY_Chart_Type":
                            bdsm.INDUSTRY_TYPE = "A02";
                            break;
                        case "AGENCY_INFO":
                        case "AGENCY_INFO_MODE":
                        case "AGENCY_INFO_AREA":
                        case "AGENCY_INFO_MAX":
                            bdsm.BeginTime = DateTime.MinValue;
                            bdsm.EndTime = DateTime.MinValue;
                            bdsm.code = "16253627-9";
                            break;
                        case "DZJG_LIST":
                            bdsm.pageindex = 1;
                             bdsm.pagesize = 10;
                            bdsm.AREACODE = "350000";
                            break;
                        case "WIN_LIST":
                            bdsm.BeginTime = DateTime.MinValue;
                            bdsm.EndTime = DateTime.MinValue;
                            bdsm.WIN_BIDDER_CODE = "9135010005034623729";
                            break;
                    }

                    if (tuple.Item1 == "test") continue;
                    bdsm.method = tuple.Item1;
                    Console.WriteLine(tuple.Item1);
                    var r = ServicesFactory.GGZYJD.BigDataMainService.GetData(bdsm);
                    Console.WriteLine(r.Serializer());
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine(cout++);
                }
            }
#pragma warning disable CS0168 // 声明了变量“e”，但从未使用过
            catch (Exception e)
#pragma warning restore CS0168 // 声明了变量“e”，但从未使用过
            {
                throw;
            }
        }
        [TestMethod]
        public void TestMethod2()
        {
            BigDataSearchModel bdsm = new BigDataSearchModel();
            bdsm.BeginTime = new DateTime(2018, 1, 1);
            bdsm.EndTime = new DateTime(2020, 1, 1);
            bdsm.method = "EXPERT_AREA";
            bdsm.code = "913506026919213696";
            //bdsm.type = "sw";
            //bdsm.pareacode = "350000";

            var r = ServicesFactory.GGZYJD.BigDataMainService.GetData(bdsm);
            Console.WriteLine(r.Serializer());

        }
        [TestMethod]
        public void TestMethod3()
        {
            BigDataSearchModel bdsm = new BigDataSearchModel();
            bdsm.BeginTime = new DateTime(2018, 1, 1);
            bdsm.EndTime = new DateTime(2020, 1, 1);
            bdsm.method = "TENDER_BIDDER_LIST";
            bdsm.pageindex = 1;
            bdsm.pagesize = 10;
            bdsm.biddername = "福州";
            //bdsm.AREACODE = "350100";
            //bdsm.code = "110203222841";

            var r = ServicesFactory.GGZYJD.BigDataMainService.GetData(bdsm);
            Console.WriteLine(r.Serializer());

        }
    }
}
