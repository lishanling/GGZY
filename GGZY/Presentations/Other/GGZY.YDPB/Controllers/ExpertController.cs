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
    [ApiAuthorizationFilter(Roles = "tradingCenter")]
    public class ExpertController : BaseController
    {
        /// <summary>
        /// 评标席位分配详情
        /// </summary>
        /// <param name="id">申请单id</param>
        /// <returns></returns>
        // GET api/<controller>/5
        public GeneralResult Get(int id)
        {
            return Jd.YdpbEvalExpertRecordService.Detail(id);
        }

        // POST api/<controller>
        public GeneralResult Post([FromBody]dynamic dic)
        {
            GeneralResult result = new GeneralResult();
            if(null == dic || null == dic["ID"])
            {
                result.SetFail("ID不能为空");
                return result;
            }
            if(null == dic["EXPERT"])
            {
                result.SetFail("评标专家信息不能为空");
                return result;
            }
            var id = 0;
            Int32.TryParse(dic["ID"].ToString(), out id);
            List<YDPB_EVAL_EXPERT_RECORD> experts = Newtonsoft.Json.JsonConvert.DeserializeObject<List<YDPB_EVAL_EXPERT_RECORD>>(dic["EXPERT"].ToString());
            var isAnyEmpty =experts.Where(w => String.IsNullOrEmpty(w.ID_CARD) || String.IsNullOrEmpty(w.ID_CARD_TYPE) || String.IsNullOrEmpty(w.EXPERT_NAME)).Any();
            if(isAnyEmpty)
            {
                result.SetFail("评标专家信息不完整");
                return result;
            }
            return Jd.YdpbEvalExpertRecordService.Add(id, experts);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }
        [Route("api/expert/list")]
        [HttpGet]
        public GeneralResult List([FromUri]SearchCondition condition, [FromUri]int? state = null)
        {
            if(null == condition)
            {
                condition = new SearchCondition();
            }
            return Jd.YdpbEvalExpertRecordService.List(condition, state);
        }
    }
}