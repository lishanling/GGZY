using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{

    /// <summary>
    /// 检察机关-纪委-智能监察-招标计划
    /// </summary>
    public partial class TSuperviseResultService
    {
      
        /// <summary>
        /// 招标计划-检查点-红灯变更为绿灯
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult SuperviseChange(TSuperviseResultLogModel model)
        {
            var r = new GeneralResult();
            var dbEntity = FirstOrNull(T_SUPERVISE_RESULT._.M_ID == model.M_ID);
            if (dbEntity != null)
            {
                using (var trans = GetDbSession().BeginTransaction())
                {
                    dbEntity.Attach();
                    dbEntity.STATUS = 0;
                    dbEntity.SUPERVISE_TIME = DateTime.Now;
                    dbEntity.SUPERVISE_OP_ID = JdUser?.ID?.ToString();
                    dbEntity.SUPERVISE_OP_NAME = JdUser?.USERNAME;
                    trans.Update(dbEntity);
                    var logEntity = new T_SUPERVISE_RESULT_LOG
                    {
                        M_ID = Guid.NewGuid().ToString("N"),
                        SUPERVISE_NAME = dbEntity.SUPERVISE_NAME,
                        SUPERVISE_TYPE = dbEntity.SUPERVISE_TYPE,
                        SUPERVISE_WAY = dbEntity.SUPERVISE_WAY,
                        STATUS = dbEntity.STATUS,
                        SUPERVISE_TIME = dbEntity.SUPERVISE_TIME,
                        SUPERVISE_OP_ID = dbEntity.SUPERVISE_OP_ID,
                        SUPERVISE_OP_NAME = dbEntity.SUPERVISE_OP_NAME,
                        SUPERVISE_DEP_ID = JdUser?.DEPARTID?.ToString(),
                        SUPERVISE_DEP_NAME = JdUser?.UserDepartment?.DNAME,
                        SUPERVISE_REMARK = model.SUPERVISE_REMARK,
                        ENTITY_ID = dbEntity.ENTITY_ID,
                        ENTITY_TYPE_NAME = dbEntity.ENTITY_TYPE_NAME,
                        SUPERVISE_ID = dbEntity.M_ID,
                        ENTITY_TENDER_PROJECT_CODE = dbEntity.ENTITY_TENDER_PROJECT_CODE,
                        ENTITY_TENDER_PROJECT_NAME = dbEntity.ENTITY_TENDER_PROJECT_NAME

                    };

                    trans.Insert(logEntity);
                    trans.Commit();
                    r.SetSuccess();
                    //model.SUPERVISE_REMARK
                }
            }
            else
            {
                r.SetFail("未找到对应的监察记录信息");
            }

            return r;
        }

        public GeneralResult Supervise(TSuperviseModel model)
        {
            var r = new GeneralResult();
            switch (model.ENTITY_TYPE_NAME)
            {
                case nameof(T_AFC_PROJECT):
                    r = AfcSupervise(model);
                    break;
                case nameof(TENDER_PROJECT):
                    r = TenderProjectSupervise(model);
                    break;
                case nameof(PT_ZXTS):
                    r = ZxtsSupervise(model);
                    break;
                case nameof(RECORD_REVIEW):
                    r = ReviewSupervise(model);
                    break;
                case nameof(GGZYFW.DbEntity.WARN_RESULT):
                    r = PointSupervise(model);
                    break;
                case nameof(GGZYFW.DbEntity.BD_VIOLATION_RECORD):
                    r = BdViolationRecordSupervise(model);
                    break;
                case nameof(GGZYFW.DbEntity.BD_VIOLATION_ENTITY):
                    r = BdViolationEntitySupervise(model);
                    break;
            }
            return r;
        }
        /// <summary>
        /// 招标计划登记 招标备案 投诉处理 监督点处理 督查细项
        /// </summary>
        /// <param name="model">ENTITY_TYPE_NAME ENTITY_ID</param>
        /// <returns></returns>
        public GeneralResult SuperviseItem(TSuperviseModel model)
        {
            var r = new GeneralResult();
            switch (model.ENTITY_TYPE_NAME)
            {
                case nameof(T_AFC_PROJECT):
                    r = Jd.TAfcProjectService.AfcSuperviseItem(model);
                    break;
                case nameof(PT_ZXTS):
                    r = Jd.PtZxtsService.PtZxtsSuperviseItem(model);
                    break;
                case nameof(RECORD_REVIEW):
                    r =Jd.RecordReviewService.RecordReviewSuperviseItem(model);
                    break;
                case nameof(GGZYFW.DbEntity.WARN_RESULT):
                    r = Fw.WarnResultService.RecordReviewSuperviseItem(model);
                    break;
            }
            return r;
        }

        public GeneralResult SuperviseDetail(TSuperviseResultModel model)
        {
            var r = new GeneralResult();
            var dbModel = FirstOrNull(T_SUPERVISE_RESULT._.M_ID == model.M_ID);
            if (dbModel == null)
            {
                r.SetFail("未找到对应的监察记录信息");
            }
            else
            {
                switch (dbModel.ENTITY_TYPE_NAME)
                {
                    case nameof(T_AFC_PROJECT):
                        r = AfcProjectSuperviseDetail(model);
                        break;
                    case nameof(PT_ZXTS):
                        r = ZxtsSuperviseDetail(model);
                        break;
                    case nameof(RECORD_REVIEW):
                        r = ReviewSuperviseDetail(model);
                        break;
                    case nameof(GGZYFW.DbEntity.WARN_RESULT):
                        r = PointSuperviseDetail(model);
                        break;
                }
            }
            return r;
        }
        /// <summary>
        /// 生成督查码
        /// </summary>
        /// <returns></returns>
        public string CreateSuperviseCode()
        {
            var idxStr = "-1";
            var key = $"SUPERVISE:CODE";
            if (Cache.IsSet(key))
            {
                idxStr =  Cache.Get<string>(key);
            }

            var idx = Convert.ToInt32(idxStr)+1;
            Cache.Set(key, idx, (int) (DateTime.Today.AddDays(1).AddSeconds(-1) - DateTime.Now).TotalMinutes);
            var idxSequence = idx.ToString().PadLeft(4, '0');
            var code = $"{DateTime.Today:yyMMdd}{idxSequence}";
            return code;
        }

        #region Schedule 计划任务 监察机关-纪委-智能监察-招标计划
        /// <summary>
        /// 处理时限
        /// 时限监察
        /// 自动
        /// 处理时限不超过15个工作日
        /// 提交日期、审查日期、当前处理状态
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        public void AfcProjectSuperviseTask(int pageSize = 500, int pageIndex = 1)
        {
            var workingday15 = DateTime.Today;//
            workingday15 = Jd.THolidayService.GetWorkDate(workingday15, -15);
            //bool isFirst = FromWhere().Count() == 0;
            var dataSource = new List<TAfcProjectModel>();
            do
            {
                dataSource = Jd.TAfcProjectService.FromWhere(T_AFC_PROJECT._.APPROVAL_STATE != 1)
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE=="63"&&SYS_DIC._.VALUE==T_AFC_PROJECT._.PROJECT_TYPE)
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "61" && SYS_DIC._.VALUE == T_AFC_PROJECT._.APPROVAL_STATE.ToChar()) //审查状态
                    .Select(
                        //T_AFC_PROJECT._.ID
                        //, T_AFC_PROJECT._.TM
                        //, T_AFC_PROJECT._.DATA_TIMESTAMP
                        //, T_AFC_PROJECT._.APPROVAL_STATE
                        //,T_AFC_PROJECT._.REGION_CITY
                        //, T_AFC_PROJECT._.REGION_COUNTY
                        //, T_AFC_PROJECT._.PROJECT_TYPE
                        //,T_AFC_PROJECT._.APPROVAL_TM
                        T_AFC_PROJECT._.All
                        ,SYS_DIC._.VALUE3.As("PROJECT_TYPE_NAME")
                        ,new Field("TEXT","SYS_DIC2").As("APPROVAL_STATE_NAME"))
                   .Page(pageSize, pageIndex)
                   .OrderBy(T_AFC_PROJECT._.TM, T_AFC_PROJECT._.ID)
                   .ToList<TAfcProjectModel>();
               

                #region do supervise

                var entityIds = dataSource.Select(c => c.ID).Distinct().ToList();
                var entityName = nameof(T_AFC_PROJECT);
                var newSupervise = new List<T_SUPERVISE_RESULT>();
                var updateSupervise = FromWhere(T_SUPERVISE_RESULT._.ENTITY_ID.In(entityIds) && T_SUPERVISE_RESULT._.ENTITY_TYPE_NAME == entityName).ToList();
                var logs = new List<T_SUPERVISE_RESULT_LOG>();

                foreach (var data in dataSource)
                {
                    var reasonRemark = "";//原因
                    var statusRemark = "";//状态
                    var status = 0;//绿灯 正常
                    var submitTime = data.TM;
                    if (data.APPROVAL_STATE == 2) //待审批 且提交时间
                    {
                        submitTime = data.DATA_TIMESTAMP;

                        if (data.DATA_TIMESTAMP < workingday15)
                        {
                            status = 1;//红灯
                            reasonRemark = $"原因:招标计划处理时限超过15个工作日";
                        }
                        else
                        {
                            status = 0;//绿灯
                            reasonRemark = $"原因:招标计划处理时限未超过15个工作日";
                        }

                    }
                    else
                    {
                        reasonRemark = $"原因:招标计划已处理({data.APPROVAL_STATE_NAME})";
                    }

                    var afcId = data.ID?.ToString();
                    string superviseName = "处理时限", superviseType = "时限监察", superviseWay = "自动监察", superviseRule = "招标计划处理时限不可超过15个工作日";
                    var now = DateTime.Now;

                    var supervise = updateSupervise.FirstOrDefault(c => c.ENTITY_ID == afcId && c.ENTITY_TYPE_NAME == entityName);
                    if (supervise != null)
                    {
                        if ((!string.IsNullOrWhiteSpace(supervise.SUPERVISE_OP_ID) || supervise.STATUS == status) && supervise.STATUS == 0)//纪委变更为绿灯 系统不再继续监察 | 绿灯未发生改变 系统不在监督
                        {
                            continue;
                        }
                        if (supervise.STATUS == status)
                        {
                            statusRemark = $"检查点状态为{(supervise.STATUS == 0 ? "绿灯" : "红灯")}未发生改变";
                        }
                        else
                        {
                            statusRemark = $"检查点状态由{(supervise.STATUS == 0 ? "绿灯" : "红灯")}变更为{(status == 0 ? "绿灯" : "红灯")}";
                        }
                        supervise.Attach();
                        supervise.STATUS = status;
                        if (!supervise.SUPERVISE_TIME.HasValue)
                        {
                            supervise.ENTITY_SUBMIT_TIME = submitTime;
                        }
                        if (!supervise.ENTITY_HANDLE_TIME.HasValue)
                        {
                            supervise.ENTITY_HANDLE_TIME = data.APPROVAL_TM;
                        }

                        if (supervise.WARNING != 1)
                        {
                            supervise.WARNING = status;
                        }
                        supervise.SUPERVISE_TIME = now;
                    }
                    else
                    {
                        supervise = new T_SUPERVISE_RESULT
                        {
                            M_ID = Guid.NewGuid().ToString("N"),
                            ENTITY_ID = afcId,
                            STATUS = status,
                            SUPERVISE_NAME = superviseName,
                            SUPERVISE_TYPE = superviseType,
                            SUPERVISE_WAY = superviseWay,
                            SUPERVISE_TIME = now,
                            SUPERVISE_RULE = superviseRule,
                            SUPERVISE_OP_ID = "",
                            SUPERVISE_OP_NAME = "系统",
                            ENTITY_SUBMIT_TIME = submitTime,
                            ENTITY_HANDLE_TIME = data.APPROVAL_TM,
                            ENTITY_TYPE_NAME=entityName,
                            ENTITY_REGION_CODE =!string.IsNullOrWhiteSpace(data.REGION_COUNTY)? data.REGION_COUNTY : data.REGION_CITY,
                            ENTITY_TENDER_PROJECT_TYPE = $"A{data.PROJECT_TYPE}",
                            WARNING=status,
                            ENTITY_TENDER_PROJECT_CODE = data.CODE,
                            ENTITY_TENDER_PROJECT_NAME=data.PROJECT_NAME
                        };
                        statusRemark = $"检查点状态由无变更为{(status == 0 ? "绿灯" : "红灯")}";
                        newSupervise.Add(supervise);
                    }

                    logs.Add(new T_SUPERVISE_RESULT_LOG
                    {
                        M_ID = Guid.NewGuid().ToString("N"),
                        ENTITY_ID = afcId,
                        STATUS = status,
                        SUPERVISE_ID = supervise.M_ID,
                        SUPERVISE_NAME = superviseName,
                        SUPERVISE_TYPE = superviseType,
                        SUPERVISE_WAY = superviseWay,
                        SUPERVISE_TIME = now,
                        SUPERVISE_REMARK = $"{statusRemark},{reasonRemark}",
                        SUPERVISE_OP_ID = "",
                        SUPERVISE_OP_NAME = "系统",
                        SUPERVISE_DEP_ID = "",
                        SUPERVISE_DEP_NAME = "系统",
                        ENTITY_REGION_CODE = !string.IsNullOrWhiteSpace(data.REGION_COUNTY) ? data.REGION_COUNTY : data.REGION_CITY,
                        ENTITY_TENDER_PROJECT_TYPE = $"A{data.PROJECT_TYPE}",
                        ENTITY_TYPE_NAME = entityName,
                        ENTITY_TENDER_PROJECT_CODE = data.CODE,
                        ENTITY_TENDER_PROJECT_NAME = data.PROJECT_NAME
                    });
                }

                using (var trans = GetDbSession().BeginTransaction())
                {
                    if (newSupervise.Any())
                    {
                        trans.Insert(newSupervise);
                    }

                    if (updateSupervise.Any())
                    {
                        trans.Update(updateSupervise);
                    }

                    trans.Insert(logs);
                    trans.Commit();
                }


                #endregion
                pageIndex++;

            } while (dataSource.Any());
        }

        #endregion

        #region Schedule 计划任务 监察机关-纪委-智能监察-投诉处理
        /// <summary>
        /// 处理时限
        /// 时限监察
        /// 自动
        /// 处理时限不超过15个工作日
        /// 提交日期、审查日期、当前处理状态
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        public void ZxtsSuperviseTask(int pageSize = 500, int pageIndex = 1)
        {
            var workingday15 = DateTime.Today;//
            workingday15 = Jd.THolidayService.GetWorkDate(workingday15, -15);
            //bool isFirst = FromWhere().Count() == 0;
            var dataSource = new List<PtZxtsModel>();
            do
            {
                dataSource = Jd.PtZxtsService.FromWhere(PT_ZXTS._.TYPE!=2)//排除线下投诉
                    .InnerJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE==PT_ZXTS._.TENDER_PROJECT_CODE)
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE=="72"&&SYS_DIC._.VALUE==PT_ZXTS._.STATE)
                    .Select(PT_ZXTS._.All
                        ,SYS_DIC._.TEXT.As("STATE_TEXT")
                        , TENDER_PROJECT._.REGION_CODE
                        , TENDER_PROJECT._.TENDER_PROJECT_TYPE)
                   .Page(pageSize, pageIndex)
                   .OrderBy(PT_ZXTS._.CREATE_TM, PT_ZXTS._.ID)
                   .ToList<PtZxtsModel>();
               

                #region do supervise

                var entityIds = dataSource.Select(c => c.ID).Distinct().ToList();
                var entityName = nameof(PT_ZXTS);
                var newSupervise = new List<T_SUPERVISE_RESULT>();
                var updateSupervise = FromWhere(T_SUPERVISE_RESULT._.ENTITY_ID.In(entityIds) && T_SUPERVISE_RESULT._.ENTITY_TYPE_NAME == entityName).ToList();
                var logs = new List<T_SUPERVISE_RESULT_LOG>();

                foreach (var data in dataSource)
                {
                    var reasonRemark = "";//原因
                    var statusRemark = "";//状态
                    var status = 0;//绿灯 正常
                    DateTime? submitTime = data.CREATE_TM;//提交时间
                    DateTime? handleTime = data.HANDLE_TM;//处理时间
                    if (data.STATE == "4" || (data.STATE == "7" && data.HANDLE_STATE == "1"))
                    {
                        if (data.IS_DELAY == "1")
                        {
                            submitTime = data.DELAY_TM;
                            if (DateTime.Now > data.DELAY_TM)
                            {
                                status = 1;//红灯
                                reasonRemark = $"原因:投诉处理时限超过延期时间";
                            }
                            else
                            {
                                status = 0;//绿灯
                                reasonRemark = $"原因:投诉处理时限未超过延期时间";
                            }
                        }
                        else
                        {
                            if (data.ACCEPT_TM < workingday15)//受理时间在15个工作日以前
                            {
                                status = 1;//红灯
                                reasonRemark = $"原因:投诉处理时限超过15个工作日";
                            }
                            else
                            {
                                status = 0;//绿灯
                                reasonRemark = $"原因:投诉处理时限未超过15个工作日";
                            }
                        }
                    }
                    else
                    {
                        reasonRemark = $"原因:投诉处理状态为{data.STATE_TEXT}";
                    }

                    //switch (data.STATE)
                    //{
                    //    case "1"://
                    //        break;
                    //    case "2"://待受理
                    //        break;
                    //    case "3"://不予受理
                    //        break;
                    //    case "4"://待处理
                    //        break;
                    //    case "5"://已处理
                    //        break;
                    //    case "6"://申请撤诉
                    //        break;
                    //    case "7"://不予撤诉
                    //        break;
                    //    case "8"://同意撤诉
                    //        break;
                    //    case "9"://撤销
                    //        break;
                    //}
                   

                    var entityId = data.ID?.ToString();
                    string superviseName = "处理时限", superviseType = "时限监察", superviseWay = "自动监察", superviseRule = "无延期情况下处理时限不超过30个工作日（如延期则另算）";
                    var now = DateTime.Now;

                    var supervise = updateSupervise.FirstOrDefault(c => c.ENTITY_ID == entityId && c.ENTITY_TYPE_NAME == entityName);
                    if (supervise != null)
                    {
                        if ((!string.IsNullOrWhiteSpace(supervise.SUPERVISE_OP_ID) || supervise.STATUS == status) && supervise.STATUS == 0)//纪委变更为绿灯 系统不再继续监察 | 绿灯未发生改变 系统不在监督
                        {
                            continue;
                        }
                        if (supervise.STATUS == status)
                        {
                            statusRemark = $"检查点状态为{(supervise.STATUS == 0 ? "绿灯" : "红灯")}未发生改变";
                        }
                        else
                        {
                            statusRemark = $"检查点状态由{(supervise.STATUS == 0 ? "绿灯" : "红灯")}变更为{(status == 0 ? "绿灯" : "红灯")}";
                        }
                        supervise.Attach();
                        supervise.STATUS = status;
                        if (!supervise.SUPERVISE_TIME.HasValue)
                        {
                            supervise.ENTITY_SUBMIT_TIME = submitTime;
                        }
                        if (!supervise.ENTITY_HANDLE_TIME.HasValue)
                        {
                            supervise.ENTITY_HANDLE_TIME = handleTime;
                        }

                        if (supervise.WARNING != 1)
                        {
                            supervise.WARNING = status;
                        }
                        supervise.SUPERVISE_TIME = now;
                    }
                    else
                    {
                        supervise = new T_SUPERVISE_RESULT
                        {
                            M_ID = Guid.NewGuid().ToString("N"),
                            ENTITY_ID = entityId,
                            STATUS = status,
                            SUPERVISE_NAME = superviseName,
                            SUPERVISE_TYPE = superviseType,
                            SUPERVISE_WAY = superviseWay,
                            SUPERVISE_TIME = now,
                            SUPERVISE_RULE = superviseRule,
                            SUPERVISE_OP_ID = "",
                            SUPERVISE_OP_NAME = "系统",
                            ENTITY_SUBMIT_TIME = submitTime,
                            ENTITY_HANDLE_TIME = handleTime,
                            ENTITY_TYPE_NAME = entityName,
                            ENTITY_REGION_CODE = data.REGION_CODE,
                            ENTITY_TENDER_PROJECT_TYPE = data.TENDER_PROJECT_TYPE,
                            WARNING=status,
                            ENTITY_TENDER_PROJECT_CODE = data.TENDER_PROJECT_CODE,
                            ENTITY_TENDER_PROJECT_NAME = data.TENDER_PROJECT_NAME
                        };
                        statusRemark = $"检查点状态由无变更为{(status == 0 ? "绿灯" : "红灯")}";
                        newSupervise.Add(supervise);
                    }

                    logs.Add(new T_SUPERVISE_RESULT_LOG
                    {
                        M_ID = Guid.NewGuid().ToString("N"),
                        ENTITY_ID = entityId,
                        STATUS = status,
                        SUPERVISE_ID = supervise.M_ID,
                        SUPERVISE_NAME = superviseName,
                        SUPERVISE_TYPE = superviseType,
                        SUPERVISE_WAY = superviseWay,
                        SUPERVISE_TIME = now,
                        SUPERVISE_REMARK = $"{statusRemark},{reasonRemark}",
                        SUPERVISE_OP_ID = "",
                        SUPERVISE_OP_NAME = "系统",
                        SUPERVISE_DEP_ID = "",
                        SUPERVISE_DEP_NAME = "系统",
                        ENTITY_REGION_CODE = data.REGION_CODE,
                        ENTITY_TENDER_PROJECT_TYPE = data.TENDER_PROJECT_TYPE,
                        ENTITY_TYPE_NAME = entityName,
                        ENTITY_TENDER_PROJECT_CODE = data.TENDER_PROJECT_CODE,
                        ENTITY_TENDER_PROJECT_NAME = data.TENDER_PROJECT_NAME
                    });
                }

                using (var trans = GetDbSession().BeginTransaction())
                {
                    if (newSupervise.Any())
                    {
                        trans.Insert(newSupervise);
                    }

                    if (updateSupervise.Any())
                    {
                        trans.Update(updateSupervise);
                    }

                    trans.Insert(logs);
                    trans.Commit();
                }


                #endregion
                pageIndex++;
            } while (dataSource.Any());
        }
        #endregion
    }
}