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
    [ApiAuthorizationFilter(Roles = "agency")]
    public class ApplyController : BaseController
    {
       
        // GET api/apply/5
        public GeneralResult Get(int id)
        {
            return Jd.YdpbEvalApplyService.View(id);
        }

        // POST api/apply
        
        public GeneralResult Post([FromBody]dynamic dic)
        {
            if(null == dic["DETAIL"])
            {
                var result = new GeneralResult();
                result.SetFail("会场申请信息不能为空");
                return result;
            }
            var entity = Newtonsoft.Json.JsonConvert.DeserializeObject<YDPB_EVAL_APPLY>(dic.ToString());
            var detail = Newtonsoft.Json.JsonConvert.DeserializeObject<List<YDPB_EVAL_APPLY_DETAIL>>(dic["DETAIL"].ToString());
            
            return Jd.YdpbEvalApplyService.Add(entity, detail);
        }
        /// <summary>
        /// 获取所有评标场地列表
        /// </summary>
        /// <param name="condition">分页条件</param>
        /// <param name="state">审核状态 0:待审核 1:审核通过 2:审核不通过</param>
        /// <returns></returns>
        [Route("api/apply/List")]
        [HttpGet]
        public GGZY.Core.Models.GeneralResult List([FromUri]SearchCondition condition, [FromUri]int? state = null)
        {
            return Jd.YdpbEvalApplyService.PageList(state, condition);
        }
        /// <summary>
        /// 查询审批结果
        /// </summary>
        /// <returns></returns>
        [Route("api/apply/query")]
        [AllowAnonymous]
        [HttpGet]
        public GeneralResult Query(string SERIES_NUMBER)
        {

            return Jd.YdpbEvalApplyService.Query(SERIES_NUMBER);
        }
    }
}