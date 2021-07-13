using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.WebSockets;
using Aspose.Words.Lists;
using Dos.ORM;
using GGZY.Core.Cache;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Services.Base;
using GGZY.Services.Extensions;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    /// <summary>
    /// 处长门户 项目监督 纪委监委
    /// </summary>
    public partial class ProjectSupervisionService
    {

        #region 纪委监委

        #region 项目监督 纪委监委 处理项目及事项 列表
        /// <summary>
        /// 项目监督 纪委监委 处理项目及事项 列表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PageTableResult JwProjectSupervisions(ProjectSupervisionRequestModel model)
        {

            var list = new List<ProjectSupervisionResponseJwModel>();
            int count = 0;
            switch (model.Type)
            {
                case nameof(T_SUPERVISE_RESULT):
                    list = JcdProjectSupervisions(model, out count);
                    break;
                case "YISONG"://
                    list = YsProjectSupervisions(model, out count);
                    break;
                default:
                    var jcdQuery = JcdProjectSupervisionQueryable(model);
                    var ysQuery = YsProjectSupervisionQueryable(model);
                    var query = jcdQuery
                        .UnionAll(ysQuery);
                    count = query.Count();
                    list = query.OrderBy(new Field("TM").Desc)
                        .Page(model.PageSize, model.PageNo)
                        .ToList<ProjectSupervisionResponseJwModel>();
                    break;
            }
            var pageList = list.ToPageTableResult(model, count);
            return pageList;
        }
        #region 监察点

        public List<ProjectSupervisionResponseJwModel> JcdProjectSupervisions(ProjectSupervisionRequestModel model, out int count)
        {
            var list = new List<ProjectSupervisionResponseJwModel>();
            var queryable = JcdProjectSupervisionQueryable(model);
            count = queryable.Count();
            if (count > 0)
            {
                list = queryable.OrderBy(new Field("TM").Desc).Page(model.PageSize, model.PageNo)
                    .ToList<ProjectSupervisionResponseJwModel>();
            }

            return list;
        }
        private FromSection<T_SUPERVISE_RESULT> JcdProjectSupervisionQueryable(ProjectSupervisionRequestModel model)
        {
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode;
            var hyTypes = JdUser?.UserDepartment?.SYS_DIC_63?.Select(c => c.VALUE3).ToList();
            var con = new WhereClipBuilder(T_SUPERVISE_RESULT._.WARNING == 1);
            if (string.IsNullOrWhiteSpace(rootAreaCode) || hyTypes == null || !hyTypes.Any())
            {
                con.And(T_SUPERVISE_RESULT._.ENTITY_REGION_CODE.IsNull() && T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_TYPE.IsNull());
            }
            else
            {
                #region 条件
                con.And(T_SUPERVISE_RESULT._.ENTITY_REGION_CODE.BeginWith(rootAreaCode) && T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_TYPE.In(hyTypes));
                if (rootAreaCode == "3501")
                {
                    con.And(T_SUPERVISE_RESULT._.ENTITY_REGION_CODE != "350128");
                }

                #region 处理状态

                if (model.HANDLE_STATE == "DCL")//待处理项目及事项
                {
                    con.And(T_SUPERVISE_RESULT._.STATUS != 1);
                }
                else//已处理项目及事项
                {
                    con.And(T_SUPERVISE_RESULT._.STATUS == 1);
                }


                #endregion


                #region 创建时间

                if (model.BeginTime.HasValue)
                {
                    con.And(T_SUPERVISE_RESULT._.SUPERVISE_TIME >= model.BeginTime);
                }
                if (model.EndTime.HasValue)
                {
                    con.And(T_SUPERVISE_RESULT._.SUPERVISE_TIME <= model.EndTime);
                }
                #endregion


                if (!string.IsNullOrWhiteSpace(model.KeyWord))
                {
                    con.And(T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_NAME.Contain(model.KeyWord) || T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_CODE.Contain(model.KeyWord));
                }
                #endregion
            }
            var queryable = Jd.TSuperviseResultService.FromWhere(con.ToWhereClip())
                .Select(
                    T_SUPERVISE_RESULT._.M_ID.ToChar().As("ID"),
                    T_SUPERVISE_RESULT._.SUPERVISE_TIME.As("TM"),
                    T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_CODE.ToChar().As("CODE"),
                    T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_NAME.ToChar().As("NAME"),
                //T_SUPERVISE_RESULT._.ENTITY_ID.As("MODULE_ID"),
                //T_SUPERVISE_RESULT._.ENTITY_TYPE_NAME.As("MODULE_TYPE"),
                new Field("'T_SUPERVISE_RESULT'").As("TYPE"),
                new Field("'监察点'").As("TYPE_TEXT")
            );
            return queryable;
        }


        #endregion

        #endregion

        #region 项目监督 纪委监委 项目处理信息汇总
        /// <summary>
        /// 项目监督 纪委监委 项目处理信息汇总
        /// </summary>
        /// <returns></returns>
        public List<ProjectSupervisionCountResponseModel> JwProjectSupervisionCount()
        {
            var jdUserId = JdUser?.ID?.ToString();
            var jdUserDepartId = JdUser?.DEPARTID?.ToString();
            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode;
            var projectTypes = JdUser?.UserDepartment?.SYS_DIC_63?.Select(c => c.VALUE3).ToList();
            var cacheCounts = Cache.Get($"{ConfigHelper.APP_KEY_GGZYJD}:JwProjectSupervisionCount:{jdUserDepartId}", 10, () =>
            {
                var counts = new List<ProjectSupervisionCountResponseModel>();

                #region 监察点

                var jcd = new ProjectSupervisionCountResponseModel() { Label = "监察点" };
                if (string.IsNullOrWhiteSpace(rootAreaCode) || projectTypes == null || !projectTypes.Any())
                {
                    jcd.UndoCount = 0;
                    jcd.DoneCount = 0;
                }
                else
                {
                    var jcdCon = new WhereClipBuilder(
                        T_SUPERVISE_RESULT._.WARNING == 1 && T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_TYPE.In(projectTypes) && T_SUPERVISE_RESULT._.ENTITY_REGION_CODE.BeginWith(rootAreaCode));
                    if (rootAreaCode == "3501")
                    {
                        jcdCon.And(T_SUPERVISE_RESULT._.ENTITY_REGION_CODE != "350128");
                    }
                    var jcdWhere = jcdCon.ToWhereClip();
                    jcd.UndoCount = Jd.TSuperviseResultService.Count(jcdWhere && T_SUPERVISE_RESULT._.STATUS != 1);
                    jcd.DoneCount = Jd.TSuperviseResultService.Count(jcdWhere && T_SUPERVISE_RESULT._.STATUS == 1);
                }

                counts.Add(jcd);

                #endregion

                var staff = new ProjectSupervisionCountResponseModel { Label = "行业部门移送的公职人员信息", DoneCount = 0 };
                staff.DoneCount = Jd.JcTransPersonService
                    .FromWhere(JC_TRANS_PERSON._.IS_DELETE != 1 && JC_TRANS_RECORD._.IS_DELETE != 1 && JC_TRANS_RECORD._.HAS_RESULT == 1 && JC_TRANS_RECORD._.RECEIVER_UNIT_ID == jdUserDepartId)
                    .InnerJoin<JC_TRANS_RECORD>(JC_TRANS_RECORD._.ID == JC_TRANS_PERSON._.RECORD_ID).Count();
                staff.UndoCount = Jd.JcTransPersonService
                    .FromWhere(JC_TRANS_PERSON._.IS_DELETE != 1 && JC_TRANS_RECORD._.IS_DELETE != 1 && JC_TRANS_RECORD._.HAS_RESULT != 1 && JC_TRANS_RECORD._.RECEIVER_UNIT_ID == jdUserDepartId)
                    .InnerJoin<JC_TRANS_RECORD>(JC_TRANS_RECORD._.ID == JC_TRANS_PERSON._.RECORD_ID).Count();
                counts.Add(staff);

                var sendPolice = new ProjectSupervisionCountResponseModel { Label = "移送公安部门信息", DoneCount = 0 };
                sendPolice.DoneCount = Jd.JcTransRecordService.FromWhere(
                        JC_TRANS_RECORD._.IS_DELETE != 1 && JC_TRANS_RECORD._.HAS_RESULT == 1 &&
                        JC_TRANS_RECORD._.TRANS_USER_ID == jdUserId && T_USER_DEPARTMENT._.DTYPE == 4)
                    .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == JC_TRANS_RECORD._.RECEIVER_UNIT_ID)
                    .Count();
                sendPolice.UndoCount = Jd.JcTransRecordService.FromWhere(
                        JC_TRANS_RECORD._.IS_DELETE != 1 && JC_TRANS_RECORD._.HAS_RESULT != 1 &&
                        JC_TRANS_RECORD._.TRANS_USER_ID == jdUserId && T_USER_DEPARTMENT._.DTYPE == 4)
                    .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == JC_TRANS_RECORD._.RECEIVER_UNIT_ID)
                    .Count();
                counts.Add(sendPolice);
                var sendDep = new ProjectSupervisionCountResponseModel { Label = "移送行业监督部门", DoneCount = 0 };
                sendDep.DoneCount = Jd.JcTransRecordService.FromWhere(
                        JC_TRANS_RECORD._.IS_DELETE != 1 && JC_TRANS_RECORD._.HAS_RESULT == 1 &&
                        JC_TRANS_RECORD._.TRANS_USER_ID == jdUserId && (T_USER_DEPARTMENT._.DTYPE.In(1, 2) || T_USER_DEPARTMENT._.DTYPE.IsNull()))
                    .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == JC_TRANS_RECORD._.RECEIVER_UNIT_ID)
                    .Count();
                sendDep.UndoCount = Jd.JcTransRecordService.FromWhere(
                        JC_TRANS_RECORD._.IS_DELETE != 1 && JC_TRANS_RECORD._.HAS_RESULT != 1 &&
                        JC_TRANS_RECORD._.TRANS_USER_ID == jdUserId && (T_USER_DEPARTMENT._.DTYPE.In(1, 2) || T_USER_DEPARTMENT._.DTYPE.IsNull()))
                    .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == JC_TRANS_RECORD._.RECEIVER_UNIT_ID)
                    .Count();
                counts.Add(sendDep);

                #region 发起督查

                var fqdc = new ProjectSupervisionCountResponseModel() { Label = "发起督查" };
                fqdc.DoneCount = Jd.TSuperviseService.Count(T_SUPERVISE._.OP_ID == jdUserId);
                counts.Add(fqdc);

                #endregion


                counts.Add(new ProjectSupervisionCountResponseModel { Label = "处罚记录", DoneCount = 0 });//TODO zlw

                return counts;
            });
            return cacheCounts;
        }
        #endregion

        #region 项目监督 纪委监委 标后监管系统


        public PageTableResult JwAfterSupervisions(SearchCondition search)
        {
            return search.ToPageTableResult();
        }

        #endregion

        #region 项目监督 纪委监委 处理项目及事项 详情

        #region 项目监督 纪委监委 处理项目及事项 项目信息

        public GeneralResult JwProjectDetail(ProjectSupervisionResponseHyModel model)
        {
            var r = new GeneralResult();
            if (model.TYPE == nameof(T_SUPERVISE_RESULT))
            {
                var tSuperviseResult = Jd.TSuperviseResultService.FirstOrNull(T_SUPERVISE_RESULT._.M_ID == model.ID);
                if (tSuperviseResult != null)
                {
                    model.ID = tSuperviseResult.ENTITY_ID;
                    switch (tSuperviseResult.ENTITY_TYPE_NAME)
                    {
                        case nameof(T_AFC_PROJECT):
                            r = HyAfcProjectDetail(model);
                            break;
                        case nameof(RECORD_REVIEW):
                            r = HyRecordProjectDetail(model);
                            break;
                        case nameof(PT_ZXTS):
                            r = HyTsProjectDetail(model);
                            break;
                        case nameof(GGZYFW.DbEntity.WARN_RESULT):
                            r = HyWarnResultProjectDetail(model);
                            break;
                        default:
                            r.SetFail("参数错误");
                            break;
                    }
                }
                else
                {
                    r.SetFail("未找到对应的检查点详情信息");
                }
            }
            else
            {
                r = GaProjectDetail(model);
            }

            return r;
        }
        #endregion

        #region 项目监督 纪委监委 处理项目及事项 详情 监督在监督

        public PageTableResult JdzJd(ProjectSupervisionResponseHyModel model, SearchCondition search)
        {
            var plist = search.ToPageTableResult();
            var condition = new WhereClipBuilder(T_SUPERVISE_RESULT._.WARNING == 1);
            #region 纪委监委组织机构所在归属地过滤

            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode;
            if (!string.IsNullOrWhiteSpace(rootAreaCode))
            {
                condition.And(T_SUPERVISE_RESULT._.ENTITY_REGION_CODE.BeginWith(rootAreaCode));
                if (rootAreaCode == "3501")
                {
                    condition.And(T_SUPERVISE_RESULT._.ENTITY_REGION_CODE != "350128");
                }
            }
            else
            {
                return plist;
            }

            #endregion

            #region 纪委监委组织机构可查看行业过滤

            var hyTypes = JdUser?.UserDepartment?.SYS_DIC_63;
            if (hyTypes != null && hyTypes.Any())
            {
                var projectTypes = hyTypes.Select(c => c.VALUE3).ToList();//A01 A02
                condition.And(T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_TYPE.In(projectTypes));
            }
            else
            {
                return plist;
            }

            #endregion
            if (model.TYPE == nameof(T_SUPERVISE_RESULT))
            {
                var dbEntity = Jd.TSuperviseResultService.FirstOrNull(T_SUPERVISE_RESULT._.M_ID == model.ID);
                if (dbEntity != null)
                {
                    if (dbEntity.ENTITY_TYPE_NAME == nameof(T_AFC_PROJECT))
                    {
                        var tenderProjectCode = Jd.TenderProjectService
                            .FromWhere(T_AFC_PROJECT._.ID == dbEntity.ENTITY_ID)
                            .InnerJoin<PROJECT>(PROJECT._.PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                            .InnerJoin<T_AFC_PROJECT>(T_AFC_PROJECT._.CODE == PROJECT._.CONSTRUCTION_ID)
                            .Select(TENDER_PROJECT._.TENDER_PROJECT_CODE).ToScalar<string>();
                        if (!string.IsNullOrWhiteSpace(tenderProjectCode))
                        {
                            condition.And(T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_CODE == tenderProjectCode || T_SUPERVISE_RESULT._.M_ID == model.ID);
                        }
                        else
                        {
                            condition.And(T_SUPERVISE_RESULT._.M_ID == model.ID);
                        }
                    }

                }
            }
            else
            {
                var tenderProject = Jd.TenderProjectService.FromWhere(JC_TRANS_PROJECT._.RECORD_ID == model.ID)
                    .InnerJoin<JC_TRANS_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE ==
                                                 JC_TRANS_PROJECT._.TENDER_PROJECT_CODE).Select(TENDER_PROJECT._.All)
                    .ToFirst();
                if (tenderProject != null)
                {
                    condition.And((T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_CODE == tenderProject.TENDER_PROJECT_CODE && T_SUPERVISE_RESULT._.ENTITY_TYPE_NAME != nameof(GGZYFW.DbEntity.WARN_RESULT)) || (T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_CODE == tenderProject.TENDER_PROJECT_CODE_OLD1 && T_SUPERVISE_RESULT._.ENTITY_TYPE_NAME == nameof(GGZYFW.DbEntity.WARN_RESULT)));
                }
            }


            var count = Jd.TSuperviseResultService.Count(condition.ToWhereClip());
            if (count > 0)
            {
                var list = Jd.TSuperviseResultService.FromWhere(condition.ToWhereClip())
                    .OrderBy(T_SUPERVISE_RESULT._.SUPERVISE_TIME.Desc)
                    .Page(search.PageSize, search.PageNo)
                    .ToList<TSuperviseResultModel>();
                plist = list.ToPageTableResult(search, count);

            }

            return plist;
        }


        #endregion


        #region 项目监督 纪委监委 处理项目及事项 详情 行业部门移送的公职人员信息

        public PageTableResult TransferStaff(ProjectSupervisionResponseHyModel model, SearchCondition search)
        {
            var tenderProjectCode = string.Empty;
            if (model.TYPE == nameof(T_SUPERVISE_RESULT))
            {
                var supervise = Jd.TSuperviseResultService.FirstOrNull(T_SUPERVISE_RESULT._.M_ID == model.ID);
                if (supervise != null)
                {
                    switch (supervise.ENTITY_TYPE_NAME)
                    {
                        case nameof(RECORD_REVIEW):
                        case nameof(PT_ZXTS):
                            tenderProjectCode = supervise.ENTITY_TENDER_PROJECT_CODE;
                            break;
                        case nameof(T_AFC_PROJECT):
                            tenderProjectCode = Jd.TenderProjectService.FromWhere(T_AFC_PROJECT._.ID == model.ID)
                                .InnerJoin<PROJECT>(PROJECT._.PROJECT_CODE == TENDER_PROJECT._.PROJECT_CODE)
                                .InnerJoin<T_AFC_PROJECT>(T_AFC_PROJECT._.CODE == PROJECT._.CONSTRUCTION_ID)
                                .Select(TENDER_PROJECT._.TENDER_PROJECT_CODE).ToScalar<string>();
                            break;
                        case nameof(GGZYFW.DbEntity.WARN_RESULT):
                            var old1 = Fw.WarnResultService.FirstOrNull(GGZYFW.DbEntity.WARN_RESULT._.M_ID == model.ID)
                                ?.TENDER_PROJECT_CODE;
                            if (!string.IsNullOrWhiteSpace(old1))
                            {
                                tenderProjectCode = Jd.TenderProjectService
                                    .FirstOrNull(TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1 == old1)
                                    ?.TENDER_PROJECT_CODE;
                            }
                            break;
                    }
                }
            }
            else
            {
                tenderProjectCode = Jd.JcTransProjectService.FirstOrNull(JC_TRANS_PROJECT._.RECORD_ID == model.ID)
                   ?.TENDER_PROJECT_CODE;

            }

            if (!string.IsNullOrWhiteSpace(tenderProjectCode))
            {
                var plist = Jd.JcTransPersonService.DepTransStaff(
                    new JC_TRANS_PERSON { TENDER_PROJECT_CODE = tenderProjectCode }, search);
                return plist;
            }
            return search.ToPageTableResult();
        }

        #endregion

        #region 项目监督 纪委监委 处理项目及事项 详情 12388纪委监委平台举报信息

        public PageTableResult Report12388(ProjectSupervisionResponseHyModel model, SearchCondition search)
        {
            var plist = search.ToPageTableResult();
            //举报标题 举报人 时间 //TODO zlw
            //返回值使用标题首字母大写
            return plist;
        }

        #endregion


        #region 项目监督 纪委监委 处理项目及事项 详情 处理事项

        public PageTableResult JwHandleItems(ProjectSupervisionResponseHyModel model, SearchCondition search)
        {
            var plist = search.ToPageTableResult();
            var superviseCon = new WhereClipBuilder(T_SUPERVISE_RESULT._.WARNING == 1);//监察条件
            var transCon = new WhereClipBuilder(JC_TRANS_RECORD._.TRANS_TYPE == 2);//移送
            if (model.TYPE == nameof(T_SUPERVISE_RESULT))//监察
            {
                var supervise = Jd.TSuperviseResultService.FirstOrNull(T_SUPERVISE_RESULT._.M_ID == model.ID);
                var tenderProjectCode = supervise?.ENTITY_TENDER_PROJECT_CODE;
                TENDER_PROJECT tenderProject = null;
                switch (supervise?.ENTITY_TYPE_NAME)
                {
                    case nameof(T_AFC_PROJECT):
                        tenderProject = Jd.TenderProjectService.FromWhere(T_AFC_PROJECT._.ID == model.ID)
                            .InnerJoin<PROJECT>(PROJECT._.PROJECT_CODE == TENDER_PROJECT._.PROJECT_CODE)
                           .InnerJoin<T_AFC_PROJECT>(T_AFC_PROJECT._.CODE == PROJECT._.CONSTRUCTION_ID)
                           .Select(TENDER_PROJECT._.All).ToFirst();
                        break;
                    case nameof(GGZYFW.DbEntity.WARN_RESULT):
                        tenderProject =
                            Jd.TenderProjectService.FirstOrNull(
                                TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1 == tenderProjectCode);
                        break;
                }
                superviseCon.And(T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_CODE == tenderProjectCode || T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_CODE == tenderProject?.TENDER_PROJECT_CODE || T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_CODE == tenderProject?.TENDER_PROJECT_CODE_OLD1 ||
                                 T_SUPERVISE_RESULT._.M_ID == model.ID);
                transCon.And(JC_TRANS_PERSON._.TENDER_PROJECT_CODE == tenderProject?.TENDER_PROJECT_CODE);
            }
            else//移送
            {
                var tenderProjectCode =
                    Jd.JcTransProjectService.FirstOrNull(JC_TRANS_PROJECT._.RECORD_ID == model.ID &&
                                                         JC_TRANS_PROJECT._.IS_DELETE != 1)?.TENDER_PROJECT_CODE;
                var tenderProject = Jd.TenderProjectService.FirstOrNull(
                    TENDER_PROJECT._.TENDER_PROJECT_CODE == tenderProjectCode);
                superviseCon.And(T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_CODE == tenderProject?.CONSTRUCTION_ID || T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_CODE == tenderProject?.TENDER_PROJECT_CODE || T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_CODE == tenderProject?.TENDER_PROJECT_CODE_OLD1);
                transCon.And(JC_TRANS_PERSON._.TENDER_PROJECT_CODE == tenderProject?.TENDER_PROJECT_CODE);
            }

            var superviseQueryable = Jd.TSuperviseResultService.FromWhere(superviseCon.ToWhereClip())
                .Select(
                    new Field("'T_SUPERVISE_RESULT'").As("SXLX"),
                    T_SUPERVISE_RESULT._.ENTITY_TYPE_NAME.As("SUB_SXLX"),
                    T_SUPERVISE_RESULT._.SUPERVISE_NAME.As("TITLE"),
                    T_SUPERVISE_RESULT._.STATUS,
                    new Field("''").As("OPERATOR"),
                    new Field("''").As("OPINION"),
                    T_SUPERVISE_RESULT._.SUPERVISE_TIME.As("TM")
                    );
            var transQueryable = Jd.JcTransRecordService.FromWhere(transCon.ToWhereClip())
                .InnerJoin<JC_TRANS_PERSON>(JC_TRANS_RECORD._.ID == JC_TRANS_PERSON._.RECORD_ID &&
                                            JC_TRANS_RECORD._.IS_DELETE != 1)
                .LeftJoin<JC_TRANS_RESULT>(JC_TRANS_RESULT._.RECORD_ID == JC_TRANS_RECORD._.ID && JC_TRANS_RESULT._.IS_DELETE != 1)
                .Select(
                    new Field("'JC_TRANS_RECORD'").As("SXLX"),
                    JC_TRANS_RECORD._.TRANS_TYPE.As("SUB_SXLX"),
                    JC_TRANS_RECORD._.TITLE,
                    JC_TRANS_RECORD._.HAS_RESULT.As("STATUS"),
                    JC_TRANS_RECORD._.TRANS_USER.As("OPERATOR"),
                    JC_TRANS_RESULT._.RESULT_MSG.As("OPINION"),
                    JC_TRANS_RECORD._.TRANS_TIME.As("TM")
                    );
            var count = superviseQueryable.UnionAll(transQueryable).Count();
            if (count > 0)
            {
                var list = superviseQueryable.UnionAll(transQueryable).OrderBy(new Field("TM"))
                    .Page(search.PageSize, search.PageNo)
                    .ToList<ProjectSupervisionHandleItemResponseModelJW>();
                plist = list.ToPageTableResult(search, count);
            }
            return plist;
        }

        #endregion

        #endregion

        #endregion


        #region 闽政通

        /// <summary>
        /// 项目监督 纪委监委 处理项目及事项 列表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PageTableResult MztJwProjectSupervisions(ProjectSupervisionRequestModel model)
        {

            var list = new List<ProjectSupervisionResponseJwModel>();
            var jcdQuery = JcdProjectSupervisionQueryable(model);
            var ysQuery = YsSupervisionQueryable(model);
            var query = jcdQuery.UnionAll(ysQuery);//todo mzt
            var count = query.Count();
            if (count > 0)
            {
                list = query.OrderBy(new Field("TM").Desc)
                    .Page(model.PageSize, model.PageNo)
                    .ToList<ProjectSupervisionResponseJwModel>();
            }
            var pageList = list.ToPageTableResult(model, count);
            return pageList;
        }

        /// <summary>
        /// 闽政通 项目监督 待处理事项 已处理事项
        /// </summary>
        /// <returns></returns>
        public List<object> MztJwProjectSupervisionCount()
        {
            var model = new ProjectSupervisionRequestModel();

            var jcdQuery = JcdProjectSupervisionQueryable(model);
            var ysQuery = YsSupervisionQueryable(model);
            var query = jcdQuery.UnionAll(ysQuery);//todo mzt
            var count = query.Count();//已处理
            model.HANDLE_STATE = "DCL";
            jcdQuery = JcdProjectSupervisionQueryable(model);
            ysQuery = YsSupervisionQueryable(model);
            query = jcdQuery.UnionAll(ysQuery);
            var count2 = query.Count();//待处理
            return new List<object>
            {
                new {label = "待处理事项",count = count2,value="DCL"},
                new {label = "已处理事项",count = count,value="YCL"},
            };
        }

        #endregion
    }
}