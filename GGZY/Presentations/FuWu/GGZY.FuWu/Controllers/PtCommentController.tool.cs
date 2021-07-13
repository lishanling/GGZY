using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdPtCommentController:BaseController
    {
        /// <summary>
        /// 读取PT_COMMENT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadPtComments(PT_COMMENT model, SearchCondition condition)
        {
            var result = Fw.PtCommentService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PT_COMMENT明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadPtComment(decimal ID)
        
        {
            var result = Fw.PtCommentService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PT_COMMENT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreatePtComment(PT_COMMENT model)
        {
            var result = Fw.PtCommentService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PT_COMMENT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdatePtComment(PT_COMMENT model)
        {
            var result = Fw.PtCommentService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PT_COMMENT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeletePtComment(string ids)
        {
            var result = Fw.PtCommentService.Delete(ids);
            return JResult(result); 
        }
    }
}