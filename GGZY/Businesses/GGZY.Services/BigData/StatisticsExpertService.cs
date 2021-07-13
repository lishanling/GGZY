using System;
using System.Collections.Generic;
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
    /// 工程领域监察大数据服务系统-综合统计-评标专家
    /// </summary>
    public class StatisticsExpertService : BaseServiceT<FwEntity>
    {
        #region 专家参与项目总量排行

        /// <summary>
        /// 专家参与项目总量排行
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult ProjectCountRank(StatisticsBidderSearchModel search)
        {
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode ?? "35";
            var typeList = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES ?? new List<string> { "A01", "A02" };
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {


                var con1 = new WhereClipBuilder(TENDER_PROJECT._.REGION_CODE.BeginWith(rootAreaCode) && TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(typeList));
                if (rootAreaCode == "3501")
                {
                    con1.And(TENDER_PROJECT._.REGION_CODE != "350128");
                }
                if (!string.IsNullOrWhiteSpace(search.TENDER_PROJECT_TYPE))
                {
                    if (search.TENDER_PROJECT_TYPE.Contains(","))
                    {
                        var projectTypes =
                            search.TENDER_PROJECT_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        con1.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(projectTypes));
                    }
                    else
                    {
                        con1.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE == search.TENDER_PROJECT_TYPE);
                    }
                }
                if (search.BeginTime.HasValue)
                {
                    con1.And(BID_EVALUATION_EXPERT._.EXPERT_CHECK_IN_TIME >= search.BeginTime);
                }
                if (search.EndDateTime.HasValue)
                {
                    con1.And(BID_EVALUATION_EXPERT._.EXPERT_CHECK_IN_TIME <= search.EndDateTime);
                }

                var con = new WhereClipBuilder();
                if (!string.IsNullOrWhiteSpace(search.AREACODE))
                {
                    con.And(DSJ_AREA._.PCODE == search.AREACODE);
                }

                if (!string.IsNullOrWhiteSpace(search.LEGAL_NAME))
                {
                    con.And(EXPERT_BID_EVALUATION._.EXPERT_NAME.Contain(search.LEGAL_NAME));
                }
                if (!string.IsNullOrWhiteSpace(search.LEGAL_CODE))
                {
                    con.And(EXPERT_BID_EVALUATION._.ID_CARD.Contain(search.LEGAL_CODE));
                }


                var tmp = Fw.BidEvaluationExpertService.FromWhere(con1.ToWhereClip())
                    .InnerJoin<EVALUATION_REPORT>(
                        EVALUATION_REPORT._.TENDER_PROJECT_CODE == BID_EVALUATION_EXPERT._.TENDER_PROJECT_CODE &&
                        EVALUATION_REPORT._.BID_SECTION_CODE == BID_EVALUATION_EXPERT._.BID_SECTION_CODE)
                    .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == BID_EVALUATION_EXPERT._.TENDER_PROJECT_CODE)
                    .GroupBy(EVALUATION_REPORT._.EVALUATION_RESULT, BID_EVALUATION_EXPERT._.ID_CARD)
                    .Select(EVALUATION_REPORT._.EVALUATION_RESULT, BID_EVALUATION_EXPERT._.ID_CARD, EVALUATION_REPORT._.EVALUATION_RESULT.Count().As("EVALUATION_RESULT_COUNT"));
                var query = Fw.ExpertBidEvaluationService.FromWhere(con.ToWhereClip())
                    .InnerJoin<DSJ_AREA>(DSJ_AREA._.OLDCODE == EXPERT_BID_EVALUATION._.AREA)
                    .InnerJoinTmp<V_EVALUATION_REPORT>(tmp, V_EVALUATION_REPORT.ID_CARD == EXPERT_BID_EVALUATION._.ID_CARD)
                    .GroupBy(EXPERT_BID_EVALUATION._.EXPERT_NAME, EXPERT_BID_EVALUATION._.ID_CARD)
                    .Select(
                        EXPERT_BID_EVALUATION._.EXPERT_NAME,
                        V_EVALUATION_REPORT.EVALUATION_RESULT_COUNT.Sum().As("COUNT"),
                        EXPERT_BID_EVALUATION._.ID_CARD,
                        DSJ_AREA._.SHI.Max().As("AREANAME"),
                        V_EVALUATION_REPORT.LOST_COUNT.As("LOST_COUNT"),
                        V_EVALUATION_REPORT.AGAIN_COUNT.As("AGAIN_COUNT"),
                        V_EVALUATION_REPORT.WIN_COUNT.As("WIN_COUNT"),
                        V_EVALUATION_REPORT.RATE.As("RATE")
                    );
                var total = query.Count();
                //if (total > 0)
                {
                    var list = query.OrderBy(new Field("COUNT").Nvl(0).Desc)
                        .Page(search.PageSize, search.PageNo)
                        .ToList<ExpertInfoModel>();
                    var pageList = list.ToPageTableResult(search, total);
                    return pageList;
                }
            }

            return search.ToPageTableResult();
        }


        #endregion

        #region 评标专家项目金额分布

        /// <summary>
        /// 评标专家项目金额分布
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public object ProjectAmountDistribution_ActiveCount(StatisticsBidderSearchModel search)
        {
            Int64 ACTIVE_COUNT = 0;
            var CHART_DATA = new List<Int64?>();
            var CHART_INDICATOR = new[] { "5次以内", "5-10次内", "10-15次内", "15-20次内", "20-30次内", "30次以上" };
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode;
            var typeList = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;

            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {
                var bidEvaluationExpertCon = new WhereClipBuilder(TENDER_PROJECT._.REGION_CODE.BeginWith(rootAreaCode) && TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(typeList));
                if (rootAreaCode == "3501")
                {
                    bidEvaluationExpertCon.And(TENDER_PROJECT._.REGION_CODE != "350128");
                }
                if (!string.IsNullOrWhiteSpace(search.TENDER_PROJECT_TYPE))
                {
                    if (search.TENDER_PROJECT_TYPE.Contains(","))
                    {
                        var projectTypes =
                            search.TENDER_PROJECT_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        bidEvaluationExpertCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(projectTypes));
                    }
                    else
                    {
                        bidEvaluationExpertCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE == search.TENDER_PROJECT_TYPE);
                    }
                }
                if (search.BeginTime.HasValue)
                {
                    bidEvaluationExpertCon.And(BID_EVALUATION_EXPERT._.EXPERT_CHECK_IN_TIME >= search.BeginTime);
                }

                if (search.EndDateTime.HasValue)
                {
                    bidEvaluationExpertCon.And(BID_EVALUATION_EXPERT._.EXPERT_CHECK_IN_TIME <= search.EndDateTime);
                }

                if (!string.IsNullOrWhiteSpace(search.AREACODE))
                {
                    bidEvaluationExpertCon.And(TENDER_PROJECT._.REGION_CODE == search.AREACODE);
                }

                if (!string.IsNullOrWhiteSpace(search.LEGAL_CODE))
                {
                    bidEvaluationExpertCon.And(BID_EVALUATION_EXPERT._.ID_CARD.Contain(search.LEGAL_CODE));
                }

                if (!string.IsNullOrWhiteSpace(search.LEGAL_NAME))
                {
                    bidEvaluationExpertCon.And(BID_EVALUATION_EXPERT._.EXPERT_NAME.Contain(search.LEGAL_NAME));
                }


                //var count = Fw.BidEvaluationExpertService.FromWhere(bidEvaluationExpertCon.ToWhereClip())
                //    .Select(BID_EVALUATION_EXPERT._.ID_CARD.Distinct().Count()).ToScalar<Int64>();

                var tmp = Fw.BidEvaluationExpertService.FromWhere(bidEvaluationExpertCon.ToWhereClip())
                    .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == BID_EVALUATION_EXPERT._.TENDER_PROJECT_CODE)
                    .LeftJoin<LEGAL_PERSON_BASE>(LEGAL_PERSON_BASE._.LEGAL_CODE == BID_EVALUATION_EXPERT._.ID_CARD)
                    .GroupBy(BID_EVALUATION_EXPERT._.ID_CARD)
                    .Select(
                        BID_EVALUATION_EXPERT._.ID_CARD, BID_EVALUATION_EXPERT._.ID_CARD.Count().As("COUNT")
                    );
                var selectField = new Field(@" CASE WHEN COUNT<5 THEN '1' 
          WHEN COUNT>=5 AND COUNT<10 THEN '2'
          WHEN COUNT>=10 AND COUNT<15 THEN '3'
          WHEN COUNT>=15 AND COUNT<20 THEN '4'                             
          WHEN COUNT>=20 AND COUNT<30 THEN '5'
          WHEN COUNT>=30  THEN '6'
      END");
                var data = Fw.BidEvaluationExpertService.FromWhere()
                    .RightJoinTmp("TMP", tmp, "1=0")
                    .GroupBy(selectField)
                    .Select(selectField.As("Name"), Field.All.Count().As("Value"))
                    .ToList<StatisticsBidderDataSourceModel>();
                ACTIVE_COUNT = data.Sum(c => c.Value);
                CHART_DATA = new List<Int64?>
            {
                data.FirstOrDefault(c=>c.Name=="1")?.Value,
                data.FirstOrDefault(c=>c.Name=="2")?.Value,
                data.FirstOrDefault(c=>c.Name=="3")?.Value,
                data.FirstOrDefault(c=>c.Name=="4")?.Value,
                data.FirstOrDefault(c=>c.Name=="5")?.Value,
                data.FirstOrDefault(c=>c.Name=="6")?.Value,
            };
            }

            return new
            {
                ACTIVE_COUNT,
                CHART_DATA,
                CHART_INDICATOR,
            };


        }


        #endregion

        #region 评标专家分析-总数|新增数|活跃数|总次数

        /// <summary>
        /// 评标专家分析-总数|新增数|活跃数|总次数
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public StatisticsSummaryModel UserCount(StatisticsBidderSearchModel search)
        {
            var obj = new StatisticsSummaryModel();
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode ?? "35";
            var typeList = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES ?? new List<string> { "A01", "A02", "A99-1", "A07", "A03-1", "A03-2", "A06", "A99-2" };
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {
                var bidEvaluationExpertCon = new WhereClipBuilder(TENDER_PROJECT._.REGION_CODE.BeginWith(rootAreaCode) && TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(typeList));
                if (rootAreaCode == "3501")
                {
                    bidEvaluationExpertCon.And(TENDER_PROJECT._.REGION_CODE != "350128");
                }
                if (!string.IsNullOrWhiteSpace(search.TENDER_PROJECT_TYPE))
                {
                    if (search.TENDER_PROJECT_TYPE.Contains(","))
                    {
                        var projectTypes =
                            search.TENDER_PROJECT_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        bidEvaluationExpertCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(projectTypes));
                    }
                    else
                    {
                        bidEvaluationExpertCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE == search.TENDER_PROJECT_TYPE);
                    }
                }
                if (search.BeginTime.HasValue)
                {
                    bidEvaluationExpertCon.And(BID_EVALUATION_EXPERT._.EXPERT_CHECK_IN_TIME >= search.BeginTime);
                }

                if (search.EndDateTime.HasValue)
                {
                    bidEvaluationExpertCon.And(BID_EVALUATION_EXPERT._.EXPERT_CHECK_IN_TIME <= search.EndDateTime);
                }

                if (!string.IsNullOrWhiteSpace(search.AREACODE))
                {
                    bidEvaluationExpertCon.And(TENDER_PROJECT._.REGION_CODE == search.AREACODE);
                }

                if (!string.IsNullOrWhiteSpace(search.LEGAL_CODE))
                {
                    bidEvaluationExpertCon.And(BID_EVALUATION_EXPERT._.ID_CARD.Contain(search.LEGAL_CODE));
                }

                if (!string.IsNullOrWhiteSpace(search.LEGAL_NAME))
                {
                    bidEvaluationExpertCon.And(BID_EVALUATION_EXPERT._.EXPERT_NAME.Contain(search.LEGAL_NAME));
                }
                obj.TOTAL_COUNT = Fw.ExpertBidEvaluationService.FromWhere(bidEvaluationExpertCon.ToWhereClip())
                    .InnerJoin<BID_EVALUATION_EXPERT>(BID_EVALUATION_EXPERT._.ID_CARD == EXPERT_BID_EVALUATION._.ID_CARD)
                    .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == BID_EVALUATION_EXPERT._.TENDER_PROJECT_CODE)
                    .Select(EXPERT_BID_EVALUATION._.ID_CARD.Distinct().Count()).ToScalar<Int64>();
                var birth = Fw.ExpertBidEvaluationService.FromWhere(bidEvaluationExpertCon.ToWhereClip())
                    .InnerJoin<BID_EVALUATION_EXPERT>(BID_EVALUATION_EXPERT._.ID_CARD == EXPERT_BID_EVALUATION._.ID_CARD)
                    .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == BID_EVALUATION_EXPERT._.TENDER_PROJECT_CODE)
                    .Select(EXPERT_BID_EVALUATION._.BIRTHDAY.Year.Avg().ROUND())
                    .ToScalar<Int64>();
                if (birth > 0)
                {
                    obj.ADD_COUNT = DateTime.Today.Year - Convert.ToInt64(birth);//工作年龄
                }
                else
                {
                    obj.ADD_COUNT = null;//工作年龄
                }

                obj.ACTIVE_COUNT = Fw.ExpertBidEvaluationService.FromWhere(bidEvaluationExpertCon.ToWhereClip()).Select(EXPERT_BID_EVALUATION._.WORK_YEAR.Avg().ROUND())
                    .InnerJoin<BID_EVALUATION_EXPERT>(BID_EVALUATION_EXPERT._.ID_CARD == EXPERT_BID_EVALUATION._.ID_CARD)
                    .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == BID_EVALUATION_EXPERT._.TENDER_PROJECT_CODE)
                    .ToScalar<Int64>();//评价评标年限
                obj.PROJECT_COUNT = Fw.BidEvaluationExpertService.FromWhere(bidEvaluationExpertCon.ToWhereClip())
                    .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == BID_EVALUATION_EXPERT._.TENDER_PROJECT_CODE)
                    .Select(BID_EVALUATION_EXPERT._.TENDER_PROJECT_CODE.Count()).ToScalar<Int64>();
            }

            return obj;
        }

        #endregion

        #region 专家年龄
        /// <summary>
        /// 专家年龄
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public PieSeries Age(StatisticsBidderSearchModel search)
        {
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode;
            var typeList = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;
            var age30 = 0;
            var age40 = 0;
            var age50 = 0;
            var age60 = 0;
            var age70 = 0;
            var ageMax = 0;
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {
                var bidEvaluationExpertCon = new WhereClipBuilder(TENDER_PROJECT._.REGION_CODE.BeginWith(rootAreaCode) && TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(typeList));
                if (rootAreaCode == "3501")
                {
                    bidEvaluationExpertCon.And(TENDER_PROJECT._.REGION_CODE != "350128");
                }
                if (!string.IsNullOrWhiteSpace(search.TENDER_PROJECT_TYPE))
                {
                    if (search.TENDER_PROJECT_TYPE.Contains(","))
                    {
                        var projectTypes =
                            search.TENDER_PROJECT_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        bidEvaluationExpertCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(projectTypes));
                    }
                    else
                    {
                        bidEvaluationExpertCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE == search.TENDER_PROJECT_TYPE);
                    }
                }
                if (search.BeginTime.HasValue)
                {
                    bidEvaluationExpertCon.And(BID_EVALUATION_EXPERT._.EXPERT_CHECK_IN_TIME >= search.BeginTime);
                }

                if (search.EndDateTime.HasValue)
                {
                    bidEvaluationExpertCon.And(BID_EVALUATION_EXPERT._.EXPERT_CHECK_IN_TIME <= search.EndDateTime);
                }

                if (!string.IsNullOrWhiteSpace(search.AREACODE))
                {
                    bidEvaluationExpertCon.And(TENDER_PROJECT._.REGION_CODE == search.AREACODE);
                }

                if (!string.IsNullOrWhiteSpace(search.LEGAL_CODE))
                {
                    bidEvaluationExpertCon.And(BID_EVALUATION_EXPERT._.ID_CARD.Contain(search.LEGAL_CODE));
                }

                if (!string.IsNullOrWhiteSpace(search.LEGAL_NAME))
                {
                    bidEvaluationExpertCon.And(BID_EVALUATION_EXPERT._.EXPERT_NAME.Contain(search.LEGAL_NAME));
                }

                var birth = Fw.ExpertBidEvaluationService.FromWhere(bidEvaluationExpertCon.ToWhereClip())
                    .InnerJoin<BID_EVALUATION_EXPERT>(BID_EVALUATION_EXPERT._.ID_CARD == EXPERT_BID_EVALUATION._.ID_CARD)
                    .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == BID_EVALUATION_EXPERT._.TENDER_PROJECT_CODE)
                    .Select(EXPERT_BID_EVALUATION._.BIRTHDAY.Year)
                    .ToList<Int64>();
                var year = DateTime.Now.Year;
                age30 = birth.Count(c => year - c < 30);
                age40 = birth.Count(c => year - c < 40 && year - c >= 30);
                age50 = birth.Count(c => year - c < 50 && year - c >= 40);
                age60 = birth.Count(c => year - c < 60 && year - c >= 50);
                age70 = birth.Count(c => year - c < 70 && year - c >= 60);
                ageMax = birth.Count(c => year - c > 70);
            }
            var r = new PieSeries
            {
                Data = new List<PieSeriesData>
                {
                    new PieSeriesData {Value = ageMax, Name = $"70岁以上"},
                    new PieSeriesData {Value = age70, Name =$"60-70岁"},
                    new PieSeriesData {Value = age60, Name =$"50-60岁"},
                    new PieSeriesData {Value = age50, Name =$"40-50岁"},
                    new PieSeriesData {Value = age40, Name = $"30-40岁"},
                    new PieSeriesData {Value = age30, Name = $"30岁以下"},
                }
            };

            return r;
        }

        #endregion

        #region 专家专业占比
        /// <summary>
        /// 专家专业占比
        /// TODO 梳理 数据填充 zlw
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public PieSeries Major(StatisticsBidderSearchModel search)
        {
            var r = new PieSeries
            {
                Data = new List<PieSeriesData>
                {
                    new PieSeriesData {Value = 0, Name = $"专业1"},
                    new PieSeriesData {Value = 0, Name =$"专业2"},
                    new PieSeriesData {Value = 0, Name = $"专业3"},
                    new PieSeriesData {Value = 0, Name = $"专业4"},
                }
            };

            return r;
        }

        #endregion

        #region 参与招标情况
        /// <summary>
        /// 参与招标情况
        /// TODO 梳理 数据填充 zlw
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

                var con = new WhereClipBuilder(BID_EVALUATION_EXPERT._.EXPERT_CHECK_IN_TIME >= begin && BID_EVALUATION_EXPERT._.EXPERT_CHECK_IN_TIME <= end && TENDER_PROJECT._.REGION_CODE.BeginWith(rootAreaCode) && TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(typeList));

                var winResultAnnoCon = new WhereClipBuilder(WIN_RESULT_ANNO._.M_TM >= begin && WIN_RESULT_ANNO._.M_TM <= end && TENDER_PROJECT._.REGION_CODE.BeginWith(rootAreaCode) && TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(typeList));
                if (rootAreaCode == "3501")
                {
                    con.And(TENDER_PROJECT._.REGION_CODE != "350128");
                    winResultAnnoCon.And(TENDER_PROJECT._.REGION_CODE != "350128");
                }
                if (!string.IsNullOrWhiteSpace(search.TENDER_PROJECT_TYPE))
                {
                    if (search.TENDER_PROJECT_TYPE.Contains(","))
                    {
                        var projectTypes =
                            search.TENDER_PROJECT_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        con.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(projectTypes));
                        winResultAnnoCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(projectTypes));
                    }
                    else
                    {
                        con.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE == search.TENDER_PROJECT_TYPE);
                        winResultAnnoCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE == search.TENDER_PROJECT_TYPE);
                    }
                }
                if (!string.IsNullOrWhiteSpace(search.AREACODE))
                {
                    con.And(DSJ_AREA._.PCODE == search.AREACODE);
                    winResultAnnoCon.And(TENDER_PROJECT._.REGION_CODE == search.AREACODE);
                }
                var enterpriseData = Fw.ExpertBidEvaluationService.FromWhere(con.ToWhereClip())
                    .InnerJoin<DSJ_AREA>(DSJ_AREA._.OLDCODE == EXPERT_BID_EVALUATION._.AREA)
                    .InnerJoin<BID_EVALUATION_EXPERT>(BID_EVALUATION_EXPERT._.ID_CARD == EXPERT_BID_EVALUATION._.ID_CARD)
                    .InnerJoin<EVALUATION_REPORT>(
                        EVALUATION_REPORT._.TENDER_PROJECT_CODE == BID_EVALUATION_EXPERT._.TENDER_PROJECT_CODE &&
                        EVALUATION_REPORT._.BID_SECTION_CODE == BID_EVALUATION_EXPERT._.BID_SECTION_CODE)
                    .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == BID_EVALUATION_EXPERT._.TENDER_PROJECT_CODE)
                    .GroupBy(BID_EVALUATION_EXPERT._.EXPERT_CHECK_IN_TIME.ToChar(dbFormat))
                    .Select(BID_EVALUATION_EXPERT._.EXPERT_CHECK_IN_TIME.ToChar(dbFormat).As("Name"),
                        BID_EVALUATION_EXPERT._.ID_CARD.Distinct().Count().As("Value"))
                    .ToList<PieSeriesData>();

                var bidData = Fw.ExpertBidEvaluationService.FromWhere(con.ToWhereClip())
                    .InnerJoin<DSJ_AREA>(DSJ_AREA._.OLDCODE == EXPERT_BID_EVALUATION._.AREA)
                    .InnerJoin<BID_EVALUATION_EXPERT>(BID_EVALUATION_EXPERT._.ID_CARD == EXPERT_BID_EVALUATION._.ID_CARD)
                    .InnerJoin<EVALUATION_REPORT>(
                        EVALUATION_REPORT._.TENDER_PROJECT_CODE == BID_EVALUATION_EXPERT._.TENDER_PROJECT_CODE &&
                        EVALUATION_REPORT._.BID_SECTION_CODE == BID_EVALUATION_EXPERT._.BID_SECTION_CODE)
                    .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == BID_EVALUATION_EXPERT._.TENDER_PROJECT_CODE)
                    .GroupBy(BID_EVALUATION_EXPERT._.EXPERT_CHECK_IN_TIME.ToChar(dbFormat))
                    .Select(BID_EVALUATION_EXPERT._.EXPERT_CHECK_IN_TIME.ToChar(dbFormat).As("Name"),
                        Field.All.Count().As("Value"))
                    .ToList<PieSeriesData>();

                var bidSectionData = Fw.WinResultAnnoService.FromWhere(winResultAnnoCon.ToWhereClip())
                    .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == WIN_RESULT_ANNO._.TENDER_PROJECT_CODE)
                    .GroupBy(WIN_RESULT_ANNO._.M_TM.ToChar(dbFormat))
                    .Select(WIN_RESULT_ANNO._.M_TM.ToChar(dbFormat).As("Name"), Field.All.Count().As("Value"))
                    .ToList<PieSeriesData>();
                var enterprise = new LineBarSeries("ZJS");//专家数
                var bid = new LineBarSeries("PBCS");//评标次数
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

        protected string MixCode2IdCard(string c)
        {
            if (!string.IsNullOrWhiteSpace(c) && c.Length == 18)
            {
                return $"{c[6]}{c[0]}{c[7]}{c[12]}{c[16]}{c[1]}{c[13]}{c[8]}{c[17]}{c[2]}{c[4]}{c[14]}{c[5]}{c[10]}{c[9]}{c[15]}{c[11]}{c[3]}";
            }

            return c;
        }
        #region 评标参与排行（代理机构）
        /// <summary>
        /// 评标参与排行（代理机构）指评标专家参评的标与招标代理代理的招标项目相关联的招标代理机构排行，分析评标专家与招标代理机构的紧密度
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<LabelValueModel<int>> EXPERT_AGENCY(StatisticsBidderSearchModel search)
        {
            var code = MixCode2IdCard(search.KeyWord);
            var condition = new WhereClipBuilder(BID_EVALUATION_EXPERT._.ID_CARD == code);
            if (search.BeginTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME <= search.EndDateTime);
            }

            var query = FromWhere<V_BIG_JG>(condition.ToWhereClip())
                .InnerJoin<BID_EVALUATION_EXPERT>(
                    BID_EVALUATION_EXPERT._.TENDER_PROJECT_CODE == V_BIG_JG._.PROJECT_CODE)
                .GroupBy(V_BIG_JG._.TENDER_AGENCY_NAME)
                .Select(V_BIG_JG._.TENDER_AGENCY_NAME.As("Label"), V_BIG_JG._.All.Count().As("Value"))
                .OrderBy(LabelValueField.Value.Desc && LabelValueField.Label.Desc);
            if (string.IsNullOrWhiteSpace(search.Type))
            {
                query.Page(search.PageSize, search.PageNo);
            }
            var r = query.ToList<LabelValueModel<int>>();
            var r1 = r.Take(search.PageSize).ToList();
            r1.ForEach(c =>
            {
                var source = c.Label;
                c.Label = source;
            });
            var r2 = r.Skip(search.PageSize).ToList();
            if (r.Any())
            {
                r1.Add(new LabelValueModel<int>
                {
                    Id = "OTHER",
                    Label = "其他",
                    Value = r2.Sum(c => c.Value)
                });
            }
            return r1;
        }
        #endregion

        #region 评标参与排行（招标人）
        /// <summary>
        /// 评标参与排行（招标人）指评标专家参评的标与招标人发出的招标项目相关联的招标人排行，分析评标专家与招标人的紧密度
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<LabelValueModel<int>> EXPERT_TENDERER(StatisticsBidderSearchModel search)
        {
            var code = MixCode2IdCard(search.KeyWord);
            var condition = new WhereClipBuilder(BID_EVALUATION_EXPERT._.ID_CARD == code);
            if (search.BeginTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME <= search.EndDateTime);
            }

            var query = FromWhere<V_BIG_JG>(condition.ToWhereClip())
                .InnerJoin<BID_EVALUATION_EXPERT>(
                    BID_EVALUATION_EXPERT._.TENDER_PROJECT_CODE == V_BIG_JG._.PROJECT_CODE)
                .GroupBy(V_BIG_JG._.TENDERER_NAME)
                .Select(V_BIG_JG._.TENDERER_NAME.As("Label"), V_BIG_JG._.All.Count().As("Value"))
                .OrderBy(LabelValueField.Value.Desc && LabelValueField.Label.Desc);
            if (string.IsNullOrWhiteSpace(search.Type))
            {
                query.Page(search.PageSize, search.PageNo);
            }
            var r = query.ToList<LabelValueModel<int>>();
            var r1 = r.Take(search.PageSize).ToList();
            r1.ForEach(c =>
            {
                var source = c.Label;
                c.Label = source;
            });
            var r2 = r.Skip(search.PageSize).ToList();
            if (r.Any())
            {
                r1.Add(new LabelValueModel<int>
                {
                    Id = "OTHER",
                    Label = "其他",
                    Value = r2.Sum(c => c.Value)
                });
            }
            return r1;
        }
        #endregion

        #region 评标参与排行（投标人）
        /// <summary>
        /// 评标参与排行（投标人）指评标专家参评的标与投标人参与的项目相关联的投标企业排行，分析评标专家与投标人的紧密度
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<LabelValueModel<int>> EXPERT_BIDDER(StatisticsBidderSearchModel search)
        {
            var code = MixCode2IdCard(search.KeyWord);
            var condition = new WhereClipBuilder(BID_EVALUATION_EXPERT._.ID_CARD == code);
            if (search.BeginTime.HasValue)
            {
                condition.And(TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                condition.And(TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME <= search.EndDateTime);
            }

            var query = Fw.TenderListService.FromWhere(condition.ToWhereClip())
                //.LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE==TENDER_LIST._.TENDER_PROJECT_CODE)
                .LeftJoin<TENDER_ANN_QUA_INQUERY_ANN>(TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE == TENDER_LIST._.TENDER_PROJECT_CODE)
                .InnerJoin<BID_EVALUATION_EXPERT>(
                    BID_EVALUATION_EXPERT._.TENDER_PROJECT_CODE == TENDER_LIST._.TENDER_PROJECT_CODE)
                .GroupBy(TENDER_LIST._.BIDDER_NAME)
                .Select(TENDER_LIST._.BIDDER_NAME.As("Label"), V_BIG_JG._.All.Count().As("Value"))
                .OrderBy(LabelValueField.Value.Desc && LabelValueField.Label.Desc);
            if (string.IsNullOrWhiteSpace(search.Type))
            {
                query.Page(search.PageSize, search.PageNo);
            }
            var r = query.ToList<LabelValueModel<int>>();
            var r1 = r.Take(search.PageSize).ToList();
            r1.ForEach(c =>
            {
                var source = c.Label;
                c.Label = source;
            });
            var r2 = r.Skip(search.PageSize).ToList();
            if (r.Any())
            {
                r1.Add(new LabelValueModel<int>
                {
                    Id = "OTHER",
                    Label = "其他",
                    Value = r2.Sum(c => c.Value)
                });
            }
            return r1;
        }


        #endregion

        #region 中标情况分析
        /// <summary>
        /// 中标情况分析 指评标专家参评的标与中标人中标的招标项目相关联的招标人前5名占正常项目占比情况（有中标结果）
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<LabelValueModel<int>> EXPERT_WIN_BIDDER(StatisticsBidderSearchModel search)
        {
            var code = MixCode2IdCard(search.KeyWord);
            var condition = new WhereClipBuilder(BID_EVALUATION_EXPERT._.ID_CARD == code);
            if (search.BeginTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME <= search.EndDateTime);
            }

            var r = FromWhere<V_BIG_JG>(condition.ToWhereClip())
                .InnerJoin<BID_EVALUATION_EXPERT>(
                    BID_EVALUATION_EXPERT._.TENDER_PROJECT_CODE == V_BIG_JG._.PROJECT_CODE)
                .GroupBy(V_BIG_JG._.WIN_BIDDER_NAME)
                .Select(V_BIG_JG._.WIN_BIDDER_NAME.As("Label"), V_BIG_JG._.All.Count().As("Value"))
                .OrderBy(LabelValueField.Value.Desc && LabelValueField.Label.Desc)
                //.Page(search.PageSize, search.PageNo)
                .ToList<LabelValueModel<int>>();
            //return r;
            var r1 = r.Take(search.PageSize).ToList();
            r1.ForEach(c =>
            {
                var source = c.Label;
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

        #region 评标专家信息
        /// <summary>
        /// 评标专家信息
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public object EXPERT_INFO(StatisticsBidderSearchModel search)
        {
            var code = MixCode2IdCard(search.KeyWord);
            var condition = new WhereClipBuilder(BID_EVALUATION_EXPERT._.ID_CARD == code);
            //if (search.BeginTime.HasValue)
            //{
            //    condition.And(V_BIG_JG._.NOTICE_SEND_TIME >= search.BeginTime);
            //}

            //if (search.EndDateTime.HasValue)
            //{
            //    condition.And(V_BIG_JG._.NOTICE_SEND_TIME <= search.EndDateTime);
            //}

            var r = FromWhere<BID_EVALUATION_EXPERT>(condition.ToWhereClip())
                .LeftJoin<EXPERT_BID_EVALUATION>(BID_EVALUATION_EXPERT._.ID_CARD == EXPERT_BID_EVALUATION._.ID_CARD)
                .LeftJoin<SYS_DIC>(BID_EVALUATION_EXPERT._.ID_CARD_TYPE == SYS_DIC._.VALUE && SYS_DIC._.TYPE == "7")
                .LeftJoin<SYS_DIC>(EXPERT_BID_EVALUATION._.ONWORK == SYS_DIC._.VALUE && SYS_DIC._.TYPE == "2003")
                .LeftJoin<SYS_DIC>(EXPERT_BID_EVALUATION._.MAJOR_CODE == SYS_DIC._.VALUE && SYS_DIC._.TYPE == "5001")
                .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == EXPERT_BID_EVALUATION._.AREA)
                .Select(
                    BID_EVALUATION_EXPERT._.EXPERT_NAME,
                    BID_EVALUATION_EXPERT._.ID_CARD_TYPE,
                    SYS_DIC._.TEXT.As("ID_CARD_TYPE_TEXT"),
                    BID_EVALUATION_EXPERT._.ID_CARD,
                    EXPERT_BID_EVALUATION._.BASE_TYPE,
                    new Field("'综合评标专家'").As("BASE_TYPE_TEXT"),
                    EXPERT_BID_EVALUATION._.MAJOR_CODE,
                    new Field("TEXT", "SYS_DIC3").As("MAJOR_CODE_TEXT"),
                    EXPERT_BID_EVALUATION._.DUTY,
                    EXPERT_BID_EVALUATION._.ONWORK,
                    new Field("TEXT", "SYS_DIC2").As("ONWORK_TEXT"),
                    EXPERT_BID_EVALUATION._.AREA,
                    SYS_AREA_QUANGUO._.AREANAME,
                    EXPERT_BID_EVALUATION._.PROFESSIONAL
                    )
                .ToFirst<dynamic>();
            if (r != null)
            {
                if (!string.IsNullOrWhiteSpace(r.EXPERT_NAME))
                {
                    string expertName = r.EXPERT_NAME.ToString();
                    r.EXPERT_NAME = expertName.Desensitization();
                }
                if (!string.IsNullOrWhiteSpace(r.ID_CARD))//project_code 
                {
                    string idCard = r.ID_CARD.ToString();
                    r.ID_CARD =idCard.Desensitization();
                }
            }
            return r;
        }
        #endregion

        #region 专家评标项目情况
        /// <summary>
        /// 专家评标项目情况
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public object EXPERT_CHART_INFO(StatisticsBidderSearchModel search)
        {
            var code = MixCode2IdCard(search.KeyWord);
            var condition = new WhereClipBuilder(BID_EVALUATION_EXPERT._.ID_CARD == code);
            if (search.BeginTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME <= search.EndDateTime);
            }

            var r = FromWhere<BID_EVALUATION_EXPERT>(condition.ToWhereClip())
                .InnerJoin<V_BIG_JG>(V_BIG_JG._.PROJECT_CODE == BID_EVALUATION_EXPERT._.TENDER_PROJECT_CODE)
                .GroupBy(V_BIG_JG._.M_TM.Year)
                .Select(V_BIG_JG._.M_TM.Year.As("Label"), V_BIG_JG._.All.Count().As("Value"))
                .OrderBy(LabelValueField.Label.Asc)
                .ToList<LabelValueModel>();
            var r1 = new
            {
                xaixs = r.Select(c => c.Label).ToList(),
                data = r.Select(c => c.Value).ToList()
            };
            return r1;
        }
        #endregion


        #region 评标项目地区分布图

        /// <summary>
        /// 评标项目地区分布图
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>

        public List<LabelValueModel> EXPERT_AREA(StatisticsBidderSearchModel search)
        {
            var code = MixCode2IdCard(search.KeyWord);
            var condition = new WhereClipBuilder(BID_EVALUATION_EXPERT._.ID_CARD == code);
            if (search.BeginTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME <= search.EndDateTime);
            }
            var r = FromWhere<V_BIG_JG>(condition.ToWhereClip())
                .InnerJoin<BID_EVALUATION_EXPERT>(V_BIG_JG._.PROJECT_CODE == BID_EVALUATION_EXPERT._.TENDER_PROJECT_CODE)
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


        #endregion
    }
}