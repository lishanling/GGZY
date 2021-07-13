using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dos.ORM;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TSuperviseResultService
    {
        #region 智能监察

        #region 执纪执法 纪委 智能监察 招标计划 当前筛选统计

        /// <summary>
        /// 执纪执法 纪委 智能监察 招标计划 当前筛选统计
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<LabelValueModel> AfcProjectSuperviseCount(TSuperviseResultSearchModel search)
        {
            var condition = ConditionBuilder(search);
            var g = FromWhere(condition.ToWhereClip()).InnerJoin<T_AFC_PROJECT>(
                        T_SUPERVISE_RESULT._.ENTITY_ID == T_AFC_PROJECT._.ID).GroupBy(T_SUPERVISE_RESULT._.STATUS)
                .Select(T_SUPERVISE_RESULT._.All.Count().As("Value"), T_SUPERVISE_RESULT._.STATUS.As("Label"))
                .ToList<LabelValueModel<int>>();
            var r = new List<LabelValueModel>()
            {
                new LabelValueModel {Id="ZCXMS",Label = "正常项目（个）", Value = "0"},
                new LabelValueModel {Id="HDXMS",Label = "红灯项目（个）", Value = "0"},
                new LabelValueModel {Id="JCXMS",Label = "监察项目数（个）", Value = "0"},
            };
            if (g.Any())
            {
                r.Clear();
                r.Add(new LabelValueModel { Id = "ZCXMS", Label = "正常项目（个）", Value = (g.FirstOrDefault(c => c.Label == "0")?.Value ?? 0).ToString() });
                r.Add(new LabelValueModel { Id = "HDXMS", Label = "红灯项目（个）", Value = (g.FirstOrDefault(c => c.Label == "1")?.Value ?? 0).ToString() });
                r.Add(new LabelValueModel { Id = "JCXMS", Label = "监察项目数（个）", Value = (g.Sum(c => c.Value)).ToString() });
            }
            return r;
        }


        #endregion

        #region 执纪执法 纪委 智能监察 招标计划 当前筛选列表

        /// <summary>
        /// 执纪执法 纪委 智能监察 招标计划 当前筛选列表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PageTableResult<TSuperviseResultAfcModel> AfcProjectSuperviseList(TSuperviseResultSearchModel model)
        {
            var condition = ConditionBuilder(model);

            var queryable = FromWhere(condition.ToWhereClip())
                    .InnerJoin<T_AFC_PROJECT>(
                        T_SUPERVISE_RESULT._.ENTITY_ID == T_AFC_PROJECT._.ID)
                    .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == T_AFC_PROJECT._.APPROVAL_DEPID) //审查单位
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "61" && SYS_DIC._.VALUE == T_AFC_PROJECT._.APPROVAL_STATE)//审查状态
                    .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == T_SUPERVISE_RESULT._.ENTITY_REGION_CODE)
                ;
            var total = queryable.Count();
            if (total > 0)
            {
                if (model.PageSize < int.MaxValue)
                {
                    queryable.Page(model.PageSize, model.PageNo);
                }
                var list = queryable
                    .OrderBy(T_SUPERVISE_RESULT._.ENTITY_SUBMIT_TIME.Desc)
                    .Select(T_SUPERVISE_RESULT._.All,
                        T_AFC_PROJECT._.CODE,
                        T_AFC_PROJECT._.PROJECT_NAME,
                        T_USER_DEPARTMENT._.DNAME.As("APPROVAL_DEPNAME"),
                        SYS_AREA_QUANGUO._.AREANAME.As("REGION_NAME"),
                        T_AFC_PROJECT._.APPROVAL_DEPID.As("DEPID"))
                    .ToList<TSuperviseResultAfcModel>();
                var pageList = list.ToPageTableTResult(model, total);
                return pageList;
            }

            return model.ToPageTableTResult<TSuperviseResultAfcModel>(total);
        }


        #endregion

        #region 执纪执法 纪委 智能监察 招标计划 当前筛选列表 导出

        /// <summary>
        /// 执纪执法 纪委 智能监察 招标计划 当前筛选列表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult<UploadResData> AfcExport(TSuperviseResultSearchModel model)
        {
            model.PageSize = int.MaxValue;
            var r = new GeneralResult<UploadResData>();
            var d = AfcProjectSuperviseList(model);
            if (d.Total > 0)
            {
                var data = new UploadResData
                {
                    //Id = Guid.NewGuid().ToString("N"),
                    FullUrl = $"/Temp/Export/{DateTime.Today:yyyyMMdd}/智能监察_招标计划_{DateTime.Now:HHmmssfff}_{Guid.NewGuid():N}.xls"
                };
                NpoiUtils.GenerateExcelPath(d.TData, HttpContext.Current?.Server.MapPath($"~{data.FullUrl}"));
                r.SetSuccess(data);
            }
            else
            {
                r.SetFail("导出数据为空");
            }


            return r;
        }


        #endregion

        #region 监察详情

        /// <summary>
        /// 监察详情
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult AfcProjectSuperviseDetail(TSuperviseResultModel model)
        {
            var r = new GeneralResult();
            var dbModel = FromWhere(T_SUPERVISE_RESULT._.M_ID == model.M_ID)
                .InnerJoin<T_AFC_PROJECT>(
                    T_SUPERVISE_RESULT._.ENTITY_ID == T_AFC_PROJECT._.ID)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == T_AFC_PROJECT._.APPROVAL_DEPID) //审查单位
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "61" && SYS_DIC._.VALUE == T_AFC_PROJECT._.APPROVAL_STATE)
                .Select(T_SUPERVISE_RESULT._.All,
                    T_AFC_PROJECT._.CODE,
                    T_AFC_PROJECT._.PROJECT_NAME,
                    T_USER_DEPARTMENT._.DNAME.As("APPROVAL_DEPNAME"),
                    SYS_DIC._.TEXT.As("STATE_TEXT"))
                .ToFirst<TSuperviseResultModel>(); //审查状态
            if (dbModel != null)
            {
                dbModel.Logs =
                    FromWhere<T_SUPERVISE_RESULT_LOG>(T_SUPERVISE_RESULT_LOG._.SUPERVISE_ID == model.M_ID)
                        .OrderByDescending(T_SUPERVISE_RESULT_LOG._.SUPERVISE_TIME)
                        .ToList();

                #region 督查&反馈

                var entityTypeName = dbModel.ENTITY_TYPE_NAME;
                var supervise = FromWhere<T_SUPERVISE>(T_SUPERVISE._.ENTITY_ID == dbModel.ENTITY_ID && T_SUPERVISE._.ENTITY_TYPE_NAME == entityTypeName).ToList<TSuperviseModel>();
                var feedback = FromWhere<T_SUPERVISE_FEEDBACK>(T_SUPERVISE_FEEDBACK._.ENTITY_ID == dbModel.ENTITY_ID && T_SUPERVISE_FEEDBACK._.ENTITY_TYPE_NAME == entityTypeName).ToList<TSuperviseFeedbackModel>();
                var superviseFeedback = new List<TSuperviseAndFeedbackModel>();
                foreach (var afcProjectSuperviseModel in supervise)
                {
                    afcProjectSuperviseModel.FILES_ATTACHMENT = Jd.CommonService.Attachments(
                        afcProjectSuperviseModel.FILES, "Sys",true);
                    superviseFeedback.Add(new TSuperviseAndFeedbackModel
                    {
                        LABEL = "发起督查",
                        VALUE = nameof(T_SUPERVISE),
                        TIME = afcProjectSuperviseModel.TIME,
                        DATA = afcProjectSuperviseModel
                    });
                }
                foreach (var afcProjectSuperviseModel in feedback)
                {
                    afcProjectSuperviseModel.FILES_ATTACHMENT = Jd.CommonService.Attachments(
                        afcProjectSuperviseModel.FILES, "Sys",true);
                    superviseFeedback.Add(new TSuperviseAndFeedbackModel
                    {
                        LABEL = "督察反馈",
                        VALUE = nameof(T_SUPERVISE_FEEDBACK),
                        TIME = afcProjectSuperviseModel.TIME,
                        DATA = afcProjectSuperviseModel
                    });
                }


                #endregion

                dbModel.SuperviseFeedback = superviseFeedback.OrderByDescending(c => c.TIME).ToList();

                r.SetSuccess(dbModel);
            }
            else
            {
                r.SetFail("未找到对应的监察记录信息");
            }

            return r;
        }


        #endregion

        #region 发起督察
        /// <summary>
        /// 督察
        /// </summary>
        /// <returns></returns>
        public GeneralResult AfcSupervise(TSuperviseModel model)
        {
            var r = new GeneralResult();
            model.M_ID = Guid.NewGuid().ToString();
            model.TIME = DateTime.Now;
            model.STATUS = 0;
            model.ENTITY_TYPE_NAME = nameof(T_AFC_PROJECT);
            model.OP_ID = JdUser?.ID?.ToString();
            model.OP_NAME = JdUser?.MANAGE_NAME;
            model.DEP_ID = JdUser?.DEPARTID?.ToString();
            model.DEP_NAME = JdUser?.UserDepartment?.DNAME;
            var afc = Jd.TAfcProjectService.FirstOrNull(T_AFC_PROJECT._.ID == model.ENTITY_ID);
            model.ENTITY_NAME = afc?.PROJECT_NAME;
            model.TENDER_PROJECT_CODE = afc?.CODE;
            model.TENDER_PROJECT_NAME = afc?.PROJECT_NAME;
            model.REGION_CODE = afc?.REGION_COUNTY ?? afc?.REGION_CITY;
            model.TENDER_PROJECT_TYPE = $"A{afc?.PROJECT_TYPE}";
            if (!string.IsNullOrWhiteSpace(model.OBJ) && decimal.TryParse(model.OBJ, out decimal objId))
            {
                //var obj = Jd.TUserService.JdUserInfo(objId);
                var obj = Jd.TUserDepartmentService.FindDepartmentByDepid(objId);
                model.OBJ_NAME = obj?.DNAME;
                model.OBJ_DEP_ID = obj?.DEPID?.ToString();
                model.OBJDEP_NAME = obj?.DNAME;// obj?.UserDepartment?.DNAME;
                model.CODE = CreateSuperviseCode();
                using (var trans = GetDbSession().BeginTransaction())
                {
                    var attachments = model.FILES_ATTACHMENT.Select(c => c.JdSysAttachment()).ToList();
                    trans.Insert(attachments);
                    model.FILES = string.Join(",", attachments.Select(c => c.GUID));
                    var entity = model.ConvertTo<T_SUPERVISE>();

                    trans.Insert(entity);

                    #region 督查操作记录

                    var log = new T_SUPERVISE_LOG
                    {
                        M_ID = Guid.NewGuid().ToString(),
                        ENTITY_ID = model.ENTITY_ID,
                        ENTITY_TYPE_NAME = model.ENTITY_TYPE_NAME,
                        SUPERVISE_ID = model.M_ID,
                        OP_ID = model.OP_ID,
                        OP_NAME = model.OP_NAME,
                        DEP_ID = model.DEP_ID,
                        DEP_NAME = model.DEP_NAME,
                        OBJ = model.OBJ,
                        OBJ_NAME = model.OBJ_NAME,
                        OBJ_DEP_ID = model.OBJ_DEP_ID,
                        OBJDEP_NAME = model.OBJDEP_NAME,
                        LOG_TIME = DateTime.Now,
                        LOG_TYPE = "10",
                        LOG_TYPE_TXT = "发起督察",
                        SUPERVISE_FEEDBACK_ID = String.Empty,
                        SUPERVISE_FORWORD_ID = string.Empty,
                    };
                    trans.Insert(log);

                    #endregion

                    #region 督查流转实例
                    var forward = new T_SUPERVISE_FORWARD
                    {
                        M_ID = Guid.NewGuid().ToString(),
                        ENTITY_ID = model.ENTITY_ID,
                        ENTITY_TYPE_NAME = model.ENTITY_TYPE_NAME,
                        SUPERVISE_ID = model.M_ID,
                        OP_ID = model.OP_ID,
                        OP_NAME = model.OP_NAME,
                        DEP_ID = model.DEP_ID,
                        DEP_NAME = model.DEP_NAME,
                        OBJ = model.OBJ,
                        OBJ_NAME = model.OBJ_NAME,
                        OBJ_DEP_ID = model.OBJ_DEP_ID,
                        OBJDEP_NAME = model.OBJDEP_NAME,
                        FORWARD_TIME = DateTime.Now,
                        SUPERVISE_INSTANCE_ID = model.M_ID,
                    };
                    trans.Insert(forward);


                    #endregion
                    trans.Commit();
                }
                r.SetSuccess();
            }
            else
            {
                r.SetFail("请选择督查对象");
            }

            return r;
        }

        #endregion

        #endregion

        #region 行政监督信息

        /// <summary>
        /// 列表查询
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PageTableResult<TAfcProjectModel> AfcSearchList(TAfcProjectModel model, SearchCondition search)
        {

            var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode;
            var hyList = JdUser?.UserDepartment?.SYS_DIC_63.Select(c => c.VALUE).ToList();//这里不能使用HY_TYPE_LIST 1，2，3

            var pageList = search.ToPageTableTResult<TAfcProjectModel>();
            if (!string.IsNullOrWhiteSpace(rootAreaCode) && hyList != null && hyList.Any())
            {
                var condition = new WhereClipBuilder();

                condition.And(T_AFC_PROJECT._.REGION_COUNTY.Contain(rootAreaCode));
                condition.And(T_AFC_PROJECT._.PROJECT_TYPE.In(hyList));//PROJECT_TYPE 值是01，02 ，03 

                #region 可选查询条件构造

                //招标计划编号
                if (!string.IsNullOrWhiteSpace(model.CODE))
                {
                    condition.And(T_AFC_PROJECT._.CODE.Contain(model.CODE));
                }
                //招标计划名称
                if (!string.IsNullOrWhiteSpace(model.PROJECT_NAME))
                {
                    condition.And(T_AFC_PROJECT._.PROJECT_NAME.Contain(model.PROJECT_NAME));
                }
                //地区+归属地 归属地 JdUser.UserDepartment.RootAreaCode REGION_COUNTY

                if (!string.IsNullOrWhiteSpace(model.REGION_COUNTY))
                {
                    condition.And(T_AFC_PROJECT._.REGION_COUNTY == model.REGION_COUNTY || T_AFC_PROJECT._.REGION_CITY == model.REGION_COUNTY);
                }
                //填报日期
                if (search.BeginTime.HasValue)
                {
                    condition.And(T_AFC_PROJECT._.TM >= search.BeginTime);
                }
                if (search.EndTime.HasValue)
                {
                    condition.And(T_AFC_PROJECT._.TM <= search.EndTime);
                }
                //业务类型+行业  JdUser.UserDepartment.HY_TYPE_List 行业  KIND 

                if (!string.IsNullOrWhiteSpace(model.PROJECT_TYPE))
                {
                    condition.And(T_AFC_PROJECT._.PROJECT_TYPE == (model.PROJECT_TYPE));
                }
                //审查单位
                if (!string.IsNullOrWhiteSpace(model.APPROVAL_DEPID))
                {
                    condition.And(T_AFC_PROJECT._.APPROVAL_DEPID == (model.APPROVAL_DEPID));
                }

                #endregion
                //数据记录条数
                var total = Jd.TAfcProjectService.FromWhere(condition.ToWhereClip()).Count();
                if (total > 0)
                {
                    var query = Jd.TAfcProjectService.FromWhere(condition.ToWhereClip())
                        .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == T_AFC_PROJECT._.REGION_CITY)
                        .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == T_AFC_PROJECT._.REGION_COUNTY)
                        .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "63" &&
                                           SYS_DIC._.VALUE == T_AFC_PROJECT._.PROJECT_TYPE) //工程类别
                        .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "61" &&
                                           SYS_DIC._.VALUE == T_AFC_PROJECT._.APPROVAL_STATE.ToChar()) //审查状态
                        .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "66" &&
                                           SYS_DIC._.VALUE == T_AFC_PROJECT._.APPROVAL_TACHE.ToChar()) //审查环节
                        .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == T_AFC_PROJECT._.APPROVAL_DEPID) //审查单位
                        .LeftJoin<T_AFC_LOG>(T_AFC_LOG._.AFC_ID == T_AFC_PROJECT._.ID&&T_AFC_LOG._.ISNEW==1)
                        .LeftJoin<PROJECT>(PROJECT._.CONSTRUCTION_ID == T_AFC_PROJECT._.ID)
                        .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.PROJECT_CODE == PROJECT._.PROJECT_CODE)
                        .OrderByDescending(T_AFC_PROJECT._.TM);
                    if (search.PageSize < int.MaxValue)
                    {
                        //分页页码
                        query.Page(search.PageSize, search.PageNo);
                    }
                    var list = query
                      .Select(
                                T_AFC_PROJECT._.All,
                                SYS_AREA_QUANGUO._.AREANAME.As("REGION_CITY_NAME"),
                                new Field("AREANAME", "SYS_AREA_QUANGUO2").As("REGION_COUNTY_NAME"),
                                SYS_DIC._.TEXT.As("PROJECT_TYPE_NAME"),
                                new Field("TEXT", "SYS_DIC2").As("APPROVAL_STATE_NAME"),
                                new Field("TEXT", "SYS_DIC3").As("APPROVAL_TACHE_NAME"),
                                new Field("(CASE WHEN T_AFC_LOG.ID IS NULL THEN '否' ELSE '是' END)").As("IS_GET"),
                                T_USER_DEPARTMENT._.DNAME.As("APPROVAL_DEPNAME"),
                                PROJECT._.PROJECT_CODE.As("JD_PROJECT_CODE"),
                                TENDER_PROJECT._.TENDER_PROJECT_CODE.As("JD_TENDER_PROJECT_CODE"),
                                TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1.As("FW_TENDER_PROJECT_CODE"),
                                new Field("(CASE WHEN TENDER_PROJECT.TENDER_PROJECT_CODE_OLD1 IS NULL THEN 0 ELSE 1 END)").As("HAS_DATA")

                      ).ToList<TAfcProjectModel>();

                    pageList = list.ToPageTableTResult(search, total);
                }
                //列表返回值

            }
            return pageList;
        }
        public GeneralResult<UploadResData> AfcSearchExport(TAfcProjectModel model, SearchCondition search)
        {
            search.PageSize = int.MaxValue;
            var r = new GeneralResult<UploadResData>();
            var d = AfcSearchList(model, search);
            if (d.Total > 0)
            {
                var data = new UploadResData
                {
                    FullUrl = $"/Temp/Export/{DateTime.Today:yyyyMMdd}/行政监督信息_招标计划_{DateTime.Now:HHmmssfff}_{Guid.NewGuid():N}.xls"
                };
                NpoiUtils.GenerateExcelPath(d.TData, HttpContext.Current?.Server.MapPath($"~{data.FullUrl}"));
                r.SetSuccess(data);
            }
            else
            {
                r.SetFail("导出数据为空");
            }


            return r;
        }

        #endregion

        #region Utils

        protected WhereClipBuilder ConditionBuilder(TSuperviseResultSearchModel model)
        {
            #region condition builder

            var entityName = nameof(T_AFC_PROJECT); //model.ENTITY_TYPE_NAME;
            var condition = new WhereClipBuilder(T_SUPERVISE_RESULT._.ENTITY_TYPE_NAME == entityName && T_SUPERVISE_RESULT._.WARNING == 1);
            if (!string.IsNullOrWhiteSpace(model.PROJECT_NAME))
            {
                condition.And(T_AFC_PROJECT._.PROJECT_NAME.Contain(model.PROJECT_NAME));
            }

            if (!string.IsNullOrWhiteSpace(model.CODE))
            {
                condition.And(T_AFC_PROJECT._.CODE.Contain(model.CODE));
            }

            if (model.BeginTime.HasValue)
            {
                condition.And(T_SUPERVISE_RESULT._.ENTITY_SUBMIT_TIME >= model.BeginTime);
            }

            if (model.EndTime.HasValue)
            {
                condition.And(T_SUPERVISE_RESULT._.ENTITY_SUBMIT_TIME <= model.EndTime);
            }

            if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
            {
                condition.And(T_SUPERVISE_RESULT._.ENTITY_REGION_CODE == model.REGION_CODE);
            }

            if (!string.IsNullOrWhiteSpace(model.PROJECT_TYPE))
            {
                condition.And(T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_TYPE.Contain(model.PROJECT_TYPE));
            }

            if (!string.IsNullOrWhiteSpace(model.STATUS))
            {
                condition.And(T_SUPERVISE_RESULT._.STATUS == model.STATUS);
            }

            if (!string.IsNullOrWhiteSpace(model.DEPID))
            {
                condition.And(T_AFC_PROJECT._.APPROVAL_DEPID == model.DEPID);
            }
            #endregion

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

            #endregion

            #region 纪委监委组织机构可查看行业过滤

            var hyTypes = JdUser?.UserDepartment?.TENDER_PROJECT_TYPES;
            if (hyTypes != null && hyTypes.Any())
            {

                condition.And(T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_TYPE.In(hyTypes));
            }

            #endregion

            return condition;
        }

        #endregion


    }
}