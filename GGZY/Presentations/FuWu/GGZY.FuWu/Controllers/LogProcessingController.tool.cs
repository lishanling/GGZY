using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdLogProcessingController:BaseController
    {
        /// <summary>
        /// 读取LOG_PROCESSING列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadLogProcessings(LOG_PROCESSING model, SearchCondition condition)
        {
            var result = Fw.LogProcessingService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取LOG_PROCESSING明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadLogProcessing(decimal ID)
        
        {
            var result = Fw.LogProcessingService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建LOG_PROCESSING信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateLogProcessing(LOG_PROCESSING model)
        {
            var result = Fw.LogProcessingService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新LOG_PROCESSING信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateLogProcessing(LOG_PROCESSING model)
        {
            var result = Fw.LogProcessingService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除LOG_PROCESSING信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteLogProcessing(string ids)
        {
            var result = Fw.LogProcessingService.Delete(ids);
            return JResult(result); 
        }
    }
}