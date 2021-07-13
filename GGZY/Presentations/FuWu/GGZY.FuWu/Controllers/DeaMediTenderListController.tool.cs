using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdDeaMediTenderListController:BaseController
    {
        /// <summary>
        /// 读取DEA_MEDI_TENDER_LIST列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadDeaMediTenderLists(DEA_MEDI_TENDER_LIST model, SearchCondition condition)
        {
            var result = Fw.DeaMediTenderListService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取DEA_MEDI_TENDER_LIST明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadDeaMediTenderList(decimal M_ID)
        
        {
            var result = Fw.DeaMediTenderListService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建DEA_MEDI_TENDER_LIST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateDeaMediTenderList(DEA_MEDI_TENDER_LIST model)
        {
            var result = Fw.DeaMediTenderListService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新DEA_MEDI_TENDER_LIST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateDeaMediTenderList(DEA_MEDI_TENDER_LIST model)
        {
            var result = Fw.DeaMediTenderListService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除DEA_MEDI_TENDER_LIST信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteDeaMediTenderList(string ids)
        {
            var result = Fw.DeaMediTenderListService.Delete(ids);
            return JResult(result); 
        }
    }
}