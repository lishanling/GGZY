using GGZY.Core.Models;
using GGZY.Framework.Infrastructure.Filters;
using GGZY.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GGZY.Services.Infrastructure.Extensions;

namespace GGZY.YDPB.Controllers
{
    /// <summary>
    /// 交易中心审批
    /// </summary>
    [ApiAuthorizationFilter(Roles = "tradingCenter")]
    public class AuditController : BaseController
    {
        [HttpGet]
        public GGZY.Core.Models.GeneralResult Get(int id)
        {
            return Jd.YdpbEvalApplyService.ViewByTrade(id);
        }
        /// <summary>
        /// 交易中心审核场地列表
        /// </summary>
        /// <param name="search"></param>
        /// <param name="status"></param>
        /// <param name="ctype"></param>
        /// <returns></returns>
        [Route("api/audit/list")]
        [HttpGet]
        public GGZY.Core.Models.GeneralResult List([FromUri]SearchCondition search, [FromUri]int? status = null, [FromUri] int? ctype = null)
        {
            GGZYJD.DbEntity.V_YDPB_APPLY_TRADE model = new GGZYJD.DbEntity.V_YDPB_APPLY_TRADE();
            if(status.HasValue)
            {
                model.STATUS = status;
            }
            if(ctype.HasValue)
            {
                model.IS_MAIN = ctype;
            }
            if(null == search)
            {
                search = new SearchCondition();
            }
            model.AREA_CODE = Identity.FwUser().AREACODE;
            var result = new GGZY.Core.Models.GeneralResult();
            var data =Jd.VYdpbApplyTradeService.PageList(model, search);
            result.SetSuccess(data);
            return result;
        }

        [HttpPost]
        public GGZY.Core.Models.GeneralResult Index([FromBody] dynamic dic)
        {
            return Jd.YdpbEvalApplyService.Audit(dic);
        }
    }
}
