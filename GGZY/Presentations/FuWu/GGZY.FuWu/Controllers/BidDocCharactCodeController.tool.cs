using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdBidDocCharactCodeController:BaseController
    {
        /// <summary>
        /// 读取BID_DOC_CHARACT_CODE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadBidDocCharactCodes(BID_DOC_CHARACT_CODE model, SearchCondition condition)
        {
            var result = Fw.BidDocCharactCodeService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取BID_DOC_CHARACT_CODE明细
        /// </summary>
      /// <param name="M_ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadBidDocCharactCode(decimal M_ID)
        
        {
            var result = Fw.BidDocCharactCodeService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建BID_DOC_CHARACT_CODE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateBidDocCharactCode(BID_DOC_CHARACT_CODE model)
        {
            var result = Fw.BidDocCharactCodeService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新BID_DOC_CHARACT_CODE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateBidDocCharactCode(BID_DOC_CHARACT_CODE model)
        {
            var result = Fw.BidDocCharactCodeService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除BID_DOC_CHARACT_CODE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteBidDocCharactCode(string ids)
        {
            var result = Fw.BidDocCharactCodeService.Delete(ids);
            return JResult(result); 
        }
    }
}