using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdBidEvaluationExpertController:BaseController
    {
        /// <summary>
        /// 读取BID_EVALUATION_EXPERT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadBidEvaluationExperts(BID_EVALUATION_EXPERT model, SearchCondition condition)
        {
            var result = Fw.BidEvaluationExpertService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取BID_EVALUATION_EXPERT明细
        /// </summary>
      /// <param name="M_ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadBidEvaluationExpert(decimal M_ID)
        
        {
            var result = Fw.BidEvaluationExpertService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建BID_EVALUATION_EXPERT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateBidEvaluationExpert(BID_EVALUATION_EXPERT model)
        {
            var result = Fw.BidEvaluationExpertService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新BID_EVALUATION_EXPERT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateBidEvaluationExpert(BID_EVALUATION_EXPERT model)
        {
            var result = Fw.BidEvaluationExpertService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除BID_EVALUATION_EXPERT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteBidEvaluationExpert(string ids)
        {
            var result = Fw.BidEvaluationExpertService.Delete(ids);
            return JResult(result); 
        }
    }
}