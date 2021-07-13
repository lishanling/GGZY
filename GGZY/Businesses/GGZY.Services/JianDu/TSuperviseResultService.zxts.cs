using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
    /// <summary>
    /// 执纪执法 纪委
    /// </summary>
    public partial class TSuperviseResultService
    {
        #region 智能监察

        #region 执纪执法 纪委 智能监察 投诉处理 当前筛选统计

        public List<LabelValueModel> ZxtsSuperviseCount(TSuperviseResultSearchModel model)
        {
            var condition = PtZxtsConditionBuilder(model);

            var normal = FromWhere(condition.ToWhereClip() && T_SUPERVISE_RESULT._.STATUS == 0).InnerJoin<PT_ZXTS>(PT_ZXTS._.ID == T_SUPERVISE_RESULT._.ENTITY_ID)
                .Select(new Field("'正常项目（个）'").As("Label"), Field.All.Count().As("Value"));
            var red = FromWhere(condition.ToWhereClip() && T_SUPERVISE_RESULT._.STATUS == 1).InnerJoin<PT_ZXTS>(PT_ZXTS._.ID == T_SUPERVISE_RESULT._.ENTITY_ID)
                .Select(new Field("'红灯项目（个）'").As("Label"), Field.All.Count().As("Value"));

            var r = FromWhere(condition.ToWhereClip()).InnerJoin<PT_ZXTS>(PT_ZXTS._.ID == T_SUPERVISE_RESULT._.ENTITY_ID)
                .Select(new Field("'监察项目数（个）'").As("Label"), Field.All.Count().As("Value"))
                .UnionAll(normal)
                .UnionAll(red)
                .ToList<LabelValueModel>();
            return r;
        }
        

        #endregion
        
        #region 执纪执法 纪委 智能监察 投诉处理 当前筛选列表

        public PageTableResult<TSuperviseResultZXTSModel> ZxtsSuperviseList(TSuperviseResultSearchModel model)
        {
            var condition = PtZxtsConditionBuilder(model);

            var queryable = FromWhere(condition.ToWhereClip())
                    .InnerJoin<PT_ZXTS>(
                        T_SUPERVISE_RESULT._.ENTITY_ID == PT_ZXTS._.ID)
                    .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == PT_ZXTS._.ACCEPT_DEPID) //审查单位
                    .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == T_SUPERVISE_RESULT._.ENTITY_REGION_CODE)
                //.LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "72" && SYS_DIC._.VALUE == PT_ZXTS._.STATE)
                ; //审查状态
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
                        PT_ZXTS._.CODE,
                        PT_ZXTS._.COMPLAINT_TITLE,
                        PT_ZXTS._.TENDER_PROJECT_NAME.As("PROJECT_NAME"),
                        T_USER_DEPARTMENT._.DNAME.As("APPROVAL_DEPNAME"),
                        SYS_AREA_QUANGUO._.AREANAME.As("REGION_NAME"),
                        PT_ZXTS._.ACCEPT_DEPID.As("DEPID"))
                    .ToList<TSuperviseResultZXTSModel>();
                var pageList = list.ToPageTableTResult(model, total);
                return pageList;
            }

            return model.ToPageTableTResult<TSuperviseResultZXTSModel>(total);
        }

        public GeneralResult<UploadResData> ZxtsExport(TSuperviseResultSearchModel model)
        {
            model.PageSize = int.MaxValue;
            var r = new GeneralResult<UploadResData>();
            var d = ZxtsSuperviseList(model);
            if (d.Total > 0)
            {
                var data = new UploadResData
                {
                    //Id = Guid.NewGuid().ToString("N"),
                    FullUrl = $"/Temp/Export/{DateTime.Today:yyyyMMdd}/智能监察_在线投诉_{DateTime.Now:HHmmssfff}_{Guid.NewGuid():N}.xls"
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

        #region 执纪执法 纪委 智能监察 投诉处理 督察详情

        /// <summary>
        /// 监察详情
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult ZxtsSuperviseDetail(TSuperviseResultModel model)
        {
            var r = new GeneralResult();
            var dbModel = FromWhere(T_SUPERVISE_RESULT._.M_ID == model.M_ID)
                .InnerJoin<PT_ZXTS>(
                    T_SUPERVISE_RESULT._.ENTITY_ID == PT_ZXTS._.ID)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == PT_ZXTS._.ACCEPT_DEPID) //审查单位
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "72" && SYS_DIC._.VALUE == PT_ZXTS._.STATE)
                .Select(T_SUPERVISE_RESULT._.All,
                    PT_ZXTS._.CODE,
                    PT_ZXTS._.TENDER_PROJECT_NAME.As("PROJECT_NAME"),
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
                foreach (var ZxtsSuperviseModel in supervise)
                {
                    ZxtsSuperviseModel.FILES_ATTACHMENT = Jd.CommonService.Attachments(
                        ZxtsSuperviseModel.FILES, "Sys",true);
                    superviseFeedback.Add(new TSuperviseAndFeedbackModel
                    {
                        LABEL = "发起督查",
                        VALUE = nameof(T_SUPERVISE),
                        TIME = ZxtsSuperviseModel.TIME,
                        DATA = ZxtsSuperviseModel
                    });
                }
                foreach (var ZxtsSuperviseModel in feedback)
                {
                    ZxtsSuperviseModel.FILES_ATTACHMENT = Jd.CommonService.Attachments(
                        ZxtsSuperviseModel.FILES, "Sys",true);
                    superviseFeedback.Add(new TSuperviseAndFeedbackModel
                    {
                        LABEL = "督察反馈",
                        VALUE = nameof(T_SUPERVISE_FEEDBACK),
                        TIME = ZxtsSuperviseModel.TIME,
                        DATA = ZxtsSuperviseModel
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

        #region 执纪执法 纪委 智能监察 投诉处理 督查

        /// <summary>
        /// 督察
        /// </summary>
        /// <returns></returns>
        public GeneralResult ZxtsSupervise(TSuperviseModel model)
        {
            var r = new GeneralResult();
            model.M_ID = Guid.NewGuid().ToString();
            model.TIME = DateTime.Now;
            model.STATUS = 0;
            model.ENTITY_TYPE_NAME = nameof(PT_ZXTS);
            model.OP_ID = JdUser?.ID?.ToString();
            model.OP_NAME = JdUser?.MANAGE_NAME;
            model.DEP_ID = JdUser?.DEPARTID?.ToString();
            model.DEP_NAME = JdUser?.UserDepartment?.DNAME;
            var zxts = Jd.PtZxtsService.FromWhere(PT_ZXTS._.ID == model.ENTITY_ID)
                .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE==PT_ZXTS._.TENDER_PROJECT_CODE)
                .Select(
                    TENDER_PROJECT._.REGION_CODE,
                    TENDER_PROJECT._.TENDER_PROJECT_TYPE,
                    PT_ZXTS._.All)
                .ToFirst<PtZxtsModel>();
            model.ENTITY_NAME = zxts?.COMPLAINT_TITLE;
            model.TENDER_PROJECT_CODE = zxts?.TENDER_PROJECT_CODE;
            model.TENDER_PROJECT_NAME = zxts?.TENDER_PROJECT_NAME;
            model.TENDER_PROJECT_TYPE = zxts?.TENDER_PROJECT_TYPE;
            model.REGION_CODE = zxts?.REGION_CODE ;
            if (!string.IsNullOrWhiteSpace(model.OBJ) && decimal.TryParse(model.OBJ, out decimal objId))
            {
                //var obj = Jd.TUserService.JdUserInfo(objId);
                var obj = Jd.TUserDepartmentService.FindDepartmentByDepid(objId);
                model.OBJ_NAME = obj?.DNAME;
                model.OBJ_DEP_ID =obj?.DEPID?.ToString();
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

        #region 执纪执法 纪委 智能监察 投诉处理 查询条件构建 

        protected WhereClipBuilder PtZxtsConditionBuilder(TSuperviseResultSearchModel model)
        {
            #region condition builder

            var entityName = nameof(PT_ZXTS);//model.ENTITY_TYPE_NAME;
            var condition = new WhereClipBuilder(T_SUPERVISE_RESULT._.ENTITY_TYPE_NAME == entityName&&PT_ZXTS._.TYPE!=2&&T_SUPERVISE_RESULT._.WARNING==1);
            if (!string.IsNullOrWhiteSpace(model.PROJECT_NAME))
            {
                condition.And(PT_ZXTS._.TENDER_PROJECT_NAME.Contain(model.PROJECT_NAME));
            }

            if (!string.IsNullOrWhiteSpace(model.CODE))
            {
                condition.And(PT_ZXTS._.CODE.Contain(model.CODE));
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
                condition.And(T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_TYPE == model.PROJECT_TYPE);
            }

            if (!string.IsNullOrWhiteSpace(model.STATUS))
            {
                condition.And(T_SUPERVISE_RESULT._.STATUS == model.STATUS);
            }

            if (!string.IsNullOrWhiteSpace(model.DEPID))
            {
                condition.And(PT_ZXTS._.ACCEPT_DEPID == model.DEPID);
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

            var hyTypes = JdUser?.UserDepartment?.SYS_DIC_63;
            if (hyTypes != null && hyTypes.Any())
            {
                var projectTypes = hyTypes.Select(c => c.VALUE3).ToList();
                condition.And(T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_TYPE.In(projectTypes));
            }

            #endregion
            return condition;
        }

        #endregion

        #endregion

        #region 行政监督信息

        
        #region   执纪执法 纪委 行政监督信息 投诉处理 投诉信息查询
        /// <summary>
        /// 列表查询
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// </remarks>
        public PageTableResult<XinPtZxtsModel> ZxtsSuperviseSearchList(XinPtZxtsModel model, SearchCondition search)
        {
            var condition = new WhereClipBuilder();
            var hylist = JdUser?.UserDepartment?.TENDER_PROJECT_TYPES;
            var rootCode = JdUser?.UserDepartment?.RootAreaCode;
            if (hylist != null && hylist.Any() && !string.IsNullOrWhiteSpace(rootCode))
            {
                //行业  JdUser.UserDepartment.HY_TYPE_List 
                condition.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(hylist));
                //归属地 归属地 JdUser.UserDepartment.RootAreaCode REGION_COUNTY
                condition.And(TENDER_PROJECT._.REGION_CODE.Contain(rootCode));

                #region 查询条件

                //投诉编号
                if (!string.IsNullOrWhiteSpace(model.CODE))
                {
                    condition.And(PT_ZXTS._.CODE.Contain(model.CODE));
                }
                //投诉标题
                if (!string.IsNullOrWhiteSpace(model.COMPLAINT_TITLE))
                {
                    condition.And(PT_ZXTS._.COMPLAINT_TITLE.Contain(model.COMPLAINT_TITLE));
                }
                //招标项目名称
                if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
                {//  

                    condition.And(PT_ZXTS._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
                }
                //提交日期
                if (search.BeginTime.HasValue)
                {
                    condition.And(PT_ZXTS._.CREATE_TM >= search.BeginTime);
                }
                if (search.EndTime.HasValue)
                {
                    condition.And(PT_ZXTS._.CREATE_TM <= search.EndTime);
                }
                //业务类型
                if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
                {

                    condition.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE == (model.TENDER_PROJECT_TYPE));
                }
                //审查单位
                if (!string.IsNullOrWhiteSpace(model.ACCEPT_DEPID))
                {
                    condition.And(PT_ZXTS._.ACCEPT_DEPID == (model.ACCEPT_DEPID));
                }
                #endregion
                //数据记录条数
                var total = Jd.PtZxtsService.FromWhere(condition.ToWhereClip())
                    .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == PT_ZXTS._.TENDER_PROJECT_CODE)
                    .Count();
                //列表返回值
                var list = Jd.PtZxtsService.FromWhere()
                          .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == PT_ZXTS._.TENDER_PROJECT_CODE)
                          .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == PT_ZXTS._.ACCEPT_DEPID)
                          .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == TENDER_PROJECT._.REGION_CODE)
                          .Where(condition.ToWhereClip())
                          .OrderByDescending(PT_ZXTS._.CREATE_TM)
                          //分页页码
                          .Page(search.PageSize, search.PageNo)
                          .Select(
                          PT_ZXTS._.ID.As("M_ID"),
                          PT_ZXTS._.CODE,
                          PT_ZXTS._.COMPLAINT_TITLE,
                          PT_ZXTS._.COMPLAINT_NAME,
                          TENDER_PROJECT._.TENDER_PROJECT_NAME,
                          TENDER_PROJECT._.TENDER_PROJECT_CODE,
                          PT_ZXTS._.CREATE_TM,
                          PT_ZXTS._.HANDLE_TM,
                          PT_ZXTS._.COMPLAINT_SX,
                          PT_ZXTS._.ACCEPT_DEPID,
                          SYS_AREA_QUANGUO._.AREANAME,
                          T_USER_DEPARTMENT._.DNAME
                    ).ToList<XinPtZxtsModel>();

                //返回列表值
                var pageList = list.ToPageTableTResult(search, total);
                return pageList;
            }

            return search.ToPageTableTResult<XinPtZxtsModel>();
        }
        /// <summary>
        /// 投诉信息-导出
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public GeneralResult<UploadResData> ZxtsSuperviseSearchExport(XinPtZxtsModel model, SearchCondition search)
        {
            search.PageSize = int.MaxValue;
            var r = new GeneralResult<UploadResData>();
            var d = ZxtsSuperviseSearchList(model, search);
            if (d.Total > 0)
            {
                var data = new UploadResData
                {
                    FullUrl = $"/Temp/Export/{DateTime.Today:yyyyMMdd}/行政监督信息_投诉信息_{DateTime.Now:HHmmssfff}_{Guid.NewGuid():N}.xls"
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

        #endregion
    }
}