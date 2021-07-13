using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTTjAlltbUploadController:BaseController
    {
        /// <summary>
        /// 读取T_TJ_ALLTB_UPLOAD列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTTjAlltbUploads(T_TJ_ALLTB_UPLOAD model, SearchCondition condition)
        {
            var result = Fw.TTjAlltbUploadService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_TJ_ALLTB_UPLOAD明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTTjAlltbUpload(decimal ID)
        
        {
            var result = Fw.TTjAlltbUploadService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_TJ_ALLTB_UPLOAD信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTTjAlltbUpload(T_TJ_ALLTB_UPLOAD model)
        {
            var result = Fw.TTjAlltbUploadService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_TJ_ALLTB_UPLOAD信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTTjAlltbUpload(T_TJ_ALLTB_UPLOAD model)
        {
            var result = Fw.TTjAlltbUploadService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_TJ_ALLTB_UPLOAD信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTTjAlltbUpload(string ids)
        {
            var result = Fw.TTjAlltbUploadService.Delete(ids);
            return JResult(result); 
        }
    }
}