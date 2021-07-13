using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTMedicalController:BaseController
    {
        /// <summary>
        /// 读取T_MEDICAL列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTMedicals(T_MEDICAL model, SearchCondition condition)
        {
            var result = Fw.TMedicalService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_MEDICAL明细
        /// </summary>
      /// <param name="SYNC_PROD_ID">主键ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTMedical(string SYNC_PROD_ID)
        
        {
            var result = Fw.TMedicalService.ViewByPk(SYNC_PROD_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_MEDICAL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTMedical(T_MEDICAL model)
        {
            var result = Fw.TMedicalService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_MEDICAL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTMedical(T_MEDICAL model)
        {
            var result = Fw.TMedicalService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_MEDICAL信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTMedical(string ids)
        {
            var result = Fw.TMedicalService.Delete(ids);
            return JResult(result); 
        }
    }
}