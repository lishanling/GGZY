using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdDeaMediNegoPurchaseDetailController:BaseController
    {
        /// <summary>
        /// 读取DEA_MEDI_NEGO_PURCHASE_DETAIL列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadDeaMediNegoPurchaseDetails(DEA_MEDI_NEGO_PURCHASE_DETAIL model, SearchCondition condition)
        {
            var result = Fw.DeaMediNegoPurchaseDetailService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取DEA_MEDI_NEGO_PURCHASE_DETAIL明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadDeaMediNegoPurchaseDetail(decimal M_ID)
        
        {
            var result = Fw.DeaMediNegoPurchaseDetailService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建DEA_MEDI_NEGO_PURCHASE_DETAIL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateDeaMediNegoPurchaseDetail(DEA_MEDI_NEGO_PURCHASE_DETAIL model)
        {
            var result = Fw.DeaMediNegoPurchaseDetailService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新DEA_MEDI_NEGO_PURCHASE_DETAIL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateDeaMediNegoPurchaseDetail(DEA_MEDI_NEGO_PURCHASE_DETAIL model)
        {
            var result = Fw.DeaMediNegoPurchaseDetailService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除DEA_MEDI_NEGO_PURCHASE_DETAIL信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteDeaMediNegoPurchaseDetail(string ids)
        {
            var result = Fw.DeaMediNegoPurchaseDetailService.Delete(ids);
            return JResult(result); 
        }
    }
}