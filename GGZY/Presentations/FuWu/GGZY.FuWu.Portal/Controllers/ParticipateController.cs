using System.Web.Mvc;
using GGZY.Framework.Controllers;

namespace GGZY.FuWu.Portal.Controllers
{
    public class ParticipateController:BaseController
    {
        #region 服务门户
        /// <summary>
        /// 收藏|关注
        /// </summary>
        /// <param name="annid">公告ID</param>
        /// <returns></returns>
        public ActionResult Attention(decimal? annid)
        {
            var r = Fw.TbParticipateService.Attention(annid);
            return JResult(r);
        }
        /// <summary>
        /// 是否已经关注
        /// </summary>
        /// <param name="annid">公告ID</param>
        /// <returns></returns>
        public ActionResult IsAttention(decimal? annid)
        {
            var isAttention = Fw.TbParticipateService.IsAttention(annid);
            return JResult(new{ IS_ATTENTION= isAttention });
        }
        #endregion
    }
}