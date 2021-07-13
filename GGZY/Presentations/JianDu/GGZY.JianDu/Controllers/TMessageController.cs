using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdTMessageController
    {
        /// <summary>
        /// 查询【调阅申请】
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult SearchDYSQ(T_MESSAGE model, SearchCondition search)
        {
            var r = Jd.TMessageService.SearchDYSQ(model, search);
            return JResult(r);
        }

        /// <summary>
        /// 监督后台-通知信息 详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult DYSQ_Detail(string id)
        {
            var r = Jd.TMessageService.DYSQ_Detail(id);
            return JResult(r);
        }
    }
}