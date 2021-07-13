using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdSysDocumentsController:BaseController
    {
        /// <summary>
        /// 读取SYS_DOCUMENTS列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadSysDocumentss(SYS_DOCUMENTS model, SearchCondition condition)
        {
            var result = Fw.SysDocumentsService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取SYS_DOCUMENTS明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadSysDocuments(decimal ID)
        
        {
            var result = Fw.SysDocumentsService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建SYS_DOCUMENTS信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateSysDocuments(SYS_DOCUMENTS model)
        {
            var result = Fw.SysDocumentsService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新SYS_DOCUMENTS信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateSysDocuments(SYS_DOCUMENTS model)
        {
            var result = Fw.SysDocumentsService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除SYS_DOCUMENTS信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteSysDocuments(string ids)
        {
            var result = Fw.SysDocumentsService.Delete(ids);
            return JResult(result); 
        }
    }
}