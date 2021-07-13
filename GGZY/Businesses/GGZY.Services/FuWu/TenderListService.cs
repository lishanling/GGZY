using GGZYFW.DbEntity;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GGZY.Services.FuWu
{
    public partial class TenderListService
    {
        /// <summary>
        /// 监督平台门户  项目监督信息 >> 详细信息 投标报名 投标人名单
        /// </summary>
        /// <param name="tenderProjectCode"></param>
        /// <param name="bidSectionCode"></param>
        /// <returns></returns>
        public List<object> JD_GCJS_TBBM_TenderList(string tenderProjectCode, string bidSectionCode)
        {
            var obj = FromSql(@"
                SELECT T.BIDDER_NAME,
                       T.BID_MANAGER,
                       T2.TEXT AS MARGIN_PAY_FORM,
                       T.MARGIN_RECEIVE_TIME,
                       T.CHECKIN_TIME,
                       T.BID_PRICE,
                       T.TIME_LIMIT,
                       T1.TEXT AS PRICE_UNIT_TEXT
                  FROM TENDER_LIST T
                       INNER JOIN (SELECT TENDER_PROJECT_CODE,
                                          BID_SECTION_CODE,
                                          MAX( CASE WHEN IS_POSTPONE='1' THEN POST_OPEN_TIME ELSE BID_OPEN_TIME END) AS BID_OPEN_TIME 
                                     FROM TENDER_FILE_CLARI_MODI 
                                    GROUP BY TENDER_PROJECT_CODE,BID_SECTION_CODE) TB2 
                        ON T.TENDER_PROJECT_CODE=TB2.TENDER_PROJECT_CODE AND T.BID_SECTION_CODE=TB2.BID_SECTION_CODE
                       LEFT JOIN SYS_DIC T1 ON T1.TYPE = 18 AND T.PRICE_UNIT = T1.VALUE
                       LEFT JOIN SYS_DIC T2 ON T2.TYPE = 29 AND T.MARGIN_PAY_FORM = T2.VALUE
                 WHERE T.TENDER_PROJECT_CODE =:tender_project_code AND T.BID_SECTION_CODE=:bid_section_code AND TB2.BID_OPEN_TIME<SYSDATE
                 ORDER BY T.BIDDER_NAME")
                .AddInParameter(":tender_project_code", DbType.AnsiString, tenderProjectCode)
                .AddInParameter(":bid_section_code", DbType.AnsiString, bidSectionCode)
                .ToList<object>();
            return obj;
        }

        #region 公安厅外网
        /// <summary>
        /// 投标人信息
        /// </summary>
        /// <param name="tender_project_code"></param>
        /// <returns></returns>
        public List<dynamic> Collection(string bidder_org_code)
        {
            var project = Fw.TenderListService.FromWhere(TENDER_LIST._.BIDDER_ORG_CODE == bidder_org_code)
                .InnerJoin<SYS_AREA_QUANGUO>(TENDER_LIST._.BIDDER_REGION_CODE == SYS_AREA_QUANGUO._.AREACODE)
                .Select
                (
                TENDER_LIST._.BIDDER_ORG_CODE,
                TENDER_LIST._.BID_SECTION_CODE,
                TENDER_LIST._.UNIFIED_DEAL_CODE,
                TENDER_LIST._.BIDDER_NAME,
                TENDER_LIST._.BIDDER_CODE_TYPE,
                TENDER_LIST._.BIDDER_ROLE,
                SYS_AREA_QUANGUO._.AREANAME,
                TENDER_LIST._.BIDDER_OPERATION_PERSON,
                TENDER_LIST._.BIDDER_OPERATION_PERSON_ID,
                TENDER_LIST._.BIDDER_OPERATION_PERSON_CON,
                TENDER_LIST._.BID_MANAGER,
                TENDER_LIST._.PM_CODE,
                TENDER_LIST._.PM_CERTIFICATES,
                TENDER_LIST._.UNION_ENTERPRISE_NAME,
                TENDER_LIST._.UNION_ORGAN_SET_CODE,
                TENDER_LIST._.UNION_CONTACT_NAME,
                TENDER_LIST._.UNION_CONTACT_PHONE,
                TENDER_LIST._.PURCHASE_ORDER_NUMBER,
                TENDER_LIST._.IS_REVIEW_SHORTLISTED,
                TENDER_LIST._.CHECKIN_TIME,
                TENDER_LIST._.TENDER_PROJECT_CODE,
                TENDER_LIST._.M_ID,
                TENDER_LIST._.DATA_TIMESTAMP
                ).ToList<dynamic>();
            return project;
            //var records = Fw.TenderListService.FindList(TENDER_LIST._.TENDER_PROJECT_CODE == tender_project_code);
            //return records.Select(t => new
            //{

            //    BID_SECTION_CODE = t.BID_SECTION_CODE,
            //    UNIFIED_DEAL_CODE = t.UNIFIED_DEAL_CODE,
            //    BIDDER_NAME = t.BIDDER_NAME,
            //    BIDDER_CODE_TYPE = t.BIDDER_CODE_TYPE,
            //    BIDDER_ORG_CODE = t.BIDDER_ORG_CODE,
            //    BIDDER_ROLE = t.BIDDER_ROLE,
            //    BIDDER_REGION_CODE = t.BIDDER_REGION_CODE,
            //    BIDDER_OPERATION_PERSON = t.BIDDER_OPERATION_PERSON,
            //    BIDDER_OPERATION_PERSON_ID = t.BIDDER_OPERATION_PERSON_ID,
            //    BIDDER_OPERATION_PERSON_CON = t.BIDDER_OPERATION_PERSON_CON,
            //    BID_MANAGER = t.BID_MANAGER,
            //    PM_CODE = t.PM_CODE,
            //    PM_CERTIFICATES = t.PM_CERTIFICATES,
            //    UNION_ENTERPRISE_NAME = t.UNION_ENTERPRISE_NAME,
            //    UNION_ORGAN_SET_CODE = t.UNION_ORGAN_SET_CODE,
            //    UNION_CONTACT_NAME = t.UNION_CONTACT_NAME,
            //    UNION_CONTACT_PHONE = t.UNION_CONTACT_PHONE,
            //    PURCHASE_ORDER_NUMBER = t.PURCHASE_ORDER_NUMBER,
            //    IS_REVIEW_SHORTLISTED = t.IS_REVIEW_SHORTLISTED,
            //    CHECKIN_TIME = t.CHECKIN_TIME,
            //    TENDER_PROJECT_CODE = t.TENDER_PROJECT_CODE,
            //    M_ID = t.M_ID,
            //    DATA_TIMESTAMP = t.DATA_TIMESTAMP

            //}).ToList<dynamic>();
        }
        #endregion

        /// <summary>
        /// 招投标过程监督投标人名单
        /// </summary>
        /// <param name="bidder_org_code"></param>
        /// <returns></returns>
        public List<dynamic> Collections(string bidder_section_code)
        {
            var project = Fw.WarnResultService.FromWhere(WARN_RESULT._.BID_SECTION_CODE == bidder_section_code)
                .LeftJoin<TENDER_LIST>(TENDER_LIST._.BID_SECTION_CODE == WARN_RESULT._.BID_SECTION_CODE)
                .Select
                (
                TENDER_LIST._.BID_SECTION_CODE,
                TENDER_LIST._.BIDDER_NAME,
                TENDER_LIST._.BIDDER_ORG_CODE
                ).ToList<dynamic>();
            return project;
        }
    }
}