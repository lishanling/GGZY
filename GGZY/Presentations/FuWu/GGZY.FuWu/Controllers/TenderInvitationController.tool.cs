using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTenderInvitationController:BaseController
    {
        /// <summary>
        /// 读取TENDER_INVITATION列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTenderInvitations(TENDER_INVITATION model, SearchCondition condition)
        {
            var result = Fw.TenderInvitationService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TENDER_INVITATION明细
        /// </summary>
      /// <param name="M_ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTenderInvitation(decimal M_ID)
        
        {
            var result = Fw.TenderInvitationService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TENDER_INVITATION信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTenderInvitation(TENDER_INVITATION model)
        {
            var result = Fw.TenderInvitationService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TENDER_INVITATION信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTenderInvitation(TENDER_INVITATION model)
        {
            var result = Fw.TenderInvitationService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TENDER_INVITATION信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTenderInvitation(string ids)
        {
            var result = Fw.TenderInvitationService.Delete(ids);
            return JResult(result); 
        }
    }
}