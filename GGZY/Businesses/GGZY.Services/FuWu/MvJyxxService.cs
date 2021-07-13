using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model;
using GGZY.Services.Infrastructure.Model.FuWu;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class MvJyxxService
    {
        public List<FwPortalTradeInfoType> TradeInfoProTypes(SearchCondition search)
        {
            var begin = DateTime.Now;
            if (search.BeginTime.HasValue)
            {
                search.BeginTime = search.BeginTime.Value.Date;
            }
            if (search.EndTime.HasValue)
            {
                search.EndTime = search.EndTime.Value.Date.AddDays(1).AddSeconds(-1);
            }
            var md5 = search.Md5Param();
            var groupKey = $"{ConfigHelper.APP_KEY_GGZYFW}:TradeInfoProTypes:TradeInfo";
            var dicKey = $"{groupKey}:Dic";
            Logger.Info($"{dicKey}=> {Cache.IsSet(dicKey)}");
            var result = Cache.Get(dicKey, () =>
            {
                var cacheResult = new List<FwPortalTradeInfoType>();
                Logger.Info($"{groupKey}=> {Cache.IsSet(groupKey)}");
                var groups = Cache.Get(groupKey, () =>
                {
                    var field = new Field("PROTYPE");
                    var tmField = new Field("TM");
                    var condition = new WhereClipBuilder();
                    if (search.BeginTime.HasValue)
                    {
                        condition.And(tmField >= search.BeginTime);
                    }
                    if (search.EndTime.HasValue)
                    {
                        condition.And(tmField <= search.EndTime);
                    }
                    return FromWhere().Union(FromWhere<MV_JYXX_HISTORY>().Where(condition.ToWhereClip()))
                        .Where(condition.ToWhereClip())
                        .GroupBy(field)
                        .Select(field.As("Label"), field.Count().As("Value")).ToList<LabelValueModel>();
                });
                var projectTypes = groups.FindAll(c => String.CompareOrdinal(c.Value, "0") > 0).Select(c => c.Label)
                    .ToList();
                var gProjectTypes = projectTypes.Select(c => c.Replace("G", "A")).ToList();
                var p = Fw.SysDicService.FindList(SYS_DIC._.TYPE == "20200830001", SYS_DIC._.ORDER_ID.Asc);
                var pids = p.Select(pi => pi.ID).ToList();
                var dic = Fw.SysDicService.FindList(SYS_DIC._.PID.In(pids), SYS_DIC._.ORDER_ID.Asc);

                foreach (var pi in p)
                {
                    var child = dic
                        .FindAll(o => o.PID == pi.ID && o.TYPE == "20200830003" &&
                            (string.IsNullOrWhiteSpace(o.VALUE) || o.VALUE.Contains(",") || projectTypes.Contains(o.VALUE) || gProjectTypes.Contains(o.VALUE)))
                        .Select(c => new SelectModel(c.VALUE, c.TEXT)).ToList();
                    var ggtype = dic.FindAll(o => o.PID == pi.ID && o.TYPE == "20200830002").Select(c =>
                        new LabelValueModel
                        {
                            Label = c.TEXT,
                            Value = c.VALUE,
                        }).ToList();
                    var piTree = new FwPortalTradeInfoType(pi.VALUE, pi.TEXT)
                    {
                        Children = child,
                        GGTYPE = ggtype
                    };
                    cacheResult.Add(piTree);
                }

                return cacheResult;
            });
            var end = DateTime.Now;
            Logger.Info($"Read {dicKey} Cost {end:HH:mm:ss.fff}-{begin:HH:mm:ss.fff}={(end - begin).Duration().TotalMilliseconds} 毫秒");
            return result;
        }

        public PageTableResult TradeInfoPageList(MV_JYXX model, SearchCondition search)
        {
            #region 条件

            var con = new WhereClipBuilder();
            var con1 = new WhereClipBuilder();
            if (search.BeginTime.HasValue && search.EndTime.HasValue)
            {
                con.And(MV_JYXX._.TM >= search.BeginTime.Value && MV_JYXX._.TM <= search.EndTime.Value && MV_JYXX._.TM <= DateTime.Now);
                con1.And(MV_JYXX_HISTORY._.TM >= search.BeginTime.Value && MV_JYXX_HISTORY._.TM <= search.EndTime.Value && MV_JYXX_HISTORY._.TM <= DateTime.Now);
            }
            if (!string.IsNullOrWhiteSpace(model.NAME))
            {
                con.And(MV_JYXX._.NAME.Contain(model.NAME) || MV_JYXX._.M_ID.Contain(model.NAME));
                con1.And(MV_JYXX_HISTORY._.NAME.Contain(model.NAME) || MV_JYXX_HISTORY._.M_ID.Contain(model.NAME));
            }

            if (!string.IsNullOrWhiteSpace(model.AREACODE))
            {
                if (model.AREACODE == "350000" || model.AREACODE == "350128") //省本级和平潭实验区
                {
                    con.And(MV_JYXX._.AREACODE == model.AREACODE);
                    con1.And(MV_JYXX_HISTORY._.AREACODE == model.AREACODE);
                }
                else if (model.AREACODE == "350100")//福州市不包含平潭实验区
                {
                    con.And(MV_JYXX._.AREACODE.BeginWith("3501") && MV_JYXX._.AREACODE != "350128");
                    con1.And(MV_JYXX_HISTORY._.AREACODE.BeginWith("3501") && MV_JYXX_HISTORY._.AREACODE != "350128");
                }
                else
                {
                    var area = model.AREACODE.MaxSubString(4);
                    con.And(MV_JYXX._.AREACODE.BeginWith(area));
                    con1.And(MV_JYXX_HISTORY._.AREACODE.BeginWith(area));
                }
            }
            else
            {
                con.And(MV_JYXX._.AREACODE.BeginWith("350"));
                con1.And(MV_JYXX_HISTORY._.AREACODE.BeginWith("350"));
            }
            if (string.IsNullOrWhiteSpace(model.KIND))
            {
                model.KIND = "GCJS"; //工程建设
            }
            con.And(MV_JYXX._.KIND == model.KIND);
            con1.And(MV_JYXX_HISTORY._.KIND == model.KIND);
            if (model.KIND == "GCJS")
            {
                var dt2018 = new DateTime(2018, 1, 1);
                var dataSource = "9999";
                con.And(MV_JYXX._.M_DATA_SOURCE == dataSource || MV_JYXX._.TM >= dt2018);
                con1.And(MV_JYXX_HISTORY._.M_DATA_SOURCE == dataSource || MV_JYXX_HISTORY._.TM >= dt2018);
                if (!string.IsNullOrWhiteSpace(model.M_PROJECT_TYPE))
                {
                    con.And(MV_JYXX._.M_PROJECT_TYPE == model.M_PROJECT_TYPE);
                    con1.And(MV_JYXX_HISTORY._.M_PROJECT_TYPE == model.M_PROJECT_TYPE);
                }
            }

            if (!string.IsNullOrWhiteSpace(model.GGTYPE))
            {// TODO 这里可能有bug
                var types = model.GGTYPE.Split(',').ToList();
                con.And(MV_JYXX._.GGTYPE.In(types));
                con1.And(MV_JYXX_HISTORY._.GGTYPE.In(types));
            }
            if (!string.IsNullOrWhiteSpace(model.PROTYPE))
            {
                var gType = model.PROTYPE.Replace("A", "G");
                con.And(MV_JYXX._.PROTYPE == model.PROTYPE || MV_JYXX._.PROTYPE == gType);
                con1.And(MV_JYXX_HISTORY._.PROTYPE == model.PROTYPE || MV_JYXX_HISTORY._.PROTYPE == gType);
            }

            #endregion
            if (!search.BeginTime.HasValue || (DateTime.Now - search.BeginTime.Value).TotalDays <= 91)
            {
                con.And(MV_JYXX._.TM < DateTime.Now);
                var count = Count(con);
                //var pageList = PageList(con, search, MV_JYXX._.TM.Desc && MV_JYXX._.M_ID.Desc)
                //    .ToDataTableResult(search, count);
                var pageList = FromWhere(con.ToWhereClip())
                    .OrderBy(MV_JYXX._.TM.Desc && MV_JYXX._.M_ID.Desc)
                    .Page(search.PageSize, search.PageNo)
                    .ToList<TradeInfoModel>()
                    .ToPageTableResult(search, count);
                return pageList;
            }
            else
            {
                var count = FromWhere(con.ToWhereClip())
                    .Union(FromWhere<MV_JYXX_HISTORY>(con1.ToWhereClip())).Count();
                var pageList = FromWhere(con.ToWhereClip())
                      .Union(FromWhere<MV_JYXX_HISTORY>(con1.ToWhereClip()))
                      .OrderBy(new Field("TM").Desc && new Field("M_ID").Desc)
                      .Page(search.PageSize, search.PageNo)
                      .ToList<TradeInfoModel>()
                      .ToPageTableResult(search, count);
                return pageList;
            }
        }
        /// <summary>
        /// //交易信息->工程建设：获取公告基本信息/公告节点接口
        /// </summary>
        /// <returns></returns>
        public FwGCJSTradeInfo GCJS_TradeInfo(string id, Func<string, string> attachmentFunc = null)
        {
            var model = new FwGCJSTradeInfo();
            //获取公告基本信息

            #region 基础信息

            model.BaseInfo = Fw.TenderAnnQuaInqueryAnnService.FromWhere(TENDER_ANN_QUA_INQUERY_ANN._.M_ID == id && TENDER_ANN_QUA_INQUERY_ANN._.M_STATUS == 2)
                .LeftJoin<T_USER_TRADEPLATFORM>(T_USER_TRADEPLATFORM._.PLATFORM_CODE == TENDER_ANN_QUA_INQUERY_ANN._.PLATFORM_CODE)
                .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "9" && "TENDER_PROJECT.TENDER_PROJECT_TYPE LIKE SYS_DIC.VALUE1||'%'")//SYS_DIC._.VALUE1=="regexp_replace(C.TENDER_PROJECT_TYPE,'\\d','')"
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "10" && SYS_DIC._.VALUE == TENDER_PROJECT._.TENDER_PROJECT_TYPE)
                .Select(
                    TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_NAME,
                    TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE,
                    TENDER_ANN_QUA_INQUERY_ANN._.BID_SECTION_CODES,
                    T_USER_TRADEPLATFORM._.SYSTEM_NAME.As("PLATFORM_CODE_NAME"),
                    TENDER_PROJECT._.TENDER_PROJECT_TYPE,
                    SYS_DIC._.TEXT.As("TENDER_PROJECT_TYPE_CATEGORY"),
                    new Field("TEXT", "SYS_DIC2").As("TENDER_PROJECT_TYPE_NAME"),
                    TENDER_ANN_QUA_INQUERY_ANN._.DOC_GET_END_TIME,
                    TENDER_ANN_QUA_INQUERY_ANN._.M_ZY_TM,
                    TENDER_ANN_QUA_INQUERY_ANN._.M_BZJ_TM,
                    TENDER_ANN_QUA_INQUERY_ANN._.BID_DOC_REFER_END_TIME
                ).ToFirst<FwGCJSTradeDetailBase>();

            #endregion

            #region 咨询答疑

            var askanswers = Fw.TAskanswerService.FromWhere(T_ASKANSWER._.ANN_ID == id && T_ASKANSWER._.IS_GS == 1)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "9001" && SYS_DIC._.VALUE == T_ASKANSWER._.TYPE)
                .LeftJoin<T_USER>(T_USER._.ID == T_ASKANSWER._.ANSWER_USERID)
                .OrderBy(T_ASKANSWER._.TM)
                .Select(
                    T_ASKANSWER._.ID,
                    T_ASKANSWER._.TM,
                    T_ASKANSWER._.ASK,
                    T_ASKANSWER._.TITLE,
                    T_ASKANSWER._.ANSWER,
                    T_ASKANSWER._.ANSWER_TM,
                    T_ASKANSWER._.ASK_ZY_REASON,
                    SYS_DIC._.TEXT.As("TYPE"),
                    T_USER._.ZP_UNIT,
                    T_USER._.MANAGE_NAME
                ).ToList<T_ASKANSWER>();

            #endregion
            var all = new List<FwGCJSTradeDetail>();
            if (model.BaseInfo != null)
            {
                //获取公告节点  资格预审和招标公告是同级的
                var condition = new WhereClip($"M_STATUS=2 and TENDER_PROJECT_CODE='{model.BaseInfo.TENDER_PROJECT_CODE}'");
                var con = new WhereClipBuilder();
                var winCon = new WhereClipBuilder();
                var cnnCon = new WhereClipBuilder();
                if (string.IsNullOrWhiteSpace(model.BaseInfo.BID_SECTION_CODES))
                {
                    con.And(" to_char(BID_SECTION_CODES) is null");
                }
                else
                {
                    con.And($" to_char(BID_SECTION_CODES) ='{model.BaseInfo.BID_SECTION_CODES}'");
                    winCon.And($"  instr(';{model.BaseInfo.BID_SECTION_CODES};', ';' || to_char(BID_SECTION_CODE) || ';') > 0");
                    cnnCon.And($"  instr(';{model.BaseInfo.BID_SECTION_CODES};', ';' || to_char(BID_SECTION_CODES) || ';') > 0");
                }
                var notices = Fw.TenderAnnQuaInqueryAnnService.FindList(condition
                    && TENDER_ANN_QUA_INQUERY_ANN._.BULLETIN_TYPE.In("1", "2")
                    && TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_NATURE.In("1", "2", "3")
                    && con.ToWhereClip());
                var zbgg = notices.FindAll(c => c.BULLETIN_TYPE == "1" && (c.NOTICE_NATURE == "1" || c.NOTICE_NATURE == "3")).Select(c =>
                        {
                            var m = new FwGCJSTradeDetail
                            {
                                Title = "招标公告",
                                Type = 1,
                                Sort = 1,
                                Contents = c.NOTICE_CONTENT,
                                Time = c.M_TM ?? c.NOTICE_SEND_TIME,
                                Year = c.NOTICE_SEND_TIME?.Year,
                                Detail = string.Empty,
                            };
                            var attachments = string.Empty;
                            if (!string.IsNullOrWhiteSpace(c.M_ATT_TENDER_NOTICE))
                            {
                                attachments = c.M_ATT_TENDER_NOTICE;
                            }
                            else if (!string.IsNullOrWhiteSpace(c.M_ATT_FILE_EX_TDOC))
                            {
                                attachments = c.M_ATT_FILE_EX_TDOC;
                            }
                            else if (!string.IsNullOrWhiteSpace(c.M_ATT_QUAL_NOTICE_FILE))
                            {
                                attachments = c.M_ATT_QUAL_NOTICE_FILE;
                            }

                            if (!string.IsNullOrWhiteSpace(attachments) && attachmentFunc != null)
                            {
                                m.Attachment = attachmentFunc.Invoke(attachments);//.Select(o => o.ATTACHMENT_FILE_NAME).ToList();
                            }
                            return m;
                        }).ToList();
                var bggg = notices.FindAll(c => c.NOTICE_NATURE == "2" && c.BULLETIN_TYPE == "1").Select(c =>
                {
                    var m = new FwGCJSTradeDetail
                    {
                        Title = "变更公告",
                        Type = 2,
                        Sort = 2,
                        Contents = c.NOTICE_CONTENT,
                        Time = c.M_TM ?? c.NOTICE_SEND_TIME,
                        Year = c.NOTICE_SEND_TIME?.Year,
                        Detail = string.Empty,
                    };
                    var attachments = string.Empty;
                    if (!string.IsNullOrWhiteSpace(c.M_ATT_TENDER_NOTICE))
                    {
                        attachments = c.M_ATT_TENDER_NOTICE;
                    }
                    else if (!string.IsNullOrWhiteSpace(c.M_ATT_FILE_EX_TDOC))
                    {
                        attachments = c.M_ATT_FILE_EX_TDOC;
                    }
                    else if (!string.IsNullOrWhiteSpace(c.M_ATT_QUAL_NOTICE_FILE))
                    {
                        attachments = c.M_ATT_QUAL_NOTICE_FILE;
                    }

                    if (!string.IsNullOrWhiteSpace(attachments) && attachmentFunc != null)
                    {
                        m.Attachment = attachmentFunc.Invoke(attachments);//.Select(o => o.ATTACHMENT_FILE_NAME).ToList();
                        m.Contents = string.Empty;
                    }
                    return m;
                }).ToList();
                var zgysgg = notices.FindAll(c => c.NOTICE_NATURE == "1" && c.BULLETIN_TYPE == "2").Select(c =>
                {
                    var m = new FwGCJSTradeDetail
                    {
                        Title = "资格预审公告",
                        Type = 6,
                        Sort = 1,
                        Contents = c.NOTICE_CONTENT,
                        Time = c.M_TM ?? c.NOTICE_SEND_TIME,
                        Year = c.NOTICE_SEND_TIME?.Year,
                        Detail = string.Empty,
                    };
                    var attachments = string.Empty;
                    if (!string.IsNullOrWhiteSpace(c.M_ATT_TENDER_NOTICE))
                    {
                        attachments = c.M_ATT_TENDER_NOTICE;
                    }
                    else if (!string.IsNullOrWhiteSpace(c.M_ATT_FILE_EX_TDOC))
                    {
                        attachments = c.M_ATT_FILE_EX_TDOC;
                    }
                    else if (!string.IsNullOrWhiteSpace(c.M_ATT_QUAL_NOTICE_FILE))
                    {
                        attachments = c.M_ATT_QUAL_NOTICE_FILE;
                    }

                    if (!string.IsNullOrWhiteSpace(attachments) && attachmentFunc != null)
                    {
                        m.Attachment = attachmentFunc.Invoke(attachments);//.Select(o => o.ATTACHMENT_FILE_NAME).ToList();
                        m.Contents = string.Empty;
                    }
                    return m;

                }).ToList();

                var dygs = Fw.TAnswerAnnService.FindList(condition && con.ToWhereClip()).Select(c => new FwGCJSTradeDetail
                {
                    Title = "答疑公示",
                    Type = 3,
                    Sort = 3,
                    Contents = c.ANN_CONTENT,
                    Time = c.M_TM,
                    Year = c.M_TM?.Year,
                    Detail = string.Empty,
                }).ToList();
                var zbhxrgs = Fw.TenderCandidateAnnounceService.FindList(condition && cnnCon.ToWhereClip()).Select(c =>
                {
                    var m = new FwGCJSTradeDetail
                    {
                        Title = "中标候选人公示",
                        Type = 4,
                        Sort = 3,
                        Contents = c.PUBLICITY_CONTENT,
                        Time = c.M_TM ?? c.PUBLICITY_REFER_TIME,
                        Year = c.PUBLICITY_REFER_TIME?.Year,
                        Detail = string.Empty,
                    };
                    if (!string.IsNullOrWhiteSpace(c.M_ATT_PUBLICITY_DOC) && attachmentFunc != null)
                    {
                        m.Attachment = attachmentFunc.Invoke(c.M_ATT_PUBLICITY_DOC);//.Select(o => o.ATTACHMENT_FILE_NAME).ToList();
                        m.Contents = string.Empty;
                    }
                    return m;
                }).ToList();
                var zbjggg = Fw.WinResultAnnoService.FindList(condition && winCon.ToWhereClip()).Select(c =>
                {
                    var m = new FwGCJSTradeDetail
                    {
                        Title = "中标结果公告",
                        Type = 5,
                        Sort = 5,
                        Contents = c.NOTICE_CONTENT,
                        Time = c.M_TM ?? c.NOTICE_SEND_TIME,
                        Year = c.NOTICE_SEND_TIME?.Year,
                        Detail = string.Empty
                    };
                    if (!string.IsNullOrWhiteSpace(c.M_ATT_WIN_BID_NOTICE) && attachmentFunc != null)
                    {
                        m.Attachment = attachmentFunc.Invoke(c.M_ATT_WIN_BID_NOTICE);//.Select(o => o.ATTACHMENT_FILE_NAME).ToList();
                        m.Contents = string.Empty;
                    }
                    return m;
                }).ToList();
                var lbgs = Fw.TenderFlowMarkService.FindList(condition && con.ToWhereClip()).Select(c =>
                {
                    var m = new FwGCJSTradeDetail
                    {
                        Title = "流标公示",
                        Type = 7,
                        Sort = 7,
                        Contents = c.PUBLICITY_CONTENT,
                        Time = c.M_TM ?? c.PUBLICITY_REFER_TIME,
                        Year = c.PUBLICITY_REFER_TIME?.Year,
                        Detail = string.Empty,
                    };

                    if (!string.IsNullOrWhiteSpace(c.M_ATT_PUBLICITY_DOC) && attachmentFunc != null)
                    {
                        m.Attachment = attachmentFunc.Invoke(c.M_ATT_PUBLICITY_DOC);//.Select(o => o.ATTACHMENT_FILE_NAME).ToList();
                        m.Contents = string.Empty;
                    }
                    return m;
                }).ToList();
                all.AddRange(zbgg);
                all.AddRange(bggg);
                all.AddRange(zgysgg);
                all.AddRange(dygs);
                all.AddRange(zbhxrgs);
                all.AddRange(zbjggg);
                all.AddRange(zbjggg);
                all.AddRange(lbgs);
            }
            var nodes = all.OrderBy(c => c.Sort).ThenBy(c => c.Time).ToList();
            if (askanswers.Any())
            {
                for (int i = 0; i < nodes.Count; i++)
                {
                    var node1 = nodes[i];

                    var qas = askanswers.Where(c => c.TM >= node1.Time);
                    if (i < nodes.Count - 1)
                    {
                        var node2 = nodes[i + 1];
                        qas = qas.Where(c => c.TM < node2.Time);
                    }

                    var t = qas.Select(c => new FwGCJSTradeDetail
                    {
                        Title = "咨询质疑",
                        Type = 8,
                        Sort = node1.Sort,
                        Contents = c.ASK,
                        Time = c.TM,
                        Year = c.TM?.Year,
                        Detail = c
                    });
                    all.AddRange(t);
                }
            }
            var allNodes = all.OrderBy(c => c.Sort).ThenBy(c => c.Time).ToList();

            model.Nodes = allNodes.GroupBy(c => c.Year)
                .Select(c => new GCJSTradeNode
                {
                    Year = c.Key,
                    Children = c.ToList()
                }).ToList();
            return model;
        }

        public FwGCJSTradeInfo GCJS_TradeInfoDetail(string id, Func<string, string> attachmentFunc = null)
        {
            //获取公告基本信息
            var cacheModel = Cache.Get($"{ConfigHelper.APP_KEY_GGZYFW}:GCJS_TradeInfoDetail:{id}", 10, () =>
               {
                   var model = new FwGCJSTradeInfo();

                   #region 基础信息

                   model.BaseInfo = Fw.TenderAnnQuaInqueryAnnService.EngineerTradeBaseInfo(id);

                   #endregion

                   //#region 咨询答疑

                   //var askanswers = Fw.TAskanswerService.EngineerTradeInfoQa(id);

                   //#endregion

                   var all = EngineerTradeAnn(id, model.BaseInfo?.TENDER_PROJECT_CODE,
                       model.BaseInfo.BID_SECTION_CODES);
                   var allNodes = all.OrderBy(c => c.Sort).ThenBy(c => c.Time).ToList();

                   model.Nodes = allNodes.GroupBy(c => c.Year)
                       .Select(c => new GCJSTradeNode
                       {
                           Year = c.Key,
                           Children = c.ToList()
                       }).ToList();
                   return model;
               });

            return cacheModel;
        }

        public List<FwGCJSTradeDetail> EngineerTradeAnn(string id, string tenderProjectCode, string bidSectionCodes)
        {
            #region TENDER_ANN_QUA_INQUERY_ANN 招标公告 zbggFromSection

            var zbggFromSection = Fw.TenderAnnQuaInqueryAnnService.FromWhere(
                TENDER_ANN_QUA_INQUERY_ANN._.M_STATUS == 2
                && TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_NATURE.In(1, 3)
                && TENDER_ANN_QUA_INQUERY_ANN._.BULLETIN_TYPE == 1
                && TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE == tenderProjectCode
                && TENDER_ANN_QUA_INQUERY_ANN._.BID_SECTION_CODES.ToChar() == bidSectionCodes)
                .Select(
                    new Field("'招标公告'").As("Title")
                    , new Field("'1'").As("Sort")
                    , new Field("'1'").As("Type")
                    , TENDER_ANN_QUA_INQUERY_ANN._.M_ID
                    //, TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_CONTENT.As("Contents")
                    , new Field("(CASE WHEN M_TM IS NULL THEN NOTICE_SEND_TIME ELSE M_TM END)").As("Time")
                    , TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME.Year.As("Year")
                    );

            #endregion

            #region TENDER_ANN_QUA_INQUERY_ANN 变更公告 bgggFromSection

            var bgggFromSection = Fw.TenderAnnQuaInqueryAnnService.FromWhere(
                TENDER_ANN_QUA_INQUERY_ANN._.M_STATUS == 2
                && TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_NATURE == 2
                && TENDER_ANN_QUA_INQUERY_ANN._.BULLETIN_TYPE == 1
                && TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE == tenderProjectCode
                && TENDER_ANN_QUA_INQUERY_ANN._.BID_SECTION_CODES.ToChar() == bidSectionCodes)
                .Select(
                    new Field("'变更公告'").As("Title")
                    , new Field("'2'").As("Sort")
                    , new Field("'2'").As("Type")
                    , TENDER_ANN_QUA_INQUERY_ANN._.M_ID
                    //, TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_CONTENT.As("Contents")
                    , new Field("(CASE WHEN M_TM IS NULL THEN NOTICE_SEND_TIME ELSE M_TM END)").As("Time")
                    , TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME.Year.As("Year")
                );

            #endregion

            #region T_ANSWER_ANN 答疑公示 askFromSection

            var askFromSection = Fw.TAnswerAnnService.FromWhere(T_ANSWER_ANN._.M_STATUS == 2
                                                              && T_ANSWER_ANN._.TENDER_PROJECT_CODE == tenderProjectCode
                                                              && T_ANSWER_ANN._.BID_SECTION_CODES.ToChar() == bidSectionCodes)
                .Select(
                    new Field("'变更公告'").As("Title")// GGTYPE 3:答疑公示、7:流标公示 => 改成 变更公告
                    , new Field("'3'").As("Sort")
                    , new Field("'3'").As("Type")
                    , T_ANSWER_ANN._.ID.As("M_ID")
                    //, T_ANSWER_ANN._.ANN_CONTENT.As("Contents")
                    , T_ANSWER_ANN._.M_TM.As("Time")
                    , T_ANSWER_ANN._.M_TM.Year.As("Year")
                );

            #endregion

            #region TENDER_CANDIDATE_ANNOUNCE 中标候选人公示 tenderCandidateFromSection

            var tenderCandidateFromSection = Fw.TenderCandidateAnnounceService.FromWhere(
                    TENDER_CANDIDATE_ANNOUNCE._.M_STATUS == 2
                    && TENDER_CANDIDATE_ANNOUNCE._.TENDER_PROJECT_CODE == tenderProjectCode
                    && ";".OracleConcat(TENDER_CANDIDATE_ANNOUNCE._.BID_SECTION_CODES.ToChar().OracleConcat(";")).IndexOf($";{bidSectionCodes};") > -1)
                .Select(
                    new Field("'中标候选人公示'").As("Title")
                    , new Field("'4'").As("Sort")
                    , new Field("'4'").As("Type")
                    , TENDER_CANDIDATE_ANNOUNCE._.M_ID
                    //, TENDER_CANDIDATE_ANNOUNCE._.PUBLICITY_CONTENT.As("Contents")
                    , new Field("(CASE WHEN M_TM IS NULL THEN PUBLICITY_REFER_TIME ELSE M_TM END)").As("Time")
                    , TENDER_CANDIDATE_ANNOUNCE._.PUBLICITY_REFER_TIME.Year.As("Year")
                );

            #endregion

            #region WIN_RESULT_ANNO 中标结果公告 winResultFromSection

            var winResultFromSection = Fw.WinResultAnnoService.FromWhere(
                    WIN_RESULT_ANNO._.M_STATUS == 2
                    && WIN_RESULT_ANNO._.TENDER_PROJECT_CODE == tenderProjectCode
                    && ";".OracleConcat(WIN_RESULT_ANNO._.BID_SECTION_CODE.ToChar().OracleConcat(";")).IndexOf($";{bidSectionCodes};") > -1)
                .Select(
                    new Field("'中标结果公告'").As("Title")
                    , new Field("'5'").As("Sort")
                    , new Field("'5'").As("Type")
                    , WIN_RESULT_ANNO._.M_ID
                    //, WIN_RESULT_ANNO._.NOTICE_CONTENT.As("Contents")
                    , new Field("(CASE WHEN M_TM IS NULL THEN NOTICE_SEND_TIME ELSE M_TM END)").As("Time")
                    , WIN_RESULT_ANNO._.NOTICE_SEND_TIME.Year.As("Year")
                );

            #endregion

            #region TENDER_ANN_QUA_INQUERY_ANN 资格预审公告 zgysggFromSection

            var zgysggFromSection = Fw.TenderAnnQuaInqueryAnnService.FromWhere(
                    TENDER_ANN_QUA_INQUERY_ANN._.M_STATUS == 2
                    && TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_NATURE == 1
                    && TENDER_ANN_QUA_INQUERY_ANN._.BULLETIN_TYPE == 2
                    && TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE == tenderProjectCode
                    && TENDER_ANN_QUA_INQUERY_ANN._.BID_SECTION_CODES.ToChar() == bidSectionCodes)
                .Select(
                    new Field("'资格预审公告'").As("Title")
                    , new Field("'1'").As("Sort")
                    , new Field("'6'").As("Type")
                    , TENDER_ANN_QUA_INQUERY_ANN._.M_ID
                    //, TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_CONTENT.As("Contents")
                    , new Field("(CASE WHEN M_TM IS NULL THEN NOTICE_SEND_TIME ELSE M_TM END)").As("Time")
                    , TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME.Year.As("Year")
                );

            #endregion

            #region TENDER_FLOW_MARK 流标公示 tenderFlowMarkFromSection

            var tenderFlowMarkFromSection = Fw.TenderFlowMarkService.FromWhere(
                    TENDER_FLOW_MARK._.M_STATUS == 2
                    && TENDER_FLOW_MARK._.TENDER_PROJECT_CODE == tenderProjectCode
                    && TENDER_FLOW_MARK._.BID_SECTION_CODES.ToChar() == bidSectionCodes)
                .Select(
                    new Field("'变更公告'").As("Title")// GGTYPE 3:答疑公示、7:流标公示 => 改成 变更公告
                    , new Field("'7'").As("Sort")
                    , new Field("'7'").As("Type")
                    , TENDER_FLOW_MARK._.M_ID
                    //, TENDER_FLOW_MARK._.PUBLICITY_CONTENT.As("Contents")
                    , new Field("(CASE WHEN M_TM IS NULL THEN PUBLICITY_REFER_TIME ELSE M_TM END)").As("Time")
                    , TENDER_FLOW_MARK._.PUBLICITY_REFER_TIME.Year.As("Year")
                );

            #endregion

            var all = zbggFromSection
                .UnionAll(bgggFromSection)
                .UnionAll(askFromSection)
                .UnionAll(tenderCandidateFromSection)
                .UnionAll(zgysggFromSection)
                .UnionAll(winResultFromSection)
                .UnionAll(tenderFlowMarkFromSection)
                .OrderBy(new Field("Sort").Asc && new Field("Time").Asc)
                .ToList<FwGCJSTradeDetail>();
            var askanswers = Fw.TAskanswerService.EngineerTradeInfoQas(id);
            var nodes = all.OrderBy(c => c.Sort).ThenBy(c => c.Time).ToList();
            Logger.Info($"咨询质疑:{askanswers.Serializer()}");
            if (askanswers.Any())
            {
                for (int i = 0; i < nodes.Count; i++)
                {
                    var node1 = nodes[i];

                    var qas = askanswers.Where(c => c.TM >= node1.Time).ToList();
                    if (i < nodes.Count - 1)
                    {
                        var node2 = nodes[i + 1];
                        qas = qas.Where(c => c.TM < node2.Time).ToList();
                    }

                    var t = qas.Select(c => new FwGCJSTradeDetail
                    {
                        Title = "咨询质疑",
                        Type = 8,
                        M_ID = c.ID?.ToString(),
                        Sort = node1.Sort,
                        Contents = c.ASK,
                        Time = c.TM,
                        Year = c.TM?.Year,
                        Detail = c
                    }).ToList();
                    all.AddRange(t);
                }
            }
            return all;
        }

        /// <summary>
        /// 服务平台门户-交易信息-公示内容
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public GeneralResult EngineerTradeAnnContent(string id, string type)
        {
            
           var cacheResult= Cache.Get($"{ConfigHelper.APP_KEY_GGZYFW}:TradeContent:{type}:{id}", () =>
            {
                var r = new GeneralResult() { Success = true };
                var contents = string.Empty;
                switch (type)
                {
                    case "1"://招标公告 TENDER_ANN_QUA_INQUERY_ANN
                    case "2"://变更公告 TENDER_ANN_QUA_INQUERY_ANN
                    case "6"://资格预审公告 TENDER_ANN_QUA_INQUERY_ANN
                        contents = Fw.TenderAnnQuaInqueryAnnService
                            .FromWhere(TENDER_ANN_QUA_INQUERY_ANN._.M_ID == id)
                            .Select(TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_CONTENT).ToScalar<string>();
                        break;
                    case "3"://答疑公示 T_ANSWER_ANN
                        contents = Fw.TAnswerAnnService.FromWhere(T_ANSWER_ANN._.ID == id)
                            .Select(T_ANSWER_ANN._.ANN_CONTENT).ToScalar<string>();
                        break;
                    case "4"://中标候选人公示 TENDER_CANDIDATE_ANNOUNCE
                        contents = Fw.TenderCandidateAnnounceService
                            .FromWhere(TENDER_CANDIDATE_ANNOUNCE._.M_ID == id)
                            .Select(TENDER_CANDIDATE_ANNOUNCE._.PUBLICITY_CONTENT).ToScalar<string>();
                        break;
                    case "5"://中标结果公告 WIN_RESULT_ANNO
                        contents = Fw.WinResultAnnoService.FromWhere(WIN_RESULT_ANNO._.M_ID == id)
                            .Select(WIN_RESULT_ANNO._.NOTICE_CONTENT).ToScalar<string>();
                        break;
                    case "7"://流标公示 TENDER_FLOW_MARK
                        contents = Fw.TenderFlowMarkService.FromWhere(TENDER_FLOW_MARK._.M_ID == id)
                            .Select(TENDER_FLOW_MARK._.PUBLICITY_CONTENT).ToScalar<string>();
                        break;
                    case "8"://咨询质疑 T_ASKANSWER
                             //contents = Fw.TAskanswerService.FromWhere(T_ASKANSWER._.ID == id)
                             //    .Select(T_ASKANSWER._.ASK).ToScalar<string>();
                        var ask = Fw.TAskanswerService.EngineerTradeInfoQa(id);
                        if (ask != null)
                        {
                            r.SetSuccess(new
                            {
                                M_ID = id,
                                Type = type,
                                Detail = ask,
                            });
                        }
                        else
                        {
                            r.SetFail("未找到咨询质疑");
                        }
                        return r;
                    case nameof(PURCHASE_QUALI_INQUERY_ANN)://政府采购 采购/资审公告
                        contents = Fw.PurchaseQualiInqueryAnnService.FromWhere(PURCHASE_QUALI_INQUERY_ANN._.M_ID == id)
                            .Select(PURCHASE_QUALI_INQUERY_ANN._.BULLETIN_CONTENT).ToScalar<string>();
                        break;
                    case nameof(BID_DEAL_ANNOUNCE)://政府采购 中标公告
                        contents = Fw.BidDealAnnounceService.FromWhere(BID_DEAL_ANNOUNCE._.M_ID == id)
                            .Select(BID_DEAL_ANNOUNCE._.WIN_BID_BULLETIN_CONTENT).ToScalar<string>();
                        break;
                    case nameof(CORRECTION_ITEM)://政府采购 更正事项
                        contents = Fw.CorrectionItemService.FromWhere(CORRECTION_ITEM._.M_ID == id)
                            .Select(CORRECTION_ITEM._.TERMINATION_BULLETIN_CONTENT).ToScalar<string>();
                        break;
                    case nameof(DEAL_BEHAVIOR_INFO)://土地使用权 出让公示
                        contents = Fw.DealBehaviorInfoService.FromWhere(DEAL_BEHAVIOR_INFO._.M_ID == id)
                            .Select(DEAL_BEHAVIOR_INFO._.ANNOUNCEMENT_CONNECT).ToScalar<string>();
                        break;
                    case nameof(OTHER_TRADE_PUB_INFO)://其他交易信息 交易公告
                        contents = Fw.OtherTradePubInfoService.FromWhere(OTHER_TRADE_PUB_INFO._.M_ID == id)
                            .Select(OTHER_TRADE_PUB_INFO._.ANNOUNCEMENT_CONNECT).ToScalar<string>();
                        break;
                    case nameof(OTHER_TRADE_RESULT_INFO)://其他交易信息 成交公示
                        contents = Fw.OtherTradeResultInfoService.FromWhere(OTHER_TRADE_RESULT_INFO._.M_ID == id)
                            .Select(OTHER_TRADE_RESULT_INFO._.ANNOUNCEMENT_CONNECT).ToScalar<string>();
                        break;
                    case nameof(DEA_SEWAGE_PAID_TRANSFER_ANNO)://其他交易信息 交易公告
                        contents = Fw.DeaSewagePaidTransferAnnoService.FromWhere(DEA_SEWAGE_PAID_TRANSFER_ANNO._.M_ID == id)
                            .Select(DEA_SEWAGE_PAID_TRANSFER_ANNO._.NOTICE_CONTENT).ToScalar<string>();
                        break;
                    case nameof(DEA_SEWAGE_PAID_TRANSFER_RES)://其他交易信息 成交公示
                        contents = Fw.DeaSewagePaidTransferResService.FromWhere(DEA_SEWAGE_PAID_TRANSFER_RES._.M_ID == id)
                            .Select(DEA_SEWAGE_PAID_TRANSFER_RES._.NOTICE_CONTENT).ToScalar<string>();
                        break;
                    default:
                        r.SetFail("参数错误");
                        break;
                }
                if (r.Success)
                {
                    r.SetSuccess(new
                    {
                        M_ID = id,
                        Type = type,
                        Contents = contents,
                    });
                }
                return r;
            });
          
            return cacheResult;
        }

        /// <summary>
        /// //获取交易信息内容页面:政府采购
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public object ZFCG_TradeInfo(string id)
        {
            #region 采购/资审公告

            var purchase = Fw.PurchaseQualiInqueryAnnService.FromWhere(PURCHASE_QUALI_INQUERY_ANN._.UNIFIED_DEAL_CODE == id)
                .LeftJoin<T_USER_TRADEPLATFORM>(T_USER_TRADEPLATFORM._.PLATFORM_CODE == PURCHASE_QUALI_INQUERY_ANN._.PLATFORM_CODE)
                .Select(
                    //new Field("采购/资审公告").As("Title"),
                    //new Field("1").As("Type"),
                    PURCHASE_QUALI_INQUERY_ANN._.M_ID,
                    new Field("'PURCHASE_QUALI_INQUERY_ANN'").As("ENTITY_TYPE"),
                    PURCHASE_QUALI_INQUERY_ANN._.PURCHASE_PROJECT_NAME.As("ProjectName"),
                    PURCHASE_QUALI_INQUERY_ANN._.PURCHASE_PROJECT_CODE.As("ProjectCode"),
                    PURCHASE_QUALI_INQUERY_ANN._.URL.As("Url"),
                    //PURCHASE_QUALI_INQUERY_ANN._.BULLETIN_CONTENT.As("Content"),
                    PURCHASE_QUALI_INQUERY_ANN._.M_TM.As("Tm"),
                    PURCHASE_QUALI_INQUERY_ANN._.BULLETIN_START_TIME.As("StartTime"),
                    PURCHASE_QUALI_INQUERY_ANN._.PLATFORM_CODE.As("PlatformCode"),
                    T_USER_TRADEPLATFORM._.SYSTEM_NAME.As("PlatformText")
                ).ToList<object>();

            #endregion

            #region 中标公告

            var dealAnnounce = Fw.BidDealAnnounceService.FromWhere(BID_DEAL_ANNOUNCE._.UNIFIED_DEAL_CODE == id)
                .LeftJoin<T_USER_TRADEPLATFORM>(T_USER_TRADEPLATFORM._.PLATFORM_CODE == BID_DEAL_ANNOUNCE._.PLATFORM_CODE)
                .Select(
                    //new Field("中标公告").As("Title"),
                    //new Field("2").As("Type"),
                    BID_DEAL_ANNOUNCE._.M_ID,
                    new Field("'BID_DEAL_ANNOUNCE'").As("ENTITY_TYPE"),
                    BID_DEAL_ANNOUNCE._.PURCHASE_PROJECT_NAME.As("ProjectName"),
                    BID_DEAL_ANNOUNCE._.PURCHASE_PROJECT_CODE.As("ProjectCode"),
                    BID_DEAL_ANNOUNCE._.URL.As("Url"),
                    //BID_DEAL_ANNOUNCE._.WIN_BID_BULLETIN_CONTENT.As("Content"),
                    BID_DEAL_ANNOUNCE._.M_TM.As("Tm"),
                    BID_DEAL_ANNOUNCE._.WIN_BID_BULLETIN_START_TIME.As("StartTime"),
                    BID_DEAL_ANNOUNCE._.PLATFORM_CODE.As("PlatformCode"),
                    T_USER_TRADEPLATFORM._.SYSTEM_NAME.As("PlatformText")
                ).ToList<object>();

            #endregion

            #region 更正事项

            var correctionItem = Fw.CorrectionItemService.FromWhere(CORRECTION_ITEM._.UNIFIED_DEAL_CODE == id)
                .LeftJoin<T_USER_TRADEPLATFORM>(T_USER_TRADEPLATFORM._.PLATFORM_CODE == CORRECTION_ITEM._.PLATFORM_CODE)
                .Select(
                    //new Field("更正事项").As("Title"),
                    //new Field("4").As("Type"),
                    CORRECTION_ITEM._.M_ID,
                    new Field("'CORRECTION_ITEM'").As("ENTITY_TYPE"),
                    CORRECTION_ITEM._.PURCHASE_PROJECT_NAME.As("ProjectName"),
                    CORRECTION_ITEM._.PURCHASE_PROJECT_CODE.As("ProjectCode"),
                    CORRECTION_ITEM._.URL.As("Url"),
                    //CORRECTION_ITEM._.TERMINATION_BULLETIN_CONTENT.As("Content"),
                    CORRECTION_ITEM._.M_TM.As("Tm"),
                    CORRECTION_ITEM._.MODIFICATION_START_TIME.As("StartTime"),
                    CORRECTION_ITEM._.PLATFORM_CODE.As("PlatformCode"),
                    T_USER_TRADEPLATFORM._.SYSTEM_NAME.As("PlatformText")
                ).ToList<object>();

            #endregion

            #region 采购合同

            var contract = Fw.PurchaseContractService.FromWhere(PURCHASE_CONTRACT._.UNIFIED_DEAL_CODE == id)
                .LeftJoin<T_USER_TRADEPLATFORM>(T_USER_TRADEPLATFORM._.PLATFORM_CODE == PURCHASE_CONTRACT._.PLATFORM_CODE)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "18" && SYS_DIC._.VALUE == PURCHASE_CONTRACT._.PRICE_UNIT)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "4" && SYS_DIC._.VALUE == PURCHASE_CONTRACT._.CURRENCY_CODE)
                .Select(
                    //new Field("采购合同").As("Title"),
                    //new Field("3").As("Type"),
                    PURCHASE_CONTRACT._.PURCHASE_PROJECT_NAME.As("ProjectName"),
                    PURCHASE_CONTRACT._.PURCHASE_PROJECT_CODE.As("ProjectCode"),
                    PURCHASE_CONTRACT._.URL.As("Url"),
                    //PURCHASE_CONTRACT._.TERMINATION_BULLETIN_CONTENT.As("Content"),
                    PURCHASE_CONTRACT._.SIGNING_TIME.As("Tm"),
                    // PURCHASE_CONTRACT._.MODIFICATION_START_TIME.As("StartTime"),
                    PURCHASE_CONTRACT._.PLATFORM_CODE.As("PlatformCode"),
                    PURCHASE_CONTRACT._.PURCHASER_NAME.As("PurchaserName"),
                    PURCHASE_CONTRACT._.SUPPLIER_NAME.As("SupplierName"),
                    PURCHASE_CONTRACT._.CONTRACT_AMOUNT.As("ContractAmount"),
                    SYS_DIC._.TEXT.As("PriceUnitText"),
                    new Field("TEXT", "SYS_DIC2").As("CurrencyCodeText"),
                    T_USER_TRADEPLATFORM._.SYSTEM_NAME.As("PlatformText"),
                    PURCHASE_CONTRACT._.CONTRACT_TERM.As("ContractTerm")
                ).OrderBy(PURCHASE_CONTRACT._.SIGNING_TIME.Desc).ToList<object>();


            #endregion

            #region BaseInfo

            object obj = null;
            var projectName = string.Empty;
            var projectCode = string.Empty;
            var platformText = string.Empty;
            if (purchase.Count > 0)
            {
                obj = purchase.FirstOrDefault();
            }
            else if (dealAnnounce.Count > 0)
            {
                obj = dealAnnounce.FirstOrDefault();
            }
            else if (contract.Count > 0)
            {
                obj = contract.FirstOrDefault();
            }
            else if (correctionItem.Count > 0)
            {
                obj = correctionItem.FirstOrDefault();
            }

            if (obj != null && obj is EntityUtils.FastExpando expando)
            {
                projectName = expando.Data["ProjectName"]?.ToString();
                projectCode = expando.Data["ProjectCode"]?.ToString();
                platformText = expando.Data["PlatformText"]?.ToString();
            }

            #endregion
            return new
            {
                #region BaseInfo

                BaseInfo = new
                {
                    ProjectName = projectName,
                    ProjectCode = projectCode,
                    PlatformText = platformText,
                },

                #endregion

                #region PurchaseAnnounce 采购/资审公告

                PurchaseAnnounce = new
                {
                    Title = "采购/资审公告",
                    Type = 1,
                    Count = purchase.Count,
                    Data = purchase
                },

                #endregion

                #region DealAnnounce 中标公告

                DealAnnounce = new
                {
                    Title = "中标公告",
                    Type = 1,
                    Count = dealAnnounce.Count,
                    Data = dealAnnounce
                },

                #endregion

                #region PurchaseContract 采购合同

                PurchaseContract = new
                {
                    Title = "采购合同",
                    Type = 3,
                    Count = contract.Count,
                    Data = contract
                },

                #endregion

                #region CorrectionItem 更正事项

                CorrectionItem = new
                {
                    Title = "更正事项",
                    Type = 4,
                    Count = correctionItem.Count,
                    Data = correctionItem
                },

                #endregion
            };
        }
        /// <summary>
        /// 获取交易信息内容页面:土地使用权
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public object TDSYQ_TradeInfo(string id)
        {
            #region 出让公示

            var behavior = Fw.DealBehaviorInfoService.FromWhere(DEAL_BEHAVIOR_INFO._.UNIFIED_DEAL_CODE == id)
                .LeftJoin<T_USER_TRADEPLATFORM>(T_USER_TRADEPLATFORM._.PLATFORM_CODE == DEAL_BEHAVIOR_INFO._.PLATFORM_CODE)
                .Select(
                    //new Field("出让公示").As("Title"),
                    //new Field("1").As("Type"),
                    DEAL_BEHAVIOR_INFO._.ANNOUNCEMENT_TITLE,
                    T_USER_TRADEPLATFORM._.SYSTEM_NAME,
                    DEAL_BEHAVIOR_INFO._.M_TM,
                    DEAL_BEHAVIOR_INFO._.PUBLISHING_TIME,
                    DEAL_BEHAVIOR_INFO._.URL,
                    //DEAL_BEHAVIOR_INFO._.ANNOUNCEMENT_CONNECT
                    DEAL_BEHAVIOR_INFO._.M_ID,
                    new Field("'DEAL_BEHAVIOR_INFO'").As("ENTITY_TYPE")
                )
                .OrderBy(DEAL_BEHAVIOR_INFO._.M_TM.Desc && DEAL_BEHAVIOR_INFO._.PUBLISHING_TIME.Desc).ToList<object>();

            #endregion

            #region 成交宗地

            var land = Fw.DealLandInfoService.FromWhere(DEAL_LAND_INFO._.UNIFIED_DEAL_CODE == id)
                .LeftJoin<T_USER_TRADEPLATFORM>(T_USER_TRADEPLATFORM._.PLATFORM_CODE == DEAL_LAND_INFO._.PLATFORM_CODE)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "18" && SYS_DIC._.VALUE == DEAL_LAND_INFO._.PRICE_UNIT)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "4" && SYS_DIC._.VALUE == DEAL_LAND_INFO._.CURRENCY_CODE)
                .Select(
                    //new Field("成交宗地").As("Title"),
                    //new Field("1").As("Type"),
                    DEAL_LAND_INFO._.LAND_PROJECT_NAME,
                    T_USER_TRADEPLATFORM._.SYSTEM_NAME,
                    DEAL_LAND_INFO._.M_TM,
                    DEAL_LAND_INFO._.PUBLISHING_TIME,
                    DEAL_LAND_INFO._.LAND_URL,
                    DEAL_LAND_INFO._.LAND_CODE,
                    DEAL_LAND_INFO._.LAND_USAGE,
                    DEAL_LAND_INFO._.LAND_POSITION,
                    DEAL_LAND_INFO._.DEAL_PRICE,
                    SYS_DIC._.TEXT.As("PriceUnitText"),
                    new Field("TEXT", "SYS_DIC2").As("CurrentyCodeText"),
                    DEAL_LAND_INFO._.LENDING_NAME,
                    DEAL_LAND_INFO._.LAND_BZ,
                    DEAL_LAND_INFO._.LAND_AREA,
                    DEAL_LAND_INFO._.LEND_AGE_LIMIT
                )
                .OrderBy(DEAL_LAND_INFO._.M_TM.Desc && DEAL_LAND_INFO._.PUBLISHING_TIME.Desc).ToList<object>();


            #endregion

            #region BaseInfo

            var projectName = string.Empty;
            var projectCode = string.Empty;
            var platformText = string.Empty;
            if (behavior.Count > 0)
            {
                var obj = behavior.FirstOrDefault();

                if (obj != null && obj is EntityUtils.FastExpando expando)
                {
                    projectName = expando.Data["ANNOUNCEMENT_TITLE"]?.ToString();
                    //projectCode = expando.Data["ProjectCode"]?.ToString();
                    platformText = expando.Data["SYSTEM_NAME"]?.ToString();
                }
            }
            else if (land.Count > 0)
            {
                var obj = land.FirstOrDefault();
                if (obj != null && obj is EntityUtils.FastExpando expando)
                {
                    projectName = expando.Data["LAND_PROJECT_NAME"]?.ToString();
                    //projectCode = expando.Data["ProjectCode"]?.ToString();
                    platformText = expando.Data["SYSTEM_NAME"]?.ToString();
                }
            }


            #endregion

            return new
            {
                #region BaseInfo

                BaseInfo = new
                {
                    ProjectName = projectName,
                    ProjectCode = projectCode,
                    PlatformText = platformText,
                },

                #endregion

                #region 出让公示

                BehaviorInfo = new
                {
                    Title = "出让公示",
                    Type = 1,
                    Count = behavior.Count,
                    Data = behavior,
                },

                #endregion

                #region 成交宗地

                LandInfo = new
                {
                    Title = "成交宗地",
                    Type = 2,
                    Count = land.Count,
                    Data = land
                }

                #endregion
            };
        }
        /// <summary>
        /// 获取交易信息内容页面:矿业权
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public object KYQ_TradeInfo(string id)
        {
            #region 出让公告

            #region 

            //var tkcrgg=Fw.ExplorBidAuctionTransAnnService.FromWhere(EXPLOR_BID_AUCTION_TRANS_ANN._.UNIFIED_DEAL_CODE==id)
            //    .LeftJoin<T_USER_TRADEPLATFORM>(T_USER_TRADEPLATFORM._.PLATFORM_CODE==EXPLOR_BID_AUCTION_TRANS_ANN._.PLATFORM_CODE)
            //    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE=="40"&&SYS_DIC._.VALUE== EXPLOR_BID_AUCTION_TRANS_ANN._.IN_BUY_KIND)
            //    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "8001" && SYS_DIC._.VALUE == EXPLOR_BID_AUCTION_TRANS_ANN._.IN_MINE_COME)
            //    .Select(
            //        EXPLOR_BID_AUCTION_TRANS_ANN._.NA_APP_NAME,
            //        EXPLOR_BID_AUCTION_TRANS_ANN._.PLATFORM_CODE,
            //        EXPLOR_BID_AUCTION_TRANS_ANN._.M_TM,
            //        EXPLOR_BID_AUCTION_TRANS_ANN._.PUBLISHING_TIME,
            //        EXPLOR_BID_AUCTION_TRANS_ANN._.URL,
            //        EXPLOR_BID_AUCTION_TRANS_ANN._.IN_BUY_KIND,
            //        EXPLOR_BID_AUCTION_TRANS_ANN._.IN_MINE_COME,
            //        EXPLOR_BID_AUCTION_TRANS_ANN._.NA_GEOGRAPHY_POSITION,
            //        EXPLOR_BID_AUCTION_TRANS_ANN._.NA_AREA_COORDINATE,
            //        EXPLOR_BID_AUCTION_TRANS_ANN._.QT_PLAN_YEARS,
            //        EXPLOR_BID_AUCTION_TRANS_ANN._.QT_TOTAL_AREA,
            //        T_USER_TRADEPLATFORM._.SYSTEM_NAME.As("PlatformText"),
            //        SYS_DIC._.TEXT.As("InBuyKindText"),
            //        new Field("TEXT","SYS_DIC2").As("InMineComeText")
            //    ).OrderBy(EXPLOR_BID_AUCTION_TRANS_ANN._.M_TM.Asc&& EXPLOR_BID_AUCTION_TRANS_ANN._.PUBLISHING_TIME.Asc).ToList<object>();
            //var ckcrgg = Fw.MiningBidAuctionTransAnnService.FromWhere(MINING_BID_AUCTION_TRANS_ANN._.UNIFIED_DEAL_CODE == id)
            //    .LeftJoin<T_USER_TRADEPLATFORM>(T_USER_TRADEPLATFORM._.PLATFORM_CODE == MINING_BID_AUCTION_TRANS_ANN._.PLATFORM_CODE)
            //    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "40" && SYS_DIC._.VALUE == MINING_BID_AUCTION_TRANS_ANN._.IN_BUY_KIND)
            //    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "8001" && SYS_DIC._.VALUE == MINING_BID_AUCTION_TRANS_ANN._.IN_MINE_COME)
            //    .Select(
            //        MINING_BID_AUCTION_TRANS_ANN._.NA_APP_NAME,
            //        MINING_BID_AUCTION_TRANS_ANN._.PLATFORM_CODE,
            //        MINING_BID_AUCTION_TRANS_ANN._.M_TM,
            //        MINING_BID_AUCTION_TRANS_ANN._.PUBLISHING_TIME,
            //        MINING_BID_AUCTION_TRANS_ANN._.URL,
            //        MINING_BID_AUCTION_TRANS_ANN._.IN_BUY_KIND,
            //        MINING_BID_AUCTION_TRANS_ANN._.IN_MINE_COME,
            //        MINING_BID_AUCTION_TRANS_ANN._.NA_GEOGRAPHY_POSITION,
            //        MINING_BID_AUCTION_TRANS_ANN._.NA_AREA_COORDINATE,
            //        MINING_BID_AUCTION_TRANS_ANN._.QT_PLAN_YEARS,
            //        MINING_BID_AUCTION_TRANS_ANN._.QT_TOTAL_AREA,
            //        T_USER_TRADEPLATFORM._.SYSTEM_NAME.As("PlatformText"),
            //        SYS_DIC._.TEXT.As("InBuyKindText"),
            //        new Field("TEXT", "SYS_DIC2").As("InMineComeText")
            //    ).OrderBy(MINING_BID_AUCTION_TRANS_ANN._.M_TM.Asc && MINING_BID_AUCTION_TRANS_ANN._.PUBLISHING_TIME.Asc).ToList<object>();

            #endregion

            var crgg = FromSql(
                @"select TEMP.*,PLAT.SYSTEM_NAME as PLATFORM_NAME,KDIC.TEXT as IN_BUY_KIND_TEXT,CDIC.TEXT as IN_MINE_COME_TEXT
                        from (                        
                            select '探矿权出让公告' as TITLE,'1' as GGTYPE,NA_APP_NAME as NAME,PLATFORM_CODE,CASE WHEN M_TM IS NOT NULL THEN M_TM ELSE PUBLISHING_TIME END  as TM,URL
                                   ,IN_BUY_KIND,IN_MINE_COME,NA_GEOGRAPHY_POSITION,NA_AREA_COORDINATE
                                   ,case when QT_PLAN_YEARS is null then '' else QT_PLAN_YEARS||'年' end as QT_PLAN_YEARS
                                   ,case when QT_TOTAL_AREA is null then '' else QT_TOTAL_AREA||'平方公里' end as QT_TOTAL_AREA
                            from EXPLOR_BID_AUCTION_TRANS_ANN
                            where UNIFIED_DEAL_CODE=:unifiedDealCode
                            union all
                            select '采矿权出让公告' as TITLE,'1' as GGTYPE,NA_APP_NAME,PLATFORM_CODE,PUBLISHING_TIME,URL
                                   ,IN_BUY_KIND,IN_MINE_COME,NA_GEOGRAPHY_POSITION,NA_AREA_COORDINATE
                                   ,case when QT_PLAN_YEARS is null then '' else QT_PLAN_YEARS||'年' end as QT_PLAN_YEARS
                                   ,case when QT_TOTAL_AREA is null then '' else QT_TOTAL_AREA||'平方公里' end as QT_TOTAL_AREA 
                            from MINING_BID_AUCTION_TRANS_ANN
                            where UNIFIED_DEAL_CODE=:unifiedDealCode                            
                        ) TEMP 
                        left join T_USER_TRADEPLATFORM PLAT on PLAT.PLATFORM_CODE = TEMP.PLATFORM_CODE
                        left join SYS_DIC KDIC on KDIC.TYPE = '40' and KDIC.VALUE = TEMP.IN_BUY_KIND
                        left join SYS_DIC CDIC on CDIC.TYPE = '8001' and CDIC.VALUE = TEMP.IN_MINE_COME                        
                        order by TM desc").AddInParameter(":unifiedDealCode", DbType.AnsiString, id).ToList<object>();

            #endregion

            #region 出让结果
            var crjg = FromSql(@"select TEMP.*,PLAT.SYSTEM_NAME as PLATFORM_NAME,KDIC.TEXT as IN_BUY_KIND_TEXT,SDIC.TEXT as IN_COST_STYLE_TEXT
                        from (                        
                            select '探矿权出让结果' as TITLE,'2' as GGTYPE,NA_APP_NAME as NAME,PLATFORM_CODE,CASE WHEN M_TM IS NOT NULL THEN M_TM ELSE PUBLISHING_TIME END  as TM,URL                            
                                   ,IN_BUY_KIND,NA_GEOGRAPHY_POSITION,NA_AREA_COORDINATE,NA_PUBLIC_BIDDER,BIDDER_CODE,NA_REG_ADDRESS
                                   ,NA_TD_ADDRESS,DT_BUY_DATE,IN_COST_STYLE,DT_COST_DATE
                                   ,case when QT_PLAN_YEARS is null then '' else QT_PLAN_YEARS||'年' end as QT_PLAN_YEARS
                                   ,case when QT_TOTAL_AREA is null then '' else QT_TOTAL_AREA||'平方公里' end as QT_TOTAL_AREA
                                   ,case when QT_PUBLIC_PRICE is null then '' else QT_PUBLIC_PRICE||'万元' end as QT_PUBLIC_PRICE
                            from EXPLOR_BID_AUC_TRANS_RES_ANN
                            where UNIFIED_DEAL_CODE=:unifiedDealCode
                            union all
                            select '采矿权出让结果' as TITLE,'2' as GGTYPE,NA_APP_NAME,PLATFORM_CODE,CASE WHEN M_TM IS NOT NULL THEN M_TM ELSE PUBLISHING_TIME END as TM,URL                            
                                   ,IN_BUY_KIND,NA_GEOGRAPHY_POSITION,NA_AREA_COORDINATE,NA_PUBLIC_BIDDER,BIDDER_CODE,NA_REG_ADDRESS
                                   ,NA_TD_ADDRESS,DT_BUY_DATE,IN_COST_STYLE,DT_COST_DATE
                                   ,case when QT_PLAN_YEARS is null then '' else QT_PLAN_YEARS||'年' end as QT_PLAN_YEARS
                                   ,case when QT_TOTAL_AREA is null then '' else QT_TOTAL_AREA||'平方公里' end as QT_TOTAL_AREA
                                   ,case when QT_PUBLIC_PRICE is null then '' else QT_PUBLIC_PRICE||'万元' end as QT_PUBLIC_PRICE
                            from MINING_BID_AUC_TRANS_RES_ANN
                            where UNIFIED_DEAL_CODE=:unifiedDealCode                            
                        ) TEMP 
                        left join T_USER_TRADEPLATFORM PLAT on PLAT.PLATFORM_CODE = TEMP.PLATFORM_CODE
                        left join SYS_DIC KDIC on KDIC.TYPE = '40' and KDIC.VALUE = TEMP.IN_BUY_KIND                        
                        left join SYS_DIC SDIC on SDIC.TYPE = '3000' and SDIC.VALUE = TEMP.IN_COST_STYLE
                        
                        order by TM desc").AddInParameter(":unifiedDealCode", DbType.AnsiString, id).ToList<object>();


            #endregion

            #region 公开信息

            var gkxx = FromSql(@"select TEMP.*,PLAT.SYSTEM_NAME as PLATFORM_NAME,CDIC.TEXT as IN_MINE_COME_TEXT
                        from (                        
                            select '探矿权公开信息' as TITLE,'3' as GGTYPE,NA_APP_NAME as NAME,PLATFORM_CODE,CASE WHEN M_TM IS NOT NULL THEN M_TM ELSE PUBLISHING_TIME END as TM,URL                            
                                   ,IN_MINE_COME,NA_APPLY_PERSON,APPLY_CODE
                            from EXPLOR_TRANS_PUB_INFO
                            where UNIFIED_DEAL_CODE=:unifiedDealCode
                            union all
                            select '采矿权公开信息' as TITLE,'3' as GGTYPE,NA_APP_NAME,PLATFORM_CODE,CASE WHEN M_TM IS NOT NULL THEN M_TM ELSE PUBLISHING_TIME END as TM,URL                            
                                   ,IN_MINE_COME,NA_APPLY_PERSON,APPLY_CODE
                            from MINING_TRANS_PUB_INFO
                            where UNIFIED_DEAL_CODE=:unifiedDealCode  
                            union all
                            select '划定矿区公开信息' as TITLE,'3' as GGTYPE,NA_APP_NAME,PLATFORM_CODE,CASE WHEN M_TM IS NOT NULL THEN M_TM ELSE PUBLISHING_TIME END as TM,URL                            
                                   ,IN_MINE_COME,NA_APPLY_PERSON,APPLY_CODE
                            from MINING_DISTRICT_RANGE_PUB
                            where UNIFIED_DEAL_CODE=:unifiedDealCode  
                        ) TEMP 
                        left join T_USER_TRADEPLATFORM PLAT on PLAT.PLATFORM_CODE = TEMP.PLATFORM_CODE
                        left join SYS_DIC CDIC on CDIC.TYPE = '8001' and CDIC.VALUE = TEMP.IN_MINE_COME
                        
                        order by TM desc").AddInParameter(":unifiedDealCode", DbType.AnsiString, id).ToList<object>();

            #endregion

            #region 登记公告信息
            var ggxx = FromSql(@"select TEMP.*,PLAT.SYSTEM_NAME as PLATFORM_NAME from (                        
                            select '非油气探矿权登记公告信息' as TITLE,'4' as GGTYPE,NA_ITEM_NAME as NAME,PLATFORM_CODE,CASE WHEN M_TM IS NOT NULL THEN M_TM ELSE PUBLISHING_TIME END as TM,URL                            
                                   ,NA_APPLY_PERSON,APPLY_CODE
                                   ,case when QT_TOTAL_AREA is null then '' else QT_TOTAL_AREA||'平方公里' end as QT_TOTAL_AREA
                            from NON_OIL_GAS_EXPLOR_REG_ANN
                            where UNIFIED_DEAL_CODE=:unifiedDealCode
                            union all
                            select '非油气采矿权登记公告信息' as TITLE,'4' as GGTYPE,NA_MINE_NAME,PLATFORM_CODE,CASE WHEN M_TM IS NOT NULL THEN M_TM ELSE PUBLISHING_TIME END as TM,URL                            
                                   ,NA_APPLY_PERSON,APPLY_CODE
                                   ,case when QT_DIGINGS_AREA is null then '' else QT_DIGINGS_AREA||'平方公里' end as QT_TOTAL_AREA
                            from NON_OIL_GAS_MINING_REG_ANN
                            where UNIFIED_DEAL_CODE=:unifiedDealCode 
                            union all
                            select '油气探矿权登记公告信息' as TITLE,'4' as GGTYPE,NA_ITEM_NAME,PLATFORM_CODE,CASE WHEN M_TM IS NOT NULL THEN M_TM ELSE PUBLISHING_TIME END as TM,URL                            
                                   ,NA_APPLY_PERSON,APPLY_CODE
                                   ,case when QT_TOTAL_AREA is null then '' else QT_TOTAL_AREA||'平方公里' end as QT_TOTAL_AREA
                            from OIL_GAS_EXPLOR_REG_ANN
                            where UNIFIED_DEAL_CODE=:unifiedDealCode
                            union all
                            select '油气采矿权登记公告信息' as TITLE,'4' as GGTYPE,NA_ITEM_NAME,PLATFORM_CODE,CASE WHEN M_TM IS NOT NULL THEN M_TM ELSE PUBLISHING_TIME END as TM,URL                            
                                   ,NA_APPLY_PERSON,APPLY_CODE
                                   ,case when QT_TOTAL_AREA is null then '' else QT_TOTAL_AREA||'平方公里' end as QT_TOTAL_AREA
                            from OIL_GAS_MINING_REG_ANN
                            where UNIFIED_DEAL_CODE=:unifiedDealCode
                        ) TEMP 
                        left join T_USER_TRADEPLATFORM PLAT on PLAT.PLATFORM_CODE = TEMP.PLATFORM_CODE
                        
                        order by TM desc").AddInParameter(":unifiedDealCode", DbType.AnsiString, id).ToList<object>();


            #endregion

            #region 返回结果

            #region BaseInfo

            object obj = null;
            var projectName = string.Empty;
            var projectCode = string.Empty;
            var platformText = string.Empty;
            if (crgg.Count > 0)
            {
                obj = crgg.FirstOrDefault();

            }
            else if (crjg.Count > 0)
            {
                obj = crjg.FirstOrDefault();
            }
            else if (gkxx.Count > 0)
            {
                obj = gkxx.FirstOrDefault();
            }
            else if (ggxx.Count > 0)
            {
                obj = ggxx.FirstOrDefault();
            }

            if (obj != null && obj is EntityUtils.FastExpando expando)
            {
                projectName = expando.Data["NAME"]?.ToString();
                //projectCode = expando.Data["ProjectCode"]?.ToString();
                platformText = expando.Data["PLATFORM_NAME"]?.ToString();
            }

            #endregion

            #region Return

            return new
            {
                BaseInfo = new
                {
                    ProjectName = projectName,
                    ProjectCode = projectCode,
                    PlatformText = platformText,
                },
                TransAnnounce = new
                {
                    Title = "出让公告",
                    Type = 1,
                    crgg.Count,
                    Data = crgg,
                },
                TransResult = new
                {
                    Title = "出让结果",
                    Type = 2,
                    crjg.Count,
                    Data = crjg
                },
                PublishInfo = new
                {
                    Title = "公开信息",
                    Type = 3,
                    gkxx.Count,
                    Data = gkxx.Count
                },
                RegAnnounce = new
                {
                    Title = "登记公告信息",
                    Type = 4,
                    ggxx.Count,
                    Data = ggxx,
                }
            };

            #endregion

            #endregion
        }
        /// <summary>
        /// 获取交易信息内容页面:国有产权
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public object GYCQ_TradeInfo(string id)
        {
            #region 挂牌披露

            var gppl = FromSql(@"select '挂牌披露' as TITLE,'1' as GGTYPE,PROJECT_NAME as NAME,PROJECT_CODE as PROCODE,PLAT.SYSTEM_NAME as PLATFORM_NAME
                                   ,CASE WHEN M_TM IS NOT NULL THEN M_TM ELSE PUBLISH_DATE END  as TM,to_char(PROJECT_URL) as URL
                                   ,to_char(TDIC.TEXT) as PROJECT_TYPE_TEXT,SELLER_NAME,AREA.AREANAME as ZONE_NAME,PROJECT_PRICE,UDIC.TEXT as PRICE_UNIT_TEXT,CDIC.TEXT as CURRENCY_CODE_TEXT
                                   ,PUBLISH_DURATION,PUBLISH_DATE,EDIC.TEXT as PRE_EXCHANGE_TYPE_TEXT,TRANSFER_NOTES
                            from LISTING_PUB_INFO TEMP
                            left join T_USER_TRADEPLATFORM PLAT on PLAT.PLATFORM_CODE = TEMP.PLATFORM_CODE
                            left join SYS_DIC TDIC on TDIC.TYPE = '22' and TDIC.VALUE = TEMP.PROJECT_TYPE
                            left join SYS_DIC EDIC on EDIC.TYPE = '23' and EDIC.value5 like '%实物资产类%' and EDIC.VALUE = TEMP.PRE_EXCHANGE_TYPE
                            left join SYS_AREA_QUANGUO AREA on AREA.AREACODE = TEMP.ZONE
                            left join SYS_DIC UDIC on UDIC.TYPE = '18' and UDIC.VALUE = TEMP.PRICE_UNIT
                            left join SYS_DIC CDIC on CDIC.TYPE = '4' and CDIC.VALUE = TEMP.CURRENCY_CODE
                            where UNIFIED_DEAL_CODE=:unifiedDealCode 
                            union all
                            select '挂牌披露' as TITLE,'1' as GGTYPE,PROJECT_NAME as NAME,PROJECT_CODE as PROCODE,PLAT.SYSTEM_NAME as PLATFORM_NAME
                                   ,CASE WHEN M_TM IS NOT NULL THEN M_TM ELSE PUBLISH_DATE END as TM,to_char(PROJECT_URL) as URL
                                   ,'' as PROJECT_TYPE_TEXT,SELLER_NAME,'' as ZONE_NAME,PROJECT_PRICE,UDIC.TEXT as PRICE_UNIT_TEXT,CDIC.TEXT as CURRENCY_CODE_TEXT
                                   ,PUBLISH_DURATION,PUBLISH_DATE,EDIC.TEXT as PRE_EXCHANGE_TYPE_TEXT,to_clob('')
                            from STOCK_LISTING_PUB_INFO TEMP
                            left join T_USER_TRADEPLATFORM PLAT on PLAT.PLATFORM_CODE = TEMP.PLATFORM_CODE
                            left join SYS_DIC EDIC on EDIC.TYPE = '23' and EDIC.value5 like '%股权类%' and EDIC.VALUE = TEMP.PRE_EXCHANGE_TYPE
                            left join SYS_DIC UDIC on UDIC.TYPE = '18' and UDIC.VALUE = TEMP.PRICE_UNIT
                            left join SYS_DIC CDIC on CDIC.TYPE = '4' and CDIC.VALUE = TEMP.CURRENCY_CODE
                            where UNIFIED_DEAL_CODE=:unifiedDealCode 
                            order by TM desc").AddInParameter(":unifiedDealCode", DbType.AnsiString, id).ToList<object>();

            #endregion

            #region 交易结果
            var jyjg = FromSql(@"select '交易结果' as TITLE,'2' as GGTYPE,PROJECT_NAME as NAME,PROJECT_CODE as PROCODE,PLAT.SYSTEM_NAME as PLATFORM_NAME
                                   ,CASE WHEN M_TM IS NOT NULL THEN M_TM ELSE TRADE_DATE END as TM,PROJECT_URL as URL
                                   ,EDIC.TEXT as EXCHANGE_TYPE_TEXT,SELLER_NAME,OBJECT_EVALUATE_VALUE,TRADE_VALUE
                                   ,UDIC.TEXT as PRICE_UNIT_TEXT,CDIC.TEXT as CURRENCY_CODE_TEXT,TRADE_DATE
                            from TRADE_RESULT_INFO TEMP
                            left join T_USER_TRADEPLATFORM PLAT on PLAT.PLATFORM_CODE = TEMP.PLATFORM_CODE
                            left join SYS_DIC EDIC on EDIC.TYPE = '23' and EDIC.value5 like '%实物资产类%' and EDIC.VALUE = TEMP.EXCHANGE_TYPE
                            left join SYS_DIC UDIC on UDIC.TYPE = '18' and UDIC.VALUE = TEMP.PRICE_UNIT
                            left join SYS_DIC CDIC on CDIC.TYPE = '4' and CDIC.VALUE = TEMP.CURRENCY_CODE
                            where UNIFIED_DEAL_CODE=:unifiedDealCode
                            union all
                            select '交易结果' as TITLE,'2' as GGTYPE,PROJECT_NAME as NAME,PROJECT_CODE as PROCODE,PLAT.SYSTEM_NAME as PLATFORM_NAME
                                   ,CASE WHEN M_TM IS NOT NULL THEN M_TM ELSE TRADE_DATE END as TM,PROJECT_URL as URL
                                   ,EDIC.TEXT as EXCHANGE_TYPE_TEXT,SELLER_NAME,OBJECT_EVALUATE_VALUE,TRADE_VALUE
                                   ,UDIC.TEXT as PRICE_UNIT_TEXT,CDIC.TEXT as CURRENCY_CODE_TEXT,TRADE_DATE
                            from STOCK_TRADE_RESULT_INFO TEMP
                            left join T_USER_TRADEPLATFORM PLAT on PLAT.PLATFORM_CODE = TEMP.PLATFORM_CODE
                            left join SYS_DIC EDIC on EDIC.TYPE = '23' and EDIC.value5 like '%实物资产类%' and EDIC.VALUE = TEMP.EXCHANGE_TYPE
                            left join SYS_DIC UDIC on UDIC.TYPE = '18' and UDIC.VALUE = TEMP.PRICE_UNIT
                            left join SYS_DIC CDIC on CDIC.TYPE = '4' and CDIC.VALUE = TEMP.CURRENCY_CODE
                            where UNIFIED_DEAL_CODE=:unifiedDealCode 
                            order by TM desc").AddInParameter(":unifiedDealCode", DbType.AnsiString, id).ToList<object>();

            #endregion

            #region BaseInfo

            object obj = null;
            var projectName = string.Empty;
            var projectCode = string.Empty;
            var platformText = string.Empty;
            if (gppl.Count > 0)
            {
                obj = gppl.FirstOrDefault();

            }
            else if (jyjg.Count > 0)
            {
                obj = jyjg.FirstOrDefault();
            }

            if (obj != null && obj is EntityUtils.FastExpando expando)
            {
                projectName = expando.Data["NAME"]?.ToString();
                projectCode = expando.Data["PROCODE"]?.ToString();
                platformText = expando.Data["PLATFORM_NAME"]?.ToString();
            }

            #endregion

            #region 返回值

            return new
            {
                BaseInfo = new
                {
                    ProjectName = projectName,
                    ProjectCode = projectCode,
                    PlatformText = platformText,
                },
                PublishInfo = new
                {
                    Title = "挂牌披露",
                    Type = 1,
                    gppl.Count,
                    Data = gppl,
                },
                TradeResult = new
                {
                    Title = "交易结果",
                    Type = 2,
                    jyjg.Count,
                    Data = jyjg
                }
            };

            #endregion
        }
        /// <summary>
        /// 比选公告
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public object BXGG_TradeInfo(string id)
        {
            #region 比选公告

            var gg = FromSql(@"select TEMP.*,PLAT.SYSTEM_NAME as PLATFORM_NAME from (       
                            select '比选公告' as TITLE,'1' as GGTYPE,PROJECT_NAME as NAME,PROJECT_CODE as PROCODE,PLATFORM_CODE,ADD_TIME as TM,URL
                                   ,OWNER_NAME,AGENCY_FEE_STANDARD,case when IS_GOVERNMENT_PLAY='1' then '是' else '否' end as IS_GOVERNMENT_PLAY
                                   ,to_char(APPLICATION_END_TIME,'yyyy-MM-dd HH24:mi') as APPLICATION_END_TIME
                                   ,AGENCY_CONTENT as CONTENT,AGENCY_CONDITION as CONDITION
                            from COMPARE_SELECT_ANN
                            where PROJECT_CODE=:unifiedDealCode
                        ) TEMP 
                        left join T_USER_TRADEPLATFORM PLAT on PLAT.PLATFORM_CODE = TEMP.PLATFORM_CODE
                        
                        order by GGTYPE asc,TM desc").AddInParameter(":unifiedDealCode", DbType.AnsiString, id).ToList<object>();

            #endregion

            #region 比选结果

            var jg = FromSql(@"select TEMP.*,PLAT.SYSTEM_NAME as PLATFORM_NAME from (                                  
                            select '比选结果' as TITLE,'2' as GGTYPE,ANN.PROJECT_NAME,ANN.PROJECT_CODE,A.PLATFORM_CODE,A.ADD_TIME,A.URL
                                   ,ANN.OWNER_NAME,ANN.AGENCY_FEE_STANDARD,case when ANN.IS_GOVERNMENT_PLAY='1' then '是' else '否' end as IS_GOVERNMENT_PLAY
                                   ,to_char(ANN.APPLICATION_END_TIME,'yyyy-MM-dd HH24:mi')
                                   ,CONTENT,to_clob('')
                            from COMPARE_SELECT_RESULT A
                            inner join COMPARE_SELECT_ANN ANN on ANN.M_ID = A.ANNID
                            where PROJECT_CODE=:unifiedDealCode 
                        ) TEMP 
                        left join T_USER_TRADEPLATFORM PLAT on PLAT.PLATFORM_CODE = TEMP.PLATFORM_CODE
                        
                        order by GGTYPE asc,TM desc").AddInParameter(":unifiedDealCode", DbType.AnsiString, id).ToList<object>();

            #endregion

            #region BaseInfo

            object obj = null;
            var projectName = string.Empty;
            var projectCode = string.Empty;
            var platformText = string.Empty;
            if (gg.Count > 0)
            {
                obj = gg.FirstOrDefault();

                if (obj != null && obj is EntityUtils.FastExpando expando)
                {
                    projectName = expando.Data["NAME"]?.ToString();
                    projectCode = expando.Data["PROCODE"]?.ToString();
                    platformText = expando.Data["PLATFORM_NAME"]?.ToString();
                }
            }
            else if (jg.Count > 0)
            {
                obj = jg.FirstOrDefault();
                if (obj != null && obj is EntityUtils.FastExpando expando)
                {
                    projectName = expando.Data["PROJECT_NAME"]?.ToString();
                    projectCode = expando.Data["PROJECT_CODE"]?.ToString();
                    platformText = expando.Data["PLATFORM_NAME"]?.ToString();
                }
            }


            #endregion


            #region 返回值

            return new
            {
                BaseInfo = new
                {
                    ProjectName = projectName,
                    ProjectCode = projectCode,
                    PlatformText = platformText,
                },
                SelectAnnounce = new
                {
                    Title = "必选公告",
                    Type = 1,
                    gg.Count,
                    Data = gg
                },
                SelectResult = new
                {
                    Title = "必选结果",
                    Type = 2,
                    jg.Count,
                    Data = jg
                }
            };

            #endregion
        }
        /// <summary>
        /// 其他
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public object OtherTradeInfo(string id)
        {
            #region 交易公告

            //var gg = FromSql(@"select TEMP.*,PLAT.SYSTEM_NAME as PLATFORM_NAME from (       
            //                select '交易公告' as TITLE,'1' as GGTYPE,PROJECT_NAME as NAME,PROJECT_CODE as PROCODE,PLATFORM_CODE,CASE WHEN M_TM IS NOT NULL THEN M_TM ELSE PUBLISHING_TIME END as TM,URL
            //                       ,ANNOUNCEMENT_TITLE,ANNOUNCEMENT_CONNECT as CONTENT
            //                from OTHER_TRADE_PUB_INFO
            //                where UNIFIED_DEAL_CODE=:unifiedDealCode
            //            ) TEMP 
            //            left join T_USER_TRADEPLATFORM PLAT on PLAT.PLATFORM_CODE = TEMP.PLATFORM_CODE

            //            order by GGTYPE asc,TM desc").AddInParameter(":unifiedDealCode", DbType.AnsiString, id).ToList<object>();
            var gg = FromSql(@"select TEMP.*,PLAT.SYSTEM_NAME as PLATFORM_NAME from (       
                            select '交易公告' as TITLE,'1' as GGTYPE,TO_CHAR(PROJECT_NAME) as NAME,PROJECT_CODE as PROCODE,PLATFORM_CODE,CASE WHEN M_TM IS NOT NULL THEN M_TM ELSE PUBLISHING_TIME END as TM,TO_CHAR(URL) URL
                                   ,TO_CHAR(ANNOUNCEMENT_TITLE) ANNOUNCEMENT_TITLE, M_ID, 'OTHER_TRADE_PUB_INFO' as ENTITY_TYPE
                            from OTHER_TRADE_PUB_INFO
                            where UNIFIED_DEAL_CODE=:unifiedDealCode
                            union all
                            select '交易公告' as TITLE,'1' as GGTYPE,NOTICE_NAME as NAME,PROJECT_CODE as PROCODE,PLATFORM_CODE,CASE WHEN M_TM IS NOT NULL THEN M_TM ELSE NOTICE_SEND_TIME END as TM,URL
                                   ,NOTICE_NAME, M_ID, 'DEA_SEWAGE_PAID_TRANSFER_ANNO' as ENTITY_TYPE
                            from DEA_SEWAGE_PAID_TRANSFER_ANNO
                            where UNIFIED_DEAL_CODEs=:unifiedDealCode
                        ) TEMP 
                        left join T_USER_TRADEPLATFORM PLAT on PLAT.PLATFORM_CODE = TEMP.PLATFORM_CODE
                        
                        order by GGTYPE asc,TM desc").AddInParameter(":unifiedDealCode", DbType.AnsiString, id).ToList<object>();

            #endregion

            #region 成交公示


            //var gs = FromSql(@"select TEMP.*,PLAT.SYSTEM_NAME as PLATFORM_NAME from (  
            //                select '成交公示' as TITLE,'2' as GGTYPE,PROJECT_NAME,PROJECT_CODE,PLATFORM_CODE,CASE WHEN M_TM IS NOT NULL THEN M_TM ELSE PUBLISHING_TIME END as TM,URL
            //                       ,ANNOUNCEMENT_TITLE,ANNOUNCEMENT_CONNECT
            //                from OTHER_TRADE_RESULT_INFO
            //                where UNIFIED_DEAL_CODE=:unifiedDealCode
            //            ) TEMP 
            //            left join T_USER_TRADEPLATFORM PLAT on PLAT.PLATFORM_CODE = TEMP.PLATFORM_CODE

            //            order by GGTYPE asc,TM desc").AddInParameter(":unifiedDealCode", DbType.AnsiString, id).ToList<object>();
            var gs = FromSql(@"select TEMP.*,PLAT.SYSTEM_NAME as PLATFORM_NAME from (  
                            select '成交公示' as TITLE,'2' as GGTYPE,TO_CHAR(PROJECT_NAME) PROJECT_NAME,PROJECT_CODE,PLATFORM_CODE,CASE WHEN M_TM IS NOT NULL THEN M_TM ELSE PUBLISHING_TIME END as TM,TO_CHAR(URL) URL
                                   ,TO_CHAR(ANNOUNCEMENT_TITLE) ANNOUNCEMENT_TITLE,M_ID, 'OTHER_TRADE_RESULT_INFO' as ENTITY_TYPE
                            from OTHER_TRADE_RESULT_INFO
                            where UNIFIED_DEAL_CODE=:unifiedDealCode
                             union all
                            select '成交公示' as TITLE,'2' as GGTYPE,NOTICE_NAME,PROJECT_CODE,PLATFORM_CODE,CASE WHEN M_TM IS NOT NULL THEN M_TM ELSE NOTICE_SEND_TIME END as TM,URL
                                   ,NOTICE_NAME,M_ID, 'DEA_SEWAGE_PAID_TRANSFER_RES' as ENTITY_TYPE
                            from DEA_SEWAGE_PAID_TRANSFER_RES
                            where UNIFIED_DEAL_CODES=:unifiedDealCode 
    
                        ) TEMP 
                        left join T_USER_TRADEPLATFORM PLAT on PLAT.PLATFORM_CODE = TEMP.PLATFORM_CODE
                        
                        order by GGTYPE asc,TM desc").AddInParameter(":unifiedDealCode", DbType.AnsiString, id).ToList<object>();


            #endregion

            #region BaseInfo

            object obj = null;
            var projectName = string.Empty;
            var projectCode = string.Empty;
            var platformText = string.Empty;
            if (gg.Count > 0)
            {
                obj = gg.FirstOrDefault();

                if (obj != null && obj is EntityUtils.FastExpando expando)
                {
                    projectName = expando.Data["NAME"]?.ToString();
                    projectCode = expando.Data["PROCODE"]?.ToString();
                    platformText = expando.Data["PLATFORM_NAME"]?.ToString();
                }

            }
            else if (gs.Count > 0)
            {
                obj = gs.FirstOrDefault();

                if (obj != null && obj is EntityUtils.FastExpando expando)
                {
                    projectName = expando.Data["PROJECT_NAME"]?.ToString();
                    projectCode = expando.Data["PROJECT_CODE"]?.ToString();
                    platformText = expando.Data["PLATFORM_NAME"]?.ToString();
                }
            }

            #endregion

            #region 返回值

            return new
            {
                BaseInfo = new
                {
                    ProjectName = projectName,
                    ProjectCode = projectCode,
                    PlatformText = platformText,
                },
                TradePublishInfo = new
                {
                    Title = "交易公告",
                    Type = 1,
                    gg.Count,
                    Data = gg
                },
                TradeResultInfo = new
                {
                    Title = "成交公示",
                    Type = 2,
                    gs.Count,
                    Data = gs
                }
            };

            #endregion
        }


    }
}