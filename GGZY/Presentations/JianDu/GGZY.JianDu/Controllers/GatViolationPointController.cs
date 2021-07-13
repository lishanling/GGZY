using Dos.ORM;
using GGZY.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GGZY.Framework.Controllers;
using GGZYFW.DbEntity;
using GGZY.Core.Extensions;
namespace GGZY.JianDu.Controllers
{
    public class GatViolationPointController : BaseController
    {
        // GET: GatViolationPoint
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 列表页查询
        /// </summary>
        /// <param name="tender_project_code"></param>
        /// <returns></returns>
        public ActionResult Search(string tender_project_code)
        {
            var result = Fw.BdViolationRecordService.Show(tender_project_code);
            return JResult(result);
        }

        /// <summary>
        /// 详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Detail(string id)
        {
            var data = Fw.BdViolationRecordService.Details(id);
            return JResult(data);
        }




    }

}