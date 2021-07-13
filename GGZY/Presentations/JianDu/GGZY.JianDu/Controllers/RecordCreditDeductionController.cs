using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;
using GGZY.JianDu.Models;

namespace GGZY.JianDu.Controllers
{
    public partial class JdRecordCreditDeductionController 
    {
        public ActionResult GetCreditDetailList(string REVIEW_ID)
        {
            return JResult(Jd.RecordCreditDeductionService.GetCreditDetailList(REVIEW_ID));
        }
        public ActionResult GetProgramAttributes()
        {
            return JResult(Jd.RecordCreditDeductionService.GetProgramAttributes());
        }
        public ActionResult GetCreditList(CreditSearchModel search)
        {
            return JResult(Jd.RecordCreditDeductionService.GetCreditList(search));
        }
        public ActionResult GetDetail(string code)
        {
            return JResult(Jd.RecordCreditDeductionService.GetDetail(code));
        }
        /// <summary>
        /// 住建备案审核-信用分扣分结果查询
        /// </summary>
        /// <param name="search"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public ActionResult AuditSearch(SearchCondition search,RECORD_CREDIT_DEDUCTION_REQUEST request)
        {
            if(! request.CREATOR.HasValue || request.CREATOR.Value <=0)
            {
                var r = new GeneralResult();
                r.SetFail("参数错误，CREATOR值错误");
                return JResult(r);
            }
            DateTime? dt1 = null;
            DateTime? dt2 = null;
            if(request.TIMERANGE.HasValue)
            {
                if(request.TIMERANGE.Value >=1 && request.TIMERANGE.Value <=4)
                {
                    dt1 = new DateTime(DateTime.Now.Year, 1 + 3 * (request.TIMERANGE.Value - 1), 1);
                    dt2 = new DateTime(DateTime.Now.Year, 1 + 3 * (request.TIMERANGE.Value), 1).AddMilliseconds(-1);
                }
            }
            return JResult(Jd.RecordCreditDeductionService.AuditSearch(search,request.RECORD_DEPID,
                request.CREATOR,request.REVIEW_TYPE,request.PROBLEM_ATTRIBUTE,dt1,dt2,request.TENDER_PROJECT_TYPE));
        }
        /// <summary>
        /// 根据备案人ID查询备案部门列表
        /// </summary>
        /// <param name="creator"></param>
        /// <returns></returns>
        public ActionResult GetDeptList(decimal? creator)
        {
            if (!creator.HasValue || creator.Value <= 0)
            {
                var r = new GeneralResult();
                r.SetFail("参数错误，CREATOR值错误");
                return JResult(r);
            }
            return JResult(Jd.RecordCreditDeductionService.GetDeptList(creator.Value));
        }
    }
}