using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdDeaCarbonQuotaSellResultController:BaseController
    {
        /// <summary>
        /// 读取DEA_CARBON_QUOTA_SELL_RESULT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadDeaCarbonQuotaSellResults(DEA_CARBON_QUOTA_SELL_RESULT model, SearchCondition condition)
        {
            var result = Fw.DeaCarbonQuotaSellResultService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取DEA_CARBON_QUOTA_SELL_RESULT明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadDeaCarbonQuotaSellResult(decimal M_ID)
        
        {
            var result = Fw.DeaCarbonQuotaSellResultService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建DEA_CARBON_QUOTA_SELL_RESULT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateDeaCarbonQuotaSellResult(DEA_CARBON_QUOTA_SELL_RESULT model)
        {
            var result = Fw.DeaCarbonQuotaSellResultService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新DEA_CARBON_QUOTA_SELL_RESULT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateDeaCarbonQuotaSellResult(DEA_CARBON_QUOTA_SELL_RESULT model)
        {
            var result = Fw.DeaCarbonQuotaSellResultService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除DEA_CARBON_QUOTA_SELL_RESULT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteDeaCarbonQuotaSellResult(string ids)
        {
            var result = Fw.DeaCarbonQuotaSellResultService.Delete(ids);
            return JResult(result); 
        }
    }
}