using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTransferEnteInfoPreController:BaseController
    {
        /// <summary>
        /// 读取TRANSFER_ENTE_INFO_PRE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTransferEnteInfoPres(TRANSFER_ENTE_INFO_PRE model, SearchCondition condition)
        {
            var result = Fw.TransferEnteInfoPreService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TRANSFER_ENTE_INFO_PRE明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTransferEnteInfoPre(decimal M_ID)
        
        {
            var result = Fw.TransferEnteInfoPreService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TRANSFER_ENTE_INFO_PRE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTransferEnteInfoPre(TRANSFER_ENTE_INFO_PRE model)
        {
            var result = Fw.TransferEnteInfoPreService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TRANSFER_ENTE_INFO_PRE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTransferEnteInfoPre(TRANSFER_ENTE_INFO_PRE model)
        {
            var result = Fw.TransferEnteInfoPreService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TRANSFER_ENTE_INFO_PRE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTransferEnteInfoPre(string ids)
        {
            var result = Fw.TransferEnteInfoPreService.Delete(ids);
            return JResult(result); 
        }
    }
}