using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdSysAuditInfoController:BaseController
    {
        /// <summary>
        /// 读取SYS_AUDIT_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadSysAuditInfos(SYS_AUDIT_INFO model, SearchCondition condition)
        {
            var result = Fw.SysAuditInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取SYS_AUDIT_INFO明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadSysAuditInfo(decimal ID)
        
        {
            var result = Fw.SysAuditInfoService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建SYS_AUDIT_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateSysAuditInfo(SYS_AUDIT_INFO model)
        {
            var result = Fw.SysAuditInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新SYS_AUDIT_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateSysAuditInfo(SYS_AUDIT_INFO model)
        {
            var result = Fw.SysAuditInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除SYS_AUDIT_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteSysAuditInfo(string ids)
        {
            var result = Fw.SysAuditInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}