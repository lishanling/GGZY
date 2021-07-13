using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using GGZYFW.DbEntity;
using GGZYJD.DbEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GGZY.JianDu.Controllers
{
    public class GatBidderController : BaseController
    {
        // GET: GatBidder
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 公安厅外网-项目信息-投标人名单
        /// </summary>
        /// <returns></returns>
        public ActionResult Search(string tender_project_code)
        {
            GeneralResult r = new GeneralResult();
            var sections = Fw.SectionService.FindList(GGZYFW.DbEntity.SECTION._.TENDER_PROJECT_CODE == tender_project_code);
            var results = Fw.TenderListService.FindList(TENDER_LIST._.TENDER_PROJECT_CODE == tender_project_code);
            var data = sections.Select(t => new {
                
                TENDER_PROJECT_CODE = t.TENDER_PROJECT_CODE,
                BID_SECTION_NAME = t.BID_SECTION_NAME,
                BID_SECTION_CODE = t.BID_SECTION_CODE,
                
                RESULTS = results.Where(w => w.BID_SECTION_CODE == t.BID_SECTION_CODE).Select(t1 => new {
                    BID_SECTION_CODE = t1.BID_SECTION_CODE,
                    BIDDER_NAME = t1.BIDDER_NAME,
                    BIDDER_ORG_CODE = t1.BIDDER_ORG_CODE,
                    BIDDER_CODE_TYPE = t1.BIDDER_CODE_TYPE,
                    BIDDER_REGION_CODE = t1.BIDDER_REGION_CODE,
                    BID_MANAGER = t1.BID_MANAGER,
                    BIDDER_OPERATION_PERSON = t1.BIDDER_OPERATION_PERSON,
                    CHECKIN_TIME = t1.CHECKIN_TIME,
                    TENDER_PROJECT_CODE = t1.TENDER_PROJECT_CODE,
                    M_ID = t1.M_ID,
                    DATA_TIMESTAMP = t1.DATA_TIMESTAMP
                })
            });
            r.SetSuccess(data);
            return JResult(r);
        }
        /// <summary>
        /// 公安厅外网-项目信息-投标人名单详情
        /// </summary>
        /// <returns></returns>
        public ActionResult Check(string bidder_org_code)
        {
            GeneralResult r = new GeneralResult();
            var Didder = Fw.TenderListService.Collection(bidder_org_code);
            var Team = Fw.BidderProjectMemberService.Collection(bidder_org_code);
            

            r.SetSuccess(new
            {
                DIDDER = Didder,
                TEAM = Team,

            });
            return JResult(r);
        }

        /// <summary>
        /// 公安厅外网-项目信息-评标专家
        /// </summary>
        /// <returns></returns>
        public ActionResult Expert(string tender_project_code)
        {

            //var result = service.BidderExpertService.Collection(tender_project_code);
            //return JResult(result);
            GeneralResult r = new GeneralResult();
            var sections = Fw.SectionService.FindList(GGZYFW.DbEntity.SECTION._.TENDER_PROJECT_CODE == tender_project_code);
            var results = Fw.BidEvaluationExpertService.FindList(BID_EVALUATION_EXPERT._.TENDER_PROJECT_CODE == tender_project_code);
            var data = sections.Select(t => new {
                
                TENDER_PROJECT_CODE = t.TENDER_PROJECT_CODE,
                BID_SECTION_NAME = t.BID_SECTION_NAME,
                BID_SECTION_CODE = t.BID_SECTION_CODE,
                DATA_TIMESTAMP = t.DATA_TIMESTAMP,
                RESULTS = results.Where(w => w.BID_SECTION_CODE == t.BID_SECTION_CODE).Select(t1 => new {
                    
                    BID_SECTION_CODE = t1.BID_SECTION_CODE,
                    EXPERT_NAME = t1.EXPERT_NAME,
                    EXPERT_TYPE = t1.EXPERT_TYPE,
                    ID_CARD = t1.ID_CARD,
                    ID_CARD_TYPE = t1.ID_CARD_TYPE,
                    EXPERT_CHECK_IN_TIME = t1.EXPERT_CHECK_IN_TIME,
                    IS_CHAIR_MAN = t1.IS_CHAIR_MAN,
                    TENDER_PROJECT_CODE = t1.TENDER_PROJECT_CODE,
                    M_ID = t1.M_ID,
                    DATA_TIMESTAMP = t1.DATA_TIMESTAMP
                })
            });
            r.SetSuccess(data);
            return JResult(r);
        }
        /// <summary>
        /// 公安厅外网-项目信息-中标候选人
        /// </summary>
        /// <returns></returns>
        public ActionResult WinCandidate(string tender_project_code)
        {
            //var result = service.WinCandidateService.Collection(tender_project_code);
            //return JResult(result);
            GeneralResult r = new GeneralResult();
            var sections = Fw.SectionService.FindList(GGZYFW.DbEntity.SECTION._.TENDER_PROJECT_CODE == tender_project_code);
            var results = Fw.TenderCandidateService.FindList(TENDER_CANDIDATE._.TENDER_PROJECT_CODE == tender_project_code);
            var data = sections.Select(t => new {
                
                TENDER_PROJECT_CODE = t.TENDER_PROJECT_CODE,
                BID_SECTION_NAME = t.BID_SECTION_NAME,
                BID_SECTION_CODE = t.BID_SECTION_CODE,
                DATA_TIMESTAMP = t.DATA_TIMESTAMP,
                RESULTS = results.Where(w => w.BID_SECTION_CODE == t.BID_SECTION_CODE).Select(t1 => new {
                    
                    BID_SECTION_CODE = t1.BID_SECTION_CODE,
                    WIN_CANDIDATE_NAME = t1.WIN_CANDIDATE_NAME,
                    BIDDER_CODE_TYPE = t1.BIDDER_CODE_TYPE,
                    WIN_CANDIDATE_CODE = t1.WIN_CANDIDATE_CODE,
                    BIDDER_ROLE = t1.BIDDER_ROLE,
                    WIN_CANDIDATE_ORDER = t1.WIN_CANDIDATE_ORDER,
                    TENDER_PROJECT_CODE = t1.TENDER_PROJECT_CODE,
                    M_ID = t1.M_ID,
                    DATA_TIMESTAMP = t1.DATA_TIMESTAMP
                })
            });
            r.SetSuccess(data);
            return JResult(r);
        }
    }
}