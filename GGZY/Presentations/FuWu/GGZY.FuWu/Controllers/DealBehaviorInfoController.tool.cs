using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdDealBehaviorInfoController:BaseController
    {
        /// <summary>
        /// 读取DEAL_BEHAVIOR_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadDealBehaviorInfos(DEAL_BEHAVIOR_INFO model, SearchCondition condition)
        {
            var result = Fw.DealBehaviorInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取DEAL_BEHAVIOR_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadDealBehaviorInfo(decimal M_ID)
        
        {
            var result = Fw.DealBehaviorInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建DEAL_BEHAVIOR_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateDealBehaviorInfo(DEAL_BEHAVIOR_INFO model)
        {
            var result = Fw.DealBehaviorInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新DEAL_BEHAVIOR_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateDealBehaviorInfo(DEAL_BEHAVIOR_INFO model)
        {
            var result = Fw.DealBehaviorInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除DEAL_BEHAVIOR_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteDealBehaviorInfo(string ids)
        {
            var result = Fw.DealBehaviorInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}