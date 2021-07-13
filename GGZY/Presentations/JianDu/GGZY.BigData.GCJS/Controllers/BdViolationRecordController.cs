using GGZY.BigData.GCJS.Models;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using GGZY.Services.Infrastructure.Extensions;
using GGZYFW.DbEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GGZY.BigData.GCJS.Controllers
{
    public class BdViolationRecordController : BaseController
    {
        // GET: BdViolationRecord
        public ActionResult List(Models.BD_VIOLATION_RECORD_REQUEST model,SearchCondition search)
        {
            var data = Fw.BdViolationRecordService.List(search, model.AREA_CODE,model.POINT_CODE, 
                model.DATETIME_START,model.DATETIME_END,model.STATE,
                model.TENDER_PROJECT_CODE,model.TENDER_PROJECT_NAME,model.TENDER_PROJECT_TYPE);
            return JResult(data);
        }

        public ActionResult Detail(string id)
        {
            var data = Fw.BdViolationRecordService.Detail(id);
            return JResult(data);
        }
       
    }
}