using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTenderAnnQuaInqueryAnnController:BaseController
    {
        /// <summary>
        /// 读取TENDER_ANN_QUA_INQUERY_ANN列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTenderAnnQuaInqueryAnns(TENDER_ANN_QUA_INQUERY_ANN model, SearchCondition condition)
        {
            var result = Fw.TenderAnnQuaInqueryAnnService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TENDER_ANN_QUA_INQUERY_ANN明细
        /// </summary>
      /// <param name="M_ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTenderAnnQuaInqueryAnn(decimal M_ID)
        
        {
            var result = Fw.TenderAnnQuaInqueryAnnService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TENDER_ANN_QUA_INQUERY_ANN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTenderAnnQuaInqueryAnn(TENDER_ANN_QUA_INQUERY_ANN model)
        {
            var result = Fw.TenderAnnQuaInqueryAnnService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TENDER_ANN_QUA_INQUERY_ANN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTenderAnnQuaInqueryAnn(TENDER_ANN_QUA_INQUERY_ANN model)
        {
            var result = Fw.TenderAnnQuaInqueryAnnService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TENDER_ANN_QUA_INQUERY_ANN信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTenderAnnQuaInqueryAnn(string ids)
        {
            var result = Fw.TenderAnnQuaInqueryAnnService.Delete(ids);
            return JResult(result); 
        }
    }
}