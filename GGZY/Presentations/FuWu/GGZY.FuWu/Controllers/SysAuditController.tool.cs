using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdSysAuditController:BaseController
    {
        /// <summary>
        /// 读取SYS_AUDIT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadSysAudits(SYS_AUDIT model, SearchCondition condition)
        {
            var result = Fw.SysAuditService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取SYS_AUDIT明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadSysAudit(decimal ID)
        
        {
            var result = Fw.SysAuditService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建SYS_AUDIT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateSysAudit(SYS_AUDIT model)
        {
            var result = Fw.SysAuditService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新SYS_AUDIT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateSysAudit(SYS_AUDIT model)
        {
            var result = Fw.SysAuditService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除SYS_AUDIT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteSysAudit(string ids)
        {
            var result = Fw.SysAuditService.Delete(ids);
            return JResult(result); 
        }
    }
}