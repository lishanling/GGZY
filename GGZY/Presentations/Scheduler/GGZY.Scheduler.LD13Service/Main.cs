using GGZY.Core.Log;
using GGZYFW.DbEntity;
using Newtonsoft.Json;
#pragma warning disable CS0246 // 未能找到类型或命名空间名“Quartz”(是否缺少 using 指令或程序集引用?)
using Quartz;
#pragma warning restore CS0246 // 未能找到类型或命名空间名“Quartz”(是否缺少 using 指令或程序集引用?)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Scheduler.LD13Service
{
    /// <summary>
    /// 量定LD13-中标人得分明显偏高
    /// </summary>
#pragma warning disable CS0246 // 未能找到类型或命名空间名“IJob”(是否缺少 using 指令或程序集引用?)
    public class Main : GGZY.Services.Base.BaseServiceT<BD_VIOLATION_POINT>, IJob
#pragma warning restore CS0246 // 未能找到类型或命名空间名“IJob”(是否缺少 using 指令或程序集引用?)
    {
        protected string point_code = "WG0413";
        protected const string actionName = "量身定做-中标人得分明显偏高";
#pragma warning disable CS0246 // 未能找到类型或命名空间名“IJobExecutionContext”(是否缺少 using 指令或程序集引用?)
        public Task Execute(IJobExecutionContext context)
#pragma warning restore CS0246 // 未能找到类型或命名空间名“IJobExecutionContext”(是否缺少 using 指令或程序集引用?)
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
                    sb.AppendLine("SELECT RE.*,");
                    sb.AppendLine("       TP.TENDER_PROJECT_NAME,");
                    sb.AppendLine("       TP.TENDER_PROJECT_TYPE,");
                    sb.AppendLine("       TP.REGION_CODE,");
                    sb.AppendLine("       ST.BID_SECTION_NAME,");
                    sb.AppendLine("       ROUND(rt.technical_points + rt.business_points + rt.other_points +rt.PRICE_POINTS,2) as WINNER_TOTAL_SCORE");
                    sb.AppendLine("  FROM (SELECT R.TENDER_PROJECT_CODE,");
                    sb.AppendLine("               R.BID_SECTION_CODE,");
                    sb.AppendLine("               round(AVG(r.technical_points + r.business_points +r.other_points + r.PRICE_POINTS),2) as AVG_POINT");
                    sb.AppendLine("          from EVALUATION_RESULT R");
                    sb.AppendLine("         WHERE EXISTS (SELECT *");
                    sb.AppendLine("                  FROM TENDER_CANDIDATE CD");
                    sb.AppendLine("                 WHERE CD.TENDER_PROJECT_CODE = R.TENDER_PROJECT_CODE");
                    sb.AppendLine("                   AND CD.BID_SECTION_CODE = R.BID_SECTION_CODE");
                    sb.AppendLine("                   AND CD.WIN_CANDIDATE_ORDER = 1");
                    sb.AppendLine("                   AND CD.WIN_CANDIDATE_CODE != R.BIDDER_ROLE");
                    if (point_detail.CHECK_TIME.HasValue)
                    {
                        sb.AppendLine(" AND CD.M_TM>=TO_DATE('" + point_detail.CHECK_TIME.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','yyyy-MM-dd HH24:mi:ss')");
                    }
                    sb.AppendLine(")");
                    sb.AppendLine("         GROUP BY R.TENDER_PROJECT_CODE, R.BID_SECTION_CODE) RE");
                    sb.AppendLine(" INNER JOIN EVALUATION_RESULT RT");
                    sb.AppendLine("    ON RT.TENDER_PROJECT_CODE = RE.TENDER_PROJECT_CODE");
                    sb.AppendLine("   AND RT.BID_SECTION_CODE = RE.BID_SECTION_CODE");
                    sb.AppendLine("   AND RT.RANK = 1");
                    sb.AppendLine(" INNER JOIN TENDER_PROJECT TP");
                    sb.AppendLine("    ON TP.TENDER_PROJECT_CODE = RT.TENDER_PROJECT_CODE");
                    sb.AppendLine(" INNER JOIN SECTION ST");
                    sb.AppendLine("    ON ST.BID_SECTION_CODE = RT.BID_SECTION_CODE");
                    sb.AppendLine(" where RE.avg_point > 5");
                    sb.AppendLine("   and (rt.technical_points + rt.business_points + rt.other_points +");
                    sb.AppendLine("       rt.PRICE_POINTS) / RE.avg_point >= 1.5");

                    
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
            public string WINNER_TOTAL_SCORE { get; set; }
            /// <summary>
            /// 标段包名称
            /// </summary>
            public string BID_SECTION_NAME { get; set; }
            public string AVG_POINT { get; set; }

        }
    }
}
