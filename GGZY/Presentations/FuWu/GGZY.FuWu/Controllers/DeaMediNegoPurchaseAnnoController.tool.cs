using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdDeaMediNegoPurchaseAnnoController:BaseController
    {
        /// <summary>
        /// 读取DEA_MEDI_NEGO_PURCHASE_ANNO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadDeaMediNegoPurchaseAnnos(DEA_MEDI_NEGO_PURCHASE_ANNO model, SearchCondition condition)
        {
            var result = Fw.DeaMediNegoPurchaseAnnoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取DEA_MEDI_NEGO_PURCHASE_ANNO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadDeaMediNegoPurchaseAnno(decimal M_ID)
        
        {
            var result = Fw.DeaMediNegoPurchaseAnnoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建DEA_MEDI_NEGO_PURCHASE_ANNO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateDeaMediNegoPurchaseAnno(DEA_MEDI_NEGO_PURCHASE_ANNO model)
        {
            var result = Fw.DeaMediNegoPurchaseAnnoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新DEA_MEDI_NEGO_PURCHASE_ANNO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateDeaMediNegoPurchaseAnno(DEA_MEDI_NEGO_PURCHASE_ANNO model)
        {
            var result = Fw.DeaMediNegoPurchaseAnnoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除DEA_MEDI_NEGO_PURCHASE_ANNO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteDeaMediNegoPurchaseAnno(string ids)
        {
            var result = Fw.DeaMediNegoPurchaseAnnoService.Delete(ids);
            return JResult(result); 
        }
    }
}