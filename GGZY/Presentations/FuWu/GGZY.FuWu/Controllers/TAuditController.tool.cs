using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTAuditController:BaseController
    {
        /// <summary>
        /// 读取T_AUDIT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTAudits(T_AUDIT model, SearchCondition condition)
        {
            var result = Fw.TAuditService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_AUDIT明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTAudit(decimal ID)
        
        {
            var result = Fw.TAuditService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_AUDIT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTAudit(T_AUDIT model)
        {
            var result = Fw.TAuditService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_AUDIT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTAudit(T_AUDIT model)
        {
            var result = Fw.TAuditService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_AUDIT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTAudit(string ids)
        {
            var result = Fw.TAuditService.Delete(ids);
            return JResult(result); 
        }
    }
}