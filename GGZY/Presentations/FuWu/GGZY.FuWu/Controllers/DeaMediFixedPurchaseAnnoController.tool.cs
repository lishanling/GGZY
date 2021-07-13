using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdDeaMediFixedPurchaseAnnoController:BaseController
    {
        /// <summary>
        /// 读取DEA_MEDI_FIXED_PURCHASE_ANNO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadDeaMediFixedPurchaseAnnos(DEA_MEDI_FIXED_PURCHASE_ANNO model, SearchCondition condition)
        {
            var result = Fw.DeaMediFixedPurchaseAnnoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取DEA_MEDI_FIXED_PURCHASE_ANNO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadDeaMediFixedPurchaseAnno(decimal M_ID)
        
        {
            var result = Fw.DeaMediFixedPurchaseAnnoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建DEA_MEDI_FIXED_PURCHASE_ANNO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateDeaMediFixedPurchaseAnno(DEA_MEDI_FIXED_PURCHASE_ANNO model)
        {
            var result = Fw.DeaMediFixedPurchaseAnnoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新DEA_MEDI_FIXED_PURCHASE_ANNO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateDeaMediFixedPurchaseAnno(DEA_MEDI_FIXED_PURCHASE_ANNO model)
        {
            var result = Fw.DeaMediFixedPurchaseAnnoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除DEA_MEDI_FIXED_PURCHASE_ANNO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteDeaMediFixedPurchaseAnno(string ids)
        {
            var result = Fw.DeaMediFixedPurchaseAnnoService.Delete(ids);
            return JResult(result); 
        }
    }
}