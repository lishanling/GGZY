using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdBidEvaluationExpertDelController:BaseController
    {
        /// <summary>
        /// 读取BID_EVALUATION_EXPERT_DEL列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadBidEvaluationExpertDels(BID_EVALUATION_EXPERT_DEL model, SearchCondition condition)
        {
            var result = Fw.BidEvaluationExpertDelService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取BID_EVALUATION_EXPERT_DEL明细
        /// </summary>
      /// <param name="M_ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadBidEvaluationExpertDel(decimal M_ID)
        
        {
            var result = Fw.BidEvaluationExpertDelService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建BID_EVALUATION_EXPERT_DEL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateBidEvaluationExpertDel(BID_EVALUATION_EXPERT_DEL model)
        {
            var result = Fw.BidEvaluationExpertDelService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新BID_EVALUATION_EXPERT_DEL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateBidEvaluationExpertDel(BID_EVALUATION_EXPERT_DEL model)
        {
            var result = Fw.BidEvaluationExpertDelService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除BID_EVALUATION_EXPERT_DEL信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteBidEvaluationExpertDel(string ids)
        {
            var result = Fw.BidEvaluationExpertDelService.Delete(ids);
            return JResult(result); 
        }
    }
}