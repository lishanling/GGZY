using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdBhSendApplicationFormController:BaseController
    {
        /// <summary>
        /// 读取BH_SEND_APPLICATION_FORM列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadBhSendApplicationForms(BH_SEND_APPLICATION_FORM model, SearchCondition condition)
        {
            var result = Fw.BhSendApplicationFormService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取BH_SEND_APPLICATION_FORM明细
        /// </summary>
      /// <param name="M_ID">自增长ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadBhSendApplicationForm(decimal M_ID)
        
        {
            var result = Fw.BhSendApplicationFormService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建BH_SEND_APPLICATION_FORM信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateBhSendApplicationForm(BH_SEND_APPLICATION_FORM model)
        {
            var result = Fw.BhSendApplicationFormService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新BH_SEND_APPLICATION_FORM信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateBhSendApplicationForm(BH_SEND_APPLICATION_FORM model)
        {
            var result = Fw.BhSendApplicationFormService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除BH_SEND_APPLICATION_FORM信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteBhSendApplicationForm(string ids)
        {
            var result = Fw.BhSendApplicationFormService.Delete(ids);
            return JResult(result); 
        }
    }
}