using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdDeaMediWinBidListController:BaseController
    {
        /// <summary>
        /// 读取DEA_MEDI_WIN_BID_LIST列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadDeaMediWinBidLists(DEA_MEDI_WIN_BID_LIST model, SearchCondition condition)
        {
            var result = Fw.DeaMediWinBidListService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取DEA_MEDI_WIN_BID_LIST明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadDeaMediWinBidList(decimal M_ID)
        
        {
            var result = Fw.DeaMediWinBidListService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建DEA_MEDI_WIN_BID_LIST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateDeaMediWinBidList(DEA_MEDI_WIN_BID_LIST model)
        {
            var result = Fw.DeaMediWinBidListService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新DEA_MEDI_WIN_BID_LIST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateDeaMediWinBidList(DEA_MEDI_WIN_BID_LIST model)
        {
            var result = Fw.DeaMediWinBidListService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除DEA_MEDI_WIN_BID_LIST信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteDeaMediWinBidList(string ids)
        {
            var result = Fw.DeaMediWinBidListService.Delete(ids);
            return JResult(result); 
        }
    }
}