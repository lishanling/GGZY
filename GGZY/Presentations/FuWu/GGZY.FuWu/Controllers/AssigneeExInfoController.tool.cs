using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdAssigneeExInfoController:BaseController
    {
        /// <summary>
        /// 读取ASSIGNEE_EX_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadAssigneeExInfos(ASSIGNEE_EX_INFO model, SearchCondition condition)
        {
            var result = Fw.AssigneeExInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取ASSIGNEE_EX_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadAssigneeExInfo(decimal M_ID)
        
        {
            var result = Fw.AssigneeExInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建ASSIGNEE_EX_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateAssigneeExInfo(ASSIGNEE_EX_INFO model)
        {
            var result = Fw.AssigneeExInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新ASSIGNEE_EX_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateAssigneeExInfo(ASSIGNEE_EX_INFO model)
        {
            var result = Fw.AssigneeExInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除ASSIGNEE_EX_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteAssigneeExInfo(string ids)
        {
            var result = Fw.AssigneeExInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}