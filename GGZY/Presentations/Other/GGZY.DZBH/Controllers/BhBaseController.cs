using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GGZY.Framework.Controllers;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GGZY.DZBH.Controllers
{
    [AllowAnonymous]
    public class BhBaseController : BaseController
    {
        // GET: BhBase
        protected ContentResult JsonReturn(object Data)
        {
            JsonSerializerSettings setting = new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                Formatting = Formatting.Indented,
                Converters = new List<JsonConverter>
                {
                    new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" }
                }
            };
            return Content(JsonConvert.SerializeObject(Data, setting));
        }
        protected ContentResult JsonReturn_dateToStr(object Data)
        {
            JsonSerializerSettings setting = new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                Formatting = Formatting.Indented,
                Converters = new List<JsonConverter>
                {
                    new IsoDateTimeConverter { DateTimeFormat = "yyyyMMddHHmmss" }
                }
            };
            return Content(JsonConvert.SerializeObject(Data, setting));
        }
    }
}