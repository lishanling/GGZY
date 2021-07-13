using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TSuperviseResultService
    {
        public List<LabelValueModel> ReviewSuperviseCount(TSuperviseResultSearchModel model)
        {
            var condition = RecordReviewConditionBuilder(model);

            var normal = FromWhere(condition.ToWhereClip() && T_SUPERVISE_RESULT._.STATUS == 0)
                .InnerJoin<RECORD_REVIEW>(RECORD_REVIEW._.ID == T_SUPERVISE_RESULT._.ENTITY_ID)
                .InnerJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == RECORD_REVIEW._.TENDER_PROJECT_CODE)
                .InnerJoin<T_USER>(T_USER._.ID == RECORD_REVIEW._.REVIEW_PERSON)
                .Select(new Field("'正常项目（个）'").As("Label"), Field.All.Count().As("Value"));
            var red = FromWhere(condition.ToWhereClip() && T_SUPERVISE_RESULT._.STATUS == 1)
                .InnerJoin<RECORD_REVIEW>(RECORD_REVIEW._.ID == T_SUPERVISE_RESULT._.ENTITY_ID)
                .InnerJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == RECORD_REVIEW._.TENDER_PROJECT_CODE)
                .InnerJoin<T_USER>(T_USER._.ID == RECORD_REVIEW._.REVIEW_PERSON)
                .Select(new Field("'红灯项目（个）'").As("Label"), Field.All.Count().As("Value"));

            var r = FromWhere(condition.ToWhereClip())
                .InnerJoin<RECORD_REVIEW>(RECORD_REVIEW._.ID == T_SUPERVISE_RESULT._.ENTITY_ID)
                .InnerJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == RECORD_REVIEW._.TENDER_PROJECT_CODE)
                .InnerJoin<T_USER>(T_USER._.ID == RECORD_REVIEW._.REVIEW_PERSON)
                .Select(new Field("'监察项目数（个）'").As("Label"), Field.All.Count().As("Value"))
                   .UnionAll(normal)
                   .UnionAll(red)
                   .ToList<LabelValueModel>();
            return r;
        }
        public PageTableResult<TSuperviseZBBAResultModel> ReviewSuperviseList(TSuperviseResultSearchModel model)
        {
            var condition = RecordReviewConditionBuilder(model);

            var queryable = FromWhere(condition.ToWhereClip())
                .InnerJoin<RECORD_REVIEW>(T_SUPERVISE_RESULT._.ENTITY_ID == RECORD_REVIEW._.ID)
                .InnerJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == RECORD_REVIEW._.TENDER_PROJECT_CODE)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == TENDER_PROJECT._.RECORD_DEPID) //审查单位
                .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == T_SUPERVISE_RESULT._.ENTITY_REGION_CODE)
                //.LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "72" && SYS_DIC._.VALUE == RECORD_REVIEW._.STATE)
                ; //审查状态
            var total = queryable.Count();
            if (total > 0)
            {
                var list = queryable
                    .OrderBy(T_SUPERVISE_RESULT._.SUPERVISE_TIME.Desc)
                    .Page(model.PageSize, model.PageNo)
                    .Select(T_SUPERVISE_RESULT._.All,
                        RECORD_REVIEW._.TENDER_PROJECT_CODE.As("CODE"),
                        TENDER_PROJECT._.TENDER_PROJECT_NAME.As("PROJECT_NAME"),
                        TENDER_PROJECT._.RECORD_DEPID.As("DEPID"),
                        T_USER_DEPARTMENT._.DNAME.As("APPROVAL_DEPNAME"),
                        SYS_AREA_QUANGUO._.AREANAME.As("REGION_NAME"))
                    .ToList<TSuperviseZBBAResultModel>();
                var pageList = list.ToPageTableTResult(model, total);
                return pageList;
            }

            return model.ToPageTableTResult<TSuperviseZBBAResultModel>(total);
        }
        public GeneralResult<UploadResData> ZbbaExport(TSuperviseResultSearchModel model)
        {
            model.PageSize = int.MaxValue;
            var r = new GeneralResult<UploadResData>();
            var d = ReviewSuperviseList(model);
            if (d.Total > 0)
            {
                var data = new UploadResData
                {
                    //Id = Guid.NewGuid().ToString("N"),
                    FullUrl = $"/Temp/Export/{DateTime.Today:yyyyMMdd}/智能监察_招标备案_{DateTime.Now:HHmmssfff}_{Guid.NewGuid():N}.xls"
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
        /// <summary>
        /// 监察详情
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult ReviewSuperviseDetail(TSuperviseResultModel model)
        {
            var r = new GeneralResult();
            var dbModel = FromWhere(T_SUPERVISE_RESULT._.M_ID == model.M_ID)
                .InnerJoin<RECORD_REVIEW>(RECORD_REVIEW._.ID == T_SUPERVISE_RESULT._.ENTITY_ID)
                .InnerJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == RECORD_REVIEW._.TENDER_PROJECT_CODE)
                .LeftJoin<T_USER>(T_USER._.ID == RECORD_REVIEW._.REVIEW_PERSON)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == T_USER._.DEPARTID) //审查单位
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "3028" && SYS_DIC._.VALUE == RECORD_REVIEW._.REVIEW_STATUS)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "3021" && SYS_DIC._.VALUE == RECORD_REVIEW._.REVIEW_TYPE)
                .Select(T_SUPERVISE_RESULT._.All,
                    RECORD_REVIEW._.TENDER_PROJECT_CODE.As("CODE"),
                    TENDER_PROJECT._.TENDER_PROJECT_NAME.As("PROJECT_NAME"),
                    T_USER_DEPARTMENT._.DNAME.As("APPROVAL_DEPNAME"),
                    SYS_DIC._.TEXT.As("STATE_TEXT"),
                    new Field("TEXT", "SYS_DIC2").As("REVIEW_TYPE_TEXT"))
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
                foreach (var reviewSuperviseModel in supervise)
                {
                    reviewSuperviseModel.FILES_ATTACHMENT = Jd.CommonService.Attachments(
                        reviewSuperviseModel.FILES, "Sys",true);
                    superviseFeedback.Add(new TSuperviseAndFeedbackModel
                    {
                        LABEL = "发起督查",
                        VALUE = nameof(T_SUPERVISE),
                        TIME = reviewSuperviseModel.TIME,
                        DATA = reviewSuperviseModel
                    });
                }
                foreach (var reviewSuperviseModel in feedback)
                {
                    reviewSuperviseModel.FILES_ATTACHMENT = Jd.CommonService.Attachments(
                        reviewSuperviseModel.FILES, "Sys",true);
                    superviseFeedback.Add(new TSuperviseAndFeedbackModel
                    {
                        LABEL = "督察反馈",
                        VALUE = nameof(T_SUPERVISE_FEEDBACK),
                        TIME = reviewSuperviseModel.TIME,
                        DATA = reviewSuperviseModel
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
        public GeneralResult ReviewSupervise(TSuperviseModel model)
        {
            var r = new GeneralResult();
            model.M_ID = Guid.NewGuid().ToString();
            model.TIME = DateTime.Now;
            model.STATUS = 0;
            model.ENTITY_TYPE_NAME = nameof(RECORD_REVIEW);
            model.OP_ID = JdUser?.ID?.ToString();
            model.OP_NAME = JdUser?.MANAGE_NAME;
            model.DEP_ID = JdUser?.DEPARTID?.ToString();
            model.DEP_NAME = JdUser?.UserDepartment?.DNAME;
            var record = Jd.TenderProjectService.FromWhere(RECORD_REVIEW._.M_ID == model.ENTITY_ID)
                .InnerJoin<RECORD_REVIEW>(RECORD_REVIEW._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE).ToFirst();
            model.ENTITY_NAME = record?.TENDER_PROJECT_NAME;
            model.TENDER_PROJECT_CODE = record?.TENDER_PROJECT_CODE;
            model.TENDER_PROJECT_NAME = record?.TENDER_PROJECT_NAME;
            model.TENDER_PROJECT_TYPE = record?.TENDER_PROJECT_TYPE;
            model.REGION_CODE = record?.REGION_CODE;
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
        /// <summary>
        /// 列表查询
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// TENDER_PROJECT_CODE 招标计划编号
        /// TENDER_PROJECT_NAME 招标计划名称
        /// REGION_CODE 地区
        /// CREATE_TIME 提交日期
        /// TENDER_PROJECT_TYPE 业务类型
        /// RECORD_DEPID 审查单位
        /// </remarks>
        public PageTableResult<ReviewSuperviseProjectModel> ReviewSuperviseSearchList(ReviewSuperviseProjectModel model, SearchCondition search)
        {

            var hylist = JdUser?.UserDepartment?.HY_TYPE_LIST;
            var rootCode = JdUser?.UserDepartment?.RootAreaCode;
            if (hylist != null && hylist.Any() && !string.IsNullOrWhiteSpace(rootCode))
            {

                var condition = new WhereClipBuilder();

                //行业  JdUser.UserDepartment.HY_TYPE_List 
                condition.And(SYS_DIC._.VALUE3.In(hylist));
                //归属地 归属地 JdUser.UserDepartment.RootAreaCode REGION_COUNTY
                condition.And(TENDER_PROJECT._.REGION_CODE.BeginWith(rootCode));

                #region 查询条件

                //招标计划编号
                if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
                {
                    condition.And(TENDER_PROJECT._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
                }
                //招标计划名称
                if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
                {
                    condition.And(TENDER_PROJECT._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
                }
                //地区
                if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
                {
                    //截取字符串判断地区编号 末尾为0为市
                    if ((model.REGION_CODE.Substring(model.REGION_CODE.Length - 1, 1)) == "0")
                    {
                        condition.And(TENDER_PROJECT._.REGION_CODE.Contain(model.REGION_CODE.Substring(0, model.REGION_CODE.Length - 1)));
                    }
                    else
                    {
                        condition.And(TENDER_PROJECT._.REGION_CODE == (model.REGION_CODE));
                    }
                }

                //提交日期
                if (search.BeginTime.HasValue)
                {
                    condition.And(TENDER_PROJECT._.CREATE_TIME >= search.BeginTime);
                }
                if (search.EndTime.HasValue)
                {
                    condition.And(TENDER_PROJECT._.CREATE_TIME <= search.EndTime);
                }
                //业务类型
                if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
                {

                    condition.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE == (model.TENDER_PROJECT_TYPE));
                }

                //审查单位
                if (!string.IsNullOrWhiteSpace(model.RECORD_DEPID))
                {
                    condition.And(TENDER_PROJECT._.RECORD_DEPID == (model.RECORD_DEPID));
                }
                #endregion
                //数据记录条数
                var total = Jd.TenderProjectService.FromWhere(condition.ToWhereClip())
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "2002" && SYS_DIC._.VALUE == TENDER_PROJECT._.TENDER_PROJECT_TYPE)
                    .Count();
                //列表返回值
                var list = Jd.TenderProjectService.FromWhere()
                          .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == TENDER_PROJECT._.REGION_CODE)
                          .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == TENDER_PROJECT._.RECORD_DEPID)
                          .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "2002" && SYS_DIC._.VALUE == TENDER_PROJECT._.TENDER_PROJECT_TYPE)
                          .OrderByDescending(TENDER_PROJECT._.CREATE_TIME)
                          .Where(condition.ToWhereClip())
                          //分页页码
                          .Page(search.PageSize, search.PageNo)
                          .Select(
                          TENDER_PROJECT._.M_ID,
                          TENDER_PROJECT._.TENDER_PROJECT_CODE,
                          TENDER_PROJECT._.TENDER_PROJECT_NAME,
                          TENDER_PROJECT._.TENDERER_NAME,
                          TENDER_PROJECT._.TENDER_AGENCY_NAME,
                          T_USER_DEPARTMENT._.DNAME.As("DNAME"),
                          SYS_AREA_QUANGUO._.AREANAME.As("AREANAME"),
                          SYS_DIC._.TEXT.As("TENDER_PROJECT_TYPE"),
                          TENDER_PROJECT._.CREATE_TIME,
                          TENDER_PROJECT._.RECORD_DEPID
                    ).ToList<ReviewSuperviseProjectModel>();

                //返回列表值
                var pageList = list.ToPageTableTResult(search, total);
                return pageList;
            }

            return search.ToPageTableTResult<ReviewSuperviseProjectModel>();
        }
        public GeneralResult<UploadResData> ReviewSuperviseSearchExport(ReviewSuperviseProjectModel model, SearchCondition search)
        {
            search.PageSize = int.MaxValue;
            var r = new GeneralResult<UploadResData>();
            var d = ReviewSuperviseSearchList(model, search);
            if (d.Total > 0)
            {
                var data = new UploadResData
                {
                    FullUrl = $"/Temp/Export/{DateTime.Today:yyyyMMdd}/行政监督信息_招标项目_{DateTime.Now:HHmmssfff}_{Guid.NewGuid():N}.xls"
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

        /// <summary>
        /// 审查单位弹窗
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PageTableResult RecordDepid(T_USER_DEPARTMENT model, SearchCondition search)
        {

            var condition = new WhereClipBuilder();

            #region 查询条件

            //部门名称
            if (!string.IsNullOrWhiteSpace(model.DNAME))
            {
                condition.And(T_USER_DEPARTMENT._.DNAME.Contain(model.DNAME));
            }
            //行业类型
            if (!string.IsNullOrWhiteSpace(model.KINDS))
            {
                condition.And(T_USER_DEPARTMENT._.KINDS.Contain(model.KINDS));
            }
            //地区
            if (!string.IsNullOrWhiteSpace(model.AREACODE))
            {//  

                condition.And(T_USER_DEPARTMENT._.AREACODE == (model.AREACODE));
            }

            #endregion
            //数据记录条数
            var total = Jd.TUserDepartmentService.FromWhere(condition.ToWhereClip()).Count();
            //列表返回值
            var list = Jd.TUserDepartmentService.FromWhere().Where(condition.ToWhereClip())
                      //分页页码
                      .Page(search.PageSize, search.PageNo)
                      .OrderBy(T_USER_DEPARTMENT._.DNAME)
                      .Select(
                     T_USER_DEPARTMENT._.DNAME,
                     T_USER_DEPARTMENT._.DEPID.As("RECORD_DEPID"),
                     T_USER_DEPARTMENT._.DCODE,
                     T_USER_DEPARTMENT._.PHONE
                ).ToList<object>();

            //返回列表值
            var pageList = list.ToPageTableResult(search, total);
            return pageList;
        }

        protected WhereClipBuilder RecordReviewConditionBuilder(TSuperviseResultSearchModel model)
        {
            #region condition builder

            var entityName = nameof(RECORD_REVIEW);//model.ENTITY_TYPE_NAME;
            var condition = new WhereClipBuilder(T_SUPERVISE_RESULT._.ENTITY_TYPE_NAME == entityName && T_SUPERVISE_RESULT._.WARNING == 1);
            if (!string.IsNullOrWhiteSpace(model.PROJECT_NAME))
            {
                condition.And(TENDER_PROJECT._.TENDERER_NAME.Contain(model.PROJECT_NAME));
            }

            if (!string.IsNullOrWhiteSpace(model.CODE))
            {
                condition.And(RECORD_REVIEW._.TENDER_PROJECT_CODE.Contain(model.CODE));
            }

            if (model.BeginTime.HasValue)
            {
                condition.And(RECORD_REVIEW._.CREATE_TM >= model.BeginTime);
            }

            if (model.EndTime.HasValue)
            {
                condition.And(RECORD_REVIEW._.CREATE_TM <= model.EndTime);
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
                condition.And(T_USER._.DEPARTID == model.DEPID);
            }
            #endregion
            return condition;
        }
    }
}