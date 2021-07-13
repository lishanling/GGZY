using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdYdRequisitionController:BaseController
    {
        /// <summary>
        /// 读取YD_REQUISITION列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadYdRequisitions(YD_REQUISITION model, SearchCondition condition)
        {
            var result = Fw.YdRequisitionService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取YD_REQUISITION明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadYdRequisition(decimal ID)
        
        {
            var result = Fw.YdRequisitionService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建YD_REQUISITION信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateYdRequisition(YD_REQUISITION model)
        {
            var result = Fw.YdRequisitionService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新YD_REQUISITION信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateYdRequisition(YD_REQUISITION model)
        {
            var result = Fw.YdRequisitionService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除YD_REQUISITION信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteYdRequisition(string ids)
        {
            var result = Fw.YdRequisitionService.Delete(ids);
            return JResult(result); 
        }
    }
}