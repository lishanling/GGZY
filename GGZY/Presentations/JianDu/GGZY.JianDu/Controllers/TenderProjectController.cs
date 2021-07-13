using System;
using System.Web.Mvc;
using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;
using System.Collections.Generic;
using System.Linq;
using GGZY.JianDu.Models;

namespace GGZY.JianDu.Controllers
{
    public partial class JdTenderProjectController : BaseController
    {
        /// <summary>
        /// 招标项目管理-列表
        /// </summary>
        /// <param name="tender_project"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult List(TENDER_PROJECT tender_project, SearchCondition search)
        {
            GeneralResult r = new GeneralResult();
            var data = Jd.TenderProjectService.List(tender_project, search);
            r.SetSuccess(data);
            return JResult(r);
        }

        public ActionResult TabCollection()
        {
            var data = Jd.TenderProjectService.TabCollection();
            return JResult(data);
        }

        /// <summary>
        /// 招标项目管理-列表-行业主管
        /// </summary>
        /// <param name="tender_project"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult Collection(TENDER_PROJECT_REQUEST tender_project, SearchCondition search)
        {
            GeneralResult r = new GeneralResult();

            if (JdUser.UserDepartment.JGBM == "MZ" || JdUser.UserDepartment.JGBM == "MT")
            {
                var data = Jd.TenderProjectService.Collection_ZJ(tender_project.TENDER_PROJECT_NAME, tender_project.TENDER_PROJECT_CODE,
                   tender_project.REVIEW_TYPE, tender_project.REVIEW_STATUS, tender_project.Is_SIGN,
                   tender_project.IS_SIGNUP, tender_project.REVIEW_ASCRIPTION, search.BeginTime, search.EndTime, search, tender_project.NODE_NAME);
                r.SetSuccess(data);
            }
            else
            {
                var data = Jd.TenderProjectService.Collection(tender_project.TENDER_PROJECT_NAME, tender_project.TENDER_PROJECT_CODE,
                    tender_project.REVIEW_TYPE, tender_project.REVIEW_STATUS, tender_project.Is_SIGN,
                    tender_project.IS_SIGNUP, tender_project.REVIEW_ASCRIPTION, search.BeginTime, search.EndTime, search);
                r.SetSuccess(data);
            }
            return JResult(r);
        }

        /// <summary>
        /// 更新招标项目
        /// </summary>
        /// <param name="tender_project"></param>
        /// <returns></returns>
        public ActionResult Update(TENDER_PROJECT tender_project)
        {
            var result = new GeneralResult();
            if (null == tender_project)
            {
                result.SetFail("招标项目不能为空");
                return JResult(result);
            }
            if (!tender_project.M_ID.HasValue || tender_project.M_ID == 0)
            {
                result.SetFail("招标项目ID不能为空");
                return JResult(result);
            }
            var data = Jd.TenderProjectService.Save(tender_project);
            return JResult(data);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="tender_project_code"></param>
        /// <returns></returns>
        public ActionResult Delete(string tender_project_code = "")
        {
            var result = new GeneralResult();
            if (String.IsNullOrEmpty(tender_project_code))
            {
                result.SetFail("招标项目编号不能为空");
                return JResult(result);
            }
            result = Jd.TenderProjectService.Delete(tender_project_code);
            return JResult(result);
        }

        /// <summary>
        /// 通过服务平台TENDER_PROJECT_CODE获取监督平台对应的TENDER_PROJECT信息
        /// </summary>
        /// <param name="fwTenderProjectCode">服务平台TENDER_PROJECT_CODE</param>
        /// <returns></returns>
        public ActionResult GetJdTenderProjectFwTpCode(string fwTenderProjectCode)
        {
            var result = Jd.TenderProjectService.GetJdTenderProjectFwTpCode(fwTenderProjectCode);
            return JResult(result);
        }

        public ActionResult TenderProjectInfo(string jdTenderProjectCode, string fwTenderProjectCode)
        {
            var result = Jd.TenderProjectService.TenderProjectInfo(jdTenderProjectCode, fwTenderProjectCode);
            return JResult(result);
        }

    }
}