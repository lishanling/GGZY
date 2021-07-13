using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdBidViolationController:BaseController
    {
        /// <summary>
        /// 读取BID_VIOLATION列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadBidViolations(BID_VIOLATION model, SearchCondition condition)
        {
            var result = Fw.BidViolationService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取BID_VIOLATION明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadBidViolation(decimal ID)
        
        {
            var result = Fw.BidViolationService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建BID_VIOLATION信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateBidViolation(BID_VIOLATION model)
        {
            var result = Fw.BidViolationService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新BID_VIOLATION信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateBidViolation(BID_VIOLATION model)
        {
            var result = Fw.BidViolationService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除BID_VIOLATION信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteBidViolation(string ids)
        {
            var result = Fw.BidViolationService.Delete(ids);
            return JResult(result); 
        }
    }
}