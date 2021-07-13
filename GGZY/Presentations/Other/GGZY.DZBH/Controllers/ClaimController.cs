using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GGZY.Framework.Controllers;
using GGZY.Services.DZBH.ParamModel;
using GGZYFW.DbEntity;

namespace GGZY.DZBH.Controllers
{
    public class ClaimController : BaseController
    {
        // GET: Claim
        public ActionResult GetOrderInfo(string orderId, string guaranteeNo)
        {
            return JResult(Fw.ClaimService.GetOrderInfo(orderId, guaranteeNo));
        }
        public ActionResult Add(BH_SEND_CLAIM_FORM obj, List<BH_ATTACHMENT> CLIAM_ATTACHMENT)
        {
            return JResult(Fw.ClaimService.Add(obj, CLIAM_ATTACHMENT));
        }
        public ActionResult View(int id)
        {
            return JResult(Fw.ClaimService.ViewByPk(id));
        }
        public ActionResult List(ListSearchModel search)
        {
            return JResult(Fw.ClaimService.List(search));
        }
    }
}