using GGZY.Core.Log;
using GGZYFW.DbEntity;
using Newtonsoft.Json;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Scheduler.GB01Service
{
    /// <summary>
    /// 规避GB6-金额异常
    /// </summary>
    public class Main : GGZY.Services.Base.BaseServiceT<BD_VIOLATION_POINT_DETAIL>, IJob
    {
        protected string point_code = "WG0201";
        public Task Execute(IJobExecutionContext context)
        {
            return Task.Factory.StartNew(() =>
            {
                try
                {

                    var point_detail = FirstOrNull<BD_VIOLATION_POINT_DETAIL>(BD_VIOLATION_POINT_DETAIL._.CODE == point_code
                        && BD_VIOLATION_POINT_DETAIL._.IS_ENABLE == 1);
                    if (null == point_detail)
                    {
                        Logger.Error("未找到编号为" + point_code + "的疑似违规行为配置项或配置未启用");
                        return;
                    }

                    GGZY.Core.Log.Logger.Info("规避招标分析 " + point_code + " 任务开始执行--------------");


                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("SELECT T.*");
                    sb.AppendLine("  FROM (SELECT TPC.PROJECT_CODE,");
                    sb.AppendLine("               TPC.TENDER_PROJECT_CODE,");
                    sb.AppendLine("               TPC.TENDER_PROJECT_NAME,");
                    sb.AppendLine("               TPC.TENDER_PROJECT_TYPE,");
                    sb.AppendLine("               TPC.REGION_CODE,");
                    sb.AppendLine("               JDAFC.KIND,");
                    sb.AppendLine("               JDAFC.TOTAL_INVEST,");
                    sb.AppendLine("               S.CONTRACT_RECKON_PRICE,");
                    sb.AppendLine("               S.COUNT,");
                    sb.AppendLine("               TPC.M_TM,");
                    sb.AppendLine("               ROW_NUMBER() OVER(PARTITION BY(TPC.PROJECT_CODE) ORDER BY TPC.M_TM DESC) RN");
                    sb.AppendLine("          FROM TENDER_PROJECT TPC");
                    sb.AppendLine("         INNER JOIN TENDER_PROJECT@GGZYJD JDTPC");
                    sb.AppendLine("            ON TPC.TENDER_PROJECT_CODE = JDTPC.TENDER_PROJECT_CODE_OLD1");
                    sb.AppendLine("         INNER JOIN PROJECT@GGZYJD JDPROJ");
                    sb.AppendLine("            ON JDPROJ.PROJECT_CODE = JDTPC.PROJECT_CODE");
                    sb.AppendLine("         INNER JOIN T_AFC_PROJECT@GGZYJD JDAFC");
                    sb.AppendLine("            ON JDAFC.CODE = JDPROJ.CONSTRUCTION_ID");
                    sb.AppendLine("         INNER JOIN (SELECT COUNT(1) AS COUNT,");
                    sb.AppendLine("                           TENDER_PROJECT_CODE,");
                    sb.AppendLine("                           MIN(CASE");
                    sb.AppendLine("                                 WHEN PRICE_UNIT = '1' THEN");
                    sb.AppendLine("                                  CONTRACT_RECKON_PRICE * 10000");
                    sb.AppendLine("                                 ELSE");
                    sb.AppendLine("                                  CONTRACT_RECKON_PRICE");
                    sb.AppendLine("                               END) CONTRACT_RECKON_PRICE");
                    sb.AppendLine("                      FROM SECTION");
                    sb.AppendLine("                     GROUP BY TENDER_PROJECT_CODE");
                    sb.AppendLine("                    HAVING COUNT(1) = 1 AND MIN(CASE WHEN PRICE_UNIT = '1' THEN CONTRACT_RECKON_PRICE * 10000 ELSE CONTRACT_RECKON_PRICE END) < 400 * 10000) S");
                    sb.AppendLine("            ON S.TENDER_PROJECT_CODE = TPC.TENDER_PROJECT_CODE");
                    sb.AppendLine("         WHERE JDAFC.TOTAL_INVEST < 400");
                    sb.AppendLine("           AND TPC.IS_TO_LAW = 0");
                    sb.AppendLine("           AND JDAFC.TOTAL_INVEST * 10000 - S.CONTRACT_RECKON_PRICE >=");
                    sb.AppendLine("               200 * 10000) T");
                    sb.AppendLine(" WHERE T.RN = 1");

                    if (point_detail.CHECK_TIME.HasValue)
                    {
                        sb.AppendLine(" AND T.M_TM>=TO_DATE('" + point_detail.CHECK_TIME.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','yyyy-MM-dd HH24:mi:ss')");
                    }
                    sb.AppendLine(" ORDER BY M_TM DESC");
                    point_detail.Attach();
                    point_detail.CHECK_TIME = GetDBTime();
                    Update<BD_VIOLATION_POINT_DETAIL>(point_detail);

                    var projects = FromSql(sb.ToString()).ToList<RESULT>();

                    projects.ForEach(e => {
                        Logger.Info("开始规避招标分析 - " + point_code + " 招标项目编号：" + e.TENDER_PROJECT_CODE + ",招标项目名称：" + e.TENDER_PROJECT_NAME);
                        try
                        {
                            var sections = FindList<SECTION>(SECTION._.TENDER_PROJECT_CODE == e.TENDER_PROJECT_CODE);
                            var datas = sections.Select(t => new
                            {
                                BID_SECTION_CODE = t.BID_SECTION_CODE,
                                BID_SECTION_NAME = t.BID_SECTION_NAME,
                                CONTRACT_RECKON_PRICE = t.CONTRACT_RECKON_PRICE,
                                PRICE_UNIT = t.PRICE_UNIT,
                                CURRENCY_CODE = t.CURRENCY_CODE
                            });

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
                            record.INDUSTRIES = e.KIND;
                            record.SCORE = point_detail.SCORE;
                            record.RESULT_MSG = point_detail.RESULT_MSG;
                            record.CHECK_TIME = GetDBTime();
                            var result = new
                            {
                                TOTAL_INVEST = String.Concat(e.TOTAL_INVEST," 万元"),
                                SECTION_COUNT = e.COUNT,
                                SECTION = datas
                            };
                            record.RESULT_DATA = JsonConvert.SerializeObject(result);

                            if (isInsert)
                            {
                                Insert<BD_VIOLATION_RECORD>(record);
                                return;
                            }

                            Update<BD_VIOLATION_RECORD>(record);

                            Logger.Info("规避招标分析 - " + point_code + " 完成 招标项目编号：" + e.TENDER_PROJECT_CODE + ",招标项目名称：" + e.TENDER_PROJECT_NAME);
                        }
                        catch (Exception exx)
                        {
                            Logger.Info("规避招标分析 - " + point_code + " 异常 招标项目编号：" + e.TENDER_PROJECT_CODE + ",招标项目名称："
                                + e.TENDER_PROJECT_NAME + "，异常信息：" + exx.Message, exx);
                        }
                    });
                    GGZY.Core.Log.Logger.Info("规避招标分析 - " + point_code + " 任务执行完毕--------------");
                }
                catch (Exception ex)
                {
                    Logger.Error("规避招标分析 - " + point_code + " 分析发生异常:" + ex.Message, ex);
                }
            });
        }
        public class RESULT
        {
            public string PROJECT_CODE { get; set; }
            public string TENDER_PROJECT_CODE { get; set; }
            public string TENDER_PROJECT_NAME { get; set; }
            public string TENDER_PROJECT_TYPE { get; set; }
            public string REGION_CODE { get; set; }
            /// <summary>
            /// 报建类别
            /// </summary>
            public decimal? KIND { get; set; }
            /// <summary>
            /// 项目投资规模
            /// </summary>
            public string TOTAL_INVEST { get; set; }
            public int COUNT { get; set; }
            public DateTime M_TM { get; set; }
            public int RN { get; set; }
        }
    }
}
