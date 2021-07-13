using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Model.BigData;
using GGZYFW.DbEntity;

namespace GGZY.Services.BigData
{
    /// <summary>
    /// 工程领域监察大数据服务系统-首页
    /// </summary>
    public partial class DashboardService : BaseServiceT<FwEntity>
    {
        #region 交易排行

        /// <summary>
        /// 交易排行
        /// </summary>
        /// <returns></returns>
        public PageTableResult TradeRank(EngineerSearchModel search)
        {
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode;//??"35";
            var typeList = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;//??new List<string>{ "A01", "A02", "A99-1", "A07", "A03-1", "A03-2", "A06", "A99-2", "G01", "G02", "G99-1", "G07", "G03-1", "G03-2", "G06", "G99-2", "A99", "G99", "A03", "G03" };

            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {
                var con = new WhereClipBuilder(V_BIG_ALLRESULT._.TYPE == "工程建设" && V_BIG_ALLRESULT._.AREACODE.BeginWith(rootAreaCode) && V_BIG_ALLRESULT._.PROJECT_TYPE.In(typeList));
                if (rootAreaCode == "3501")
                {
                    con.And(V_BIG_ALLRESULT._.AREACODE!="350128");
                }
                if (string.IsNullOrWhiteSpace(search.AREACODE))
                {
                    search.AREACODE = JdUser?.UserDepartment?.AREACODE;//??"350000";
                }
                if (!string.IsNullOrWhiteSpace(search.TENDER_PROJECT_TYPE))
                {
                    if (search.TENDER_PROJECT_TYPE.Contains(","))
                    {
                        var projectTypes =
                            search.TENDER_PROJECT_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        con.And(V_BIG_ALLRESULT._.PROJECT_TYPE.In(projectTypes));
                    }
                    else
                    {
                        con.And(V_BIG_ALLRESULT._.PROJECT_TYPE == search.TENDER_PROJECT_TYPE);
                    }
                }
                if (search.BeginTime.HasValue)
                {
                    con.And(V_BIG_ALLRESULT._.M_TM >= search.BeginTime);
                }
                if (search.EndDateTime.HasValue)
                {
                    con.And(V_BIG_ALLRESULT._.M_TM <= search.EndDateTime);
                }

                var dsjArea = FromWhere<DSJ_AREA>(DSJ_AREA._.PCODE == search.AREACODE);
                FromSection<V_BIG_ALLRESULT> bigAllResultSection;
                if (search.AREACODE == "350000")
                {
                    bigAllResultSection = FromWhere<V_BIG_ALLRESULT>(con.ToWhereClip())
                        .Select(
                            V_BIG_ALLRESULT._.AREACODE.Substring(0, 4).OracleConcat("00").As("AREACODE")
                            , V_BIG_ALLRESULT._.AMOUNT.Sum()
                            , V_BIG_ALLRESULT._.AREACODE.Count().As("TOTAL_COUNT")
                        )
                        .GroupBy(V_BIG_ALLRESULT._.AREACODE.Substring(0, 4));
                }
                else
                {

                    con.And(V_BIG_ALLRESULT._.AREACODE.SubQueryIn(dsjArea.Select(DSJ_AREA._.AREACODE)));
                    bigAllResultSection = FromWhere<V_BIG_ALLRESULT>(con.ToWhereClip())
                        .Select(
                            V_BIG_ALLRESULT._.AREACODE
                            , V_BIG_ALLRESULT._.AMOUNT.Sum()
                            , V_BIG_ALLRESULT._.AREACODE.Count().As("TOTAL_COUNT")
                        )
                        .GroupBy(V_BIG_ALLRESULT._.AREACODE);
                }

                OrderByClip orderBy = V_TRADE_RANK.AMOUNT.Nvl(0).Desc;
                if (search.Type == "1")//1 交易数量 2 交易额
                {
                    orderBy = V_TRADE_RANK.TOTAL_COUNT.Nvl(0).Desc;
                }

                var query = dsjArea.LeftJoinTmp<V_TRADE_RANK>(bigAllResultSection, DSJ_AREA._.AREACODE == V_TRADE_RANK.AREACODE);
                var total = query.Count();
                if (total > 0)
                {
                    var list = query.Select(DSJ_AREA._.AREANAME, V_TRADE_RANK.AMOUNT, V_TRADE_RANK.TOTAL_COUNT)
                        .OrderBy(orderBy && V_TRADE_RANK.AREACODE.Asc)
                        .Page(search.PageSize, search.PageNo)
                        .ToList<DashboardTradeRankModel>();
                    var pageList = list.ToPageTableResult(search, total);
                    return pageList;
                }
            }


            return search.ToPageTableResult();
        }



        #endregion

        #region 交易数据统计
        /// <summary>
        /// 交易数据统计
        /// </summary>
        /// <param name="search">AREACODE BeginTime EndTime</param>
        /// <returns></returns>
        public DashboardTradeDataSummaryModel TradeDataSummary(EngineerSearchModel search)
        {
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode;
            var typeList = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;
            var summary = new DashboardTradeDataSummaryModel();
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {
                var condition =
                    new WhereClipBuilder(V_BIG_ALLRESULT._.TYPE == "工程建设"  && V_BIG_ALLRESULT._.PROJECT_TYPE.In(typeList));


                var jieYueCondition = new WhereClipBuilder(
                    $"{SECTION._.CONTRACT_RECKON_PRICE_W.Name} - {WIN_RESULT_ANNO._.BID_AMOUNT_W.Name}>0"
                    && WIN_RESULT_ANNO._.BID_AMOUNT.IsNotNull() && WIN_RESULT_ANNO._.BID_AMOUNT != 0 &&
                    WIN_RESULT_ANNO._.BID_AMOUNT_W <= 300000
                    && SECTION._.CONTRACT_RECKON_PRICE.IsNotNull() && SECTION._.CONTRACT_RECKON_PRICE != 0 &&
                    SECTION._.CONTRACT_RECKON_PRICE_W <= 300000
                    && TENDER_PROJECT._.TENDERER_CODE_TYPE.In(typeList));
                if (rootAreaCode == "3501")
                {
                    condition.And(V_BIG_ALLRESULT._.AREACODE != "350128");
                }
                if (string.IsNullOrWhiteSpace(search.AREACODE))
                {
                    search.AREACODE = JdUser?.UserDepartment?.AREACODE;
                }
                if (!string.IsNullOrWhiteSpace(search.TENDER_PROJECT_TYPE))
                {
                    if (search.TENDER_PROJECT_TYPE.Contains(","))
                    {
                        var projectTypes =
                            search.TENDER_PROJECT_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        condition.And(V_BIG_ALLRESULT._.PROJECT_TYPE.In(projectTypes));
                        jieYueCondition.And(TENDER_PROJECT._.TENDERER_CODE_TYPE.In(search.TENDER_PROJECT_TYPE));
                    }
                    else
                    {
                        condition.And(V_BIG_ALLRESULT._.PROJECT_TYPE == search.TENDER_PROJECT_TYPE);
                        jieYueCondition.And(TENDER_PROJECT._.TENDERER_CODE_TYPE == search.TENDER_PROJECT_TYPE);
                    }
                }


                if (search.BeginTime.HasValue)
                {
                    condition.And(V_BIG_ALLRESULT._.M_TM >= search.BeginTime);
                    jieYueCondition.And(SECTION._.M_TM >= search.BeginTime);
                }

                if (search.EndDateTime.HasValue)
                {
                    condition.And(V_BIG_ALLRESULT._.M_TM <= search.EndDateTime);
                    jieYueCondition.And(SECTION._.M_TM <= search.EndDateTime);
                }


                if (!string.IsNullOrWhiteSpace(search.AREACODE) && !search.AREACODE.Equals("350000"))
                {
                    condition.And(V_BIG_ALLRESULT._.AREACODE.SubQueryIn(
                        FromWhere<DSJ_AREA>(DSJ_AREA._.PCODE == search.AREACODE).Select(DSJ_AREA._.AREACODE)));
                    jieYueCondition.And(DSJ_AREA._.AREACODE.SubQueryIn(
                        FromWhere<DSJ_AREA>(DSJ_AREA._.PCODE == search.AREACODE).Select(DSJ_AREA._.AREACODE)));
                }

                summary = FromWhere<V_BIG_ALLRESULT>(condition.ToWhereClip())
                   .Select(V_BIG_ALLRESULT._.All.Count().As("TOTAL_COUNT"),
                       V_BIG_ALLRESULT._.AMOUNT.Sum()
                   ).ToFirst<DashboardTradeDataSummaryModel>();


                summary.JIEYUE_AMOUNT = Fw.SectionService.FromWhere(jieYueCondition.ToWhereClip())
                    .InnerJoin<WIN_RESULT_ANNO>(WIN_RESULT_ANNO._.BID_SECTION_CODE ==
                                                SECTION._.BID_SECTION_CODE)
                    .InnerJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE ==
                                               WIN_RESULT_ANNO._.TENDER_PROJECT_CODE )
                    .InnerJoin<DSJ_AREA>(DSJ_AREA._.OLDCODE == TENDER_PROJECT._.REGION_CODE)
                    .Select((SECTION._.CONTRACT_RECKON_PRICE_W - WIN_RESULT_ANNO._.BID_AMOUNT_W).Sum()
                        .As("JIEYUE_AMOUNT"))
                    .ToScalar<decimal>();
            }

            return summary;
        }

        #endregion

        #region 交易方式占比

        /// <summary>
        /// 交易方式占比
        /// </summary>
        /// <param name="search">AREACODE BeginTime EndTime</param>
        /// <returns></returns>
        public List<Infrastructure.Model.BigData.PieSeriesData> TradeMethod(EngineerSearchModel search)
        {//{value:"",name:""}
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode;//??"35";
            var typeList = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;//??new List<string>{ "A01", "A02", "A99-1", "A07", "A03-1", "A03-2", "A06", "A99-2" };
            var method = new List<Infrastructure.Model.BigData.PieSeriesData>();
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {
                var condition = new WhereClipBuilder(V_BIG_ALLRESULT._.TYPE == "工程建设" && V_BIG_ALLRESULT._.AREACODE.BeginWith(rootAreaCode) && V_BIG_ALLRESULT._.PROJECT_TYPE.In(typeList));
                if (rootAreaCode == "3501")
                {
                    condition.And(V_BIG_ALLRESULT._.AREACODE != "350128");
                }
                //if (string.IsNullOrWhiteSpace(search.AREACODE))
                //{
                //    search.AREACODE = JdUser?.UserDepartment?.AREACODE;
                //}
                if (!string.IsNullOrWhiteSpace(search.TENDER_PROJECT_TYPE))
                {
                    if (search.TENDER_PROJECT_TYPE.Contains(","))
                    {
                        var projectTypes =
                            search.TENDER_PROJECT_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        condition.And(V_BIG_ALLRESULT._.PROJECT_TYPE.In(projectTypes));
                    }
                    else
                    {
                        condition.And(V_BIG_ALLRESULT._.PROJECT_TYPE == search.TENDER_PROJECT_TYPE);
                    }
                }
                if (search.BeginTime.HasValue)
                {
                    condition.And(V_BIG_ALLRESULT._.M_TM >= search.BeginTime);
                }

                if (search.EndDateTime.HasValue)
                {
                    condition.And(V_BIG_ALLRESULT._.M_TM <= search.EndDateTime);
                }


                if (!string.IsNullOrWhiteSpace(search.AREACODE) && !search.AREACODE.Equals("350000"))
                {
                    condition.And(V_BIG_ALLRESULT._.AREACODE.SubQueryIn(FromWhere<DSJ_AREA>(DSJ_AREA._.PCODE == search.AREACODE).Select(DSJ_AREA._.AREACODE)));
                }

                method = Fw.SysDicService.FromWhere(SYS_DIC._.TYPE == "1000")
                    .LeftJoin<V_BIG_ALLRESULT>(SYS_DIC._.VALUE == V_BIG_ALLRESULT._.TENDER_MODE && condition.ToWhereClip())
                    .GroupBy(SYS_DIC._.TEXT)
                    .Select(SYS_DIC._.TEXT.As("Name"),
                        V_BIG_ALLRESULT._.TENDER_MODE.Count().As("Value"))
                    .ToList<Infrastructure.Model.BigData.PieSeriesData>();
            }
            return method;
        }

        #endregion

        #region 交易类型分布

        /// <summary>
        /// 交易类型分布
        /// </summary>
        /// <param name="search">AREACODE BeginTime EndTime</param>
        /// <returns></returns>
        public object TradeType(EngineerSearchModel search)
        {//{value:"",name:""}
            var xAxis = new List<string>();
            var barData = new List<decimal?>();
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode;//??"35";
            var typeList = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;//??new List<string>{ "A01", "A02", "A99-1", "A07", "A03-1", "A03-2", "A06", "A99-2" };
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {
                var condition = new WhereClipBuilder(V_BIG_ALLRESULT._.TYPE == "工程建设" && V_BIG_ALLRESULT._.AREACODE.BeginWith(rootAreaCode) && V_BIG_ALLRESULT._.PROJECT_TYPE.In(typeList));
                if (rootAreaCode == "3501")
                {
                    condition.And(V_BIG_ALLRESULT._.AREACODE != "350128");
                }
                //if (string.IsNullOrWhiteSpace(search.AREACODE))
                //{
                //    search.AREACODE = JdUser?.UserDepartment?.AREACODE;
                //}
                if (!string.IsNullOrWhiteSpace(search.TENDER_PROJECT_TYPE))
                {
                    if (search.TENDER_PROJECT_TYPE.Contains(","))
                    {
                        var projectTypes =
                            search.TENDER_PROJECT_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        condition.And(V_BIG_ALLRESULT._.PROJECT_TYPE.In(projectTypes));
                    }
                    else
                    {
                        condition.And(V_BIG_ALLRESULT._.PROJECT_TYPE == search.TENDER_PROJECT_TYPE);
                    }
                }
                if (search.BeginTime.HasValue)
                {
                    condition.And(V_BIG_ALLRESULT._.M_TM >= search.BeginTime);
                }

                if (search.EndDateTime.HasValue)
                {
                    condition.And(V_BIG_ALLRESULT._.M_TM <= search.EndDateTime);
                }


                if (!string.IsNullOrWhiteSpace(search.AREACODE) && !search.AREACODE.Equals("350000"))
                {
                    condition.And(V_BIG_ALLRESULT._.AREACODE.SubQueryIn(FromWhere<DSJ_AREA>(DSJ_AREA._.PCODE == search.AREACODE).Select(DSJ_AREA._.AREACODE)));
                }
                var data = Fw.SysDicService.FromWhere(SYS_DIC._.TYPE == "2002" && SYS_DIC._.PID == "2525" && condition.ToWhereClip())
                    .LeftJoin<V_BIG_ALLRESULT>(SYS_DIC._.VALUE == V_BIG_ALLRESULT._.PROJECT_TYPE)
                    .GroupBy(SYS_DIC._.TEXT)
                    .Select(SYS_DIC._.TEXT.As("Name"),
                        V_BIG_ALLRESULT._.AMOUNT.Sum().As("Value"))
                    .ToList<Infrastructure.Model.BigData.PieSeriesData>();
                xAxis = data.Select(c => c.Name).ToList();
                barData = data.Select(c => c?.Value / 10000).ToList();
                if (!xAxis.Any())
                {
                    xAxis = new List<string> { "房屋建筑", "市政", "公路", "民航", "水运", "水利水电", "能源电力", "广电通信", "其他" };
                }
            }
            return new
            {
                xAxis ,
                barData 
            };
        }

        #endregion

        #region 节约额分布情况
        /// <summary>
        /// 节约额分布情况
        /// </summary>
        /// <param name="search">AREACODE BeginTime EndTime</param>
        /// <returns></returns>
        public object JieYueAmount(EngineerSearchModel search)
        {

            var xAixs = new List<string>();
            var lineData = new List<decimal?>();
            var data = new List<Infrastructure.Model.BigData.PieSeriesData>();
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode;//??"35";
            var typeList = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;//??new List<string>{ "A01", "A02", "A99-1", "A07", "A03-1", "A03-2", "A06", "A99-2" };
            if (search.BeginTime.HasValue && search.EndDateTime.HasValue&&!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {

                var jieYueCondition = new WhereClipBuilder($"{SECTION._.CONTRACT_RECKON_PRICE_W.Name} - {WIN_RESULT_ANNO._.BID_AMOUNT_W.Name}>0"
                                                           && WIN_RESULT_ANNO._.BID_AMOUNT.IsNotNull() && WIN_RESULT_ANNO._.BID_AMOUNT != 0 && WIN_RESULT_ANNO._.BID_AMOUNT_W <= 300000
                                                           && SECTION._.CONTRACT_RECKON_PRICE.IsNotNull() && SECTION._.CONTRACT_RECKON_PRICE != 0 && SECTION._.CONTRACT_RECKON_PRICE_W <= 300000&&TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(typeList));

                if (string.IsNullOrWhiteSpace(search.AREACODE))
                {
                    search.AREACODE = JdUser?.UserDepartment?.AREACODE;//??"350000";
                }
                if (!string.IsNullOrWhiteSpace(search.TENDER_PROJECT_TYPE))
                {
                    if (search.TENDER_PROJECT_TYPE.Contains(","))
                    {
                        var projectTypes =
                            search.TENDER_PROJECT_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        jieYueCondition.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(projectTypes));
                    }
                    else
                    {
                        jieYueCondition.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE == search.TENDER_PROJECT_TYPE);
                    }
                }
                jieYueCondition.And(SECTION._.M_TM >= search.BeginTime);

                jieYueCondition.And(SECTION._.M_TM <= search.EndDateTime);
                var format = "yyyy-MM";
                var dbFormat = "yyyy-mm";
                if (search.BeginTime.Value.Month == search.EndDateTime.Value.Month)
                {
                    format = "yyyy-MM-dd";
                    dbFormat = "yyyy-mm-dd";
                }
                if (!string.IsNullOrWhiteSpace(search.AREACODE) && !search.AREACODE.Equals("350000"))
                {
                    jieYueCondition.And(DSJ_AREA._.AREACODE.SubQueryIn(FromWhere<DSJ_AREA>(DSJ_AREA._.PCODE == search.AREACODE).Select(DSJ_AREA._.AREACODE)));
                }
                data = Fw.SectionService.FromWhere(jieYueCondition.ToWhereClip())
                   .InnerJoin<WIN_RESULT_ANNO>(WIN_RESULT_ANNO._.BID_SECTION_CODE ==
                                               SECTION._.BID_SECTION_CODE)
                   .InnerJoin<TENDER_PROJECT>(
                       TENDER_PROJECT._.TENDER_PROJECT_CODE == WIN_RESULT_ANNO._.TENDER_PROJECT_CODE)
                   .InnerJoin<DSJ_AREA>(DSJ_AREA._.OLDCODE == TENDER_PROJECT._.REGION_CODE)
                   .GroupBy(WIN_RESULT_ANNO._.M_TM.ToChar(dbFormat))
                   .OrderBy(WIN_RESULT_ANNO._.M_TM.ToChar(dbFormat).Asc)
                   .Select(
                       (SECTION._.CONTRACT_RECKON_PRICE_W - WIN_RESULT_ANNO._.BID_AMOUNT_W).Sum().As("Value")
                       , WIN_RESULT_ANNO._.M_TM.ToChar(dbFormat).As("Name"))
                   .ToList<Infrastructure.Model.BigData.PieSeriesData>();
                var begin = search.BeginTime.Value;
                while (begin <= search.EndDateTime)
                {
                    var d = begin.ToString(format);
                    xAixs.Add(d);
                    lineData.Add((data.FirstOrDefault(c => c.Name == d)?.Value / 10000)??0);
                    if (search.BeginTime.Value.Month == search.EndDateTime.Value.Month)
                    {
                        begin = begin.AddDays(1);
                    }
                    else
                    {
                        begin = begin.AddMonths(1);
                    }

                }

            }
            return new
            {
                data,
                xAixs,
                lineData
            };
        }

        #endregion
    }
}