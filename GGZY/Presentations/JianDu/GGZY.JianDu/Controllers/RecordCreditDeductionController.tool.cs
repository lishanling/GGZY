using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdRecordCreditDeductionController:BaseController
    {
        /// <summary>
        /// 读取RECORD_CREDIT_DEDUCTION列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadRecordCreditDeductions(RECORD_CREDIT_DEDUCTION model, SearchCondition condition)
        {
            var result = Jd.RecordCreditDeductionService.PageList(model, condition).ToPageTableResult(condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取RECORD_CREDIT_DEDUCTION明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadRecordCreditDeduction(decimal ID)
        
        {
            var result = Jd.RecordCreditDeductionService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建RECORD_CREDIT_DEDUCTION信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateRecordCreditDeduction(RECORD_CREDIT_DEDUCTION model)
        {
            var result = Jd.RecordCreditDeductionService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新RECORD_CREDIT_DEDUCTION信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateRecordCreditDeduction(RECORD_CREDIT_DEDUCTION model)
        {
            var result = Jd.RecordCreditDeductionService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除RECORD_CREDIT_DEDUCTION信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteRecordCreditDeduction(string ids)
        {
            var result = Jd.RecordCreditDeductionService.Delete(ids);
            return JResult(result); 
        }
    }
}