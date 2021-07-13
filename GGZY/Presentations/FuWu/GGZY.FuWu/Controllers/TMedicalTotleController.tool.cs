using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTMedicalTotleController:BaseController
    {
        /// <summary>
        /// 读取T_MEDICAL_TOTLE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTMedicalTotles(T_MEDICAL_TOTLE model, SearchCondition condition)
        {
            var result = Fw.TMedicalTotleService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_MEDICAL_TOTLE明细
        /// </summary>
      /// <param name="ID">主键ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTMedicalTotle(decimal ID)
        
        {
            var result = Fw.TMedicalTotleService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_MEDICAL_TOTLE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTMedicalTotle(T_MEDICAL_TOTLE model)
        {
            var result = Fw.TMedicalTotleService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_MEDICAL_TOTLE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTMedicalTotle(T_MEDICAL_TOTLE model)
        {
            var result = Fw.TMedicalTotleService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_MEDICAL_TOTLE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTMedicalTotle(string ids)
        {
            var result = Fw.TMedicalTotleService.Delete(ids);
            return JResult(result); 
        }
    }
}