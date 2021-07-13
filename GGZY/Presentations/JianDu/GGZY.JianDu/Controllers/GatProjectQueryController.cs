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
    public class GatProjectQueryController : BaseController
    {
        // GET: ProjectQuery
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 公安厅外网
        /// 项目查询模块
        /// </summary>
        /// <param name="request"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        //项目查询
        public ActionResult List(Project_Query_Request request, SearchCondition search)
        {
            GeneralResult r = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(TENDER_PROJECT._.M_ID.IsNotNull());
            if (!String.IsNullOrWhiteSpace(request.TENDER_PROJECT_NAME))
            {
                condition.And(TENDER_PROJECT._.TENDER_PROJECT_NAME.Contain(request.TENDER_PROJECT_NAME));
            }
            if (!String.IsNullOrWhiteSpace(request.TENDER_PROJECT_CODE))
            {
                condition.And(TENDER_PROJECT._.TENDER_PROJECT_CODE.Contain(request.TENDER_PROJECT_CODE));
            }
            if (request.Begin_Time.HasValue)
            {
                condition.And(TENDER_PROJECT._.CREATE_TIME >= request.Begin_Time);
            }
            if (request.End_Time.HasValue)
            {
                condition.And(TENDER_PROJECT._.CREATE_TIME <= request.End_Time);
            }
            if (!String.IsNullOrWhiteSpace(request.AREA_CODE))
            {
                condition.And(TENDER_PROJECT._.REGION_CODE.Contain(request.AREA_CODE));

            }
            var result = Fw.TenderProjectService.PageList(search, condition.ToWhereClip());
            r.SetSuccess(result);
            return JResult(r);
        }
        /// <summary>
        /// 公安厅外网系统
        /// 项目信息-项目关键信息模块
        /// </summary>
        /// <param name="tender_project_code"></param>
        /// <returns></returns>
        public ActionResult Search(string tender_project_code)
        {
            GeneralResult r = new GeneralResult();
            var tender = Fw.TenderProjectService.Collection(tender_project_code);
            var project = Jd.JcTransProjectService.Collections(tender_project_code);
            var projectKey = Jd.JcTransProjectService.Collection(tender_project_code);
            var tontice = Fw.TenderAnnQuaInqueryAnnService.Collection(tender_project_code);
            r.SetSuccess(new
            {
                //招标项目
                Tender = tender,
                //移送项目
                Project = project,
                //项目关键信息
                ProjectKey = projectKey,
                //招标公告关键信息
                Tontice = tontice
            });
            return JResult(r);
        }

        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Export(TENDER_PROJECT model, SearchCondition condition)
        {
            condition.PageNo = 0;
            condition.PageSize = Int32.MaxValue;
            var result = 
                Fw.TenderProjectService.FindList(model).Select(c => new {
                TENDER_PROJECT_CODE = c.TENDER_PROJECT_CODE,
                TENDER_PROJECT_NAME = c.TENDER_PROJECT_NAME,
                TENDERER_NAME = c.TENDERER_NAME,
                TENDER_AGENCY_NAME = c.TENDER_AGENCY_NAME,
                APPROVE_DEPT_NAME = c.APPROVE_DEPT_NAME,
                REGION_CODE = c.REGION_CODE,
                CREATE_TIME = c.CREATE_TIME
               
            }).ToList();
            if (result.Any())
            {
                var bytes = result.GenerateExcel("招标项目编号", "招标项目名称", "投标人名称", "代理机构", "审查单位", "地区名称", "触发时间");
                var fileName = $"{model.TENDER_PROJECT_NAME}项目_{DateTime.Now:yyyyMMddHHmmss}.xls";
                return File(bytes, "application/vnd.ms-excel", fileName);
            }
            return Content("<script> alert('导出数据为空');window.close();</script>");
        }



        public class Project_Query_Request
        {
            public string TENDER_PROJECT_NAME { get; set; }

            public string TENDER_PROJECT_CODE { get; set; }

            public DateTime? Begin_Time { get; set; }

            public DateTime? End_Time { get; set; }

          
            public string AREA_CODE { get; set; }

        }
    }
}