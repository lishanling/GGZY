using System;
using System.Web.Mvc;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using GGZY.Services.Infrastructure.Model;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Portal.Controllers
{
    [AllowAnonymous]
    public class AdviceController: BaseController
    {
        public ActionResult Save(EXT_SERVICE_ADVICE model, string mobileValidateCode, string imgCode)
        {
            var r = SmsModel.ValidateMobileCode(model.PHONE, mobileValidateCode, imgCode);
            if (r.Success)
            {
                model.ID = 0;
                model.TM=DateTime.Now;
                r = Fw.ExtServiceAdviceService.Add(model);
            }
            return JResult(r);
        }

        public ActionResult PageList(EXT_SERVICE_ADVICE model, SearchCondition search)
        {
            model.RETURN = 1;
            var r = Fw.ExtServiceAdviceService.PageList(model, search).ToPageTableResult(search);
            return JResult(r);
        }
    }
}