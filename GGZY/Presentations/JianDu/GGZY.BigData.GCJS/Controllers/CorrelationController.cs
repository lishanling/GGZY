using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GGZY.Framework.Controllers;

namespace GGZY.BigData.GCJS.Controllers
{
    public class CorrelationController : BaseController
    {

        public ActionResult GetBidderTop10(List<string> companyList)
        {
            return JResult(Jd.CorrelationService.GetBidderTop10(companyList));
        }
        public ActionResult GetTendererTop10(List<string> companyList)
        {
            return JResult(Jd.CorrelationService.GetBidderTop10(companyList));
        }
        public ActionResult GetTenderAgentTop10(List<string> companyList)
        {
            return JResult(Jd.CorrelationService.GetBidderTop10(companyList));
        }

        public ActionResult GetTheSameMacFromBidders(List<string> companyList)
        {
            return JResult(Jd.CorrelationService.GetTheSameMacFromBidders(companyList));
        }
        public ActionResult GetConfig(string name, int num)
        {
            return JResult(Jd.CorrelationService.GetConfig(name, num));
        }
        public ActionResult GetTenderBidderList(int pageNo, int pageSize, string name, string code)
        {
            return JResult(Jd.CorrelationService.GetTenderBidderList(pageNo, pageSize, name, code));
        }
        public ActionResult GetTenderListByBidderList(int pageNo, int pageSize, List<string> companyList)
        {
            return JResult(Jd.CorrelationService.GetTenderListByBidderList(pageNo, pageSize, companyList));
        }
        public ActionResult GetWinTenderListByBidderList(int pageNo, int pageSize, List<string> companyList)
        {
            return JResult(Jd.CorrelationService.GetWinTenderListByBidderList(pageNo, pageSize, companyList));
        }
        public ActionResult GetTheSameTenderByBidderList(int pageNo, int pageSize, List<string> companyList)
        {
            return JResult(Jd.CorrelationService.GetTheSameTenderByBidderList(pageNo, pageSize, companyList));
        }
    }
}