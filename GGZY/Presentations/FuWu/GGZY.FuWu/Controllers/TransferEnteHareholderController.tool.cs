using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTransferEnteHareholderController:BaseController
    {
        /// <summary>
        /// 读取TRANSFER_ENTE_HAREHOLDER列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTransferEnteHareholders(TRANSFER_ENTE_HAREHOLDER model, SearchCondition condition)
        {
            var result = Fw.TransferEnteHareholderService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TRANSFER_ENTE_HAREHOLDER明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTransferEnteHareholder(decimal M_ID)
        
        {
            var result = Fw.TransferEnteHareholderService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TRANSFER_ENTE_HAREHOLDER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTransferEnteHareholder(TRANSFER_ENTE_HAREHOLDER model)
        {
            var result = Fw.TransferEnteHareholderService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TRANSFER_ENTE_HAREHOLDER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTransferEnteHareholder(TRANSFER_ENTE_HAREHOLDER model)
        {
            var result = Fw.TransferEnteHareholderService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TRANSFER_ENTE_HAREHOLDER信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTransferEnteHareholder(string ids)
        {
            var result = Fw.TransferEnteHareholderService.Delete(ids);
            return JResult(result); 
        }
    }
}