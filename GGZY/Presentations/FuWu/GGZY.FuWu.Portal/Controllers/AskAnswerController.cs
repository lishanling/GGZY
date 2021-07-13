using System;
using System.Web.Mvc;
using GGZY.Framework.Controllers;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Portal.Controllers
{
    public class AskAnswerController:BaseController
    {


        #region 服务门户-咨询|质疑
        /// <summary>
        /// 服务门户-咨询
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Ask(T_ASKANSWER model)
        {
            var r = Fw.TAskanswerService.Ask(model);
            return JResult(r);
        }
        /// <summary>
        /// 服务门户-质疑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Question(T_ASKANSWER model)
        {
            var r = Fw.TAskanswerService.Question(model);
            return JResult(r);
        }
        #endregion
    }
}