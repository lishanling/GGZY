using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTransferEnteHolderPreController:BaseController
    {
        /// <summary>
        /// 读取TRANSFER_ENTE_HOLDER_PRE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTransferEnteHolderPres(TRANSFER_ENTE_HOLDER_PRE model, SearchCondition condition)
        {
            var result = Fw.TransferEnteHolderPreService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TRANSFER_ENTE_HOLDER_PRE明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTransferEnteHolderPre(decimal M_ID)
        
        {
            var result = Fw.TransferEnteHolderPreService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TRANSFER_ENTE_HOLDER_PRE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTransferEnteHolderPre(TRANSFER_ENTE_HOLDER_PRE model)
        {
            var result = Fw.TransferEnteHolderPreService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TRANSFER_ENTE_HOLDER_PRE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTransferEnteHolderPre(TRANSFER_ENTE_HOLDER_PRE model)
        {
            var result = Fw.TransferEnteHolderPreService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TRANSFER_ENTE_HOLDER_PRE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTransferEnteHolderPre(string ids)
        {
            var result = Fw.TransferEnteHolderPreService.Delete(ids);
            return JResult(result); 
        }
    }
}