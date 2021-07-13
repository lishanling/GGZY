using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJH.DbEntity;

namespace GGZY.Services.ZBCG
{
    public partial class ZpNoticeService
    {
        /// <summary>
        /// 招标采购网历史数据明细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Hashtable> BidDetail(string id)
        {
            var nodes = new List<Hashtable>();
            var GG = FromSql(
                    @"SELECT ZN_ID,ZN_TITLE,ZN_ZID,ZN_OPENTIME,ZN_INDUSTRY,ZN_AREA,ZN_BEACONTYPE,ZN_MONEY,ZN_PROXY,ZN_USERNAME,ZN_CONTENT as CONTENT,CRTIME FROM ZP_NOTICE where ZN_ID=:znid")
                .AddInParameter(":znid", DbType.AnsiString, id)
                .ToFirst<object>();
            var index = 0;
            if (GG != null)
            {
                Hashtable nodeGG = new Hashtable
                {
                    ["TITLE"] = "招标公告",
                    ["GGTYPE"] = "1",
                    ["GGSORT"] = index,
                    ["TM"] = GG.PropertyToString("CRTIME"),
                    ["YEAR"] = GG.PropertyToString("CRTIME")?.Substring(0, 4),
                    ["NUM"] = index,
                    ["DATA"] = GG
                };
                nodes.Add(nodeGG);
            }

            var gs = FromSql(@"select ZR_ID,ZR_INDUSTRY,ZR_PROXY,ZR_QUOTE,ZR_ZUNIT,ZR_TITLE,ZR_CONTENT as CONTENT,CRTIME,ZR_TYPE from ZP_RESULT where ZR_STATE = 'RELEASE' and ZR_BID=:zrbid order by crtime desc")
                .AddInParameter(":zrbid", DbType.AnsiString, id)
                .ToList<object>();
            foreach (var o in gs)
            {
                index++;
                Hashtable item = new Hashtable
                {
                    ["TITLE"] = o.PropertyToString("ZR_TYPE") == "RESULT" ? "中标结果" : "中标公示",
                    ["GGTYPE"] = o.PropertyToString("ZR_TYPE") == "RESULT" ? "3" : "2",
                    ["GGSORT"] = index,
                    ["TM"] = o.PropertyToString("CRTIME"),
                    ["YEAR"] = o.PropertyToString("CRTIME")?.Substring(0, 4),
                    ["NUM"] = index,
                    ["DATA"] = o
                };
                nodes.Add(item);
            }

            var dayi = FromSql(@"select ZF_TITLE,ZF_ID,ZF_QNAME,CRTIME,ZF_ANSWER,ZF_QUESTION from ZP_FAQ where ZF_TID=:zftid and ZF_STATE = 'YES'  order by crtime desc")
                .AddInParameter(":zftid", DbType.AnsiString, id)
                .ToList<object>();
            foreach (var o in dayi)
            {
                index++;
                Hashtable item = new Hashtable
                {
                    ["TITLE"] = "答疑",
                    ["GGTYPE"] = 4,
                    ["GGSORT"] = index.ToString(),
                    ["TM"] = o.PropertyToString("CRTIME"),
                    ["YEAR"] = o.PropertyToString("CRTIME")?.Substring(0, 4),
                    ["NUM"] = index,
                    ["DATA"] = o
                };
            }
            nodes.Sort(
                delegate (Hashtable a, Hashtable b)
                {
                    DateTime dateTime1 = a["TM"].ToString().ToDateTime();
                    DateTime dateTime2 = b["TM"].ToString().ToDateTime();
                    return dateTime1.CompareTo(dateTime2);
                }
            );
            return nodes;
        }
        /// <summary>
        /// 招标采购网历史数据明细
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public object BidPageList(ZP_NOTICE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            if (search.BeginTime.HasValue)
            {
                condition.And(ZP_NOTICE._.CRTIME >= search.BeginTime.Value);
            }

            if (search.EndTime.HasValue)
            {
                condition.And(ZP_NOTICE._.CRTIME <= search.EndTime.Value);
            }
            condition.And(ZP_NOTICE._.CRTIME < new DateTime(2017, 1, 1));
            condition.And(ZP_NOTICE._.ZN_STATE == "RELEASE");
            var count = Count(condition.ToWhereClip());
            var dt = PageList(condition, search, ZP_NOTICE._.CRTIME.Desc && ZP_NOTICE._.ZN_ID.Desc);
            var znIds = dt.Select(c => c.ZN_ID).Distinct().ToList();
            var gsjg = ZBCG.ZpResultService.FromWhere(ZP_RESULT._.ZR_BID.In(znIds)).ToList();
            var grp = gsjg.GroupBy(c => new {c.ZR_TYPE, c.ZR_BID}).Select(c => new
            {
                ZR_ID=c.Max(o=>o.ZR_ID),
                ZR_TYPE=c.Key.ZR_TYPE,
                c.Key.ZR_BID,
            }).ToList();
                //.GroupBy(ZP_RESULT._.ZR_TYPE.GroupBy && ZP_RESULT._.ZR_BID.GroupBy)
                //.Select(ZP_RESULT._.ZR_ID.Max(), ZP_RESULT._.ZR_TYPE, ZP_RESULT._.ZR_BID).ToList();
            var faq = ZBCG.ZpFaqService.FromWhere(ZP_FAQ._.ZF_TID.In(znIds)).ToList();
                var zfTidGroup= faq.GroupBy(c => c.ZF_TID)
                .Select(c => new
                {
                    Count=c.Count(),
                    ZF_TID=c.Key
                }).ToList();
                //.GroupBy(ZP_FAQ._.ZF_TID).Select(ZP_FAQ._.ZF_ID.Count(), ZP_FAQ._.ZF_TID).ToList();
            List<Hashtable> list = new List<Hashtable>();
            for (var index = 0; index < dt.Count; index++)
            {
                var r = dt[index];
                Hashtable item = new Hashtable();
                item["ZN_ID"] = r.ZN_ID;
                item["RN"] =search.StartIndex+index;
                item["ZN_TITLE"] = r.ZN_TITLE;
                item["CRTIME"] = r.CRTIME; //string.IsNullOrEmpty(r["CRTIME"].ToString()) ? "" : 
                item["GS"] = grp.FirstOrDefault(c => String.Compare("pub", c.ZR_TYPE, StringComparison.CurrentCultureIgnoreCase) == 0 && c.ZR_BID == r.ZN_ID.ToString())?.ZR_ID;
                item["JG"] = grp.FirstOrDefault(c => String.Compare("result", c.ZR_TYPE, StringComparison.CurrentCultureIgnoreCase) == 0 && c.ZR_BID == r.ZN_ID.ToString())?.ZR_ID;
                item["FAQ"] = zfTidGroup.FirstOrDefault(c => c.ZF_TID == r.ZN_ID)?.Count;
                list.Add(item);
            }

            return list.ToPageTableResult(search, count);
        }
    }
}