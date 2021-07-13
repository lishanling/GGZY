using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GGZYJD.DbEntity;
using Dos.ORM;
using GGZYFW.DbEntity;
using System.Text;

namespace GGZY.BigData.GCJS.Controllers
{
    /// <summary>
    /// 疑似违规行为类别
    /// </summary>
    public class JdBdViolationPointController : BaseController
    {
        public ActionResult List(string code="")
        {
           //不包含全部的接口
            var r = Fw.BdViolationPointService.List(code);
           //包含全部的接口
            //var r = Fw.BdViolationPointService.TreeList(code);
            return JResult(r);

        }
    }
}