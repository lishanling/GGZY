using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdDeaMediWinBidAnnoController:BaseController
    {
        /// <summary>
        /// 读取DEA_MEDI_WIN_BID_ANNO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadDeaMediWinBidAnnos(DEA_MEDI_WIN_BID_ANNO model, SearchCondition condition)
        {
            var result = Fw.DeaMediWinBidAnnoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取DEA_MEDI_WIN_BID_ANNO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadDeaMediWinBidAnno(decimal M_ID)
        
        {
            var result = Fw.DeaMediWinBidAnnoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建DEA_MEDI_WIN_BID_ANNO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateDeaMediWinBidAnno(DEA_MEDI_WIN_BID_ANNO model)
        {
            var result = Fw.DeaMediWinBidAnnoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新DEA_MEDI_WIN_BID_ANNO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateDeaMediWinBidAnno(DEA_MEDI_WIN_BID_ANNO model)
        {
            var result = Fw.DeaMediWinBidAnnoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除DEA_MEDI_WIN_BID_ANNO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteDeaMediWinBidAnno(string ids)
        {
            var result = Fw.DeaMediWinBidAnnoService.Delete(ids);
            return JResult(result); 
        }
    }
}