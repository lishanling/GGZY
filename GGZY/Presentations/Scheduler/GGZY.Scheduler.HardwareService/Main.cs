using Dos.ORM;
using GGZY.Core.Log;
using GGZY.Services.Extensions;
using GGZYFW.DbEntity;
using Newtonsoft.Json;
using Quartz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Scheduler.HardwareService
{
    public  class Main : GGZY.Services.Base.BaseServiceT<Dos.ORM.Entity>, IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            var point_code = "WG0701";
            return Task.Factory.StartNew(() =>
            {
                try
                {
                    var point_detail = FirstOrNull<BD_VIOLATION_POINT_DETAIL>(BD_VIOLATION_POINT_DETAIL._.CODE == point_code
                        && BD_VIOLATION_POINT_DETAIL._.IS_ENABLE == 1);
                    if (null == point_detail)
                    {
                        Logger.Error("未找到编号 "+ point_code + " 为的疑似违规行为配置项");
                        return;
                    }

                    GGZY.Core.Log.Logger.Info("围串标行为分析开始执行--------------");

                    GGZY.Core.Log.Logger.Info("围串标行为分析开始初始化视图和序列--------------");

                    string sql1 = "truncate table BD_HARDWARE_MULTI";
                    FromSql(sql1).ExecuteNonQuery();

                    FromSql("DROP SEQUENCE SEQ_BD_HARDWARE_MULTI");

                    StringBuilder sbInitSequence = new StringBuilder();
                    sbInitSequence.AppendLine("create sequence SEQ_BD_HARDWARE_MULTI");
                    sbInitSequence.AppendLine("minvalue 1");
                    sbInitSequence.AppendLine("maxvalue 9999999999");
                    sbInitSequence.AppendLine("start with 1");
                    sbInitSequence.AppendLine("increment by 1");
                    sbInitSequence.AppendLine("cache 10;");

                    FromSql(sbInitSequence.ToString());

                    GGZY.Core.Log.Logger.Info("围串标行为分析 初始化视图和序列完毕--------------");

                    GGZY.Core.Log.Logger.Info("围串标行为分析 开始分析重复硬件信息--------------");

                    StringBuilder sbInitData = new StringBuilder();
                    sbInitData.AppendLine("INSERT INTO BD_HARDWARE_MULTI");
                    sbInitData.AppendLine("SELECT");
                    sbInitData.AppendLine("         SEQ_BD_HARDWARE_MULTI.NEXTVAL AS ID,TENDER_PROJECT_CODE,");
                    sbInitData.AppendLine("         t1.CPU_ID,");
                    sbInitData.AppendLine("         t1.MAC_ADDRESS,");
                    sbInitData.AppendLine("         t1.HARD_DISK_SERIAL_NUMBER");
                    sbInitData.AppendLine("FROM");
                    sbInitData.AppendLine("         ( select TENDER_PROJECT_CODE,");
                    sbInitData.AppendLine("                  CPU_ID,");
                    sbInitData.AppendLine("                  MAC_ADDRESS,");
                    sbInitData.AppendLine("                  HARD_DISK_SERIAL_NUMBER,");
                    sbInitData.AppendLine("                  ROW_NUMBER() OVER(PARTITION BY TENDER_PROJECT_CODE,CPU_ID,MAC_ADDRESS,HARD_DISK_SERIAL_NUMBER ORDER BY BIDDER_NAME) RN");
                    sbInitData.AppendLine("         from");
                    sbInitData.AppendLine("                  V_BD_HARDWARE t");
                    sbInitData.AppendLine("         )t1");
                    sbInitData.AppendLine("WHERE");
                    sbInitData.AppendLine("         t1.RN=2");


                    FromSql(sbInitData.ToString()).ExecuteNonQuery();

                    GGZY.Core.Log.Logger.Info("围串标行为分析 分析重复硬件信息完成--------------");

                    GGZY.Core.Log.Logger.Info("围串标行为分析 开始生成涉嫌围串标投标人结果--------------");

                    FromSql("TRUNCATE TABLE BD_HAREDWARE_RESULT").ExecuteNonQuery();

                    StringBuilder sbInitResult = new StringBuilder();
                    sbInitResult.AppendLine("INSERT INTO BD_HAREDWARE_RESULT ");
                    sbInitResult.AppendLine("SELECT BDC.TENDER_PROJECT_CODE,");
                    sbInitResult.AppendLine("       BDC.BID_SECTION_CODE,");
                    sbInitResult.AppendLine("       BDC.CPU_ID,");
                    sbInitResult.AppendLine("       BDC.HARD_DISK_SERIAL_NUMBER,");
                    sbInitResult.AppendLine("       BDC.MAC_ADDRESS,");
                    sbInitResult.AppendLine("       BDC.BIDDER_NAME,");
                    sbInitResult.AppendLine("       BDC.BIDDER_ORG_CODE,");
                    sbInitResult.AppendLine("       BDC.M_TM");
                    sbInitResult.AppendLine("  FROM BID_DOC_CHARACT_CODE BDC");
                    sbInitResult.AppendLine(" INNER JOIN BD_HARDWARE_MULTI R");
                    sbInitResult.AppendLine("    ON BDC.CPU_ID = R.CPU_ID");
                    sbInitResult.AppendLine("   AND BDC.MAC_ADDRESS = R.MAC_ADDRESS");
                    sbInitResult.AppendLine("   AND BDC.HARD_DISK_SERIAL_NUMBER = R.HARD_DISK_SERIAL_NUMBER");
                    sbInitResult.AppendLine("   AND BDC.TENDER_PROJECT_CODE = R.TENDER_PROJECT_CODE");

                    FromSql(sbInitResult.ToString()).ExecuteNonQuery();

                    GGZY.Core.Log.Logger.Info("围串标行为分析 完成生成涉嫌围串标投标人结果--------------");
                    //sbResult.AppendLine("INSERT INTO BD_VIOLATION_ENTITY(");
                    //sbResult.Append("ID,POINT_ID,POINT_CODE,POINT_NAME,ENTITY_NAME,ENTITY_CODE,AREA_CODE,CHECK_TIME");
                    //sbResult.Append(",RESULT_MSG,SCORE,STATE,TRANSFER_STATE,CREATE_TIME,ENTITY_TYPE");
                    //sbResult.Append(") ");
                    //sbResult.AppendLine("SELECT SYS_GUID()," + point_detail.ID + ",'" + point_detail.CODE + "','" + point_detail.NAME.Replace("'", "''") + "'");
                    //sbResult.AppendLine(",BIDDER_NAME,BIDDER_ORG_CODE,'',SYSDATE,'" + point_detail.RESULT_MSG + "'," + point_detail.SCORE + ",0,0,SYSDATE,3 ");
                    //sbResult.AppendLine("FROM(");
                    //sbResult.AppendLine("SELECT  BIDDER_NAME, BIDDER_ORG_CODE,ROW_NUMBER() OVER(PARTITION BY BIDDER_NAME ORDER BY LENGTH(BIDDER_ORG_CODE) DESC) RN FROM V_BD_HAREDWARE_RESULT");
                    //sbResult.AppendLine(" ) T WHERE T.RN = 1");

                    var sqlBidder = "SELECT BIDDER_NAME, BIDDER_ORG_CODE FROM (SELECT  BIDDER_NAME, BIDDER_ORG_CODE,ROW_NUMBER() OVER(PARTITION BY BIDDER_NAME ORDER BY LENGTH(BIDDER_ORG_CODE) DESC) RN FROM BD_HAREDWARE_RESULT) T WHERE T.RN=1";

                    GGZY.Core.Log.Logger.Info("围串标行为分析 正在统计涉嫌违规行为投标人总数--------------");
                    int totalCount = FromSql("SELECT COUNT(1) FROM (SELECT  BIDDER_NAME, BIDDER_ORG_CODE,ROW_NUMBER() OVER(PARTITION BY BIDDER_NAME ORDER BY LENGTH(BIDDER_ORG_CODE) DESC) RN FROM BD_HAREDWARE_RESULT) T WHERE T.RN=1").ToScalar<int>();
                    int pageSize = 50;
                    int maxPage = Convert.ToInt32(Math.Ceiling(totalCount * 1.0 / pageSize));
                    GGZY.Core.Log.Logger.Info("围串标行为分析 完成统计涉嫌违规行为投标人总数:"+totalCount+"，分页大小:"+pageSize+ ",总页数:"+maxPage+"--------------");

 

                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("SELECT rt.*, tp.tender_project_name,sec.bid_section_name ");
                    sb.AppendLine("  FROM (SELECT distinct TENDER_PROJECT_CODE,");
                    sb.AppendLine("                        BID_SECTION_CODE,");
                    sb.AppendLine("                        BIDDER_ORG_CODE,");
                    sb.AppendLine("                        CPU_ID,");
                    sb.AppendLine("                        HARD_DISK_SERIAL_NUMBER,");
                    sb.AppendLine("                        MAC_ADDRESS,");
                    sb.AppendLine("                        BIDDER_NAME");
                    sb.AppendLine("          FROM BID_DOC_CHARACT_CODE CC");
                    sb.AppendLine("         WHERE EXISTS (SELECT 1");
                    sb.AppendLine("                  from (SELECT DISTINCT MT.TENDER_PROJECT_CODE,");
                    sb.AppendLine("                                        MT.CPU_ID,");
                    sb.AppendLine("                                        MT.MAC_ADDRESS,");
                    sb.AppendLine("                                        MT.HARD_DISK_SERIAL_NUMBER");
                    sb.AppendLine("                          FROM BD_HAREDWARE_RESULT MT");
                    sb.AppendLine("                        ");
                    sb.AppendLine("                         WHERE MT.BIDDER_NAME = '{0}') TC");
                    sb.AppendLine("                 WHERE CC.TENDER_PROJECT_CODE = TC.TENDER_PROJECT_CODE");
                    sb.AppendLine("                   AND CC.CPU_ID = TC.CPU_ID");
                    sb.AppendLine("                   AND CC.MAC_ADDRESS = TC.MAC_ADDRESS");
                    sb.AppendLine("                   AND CC.HARD_DISK_SERIAL_NUMBER =");
                    sb.AppendLine("                       TC.HARD_DISK_SERIAL_NUMBER");
                    sb.AppendLine("                   AND CC.CPU_ID NOT IN ('-', '暂无', '无', '/')");
                    sb.AppendLine("                   AND CC.MAC_ADDRESS NOT IN ('-', '暂无', '无', '/')");
                    sb.AppendLine("                   AND CC.HARD_DISK_SERIAL_NUMBER NOT IN");
                    sb.AppendLine("                       ('-', '暂无', '无', '/')");
                    sb.AppendLine("                   AND CC.HARD_DISK_SERIAL_NUMBER NOT IN");
                    sb.AppendLine("                       ('-', '暂无', '无', '/'))");
                    sb.AppendLine("        ");
                    sb.AppendLine("        ) RT");
                    sb.AppendLine(" INNER JOIN TENDER_PROJECT TP");
                    sb.AppendLine("    on tp.tender_project_code = rt.tender_project_code");
                    sb.AppendLine(" inner join section sec");
                    sb.AppendLine("    on sec.bid_section_code = rt.bid_section_code");


                    for (int i = 1; i <= maxPage; i++)
                    {
                        GGZY.Core.Log.Logger.Info("开始查询涉嫌违规行为投标人 第" + (pageSize * (i - 1) + 1) + " 至" +
                         pageSize * i + " 条记录 --------------");
                        var bidders = FromSql(sqlBidder).Page(pageSize, i).ToPageTable(out totalCount, "BIDDER_NAME");

                        GGZY.Core.Log.Logger.Info("完成查询涉嫌违规行为投标人 第" + (pageSize * (i - 1) + 1) + " 至" +
                           pageSize * i + " 条记录 --------------");

                        if (bidders.Rows.Count>0)
                        {
                            var updateSql = "UPDATE BD_VIOLATION_ENTITY SET RESULT_DATA=:RESULT_DATA,CHECK_TIME=SYSDATE WHERE ENTITY_NAME=:ENTITY_NAME"
                            + " AND POINT_CODE=:POINT_CODE AND POINT_ID=:POINT_ID AND ENTITY_TYPE=3";

                            var m = 1;
                            bidders.AsEnumerable().Select(t=>new BID_DOC_CHARACT_CODE
                            {
                                BIDDER_NAME = t["BIDDER_NAME"].ToString().Trim(),
                                BIDDER_ORG_CODE = t["BIDDER_ORG_CODE"].ToString().Trim()
                            }).ToList<BID_DOC_CHARACT_CODE>().ForEach(e => {
                                try
                                {
                                    GGZY.Core.Log.Logger.Info("围串标行为分析 正在完善分析报告，"+ (pageSize * (i - 1) + m) + "：" + e.BIDDER_NAME + "--------------");

                                    var dyn = FromSql(String.Format(sb.ToString(), e.BIDDER_NAME)).ToList<HAREDWARE_RESULT>();
                                    var countDyn = dyn.Count();
                                    if(dyn.Where(w=>w.BIDDER_NAME != e.BIDDER_NAME).Count() ==0)
                                    {
                                        return;
                                    }
                                    var result = dyn.GroupBy(g => new { g.TENDER_PROJECT_CODE, g.TENDER_PROJECT_NAME })
                                    .Select(t => new
                                    {
                                        TENDER_PROJECT_CODE = t.Key.TENDER_PROJECT_CODE,
                                        TENDER_PROJECT_NAME = t.Key.TENDER_PROJECT_NAME,
                                        ALL_COUNT = Fw.BidDocCharactCodeService.Count(BID_DOC_CHARACT_CODE._.TENDER_PROJECT_CODE == t.Key.TENDER_PROJECT_CODE),
                                        ABNORMAL_COUNT = t.Count(),
                                        ABNORMAL_BIDDERS = t.Select(t1 => new
                                        {
                                            t1.CPU_ID,
                                            t1.HARD_DISK_SERIAL_NUMBER,
                                            t1.MAC_ADDRESS,
                                            t1.BID_SECTION_CODE,
                                            t1.BID_SECTION_NAME,
                                            t1.BIDDER_NAME,
                                            t1.BIDDER_ORG_CODE,
                                        })
                                    }).ToList();

                                    var result_data = JsonConvert.SerializeObject(result);

                                    var entity = Fw.BdViolationEntityService.FirstOrNull(BD_VIOLATION_ENTITY._.POINT_CODE == point_code 
                                        && BD_VIOLATION_ENTITY._.ENTITY_NAME == e.BIDDER_NAME
                                        && BD_VIOLATION_ENTITY._.ENTITY_TYPE == 3);
                                    if(null == entity)
                                    {
                                        entity = new BD_VIOLATION_ENTITY();
                                        entity.ENTITY_NAME = e.BIDDER_NAME;
                                        entity.ENTITY_CODE = e.BIDDER_ORG_CODE;
                                        entity.ENTITY_TYPE = 3;
                                        entity.POINT_NAME = point_detail.NAME;
                                        entity.POINT_CODE = point_detail.CODE;
                                        entity.ID = Guid.NewGuid().ToString().ToLower();
                                        entity.SCORE = point_detail.SCORE;
                                        entity.RESULT_MSG = point_detail.RESULT_MSG;
                                        entity.RESULT_DATA = result_data;
                                        entity.POINT_ID = point_detail.ID;
                                        Insert<BD_VIOLATION_ENTITY>(entity);
                                        GGZY.Core.Log.Logger.Info(e.BIDDER_NAME + " 围串标行为分析完成，结果已保存--------------");
                                        return;
                                    }

                                    FromSql(updateSql).AddInParameter(":RESULT_DATA", System.Data.DbType.String, JsonConvert.SerializeObject(result))
                                    .AddInParameter(":ENTITY_NAME", System.Data.DbType.String, e.BIDDER_NAME)
                                    .AddInParameter(":POINT_CODE",System.Data.DbType.String,point_code)
                                    .AddInParameter(":POINT_ID",System.Data.DbType.Int16,point_detail.ID)
                                    .ExecuteNonQuery();

                                    GGZY.Core.Log.Logger.Info("围串标行为分析 分析报告更新完成，" + (pageSize * (i - 1) + m) + "：" + e.BIDDER_NAME + "--------------");
                                }
                                catch (Exception exx)
                                {
                                    GGZY.Core.Log.Logger.Info("围串标行为分析 发生异常，" + (pageSize * (i - 1) +m) + "：" + e.BIDDER_NAME + "，异常信息:" + exx.Message, exx);
                                }
                                finally
                                {
                                    m++;
                                }
                            });
                        }
                    }

                    GGZY.Core.Log.Logger.Info("围串标行为分析完成--------------");
                }
                catch (Exception ex)
                {
                    Logger.Error("围串标行为分析发生异常:" + ex.Message, ex);
                }
            });
        }

        public class HAREDWARE_RESULT
        {
            public string TENDER_PROJECT_CODE { get; set; }
            public string TENDER_PROJECT_NAME { get; set; }

            public string CPU_ID { get; set; }
            public string HARD_DISK_SERIAL_NUMBER { get; set; }
            public string MAC_ADDRESS { get; set; }

            public string BIDDER_NAME { get; set; }

            public string BIDDER_ORG_CODE { get; set; }
            public string BID_SECTION_NAME { get; set; }
            public string BID_SECTION_CODE { get; set; }
        }
    }
}