using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using GGZY.Core.Utils;
using GGZY.Framework.Infrastructure.Filters;
using GGZY.Framework.Models;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;


namespace GGZY.JianDu.Portal.Controllers
{
    [AllowAnonymous]
    public class HomeController : BaseController
    {
        [PortalUnFilter]
        public ActionResult Index()
        {
            return Redirect("/jdportal/web/#/");
            var portal = ConfigHelper.AppSettings.Portal;
            var path = Server.MapPath(portal);
            if (System.IO.File.Exists(path))
            {
                return Redirect(portal);
            }
            return Content("");
        }

        /// <summary>
        /// 相关链接
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Link(PT_LINK model)
        {
            var list = Jd.PtLinkService.Link(model);
            return JResult(list);
        }

        #region 异议处理结果列表|详情
        /// <summary>
        /// 4、首页下方“异议处理结果”里隐藏“普通公路、高速公路”标签，后期如果有项目，需要恢复标签（工程类型参照报建登记表里报建类型，有数据就显示、没有就隐藏）
        /// </summary>
        /// <returns></returns>
        public ActionResult ObjectionTenderProjectType(SearchCondition search)
        {
            var r = Jd.JdPortalObjectionService.ObjectionTenderProjectType(search);
            return JResult(r);
        }
        public ActionResult ObjectionResult(ObjectionSearchRequest search)
        {
            var r = Jd.JdPortalObjectionService.ObjectionResult(search);
            return JResult(r);
        }

        public ActionResult ObjectionResultDetail(string id)
        {
            var r = Jd.JdPortalObjectionService.ObjectionResultDetail(id);
            return JResult(r);
        }

        #endregion

        #region 项目报建
        /// <summary>
        /// 3、首页下方“招标计划登记”里隐藏“园林绿化、公路、铁路、民航、信息网络、能源、邮电通信”，标签，后期如果有项目，需要恢复标签（工程类型参照报建登记表里报建类型，有数据就显示、没有就隐藏）
        /// </summary>
        /// <returns></returns>
        public ActionResult JdPortalProjectType(SearchCondition search)
        {
            var r = Jd.TAfcLogService.JdPortalProjectType(search);
            return JResult(r);
        }
        /// <summary>
        /// 门户 项目报建
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult ProjectReportBuildSearch(T_AFC_LOG model, SearchCondition search)
        {
            var r = Jd.TAfcLogService.ProjectReportBuildSearch(model, search);
            return JResult(r);
        }

        #endregion

        #region 闽政通小程序首屏接口


        /// <summary>
        /// 闽政通小程序过渡页开关
        /// </summary>
        /// <returns></returns>
        [PortalUnFilter, PortalUnEncryptFilter]
        public ActionResult MztDashboard()
        {
            var r = ConfigHelper.AppSettings.MZT_MINI_PROGRAM_DASHBOARD;
            return JResult(r);
        }
        /// <summary>
        /// 闽政通小程序过渡页重要新闻
        /// </summary>
        /// <returns></returns>
        [PortalUnFilter, PortalUnEncryptFilter]
        public ActionResult MztTopNews()
        {
            var r = Jd.PtArticleService.MztTopNews();
            return JResult(r);
        }

        #endregion
    }
}