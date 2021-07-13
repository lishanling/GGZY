using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdPaymentManageController:BaseController
    {
        /// <summary>
        /// 读取PAYMENT_MANAGE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadPaymentManages(PAYMENT_MANAGE model, SearchCondition condition)
        {
            var result = Fw.PaymentManageService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PAYMENT_MANAGE明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadPaymentManage(decimal ID)
        
        {
            var result = Fw.PaymentManageService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PAYMENT_MANAGE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreatePaymentManage(PAYMENT_MANAGE model)
        {
            var result = Fw.PaymentManageService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PAYMENT_MANAGE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdatePaymentManage(PAYMENT_MANAGE model)
        {
            var result = Fw.PaymentManageService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PAYMENT_MANAGE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeletePaymentManage(string ids)
        {
            var result = Fw.PaymentManageService.Delete(ids);
            return JResult(result); 
        }
    }
}