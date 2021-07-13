using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTUploadController:BaseController
    {
        /// <summary>
        /// 读取T_UPLOAD列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTUploads(T_UPLOAD model, SearchCondition condition)
        {
            var result = Fw.TUploadService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_UPLOAD明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTUpload(decimal ID)
        
        {
            var result = Fw.TUploadService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_UPLOAD信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTUpload(T_UPLOAD model)
        {
            var result = Fw.TUploadService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_UPLOAD信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTUpload(T_UPLOAD model)
        {
            var result = Fw.TUploadService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_UPLOAD信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTUpload(string ids)
        {
            var result = Fw.TUploadService.Delete(ids);
            return JResult(result); 
        }
    }
}