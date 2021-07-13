using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdDeaMediNetPurchaseDetailController:BaseController
    {
        /// <summary>
        /// 读取DEA_MEDI_NET_PURCHASE_DETAIL列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadDeaMediNetPurchaseDetails(DEA_MEDI_NET_PURCHASE_DETAIL model, SearchCondition condition)
        {
            var result = Fw.DeaMediNetPurchaseDetailService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取DEA_MEDI_NET_PURCHASE_DETAIL明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadDeaMediNetPurchaseDetail(decimal M_ID)
        
        {
            var result = Fw.DeaMediNetPurchaseDetailService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建DEA_MEDI_NET_PURCHASE_DETAIL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateDeaMediNetPurchaseDetail(DEA_MEDI_NET_PURCHASE_DETAIL model)
        {
            var result = Fw.DeaMediNetPurchaseDetailService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新DEA_MEDI_NET_PURCHASE_DETAIL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateDeaMediNetPurchaseDetail(DEA_MEDI_NET_PURCHASE_DETAIL model)
        {
            var result = Fw.DeaMediNetPurchaseDetailService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除DEA_MEDI_NET_PURCHASE_DETAIL信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteDeaMediNetPurchaseDetail(string ids)
        {
            var result = Fw.DeaMediNetPurchaseDetailService.Delete(ids);
            return JResult(result); 
        }
    }
}