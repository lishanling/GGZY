using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdBidZjrjCodeController:BaseController
    {
        /// <summary>
        /// 读取BID_ZJRJ_CODE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadBidZjrjCodes(BID_ZJRJ_CODE model, SearchCondition condition)
        {
            var result = Fw.BidZjrjCodeService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取BID_ZJRJ_CODE明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadBidZjrjCode(decimal ID)
        
        {
            var result = Fw.BidZjrjCodeService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建BID_ZJRJ_CODE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateBidZjrjCode(BID_ZJRJ_CODE model)
        {
            var result = Fw.BidZjrjCodeService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新BID_ZJRJ_CODE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateBidZjrjCode(BID_ZJRJ_CODE model)
        {
            var result = Fw.BidZjrjCodeService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除BID_ZJRJ_CODE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteBidZjrjCode(string ids)
        {
            var result = Fw.BidZjrjCodeService.Delete(ids);
            return JResult(result); 
        }
    }
}