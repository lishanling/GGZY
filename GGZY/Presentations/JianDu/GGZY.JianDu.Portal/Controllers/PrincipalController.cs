using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using GGZYFW.DbEntity;
using PullData;
using PullData.Model;

namespace GGZY.JianDu.Portal.Controllers
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
            if (model.LEGAL_ROLE == "99")
            {
                var r1 = Fw.TUserTradeplatformService.PageTable(new T_USER_TRADEPLATFORM
                {
                    PLATFORM_CODE = model.LEGAL_CODE,
                    SYSTEM_NAME = model.LEGAL_NAME
                }, search);
                return JResult(r1);
            }
            var r = Fw.LegalPersonBaseService.CreditPageList(model, search);
            return JResult(r);
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
           
            return JResult(new{Count= count });
        }

        public ActionResult Punishment(string legalCode)
        {
           // string companyName = "91440300MA5DAJ3J91";
            //string companyName = "91350212562842576W";
            Main main = new Main();
            PoorCreditResult c = main.CheckOrg(legalCode);
            
            return JResult(c.Result.Select(o=>new
            {
                NameList=o.Id,
                Memo=o.Value,
                Content=o.Label
            }));
        }
    }
}