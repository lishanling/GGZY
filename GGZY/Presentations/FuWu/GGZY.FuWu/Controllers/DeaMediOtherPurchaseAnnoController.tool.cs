using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdDeaMediOtherPurchaseAnnoController:BaseController
    {
        /// <summary>
        /// 读取DEA_MEDI_OTHER_PURCHASE_ANNO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadDeaMediOtherPurchaseAnnos(DEA_MEDI_OTHER_PURCHASE_ANNO model, SearchCondition condition)
        {
            var result = Fw.DeaMediOtherPurchaseAnnoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取DEA_MEDI_OTHER_PURCHASE_ANNO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadDeaMediOtherPurchaseAnno(decimal M_ID)
        
        {
            var result = Fw.DeaMediOtherPurchaseAnnoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建DEA_MEDI_OTHER_PURCHASE_ANNO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateDeaMediOtherPurchaseAnno(DEA_MEDI_OTHER_PURCHASE_ANNO model)
        {
            var result = Fw.DeaMediOtherPurchaseAnnoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新DEA_MEDI_OTHER_PURCHASE_ANNO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateDeaMediOtherPurchaseAnno(DEA_MEDI_OTHER_PURCHASE_ANNO model)
        {
            var result = Fw.DeaMediOtherPurchaseAnnoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除DEA_MEDI_OTHER_PURCHASE_ANNO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteDeaMediOtherPurchaseAnno(string ids)
        {
            var result = Fw.DeaMediOtherPurchaseAnnoService.Delete(ids);
            return JResult(result); 
        }
    }
}