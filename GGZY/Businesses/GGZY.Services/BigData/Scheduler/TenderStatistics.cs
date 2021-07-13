using System;
using System.Linq;
using GGZY.Core.Extensions;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Model.BigData;
using GGZYFW.DbEntity;

namespace GGZY.Services.BigData.Scheduler
{
    /// <summary>
    /// 投标人统计
    /// </summary>
    public class TenderStatistics : BaseServiceT<FwEntity>
    {
        /// <summary>
        /// 近5年招投标数据
        /// </summary>
        public void FiveYearsProjectData(DateTime? beginDate=null,DateTime? endDate=null)
        {

            if (!endDate.HasValue)
            {
                endDate = DateTime.Today.AddDays(1);
            }

            if (!beginDate.HasValue)
            {
                beginDate = endDate.Value.AddYears(-5).AddDays(-1);
            }

            var tenderList = Fw.TenderListService
                .FromWhere(TENDER_LIST._.CHECKIN_TIME >= beginDate && TENDER_LIST._.CHECKIN_TIME <= endDate &&
                           TENDER_LIST._.M_KEY.IsNotNull())
                .LeftJoin<WIN_RESULT_ANNO>(WIN_RESULT_ANNO._.NOTICE_SEND_TIME >= beginDate &&
                                           WIN_RESULT_ANNO._.NOTICE_SEND_TIME <= endDate &&
                                           WIN_RESULT_ANNO._.M_KEY.IsNotNull() && WIN_RESULT_ANNO._.WIN_BIDDER_NAME ==
                                           TENDER_LIST._.BIDDER_NAME)
                .GroupBy(TENDER_LIST._.BIDDER_NAME)
                .Select(
                    TENDER_LIST._.BIDDER_NAME.As("LEGAL_NAME")
                    , TENDER_LIST._.BID_SECTION_CODE.Distinct().Count().As("COUNT")
                    , WIN_RESULT_ANNO._.BID_SECTION_CODE.Distinct().Count().As("WIN_COUNT")
                ).ToList<StatisticsBidderRankModel>();
            var legalPersonBase = Fw.LegalPersonBaseService.FromWhere(LEGAL_PERSON_BASE._.LEGAL_ROLE.Contain("03"))
                .LeftJoin<DSJ_AREA>(DSJ_AREA._.OLDCODE == LEGAL_PERSON_BASE._.REGION_CODE)
                .Select(LEGAL_PERSON_BASE._.LEGAL_NAME, LEGAL_PERSON_BASE._.LEGAL_CODE,
                    LEGAL_PERSON_BASE._.REGION_CODE,DSJ_AREA._.SHI.As("REGISTER_CITY"))
                .ToList();
            foreach (var tender in tenderList)
            {
                var legal = legalPersonBase.FirstOrDefault(c => c.LEGAL_NAME == tender.LEGAL_NAME);
                if (legal != null)
                {
                    tender.AREANAME = legal.REGISTER_CITY;
                    tender.LEGAL_CODE = legal.LEGAL_CODE;
                }
            }

            Console.WriteLine(tenderList.Serializer());
        }
    }
}