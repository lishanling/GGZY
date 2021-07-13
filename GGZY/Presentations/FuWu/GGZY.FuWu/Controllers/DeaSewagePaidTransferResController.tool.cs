using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdDeaSewagePaidTransferResController:BaseController
    {
        /// <summary>
        /// 读取DEA_SEWAGE_PAID_TRANSFER_RES列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadDeaSewagePaidTransferRess(DEA_SEWAGE_PAID_TRANSFER_RES model, SearchCondition condition)
        {
            var result = Fw.DeaSewagePaidTransferResService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取DEA_SEWAGE_PAID_TRANSFER_RES明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadDeaSewagePaidTransferRes(decimal M_ID)
        
        {
            var result = Fw.DeaSewagePaidTransferResService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建DEA_SEWAGE_PAID_TRANSFER_RES信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateDeaSewagePaidTransferRes(DEA_SEWAGE_PAID_TRANSFER_RES model)
        {
            var result = Fw.DeaSewagePaidTransferResService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新DEA_SEWAGE_PAID_TRANSFER_RES信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateDeaSewagePaidTransferRes(DEA_SEWAGE_PAID_TRANSFER_RES model)
        {
            var result = Fw.DeaSewagePaidTransferResService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除DEA_SEWAGE_PAID_TRANSFER_RES信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteDeaSewagePaidTransferRes(string ids)
        {
            var result = Fw.DeaSewagePaidTransferResService.Delete(ids);
            return JResult(result); 
        }
    }
}