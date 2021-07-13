using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GGZY.Core.Models;

namespace GGZY.DZBH.Controllers
{
    public class ReceiveController : BhBaseController
    {
        /// <summary>
        /// 接收保函保单
        /// </summary>
        /// <param name="validation"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public ActionResult Guarantor(string validation, string data)
        {
            Hashtable result = new Hashtable();
            GeneralResult r = Fw.ExChangeService.ReceiveGuaranteeResult(validation, data);
            if (r.Success)
            {
                result["STATUS"] = "1";
                result["MSG"] = "";
            }
            else
            {
                result["STATUS"] = "0";
                result["MSG"] = r.Msg;
            }

            return JsonReturn(result);
        }
        /// <summary>
        /// 接收申请单信息
        /// </summary>
        /// <param name="validation"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public ActionResult ApplicationForm(string validation, string data)
        {
            Hashtable result = new Hashtable();
            GeneralResult r = Fw.ExChangeService.ReceiveApplicationForm(validation, data);
            if (r.Success)
            {
                result["STATUS"] = "1";
                result["MSG"] = "";
            }
            else
            {
                result["STATUS"] = "0";
                result["MSG"] = r.Msg;
            }

            return JsonReturn(result);
        }
        /// <summary>
        /// 修改申请单状态
        /// </summary>
        /// <param name="validation"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public ActionResult ChangeStatus(string validation, string data)
        {
            Hashtable result = new Hashtable();
            GeneralResult r = Fw.ExChangeService.ChangeStatus(validation, data);
            if (r.Success)
            {
                result["STATUS"] = "1";
                result["MSG"] = "";
            }
            else
            {
                result["STATUS"] = "0";
                result["MSG"] = r.Msg;
            }

            return JsonReturn(result);
        }
        /// <summary>
        /// 理赔反馈
        /// </summary>
        /// <param name="validation"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public ActionResult Claim(string validation, string data)
        {
            Hashtable result = new Hashtable();
            GeneralResult r = Fw.ExChangeService.ReceiveClaim(validation, data);
            if (r.Success)
            {
                result["STATUS"] = "1";
                result["MSG"] = "";
            }
            else
            {
                result["STATUS"] = "0";
                result["MSG"] = r.Msg;
            }

            return JsonReturn(result);
        }
    }
}