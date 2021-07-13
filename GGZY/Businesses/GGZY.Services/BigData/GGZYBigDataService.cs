using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dos.ORM;
using GGZY.Core.Helper;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.BigData
{
    public partial class BigDataMainService
    {
        #region 公共资源交易大数据-首页

        public GeneralResult ShouYeJiaoYiE(BigDataSearchModel searchModel)
        {
            var r = new GeneralResult();
            //计算交易总数、交易金额
            var where = new WhereClipBuilder();
            if (!DateTime.MinValue.Equals(searchModel.BeginTime))
            {
                where.And(V_BIG_ALLRESULT._.M_TM >= searchModel.BeginTime);
            }

            if (!DateTime.MinValue.Equals(searchModel.EndTime))
            {
                where.And(V_BIG_ALLRESULT._.M_TM < searchModel.EndTime);
            }

            /*if (!string.IsNullOrWhiteSpace(searchModel.AREACODE))
            {
                where.And(V_BIG_ALLRESULT._.AREACODE == searchModel.AREACODE);
            }*/

            var jydt = DbContext.Fw.From<V_BIG_ALLRESULT>().Where(where.ToWhereClip())
                .GroupBy(V_BIG_ALLRESULT._.TYPE)
                .Select(V_BIG_ALLRESULT._.TYPE, V_BIG_ALLRESULT._.AMOUNT.Sum().As("AMOUNT"),
                    V_BIG_ALLRESULT._.PROJECT_CODE.Count().As("COU")).ToDataTable().ToDictionary();


            //计算节约额
            searchModel.method = "Main_JieYueAmount";
            string sql = GetSql(searchModel, out string orderby, out List<OracleParameter> dbParams);
            var jyedt = FromSql(sql).AddParameter(dbParams.ToArray()).ToDataTable().ToDictionary();
            //计算增值额
            searchModel.method = "Main_AddAmount";
            sql = GetSql(searchModel, out string orderby1, out List<OracleParameter> dbParams1);
            var zzedt = FromSql(sql).AddParameter(dbParams1.ToArray()).ToDataTable().ToDictionary();

            //构建返回数据
            var JYJE = jydt.Sum(e => e["AMOUNT"].ToString().ToDecimal() / 10000).ToRound();
            var JYZS = jydt.Sum(e => e["COU"].ToString().ToInt());
            var JYE = jyedt.Sum(e => e["TOTAL_AMOUNT"].ToString().ToDecimal()).ToRound();
            var ZZE = zzedt.Sum(e => e["TOTAL_AMOUNT"].ToString().ToDecimal()).ToRound();

            var COUNT = new
            {
                JYJE,
                JYZS,
                JYE,
                ZZE
            };
            //交易数占比
            List<int> JYSZB = new List<int>
            {
                jydt.Where(e => e["TYPE"].ToString() == "工程建设").Sum(e => e["COU"].ToString().ToInt()),
                jydt.Where(e => e["TYPE"].ToString() == "产权交易").Sum(e => e["COU"].ToString().ToInt()),
                jydt.Where(e => e["TYPE"].ToString() == "土地矿产").Sum(e => e["COU"].ToString().ToInt()),
                jydt.Where(e => e["TYPE"].ToString() == "政府采购").Sum(e => e["COU"].ToString().ToInt()),
                jydt.Where(e => e["TYPE"].ToString() == "其他交易").Sum(e => e["COU"].ToString().ToInt())
            };
            //交易额占比
            List<decimal> JYEZB = new List<decimal>
            {
                jydt.Where(e => e["TYPE"].ToString() == "工程建设").Sum(e => e["AMOUNT"].ToString().ToDecimal()).ToRound(),
                jydt.Where(e => e["TYPE"].ToString() == "产权交易").Sum(e => e["AMOUNT"].ToString().ToDecimal()).ToRound(),
                jydt.Where(e => e["TYPE"].ToString() == "土地矿产").Sum(e => e["AMOUNT"].ToString().ToDecimal()).ToRound(),
                jydt.Where(e => e["TYPE"].ToString() == "政府采购").Sum(e => e["AMOUNT"].ToString().ToDecimal()).ToRound(),
                jydt.Where(e => e["TYPE"].ToString() == "其他交易").Sum(e => e["AMOUNT"].ToString().ToDecimal()).ToRound()
            };
            //节约额占比
            List<decimal> JYE1ZB = new List<decimal>
            {
                jyedt.Where(e => e["TYPE"].ToString() == "工程建设").Sum(e => e["TOTAL_AMOUNT"].ToString().ToDecimal()).ToRound(),
                jyedt.Where(e => e["TYPE"].ToString() == "产权交易").Sum(e => e["TOTAL_AMOUNT"].ToString().ToDecimal()).ToRound(),
                jyedt.Where(e => e["TYPE"].ToString() == "土地矿产").Sum(e => e["TOTAL_AMOUNT"].ToString().ToDecimal()).ToRound(),
                jyedt.Where(e => e["TYPE"].ToString() == "政府采购").Sum(e => e["TOTAL_AMOUNT"].ToString().ToDecimal()).ToRound(),
                jyedt.Where(e => e["TYPE"].ToString() == "其他交易").Sum(e => e["TOTAL_AMOUNT"].ToString().ToDecimal()).ToRound()
            };
            //增值额占比
            List<decimal> ZZEZB = new List<decimal>
            {
                zzedt.Where(e => e["TYPE"].ToString() == "工程建设").Sum(e => e["TOTAL_AMOUNT"].ToString().ToDecimal()).ToRound(),
                zzedt.Where(e => e["TYPE"].ToString() == "产权交易").Sum(e => e["TOTAL_AMOUNT"].ToString().ToDecimal()).ToRound(),
                zzedt.Where(e => e["TYPE"].ToString() == "土地矿产").Sum(e => e["TOTAL_AMOUNT"].ToString().ToDecimal()).ToRound(),
                zzedt.Where(e => e["TYPE"].ToString() == "政府采购").Sum(e => e["TOTAL_AMOUNT"].ToString().ToDecimal()).ToRound(),
                zzedt.Where(e => e["TYPE"].ToString() == "其他交易").Sum(e => e["TOTAL_AMOUNT"].ToString().ToDecimal()).ToRound()
            };
            r.SetSuccess(new
            {
                COUNT,
                JYS = JYSZB,
                JYE = JYEZB,
                JYJYE = JYE1ZB,
                JYZZE = ZZEZB
            });
            return r;
        }

        public GeneralResult ShouYeQuShi(BigDataSearchModel search)
        {
            var r = new GeneralResult();
            //判断时间跨度确认X轴
            if (DateTime.MinValue.Equals(search.BeginTime) || DateTime.MinValue.Equals(search.EndTime))
            {
                r.SetFail("起始时间和结束时间不能为空");
                return r;
            }
            var where = new WhereClipBuilder();
            if (!DateTime.MinValue.Equals(search.BeginTime))
            {
                where.And(V_BIG_ALLRESULT._.M_TM >= search.BeginTime);
            }

            if (!DateTime.MinValue.Equals(search.EndTime))
            {
                where.And(V_BIG_ALLRESULT._.M_TM < search.EndTime);
            }
            List<string> xData = new List<string>();
            List<Dictionary<string, object>> dt;
            string Unit = "";
            //小于30按天
            if ((search.EndTime - search.BeginTime).TotalDays < 32)
            {
                Unit = "天";
                dt = DbContext.Fw.From<V_BIG_ALLRESULT>().Where(where.ToWhereClip())
                    .GroupBy(V_BIG_ALLRESULT._.TYPE, V_BIG_ALLRESULT._.M_TM.ToChar("yyyy-mm-dd", "M_TM"))
                    .Select(V_BIG_ALLRESULT._.TYPE, V_BIG_ALLRESULT._.M_TM.ToChar("yyyy-mm-dd", "M_TM"), V_BIG_ALLRESULT._.AMOUNT.Sum().As("AMOUNT"),
                        V_BIG_ALLRESULT._.PROJECT_CODE.Count().As("COU")).ToDataTable().ToDictionary();
                //生成横轴
                for (int i = 0; i < (search.EndTime - search.BeginTime).TotalDays; i++)
                {
                    xData.Add(search.BeginTime.AddDays(i).ToString("yyyy-MM-dd"));
                }
            }
            //按月
            else
            {
                Unit = "月";
                dt = DbContext.Fw.From<V_BIG_ALLRESULT>().Where(where.ToWhereClip())
                   .GroupBy(V_BIG_ALLRESULT._.TYPE, V_BIG_ALLRESULT._.M_TM.ToChar("yyyy-mm", "M_TM"))
                   .Select(V_BIG_ALLRESULT._.TYPE, V_BIG_ALLRESULT._.M_TM.ToChar("yyyy-mm", "M_TM"), V_BIG_ALLRESULT._.AMOUNT.Sum().As("AMOUNT"),
                       V_BIG_ALLRESULT._.PROJECT_CODE.Count().As("COU")).ToDataTable().ToDictionary();
                //生成横轴
                for (int i = 0; i < 12; i++)
                {
                    var time = search.BeginTime.AddMonths(i);
                    xData.Add(time.ToString("yyyy-MM"));
                    if ((search.EndTime - time).TotalDays < 32)
                    {
                        break;
                    }
                }
            }
            List<decimal> CQJYJYE = new List<decimal>();
            List<int> CQJYJYS = new List<int>();
            List<decimal> GCJSJYE = new List<decimal>();
            List<int> GCJSJYS = new List<int>();
            List<decimal> TDKCJYE = new List<decimal>();
            List<int> TDKCJYS = new List<int>();
            List<decimal> ZFCGJYE = new List<decimal>();
            List<int> ZFCGJYS = new List<int>();
            foreach (var d in xData)
            {
                CQJYJYE.Add(dt.Where(e => e["M_TM"].ToString() == d && e["TYPE"].ToString() == "产权交易").Sum(e => e["AMOUNT"].ToString().ToDecimal() / 10000).ToRound());
                GCJSJYE.Add(dt.Where(e => e["M_TM"].ToString() == d && e["TYPE"].ToString() == "工程建设").Sum(e => e["AMOUNT"].ToString().ToDecimal() / 10000).ToRound());
                TDKCJYE.Add(dt.Where(e => e["M_TM"].ToString() == d && e["TYPE"].ToString() == "土地矿业").Sum(e => e["AMOUNT"].ToString().ToDecimal() / 10000).ToRound());
                ZFCGJYE.Add(dt.Where(e => e["M_TM"].ToString() == d && e["TYPE"].ToString() == "政府采购").Sum(e => e["AMOUNT"].ToString().ToDecimal() / 10000).ToRound());

                CQJYJYS.Add(dt.Where(e => e["M_TM"].ToString() == d && e["TYPE"].ToString() == "产权交易").Sum(e => e["COU"].ToString().ToInt()));
                GCJSJYS.Add(dt.Where(e => e["M_TM"].ToString() == d && e["TYPE"].ToString() == "工程建设").Sum(e => e["COU"].ToString().ToInt()));
                TDKCJYS.Add(dt.Where(e => e["M_TM"].ToString() == d && e["TYPE"].ToString() == "土地矿业").Sum(e => e["COU"].ToString().ToInt()));
                ZFCGJYS.Add(dt.Where(e => e["M_TM"].ToString() == d && e["TYPE"].ToString() == "政府采购").Sum(e => e["COU"].ToString().ToInt()));
            }

            r.SetSuccess(new
            {
                xData,
                ChartDataBottom = new
                {
                    CQJYJYE,
                    GCJSJYE,
                    TDKCJYE,
                    ZFCGJYE,
                    CQJYJYS,
                    GCJSJYS,
                    TDKCJYS,
                    ZFCGJYS,
                },
                Unit
            });
            return r;
        }

        #endregion

        #region 交易概况-工程建设-代理

        public GeneralResult GCJSProxyRank(BigDataSearchModel s)
        {
            var r = new GeneralResult();
            var where = new WhereClipBuilder();
            if (!DateTime.MinValue.Equals(s.BeginTime))
            {
                where.And(V_BIG_PROXY._.M_TM >= s.BeginTime);
            }

            if (!DateTime.MinValue.Equals(s.EndTime))
            {
                where.And(V_BIG_PROXY._.M_TM < s.EndTime);
            }

            var jysRank = DbContext.Fw.From<V_BIG_PROXY>().Where(where.ToWhereClip())
                .GroupBy(V_BIG_PROXY._.TENDER_AGENCY_NAME)
                .Select(V_BIG_PROXY._.TENDER_AGENCY_NAME, V_BIG_PROXY._.PROJECT_CODE.Count().As("COUNT"))
                .OrderByDescending(V_BIG_PROXY._.PROJECT_CODE.Count().As("COUNT"))
                .Top(10)
                .ToDataTable().ToDictionary();
            var jyeRank = DbContext.Fw.From<V_BIG_PROXY>().Where(where.ToWhereClip())
                .GroupBy(V_BIG_PROXY._.TENDER_AGENCY_NAME)
                .Select(V_BIG_PROXY._.TENDER_AGENCY_NAME, V_BIG_PROXY._.AMOUNT.Sum().As("AMOUNT"))
                .OrderByDescending(V_BIG_PROXY._.AMOUNT.Sum().As("AMOUNT"))
                .Top(10)
                .ToDataTable().ToDictionary();
            r.SetSuccess(new
            {
                jysRank,
                jyeRank
            });
            return r;
        }

        public GeneralResult GCJSProxyMiddle(BigDataSearchModel s)
        {
            var r = new GeneralResult();
            s.method = "PROXY_MIDDLE";
            string sql = GetSql(s, out string orderby1, out List<OracleParameter> dbParams1);
            var dt = FromSql(sql).AddParameter(dbParams1.ToArray()).ToDataTable().ToDictionary();
            List<object> list = new List<object>();
            foreach (var obj in dt)
            {
                list.Add(new
                {
                    name = obj["NAME"],
                    value = obj["VALUE"]
                });
            }
            r.SetSuccess(list);
            return r;
        }

        public GeneralResult GCJSProxyAreaCount(BigDataSearchModel s)
        {
            var r = new GeneralResult();
            var where = new WhereClipBuilder();
            if (!DateTime.MinValue.Equals(s.BeginTime))
            {
                where.And(V_BIG_DAILI._.M_TM >= s.BeginTime);
            }

            if (!DateTime.MinValue.Equals(s.EndTime))
            {
                where.And(V_BIG_DAILI._.M_TM < s.EndTime);
            }
            var dt = DbContext.Fw.From<V_BIG_DAILI>().Where(where.ToWhereClip())
                .GroupBy(V_BIG_DAILI._.QUYU)
                .Select(V_BIG_DAILI._.QUYU, V_BIG_DAILI._.LEGAL_CODE.Count().As("COUNT"))
                .ToDataTable().ToDictionary();
            r.SetSuccess(dt);
            return r;
        }

        public GeneralResult GCJSProxyAreaChart(BigDataSearchModel s)
        {
            var r = new GeneralResult();
            s.method = "PROXY_AREA";
            string sql = GetSql(s, out string orderby1, out List<OracleParameter> dbParams1);
            var dt = FromSql(sql).AddParameter(dbParams1.ToArray()).ToDataTable().ToDictionary();
            //对结果进行排序并只返回数组
            var list = new List<int>()
            {
                int.Parse(dt.FirstOrDefault(e => e["AREANAME"].ToString() == "省本级") != null
                    ? dt.FirstOrDefault(e => e["AREANAME"].ToString() == "省本级").GetStringValue("TOTAL_COUNT")
                    : "0"),
                int.Parse(dt.FirstOrDefault(e => e["AREANAME"].ToString() == "福州市") != null
                    ? dt.FirstOrDefault(e => e["AREANAME"].ToString() == "福州市").GetStringValue("TOTAL_COUNT")
                    : "0"),
                int.Parse(dt.FirstOrDefault(e => e["AREANAME"].ToString() == "厦门市") != null
                    ? dt.FirstOrDefault(e => e["AREANAME"].ToString() == "厦门市").GetStringValue("TOTAL_COUNT")
                    : "0"),
                int.Parse(dt.FirstOrDefault(e => e["AREANAME"].ToString() == "漳州市") != null
                    ? dt.FirstOrDefault(e => e["AREANAME"].ToString() == "漳州市").GetStringValue("TOTAL_COUNT")
                    : "0"),
                int.Parse(dt.FirstOrDefault(e => e["AREANAME"].ToString() == "泉州市") != null
                    ? dt.FirstOrDefault(e => e["AREANAME"].ToString() == "泉州市").GetStringValue("TOTAL_COUNT")
                    : "0"),
                int.Parse(dt.FirstOrDefault(e => e["AREANAME"].ToString() == "三明市") != null
                    ? dt.FirstOrDefault(e => e["AREANAME"].ToString() == "三明市").GetStringValue("TOTAL_COUNT")
                    : "0"),
                int.Parse(dt.FirstOrDefault(e => e["AREANAME"].ToString() == "莆田市") != null
                    ? dt.FirstOrDefault(e => e["AREANAME"].ToString() == "莆田市").GetStringValue("TOTAL_COUNT")
                    : "0"),
                int.Parse(dt.FirstOrDefault(e => e["AREANAME"].ToString() == "南平市") != null
                    ? dt.FirstOrDefault(e => e["AREANAME"].ToString() == "南平市").GetStringValue("TOTAL_COUNT")
                    : "0"),
                int.Parse(dt.FirstOrDefault(e => e["AREANAME"].ToString() == "龙岩市") != null
                    ? dt.FirstOrDefault(e => e["AREANAME"].ToString() == "龙岩市").GetStringValue("TOTAL_COUNT")
                    : "0"),
                int.Parse(dt.FirstOrDefault(e => e["AREANAME"].ToString() == "宁德市") != null
                    ? dt.FirstOrDefault(e => e["AREANAME"].ToString() == "宁德市").GetStringValue("TOTAL_COUNT")
                    : "0"),
                int.Parse(dt.FirstOrDefault(e => e["AREANAME"].ToString() == "平潭综合实验区") != null
                    ? dt.FirstOrDefault(e => e["AREANAME"].ToString() == "平潭综合实验区").GetStringValue("TOTAL_COUNT")
                    : "0"),
            };
            r.SetSuccess(list);
            return r;
        }

        public GeneralResult GCJSProxyLevelCount(BigDataSearchModel s)
        {
            var r = new GeneralResult();
            var where = new WhereClipBuilder();
            if (!DateTime.MinValue.Equals(s.BeginTime))
            {
                where.And(V_BIG_DAILI._.M_TM >= s.BeginTime);
            }

            if (!DateTime.MinValue.Equals(s.EndTime))
            {
                where.And(V_BIG_DAILI._.M_TM < s.EndTime);
            }
            var dt = DbContext.Fw.From<V_BIG_DAILI>().Where(where.ToWhereClip())
                .GroupBy(V_BIG_DAILI._.TYPE)
                .Select(V_BIG_DAILI._.TYPE, V_BIG_DAILI._.LEGAL_CODE.Count().As("COUNT"))
                .ToDataTable().ToDictionary();
            //对结果进行排序并只返回数组
            var list = new List<int>()
            {
                int.Parse(dt.FirstOrDefault(e => e["TYPE"].ToString() == "甲级") != null
                    ? dt.FirstOrDefault(e => e["TYPE"].ToString() == "甲级").GetStringValue("COUNT")
                    : "0"),
                int.Parse(dt.FirstOrDefault(e => e["TYPE"].ToString() == "乙级") != null
                    ? dt.FirstOrDefault(e => e["TYPE"].ToString() == "乙级").GetStringValue("COUNT")
                    : "0"),
                int.Parse(dt.FirstOrDefault(e => e["TYPE"].ToString() == "丙级") != null
                    ? dt.FirstOrDefault(e => e["TYPE"].ToString() == "丙级").GetStringValue("COUNT")
                    : "0"),
                int.Parse(dt.FirstOrDefault(e => e["TYPE"].ToString() == "丁级") != null
                    ? dt.FirstOrDefault(e => e["TYPE"].ToString() == "丁级").GetStringValue("COUNT")
                    : "0"),
                int.Parse(dt.FirstOrDefault(e => e["TYPE"].ToString() == "暂定级（预乙级）") != null
                    ? dt.FirstOrDefault(e => e["TYPE"].ToString() == "暂定级（预乙级）").GetStringValue("COUNT")
                    : "0")
            };
            r.SetSuccess(list);
            return r;
        }

        #endregion
    }
}
