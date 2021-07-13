using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTransferEnteInfoController:BaseController
    {
        /// <summary>
        /// 读取TRANSFER_ENTE_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTransferEnteInfos(TRANSFER_ENTE_INFO model, SearchCondition condition)
        {
            var result = Fw.TransferEnteInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TRANSFER_ENTE_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTransferEnteInfo(decimal M_ID)
        
        {
            var result = Fw.TransferEnteInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TRANSFER_ENTE_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTransferEnteInfo(TRANSFER_ENTE_INFO model)
        {
            var result = Fw.TransferEnteInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TRANSFER_ENTE_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTransferEnteInfo(TRANSFER_ENTE_INFO model)
        {
            var result = Fw.TransferEnteInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TRANSFER_ENTE_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTransferEnteInfo(string ids)
        {
            var result = Fw.TransferEnteInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}