using GGZY.Core.Converters;
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

namespace GGZY.Scheduler.Clue01Service
{
    public class Main : GGZY.Services.Base.BaseServiceT<BD_VIOLATION_POINT>, IJob
    {
        protected string point_code = "WG080101";
        public Task Execute(IJobExecutionContext context)
        {
            return Task.Factory.StartNew(() =>
            {
                GGZY.Core.Log.Logger.Info(point_code +" 定时任务开始执行--------------");

                var point_detail = FirstOrNull<BD_VIOLATION_POINT_DETAIL>(BD_VIOLATION_POINT_DETAIL._.CODE == point_code
                       && BD_VIOLATION_POINT_DETAIL._.IS_ENABLE == 1);
                if (null == point_detail)
                {
                    Logger.Error("未找到编号为"+ point_code + "的疑似违规行为配置项");
                    return;
                }


                string sqlBidder = "select distinct WIN_BIDDER_NAME from V_TENDERER_BIDDER ORDER BY WIN_BIDDER_NAME";

                int totalCount = FromSql(sqlBidder).Count();
                int pageSize = 50;
                int maxPage = Convert.ToInt32(Math.Ceiling(totalCount * 1.0 / pageSize));

                if(totalCount > 0)
                {
                    point_detail.Attach();
                    point_detail.CHECK_TIME = GetDBTime();
                    Update<BD_VIOLATION_POINT_DETAIL>(point_detail);
                }

                GGZY.Core.Log.Logger.Info("开始查询多次在同一招标人中标的投标人名单--------------");
                for (int i = 1; i <= maxPage; i++)
                {
                    try
                    {
                        GGZY.Core.Log.Logger.Info("开始查询多次在同一招标人中标的投标人名单 第" + (pageSize * (i - 1) + 1) + " 至" +
                           pageSize * i + " 条记录 --------------");
                        var biddersTable = FromSql(sqlBidder).Page(pageSize, i).ToPageTable(out totalCount, "WIN_BIDDER_NAME");
                        GGZY.Core.Log.Logger.Info("完成查询多次在同一招标人中标的投标人名单 第" + (pageSize * (i - 1) + 1) + " 至" +
                           pageSize * i + " 条记录 --------------");
                        biddersTable.AsEnumerable().Select(t=>t["WIN_BIDDER_NAME"].ToString()).ToList<string>().ForEach(e => {

                            try
                            {
                                GGZY.Core.Log.Logger.Info("开始分析 " + e + " 多次中标情况--------------");
                                var results = FromSql("SELECT * FROM V_TENDERER_BIDDER_DETAIL WHERE WIN_BIDDER_NAME='" + e + "'").ToList<RESULT>();
                                if (results.Any())
                                {
                                    var entity_id = FromSql("SELECT ID FROM BD_VIOLATION_ENTITY WHERE ENTITY_TYPE=3 " +
                                        " AND ENTITY_NAME='" + e + "' AND POINT_CODE='" + point_detail.CODE + "'").ToScalar<string>();

                                    var result_data = JsonConvert.SerializeObject(results.Select(t => new
                                    {
                                        t.TENDERER_NAME,
                                        t.TENDERER_CODE,
                                        t.TENDER_PROJECT_NAME,
                                        t.TENDER_PROJECT_CODE,
                                        t.BID_SECTION_NAME,
                                        t.BID_SECTION_CODE
                                    }));
                                    if (!String.IsNullOrEmpty(entity_id))
                                    {
                                        FromSql("UPDATE BD_VIOLATION_ENTITY SET RESULT_DATA=:RESULT_DATA,POINT_ID=:POINT_ID,CHECK_TIME=SYSDATE WHERE ID=:ID")
                                        .AddInParameter(":RESULT_DATA", System.Data.DbType.String, result_data)
                                        .AddInParameter(":ID", System.Data.DbType.String, entity_id)
                                        .AddInParameter(":POINT_ID", System.Data.DbType.Int16, point_detail.ID)
                                        .ExecuteNonQuery();

                                        GGZY.Core.Log.Logger.Info(e + " 分析结果数据更新完成--------------");
                                        return;
                                    }

                                    BD_VIOLATION_ENTITY entity = new BD_VIOLATION_ENTITY();
                                    entity.ENTITY_NAME = e;
                                    entity.ENTITY_CODE = results.FirstOrDefault()?.WIN_BIDDER_CODE;
                                    entity.ENTITY_TYPE = 3;
                                    entity.POINT_NAME = point_detail.NAME;
                                    entity.POINT_CODE = point_detail.CODE;
                                    entity.ID = Guid.NewGuid().ToString();
                                    entity.POINT_ID = point_detail.ID;
                                    entity.SCORE = point_detail.SCORE;
                                    entity.RESULT_MSG = point_detail.RESULT_MSG;
                                    entity.RESULT_DATA = result_data;
                                    Insert<BD_VIOLATION_ENTITY>(entity);
                                    GGZY.Core.Log.Logger.Info(e + " 分析结果数据新增完成--------------");
                                }
                            }
                            catch(Exception exd)
                            {
                                Logger.Error("处理多次在同一招标人中标的投标人名单发生异常:" + exd.Message, exd);
                            }
                        });
                    }
                    catch(Exception ex)
                    {
                        Logger.Error("分析多次在同一招标人中标的投标人名单发生异常:" + ex.Message, ex);
                    }
                }
                GGZY.Core.Log.Logger.Info("完成查询多次在同一招标人中标的投标人名单--------------");
                GGZY.Core.Log.Logger.Info(point_code + " 定时任务执行结束--------------");
            });
        }
    }

    public class RESULT
    {
        public string TENDER_PROJECT_CODE { get; set; }
        public string TENDER_PROJECT_NAME { get; set; }

        public string BID_SECTION_CODE { get; set; }
        public string BID_SECTION_NAME { get; set; }

        public string TENDERER_NAME { get; set; }
        public string TENDERER_CODE { get; set; }
        public string WIN_BIDDER_NAME { get; set; }
        public string WIN_BIDDER_CODE { get; set; }
    }
}
