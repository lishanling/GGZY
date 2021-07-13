using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdDeaSewageAssigneeListController:BaseController
    {
        /// <summary>
        /// 读取DEA_SEWAGE_ASSIGNEE_LIST列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadDeaSewageAssigneeLists(DEA_SEWAGE_ASSIGNEE_LIST model, SearchCondition condition)
        {
            var result = Fw.DeaSewageAssigneeListService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取DEA_SEWAGE_ASSIGNEE_LIST明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadDeaSewageAssigneeList(decimal M_ID)
        
        {
            var result = Fw.DeaSewageAssigneeListService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建DEA_SEWAGE_ASSIGNEE_LIST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateDeaSewageAssigneeList(DEA_SEWAGE_ASSIGNEE_LIST model)
        {
            var result = Fw.DeaSewageAssigneeListService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新DEA_SEWAGE_ASSIGNEE_LIST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateDeaSewageAssigneeList(DEA_SEWAGE_ASSIGNEE_LIST model)
        {
            var result = Fw.DeaSewageAssigneeListService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除DEA_SEWAGE_ASSIGNEE_LIST信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteDeaSewageAssigneeList(string ids)
        {
            var result = Fw.DeaSewageAssigneeListService.Delete(ids);
            return JResult(result); 
        }
    }
}