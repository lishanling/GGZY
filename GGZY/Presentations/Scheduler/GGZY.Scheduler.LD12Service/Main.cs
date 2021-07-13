using GGZY.Core.Log;
using GGZYFW.DbEntity;
using Newtonsoft.Json;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Scheduler.LD12Service
{
    /// <summary>
    /// 量定LD12-分值设置大于规定
    /// </summary>
    public class Main : GGZY.Services.Base.BaseServiceT<BD_VIOLATION_POINT>, IJob
    {
        protected string point_code = "WG0412";
        protected const string actionName = "量身定做-分值设置大于规定";
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
                    sb.AppendLine("SELECT tp.tender_project_name,tp.TENDER_PROJECT_TYPE,");
                    sb.AppendLine("       TP.REGION_CODE,");
                    sb.AppendLine("       S.BID_SECTION_NAME,");
                    sb.AppendLine("       RST.*");
                    sb.AppendLine("  FROM (SELECT RT.Tender_Project_Code,");
                    sb.AppendLine("               RT.BID_SECTION_CODE,");
                    sb.AppendLine("               TO_CHAR(MAX(RT.BID_OPEN_TIME), 'yyyy-mm-dd HH:MI:SS') as BID_OPEN_TIME,");
                    sb.AppendLine("               MAX(RT.TECHNICAL_POINTS) AS MAX_TECHNICAL_POINTS");
                    sb.AppendLine("          FROM (SELECT R.Tender_Project_Code,");
                    sb.AppendLine("                       R.BID_SECTION_CODE,");
                    sb.AppendLine("                       R.TECHNICAL_POINTS,");
                    sb.AppendLine("                       TP.BID_OPEN_TIME");
                    sb.AppendLine("                  from EVALUATION_RESULT R");
                    sb.AppendLine("                 INNER JOIN (SELECT *");
                    sb.AppendLine("                              FROM (SELECT TFM.Tender_Project_Code,");
                    sb.AppendLine("                                           tfm.bid_section_code,");
                    sb.AppendLine("                                           NVL(TFM.CLARIFY_TIME, sysdate),");
                    sb.AppendLine("                                           TFM.BID_OPEN_TIME,");
                    sb.AppendLine("                                           row_number() over(partition by TFM.tender_project_code, TFM.BID_SECTION_CODE order by NVL(TFM.CLARIFY_TIME, sysdate)) rn");
                    sb.AppendLine("                                      FROM TENDER_FILE_CLARI_MODI TFM");
                    sb.AppendLine("                                     WHERE TFM.EVALUATING_METHOD LIKE '%综合%') T");
                    sb.AppendLine("                             WHERE T.RN = 1) TP");
                    sb.AppendLine("                    on tp.tender_project_code = r.tender_project_code");
                    sb.AppendLine("                 WHERE R.TECHNICAL_POINTS > 75");
                    if (point_detail.CHECK_TIME.HasValue)
                    {
                        sb.AppendLine(" AND R.M_TM>=TO_DATE('" + point_detail.CHECK_TIME.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','yyyy-MM-dd HH24:mi:ss')");
                    }
                    sb.AppendLine(") RT");
                    sb.AppendLine("         GROUP BY RT.Tender_Project_Code, RT.BID_SECTION_CODE) RST");
                    sb.AppendLine(" INNER JOIN tender_project tp");
                    sb.AppendLine("    on tp.Tender_Project_Code = RST.Tender_Project_Code");
                    sb.AppendLine(" INNER JOIN SECTION S ");
                    sb.AppendLine("    ON  S.BID_SECTION_CODE= RST.BID_SECTION_CODE");

                    point_detail.Attach();
                    point_detail.CHECK_TIME = GetDBTime();
                    Update<BD_VIOLATION_POINT_DETAIL>(point_detail);

                    var projects = FromSql(sb.ToString()).ToList<RESULT>();

                    projects.ForEach(e =>
                    {
                        Logger.Info("开始 " + actionName + " 分析 - " + point_code + " 招标项目编号：" + e.TENDER_PROJECT_CODE + ",招标项目名称：" + e.TENDER_PROJECT_NAME);
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

                            Logger.Info(actionName + "分析 - " + point_code + " 完成 招标项目编号：" + e.TENDER_PROJECT_CODE + ",招标项目名称：" + e.TENDER_PROJECT_NAME);
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
            /// <summary>
            /// 最高技术分得分
            /// </summary>
            public string MAX_TECHNICAL_POINTS { get; set; }
            /// <summary>
            /// 标段包名称
            /// </summary>
            public string BID_SECTION_NAME { get; set; }
            public string BID_OPEN_TIME { get; set; }

        }
    }
}
