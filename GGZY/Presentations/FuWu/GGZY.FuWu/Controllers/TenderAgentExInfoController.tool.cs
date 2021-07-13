using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTenderAgentExInfoController:BaseController
    {
        /// <summary>
        /// 读取TENDER_AGENT_EX_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTenderAgentExInfos(TENDER_AGENT_EX_INFO model, SearchCondition condition)
        {
            var result = Fw.TenderAgentExInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TENDER_AGENT_EX_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTenderAgentExInfo(decimal M_ID)
        
        {
            var result = Fw.TenderAgentExInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TENDER_AGENT_EX_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTenderAgentExInfo(TENDER_AGENT_EX_INFO model)
        {
            var result = Fw.TenderAgentExInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TENDER_AGENT_EX_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTenderAgentExInfo(TENDER_AGENT_EX_INFO model)
        {
            var result = Fw.TenderAgentExInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TENDER_AGENT_EX_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTenderAgentExInfo(string ids)
        {
            var result = Fw.TenderAgentExInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}