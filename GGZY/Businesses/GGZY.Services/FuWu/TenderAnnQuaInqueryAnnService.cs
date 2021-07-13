using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Infrastructure.Model.FuWu;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TenderAnnQuaInqueryAnnService
    {
        /// <summary>
        /// 服务平台门户 全文检索 招标公告
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public object NoticeKeywordSearch(SearchCondition search)
        {
            var condition = new WhereClipBuilder();
            condition.And(TENDER_ANN_QUA_INQUERY_ANN._.BULLETIN_TYPE.In("1", "2")
            && (TENDER_ANN_QUA_INQUERY_ANN._.M_STATUS.IsNull() || TENDER_ANN_QUA_INQUERY_ANN._.M_STATUS == 2));
            if (!string.IsNullOrWhiteSpace(search.KeyWord))
            {
                condition.And(TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_NAME.Contain(search.KeyWord));
            }
            if (search.BeginTime.HasValue)
            {
                condition.And(TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME >= search.BeginTime.Value);
            }

            if (search.EndTime.HasValue)
            {
                condition.And(TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME >= search.EndTime.Value);
            }
            var count = Count(condition);
            var pageList = FromWhere(condition.ToWhereClip())
                .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE && TENDER_PROJECT._.REGION_CODE.IsNotNull() && TENDER_PROJECT._.TENDER_PROJECT_TYPE.IsNotNull())
                .OrderBy(TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME.Desc)
                .Page(search.PageSize, search.PageNo)
                .Select(
                    TENDER_ANN_QUA_INQUERY_ANN._.M_ID.As("Id"),
                    TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_NAME.As("Title"),
                    TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME.As("Tm"),
                    new Field("'GCJS'").As("Kind")
                )
                .ToList<object>().ToPageTableResult(search, count);

            return pageList;

        }


        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 项目进场 标段信息
        /// </summary>
        /// <param name="projectCode"></param>
        /// <param name="attachmentFunc">门户网站不展示附件null 后台展示附件 </param>
        /// <returns></returns>
        public dynamic JD_GCJS_TenderAnnQuaInqueryAnn(string projectCode, Func<string, List<UploadResData>> attachmentFunc = null)
        {
            var sqlBuilder = new StringBuilder(@"
                SELECT T.M_ID,
                       NOTICE_NAME,
                       NOTICE_CONTENT,
                       TO_CHAR(NOTICE_SEND_TIME,'yyyy-mm-dd hh24:mi:ss')       AS NOTICE_SEND_TIME,
                       NOTICE_NATURE,
                       BULLETIN_TYPE,
                       TO_CHAR(DOC_GET_START_TIME,'yyyy-mm-dd hh24:mi:ss')     AS DOC_GET_START_TIME,
                       TO_CHAR(DOC_GET_END_TIME,'yyyy-mm-dd hh24:mi:ss')       AS DOC_GET_END_TIME,
                       TENDER_DOC_GET_METHOD,
                       TO_CHAR(BID_DOC_REFER_END_TIME,'yyyy-mm-dd hh24:mi:ss') AS BID_DOC_REFER_END_TIME,
                       TO_CHAR(BID_OPEN_TIME,'yyyy-mm-dd hh24:mi:ss')          AS BID_OPEN_TIME,
                       DOC_PRICE,
                       T4.TEXT                AS DOC_PRICE_UNIT,
                       BID_DOC_REFER_METHOD,
                       SYNDICATED_FLAG,
                       NOTICE_MEDIA,
                       URL, 
                       M_ATT_TENDER_NOTICE,
                       M_ATT_TENDER_NOTICE_SIGN,
                       M_ATT_FILE_EX_TDOC,
                       M_ATT_FILE_EX_TDOC_SIGN,
                       M_ATT_QUAL_NOTICE_FILE,
                       M_ATT_QUAL_NOTICE_FILE_SIGN,
                       T1.TEXT                AS NOTICE_NATURE_TEXT,
                       T2.TEXT                AS BULLETIN_TYPE_TEXT,
                       T3.TEXT                AS SYNDICATED_FLAG_TEXT
                  FROM TENDER_ANN_QUA_INQUERY_ANN T
                       LEFT JOIN SYS_DIC T1 ON T.NOTICE_NATURE = T1.VALUE AND T1.TYPE = 20
                       LEFT JOIN SYS_DIC T2 ON T.BULLETIN_TYPE = T2.VALUE AND T2.TYPE = 32
                       LEFT JOIN SYS_DIC T3 ON T.SYNDICATED_FLAG = T3.VALUE AND T3.TYPE = 2003
                       LEFT JOIN SYS_DIC T4 ON T.DOC_PRICE_UNIT = T4.VALUE AND T4.TYPE = 18
                 WHERE T.TENDER_PROJECT_CODE = :tender_project_code AND T.BULLETIN_TYPE = '1' AND T.NOTICE_NATURE IN ('1', '2')
                 ORDER BY T.NOTICE_SEND_TIME");
            var entities = FromSql(sqlBuilder.ToString())
                .AddInParameter(":tender_project_code", DbType.AnsiString, projectCode).ToList<dynamic>();
            if (attachmentFunc != null)
            {
                foreach (var entity in entities)
                {
                    entity.M_ATT_TENDER_NOTICE_ATTACHMENT = attachmentFunc.Invoke(entity.M_ATT_TENDER_NOTICE);
                    entity.M_ATT_TENDER_NOTICE_SIGN_ATTACHMENT = attachmentFunc.Invoke(entity.M_ATT_TENDER_NOTICE_SIGN);
                    entity.M_ATT_FILE_EX_TDOC_ATTACHMENT = attachmentFunc.Invoke(entity.M_ATT_FILE_EX_TDOC);
                    entity.M_ATT_FILE_EX_TDOC_SIGN_ATTACHMENT = attachmentFunc.Invoke(entity.M_ATT_FILE_EX_TDOC_SIGN);
                    entity.M_ATT_QUAL_NOTICE_FILE_ATTACHMENT = attachmentFunc.Invoke(entity.M_ATT_QUAL_NOTICE_FILE);
                    entity.M_ATT_QUAL_NOTICE_FILE_SIGN_ATTACHMENT = attachmentFunc.Invoke(entity.M_ATT_QUAL_NOTICE_FILE_SIGN);
                }
            }
            return entities;
        }

        /// <summary>
        /// 服务平台门户-交易信息-详情页-顶部项目信息
        /// </summary>
        /// <param name="cid"></param>
        /// <returns></returns>
        public FwGCJSTradeDetailBase EngineerTradeBaseInfo(string cid)
        {
          var baseInfo=  FromWhere(TENDER_ANN_QUA_INQUERY_ANN._.M_ID == cid && TENDER_ANN_QUA_INQUERY_ANN._.M_STATUS == 2)
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
                    TENDER_ANN_QUA_INQUERY_ANN._.M_TM,
                    TENDER_ANN_QUA_INQUERY_ANN._.BID_DOC_REFER_END_TIME
                ).ToFirst<FwGCJSTradeDetailBase>();
          return baseInfo;
        }



        #region  公安厅外网系统
        public List<dynamic> Collection(string tender_project_code)
        {
            var records = Fw.TenderAnnQuaInqueryAnnService.FindList(TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE == tender_project_code);
            return records.Select(t => new {
                
                NOTICE_BID_NUM = t.NOTICE_BID_NUM,
                BID_SECTION_CODES = t.BID_SECTION_CODES,
                TRAD_CENTER_NAME = t.TRAD_CENTER_NAME,
                UNIFIED_DEAL_CODES = t.UNIFIED_DEAL_CODES,
                TENDERER_NAME = t.TENDERER_NAME,
                TENDERER_CODE = t.TENDERER_CODE,
                TENDERER_ADDRESS = t.TENDERER_ADDRESS,
                TENDERER_CONTACTOR = t.TENDERER_CONTACTOR,
                TENDERER_PHONE_NUMBER = t.TENDERER_PHONE_NUMBER,
                TENDERER_EMAIL = t.TENDERER_EMAIL,
                TENDER_AGENCY_NAME = t.TENDER_AGENCY_NAME,
                TENDER_AGENCY_CODE = t.TENDER_AGENCY_CODE,
                TENDER_AGENCY_ADDRESS = t.TENDER_AGENCY_ADDRESS,
                TENDER_AGENCY_CONTACTOR = t.TENDER_AGENCY_CONTACTOR,
                TENDER_AGENCY_PHONE_NUMBER = t.TENDER_AGENCY_PHONE_NUMBER,
                TENDER_AGENCY_EMAIL = t.TENDER_AGENCY_EMAIL,
                TENDER_PROJECT_CODE = t.TENDER_PROJECT_CODE,
                M_ID = t.M_ID,
                DATA_TIMESTAMP = t.DATA_TIMESTAMP

            }).ToList<dynamic>();
        }
        #endregion
    }
}