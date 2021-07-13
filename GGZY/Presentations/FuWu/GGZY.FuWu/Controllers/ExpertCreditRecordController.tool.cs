using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdExpertCreditRecordController:BaseController
    {
        /// <summary>
        /// 读取EXPERT_CREDIT_RECORD列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadExpertCreditRecords(EXPERT_CREDIT_RECORD model, SearchCondition condition)
        {
            var result = Fw.ExpertCreditRecordService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取EXPERT_CREDIT_RECORD明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadExpertCreditRecord(decimal M_ID)
        
        {
            var result = Fw.ExpertCreditRecordService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建EXPERT_CREDIT_RECORD信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateExpertCreditRecord(EXPERT_CREDIT_RECORD model)
        {
            var result = Fw.ExpertCreditRecordService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新EXPERT_CREDIT_RECORD信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateExpertCreditRecord(EXPERT_CREDIT_RECORD model)
        {
            var result = Fw.ExpertCreditRecordService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除EXPERT_CREDIT_RECORD信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteExpertCreditRecord(string ids)
        {
            var result = Fw.ExpertCreditRecordService.Delete(ids);
            return JResult(result); 
        }
    }
}