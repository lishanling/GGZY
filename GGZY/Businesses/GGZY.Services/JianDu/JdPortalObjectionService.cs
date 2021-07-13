using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public class JdPortalObjectionService:BaseServiceT<JdEntity>
    {
        #region 监督平台门户 异议处理结果列表|详情

        public List<LabelValueModel> ObjectionTenderProjectType(SearchCondition search)
        {
            var recordHandleResultCon = new WhereClipBuilder();
            var recordReviewCon = new WhereClipBuilder(RECORD_REVIEW._.REVIEW_STATUS == 1);
            var result = new List<LabelValueModel>{new LabelValueModel
            {
                Id="",Value="",Label = "全部"
            } };
            if (search.BeginTime.HasValue)
            {
                recordHandleResultCon.And(RECORD_HANDLE_RESULT._.HANDLE_TIME >= search.BeginTime);
                recordReviewCon.And(RECORD_REVIEW._.COMMIT_TIME >= search.BeginTime);
            }
            //处理时间
            if (search.EndTime.HasValue)
            {
                recordHandleResultCon.And(RECORD_HANDLE_RESULT._.HANDLE_TIME <= search.EndTime);
                recordReviewCon.And(RECORD_REVIEW._.COMMIT_TIME <= search.EndTime);
            }
            var groups =Jd.TenderProjectService.FromWhere()
                .InnerJoin<RECORD_REVIEW>(recordReviewCon.ToWhereClip() && TENDER_PROJECT._.TENDER_PROJECT_CODE == RECORD_REVIEW._.TENDER_PROJECT_CODE)
                .InnerJoin<RECORD_HANDLE_RESULT>(recordHandleResultCon.ToWhereClip() &&
                                                 RECORD_HANDLE_RESULT._.RECORD_ID == RECORD_REVIEW._.ID)
                .GroupBy(TENDER_PROJECT._.TENDER_PROJECT_TYPE)
                .Select(TENDER_PROJECT._.TENDER_PROJECT_TYPE.As("Label"), TENDER_PROJECT._.All.Count().As("Value"))
                .ToList<LabelValueModel>();
            var tenderProjectTypes = groups.FindAll(c => string.CompareOrdinal(c.Value, "0") > 0).Select(c => c.Label)
                .ToList();
            var dic = Jd.SysDicService.FindList(SYS_DIC._.TYPE == "20200830003"&&SYS_DIC._.VALUE.In(tenderProjectTypes),SYS_DIC._.ORDER_ID.Asc).ToList();
            result.AddRange(dic.Select(c=>new LabelValueModel
            {
                Id=c.ID?.ToString(),Value=c.VALUE,Label = c.TEXT
            }));
            return result;
        }
        /// <summary>
        /// 监督平台门户 异议处理结果列表
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult ObjectionResult(ObjectionSearchRequest search)
        {
            var recordReviewCon = new WhereClipBuilder(RECORD_REVIEW._.REVIEW_STATUS == 1);
            var recordHandleResultCon = new WhereClipBuilder();
            var tenderProjectCon = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(search.TenderProjectType))
            {
                tenderProjectCon.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE == search.TenderProjectType);
            }

            if (!string.IsNullOrWhiteSpace(search.KeyWord))
            {
                //recordReviewCon.And(RECORD_REVIEW._.REVIEW_CODE.Contain(search.KeyWord));
                tenderProjectCon.And(TENDER_PROJECT._.TENDER_PROJECT_NAME.Contain(search.KeyWord) || RECORD_REVIEW._.REVIEW_CODE.Contain(search.KeyWord));
            }

            #region 公示时间

            if (search.GsBeginTime.HasValue)
            {
                recordReviewCon.And(RECORD_REVIEW._.COMMIT_TIME >= search.GsBeginTime);
            }
            if (search.GsEndTime.HasValue)
            {
                recordReviewCon.And(RECORD_REVIEW._.COMMIT_TIME <= search.GsEndTime);
            }

            #endregion

            #region 处理时间|异议类型
            //处理时间
            if (search.BeginTime.HasValue)
            {
                recordHandleResultCon.And(RECORD_HANDLE_RESULT._.HANDLE_TIME >= search.BeginTime);
            }
            //处理时间
            if (search.EndTime.HasValue)
            {
                recordHandleResultCon.And(RECORD_HANDLE_RESULT._.HANDLE_TIME <= search.EndTime);
            }
            //异议类型
            if (!string.IsNullOrWhiteSpace(search.Type))
            {
                recordHandleResultCon.And(RECORD_HANDLE_RESULT._.DISSENT_TYPE == search.Type);
            }
            #endregion

            var count = Jd.TenderProjectService.FromWhere(tenderProjectCon.ToWhereClip())
                .InnerJoin<RECORD_REVIEW>(recordReviewCon.ToWhereClip() &&
                                          TENDER_PROJECT._.TENDER_PROJECT_CODE == RECORD_REVIEW._.TENDER_PROJECT_CODE)
                .InnerJoin<RECORD_HANDLE_RESULT>(recordHandleResultCon.ToWhereClip() &&
                                                 RECORD_HANDLE_RESULT._.RECORD_ID == RECORD_REVIEW._.ID)
                .Count();
            var pageList = Jd.TenderProjectService.FromWhere(tenderProjectCon.ToWhereClip())
                .InnerJoin<RECORD_REVIEW>(recordReviewCon.ToWhereClip() &&
                                          TENDER_PROJECT._.TENDER_PROJECT_CODE == RECORD_REVIEW._.TENDER_PROJECT_CODE)
                .InnerJoin<RECORD_HANDLE_RESULT>(recordHandleResultCon.ToWhereClip() &&
                                                 RECORD_HANDLE_RESULT._.RECORD_ID == RECORD_REVIEW._.ID)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "3026" && SYS_DIC._.VALUE == RECORD_HANDLE_RESULT._.DISSENT_TYPE)
                .Page(search.PageSize, search.PageNo)
                .OrderBy(RECORD_REVIEW._.COMMIT_TIME.Desc)
                .Select(
                    RECORD_HANDLE_RESULT._.ID,
                    //RECORD_HANDLE_RESULT._.ID,
                    RECORD_REVIEW._.REVIEW_CODE,
                    TENDER_PROJECT._.TENDER_PROJECT_CODE,
                    TENDER_PROJECT._.TENDER_PROJECT_TYPE,
                    TENDER_PROJECT._.TENDER_PROJECT_NAME,
                    SYS_DIC._.VALUE1.As("DISSENT_TYPE"),
                    TENDER_PROJECT._.TENDER_AGENCY_NAME,
                    RECORD_REVIEW._.COMMIT_TIME,
                    RECORD_REVIEW._.COMMIT_TIME.ToChar("yyyy-mm-dd", "TM")
                ).ToList<ObjectionResultResponse>()
                .ToPageTableResult(search, count);
            return pageList;
        }


        public object ObjectionResultDetail(string id)
        {
            id = id.DesDecrypt();
            var title = Jd.TenderProjectService.FromWhere(WhereClip.All)
                .InnerJoin<RECORD_REVIEW>(TENDER_PROJECT._.TENDER_PROJECT_CODE == RECORD_REVIEW._.TENDER_PROJECT_CODE)
                .InnerJoin<RECORD_HANDLE_RESULT>(RECORD_HANDLE_RESULT._.ID == id &&
                                                 RECORD_HANDLE_RESULT._.RECORD_ID == RECORD_REVIEW._.ID)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "3026" && SYS_DIC._.VALUE == RECORD_HANDLE_RESULT._.DISSENT_TYPE)
                .Select(
                    RECORD_HANDLE_RESULT._.ID,
                    RECORD_REVIEW._.REVIEW_CODE,
                    TENDER_PROJECT._.TENDER_PROJECT_CODE,
                    TENDER_PROJECT._.TENDERER_NAME,
                    TENDER_PROJECT._.TENDER_PROJECT_TYPE,
                    SYS_DIC._.VALUE1.As("DISSENT_TYPE"),
                    TENDER_PROJECT._.TENDER_AGENCY_NAME,
                    RECORD_REVIEW._.COMMIT_TIME,
                    RECORD_REVIEW._.COMMIT_TIME.ToChar("yyyy-mm-dd", "TM")
                ).ToFirst<ObjectionResultResponse>();
            var context = FromSql(@"SELECT A.ID,
                                  (SELECT WM_CONCAT(BID_SECTION_NAME) FROM SECTION WHERE BID_SECTION_CODE IN (SELECT * FROM TABLE(SPLIT(A.BID_SECTION_CODES)))) AS BID_SECTION_CODES,
                                  A.DISSENT_NAME,
                                  A.COMPLAINED_NAME,
                                  A.DISSENT_COMMIT_TIME,
                                  B.TEXT AS DISSENT_TYPE,
                                  A.DISSENT_CONTENT,
                                  A.GROUND_REASON,
                                  A.IS_ACCEPT_TIME,
                                  C.TEXT AS DISSENT_OPINION,
                                  A.HANDLE_RESULT,
                                  A.HANDLE_BASIS,
                                  A.HANDLE_TIME
                             FROM RECORD_HANDLE_RESULT A
                                  LEFT JOIN SYS_DIC B ON A.DISSENT_TYPE = B.VALUE AND B.TYPE = '3026'
                                  LEFT JOIN SYS_DIC C ON A.DISSENT_OPINION = C.VALUE AND C.TYPE = '3027'
                            WHERE A.ID=:id").AddInParameter(":id", DbType.Int32, id)
                .ToFirst<object>();
            return new
            {
                Title = title,
                Context = context
            };
        }

        #endregion
    }
}