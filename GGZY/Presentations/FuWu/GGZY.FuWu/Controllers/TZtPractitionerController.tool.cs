using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTZtPractitionerController:BaseController
    {
        /// <summary>
        /// 读取T_ZT_PRACTITIONER列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTZtPractitioners(T_ZT_PRACTITIONER model, SearchCondition condition)
        {
            var result = Fw.TZtPractitionerService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_ZT_PRACTITIONER明细
        /// </summary>
      /// <param name="IDCARD">身份证件号码</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTZtPractitioner(string IDCARD)
        
        {
            var result = Fw.TZtPractitionerService.ViewByPk(IDCARD);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_ZT_PRACTITIONER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTZtPractitioner(T_ZT_PRACTITIONER model)
        {
            var result = Fw.TZtPractitionerService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_ZT_PRACTITIONER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTZtPractitioner(T_ZT_PRACTITIONER model)
        {
            var result = Fw.TZtPractitionerService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_ZT_PRACTITIONER信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTZtPractitioner(string ids)
        {
            var result = Fw.TZtPractitionerService.Delete(ids);
            return JResult(result); 
        }
    }
}