using GGZY.Core.Log;
using GGZYFW.DbEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Scheduler.HardwareService
{
    public class MainServie2: GGZY.Services.Base.BaseServiceT<Dos.ORM.Entity>
    {
        protected string point_code = "WG0702";
        protected const string actionName = "围标串标-围串标WC10-不同人使用同一PC";

        public void Run()
        {
            GGZY.Core.Log.Logger.Info(point_code + " 定时任务开始执行--------------");

            var point_detail = FirstOrNull<BD_VIOLATION_POINT_DETAIL>(BD_VIOLATION_POINT_DETAIL._.CODE == point_code
                        && BD_VIOLATION_POINT_DETAIL._.IS_ENABLE == 1);
            if (null == point_detail)
            {
                Logger.Error("未找到编号 " + point_code + " 为的疑似违规行为配置项");
                return;
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select cpu_id, hard_disk_serial_number, mac_address");
            sb.AppendLine("  from (SELECT r.cpu_id,");
            sb.AppendLine("               r.hard_disk_serial_number,");
            sb.AppendLine("               r.mac_address,");
            sb.AppendLine("               r.bidder_name,");
            sb.AppendLine("               r.bidder_org_code,");
            sb.AppendLine("               row_number() over(partition by r.cpu_id, r.hard_disk_serial_number, r.mac_address order by r.bidder_org_code) rn");
            sb.AppendLine("          FROM (SELECT DISTINCT cpu_id,");
            sb.AppendLine("                                hard_disk_serial_number,");
            sb.AppendLine("                                mac_address,");
            sb.AppendLine("                                bidder_name,");
            sb.AppendLine("                                bidder_org_code");
            sb.AppendLine("                  FROM BD_HAREDWARE_RESULT");
            if (point_detail.CHECK_TIME.HasValue)
            {
                sb.AppendLine(" AND M_TM>=TO_DATE('" + point_detail.CHECK_TIME.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','yyyy-MM-dd HH24:mi:ss')");
            }
            sb.AppendLine(") R)");
            sb.AppendLine(" where rn = 2");

            point_detail.Attach();
            point_detail.CHECK_TIME = GetDBTime();
            Update<BD_VIOLATION_POINT_DETAIL>(point_detail);

            var results = FromSql(sb.ToString()).ToList<RESULT>();

            StringBuilder sqlFormat = new StringBuilder();
            sqlFormat.AppendLine(" SELECT HR.TENDER_PROJECT_CODE,");
            sqlFormat.AppendLine("        TP.TENDER_PROJECT_NAME,");
            sqlFormat.AppendLine("        TP.TENDER_PROJECT_TYPE,");
            sqlFormat.AppendLine("        TP.REGION_CODE,");
            sqlFormat.AppendLine("        HR.BID_SECTION_CODE,");
            sqlFormat.AppendLine("        S.BID_SECTION_NAME,");
            sqlFormat.AppendLine("        HR.BIDDER_NAME,");
            sqlFormat.AppendLine("        HR.BIDDER_ORG_CODE");
            sqlFormat.AppendLine("   FROM BD_HAREDWARE_RESULT HR");
            sqlFormat.AppendLine("  INNER JOIN TENDER_PROJECT TP");
            sqlFormat.AppendLine("     ON HR.TENDER_PROJECT_CODE = TP.TENDER_PROJECT_CODE");
            sqlFormat.AppendLine("  INNER JOIN SECTION S");
            sqlFormat.AppendLine("     ON S.BID_SECTION_CODE = HR.BID_SECTION_CODE");
            sqlFormat.AppendLine("  WHERE HR.cpu_id='{0}' AND hard_disk_serial_number='{1}' AND mac_address='{2}'");

            results.ForEach(e =>
            {
                Logger.Info("开始 " + actionName + " 分析 - " + point_code + " CPU ID：" + e.cpu_id + ",硬盘序列号：" + e.hard_disk_serial_number + ",Mac地址:"+e.mac_address);
                try
                {

                    var details = FromSql(String.Format(sqlFormat.ToString(), e.cpu_id, e.hard_disk_serial_number, e.mac_address))
                    .ToList<RESULT_DETAIL>();

                    

                    details.GroupBy(g => new { g.BIDDER_ORG_CODE, g.BIDDER_NAME })
                    .Select(t => new {
                        BIDDER_ORG_CODE = t.Key.BIDDER_ORG_CODE,
                        BIDDER_NAME = t.Key.BIDDER_NAME

                        //details.Where(w1=>w1.).GroupBy(g1 =>g1.)
                    }).ToList();
                    
                }
#pragma warning disable CS0168 // 声明了变量“exx”，但从未使用过
                catch (Exception exx)
#pragma warning restore CS0168 // 声明了变量“exx”，但从未使用过
                {
                   
                }
            });
            GGZY.Core.Log.Logger.Info(actionName + "分析 - " + point_code + " 任务执行完毕--------------");
        }

        public class RESULT
        {
            public string cpu_id { get; set; }
            public string hard_disk_serial_number { get; set; }
            public string mac_address { get; set; }
        }

        public class RESULT_DETAIL
        {
            public string TENDER_PROJECT_CODE { get; set; }
            public string TENDER_PROJECT_NAME { get; set; }
            public string TENDER_PROJECT_TYPE { get; set; }
            public string BID_SECTION_CODE { get; set; }
            public string BID_SECTION_NAME { get; set; }

            public string REGION_CODE { get; set; }

            public string BIDDER_NAME { get; set; }

            public string BIDDER_ORG_CODE { get; set; }
        }

    }
}
