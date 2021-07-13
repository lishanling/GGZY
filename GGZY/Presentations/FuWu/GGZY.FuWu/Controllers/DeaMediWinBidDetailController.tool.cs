using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdDeaMediWinBidDetailController:BaseController
    {
        /// <summary>
        /// 读取DEA_MEDI_WIN_BID_DETAIL列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadDeaMediWinBidDetails(DEA_MEDI_WIN_BID_DETAIL model, SearchCondition condition)
        {
            var result = Fw.DeaMediWinBidDetailService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取DEA_MEDI_WIN_BID_DETAIL明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadDeaMediWinBidDetail(decimal M_ID)
        
        {
            var result = Fw.DeaMediWinBidDetailService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建DEA_MEDI_WIN_BID_DETAIL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateDeaMediWinBidDetail(DEA_MEDI_WIN_BID_DETAIL model)
        {
            var result = Fw.DeaMediWinBidDetailService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新DEA_MEDI_WIN_BID_DETAIL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateDeaMediWinBidDetail(DEA_MEDI_WIN_BID_DETAIL model)
        {
            var result = Fw.DeaMediWinBidDetailService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除DEA_MEDI_WIN_BID_DETAIL信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteDeaMediWinBidDetail(string ids)
        {
            var result = Fw.DeaMediWinBidDetailService.Delete(ids);
            return JResult(result); 
        }
    }
}