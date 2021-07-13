using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdBhSendClaimFormController:BaseController
    {
        /// <summary>
        /// 读取BH_SEND_CLAIM_FORM列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadBhSendClaimForms(BH_SEND_CLAIM_FORM model, SearchCondition condition)
        {
            var result = Fw.BhSendClaimFormService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取BH_SEND_CLAIM_FORM明细
        /// </summary>
      /// <param name="M_ID">自增长ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadBhSendClaimForm(decimal M_ID)
        
        {
            var result = Fw.BhSendClaimFormService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建BH_SEND_CLAIM_FORM信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateBhSendClaimForm(BH_SEND_CLAIM_FORM model)
        {
            var result = Fw.BhSendClaimFormService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新BH_SEND_CLAIM_FORM信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateBhSendClaimForm(BH_SEND_CLAIM_FORM model)
        {
            var result = Fw.BhSendClaimFormService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除BH_SEND_CLAIM_FORM信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteBhSendClaimForm(string ids)
        {
            var result = Fw.BhSendClaimFormService.Delete(ids);
            return JResult(result); 
        }
    }
}