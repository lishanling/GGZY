using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdTUserDepartmentController: BaseController
    {
        /// <summary>
        /// 获取备案部门列表
        /// </summary>
        /// <param name="model">
        /// model.JGBM 监管部门
        ///     住建：MZ,MT
        ///     水利：MS
        ///     交通：MJ
        /// </param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult BeiAnList(T_USER_DEPARTMENT model, SearchCondition condition)
        {
            model.ISBA = 1;
            var result = Jd.TUserDepartmentService.SelectList(model, condition);
            return JResult(result);
        }
    }
}