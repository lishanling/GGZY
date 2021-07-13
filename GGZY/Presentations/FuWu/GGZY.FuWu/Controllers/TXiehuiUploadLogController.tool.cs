using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTXiehuiUploadLogController:BaseController
    {
        /// <summary>
        /// 读取T_XIEHUI_UPLOAD_LOG列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTXiehuiUploadLogs(T_XIEHUI_UPLOAD_LOG model, SearchCondition condition)
        {
            var result = Fw.TXiehuiUploadLogService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_XIEHUI_UPLOAD_LOG明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTXiehuiUploadLog(decimal ID)
        
        {
            var result = Fw.TXiehuiUploadLogService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_XIEHUI_UPLOAD_LOG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTXiehuiUploadLog(T_XIEHUI_UPLOAD_LOG model)
        {
            var result = Fw.TXiehuiUploadLogService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_XIEHUI_UPLOAD_LOG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTXiehuiUploadLog(T_XIEHUI_UPLOAD_LOG model)
        {
            var result = Fw.TXiehuiUploadLogService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_XIEHUI_UPLOAD_LOG信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTXiehuiUploadLog(string ids)
        {
            var result = Fw.TXiehuiUploadLogService.Delete(ids);
            return JResult(result); 
        }
    }
}