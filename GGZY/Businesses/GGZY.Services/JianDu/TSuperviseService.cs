using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model.BigData;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TSuperviseService
    {
        #region 已发督查

        /// <summary>
        /// 已发督查
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult<TSuperviseModel> SupervisionIssued(TSuperviseModel model, SearchCondition search)
        {
            var jdUserId = JdUser?.ID;
            //var pageList = search.ToPageTableResult();
            var condition = model.ConditionBuilder(search);
            condition.And(T_SUPERVISE._.OP_ID == jdUserId);
            var whereClip = condition.ToWhereClip();
            var total = FromWhere(whereClip).Count();
            if (total > 0)
            {
                var list = FromWhere(whereClip)
                    .OrderBy(T_SUPERVISE._.TIME.Desc)
                    .Page(search.PageSize, search.PageNo)
                    .ToList<TSuperviseModel>();
                var pageList = list.ToPageTableTResult(search, total);
                return pageList;
            }

            return search.ToPageTableTResult<TSuperviseModel>(total);
        }

        public GeneralResult<UploadResData> YfdcExport(TSuperviseModel model, SearchCondition search)
        {
            search.PageSize = int.MaxValue;
            var r = new GeneralResult<UploadResData>();
            var d = SupervisionIssued(model, search);
            if (d.Total > 0)
            {
                var data = new UploadResData
                {
                    //Id = Guid.NewGuid().ToString("N"),
                    FullUrl = $"/Temp/Export/{DateTime.Today:yyyyMMdd}/督查情况_已发督察_{DateTime.Now:HHmmssfff}_{Guid.NewGuid():N}.xls"
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

        #region 上级督查

        /// <summary>
        /// 上级督查
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult<TSuperviseModel> SuperiorInspector(TSuperviseModel model, SearchCondition search)
        {
            var departid = JdUser?.DEPARTID?.ToString() ?? JdUser?.DEPARTIDS?.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).LastOrDefault();
            // var pageList = search.ToPageTableResult();
            var condition = model.ConditionBuilder(search);
            condition.And(T_SUPERVISE._.OBJ_DEP_ID == departid);
            var whereClip = condition.ToWhereClip();
            var total = FromWhere(whereClip).Count();
            if (total > 0)
            {
                var list = FromWhere(whereClip)
                    .OrderBy(T_SUPERVISE._.TIME.Desc)
                    .Page(search.PageSize, search.PageNo)
                    .ToList<TSuperviseModel>();
                var pageList = list.ToPageTableTResult(search, total);
                return pageList;
            }

            return search.ToPageTableTResult<TSuperviseModel>(total);
        }

        /// <summary>
        /// 上级督察-导出
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public GeneralResult<UploadResData> SjdcExport(TSuperviseModel model, SearchCondition search)
        {
            search.PageSize = int.MaxValue;
            var r = new GeneralResult<UploadResData>();
            var d = SuperiorInspector(model, search);
            if (d.Total > 0)
            {
                var data = new UploadResData
                {
                    FullUrl = $"/Temp/Export/{DateTime.Today:yyyyMMdd}/督查情况_上级督查_{DateTime.Now:HHmmssfff}_{Guid.NewGuid():N}.xls"
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

        #region 详情
        #region 督查来源

        /// <summary>
        /// 督查来源
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public object SuperviseForward(TSuperviseModel model)
        {
            var subQuery = FromWhere<T_SUPERVISE_FORWARD>(T_SUPERVISE_FORWARD._.SUPERVISE_ID == model.M_ID).Select(T_SUPERVISE_FORWARD._.SUPERVISE_INSTANCE_ID);
            var list = FromWhere<T_SUPERVISE_FORWARD>(
                    T_SUPERVISE_FORWARD._.SUPERVISE_INSTANCE_ID.SubQueryEqual(subQuery))
                .OrderBy(T_SUPERVISE_FORWARD._.FORWARD_TIME).ToList();
            var r = list.Select(c => new LabelValueModel
            {
                Id = c.M_ID,
                Label = c.DEP_NAME,
                Value = c.SUPERVISE_ID
            }).ToList();
            //var last = list.LastOrDefault();
            //if (last != null)
            //{
            //    r.Add(new LabelValueModel
            //    {
            //        Id = last.M_ID,
            //        Label = last.OBJDEP_NAME,
            //        Value = last.SUPERVISE_ID
            //    });
            //}
            var cur = list.FirstOrDefault(c => c.SUPERVISE_ID == model.M_ID);//当前督查

            var superiorInspector = list.LastOrDefault(c => c.FORWARD_TIME < cur.FORWARD_TIME);//再当前督查前面存在更早的督查信息，本督查来源为转发督查=>查看上级督查
            return new
            {
                Forward = r,
                SuperiorInspectorId = superiorInspector?.SUPERVISE_ID ?? ""
            };
        }
        #endregion

        #region 督查信息
        /// <summary>
        /// 督查信息
        /// </summary>
        /// <param name="searchModel"></param>
        /// <returns></returns>
        public TSuperviseModel SuperviseInfo(TSuperviseModel searchModel)
        {

            var model = FromWhere(T_SUPERVISE._.M_ID == searchModel.M_ID).ToFirst<TSuperviseModel>();
            model.FILES_ATTACHMENT = Jd.CommonService.Attachments(model.FILES, "Sys",true);
            switch (model.ENTITY_TYPE_NAME)
            {
                case nameof(T_AFC_PROJECT):
                    model.HY_DEPID = Jd.TAfcProjectService.FirstOrNull(T_AFC_PROJECT._.ID == model.ENTITY_ID)?.APPROVAL_DEPID;
                    break;
                case nameof(RECORD_REVIEW):
                    model.HY_DEPID = Jd.RecordReviewService.FromWhere(RECORD_REVIEW._.M_ID == model.ENTITY_ID)
                        .InnerJoin<TENDER_PROJECT>(RECORD_REVIEW._.TENDER_PROJECT_CODE ==
                                                   TENDER_PROJECT._.TENDER_PROJECT_CODE)
                        .Select(TENDER_PROJECT._.RECORD_DEPID).ToScalar<string>();
                    break;
                case nameof(TENDER_PROJECT):
                    model.HY_DEPID = Jd.TenderProjectService.FirstOrNull(TENDER_PROJECT._.M_ID == model.ENTITY_ID)?.RECORD_DEPID;
                    break;
                case nameof(PT_ZXTS):
                    model.HY_DEPID = Jd.PtZxtsService.FirstOrNull(PT_ZXTS._.ID == model.ENTITY_ID)?.ACCEPT_DEPID;
                    break;
                case nameof(GGZYFW.DbEntity.WARN_RESULT):
                    //todo
                    break;
            }
            model.BUTTONS = new List<string>();
            if (model.OBJ_DEP_ID == JdUser?.DEPARTID?.ToString())
            {
                //if (!model.STATUS.HasValue || model.STATUS <= 0)
                {
                    model.BUTTONS.Add("FEEDBACK");
                }

                if (JdUser?.UserDepartment?.DTYPE == ConfigHelper.AppSettings.JD_DEP_JIWEI_TYPE)
                {
                    model.BUTTONS.Add("FORWARD");
                }

            }
            return model;
        }

        #endregion

        #region 督查事项
        /// <summary>
        /// 督查事项
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public object SuperviseItem(TSuperviseModel model)
        {
            object result = null;
            var supervise = FromWhere<T_SUPERVISE_FORWARD>(T_SUPERVISE_FORWARD._.SUPERVISE_ID == model.M_ID).ToFirst();
            switch (supervise.ENTITY_TYPE_NAME)
            {
                case nameof(T_AFC_PROJECT)://招标计划
                    result = SuperviseAfcItem(supervise);
                    break;
                case nameof(PT_ZXTS)://投诉处理
                    result = SuperviseZxtsItem(supervise);
                    break;
                case nameof(RECORD_REVIEW)://招标备案
                    result = SuperviseZbba(supervise);
                    break;
                case nameof(GGZYFW.DbEntity.WARN_RESULT)://监督点处理
                    result = SuperviseWarnResult(supervise);
                    break;
                case nameof(TENDER_PROJECT)://招标项目
                    result = SuperviseTenderProject(supervise);
                    break;
                case  nameof(GGZYFW.DbEntity.BD_VIOLATION_RECORD)://  疑似违规点项目
                    result = SuperviseBdViolationRecord(supervise);
                    break;
                case nameof(GGZYFW.DbEntity.BD_VIOLATION_ENTITY)://疑似违规点主体
                    result = SuperviseBdViolationEntity(supervise);
                    break;
            }

            return result;
        }
        #region 督查事项-招标计划

        /// <summary>
        /// 督查事项-招标计划
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// 招标计划
        /// 事项类型、审查单位、招标计划编号、招标计划名称、地区、督查原由、
        /// （注释：
        /// 1、督查原由：如该条条督查是从智能监察发起的，则该字段显示，并且填写内容为，监察点名称，例：处理时限；
        /// 2、如非智能监察模块发起的，则该字段隐藏
        /// ）
        /// </remarks>
        private object SuperviseAfcItem(T_SUPERVISE_FORWARD model)
        {

            var fields = new List<Field>
            {
                new Field("'1'").As("MODULE_TYPE"),
                new Field("'招标计划'").As("SUPERVISE_ITEM_NAME"),
                T_USER_DEPARTMENT._.DNAME,
                T_AFC_PROJECT._.PROJECT_CODE,
                T_AFC_PROJECT._.PROJECT_NAME,
                SYS_AREA_QUANGUO._.AREANAME
            };
            if (model?.SUPERVISE_ID == model?.SUPERVISE_INSTANCE_ID)
            {
                fields.Add(new Field("'处理时限'").As("SUPERVISE_REASON"));
            }
            var entity = Jd.TAfcProjectService.FromWhere(T_AFC_PROJECT._.ID == model?.ENTITY_ID)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == T_AFC_PROJECT._.APPROVAL_DEPID)
                .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == T_AFC_PROJECT._.REGION_CITY)
                .Select(
                    fields.ToArray()
                ).ToFirst<object>();
            return entity;
        }


        #endregion

        #region 督查事项-投诉处理
        /// <summary>
        /// 督查事项-投诉处理
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// 事项类型、处理单位、投诉编号、投诉标题、招标项目名称、督查原由、
        /// （注释：
        /// 1、督查原由：如该条条督查是从智能监察发起的，则该字段显示，并且填写内容为，监察点名称，例：处理时限；
        /// 2、如非智能监察模块发起的，则该字段隐藏
        /// ）
        /// </remarks>
        public object SuperviseZxtsItem(T_SUPERVISE_FORWARD model)
        {
            var fields = new List<Field>
            {
                new Field("'3'").As("MODULE_TYPE"),
                new Field("'投诉处理'").As("SUPERVISE_ITEM_NAME"),
                T_USER_DEPARTMENT._.DNAME,
                PT_ZXTS._.CODE,
                PT_ZXTS._.COMPLAINT_TITLE,
                PT_ZXTS._.TENDER_PROJECT_NAME,
            };
            if (model?.SUPERVISE_ID == model?.SUPERVISE_INSTANCE_ID)
            {
                fields.Add(new Field("'处理时限'").As("SUPERVISE_REASON"));
            }
            var entity = Jd.PtZxtsService.FromWhere(PT_ZXTS._.ID == model?.ENTITY_ID)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == PT_ZXTS._.ACCEPT_DEPID)
                .Select(
                    fields.ToArray()
                ).ToFirst<object>();
            return entity;
        }

        #endregion

        #region 督查事项-招标备案
        /// <summary>
        /// 督查事项-招标备案
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// 事项类型、备案类型名称、审查单位、招标编号、招标项目名称、督查原由、
        /// （注释：备案类型名称，即为 招标文件备案、澄清修改备案 等）
        /// （注释：
        /// 1、督查原由：如该条条督查是从智能监察发起的，则该字段显示，并且填写内容为，监察点名称，例：处理时限；
        /// 2、如非智能监察模块发起的，则该字段隐藏
        /// ）
        /// </remarks>
        private object SuperviseZbba(T_SUPERVISE_FORWARD model)
        {
            var fields = new List<Field>
            {
                new Field("'2'").As("MODULE_TYPE"),
                new Field("'招标备案'").As("SUPERVISE_ITEM_NAME"),
                SYS_DIC._.TEXT.As("REVIEW_TYPE_TEXT"),
                T_USER_DEPARTMENT._.DNAME,
                RECORD_REVIEW._.TENDER_PROJECT_CODE,
                TENDER_PROJECT._.TENDER_PROJECT_NAME,
            };
            if (model?.SUPERVISE_ID == model?.SUPERVISE_INSTANCE_ID)
            {
                fields.Add(new Field("'处理时限'").As("SUPERVISE_REASON"));
            }
            var entity = Jd.RecordReviewService.FromWhere(RECORD_REVIEW._.ID == model?.ENTITY_ID)
                .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == RECORD_REVIEW._.TENDER_PROJECT_CODE)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "3021" && SYS_DIC._.VALUE == RECORD_REVIEW._.REVIEW_TYPE)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == TENDER_PROJECT._.RECORD_DEPID)
                .Select(
                    fields.ToArray()
                ).ToFirst<object>();
            return entity;
        }

        #endregion
        #region 督查事项-招标项目

        /// <summary>
        /// 督查事项-招标项目
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// 招标项目 事项类型、 审查单位、招标编号、招标项目名称、
        /// </remarks>
        private object SuperviseTenderProject(T_SUPERVISE_FORWARD model)
        {
            var fields = new List<Field>
            {
                new Field("'5'").As("MODULE_TYPE"),
                new Field("'招标项目'").As("SUPERVISE_ITEM_NAME"),
                //SYS_DIC._.TEXT.As("REVIEW_TYPE_TEXT"),
                T_USER_DEPARTMENT._.DNAME,
                TENDER_PROJECT._.TENDER_PROJECT_CODE,
                TENDER_PROJECT._.TENDER_PROJECT_NAME,
            };
            //if (model?.SUPERVISE_ID == model?.SUPERVISE_INSTANCE_ID)
            //{
            //    fields.Add(new Field("'处理时限'").As("SUPERVISE_REASON"));
            //}
            var entity = Jd.TenderProjectService.FromWhere(TENDER_PROJECT._.M_ID == model?.ENTITY_ID)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == TENDER_PROJECT._.RECORD_DEPID)
                .Select(
                    fields.ToArray()
                ).ToFirst<object>();
            return entity;
        }

        #endregion

        #region 督查事项-监督点处理
        /// <summary>
        /// 督查事项-招标备案
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// 事项类型、监督单位、招标编号、招标项目名称、触发监督点、监督点类型、监督方式、归属环节、督查原由、
        /// （注释：
        /// 1、督查原由：如该条条督查是从智能监察发起的，则该字段显示，并且填写内容为，监察点名称，例：处理时限；
        /// 2、如非智能监察模块发起的，则该字段隐藏
        /// ）
        /// </remarks>
        private object SupervisePoint(T_SUPERVISE_FORWARD model)
        {
            var fields = new List<Field>
            {
                new Field("'4'").As("MODULE_TYPE"),
                new Field("'监督点处理'").As("SUPERVISE_ITEM_NAME"),
                T_PROJECT_DATA._.SUPERVISE_DEPT_NAME,
                T_PROJECT_DATA._.PROJECT_CODE,
                T_PROJECT_DATA._.PROJECT_NAME,
                T_MP_PLAN_INFO._.NAME,//监督点名称
                SYS_DIC._.TEXT.As("TYPE_TEXT"),//T_MP_PLAN_INFO._.TYPE,//监督点类型
                new Field("(CASE T_MP_PLAN_INFO.ISUSER WHEN '1' THEN '人工监督' ELSE '自动监督' END )").As("ISUSER_TEXT"),//监督方式
                T_TP_TACHE._.NAME.As("TACHE_NAME"),//归属环节
            };
            if (model?.SUPERVISE_ID == model?.SUPERVISE_INSTANCE_ID)
            {
                fields.Add(new Field("'处理时限'").As("SUPERVISE_REASON"));
            }
            var entity = Jd.TProjectDataService.FromWhere(T_PROJECT_DATA._.ID == model?.ENTITY_ID)
                .InnerJoin<T_TP_TACHE>(T_TP_TACHE._.TP_CODE == T_PROJECT_DATA._.TP_CODE)
                .InnerJoin<T_TP_NODE>(T_TP_NODE._.TACHE_CODE == T_TP_TACHE._.CODE)
                .InnerJoin<T_MP_PLAN_INFO>(T_MP_PLAN_INFO._.NODE_CODE == T_TP_NODE._.CODE)
                .LeftJoin<T_PM_JDINFO>(T_PM_JDINFO._.TENDER_PROJECT_CODE == T_PROJECT_DATA._.PROJECT_CODE &&
                                       T_PM_JDINFO._.MPID == T_MP_PLAN_INFO._.ID)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "52" && SYS_DIC._.VALUE == T_MP_PLAN_INFO._.TYPE)
                .Select(
                    fields.ToArray()
                ).ToFirst<object>();
            return entity;
        }
        /// <summary>
        /// 督查事项-招标备案
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// 事项类型、监督单位、招标编号、招标项目名称、触发监督点、监督点类型、监督方式、归属环节、督查原由、
        /// （注释：
        /// 1、督查原由：如该条条督查是从智能监察发起的，则该字段显示，并且填写内容为，监察点名称，例：处理时限；
        /// 2、如非智能监察模块发起的，则该字段隐藏
        /// ）
        /// </remarks>
        private object SuperviseWarnResult(T_SUPERVISE_FORWARD model)
        {
            var fields = new List<Field>
            {
                new Field("'4'").As("MODULE_TYPE"),
                new Field("'监督点处理'").As("SUPERVISE_ITEM_NAME"),
                new Field("''").As("SUPERVISE_DEPT_NAME"),
               GGZYFW.DbEntity.WARN_RESULT._.TENDER_PROJECT_CODE,
               GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_NAME,
                GGZYFW.DbEntity.WARN_EXPRESSION._.SP_NAME,//监督点名称
                GGZYFW.DbEntity.WARN_EXPRESSION._.SP_TYPE,//T_MP_PLAN_INFO._.TYPE,//监督点类型
                GGZYFW.DbEntity.WARN_EXPRESSION._.SP_WAY,//监督方式
                GGZYFW.DbEntity.WARN_EXPRESSION._.SP_FLOW_NAME,//归属环节
            };
            if (model?.SUPERVISE_ID == model?.SUPERVISE_INSTANCE_ID)
            {
                fields.Add(new Field("'处理时限'").As("SUPERVISE_REASON"));
            }
            var entity = Fw.WarnResultService.FromWhere(GGZYFW.DbEntity.WARN_RESULT._.M_ID == model?.ENTITY_ID)
                .LeftJoin<GGZYFW.DbEntity.TENDER_PROJECT>(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == GGZYFW.DbEntity.WARN_RESULT._.TENDER_PROJECT_CODE)
                .LeftJoin<GGZYFW.DbEntity.WARN_EXPRESSION>(GGZYFW.DbEntity.WARN_EXPRESSION._.M_ID == GGZYFW.DbEntity.WARN_RESULT._.SP_ID)
                .Select(
                    fields.ToArray()
                ).ToFirst<object>();
            return entity;
        }

        /// <summary>
        /// 疑似违规点项目
        /// </summary>
        /// <param name="model"></param>
        /// <returns>
        /// 疑似违规点项目
        /// 事项类型、监督单位、招标编号、招标项目名称、触发疑似违规点、
        /// </returns>
        private object SuperviseBdViolationRecord(T_SUPERVISE_FORWARD model)
        {
            var fields = new List<Field>
            {
                new Field("'6'").As("MODULE_TYPE"),
                new Field("'疑似违规点项目'").As("SUPERVISE_ITEM_NAME"),
                new Field("''").As("SUPERVISE_DEPT_NAME"),
               GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE,
               GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_NAME,
                GGZYFW.DbEntity.BD_VIOLATION_POINT_DETAIL._.NAME,
            };
            if (model?.SUPERVISE_ID == model?.SUPERVISE_INSTANCE_ID)
            {
                fields.Add(new Field("'处理时限'").As("SUPERVISE_REASON"));
            }
            var entity = Fw.BdViolationRecordService.FromWhere(GGZYFW.DbEntity.BD_VIOLATION_RECORD._.ID == model?.ENTITY_ID)
                .LeftJoin<GGZYFW.DbEntity.BD_VIOLATION_POINT_DETAIL>(GGZYFW.DbEntity.BD_VIOLATION_RECORD._.POINT_ID == GGZYFW.DbEntity.BD_VIOLATION_POINT_DETAIL._.ID)
                .Select(
                    fields.ToArray()
                ).ToFirst<object>();
            return entity;
        }

        /// <summary>
        /// 疑似违规点主体督查事项
        /// </summary>
        /// <param name="model"></param>
        /// <returns>
        /// 疑似违规点主体
        /// 事项类型、监督单位、主体类型、单位名称、企业代码、招标编号、招标项目名称、触发疑似违规点、
        /// （注释：主体类型包含 招标人、代理机构、投标人）
        /// </returns>
        private object SuperviseBdViolationEntity(T_SUPERVISE_FORWARD model)
        {
            var fields = new List<Field>
            {
                new Field("'7'").As("MODULE_TYPE"),
                new Field("'疑似违规点主体'").As("SUPERVISE_ITEM_NAME"),
                new Field("''").As("SUPERVISE_DEPT_NAME"),
                new Field("(CASE ENTITY_TYPE WHEN 1 THNE '招标人' WHEN 2 THEN '代理机构' WHEN 3 '投标人' ELSE TO_CHAR(ENTITY_TYPE) END )").As("ENTITY_TYPE_TEXT"),
               GGZYFW.DbEntity.BD_VIOLATION_ENTITY._.ENTITY_NAME,
               GGZYFW.DbEntity.BD_VIOLATION_ENTITY._.ENTITY_CODE,
               new Field("''").As("TENDER_PROJECT_CODE"),
               new Field("''").As("TENDER_PROJECT_NAME"),
               GGZYFW.DbEntity.BD_VIOLATION_POINT_DETAIL._.NAME,
            };
            if (model?.SUPERVISE_ID == model?.SUPERVISE_INSTANCE_ID)
            {
                fields.Add(new Field("'处理时限'").As("SUPERVISE_REASON"));
            }
            var entity = Fw.BdViolationEntityService.FromWhere(GGZYFW.DbEntity.BD_VIOLATION_ENTITY._.ID == model?.ENTITY_ID)
                .LeftJoin<GGZYFW.DbEntity.BD_VIOLATION_POINT_DETAIL>(GGZYFW.DbEntity.BD_VIOLATION_POINT_DETAIL._.ID==GGZYFW.DbEntity.BD_VIOLATION_ENTITY._.POINT_ID)
               .Select(
                    fields.ToArray()
                ).ToFirst<object>();
            return entity;
        }
        #endregion

        #endregion

        #region 反馈记录
        /// <summary>
        /// 反馈记录
        /// </summary>
        /// <param name="searchModel"></param>
        /// <returns></returns>
        public List<TSuperviseFeedbackModel> SuperviseFeedback(TSuperviseModel searchModel)
        {
            var feedback = FromWhere<T_SUPERVISE_FEEDBACK>(T_SUPERVISE_FEEDBACK._.SUPERVISE_ID == searchModel.M_ID)
                .OrderBy(T_SUPERVISE_FEEDBACK._.TIME.Desc)
                .ToList<TSuperviseFeedbackModel>();
            foreach (var model in feedback)
            {
                model.FILES_ATTACHMENT = Jd.CommonService.Attachments(model.FILES, "Sys",true);
            }

            return feedback;
        }

        #endregion

        #region 操作记录
        /// <summary>
        /// 操作记录
        /// </summary>
        /// <param name="searchModel"></param>
        /// <returns></returns>
        public List<object> SuperviseLog(TSuperviseModel searchModel)
        {
            var logs = FromWhere<T_SUPERVISE_LOG>(T_SUPERVISE_LOG._.SUPERVISE_ID == searchModel.M_ID)
                .LeftJoin<T_SUPERVISE>(T_SUPERVISE._.M_ID == T_SUPERVISE_LOG._.SUPERVISE_FORWORD_ID &&
                                       T_SUPERVISE_LOG._.LOG_TYPE == "30")
                .OrderBy(T_SUPERVISE_LOG._.LOG_TIME)
                .Select(
                    T_SUPERVISE_LOG._.DEP_NAME
                    , T_SUPERVISE_LOG._.OP_NAME
                    , T_SUPERVISE_LOG._.LOG_TIME
                    , T_SUPERVISE_LOG._.LOG_TYPE_TXT
                    , T_SUPERVISE._.CODE
                    )
                .ToList<object>();
            return logs;
        }

        #endregion
        #endregion

        #region 督察反馈

        public GeneralResult Feedback(TSuperviseFeedbackModel model)
        {
            var r = new GeneralResult();
            var supervise = FromWhere(T_SUPERVISE._.M_ID == model.SUPERVISE_ID).ToFirst();

            model.M_ID = Guid.NewGuid().ToString();
            model.TIME = DateTime.Now;
            model.ENTITY_ID = supervise.ENTITY_ID;
            model.ENTITY_TYPE_NAME = supervise.ENTITY_TYPE_NAME;
            model.OP_ID = JdUser?.ID?.ToString();
            model.OP_NAME = JdUser?.MANAGE_NAME;
            model.DEP_ID = JdUser?.DEPARTID?.ToString();
            model.DEP_NAME = JdUser?.UserDepartment?.DNAME;
            model.OBJ = supervise.OP_ID;
            model.OBJ_NAME = supervise.OP_NAME;
            model.OBJ_DEP_ID = supervise.DEP_ID;
            model.OBJDEP_NAME = supervise.DEP_NAME;
            model.CODE = Jd.TSuperviseResultService.CreateSuperviseCode();

            using (var trans = GetDbSession().BeginTransaction())
            {
                if (model.FILES_ATTACHMENT != null && model.FILES_ATTACHMENT.Any())
                {
                    var attachments = model.FILES_ATTACHMENT.Select(c => c.JdSysAttachment()).ToList();
                    trans.Insert(attachments);
                    model.FILES = string.Join(",", attachments.Select(c => c.GUID));
                }

                var entity = model.ConvertTo<T_SUPERVISE_FEEDBACK>();
                trans.Insert(entity);

                #region 督查操作记录

                var log = new T_SUPERVISE_LOG
                {
                    M_ID = Guid.NewGuid().ToString(),
                    ENTITY_ID = model.ENTITY_ID,
                    ENTITY_TYPE_NAME = model.ENTITY_TYPE_NAME,
                    SUPERVISE_ID = model.SUPERVISE_ID,
                    OP_ID = model.OP_ID,
                    OP_NAME = model.OP_NAME,
                    DEP_ID = model.DEP_ID,
                    DEP_NAME = model.DEP_NAME,
                    OBJ = model.OBJ,
                    OBJ_NAME = model.OBJ_NAME,
                    OBJ_DEP_ID = model.OBJ_DEP_ID,
                    OBJDEP_NAME = model.OBJDEP_NAME,
                    LOG_TIME = DateTime.Now,
                    LOG_TYPE = "20",
                    LOG_TYPE_TXT = "督查反馈",
                    SUPERVISE_FEEDBACK_ID = model.M_ID,
                    SUPERVISE_FORWORD_ID = String.Empty,
                };
                trans.Insert(log);

                #endregion

                supervise.Attach();
                supervise.STATUS = (supervise.STATUS ?? 0) + 1;
                trans.Update(supervise);
                trans.Commit();
            }
            r.SetSuccess();

            return r;
        }

        #endregion

        #region 转发督查

        public GeneralResult Forward(TSuperviseModel model)
        {
            var r = new GeneralResult();
            var supervise = FromWhere(T_SUPERVISE._.M_ID == model.SUPERVISE_ID).ToFirst();

            model.M_ID = Guid.NewGuid().ToString();
            model.TIME = DateTime.Now;
            model.STATUS = 0;
            model.ENTITY_TYPE_NAME = supervise.ENTITY_TYPE_NAME;
            model.ENTITY_ID = supervise.ENTITY_ID;
            model.OP_ID = JdUser?.ID?.ToString();
            model.OP_NAME = JdUser?.MANAGE_NAME;
            model.DEP_ID = JdUser?.DEPARTID?.ToString();
            model.DEP_NAME = JdUser?.UserDepartment?.DNAME;

            model.ENTITY_NAME = supervise?.ENTITY_NAME;
            model.REGION_CODE = supervise?.REGION_CODE;
            model.TENDER_PROJECT_TYPE = supervise?.TENDER_PROJECT_TYPE;
            model.TENDER_PROJECT_CODE = supervise?.TENDER_PROJECT_CODE;
            model.TENDER_PROJECT_NAME = supervise?.TENDER_PROJECT_NAME;
            if (!string.IsNullOrWhiteSpace(model.OBJ) && decimal.TryParse(model.OBJ, out decimal objId))
            {
                var obj = Jd.TUserDepartmentService.FindDepartmentByDepid(objId);
                model.OBJ_NAME = obj?.DNAME;
                model.OBJ_DEP_ID = obj?.DEPID?.ToString();
                model.OBJDEP_NAME = obj?.DNAME;
                model.CODE = Jd.TSuperviseResultService.CreateSuperviseCode();
                using (var trans = GetDbSession().BeginTransaction())
                {
                    var attachments = model.FILES_ATTACHMENT.Select(c => c.JdSysAttachment()).ToList();
                    trans.Insert(attachments);
                    model.FILES = string.Join(",", attachments.Select(c => c.GUID));
                    var entity = model.ConvertTo<T_SUPERVISE>();
                    trans.Insert(entity);

                    #region 督查流转实例
                    var lastForward = FromWhere<T_SUPERVISE_FORWARD>(T_SUPERVISE_FORWARD._.SUPERVISE_ID == model.SUPERVISE_ID).ToFirst();
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
                        SUPERVISE_INSTANCE_ID = lastForward.SUPERVISE_INSTANCE_ID,
                    };
                    trans.Insert(forward);


                    #endregion
                    #region 督查操作记录

                    var forwardLog = new T_SUPERVISE_LOG
                    {
                        M_ID = Guid.NewGuid().ToString(),
                        ENTITY_ID = model.ENTITY_ID,
                        ENTITY_TYPE_NAME = model.ENTITY_TYPE_NAME,
                        SUPERVISE_ID = lastForward.SUPERVISE_ID,
                        OP_ID = model.OP_ID,
                        OP_NAME = model.OP_NAME,
                        DEP_ID = model.DEP_ID,
                        DEP_NAME = model.DEP_NAME,
                        OBJ = model.OBJ,
                        OBJ_NAME = model.OBJ_NAME,
                        OBJ_DEP_ID = model.OBJ_DEP_ID,
                        OBJDEP_NAME = model.OBJDEP_NAME,
                        LOG_TIME = DateTime.Now,
                        LOG_TYPE = "30",
                        LOG_TYPE_TXT = "转发督查",
                        SUPERVISE_FEEDBACK_ID = String.Empty,
                        SUPERVISE_FORWORD_ID = forward.M_ID,
                    };
                    trans.Insert(forwardLog);
                    //var log = new T_SUPERVISE_LOG
                    //{
                    //    M_ID = Guid.NewGuid().ToString(),
                    //    ENTITY_ID = model.ENTITY_ID,
                    //    ENTITY_TYPE_NAME = model.ENTITY_TYPE_NAME,
                    //    SUPERVISE_ID = model.M_ID,
                    //    OP_ID = model.OP_ID,
                    //    OP_NAME = model.OP_NAME,
                    //    DEP_ID = model.DEP_ID,
                    //    DEP_NAME = model.DEP_NAME,
                    //    OBJ = model.OBJ,
                    //    OBJ_NAME = model.OBJ_NAME,
                    //    OBJ_DEP_ID = model.OBJ_DEP_ID,
                    //    OBJDEP_NAME = model.OBJDEP_NAME,
                    //    LOG_TIME = DateTime.Now,
                    //    LOG_TYPE = "10",
                    //    LOG_TYPE_TXT = "发起督察",
                    //    SUPERVISE_FEEDBACK_ID = String.Empty,
                    //    SUPERVISE_FORWORD_ID = String.Empty,
                    //};
                    //trans.Insert(log);
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

        #region 督查抄送

        /// <summary>
        /// 督查抄送
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult<TSuperviseModel> SupervisionCC(TSuperviseModel model, SearchCondition search)
        {
            //var pageList = search.ToPageTableResult();
            var areaCode = JdUser?.UserDepartment?.AREACODE;
            var total = 0;
            if (!string.IsNullOrWhiteSpace(areaCode) && areaCode.EndsWith("0"))
            {
                var departid = JdUser?.DEPARTID?.ToString() ?? JdUser?.DEPARTIDS?.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).LastOrDefault();
                var condition = model.ConditionBuilder(search);
                condition.And(T_SUPERVISE._.DEP_ID != departid);//督查人不是自己
                condition.And(T_SUPERVISE._.OBJ_DEP_ID != departid);//督查对象不是自己
                condition.And(T_SUPERVISE._.REGION_CODE != "350000");
                var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode;
                if (!string.IsNullOrWhiteSpace(rootAreaCode))
                {
                    condition.And(T_SUPERVISE._.REGION_CODE.Contain(rootAreaCode));
                    if (rootAreaCode == "3501")
                    {
                        condition.And(T_SUPERVISE._.REGION_CODE != "350128");
                    }
                }
                var hyTypes = JdUser?.UserDepartment?.SYS_DIC_63;
                if (hyTypes != null && hyTypes.Any())
                {
                    var projectTypes = hyTypes.Select(c => c.VALUE3).ToList();
                    condition.And(T_SUPERVISE._.TENDER_PROJECT_TYPE.In(projectTypes));
                }

                var whereClip = condition.ToWhereClip();
                total = FromWhere(whereClip).Count();
                if (total > 0)
                {
                    var list = FromWhere(whereClip)
                        .OrderBy(T_SUPERVISE._.TIME.Desc)
                        .Page(search.PageSize, search.PageNo)
                        .ToList<TSuperviseModel>();
                    var pageList = list.ToPageTableTResult(search, total);
                    return pageList;
                }
            }

            return search.ToPageTableTResult<TSuperviseModel>(total); ;
        }
        /// <summary>
        /// 督查抄送
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public GeneralResult<UploadResData> DccsExport(TSuperviseModel model, SearchCondition search)
        {
            search.PageSize = int.MaxValue;
            var r = new GeneralResult<UploadResData>();
            var d = SupervisionCC(model, search);
            if (d.Total > 0)
            {
                var data = new UploadResData
                {
                    FullUrl = $"/Temp/Export/{DateTime.Today:yyyyMMdd}/督查情况_督查抄送_{DateTime.Now:HHmmssfff}_{Guid.NewGuid():N}.xls"
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

        #region 首页-上级督察情况统计图
        /// <summary>
        /// 上级督察情况-数量统计
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// 上级督查=督查对象组织机构ID为当前登录账号组织机构ID=>T_SUPERVISE.OBJ_DEP_ID==JdUser.DEPARTID
        /// 不需要再默认过滤行业与归属地
        /// </remarks>
        public List<LabelValueModel<int>> UpCount(TAfcProjectStatisticsModel model)
        {
            var condition = new WhereClipBuilder();
            //统计当前账号的上级督察
            //督察当前账号id
            condition.And(T_SUPERVISE._.OBJ_DEP_ID == JdUser?.DEPARTID);
            //时间
            if (model.BeginTime.HasValue)
            {
                condition.And(T_SUPERVISE._.TIME >= model.BeginTime);
            }
            if (model.EndTime.HasValue)
            {
                condition.And(T_SUPERVISE._.TIME <= model.EndTime);
            }

            if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
            {
                condition.And(T_SUPERVISE._.REGION_CODE==model.REGION_CODE);
            }
            if (model.TENDER_PROJECT_TYPES!=null&&model.TENDER_PROJECT_TYPES.Any())
            {
                condition.And(T_SUPERVISE._.TENDER_PROJECT_TYPE.In(model.TENDER_PROJECT_TYPES));
            }
            var feedback = Count(condition.ToWhereClip() && T_SUPERVISE._.STATUS == 0);//未反馈
            var total = Count(condition);//总数
            var done = total - feedback;
            return new List<LabelValueModel<int>>
            {
                new LabelValueModel<int>{Id = "T_SUPERVISE_TOTAL",Label = "上级督察总数",Value = total},
                new LabelValueModel<int>{Id="T_SUPERVISE_UN_FEEDBACK",Label = "上级督未反馈",Value = feedback},
                new LabelValueModel<int>{Id = "T_SUPERVISE_FEEDBACK",Label = "上级督察已反馈数",Value = done},
            };
        }
        /// <summary>
        ///  上级督察情况-根据事项类型统计接口
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// 上级督查=督查对象组织机构ID为当前登录账号组织机构ID=>T_SUPERVISE.OBJ_DEP_ID==JdUser.DEPARTID
        /// 不需要再默认过滤行业与归属地
        /// </remarks>
        public List<PieSeriesData> UpGroupByType(TAfcProjectStatisticsModel model)
        {
            var condition = new WhereClipBuilder();
            condition.And(T_SUPERVISE._.OBJ_DEP_ID == JdUser?.DEPARTID);//督察对象是当前账号
            if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
            {
                condition.And(T_SUPERVISE._.REGION_CODE == model.REGION_CODE);
            }
            if (model.TENDER_PROJECT_TYPES != null && model.TENDER_PROJECT_TYPES.Any())
            {
                condition.And(T_SUPERVISE._.TENDER_PROJECT_TYPE.In(model.TENDER_PROJECT_TYPES));
            }
            if (model.BeginTime != null)
            {
                condition.And(T_SUPERVISE._.TIME >= model.BeginTime);
            }
            if (model.EndTime != null)
            {
                condition.And(T_SUPERVISE._.TIME <= model.EndTime);
            }

            var result = FromWhere(condition.ToWhereClip()).Select(T_SUPERVISE._.ENTITY_TYPE_NAME.As("Label"),
                    T_SUPERVISE_RESULT._.All.Count().As("Value"))
                .GroupBy(T_SUPERVISE._.ENTITY_TYPE_NAME).ToList<LabelValueModel<int>>();

            //罗列所有的 级督查事项类型  无数据的做数据填充 补0
            return new List<PieSeriesData>
            {
                new PieSeriesData{Name = "招标计划登记",Value = result.FirstOrDefault(o=>o.Label==nameof(T_AFC_PROJECT))?.Value??0},
                new PieSeriesData{Name = "投诉处理",Value = result.FirstOrDefault(o=>o.Label==nameof(PT_ZXTS))?.Value??0},
                new PieSeriesData{Name = "招标备案",Value = result.FirstOrDefault(o=>o.Label==nameof(RECORD_REVIEW))?.Value??0},
                new PieSeriesData{Name = "监督点处理",Value = result.FirstOrDefault(o=>o.Label==nameof(GGZYFW.DbEntity.WARN_RESULT))?.Value??0},
                new PieSeriesData{Name = "招标项目",Value = result.FirstOrDefault(o=>o.Label==nameof(TENDER_PROJECT))?.Value??0},
                new PieSeriesData{Name = "疑似违规点",Value = (result.FirstOrDefault(o=>o.Label==nameof(GGZYFW.DbEntity.BD_VIOLATION_RECORD))?.Value??0)+(result.FirstOrDefault(o=>o.Label==nameof(GGZYFW.DbEntity.BD_VIOLATION_ENTITY))?.Value??0)},
            };
        }
       
        #endregion
    }
}




