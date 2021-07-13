using GGZY.Core.Models;
using GGZY.Framework.Infrastructure.Filters;
using GGZYJD.DbEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GGZY.YDPB.Controllers
{
    public class ChangeController : BaseController
    {
        [ApiAuthorizationFilter(Roles = "agency")]
        [HttpPost]
        public GeneralResult Post([FromBody]dynamic dic)
        {
            var result = new GeneralResult();
            int id = 0;
            var idstr = dic["ID"];
            if(null == idstr)
            {
                result.SetFail("原申请单ID不能为空");
                return result;
            }
            Int32.TryParse(idstr.ToString(), out id);

            var entity = Newtonsoft.Json.JsonConvert.DeserializeObject<YDPB_EVAL_APPLY>(dic.ToString());
            var detail = Newtonsoft.Json.JsonConvert.DeserializeObject<List<YDPB_EVAL_APPLY_DETAIL>>(dic["DETAIL"].ToString());

            return Jd.YdpbEvalApplyService.Change(id,entity, detail);
        }
        [ApiAuthorizationFilter(Roles = "tradingCenter")]
        [Route("api/change/audit")]
        [HttpPost]
        public GeneralResult Audit([FromBody] dynamic dic)
        {
            return Jd.YdpbEvalApplyService.AuditChange(dic);
        }
    }
}
