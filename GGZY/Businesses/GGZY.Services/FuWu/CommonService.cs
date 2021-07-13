using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model.FuWu;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class CommonService : BaseServiceT<FwEntity>
    {
        #region 服务平台门户交易统计
        /// <summary>
        /// 有效期内公告统计
        /// </summary>
        /// <returns></returns>
        public object NoticeStat()
        {
            string sql = string.Format(@"with ltemp as
                                            (
                                                select sum(ZBGG) as ZBGG,AREACODE from MV_JYTJ_RANGE group by AREACODE
                                            ),ttemp as
                                            (
                                              select sum(ZBGG) as ZBGG,AREACODE from MV_JYTJ_RANGE
                                              where TM between to_date('{1}','yyyy-mm-dd hh24:mi:ss') and to_date('{0}','yyyy-mm-dd hh24:mi:ss')
                                              group by AREACODE
                                            )
                                        select A.*,nvl(LT.ZBGG,0) as LZBGG,nvl(TT.ZBGG,0) as TZBGG from(
                                            select AREACODE,ORDER_BY,AREANAME from SYS_AREA_QUANGUO SA
                                            where AREACODE like '35__00' or AREACODE = '350128'
                                            order by ORDER_BY
                                        ) A
                                        left join ltemp LT on LT.AREACODE=A.AREACODE
                                        left join ttemp TT on TT.AREACODE=A.AREACODE
                                        order by ORDER_BY", DateTime.Now, DateTime.Now.AddDays(-1));
            var dt = ToDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                var qAREANAME = dt.AsEnumerable().Select(c => c.Field<string>("AREANAME")).Distinct().ToList();//;(from v in dt.AsEnumerable()select v.Field<string>("AREANAME")).Distinct().ToList();
                qAREANAME[0] = "省本级";
                var ldata = dt.AsEnumerable().Select(c => c.Field<decimal>("LZBGG")).ToList();//(from v in dt.AsEnumerable()select v.Field<Decimal>("LZBGG")).ToList();
                var tdata = dt.AsEnumerable().Select(c => c.Field<decimal>("TZBGG")).ToList();//(from v in dt.AsEnumerable()select v.Field<Decimal>("TZBGG")).ToList();
                return new
                {
                    Area = qAREANAME,
                    Last = ldata,
                    Today = tdata,
                };
            }

            var emptyList = new List<object>();
            return new
            {
                Area = emptyList,
                Last = emptyList,
                Today = emptyList,
            };
        }
        /// <summary>
        /// 获取交易统计页面--2.全省各地市交易量对比
        /// 1.分别多年、月、日进行统计，先按类型、地区进行分组统计
        /// 2.在作为地区的左链接，依次得到每个地区的公告数量
        /// </summary>
        public object RegionTradeStat()
        {
            DateTime time = DateTime.Now;
            string sql = string.Format(@"with ytemp as
                                            (
                                                select sum(ZBGG) as ZBGG,PROTYPE,AREACODE from MV_JYTJ_ALL
                                                where TM between to_date('{1}','yyyy-mm-dd hh24:mi:ss') and to_date('{0}','yyyy-mm-dd hh24:mi:ss')
                                                group by PROTYPE,AREACODE
                                            ),mtemp as
                                            (
                                                select sum(ZBGG) as ZBGG,PROTYPE,AREACODE from MV_JYTJ_ALL
                                                where TM between to_date('{2}','yyyy-mm-dd hh24:mi:ss') and to_date('{0}','yyyy-mm-dd hh24:mi:ss')
                                                group by PROTYPE,AREACODE
                                            ),dtemp as
                                            (
                                                select sum(ZBGG) as ZBGG,PROTYPE,AREACODE from MV_JYTJ_ALL
                                                where TM between to_date('{3}','yyyy-mm-dd hh24:mi:ss') and to_date('{0}','yyyy-mm-dd hh24:mi:ss')
                                                group by PROTYPE,AREACODE
                                            )
                                        select A.*,nvl(YT.ZBGG,0) as YZBGG,nvl(MT.ZBGG,0) as MZBGG,nvl(DT.ZBGG,0) as DZBGG 
                                        from(
                                            select SDT.TEXT as TYPE_TEXT,SDT.VALUE as TYPE_VAL,AREACODE,ORDER_BY,AREANAME
                                            from SYS_AREA_QUANGUO SA
                                            ,(select TEXT,VALUE from SYS_DIC where type='9017' order by ORDER_ID) SDT
                                            where AREACODE like '35__00' or AREACODE = '350128'
                                            order by TYPE_VAL,AREACODE
                                        ) A
                                        left join ytemp YT on YT.AREACODE=A.AREACODE and YT.PROTYPE=A.TYPE_VAL
                                        left join mtemp MT on MT.AREACODE=A.AREACODE and MT.PROTYPE=A.TYPE_VAL
                                        left join dtemp DT on DT.AREACODE=A.AREACODE and DT.PROTYPE=A.TYPE_VAL                                           
                                        order by TYPE_VAL,ORDER_BY", time, new DateTime(time.Year, 1, 1), time.AddDays(1 - time.Day), time.AddDays(-1));

            DataTable dt = ToDataTable(sql);

            Dictionary<string, object> YAREACODE = new Dictionary<string, object>();
            Dictionary<string, object> MAREACODE = new Dictionary<string, object>();
            Dictionary<string, object> DAREACODE = new Dictionary<string, object>();
            var qAREANAME = new List<string>();
            object qTYPE = new object();
            if (dt != null && dt.Rows.Count > 0)
            {
                var enumerable = dt.AsEnumerable();
                qAREANAME = enumerable.Select(c => c.Field<string>("AREANAME")).Distinct().ToList();
                qAREANAME[0] = "省本级";
                var qTYPEVAL = enumerable.Select(c => c.Field<string>("TYPE_VAL")).Distinct().ToList();
                qTYPE = enumerable.Select(c => new
                {
                    TEXT = c.Field<string>("TYPE_TEXT"),
                    VALUE = c.Field<string>("TYPE_VAL")
                }).Distinct().ToList();

                for (int i = 0, l = qTYPEVAL.Count; i < l; i++)
                {
                    var queryable = enumerable.Where(c => c.Field<string>("TYPE_VAL") == qTYPEVAL[i]);
                    //统计全部类型 -1
                    if (qTYPEVAL[i] == "-1")
                    {
                        var ysdata = queryable.Select(c => c.Field<Decimal>("YSZBGG"));
                        var msdata = queryable.Select(c => c.Field<Decimal>("MSZBGG"));
                        var dsdata = queryable.Select(c => c.Field<Decimal>("DSZBGG"));
                        YAREACODE.Add(qTYPEVAL[i], ysdata.ToList());
                        MAREACODE.Add(qTYPEVAL[i], msdata.ToList());
                        DAREACODE.Add(qTYPEVAL[i], dsdata.ToList());
                    }
                    else//各个类型
                    {
                        var ydata = queryable.Select(c => c.Field<Decimal>("YZBGG"));
                        var mdata = queryable.Select(c => c.Field<Decimal>("MZBGG"));
                        var ddata = queryable.Select(c => c.Field<Decimal>("DZBGG"));
                        YAREACODE.Add(qTYPEVAL[i], ydata.ToList());
                        MAREACODE.Add(qTYPEVAL[i], mdata.ToList());
                        DAREACODE.Add(qTYPEVAL[i], ddata.ToList());
                    }
                }
            }
            return new
            {
                Type = qTYPE,
                Area = qAREANAME,
                Year = YAREACODE,
                Month = MAREACODE,
                Day = DAREACODE,
            };
        }

        /// <summary>
        /// 获取交易统计页面--3.全省各类型交易量统计
        /// </summary>
        public object TradeTypeStat()
        {
            DateTime time = DateTime.Now;
            string sql = string.Format(@"with ytemp as
                                            (
                                              select sum(ZBGG) as ZBGG,AREACODE,PROTYPE from MV_JYTJ_ALL
                                              where TM between to_date('{1}','yyyy-mm-dd hh24:mi:ss') and to_date('{0}','yyyy-mm-dd hh24:mi:ss')
                                              group by AREACODE,PROTYPE
                                            ),mtemp as
                                            (
                                              select sum(ZBGG) as ZBGG,AREACODE,PROTYPE from MV_JYTJ_ALL
                                              where TM between to_date('{2}','yyyy-mm-dd hh24:mi:ss') and to_date('{0}','yyyy-mm-dd hh24:mi:ss')
                                              group by AREACODE,PROTYPE
                                            ),dtemp as
                                            (
                                              select sum(ZBGG) as ZBGG,AREACODE,PROTYPE from MV_JYTJ_ALL
                                              where TM between to_date('{3}','yyyy-mm-dd hh24:mi:ss') and to_date('{0}','yyyy-mm-dd hh24:mi:ss')
                                              group by AREACODE,PROTYPE
                                            )
                                        select A.*,nvl(YT.ZBGG,0) as YZBGG,nvl(MT.ZBGG,0) as MZBGG,nvl(DT.ZBGG,0) as DZBGG from(
                                            select AREACODE,ORDER_BY,SDT.TEXT as TYPE_TEXT,SDT.VALUE as TYPE_VAL
                                            from SYS_AREA_QUANGUO SA
                                            ,(select TEXT,VALUE from SYS_DIC where type='9017' order by ORDER_ID) SDT
                                            where AREACODE like '35__00' or AREACODE = '350128'
                                        ) A
                                        left join ytemp YT on YT.AREACODE=A.AREACODE and YT.PROTYPE=A.TYPE_VAL
                                        left join mtemp MT on MT.AREACODE=A.AREACODE and MT.PROTYPE=A.TYPE_VAL
                                        left join dtemp DT on DT.AREACODE=A.AREACODE and DT.PROTYPE=A.TYPE_VAL                                        
                                        order by ORDER_BY,TYPE_VAL", time, new DateTime(time.Year, 1, 1), time.AddDays(1 - time.Day), time.AddDays(-1));

            DataTable dt = ToDataTable(sql);

            Dictionary<string, object> YAREACODE = new Dictionary<string, object>();
            Dictionary<string, object> MAREACODE = new Dictionary<string, object>();
            Dictionary<string, object> DAREACODE = new Dictionary<string, object>();
            var qTYPE = new List<string>();
            if (dt != null && dt.Rows.Count > 0)
            {
                var enumerable = dt.AsEnumerable();
                var qAREACODE = enumerable.Select(c => c.Field<string>("AREACODE")).Distinct().ToList();
                qTYPE = enumerable.Select(c => c.Field<string>("TYPE_TEXT")).Distinct().ToList();

                foreach (var qa in qAREACODE)
                {
                    List<Dictionary<string, object>> ylist = new List<Dictionary<string, object>>();
                    List<Dictionary<string, object>> mlist = new List<Dictionary<string, object>>();
                    List<Dictionary<string, object>> dlist = new List<Dictionary<string, object>>();
                    
                    for (int i = 0, l = qTYPE.Count; i < l; i++)
                    {
                        var data = enumerable.Where(c => c.Field<string>("AREACODE") == qa && c.Field<string>("TYPE_TEXT") == qTYPE[i])
                                   .Select(v => new
                                   {
                                       YZBGG = v.Field<Decimal>("YZBGG"),
                                       MZBGG = v.Field<Decimal>("MZBGG"),
                                       DZBGG = v.Field<Decimal>("DZBGG")
                                   });
                       
                        Dictionary<string, object> YTYPE = new Dictionary<string, object>();
                        Dictionary<string, object> MTYPE = new Dictionary<string, object>();
                        Dictionary<string, object> DTYPE = new Dictionary<string, object>();
                        YTYPE.Add("name", qTYPE[i]);
                        YTYPE.Add("value", data.ToList()[0].YZBGG);
                        ylist.Add(YTYPE);
                        MTYPE.Add("name", qTYPE[i]);
                        MTYPE.Add("value", data.ToList()[0].MZBGG);
                        mlist.Add(MTYPE);
                        DTYPE.Add("name", qTYPE[i]);
                        DTYPE.Add("value", data.ToList()[0].DZBGG);
                        dlist.Add(DTYPE);
                    }
                    YAREACODE.Add(qa, ylist);
                    MAREACODE.Add(qa, mlist);
                    DAREACODE.Add(qa, dlist);
                }
            }

            return new
            {
                Type = qTYPE,
                Year = YAREACODE,
                Month = MAREACODE,
                Day = DAREACODE,
            };
        }

        /// <summary>
        /// 近一年交易走势统计
        /// </summary>
        /// <returns></returns>
        public object LastYearTradeTrendStat()
        {
            string sql = string.Format(@"with temp as
                                            (
                                                select sum(ZBGG) as ZBGG,AREACODE,PROTYPE,TO_CHAR(TM, 'mm') as TIME_MON from MV_JYTJ_ALL
                                                where TM between to_date('{0}','yyyy-mm-dd hh24:mi:ss') and to_date('{1}','yyyy-mm-dd hh24:mi:ss')
                                                group by AREACODE,PROTYPE,TO_CHAR(TM, 'mm')
                                            )
                                        select A.*,nvl(T.ZBGG,0) as ZBGG from(
                                            select AREACODE,ORDER_BY,SDT.TEXT as TYPE_TEXT,SDT.VALUE as TYPE_VAL,SDM.TEXT as MON
                                            from SYS_AREA_QUANGUO SA
                                            ,(select TEXT,VALUE from SYS_DIC where type='9017' order by ORDER_ID) SDT
                                            ,(select TEXT,VALUE from SYS_DIC where type='9015') SDM
                                            where AREACODE like '35__00' or AREACODE = '350128'
                                        ) A
                                        left join temp T on T.AREACODE=A.AREACODE and T.PROTYPE=A.TYPE_VAL and T.TIME_MON=A.MON                                        
                                        order by ORDER_BY,TYPE_VAL,MON", DateTime.Now.AddYears(-1), DateTime.Now);

            DataTable dt = ToDataTable(sql);
            var qTYPE = new List<string>();
            Dictionary<string, object> AREACODE = new Dictionary<string, object>();
            if (dt != null && dt.Rows.Count > 0)
            {
                var enumerable = dt.AsEnumerable();
                var qAREACODE = enumerable.Select(c => c.Field<string>("AREACODE")).Distinct().ToList();
                qTYPE = enumerable.Select(c => c.Field<string>("TYPE_TEXT")).Distinct().ToList();

                foreach (var qa in qAREACODE)
                {
                    List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
                    for (int i = 0, l = qTYPE.Count; i < l; i++)
                    {
                        var data = enumerable.Where(v => v.Field<string>("AREACODE") == qa && v.Field<string>("TYPE_TEXT") == qTYPE[i])
                            .Select(c => c.Field<Decimal>("ZBGG")).ToList();

                        Dictionary<string, object> TYPE = new Dictionary<string, object> { { qTYPE[i], data } };
                        list.Add(TYPE);
                    }
                    AREACODE.Add(qa, list);
                }
            }

            return new
            {
                Type = qTYPE,
                Data = AREACODE
            };
        }
        /// <summary>
        /// 医疗药品走势统计
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public object MedicalDrugsTrendStat(SearchCondition condition)
        {
            string sql = string.Format(@"with
                  TM as(
                      SELECT TRUNC(min(daylist),'dd') as TM from(
                          SELECT TRUNC(to_date('{0}','yyyy-MM-dd HH24:mi:ss'))+ROWNUM-1 as daylist FROM DUAL  
                              CONNECT BY ROWNUM<=trunc(
                                   to_date('{1}','yyyy-MM-dd HH24:mi:ss')
                                  -to_date('{0}','yyyy-MM-dd HH24:mi:ss')
                              )+1  
                      )
                      group by trunc(daylist,'dd')
                  ),
                  VAL as(
                      select TRUNC(min(JY_DATE),'dd') as TM,sum(FHJE) as FHJE,sum(CPZS) as CPZS,sum(YLJG) as YLJG,sum(SCQY) as SCQY,sum(PSQY) as PSQY
                      from T_MEDICAL_TOTLE
                      WHERE JY_DATE between to_date('{0}','yyyy-mm-dd hh24:mi:ss') and to_date('{1}','yyyy-mm-dd hh24:mi:ss')
                      group by trunc(JY_DATE,'dd')
                  )
                  select to_char(TM.TM,'yyyy-MM-dd') as TM,ROUND(nvl(FHJE,0),2) as FHJE,nvl(CPZS,0) as CPZS,nvl(YLJG,0) as YLJG,nvl(SCQY,0) as SCQY,nvl(PSQY,0) as PSQY
                  from TM
                  left join VAL on trunc(VAL.TM) = trunc(TM.TM)
                  order by TM", condition.BeginTime.Value, condition.EndTime.Value);
            DataTable dt = ToDataTable(sql);
            var result = new Dictionary<string, object>();
            if (dt != null && dt.Rows.Count > 0)
            {
                var enumerable = dt.AsEnumerable();
                foreach (DataColumn column in dt.Columns)
                {
                    var lst = enumerable.Select(c => c.Field<object>(column.ColumnName)).ToList();
                    result.Add(column.ColumnName, lst);
                }
            }

            return result;
        }
        #endregion

        #region 服务平台门户 全文检索

        public object KeywordSearch(SearchCondition search)
        {
            switch (search.Type)
            {
                case "2"://招标公告
                    var notices = Fw.TenderAnnQuaInqueryAnnService.NoticeKeywordSearch(search);
                    return notices;
                case "3"://新闻类型
                    var articles = Fw.PtArticleService.NewsKeywordSearch(search);
                    return articles;
                case "4"://主体资信
                    var legalPersons = Fw.LegalPersonBaseService.LegalPersonKeywordSearch(search);
                    return legalPersons;
            }

            var noticesCon = new WhereClipBuilder(TENDER_ANN_QUA_INQUERY_ANN._.BULLETIN_TYPE.In("1", "2")
                                                  && (TENDER_ANN_QUA_INQUERY_ANN._.M_STATUS.IsNull() || TENDER_ANN_QUA_INQUERY_ANN._.M_STATUS == 2));
            var newsCon = new WhereClipBuilder();
            var legalCon = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(search.KeyWord))
            {
                noticesCon.And(TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_NAME.Contain(search.KeyWord));
                newsCon.And(PT_ARTICLE._.TITLE.Contain(search.KeyWord));
                legalCon.And(LEGAL_PERSON_BASE._.LEGAL_NAME.Contain(search.KeyWord));
            }
            if (search.BeginTime.HasValue)
            {
                noticesCon.And(TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME >= search.BeginTime.Value);
                newsCon.And(PT_ARTICLE._.TM >= search.BeginTime.Value);
            }
            if (search.EndTime.HasValue)
            {
                noticesCon.And(TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME >= search.EndTime.Value);
                newsCon.And(PT_ARTICLE._.TM <= search.EndTime.Value);
            }
            if (search.BeginTime.HasValue && search.EndTime.HasValue)
            {
                legalCon.And(LEGAL_PERSON_BASE._.M_IS_HISTORY == 0);
            }

            var count = FromWhere<TENDER_ANN_QUA_INQUERY_ANN>(noticesCon.ToWhereClip()).Select(TENDER_ANN_QUA_INQUERY_ANN._.M_ID)
                .UnionAll(FromWhere<PT_ARTICLE>(newsCon.ToWhereClip()).Select(PT_ARTICLE._.ID))
                .UnionAll(FromWhere<LEGAL_PERSON_BASE>(legalCon.ToWhereClip()).Select(LEGAL_PERSON_BASE._.M_ID))
                .Count();

            var pageList = FromWhere<TENDER_ANN_QUA_INQUERY_ANN>(noticesCon.ToWhereClip())
                .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE && TENDER_PROJECT._.REGION_CODE.IsNotNull() && TENDER_PROJECT._.TENDER_PROJECT_TYPE.IsNotNull())
                .Select(
                    TENDER_ANN_QUA_INQUERY_ANN._.M_ID.As("Id"),
                    TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_NAME.As("Title"),
                    TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME.As("Tm"),
                    new Field("'GCJS'").As("Kind")
                    )
                .UnionAll(FromWhere<PT_ARTICLE>(newsCon.ToWhereClip())
                    .Select(
                        PT_ARTICLE._.ID.As("Id"),
                        PT_ARTICLE._.TITLE.As("Title"),
                        PT_ARTICLE._.TM.As("Tm"),
                        new Field("'NEWS'").As("Kind")
                    ))
                .UnionAll(FromWhere<LEGAL_PERSON_BASE>(legalCon.ToWhereClip()).Select(
                    LEGAL_PERSON_BASE._.M_ID.As("Id"),
                    LEGAL_PERSON_BASE._.LEGAL_NAME.As("Title"),
                    LEGAL_PERSON_BASE._.DATA_TIMESTAMP.As("Tm"),
                    new Field("'LEGALPERSON'").As("Kind")
                ))
                .OrderBy(new Field("Tm").Desc)
                .Page(search.PageSize, search.PageNo).ToList<PortalSearchModel>().ToPageTableResult(search, count);
            return pageList;

        }

        public object SearchDetail(string id, string roleType = "01")
        {
            var baseInfo = Fw.LegalPersonBaseService.LegalPersonBaseInfo(id, roleType);
            var search = new SearchCondition();
            var illegal = search.ToPageTableResult();
            var blackList = search.ToPageTableResult();

            search.KeyWord = baseInfo?.LEGAL_CODE;
            if (baseInfo != null)
            {
                illegal = Fw.ViolatingLawsRulesInfoService.FindViolatingLawsRulesInfoPageListByLegalCode(search);
                blackList = Fw.BlackListService.FindBlackListByLegalCode(search);
            }

            var ext = ExtInfo(search, roleType);
            return new
            {
                BaseInfo = baseInfo,
                ExInfo = ext,
                Illegal = illegal,
                BlackList = blackList,
            };
        }
        /// <summary>
        /// 资质信息
        /// </summary>
        /// <param name="search"></param>
        /// <param name="roleType"></param>
        /// <returns></returns>
        public PageTableResult ExtInfo(SearchCondition search, string roleType)
        {
            var ext = search.ToPageTableResult();
            //有社会公开字段：02.招标代理机构、03.投标人、06.供应商
            //没有社会公开字段：01.招标人、04.采购人、05.采购代理机构、07.出让人、08.受让人、09.竞得人、99.平台机构
            switch (roleType)
            {
                case "2"://招标代理机构
                case "02"://招标代理机构
                    ext = Fw.TenderAgentExInfoService.FindTenderAgentExInfoByBodyCode(search);break;
                case "3"://投标人
                case "03"://投标人
                    ext = Fw.TendererExInfoService.FindTendererExInfoByBodyCode(search); break;
                case "6"://供应商
                case "06"://供应商
                    ext = Fw.SupplierExInfoService.FindSupplierExInfoByBodyCode(search); break;
            }

            return ext;
        }
        #endregion

        #region 通用附件处理

        public string Attachment(string id, string type = "")
        {
            return Attachments(id, type).FirstOrDefault()?.FullUrl;
        }

        /// <summary>
        /// 读取附件信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<UploadResData> Attachments(string id, string type = "",Func<string,string,string>attachmentFun=null)
        {
#pragma warning disable CS0219 // 变量“extensions”已被赋值，但从未使用过它的值
            var extensions = "pdf,jpg,jpeg,png,bmp,gif,txt,html";
#pragma warning restore CS0219 // 变量“extensions”已被赋值，但从未使用过它的值
            var ls = new List<UploadResData>();
            if (!string.IsNullOrWhiteSpace(id))
            {
                var ids = id.Split(',').Where(c => !string.IsNullOrWhiteSpace(c)).Select(c=>c.Split('.').FirstOrDefault()).ToList();
                if (ids.Any())
                {
                    if (string.Compare(type, "sys", StringComparison.CurrentCultureIgnoreCase) == 0)
                    {
                        ls = Fw.SysAttachmentService.FindList(SYS_ATTACHMENT._.AID.In(ids))
                            //.FindAll(c=>c.FILEPATH.EndsWith("pdf"))
                            //.FindAll(c => c.AOBJTYPE == SYS_ATTACHMENT.FILE_CENTER || File.Exists(HttpContext.Current?.Server.MapPath($"~/{c.FILEPATH}")))
                            .Select(c =>
                            {
                                var path = c.FILEPATH;
                                if (c.AOBJTYPE == SYS_ATTACHMENT.FILE_CENTER)
                                {
                                    path = $"{ConfigHelper.AppSettings.UploadHost}{c.FILEPATH}";
                                }
                                else if (File.Exists(HttpContext.Current?.Server.MapPath($"~/{c.FILEPATH}")))
                                {
                                    path = HttpContext.Current?.Server.MapPath($"~/{c.FILEPATH}");
                                    if (attachmentFun != null)
                                    {
                                        path = attachmentFun.Invoke(type,c.AID?.ToString());
                                    }
                                }

                                var res = new UploadResData
                                {
                                    Id = c.AID?.ToString(),
                                    new_id = c.AID?.ToString(),
                                    FullUrl = path,
                                    Md5 = String.Empty,
                                    Url = c.FILEPATH,
                                    Name = c.FILETILE,
                                    FileType=c.FILETYPE,
                                };

                                return res;
                            }).ToList();
                    }
                    else
                    {
                        ls = Fw.TAttachmentService.FindList(T_ATTACHMENT._.ID.In(ids))
                            //.FindAll(c => File.Exists(HttpContext.Current?.Server.MapPath($"~/file/{c.ATTACHMENT_FILE_NAME}")))
                            .Select(c =>
                            {
                                var attachmentFileName = c.ATTACHMENT_FILE_NAME.TrimStart('/');
                                var path = HttpContext.Current?.Server.MapPath($"~/file/{attachmentFileName}");
                                if (!File.Exists(path))
                                {
                                    path = HttpContext.Current?.Server.MapPath($"~/{attachmentFileName}");
                                    if (!File.Exists(path))
                                    {
                                        path = $"{ConfigHelper.AppSettings.GgzyfwFileUrl}/{attachmentFileName}";
                                    }
                                }

                                if (attachmentFun != null &&!string.IsNullOrWhiteSpace(path)&& !path.StartsWith("http"))
                                {
                                    path = attachmentFun.Invoke(type, c.ID?.ToString());
                                }
                                var res = new UploadResData
                                {
                                    Id = c.ID?.ToString(),
                                    new_id = c.ID?.ToString(),
                                    FullUrl = path,
                                    Md5 = c.MD5,
                                    Url = c.ATTACHMENT_FILE_NAME,
                                    Name = c.ATTACHMENT_NAME,
                                    FileType = c.ATTACHMENT_TYPE,
                                };

                                return res;

                            }).ToList();
                    }
                }
            }
            return ls;
        }


        ///// <summary>
        ///// 交易详情附件
        ///// </summary>
        ///// <param name="ids"></param>
        ///// <returns></returns>
        //protected List<UploadResData> TradeDetailAttachments(string ids)
        //{
        //    var files = new List<UploadResData>();
        //    var paths = Fw.CommonService.Attachments(ids);
        //    if (paths != null && paths.Any())
        //    {
        //        files = paths.Select(c => new UploadResData
        //        {
        //            Name = c.FileName(),
        //            FullUrl = c
        //        }).ToList();
        //    }
        //    return files;
        //}

        #endregion

        #region 福建今日公告数量

        /// <summary>
        /// 福建今日公告数量
        /// </summary>
        /// <param name="areaCode"></param>
        /// <returns></returns>
        public object NoticeCount(string areaCode)
        {
            var sb = new StringBuilder(@"select 
        sum(case when  m ='五、工程建设项目招标投标' and type='1' then nvl(amount,0) else 0 end) as ZBZSGG
        ,sum(case when  m ='五、工程建设项目招标投标' and type='2' then amount else 0 end ) as JYJGGS
        ,sum(case when  m = '六、政府采购共享交换数据标准'and type='1' then amount else 0 end) as CAZSGG
        ,sum(case when  m = '六、政府采购共享交换数据标准'and type='2' then amount else 0 end) as ZBGG
        ,sum(case when  m = '七、土地使用权共享交换数据标准'and type='1' then amount else 0 end) as CRGS
        ,sum(case when  m = '七、土地使用权共享交换数据标准'and type='2' then amount else 0 end) as CJZD
        ,sum(case when  m = '八、矿业权出让共享交换数据标准'and type='1' then amount else 0 end) as CRGG
        ,sum(case when  m = '八、矿业权出让共享交换数据标准'and type='2' then amount else 0 end) as CRJG
        ,sum(case when  m = '国有产权共享交换数据标准'and type='1' then amount else 0 end) as GPPL
        ,sum(case when  m = '国有产权共享交换数据标准'and type='2' then amount else 0 end) as JYJG
        ,sum(case when  m = '其它交易类型'and type='1' then amount else 0 end) as JYGG
       ,sum(case when  m = '其它交易类型'and type='2' then amount else 0 end) as JYGS
from MV_NOTICE_COUNT a inner join T_USER_TRADEPLATFORM b on a.platform_code=b.platform_code");
            if (string.IsNullOrWhiteSpace(areaCode))
            {
                return FromSql(sb.ToString()).ToFirst<object>();
            }
            sb.Append(" And b.AREACODE=:regioncode");
            return FromSql(sb.ToString()).AddInParameter(":regioncode", DbType.AnsiString, areaCode).ToFirst<object>();
        }

        #endregion
    }
}