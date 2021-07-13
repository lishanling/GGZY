using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;
using GGZY.Core.Helper;
using GGZY.Services.Base;
using System.Collections.Generic;
using Newtonsoft.Json;
using GGZY.Services.Infrastructure.Extensions;
using System.Linq;

namespace GGZY.JianDu.Controllers
{
    /// <summary>
    /// 招标项目管理
    /// </summary>
    public partial class JdProjectController
    {
        /// <summary>
        /// 根据报建编号获取项目信息
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        public ActionResult Get_Project_By_BJNO(string no = "")
        {
            if (String.IsNullOrEmpty(no))
            {
                return JResult("报建编号不能为空");
            }
            var model = Jd.ProjectService.FirstOrNull(PROJECT._.CONSTRUCTION_ID == no);
            var bjModel = Jd.TAfcLogService.FirstOrNull(T_AFC_LOG._.ISNEW == 1 && T_AFC_LOG._.CODE == no);
            if (null == bjModel)
            {
                return JResult("报建信息不能为空");
            }
            // 获取数据库时间
            //var now = Jd.ProjectService.FromSql("select sysdate from dual").First<DateTime>();

            var sysDic = Jd.ProjectService.FromSql(string.Format("SELECT * FROM SYS_DIC WHERE TYPE='63' AND VALUE='{0}'", bjModel.PROJECT_TYPE)).ToFirstDefault<SYS_DIC>();
            if (model == null)
            {

                //获取行业分类
                var INDUSTRIES_TYPE = sysDic.VALUE1;

                model = new PROJECT(bjModel, INDUSTRIES_TYPE, null);
                //优化调整为 入库时候生成项目编号，避免编号浪费
                //生成项目编号
                //var project_code_seq = Jd.ProjectService.Generate_PROJECT_CODE_SEQ(now);
                //model.PROJECT_CODE = String.Concat(INDUSTRIES_TYPE, model.REGION_CODE, project_code_seq);
                model.M_CREATOR = Identity.JdUser()?.ID;
                model.INDUSTRIES_TYPE = INDUSTRIES_TYPE;
            }

            var UserDetail = JdUser?.UserExtend;

            var dic = model.ToDict();
            dic.Add("EXTEND", new
            {
                KIND = bjModel.KIND,                         //报建类别/行业分类
                TENDER_PROJECT_TYPE = sysDic?.VALUE3,        //招标项目类型代码
                TENDER_PROJECT_TYPE_TEXT = sysDic?.VALUE4,   //招标项目类型名称
                TENDERER_CODE = bjModel.JS_CODE,            //招标人统一社会信用代码
                TENDER_AGENCY_NAME = UserDetail?.DEP_NAME,   //招标代理机构名称
                TENDER_AGENCY_CODE = UserDetail?.UNIFIED_CREDIT_CODE,  //招标代理机构代码
                UNIFIED_DEAL_CODE = Jd.ProjectService.Generate_UNIFIED_DEAL_CODE(model.INDUSTRIES_TYPE),
                //TENDER_PROJECT_CODE = Jd.ProjectService.Generate_TENDER_PROJECT_CODE(model.PROJECT_CODE), //招标项目编号
                AREANAME = Fw.SysAreaQuanguoService.GetRegionNames(model.REGION_CODE),
                AREA_CODE = (String.IsNullOrWhiteSpace(model.REGION_CODE) || model.REGION_CODE.Length != 6) ? new List<string>() : new List<string> {
                    model.REGION_CODE.Substring(0, 2).PadRight(6, '0'),
                    model.REGION_CODE.Substring(0, 4).PadRight(6, '0'),
                    model.REGION_CODE,
                }.Distinct<string>()
            });
            return JResult(dic);
        }

        /// <summary>
        /// 创建PROJECT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateInput(false)]
        public ActionResult Add(TENDER_PROJECT tender_project,List<SECTION> sections)
        {
            return JResult(Jd.ProjectService.AddProject(tender_project, sections));

        }
        /// <summary>
        /// 获取项目相关信息
        /// </summary>
        /// <param name="TENDER_PROJECT_CODE">招标项目信息</param>
        /// <param name="type">数据类型:project/tender_project/section</param>
        /// <returns></returns>
        public ActionResult Detail(string TENDER_PROJECT_CODE,string type,string bid_section_code="")
        {
            GeneralResult r = new GeneralResult();
            if (String.IsNullOrWhiteSpace(TENDER_PROJECT_CODE))
            {
                r.SetFail("招标项目编号不能为空");
                return JResult(r);
            }
            if (String.IsNullOrWhiteSpace(type))
            {
                r.SetFail("数据类型type不能为空");
                return JResult(r);
            }
            type = type.ToLower();
            r = Jd.ProjectService.View(TENDER_PROJECT_CODE, type, bid_section_code);
            return JResult(r);
        }
    }
}