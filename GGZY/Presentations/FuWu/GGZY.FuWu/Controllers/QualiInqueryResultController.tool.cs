using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdQualiInqueryResultController:BaseController
    {
        /// <summary>
        /// 读取QUALI_INQUERY_RESULT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadQualiInqueryResults(QUALI_INQUERY_RESULT model, SearchCondition condition)
        {
            var result = Fw.QualiInqueryResultService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取QUALI_INQUERY_RESULT明细
        /// </summary>
      /// <param name="M_ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadQualiInqueryResult(decimal M_ID)
        
        {
            var result = Fw.QualiInqueryResultService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建QUALI_INQUERY_RESULT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateQualiInqueryResult(QUALI_INQUERY_RESULT model)
        {
            var result = Fw.QualiInqueryResultService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新QUALI_INQUERY_RESULT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateQualiInqueryResult(QUALI_INQUERY_RESULT model)
        {
            var result = Fw.QualiInqueryResultService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除QUALI_INQUERY_RESULT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteQualiInqueryResult(string ids)
        {
            var result = Fw.QualiInqueryResultService.Delete(ids);
            return JResult(result); 
        }
    }
}