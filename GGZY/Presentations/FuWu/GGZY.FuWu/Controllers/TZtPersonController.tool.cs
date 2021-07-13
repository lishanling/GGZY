using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTZtPersonController:BaseController
    {
        /// <summary>
        /// 读取T_ZT_PERSON列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTZtPersons(T_ZT_PERSON model, SearchCondition condition)
        {
            var result = Fw.TZtPersonService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_ZT_PERSON明细
        /// </summary>
      /// <param name="IDCARD">主体代码（身份证件号）</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTZtPerson(string IDCARD)
        
        {
            var result = Fw.TZtPersonService.ViewByPk(IDCARD);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_ZT_PERSON信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTZtPerson(T_ZT_PERSON model)
        {
            var result = Fw.TZtPersonService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_ZT_PERSON信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTZtPerson(T_ZT_PERSON model)
        {
            var result = Fw.TZtPersonService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_ZT_PERSON信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTZtPerson(string ids)
        {
            var result = Fw.TZtPersonService.Delete(ids);
            return JResult(result); 
        }
    }
}