using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdPurchaseQualiInqueryAnnController:BaseController
    {
        /// <summary>
        /// 读取PURCHASE_QUALI_INQUERY_ANN列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadPurchaseQualiInqueryAnns(PURCHASE_QUALI_INQUERY_ANN model, SearchCondition condition)
        {
            var result = Fw.PurchaseQualiInqueryAnnService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PURCHASE_QUALI_INQUERY_ANN明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadPurchaseQualiInqueryAnn(decimal M_ID)
        
        {
            var result = Fw.PurchaseQualiInqueryAnnService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PURCHASE_QUALI_INQUERY_ANN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreatePurchaseQualiInqueryAnn(PURCHASE_QUALI_INQUERY_ANN model)
        {
            var result = Fw.PurchaseQualiInqueryAnnService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PURCHASE_QUALI_INQUERY_ANN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdatePurchaseQualiInqueryAnn(PURCHASE_QUALI_INQUERY_ANN model)
        {
            var result = Fw.PurchaseQualiInqueryAnnService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PURCHASE_QUALI_INQUERY_ANN信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeletePurchaseQualiInqueryAnn(string ids)
        {
            var result = Fw.PurchaseQualiInqueryAnnService.Delete(ids);
            return JResult(result); 
        }
    }
}