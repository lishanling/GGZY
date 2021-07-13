using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdZjBidDocCharactCodeController
    {
        [AllowAnonymous]
        public ActionResult Similar()
        {
            return View("SoftwareAndHardwareSimilarView");
        }
        /// <summary>
        /// 读取ZJ_BID_DOC_CHARACT_CODE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult SoftwareAndHardwareSimilar(ZJ_BID_DOC_CHARACT_CODE model, SearchCondition condition)
        {
            var result = Jd.ZjBidDocCharactCodeService.SoftwareAndHardwareSimilar(model, condition);
            if (condition.RspType == SearchCondition.RES_TYPE_API)
            {
                return JResult(result.ToPageTableResult(condition));
            }
            return JResult(result,false);
        }
    }
}