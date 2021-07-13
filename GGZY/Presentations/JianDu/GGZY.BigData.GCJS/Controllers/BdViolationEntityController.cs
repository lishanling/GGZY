using Dos.ORM;
using GGZY.BigData.GCJS.Models;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GGZY.BigData.GCJS.Controllers
{
    public class BdViolationEntityController : BaseController
    {
        // GET: BdViolationRecord
        public ActionResult List(BD_VIOLATION_ENTITY_REQUEST model, SearchCondition search)
        {
            var data = Fw.BdViolationEntityService.List(search, model.AREA_CODE, model.POINT_CODE,
                model.DATETIME_START, model.DATETIME_END, model.STATE,
                model.ENTITY_CODE, model.ENTITY_NAME,model.ENTITY_TYPE);
            return JResult(data);
        }

        public ActionResult Detail(string id)
        {
            var data = Fw.BdViolationEntityService.Detail(id);
            return JResult(data);
        }
    }
}