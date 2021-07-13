using System;
using System.Web.Mvc;
using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;
using System.Linq;
using System.Collections.Generic;

namespace GGZY.JianDu.Controllers
{
    public partial class JdSysDicController:BaseController
    {
        /// <summary>
        /// 招标人类别枚举信息
        /// </summary>
        /// <returns></returns>
        public ActionResult List(List<string> type)
        {
            var model = new SYS_DIC();
            model.TYPE = "2001";
            var list = Jd.SysDicService.FindList(model).OrderBy(od => od.VALUE).Select(t => new {
                t.TEXT,
                t.VALUE
            });
            return JResult(list);
        }
    }
}