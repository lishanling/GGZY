using Dos.ORM;
using GGZY.Core.Log;
using GGZYJD.DbEntity;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GGZY.Services.Base;
using GGZY.Core.Extensions;

namespace GGZY.Scheduler.BeianService
{
    public class Main : GGZY.Services.Base.BaseServiceT<RECORD_REVIEW>, IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            return Task.Factory.StartNew(() =>
            {
                Logger.Info("监察机关-纪委-智能监察-项目备案 开始");
                Service();
                Logger.Info("监察机关-纪委-智能监察-项目备案 结束");
            });
        }

        private void Service()
        {
            var condition = new WhereClipBuilder();
            condition.And(new Field("INSTR(RECORD_REVIEW.REVIEW_TYPE,'103')") ==0);
            condition.And(RECORD_REVIEW._.REVIEW_STATUS > 0);

            
            var pageSize = 50;
           
            var entity_type_name = "RECORD_REVIEW";//监察表名称
            var rule_desc = "招标备案处理时限不超过15个工作日";
            var reasonRemark = "";//原因
            var statusRemark = "";//状态

            var now = GetDBTime();

            var db = GetDbSession();

            var records = new List<RECORD_REVIEW_SUPERVISION>();
            var recordSucess = 0;
            var recordFail = 0;
            do
            {
                var fromsection = FromWhere<RECORD_REVIEW>()
                .InnerJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == RECORD_REVIEW._.TENDER_PROJECT_CODE)
                .LeftJoin<T_SUPERVISE_RESULT>(T_SUPERVISE_RESULT._.ENTITY_TYPE_NAME == "RECORD_REVIEW"
                && T_SUPERVISE_RESULT._.ENTITY_ID == RECORD_REVIEW._.ID)
                 .Where(
               condition.ToWhereClip()
               && (new Field("NVL(RECORD_REVIEW.COMMIT_TIME,SYSDATE)") != new Field("NVL(T_SUPERVISE_RESULT.ENTITY_SUBMIT_TIME,SYSDATE)")
               || new Field("NVL(RECORD_REVIEW.REVIEW_TIME,SYSDATE)") != new Field("NVL(T_SUPERVISE_RESULT.ENTITY_HANDLE_TIME,SYSDATE)")))
                .OrderBy(RECORD_REVIEW._.ID)
                 .Select(
                    RECORD_REVIEW._.ID,
                    RECORD_REVIEW._.REVIEW_STATUS,
                    RECORD_REVIEW._.COMMIT_TIME,
                    RECORD_REVIEW._.REVIEW_TIME.As("SOURCE_REVIEW_TIME"),//保留原始值，可用于监察记录复制用
                    new Field("NVL(REVIEW_TIME,SYSDATE)").As("REVIEW_TIME"),
                    RECORD_REVIEW._.TENDER_PROJECT_CODE,
                    TENDER_PROJECT._.TENDER_PROJECT_NAME,
                    TENDER_PROJECT._.TENDER_PROJECT_TYPE,
                    TENDER_PROJECT._.REGION_CODE,
                    new Field("GETWORKDATE(COMMIT_TIME,15)").As("SUPERVION_END_TIME")
                    );

                records = fromsection.Top(pageSize).ToList<RECORD_REVIEW_SUPERVISION>();

                records.ForEach(record =>
                {
                    var entity = Jd.TSuperviseResultService.FirstOrNull(T_SUPERVISE_RESULT._.ENTITY_TYPE_NAME == entity_type_name
                        && T_SUPERVISE_RESULT._.ENTITY_ID == record.ID.ToString());
                    var isNew = false;
                    if (null == entity)
                    {
                        entity = new T_SUPERVISE_RESULT();
                        entity.M_ID = Guid.NewGuid().ToString("N");
                        entity.WARNING = 0;
                        isNew = true;
                        statusRemark = $"检查点状态由无变更为{(record.REVIEW_TIME > record.SUPERVION_END_TIME ? "红灯" : "绿灯")}";
                    }
                    var oldStatus = entity.STATUS;
                    entity.Attach();
                    entity.ENTITY_HANDLE_TIME = record.SOURCE_REVIEW_TIME;
                    entity.ENTITY_ID = record.ID.ToString();
                    entity.ENTITY_REGION_CODE = record.REGION_CODE;
                    entity.ENTITY_SUBMIT_TIME = record.COMMIT_TIME;
                    entity.ENTITY_TENDER_PROJECT_CODE = record.TENDER_PROJECT_CODE;
                    entity.ENTITY_TENDER_PROJECT_NAME = record.TENDER_PROJECT_NAME;
                    entity.ENTITY_TENDER_PROJECT_TYPE = record.TENDER_PROJECT_TYPE;
                    entity.ENTITY_TYPE_NAME = entity_type_name;
                    entity.STATUS = record.REVIEW_TIME > record.SUPERVION_END_TIME ? 1 : 0;
                    if (record.REVIEW_TIME > record.SUPERVION_END_TIME)
                    {
                        entity.WARNING = 1;
                    }
                    entity.SUPERVISE_NAME = "处理时限";
                    entity.SUPERVISE_OP_NAME = "系统";
                    entity.SUPERVISE_RULE = rule_desc;
                    entity.SUPERVISE_TIME = now;
                    entity.SUPERVISE_TYPE = "时限监察";
                    entity.SUPERVISE_WAY = "自动监察";

                    if (String.IsNullOrWhiteSpace(statusRemark))
                    {
                        statusRemark = $"检查点状态由{(oldStatus == 1 ? "红灯" : "绿灯")} 变更为 {(record.REVIEW_TIME > record.SUPERVION_END_TIME ? "红灯" : "绿灯")}";
                    }
                    reasonRemark = $"原因:招标备案处理时限{(record.REVIEW_TIME > record.SUPERVION_END_TIME ? "" : "不")}超过15个工作日";

                    if (record.REVIEW_TIME < record.SUPERVION_END_TIME)
                    {
                        reasonRemark += "，招标备案" + ((EnumOperation)Convert.ToInt32(record.REVIEW_STATUS)).DisplayEnumDescription();
                    }

                    T_SUPERVISE_RESULT_LOG history = new T_SUPERVISE_RESULT_LOG()
                    {
                        ENTITY_ID = record.ID.ToString(),
                        ENTITY_REGION_CODE = record.REGION_CODE,
                        ENTITY_TENDER_PROJECT_CODE = record.TENDER_PROJECT_CODE,
                        ENTITY_TENDER_PROJECT_NAME = record.TENDER_PROJECT_NAME,
                        ENTITY_TENDER_PROJECT_TYPE = record.TENDER_PROJECT_TYPE,
                        ENTITY_TYPE_NAME = entity_type_name,
                        M_ID = Guid.NewGuid().ToString("N"),
                        STATUS = record.REVIEW_TIME > record.SUPERVION_END_TIME ? 1 : 0,
                        SUPERVISE_NAME = "处理时限",
                        SUPERVISE_OP_NAME = "系统",
                        SUPERVISE_TIME = now,
                        SUPERVISE_TYPE = "时限监察",
                        SUPERVISE_WAY = "自动监察",
                        SUPERVISE_REMARK = $"{statusRemark},{reasonRemark}",
                        SUPERVISE_ID = entity.M_ID
                    };

                    using (var tran = db.BeginTransaction())
                    {
                        try
                        {
                            if (isNew)
                            {
                                tran.Insert<T_SUPERVISE_RESULT>(entity);
                            }
                            else
                            {
                                tran.Update<T_SUPERVISE_RESULT>(entity);
                            }
                            tran.Insert<T_SUPERVISE_RESULT_LOG>(history);
                            tran.Commit();
                            recordSucess++;

                        }
                        catch (Exception ex)
                        {
                         
                            recordFail++;
                            tran.Rollback();
                            Logger.Error("招标备案智能监察失败：" + ex.Message + ",T_SUPERVISE_RESULT：\r\n" + Newtonsoft.Json.JsonConvert.SerializeObject(entity), ex);
                        }
                    }

                    LoggerR.Info(now.ToString("yyyyMMddHHmmsssss"),$"招标备案智能监察完成。本次处理成功：{(recordSucess)}条，失败：{(recordFail)}条");
                });
            }
            while (records.Any());
        }

        public class RECORD_REVIEW_SUPERVISION:RECORD_REVIEW
        {
            /// <summary>
            /// 截止审查时间
            /// </summary>
            public DateTime SUPERVION_END_TIME { get; set; }
            /// <summary>
            /// 招标项目名称
            /// </summary>
            public string TENDER_PROJECT_NAME { get; set; }
            /// <summary>
            /// 招标项目类型，对应TENDER_PROJECT表对应字段
            /// </summary>
            public string TENDER_PROJECT_TYPE { get; set; }
            /// <summary>
            /// 招标项目所在地区
            /// </summary>
            public string REGION_CODE { get; set; }

            /// <summary>
            /// 审查时间
            /// </summary>
            public DateTime? SOURCE_REVIEW_TIME { get; set; }
        }
    }
}