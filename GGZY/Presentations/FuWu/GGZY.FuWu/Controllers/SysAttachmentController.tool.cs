using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdSysAttachmentController:BaseController
    {
        /// <summary>
        /// 读取SYS_ATTACHMENT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadSysAttachments(SYS_ATTACHMENT model, SearchCondition condition)
        {
            var result = Fw.SysAttachmentService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取SYS_ATTACHMENT明细
        /// </summary>
      /// <param name="AID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadSysAttachment(decimal AID)
        
        {
            var result = Fw.SysAttachmentService.ViewByPk(AID);
            return JResult(result);
        }
        /// <summary>
        /// 创建SYS_ATTACHMENT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateSysAttachment(SYS_ATTACHMENT model)
        {
            var result = Fw.SysAttachmentService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新SYS_ATTACHMENT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateSysAttachment(SYS_ATTACHMENT model)
        {
            var result = Fw.SysAttachmentService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除SYS_ATTACHMENT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteSysAttachment(string ids)
        {
            var result = Fw.SysAttachmentService.Delete(ids);
            return JResult(result); 
        }
    }
}