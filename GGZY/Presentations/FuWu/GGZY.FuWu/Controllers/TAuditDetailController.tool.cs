using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTAuditDetailController:BaseController
    {
        /// <summary>
        /// 读取T_AUDIT_DETAIL列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTAuditDetails(T_AUDIT_DETAIL model, SearchCondition condition)
        {
            var result = Fw.TAuditDetailService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_AUDIT_DETAIL明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTAuditDetail(decimal ID)
        
        {
            var result = Fw.TAuditDetailService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_AUDIT_DETAIL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTAuditDetail(T_AUDIT_DETAIL model)
        {
            var result = Fw.TAuditDetailService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_AUDIT_DETAIL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTAuditDetail(T_AUDIT_DETAIL model)
        {
            var result = Fw.TAuditDetailService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_AUDIT_DETAIL信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTAuditDetail(string ids)
        {
            var result = Fw.TAuditDetailService.Delete(ids);
            return JResult(result); 
        }
    }
}