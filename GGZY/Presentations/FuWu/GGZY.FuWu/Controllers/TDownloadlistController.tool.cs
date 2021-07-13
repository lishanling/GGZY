using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTDownloadlistController:BaseController
    {
        /// <summary>
        /// 读取T_DOWNLOADLIST列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTDownloadlists(T_DOWNLOADLIST model, SearchCondition condition)
        {
            var result = Fw.TDownloadlistService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_DOWNLOADLIST明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTDownloadlist(decimal ID)
        
        {
            var result = Fw.TDownloadlistService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_DOWNLOADLIST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTDownloadlist(T_DOWNLOADLIST model)
        {
            var result = Fw.TDownloadlistService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_DOWNLOADLIST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTDownloadlist(T_DOWNLOADLIST model)
        {
            var result = Fw.TDownloadlistService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_DOWNLOADLIST信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTDownloadlist(string ids)
        {
            var result = Fw.TDownloadlistService.Delete(ids);
            return JResult(result); 
        }
    }
}