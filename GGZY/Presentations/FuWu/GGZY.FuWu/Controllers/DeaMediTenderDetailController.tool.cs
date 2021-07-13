using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdDeaMediTenderDetailController:BaseController
    {
        /// <summary>
        /// 读取DEA_MEDI_TENDER_DETAIL列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadDeaMediTenderDetails(DEA_MEDI_TENDER_DETAIL model, SearchCondition condition)
        {
            var result = Fw.DeaMediTenderDetailService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取DEA_MEDI_TENDER_DETAIL明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadDeaMediTenderDetail(decimal M_ID)
        
        {
            var result = Fw.DeaMediTenderDetailService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建DEA_MEDI_TENDER_DETAIL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateDeaMediTenderDetail(DEA_MEDI_TENDER_DETAIL model)
        {
            var result = Fw.DeaMediTenderDetailService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新DEA_MEDI_TENDER_DETAIL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateDeaMediTenderDetail(DEA_MEDI_TENDER_DETAIL model)
        {
            var result = Fw.DeaMediTenderDetailService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除DEA_MEDI_TENDER_DETAIL信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteDeaMediTenderDetail(string ids)
        {
            var result = Fw.DeaMediTenderDetailService.Delete(ids);
            return JResult(result); 
        }
    }
}