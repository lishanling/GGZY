using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdQualiInqueryAppFileController:BaseController
    {
        /// <summary>
        /// 读取QUALI_INQUERY_APP_FILE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadQualiInqueryAppFiles(QUALI_INQUERY_APP_FILE model, SearchCondition condition)
        {
            var result = Fw.QualiInqueryAppFileService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取QUALI_INQUERY_APP_FILE明细
        /// </summary>
      /// <param name="M_ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadQualiInqueryAppFile(decimal M_ID)
        
        {
            var result = Fw.QualiInqueryAppFileService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建QUALI_INQUERY_APP_FILE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateQualiInqueryAppFile(QUALI_INQUERY_APP_FILE model)
        {
            var result = Fw.QualiInqueryAppFileService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新QUALI_INQUERY_APP_FILE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateQualiInqueryAppFile(QUALI_INQUERY_APP_FILE model)
        {
            var result = Fw.QualiInqueryAppFileService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除QUALI_INQUERY_APP_FILE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteQualiInqueryAppFile(string ids)
        {
            var result = Fw.QualiInqueryAppFileService.Delete(ids);
            return JResult(result); 
        }
    }
}