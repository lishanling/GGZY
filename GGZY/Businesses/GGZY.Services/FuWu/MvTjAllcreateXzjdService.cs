using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model;
using GGZY.Services.Infrastructure.Model.FuWu;
using GGZYFW.DbEntity;
using GGZYJD.DbEntity;
using SECTION = GGZYFW.DbEntity.SECTION;
using SYS_AREA = GGZYFW.DbEntity.SYS_AREA;
using SYS_AREA_QUANGUO = GGZYFW.DbEntity.SYS_AREA_QUANGUO;
using SYS_DIC = GGZYFW.DbEntity.SYS_DIC;
using TENDER_PROJECT = GGZYFW.DbEntity.TENDER_PROJECT;


namespace GGZY.Services.FuWu
{
    public partial class MvTjAllcreateXzjdService
    {
        #region 监督平台-门户

        public List<SelectModel> JdPortalProjectTypeTree(SearchCondition search)
        {
            var condition = new WhereClipBuilder();
            if (search.BeginTime.HasValue)
            {
                condition.And(MV_TJ_ALLCREATE_XZJD._.CREATE_TIME >= search.BeginTime);
            }

            if (search.EndTime.HasValue)
            {
                condition.And(MV_TJ_ALLCREATE_XZJD._.CREATE_TIME <= search.EndTime);
            }

            var r = FromWhere(condition.ToWhereClip()).GroupBy(MV_TJ_ALLCREATE_XZJD._.PROJECT_TYPE)
                .Select(MV_TJ_ALLCREATE_XZJD._.PROJECT_TYPE.As("Label"), MV_TJ_ALLCREATE_XZJD._.All.Count().As("Value"))
                .ToList<LabelValueModel>();
            var projectTypes = r.FindAll(c => String.CompareOrdinal(c.Value, "0") > 0).Select(c => c.Label).ToList();
            var p = Jd.SysDicService.FindList(GGZYJD.DbEntity.SYS_DIC._.TYPE == "20200830001",
                GGZYJD.DbEntity.SYS_DIC._.ORDER_ID.Asc);
            var pids = p.Select(pi => pi.ID).ToList();
            var dic = Jd.SysDicService.FindList(GGZYJD.DbEntity.SYS_DIC._.PID.In(pids),
                GGZYJD.DbEntity.SYS_DIC._.ORDER_ID.Asc);
            var cids = dic.Select(g => g.ID).ToList();
            var children = Jd.SysDicService.FindList(GGZYJD.DbEntity.SYS_DIC._.PID.In(cids),
                GGZYJD.DbEntity.SYS_DIC._.ORDER_ID.Asc);

            var result = new List<SelectModel>();
            foreach (var pi in p)
            {

                var piTree = new SelectModel(pi.VALUE, pi.TEXT);
                var sub = dic.FindAll(c => c.PID == pi.ID);
                foreach (var ci in sub)
                {
                    var childTree = children
                        .FindAll(o => o.PID == ci.ID && (o.VALUE.Contains(",") || projectTypes.Contains(o.VALUE)))
                        .Select(c => new SelectModel(c.VALUE, c.TEXT)).ToList();
                    if (childTree.Any() || ci.TEXT == "全部")
                    {
                        var subTree = new SelectModel(ci.VALUE, ci.TEXT)
                        {
                            Children = childTree
                        };
                        piTree.Children.Add(subTree);
                    }
                }

                result.Add(piTree);
            }

            return result;
        }

        public PageTableResult PageDataTable(MV_TJ_ALLCREATE_XZJD model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            if (!string.IsNullOrWhiteSpace(search.KeyWord))
            {
                condition.And(MV_TJ_ALLCREATE_XZJD._.PROJECT_NAME.Contain(search.KeyWord) ||
                              MV_TJ_ALLCREATE_XZJD._.PROJECT_CODE.Contain(search.KeyWord));
            }

            if (search.BeginTime.HasValue)
            {
                condition.And(MV_TJ_ALLCREATE_XZJD._.CREATE_TIME >= search.BeginTime);
            }

            if (search.EndTime.HasValue)
            {
                condition.And(MV_TJ_ALLCREATE_XZJD._.CREATE_TIME <= search.EndTime);
            }
            
            if (JdUser != null && (JdUser.IsZhuGuan||JdUser.IsJiWei))
            {//标签标中吧
                condition.And(MV_TJ_ALLCREATE_XZJD._.AREACODE.BeginWith(JdUser.UserDepartment?.RootAreaCode));
                condition.And(MV_TJ_ALLCREATE_XZJD._.PROJECT_TYPE.In(JdUser.UserDepartment?.FW_TENDER_PROJECT_TYPES));
            }
            var count =FromWhere().Union(FromWhere<MV_TJ_ALLCREATE_XZJD_HOUR>())
                .Where(condition.ToWhereClip()).Count();
            var fields = model.GetFields().ToList();
            fields.RemoveAll(c => c.Name == "KIND");
            fields.Add(SYS_DIC._.TEXT.As("PROJECT_CATEGORY_TEXT"));
            fields.Add(SYS_DIC._.VALUE1.As("KIND"));
            fields.Add(new Field("TEXT", "SYS_DIC2").As("PROJECT_TYPE_NAME"));
            fields.Add(TENDER_PROJECT._.TENDERER_NAME);
            fields.Add(TENDER_PROJECT._.TENDER_AGENCY_NAME);
            fields.Add(TENDER_PROJECT._.TENDER_AGENCY_CODE);
            fields.Add(TENDER_PROJECT._.OWNER_NAME);
            //var pageList = PageList(condition, search, MV_TJ_ALLCREATE_XZJD._.CREATE_TIME.Desc).ToDataTable(search);
            var list = FromWhere().Union(FromWhere<MV_TJ_ALLCREATE_XZJD_HOUR>())
                .Where(condition.ToWhereClip())
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "300" &&
                                   MV_TJ_ALLCREATE_XZJD._.PROJECT_CATEGORY.ToChar() ==
                                   SYS_DIC._.VALUE) //"to_char(PROJECT_CATEGORY)=SYS_DIC.VALUE"
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "10" && SYS_DIC._.VALUE == MV_TJ_ALLCREATE_XZJD._.PROJECT_TYPE)
                .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == MV_TJ_ALLCREATE_XZJD._.PROJECT_CODE)
                .Page(search.PageSize, search.PageNo)
                .OrderBy(MV_TJ_ALLCREATE_XZJD._.CREATE_TIME.Desc)
                .Select(fields.ToArray())
                .ToList<MvTjAllCreateXzjdModel>();
            var areaCodes = list.Select(c => c.AREACODE).Distinct().ToList();
            var pRegions = Fw.SysAreaQuanguoService.FromWhere(SYS_AREA_QUANGUO._.AREACODE.In(areaCodes)).ToList();
            var pcodes = pRegions.Select(c => c.PCODE).ToList();
            var parentRegions = Fw.SysAreaQuanguoService.FindList(SYS_AREA_QUANGUO._.AREACODE.In(pcodes));
            var fwTenderProjectCodes = list.Select(c => c.FW_TENDER_PROJECT_CODE).ToList();
            var jdTenderProjects =
                Jd.TenderProjectService.FindList(
                    GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1.In(fwTenderProjectCodes));
            var pageList = list.ToPageTableResult(search, count, c =>
            {
                var pRegion = pRegions.FirstOrDefault(o => o.AREACODE == c.AREACODE);
                var p = parentRegions.FirstOrDefault(r => r.AREACODE == pRegion?.PCODE);
                if (!c.T_TM.HasValue)
                {
                    c.T_TM = c.CREATE_TIME;
                }
                c.P_AREACODE = p?.AREACODE ?? "";
                c.P_AREANAME = string.IsNullOrWhiteSpace(p?.AREANAME) || p.AREANAME == "福建省" ? "" : p.AREANAME;
                c.JD_TENDER_PROJECT_CODE = jdTenderProjects
                    .FirstOrDefault(jd => jd.TENDER_PROJECT_CODE_OLD1 == c.FW_TENDER_PROJECT_CODE)?.TENDER_PROJECT_CODE;
                return c;
            });
            return pageList;
        }

        /// <summary>
        /// 每日项目新增信息
        /// </summary>
        /// <returns></returns>
        public object DailyStat4Create(MV_TJ_ALLCREATE_XZJD model, SearchCondition search)
        {
            var con = new WhereClipBuilder(MV_TJ_ALLCREATE_XZJD._.KIND.IsNotNull());
            //if (string.IsNullOrWhiteSpace(model.AREACODE))
            //{
            //    con.And(MV_TJ_ALLCREATE_XZJD._.AREACODE==model.AREACODE);
            //}

            if (search.BeginTime.HasValue)
            {
                con.And(MV_TJ_ALLCREATE_XZJD._.CREATE_TIME >= search.BeginTime);
            }

            if (search.EndTime.HasValue)
            {
                con.And(MV_TJ_ALLCREATE_XZJD._.CREATE_TIME <= search.EndTime);
            }

            var fjProvince = Fw.SysAreaService.FindList(SYS_AREA._.PCODE == "350000");
            var xzjd = FromWhere(con.ToWhereClip())
                .LeftJoin<SYS_AREA>(SYS_AREA._.AREACODE == MV_TJ_ALLCREATE_XZJD._.AREACODE)
                .Select(MV_TJ_ALLCREATE_XZJD._.KIND, SYS_AREA._.PPCODE.As("AREACODE")).ToList();
            var g = xzjd.GroupBy(c => new {c.AREACODE, c.KIND}).Select(c => new
            {
                Num = c.Count(),
                c.Key.KIND,
                c.Key.AREACODE,
                AREANAME = string.Empty
            }).ToList();
            var r = new List<dynamic>();
            foreach (var area in fjProvince)
            {
                var m = g.FindAll(c => c.AREACODE == area.AREACODE).Select(c => new
                {
                    c.Num,
                    c.KIND,
                    c.AREACODE,
                    area.AREANAME
                }).ToList();
                r.AddRange(m);
            }

            return r;
        }

        /// <summary>
        /// 今日项目情况
        /// </summary>
        /// <returns></returns>
        public object DailyStat()
        {
            //取新增项目数
            var allCreate = FromSql($@"                                  
              select  KIND,nvl(NUM,0) NUM,s.AREACODE,s.AREANAME
               from SYS_AREA s
               left join (
               SELECT  COUNT(1) NUM,area.ppcode AREACODE,KIND 
                                   from MV_TJ_ALLCREATE_XZJD temp
                                   left join SYS_AREA  area on temp.AREACODE=area.AREACODE
                                 where  CREATE_TIME >= to_date('{DateTime.Today:yyyy-MM-dd}', 'yyyy-MM-dd hh24:mi;ss')
                                and CREATE_TIME < to_date('{DateTime.Today.AddDays(1):yyyy-MM-dd}', 'yyyy-MM-dd hh24:mi;ss')
            group by area.ppcode,KIND
                                 ) v  on s.AREACODE = v.AREACODE
             WHERE s.PCODE = '350000' and KIND IS NOT NULL").ToFirst<object>();
            //取交易项目数及交易金额
            var allResult = FromSql($@"                                  
              select  KIND,round(nvl(AMOUNT,0)) AMOUNT,nvl(NUM,0) NUM,s.AREACODE,s.AREANAME
               from SYS_AREA s
               left join (
               SELECT SUM(AMOUNT) AS AMOUNT, COUNT(1) NUM,area.ppcode AREACODE,KIND 
                                   from MV_TJ_ALLRESULT_XZJD temp
                                   left join SYS_AREA  area on temp.AREACODE=area.AREACODE
                                 where  M_TM >= to_date('{DateTime.Today:yyyy-MM-dd}', 'yyyy-MM-dd hh24:mi;ss')
                                and M_TM < to_date('{DateTime.Today.AddDays(1):yyyy-MM-dd}', 'yyyy-MM-dd hh24:mi;ss')
                                 group by area.ppcode,KIND
                                 ) v  on s.AREACODE = v.AREACODE
             WHERE s.PCODE = '350000' and KIND IS NOT NULL").ToFirst<object>();
            return new
            {
                AllCreate = allCreate,
                AllResult = allResult
            };
        }

        /// <summary>
        /// 今日项目情况
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public object DailyStatDetail(MV_TJ_ALLCREATE_XZJD model, SearchCondition search)
        {
            var createCon = new WhereClipBuilder(MV_TJ_ALLCREATE_XZJD._.KIND.IsNotNull());
            var resultCod = new WhereClipBuilder(MV_TJ_ALLRESULT_XZJD._.KIND.IsNotNull());
            if (!string.IsNullOrWhiteSpace(model.AREACODE))
            {
                if (model.AREACODE != "350000")
                {
                    model.AREACODE = model.AREACODE.TrimEnd('0');
                }

                createCon.And(MV_TJ_ALLCREATE_XZJD._.AREACODE.BeginWith(model.AREACODE));
                resultCod.And(MV_TJ_ALLRESULT_XZJD._.AREACODE.BeginWith(model.AREACODE));
            }

            var beginTime = DateTime.Today;
            var endTime = beginTime.AddDays(1).AddSeconds(-1);
            if (search.BeginTime.HasValue)
            {
                beginTime = search.BeginTime.Value;
            }

            if (search.EndTime.HasValue)
            {
                endTime = search.EndTime.Value;
            }

            createCon.And(MV_TJ_ALLCREATE_XZJD._.CREATE_TIME >= beginTime);
            resultCod.And(MV_TJ_ALLRESULT_XZJD._.M_TM >= beginTime);
            createCon.And(MV_TJ_ALLCREATE_XZJD._.CREATE_TIME <= endTime);
            resultCod.And(MV_TJ_ALLRESULT_XZJD._.M_TM <= endTime);
            var allCreate = FromWhere()
                .Union(FromWhere<MV_TJ_ALLCREATE_XZJD_HOUR>())
                .Where(createCon.ToWhereClip())
                //.LeftJoin<SYS_AREA>(SYS_AREA._.AREACODE == MV_TJ_ALLCREATE_XZJD._.AREACODE)
                .Select(
                    MV_TJ_ALLCREATE_XZJD._.KIND
                    //, SYS_AREA._.PPCODE.As("AREACODE")
                ).ToList()
                .Select(c => new
                {
                    //c.AREACODE,
                    c.KIND,
                    Amount = 0m,
                    Type = "create"
                }).ToList();
            var allResult = Fw.MvTjAllresultXzjdService.FromWhere(resultCod.ToWhereClip())
                //.LeftJoin<SYS_AREA>(SYS_AREA._.AREACODE == MV_TJ_ALLRESULT_XZJD._.AREACODE)
                .Select(
                    MV_TJ_ALLRESULT_XZJD._.KIND
                    , MV_TJ_ALLRESULT_XZJD._.AMOUNT
                    , MV_TJ_ALLRESULT_XZJD._.PROJECT_CODE
                //, SYS_AREA._.PPCODE.As("AREACODE")
                ).ToList().GroupBy(c=>new{c.PROJECT_CODE,c.KIND})
                .Select(c => new
                {
                    //c.AREACODE,
                    c.Key.KIND,
                    Amount = c.Sum(o=>o.AMOUNT??0),
                    Type = "result"
                }).ToList();

            allResult.AddRange(allCreate);
            //var fjProvince = Fw.SysAreaService.FindList(SYS_AREA._.AREACODE == "350000");
            var g = allResult.GroupBy(c => c.KIND).Select(c => new
            {
                KIND = c.Key,
                Amount = c.Sum(o => o.Amount),
                Count = c.Count(o => o.Type == "create"),
                ResultCount = c.Count(o => o.Type == "result"),
            }).ToList();
            g.Add(new
            {
                KIND = "SUMMARY",
                Amount = g.Sum(o => o.Amount),
                Count = g.Sum(o => o.Count),
                ResultCount = g.Sum(o => o.ResultCount)
            });
            var r = new
            {
                GCJS = g.FirstOrDefault(c => c.KIND == "GCJS") ??
                       new {KIND = "GCJS", Amount = 0m, Count = 0, ResultCount = 0},
                ZFCG = g.FirstOrDefault(c => c.KIND == "ZFCG") ??
                       new {KIND = "ZFCG", Amount = 0m, Count = 0, ResultCount = 0},
                TDSYQ = g.FirstOrDefault(c => c.KIND == "TDSYQ") ??
                        new {KIND = "TDSYQ", Amount = 0m, Count = 0, ResultCount = 0},
                KYQ = g.FirstOrDefault(c => c.KIND == "KYQ") ??
                      new {KIND = "KYQ", Amount = 0m, Count = 0, ResultCount = 0},
                GYCQ_SW = g.FirstOrDefault(c => c.KIND == "GYCQ_SW") ??
                          new {KIND = "GYCQ_SW", Amount = 0m, Count = 0, ResultCount = 0},
                GYCQ_GQ = g.FirstOrDefault(c => c.KIND == "GYCQ_GQ") ??
                          new {KIND = "GYCQ_GQ", Amount = 0m, Count = 0, ResultCount = 0},
                SUMMARY = g.FirstOrDefault(c => c.KIND == "SUMMARY") ??
                          new {KIND = "SUMMARY", Amount = 0m, Count = 0, ResultCount = 0},
            };
            return r;

        }

        /// <summary>
        /// 项目走势
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<object> StatTrend(MV_TJ_ALLCREATE_XZJD model, SearchCondition search)
        {
            var createCon = new WhereClipBuilder();
            var resultCod = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.AREACODE))
            {
                if (model.AREACODE != "350000")
                {
                    model.AREACODE = model.AREACODE.TrimEnd('0');
                }

                createCon.And(MV_TJ_ALLCREATE_XZJD._.AREACODE.BeginWith(model.AREACODE));
                resultCod.And(MV_TJ_ALLRESULT_XZJD._.AREACODE.BeginWith(model.AREACODE));
            }

            var endTime = DateTime.Today.AddDays(1).AddSeconds(-1);
            var beginTime = DateTime.Today.AddMonths(-1);
            if (search.BeginTime.HasValue)
            {
                beginTime = search.BeginTime.Value;
            }

            if (search.EndTime.HasValue)
            {
                endTime = search.EndTime.Value;
            }

            createCon.And(MV_TJ_ALLCREATE_XZJD._.CREATE_TIME >= beginTime);
            resultCod.And(MV_TJ_ALLRESULT_XZJD._.M_TM >= beginTime);
            createCon.And(MV_TJ_ALLCREATE_XZJD._.CREATE_TIME <= endTime);
            resultCod.And(MV_TJ_ALLRESULT_XZJD._.M_TM <= endTime);

            var allCreate = FindList(createCon.ToWhereClip(), MV_TJ_ALLCREATE_XZJD._.CREATE_TIME.Asc);
            var allResult =
                Fw.MvTjAllresultXzjdService.FindList(resultCod.ToWhereClip(), MV_TJ_ALLRESULT_XZJD._.M_TM.Asc);
            var format = "yyyy年MM月dd日";
            if (string.Compare(search.Type, "m", StringComparison.CurrentCultureIgnoreCase) == 0)
            {
                format = "yyyy年MM月";
            }

            var gCreate = allCreate.GroupBy(c => c.CREATE_TIME?.ToString(format))
                .Select(c => new
                {
                    M_TM = c.Key,
                    Num = c.Count()
                }).ToList();
            var gResult = allResult.GroupBy(c => c.M_TM?.ToString(format))
                .Select(c => new
                {
                    M_TM = c.Key,
                    ResultNum = c.Count(),
                    AMOUNT = c.Sum(o => o.AMOUNT ?? 0)
                }).ToList();
            var r = new List<object>();
            while (beginTime < endTime)
            {
                var tm = beginTime.ToString(format);
                var create = gCreate.FirstOrDefault(c => c.M_TM == tm);
                var result = gResult.FirstOrDefault(c => c.M_TM == tm);
                r.Add(new
                {
                    TM = tm,
                    Count = create?.Num ?? 0,
                    ResultCount = result?.ResultNum ?? 0,
                    Amount = result?.AMOUNT ?? 0,
                });
                beginTime = string.Compare(search.Type, "m", StringComparison.CurrentCultureIgnoreCase) == 0
                    ? beginTime.AddMonths(1)
                    : beginTime.AddDays(1);
            }

            return r;
        }


        #endregion

        #region 监督平台门户

        #region 工程建设


        /// <summary>
        /// 项目详情基础信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult ProjectBaseInfo(MV_TJ_ALLCREATE_XZJD model)
        {
            var r = new GeneralResult();
            string sql = string.Empty;
            switch (model.KIND)
            {
                case "1": //工程建设
                    sql =
                        @"select A.M_ID,A.TENDER_PROJECT_NAME as PROJECT_NAME,A.CREATE_TIME,A.TENDER_PROJECT_CODE as PROJECT_CODE,A.REGION_CODE,A.PLATFORM_CODE
                                   ,A.TENDER_AGENCY_NAME as AGENCY_NAME,A.OWNER_NAME
                                     ,AREA.AREANAME,PLAT.SYSTEM_NAME
                                     ,nvl(B.ZBGG,0) as ZBGG
                                     ,nvl(C.TBBM,0) as TBBM
                                     ,(SELECT COUNT(1) FROM BID_OPENING_RECORD WHERE TENDER_PROJECT_CODE=:project_code ) as KB
                                     ,(SELECT COUNT(1) FROM EVALUATION_REPORT WHERE TENDER_PROJECT_CODE=:project_code ) as PB
                                     ,nvl(F.JGGG,0)+nvl(G.ZBHXR,0) as JGGG
                              from TENDER_PROJECT A
                             left join T_USER_TRADEPLATFORM PLAT on PLAT.PLATFORM_CODE = A.PLATFORM_CODE
                             left join SYS_AREA_QUANGUO AREA on AREA.AREACODE = A.REGION_CODE
                              left join (select TENDER_PROJECT_CODE,count(M_ID) as ZBGG
                                         from TENDER_ANN_QUA_INQUERY_ANN where NOTICE_NATURE IN ('1', '2') and BULLETIN_TYPE='1' and m_status = '2'
                                         group by TENDER_PROJECT_CODE) B
                              on A.TENDER_PROJECT_CODE = B.TENDER_PROJECT_CODE       
                              left join (select tb.TENDER_PROJECT_CODE,count(tb.M_ID) as TBBM
                                         from TENDER_LIST tb
                                              INNER JOIN (SELECT TENDER_PROJECT_CODE,
                                                                 BID_SECTION_CODE,
                                                                 MAX( CASE WHEN IS_POSTPONE='1' THEN POST_OPEN_TIME ELSE BID_OPEN_TIME END) AS BID_OPEN_TIME 
                                                            FROM TENDER_FILE_CLARI_MODI 
                                                           GROUP BY TENDER_PROJECT_CODE,BID_SECTION_CODE) TB2 
                                              ON tb.TENDER_PROJECT_CODE=TB2.TENDER_PROJECT_CODE AND tb.BID_SECTION_CODE=TB2.BID_SECTION_CODE
                                          WHERE TB2.BID_OPEN_TIME<SYSDATE
                                         group by tb.TENDER_PROJECT_CODE) C
                              on A.TENDER_PROJECT_CODE = C.TENDER_PROJECT_CODE     
                              
      
                              left join (select TENDER_PROJECT_CODE,count(M_ID) as JGGG
                                         from WIN_RESULT_ANNO WHERE BULLETIN_TYPE ='3' and m_status = '2'
                                         group by TENDER_PROJECT_CODE) F
                              on A.TENDER_PROJECT_CODE =F.TENDER_PROJECT_CODE 
                              left join (select TENDER_PROJECT_CODE,count(M_ID) as ZBHXR
                                         from TENDER_CANDIDATE_ANNOUNCE where m_status = '2'
                                         group by TENDER_PROJECT_CODE) G
                              on A.TENDER_PROJECT_CODE =G.TENDER_PROJECT_CODE 
                             WHERE A.TENDER_PROJECT_CODE = :project_code AND ROWNUM = 1";
                    break;
                case "1_": //工程建设
                    sql =
                        @"select A.M_ID,A.TENDER_PROJECT_NAME as PROJECT_NAME,A.CREATE_TIME,A.TENDER_PROJECT_CODE as PROJECT_CODE,A.REGION_CODE,A.PLATFORM_CODE
                                   ,A.TENDER_AGENCY_NAME as AGENCY_NAME,A.OWNER_NAME
                                     ,AREA.AREANAME,PLAT.SYSTEM_NAME
                                     ,nvl(B.ZBGG,0) as ZBGG
                                     ,nvl(C.TBBM,0) as TBBM
                                     ,nvl(D.KB,0) as KB
                                     ,nvl(E.PB,0) as PB
                                     ,nvl(F.JGGG,0)+nvl(G.ZBHXR,0) as JGGG
                              from TENDER_PROJECT A
                             left join T_USER_TRADEPLATFORM PLAT on PLAT.PLATFORM_CODE = A.PLATFORM_CODE
                             left join SYS_AREA_QUANGUO AREA on AREA.AREACODE = A.REGION_CODE
                              left join (select TENDER_PROJECT_CODE,count(M_ID) as ZBGG
                                         from TENDER_ANN_QUA_INQUERY_ANN where NOTICE_NATURE IN ('1', '2') and BULLETIN_TYPE='1' and m_status = '2'
                                         group by TENDER_PROJECT_CODE) B
                              on A.TENDER_PROJECT_CODE = B.TENDER_PROJECT_CODE       
                              left join (select tb.TENDER_PROJECT_CODE,count(tb.M_ID) as TBBM
                                         from TENDER_LIST tb
                                              INNER JOIN (SELECT TENDER_PROJECT_CODE,
                                                                 BID_SECTION_CODE,
                                                                 MAX( CASE WHEN IS_POSTPONE='1' THEN POST_OPEN_TIME ELSE BID_OPEN_TIME END) AS BID_OPEN_TIME 
                                                            FROM TENDER_FILE_CLARI_MODI 
                                                           GROUP BY TENDER_PROJECT_CODE,BID_SECTION_CODE) TB2 
                                              ON tb.TENDER_PROJECT_CODE=TB2.TENDER_PROJECT_CODE AND tb.BID_SECTION_CODE=TB2.BID_SECTION_CODE
                                          WHERE TB2.BID_OPEN_TIME<SYSDATE
                                         group by tb.TENDER_PROJECT_CODE) C
                              on A.TENDER_PROJECT_CODE = C.TENDER_PROJECT_CODE
      
                              left join (select TENDER_PROJECT_CODE,count(M_ID) as KB
                                         from BID_OPENING_RECORD
                                         group by TENDER_PROJECT_CODE) D
                              on A.TENDER_PROJECT_CODE = D.TENDER_PROJECT_CODE
      
                              left join (select TENDER_PROJECT_CODE,count(M_ID) as PB
                                         from EVALUATION_REPORT
                                         group by TENDER_PROJECT_CODE) E
                              on A.TENDER_PROJECT_CODE = E.TENDER_PROJECT_CODE
      
                              left join (select TENDER_PROJECT_CODE,count(M_ID) as JGGG
                                         from WIN_RESULT_ANNO WHERE BULLETIN_TYPE ='3' and m_status = '2'
                                         group by TENDER_PROJECT_CODE) F
                              on A.TENDER_PROJECT_CODE =F.TENDER_PROJECT_CODE 
                              left join (select TENDER_PROJECT_CODE,count(M_ID) as ZBHXR
                                         from TENDER_CANDIDATE_ANNOUNCE where m_status = '2'
                                         group by TENDER_PROJECT_CODE) G
                              on A.TENDER_PROJECT_CODE =G.TENDER_PROJECT_CODE 
                             WHERE A.TENDER_PROJECT_CODE = :project_code AND ROWNUM = 1";
                    break;
                case "2": //政府采购 ZFCG
                    sql =
                        @"SELECT A.PURCHASE_PROJECT_CODE as PROJECT_CODE,A.PURCHASE_PROJECT_NAME as PROJECT_NAME,A.CREATE_TIME
                                    ,AREA.AREANAME,AREA.AREACODE as REGION_CODE,PLAT.SYSTEM_NAME,A.PURCHASER_NAME as OWNER_NAME,A.PURCHASER_AGENCY_NAME as AGENCY_NAME,A.PURCHASE_SECTION_CODE
                                      ,nvl(B.CGGG, 0) as CGGG
                                      ,nvl(C.JGGG, 0) as JGGG
                                FROM PURCHASE_PROJECT A
                                left join T_USER_TRADEPLATFORM PLAT on PLAT.PLATFORM_CODE = A.PLATFORM_CODE
                                left join SYS_AREA_QUANGUO AREA on AREA.AREACODE = PLAT.AREACODE
                                left join (select PURCHASE_PROJECT_CODE, count(M_ID) as CGGG
                                            from PURCHASE_QUALI_INQUERY_ANN
                                           group by PURCHASE_PROJECT_CODE) B
                                on A.PURCHASE_PROJECT_CODE = B.PURCHASE_PROJECT_CODE
                                left join (select PURCHASE_PROJECT_CODE, count(M_ID) as JGGG
                                            from BID_DEAL_ANNOUNCE
                                           group by PURCHASE_PROJECT_CODE) C
                                on A.PURCHASE_PROJECT_CODE = C.PURCHASE_PROJECT_CODE 
                                WHERE A.PURCHASE_PROJECT_CODE = :project_code AND ROWNUM = 1";
                    break;
                case "3": //土地使用权 TDSYQ
                    sql =
                        @"SELECT A.ANNOUNCEMENT_GUID AS PROJECT_CODE,A.ANNOUNCEMENT_TITLE AS PROJECT_NAME,CREATE_TIME,AREA.AREANAME,AREA.AREACODE as REGION_CODE,PLAT.SYSTEM_NAME
                                ,LIAISON_UNIT OWNER_NAME,'' AGENCY_NAME,(CASE WHEN A.ANNOUNCEMENT_GUID IS NOT NULL THEN 1 ELSE 0 END) AS CJXW,nvl(B.CJZD,0) as CJZD
                                FROM DEAL_BEHAVIOR_INFO A
                                left join (select DEAL_ANNOUNCEMENT_GUID, count(M_ID) as CJZD
                                            from DEAL_LAND_INFO
                                            group by DEAL_ANNOUNCEMENT_GUID) B
                                on A.ANNOUNCEMENT_GUID = B.DEAL_ANNOUNCEMENT_GUID
                                left join T_USER_TRADEPLATFORM PLAT on PLAT.PLATFORM_CODE = A.PLATFORM_CODE
                                left join SYS_AREA_QUANGUO AREA on AREA.AREACODE = A.LAND_DISTRICT
                                WHERE A.ANNOUNCEMENT_GUID = :project_code and rownum=1";
                    break;
                case "4": //矿业权-探矿 KYQ_TK
                    sql =
                        @"SELECT A.NA_APP_NAME as PROJECT_NAME,A.PUBLISHING_TIME as CREATE_TIME,A.UNIFIED_DEAL_CODE as PROJECT_CODE,AREA.AREANAME,AREA.AREACODE as REGION_CODE,PLAT.SYSTEM_NAME
                             ,'' OWNER_NAME,'' AGENCY_NAME,nvl(B.JGGS,0) as JGGS
                            FROM EXPLOR_BID_AUCTION_TRANS_ANN A
                            left join T_USER_TRADEPLATFORM PLAT on PLAT.PLATFORM_CODE = A.PLATFORM_CODE
                            left join SYS_AREA_QUANGUO AREA on AREA.AREACODE = PLAT.AREACODE
                            left join (select NA_APP_NAME, count(M_ID) as JGGS
                                        from EXPLOR_BID_AUC_TRANS_RES_ANN
                                        group by NA_APP_NAME) B
                             on A.NA_APP_NAME = B.NA_APP_NAME
                            WHERE A.NA_APP_NAME = :project_code and rownum=1";
                    break;
                case "5": //矿业权-采矿 KYQ_CK
                    sql =
                        @"SELECT A.NA_APP_NAME as PROJECT_NAME,A.PUBLISHING_TIME as CREATE_TIME,A.UNIFIED_DEAL_CODE as PROJECT_CODE,AREA.AREANAME,AREA.AREACODE as REGION_CODE,PLAT.SYSTEM_NAME
                             ,'' OWNER_NAME,'' AGENCY_NAME,nvl(B.JGGS,0) as JGGS
                            FROM MINING_BID_AUCTION_TRANS_ANN A
                            left join T_USER_TRADEPLATFORM PLAT on PLAT.PLATFORM_CODE = A.PLATFORM_CODE
                            left join SYS_AREA_QUANGUO AREA on AREA.AREACODE = PLAT.AREACODE
                            left join (select NA_APP_NAME, count(M_ID) as JGGS
                                        from MINING_BID_AUC_TRANS_RES_ANN
                                        group by NA_APP_NAME) B
                             on A.NA_APP_NAME = B.NA_APP_NAME
                            WHERE A.NA_APP_NAME = :project_code  and rownum=1";
                    break;
                case "6": //国有产权-实物 GYCQ_SW
                    sql =
                        @"SELECT A.PROJECT_CODE ,A.PROJECT_NAME AS PROJECT_NAME,PUBLISH_DATE AS CREATE_TIME,AREA.AREANAME,AREA.AREACODE as REGION_CODE,PLAT.SYSTEM_NAME
                                    ,'' OWNER_NAME,'' AGENCY_NAME,nvl(B.JYJG,0) as JYJG
                                FROM LISTING_PUB_INFO A
                                left join (select PROJECT_CODE, count(M_ID) as JYJG
                                            from TRADE_RESULT_INFO
                                            group by PROJECT_CODE) B
                                on A.PROJECT_CODE = B.PROJECT_CODE
                                left join T_USER_TRADEPLATFORM PLAT on PLAT.PLATFORM_CODE = A.PLATFORM_CODE
                                left join SYS_AREA_QUANGUO AREA on AREA.AREACODE = PLAT.AREACODE
                                WHERE A.PROJECT_CODE = :project_code and rownum=1";
                    break;
                case "7": //国有产权-股权 GYCQ_GQ
                    sql =
                        @"SELECT A.PROJECT_CODE ,A.PROJECT_NAME AS PROJECT_NAME,PUBLISH_DATE AS CREATE_TIME,AREA.AREANAME,AREA.AREACODE as REGION_CODE,PLAT.SYSTEM_NAME
                                    ,'' OWNER_NAME,'' AGENCY_NAME,nvl(B.JYJG,0) as JYJG
                                FROM STOCK_LISTING_PUB_INFO A
                                left join (select PROJECT_CODE, count(M_ID) as JYJG
                                            from STOCK_TRADE_RESULT_INFO
                                            group by PROJECT_CODE) B
                                on A.PROJECT_CODE = B.PROJECT_CODE
                                left join T_USER_TRADEPLATFORM PLAT on PLAT.PLATFORM_CODE = A.PLATFORM_CODE
                                left join SYS_AREA_QUANGUO AREA on AREA.AREACODE = PLAT.AREACODE
                                WHERE A.PROJECT_CODE = :project_code and rownum=1";
                    break;
            }

            if (string.IsNullOrWhiteSpace(sql))
            {
                r.SetFail("参数错误");
            }
            else
            {
                #region 修改阅读量

                var browser =
                    Jd.TProjectBrowseService.FirstOrNull(GGZYJD.DbEntity.T_PROJECT_BROWSE._.PROJECT_CODE ==
                                                         model.PROJECT_CODE);
                if (browser != null)
                {
                    browser.Attach();
                    browser.BROWSE_NUM = (browser.BROWSE_NUM ?? 0) + 1;
                    Jd.TProjectBrowseService.Update(browser);
                }
                else
                {
                    var project = FirstOrNull(MV_TJ_ALLCREATE_XZJD._.PLATFORM_CODE == model.PROJECT_CODE);
                    if (project != null)
                    {

                        browser = new GGZYJD.DbEntity.T_PROJECT_BROWSE
                        {
                            PROJECT_CODE = model.PROJECT_CODE,
                            PROJECT_NAME = project.PROJECT_NAME,
                            PROJECT_CATEGORY = project.PROJECT_CATEGORY?.ToString(),
                            CREATE_TIME = DateTime.Now,
                            BROWSE_NUM = 1
                        };
                        Jd.TProjectBrowseService.Add(browser);
                    }
                }


                #endregion

                var obj = FromSql(sql).AddInParameter(":project_code", DbType.AnsiString, model.PROJECT_CODE)
                    .ToFirst<dynamic>();
                string shiBenJi = obj.AREANAME?.ToString(); //市本级
                string shiBenJiCode = obj.REGION_CODE?.ToString(); //市本级编码
                if (!string.IsNullOrWhiteSpace(shiBenJiCode) && !string.IsNullOrWhiteSpace(shiBenJi) &&
                    shiBenJi == "市本级")
                {
                    //var areacode = shiBenJiCode.PadRight(6, '0').Substring(0, 4).PadRight(6,'0');
                    var parentRegion = Fw.SysAreaQuanguoService.FirstOrNull(SYS_AREA_QUANGUO._.AREACODE.SubQueryIn(
                        Fw.SysAreaQuanguoService.FromWhere(SYS_AREA_QUANGUO._.AREACODE == shiBenJiCode)
                            .Select(SYS_AREA_QUANGUO._.PCODE)));
                    if (parentRegion != null)
                    {
                        obj.P_AREANAME =
                            string.IsNullOrWhiteSpace(parentRegion.AREANAME) || parentRegion.AREANAME == "福建省"
                                ? ""
                                : parentRegion.AREANAME;
                        obj.P_REGION_CODE = parentRegion.AREACODE;
                    }
                    else
                    {
                        obj.P_AREANAME = "";
                        obj.P_REGION_CODE = "";
                    }
                }
                else
                {
                    obj.P_AREANAME = "";
                    obj.P_REGION_CODE = "";
                }

                r.SetSuccess((object) obj);
            }


            return r;
        }

        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 项目进场 
        /// </summary>
        /// <param name="projectCode"></param>
        /// <param name="attachmentFunc">门户网站不展示附件null 后台展示附件 </param>
        /// <returns></returns>
        public object GCJS_XMJC_ProjectInfo(string projectCode, Func<string, List<UploadResData>> attachmentFunc = null)
        {
            var project = Fw.ProjectService.JD_GCJS_XMJC_ProjectInfo(projectCode, attachmentFunc);
            var tenderProject = Fw.TenderProjectService.JD_GCJS_XMJC_TenderProjectInfo(projectCode, attachmentFunc);
            var section = Fw.SectionService.JD_GCJS_XMJC_SectionInfo(projectCode, attachmentFunc);
            return new
            {
                Project = project,
                TenderProject = tenderProject,
                Section = section
            };
        }

        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 招标公告 
        /// </summary>
        /// <param name="projectCode"></param>
        /// <param name="attachmentFunc">门户网站不展示附件null 后台展示附件 </param>
        /// <returns></returns>
        public object GCJS_ZBGG(string projectCode, Func<string, List<UploadResData>> attachmentFunc = null)
        {
            var ann = Fw.TenderAnnQuaInqueryAnnService.JD_GCJS_TenderAnnQuaInqueryAnn(projectCode, attachmentFunc);
            return ann;
        }

        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 投标报名
        /// </summary>
        /// <param name="projectCode"></param>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        public GeneralResult GCJS_TBBM(string projectCode, string sourceType)
        {
            var result = new GeneralResult();
            var section = Fw.SectionService.FirstOrNull(SECTION._.TENDER_PROJECT_CODE == projectCode);
            if (section == null)
            {
                result.SetFail("参数错误,未找到对应的标段信息");
            }
            else
            {
                var tenderList = Fw.TenderListService.JD_GCJS_TBBM_TenderList(projectCode, section.BID_SECTION_CODE);
                result.SetSuccess(new
                {
                    Section = section,
                    TenderList = tenderList
                });
            }

            return result;

        }
      

        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 开标 投标人特征码|开标记录 
        /// </summary>
        /// <param name="projectCode"></param>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        public GeneralResult GCJS_KB(string projectCode, string sourceType)
        {
            var result = new GeneralResult();
            var openingRecord = Fw.BidOpeningRecordService.JD_GCJS_KB_BidOpeningRecord(projectCode);
            if (sourceType == "HT" && JdUser != null)
            {
                var bidDocCharactCode = Fw.BidDocCharactCodeService.JD_GCJS_KB_BidDocCharactCode(projectCode);
                if (bidDocCharactCode != null)
                {
                    var bidSectionCode = bidDocCharactCode.PropertyToString("BID_SECTION_CODE");
                    var bidDocCharactCodeList =
                        Fw.BidDocCharactCodeService.JD_GCJS_KB_BidDocCharactCodeList(projectCode, bidSectionCode);
                    result.SetSuccess(new
                    {
                        BidDocCharactCode = bidDocCharactCode, //特征码 对象
                        BidDocCharactCodeList = bidDocCharactCodeList, //特征码列表 数组
                        OpeningRecord = openingRecord //开标 对象
                    });
                }
                else
                {
                    result.SetSuccess(new
                    {
                        OpeningRecord = openingRecord
                    });
                }
            }
            else
            {
                result.SetSuccess(new
                {
                    OpeningRecord = openingRecord
                });
            }

            return result;

        }


        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 评标
        /// </summary>
        /// <param name="projectCode"></param>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        public GeneralResult GCJS_PB(string projectCode, string sourceType)
        {
            var result = new GeneralResult();
            var section = Fw.SectionService.FirstOrNull(SECTION._.TENDER_PROJECT_CODE == projectCode);
            if (section == null)
            {
                result.SetFail($"参数错误，未找到对应的标段信息");
            }
            else
            {
                var bidSectionCode = section.BID_SECTION_CODE;
                var evaluationReport =
                    Fw.EvaluationReportService.JD_GCJS_PB_EvaluationReport(projectCode, bidSectionCode);
                var tenderCandidate = Fw.TenderCandidateService.JD_GCJS_PB_TenderCandidate(projectCode, bidSectionCode);
                if (sourceType == "HT" && JdUser != null)
                {
                    var evaluationExpert =
                        Fw.BidEvaluationExpertService.JD_GCJS_PB_BidEvaluationExpert(projectCode, bidSectionCode);
                    result.SetSuccess(new
                    {
                        Section = section,
                        EvaluationReport = evaluationReport,
                        TenderCandidate = tenderCandidate,
                        EvaluationExpert = evaluationExpert
                    });
                }
                else
                {
                    result.SetSuccess(new
                    {
                        Section = section,
                        EvaluationReport = evaluationReport,
                        TenderCandidate = tenderCandidate,
                    });
                }

            }

            return result;
        }


        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 结果公告
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public GeneralResult GCJS_JGGG(string projectCode)
        {
            var result = new GeneralResult();
            var tenderCandidateAnnounce =
                Fw.TenderCandidateAnnounceService.FirstOrNull(
                    TENDER_CANDIDATE_ANNOUNCE._.TENDER_PROJECT_CODE == projectCode);
            var winResultAnn = Fw.WinResultAnnoService.JD_GCJS_JGGG_WinResultAnno(projectCode);
            result.SetSuccess(new
            {
                TenderCandidateAnnounce = tenderCandidateAnnounce,
                WinResultAnno = winResultAnn
            });
            return result;
        }

        #endregion
        #region 公安厅外网系统

        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 项目进场 
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public object GAT_XMJC_ProjectInfo(string projectCode)
        {
            var project = Fw.ProjectService.JD_GCJS_XMJC_ProjectInfo(projectCode);
            var tenderProject = Fw.TenderProjectService.JD_GCJS_XMJC_TenderProjectInfo(projectCode);
            var section = Fw.SectionService.JD_GCJS_XMJC_SectionInfo(projectCode);
            return new
            {
                Project = project,
                TenderProject = tenderProject,
                Section = section
            };
        }

        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 招标公告 
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public object GAT_ZBGG(string projectCode)
        {
            var ann = Fw.TenderAnnQuaInqueryAnnService.JD_GCJS_TenderAnnQuaInqueryAnn(projectCode);
            return ann;
        }
        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 开标记录
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public GeneralResult GAT_KBJV(string projectCode)
        {
            var result = new GeneralResult();
            var openingRecord = Fw.BidOpeningRecordService.JD_GCJS_KB_BidOpeningRecord(projectCode);

            result.SetSuccess(openingRecord);


            return result;

        }
        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 投标报名
        /// </summary>
        /// <param name="projectCode"></param>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        public GeneralResult GAT_TBBM(string projectCode)
        {
            var result = new GeneralResult();
            var section = Fw.SectionService.FirstOrNull(SECTION._.TENDER_PROJECT_CODE == projectCode);
            if (section == null)
            {
                result.SetFail("参数错误,未找到对应的标段信息");
            }
            else
            {
                var tenderList = Fw.TenderListService.JD_GCJS_TBBM_TenderList(projectCode, section.BID_SECTION_CODE);
                result.SetSuccess(new
                {
                    Section = section,
                    TenderList = tenderList
                });
            }

            return result;

        }

        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 评标
        /// </summary>
        /// <param name="projectCode"></param>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        public GeneralResult GAT_PB(string projectCode, string sourceType)
        {
            var result = new GeneralResult();
            var section = Fw.SectionService.FirstOrNull(SECTION._.TENDER_PROJECT_CODE == projectCode);
            if (section == null)
            {
                result.SetFail($"参数错误，未找到对应的标段信息");
            }
            else
            {
                var bidSectionCode = section.BID_SECTION_CODE;
                var evaluationReport =
                    Fw.EvaluationReportService.JD_GCJS_PB_EvaluationReport(projectCode, bidSectionCode);
                var tenderCandidate = Fw.TenderCandidateService.JD_GCJS_PB_TenderCandidate(projectCode, bidSectionCode);
                if (sourceType == "HT" )//&& JdUser != null)
                {
                    var evaluationExpert =
                        Fw.BidEvaluationExpertService.JD_GCJS_PB_BidEvaluationExpert(projectCode, bidSectionCode);
                    result.SetSuccess(new
                    {
                        Section = section,
                        EvaluationReport = evaluationReport,
                        TenderCandidate = tenderCandidate,
                        EvaluationExpert = evaluationExpert
                    });
                }
                else
                {
                    result.SetSuccess(new
                    {
                        Section = section,
                        EvaluationReport = evaluationReport,
                        TenderCandidate = tenderCandidate,
                    });
                }

            }

            return result;
        }
        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 结果公告
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public GeneralResult GAT_JGGG(string projectCode)
        {
            var result = new GeneralResult();
            var tenderCandidateAnnounce =
                Fw.TenderCandidateAnnounceService.FirstOrNull(
                    TENDER_CANDIDATE_ANNOUNCE._.TENDER_PROJECT_CODE == projectCode);
            var winResultAnn = Fw.WinResultAnnoService.JD_GCJS_JGGG_WinResultAnno(projectCode);
            result.SetSuccess(new
            {
                TenderCandidateAnnounce = tenderCandidateAnnounce,
                WinResultAnno = winResultAnn
            });
            return result;
        }
        #endregion

        #region 政府采购

        /// <summary>
        /// 监督平台门户 项目监督信息 政府采购 项目进场
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public object ZFCG_XMJC(string projectCode)
        {
            return Fw.PurchaseProjectService.JD_ZFCG_XMJC_PurchaseProject(projectCode);
        }

        /// <summary>
        /// 监督平台门户 项目监督信息 政府采购 采购公告
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public object ZFCG_CGGG(string projectCode)
        {
            var purchaseQualiInqueryAnn =
                Fw.PurchaseQualiInqueryAnnService.FindPurchaseQualiInqueryAnnByProjectCode(projectCode);
            var correctionItem = Fw.CorrectionItemService.FindCorrectionItemByProjectCode(projectCode);
            return new
            {
                PurchaseQualiInqueryAnn = purchaseQualiInqueryAnn,
                CorrectionItem = correctionItem,
            };
        }

        /// <summary>
        /// 监督平台门户 项目监督信息 政府采购 结果公告
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public object ZFCG_JGGG(string projectCode)
        {
            return Fw.BidDealAnnounceService.JD_ZFCG_JGGG_bidDealAnnounce(projectCode);
        }

        #endregion

        #region 土地使用权

        /// <summary>
        /// 监督平台门户 项目监督信息 土地使用权 成交行为信息
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public object TDSYQ_CJXWBG(string projectCode)
        {
            var obj = Fw.DealBehaviorInfoService.JD_TDSYQ_DealBehabiorInfo(projectCode);
            return obj;
        }

        /// <summary>
        /// 监督平台门户 项目监督信息 土地使用权 成交宗地信息
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public object TDSYQ_CJZDS(string projectCode)
        {
            var obj = Fw.DealLandInfoService.JD_TDSYQ_DealLandInfo(projectCode);
            return obj;
        }

        #endregion

        #region 矿业权

        /// <summary>
        /// 监督平台门户 项目监督信息 矿业权  招拍挂出让公告  采矿矿权交易电子挂牌
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public object KYQ_ZPGCRGG(string projectCode)
        {
            var obj = Fw.MiningBidAuctionTransAnnService.JD_KYQ_MiningBidAuctionTransAnn(projectCode);
            return obj;
        }

        /// <summary>
        /// 监督平台门户 项目监督信息 矿业权  结果公示  采矿矿权交易结果公示
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public object KYQ_JGGS(string projectCode)
        {
            var obj = Fw.MiningBidAucTransResAnnService.JD_KYQ_MiningBidAuctionTransResAnn(projectCode);
            return obj;
        }

        #endregion


        #region 矿业权 -探矿

        /// <summary>
        /// 监督平台门户 项目监督信息 矿业权  探矿矿权交易电子挂牌 
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public object KYQ_TK_CRGG(string projectCode)
        {
            var obj = Fw.ExplorBidAucTransResAnnService.JD_KYQ_ExplorBidAucTransResAnn(projectCode);
            return obj;
        }

        /// <summary>
        /// 监督平台门户 项目监督信息 矿业权  结果公示  探矿矿权交易结果公示
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public object KYQ_TK_JGGS(string projectCode)
        {
            var obj = Fw.ExplorBidAuctionTransAnnService.JD_KYQ_ExplorBidAuctionTransAnn(projectCode);
            return obj;
        }

        #endregion

        #region 国有产权 实物

        /// <summary>
        /// 监督平台门户 项目监督信息 国有产权 实物   挂牌披露  挂牌披露信息(实物资产类)
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public object GYCQ_SW_GPPL(string projectCode)
        {
            var obj = Fw.ListingPubInfoService.JD_GYCQ_SW_ListingPubInfo(projectCode);
            return new
            {
                BaseInfo = obj.FirstOrDefault(),
                ZRSMSX = obj,
            };
        }

        /// <summary>
        /// 监督平台门户 项目监督信息 国有产权 实物   交易结果  交易结果信息(实物资产类)
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public object GYCQ_SW_JYJG(string projectCode)
        {
            var obj = Fw.TradeResultInfoService.JD_GYCQ_SW_TradeResultInfo(projectCode);
            return obj;
        }

        #endregion

        #region 国有产权 股权

        /// <summary>
        /// 监督平台门户 项目监督信息 国有产权 股权   挂牌披露  挂牌披露信息(股权类)
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public object GYCQ_GQ_GPPL(string projectCode)
        {
            var obj = Fw.StockListingPubInfoService.JD_GYCQ_GQ_StockListingPubInfo(projectCode);
            return new
            {
                BaseInfo = obj.FirstOrDefault(),
                ZRSMSX = obj,
            };
        }

        /// <summary>
        /// 监督平台门户 项目监督信息 国有产权 股权    交易结果  交易结果信息(股权类)
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public object GYCQ_GQ_JYJG(string projectCode)
        {
            var obj = Fw.StockTradeResultInfoService.JD_GYCQ_GQ_StockTradeResultInfo(projectCode);
            return obj;
        }

        #endregion

        #endregion

        #region 监督平台后台-项目登记（项目报建）审批单位 交易数据 详情




        public GeneralResult GetProcess(MV_TJ_ALLCREATE_XZJD model)
        {
            var r = new GeneralResult();
            string sql = "";
            switch (model.KIND)
            {
                case "1":
                case "GCJS":
                    sql =
                        @"select A.M_ID,A.TENDER_PROJECT_NAME as PROJECT_NAME,A.CREATE_TIME,A.TENDER_PROJECT_CODE as PROJECT_CODE,A.REGION_CODE,A.PLATFORM_CODE
                                   ,A.TENDER_AGENCY_NAME as AGENCY_NAME,A.OWNER_NAME,A.TENDERER_NAME,A.TENDER_AGENCY_CODE
                                     ,AREA.AREANAME,PLAT.SYSTEM_NAME
                                     ,nvl(B.ZBGG,0) as ZBGG
                                     ,nvl(C.TBBM,0) as TBBM
                                     ,nvl(D.KB,0) as KB
                                     ,nvl(E.PB,0) as PB
                                     ,nvl(F.JGGG,0)+nvl(G.ZBHXR,0) as JGGG
                              from TENDER_PROJECT A
                             left join T_USER_TRADEPLATFORM PLAT on PLAT.PLATFORM_CODE = A.PLATFORM_CODE
                             left join SYS_AREA_QUANGUO AREA on AREA.AREACODE = A.REGION_CODE
                              left join (select TENDER_PROJECT_CODE,count(M_ID) as ZBGG
                                         from TENDER_ANN_QUA_INQUERY_ANN where NOTICE_NATURE IN ('1', '2') and BULLETIN_TYPE='1'
                                         group by TENDER_PROJECT_CODE) B
                              on A.TENDER_PROJECT_CODE = B.TENDER_PROJECT_CODE       
                              left join (select tb.TENDER_PROJECT_CODE,count(tb.M_ID) as TBBM
                                         from TENDER_LIST tb
                                              INNER JOIN (SELECT TENDER_PROJECT_CODE,
                                                                 BID_SECTION_CODE,
                                                                 MAX( CASE WHEN IS_POSTPONE='1' THEN POST_OPEN_TIME ELSE BID_OPEN_TIME END) AS BID_OPEN_TIME 
                                                            FROM TENDER_FILE_CLARI_MODI 
                                                           GROUP BY TENDER_PROJECT_CODE,BID_SECTION_CODE) TB2 
                                              ON tb.TENDER_PROJECT_CODE=TB2.TENDER_PROJECT_CODE AND tb.BID_SECTION_CODE=TB2.BID_SECTION_CODE
                                          WHERE TB2.BID_OPEN_TIME<SYSDATE
                                         group by tb.TENDER_PROJECT_CODE) C
                              on A.TENDER_PROJECT_CODE = C.TENDER_PROJECT_CODE
      
                              left join (select TENDER_PROJECT_CODE,count(M_ID) as KB
                                         from BID_OPENING_RECORD
                                         group by TENDER_PROJECT_CODE) D
                              on A.TENDER_PROJECT_CODE = D.TENDER_PROJECT_CODE
      
                              left join (select TENDER_PROJECT_CODE,count(M_ID) as PB
                                         from EVALUATION_REPORT
                                         group by TENDER_PROJECT_CODE) E
                              on A.TENDER_PROJECT_CODE = E.TENDER_PROJECT_CODE
      
                              left join (select TENDER_PROJECT_CODE,count(M_ID) as JGGG
                                         from WIN_RESULT_ANNO WHERE BULLETIN_TYPE ='3'
                                         group by TENDER_PROJECT_CODE) F
                              on A.TENDER_PROJECT_CODE =F.TENDER_PROJECT_CODE 
                              left join (select TENDER_PROJECT_CODE,count(M_ID) as ZBHXR
                                         from TENDER_CANDIDATE_ANNOUNCE 
                                         group by TENDER_PROJECT_CODE) G
                              on A.TENDER_PROJECT_CODE =G.TENDER_PROJECT_CODE 
                             WHERE A.TENDER_PROJECT_CODE = :projectCode";
                    break;
                case "2":
                case "ZFCG":
                    sql =
                        @"SELECT A.PURCHASE_PROJECT_CODE as PROJECT_CODE,A.PURCHASE_PROJECT_NAME as PROJECT_NAME,A.CREATE_TIME
                                    ,AREA.AREANAME,PLAT.SYSTEM_NAME,A.PURCHASER_NAME as OWNER_NAME,A.PURCHASER_AGENCY_NAME as AGENCY_NAME,A.PURCHASE_SECTION_CODE
                                      ,nvl(B.CGGG, 0) as CGGG
                                      ,nvl(C.JGGG, 0) as JGGG
                                      ,TENDER_PROJECT.TENDERER_NAME
                                      ,TENDER_PROJECT.TENDER_AGENCY_CODE
                                FROM PURCHASE_PROJECT A
                                left join T_USER_TRADEPLATFORM PLAT on PLAT.PLATFORM_CODE = A.PLATFORM_CODE
                                left join SYS_AREA_QUANGUO AREA on AREA.AREACODE = PLAT.AREACODE
                                left join (select PURCHASE_PROJECT_CODE, count(M_ID) as CGGG
                                            from PURCHASE_QUALI_INQUERY_ANN
                                           group by PURCHASE_PROJECT_CODE) B
                                on A.PURCHASE_PROJECT_CODE = B.PURCHASE_PROJECT_CODE
                                left join (select PURCHASE_PROJECT_CODE, count(M_ID) as JGGG
                                            from BID_DEAL_ANNOUNCE
                                           group by PURCHASE_PROJECT_CODE) C
                                on A.PURCHASE_PROJECT_CODE = C.PURCHASE_PROJECT_CODE 
                                left join TENDER_PROJECT ON TENDER_PROJECT.TENDER_PROJECT_CODE=A.PURCHASE_PROJECT_CODE
                                WHERE A.PURCHASE_PROJECT_CODE = :projectCode";
                    break;
                case "3":
                case "TDSYQ":
                    sql =
                        @"SELECT A.ANNOUNCEMENT_GUID AS PROJECT_CODE,A.ANNOUNCEMENT_TITLE AS PROJECT_NAME,CREATE_TIME,AREA.AREANAME,PLAT.SYSTEM_NAME
                                ,LIAISON_UNIT OWNER_NAME,(CASE WHEN A.ANNOUNCEMENT_GUID IS NOT NULL THEN 1 ELSE 0 END) AS CJXW,'' AGENCY_NAME,nvl(B.CJZD,0) as CJZD
                                
                                      ,TENDER_PROJECT.TENDERER_NAME
                                      ,TENDER_PROJECT.TENDER_AGENCY_CODE
                                FROM DEAL_BEHAVIOR_INFO A
                                left join (select DEAL_ANNOUNCEMENT_GUID, count(M_ID) as CJZD
                                            from DEAL_LAND_INFO
                                            group by DEAL_ANNOUNCEMENT_GUID) B
                                on A.ANNOUNCEMENT_GUID = B.DEAL_ANNOUNCEMENT_GUID
                                left join T_USER_TRADEPLATFORM PLAT on PLAT.PLATFORM_CODE = A.PLATFORM_CODE
                                left join SYS_AREA_QUANGUO AREA on AREA.AREACODE = A.LAND_DISTRICT
                                left join TENDER_PROJECT ON TENDER_PROJECT.TENDER_PROJECT_CODE=A.ANNOUNCEMENT_GUID
                                WHERE A.ANNOUNCEMENT_GUID = :projectCode";
                    break;
                case "4":
                case "KYQ_TK":
                    sql =
                        @"SELECT A.NA_APP_NAME as PROJECT_NAME,A.PUBLISHING_TIME as CREATE_TIME,A.UNIFIED_DEAL_CODE as PROJECT_CODE,AREA.AREANAME,PLAT.SYSTEM_NAME
                             ,TENDER_PROJECT.OWNER_NAME OWNER_NAME,TENDER_PROJECT.TENDER_AGENCY_NAME AGENCY_NAME,nvl(B.JGGS,0) as JGGS
                                      ,TENDER_PROJECT.TENDERER_NAME
                                      ,TENDER_PROJECT.TENDER_AGENCY_CODE
                                FROM EXPLOR_BID_AUCTION_TRANS_ANN A
                            left join T_USER_TRADEPLATFORM PLAT on PLAT.PLATFORM_CODE = A.PLATFORM_CODE
                            left join SYS_AREA_QUANGUO AREA on AREA.AREACODE = PLAT.AREACODE
                            left join (select NA_APP_NAME, count(M_ID) as JGGS
                                        from EXPLOR_BID_AUC_TRANS_RES_ANN
                                        group by NA_APP_NAME) B
                             on A.NA_APP_NAME = B.NA_APP_NAME
                                left join TENDER_PROJECT ON TENDER_PROJECT.TENDER_PROJECT_CODE=A.NA_APP_NAME
                            WHERE A.NA_APP_NAME = :projectCode";
                    break;
                case "5":
                case "KYQ_CK":
                    sql =
                        @"SELECT A.NA_APP_NAME as PROJECT_NAME,A.PUBLISHING_TIME as CREATE_TIME,A.UNIFIED_DEAL_CODE as PROJECT_CODE,AREA.AREANAME,PLAT.SYSTEM_NAME
                             ,TENDER_PROJECT.OWNER_NAME OWNER_NAME,TENDER_PROJECT.TENDER_AGENCY_NAME AGENCY_NAME,nvl(B.JGGS,0) as JGGS
                                      ,TENDER_PROJECT.TENDERER_NAME
                                      ,TENDER_PROJECT.TENDER_AGENCY_CODE
                            FROM MINING_BID_AUCTION_TRANS_ANN A
                            left join T_USER_TRADEPLATFORM PLAT on PLAT.PLATFORM_CODE = A.PLATFORM_CODE
                            left join SYS_AREA_QUANGUO AREA on AREA.AREACODE = PLAT.AREACODE
                            left join (select NA_APP_NAME, count(M_ID) as JGGS
                                        from MINING_BID_AUC_TRANS_RES_ANN
                                        group by NA_APP_NAME) B
                             on A.NA_APP_NAME = B.NA_APP_NAME
                                left join TENDER_PROJECT ON TENDER_PROJECT.TENDER_PROJECT_CODE=A.NA_APP_NAME
                            WHERE A.NA_APP_NAME = :projectCode";
                    break;
                case "6":
                case "GYCQ_SW":
                    sql =
                        @"SELECT A.PROJECT_CODE ,A.PROJECT_NAME AS PROJECT_NAME,PUBLISH_DATE AS CREATE_TIME,AREA.AREANAME,PLAT.SYSTEM_NAME
                                    ,TENDER_PROJECT.OWNER_NAME OWNER_NAME,TENDER_PROJECT.TENDER_AGENCY_NAME AGENCY_NAME,nvl(B.JYJG,0) as JYJG
                                      ,TENDER_PROJECT.TENDERER_NAME
                                      ,TENDER_PROJECT.TENDER_AGENCY_CODE
                                FROM LISTING_PUB_INFO A
                                left join (select PROJECT_CODE, count(M_ID) as JYJG
                                            from TRADE_RESULT_INFO
                                            group by PROJECT_CODE) B
                                on A.PROJECT_CODE = B.PROJECT_CODE
                                left join T_USER_TRADEPLATFORM PLAT on PLAT.PLATFORM_CODE = A.PLATFORM_CODE
                                left join SYS_AREA_QUANGUO AREA on AREA.AREACODE = PLAT.AREACODE
                                left join TENDER_PROJECT ON TENDER_PROJECT.TENDER_PROJECT_CODE=A.PROJECT_CODE
                                WHERE A.PROJECT_CODE = :projectCode";
                    break;
                case "7":
                case "GYCQ_GQ":
                    sql =
                        @"SELECT A.PROJECT_CODE ,A.PROJECT_NAME AS PROJECT_NAME,PUBLISH_DATE AS CREATE_TIME,AREA.AREANAME,PLAT.SYSTEM_NAME
                                    ,TENDER_PROJECT.OWNER_NAME OWNER_NAME,TENDER_PROJECT.TENDER_AGENCY_NAME AGENCY_NAME,nvl(B.JYJG,0) as JYJG
                                      ,TENDER_PROJECT.TENDERER_NAME
                                      ,TENDER_PROJECT.TENDER_AGENCY_CODE
                                FROM STOCK_LISTING_PUB_INFO A
                                left join (select PROJECT_CODE, count(M_ID) as JYJG
                                            from STOCK_TRADE_RESULT_INFO
                                            group by PROJECT_CODE) B
                                on A.PROJECT_CODE = B.PROJECT_CODE
                                left join T_USER_TRADEPLATFORM PLAT on PLAT.PLATFORM_CODE = A.PLATFORM_CODE
                                left join SYS_AREA_QUANGUO AREA on AREA.AREACODE = PLAT.AREACODE
                                left join TENDER_PROJECT ON TENDER_PROJECT.TENDER_PROJECT_CODE=A.PROJECT_CODE
                                WHERE A.PROJECT_CODE = :projectCode";
                    break;
            }

            if (string.IsNullOrWhiteSpace(sql))
            {
                r.SetFail("参数错误");
            }
            else
            {
                var obj = FromSql(sql).AddInParameter(":ProjectCode", DbType.AnsiString, model.PROJECT_CODE)
                    .ToFirst<dynamic>();

                var tenderProjectCode = Jd.TenderProjectService
                    .FromWhere(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1 == model.PROJECT_CODE)
                    .InnerJoin<GGZYJD.DbEntity.PROJECT>(GGZYJD.DbEntity.PROJECT._.PROJECT_CODE ==
                                                        GGZYJD.DbEntity.TENDER_PROJECT._.PROJECT_CODE)
                    .InnerJoin<T_AFC_PROJECT>(T_AFC_PROJECT._.CODE == GGZYJD.DbEntity.PROJECT._.CONSTRUCTION_ID)
                    .Select(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE).ToScalar<string>();
                int xmbj = 0, zbba = 0;
                if (!string.IsNullOrWhiteSpace(tenderProjectCode))
                {
                    xmbj = 1; //项目报建数量
                    zbba = Jd.RecordReviewService.Count(RECORD_REVIEW._.TENDER_PROJECT_CODE == tenderProjectCode &&
                                                        RECORD_REVIEW._.REVIEW_STATUS != "0"); //招标备案数量
                    obj.JD_TENDER_PROJECT_CODE = tenderProjectCode;
                    //obj.TENDER_PROJECT_CODE_OLD1 = jdObj.TENDER_PROJECT_CODE_OLD1;
                }

                obj.XMJC = 1; //项目进场
                obj.ZBJH = xmbj; //招标计划
                obj.ZBBA = zbba; //招标备案
                r.SetSuccess((object) obj);
            }

            return r;
        }

        #endregion

        #region 监督平台后台 监督服务 项目列表

        public PageTableResult GetProjectList_GGFW(MV_TJ_ALLCREATE_XZJD model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);

            #region 归属地过滤

            var rootAreaCode = JdUser?.RootAreaCode;
            if (!string.IsNullOrWhiteSpace(rootAreaCode))
            {
                var areaCondition = new WhereClipBuilder();
                if (rootAreaCode == "3501") //福州市排除平潭
                {
                    areaCondition.And(MV_TJ_ALLCREATE_XZJD._.REGION_CODE.BeginWith(rootAreaCode) &&
                                      MV_TJ_ALLCREATE_XZJD._.REGION_CODE != "350128");
                }
                else
                {
                    areaCondition.And(MV_TJ_ALLCREATE_XZJD._.REGION_CODE.BeginWith(rootAreaCode));
                }

                if (rootAreaCode.Length > 2)
                {
                    var pCode = string.Empty;
                    if (rootAreaCode == "350128") //平潭直接查看省级数据
                    {
                        pCode += "350000";
                    }
                    else
                    {
                        pCode = rootAreaCode.Substring(0, rootAreaCode.Length - 2).PadRight(6, '0');
                    }

                    areaCondition.Or(MV_TJ_ALLCREATE_XZJD._.REGION_CODE == pCode);
                }

                if (!WhereClip.IsNullOrEmpty(areaCondition.ToWhereClip()))
                {
                    condition.And(areaCondition.ToWhereClip() || TENDER_PROJECT._.M_ID.IsNotNull());
                }
                else
                {
                    condition.And(TENDER_PROJECT._.M_ID.IsNotNull());
                }
            }

            #endregion

            #region 行业过滤

            if (JdUser?.ISALLKIND != 1)
            {
                if (string.IsNullOrWhiteSpace(JdUser?.HY_TYPE))
                {
                    condition.And(MV_TJ_ALLCREATE_XZJD._.PROJECT_TYPE == "-1");
                }
                else
                {
                    var hyTypes = JdUser.HY_TYPE.Split(',').ToList();
                    condition.And(MV_TJ_ALLCREATE_XZJD._.PROJECT_TYPE.In(hyTypes));
                }
            }

            #endregion

            #region RECORD_REVIEW.M_ID 过滤

            var jdUserDepartId = JdUser?.DEPARTID;
            var sqlSection = FromSql(@"SELECT T.M_ID_GGFW AS M_ID FROM RECORD_REVIEW@GGZYJD R
            INNER JOIN TENDER_PROJECT@GGZYJD T ON R.TENDER_PROJECT_CODE = T.TENDER_PROJECT_CODE
            WHERE R.REVIEW_STATUS IS NOT NULL AND R.REVIEW_STATUS != '0' AND T.M_ID_GGFW IS NOT NULL AND T.RECORD_DEPID = :JDUSER_DEPARTID
            GROUP BY T.M_ID_GGFW").AddInParameter(":JDUSER_DEPARTID", DbType.AnsiString, jdUserDepartId);

            #endregion

            var subQuery = Fw.TenderAnnQuaInqueryAnnService.FromWhere().Select(
                    TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE, TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME)
                .GroupBy(TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE,
                    TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME);
            var query = FromWhere()
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "10" && SYS_DIC._.VALUE == MV_TJ_ALLCREATE_XZJD._.PROJECT_TYPE)
                .LeftJoin<SYS_DIC>(
                    SYS_DIC._.TYPE == "300" && SYS_DIC._.VALUE == MV_TJ_ALLCREATE_XZJD._.PROJECT_CATEGORY)
                .LeftJoinTmp<TENDER_ANN_QUA_INQUERY_ANN>(subQuery,
                    TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE == MV_TJ_ALLCREATE_XZJD._.PROJECT_CODE)
                .LeftJoinTmp<TENDER_PROJECT>(sqlSection, TENDER_PROJECT._.M_ID == MV_TJ_ALLCREATE_XZJD._.M_ID)
                .Where(condition.ToWhereClip());
            var total = query.Count();
            var pageList = search.ToPageTableResult(total);
            if (total > 0)
            {

                var list = query.Select(
                        MV_TJ_ALLCREATE_XZJD._.PROJECT_CODE
                        , MV_TJ_ALLCREATE_XZJD._.PROJECT_NAME
                        , TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME.As("CREATE_TIME")
                        , MV_TJ_ALLCREATE_XZJD._.AREANAME
                        , MV_TJ_ALLCREATE_XZJD._.PLATFORM_NAME
                        , SYS_DIC._.TEXT.As("PROJECT_TYPE_NAME")
                        , MV_TJ_ALLCREATE_XZJD._.T_TM
                        , MV_TJ_ALLCREATE_XZJD._.PROJECT_CATEGORY
                        ,
                        new Field("TEXT", "SYS_DIC2").As("PROJECT_CATEGORY_TEXT")
                        ,
                        new Field("VALUE1", "SYS_DIC2").As("PROJECT_CATEGORY_KIND")
                    )
                    .OrderBy(MV_TJ_ALLCREATE_XZJD._.CREATE_TIME.Desc)
                    .Page(search.PageSize, search.PageNo)
                    .ToList<MvTjAllCreateXzjdModel>();
                var fwTenderProjectCodes = list.Select(c => c.PROJECT_CODE).ToArray();
                var jdTenderProject = Jd.TenderProjectService.GetJdTenderProjectsFwTpCodes(fwTenderProjectCodes);
                
                pageList = list.ToPageTableResult(search, total, c =>
                {
                    c.JD_TENDER_PROJECT_CODE = jdTenderProject
                        .FirstOrDefault(o => o.TENDER_PROJECT_CODE_OLD1 == c.PROJECT_CODE)?.TENDER_PROJECT_CODE;
                    return c;
                });
            }

            return pageList;
        }


        #endregion

        #region 闽政通-首页-交易信息 招标公告项目 开评标项目 中标金额

        public List<LabelValueModel> TradeInfoStat(MV_TJ_ALLCREATE_XZJD model, SearchCondition search)
        {
            var createCon = new WhereClipBuilder( MV_TJ_ALLCREATE_XZJD._.KIND=="GCJS");//MV_TJ_ALLCREATE_XZJD._.KIND.IsNotNull()&&

            var resultCod = new WhereClipBuilder(MV_TJ_ALLRESULT_XZJD._.KIND=="GCJS");//MV_TJ_ALLRESULT_XZJD._.KIND.IsNotNull()&& 
            var projectCon = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.AREACODE))
            {
                if (model.AREACODE != "350000")
                {
                    model.AREACODE = model.AREACODE.TrimEnd('0');
                }

                createCon.And(MV_TJ_ALLCREATE_XZJD._.AREACODE.BeginWith(model.AREACODE));
                resultCod.And(MV_TJ_ALLRESULT_XZJD._.AREACODE.BeginWith(model.AREACODE));
                projectCon.And(TENDER_PROJECT._.REGION_CODE.BeginWith(model.AREACODE));
            }

            var beginTime = DateTime.Today;
            var endTime = beginTime.AddDays(1).AddSeconds(-1);
            if (search.BeginTime.HasValue)
            {
                beginTime = search.BeginTime.Value;
            }

            if (search.EndTime.HasValue)
            {
                endTime = search.EndTime.Value;
            }

            createCon.And(MV_TJ_ALLCREATE_XZJD._.CREATE_TIME >= beginTime);
            resultCod.And(MV_TJ_ALLRESULT_XZJD._.M_TM >= beginTime);
            createCon.And(MV_TJ_ALLCREATE_XZJD._.CREATE_TIME <= endTime);
            resultCod.And(MV_TJ_ALLRESULT_XZJD._.M_TM <= endTime);
            var tenderAnnQuaInqueryAnnCount =
                FromWhere()
                    .Union(FromWhere<MV_TJ_ALLCREATE_XZJD_HOUR>())
                    .Where(createCon.ToWhereClip())
                    .GroupBy(MV_TJ_ALLCREATE_XZJD._.PROJECT_CODE).Select(MV_TJ_ALLCREATE_XZJD._.PROJECT_CODE).Count(); //TENDER_ANN_QUA_INQUERY_ANN 招标公告数量
            var evaluationReportCount =
                Fw.MvTjAllresultXzjdService.FromWhere(resultCod.ToWhereClip())
                    .GroupBy(MV_TJ_ALLRESULT_XZJD._.PROJECT_CODE).Select(MV_TJ_ALLRESULT_XZJD._.PROJECT_CODE)
                    .Count(); //开评标项目 EVALUATION_REPORT
            var amount = Fw.MvTjAllresultXzjdService.FromWhere(resultCod.ToWhereClip())
                .Select(MV_TJ_ALLRESULT_XZJD._.AMOUNT.Sum()).ToScalar<decimal>();
            var r = new List<LabelValueModel>
            {
                new LabelValueModel {Label = "招标公告项目", Value = tenderAnnQuaInqueryAnnCount.ToString()},
                new LabelValueModel {Label = "开评标项目", Value = evaluationReportCount.ToString()},
                new LabelValueModel {Label = "中标金额", Value = amount.ToString("#.##")},
            };
            return r;
            //projectCon.And(TENDER_PROJECT._.CREATE_TIME>=beginTime);
            //projectCon.And(TENDER_PROJECT._.CREATE_TIME<=endTime);
            //var modelParam = model.Md5Param();
            //var searchParam = search.Md5Param();
            //var cacheTime = 60 - DateTime.Now.Minute;
            //var result = Cache.Get($"{ConfigHelper.APP_KEY_GGZYJD}:MZT:TradeInfoStat:{modelParam}:{searchParam}",
            //    cacheTime,
            //    () =>
            //    {
            //        var annMaxTmp = Fw.TenderAnnQuaInqueryAnnService
            //            .FromWhere(TENDER_ANN_QUA_INQUERY_ANN._.M_STATUS == 2 &&
            //                       TENDER_ANN_QUA_INQUERY_ANN._.BULLETIN_TYPE == "1")
            //            .GroupBy(TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE)
            //            .Select(TENDER_ANN_QUA_INQUERY_ANN._.M_ID.Max());
            //        var annTmp =
            //            Fw.TenderAnnQuaInqueryAnnService.FromWhere(
            //                TENDER_ANN_QUA_INQUERY_ANN._.M_ID.SubQueryIn(annMaxTmp));
            //        var tenderAnnQuaInqueryAnnCount = Fw.TenderProjectService.FromWhere(projectCon.ToWhereClip())
            //            .InnerJoinTmp<TENDER_ANN_QUA_INQUERY_ANN>(annTmp,
            //                TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
            //            .GroupBy(TENDER_PROJECT._.TENDER_PROJECT_CODE).Select(TENDER_PROJECT._.TENDER_PROJECT_CODE)
            //            .Count();
            //    });
            //return result;

        }
        public PageTableResult TenderAnnQuaInqueryAnnPageDataTable(MV_TJ_ALLCREATE_XZJD model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            if (!string.IsNullOrWhiteSpace(search.KeyWord))
            {
                condition.And(MV_TJ_ALLCREATE_XZJD._.PROJECT_NAME.Contain(search.KeyWord) ||
                              MV_TJ_ALLCREATE_XZJD._.PROJECT_CODE.Contain(search.KeyWord));
            }

            if (search.BeginTime.HasValue)
            {
                condition.And(MV_TJ_ALLCREATE_XZJD._.CREATE_TIME >= search.BeginTime);
            }

            if (search.EndTime.HasValue)
            {
                condition.And(MV_TJ_ALLCREATE_XZJD._.CREATE_TIME <= search.EndTime);
            }

            condition.And(MV_TJ_ALLCREATE_XZJD._.KIND == "GCJS");
            var count = FromWhere()
                .Union(FromWhere<MV_TJ_ALLCREATE_XZJD_HOUR>())
                .Where(condition.ToWhereClip())
                .GroupBy(MV_TJ_ALLCREATE_XZJD._.PROJECT_CODE)
                .Select(MV_TJ_ALLCREATE_XZJD._.PROJECT_CODE).Count();
           
            //var pageList = PageList(condition, search, MV_TJ_ALLCREATE_XZJD._.CREATE_TIME.Desc).ToDataTable(search);
            var list = FromWhere()
                .Union(FromWhere<MV_TJ_ALLCREATE_XZJD_HOUR>())
                .Where(condition.ToWhereClip())
                .GroupBy(MV_TJ_ALLCREATE_XZJD._.PROJECT_CODE, MV_TJ_ALLCREATE_XZJD._.PROJECT_NAME)
                .Page(search.PageSize, search.PageNo)
                .Select(MV_TJ_ALLCREATE_XZJD._.PROJECT_CODE, MV_TJ_ALLCREATE_XZJD._.PROJECT_NAME, MV_TJ_ALLCREATE_XZJD._.CREATE_TIME.Max()
                )
                .OrderBy(new Field("CREATE_TIME").Desc)
                .ToList<object>();
               
            var pageList = list.ToPageTableResult(search, count);
            return pageList;
        }

        #endregion
    }
}
