using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Helper;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.BigData.Model;
using GGZY.Services.Infrastructure.Model.BigData;
using GGZYFW.DbEntity;

namespace GGZY.Services.BigData
{
    public class StatisticsSupervisionService : BaseServiceT<FwEntity>
    {
        #region 监察情况分析-监督点异常情况-上部统计

        public GeneralResult SupervisionCount(StatisticsSupervisionSearchModel search)
        {
            var r = new GeneralResult();
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode.TrimEnd('0');
            var typeList = JdUser?.UserDepartment?.TENDER_PROJECT_TYPES;
            Logger.Debug($"rootAreaCode:{rootAreaCode},typeList:{typeList}");
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {
                var projectTypes = string.Join("','", typeList);
                var where1 = new StringBuilder($" AND REGION_CODE LIKE '{rootAreaCode}%' AND TENDER_PROJECT_TYPE IN('{projectTypes}')");
                if (rootAreaCode == "3501")
                {
                    where1.Append($" and REGION_CODE !='350128'");
                }
                if (!string.IsNullOrWhiteSpace(search.RegionCode))
                {
                    where1.Append($" and REGION_CODE LIKE '{search.RegionCode.Substring(0, 4)}%'");
                }
                if (!string.IsNullOrWhiteSpace(search.TenderType))
                {
                    where1.Append($" and TENDER_PROJECT_TYPE = '{search.TenderType}'");
                }
                if (!DateTime.MinValue.Equals(search.BeginTime))
                {
                    where1.Append($" and CREATE_TIME >= to_date('{search.BeginTime:yyyy-MM-dd}','yyyy-mm-dd')");
                }
                if (!DateTime.MinValue.Equals(search.EndTime))
                {
                    where1.Append($" and CREATE_TIME < to_date('{search.EndTime.AddDays(1):yyyy-MM-dd}','yyyy-mm-dd')");
                }
                //计算监督项目总数
                var sql = $@"select count(*) from( select TENDER_PROJECT_CODE from  WARN_RESULT where  
tender_project_code in  (select tender_project_code from tender_project where 1=1 {where1})
)";
                int tenderProjectCount = FromSql(sql).ToScalar<int>();
                sql = $@"select count(*) from( select TENDER_PROJECT_CODE from  WARN_RESULT where  
tender_project_code in  (select tender_project_code from tender_project where 1=1 {where1}) and RESULT_STATUS = '3'
group by TENDER_PROJECT_CODE 
)";
                int exceptionProjectCount = FromSql(sql).ToScalar<int>();
                sql = $@"select count(*) from( select TENDER_PROJECT_CODE from  T_PROJECT_WARN where  
tender_project_code in  (select tender_project_code from tender_project where 1=1 {where1})
group by TENDER_PROJECT_CODE 
)";
                int earlyWarnCount = DbContext.Jd.FromSql(sql).ToScalar<int>();
                r.SetSuccess(new
                {
                    tenderProjectCount,
                    exceptionProjectCount,
                    earlyWarnCount
                });
            }
            else
            {
                r.SetSuccess(new
                {
                    tenderProjectCount = 0,
                    exceptionProjectCount = 0,
                    earlyWarnCount = 0
                });
            }
            return r;
        }
        #endregion

        #region 监察情况分析-监督点异常情况-监督点异常排行

        public GeneralResult SupervisionExceptionRank(StatisticsSupervisionSearchModel search)
        {
            var r = new GeneralResult();
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode.TrimEnd('0');
            var typeList = JdUser?.UserDepartment?.TENDER_PROJECT_TYPES;
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {
                var projectTypes = string.Join("','", typeList);
                var where1 = new StringBuilder($" AND REGION_CODE LIKE '{rootAreaCode}%' AND TENDER_PROJECT_TYPE IN('{projectTypes}')");
                if (rootAreaCode == "3501")
                {
                    where1.Append($" and REGION_CODE !='350128'");
                }

                if (!string.IsNullOrWhiteSpace(search.RegionCode))
                {
                    where1.Append($" and REGION_CODE LIKE '{search.RegionCode.Substring(0, 4)}%'");
                }
                if (!string.IsNullOrWhiteSpace(search.TenderType))
                {
                    where1.Append($" and TENDER_PROJECT_TYPE = '{search.TenderType}'");
                }
                if (!DateTime.MinValue.Equals(search.BeginTime))
                {
                    where1.Append($" and CREATE_TIME >= to_date('{search.BeginTime:yyyy-MM-dd}','yyyy-mm-dd')");
                }
                if (!DateTime.MinValue.Equals(search.EndTime))
                {
                    where1.Append($" and CREATE_TIME < to_date('{search.EndTime.AddDays(1):yyyy-MM-dd}','yyyy-mm-dd')");
                }
                //计算异常排行
                var sql = $@"select * from (
select a.cou 异常项目数,b.sp_name 监督点名称 from (
select sp_id,count(1) cou from warn_result where RESULT_STATUS = '3' and TENDER_PROJECT_CODE IN (SELECT TENDER_PROJECT_CODE FROM TENDER_PROJECT WHERE 1=1 {where1})
group by sp_id
) a inner join warn_expression b on a.sp_id = b.m_id
order by cou desc
) where rownum <= 10";
                var dt = FromSql(sql).ToDataTable();
                r.SetSuccess(dt);
            }
            else
            {
                r.SetSuccess(new List<object>());
            }
            return r;
        }
        #endregion

        #region 监察情况分析-监督点异常情况-时间分析

        public GeneralResult SupervisionTimeAnalyze(StatisticsSupervisionSearchModel search)
        {
            var r = new GeneralResult();


            DateTime now = DateTime.Now;
            DateTime thisBeginTime = new DateTime(now.Year, now.Month, 1);
            DateTime thisEndTime = new DateTime(now.AddMonths(1).Year, now.AddMonths(1).Month, 1);
            DateTime LastBeginTime = new DateTime(now.AddYears(-1).Year, now.AddYears(-1).Month, 1);
            DateTime LastEndTime = new DateTime(now.AddYears(-1).AddMonths(1).Year, now.AddYears(-1).AddMonths(1).Month, 1);
            switch (search.TimeType)
            {
                case "1":
                    break;
                case "2":
                    switch (now.Month)
                    {
                        case 0:
                        case 1:
                        case 2:
                            thisBeginTime = new DateTime(now.Year, 1, 1);
                            thisEndTime = new DateTime(now.Year, 4, 1);
                            LastBeginTime = new DateTime(now.AddYears(-1).Year, 9, 1);
                            LastEndTime = new DateTime(now.Year, 1, 1);
                            break;
                        case 3:
                        case 4:
                        case 5:
                            thisBeginTime = new DateTime(now.Year, 4, 1);
                            thisEndTime = new DateTime(now.Year, 7, 1);
                            LastBeginTime = new DateTime(now.Year, 1, 1);
                            LastEndTime = new DateTime(now.Year, 4, 1);
                            break;
                        case 6:
                        case 7:
                        case 8:
                            thisBeginTime = new DateTime(now.Year, 7, 1);
                            thisEndTime = new DateTime(now.Year, 10, 1);
                            LastBeginTime = new DateTime(now.Year, 4, 1);
                            LastEndTime = new DateTime(now.Year, 7, 1);
                            break;
                        case 9:
                        case 10:
                        case 11:
                            thisBeginTime = new DateTime(now.Year, 9, 1);
                            thisEndTime = new DateTime(now.AddYears(1).Year, 1, 1);
                            LastBeginTime = new DateTime(now.Year, 7, 1);
                            LastEndTime = new DateTime(now.Year, 10, 1);
                            break;
                    }
                    break;
                case "3":
                    thisBeginTime = new DateTime(now.Year, 1, 1);
                    thisEndTime = new DateTime(now.AddYears(1).Year, 1, 1);
                    LastBeginTime = new DateTime(now.AddYears(-1).Year, 1, 1);
                    LastEndTime = new DateTime(now.Year, 1, 1);
                    break;

            }
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode.TrimEnd('0');
            var typeList = JdUser?.UserDepartment?.TENDER_PROJECT_TYPES;
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {
                var projectTypes = string.Join("','", typeList);
                var where1 = new StringBuilder($" AND REGION_CODE LIKE '{rootAreaCode}%' AND TENDER_PROJECT_TYPE IN('{projectTypes}')");
                if (rootAreaCode == "3501")
                {
                    where1.Append($" and REGION_CODE !='350128'");
                }

                if (!string.IsNullOrWhiteSpace(search.RegionCode))
                {
                    where1.Append($" and REGION_CODE LIKE '{search.RegionCode.Substring(0, 4)}%'");
                }
                if (!string.IsNullOrWhiteSpace(search.TenderType))
                {
                    where1.Append($" and TENDER_PROJECT_TYPE = '{search.TenderType}'");
                }
                where1.Append($" and CREATE_TIME >= to_date('{thisBeginTime:yyyy-MM-dd}','yyyy-mm-dd')");
                where1.Append($" and CREATE_TIME < to_date('{thisEndTime:yyyy-MM-dd}','yyyy-mm-dd')");
                var where2 = new StringBuilder();
                if (!string.IsNullOrWhiteSpace(search.RegionCode))
                {
                    where2.Append($" and REGION_CODE LIKE '{search.RegionCode.Substring(0, 4)}%'");
                }
                if (!string.IsNullOrWhiteSpace(search.TenderType))
                {
                    where2.Append($" and TENDER_PROJECT_TYPE = '{search.TenderType}'");
                }
                where2.Append($" and CREATE_TIME >= to_date('{LastBeginTime:yyyy-MM-dd}','yyyy-mm-dd')");
                where2.Append($" and CREATE_TIME < to_date('{LastEndTime:yyyy-MM-dd}','yyyy-mm-dd')");

                //异常数量
                var sql = $@"select count(*) from warn_result where TENDER_PROJECT_CODE IN (SELECT TENDER_PROJECT_CODE FROM TENDER_PROJECT WHERE 1=1 {where1})";
                int thisYcCount = FromSql(sql).ToScalar<int>();
                sql = $@"select count(*) from warn_result where TENDER_PROJECT_CODE IN (SELECT TENDER_PROJECT_CODE FROM TENDER_PROJECT WHERE 1=1 {where2})";
                int lastYcCount = FromSql(sql).ToScalar<int>();

                //发出预警数量
                sql = $@"select count(*) from t_project_warn where TENDER_PROJECT_CODE IN (SELECT TENDER_PROJECT_CODE FROM TENDER_PROJECT WHERE 1=1 {where1})";
                int thisYjCount = DbContext.Jd.FromSql(sql).ToScalar<int>();
                sql = $@"select count(*) from t_project_warn where TENDER_PROJECT_CODE IN (SELECT TENDER_PROJECT_CODE FROM TENDER_PROJECT WHERE 1=1 {where2})";
                int lastYjCount = DbContext.Jd.FromSql(sql).ToScalar<int>();
                //异常未预警数量
                int thisYcwyjCount = thisYcCount - thisYjCount;
                int lastYcwyjCount = lastYcCount - lastYjCount;

                //发出预警已反馈数 
                //todo:反馈数目前无法统计使用0代替
                int thisFkCount = 0;
                int lastFkCount = 0;
                //发出预警未反馈数
                int thisYjwfkCount = thisYjCount - thisFkCount;
                int lastYjwfkCount = lastYjCount - lastFkCount;
                //组装数据
                var result = new
                {
                    thisdata = new List<int>() { thisYcCount, thisYcwyjCount, thisYjCount, thisFkCount, thisYjwfkCount },
                    lastdata = new List<int>() { lastYcCount, lastYcwyjCount, lastYjCount, lastFkCount, lastYjwfkCount }
                };

                r.SetSuccess(result);
            }
            else
            {
                r.SetSuccess(new
                {
                    thisdata = new List<int>() { 0, 0, 0, 0, 0 },
                    lastdata = new List<int>() { 0, 0, 0, 0, 0 }
                });
            }
            return r;
        }
        #endregion

        #region 监察情况分析-监督点异常情况-底部四个饼图

        public GeneralResult SupervisionPie(StatisticsSupervisionSearchModel search)
        {
            var r = new GeneralResult();
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode.TrimEnd('0');
            var typeList = JdUser?.UserDepartment?.TENDER_PROJECT_TYPES;
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {
                var projectTypes = string.Join("','", typeList);
                var where1 = new StringBuilder($" AND a.REGION_CODE LIKE '{rootAreaCode}%' AND a.TENDER_PROJECT_TYPE IN('{projectTypes}')");
                if (rootAreaCode == "3501")
                {
                    where1.Append($" and a.REGION_CODE !='350128'");
                }

                if (!string.IsNullOrWhiteSpace(search.RegionCode))
                {
                    where1.Append($" and a.REGION_CODE LIKE '{search.RegionCode.Substring(0, 4)}%'");
                }
                if (!string.IsNullOrWhiteSpace(search.TenderType))
                {
                    where1.Append($" and a.TENDER_PROJECT_TYPE = '{search.TenderType}'");
                }
                if (!DateTime.MinValue.Equals(search.BeginTime))
                {
                    where1.Append($" and A.CREATE_TIME >= to_date('{search.BeginTime:yyyy-MM-dd}','yyyy-mm-dd')");
                }
                if (!DateTime.MinValue.Equals(search.EndTime))
                {
                    where1.Append($" and A.CREATE_TIME < to_date('{search.EndTime.AddDays(1):yyyy-MM-dd}','yyyy-mm-dd')");
                }
                //计算异常排行
                var sql = $@"select a.tender_project_code,a.tender_mode,substr(b.tender_project_classify_code,0,3) tender_class,a.tender_organize_form,(select count(*) from  QUALI_INQUERY_CLARI where tender_project_code = a.tender_project_code) ysCount from tender_project a 
 left join section b on b.tender_project_code  = a.tender_project_code
 where a.tender_project_code in 
(select tender_project_code from warn_result)
 {where1}";
                var ls = FromSql(sql).ToList<PieTenderProjectModel>();
                //统计招标方式
                var data1 = new List<object>()
            {
                new {name = "公开招标",value = ls.Count(e=>e.TENDER_MODE == "1") },
                new {name = "邀请招标",value = ls.Count(e=>e.TENDER_MODE == "2") },
                new {name = "其他",value = ls.Count(e=>e.TENDER_MODE != "2" && e.TENDER_MODE !="1") }
            };
                //统计标包类型
                var data2 = new List<object>()
            {
                new {name = "施工",value = ls.Count(e=>e.TENDER_CLASS == "A08") },
                new {name = "监理",value = ls.Count(e=>e.TENDER_CLASS == "A05") },
                new {name = "勘察",value = ls.Count(e=>e.TENDER_CLASS == "A03") },
                new {name = "设计",value = ls.Count(e=>e.TENDER_CLASS == "A04") },
                new {name = "其他",value = ls.Count(e=>e.TENDER_CLASS!=null &&!"A03,A04,A05,A08".Contains(e.TENDER_CLASS))},
            };
                //统计资格预审
                var data3 = new List<object>()
            {
                new {name = "资格预审",value = ls.Count(e=>e.YSCOUNT>0) },
                new {name = "资格后审",value = ls.Count(e=>e.YSCOUNT<=0) },
            };
                //统计招标组织形式
                var data4 = new List<object>()
            {
                new {name = "自行招标",value = ls.Count(e=>e.TENDER_ORGANIZE_FORM == "1") },
                new {name = "委托招标",value = ls.Count(e=>e.TENDER_ORGANIZE_FORM == "2")},
                new {name = "其他",value = ls.Count(e=>e.TENDER_ORGANIZE_FORM != "2" && e.TENDER_ORGANIZE_FORM !="1")},
            };
                var result = new
                {
                    data1,
                    data2,
                    data3,
                    data4
                };
                r.SetSuccess(result);
            }
            else
            {
                r.SetSuccess(new
                {
                    data1 = new List<object>{
                        new {name = "公开招标",value = 0 },
                        new {name = "邀请招标",value = 0 },
                        new {name = "其他",value = 0}
                    },
                    data2 = new List<object>{
                        new {name = "施工",value = 0},
                        new {name = "监理",value = 0},
                        new {name = "勘察",value = 0},
                        new {name = "设计",value = 0},
                        new {name = "其他",value = 0},
                    },
                    data3 = new List<object>{
                        new {name = "资格预审",value = 0},
                        new {name = "资格后审",value = 0 },
                    },
                    data4 = new List<object>{
                        new {name = "自行招标",value = 0 },
                        new { name = "委托招标", value = 0},
                        new { name = "其他", value = 0 },
                    }
                });
            }
            return r;
        }
        #endregion

        #region 监察情况分析-疑是违规点情况-上部统计

        public GeneralResult SuspectCount(StatisticsSupervisionSearchModel search)
        {
            var r = new GeneralResult();
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode.TrimEnd('0');
            var typeList = JdUser?.UserDepartment?.TENDER_PROJECT_TYPES;
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {
                var projectTypes = string.Join("','", typeList);
                var where1 = new StringBuilder($" AND REGION_CODE LIKE '{rootAreaCode}%' AND TENDER_PROJECT_TYPE IN('{projectTypes}')");
                if (rootAreaCode == "3501")
                {
                    where1.Append($" and REGION_CODE !='350128'");
                }

                if (!string.IsNullOrWhiteSpace(search.RegionCode))
                {
                    where1.Append($" and REGION_CODE LIKE '{search.RegionCode.Substring(0, 4)}%'");
                }
                if (!string.IsNullOrWhiteSpace(search.TenderType))
                {
                    where1.Append($" and TENDER_PROJECT_TYPE = '{search.TenderType}'");
                }
                if (!DateTime.MinValue.Equals(search.BeginTime))
                {
                    where1.Append($" and CREATE_TIME >= to_date('{search.BeginTime:yyyy-MM-dd}','yyyy-mm-dd')");
                }
                if (!DateTime.MinValue.Equals(search.EndTime))
                {
                    where1.Append($" and CREATE_TIME < to_date('{search.EndTime.AddDays(1):yyyy-MM-dd}','yyyy-mm-dd')");
                }
                //项目数
                var sql = $@"
                select count(*) COU from TENDER_PROJECT where 1=1 {where1}";
                int tenderProjectCount = FromSql(sql).ToScalar<int>();
                //疑似违规项目
                sql = $@"select count(*) from( select TENDER_PROJECT_CODE from  bd_violation_record where  
tender_project_code in  (select tender_project_code from tender_project where 1=1 {where1})  
group by TENDER_PROJECT_CODE 
)";
                //记录调查总数
                int exceptionProjectCount = FromSql(sql).ToScalar<int>();
                sql = $@"select count(*) from( select TENDER_PROJECT_CODE from  bd_violation_record where  
tender_project_code in  (select tender_project_code from tender_project where 1=1 {where1}) and STATE = '1' 
group by TENDER_PROJECT_CODE 
)";
                int surveyCount = FromSql(sql).ToScalar<int>();
                r.SetSuccess(new
                {
                    tenderProjectCount,
                    exceptionProjectCount,
                    surveyCount
                });
            }
            else
            {
                r.SetSuccess(new
                {
                    tenderProjectCount = 0,
                    exceptionProjectCount = 0,
                    surveyCount = 0
                });
            }
            return r;
        }
        #endregion

        #region 监察情况分析-疑似违规点情况-疑似违规点排行

        public GeneralResult SuspectRank(StatisticsSupervisionSearchModel search)
        {
            var r = new GeneralResult();
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode.TrimEnd('0');
            var typeList = JdUser?.UserDepartment?.TENDER_PROJECT_TYPES;
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {
                var projectTypes = string.Join("','", typeList);
                var where1 = new StringBuilder($" AND REGION_CODE LIKE '{rootAreaCode}%' AND TENDER_PROJECT_TYPE IN('{projectTypes}')");
                if (rootAreaCode == "3501")
                {
                    where1.Append($" and REGION_CODE !='350128'");
                }

                if (!string.IsNullOrWhiteSpace(search.RegionCode))
                {
                    where1.Append($" and REGION_CODE LIKE '{search.RegionCode.Substring(0, 4)}%'");
                }
                if (!string.IsNullOrWhiteSpace(search.TenderType))
                {
                    where1.Append($" and TENDER_PROJECT_TYPE = '{search.TenderType}'");
                }
                if (!DateTime.MinValue.Equals(search.BeginTime))
                {
                    where1.Append($" and CREATE_TIME >= to_date('{search.BeginTime:yyyy-MM-dd}','yyyy-mm-dd')");
                }
                if (!DateTime.MinValue.Equals(search.EndTime))
                {
                    where1.Append($" and CREATE_TIME < to_date('{search.EndTime.AddDays(1):yyyy-MM-dd}','yyyy-mm-dd')");
                }
                //计算异常排行
                var sql = $@"select * from (
select a.cou 疑似违规项目数,b.CATEGORY_NAME 疑似违规点名 from (
select POINT_ID,count(1) cou from bd_violation_record where  TENDER_PROJECT_CODE IN (SELECT TENDER_PROJECT_CODE FROM TENDER_PROJECT WHERE 1=1 {where1})
group by POINT_ID
) a inner join bd_violation_point b on a.POINT_ID = b.id
order by cou desc
) where rownum <= 10";
                var dt = FromSql(sql).ToDataTable();
                r.SetSuccess(dt);
            }
            else
            {
                r.SetSuccess(new List<object>());
            }
            return r;
        }
        #endregion

        #region 监察情况分析-疑似违规点情况-时间分析

        public GeneralResult SuspectTimeAnalyze(StatisticsSupervisionSearchModel search)
        {
            var r = new GeneralResult();


            DateTime now = DateTime.Now;
            DateTime thisBeginTime = new DateTime(now.Year, now.Month, 1);
            DateTime thisEndTime = new DateTime(now.AddMonths(1).Year, now.AddMonths(1).Month, 1);
            DateTime LastBeginTime = new DateTime(now.AddYears(-1).Year, now.AddYears(-1).Month, 1);
            DateTime LastEndTime = new DateTime(now.AddYears(-1).AddMonths(1).Year, now.AddYears(-1).AddMonths(1).Month, 1);
            switch (search.TimeType)
            {
                case "1":
                    break;
                case "2":
                    switch (now.Month)
                    {
                        case 0:
                        case 1:
                        case 2:
                            thisBeginTime = new DateTime(now.Year, 1, 1);
                            thisEndTime = new DateTime(now.Year, 4, 1);
                            LastBeginTime = new DateTime(now.AddYears(-1).Year, 9, 1);
                            LastEndTime = new DateTime(now.Year, 1, 1);
                            break;
                        case 3:
                        case 4:
                        case 5:
                            thisBeginTime = new DateTime(now.Year, 4, 1);
                            thisEndTime = new DateTime(now.Year, 7, 1);
                            LastBeginTime = new DateTime(now.Year, 1, 1);
                            LastEndTime = new DateTime(now.Year, 4, 1);
                            break;
                        case 6:
                        case 7:
                        case 8:
                            thisBeginTime = new DateTime(now.Year, 7, 1);
                            thisEndTime = new DateTime(now.Year, 10, 1);
                            LastBeginTime = new DateTime(now.Year, 4, 1);
                            LastEndTime = new DateTime(now.Year, 7, 1);
                            break;
                        case 9:
                        case 10:
                        case 11:
                            thisBeginTime = new DateTime(now.Year, 9, 1);
                            thisEndTime = new DateTime(now.AddYears(1).Year, 1, 1);
                            LastBeginTime = new DateTime(now.Year, 7, 1);
                            LastEndTime = new DateTime(now.Year, 10, 1);
                            break;
                    }
                    break;
                case "3":
                    thisBeginTime = new DateTime(now.Year, 1, 1);
                    thisEndTime = new DateTime(now.AddYears(1).Year, 1, 1);
                    LastBeginTime = new DateTime(now.AddYears(-1).Year, 1, 1);
                    LastEndTime = new DateTime(now.Year, 1, 1);
                    break;

            }
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode.TrimEnd('0');
            var typeList = JdUser?.UserDepartment?.TENDER_PROJECT_TYPES;
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {
                var projectTypes = string.Join("','", typeList);
                var where1 = new StringBuilder($" AND REGION_CODE LIKE '{rootAreaCode}%' AND TENDER_PROJECT_TYPE IN('{projectTypes}')");
                if (rootAreaCode == "3501")
                {
                    where1.Append($" and REGION_CODE !='350128'");
                }

                if (!string.IsNullOrWhiteSpace(search.RegionCode))
                {
                    where1.Append($" and REGION_CODE LIKE '{search.RegionCode.Substring(0, 4)}%'");
                }
                if (!string.IsNullOrWhiteSpace(search.TenderType))
                {
                    where1.Append($" and TENDER_PROJECT_TYPE = '{search.TenderType}'");
                }
                where1.Append($" and CREATE_TIME >= to_date('{thisBeginTime:yyyy-MM-dd}','yyyy-mm-dd')");
                where1.Append($" and CREATE_TIME < to_date('{thisEndTime:yyyy-MM-dd}','yyyy-mm-dd')");

                var where2 = new StringBuilder();
                if (!string.IsNullOrWhiteSpace(search.RegionCode))
                {
                    where2.Append($" and REGION_CODE LIKE '{search.RegionCode.Substring(0, 4)}%'");
                }
                if (!string.IsNullOrWhiteSpace(search.TenderType))
                {
                    where2.Append($" and TENDER_PROJECT_TYPE = '{search.TenderType}'");
                }
                where2.Append($" and CREATE_TIME >= to_date('{thisBeginTime:yyyy-MM-dd}','yyyy-mm-dd')");
                where2.Append($" and CREATE_TIME < to_date('{thisEndTime:yyyy-MM-dd}','yyyy-mm-dd')");

                //疑似违规项目数
                var sql = $@"select count(*) from bd_violation_record where TENDER_PROJECT_CODE IN (SELECT TENDER_PROJECT_CODE FROM TENDER_PROJECT WHERE 1=1 {where1})";
                int thisYcCount = FromSql(sql).ToScalar<int>();
                sql = $@"select count(*) from bd_violation_record where TENDER_PROJECT_CODE IN (SELECT TENDER_PROJECT_CODE FROM TENDER_PROJECT WHERE 1=1 {where2})";
                int lastYcCount = FromSql(sql).ToScalar<int>();

                //记录调查结果数量
                sql = $@"select count(*) from bd_violation_record where STATE = '1' AND TENDER_PROJECT_CODE IN (SELECT TENDER_PROJECT_CODE FROM TENDER_PROJECT WHERE 1=1 {where1})";
                int thisDcCount = FromSql(sql).ToScalar<int>();
                sql = $@"select count(*) from bd_violation_record where STATE = '1' AND TENDER_PROJECT_CODE IN (SELECT TENDER_PROJECT_CODE FROM TENDER_PROJECT WHERE 1=1 {where2})";
                int lastDcCount = FromSql(sql).ToScalar<int>();

                //组装数据
                var result = new
                {
                    thisdata = new List<int>() { thisYcCount, thisDcCount },
                    lastdata = new List<int>() { lastYcCount, lastDcCount }
                };

                r.SetSuccess(result);
            }
            else
            {
                r.SetSuccess(new
                {
                    thisdata = new List<int>() { 0, 0 },
                    lastdata = new List<int>() { 0, 0 }
                });
            }
            return r;
        }
        #endregion

        #region 监察情况分析-疑似违规点情况-底部四个饼图

        public GeneralResult SuspectPie(StatisticsSupervisionSearchModel search)
        {
            var r = new GeneralResult();
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode.TrimEnd('0');
            var typeList = JdUser?.UserDepartment?.TENDER_PROJECT_TYPES;
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {
                var projectTypes = string.Join("','", typeList);
                var where1 = new StringBuilder($" AND a.REGION_CODE LIKE '{rootAreaCode}%' AND a.TENDER_PROJECT_TYPE IN('{projectTypes}')");
                if (rootAreaCode == "3501")
                {
                    where1.Append($" and a.REGION_CODE !='350128'");
                }

                if (!string.IsNullOrWhiteSpace(search.RegionCode))
                {
                    where1.Append($" and a.REGION_CODE LIKE '{search.RegionCode.Substring(0, 4)}%'");
                }
                if (!string.IsNullOrWhiteSpace(search.TenderType))
                {
                    where1.Append($" and a.TENDER_PROJECT_TYPE = '{search.TenderType}'");
                }
                if (!DateTime.MinValue.Equals(search.BeginTime))
                {
                    where1.Append($" and a.CREATE_TIME >= to_date('{search.BeginTime:yyyy-MM-dd}','yyyy-mm-dd')");
                }
                if (!DateTime.MinValue.Equals(search.EndTime))
                {
                    where1.Append($" and a.CREATE_TIME < to_date('{search.EndTime.AddDays(1):yyyy-MM-dd}','yyyy-mm-dd')");
                }
                //计算异常排行
                var sql = $@"select a.tender_project_code,a.tender_mode,substr(b.tender_project_classify_code,0,3) tender_class,a.tender_organize_form,(select count(*) from  QUALI_INQUERY_CLARI where tender_project_code = a.tender_project_code) ysCount from tender_project a 
 left join section b on b.tender_project_code  = a.tender_project_code
 where a.tender_project_code in 
(select tender_project_code from bd_violation_record)
 {where1}";
                var ls = FromSql(sql).ToList<PieTenderProjectModel>();
                //统计招标方式
                var data1 = new List<object>()
            {
                new {name = "公开招标",value = ls.Count(e=>e.TENDER_MODE == "1") },
                new {name = "邀请招标",value = ls.Count(e=>e.TENDER_MODE == "2") },
                new {name = "其他",value = ls.Count(e=>e.TENDER_MODE != "2" && e.TENDER_MODE !="1") }
            };
                //统计标包类型
                var data2 = new List<object>()
            {
                new {name = "施工",value = ls.Count(e=>e.TENDER_CLASS == "A08") },
                new {name = "监理",value = ls.Count(e=>e.TENDER_CLASS == "A05") },
                new {name = "勘察",value = ls.Count(e=>e.TENDER_CLASS == "A03") },
                new {name = "设计",value = ls.Count(e=>e.TENDER_CLASS == "A04") },
                new {name = "其他",value = ls.Count(e=>e.TENDER_CLASS!=null && !"A03,A04,A05,A08".Contains(e.TENDER_CLASS))},
            };
                //统计资格预审
                var data3 = new List<object>()
            {
                new {name = "资格预审",value = ls.Count(e=>e.YSCOUNT>0) },
                new {name = "资格后审",value = ls.Count(e=>e.YSCOUNT<=0) },
            };
                //统计招标组织形式
                var data4 = new List<object>()
            {
                new {name = "自行招标",value = ls.Count(e=>e.TENDER_ORGANIZE_FORM == "1") },
                new {name = "委托招标",value = ls.Count(e=>e.TENDER_ORGANIZE_FORM == "2")},
                new {name = "其他",value = ls.Count(e=>e.TENDER_ORGANIZE_FORM != "2" && e.TENDER_ORGANIZE_FORM !="1")},
            };
                var result = new
                {
                    data1,
                    data2,
                    data3,
                    data4
                };
                r.SetSuccess(result);
            }
            else
            {
                r.SetSuccess(new
                {
                    data1 = new List<object>()
                    {
                        new {name = "公开招标",value = 0 },
                        new {name = "邀请招标",value = 0 },
                        new {name = "其他",value = 0 }
                    },
                    data2 = new List<object>()
                    {
                        new {name = "施工",value = 0 },
                        new {name = "监理",value = 0 },
                        new {name = "勘察",value = 0 },
                        new {name = "设计",value = 0 },
                        new {name = "其他",value = 0},
                    },
                    data3 = new List<object>()
                    {
                        new {name = "资格预审",value =0},
                        new {name = "资格后审",value =0 },
                    },
                    data4 = new List<object>()
                    {
                        new {name = "自行招标",value = 0 },
                        new {name = "委托招标",value = 0},
                        new {name = "其他",value = 0},
                    }
                });
            }
            return r;
        }
        #endregion

        #region 监察情况分析-行业监督部门情况-上部统计

        public GeneralResult DepartmentCount()
        {
            var r = new GeneralResult();

            //项目数
            var sql = "select count(*) COU from t_user_department";
            int departmentCount = DbContext.Jd.FromSql(sql).ToScalar<int>();
            r.SetSuccess(new
            {
                departmentCount
            });
            return r;
        }
        #endregion

        #region 监察情况分析-行业监督部门情况-参与监督项目数排行

        public GeneralResult DepartmentCyjdxmsRank(StatisticsSupervisionSearchModel search)
        {
            var r = new GeneralResult();
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode.TrimEnd('0');
            var typeList = JdUser?.UserDepartment?.TENDER_PROJECT_TYPES;
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {
                var projectTypes = string.Join("','", typeList);
                var where1 = new StringBuilder($" AND REGION_CODE LIKE '{rootAreaCode}%' AND TENDER_PROJECT_TYPE IN('{projectTypes}')");
                if (rootAreaCode == "3501")
                {
                    where1.Append($" and REGION_CODE !='350128'");
                }

                if (!string.IsNullOrWhiteSpace(search.RegionCode))
                {
                    where1.Append($" and REGION_CODE LIKE '{search.RegionCode.Substring(0, 4)}%'");
                }
                if (!string.IsNullOrWhiteSpace(search.TenderType))
                {
                    where1.Append($" and TENDER_PROJECT_TYPE = '{search.TenderType}'");
                }
                if (!DateTime.MinValue.Equals(search.BeginTime))
                {
                    where1.Append($" and CREATE_TIME >= to_date('{search.BeginTime:yyyy-MM-dd}','yyyy-mm-dd')");
                }
                if (!DateTime.MinValue.Equals(search.EndTime))
                {
                    where1.Append($" and CREATE_TIME < to_date('{search.EndTime.AddDays(1):yyyy-MM-dd}','yyyy-mm-dd')");
                }
                //计算异常排行
                var sql = $@"select * from (
select RECORD_DEPID,dname,count(1) cou from  (
select a.tender_project_code,c.RECORD_DEPID,b.dname from (select tender_project_code from warn_result where  TENDER_PROJECT_CODE IN (SELECT TENDER_PROJECT_CODE FROM TENDER_PROJECT WHERE 1=1 {where1}) group by tender_project_code) a
left join tender_project@ggzyjd c on c.tender_project_code_old1 = a.tender_project_code
left join t_user_department@ggzyjd b on b.depid = c.RECORD_DEPID
where dname is not null
)
group by dname,RECORD_DEPID
order by cou desc)
where rownum <= 10";
                var dt = FromSql(sql).ToDataTable();
                r.SetSuccess(dt);
            }
            else
            {
                r.SetSuccess(new List<object>());
            }
            return r;
        }
        #endregion

        #region 监察情况分析-行业监督部门情况-异常项目数排行

        public GeneralResult DepartmentYcxmsRank(StatisticsSupervisionSearchModel search)
        {
            var r = new GeneralResult();
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode.TrimEnd('0');
            var typeList = JdUser?.UserDepartment?.TENDER_PROJECT_TYPES;
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {
                var projectTypes = string.Join("','", typeList);
                var where1 = new StringBuilder($" AND REGION_CODE LIKE '{rootAreaCode}%' AND TENDER_PROJECT_TYPE IN('{projectTypes}')");
                if (rootAreaCode == "3501")
                {
                    where1.Append($" and REGION_CODE !='350128'");
                }

                if (!string.IsNullOrWhiteSpace(search.RegionCode))
                {
                    where1.Append($" and REGION_CODE LIKE '{search.RegionCode.Substring(0, 4)}%'");
                }
                if (!string.IsNullOrWhiteSpace(search.TenderType))
                {
                    where1.Append($" and TENDER_PROJECT_TYPE = '{search.TenderType}'");
                }
                if (!DateTime.MinValue.Equals(search.BeginTime))
                {
                    where1.Append($" and CREATE_TIME >= to_date('{search.BeginTime:yyyy-MM-dd}','yyyy-mm-dd')");
                }
                if (!DateTime.MinValue.Equals(search.EndTime))
                {
                    where1.Append($" and CREATE_TIME < to_date('{search.EndTime.AddDays(1):yyyy-MM-dd}','yyyy-mm-dd')");
                }
                where1.Append($" and RESULT_STATUS ='3' ");
                //计算异常排行
                var sql = $@"select * from (
select RECORD_DEPID,dname,count(1) cou from  (
select a.tender_project_code,c.RECORD_DEPID,b.dname from (select tender_project_code from warn_result where TENDER_PROJECT_CODE IN (SELECT TENDER_PROJECT_CODE FROM TENDER_PROJECT WHERE 1=1 {where1}) group by tender_project_code) a
left join tender_project@ggzyjd c on c.tender_project_code_old1 = a.tender_project_code
left join t_user_department@ggzyjd b on b.depid = c.RECORD_DEPID
where dname is not null
)
group by dname,RECORD_DEPID
order by cou desc)
where rownum <= 10";
                var dt = FromSql(sql).ToDataTable();
                r.SetSuccess(dt);
            }
            else
            {
                r.SetSuccess(new List<object>());
            }
            return r;
        }
        #endregion

        #region 监察情况分析-行业监督部门情况-发出预警数排行

        public GeneralResult DepartmentFcyjsRank(StatisticsSupervisionSearchModel search)
        {
            var r = new GeneralResult();
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode.TrimEnd('0');
            var typeList = JdUser?.UserDepartment?.TENDER_PROJECT_TYPES;
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {
                var projectTypes = string.Join("','", typeList);
                var where1 = new StringBuilder($" AND c.REGION_CODE LIKE '{rootAreaCode}%' AND c.TENDER_PROJECT_TYPE IN('{projectTypes}')");
                if (rootAreaCode == "3501")
                {
                    where1.Append($" and c.REGION_CODE !='350128'");
                }

                if (!string.IsNullOrWhiteSpace(search.RegionCode))
                {
                    where1.Append($" and c.REGION_CODE LIKE '{search.RegionCode.Substring(0, 4)}%'");
                }
                if (!string.IsNullOrWhiteSpace(search.TenderType))
                {
                    where1.Append($" and c.TENDER_PROJECT_TYPE = '{search.TenderType}'");
                }
                if (!DateTime.MinValue.Equals(search.BeginTime))
                {
                    where1.Append($" and c.CREATE_TIME >= to_date('{search.BeginTime:yyyy-MM-dd}','yyyy-mm-dd')");
                }
                if (!DateTime.MinValue.Equals(search.EndTime))
                {
                    where1.Append($" and c.CREATE_TIME < to_date('{search.EndTime.AddDays(1):yyyy-MM-dd}','yyyy-mm-dd')");
                }
                //计算异常排行
                var sql = $@"select * from (
select RECORD_DEPID,dname,count(1) cou from  (
select a.tender_project_code,c.RECORD_DEPID,b.dname from  t_project_warn  a
left join tender_project c on c.tender_project_code_old1 = a.tender_project_code
left join t_user_department b on b.depid = c.RECORD_DEPID
where dname is not null {where1}
)
group by dname,RECORD_DEPID
order by cou desc)
where rownum <= 10";
                var dt = DbContext.Jd.FromSql(sql).ToDataTable();
                r.SetSuccess(dt);
            }
            else
            {
                r.SetSuccess(new List<object>());
            }
            return r;
        }
        #endregion

        #region 监察情况分析-行业监督部门情况-预警项目比率排行

        public GeneralResult DepartmentYjxmblRank(StatisticsSupervisionSearchModel search)
        {
            var r = new GeneralResult();
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode.TrimEnd('0');
            var typeList = JdUser?.UserDepartment?.TENDER_PROJECT_TYPES;
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {
                var projectTypes = string.Join("','", typeList);
                var where1 = new StringBuilder($" AND c.REGION_CODE LIKE '{rootAreaCode}%' AND c.TENDER_PROJECT_TYPE IN('{projectTypes}')");
                if (rootAreaCode == "3501")
                {
                    where1.Append($" and c.REGION_CODE !='350128'");
                }

                if (!string.IsNullOrWhiteSpace(search.RegionCode))
                {
                    where1.Append($" and c.REGION_CODE LIKE '{search.RegionCode.Substring(0, 4)}%'");
                }
                if (!string.IsNullOrWhiteSpace(search.TenderType))
                {
                    where1.Append($" and c.TENDER_PROJECT_TYPE = '{search.TenderType}'");
                }
                if (!DateTime.MinValue.Equals(search.BeginTime))
                {
                    where1.Append($" and a.CREATE_TM >= to_date('{search.BeginTime:yyyy-MM-dd}','yyyy-mm-dd')");
                }
                if (!DateTime.MinValue.Equals(search.EndTime))
                {
                    where1.Append($" and a.CREATE_TM < to_date('{search.EndTime.AddDays(1):yyyy-MM-dd}','yyyy-mm-dd')");
                }
                var where2 = new StringBuilder();
                if (!string.IsNullOrWhiteSpace(search.RegionCode))
                {
                    where2.Append($" and REGION_CODE LIKE '{search.RegionCode.Substring(0, 4)}%'");
                }
                if (!string.IsNullOrWhiteSpace(search.TenderType))
                {
                    where2.Append($" and TENDER_PROJECT_TYPE = '{search.TenderType}'");
                }
                if (!DateTime.MinValue.Equals(search.BeginTime))
                {
                    where2.Append($" and LAST_RECORD_TIME >= to_date('{search.BeginTime:yyyy-MM-dd}','yyyy-mm-dd')");
                }
                if (!DateTime.MinValue.Equals(search.EndTime))
                {
                    where2.Append($" and LAST_RECORD_TIME < to_date('{search.EndTime.AddDays(1):yyyy-MM-dd}','yyyy-mm-dd')");
                }
                where2.Append($" and RESULT_STATUS ='3' ");
                //计算异常排行
                var sql = $@"select * from (

select case when x.dname is not null then x.dname else y.dname end dname,x.cou1,y.cou2,case when cou2 is not null and cou1 is not null then round(cou1/cou2,2) else 0 end bilv  from (
select RECORD_DEPID,dname,count(1) cou1 from  (
select a.tender_project_code,c.RECORD_DEPID,b.dname from  t_project_warn  a
left join tender_project c on c.tender_project_code_old1 = a.tender_project_code
left join t_user_department b on b.depid = c.RECORD_DEPID
where 1=1 {where1}
)
where dname is not null
group by dname,RECORD_DEPID
order by cou1 desc)  x

full join 

(
select RECORD_DEPID,dname,count(1) cou2 from  (
select a.tender_project_code,c.RECORD_DEPID,b.dname from  (select tender_project_code from warn_result@dzjypt where 1=1 {where2} group by tender_project_code)  a
left join tender_project c on c.tender_project_code_old1 = a.tender_project_code
left join t_user_department b on b.depid = c.RECORD_DEPID
) 
where dname is not null
group by dname,RECORD_DEPID
) y
on x.dname = y.dname
order by bilv desc
)
where rownum <=10";
                var dt = DbContext.Jd.FromSql(sql).ToDataTable();
                r.SetSuccess(dt);
            }
            else
            {
                r.SetSuccess(new List<object>());
            }
            return r;
        }
        #endregion

        #region 监察情况分析-行业监督部门情况-疑似违规点排行

        public GeneralResult DepartmentYswgdRank(StatisticsSupervisionSearchModel search)
        {
            var r = new GeneralResult();
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode.TrimEnd('0');
            var typeList = JdUser?.UserDepartment?.TENDER_PROJECT_TYPES;
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {
                var projectTypes = string.Join("','", typeList);
                var where1 = new StringBuilder($" AND AREA_CODE LIKE '{rootAreaCode}%' AND TENDER_PROJECT_TYPE IN('{projectTypes}')");
                if (rootAreaCode == "3501")
                {
                    where1.Append($" and AREA_CODE !='350128'");
                }

                if (!string.IsNullOrWhiteSpace(search.RegionCode))
                {
                    where1.Append($" and AREA_CODE LIKE '{search.RegionCode.Substring(0, 4)}%'");
                }
                if (!string.IsNullOrWhiteSpace(search.TenderType))
                {
                    where1.Append($" and TENDER_PROJECT_TYPE = '{search.TenderType}'");
                }
                if (!DateTime.MinValue.Equals(search.BeginTime))
                {
                    where1.Append($" and CREATE_TIME >= to_date('{search.BeginTime:yyyy-MM-dd}','yyyy-mm-dd')");
                }
                if (!DateTime.MinValue.Equals(search.EndTime))
                {
                    where1.Append($" and CREATE_TIME < to_date('{search.EndTime.AddDays(1):yyyy-MM-dd}','yyyy-mm-dd')");
                }
                //计算异常排行
                var sql = $@"select * from (
select dname,count(1) cou from  (
select a.tender_project_code,c.RECORD_DEPID,b.dname from (select tender_project_code from bd_violation_record where TENDER_PROJECT_CODE IN (SELECT TENDER_PROJECT_CODE FROM TENDER_PROJECT WHERE 1=1 {where1}) group by  tender_project_code) a
left join tender_project@ggzyjd c on c.tender_project_code_old1 = a.tender_project_code
left join t_user_department@ggzyjd b on b.depid = c.RECORD_DEPID
)
group by dname
order by cou desc)
where rownum <= 10";
                var dt = FromSql(sql).ToDataTable();
                r.SetSuccess(dt);
            }
            else
            {
                r.SetSuccess(new List<Object>());
            }
            return r;
        }
        #endregion

        #region 监察情况分析-行业监督部门情况-调查结果排行

        public GeneralResult DepartmentDcjgRank(StatisticsSupervisionSearchModel search)
        {
            var r = new GeneralResult();
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode.TrimEnd('0');
            var typeList = JdUser?.UserDepartment?.TENDER_PROJECT_TYPES;
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {
                var projectTypes = string.Join("','", typeList);
                var where1 = new StringBuilder($" AND REGION_CODE LIKE '{rootAreaCode}%' AND TENDER_PROJECT_TYPE IN('{projectTypes}')");
                if (rootAreaCode == "3501")
                {
                    where1.Append($" and REGION_CODE !='350128'");
                }

                if (!string.IsNullOrWhiteSpace(search.RegionCode))
                {
                    where1.Append($" and REGION_CODE LIKE '{search.RegionCode.Substring(0, 4)}%'");
                }
                if (!string.IsNullOrWhiteSpace(search.TenderType))
                {
                    where1.Append($" and TENDER_PROJECT_TYPE = '{search.TenderType}'");
                }
                if (!DateTime.MinValue.Equals(search.BeginTime))
                {
                    where1.Append($" and CREATE_TIME >= to_date('{search.BeginTime:yyyy-MM-dd}','yyyy-mm-dd')");
                }
                if (!DateTime.MinValue.Equals(search.EndTime))
                {
                    where1.Append($" and CREATE_TIME < to_date('{search.EndTime.AddDays(1):yyyy-MM-dd}','yyyy-mm-dd')");
                }
                //计算异常排行
                var sql = $@"select * from (
select dname,count(1) cou from  (
select a.tender_project_code,c.RECORD_DEPID,b.dname from  （select STATE,tender_project_code from bd_violation_record where TENDER_PROJECT_CODE IN (SELECT TENDER_PROJECT_CODE FROM TENDER_PROJECT WHERE 1=1 {where1})） a
left join tender_project@ggzyjd c on c.tender_project_code_old1 = a.tender_project_code
left join t_user_department@ggzyjd b on b.depid = c.RECORD_DEPID
where a.STATE = '1'
)
group by dname
order by cou desc)
where rownum <= 10";
                var dt = FromSql(sql).ToDataTable();
                r.SetSuccess(dt);
            }
            else
            {
                r.SetSuccess(new List<object>());
            }
            return r;
        }
        #endregion

        #region 违规行为分析-概况-上部统计/右侧饼图

        public GeneralResult SurveyCount(StatisticsSupervisionSearchModel search)
        {
            var r = new GeneralResult();
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode.TrimEnd('0');
            var typeList = JdUser?.UserDepartment?.TENDER_PROJECT_TYPES;
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {
                var projectTypes = string.Join("','", typeList);
                var where1 = new StringBuilder($" AND REGION_CODE LIKE '{rootAreaCode}%' AND TENDER_PROJECT_TYPE IN('{projectTypes}')");
                if (rootAreaCode == "3501")
                {
                    where1.Append($" and REGION_CODE !='350128'");
                }

                if (!string.IsNullOrWhiteSpace(search.RegionCode))
                {
                    where1.Append($" and REGION_CODE LIKE '{search.RegionCode.Substring(0, 4)}%'");
                }
                if (!string.IsNullOrWhiteSpace(search.TenderType))
                {
                    where1.Append($" and TENDER_PROJECT_TYPE = '{search.TenderType}'");
                }
                var where2 = new StringBuilder();
                if (!DateTime.MinValue.Equals(search.BeginTime))
                {
                    where2.Append($" and CREATE_TIME >= to_date('{search.BeginTime:yyyy-MM-dd}','yyyy-mm-dd')");
                }
                if (!DateTime.MinValue.Equals(search.EndTime))
                {
                    where2.Append($" and CREATE_TIME < to_date('{search.EndTime.AddDays(1):yyyy-MM-dd}','yyyy-mm-dd')");
                }

                //计算监督项目总数
                var sql = $@"select count(*) from tender_project where 1=1 {where1}";
                int tenderProjectCount = FromSql(sql).ToScalar<int>();
                sql = $@"select count(*) from tender_project where 1=1 {where1} {where2}";
                int thisTenderProjectCount = FromSql(sql).ToScalar<int>();
                sql = $@"select count(*) from( select TENDER_PROJECT_CODE from  bd_violation_record where  
tender_project_code in  (select tender_project_code from tender_project where 1=1 {where1} {where2})  
group by TENDER_PROJECT_CODE 
)";
                int exceptionProjectCount = FromSql(sql).ToScalar<int>();

                //todo 确定违规的数量目前为0
                int illegalCount = 0;
                r.SetSuccess(new
                {
                    tenderProjectCount,
                    thisTenderProjectCount,
                    exceptionProjectCount,
                    illegalCount,
                    normalCount = tenderProjectCount - exceptionProjectCount - illegalCount
                });
            }
            else
            {
                r.SetSuccess(new
                {
                    tenderProjectCount = 0,
                    thisTenderProjectCount = 0,
                    exceptionProjectCount = 0,
                    illegalCount = 0,
                    normalCount = 0
                });
            }
            return r;
        }
        #endregion

        #region 违规行为分析-概况-项目情况分析

        public GeneralResult ProjectConditionCount(StatisticsSupervisionSearchModel search)
        {
            var r = new GeneralResult();

            //汇总成数组
            Dictionary<string, string> regionDcit = new Dictionary<string, string>()
            {
                {"省本级","3500" },
                {"福州","3501" },
                {"厦门","3502" },
                {"漳州","3506" },
                {"泉州","3505" },
                {"三明","3504" },
                {"莆田","3503" },
                {"南平","3507" },
                {"龙岩","3508" },
                {"宁德","3509" },
                {"平潭","350128" },
            };
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode.TrimEnd('0');
            var typeList = JdUser?.UserDepartment?.TENDER_PROJECT_TYPES;
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {
                var projectTypes = string.Join("','", typeList);
                var where1 = new StringBuilder($" AND REGION_CODE LIKE '{rootAreaCode}%' AND TENDER_PROJECT_TYPE IN('{projectTypes}')");
                if (rootAreaCode == "3501")
                {
                    where1.Append($" and REGION_CODE !='350128'");
                }

                if (!string.IsNullOrWhiteSpace(search.RegionCode))
                {
                    where1.Append($" and REGION_CODE LIKE '{search.RegionCode.Substring(0, 4)}%'");
                }
                if (!string.IsNullOrWhiteSpace(search.TenderType))
                {
                    where1.Append($" and TENDER_PROJECT_TYPE = '{search.TenderType}'");
                }
                var where2 = new StringBuilder();
                if (!DateTime.MinValue.Equals(search.BeginTime))
                {
                    where2.Append($" and CREATE_TIME >= to_date('{search.BeginTime:yyyy-MM-dd}','yyyy-mm-dd')");
                }
                if (!DateTime.MinValue.Equals(search.EndTime))
                {
                    where2.Append($" and CREATE_TIME < to_date('{search.EndTime.AddDays(1):yyyy-MM-dd}','yyyy-mm-dd')");
                }
                //计算监督项目总数
                var sql = $@"select region_code,count(1) cou from tender_project where 1=1 {where1} group by region_code";
                List<Dictionary<string, object>> tenderProjectCount = FromSql(sql).ToDataTable().ToDictionary();
                sql = $@"select region_code,count(1) cou from tender_project where tender_project_code in 
( select TENDER_PROJECT_CODE from  bd_violation_record   
 where 1=1 {where2}
 group by TENDER_PROJECT_CODE) 
 {where1}
 group by region_code";
                List<Dictionary<string, object>> exceptionProjectCount = FromSql(sql).ToDataTable().ToDictionary();

                //todo 确定违规的数量目前为0
#pragma warning disable CS0219 // 变量“illegalCount”已被赋值，但从未使用过它的值
                int illegalCount = 0;
#pragma warning restore CS0219 // 变量“illegalCount”已被赋值，但从未使用过它的值
                List<int> projectList = new List<int>();
                List<int> exceptionList = new List<int>();
                List<int> illegalList = new List<int>();
                foreach (var d in regionDcit)
                {
                    if (d.Key == "3501")
                    {
                        projectList.Add(tenderProjectCount
                            .Where(e => e["REGION_CODE"].ToString().Contains("3501") &&
                                        e["REGION_CODE"].ToString() != "350128")
                            .Sum(e => e["COU"] != null ? int.Parse(e["COU"].ToString()) : 0));
                        exceptionList.Add(exceptionProjectCount
                            .Where(e => e["REGION_CODE"].ToString().Contains("3501") &&
                                        e["REGION_CODE"].ToString() != "350128")
                            .Sum(e => e["COU"] != null ? int.Parse(e["COU"].ToString()) : 0));
                        //todo 调查发现违规的数量，目前暂为0
                        illegalList.Add(0);
                    }
                    else if (d.Key == "350128")
                    {
                        projectList.Add(tenderProjectCount
                            .Where(e => e["REGION_CODE"].ToString().Contains("3520") &&
                                        e["REGION_CODE"].ToString() == "350128")
                            .Sum(e => e["COU"] != null ? int.Parse(e["COU"].ToString()) : 0));
                        exceptionList.Add(exceptionProjectCount
                            .Where(e => e["REGION_CODE"].ToString().Contains("3520") &&
                                        e["REGION_CODE"].ToString() == "350128")
                            .Sum(e => e["COU"] != null ? int.Parse(e["COU"].ToString()) : 0));
                        illegalList.Add(0);
                    }
                    else
                    {
                        projectList.Add(tenderProjectCount
                            .Where(e => e["REGION_CODE"].ToString().Contains(d.Value))
                            .Sum(e => e["COU"] != null ? int.Parse(e["COU"].ToString()) : 0));
                        exceptionList.Add(exceptionProjectCount
                            .Where(e => e["REGION_CODE"].ToString().Contains(d.Value))
                            .Sum(e => e["COU"] != null ? int.Parse(e["COU"].ToString()) : 0));
                        illegalList.Add(0);
                    }
                }
                r.SetSuccess(new
                {
                    regionList = regionDcit.Select(e => e.Key).ToList(),
                    projectList,
                    exceptionList,
                    illegalList
                });
            }
            else
            {
                r.SetSuccess(new
                {
                    regionList = regionDcit.Select(e => e.Key).ToList(),
                    projectList = new List<int>(),
                    exceptionList = new List<int>(),
                    illegalList = new List<int>()
                });
            }

            return r;
        }
        #endregion

        #region 违规行为分析-概况-可疑项目top10

        public GeneralResult ProjectTop10(StatisticsSupervisionSearchModel search)
        {
            var r = new GeneralResult();
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode.TrimEnd('0');
            var typeList = JdUser?.UserDepartment?.TENDER_PROJECT_TYPES;
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && typeList != null && typeList.Any())
            {
                var projectTypes = string.Join("','", typeList);
                var where1 = new StringBuilder($" AND AREA_CODE LIKE '{rootAreaCode}%' AND TENDER_PROJECT_TYPE IN('{projectTypes}')");
                if (rootAreaCode == "3501")
                {
                    where1.Append($" and AREA_CODE !='350128'");
                }

                if (!string.IsNullOrWhiteSpace(search.RegionCode))
                {
                    where1.Append($" and AREA_CODE LIKE '{search.RegionCode.Substring(0, 4)}%'");
                }
                if (!string.IsNullOrWhiteSpace(search.TenderType))
                {
                    where1.Append($" and TENDER_PROJECT_TYPE = '{search.TenderType}'");
                }
                if (!DateTime.MinValue.Equals(search.BeginTime))
                {
                    where1.Append($" and CREATE_TIME >= to_date('{search.BeginTime:yyyy-MM-dd}','yyyy-mm-dd')");
                }
                if (!DateTime.MinValue.Equals(search.EndTime))
                {
                    where1.Append($" and CREATE_TIME < to_date('{search.EndTime.AddDays(1):yyyy-MM-dd}','yyyy-mm-dd')");
                }

                //计算监督项目总数
                var sql = $@"select * from (
select tender_project_code,tender_project_name,avg(score) score from bd_violation_record
where 1=1 {where1}
group by tender_project_code,tender_project_name
order by score desc 
)
where rownum <=10";
                var dt = FromSql(sql).ToDataTable();
                r.SetSuccess(dt);
            }
            else
            {
                r.SetSuccess(new List<object>());
            }
            return r;
        }
        #endregion

        #region 违规行为分析-概况-可疑主体top10

        public GeneralResult SubjectTop10(StatisticsSupervisionSearchModel search)
        {
            var r = new GeneralResult();

            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode.TrimEnd('0');
            var typeList = JdUser?.UserDepartment?.TENDER_PROJECT_TYPES;
            if (!string.IsNullOrWhiteSpace(rootAreaCode))// && typeList != null && typeList.Any()
            {
                var projectTypes = string.Join("','", typeList);
                var where1 = new StringBuilder($" AND AREA_CODE LIKE '{rootAreaCode}%' ");//AND TENDER_PROJECT_TYPE IN('{projectTypes}')
                if (rootAreaCode == "3501")
                {
                    where1.Append($" and AREA_CODE !='350128'");
                }

                if (!string.IsNullOrWhiteSpace(search.RegionCode))
                {
                    where1.Append($" and AREA_CODE LIKE '{search.RegionCode.Substring(0, 4)}%'");
                }
                if (!DateTime.MinValue.Equals(search.BeginTime))
                {
                    where1.Append($" and CREATE_TIME >= to_date('{search.BeginTime:yyyy-MM-dd}','yyyy-mm-dd')");
                }
                if (!DateTime.MinValue.Equals(search.EndTime))
                {
                    where1.Append($" and CREATE_TIME < to_date('{search.EndTime.AddDays(1):yyyy-MM-dd}','yyyy-mm-dd')");
                }

                //计算监督项目总数
                var sql = $@"select * from (
select ENTITY_CODE,ENTITY_NAME,avg(score) score from bd_violation_entity 
where 1=1 {where1}
group by ENTITY_CODE,ENTITY_NAME
order by score desc 
)
where rownum <=10

";
                var dt = FromSql(sql).ToDataTable();
                r.SetSuccess(dt);
            }
            else
            {
                r.SetSuccess(new List<object>());
            }
            return r;
        }
        #endregion
    }
}
