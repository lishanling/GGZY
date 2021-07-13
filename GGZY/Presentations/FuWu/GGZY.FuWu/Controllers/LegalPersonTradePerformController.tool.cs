using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdLegalPersonTradePerformController:BaseController
    {
        /// <summary>
        /// 读取LEGAL_PERSON_TRADE_PERFORM列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadLegalPersonTradePerforms(LEGAL_PERSON_TRADE_PERFORM model, SearchCondition condition)
        {
            var result = Fw.LegalPersonTradePerformService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取LEGAL_PERSON_TRADE_PERFORM明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadLegalPersonTradePerform(decimal M_ID)
        
        {
            var result = Fw.LegalPersonTradePerformService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建LEGAL_PERSON_TRADE_PERFORM信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateLegalPersonTradePerform(LEGAL_PERSON_TRADE_PERFORM model)
        {
            var result = Fw.LegalPersonTradePerformService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新LEGAL_PERSON_TRADE_PERFORM信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateLegalPersonTradePerform(LEGAL_PERSON_TRADE_PERFORM model)
        {
            var result = Fw.LegalPersonTradePerformService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除LEGAL_PERSON_TRADE_PERFORM信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteLegalPersonTradePerform(string ids)
        {
            var result = Fw.LegalPersonTradePerformService.Delete(ids);
            return JResult(result); 
        }
    }
}