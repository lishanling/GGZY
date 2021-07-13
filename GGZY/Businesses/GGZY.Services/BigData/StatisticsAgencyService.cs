using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Fields;
using GGZY.Services.Infrastructure.Model.BigData;
using GGZYFW.DbEntity;

namespace GGZY.Services.BigData
{
    /// <summary>
    /// 工程领域监察大数据服务系统-综合统计-代理机构情况
    /// </summary>
    public partial class StatisticsAgencyService : BaseServiceT<FwEntity>
    {
        #region 项目总量排行


        /// <summary>
        /// 项目总量排行
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult ProjectCountRank(StatisticsBidderSearchModel search)
        {
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode;
            var typeList = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {

                var tenderAnnQuaInqueryAnnCon = new WhereClipBuilder();
                if (search.BeginTime.HasValue)
                {
                    tenderAnnQuaInqueryAnnCon.And(TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME >= search.BeginTime);
                }
                if (search.EndDateTime.HasValue)
                {
                    tenderAnnQuaInqueryAnnCon.And(TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME <= search.EndDateTime);
                }

                var tenderCon = new WhereClipBuilder(TENDER_PROJECT._.TENDER_AGENCY_NAME.Len() > 5 && TENDER_PROJECT._.REGION_CODE.BeginWith(rootAreaCode) && TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(typeList));
                if (rootAreaCode == "3501")
                {
                    tenderCon.And(TENDER_PROJECT._.REGION_CODE != "350128");
                }
                if (!string.IsNullOrWhiteSpace(search.TENDER_PROJECT_TYPE))
                {
                    if (search.TENDER_PROJECT_TYPE.Contains(","))
                    {
                        var projectTypes =
                            search.TENDER_PROJECT_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        tenderCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(projectTypes));
                    }
                    else
                    {
                        tenderCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE == search.TENDER_PROJECT_TYPE);
                    }
                }
                //if (!string.IsNullOrWhiteSpace(search.TENDER_PROJECT_TYPE))
                //{
                //    tenderCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE == search.TENDER_PROJECT_TYPE);
                //}

                if (!string.IsNullOrWhiteSpace(search.AREACODE))
                {
                    tenderCon.And(DSJ_AREA._.PCODE == search.AREACODE);
                }
                if (!string.IsNullOrWhiteSpace(search.LEGAL_CODE))
                {
                    tenderCon.And(LEGAL_PERSON_BASE._.LEGAL_CODE.Contain(search.LEGAL_CODE));
                }
                if (!string.IsNullOrWhiteSpace(search.LEGAL_NAME))
                {
                    tenderCon.And(TENDER_PROJECT._.TENDER_AGENCY_NAME.Contain(search.LEGAL_NAME));
                }
                var tenderAnnQuaInqueryAnnSection = Fw.TenderAnnQuaInqueryAnnService
                    .FromWhere(tenderAnnQuaInqueryAnnCon.ToWhereClip())
                    .Select(TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE.Distinct());

                // var winResultAnnoSection = Fw.WinResultAnnoService.FromWhere().GroupBy(WIN_RESULT_ANNO._.TENDER_PROJECT_CODE).Select(WIN_RESULT_ANNO._.TENDER_PROJECT_CODE);

                var winSection = Fw.TenderProjectService.FromWhere()
                    .InnerJoin<WIN_RESULT_ANNO>(WIN_RESULT_ANNO._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                    .InnerJoin<TENDER_ANN_QUA_INQUERY_ANN>(TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE && tenderAnnQuaInqueryAnnCon.ToWhereClip())
                    .GroupBy(TENDER_PROJECT._.TENDER_AGENCY_NAME)
                    .Select(TENDER_PROJECT._.TENDER_AGENCY_NAME.As("LEGAL_NAME"), TENDER_PROJECT._.TENDER_PROJECT_CODE.Count().As("WIN_COUNT"));


                var legalBase = Fw.LegalPersonBaseService.FromWhere(LEGAL_PERSON_BASE._.LEGAL_ROLE == "02" || LEGAL_PERSON_BASE._.LEGAL_ROLE == "02,03")
                    .GroupBy(LEGAL_PERSON_BASE._.LEGAL_NAME)
                    .Select(LEGAL_PERSON_BASE._.LEGAL_CODE.Max(), LEGAL_PERSON_BASE._.LEGAL_NAME,
                        LEGAL_PERSON_BASE._.REGION_CODE.Max());
                var tenderSection = Fw.TenderProjectService.FromWhere(tenderCon.ToWhereClip())
                      .LeftJoinTmp<LEGAL_PERSON_BASE>(legalBase, TENDER_PROJECT._.TENDER_AGENCY_NAME == LEGAL_PERSON_BASE._.LEGAL_NAME)
                      .LeftJoin<DSJ_AREA>(DSJ_AREA._.OLDCODE == LEGAL_PERSON_BASE._.REGION_CODE)
                      .LeftJoinTmp<TENDER_ANN_QUA_INQUERY_ANN>(tenderAnnQuaInqueryAnnSection,
                          TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)//todo 这里用左连接 实际上时间过滤没生效 应该改成内连接
                      .LeftJoinTmp<V_TENDER_PROJECT_WIN_RESULT>(winSection, V_TENDER_PROJECT_WIN_RESULT.LEGAL_NAME == TENDER_PROJECT._.TENDER_AGENCY_NAME)
                      .GroupBy(TENDER_PROJECT._.TENDER_AGENCY_NAME)
                      .Select(TENDER_PROJECT._.TENDER_AGENCY_NAME.As("LEGAL_NAME"), TENDER_PROJECT._.TENDER_AGENCY_NAME.Count().As("Count"), V_TENDER_PROJECT_WIN_RESULT.WIN_COUNT.Max(), DSJ_AREA._.AREANAME.Max(), LEGAL_PERSON_BASE._.LEGAL_CODE.Max());

                var total = tenderSection.Count();
                if (total > 0)
                {
                    var list = tenderSection.OrderBy(new Field("Count").Desc)
                        .Page(search.PageSize, search.PageNo)
                        .ToList<StatisticsBidderRankModel>();
                    var pageList = list.ToPageTableResult(search, total);
                    return pageList;
                }
            }
            return search.ToPageTableResult(0);
        }

        #endregion

        #region 招标代理项目金额分布

        /// <summary>
        /// 招标代理项目金额分布
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public StatisticsBidderDataSummaryModel ProjectAmountDistribution_ActiveCount(StatisticsBidderSearchModel search)
        {

            var r = new StatisticsBidderDataSummaryModel();
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode;
            var typeList = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;

            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {
                var condition = new WhereClipBuilder(V_BIG_JG._.AMOUNT < 300000 && V_BIG_JG._.AREACODE.BeginWith(rootAreaCode) && V_BIG_JG._.PROJECT_TYPE.In(typeList));//早期数据金额单位不规范
                if (rootAreaCode == "3501")
                {
                    condition.And(V_BIG_JG._.AREACODE != "350128");
                }
                if (!string.IsNullOrWhiteSpace(search.TENDER_PROJECT_TYPE))
                {
                    if (search.TENDER_PROJECT_TYPE.Contains(","))
                    {
                        var projectTypes =
                            search.TENDER_PROJECT_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        condition.And(V_BIG_JG._.PROJECT_TYPE.In(projectTypes));
                    }
                    else
                    {
                        condition.And(V_BIG_JG._.PROJECT_TYPE == search.TENDER_PROJECT_TYPE);
                    }
                }
                if (search.BeginTime.HasValue)
                {
                    condition.And(V_BIG_JG._.M_TM >= search.BeginTime);
                }

                if (search.EndDateTime.HasValue)
                {
                    condition.And(V_BIG_JG._.M_TM <= search.EndDateTime);
                }

                if (!string.IsNullOrWhiteSpace(search.AREACODE))
                {
                    condition.And(V_BIG_JG._.AREACODE == search.AREACODE);
                }

                if (!string.IsNullOrWhiteSpace(search.LEGAL_CODE))
                {
                    condition.And(V_BIG_JG._.TENDER_AGENCY_CODE.Contain(search.LEGAL_CODE));
                }

                if (!string.IsNullOrWhiteSpace(search.LEGAL_NAME))
                {
                    condition.And(V_BIG_JG._.TENDER_AGENCY_NAME.Contain(search.LEGAL_NAME));
                }

                var query = FromWhere<V_BIG_JG>(condition.ToWhereClip());
                r.ACTIVE_COUNT = query.Select(V_BIG_JG._.TENDER_AGENCY_NAME.Distinct().Count()).ToScalar<Int64>();


                var data = query
                    .InnerJoin<SECTION>(SECTION._.BID_SECTION_CODE == V_BIG_JG._.SECTION_CODE)
                    .GroupBy(SECTION._.TENDER_PROJECT_CLASSIFY_CODE.Substring(0, 3))
                    .Select(
                        SECTION._.TENDER_PROJECT_CLASSIFY_CODE.Substring(0, 3).As("Name")
                        , Field.All.Count().As("Value")
                        , V_BIG_JG._.AMOUNT.Sum()
                    )
                    .ToList<StatisticsBidderDataSourceModel>();
                var types = new List<string> { "A01", "A03", "A04", "A05", "A06", "A08" };
                var others = data.FindAll(c => types.All(t => t != c.Name));
                r.CHART_DATA = new List<Infrastructure.Model.BigData.PieSeriesData>
            {
                new Infrastructure.Model.BigData.PieSeriesData{ Name="施工", Value=data.FirstOrDefault(c=>c.Name=="A08")?.Amount / 10000},
                new Infrastructure.Model.BigData.PieSeriesData{ Name="监理", Value=data.FirstOrDefault(c=>c.Name=="A05")?.Amount / 10000},
                new Infrastructure.Model.BigData.PieSeriesData{ Name="勘察", Value=data.FirstOrDefault(c=>c.Name=="A03")?.Amount / 10000},
                new Infrastructure.Model.BigData.PieSeriesData{ Name="设计", Value=data.FirstOrDefault(c=>c.Name=="A04")?.Amount / 10000},
                new Infrastructure.Model.BigData.PieSeriesData{ Name="造价", Value=data.FirstOrDefault(c=>c.Name=="A06")?.Amount / 10000},
                new Infrastructure.Model.BigData.PieSeriesData{ Name="规划", Value=data.FirstOrDefault(c=>c.Name=="A01")?.Amount / 10000},
                new Infrastructure.Model.BigData.PieSeriesData{ Name="其他", Value=others.Sum(c=>c.Amount/ 10000) }
            };
                r.TOTAL_AMOUNT = data.Sum(c => c.Amount / 10000);
                r.TOTAL_COUNT = data.Sum(c => c.Value);
            }

            return r;


        }


        #endregion

        #region 代理机构分析-总数|新增数|活跃数|总次数

        /// <summary>
        /// 代理机构分析-总数|新增数|活跃数|总次数
        /// TODO 梳理 数据填充 zlw
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public StatisticsSummaryModel UserCount(StatisticsBidderSearchModel search)
        {
            var obj = new StatisticsSummaryModel();
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode;
            var typeList = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {
                var totalCon = new WhereClipBuilder(TENDER_PROJECT._.REGION_CODE.BeginWith(rootAreaCode) &&
                                                    TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(typeList));
                if (rootAreaCode == "3501")
                {
                    totalCon.And(TENDER_PROJECT._.REGION_CODE != "350128");
                }
                var addAgencyCon = new WhereClipBuilder();
                //var condition = new WhereClipBuilder(V_BIG_JG._.AMOUNT < 300000);//早期数据金额单位不规范
                //var addCon = new WhereClipBuilder(LEGAL_PERSON_BASE._.LEGAL_ROLE == "02" ||LEGAL_PERSON_BASE._.LEGAL_ROLE == "02,03");//代理
               
                if (!string.IsNullOrWhiteSpace(search.TENDER_PROJECT_TYPE))
                {
                    if (search.TENDER_PROJECT_TYPE.Contains(","))
                    {
                        var projectTypes =
                            search.TENDER_PROJECT_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        totalCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(projectTypes));
                    }
                    else
                    {
                        totalCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE == search.TENDER_PROJECT_TYPE);
                    }
                }
                if (search.BeginTime.HasValue)
                {
                    //condition.And(V_BIG_JG._.M_TM >= search.BeginTime);
                    addAgencyCon.And(TENDER_PROJECT._.M_TM >= search.BeginTime);
                    //addCon.And(LEGAL_PERSON_BASE._.M_TM >= search.BeginTime);
                }

                if (search.EndDateTime.HasValue)
                {
                    //condition.And(V_BIG_JG._.M_TM <= search.EndDateTime);
                    addAgencyCon.And(TENDER_PROJECT._.M_TM <= search.EndDateTime);
                    //addCon.And(LEGAL_PERSON_BASE._.M_TM <= search.EndDateTime);
                }

                if (!string.IsNullOrWhiteSpace(search.AREACODE))
                {
                    //condition.And(V_BIG_JG._.AREACODE == search.AREACODE);
                    //addCon.And(LEGAL_PERSON_BASE._.REGION_CODE == search.AREACODE);
                    totalCon.And(TENDER_PROJECT._.REGION_CODE == search.AREACODE);
                }

                if (!string.IsNullOrWhiteSpace(search.LEGAL_CODE))
                {
                    //condition.And(V_BIG_JG._.TENDER_AGENCY_CODE.Contain(search.LEGAL_CODE));
                    //addCon.And(LEGAL_PERSON_BASE._.LEGAL_CODE.Contain(search.LEGAL_CODE));
                    totalCon.And(TENDER_PROJECT._.TENDER_AGENCY_CODE.Contain(search.LEGAL_CODE));
                }

                if (!string.IsNullOrWhiteSpace(search.LEGAL_NAME))
                {
                    //condition.And(V_BIG_JG._.TENDER_AGENCY_NAME.Contain(search.LEGAL_NAME));
                    //addCon.And(LEGAL_PERSON_BASE._.LEGAL_NAME.Contain(search.LEGAL_NAME));
                    totalCon.And(TENDER_PROJECT._.TENDER_AGENCY_NAME.Contain(search.LEGAL_NAME));
                }

                obj.TOTAL_COUNT = Fw.TenderProjectService.FromWhere(totalCon.ToWhereClip())
                    .InnerJoin<TENDER_ANN_QUA_INQUERY_ANN>(TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE ==
                                                           TENDER_PROJECT._.TENDER_PROJECT_CODE)
                    .Select(TENDER_PROJECT._.TENDER_AGENCY_CODE).Distinct().Count();//代理总数
                var addCount = Fw.TenderProjectService.FromWhere(totalCon.ToWhereClip())
                    .InnerJoin<TENDER_ANN_QUA_INQUERY_ANN>(TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE ==
                                                           TENDER_PROJECT._.TENDER_PROJECT_CODE)
                    .GroupBy(TENDER_PROJECT._.TENDER_AGENCY_CODE)
                    .Select(TENDER_PROJECT._.TENDER_AGENCY_CODE, TENDER_PROJECT._.M_TM.Min().As("M_TM"));
                obj.ADD_COUNT = Fw.TenderAnnQuaInqueryAnnService.FromWhere(addAgencyCon.ToWhereClip())
                    .RightJoinTmp<TENDER_PROJECT>(addCount,"1=0")
                    .Select(TENDER_PROJECT._.TENDER_AGENCY_CODE).Distinct().Count();//新增代理总数

                obj.ACTIVE_COUNT = Fw.TenderProjectService.FromWhere(totalCon.ToWhereClip()&& addAgencyCon.ToWhereClip())
                    .InnerJoin<TENDER_ANN_QUA_INQUERY_ANN>(TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE ==
                                                           TENDER_PROJECT._.TENDER_PROJECT_CODE)
                    .Select(TENDER_PROJECT._.TENDER_AGENCY_CODE).Distinct().Count();//活跃代理数
                obj.PROJECT_COUNT = Fw.TenderProjectService.FromWhere(totalCon.ToWhereClip() && addAgencyCon.ToWhereClip())
                    .InnerJoin<TENDER_ANN_QUA_INQUERY_ANN>(TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE ==
                                                           TENDER_PROJECT._.TENDER_PROJECT_CODE)
                    .Select(TENDER_PROJECT._.TENDER_PROJECT_CODE).Distinct().Count();//代理项目数
            }
            return obj;
        }

        #endregion

        #region 省份占比
        /// <summary>
        /// 省份占比
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<PieSeriesData> RegionChart(StatisticsBidderSearchModel search)
        {
            var sn = 0;
            var sw = 0;
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode;
            var typeList = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {
                var totalCon = new WhereClipBuilder(TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(typeList));//TENDER_PROJECT._.REGION_CODE.BeginWith(rootAreaCode) &&
               
                if (!string.IsNullOrWhiteSpace(search.TENDER_PROJECT_TYPE))
                {
                    if (search.TENDER_PROJECT_TYPE.Contains(","))
                    {
                        var projectTypes =
                            search.TENDER_PROJECT_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        totalCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(projectTypes));
                    }
                    else
                    {
                        totalCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE == search.TENDER_PROJECT_TYPE);
                    }
                }
                if (search.BeginTime.HasValue)
                {
                    totalCon.And(TENDER_PROJECT._.M_TM >= search.BeginTime);
                }

                if (search.EndDateTime.HasValue)
                {
                    totalCon.And(TENDER_PROJECT._.M_TM <= search.EndDateTime);
                }

                if (!string.IsNullOrWhiteSpace(search.AREACODE))
                {
                   // totalCon.And(TENDER_PROJECT._.REGION_CODE == search.AREACODE);
                }

                if (!string.IsNullOrWhiteSpace(search.LEGAL_CODE))
                {
                    totalCon.And(TENDER_PROJECT._.TENDER_AGENCY_CODE.Contain(search.LEGAL_CODE));
                }

                if (!string.IsNullOrWhiteSpace(search.LEGAL_NAME))
                {
                    totalCon.And(TENDER_PROJECT._.TENDER_AGENCY_NAME.Contain(search.LEGAL_NAME));
                }
                var total = Fw.TenderProjectService.FromWhere(totalCon.ToWhereClip())
                    .InnerJoin<TENDER_ANN_QUA_INQUERY_ANN>(TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE ==
                                                           TENDER_PROJECT._.TENDER_PROJECT_CODE)
                    .Select(TENDER_PROJECT._.TENDER_AGENCY_CODE).Distinct().Count();//代理总数
                sn = Fw.TenderProjectService.FromWhere(totalCon.ToWhereClip()&& LEGAL_PERSON_BASE ._.REGION_CODE.Contain("35"))
                    .InnerJoin<TENDER_ANN_QUA_INQUERY_ANN>(TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE ==
                                                           TENDER_PROJECT._.TENDER_PROJECT_CODE)
                    .LeftJoin<LEGAL_PERSON_BASE>(LEGAL_PERSON_BASE._.LEGAL_CODE==TENDER_PROJECT._.TENDER_AGENCY_CODE)
                    .Select(TENDER_PROJECT._.TENDER_AGENCY_CODE).Distinct().Count();//省内代理总数
                sw = total - sn;
            }
            var r = new List<PieSeriesData>
            {
                new PieSeriesData {Name = "SN", Value = sn},//省内
                new PieSeriesData {Name = "SW", Value = sw},//省外
            };
            return r;
        }
        #endregion


        #region 等级分布
        /// <summary>
        /// 等级分布
        /// TODO 梳理 数据填充 zlw
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public PieSeries Grade(StatisticsBidderSearchModel search)
        {
            var r = new PieSeries
            {
                Data = new List<PieSeriesData>
                {
                    new PieSeriesData {Value = 0, Name = $"甲级:"},
                    new PieSeriesData {Value = 0, Name =$"乙级:"},
                    new PieSeriesData {Value = 0, Name = $"丙级:"},
                    new PieSeriesData {Value = 0, Name = $"丁级:"},
                    new PieSeriesData {Value = 0, Name = $"暂定级(预乙级):"},
                }
            };

            return r;
        }

        #endregion

        #region 企业性质
        /// <summary>
        /// 企业性质
        /// TODO 梳理 数据填充 zlw
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public PieSeries Nature(StatisticsBidderSearchModel search)
        {
            var r = new PieSeries
            {
                Data = new List<PieSeriesData>
                {
                    new PieSeriesData {Value = 0, Name = "国有企业"},
                    new PieSeriesData {Value = 0, Name = "三资企业"},
                    new PieSeriesData {Value = 0, Name = "事业单位"},
                    new PieSeriesData {Value = 0, Name = "集体所有制企业"},
                    new PieSeriesData {Value = 0, Name = "私营企业"},
                    new PieSeriesData {Value = 0, Name = "其他制企业"},
                    new PieSeriesData {Value = 0, Name = "集体所有联营企业"},
                }
            };

            return r;
        }

        #endregion


        #region 代理项目资金规模占比
        /// <summary>
        /// 企业性质
        /// TODO 梳理 数据填充 zlw
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<IChartSeries> CapitalScale(StatisticsBidderSearchModel search)
        {
            var r = new List<IChartSeries>
            {
                new PieSeries
                {
                    Name = "预期",
                    Data = new List<PieSeriesData>
                    {
                        new PieSeriesData {Value = 15, Name = "国有企业"},
                        new PieSeriesData {Value = 25, Name = "三资企业"},
                        new PieSeriesData {Value = 35, Name = "事业单位"},
                        new PieSeriesData {Value = 45, Name = "集体所有制企业"},
                        new PieSeriesData {Value = 55, Name = "私营企业"},
                        new PieSeriesData {Value = 65, Name = "其他制企业"},
                        new PieSeriesData {Value = 75, Name = "集体所有联营企业"},
                    }
                },
                new PieSeries
                {
                    Name = "实际",
                    Data = new List<PieSeriesData>
                    {
                        new PieSeriesData {Value = 15, Name = "国有企业"},
                        new PieSeriesData {Value = 16, Name = "三资企业"},
                        new PieSeriesData {Value = 17, Name = "事业单位"},
                        new PieSeriesData {Value = 18, Name = "集体所有制企业"},
                        new PieSeriesData {Value = 19, Name = "私营企业"},
                        new PieSeriesData {Value = 10, Name = "其他制企业"},
                        new PieSeriesData {Value = 11, Name = "集体所有联营企业"},
                    }
                }

            };

            return r;
        }

        #endregion


        #region 注册资本
        /// <summary>
        /// 注册资本
        /// TODO 梳理 数据填充 zlw
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public PieSeries Capital(StatisticsBidderSearchModel search)
        {
            var r = new PieSeries
            {
                Data = new List<PieSeriesData>
                {
                    new PieSeriesData {Value = 0, Name = "5000万以上"},
                    new PieSeriesData {Value = 0, Name = "2500-5000万"},
                    new PieSeriesData {Value = 0, Name = "1000-2500万"},
                    new PieSeriesData {Value = 0, Name = "1000万以下"}
                }
            };

            return r;
        }

        #endregion

        #region 参与招标情况
        /// <summary>
        /// 参与招标情况
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ChartOptionModel Participation(StatisticsBidderSearchModel search)
        {
            var r = new ChartOptionModel();
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode;
            var typeList = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {

                #region 时间处理

                var end = DateTime.Today;
                var begin = end.AddDays(1 - end.Day);
                if (search.EndDateTime.HasValue)
                {
                    end = search.EndDateTime.Value;
                }

                if (search.BeginTime.HasValue)
                {
                    begin = search.BeginTime.Value;
                }
                string format = "yyyy-MM", dbFormat = "yyyy-mm";
                if ((end - begin).Duration().TotalDays < 32)
                {
                    format = "yyyy-MM-dd"; dbFormat = "yyyy-mm-dd";
                }

                #endregion
                var tenderAnnQuaInqueryAnnCon = new WhereClipBuilder(TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME >= begin && TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME <= end);
                var winResultAnnoCon = new WhereClipBuilder(WIN_RESULT_ANNO._.M_TM >= begin && WIN_RESULT_ANNO._.M_TM <= end && TENDER_PROJECT._.REGION_CODE.BeginWith(rootAreaCode) && TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(typeList));

                var tenderCon = new WhereClipBuilder(TENDER_PROJECT._.TENDERER_NAME.Len() > 5 && TENDER_PROJECT._.REGION_CODE.BeginWith(rootAreaCode) && TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(typeList));
                if (rootAreaCode == "3501")
                {
                    tenderCon.And(TENDER_PROJECT._.REGION_CODE != "350128");
                    winResultAnnoCon.And(TENDER_PROJECT._.REGION_CODE != "350128");
                }
                if (!string.IsNullOrWhiteSpace(search.TENDER_PROJECT_TYPE))
                {
                    if (search.TENDER_PROJECT_TYPE.Contains(","))
                    {
                        var projectTypes =
                            search.TENDER_PROJECT_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        tenderCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(projectTypes));
                        winResultAnnoCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(projectTypes));
                    }
                    else
                    {
                        tenderCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE == search.TENDER_PROJECT_TYPE);
                        winResultAnnoCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE == search.TENDER_PROJECT_TYPE);
                    }
                }

                if (!string.IsNullOrWhiteSpace(search.AREACODE))
                {
                    tenderCon.And(TENDER_PROJECT._.REGION_CODE == search.AREACODE);
                    winResultAnnoCon.And(TENDER_PROJECT._.REGION_CODE == search.AREACODE);
                }


                var enterpriseData = Fw.TenderProjectService.FromWhere(tenderCon.ToWhereClip())
                    .InnerJoin<TENDER_ANN_QUA_INQUERY_ANN>(tenderAnnQuaInqueryAnnCon.ToWhereClip() && TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                    .GroupBy(TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME.ToChar(dbFormat))
                    .Select(TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME.ToChar(dbFormat).As("Name"),
                        TENDER_PROJECT._.TENDER_AGENCY_CODE.Distinct().Count().As("Value"))
                    .ToList<PieSeriesData>();
                var bidData = Fw.TenderProjectService.FromWhere(tenderCon.ToWhereClip())
                    .InnerJoin<TENDER_ANN_QUA_INQUERY_ANN>(tenderAnnQuaInqueryAnnCon.ToWhereClip() &&
                                                           TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE ==
                                                           TENDER_PROJECT._.TENDER_PROJECT_CODE)
                    .GroupBy(TENDER_PROJECT._.TENDER_AGENCY_CODE, TENDER_PROJECT._.TENDER_PROJECT_CODE,
                        TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME.ToChar(dbFormat))
                    .Select(TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME.ToChar(dbFormat).As("Name"))
                    .ToList<PieSeriesData>();//

                var bidSectionData = Fw.WinResultAnnoService.FromWhere(winResultAnnoCon.ToWhereClip())
                    .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE==WIN_RESULT_ANNO._.TENDER_PROJECT_CODE)
                    .GroupBy(WIN_RESULT_ANNO._.M_TM.ToChar(dbFormat))
                    .Select(WIN_RESULT_ANNO._.M_TM.ToChar(dbFormat).As("Name"), Field.All.Count().As("Value"))
                    .ToList<PieSeriesData>();
                var enterprise = new LineBarSeries("DLJGS");//代理机构数（招标项目&发布招标公告）
                var bid = new LineBarSeries("DLCS");//代理次数
                var bidSection = new LineBarSeries("BDS");//标段数 (中标结果公告)
                while (begin <= end)
                {
                    var tm = begin.ToString(format);
                    enterprise.Data.Add((enterpriseData.FirstOrDefault(c => c.Name == tm)?.Value)??0);
                    bid.Data.Add(bidData.Count(c => c.Name == tm));
                    bidSection.Data.Add((bidSectionData.FirstOrDefault(c => c.Name == tm)?.Value)??0);
                    r.XAxis.Data.Add(tm);
                    begin = format == "yyyy-MM" ? begin.AddMonths(1) : begin.AddDays(1);
                }
                r.Series.Add(enterprise);
                r.Series.Add(bid);
                r.Series.Add(bidSection);
            }
            return r;
        }

        #endregion

        #region 详情接口

        #region AGENCY_INFO 招标代理信息

        /// <summary>
        /// AGENCY_INFO
        /// 招标代理信息
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>

        public object AGENCY_INFO(StatisticsBidderSearchModel search)
        {
            //search.PageSize = 2;
            TENDER_PROJECT tenderProject =
                Fw.TenderProjectService.FromWhere(TENDER_PROJECT._.TENDER_AGENCY_NAME == search.KeyWord)
                    .LeftJoin<LEGAL_PERSON_BASE>(LEGAL_PERSON_BASE._.LEGAL_NAME==TENDER_PROJECT._.TENDER_AGENCY_NAME)
                    .LeftJoin<TENDER_AGENT_EX_INFO>(TENDER_AGENT_EX_INFO._.LEGAL_CODE==LEGAL_PERSON_BASE._.LEGAL_CODE)
                    .Select(TENDER_PROJECT._.TENDER_AGENCY_NAME,TENDER_PROJECT._.TENDER_AGENCY_CODE,TENDER_AGENT_EX_INFO._.QUAL_NAME.As("TENDER_AGENCY_PROPERTY"))
                    .ToFirst<TENDER_PROJECT>();
            List<LabelValueModel<int>> modes = Fw.TenderProjectService
                .FromWhere(TENDER_PROJECT._.TENDER_AGENCY_NAME == search.KeyWord)
                .InnerJoin<WIN_RESULT_ANNO>(WIN_RESULT_ANNO._.TENDER_PROJECT_CODE ==
                                            TENDER_PROJECT._.TENDER_PROJECT_CODE)
                .InnerJoin<SYS_DIC>(SYS_DIC._.TYPE == "1000" && SYS_DIC._.VALUE == TENDER_PROJECT._.TENDER_MODE)
                .GroupBy(SYS_DIC._.TEXT)
                .Select(SYS_DIC._.TEXT.As("Label"), TENDER_PROJECT._.All.Count().As("Value"))
                .OrderBy(LabelValueField.Value.Desc)
                .Page(2, search.PageNo)
                .ToList<LabelValueModel<int>>();
            List<LabelValueModel<int>> types = Fw.TenderProjectService
                .FromWhere(TENDER_PROJECT._.TENDER_AGENCY_NAME == search.KeyWord)
                .InnerJoin<WIN_RESULT_ANNO>(WIN_RESULT_ANNO._.TENDER_PROJECT_CODE ==
                                            TENDER_PROJECT._.TENDER_PROJECT_CODE)
                .InnerJoin<SYS_DIC>(SYS_DIC._.PID == "2525" && SYS_DIC._.VALUE == TENDER_PROJECT._.TENDER_PROJECT_TYPE)
                .GroupBy(SYS_DIC._.TEXT)
                .Select(SYS_DIC._.TEXT.As("Label"), TENDER_PROJECT._.All.Count().As("Value"))
                .OrderBy(LabelValueField.Value.Desc)
                .Page(search.PageSize, search.PageNo)
                .ToList<LabelValueModel<int>>();
            decimal maxAmount =
                FromWhere<V_BIG_JG>(V_BIG_JG._.TENDER_AGENCY_NAME == search.KeyWord && V_BIG_JG._.AMOUNT < 300000)
                    .Select(V_BIG_JG._.AMOUNT.Max().ROUND(4)).ToScalar<decimal>();

            List<LabelValueModel> areas = this.AGENCY_AREA(search);
            return new
            {
                NAME=tenderProject.TENDER_AGENCY_NAME,
                CODE=tenderProject.TENDER_AGENCY_CODE,
                TENDER_MODE = string.Join(",", modes.Select(m => m.Label)),
                TENDER_PROJECT_TYPE = string.Join(",", types.Select(m => m.Label)),
                MAX_AMOUNT = maxAmount,//万元
                AREANAME = string.Join(",", areas.Select(m => m.Label)),
                QUAL_NAME = tenderProject.TENDER_AGENCY_PROPERTY,//企业资质
            };
        }

        #endregion

        #region AGENCY_CHART_INFO 代理情况

        /// <summary>
        /// AGENCY_CHART_INFO
        /// 代理情况
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>

        public List<LabelValueModel> AGENCY_CHART_INFO(StatisticsBidderSearchModel search)
        {
            var condition = new WhereClipBuilder(V_BIG_JG._.TENDER_AGENCY_NAME == search.KeyWord ||
                                                 V_BIG_JG._.TENDER_AGENCY_CODE == search.KeyWord);
            if (search.BeginTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME <= search.EndDateTime);
            }
            var r = FromWhere<V_BIG_JG>(condition.ToWhereClip())
                .GroupBy(V_BIG_JG._.M_TM.Year)
                .Select(V_BIG_JG._.M_TM.Year.As("Label"), V_BIG_JG._.All.Count().As("Value"))
                .OrderBy(LabelValueField.Label)
                .ToList<LabelValueModel>();
            return r;
        }

        #endregion

        #region AGENCY_AREA 代理项目地区分布图

        /// <summary>
        /// AGENCY_AREA
        /// 代理项目地区分布图
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>

        public List<LabelValueModel> AGENCY_AREA(StatisticsBidderSearchModel search)
        {
            var condition = new WhereClipBuilder(V_BIG_JG._.TENDER_AGENCY_NAME == search.KeyWord ||
                                                 V_BIG_JG._.TENDER_AGENCY_CODE == search.KeyWord);
            if (search.BeginTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME <= search.EndDateTime);
            }
            var r = FromWhere<V_BIG_JG>(condition.ToWhereClip())
                .GroupBy(V_BIG_JG._.AREACODE.Substring(0, 4))
                .Select(V_BIG_JG._.AREACODE.Substring(0, 4).As("Id"), V_BIG_JG._.All.Count().As("Value"))
                .OrderBy(LabelValueField.Value.Desc)
                .ToList<LabelValueModel>();
            var areaCodes = r.Select(c => c.Id.PadRight(6, '0')).ToList();
            var areas = Fw.SysAreaQuanguoService.FromWhere(SYS_AREA_QUANGUO._.AREACODE.In(areaCodes)).ToList();
            r.ForEach(c =>
            {
                c.Id = c.Id.PadRight(6, '0');
                c.Label = areas.FirstOrDefault(o => o.AREACODE == c.Id)?.AREANAME;
            });
            return r;
        }

        #endregion

        #region PROXY_TENDERER 受委托排行 指承接业主项目业务情况排行，分析招标代理机构与招标人之间的紧密度

        /// <summary>
        /// PROXY_TENDERER
        /// 受委托排行
        /// 指承接业主项目业务情况排行，分析招标代理机构与招标人之间的紧密度
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<LabelValueModel> PROXY_TENDERER(StatisticsBidderSearchModel search)
        {
            var condition = new WhereClipBuilder(V_BIG_JG._.TENDER_AGENCY_NAME == search.KeyWord ||
                                                 V_BIG_JG._.TENDER_AGENCY_CODE == search.KeyWord);
            if (search.BeginTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME <= search.EndDateTime);
            }
            var r = FromWhere<V_BIG_JG>(condition.ToWhereClip())
                .GroupBy(V_BIG_JG._.TENDERER_NAME)
                .Select(V_BIG_JG._.TENDERER_NAME.As("Label"), V_BIG_JG._.All.Count().As("Value"))
                .Page(search.PageSize, search.PageNo)
                .OrderBy(LabelValueField.Value.Desc && LabelValueField.Label.Desc)
                .ToList<LabelValueModel>();
            return r;
        }

        #endregion

        #region PROXY_TENDERER_RATE 受委托招标占比分析 指招标代理承接业主业务占所有承接招标项目的比值，展示排行前5名所占比重

        /// <summary>
        /// PROXY_TENDERER_RATE
        /// 受委托招标占比分析
        /// 指招标代理承接业主业务占所有承接招标项目的比值，展示排行前5名所占比重
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<LabelValueModel<int>> PROXY_TENDERER_RATE(StatisticsBidderSearchModel search)
        {
            var condition = new WhereClipBuilder(V_BIG_JG._.TENDER_AGENCY_NAME == search.KeyWord ||
                                                 V_BIG_JG._.TENDER_AGENCY_CODE == search.KeyWord);
            if (search.BeginTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME <= search.EndDateTime);
            }
            var r = FromWhere<V_BIG_JG>(condition.ToWhereClip())
                .GroupBy(V_BIG_JG._.TENDERER_NAME)
                .Select(V_BIG_JG._.TENDERER_NAME.As("Label"), V_BIG_JG._.All.Count().As("Value"))
                .OrderBy(LabelValueField.Value.Desc && LabelValueField.Label.Desc)
                .ToList<LabelValueModel<int>>();
            var r1 = r.Take(search.PageSize).ToList();
            var r2 = r.Skip(search.PageSize).ToList();
            r1.Add(new LabelValueModel<int>
            {
                Id = "OTHER",
                Label = "其他",
                Value = r2.Sum(c=>c.Value)
            });
            return r1;
        }

        #endregion

        #region PROXY_BIDDER_DIAG 投标参与排行 指招标代理发出的项目经常参与的投标的企业排行，通过投标企业的活跃度分析招标代理机构与投标人的紧密度

        /// <summary>
        /// PROXY_BIDDER_DIAG
        /// 投标参与排行
        /// 指招标代理发出的项目经常参与的投标的企业排行，通过投标企业的活跃度分析招标代理机构与投标人的紧密度
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<LabelValueModel<int>> PROXY_BIDDER_DIAG(StatisticsBidderSearchModel search)
        {
            var condition = new WhereClipBuilder(V_BIG_JG._.TENDER_AGENCY_NAME == search.KeyWord ||
                                                 V_BIG_JG._.TENDER_AGENCY_CODE == search.KeyWord);
            if (search.BeginTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME <= search.EndDateTime);
            }
            var r = FromWhere<V_BIG_JG>(condition.ToWhereClip())
                .InnerJoin<TENDER_LIST>(TENDER_LIST._.TENDER_PROJECT_CODE==V_BIG_JG._.PROJECT_CODE)
                .GroupBy(TENDER_LIST._.BIDDER_NAME)
                .Select(TENDER_LIST._.BIDDER_NAME.As("Label"), TENDER_LIST._.All.Count().As("Value"))
                .OrderBy(LabelValueField.Value.Desc && LabelValueField.Label.Desc)
                .Page(search.PageSize,search.PageNo)
                .ToList<LabelValueModel<int>>();
            return r;
        }

        #endregion

        #region PROXY_WIN_BIDDER 中标企业排行 指招标人发出的项目中标率较高的企业占招标人所发项目的占比情况，分析招标代理机构与中标单位之间的紧密度

        /// <summary>
        /// PROXY_WIN_BIDDER
        /// 中标企业排行
        /// 指招标人发出的项目中标率较高的企业占招标人所发项目的占比情况，分析招标代理机构与中标单位之间的紧密度
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<LabelValueModel<int>> PROXY_WIN_BIDDER(StatisticsBidderSearchModel search)
        {
            var condition = new WhereClipBuilder(V_BIG_JG._.TENDER_AGENCY_NAME == search.KeyWord ||
                                                 V_BIG_JG._.TENDER_AGENCY_CODE == search.KeyWord);
            if (search.BeginTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME <= search.EndDateTime);
            }
            var r = FromWhere<V_BIG_JG>(condition.ToWhereClip())
                .GroupBy(V_BIG_JG._.WIN_BIDDER_NAME)
                .Select(V_BIG_JG._.WIN_BIDDER_NAME.As("Label"), V_BIG_JG._.All.Count().As("Value"))
                .OrderBy(LabelValueField.Value.Desc && LabelValueField.Label.Desc)
                .Page(search.PageSize,search.PageNo)
                .ToList<LabelValueModel<int>>();
            return r;
        }

        #endregion

        #region PROXY_EXPERT 评标专家参与排行 指招标代理机构发出的项目出现频次较多的评标专家排行，分析招标人与评标专家的紧密度

        /// <summary>
        /// PROXY_EXPERT
        /// 评标专家参与排行
        /// 指招标代理机构发出的项目出现频次较多的评标专家排行，分析招标人与评标专家的紧密度
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<LabelValueModel> PROXY_EXPERT(StatisticsBidderSearchModel search)
        {
            var condition = new WhereClipBuilder(V_BIG_JG._.TENDER_AGENCY_NAME == search.KeyWord ||
                                                 V_BIG_JG._.TENDER_AGENCY_CODE == search.KeyWord);
            if (search.BeginTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME <= search.EndDateTime);
            }
            var r = FromWhere<V_BIG_JG>(condition.ToWhereClip())
                .InnerJoin<BID_EVALUATION_EXPERT>(BID_EVALUATION_EXPERT._.TENDER_PROJECT_CODE==V_BIG_JG._.PROJECT_CODE)
                .GroupBy(BID_EVALUATION_EXPERT._.EXPERT_NAME)
                .Select(BID_EVALUATION_EXPERT._.EXPERT_NAME.As("Label"), BID_EVALUATION_EXPERT._.All.Count().As("Value"))
                .Page(search.PageSize, search.PageNo)
                .OrderBy(LabelValueField.Value.Desc && LabelValueField.Label.Desc)
                .ToList<LabelValueModel>();
            r.ForEach(c =>
            {
                var source = c.Label.Desensitization();
                c.Label = source;
            });
            return r;
        }

        #endregion

        #region PROXY_EXPERT_RATE 正常项目专家参与排行 指招标代理机构发出的完成招投标环节的项目（已发出中标结果公示项目，流标及终止项目不计在内），出现频次较高的评标专家占所有评标专家的比值

        /// <summary>
        /// PROXY_EXPERT_RATE
        /// 正常项目专家参与排行
        /// 指招标代理机构发出的完成招投标环节的项目（已发出中标结果公示项目，流标及终止项目不计在内），出现频次较高的评标专家占所有评标专家的比值
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<LabelValueModel<int>> PROXY_EXPERT_RATE(StatisticsBidderSearchModel search)
        {
            var condition = new WhereClipBuilder(V_BIG_JG._.TENDER_AGENCY_NAME == search.KeyWord ||
                                                 V_BIG_JG._.TENDER_AGENCY_CODE == search.KeyWord);
            if (search.BeginTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME <= search.EndDateTime);
            }
            var r = FromWhere<V_BIG_JG>(condition.ToWhereClip())
                .InnerJoin<BID_EVALUATION_EXPERT>(BID_EVALUATION_EXPERT._.TENDER_PROJECT_CODE == V_BIG_JG._.PROJECT_CODE)
                .GroupBy(BID_EVALUATION_EXPERT._.EXPERT_NAME)
                .Select(BID_EVALUATION_EXPERT._.EXPERT_NAME.As("Label"), BID_EVALUATION_EXPERT._.All.Count().As("Value"))
                .OrderBy(LabelValueField.Value.Desc && LabelValueField.Label.Desc)
                .ToList<LabelValueModel<int>>();
            var r1 = r.Take(search.PageSize).ToList();
            r1.ForEach(c =>
            {
                var source = c.Label.Desensitization();
                c.Label = source;
            });
            var r2 = r.Skip(search.PageSize).ToList();
            r1.Add(new LabelValueModel<int>
            {
                Id = "OTHER",
                Label = "其他",
                Value = r2.Sum(c => c.Value)
            });
            return r1;
        }

        #endregion

        #endregion

    }
}