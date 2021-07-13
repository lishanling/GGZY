using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdPurchaseAgentExInfoController:BaseController
    {
        /// <summary>
        /// 读取PURCHASE_AGENT_EX_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadPurchaseAgentExInfos(PURCHASE_AGENT_EX_INFO model, SearchCondition condition)
        {
            var result = Fw.PurchaseAgentExInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PURCHASE_AGENT_EX_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadPurchaseAgentExInfo(decimal M_ID)
        
        {
            var result = Fw.PurchaseAgentExInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PURCHASE_AGENT_EX_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreatePurchaseAgentExInfo(PURCHASE_AGENT_EX_INFO model)
        {
            var result = Fw.PurchaseAgentExInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PURCHASE_AGENT_EX_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdatePurchaseAgentExInfo(PURCHASE_AGENT_EX_INFO model)
        {
            var result = Fw.PurchaseAgentExInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PURCHASE_AGENT_EX_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeletePurchaseAgentExInfo(string ids)
        {
            var result = Fw.PurchaseAgentExInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}