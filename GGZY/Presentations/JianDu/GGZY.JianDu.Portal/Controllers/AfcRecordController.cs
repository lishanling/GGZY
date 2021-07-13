using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using GGZY.Services.Infrastructure.Model.JianDu;

namespace GGZY.JianDu.Portal.Controllers
{
    /// <summary>
    /// 登记备案（处长门户）
    /// </summary>
    public class AfcRecordController : BaseController
    {
        #region 招标计划登记 
        /// <summary>
        /// 行业类型 报建类别
        /// </summary>
        /// <returns></returns>
        public ActionResult AfcProjectKind()
        {
            var r = Jd.TAfcProjectService.AfcProjectKind();
            return JResult(r);
        }
        /// <summary>
        /// 项目类型 发包方式
        /// </summary>
        /// <param name="kind">行业类型 报建类别</param>
        /// <returns></returns>
        public ActionResult AfcProjectFBFS(string kind)
        {
            var r = Jd.TAfcProjectService.AfcProjectFBFS(kind);
            return JResult(r);
        }
        /// <summary>
        /// 招标计划登记 行业 
        /// </summary>
        /// <param name="kind">行业类型 报建类别</param>
        /// <returns></returns>
        /// <remarks>
        /// 【行业部门】
        /// 该标签内容，根据当前账号所属的行业，对应展示标签
        /// 【纪委】
        /// 该标签内容，根据当前账号所属的行业，对应展示标签
        /// 如配置时管辖行业设置为多个行业，则可见多个行业，该标签对应展示多个行业子项内容
        /// 【公安】
        /// 该标签内容，根据当前账号所属的行业，对应展示标签
        /// 如配置时管辖行业设置为多个行业，则可见多个行业，该标签对应展示多个行业子项内容
        /// </remarks>
        public ActionResult AfcProjectType(string kind = "")
        {
            var r = Jd.TAfcProjectService.AfcProjectType(kind);
            return JResult(r);
        }
        /// <summary>
        /// 招标计划登记列表 
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult AfcProjects(TAfcProjectModel model, SearchCondition search)
        {
            var r = Jd.TAfcProjectService.AfcProjects(model, search);
            return JResult(r);
        }
        /// <summary>
        /// 招标计划登记详情
        /// </summary>
        /// <param name="mid"></param>
        /// <returns></returns>
        public ActionResult ProjectReportBuildDetail(string mid)
        {
            var r = Jd.TAfcProjectService.ProjectReportBuildDetail(mid);
            return JResult(r);
        }
        #endregion

        #region 招标备案
        /// <summary>
        /// 招标备案列表接口
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult RecordReviews(TAfcProjectModel model, SearchCondition search)
        {
            var r = Jd.RecordReviewService.CzRecordReviews(model, search);
            return JResult(r);
        }

        /// <summary>
        /// 闽政通招标备案列表接口
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult MztRecordReviews( SearchCondition search)
        {
            var r = Jd.TenderProjectService.MztRecordReviews(search);
            return JResult(r);
        }

        #endregion

       
    }
}