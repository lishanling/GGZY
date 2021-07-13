using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdIndividualAssigneeExInfoController:BaseController
    {
        /// <summary>
        /// 读取INDIVIDUAL_ASSIGNEE_EX_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadIndividualAssigneeExInfos(INDIVIDUAL_ASSIGNEE_EX_INFO model, SearchCondition condition)
        {
            var result = Fw.IndividualAssigneeExInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取INDIVIDUAL_ASSIGNEE_EX_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadIndividualAssigneeExInfo(decimal M_ID)
        
        {
            var result = Fw.IndividualAssigneeExInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建INDIVIDUAL_ASSIGNEE_EX_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateIndividualAssigneeExInfo(INDIVIDUAL_ASSIGNEE_EX_INFO model)
        {
            var result = Fw.IndividualAssigneeExInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新INDIVIDUAL_ASSIGNEE_EX_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateIndividualAssigneeExInfo(INDIVIDUAL_ASSIGNEE_EX_INFO model)
        {
            var result = Fw.IndividualAssigneeExInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除INDIVIDUAL_ASSIGNEE_EX_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteIndividualAssigneeExInfo(string ids)
        {
            var result = Fw.IndividualAssigneeExInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}