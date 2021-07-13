using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTAttachmentController:BaseController
    {
        /// <summary>
        /// 读取T_ATTACHMENT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTAttachments(T_ATTACHMENT model, SearchCondition condition)
        {
            var result = Fw.TAttachmentService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_ATTACHMENT明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTAttachment(decimal ID)
        
        {
            var result = Fw.TAttachmentService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_ATTACHMENT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTAttachment(T_ATTACHMENT model)
        {
            var result = Fw.TAttachmentService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_ATTACHMENT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTAttachment(T_ATTACHMENT model)
        {
            var result = Fw.TAttachmentService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_ATTACHMENT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTAttachment(string ids)
        {
            var result = Fw.TAttachmentService.Delete(ids);
            return JResult(result); 
        }
    }
}