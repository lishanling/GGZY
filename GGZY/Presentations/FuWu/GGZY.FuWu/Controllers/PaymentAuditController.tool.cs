using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdPaymentAuditController:BaseController
    {
        /// <summary>
        /// 读取PAYMENT_AUDIT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadPaymentAudits(PAYMENT_AUDIT model, SearchCondition condition)
        {
            var result = Fw.PaymentAuditService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PAYMENT_AUDIT明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadPaymentAudit(decimal ID)
        
        {
            var result = Fw.PaymentAuditService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PAYMENT_AUDIT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreatePaymentAudit(PAYMENT_AUDIT model)
        {
            var result = Fw.PaymentAuditService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PAYMENT_AUDIT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdatePaymentAudit(PAYMENT_AUDIT model)
        {
            var result = Fw.PaymentAuditService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PAYMENT_AUDIT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeletePaymentAudit(string ids)
        {
            var result = Fw.PaymentAuditService.Delete(ids);
            return JResult(result); 
        }
    }
}