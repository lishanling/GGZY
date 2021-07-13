using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    /// <summary>
    /// 标段信息
    /// </summary>
    public partial class JdSectionController: BaseController
    {
        [AcceptVerbs("POST")]
        public ActionResult Add(SECTION model)
        {
            var result = new GeneralResult();
            if(null == model)
            {
                result.SetFail("标段信息不能为空");
                return JResult(result);
            }
            if (String.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
            {
                result.SetFail("招标项目编号不能为空");
                return JResult(result);
            }
            var tender_project = Jd.TenderProjectService.FirstOrNull(TENDER_PROJECT._.TENDER_PROJECT_CODE == model.TENDER_PROJECT_CODE);
            if(null == tender_project)
            {
                result.SetFail("招标项目信息不存在或已删除");
                return JResult(result);
            }
            //防止客户端非法赋值
            var section = new SECTION(model);
            
            section.TENDER_PROJECT_CODE = model.TENDER_PROJECT_CODE;
            section.BID_SECTION_CODE = String.Concat(model.TENDER_PROJECT_CODE,
                Jd.SectionService.Generate_BID_CODE_SEQ(model.TENDER_PROJECT_CODE).ToString().PadLeft(3,'0'));
            section.UNIFIED_DEAL_CODE = tender_project.UNIFIED_DEAL_CODE;
            section.PLATFORM_CODE = tender_project.PLATFORM_CODE;
            section.PUB_SERVICE_PLAT_CODE = tender_project.PUB_SERVICE_PLAT_CODE;
            result =Jd.SectionService.Add(section);
            return JResult(result);
        }
        /// <summary>
        /// 标段包列表
        /// </summary>
        /// <param name="model">标段包搜索条件</param>
        /// <param name="search">分页条件</param>
        /// <returns></returns>
        public ActionResult List(SECTION model,SearchCondition search)
        {
            var result = new GeneralResult();
            if (null == model || String.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
            {
                result.SetFail("招标项目编号不能为空");
                return JResult(result);
            }
            var data = Jd.SectionService.List(model, search);
            return JResult(data);
        }
        /// <summary>
        /// 修改标段信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Save(SECTION model)
        {
            var result = new GeneralResult();
            if (null == model)
            {
                result.SetFail("标段信息不能为空");
                return JResult(result);
            }
            if (null == model || !model.M_ID.HasValue)
            {
                result.SetFail("标段ID不能为空");
                return JResult(result);
            }
            var data = Jd.SectionService.Save(model);
            return JResult(data);
        }
        [HttpPost]
        public ActionResult DeleteSection(string ids)
        {
            GeneralResult result = new GeneralResult();
            if(String.IsNullOrWhiteSpace(ids))
            {
                result.SetFail($"请选择要删除的记录");
                return JResult(result);
            }
            var mids = ids.Split(new char[] { ',','，',';'});
            result = Jd.SectionService.Delete(mids);
            return JResult(result);
        }
    }
}