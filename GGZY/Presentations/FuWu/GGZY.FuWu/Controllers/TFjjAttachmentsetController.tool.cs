using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTFjjAttachmentsetController:BaseController
    {
        /// <summary>
        /// 读取T_FJJ_ATTACHMENTSET列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTFjjAttachmentsets(T_FJJ_ATTACHMENTSET model, SearchCondition condition)
        {
            var result = Fw.TFjjAttachmentsetService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_FJJ_ATTACHMENTSET明细
        /// </summary>
      /// <param name="ATTACHMENTCODE">附件关联标识号</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTFjjAttachmentset(string ATTACHMENTCODE)
        
        {
            var result = Fw.TFjjAttachmentsetService.ViewByPk(ATTACHMENTCODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_FJJ_ATTACHMENTSET信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTFjjAttachmentset(T_FJJ_ATTACHMENTSET model)
        {
            var result = Fw.TFjjAttachmentsetService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_FJJ_ATTACHMENTSET信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTFjjAttachmentset(T_FJJ_ATTACHMENTSET model)
        {
            var result = Fw.TFjjAttachmentsetService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_FJJ_ATTACHMENTSET信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTFjjAttachmentset(string ids)
        {
            var result = Fw.TFjjAttachmentsetService.Delete(ids);
            return JResult(result); 
        }
    }
}