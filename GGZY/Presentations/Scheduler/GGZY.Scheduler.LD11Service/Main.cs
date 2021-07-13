using GGZY.Core.Log;
using GGZYFW.DbEntity;
using Newtonsoft.Json;
using Quartz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Scheduler.LD11Service
{
    /// <summary>
    /// 量定LD11-特级资质要求
    /// </summary>
    public class Main : GGZY.Services.Base.BaseServiceT<BD_VIOLATION_POINT>, IJob
    {
        protected string point_code = "WG0411";
        protected const string actionName = "量身定做-特级资质要求";
        public Task Execute(IJobExecutionContext context)
        {
            return Task.Factory.StartNew(() =>
            {
                GGZY.Core.Log.Logger.Info(point_code + " 定时任务开始执行--------------");

                try
                {
                    var point_detail = FirstOrNull<BD_VIOLATION_POINT_DETAIL>(BD_VIOLATION_POINT_DETAIL._.CODE == point_code
                           && BD_VIOLATION_POINT_DETAIL._.IS_ENABLE == 1);
                    if (null == point_detail)
                    {
                        Logger.Error("未找到编号为" + point_code + "的疑似违规行为配置项");
                        return;
                    }

                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("SELECT TP.TENDER_PROJECT_TYPE,");
                    sb.AppendLine("       TP.REGION_CODE,");
                    sb.AppendLine("       TP.TENDER_PROJECT_CODE,");
                    sb.AppendLine("       TP.TENDER_PROJECT_NAME,");
                    sb.AppendLine("       S.BID_SECTION_CODE,");
                    sb.AppendLine("       S.BID_SECTION_NAME,");
                    sb.AppendLine("       TQ.QUALIFICATION_NAME,");
                    sb.AppendLine("       TQ.QUALIFICATION_LEVEL,");
                    sb.AppendLine("       TQ.QUALIFICATION_CERTIFICATE_NAME,");
                    sb.AppendLine("       TQ.QUALIFICATION_DETAIL,");
                    sb.AppendLine("       TQ.QUALIFICATION_OTHER,");
                    sb.AppendLine("       TO_CHAR(TQ.M_TM,'yyyy-mm-dd hh:mi:ss') AS M_TM");
                    sb.AppendLine("  FROM TENDER_QUALIFICATION TQ");
                    sb.AppendLine(" INNER JOIN TENDER_PROJECT TP");
                    sb.AppendLine("    ON TQ.TENDER_PROJECT_CODE = TP.TENDER_PROJECT_CODE");
                    sb.AppendLine(" INNER JOIN SECTION S");
                    sb.AppendLine("    ON (CASE");
                    sb.AppendLine("         WHEN LENGTH(TQ.BID_SECTION_CODE) <> 23 THEN");
                    sb.AppendLine("          TQ.Tender_Project_Code || '001'");
                    sb.AppendLine("         ELSE");
                    sb.AppendLine("          TQ.BID_SECTION_CODE");
                    sb.AppendLine("       END) = S.Bid_Section_Code");
                    sb.AppendLine(" WHERE QUALIFICATION_TYPE = 1");
                    sb.AppendLine("   AND QUALIFICATION_LEVEL LIKE '%特%'");
                    sb.AppendLine("   AND (QUALIFICATION_NAME LIKE '%施工%' OR");
                    sb.AppendLine("       QUALIFICATION_CERTIFICATE_NAME like '%市政%')");


                    if (point_detail.CHECK_TIME.HasValue)
                    {
                        sb.AppendLine(" AND TQ.M_TM>=TO_DATE('" + point_detail.CHECK_TIME.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','yyyy-MM-dd HH24:mi:ss')");
                    }
                    point_detail.Attach();
                    point_detail.CHECK_TIME = GetDBTime();
                    Update<BD_VIOLATION_POINT_DETAIL>(point_detail);

                    var projects = FromSql(sb.ToString()).ToList<RESULT>();

                    projects.ForEach(e =>
                    {
                        Logger.Info("开始 "+ actionName + " 分析 - " + point_code + " 招标项目编号：" + e.TENDER_PROJECT_CODE + ",招标项目名称：" + e.TENDER_PROJECT_NAME);
                        try
                        {

                            BD_VIOLATION_RECORD record = FirstOrNull<BD_VIOLATION_RECORD>(
                                BD_VIOLATION_RECORD._.TENDER_PROJECT_CODE == e.TENDER_PROJECT_CODE
                                && BD_VIOLATION_RECORD._.POINT_CODE == point_code
                                && BD_VIOLATION_RECORD._.IS_DELETE == 0);
                            bool isInsert = false;

                            if (null == record)
                            {
                                record = new BD_VIOLATION_RECORD();
                                record.ID = Guid.NewGuid().ToString().ToLower();
                                isInsert = true;
                            }
                            else
                            {
                                record.Attach();
                            }
                            record.POINT_CODE = point_code;
                            record.POINT_NAME = point_detail.NAME;
                            record.POINT_ID = point_detail.ID;
                            record.TENDER_PROJECT_CODE = e.TENDER_PROJECT_CODE;
                            record.TENDER_PROJECT_NAME = e.TENDER_PROJECT_NAME;
                            record.TENDER_PROJECT_TYPE = e.TENDER_PROJECT_TYPE;
                            record.AREA_CODE = e.REGION_CODE;
                            //record.INDUSTRIES = e.KIND;
                            record.SCORE = point_detail.SCORE;
                            record.RESULT_MSG = point_detail.RESULT_MSG;
                            record.CHECK_TIME = GetDBTime();
                            
                            record.RESULT_DATA = JsonConvert.SerializeObject(e);

                            if (isInsert)
                            {
                                Insert<BD_VIOLATION_RECORD>(record);
                                return;
                            }

                            Update<BD_VIOLATION_RECORD>(record);

                            Logger.Info(actionName +  "分析 - " + point_code + " 完成 招标项目编号：" + e.TENDER_PROJECT_CODE + ",招标项目名称：" + e.TENDER_PROJECT_NAME);
                        }
                        catch (Exception exx)
                        {
                            Logger.Info(actionName + "分析 - " + point_code + " 异常 招标项目编号：" + e.TENDER_PROJECT_CODE + ",招标项目名称："
                                + e.TENDER_PROJECT_NAME + "，异常信息：" + exx.Message, exx);
                        }
                    });
                    GGZY.Core.Log.Logger.Info(actionName + "分析 - " + point_code + " 任务执行完毕--------------");
                }
                catch (Exception ex)
                {
                    Logger.Error(actionName + "分析 - " + point_code + " 分析发生异常:" + ex.Message, ex);
                }

            });
        }

        public class RESULT
        {
            public string TENDER_PROJECT_TYPE { get; set; }
            public string REGION_CODE { get; set; }
            public string TENDER_PROJECT_CODE { get; set; }
            public string TENDER_PROJECT_NAME { get; set; }
            public string BID_SECTION_CODE { get; set; }
            public string BID_SECTION_NAME { get; set; }
            public string QUALIFICATION_NAME { get; set; }
            public string QUALIFICATION_LEVEL { get; set; }
            public string QUALIFICATION_CERTIFICATE_NAME { get; set; }
            public string QUALIFICATION_DETAIL { get; set; }
            public string QUALIFICATION_OTHER { get; set; }
            public string M_TM { get; set; }

        }
    }
}
