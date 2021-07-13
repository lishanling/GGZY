using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdDeaSewagePaidTransferAnnoController:BaseController
    {
        /// <summary>
        /// 读取DEA_SEWAGE_PAID_TRANSFER_ANNO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadDeaSewagePaidTransferAnnos(DEA_SEWAGE_PAID_TRANSFER_ANNO model, SearchCondition condition)
        {
            var result = Fw.DeaSewagePaidTransferAnnoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取DEA_SEWAGE_PAID_TRANSFER_ANNO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadDeaSewagePaidTransferAnno(decimal M_ID)
        
        {
            var result = Fw.DeaSewagePaidTransferAnnoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建DEA_SEWAGE_PAID_TRANSFER_ANNO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateDeaSewagePaidTransferAnno(DEA_SEWAGE_PAID_TRANSFER_ANNO model)
        {
            var result = Fw.DeaSewagePaidTransferAnnoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新DEA_SEWAGE_PAID_TRANSFER_ANNO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateDeaSewagePaidTransferAnno(DEA_SEWAGE_PAID_TRANSFER_ANNO model)
        {
            var result = Fw.DeaSewagePaidTransferAnnoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除DEA_SEWAGE_PAID_TRANSFER_ANNO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteDeaSewagePaidTransferAnno(string ids)
        {
            var result = Fw.DeaSewagePaidTransferAnnoService.Delete(ids);
            return JResult(result); 
        }
    }
}