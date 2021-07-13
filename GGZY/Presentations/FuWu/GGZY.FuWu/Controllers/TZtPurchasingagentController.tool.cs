using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTZtPurchasingagentController:BaseController
    {
        /// <summary>
        /// 读取T_ZT_PURCHASINGAGENT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTZtPurchasingagents(T_ZT_PURCHASINGAGENT model, SearchCondition condition)
        {
            var result = Fw.TZtPurchasingagentService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_ZT_PURCHASINGAGENT明细
        /// </summary>
      /// <param name="LEGALCODE">主体代码</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTZtPurchasingagent(string LEGALCODE)
        
        {
            var result = Fw.TZtPurchasingagentService.ViewByPk(LEGALCODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_ZT_PURCHASINGAGENT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTZtPurchasingagent(T_ZT_PURCHASINGAGENT model)
        {
            var result = Fw.TZtPurchasingagentService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_ZT_PURCHASINGAGENT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTZtPurchasingagent(T_ZT_PURCHASINGAGENT model)
        {
            var result = Fw.TZtPurchasingagentService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_ZT_PURCHASINGAGENT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTZtPurchasingagent(string ids)
        {
            var result = Fw.TZtPurchasingagentService.Delete(ids);
            return JResult(result); 
        }
    }
}