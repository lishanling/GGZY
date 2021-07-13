using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GGZY.DZBH.Controllers
{
    public class GetDataController : BhBaseController
    {
        // GET: GetData
        public ActionResult CheckDataByNo(string validation, string data)
        {
            return JsonReturn(Fw.GetDataService.CheckDataByNo(validation, data));
        }
        public ActionResult CheckDataByBidderName(string validation, string data)
        {
            return JsonReturn(Fw.GetDataService.CheckDataByBidderName(validation, data));
        }
        public ActionResult CheckDataByCode(string validation, string data)
        {
            return JsonReturn(Fw.GetDataService.CheckDataByCode(validation, data));
        }
        public ActionResult CheckDataById(string validation, string data)
        {
            return JsonReturn(Fw.GetDataService.CheckDataById(validation, data));
        }
        public ActionResult SendMessageToken(string validation, string data)
        {
            return JsonReturn(Fw.GetDataService.SendMessageToken(validation, data));
        }
        public ActionResult GetSmsCode(string orderId, string phone)
        {
            return JsonReturn(Fw.GetDataService.GetSmsCode(orderId, phone));
        }
    }
}