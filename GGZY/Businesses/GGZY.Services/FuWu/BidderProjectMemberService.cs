using GGZYFW.DbEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.FuWu
{
    public partial class BidderProjectMemberService
    {
        public List<dynamic> Collection(string bidder_org_code)
        {
            var records = Fw.BidderProjectMemberService.FindList(BIDDER_PROJECT_MEMBER._.BIDDER_ORG_CODE == bidder_org_code);
            return records.Select(t => new {
               
                NAME = t.NAME,
                PHONE = t.PHONE,
                ID_CARD_NO = t.ID_CARD_NO,
                POSITION = t.POSITION,
                BIDDER_ORG_CODE=t.BIDDER_ORG_CODE,
                TECHNICAL_POST = t.TECHNICAL_POST,
                CERTIFICATE_NO = t.CERTIFICATE_NO,
                CERTIFICATE_TYPE = t.CERTIFICATE_TYPE,
                CERTIFICATE_FULL_NAME = t.CERTIFICATE_FULL_NAME,
                CERTIFICATE_LEVLE = t.CERTIFICATE_LEVLE,
                YEARS_OF_WORKING = t.YEARS_OF_WORKING,
                CREDIT_SCORE = t.CREDIT_SCORE,
                GRADUATE_SCHOOL = t.GRADUATE_SCHOOL,
                TENDER_PROJECT_CODE = t.TENDER_PROJECT_CODE,
                M_ID = t.M_ID,
                DATA_TIMESTAMP = t.DATA_TIMESTAMP

            }).ToList<dynamic>();
        }
    }
}
