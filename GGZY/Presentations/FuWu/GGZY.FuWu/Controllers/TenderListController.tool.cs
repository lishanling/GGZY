using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTenderListController:BaseController
    {
        /// <summary>
        /// 读取TENDER_LIST列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTenderLists(TENDER_LIST model, SearchCondition condition)
        {
            var result = Fw.TenderListService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TENDER_LIST明细
        /// </summary>
      /// <param name="M_ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTenderList(decimal M_ID)
        
        {
            var result = Fw.TenderListService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TENDER_LIST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTenderList(TENDER_LIST model)
        {
            var result = Fw.TenderListService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TENDER_LIST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTenderList(TENDER_LIST model)
        {
            var result = Fw.TenderListService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TENDER_LIST信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTenderList(string ids)
        {
            var result = Fw.TenderListService.Delete(ids);
            return JResult(result); 
        }
    }
}