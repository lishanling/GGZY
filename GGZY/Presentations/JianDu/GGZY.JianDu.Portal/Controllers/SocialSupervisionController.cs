using System;
using System.Web.Mvc;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using GGZYFW.DbEntity;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Portal.Controllers
{
    /// <summary>
    /// 社会监督
    /// </summary>
    [AllowAnonymous]
    public class SocialSupervisionController : BaseController
    {
        #region 中标率排名

        /// <summary>
        /// 中标率排名
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult WinRate(MV_USER_TENDER_LIST model, SearchCondition search)
        {
            var r = Fw.MvUserTenderListService.WinRatePageList(model, search);
            return JResult(r);
        }

        #endregion 
        #region 投标数

        /// <summary>
        /// 投标数
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult BidCount(MV_USER_TENDER_LIST model, SearchCondition search)
        {
            var r = Fw.MvUserTenderListService.BidCountPageList(model, search);
            return JResult(r);
        }

        #endregion

        #region 信用公示

        /// <summary>
        /// 信用公示
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult Score(SLT_SCORE_LOG model, SearchCondition search)
        {
            PageTableResult pageTable;
            if (string.Compare(search.RspType, "zj", StringComparison.CurrentCultureIgnoreCase) == 0)
            {
                pageTable = Fw.ZjEnterpriseCreditScoreService.PageTable(new ZJ_ENTERPRISE_CREDIT_SCORE(), search);
            }
            else
            {
                pageTable = Fw.SltScoreLogService.PageTable(model, search);
            }

            return JResult(pageTable);
        }

        #endregion

        #region 企业处罚公示

        /// <summary>
        /// 企业违法违规
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult CompanyIllegal(T_FRAUD model, SearchCondition search)
        {
            var r = Jd.TFraudService.CompanyIllegal(model, search);
            return JResult(r);
        }
        /// <summary>
        /// 企业违法违规
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult CompanyIllegalDetail(string id)
        {
            var rid = id.DesDecrypt().ToNullableDecimal();
            var r = Jd.TFraudService.ViewByPk(rid);
            if (r.Success)
            {
                var entity = r.Data as T_FRAUD;
                if (entity?.STATE != "3")
                {
                    r.SetFail("未找到对应企业处罚记录");
                }
                else
                {
                    r.SetSuccess(new
                    {
                        entity.ID,
                        entity.TITLE,
                        entity.COMPANY_NAME,
                        entity.COMPANY_ADDRESS,
                        entity.DISHONESTY_CONTENT,
                        entity.PUNISHMENT_RESULT,
                        entity.PUNISHMENT_BASIS,
                        entity.PUNISHMENT_DATE,
                        entity.PUNISHMENT_DEADLINE,
                        entity.ENFORCEMENT_UNIT,
                        entity.AUDIT_STAFF,
                        entity.AUDIT_OPINION,
                        entity.PUNISHMENT_TYPE,
                        entity.ATTACHMENT,
                        entity.STATE,
                        entity.COMMIT_TIME,
                        entity.AUDIT_TIME,
                        entity.USER_ID,
                        TM = entity.AUDIT_TIME ?? entity.COMMIT_TIME,
                    });
                }
            }
            return JResult(r);
        }

        #endregion

        #region 专家处罚公示
        // todo 新闻加一个分类 数据源来自 http://zjk.ggzyfw.fj.gov.cn/ 

        // 详情添加申诉功能

        public ActionResult ExpertIllegal(GGZYJD.DbEntity.PT_ARTICLE model, SearchCondition search)
        {
            //search.KeyWord = "专家处罚公示";
            var type = new GGZYJD.DbEntity.PT_ATYPE { TEXT = "专家处罚公示" };
            var r = Jd.PtArticleService.PageTableByTypeTxt(model, search, type);
            return JResult(r);
        }


        #endregion
    }
}