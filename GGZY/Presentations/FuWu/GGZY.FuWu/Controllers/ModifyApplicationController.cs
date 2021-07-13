using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public class ModifyApplicationController : BaseController
    {
        // GET: ModifyApplication
        public ActionResult Save(T_MODIFY_APPLICATION model)
        {
            if (!string.IsNullOrEmpty(model.GUID))
            {
                return JResult(Fw.TModifyApplicationService.Edit(model));

            }
            return JResult(Fw.TModifyApplicationService.Add(model));
        }

        public ActionResult Page(T_MODIFY_APPLICATION model, SearchCondition search)
        {
            return JResult(Fw.TModifyApplicationService.PageList(model, search));
        }

        public ActionResult Review(string guid)
        {
            return JResult(Fw.TModifyApplicationService.Review(guid));
        }

        public ActionResult View(string guid)
        {
            return JResult(Fw.TModifyApplicationService.ViewByPk(guid));
        }
    }
}