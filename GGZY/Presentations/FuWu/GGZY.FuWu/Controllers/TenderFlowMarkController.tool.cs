using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTenderFlowMarkController:BaseController
    {
        /// <summary>
        /// 读取TENDER_FLOW_MARK列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTenderFlowMarks(TENDER_FLOW_MARK model, SearchCondition condition)
        {
            var result = Fw.TenderFlowMarkService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TENDER_FLOW_MARK明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTenderFlowMark(decimal M_ID)
        
        {
            var result = Fw.TenderFlowMarkService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TENDER_FLOW_MARK信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTenderFlowMark(TENDER_FLOW_MARK model)
        {
            var result = Fw.TenderFlowMarkService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TENDER_FLOW_MARK信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTenderFlowMark(TENDER_FLOW_MARK model)
        {
            var result = Fw.TenderFlowMarkService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TENDER_FLOW_MARK信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTenderFlowMark(string ids)
        {
            var result = Fw.TenderFlowMarkService.Delete(ids);
            return JResult(result); 
        }
    }
}