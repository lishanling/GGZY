using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdViolatingLawsRulesInfoController:BaseController
    {
        /// <summary>
        /// 读取VIOLATING_LAWS_RULES_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadViolatingLawsRulesInfos(VIOLATING_LAWS_RULES_INFO model, SearchCondition condition)
        {
            var result = Fw.ViolatingLawsRulesInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取VIOLATING_LAWS_RULES_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadViolatingLawsRulesInfo(decimal M_ID)
        
        {
            var result = Fw.ViolatingLawsRulesInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建VIOLATING_LAWS_RULES_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateViolatingLawsRulesInfo(VIOLATING_LAWS_RULES_INFO model)
        {
            var result = Fw.ViolatingLawsRulesInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新VIOLATING_LAWS_RULES_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateViolatingLawsRulesInfo(VIOLATING_LAWS_RULES_INFO model)
        {
            var result = Fw.ViolatingLawsRulesInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除VIOLATING_LAWS_RULES_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteViolatingLawsRulesInfo(string ids)
        {
            var result = Fw.ViolatingLawsRulesInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}