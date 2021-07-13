using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Fields;
using GGZY.Services.Infrastructure.Model.BigData;
using GGZYFW.DbEntity;

namespace GGZY.Services.BigData
{
    /// <summary>
    /// 工程领域监察大数据服务系统-综合统计-投标人情况
    /// </summary>
    public class StatisticsTenderService : BaseServiceT<FwEntity>
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

                var tenderCon = new WhereClipBuilder(TENDER_PROJECT._.REGION_CODE.BeginWith(rootAreaCode) && TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(typeList));
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
                    tenderCon.And(TENDER_LIST._.BIDDER_NAME.Contain(search.LEGAL_NAME));
                }

                if (search.BeginTime.HasValue)
                {
                    tenderCon.And(TENDER_LIST._.CHECKIN_TIME >= search.BeginTime);
                }
                if (search.EndDateTime.HasValue)
                {
                    tenderCon.And(TENDER_LIST._.CHECKIN_TIME <= search.EndDateTime);
                }

                var legalBase = Fw.LegalPersonBaseService.FromWhere(LEGAL_PERSON_BASE._.LEGAL_ROLE.Contain("03"))
                    .GroupBy(LEGAL_PERSON_BASE._.LEGAL_NAME)
                    .Select(LEGAL_PERSON_BASE._.LEGAL_CODE.Max(), LEGAL_PERSON_BASE._.LEGAL_NAME,
                        LEGAL_PERSON_BASE._.REGION_CODE.Max());
                //var dsjArea=FromWhere<DSJ_AREA>().Select(DSJ_AREA._.)
                var query = Fw.TenderListService.FromWhere(tenderCon.ToWhereClip())
                    .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == TENDER_LIST._.TENDER_PROJECT_CODE)
                    .LeftJoin<WIN_RESULT_ANNO>(WIN_RESULT_ANNO._.WIN_BIDDER_NAME == TENDER_LIST._.BIDDER_NAME)
                    .LeftJoinTmp<LEGAL_PERSON_BASE>(legalBase, TENDER_LIST._.BIDDER_NAME == LEGAL_PERSON_BASE._.LEGAL_NAME)
                    .LeftJoin<DSJ_AREA>(DSJ_AREA._.OLDCODE == LEGAL_PERSON_BASE._.REGION_CODE)
                    .GroupBy(TENDER_LIST._.BIDDER_NAME)
                    .Select(TENDER_LIST._.BIDDER_NAME.As("LEGAL_NAME"),
                        TENDER_LIST._.BID_SECTION_CODE.Distinct().Count().As("COUNT"),
                        WIN_RESULT_ANNO._.BID_SECTION_CODE.Distinct().Count().As("WIN_COUNT"),
                        DSJ_AREA._.SHI.Max().As("AREANAME"),
                        LEGAL_PERSON_BASE._.LEGAL_CODE.Max());

                var total = query.Count();
                if (total > 0)
                {
                    var orderClip = new Field("WIN_COUNT").Desc;
                    if (search.Type == "TB")
                    {
                        orderClip = new Field("COUNT").Desc;
                    }
                    var list = query.OrderBy(orderClip)
                        .Page(search.PageSize, search.PageNo)
                        .ToList<StatisticsBidderRankModel>();
                    var pageList = list.ToPageTableResult(search, total);
                    return pageList;
                }
            }

            return search.ToPageTableResult();
        }

        #endregion

        #region 投标人项目金额分布

        /// <summary>
        /// 投标人项目金额分布
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
                var tenderListCon = new WhereClipBuilder(TENDER_PROJECT._.REGION_CODE.BeginWith(rootAreaCode) && TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(typeList));
                if (rootAreaCode == "3501")
                {
                    condition.And(V_BIG_JG._.AREACODE != "350128");
                    tenderListCon.And(TENDER_PROJECT._.REGION_CODE != "350128");
                }
                if (!string.IsNullOrWhiteSpace(search.TENDER_PROJECT_TYPE))
                {
                    if (search.TENDER_PROJECT_TYPE.Contains(","))
                    {
                        var projectTypes =
                            search.TENDER_PROJECT_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        condition.And(V_BIG_JG._.PROJECT_TYPE.In(projectTypes));
                        tenderListCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(projectTypes));
                    }
                    else
                    {
                        condition.And(V_BIG_JG._.PROJECT_TYPE == search.TENDER_PROJECT_TYPE);
                        tenderListCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE == search.TENDER_PROJECT_TYPE);
                    }
                }
                if (search.BeginTime.HasValue)
                {
                    condition.And(V_BIG_JG._.M_TM >= search.BeginTime);
                    tenderListCon.And(TENDER_LIST._.CHECKIN_TIME >= search.BeginTime);
                }

                if (search.EndDateTime.HasValue)
                {
                    condition.And(V_BIG_JG._.M_TM <= search.EndDateTime);
                    tenderListCon.And(TENDER_LIST._.CHECKIN_TIME <= search.EndDateTime);
                }

                if (!string.IsNullOrWhiteSpace(search.AREACODE))
                {
                    condition.And(V_BIG_JG._.AREACODE == search.AREACODE);
                    tenderListCon.And(TENDER_PROJECT._.REGION_CODE == search.AREACODE);

                }

                if (!string.IsNullOrWhiteSpace(search.LEGAL_CODE))
                {
                    condition.And(V_BIG_JG._.TENDER_AGENCY_CODE.Contain(search.LEGAL_CODE));
                    tenderListCon.And(TENDER_LIST._.BIDDER_ORG_CODE.Contain(search.LEGAL_CODE));
                }

                if (!string.IsNullOrWhiteSpace(search.LEGAL_NAME))
                {
                    condition.And(V_BIG_JG._.TENDER_AGENCY_NAME.Contain(search.LEGAL_NAME));
                    tenderListCon.And(TENDER_LIST._.BIDDER_NAME.Contain(search.LEGAL_NAME));
                }

                var query = FromWhere<V_BIG_JG>(condition.ToWhereClip());
                r.ACTIVE_COUNT = Fw.TenderListService.FromWhere(tenderListCon.ToWhereClip())
                    .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == TENDER_LIST._.TENDER_PROJECT_CODE)
                    .Select(TENDER_LIST._.BIDDER_NAME.Distinct().Count()).ToScalar<Int64>();


                var data = query
                    .InnerJoin<SECTION>(SECTION._.BID_SECTION_CODE == V_BIG_JG._.SECTION_CODE)
                    .InnerJoin<TENDER_LIST>(TENDER_LIST._.BID_SECTION_CODE == SECTION._.BID_SECTION_CODE)
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

        #region 投标人分析-总数|新增数|活跃数|总次数


        /// <summary>
        /// 投标人分析-总数|新增数|活跃数|总次数(行业归属地)
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


                #region 条件处理

                var tenderUserCountCon =
                    new WhereClipBuilder(TENDER_PROJECT._.REGION_CODE.BeginWith(rootAreaCode) &&
                                         TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(typeList));
                var tenderUserAddCountCon = new WhereClipBuilder();
                if (rootAreaCode == "3501")
                {
                    tenderUserCountCon.And(TENDER_PROJECT._.REGION_CODE != "350128");
                }
                if (search.BeginTime.HasValue)
                {
                    tenderUserAddCountCon.And(TENDER_LIST._.M_TM >= search.BeginTime);
                }

                if (search.EndDateTime.HasValue)
                {
                    tenderUserAddCountCon.And(TENDER_LIST._.M_TM <= search.EndDateTime);
                }

                if (!string.IsNullOrWhiteSpace(search.AREACODE))
                {
                    tenderUserCountCon.And(TENDER_PROJECT._.REGION_CODE == search.AREACODE);
                }
                if (!string.IsNullOrWhiteSpace(search.TENDER_PROJECT_TYPE))
                {
                    if (search.TENDER_PROJECT_TYPE.Contains(","))
                    {
                        var projectTypes =
                            search.TENDER_PROJECT_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        tenderUserCountCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(projectTypes));
                    }
                    else
                    {
                        tenderUserCountCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE == search.TENDER_PROJECT_TYPE);
                    }
                }
                #endregion
                obj.TOTAL_COUNT = Fw.TenderProjectService.FromWhere(tenderUserCountCon.ToWhereClip())
                    .InnerJoin<TENDER_LIST>(TENDER_LIST._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                    .Select(TENDER_LIST._.BIDDER_ORG_CODE).Distinct().Count();//投标人总数
                var addCountTmp = Fw.TenderProjectService.FromWhere(tenderUserCountCon.ToWhereClip())
                    .InnerJoin<TENDER_LIST>(TENDER_LIST._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                    .GroupBy(TENDER_LIST._.BIDDER_ORG_CODE)
                    .Select(TENDER_LIST._.BIDDER_ORG_CODE, TENDER_LIST._.M_TM.Min());
                obj.ADD_COUNT = Fw.TenderProjectService.FromWhere(tenderUserAddCountCon.ToWhereClip())
                    .RightJoinTmp<TENDER_LIST>(addCountTmp, "1=0")
                    .Select(TENDER_LIST._.BIDDER_ORG_CODE).Distinct().Count();//新增投标人

                obj.ACTIVE_COUNT = Fw.TenderProjectService
                    .FromWhere(tenderUserCountCon.ToWhereClip() && tenderUserAddCountCon.ToWhereClip())
                    .InnerJoin<TENDER_LIST>(TENDER_LIST._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                    .Select(TENDER_LIST._.BIDDER_ORG_CODE).Distinct().Count();//活跃投标人
                obj.PROJECT_COUNT = Fw.TenderProjectService
                    .FromWhere(tenderUserCountCon.ToWhereClip() && tenderUserAddCountCon.ToWhereClip())
                    .InnerJoin<TENDER_LIST>(TENDER_LIST._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                    .Select(TENDER_LIST._.TENDER_PROJECT_CODE).Distinct().Count();//活跃总次数人;
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
            var r = new List<PieSeriesData>();
            var swtbr = 0;
            var sntbr = 0;
            var swzbr = 0;
            var snzbr = 0;
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode;
            var typeList = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {

                var con = new WhereClipBuilder(TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(typeList));
                var tenderListCon = new WhereClipBuilder();

                if (search.BeginTime.HasValue)
                {
                    tenderListCon.And(TENDER_LIST._.CHECKIN_TIME >= search.BeginTime);
                }
                if (search.EndDateTime.HasValue)
                {
                    tenderListCon.And(TENDER_LIST._.CHECKIN_TIME <= search.EndDateTime);
                }
                if (!string.IsNullOrWhiteSpace(search.TENDER_PROJECT_TYPE))
                {
                    if (search.TENDER_PROJECT_TYPE.Contains(","))
                    {
                        var projectTypes =
                            search.TENDER_PROJECT_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        con.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(projectTypes));
                    }
                    else
                    {
                        con.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE == search.TENDER_PROJECT_TYPE);
                    }
                }

                var tbr = Fw.TenderProjectService.FromWhere(con.ToWhereClip() && tenderListCon.ToWhereClip())
                    .InnerJoin<TENDER_LIST>(TENDER_LIST._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                    .Select(TENDER_LIST._.BIDDER_ORG_CODE).Distinct().Count();
                sntbr = Fw.TenderProjectService.FromWhere(con.ToWhereClip() && tenderListCon.ToWhereClip() && TENDER_LIST._.BIDDER_REGION_CODE.Contain("35"))
                    .InnerJoin<TENDER_LIST>(TENDER_LIST._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                    .Select(TENDER_LIST._.BIDDER_ORG_CODE).Distinct().Count();
                swtbr = tbr - sntbr;
                var zbr = Fw.TenderProjectService.FromWhere(con.ToWhereClip() && tenderListCon.ToWhereClip())
                    .InnerJoin<TENDER_LIST>(TENDER_LIST._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                    .InnerJoin<WIN_RESULT_ANNO>(
                        WIN_RESULT_ANNO._.TENDER_PROJECT_CODE == TENDER_LIST._.TENDER_PROJECT_CODE &&
                        WIN_RESULT_ANNO._.WIN_BIDDER_NAME == TENDER_LIST._.BIDDER_NAME)
                    .Select(WIN_RESULT_ANNO._.WIN_BIDDER_CODE).Distinct().Count();
                snzbr = Fw.TenderProjectService.FromWhere(con.ToWhereClip() && tenderListCon.ToWhereClip() && TENDER_LIST._.BIDDER_REGION_CODE.Contain("35"))
                    .InnerJoin<TENDER_LIST>(TENDER_LIST._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                    .InnerJoin<WIN_RESULT_ANNO>(
                        WIN_RESULT_ANNO._.TENDER_PROJECT_CODE == TENDER_LIST._.TENDER_PROJECT_CODE &&
                        WIN_RESULT_ANNO._.WIN_BIDDER_NAME == TENDER_LIST._.BIDDER_NAME)
                    .Select(WIN_RESULT_ANNO._.WIN_BIDDER_CODE).Distinct().Count();
                swzbr = zbr - snzbr;
            }

            r.Add(new PieSeriesData { Name = "SWTBR", Value = swtbr });
            r.Add(new PieSeriesData { Name = "SNTBR", Value = sntbr });
            r.Add(new PieSeriesData { Name = "SWZBR", Value = swzbr });
            r.Add(new PieSeriesData { Name = "SNZBR", Value = snzbr });

            return r;
        }
        #endregion

        #region 等级分布
        /// <summary>
        /// 等级分布
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public PieSeries Grade(StatisticsBidderSearchModel search)
        {
            #region MyRegion
            var totalCon = new WhereClipBuilder();//新增
            if (search.BeginTime.HasValue)
            {
                totalCon.And(TENDERER_EX_INFO._.M_TM >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                totalCon.And(TENDERER_EX_INFO._.M_TM <= search.EndDateTime);
            }

            if (!string.IsNullOrWhiteSpace(search.AREACODE))
            {
                totalCon.And(LEGAL_PERSON_BASE._.REGION_CODE == search.AREACODE);
            }

            #endregion
            var query = Fw.LegalPersonBaseService.FromWhere(totalCon.ToWhereClip())
                .InnerJoin<TENDERER_EX_INFO>(TENDERER_EX_INFO._.LEGAL_CODE == LEGAL_PERSON_BASE._.LEGAL_CODE)
                .InnerJoin<SYS_DIC>(SYS_DIC._.TYPE == "17" && SYS_DIC._.VALUE == TENDERER_EX_INFO._.QUAL_LEVEL);
            //.InnerJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == LEGAL_PERSON_BASE._.REGION_CODE);//todo  这里应该不用关联才对
            var data = query.GroupBy(SYS_DIC._.TEXT).Select(SYS_DIC._.TEXT.As("Name"), SYS_DIC._.TEXT.Count().As("Value"))
               .ToList<PieSeriesData>();
            var names = new List<string> { "特级", "一级", "二级", "三级", "四级" };

            var r = new PieSeries
            {
                Data = names.Select(c =>
                 {
                     var value = data.FirstOrDefault(v => v.Name == c)?.Value ?? 0;
                     var o = new PieSeriesData
                     {
                         Name = $"{c} {value} 家 ",
                         Value = value
                     };
                     return o;

                 }).ToList(),
            };

            return r;
        }

        #endregion

        #region 注册资本
        /// <summary>
        /// 注册资本
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public PieSeries Capital(StatisticsBidderSearchModel search)
        {
            #region MyRegion
            var totalCon = new WhereClipBuilder();//新增
            if (search.BeginTime.HasValue)
            {
                totalCon.And(TENDERER_EX_INFO._.M_TM >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                totalCon.And(TENDERER_EX_INFO._.M_TM <= search.EndDateTime);
            }

            if (!string.IsNullOrWhiteSpace(search.AREACODE))
            {
                totalCon.And(LEGAL_PERSON_BASE._.REGION_CODE == search.AREACODE);
            }

            #endregion

            var query = Fw.LegalPersonBaseService.FromWhere(totalCon.ToWhereClip())
                .InnerJoin<TENDERER_EX_INFO>(TENDERER_EX_INFO._.LEGAL_CODE == LEGAL_PERSON_BASE._.LEGAL_CODE)
                .InnerJoin<SYS_DIC>(SYS_DIC._.TYPE == "17" && SYS_DIC._.VALUE == TENDERER_EX_INFO._.QUAL_LEVEL) //todo  这里应该不用关联才对
                .InnerJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == LEGAL_PERSON_BASE._.REGION_CODE) //todo  这里应该不用关联才对
                .Select(
                    new Field("(CASE TO_CHAR(REG_UNIT) WHEN '1' THEN REG_CAPITAL ELSE REG_CAPITAL/10000 END )").As(
                        "REG_CAPITAL"));

            var field = new Field(@"CASE WHEN REG_CAPITAL<1000 THEN '1' 
WHEN REG_CAPITAL>=1000 AND REG_CAPITAL<2500 THEN '2'
WHEN REG_CAPITAL>=2500 AND REG_CAPITAL<5000 THEN '3'
WHEN REG_CAPITAL>=5000  THEN '4'  END ");

            var data = Fw.TendererExInfoService.FromWhere()
                .RightJoinTmp<LEGAL_PERSON_BASE>(query, "1=0")
                .GroupBy(field)
                .Select(field.As("Name"), Field.All.Count().As("Value"))
                .ToList<PieSeriesData>();

            var r = new PieSeries();
            r.Data.Add(new PieSeriesData { Name = "5000万以上", Value = data.FirstOrDefault(c => c.Name == "4")?.Value ?? 0 });
            r.Data.Add(new PieSeriesData { Name = "2500-5000万", Value = data.FirstOrDefault(c => c.Name == "3")?.Value ?? 0 });
            r.Data.Add(new PieSeriesData { Name = "1000-2500万", Value = data.FirstOrDefault(c => c.Name == "2")?.Value ?? 0 });
            r.Data.Add(new PieSeriesData { Name = "1000万以下", Value = data.FirstOrDefault(c => c.Name == "1")?.Value ?? 0 });
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
        public List<IChartSeries> Nature(StatisticsBidderSearchModel search)
        {
            var r = new List<IChartSeries>
            {
                new PieSeries
                {
                    Name = "省内",
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
                },
                new PieSeries
                {
                    Name = "省外",
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
                },
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
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode;//??"35";
            var typeList = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;//??new List<string>{"A01","A02"};
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
                var tenderListCon = new WhereClipBuilder(TENDER_LIST._.M_TM >= begin && TENDER_LIST._.M_TM <= end && TENDER_PROJECT._.REGION_CODE.BeginWith(rootAreaCode) && TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(typeList));
                var winResultAnnoCon = new WhereClipBuilder(WIN_RESULT_ANNO._.M_TM >= begin && WIN_RESULT_ANNO._.M_TM <= end && TENDER_PROJECT._.REGION_CODE.BeginWith(rootAreaCode) && TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(typeList));
                if (rootAreaCode == "3501")
                {
                    tenderListCon.And(TENDER_PROJECT._.REGION_CODE != "350128");
                    winResultAnnoCon.And(TENDER_PROJECT._.REGION_CODE != "350128");
                }
                if (!string.IsNullOrWhiteSpace(search.AREACODE))
                {
                    tenderListCon.And(TENDER_PROJECT._.REGION_CODE == search.AREACODE);
                    winResultAnnoCon.And(WIN_RESULT_ANNO._.REGION_CODE == search.AREACODE);
                }
                if (!string.IsNullOrWhiteSpace(search.TENDER_PROJECT_TYPE))
                {
                    if (search.TENDER_PROJECT_TYPE.Contains(","))
                    {
                        var projectTypes =
                            search.TENDER_PROJECT_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        tenderListCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(projectTypes));
                        winResultAnnoCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(projectTypes));
                    }
                    else
                    {
                        tenderListCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE == search.TENDER_PROJECT_TYPE);
                        winResultAnnoCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE == search.TENDER_PROJECT_TYPE);
                    }
                }
                var enterpriseData = Fw.TenderListService.FromWhere(tenderListCon.ToWhereClip())
                    .InnerJoin<TENDER_PROJECT>(TENDER_LIST._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                    .GroupBy(TENDER_LIST._.CHECKIN_TIME.ToChar(dbFormat))
                    .Select(TENDER_LIST._.CHECKIN_TIME.ToChar(dbFormat).As("Name"),
                        TENDER_LIST._.BIDDER_ORG_CODE.Distinct().Count().As("Value"))
                    .ToList<PieSeriesData>();

                var bidData = Fw.TenderListService.FromWhere(tenderListCon.ToWhereClip())
                    .InnerJoin<TENDER_PROJECT>(TENDER_LIST._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                    .GroupBy(TENDER_LIST._.CHECKIN_TIME.ToChar(dbFormat))
                    .Select(TENDER_LIST._.CHECKIN_TIME.ToChar(dbFormat).As("Name"),
                        TENDER_LIST._.BIDDER_ORG_CODE.Count().As("Value"))
                    .ToList<PieSeriesData>();

                var bidSectionData = Fw.WinResultAnnoService.FromWhere(winResultAnnoCon.ToWhereClip())
                    .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == WIN_RESULT_ANNO._.TENDER_PROJECT_CODE)
                    .GroupBy(WIN_RESULT_ANNO._.M_TM.ToChar(dbFormat))
                    .Select(WIN_RESULT_ANNO._.M_TM.ToChar(dbFormat).As("Name"), Field.All.Count().As("Value"))
                    .ToList<PieSeriesData>();
                //var enterprise = new LineBarSeries("投标企业数");
                //var bid = new LineBarSeries("投标次数");
                var enterprise = new LineBarSeries("TBRZS");//投标人总数
                var bid = new LineBarSeries("TBRCZS");//投标人次总数
                var bidSection = new LineBarSeries("BDS");//标段数
                while (begin <= end)
                {
                    var tm = begin.ToString(format);
                    enterprise.Data.Add((enterpriseData.FirstOrDefault(c => c.Name == tm)?.Value) ?? 0);
                    bid.Data.Add((bidData.FirstOrDefault(c => c.Name == tm)?.Value) ?? 0);
                    bidSection.Data.Add((bidSectionData.FirstOrDefault(c => c.Name == tm)?.Value) ?? 0);
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


        #region 详情

        #region 投标人信息

        /// <summary>
        /// 投标人信息
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>

        public object TENDER_INFO(StatisticsBidderSearchModel search)
        {
            //search.PageSize = 2;
            var tenderInfo = FromWhere<V_BIG_LEGAL_BASE>(V_BIG_LEGAL_BASE._.LEGAL_NAME == search.KeyWord ||
                                                         V_BIG_LEGAL_BASE._.LEGAL_CODE == search.KeyWord)
                .LeftJoin<TENDERER_EX_INFO>(TENDERER_EX_INFO._.LEGAL_CODE == V_BIG_LEGAL_BASE._.LEGAL_CODE)
                .Select(V_BIG_LEGAL_BASE._.LEGAL_NAME, V_BIG_LEGAL_BASE._.LEGAL_CODE, TENDERER_EX_INFO._.QUAL_NAME.As("LEGAL_ROLE")).ToFirst<V_BIG_LEGAL_BASE>();
            List<LabelValueModel<int>> modes = Fw.TenderProjectService
                .FromWhere(TENDER_LIST._.BIDDER_NAME == search.KeyWord || TENDER_LIST._.BIDDER_ORG_CODE == search.KeyWord)
                .InnerJoin<TENDER_LIST>(TENDER_LIST._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                .InnerJoin<SYS_DIC>(SYS_DIC._.TYPE == "1000" && SYS_DIC._.VALUE == TENDER_PROJECT._.TENDER_MODE)
                .GroupBy(SYS_DIC._.TEXT)
                .Select(SYS_DIC._.TEXT.As("Label"), TENDER_PROJECT._.All.Count().As("Value"))
                .OrderBy(LabelValueField.Value.Desc)
                .Page(2, search.PageNo)
                .ToList<LabelValueModel<int>>();
            List<LabelValueModel<int>> types = Fw.TenderProjectService
                .FromWhere(TENDER_LIST._.BIDDER_NAME == search.KeyWord || TENDER_LIST._.BIDDER_ORG_CODE == search.KeyWord)
                .InnerJoin<TENDER_LIST>(TENDER_LIST._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                .InnerJoin<SYS_DIC>(SYS_DIC._.PID == "2525" && SYS_DIC._.VALUE == TENDER_PROJECT._.TENDER_PROJECT_TYPE)
                .GroupBy(SYS_DIC._.TEXT)
                .Select(SYS_DIC._.TEXT.As("Label"), TENDER_PROJECT._.All.Count().As("Value"))
                .OrderBy(LabelValueField.Value.Desc)
                .Page(search.PageSize, search.PageNo)
                .ToList<LabelValueModel<int>>();
            decimal maxAmount =
                FromWhere<V_BIG_JG>(V_BIG_JG._.WIN_BIDDER_NAME == search.KeyWord && V_BIG_JG._.AMOUNT < 300000)
                    .Select(V_BIG_JG._.AMOUNT.Max().ROUND(4)).ToScalar<decimal>();

            List<LabelValueModel> areas = this.TENDER_INFO_AREA(search).OrderByDescending(c=>c.Value).Take(search.PageSize).ToList();
            var tenderWinCount = TENDER_WIN_COUNT(search);
            return new
            {
                NAME = tenderInfo?.LEGAL_NAME,
                CODE = tenderInfo?.LEGAL_CODE,
                TENDER_MODE = string.Join(",", modes.Select(m => m.Label)),
                TENDER_PROJECT_TYPE = string.Join(",", types.Select(m => m.Label)),
                MAX_AMOUNT = maxAmount,//万元
                AREANAME = string.Join(",", areas.Select(m => m.Label)),
                QUAL_NAME = tenderInfo?.LEGAL_ROLE,//企业资质
                TENDER_WIN_COUNT = tenderWinCount,//当前时间段内中标 10 次
            };

        }

        #endregion

        #region 主要项目区域

        /// <summary>
        /// 主要项目区
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>

        public List<LabelValueModel> TENDER_INFO_AREA(StatisticsBidderSearchModel search)
        {
            var condition = new WhereClipBuilder(TENDER_LIST._.BIDDER_NAME == search.KeyWord ||
                                                 TENDER_LIST._.BIDDER_ORG_CODE == search.KeyWord);
            if (search.BeginTime.HasValue)
            {
                condition.And(TENDER_LIST._.CHECKIN_TIME >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                condition.And(TENDER_LIST._.CHECKIN_TIME <= search.EndDateTime);
            }
            var r = FromWhere<TENDER_LIST>(condition.ToWhereClip())
                .InnerJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == TENDER_LIST._.TENDER_PROJECT_CODE)
                .GroupBy(TENDER_PROJECT._.REGION_CODE.Substring(0, 4))
                .Select(TENDER_PROJECT._.REGION_CODE.Substring(0, 4).As("Id"), TENDER_LIST._.All.Count().As("Value"))
                .OrderBy(LabelValueField.Value.Desc)
                .Page(search.PageSize, search.PageNo)
                .ToList<LabelValueModel>();
            //var areaCodes = r.Select(c => c.Id.PadRight(6, '0')).ToList();
            //var areas = Fw.SysAreaQuanguoService.FromWhere(SYS_AREA_QUANGUO._.AREACODE.In(areaCodes)).ToList();
            //r.ForEach(c =>
            //{
            //    c.Id = c.Id.PadRight(6, '0');
            //    c.Label = areas.FirstOrDefault(o => o.AREACODE == c.Id)?.AREANAME;
            //});
            //return r;
            var areas = Fw.SysAreaQuanguoService.FromWhere(SYS_AREA_QUANGUO._.PCODE == "350000" && SYS_AREA_QUANGUO._.AREACODE != "350000").OrderBy(SYS_AREA_QUANGUO._.AREACODE).ToList();
            var result = areas.Select(c => new LabelValueModel
            {
                Id = c.AREACODE,
                Label = c.AREANAME,
                Value = r.FirstOrDefault(o => o.Id.PadRight(6, '0') == c.AREACODE)?.Value ?? "0"
            }).ToList();
            return result;
        }

        #endregion

        #region 当前时间段内中标  次

        /// <summary>
        /// 当前时间段内中标  次
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>

        public int TENDER_WIN_COUNT(StatisticsBidderSearchModel search)
        {
            var condition = new WhereClipBuilder(WIN_RESULT_ANNO._.WIN_BIDDER_NAME == search.KeyWord ||
                                                 WIN_RESULT_ANNO._.WIN_BIDDER_CODE == search.KeyWord);
            if (search.BeginTime.HasValue)
            {
                condition.And(WIN_RESULT_ANNO._.NOTICE_SEND_TIME >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                condition.And(WIN_RESULT_ANNO._.NOTICE_SEND_TIME <= search.EndDateTime);
            }

            var winResultAnnCount = Fw.WinResultAnnoService.FromWhere(condition.ToWhereClip())
                .Select(WIN_RESULT_ANNO._.TENDER_PROJECT_CODE.OracleConcat(WIN_RESULT_ANNO._.BID_SECTION_CODE).Distinct().Count().As("C")).ToScalar<int>();

            return winResultAnnCount;
        }

        #endregion

        #region 投标及中标情况
        /// <summary>
        /// TENDER_CHART_WIN,TENDER_CHART_TOUBIAO 投标及中标情况
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public object TENDER_CHART_WIN_AND_TOUBIAO(StatisticsBidderSearchModel search)
        {
            var condition = new WhereClipBuilder(TENDER_LIST._.BIDDER_NAME == search.KeyWord ||
                                                 TENDER_LIST._.BIDDER_ORG_CODE == search.KeyWord);
            var winCond = new WhereClipBuilder(WIN_RESULT_ANNO._.WIN_BIDDER_CODE == search.KeyWord ||
                                               WIN_RESULT_ANNO._.WIN_BIDDER_NAME == search.KeyWord);
            if (search.BeginTime.HasValue)
            {
                condition.And(TENDER_LIST._.CHECKIN_TIME >= search.BeginTime);
                winCond.And(WIN_RESULT_ANNO._.NOTICE_SEND_TIME >= search.BeginTime);
            }
            if (search.EndDateTime.HasValue)
            {
                condition.And(TENDER_LIST._.CHECKIN_TIME <= search.EndDateTime);
                winCond.And(WIN_RESULT_ANNO._.NOTICE_SEND_TIME <= search.EndDateTime);
            }
            var tender = Fw.TenderListService.FromWhere(condition.ToWhereClip()).GroupBy(TENDER_LIST._.CHECKIN_TIME.Year)
                .Select(TENDER_LIST._.CHECKIN_TIME.Year.As("Label"), TENDER_LIST._.All.Count().As("Value"))
                .OrderBy(LabelValueField.Value.Desc && LabelValueField.Label.Desc)
                .ToList<LabelValueModel>();
            var win = Fw.TenderListService.FromWhere(condition.ToWhereClip() && TENDER_LIST._.TENDER_PROJECT_CODE.SubQueryIn(Fw.WinResultAnnoService.FromWhere(WIN_RESULT_ANNO._.WIN_BIDDER_NAME == search.KeyWord).Select(WIN_RESULT_ANNO._.TENDER_PROJECT_CODE)))
                .GroupBy(TENDER_LIST._.CHECKIN_TIME.Year)
                .Select(TENDER_LIST._.CHECKIN_TIME.Year.As("Label"), TENDER_LIST._.All.Count().As("Value"))
                .OrderBy(LabelValueField.Value.Desc && LabelValueField.Label.Desc)
                .ToList<LabelValueModel>();
            var tm = tender.Select(c => c.Label).ToList();
            var tm1 = win.Select(c => c.Label).ToList();
            var year = tm.Union(tm1).ToList();
            return new
            {
                Tm = year,
                Tender = year.Select(c => tender.FirstOrDefault(y => y.Label == c)?.Value ?? ""),
                Win = year.Select(c => win.FirstOrDefault(y => y.Label == c)?.Value ?? "")
            };
        }

        #endregion

        #region 投标项目地区分布图
        /// <summary>
        /// 
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public object TENDER_AREA(StatisticsBidderSearchModel search)
        {
            var condition = new WhereClipBuilder(TENDER_LIST._.BIDDER_NAME == search.KeyWord ||
                                                 TENDER_LIST._.BIDDER_ORG_CODE == search.KeyWord);

            if (search.BeginTime.HasValue)
            {
                condition.And(TENDER_LIST._.CHECKIN_TIME >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                condition.And(TENDER_LIST._.CHECKIN_TIME <= search.EndDateTime);
            }

            var tender = Fw.TenderListService.FromWhere(condition.ToWhereClip())
                .InnerJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == TENDER_LIST._.TENDER_PROJECT_CODE)
                .GroupBy(TENDER_PROJECT._.REGION_CODE.Substring(0, 4))
                .Select(TENDER_PROJECT._.REGION_CODE.Substring(0, 4).As("Label"), TENDER_LIST._.All.Count().As("Value"))
                .OrderBy(LabelValueField.Value.Desc && LabelValueField.Label.Desc)
                .ToList<LabelValueModel>();

            var win = Fw.TenderListService.FromWhere(condition.ToWhereClip() && TENDER_LIST._.TENDER_PROJECT_CODE.SubQueryIn(Fw.WinResultAnnoService.FromWhere(WIN_RESULT_ANNO._.WIN_BIDDER_NAME == search.KeyWord).Select(WIN_RESULT_ANNO._.TENDER_PROJECT_CODE)))
                .InnerJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == TENDER_LIST._.TENDER_PROJECT_CODE)
                .GroupBy(TENDER_PROJECT._.REGION_CODE.Substring(0, 4))
                .Select(TENDER_PROJECT._.REGION_CODE.Substring(0, 4).As("Label"), TENDER_LIST._.All.Count().As("Value"))
                .OrderBy(LabelValueField.Value.Desc && LabelValueField.Label.Desc)
                .ToList<LabelValueModel>();
            var areas = Fw.SysAreaQuanguoService.FromWhere(SYS_AREA_QUANGUO._.PCODE == "350000" && SYS_AREA_QUANGUO._.AREACODE != "350000").OrderBy(SYS_AREA_QUANGUO._.ORDER_BY.Asc&&SYS_AREA_QUANGUO._.AREACODE.Asc).ToList();
            var result = areas.Select(c => new
            {
                c.AREACODE,
                c.AREANAME,
                TENDER =tender.FirstOrDefault(t=>t.Label.PadRight(6,'0')==c.AREACODE)?.Value??"0",
                WIN= win.FirstOrDefault(t => t.Label.PadRight(6, '0') == c.AREACODE)?.Value ?? "0",
            }).ToList();
            return result;
        }

        #endregion

        #region 投标参与度分析（代理）
        /// <summary>
        /// 投标参与度分析（代理）
        /// 指投标人投标的项目与招标代理机构发出的项目关系性排行，分析投标人与招标代理的紧密度
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<LabelValueModel> TENDER_PROXY(StatisticsBidderSearchModel search)
        {
            var condition = new WhereClipBuilder(TENDER_LIST._.BIDDER_NAME == search.KeyWord ||
                                                 TENDER_LIST._.BIDDER_ORG_CODE == search.KeyWord);
            if (search.BeginTime.HasValue)
            {
                condition.And(TENDER_LIST._.CHECKIN_TIME >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                condition.And(TENDER_LIST._.CHECKIN_TIME <= search.EndDateTime);
            }
            var r = Fw.TenderListService.FromWhere(condition.ToWhereClip())
                .InnerJoin<TENDER_PROJECT>(TENDER_LIST._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                .GroupBy(TENDER_PROJECT._.TENDER_AGENCY_NAME)
                .Select(TENDER_PROJECT._.TENDER_AGENCY_NAME.As("Label"), TENDER_LIST._.All.Count().As("Value"))
                .Page(search.PageSize, search.PageNo)
                .OrderBy(LabelValueField.Value.Desc && LabelValueField.Label.Desc)
                .ToList<LabelValueModel>();
            return r;
        }
        #endregion

        #region 投标参与排行
        /// <summary>
        /// 投标参与排行
        /// 根据投标人经常参与的招标人频率的的业主排行，分析投标企业招标人之间的紧密性
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<LabelValueModel> TENDER_TENDERER(StatisticsBidderSearchModel search)
        {
            var condition = new WhereClipBuilder(TENDER_LIST._.BIDDER_NAME == search.KeyWord ||
                                                 TENDER_LIST._.BIDDER_ORG_CODE == search.KeyWord);
            if (search.BeginTime.HasValue)
            {
                condition.And(TENDER_LIST._.CHECKIN_TIME >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                condition.And(TENDER_LIST._.CHECKIN_TIME <= search.EndDateTime);
            }
            var r = Fw.TenderListService.FromWhere(condition.ToWhereClip())
                .InnerJoin<TENDER_PROJECT>(TENDER_LIST._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                .GroupBy(TENDER_PROJECT._.TENDERER_NAME)
                .Select(TENDER_PROJECT._.TENDERER_NAME.As("Label"), TENDER_LIST._.All.Count().As("Value"))
                .Page(search.PageSize, search.PageNo)
                .OrderBy(LabelValueField.Value.Desc && LabelValueField.Label.Desc)
                .ToList<LabelValueModel>();
            return r;
        }
        #endregion

        #region 投标参与度排行（专家）
        /// <summary>
        /// 投标参与度排行（专家）
        /// 指投标人投标的项目与评标专家评的项目一致的评标专家排行，分析投标人与评标专家的紧密度
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<LabelValueModel> TENDER_EXPERT(StatisticsBidderSearchModel search)
        {
            var condition = new WhereClipBuilder(TENDER_LIST._.BIDDER_NAME == search.KeyWord ||
                                                 TENDER_LIST._.BIDDER_ORG_CODE == search.KeyWord);
            if (search.BeginTime.HasValue)
            {
                condition.And(TENDER_LIST._.CHECKIN_TIME >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                condition.And(TENDER_LIST._.CHECKIN_TIME <= search.EndDateTime);
            }
            var r = Fw.TenderListService.FromWhere(condition.ToWhereClip())
                .InnerJoin<BID_EVALUATION_EXPERT>(TENDER_LIST._.TENDER_PROJECT_CODE == BID_EVALUATION_EXPERT._.TENDER_PROJECT_CODE)
                .GroupBy(BID_EVALUATION_EXPERT._.EXPERT_NAME)
                .Select(BID_EVALUATION_EXPERT._.EXPERT_NAME.As("Label"), TENDER_LIST._.All.Count().As("Value"))
                .Page(search.PageSize, search.PageNo)
                .OrderBy(LabelValueField.Value.Desc && LabelValueField.Label.Desc)
                .ToList<LabelValueModel>();
            return r;
        }
        #endregion

        #region 中标参与分析（代理）
        /// <summary>
        /// 中标参与分析（代理）
        /// 指投标人中标的项目与招标代理机构发出的项目关系性排行，分析中标人与招标人之间的紧密度
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<LabelValueModel> TENDER_PROXY_WIN(StatisticsBidderSearchModel search)
        {
            var condition = new WhereClipBuilder(TENDER_LIST._.BIDDER_NAME == search.KeyWord ||
                                                 TENDER_LIST._.BIDDER_ORG_CODE == search.KeyWord);
            if (search.BeginTime.HasValue)
            {
                condition.And(TENDER_LIST._.CHECKIN_TIME >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                condition.And(TENDER_LIST._.CHECKIN_TIME <= search.EndDateTime);
            }
            var r = Fw.TenderListService.FromWhere(condition.ToWhereClip())
                .InnerJoin<TENDER_PROJECT>(TENDER_LIST._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE && TENDER_PROJECT._.TENDER_PROJECT_CODE.SubQueryIn(Fw.WinResultAnnoService.FromWhere(WIN_RESULT_ANNO._.WIN_BIDDER_NAME == search.KeyWord).Select(WIN_RESULT_ANNO._.TENDER_PROJECT_CODE)))
                .GroupBy(TENDER_PROJECT._.TENDER_AGENCY_NAME)
                .Select(TENDER_PROJECT._.TENDER_AGENCY_NAME.As("Label"), TENDER_LIST._.All.Count().As("Value"))
                .Page(search.PageSize, search.PageNo)
                .OrderBy(LabelValueField.Value.Desc && LabelValueField.Label.Desc)
                .ToList<LabelValueModel>();
            return r;
        }
        #endregion

        #region 中标参与分析（招标人）
        /// <summary>
        /// 中标参与分析（招标人）
        /// 对投标人中标的项目主要是业主单位进行排行，分析中标人与投标人的紧密度
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<LabelValueModel> TENDER_TENDERER_WIN(StatisticsBidderSearchModel search)
        {
            var condition = new WhereClipBuilder(TENDER_LIST._.BIDDER_NAME == search.KeyWord ||
                                                 TENDER_LIST._.BIDDER_ORG_CODE == search.KeyWord);
            if (search.BeginTime.HasValue)
            {
                condition.And(TENDER_LIST._.CHECKIN_TIME >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                condition.And(TENDER_LIST._.CHECKIN_TIME <= search.EndDateTime);
            }
            var r = Fw.TenderListService.FromWhere(condition.ToWhereClip())
                .InnerJoin<TENDER_PROJECT>(TENDER_LIST._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE && TENDER_PROJECT._.TENDER_PROJECT_CODE.SubQueryIn(Fw.WinResultAnnoService.FromWhere(WIN_RESULT_ANNO._.WIN_BIDDER_NAME == search.KeyWord).Select(WIN_RESULT_ANNO._.TENDER_PROJECT_CODE)))
                .GroupBy(TENDER_PROJECT._.TENDERER_NAME)
                .Select(TENDER_PROJECT._.TENDERER_NAME.As("Label"), TENDER_LIST._.All.Count().As("Value"))
                .Page(search.PageSize, search.PageNo)
                .OrderBy(LabelValueField.Value.Desc && LabelValueField.Label.Desc)
                .ToList<LabelValueModel>();
            return r;
        }
        #endregion

        #region 中标参与度分析
        /// <summary>
        /// 中标参与度分析
        /// 指投标人中标的项目中出现评标专家较多的评标专家占比，分析中标人与评标专家的紧密度
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<LabelValueModel> TENDER_EXPERT_WIN(StatisticsBidderSearchModel search)
        {
            var condition = new WhereClipBuilder(TENDER_LIST._.BIDDER_NAME == search.KeyWord ||
                                                 TENDER_LIST._.BIDDER_ORG_CODE == search.KeyWord);
            if (search.BeginTime.HasValue)
            {
                condition.And(TENDER_LIST._.CHECKIN_TIME >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                condition.And(TENDER_LIST._.CHECKIN_TIME <= search.EndDateTime);
            }
            var r = Fw.TenderListService.FromWhere(condition.ToWhereClip())
                .InnerJoin<BID_EVALUATION_EXPERT>(TENDER_LIST._.TENDER_PROJECT_CODE == BID_EVALUATION_EXPERT._.TENDER_PROJECT_CODE && BID_EVALUATION_EXPERT._.TENDER_PROJECT_CODE.SubQueryIn(Fw.WinResultAnnoService.FromWhere(WIN_RESULT_ANNO._.WIN_BIDDER_NAME == search.KeyWord).Select(WIN_RESULT_ANNO._.TENDER_PROJECT_CODE)))
                .GroupBy(BID_EVALUATION_EXPERT._.EXPERT_NAME)
                .Select(BID_EVALUATION_EXPERT._.EXPERT_NAME.As("Label"), TENDER_LIST._.All.Count().As("Value"))
                .Page(search.PageSize, search.PageNo)
                .OrderBy(LabelValueField.Value.Desc && LabelValueField.Label.Desc)
                .ToList<LabelValueModel>();
            return r;
        }
        #endregion

        #region 中标参与度分析（投标人）
        /// <summary>
        /// 中标参与度分析（投标人）
        /// 指投标人中标时一起参与投标的企业排行情况，分析中标人与关联投标人的紧密度 
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<LabelValueModel> TENDER_OTHER_WIN(StatisticsBidderSearchModel search)
        {
            var condition = new WhereClipBuilder(TENDER_LIST._.BIDDER_NAME != search.KeyWord &&
                                                 TENDER_LIST._.BIDDER_ORG_CODE != search.KeyWord);
            if (search.BeginTime.HasValue)
            {
                condition.And(TENDER_LIST._.CHECKIN_TIME >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                condition.And(TENDER_LIST._.CHECKIN_TIME <= search.EndDateTime);
            }
            var r = Fw.TenderListService.FromWhere(condition.ToWhereClip())
                .InnerJoin<WIN_RESULT_ANNO>(TENDER_LIST._.TENDER_PROJECT_CODE == WIN_RESULT_ANNO._.TENDER_PROJECT_CODE && WIN_RESULT_ANNO._.WIN_BIDDER_NAME == search.KeyWord)
                .GroupBy(TENDER_LIST._.BIDDER_NAME)
                .Select(TENDER_LIST._.BIDDER_NAME.As("Label"), TENDER_LIST._.All.Count().As("Value"))
                .Page(search.PageSize, search.PageNo)
                .OrderBy(LabelValueField.Value.Desc && LabelValueField.Label.Desc)
                .ToList<LabelValueModel>();
            return r;
        }
        #endregion

        #region 共同参与投标分析
        /// <summary>
        /// TENDER_INFO,TENDER_OTHER
        /// 共同参与投标分析
        /// 指投标人与投标人之间共同参与投标项目企业排行情况，分析投标企业间的紧密度
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<LabelValueModel> TENDER_INFO_TENDER_OTHER(StatisticsBidderSearchModel search)
        {
            var condition = new WhereClipBuilder();
            if (search.BeginTime.HasValue)
            {
                condition.And(TENDER_LIST._.CHECKIN_TIME >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                condition.And(TENDER_LIST._.CHECKIN_TIME <= search.EndDateTime);
            }

            var tenderProjects = Fw.TenderListService.FromWhere((TENDER_LIST._.BIDDER_NAME == search.KeyWord ||
                                                                 TENDER_LIST._.BIDDER_ORG_CODE == search.KeyWord) && condition.ToWhereClip())
                .Select(TENDER_LIST._.TENDER_PROJECT_CODE).ToList<string>();
            var r = Fw.TenderListService.FromWhere(TENDER_LIST._.BIDDER_NAME != search.KeyWord &&
                                                    TENDER_LIST._.BIDDER_ORG_CODE != search.KeyWord &&
                                                    condition.ToWhereClip()
                                                    && TENDER_LIST._.TENDER_PROJECT_CODE.In(tenderProjects))
                .GroupBy(TENDER_LIST._.BIDDER_NAME)
                .Select(TENDER_LIST._.BIDDER_NAME.As("Label"), TENDER_LIST._.All.Count().As("Value"))
                .Page(search.PageSize, search.PageNo)
                .OrderBy(LabelValueField.Value.Desc && LabelValueField.Label.Desc)
                .ToList<LabelValueModel>();
            return r;
        }
        #endregion


        #endregion
    }
}