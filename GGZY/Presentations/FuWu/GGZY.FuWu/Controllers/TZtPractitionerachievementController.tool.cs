using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTZtPractitionerachievementController:BaseController
    {
        /// <summary>
        /// 读取T_ZT_PRACTITIONERACHIEVEMENT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTZtPractitionerachievements(T_ZT_PRACTITIONERACHIEVEMENT model, SearchCondition condition)
        {
            var result = Fw.TZtPractitionerachievementService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_ZT_PRACTITIONERACHIEVEMENT明细
        /// </summary>
      /// <param name="IDCARDNO">人员身份证件号</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTZtPractitionerachievement(string IDCARDNO)
        
        {
            var result = Fw.TZtPractitionerachievementService.ViewByPk(IDCARDNO);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_ZT_PRACTITIONERACHIEVEMENT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTZtPractitionerachievement(T_ZT_PRACTITIONERACHIEVEMENT model)
        {
            var result = Fw.TZtPractitionerachievementService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_ZT_PRACTITIONERACHIEVEMENT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTZtPractitionerachievement(T_ZT_PRACTITIONERACHIEVEMENT model)
        {
            var result = Fw.TZtPractitionerachievementService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_ZT_PRACTITIONERACHIEVEMENT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTZtPractitionerachievement(string ids)
        {
            var result = Fw.TZtPractitionerachievementService.Delete(ids);
            return JResult(result); 
        }
    }
}