using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;


namespace GGZY.Services.JianDu
{
    /// <summary>
    /// 智能监察-监督点
    /// </summary>
    public partial class TSuperviseResultService
    {

        public List<LabelValueModel> JddSuperviseCount(TSuperviseResultSearchModel model)
        {
            var condition = JddConditionBuilder(model);
            var tenderProject = Jd.TenderProjectService
                .FromWhere(TENDER_PROJECT._.M_ID_GGFW.IsNotNull() && RECORD_REVIEW._.REVIEW_STATUS.IsNotNull() &&
                           RECORD_REVIEW._.REVIEW_STATUS != '0')
                .InnerJoin<RECORD_REVIEW>(RECORD_REVIEW._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                .GroupBy(TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1)
                .Select(TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1, TENDER_PROJECT._.RECORD_DEPID.Max());
            var normal = FromWhere(condition.ToWhereClip() && T_SUPERVISE_RESULT._.STATUS == 0)
                .InnerJoin<T_PROJECT_DATA>(T_PROJECT_DATA._.ID == T_SUPERVISE_RESULT._.ENTITY_ID)
                .LeftJoinTmp<TENDER_PROJECT>(tenderProject,TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1==T_PROJECT_DATA._.PROJECT_CODE)
                .Select(new Field("'正常项目（个）'").As("Label"), Field.All.Count().As("Value"));
            var red = FromWhere(condition.ToWhereClip() && T_SUPERVISE_RESULT._.STATUS == 1)
                .InnerJoin<T_PROJECT_DATA>(T_PROJECT_DATA._.ID == T_SUPERVISE_RESULT._.ENTITY_ID)
                .LeftJoinTmp<TENDER_PROJECT>(tenderProject, TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1 == T_PROJECT_DATA._.PROJECT_CODE)
                .Select(new Field("'红灯项目（个）'").As("Label"), Field.All.Count().As("Value"));

            var r = FromWhere(condition.ToWhereClip())
                .InnerJoin<T_PROJECT_DATA>(T_PROJECT_DATA._.ID == T_SUPERVISE_RESULT._.ENTITY_ID)
                .LeftJoinTmp<TENDER_PROJECT>(tenderProject, TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1 == T_PROJECT_DATA._.PROJECT_CODE)
                .Select(new Field("'监察项目数（个）'").As("Label"), Field.All.Count().As("Value"))
                   .UnionAll(normal)
                   .UnionAll(red)
                   .ToList<LabelValueModel>();
            return r;
        }
        public PageTableResult JddSuperviseList(TSuperviseResultSearchModel model)
        {
            var condition = JddConditionBuilder(model);
            var tenderProject = Jd.TenderProjectService
                .FromWhere(TENDER_PROJECT._.M_ID_GGFW.IsNotNull() && RECORD_REVIEW._.REVIEW_STATUS.IsNotNull() &&
                           RECORD_REVIEW._.REVIEW_STATUS != '0')
                .InnerJoin<RECORD_REVIEW>(RECORD_REVIEW._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                .GroupBy(TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1)
                .Select(TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1, TENDER_PROJECT._.RECORD_DEPID.Max());

            var queryable = FromWhere(condition.ToWhereClip())
                .InnerJoin<T_PROJECT_DATA>(T_SUPERVISE_RESULT._.ENTITY_ID == T_PROJECT_DATA._.ID)
                .LeftJoinTmp<TENDER_PROJECT>(tenderProject, TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1 == T_PROJECT_DATA._.PROJECT_CODE)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == TENDER_PROJECT._.RECORD_DEPID) //审查单位
                .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == T_SUPERVISE_RESULT._.ENTITY_REGION_CODE)
                //.LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "72" && SYS_DIC._.VALUE == T_PROJECT_DATA._.STATE)
                ; //审查状态
            var total = queryable.Count();
            if (total > 0)
            {
                var list = queryable
                    .OrderBy(T_SUPERVISE_RESULT._.SUPERVISE_TIME.Desc)
                    .Page(model.PageSize, model.PageNo)
                    .Select(T_SUPERVISE_RESULT._.All,
                        T_PROJECT_DATA._.PROJECT_CODE.As("CODE"),
                        T_PROJECT_DATA._.PROJECT_NAME.As("PROJECT_NAME"),
                        T_USER_DEPARTMENT._.DNAME.As("APPROVAL_DEPNAME"),
                        SYS_AREA_QUANGUO._.AREANAME.As("REGION_NAME"))
                    .ToList<TSuperviseResultModel>();
                var pageList = list.ToPageTableResult(model, total);
                return pageList;
            }

            return model.ToPageTableResult(total);
        }
        /// <summary>
        /// 监察详情
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult JddSuperviseDetail(TSuperviseResultModel model)
        {
            var r = new GeneralResult();
            var tenderProject = Jd.TenderProjectService
                .FromWhere(TENDER_PROJECT._.M_ID_GGFW.IsNotNull() && RECORD_REVIEW._.REVIEW_STATUS.IsNotNull() &&
                           RECORD_REVIEW._.REVIEW_STATUS != '0')
                .InnerJoin<RECORD_REVIEW>(RECORD_REVIEW._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                .GroupBy(TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1)
                .Select(TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1, TENDER_PROJECT._.RECORD_DEPID.Max());
            var dbModel = FromWhere(T_SUPERVISE_RESULT._.M_ID == model.M_ID)
                .InnerJoin<T_PROJECT_DATA>(T_SUPERVISE_RESULT._.ENTITY_ID == T_PROJECT_DATA._.ID)
                .LeftJoinTmp<TENDER_PROJECT>(tenderProject, TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1 == T_PROJECT_DATA._.PROJECT_CODE)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == TENDER_PROJECT._.RECORD_DEPID) //审查单位
                                                                                                  //.LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "72" && SYS_DIC._.VALUE == T_PROJECT_DATA._.STATE)
                .Select(T_SUPERVISE_RESULT._.All,
                    T_PROJECT_DATA._.PROJECT_CODE.As("CODE"),
                    T_PROJECT_DATA._.PROJECT_NAME.As("PROJECT_NAME"),
                    T_USER_DEPARTMENT._.DNAME.As("APPROVAL_DEPNAME"))
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
                foreach (var JddSuperviseModel in supervise)
                {
                    JddSuperviseModel.FILES_ATTACHMENT = Jd.CommonService.Attachments(
                        JddSuperviseModel.FILES, "Sys",true);
                    superviseFeedback.Add(new TSuperviseAndFeedbackModel
                    {
                        LABEL = "发起督查",
                        VALUE = nameof(T_SUPERVISE),
                        TIME = JddSuperviseModel.TIME,
                        DATA = JddSuperviseModel
                    });
                }
                foreach (var JddSuperviseModel in feedback)
                {
                    JddSuperviseModel.FILES_ATTACHMENT = Jd.CommonService.Attachments(
                        JddSuperviseModel.FILES, "Sys",true);
                    superviseFeedback.Add(new TSuperviseAndFeedbackModel
                    {
                        LABEL = "督察反馈",
                        VALUE = nameof(T_SUPERVISE_FEEDBACK),
                        TIME = JddSuperviseModel.TIME,
                        DATA = JddSuperviseModel
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

        /// <summary>
        /// 督察
        /// </summary>
        /// <returns></returns>
        public GeneralResult JddSupervise(TSuperviseModel model)
        {
            var r = new GeneralResult();
            model.M_ID = Guid.NewGuid().ToString();
            model.TIME = DateTime.Now;
            model.STATUS = 0;
            model.ENTITY_TYPE_NAME = nameof(GGZYFW.DbEntity.WARN_RESULT);
            model.OP_ID = JdUser?.ID?.ToString();
            model.OP_NAME = JdUser?.MANAGE_NAME;
            model.DEP_ID = JdUser?.DEPARTID?.ToString();
            model.DEP_NAME = JdUser?.UserDepartment?.DNAME;
            //model.TENDER_PROJECT_CODE = zxts?.TENDER_PROJECT_CODE;
            //model.TENDER_PROJECT_NAME = zxts?.TENDER_PROJECT_NAME;
            //model.TENDER_PROJECT_TYPE = zxts?.TENDER_PROJECT_TYPE;
            //model.REGION_CODE = zxts?.REGION_CODE;
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



        protected WhereClipBuilder JddConditionBuilder(TSuperviseResultSearchModel model)
        {
            #region condition builder

            var entityName = nameof(GGZYFW.DbEntity.WARN_RESULT);// model.ENTITY_TYPE_NAME;
            var condition = new WhereClipBuilder(T_SUPERVISE_RESULT._.ENTITY_TYPE_NAME == entityName && T_SUPERVISE_RESULT._.WARNING == 1);
            if (!string.IsNullOrWhiteSpace(model.PROJECT_NAME))
            {
                condition.And(T_PROJECT_DATA._.PROJECT_NAME.Contain(model.PROJECT_NAME));
            }

            if (!string.IsNullOrWhiteSpace(model.CODE))
            {
                condition.And(T_PROJECT_DATA._.PROJECT_CODE.Contain(model.CODE));
            }

            if (model.BeginTime.HasValue)
            {
                condition.And(T_PROJECT_DATA._.CREATE_TIME >= model.BeginTime);
            }

            if (model.EndTime.HasValue)
            {
                condition.And(T_PROJECT_DATA._.CREATE_TIME <= model.EndTime);
            }

            if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
            {
                condition.And(T_SUPERVISE_RESULT._.ENTITY_REGION_CODE == model.REGION_CODE);
            }

            if (!string.IsNullOrWhiteSpace(model.PROJECT_TYPE))
            {
                condition.And(T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_TYPE == model.PROJECT_TYPE);
            }

            if (!string.IsNullOrWhiteSpace(model.STATUS))
            {
                condition.And(T_SUPERVISE_RESULT._.STATUS == model.STATUS);
            }

            if (!string.IsNullOrWhiteSpace(model.DEPID))
            {
                condition.And(TENDER_PROJECT._.RECORD_DEPID == model.DEPID);
            }
            #endregion

            return condition;
        }
    }
}