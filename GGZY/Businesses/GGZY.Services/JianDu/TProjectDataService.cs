using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Model;
using GGZY.Services.Infrastructure.Model.FuWu;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYFW.DbEntity;
//using GGZYFW.DbEntity;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TProjectDataService
    {
        #region 监督服务

        #region 项目查询

        public PageTableResult ProjectSearch(TProjectDataModel model, SearchCondition search)
        {
            var condition = model.ConditionBuilder(search);
            #region 归属地过滤
            var rootAreaCode = JdUser?.RootAreaCode;
            if (!string.IsNullOrWhiteSpace(rootAreaCode))
            {
                var areaCondition = new WhereClipBuilder();
                if (rootAreaCode == "3501")//福州市排除平潭
                {
                    areaCondition.And(T_PROJECT_DATA._.REGION_CODE.BeginWith(rootAreaCode) && T_PROJECT_DATA._.REGION_CODE != "350128");
                }
                else
                {
                    areaCondition.And(T_PROJECT_DATA._.REGION_CODE.BeginWith(rootAreaCode));
                }

            }

            #endregion

            #region 行业过滤

            if (JdUser?.ISALLKIND != 1)
            {
                if (string.IsNullOrWhiteSpace(JdUser?.HY_TYPE))
                {
                    condition.And(T_PROJECT_DATA._.PROJECT_TYPE == "-1");
                }
                else
                {
                    var hyTypes = JdUser.HY_TYPE.Split(',').ToList();
                    condition.And(T_PROJECT_DATA._.PROJECT_TYPE.In(hyTypes));
                }
            }

            #endregion

            var query = FromWhere(condition.ToWhereClip())
                .LeftJoin<GGZYJD.DbEntity.SYS_AREA>(GGZYJD.DbEntity.SYS_AREA._.AREACODE == T_PROJECT_DATA._.REGION_CODE)
                .LeftJoin<GGZYJD.DbEntity.SYS_DIC>(GGZYJD.DbEntity.SYS_DIC._.TYPE == "10" && GGZYJD.DbEntity.SYS_DIC._.VALUE == T_PROJECT_DATA._.PROJECT_TYPE)
                .LeftJoin<GGZYJD.DbEntity.SYS_DIC>(GGZYJD.DbEntity.SYS_DIC._.TYPE == "300" && GGZYJD.DbEntity.SYS_DIC._.VALUE == T_PROJECT_DATA._.PROJECT_CATEGORY);
            var total = query.Count();
            var list = query.Page(search.PageSize, search.PageNo)
                .OrderBy(T_PROJECT_DATA._.CREATE_TIME.Desc)
                .Select(
                    T_PROJECT_DATA._.PROJECT_CODE
                    , T_PROJECT_DATA._.ID
                    , T_PROJECT_DATA._.TP_CODE
                    , T_PROJECT_DATA._.PROJECT_CODE
                    , T_PROJECT_DATA._.PROJECT_NAME
                    , T_PROJECT_DATA._.CREATE_TIME
                    , GGZYJD.DbEntity.SYS_AREA._.AREANAME
                    , T_PROJECT_DATA._.PLATFORM_NAME
                    , GGZYJD.DbEntity.SYS_DIC._.TEXT.As("PROJECT_TYPE_TEXT")
                    , T_PROJECT_DATA._.T_TM
                    , T_PROJECT_DATA._.PROJECT_CATEGORY
                    , new Field("TEXT", "STS_DIC2").As("PROJECT_CATEGORY_TEXT")
                    , new Field("VALUE1", "STS_DIC2").As("PROJECT_CATEGORY_KIND")
                )
                .ToList<TProjectDataModel>();
            var pageList = list.ToPageTableResult(search, total);
            return pageList;
        }

        #endregion


        #region 监督点统计
        /// <summary>
        /// 获取监督点列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult GetProjectMP_List(TProjectDataModel model, SearchCondition search)
        {
            var condition = model.ConditionBuilder(search);

            #region 归属地过滤
            var rootAreaCode = JdUser?.RootAreaCode;
            if (!string.IsNullOrWhiteSpace(rootAreaCode))
            {
                var areaCondition = new WhereClipBuilder();
                if (rootAreaCode == "3501")//福州市排除平潭
                {
                    areaCondition.And(T_PROJECT_DATA._.REGION_CODE.BeginWith(rootAreaCode) && T_PROJECT_DATA._.REGION_CODE != "350128");
                }
                else
                {
                    areaCondition.And(T_PROJECT_DATA._.REGION_CODE.BeginWith(rootAreaCode));
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
                    areaCondition.Or(T_PROJECT_DATA._.REGION_CODE == pCode);
                }
                if (!WhereClip.IsNullOrEmpty(areaCondition.ToWhereClip()))
                {
                    condition.And(areaCondition.ToWhereClip() || GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1.IsNotNull());
                }
                else
                {
                    condition.And(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1.IsNotNull());
                }
            }

            #endregion

            #region 行业过滤

            if (JdUser?.ISALLKIND != 1)
            {
                if (string.IsNullOrWhiteSpace(JdUser?.HY_TYPE))
                {
                    condition.And(T_PROJECT_DATA._.PROJECT_TYPE == "-1");
                }
                else
                {
                    var hyTypes = JdUser.HY_TYPE.Split(',').ToList();
                    condition.And(T_PROJECT_DATA._.PROJECT_TYPE.In(hyTypes));
                }
            }

            #endregion

            #region TENDER_PROJECT_CODE_OLD1 过滤

            var subCon = RECORD_REVIEW._.TENDER_PROJECT_CODE == GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE
                         && RECORD_REVIEW._.REVIEW_STATUS.IsNotNull() &&
                         RECORD_REVIEW._.REVIEW_STATUS != "0"
                         && GGZYJD.DbEntity.TENDER_PROJECT._.M_ID_GGFW.IsNotNull() &&
                         GGZYJD.DbEntity.TENDER_PROJECT._.RECORD_DEPID == JdUser?.DEPARTID;
            var subQuery = Jd.TenderProjectService.FromWhere()
                .InnerJoin<RECORD_REVIEW>(subCon)
                .GroupBy(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1)
                .Select(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1);

            #endregion

            condition.And(T_PROJECT_DATA._.PROJECT_CATEGORY == "1");
            var query = FromWhere(condition.ToWhereClip())
                .InnerJoin<T_TP_TACHE>(T_TP_TACHE._.TP_CODE == T_PROJECT_DATA._.TP_CODE)
                .InnerJoin<T_TP_NODE>(T_TP_NODE._.TACHE_CODE == T_TP_TACHE._.CODE)
                .InnerJoin<T_MP_PLAN_INFO>(T_MP_PLAN_INFO._.NODE_CODE == T_TP_NODE._.CODE)
                .LeftJoin<T_PM_JDINFO>(T_PM_JDINFO._.TENDER_PROJECT_CODE == T_PROJECT_DATA._.PROJECT_CODE &&
                                       T_PM_JDINFO._.MPID == T_MP_PLAN_INFO._.ID)
                .LeftJoin<GGZYJD.DbEntity.SYS_AREA>(GGZYJD.DbEntity.SYS_AREA._.AREACODE == T_PROJECT_DATA._.REGION_CODE)
                .LeftJoin<GGZYJD.DbEntity.SYS_DIC>(GGZYJD.DbEntity.SYS_DIC._.TYPE == "51" && GGZYJD.DbEntity.SYS_DIC._.VALUE == T_MP_PLAN_INFO._.KIND)
                .LeftJoin<GGZYJD.DbEntity.SYS_DIC>(GGZYJD.DbEntity.SYS_DIC._.TYPE == "2002" && GGZYJD.DbEntity.SYS_DIC._.VALUE == T_PROJECT_DATA._.PROJECT_TYPE)
                .LeftJoinTmp<GGZYJD.DbEntity.TENDER_PROJECT>(subQuery,
                    GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1 == T_PROJECT_DATA._.PROJECT_CODE);

            var total = query.Count();
            var list = query.OrderBy(T_PM_JDINFO._.UPDATE_TM.Nvl("TO_DATE('1970-01-01 00:00:00','yyyy-mm-dd hh24:mi:ss')").Desc)
                .Page(search.PageSize, search.PageNo)
                .Select(
                    T_PROJECT_DATA._.All,
                    T_TP_TACHE._.NAME.As("TACHE_NAME"),
                    T_PM_JDINFO._.LEVEL_TYPE.Nvl(0).As("LEVEL_TYPE"),
                    T_PM_JDINFO._.LEVEL_TYPE.Nvl(0).As("LEVEL_TYPE_TEXT"),
                    T_MP_PLAN_INFO._.ID.As("MPID"),
                    T_MP_PLAN_INFO._.NAME.As("MPNAME"),
                    T_MP_PLAN_INFO._.ISUSER,
                    T_PM_JDINFO._.UPDATE_TM,
                    GGZYJD.DbEntity.SYS_DIC._.TEXT.As("KIND_TEXT"),
                   GGZYJD.DbEntity.SYS_AREA._.AREANAME.As("REGION_CODE_TEXT"),
                    new Field("TEXT", "SYS_DIC2").As("PROJECT_TYPE_TEXT")
                    )
                .ToList<TProjectDataModel>();
            var pagelist = list.ToPageTableResult(search, total);
            return pagelist;
        }

        /// <summary>
        /// 获取监督点列表计数
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public object GetProjectMP_Count(TProjectDataModel model, SearchCondition search)
        {
            var condition = model.ConditionBuilder(search);

            #region 归属地过滤
            var rootAreaCode = JdUser?.RootAreaCode;
            if (!string.IsNullOrWhiteSpace(rootAreaCode))
            {
                var areaCondition = new WhereClipBuilder();
                if (rootAreaCode == "3501")//福州市排除平潭
                {
                    areaCondition.And(T_PROJECT_DATA._.REGION_CODE.BeginWith(rootAreaCode) && T_PROJECT_DATA._.REGION_CODE != "350128");
                }
                else
                {
                    areaCondition.And(T_PROJECT_DATA._.REGION_CODE.BeginWith(rootAreaCode));
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
                    areaCondition.Or(T_PROJECT_DATA._.REGION_CODE == pCode);
                }
                if (!WhereClip.IsNullOrEmpty(areaCondition.ToWhereClip()))
                {
                    condition.And(areaCondition.ToWhereClip() || GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1.IsNotNull());
                }
                else
                {
                    condition.And(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1.IsNotNull());
                }
            }

            #endregion

            #region 行业过滤

            if (JdUser?.ISALLKIND != 1)
            {
                if (string.IsNullOrWhiteSpace(JdUser?.HY_TYPE))
                {
                    condition.And(T_PROJECT_DATA._.PROJECT_TYPE == "-1");
                }
                else
                {
                    var hyTypes = JdUser.HY_TYPE.Split(',').ToList();
                    condition.And(T_PROJECT_DATA._.PROJECT_TYPE.In(hyTypes));
                }
            }

            #endregion

            #region TENDER_PROJECT_CODE_OLD1 过滤

            var subCon = RECORD_REVIEW._.TENDER_PROJECT_CODE == GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE
                         && RECORD_REVIEW._.REVIEW_STATUS.IsNotNull() &&
                         RECORD_REVIEW._.REVIEW_STATUS != "0"
                         && GGZYJD.DbEntity.TENDER_PROJECT._.M_ID_GGFW.IsNotNull() &&
                        GGZYJD.DbEntity.TENDER_PROJECT._.RECORD_DEPID == JdUser?.DEPARTID;
            var subQuery = Jd.TenderProjectService.FromWhere()
                .InnerJoin<RECORD_REVIEW>(subCon)
                .GroupBy(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1)
                .Select(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1);

            #endregion

            condition.And(T_PROJECT_DATA._.PROJECT_CATEGORY == "1");
            var query = FromWhere(condition.ToWhereClip())
                .InnerJoin<T_TP_TACHE>(T_TP_TACHE._.TP_CODE == T_PROJECT_DATA._.TP_CODE)
                .InnerJoin<T_TP_NODE>(T_TP_NODE._.TACHE_CODE == T_TP_TACHE._.CODE)
                .InnerJoin<T_MP_PLAN_INFO>(T_MP_PLAN_INFO._.NODE_CODE == T_TP_NODE._.CODE)
                .LeftJoin<T_PM_JDINFO>(T_PM_JDINFO._.TENDER_PROJECT_CODE == T_PROJECT_DATA._.PROJECT_CODE &&
                                       T_PM_JDINFO._.MPID == T_MP_PLAN_INFO._.ID)
                //.LeftJoin<SYS_AREA>(SYS_AREA._.AREACODE == T_PROJECT_DATA._.REGION_CODE)
                //.LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "51" && SYS_DIC._.VALUE == T_MP_PLAN_INFO._.KIND)
                //.LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "2002" && SYS_DIC._.VALUE == T_PROJECT_DATA._.PROJECT_TYPE)
                .LeftJoinTmp<GGZYJD.DbEntity.TENDER_PROJECT>(subQuery,
                    GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1 == T_PROJECT_DATA._.PROJECT_CODE);

            var obj = query
                .Select(
                    new Field("NVL(SUM(1),0)").As("COUNT"),
                    new Field("NVL(SUM(CASE WHEN T_PM_JDINFO.LEVEL_TYPE = '2' THEN 1 WHEN T_PM_JDINFO.LEVEL_TYPE = '3' THEN 1 ELSE 0 END),0)").As("YC_COUNT"),
                    new Field("NVL(SUM(CASE WHEN T_PM_JDINFO.LEVEL_TYPE = '1' THEN 1 ELSE 0 END),0)").As("ZC_COUNT"),
                    new Field("NVL(SUM(CASE WHEN T_PM_JDINFO.LEVEL_TYPE = '2' THEN 1 ELSE 0 END),0)").As("YELLOW_COUNT"),
                    new Field("NVL(SUM(CASE WHEN T_PM_JDINFO.LEVEL_TYPE = '3' THEN 1 ELSE 0 END),0)").As("RED_COUNT")
                    )
                .ToFirst<object>();
            return obj;
        }
        /// <summary>
        /// 获取工程建设监督点数据
        /// </summary>
        /// <returns></returns>
        public List<SelectModel> GetMPZtree()
        {
            return Cache.Get("GetMPZtree", () =>
             {
                 var r = new List<SelectModel>();
                 var taches =
                     Jd.TTpTacheService.FindList(T_TP_TACHE._.TP_CODE == "FJ00111001", T_TP_TACHE._.ORDER_ID.Asc);
                 var nodes = Jd.TTpNodeService.FindAll(); //环节
                 var mps = Jd.TMpPlanInfoService.FindAll(); //监督点

                 #region 环节

                 foreach (var tache in taches)
                 {
                     #region 节点

                     var nodeTrees = new List<SelectModel>();
                     var subNodes = nodes.FindAll(c => c.TACHE_CODE == tache.CODE).OrderBy(c => c.ORDER_ID).ToList();
                     foreach (var node in subNodes)
                     {
                         #region 监督点

                         var mpTrees = new List<SelectModel>();
                         var subMps = mps.FindAll(c => c.NODE_CODE == node.CODE);
                         foreach (var mp in subMps)
                         {
                             mpTrees.Add(new SelectModel
                             {
                                 Label = mp.NAME,
                                 Value = mp.ID?.ToString(),
                             });
                         }

                         #endregion

                         var nodeTree = new SelectModel
                         {
                             Label = node.NAME,
                             Value = node.CODE,
                             Children = mpTrees
                         };
                         nodeTrees.Add(nodeTree);
                     }

                     #endregion

                     var tacheTree = new SelectModel
                     {
                         Label = tache.NAME,
                         Value = tache.CODE,
                         Children = nodeTrees
                     };
                     r.Add(tacheTree);
                 }

                 #endregion

                 return r;
             });
        }
        #endregion

        #endregion

        #region 监督首页-监督点查询

        public object GetJDD_Data(MonitorHomePageModel model)
        {
            #region 查询条件

            var whereBuilder = new WhereClipBuilder();
            var regionBuilder = new WhereClipBuilder();
            var industryBuilder = new WhereClipBuilder();
            if (model.BeginTime.HasValue)
            {
                whereBuilder.And(T_PROJECT_DATA._.CREATE_TIME >= model.BeginTime);
            }
            if (model.EndTime.HasValue)
            {
                whereBuilder.And(T_PROJECT_DATA._.CREATE_TIME <= model.EndTime);
            }

            if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
            {

                if (model.REGION_CODE.Equals("3501"))
                {
                    whereBuilder.And(T_PROJECT_DATA._.REGION_CODE.Contain(model.REGION_CODE) && T_PROJECT_DATA._.REGION_CODE != "350128");
                }
                else
                {
                    whereBuilder.And(T_PROJECT_DATA._.REGION_CODE.Contain(model.REGION_CODE));
                }
                if (model.REGION_CODE.Equals("35"))//地区(全省统计，加载平潭)
                {
                    regionBuilder.And($"SYS_AREA_QUANGUO.AREACODE LIKE '{model.REGION_CODE}__00' OR AREACODE='350128'");
                }
                else if (model.REGION_CODE.Equals("350128"))
                {
                    regionBuilder.And(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE == "350128");
                }
                else//地区(地市统计，排除平潭)
                {
                    regionBuilder.And($"SYS_AREA_QUANGUO.AREACODE LIKE '{model.REGION_CODE}__' And AREACODE='350128'");
                }

            }
            var kinds = JdUser?.UserDepartment?.HY_TYPE_LIST;
            if (kinds != null && kinds.Any())
            {
                whereBuilder.And(GGZYJD.DbEntity.SYS_DIC._.VALUE.In(kinds));
                if (string.IsNullOrWhiteSpace(model.HY_TYPE))
                {
                    industryBuilder.And(GGZYJD.DbEntity.SYS_DIC._.VALUE.In(kinds) && GGZYJD.DbEntity.SYS_DIC._.TYPE == 76);
                }
            }

            if (!string.IsNullOrWhiteSpace(model.HY_TYPE))
            {
                whereBuilder.And(GGZYJD.DbEntity.SYS_DIC._.VALUE == model.HY_TYPE);
                industryBuilder.And(GGZYJD.DbEntity.SYS_DIC._.VALUE2 == model.HY_TYPE && GGZYJD.DbEntity.SYS_DIC._.TYPE == 63);
            }

            var where = whereBuilder.ToWhereClip();

            #endregion
            #region 状态统计 GZGK_MANAGE.Get_JDD_ZT

            var stateData = FromWhere(where)
                .InnerJoin<T_TP_TACHE>(T_TP_TACHE._.TP_CODE == T_PROJECT_DATA._.TP_CODE)
                .InnerJoin<T_TP_NODE>(T_TP_NODE._.TACHE_CODE == T_TP_TACHE._.CODE)
                .InnerJoin<T_MP_PLAN_INFO>(T_MP_PLAN_INFO._.NODE_CODE == T_TP_NODE._.CODE)
                .LeftJoin<T_PM_JDINFO>(T_PM_JDINFO._.TENDER_PROJECT_CODE == T_PROJECT_DATA._.PROJECT_CODE &&
                                       T_PM_JDINFO._.MPID == T_MP_PLAN_INFO._.ID)
                .LeftJoin<GGZYJD.DbEntity.SYS_DIC>(GGZYJD.DbEntity.SYS_DIC._.TYPE == 76 && GGZYJD.DbEntity.SYS_DIC._.VALUE3 == T_PROJECT_DATA._.TYPE.ToChar())
                .Select(
                T_PROJECT_DATA._.All.Count().As("ZS_NUM")
                , new Field("(CASE WHEN T_PM_JDINFO.LEVEL_TYPE = '2' THEN 1 WHEN T_PM_JDINFO.LEVEL_TYPE = '3' THEN 1 ELSE 0 END) ").Sum().Nvl(0).As("DB_NUM")//YC_NUM
                , new Field("(CASE WHEN T_PM_JDINFO.LEVEL_TYPE = '2' THEN 1 ELSE 0 END) ").Sum().Nvl(0).As("YB_NUM")//YELLOW_NUM
                , new Field("(CASE WHEN T_PM_JDINFO.LEVEL_TYPE = '3' THEN 1 ELSE 0 END) ").Sum().Nvl(0).As("CQ_NUM")//RED_NUM
                )
                .ToFirst<MonitorHomePageSummaryStatisticsModel>();



            #endregion
            #region 地区统计 GZGK_MANAGE.Get_JDD_DQ

            var projectDataQuery = FromWhere(where)
                .InnerJoin<T_TP_TACHE>(T_TP_TACHE._.TP_CODE == T_PROJECT_DATA._.TP_CODE)
                .InnerJoin<T_TP_NODE>(T_TP_NODE._.TACHE_CODE == T_TP_TACHE._.CODE)
                .InnerJoin<T_MP_PLAN_INFO>(T_MP_PLAN_INFO._.NODE_CODE == T_TP_NODE._.CODE)
                .LeftJoin<T_PM_JDINFO>(T_PM_JDINFO._.TENDER_PROJECT_CODE == T_PROJECT_DATA._.PROJECT_CODE &&
                                       T_PM_JDINFO._.MPID == T_MP_PLAN_INFO._.ID)
                .LeftJoin<GGZYJD.DbEntity.SYS_DIC>(GGZYJD.DbEntity.SYS_DIC._.TYPE == 76 && GGZYJD.DbEntity.SYS_DIC._.VALUE3 == T_PROJECT_DATA._.TYPE.ToChar());
            if ("35".Equals(model.REGION_CODE))
            {
                //ON (CASE TO_CHAR(A.REGION_CODE) WHEN '350128' THEN A.REGION_CODE ELSE SUBSTR(A.REGION_CODE,1,4) END) = (CASE G.AREACODE WHEN '350128' THEN G.AREACODE ELSE SUBSTR(G.AREACODE,1,4) END) 
                projectDataQuery.InnerJoin<GGZYJD.DbEntity.SYS_AREA_QUANGUO>("(CASE TO_CHAR(T_PROJECT_DATA.REGION_CODE) WHEN '350128' THEN T_PROJECT_DATA.REGION_CODE ELSE SUBSTR(T_PROJECT_DATA.REGION_CODE,1,4) END) = (CASE SYS_AREA_QUANGUO.AREACODE WHEN '350128' THEN SYS_AREA_QUANGUO.AREACODE ELSE SUBSTR(SYS_AREA_QUANGUO.AREACODE,1,4) END)");
            }
            else
            {
                projectDataQuery.InnerJoin<GGZYJD.DbEntity.SYS_AREA_QUANGUO>(
                    regionBuilder.ToWhereClip() && T_PROJECT_DATA._.REGION_CODE == GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE);
            }

            #endregion
            #region 类型统计 GZGK_MANAGE.Get_JDD_LX



            #endregion
            return new
            {
                stateData = new List<LabelValueModel>
                {
                    new LabelValueModel{Label = "监督点",Value = stateData.ZS_NUM.ToString()},
                    new LabelValueModel{Label = "异常监督点总数",Value = stateData.DB_NUM.ToString()},
                    new LabelValueModel{Label = "黄灯预警",Value = stateData.YB_NUM.ToString()},
                    new LabelValueModel{Label = "红灯预警",Value = stateData.CQ_NUM.ToString()},
                },
                regionData = new { },
                typeData = new { }
            };
        }


        #endregion

        #region 项目监督统计（新）
        protected WhereClipBuilder ProjectCondition(Project_Model model, SearchCondition search)
        {
            #region condition 条件拼接

            var condition = new WhereClipBuilder();
            //状态
            if (!string.IsNullOrWhiteSpace(model.RESULT_STATUS))
            {
                condition.And(WARN_RESULT._.RESULT_STATUS.In(model.RESULT_STATUS));
            }
            //招标项目编号
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
            {
                condition.And(WARN_RESULT._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
            }
            //招标项目名称
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
            {
                condition.And(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
            }
            //时间
            if (search.BeginTime.HasValue)
            {
                condition.And(WARN_RESULT._.SP_TIME >= search.BeginTime);
            }
            if (search.EndTime.HasValue)
            {
                condition.And(WARN_RESULT._.SP_TIME <= search.EndTime);
            }
            //所在地区
            if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
            {
                condition.And(WARN_RESULT._.REGION_CODE == (model.REGION_CODE));
            }
            //业务类型
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
            {
                condition.And(WARN_RESULT._.TENDER_PROJECT_TYPE == (model.TENDER_PROJECT_TYPE));
            }

            //}
            #endregion

            #region 组织机构所在归属地过滤

            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode;
            if (!string.IsNullOrWhiteSpace(rootAreaCode))
            {
                condition.And(WARN_RESULT._.REGION_CODE.BeginWith(rootAreaCode));
                if (rootAreaCode == "3501")
                {
                    condition.And(WARN_RESULT._.REGION_CODE != "350128");
                }
            }

            #endregion

            #region 组织机构可查看行业过滤

            var hyTypes = JdUser?.UserDepartment?.SYS_DIC_63;
            if (hyTypes != null && hyTypes.Any())
            {
                var projectTypes = hyTypes.Select(c => c.VALUE3).ToList();//A01 A02
                condition.And(WARN_RESULT._.TENDER_PROJECT_TYPE.In(projectTypes));
            }

            #endregion

            return condition;
        }
        public List<LabelValueModel> ProjectJDCount(Project_Model model, SearchCondition search)
        {
            var condition = ProjectCondition(model, search);


            var normal = Fw.WarnResultService.FromWhere(condition.ToWhereClip() && WARN_RESULT._.RESULT_STATUS == 1)
               .InnerJoin<GGZYJD.DbEntity.TENDER_PROJECT>(WARN_RESULT._.TENDER_PROJECT_CODE == GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE)
               .Select(new Field("'正常监督点（个）'").As("Label"), Field.All.Count().As("Value"));

            var yellow = Fw.WarnResultService.FromWhere(condition.ToWhereClip() && WARN_RESULT._.RESULT_STATUS == 2)
                .InnerJoin<GGZYJD.DbEntity.TENDER_PROJECT>(WARN_RESULT._.TENDER_PROJECT_CODE == GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE)
                .Select(new Field("'黄灯（个）'").As("Label"), Field.All.Count().As("Value"));

            var red = Fw.WarnResultService.FromWhere(condition.ToWhereClip() && WARN_RESULT._.RESULT_STATUS == 3)
               .InnerJoin<GGZYJD.DbEntity.TENDER_PROJECT>(WARN_RESULT._.TENDER_PROJECT_CODE == GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE)
               .Select(new Field("'红灯（个）'").As("Label"), Field.All.Count().As("Value"));

            //var nouse = Fw.WarnResultService.FromWhere(condition.ToWhereClip() && WARN_RESULT._.RESULT_STATUS == 0)
            //    .InnerJoin<GGZYJD.DbEntity.TENDER_PROJECT>(WARN_RESULT._.TENDER_PROJECT_CODE == GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE)
            //    .Select(new Field("'未监督点（个）'").As("Label"), Field.All.Count().As("Value"));

            var r = Fw.WarnResultService.FromWhere(condition.ToWhereClip())
               .InnerJoin<GGZYJD.DbEntity.TENDER_PROJECT>(WARN_RESULT._.TENDER_PROJECT_CODE == GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE)
                .Select(new Field("'监督点总数（个）'").As("Label"), Field.All.Count().As("Value"))
                .UnionAll(normal)
                .UnionAll(yellow)
                .UnionAll(red)
                //  .UnionAll(nouse)
                .ToList<LabelValueModel>();

            return r;
        }

        #endregion

        #region 项目监督列表查询（新）
        public PageTableResult ProjectList(Project_Model model, SearchCondition search)
        {
            var hylist = JdUser?.UserDepartment?.FW_TENDER_PROJECT_TYPES;//??new List<string>{ "A01", "A02", "A99-1", "A07", "A03-1", "A03-2", "A06", "A99-2", "A96", "A97", "A13", "A14" };
            var rootCode = JdUser?.UserDepartment?.RootAreaCode;// ?? "35";
            if (hylist != null && hylist.Any() && !string.IsNullOrWhiteSpace(rootCode))
            {
                var condition = new WhereClipBuilder();

                //行业  JdUser.UserDepartment.HY_TYPE_List 
                condition.And(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(hylist));
                //归属地 归属地 JdUser.UserDepartment.RootAreaCode REGION_COUNTY
                condition.And(GGZYFW.DbEntity.TENDER_PROJECT._.REGION_CODE.BeginWith(rootCode));

                #region 查询条件

                //招标项目编号
                if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
                {
                    condition.And(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
                }
                //招标项目名称
                if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
                {
                    condition.And(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
                }
                //时间
                if (search.BeginTime.HasValue)
                {
                    condition.And(GGZYFW.DbEntity.TENDER_PROJECT._.CREATE_TIME >= search.BeginTime);
                }
                if (search.EndTime.HasValue)
                {
                    condition.And(GGZYFW.DbEntity.TENDER_PROJECT._.CREATE_TIME <= search.EndTime);
                }
                //所在地区
                if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
                {
                    condition.And(GGZYFW.DbEntity.TENDER_PROJECT._.REGION_CODE == (model.REGION_CODE));
                }
                //业务类型
                if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))//A01 =>A01 G01
                {
                    var gType = model.TENDER_PROJECT_TYPE.Replace("A", "G");
                    condition.And(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_TYPE == (model.TENDER_PROJECT_TYPE) || GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_TYPE == gType);
                }

                //状态
                if (!string.IsNullOrWhiteSpace(model.RESULT_STATUS))
                {
                    condition.And(WARN_RESULT._.RESULT_STATUS == model.RESULT_STATUS);
                }
                #endregion

                var warnResultTmp = Fw.WarnResultService.FromWhere()
                    .GroupBy(WARN_RESULT._.TENDER_PROJECT_CODE)
                    .Select(
                        new Field("(CASE WHEN RESULT_STATUS='0' THEN 1 ELSE 0 END)").Sum().As("PRIMARY"),
                        new Field("(CASE WHEN RESULT_STATUS='1' THEN 1 ELSE 0 END)").Sum().As("NORMAL"),
                        new Field("(CASE WHEN RESULT_STATUS='2' THEN 1 ELSE 0 END)").Sum().As("WARNING"),
                        new Field("(CASE WHEN RESULT_STATUS='3' THEN 1 ELSE 0 END)").Sum().As("STRANG"),
                       new Field("SUM(1)").As("ALL"),
                        WARN_RESULT._.RESULT_STATUS.Max().Nvl(0).As("RESULT_STATUS"),
                        WARN_RESULT._.TENDER_PROJECT_CODE);

                //数据记录条数
                var total = Fw.TenderProjectService.FromWhere(condition.ToWhereClip())
                    .LeftJoinTmp<WARN_RESULT>(warnResultTmp, GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == WARN_RESULT._.TENDER_PROJECT_CODE)
                    .Count();


                //列表返回值
                var list = Fw.TenderProjectService.FromWhere(condition.ToWhereClip())

                    .LeftJoin<GGZYFW.DbEntity.SYS_AREA_QUANGUO>(GGZYFW.DbEntity.SYS_AREA_QUANGUO._.AREACODE == GGZYFW.DbEntity.TENDER_PROJECT._.REGION_CODE)
                    .LeftJoin<GGZYFW.DbEntity.SYS_DIC>(GGZYFW.DbEntity.SYS_DIC._.TYPE == "2002" && GGZYFW.DbEntity.SYS_DIC._.VALUE == GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_TYPE) //工程类别
                    .LeftJoinTmp<WARN_RESULT>(warnResultTmp, GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == WARN_RESULT._.TENDER_PROJECT_CODE)
                    .Page(search.PageSize, search.PageNo)
                    .OrderBy(GGZYFW.DbEntity.TENDER_PROJECT._.CREATE_TIME.Desc)
                    .Select(
                      //todo 前端状态
                      GGZYFW.DbEntity.TENDER_PROJECT._.M_ID.As("M_ID"),
                      GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE,
                      GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_NAME.As("TENDER_PROJECT_NAME"),
                      GGZYFW.DbEntity.SYS_DIC._.TEXT.As("TENDER_PROJECT_TYPE"),
                      GGZYFW.DbEntity.SYS_AREA_QUANGUO._.AREANAME.As("REGION_CODE"),
                      GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1.As("TENDER_PROJECT_CODE_OLD1"),
                      GGZYFW.DbEntity.SYS_DIC._.VALUE2.As("APPROVAL_DEPNAME"),//需要修改，只返回空字符，未错误的
                      GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_TYPE.As("G_TENDER_PROJECT_TYPE"), //用于返回G01,G02....
                      new Field("PRIMARY", "WARN_RESULT"),
                      new Field("NORMAL", "WARN_RESULT"),
                      new Field("WARNING", "WARN_RESULT"),
                      new Field("STRANG", "WARN_RESULT"),
                      WARN_RESULT._.RESULT_STATUS
                    )
                    .ToList<Project_Model>();
                list.ForEach(c =>
                {
                    if (c.STRANG > 0)
                    {
                        c.RESULT_STATUS = "3";
                    }
                    else if (c.WARNING > 0)
                    {
                        c.RESULT_STATUS = "2";
                    }
                    else if (c.NORMAL > 0)
                    {
                        c.RESULT_STATUS = "1";
                    }
                    else
                    {
                        c.RESULT_STATUS = "0";
                    }
                });
                //返回列表值
                var pageList = list.ToPageTableResult(search, total);
                return pageList;
            }

            return search.ToPageTableResult();

        }
        #endregion

        #region 监督点列表接口（新）
        /// <summary>
        /// 获取监督点列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult PointList(JD_Model model, SearchCondition search)
        {
            var hylist = JdUser?.UserDepartment?.TENDER_PROJECT_TYPES;
            var rootCode = JdUser?.UserDepartment?.RootAreaCode;
            if (hylist != null && hylist.Any() && !string.IsNullOrWhiteSpace(rootCode))
            {
                var condition = new WhereClipBuilder();

                // 行业  JdUser.UserDepartment.HY_TYPE_List 
                condition.And(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(hylist));
                //归属地 归属地 JdUser.UserDepartment.RootAreaCode REGION_COUNTY
                condition.And(WARN_RESULT._.REGION_CODE.BeginWith(rootCode));

                #region 查询条件


                //监督点名称
                if (!string.IsNullOrWhiteSpace(model.SP_NAME))
                {
                    condition.And(WARN_EXPRESSION._.SP_NAME.Contain(model.SP_NAME));
                }
                //监督点类型
                if (!string.IsNullOrWhiteSpace(model.SP_TYPE))
                {

                    condition.And(WARN_EXPRESSION._.SP_TYPE == model.SP_TYPE);
                }
                //监督方式
                if (!string.IsNullOrWhiteSpace(model.SP_WAY))
                {

                    condition.And(WARN_EXPRESSION._.SP_WAY == (model.SP_WAY));
                }
                //时间
                if (search.BeginTime.HasValue)
                {
                    condition.And(WARN_RESULT._.SP_TIME >= search.BeginTime);
                }
                if (search.EndTime.HasValue)
                {
                    condition.And(WARN_RESULT._.SP_TIME <= search.EndTime);
                }
                //所在地区
                if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
                {
                    condition.And(WARN_RESULT._.REGION_CODE == (model.REGION_CODE));
                }
                //业务类型
                if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
                {
                    condition.And(WARN_RESULT._.TENDER_PROJECT_TYPE == (model.TENDER_PROJECT_TYPE));
                }
                //所属环节
                if (!string.IsNullOrWhiteSpace(model.SP_FLOW_NAME))
                {
                    condition.And(WARN_EXPRESSION._.SP_FLOW_NAME == model.SP_FLOW_NAME);
                }
                //状态
                if (!string.IsNullOrWhiteSpace(model.SP_STATUS))
                {
                    condition.And(WARN_RESULT._.RESULT_STATUS == model.SP_STATUS);
                }
                #endregion
                //数据记录条数
                //SYS_DIC字典表
                var total = Fw.WarnResultService.FromWhere(condition.ToWhereClip())
                    .LeftJoin<WARN_EXPRESSION>(WARN_RESULT._.SP_ID == WARN_EXPRESSION._.M_ID)
                    .LeftJoin<GGZYJD.DbEntity.TENDER_PROJECT>(WARN_RESULT._.TENDER_PROJECT_CODE == GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE)
                    .LeftJoin<GGZYJD.DbEntity.SYS_DIC>(GGZYJD.DbEntity.SYS_DIC._.TYPE == "2002" && GGZYJD.DbEntity.SYS_DIC._.VALUE == GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_TYPE) //工程类别
                    .LeftJoin<GGZYJD.DbEntity.SYS_AREA_QUANGUO>(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE == WARN_RESULT._.REGION_CODE)
                    .Count();
                //列表返回值
                var list = Fw.WarnResultService.FromWhere(condition.ToWhereClip())
                          .LeftJoin<WARN_EXPRESSION>(WARN_RESULT._.SP_ID == WARN_EXPRESSION._.M_ID)
                          .LeftJoin<GGZYJD.DbEntity.TENDER_PROJECT>(WARN_RESULT._.TENDER_PROJECT_CODE == GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE)
                          .LeftJoin<GGZYJD.DbEntity.SYS_DIC>(GGZYJD.DbEntity.SYS_DIC._.TYPE == "2002" && GGZYJD.DbEntity.SYS_DIC._.VALUE == GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_TYPE) //工程类别
                          .LeftJoin<GGZYJD.DbEntity.SYS_AREA_QUANGUO>(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE == WARN_RESULT._.REGION_CODE)
                          .Where(condition.ToWhereClip())
                          //分页页码
                          .Page(search.PageSize, search.PageNo)
                          .Select(
                            //todo 前端状态
                            WARN_RESULT._.M_ID,
                            WARN_RESULT._.TENDER_PROJECT_CODE.As("TENDER_PROJECT_CODE"),
                            WARN_RESULT._.RESULT_STATUS.As("SP_STATUS"),
                            WARN_EXPRESSION._.CREATE_TIME.As("SP_TIME"),
                            WARN_EXPRESSION._.SP_NAME,
                            WARN_EXPRESSION._.SP_TYPE,
                            WARN_EXPRESSION._.SP_WAY,
                            WARN_EXPRESSION._.SP_FLOW_NAME,
                            GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_NAME.As("TENDER_PROJECT_NAME"),
                            GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREANAME.As("REGION_CODE"),
                            GGZYJD.DbEntity.SYS_DIC._.TEXT.As("TENDER_PROJECT_TYPE"),
                            //需要修改，只返回空字符,需重构
                            GGZYJD.DbEntity.SYS_DIC._.VALUE2.As("APPROVAL_DEPNAME"),
                            //用于返回G01,G02....
                            WARN_RESULT._.TENDER_PROJECT_TYPE.As("G_TENDER_PROJECT_TYPE")
                   ).ToList<dynamic>();

                //返回列表值
                var pageList = list.ToPageTableResult(search, total);
                return pageList;
            }

            return search.ToPageTableResult();

        }




        #endregion

        #region 监督点详情
        /// <summary>
        /// 监督点信息
        /// </summary>
        /// <param name="mId"></param>
        /// <returns></returns>
        public object WarnResultDetail(string mId)
        {
            var warnResult = FromWhere<WARN_RESULT>(WARN_RESULT._.M_ID == mId)
                .LeftJoin<WARN_EXPRESSION>(WARN_RESULT._.SP_ID == WARN_EXPRESSION._.M_ID && WARN_EXPRESSION._.ISDELETE != 1)
                .Select(
                    WARN_EXPRESSION._.SP_NAME,
                    WARN_EXPRESSION._.SP_TYPE,
                    WARN_EXPRESSION._.SP_FLOW_NAME,
                    WARN_EXPRESSION._.SP_NODE_NAME,
                    WARN_EXPRESSION._.SP_POINT_TYPE,
                    WARN_EXPRESSION._.SP_WAY,
                    WARN_EXPRESSION._.SP_STATUS,
                    WARN_RESULT._.CONTENT
                    )
                .ToFirst<FwWarnResultExpressionModel>();
            var warnRecords =
                Fw.WarnRecordService.FindList(WARN_RECORD._.SP_RESULT_ID == mId && WARN_RECORD._.ISDELETE != 1);

            //var dynamic = FromWhere<WARN_RESULT>(WARN_RESULT._.M_ID == mId)
            //    .LeftJoin<WARN_RECORD>(WARN_RECORD._.SP_RESULT_ID==WARN_RESULT._.M_ID  )
            //    .Select(
            //    WARN_RECORD._.CREATE_TIME.As("CREATE_TIME"),
            //    WARN_RESULT._.RESULT_STATUS.As("T_RESULT_STATUS"),
            //    WARN_RECORD._.CONTENT.As("T_CONTENT")
            //    ).ToList<dynamic>();


            return new
            {
                JDDXXNR = warnResult,
                JDDDT = warnRecords,
                //  JDDD= dynamic
            };
        }
        protected string GetJdTenderProjectCodeOld1(ProjectSupervisionResponseHyModel model)
        {
            var tenderProjectCodeOld1 = string.Empty;
            switch (model.TYPE)
            {
                case nameof(T_AFC_PROJECT):
                    tenderProjectCodeOld1 = Jd.TAfcProjectService.FromWhere(T_AFC_PROJECT._.ID == model.ID)
                        .InnerJoin<GGZYJD.DbEntity.PROJECT>(GGZYJD.DbEntity.PROJECT._.CONSTRUCTION_ID == T_AFC_PROJECT._.CODE)
                        .InnerJoin<GGZYJD.DbEntity.TENDER_PROJECT>(GGZYJD.DbEntity.TENDER_PROJECT._.PROJECT_CODE == GGZYJD.DbEntity.PROJECT._.PROJECT_CODE)
                        .Select(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1).ToScalar<string>();
                    break;
                case nameof(RECORD_REVIEW):
                    tenderProjectCodeOld1 = Jd.RecordReviewService.FromWhere(RECORD_REVIEW._.ID == model.ID)
                        .InnerJoin<GGZYJD.DbEntity.TENDER_PROJECT>(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == RECORD_REVIEW._.TENDER_PROJECT_CODE)
                        .Select(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1).ToScalar<string>();
                    break;
                case nameof(PT_ZXTS):

                    tenderProjectCodeOld1 = Jd.PtZxtsService.FromWhere(PT_ZXTS._.ID == model.ID)
                        .InnerJoin<GGZYJD.DbEntity.TENDER_PROJECT>(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == PT_ZXTS._.TENDER_PROJECT_CODE)
                        .Select(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1).ToScalar<string>();
                    break;
                case nameof(GGZYFW.DbEntity.WARN_RESULT):
                    tenderProjectCodeOld1 = Fw.WarnResultService.FirstOrNull(GGZYFW.DbEntity.WARN_RESULT._.M_ID == model.ID)?.TENDER_PROJECT_CODE;
                    break;
            }

            return tenderProjectCodeOld1;
        }

        public PageTableResult Sxjd(ProjectSupervisionResponseHyModel model, SearchCondition search)
        {
            var r = search.ToPageTableResult();
            var tenderProjectCodeOld1 = GetJdTenderProjectCodeOld1(model);

            if (!string.IsNullOrWhiteSpace(tenderProjectCodeOld1))
            {
                var count = Fw.WarnResultService.Count(GGZYFW.DbEntity.WARN_RESULT._.TENDER_PROJECT_CODE == tenderProjectCodeOld1);
                if (count > 0)
                {
                    var list = Fw.WarnResultService.FromWhere(GGZYFW.DbEntity.WARN_RESULT._.TENDER_PROJECT_CODE == tenderProjectCodeOld1 && GGZYFW.DbEntity.WARN_RESULT._.RESULT_STATUS == 3)
                        .InnerJoin<GGZYFW.DbEntity.TENDER_PROJECT>(GGZYFW.DbEntity.WARN_RESULT._.TENDER_PROJECT_CODE == GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE)
                        .InnerJoin<GGZYFW.DbEntity.WARN_EXPRESSION>(GGZYFW.DbEntity.WARN_EXPRESSION._.M_ID == GGZYFW.DbEntity.WARN_RESULT._.SP_ID)
                        .OrderBy(GGZYFW.DbEntity.WARN_RESULT._.SP_TIME.Desc)
                        .Page(search.PageSize, search.PageNo)
                        .Select(
                            GGZYFW.DbEntity.WARN_RESULT._.M_ID,
                            GGZYFW.DbEntity.WARN_RESULT._.TENDER_PROJECT_CODE,
                            GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_NAME,
                            GGZYFW.DbEntity.WARN_EXPRESSION._.SP_NAME,
                            GGZYFW.DbEntity.WARN_EXPRESSION._.SP_WAY,
                            GGZYFW.DbEntity.WARN_RESULT._.RESULT_STATUS,
                            GGZYFW.DbEntity.WARN_RESULT._.SP_TIME
                        ).ToList<object>();
                    r = list.ToPageTableResult(search, count);
                }


            }
            return r;
        }


        #endregion

        #region 监督点统计（新）
        protected WhereClipBuilder PointCondition(JD_Model model, SearchCondition search)
        {
            #region condition 条件拼接

            var condition = new WhereClipBuilder();
            //状态
            if (!string.IsNullOrWhiteSpace(model.SP_STATUS))
            {
                condition.And(WARN_RESULT._.RESULT_STATUS == model.SP_STATUS);
            }
            //监督点名称
            if (!string.IsNullOrWhiteSpace(model.SP_NAME))
            {
                condition.And(WARN_EXPRESSION._.SP_NAME.Contain(model.SP_NAME));
            }
            //监督点类型
            if (!string.IsNullOrWhiteSpace(model.SP_TYPE))
            {

                condition.And(WARN_EXPRESSION._.SP_TYPE == model.SP_TYPE);
            }
            //监督方式
            if (!string.IsNullOrWhiteSpace(model.SP_WAY))
            {

                condition.And(WARN_EXPRESSION._.SP_WAY == model.SP_WAY);
            }
            //时间
            if (search.BeginTime.HasValue)
            {
                condition.And(WARN_RESULT._.SP_TIME >= search.BeginTime);
            }
            if (search.EndTime.HasValue)
            {
                condition.And(WARN_RESULT._.SP_TIME <= search.EndTime);
            }
            //所在地区
            if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
            {
                condition.And(WARN_RESULT._.REGION_CODE == model.REGION_CODE);
            }
            //监督方式
            if (!string.IsNullOrWhiteSpace(model.SP_FLOW_NAME))
            {
                condition.And(WARN_EXPRESSION._.SP_FLOW_NAME == model.SP_FLOW_NAME);
            }
            //业务类型
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
            {
                condition.And(WARN_RESULT._.TENDER_PROJECT_TYPE == model.TENDER_PROJECT_TYPE);
            }

            //}
            #endregion


            #region 组织机构所在归属地过滤

            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode;
            if (!string.IsNullOrWhiteSpace(rootAreaCode))
            {
                condition.And(WARN_RESULT._.REGION_CODE.BeginWith(rootAreaCode));
                if (rootAreaCode == "3501")
                {
                    condition.And(WARN_RESULT._.REGION_CODE != "350128");
                }
            }

            #endregion

            #region 组织机构可查看行业过滤

            var hyTypes = JdUser?.UserDepartment?.SYS_DIC_63;
            if (hyTypes != null && hyTypes.Any())
            {
                var projectTypes = hyTypes.Select(c => c.VALUE3).ToList();//A01 A02
                condition.And(WARN_RESULT._.TENDER_PROJECT_TYPE.In(projectTypes));
            }

            #endregion

            return condition;
        }
        public List<LabelValueModel> PointJDCount(JD_Model model, SearchCondition search)
        {
            var condition = PointCondition(model, search);

            //未监督
            //var nouse = Fw.WarnResultService.FromWhere(condition.ToWhereClip() && WARN_RESULT._.RESULT_STATUS == 0)
            //    .InnerJoin<WARN_EXPRESSION>(WARN_EXPRESSION._.M_ID == WARN_RESULT._.SP_ID)
            //    .Select(new Field("'未监督点（个）'").As("Label"), Field.All.Count().As("Value"));
            //绿灯
            var normal = Fw.WarnResultService.FromWhere(condition.ToWhereClip() && WARN_RESULT._.RESULT_STATUS == 1)
                .InnerJoin<WARN_EXPRESSION>(WARN_EXPRESSION._.M_ID == WARN_RESULT._.SP_ID)
                .Select(new Field("'正常监督点（个）'").As("Label"), Field.All.Count().As("Value"));
            //黄灯
            var yellow = Fw.WarnResultService.FromWhere(condition.ToWhereClip() && WARN_RESULT._.RESULT_STATUS == 2)
                .InnerJoin<WARN_EXPRESSION>(WARN_EXPRESSION._.M_ID == WARN_RESULT._.SP_ID)
                .Select(new Field("'黄灯（个）'").As("Label"), Field.All.Count().As("Value"));
            //红灯
            var red = Fw.WarnResultService.FromWhere(condition.ToWhereClip() && WARN_RESULT._.RESULT_STATUS == 3)
                .InnerJoin<WARN_EXPRESSION>(WARN_EXPRESSION._.M_ID == WARN_RESULT._.SP_ID)
                .Select(new Field("'红灯（个）'").As("Label"), Field.All.Count().As("Value"));
            //监督点总数
            var r = Fw.WarnResultService.FromWhere(condition.ToWhereClip())
                .InnerJoin<WARN_EXPRESSION>(WARN_EXPRESSION._.M_ID == WARN_RESULT._.SP_ID)
                .Select(new Field("'监督点总数（个）'").As("Label"), Field.All.Count().As("Value"))
                .UnionAll(normal)
                .UnionAll(yellow)
                .UnionAll(red)
                //  .UnionAll(nouse)
                .ToList<LabelValueModel>();

            return r;
        }
    }
    #endregion




}










