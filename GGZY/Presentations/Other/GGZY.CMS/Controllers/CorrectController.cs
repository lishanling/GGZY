using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GGZY.Framework.Controllers;
using GGZYFW.DbEntity;

namespace GGZY.CMS.Controllers
{
    public class CorrectController : BaseAjaxController
    {
        // GET: Correct
        public ActionResult GetOneData()
        {
            return JResult(Fw.AssistCorrectInfoService.GetTenderInfo());
        }
        public ActionResult Save(ASSIST_CORRECT_INFO model)
        {
            if (!string.IsNullOrEmpty(model.ID))
            {
                return JResult(Fw.AssistCorrectInfoService.Edit(model));
            }

            model.ID = Guid.NewGuid().ToString("N");
            model.CREATE_TIME = DateTime.Now;
            return JResult(Fw.AssistCorrectInfoService.Add(model));
        }
    }
}