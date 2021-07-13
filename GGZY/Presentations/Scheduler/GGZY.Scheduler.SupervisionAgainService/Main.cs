using Dos.ORM;
using GGZY.Core.Log;
using GGZY.Services.Base;
using GGZYFW.DbEntity;
using GGZYJD.DbEntity;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Scheduler.SupervisionAgainService
{
    /// <summary>
    /// 监督点再监察服务
    /// </summary>
    public class Main: GGZY.Services.Base.BaseServiceT<WARN_RESULT>, IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            return Task.Factory.StartNew(() =>
            {
                Logger.Info("监察机关-纪委-智能监察-监督点 开始");
                Service();
                Logger.Info("监察机关-纪委-智能监察-监督点 结束");
            });
        }

        private void Service()
        {
            var condition = new WhereClipBuilder();
            condition.And(WARN_RESULT._.RESULT_STATUS ==3);
            condition.And(WARN_RESULT._.OPERATE_STATUS == 0);
            condition.And(WARN_RESULT._.DEAL_LIMIT_TIME >= new Field("SYSDATE"));


            var warn_expressions = Fw.WarnExpressionService.FindAll();

            var recordCount = Fw.WarnResultService.Count(condition.ToWhereClip());
            var pageSize = 50;
            var pageCount = Math.Ceiling(recordCount/(pageSize * 1.0));
            Logger.Info("监察机关-纪委-智能监察-监督点 共有 "+recordCount + "条记录," + pageCount+" 页");
            var now = GetDBTime();
            for (int i = 1; i <= pageCount; i++)
            {
                Logger.Info("监察机关-纪委-智能监察-监督点 当前处理第 " + i + "页记录,共" + pageCount + " 页");
                var records = Fw.WarnResultService.PageList<WARN_RESULT>(condition, pageSize, i);
                records.ForEach(r => {
                    var expression = warn_expressions.Where(w => w.M_ID == r.SP_ID).FirstOrDefault();
                    
                    var sup_result = new T_SUPERVISE_RESULT();
                    sup_result.M_ID = Guid.NewGuid().ToString("N");
                    sup_result.ENTITY_TYPE_NAME = "WARN_RESULT";
                    sup_result.ENTITY_ID = r.M_ID;
                    sup_result.STATUS = 0;
                    sup_result.ENTITY_TENDER_PROJECT_TYPE = r.TENDER_PROJECT_TYPE;
                    sup_result.ENTITY_REGION_CODE = r.REGION_CODE;
                    sup_result.SUPERVISE_NAME = "处理时限";
                    sup_result.SUPERVISE_WAY = expression.SP_WAY;
                    sup_result.SUPERVISE_TYPE = expression.SP_TYPE;
                    sup_result.SUPERVISE_RULE = "监督点处理时限不超过30个工作日";
                    sup_result.SUPERVISE_TIME = now;
                    sup_result.ENTITY_SUBMIT_TIME = r.SP_TIME;
                    sup_result.ENTITY_HANDLE_TIME = r.LAST_RECORD_TIME;
                    sup_result.SUPERVISE_OP_NAME = "系统";
                    Jd.TSuperviseResultService.Add(sup_result);

                });
            }
        }
    }
}
