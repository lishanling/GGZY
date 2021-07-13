using System.Web.Mvc;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Portal.Controllers
{
    /// <summary>
    /// 主体资信
    /// </summary>
    [AllowAnonymous]
    public class PrincipalController : BaseController
    {
        #region 主体资信

        /// <summary>
        /// 基本信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="roleType"></param>
        /// <returns></returns>
        public ActionResult Credit(string id, string roleType = "01")
        {
            var r = Fw.CommonService.SearchDetail(id, roleType);
            return JResult(r);
        }
        /// <summary>
        /// 违法违规
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult IllegalList(SearchCondition search)
        {
            var r = Fw.ViolatingLawsRulesInfoService.FindViolatingLawsRulesInfoPageListByLegalCode(search);
            return JResult(r);
        }
        /// <summary>
        /// 黑名单
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult BlackList(SearchCondition search)
        {
            var r = Fw.BlackListService.FindBlackListByLegalCode(search);
            return JResult(r);
        }
        /// <summary>
        /// 资质信息
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult ExtInfo(SearchCondition search)
        {
            var r = Fw.CommonService.ExtInfo(search, search.Type);
            return JResult(r);
        }

        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult CreditList(LEGAL_PERSON_BASE model, SearchCondition search)
        {
            var result = new GeneralResult();
            if (!"1,2,3,99".Contains(model.LEGAL_ROLE))
            {
                result.SetFail("参数非法");
            }
            else
            {

                if (model.LEGAL_ROLE == "99")
                {
                    var r1 = Fw.TUserTradeplatformService.PageTable(new T_USER_TRADEPLATFORM
                    {
                        PLATFORM_CODE = model.LEGAL_CODE,
                        SYSTEM_NAME = model.LEGAL_NAME
                    }, search);
                    result.SetSuccess(r1);
                }
                else
                {
                    var r = Fw.LegalPersonBaseService.CreditPageList(model, search);
                    result.SetSuccess(r);
                }

            }
            return JResult(result);
        }
        /// <summary>
        /// 交易主体计数
        /// </summary>
        /// <returns></returns>
        public ActionResult CreditCount(LEGAL_PERSON_BASE model, SearchCondition search)
        {
            int count;
            if (model.LEGAL_ROLE == "99")
            {
                count = Fw.TUserTradeplatformService.Count(new T_USER_TRADEPLATFORM
                {
                    PLATFORM_CODE = model.LEGAL_CODE,
                    SYSTEM_NAME = model.LEGAL_NAME
                }, search);
            }
            else
            {
                count = Fw.LegalPersonBaseService.CreditCount(model, search);
            }

            return JResult(new { Count = count });
        }
    }
}