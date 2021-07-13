using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdDeaMediNetPurchaseAnnoController:BaseController
    {
        /// <summary>
        /// 读取DEA_MEDI_NET_PURCHASE_ANNO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadDeaMediNetPurchaseAnnos(DEA_MEDI_NET_PURCHASE_ANNO model, SearchCondition condition)
        {
            var result = Fw.DeaMediNetPurchaseAnnoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取DEA_MEDI_NET_PURCHASE_ANNO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadDeaMediNetPurchaseAnno(decimal M_ID)
        
        {
            var result = Fw.DeaMediNetPurchaseAnnoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建DEA_MEDI_NET_PURCHASE_ANNO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateDeaMediNetPurchaseAnno(DEA_MEDI_NET_PURCHASE_ANNO model)
        {
            var result = Fw.DeaMediNetPurchaseAnnoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新DEA_MEDI_NET_PURCHASE_ANNO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateDeaMediNetPurchaseAnno(DEA_MEDI_NET_PURCHASE_ANNO model)
        {
            var result = Fw.DeaMediNetPurchaseAnnoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除DEA_MEDI_NET_PURCHASE_ANNO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteDeaMediNetPurchaseAnno(string ids)
        {
            var result = Fw.DeaMediNetPurchaseAnnoService.Delete(ids);
            return JResult(result); 
        }
    }
}