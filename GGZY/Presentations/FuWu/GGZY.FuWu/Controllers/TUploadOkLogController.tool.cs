using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTUploadOkLogController:BaseController
    {
        /// <summary>
        /// 读取T_UPLOAD_OK_LOG列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTUploadOkLogs(T_UPLOAD_OK_LOG model, SearchCondition condition)
        {
            var result = Fw.TUploadOkLogService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_UPLOAD_OK_LOG明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTUploadOkLog(decimal ID)
        
        {
            var result = Fw.TUploadOkLogService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_UPLOAD_OK_LOG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTUploadOkLog(T_UPLOAD_OK_LOG model)
        {
            var result = Fw.TUploadOkLogService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_UPLOAD_OK_LOG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTUploadOkLog(T_UPLOAD_OK_LOG model)
        {
            var result = Fw.TUploadOkLogService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_UPLOAD_OK_LOG信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTUploadOkLog(string ids)
        {
            var result = Fw.TUploadOkLogService.Delete(ids);
            return JResult(result); 
        }
    }
}