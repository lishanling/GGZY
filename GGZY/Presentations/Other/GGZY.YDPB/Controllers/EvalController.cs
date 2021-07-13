using GGZY.Core.Models;
using GGZY.Framework.Infrastructure.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GGZY.YDPB.Controllers
{
    [ApiAuthorizationFilter(Roles = "tradingCenter")]
    public class EvalController : BaseController
    {
        [Route("api/eval/list")]
        [HttpGet]
        public GeneralResult List([FromUri]SearchCondition condition,[FromUri] int? EVAL_STATUS = null)
        {
            return Jd.YdpbEvalApplyService.PageListProject(EVAL_STATUS, condition);
        }

        /// <summary>
        /// 启动评标
        /// </summary>
        /// <param name="id"></param>
        [Route("api/eval/start")]
        [HttpPost]
        public GeneralResult Start([FromUri]int id)
        {
            return Jd.YdpbEvalApplyService.Eval(id, 1);
        }

        /// <summary>
        /// 结束评标
        /// </summary>
        /// <param name="id"></param>
        [Route("api/eval/end")]
        [HttpPost]
        public GeneralResult End([FromUri]int id)
        {
            return Jd.YdpbEvalApplyService.Eval(id, 2);
        }
        /// <summary>
        /// 归档
        /// </summary>
        /// <param name="id"></param>
        [Route("api/eval/archive")]
        [HttpPost]
        public GeneralResult Archive([FromUri]int id)
        {
            return Jd.YdpbEvalApplyService.Eval(id, 3);
        }
    }
}