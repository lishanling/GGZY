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
    public class GatProjectTranInfoController : BaseController
    {
        
        // GET: ProjectTranInfo
        public ActionResult Index()
        {
            return View();
           
        }

        /// <summary>
        /// 公安厅外网-项目交易资料
        /// </summary>
        /// <returns></returns>
        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 项目进场 
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public ActionResult GCJS_XMJC(string tender_project_code)
        {
            var r = Fw.MvTjAllcreateXzjdService.GCJS_XMJC_ProjectInfo(tender_project_code, ids => Fw.CommonService.Attachments(ids, "Att", (type, id) => CommonAttachmentBuilder(id, fType: type)));
            return JResult(r);
        }


        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 招标公告 
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public ActionResult GCJS_ZBGG(string tender_project_code)
        {
            var r = Fw.MvTjAllcreateXzjdService.GCJS_ZBGG(tender_project_code, ids => Fw.CommonService.Attachments(ids, "Att", (type, id) => CommonAttachmentBuilder(id, fType: type)));
            return JResult(r);
        }

        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 投标报名
        /// </summary>
        /// <param name="projectCode"></param>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        public ActionResult GCJS_TBBM(string tender_project_code)
        {
            var r = Fw.MvTjAllcreateXzjdService.GAT_TBBM(tender_project_code);
            return JResult(r);
        }
        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 开标记录 
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public ActionResult GCJS_KB(string tender_project_code)
        {
            var r = Fw.MvTjAllcreateXzjdService.GAT_KBJV(tender_project_code);
            return JResult(r);
        }


        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 评标
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public ActionResult GCJS_PB(string tender_project_code)
        {
            var r = Fw.MvTjAllcreateXzjdService.GAT_PB(tender_project_code, "HT");
            return JResult(r);
        }

        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 结果公告
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public ActionResult GCJS_JGGG(string tender_project_code)
        {
            var r = Fw.MvTjAllcreateXzjdService.GAT_JGGG(tender_project_code);
            return JResult(r);
        }
    }
}