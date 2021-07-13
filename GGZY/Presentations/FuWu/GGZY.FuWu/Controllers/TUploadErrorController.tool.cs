using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTUploadErrorController:BaseController
    {
        /// <summary>
        /// 读取T_UPLOAD_ERROR列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTUploadErrors(T_UPLOAD_ERROR model, SearchCondition condition)
        {
            var result = Fw.TUploadErrorService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_UPLOAD_ERROR明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTUploadError(decimal ID)
        
        {
            var result = Fw.TUploadErrorService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_UPLOAD_ERROR信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTUploadError(T_UPLOAD_ERROR model)
        {
            var result = Fw.TUploadErrorService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_UPLOAD_ERROR信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTUploadError(T_UPLOAD_ERROR model)
        {
            var result = Fw.TUploadErrorService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_UPLOAD_ERROR信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTUploadError(string ids)
        {
            var result = Fw.TUploadErrorService.Delete(ids);
            return JResult(result); 
        }
    }
}