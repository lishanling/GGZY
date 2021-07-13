using System;
using System.Web.Mvc;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    //[RoutePrefix("auth_rule/method")]
    public partial class TUserPopedomV2Controller : BaseController
    {

        /// <summary>
        /// 添加一条规则
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("auth_rule/method/set.auth.rule.item")]
        [Route("TUserPopedomV2/SetAuthRuleItem")]
        public ActionResult SetAuthRuleItem(GeneralAuthRule model)
        {
            var r = Jd.TUserPopedomV2Service.SetAuthRuleItem(model);
            return JResult(r);
        }

        /// <summary>
        /// 获取一条规则
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("auth_rule/method/get.auth.rule.item")]
        [Route("TUserPopedomV2/GetAuthRuleItem")]
        public ActionResult GetAuthRuleItem(GeneralAuthRule model)
        {
            var r = Jd.TUserPopedomV2Service.GetAuthRuleItem(model);
            return JResult(r);
        }

        /// <summary>
        /// 添加一条规则
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("auth_rule/method/add.auth.rule.item")]
        [Route("TUserPopedomV2/AddAuthRuleItem")]
        public ActionResult AddAuthRuleItem(GeneralAuthRule model)
        {
            var r = Jd.TUserPopedomV2Service.AddAuthRuleItem(model);
            return JResult(r);
        }
        /// <summary>
        /// 批量删除规则
        /// </summary>
        /// <param name="rule_id"></param>
        /// <returns></returns>
        [Route("auth_rule/method/del.auth.rule.list")]
        [Route("TUserPopedomV2/DelAuthRuleList")]
        public ActionResult DelAuthRuleList(params string[] rule_id)
        {
            var r = Jd.TUserPopedomV2Service.Delete(rule_id);
            return JResult(r);
        }
        /// <summary>
        /// 获取规则列表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("auth_rule/method/get.auth.rule.list")]
        [Route("TUserPopedomV2/GetAuthRuleList")]
        public ActionResult GetAuthRuleList(GeneralAuthRule model)
        {
            var r = Jd.TUserPopedomV2Service.GetAuthRuleList(model);
            return JResult(r);
        }

        /// <summary>
        /// 设置规则排序
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("auth_rule/method/set.auth.rule.sort")]
        [Route("TUserPopedomV2/SetAuthRuleSort")]
        public ActionResult SetAuthRuleSort(GeneralAuthRule model)
        {
            var r = Jd.TUserPopedomV2Service.SetAuthRuleSort(model);
            return JResult(r);
        }

        /// <summary>
        /// 菜单规则初始化
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("auth_rule/method/set.auth.rule.init")]
        [Route("TUserPopedomV2/SetMenuInit")]
        public ActionResult SetMenuInit(GeneralMenu model)
        {
            var r = Jd.TUserPopedomV2Service.Initial();
            return JResult(r);
        }
    }
}