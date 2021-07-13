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
using PieSeriesData = GGZY.Services.Infrastructure.Model.BigData.PieSeriesData;

namespace GGZY.Services.BigData
{
    /// <summary>
    /// 工程领域监察大数据服务系统-综合统计-招标人情况
    /// </summary>
    public partial class StatisticsBidderService : BaseServiceT<FwEntity>
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

                var tenderCon = new WhereClipBuilder(TENDER_PROJECT._.TENDERER_NAME.Len() > 5 && TENDER_PROJECT._.M_KEY.IsNotNull() && TENDER_PROJECT._.REGION_CODE.BeginWith(rootAreaCode) && TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(typeList));
                if (rootAreaCode == "3501")
                {
                    tenderCon.And(TENDER_PROJECT._.REGION_CODE != "350128");
                }
                //if (!string.IsNullOrWhiteSpace(search.TENDER_PROJECT_TYPE))
                //{
                //    tenderCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE == search.TENDER_PROJECT_TYPE);
                //}
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
                    //tenderCon.And(DSJ_AREA._.PCODE == search.AREACODE);
                    tenderCon.And(TENDER_PROJECT._.REGION_CODE == search.AREACODE);
                }
                if (!string.IsNullOrWhiteSpace(search.LEGAL_CODE))
                {
                    tenderCon.And(LEGAL_PERSON_BASE._.LEGAL_CODE.Contain(search.LEGAL_CODE));
                }
                if (!string.IsNullOrWhiteSpace(search.LEGAL_NAME))
                {
                    tenderCon.And(TENDER_PROJECT._.TENDERER_NAME.Contain(search.LEGAL_NAME));
                }
                var tenderAnnQuaInqueryAnnSection = Fw.TenderAnnQuaInqueryAnnService
                    .FromWhere(tenderAnnQuaInqueryAnnCon.ToWhereClip() && TENDER_ANN_QUA_INQUERY_ANN._.M_KEY.IsNotNull())
                    .Select(TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE.Distinct());

                var winResultAnnoSection = Fw.WinResultAnnoService.FromWhere(WIN_RESULT_ANNO._.M_KEY.IsNotNull()).GroupBy(WIN_RESULT_ANNO._.TENDER_PROJECT_CODE).Select(WIN_RESULT_ANNO._.TENDER_PROJECT_CODE);

                var winSection = Fw.TenderProjectService.FromWhere()
                    .InnerJoinTmp<WIN_RESULT_ANNO>(winResultAnnoSection,
                        WIN_RESULT_ANNO._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                    .InnerJoinTmp<TENDER_ANN_QUA_INQUERY_ANN>(tenderAnnQuaInqueryAnnSection,
                        TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                    .GroupBy(TENDER_PROJECT._.TENDERER_NAME)
                    .Select(TENDER_PROJECT._.TENDERER_NAME.As("LEGAL_NAME"), TENDER_PROJECT._.TENDER_PROJECT_CODE.Count().As("WIN_COUNT"));


                var legalBase = Fw.LegalPersonBaseService.FromWhere(LEGAL_PERSON_BASE._.LEGAL_ROLE.Contain("01"))
                    .GroupBy(LEGAL_PERSON_BASE._.LEGAL_NAME)
                    .Select(LEGAL_PERSON_BASE._.LEGAL_CODE.Max(), LEGAL_PERSON_BASE._.LEGAL_NAME,
                        LEGAL_PERSON_BASE._.REGION_CODE.Max());
                var tenderSection = Fw.TenderProjectService.FromWhere(tenderCon.ToWhereClip())
                    .LeftJoinTmp<LEGAL_PERSON_BASE>(legalBase, TENDER_PROJECT._.TENDERER_NAME == LEGAL_PERSON_BASE._.LEGAL_NAME)
                    .LeftJoin<DSJ_AREA>(DSJ_AREA._.OLDCODE == TENDER_PROJECT._.REGION_CODE)
                    .InnerJoinTmp<TENDER_ANN_QUA_INQUERY_ANN>(tenderAnnQuaInqueryAnnSection,
                        TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                    .LeftJoinTmp<V_TENDER_PROJECT_WIN_RESULT>(winSection, V_TENDER_PROJECT_WIN_RESULT.LEGAL_NAME == TENDER_PROJECT._.TENDERER_NAME)
                    .GroupBy(TENDER_PROJECT._.TENDERER_NAME)
                    .Select(TENDER_PROJECT._.TENDERER_NAME.As("LEGAL_NAME"), TENDER_PROJECT._.TENDERER_NAME.Count().As("Count"), V_TENDER_PROJECT_WIN_RESULT.WIN_COUNT.Max(), DSJ_AREA._.AREANAME.Max(), LEGAL_PERSON_BASE._.LEGAL_CODE.Max());

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


            return search.ToPageTableResult();
        }


        #endregion

        #region 招标人项目金额分布--活跃招标人

        /// <summary>
        /// 招标人项目金额分布--活跃招标人
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public StatisticsBidderDataSummaryModel ProjectAmountDistribution_ActiveCount(
            StatisticsBidderSearchModel search)
        {
            var r = new StatisticsBidderDataSummaryModel();
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode;
            var typeList = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;

            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {
                var condition = new WhereClipBuilder(V_BIG_JG._.AMOUNT < 300000 && V_BIG_JG._.AREACODE.BeginWith(rootAreaCode) && V_BIG_JG._.PROJECT_TYPE.In(typeList)); //早期数据金额单位不规范
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
                    condition.And(V_BIG_JG._.TENDERER_CODE.Contain(search.LEGAL_CODE));
                }

                if (!string.IsNullOrWhiteSpace(search.LEGAL_NAME))
                {
                    condition.And(V_BIG_JG._.TENDERER_NAME.Contain(search.LEGAL_NAME));
                }



                var query = FromWhere<V_BIG_JG>(condition.ToWhereClip());
                r.ACTIVE_COUNT = query.Select(V_BIG_JG._.TENDERER_NAME.Distinct().Count()).ToScalar<Int64>();

                var field = new Field(@"CASE WHEN AMOUNT<200 THEN '1' 
WHEN AMOUNT>=200 AND AMOUNT<1000 THEN '2'
WHEN AMOUNT>=1000 AND AMOUNT<3000 THEN '3'
WHEN AMOUNT>=3000 AND AMOUNT<10000 THEN '4'
WHEN AMOUNT>=10000  THEN '5' END ");
                var data = query.GroupBy(field)
                    .Select(field.As("Name"), Field.All.Count().As("Value"), V_BIG_JG._.AMOUNT.Sum())
                    .ToList<StatisticsBidderDataSourceModel>();

                r.CHART_DATA = new List<PieSeriesData>
            {
                new PieSeriesData {Name = "200万元以下", Value = data.FirstOrDefault(c => c.Name == "1")?.Value},
                new PieSeriesData {Name = "200-1000万元", Value = data.FirstOrDefault(c => c.Name == "2")?.Value},
                new PieSeriesData {Name = "1000-3000万元", Value = data.FirstOrDefault(c => c.Name == "3")?.Value},
                new PieSeriesData {Name = "3000万元-1亿", Value = data.FirstOrDefault(c => c.Name == "4")?.Value},
                new PieSeriesData {Name = "1亿以上", Value = data.FirstOrDefault(c => c.Name == "5")?.Value}
            };
                r.TOTAL_AMOUNT = data.Sum(c => c.Amount / 10000);
                r.TOTAL_COUNT = data.Sum(c => c.Value);

            }

            return r;

        }

        #endregion

        #region 招标人分析-总数|新增数|活跃数|总次数

        /// <summary>
        /// 招标人分析-总数|新增数|活跃数|总次数
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

                //return obj;
                var activeCon = new WhereClipBuilder(V_BIG_JG._.AMOUNT < 300000 && V_BIG_JG._.AREACODE.BeginWith(rootAreaCode) && V_BIG_JG._.PROJECT_TYPE.In(typeList));//早期数据金额单位不规范
                var addCon = new WhereClipBuilder(LEGAL_PERSON_BASE._.LEGAL_ROLE == "01");//招标人
                var tenderCon = new WhereClipBuilder(TENDER_PROJECT._.REGION_CODE.BeginWith(rootAreaCode) && TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(typeList));//招标总次数
                var totalCon = new WhereClipBuilder(TENDER_PROJECT._.REGION_CODE.BeginWith(rootAreaCode) && TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(typeList));//招标人总数
                var addTmpCon = new WhereClipBuilder();
                if (rootAreaCode == "3501")
                {
                    tenderCon.And(TENDER_PROJECT._.REGION_CODE != "350128");
                    totalCon.And(TENDER_PROJECT._.REGION_CODE != "350128");
                    activeCon.And(V_BIG_JG._.AREACODE != "350128");
                }
                if (!string.IsNullOrWhiteSpace(search.TENDER_PROJECT_TYPE))
                {
                    if (search.TENDER_PROJECT_TYPE.Contains(","))
                    {
                        var projectTypes =
                            search.TENDER_PROJECT_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        activeCon.And(V_BIG_JG._.PROJECT_TYPE.In(projectTypes));
                        tenderCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(projectTypes));
                        totalCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(projectTypes));
                    }
                    else
                    {
                        activeCon.And(V_BIG_JG._.PROJECT_TYPE == search.TENDER_PROJECT_TYPE);
                        tenderCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE == search.TENDER_PROJECT_TYPE);
                        totalCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE == search.TENDER_PROJECT_TYPE);
                    }
                }
                if (search.BeginTime.HasValue)
                {
                    activeCon.And(V_BIG_JG._.M_TM >= search.BeginTime);
                    addCon.And(LEGAL_PERSON_BASE._.M_TM >= search.BeginTime);
                    tenderCon.And(TENDER_PROJECT._.M_TM >= search.BeginTime);
                    addTmpCon.And(TENDER_PROJECT._.M_TM >= search.BeginTime);
                }

                if (search.EndDateTime.HasValue)
                {
                    activeCon.And(V_BIG_JG._.M_TM <= search.EndDateTime);
                    addCon.And(LEGAL_PERSON_BASE._.M_TM <= search.EndDateTime);
                    tenderCon.And(TENDER_PROJECT._.M_TM <= search.EndDateTime);
                    addTmpCon.And(TENDER_PROJECT._.M_TM <= search.EndDateTime);
                }

                if (!string.IsNullOrWhiteSpace(search.AREACODE))
                {
                    activeCon.And(V_BIG_JG._.AREACODE == search.AREACODE);
                    addCon.And(LEGAL_PERSON_BASE._.REGION_CODE == search.AREACODE);
                    tenderCon.And(TENDER_PROJECT._.REGION_CODE == search.AREACODE);
                    totalCon.And(TENDER_PROJECT._.REGION_CODE == search.AREACODE);
                }

                if (!string.IsNullOrWhiteSpace(search.LEGAL_CODE))
                {
                    activeCon.And(V_BIG_JG._.TENDERER_CODE.Contain(search.LEGAL_CODE));
                    addCon.And(LEGAL_PERSON_BASE._.LEGAL_CODE.Contain(search.LEGAL_CODE));
                    tenderCon.And(TENDER_PROJECT._.TENDERER_CODE.Contain(search.LEGAL_CODE));
                    totalCon.And(TENDER_PROJECT._.TENDERER_CODE.Contain(search.LEGAL_CODE));
                }

                if (!string.IsNullOrWhiteSpace(search.LEGAL_NAME))
                {
                    activeCon.And(V_BIG_JG._.TENDERER_NAME.Contain(search.LEGAL_NAME));
                    addCon.And(LEGAL_PERSON_BASE._.LEGAL_NAME.Contain(search.LEGAL_NAME));
                    tenderCon.And(TENDER_PROJECT._.TENDERER_NAME.Contain(search.LEGAL_NAME));
                    totalCon.And(TENDER_PROJECT._.TENDERER_NAME.Contain(search.LEGAL_NAME));
                }

                var query = FromWhere<V_BIG_JG>(activeCon.ToWhereClip());
                obj.TOTAL_COUNT = Fw.TenderProjectService.FromWhere(totalCon.ToWhereClip())
                    .Select(TENDER_PROJECT._.TENDERER_CODE).Distinct().Count();//  Fw.LegalPersonBaseService.Count(LEGAL_PERSON_BASE._.LEGAL_ROLE == "01");//招标人总数
                var addTmp = Fw.TenderProjectService.FromWhere(totalCon.ToWhereClip())
                    .GroupBy(TENDER_PROJECT._.TENDERER_CODE)
                    .Select(TENDER_PROJECT._.TENDERER_CODE, TENDER_PROJECT._.M_TM.Min().As("M_TM"));
                obj.ADD_COUNT = Fw.LegalPersonBaseService.FromWhere(addTmpCon.ToWhereClip())
                    .RightJoinTmp<TENDER_PROJECT>(addTmp, "1=0").Select(TENDER_PROJECT._.TENDERER_CODE).Distinct().Count();// Fw.LegalPersonBaseService.FromWhere(addCon.ToWhereClip()).Count();//新增招标人
                obj.ACTIVE_COUNT = query.Select(V_BIG_JG._.TENDERER_NAME.Distinct().Count()).ToScalar<Int64>();//活跃招标人
                obj.PROJECT_COUNT = Fw.TenderProjectService.Count(tenderCon.ToWhereClip());//招标总次数
            }
            return obj;
        }

        #endregion

        #region 省份占比
        /// <summary>
        /// 省份占比
        /// TODO 梳理 数据填充 zlw
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<PieSeriesData> RegionChart(StatisticsBidderSearchModel search)
        {
            var r = new List<PieSeriesData>
            {
                new PieSeriesData {Name = "省内", Value = 10},
                new PieSeriesData {Name = "省外", Value = 10},
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
                    new PieSeriesData {Value = 0, Name = $"特级:0家"},
                    new PieSeriesData {Value = 0, Name =$"一级:0家"},
                    new PieSeriesData {Value = 0, Name = $"二级:0家"},
                    new PieSeriesData {Value = 0, Name = $"三级:0"},
                    new PieSeriesData {Value = 0, Name = $"四级:0"},
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

        #region 招标人性质
        /// <summary>
        /// 招标人性质
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

                var tenderCon = new WhereClipBuilder(TENDER_PROJECT._.TENDERER_NAME.Len() > 5 && TENDER_PROJECT._.REGION_CODE.BeginWith(rootAreaCode) && TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(typeList));
                var winResultAnnoCon = new WhereClipBuilder(WIN_RESULT_ANNO._.M_TM >= begin && WIN_RESULT_ANNO._.M_TM <= end && TENDER_PROJECT._.REGION_CODE.BeginWith(rootAreaCode) && TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(typeList));
                if (rootAreaCode == "3501")
                {
                    tenderCon.And(TENDER_PROJECT._.REGION_CODE != "350128");
                    winResultAnnoCon.And(TENDER_PROJECT._.REGION_CODE != "350128");
                }
                if (!string.IsNullOrWhiteSpace(search.AREACODE))
                {
                    tenderCon.And(TENDER_PROJECT._.REGION_CODE == search.AREACODE);
                    winResultAnnoCon.And(TENDER_PROJECT._.REGION_CODE == search.AREACODE);
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

                var enterpriseData = Fw.TenderProjectService.FromWhere(tenderCon.ToWhereClip())
                    .InnerJoin<TENDER_ANN_QUA_INQUERY_ANN>(tenderAnnQuaInqueryAnnCon.ToWhereClip() && TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                    .GroupBy(TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME.ToChar(dbFormat))
                    .Select(TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME.ToChar(dbFormat).As("Name"),
                        TENDER_PROJECT._.TENDERER_CODE.Distinct().Count().As("Value"))
                    .ToList<PieSeriesData>();

                //var bidData = Fw.TenderProjectService.FromWhere()
                //    .RightJoinTmp("TMP", Fw.TenderProjectService.FromWhere(tenderCon.ToWhereClip()).InnerJoin<TENDER_ANN_QUA_INQUERY_ANN>(tenderAnnQuaInqueryAnnCon.ToWhereClip() && TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                //        .GroupBy(TENDER_PROJECT._.TENDERER_CODE, TENDER_PROJECT._.TENDER_PROJECT_CODE, TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME.ToChar(dbFormat))
                //        .Select(TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME.ToChar(dbFormat).As("Name")), "1=0")
                //    .GroupBy(new Field("Name"))
                //    .Select(new Field("Name"), Field.All.Count().As("Value"))
                //    .ToList<PieSeriesData>();
                var bidDataSource = Fw.TenderProjectService.FromWhere(tenderCon.ToWhereClip()).InnerJoin<TENDER_ANN_QUA_INQUERY_ANN>(tenderAnnQuaInqueryAnnCon.ToWhereClip() && TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                    .GroupBy(TENDER_PROJECT._.TENDERER_CODE, TENDER_PROJECT._.TENDER_PROJECT_CODE, TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME.ToChar(dbFormat))
                    .Select(TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME.ToChar(dbFormat).As("Name")).ToList<PieSeriesData>();


                var bidSectionData = Fw.WinResultAnnoService.FromWhere(winResultAnnoCon.ToWhereClip())
                    .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == WIN_RESULT_ANNO._.TENDER_PROJECT_CODE)
                    .GroupBy(WIN_RESULT_ANNO._.M_TM.ToChar(dbFormat))
                    .Select(WIN_RESULT_ANNO._.M_TM.ToChar(dbFormat).As("Name"), WIN_RESULT_ANNO._.BID_SECTION_CODE.Distinct().Count().As("Value"))//Field.All.Count().As("Value")
                    .ToList<PieSeriesData>();
                var enterprise = new LineBarSeries("ZBRSL");//招标人数量（已发招标公告）
                var bid = new LineBarSeries("ZBCS");//招标次数 按照招标公告发布时间统计
                var bidSection = new LineBarSeries("BDS");//标段数(中标结果公告)标段统计
                while (begin <= end)
                {
                    var tm = begin.ToString(format);
                    enterprise.Data.Add((enterpriseData.FirstOrDefault(c => c.Name == tm)?.Value) ?? 0);
                    bid.Data.Add(bidDataSource.Count(c => c.Name == tm));
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

        #region 招标人信息

        /// <summary>
        /// 招标人信息
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>

        public object TENDERER_INFO(StatisticsBidderSearchModel search)
        {
            //search.PageSize = 2;
            TENDER_PROJECT tenderProject =
                Fw.TenderProjectService.FirstOrNull(TENDER_PROJECT._.TENDERER_NAME == search.KeyWord);
            List<LabelValueModel<int>> modes = Fw.TenderProjectService
                .FromWhere(TENDER_PROJECT._.TENDERER_NAME == search.KeyWord)
                .InnerJoin<WIN_RESULT_ANNO>(WIN_RESULT_ANNO._.TENDER_PROJECT_CODE ==
                                            TENDER_PROJECT._.TENDER_PROJECT_CODE)
                .InnerJoin<SYS_DIC>(SYS_DIC._.TYPE == "1000" && SYS_DIC._.VALUE == TENDER_PROJECT._.TENDER_MODE)
                .GroupBy(SYS_DIC._.TEXT)
                .Select(SYS_DIC._.TEXT.As("Label"), TENDER_PROJECT._.All.Count().As("Value"))
                .OrderBy(LabelValueField.Value.Desc)
                .Page(2,search.PageNo)
                .ToList<LabelValueModel<int>>();
            List<LabelValueModel<int>> types = Fw.TenderProjectService
                .FromWhere(TENDER_PROJECT._.TENDERER_NAME == search.KeyWord)
                .InnerJoin<WIN_RESULT_ANNO>(WIN_RESULT_ANNO._.TENDER_PROJECT_CODE ==
                                            TENDER_PROJECT._.TENDER_PROJECT_CODE)
                .InnerJoin<SYS_DIC>(SYS_DIC._.PID == "2525" && SYS_DIC._.VALUE == TENDER_PROJECT._.TENDER_PROJECT_TYPE)
                .GroupBy(SYS_DIC._.TEXT)
                .Select(SYS_DIC._.TEXT.As("Label"), TENDER_PROJECT._.All.Count().As("Value"))
                .OrderBy(LabelValueField.Value.Desc)
                .Page(search.PageSize, search.PageNo)
                .ToList<LabelValueModel<int>>();
            decimal maxAmount =
                FromWhere<V_BIG_JG>(V_BIG_JG._.TENDERER_NAME == search.KeyWord && V_BIG_JG._.AMOUNT < 300000)
                    .Select(V_BIG_JG._.AMOUNT.Max().ROUND(4)).ToScalar<decimal>();
            
            List<LabelValueModel> areas = this.TENDERER_AREA(search);
            return new{
                NAME=tenderProject.TENDERER_NAME,
                CODE=tenderProject.TENDERER_CODE,
                TENDER_MODE =string.Join(",",modes.Select(m=>m.Label)),
                TENDER_PROJECT_TYPE= string.Join(",", types.Select(m => m.Label)),
                MAX_AMOUNT=maxAmount,//万元
                AREANAME = string.Join(",", areas.Select(m => m.Label)),
                QUAL_NAME=string.Empty,//企业资质
            };
            //TODO 企业资质 这里实际使用的是代理的资质 有问题
            //SELECT T.TENDERER_NAME AS LEGAL_NAME,T.TENDER_AGENCY_CODE LEGAL_CODE, T1.LEGAL_CONTACT,T1.LEGAL_CONTACT_PHONE,T2.QUAL_NAME
            //    FROM TENDER_PROJECT T
            //LEFT JOIN LEGAL_PERSON_BASE T1 ON T.TENDERER_NAME = T1.LEGAL_NAME
            //LEFT JOIN TENDER_AGENT_EX_INFO T2 ON T1.LEGAL_CODE = T2.LEGAL_CODE
            //WHERE T.TENDERER_NAME =#code#
        }

        #endregion

        #region 发包情况

        /// <summary>
        /// 发包情况
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>

        public List<LabelValueModel> TENDERER_CHART_INFO(StatisticsBidderSearchModel search)
        {
            var condition = new WhereClipBuilder(V_BIG_JG._.TENDERER_NAME == search.KeyWord ||
                                                 V_BIG_JG._.TENDERER_CODE == search.KeyWord);
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

        #region 投标项目地区分布图

        /// <summary>
        /// 投标项目地区分布图
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>

        public List<LabelValueModel> TENDERER_AREA(StatisticsBidderSearchModel search)
        {
            var condition = new WhereClipBuilder(V_BIG_JG._.TENDERER_NAME == search.KeyWord ||
                                                 V_BIG_JG._.TENDERER_CODE == search.KeyWord);
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

        #region 委托招标排行

        /// <summary>
        /// 委托招标排行
        /// 指招标人发出的标经常委托招标代理机的排行情况，分析招标人与招标代理机构之间的紧密度
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>

        public List<LabelValueModel> TENDERER_PROXY(StatisticsBidderSearchModel search)
        {
            var condition = new WhereClipBuilder(V_BIG_JG._.TENDERER_NAME == search.KeyWord ||
                                                 V_BIG_JG._.TENDERER_CODE == search.KeyWord);
            if (search.BeginTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME <= search.EndDateTime);
            }
            var r = FromWhere<V_BIG_JG>(condition.ToWhereClip())
                .GroupBy(V_BIG_JG._.TENDER_AGENCY_NAME)
                .Select(V_BIG_JG._.TENDER_AGENCY_NAME.As("Label"), V_BIG_JG._.All.Count().As("Value"))
                .Page(search.PageSize, search.PageNo)
                 .OrderBy(LabelValueField.Value.Desc && LabelValueField.Label.Desc)
                .ToList<LabelValueModel>();
            return r;
        }

        #endregion

        #region 委托招标占比分析

        /// <summary>
        /// 委托招标占比分析
        /// 分析招标人经常委托的招标代理机构占招标人所有委托招标的比值
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<LabelValueModel<decimal?>> TENDERER_PROXY_RATE(StatisticsBidderSearchModel search)
        {
            var condition = new WhereClipBuilder(V_BIG_JG._.TENDERER_NAME == search.KeyWord ||
                                                 V_BIG_JG._.TENDERER_CODE == search.KeyWord);
            if (search.BeginTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME <= search.EndDateTime);
            }
            var r = FromWhere<V_BIG_JG>(condition.ToWhereClip())
                .GroupBy(V_BIG_JG._.TENDER_AGENCY_NAME)
                .Select(V_BIG_JG._.TENDER_AGENCY_NAME.As("Label"), V_BIG_JG._.All.Count().As("Value"))
                 .OrderBy(LabelValueField.Value.Desc && LabelValueField.Label.Desc)
                .ToList<LabelValueModel<decimal?>>();
            var r1 = r.Take(search.PageSize).ToList();
            var r2 = r.Skip(search.PageSize).ToList();
            r1.Add(new LabelValueModel<decimal?>
            {
                Id = "OTHER",
                Label = "其他",
                Value = r2.Sum(c => c.Value)
            });
            return r1;
        }

        #endregion

        #region 投标参与排行
        /// <summary>
        /// 投标参与排行
        /// 指招标人发出的项目经常参与的投标的企业排行，通过投标企业的活跃度分析招标人与投标企业之间的紧密性
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<LabelValueModel> TENDERER_BIDDER_DIAG(StatisticsBidderSearchModel search)
        {
            var condition = new WhereClipBuilder(V_BIG_JG._.TENDERER_NAME == search.KeyWord ||
                                                 V_BIG_JG._.TENDERER_CODE == search.KeyWord);
            if (search.BeginTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME >= search.BeginTime);
            }

            if (search.EndDateTime.HasValue)
            {
                condition.And(V_BIG_JG._.NOTICE_SEND_TIME <= search.EndDateTime);
            }
            var r = FromWhere<V_BIG_JG>(condition.ToWhereClip())
                .InnerJoin<TENDER_LIST>(TENDER_LIST._.TENDER_PROJECT_CODE == V_BIG_JG._.PROJECT_CODE)
                .GroupBy(TENDER_LIST._.BIDDER_NAME)
                .Select(TENDER_LIST._.BIDDER_NAME.As("Label"), TENDER_LIST._.All.Count().As("Value"))
                .Page(search.PageSize, search.PageNo)
                 .OrderBy(LabelValueField.Value.Desc && LabelValueField.Label.Desc)
                .ToList<LabelValueModel>();
            return r;
        }

        #endregion

        #region 中标企业排行
        /// <summary>
        /// 投标参与排行
        /// 指招标人发出的项目中标率较高的企业占招标人所发项目的占比情况，分析招标人与中标单位之间的紧密度
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<LabelValueModel> TENDERER_WIN_BIDDER(StatisticsBidderSearchModel search)
        {
            var condition = new WhereClipBuilder(V_BIG_JG._.TENDERER_NAME == search.KeyWord ||
                                                 V_BIG_JG._.TENDERER_CODE == search.KeyWord);
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
                .Page(search.PageSize, search.PageNo)
                 .OrderBy(LabelValueField.Value.Desc && LabelValueField.Label.Desc)
                .ToList<LabelValueModel>();
            return r;
        }

        #endregion

        #region 评标专家参与排行
        /// <summary>
        /// 评标专家参与排行
        /// 指招标人发出的项目出现频次较多的评标专家排行，分析招标人与评标专家的紧密度
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<LabelValueModel> TENDERER_EXPERT(StatisticsBidderSearchModel search)
        {
            var condition = new WhereClipBuilder(V_BIG_JG._.TENDERER_NAME == search.KeyWord ||
                                                 V_BIG_JG._.TENDERER_CODE == search.KeyWord);
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

        #region 正常项目专家参与排行
        /// <summary>
        /// 正常项目专家参与排行
        /// 指招标人发出的完成招投标环的项目（已发出中标结果公示项目，流标及终止项目不计在内），出现频次较高的评标专家占所有评标专家的比值
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<LabelValueModel<decimal?>> TENDERER_EXPERT_RATE(StatisticsBidderSearchModel search)
        {
            var condition = new WhereClipBuilder(V_BIG_JG._.TENDERER_NAME == search.KeyWord ||
                                                 V_BIG_JG._.TENDERER_CODE == search.KeyWord);
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
                .ToList<LabelValueModel<decimal?>>();
            var r1 = r.Take(search.PageSize).ToList();
            r1.ForEach(c =>
            {
                var source = c.Label.Desensitization();
                c.Label = source;
            });
            var r2 = r.Skip(search.PageSize).ToList();
            r1.Add(new LabelValueModel<decimal?>
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

