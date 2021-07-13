using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTZtPracticequalController:BaseController
    {
        /// <summary>
        /// 读取T_ZT_PRACTICEQUAL列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTZtPracticequals(T_ZT_PRACTICEQUAL model, SearchCondition condition)
        {
            var result = Fw.TZtPracticequalService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_ZT_PRACTICEQUAL明细
        /// </summary>
      /// <param name="IDCARD">执业人员证件号</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTZtPracticequal(string IDCARD)
        
        {
            var result = Fw.TZtPracticequalService.ViewByPk(IDCARD);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_ZT_PRACTICEQUAL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTZtPracticequal(T_ZT_PRACTICEQUAL model)
        {
            var result = Fw.TZtPracticequalService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_ZT_PRACTICEQUAL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTZtPracticequal(T_ZT_PRACTICEQUAL model)
        {
            var result = Fw.TZtPracticequalService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_ZT_PRACTICEQUAL信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTZtPracticequal(string ids)
        {
            var result = Fw.TZtPracticequalService.Delete(ids);
            return JResult(result); 
        }
    }
}