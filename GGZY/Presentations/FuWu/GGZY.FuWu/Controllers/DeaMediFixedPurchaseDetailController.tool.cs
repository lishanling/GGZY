using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdDeaMediFixedPurchaseDetailController:BaseController
    {
        /// <summary>
        /// 读取DEA_MEDI_FIXED_PURCHASE_DETAIL列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadDeaMediFixedPurchaseDetails(DEA_MEDI_FIXED_PURCHASE_DETAIL model, SearchCondition condition)
        {
            var result = Fw.DeaMediFixedPurchaseDetailService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取DEA_MEDI_FIXED_PURCHASE_DETAIL明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadDeaMediFixedPurchaseDetail(decimal M_ID)
        
        {
            var result = Fw.DeaMediFixedPurchaseDetailService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建DEA_MEDI_FIXED_PURCHASE_DETAIL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateDeaMediFixedPurchaseDetail(DEA_MEDI_FIXED_PURCHASE_DETAIL model)
        {
            var result = Fw.DeaMediFixedPurchaseDetailService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新DEA_MEDI_FIXED_PURCHASE_DETAIL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateDeaMediFixedPurchaseDetail(DEA_MEDI_FIXED_PURCHASE_DETAIL model)
        {
            var result = Fw.DeaMediFixedPurchaseDetailService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除DEA_MEDI_FIXED_PURCHASE_DETAIL信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteDeaMediFixedPurchaseDetail(string ids)
        {
            var result = Fw.DeaMediFixedPurchaseDetailService.Delete(ids);
            return JResult(result); 
        }
    }
}