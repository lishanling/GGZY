using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.WebSockets;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Services.Base;
using GGZY.Services.Extensions;
using GGZY.Services.Infrastructure.Extensions;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class ProjectService 
    {
       

        /// <summary>
        /// 获取统一交易标识码(33位,18位统一社会信用代码、8位日期码、6位流水号和1位校验码组成)
        /// </summary>
        public string Generate_UNIFIED_DEAL_CODE(string INDUSTRIES_TYPE)
        {
            //18位统一社会信用代码
            string SOCIAL_CREDIT_CODE = AppSettingUtils.GetSection("PlatFormSections")?.GetString("SOCIAL_CREDIT_CODE");
            //8位日期码
            string DATECODE = DateTime.Now.ToString("yyyyMMdd");
            //6位流水号
            string SEQNO = FromSql("select SEQ_SOCIAL_CREDIT.nextval from dual").ToScalar<string>().PadLeft(6, '0');


            //1位校验码
            string JYCODE = Mod32Utils.Mod(String.Concat(INDUSTRIES_TYPE, SOCIAL_CREDIT_CODE, DATECODE, SEQNO));

            var UNIFIED_DEAL_CODE_LAST = SOCIAL_CREDIT_CODE + "-" + DATECODE + "-" + SEQNO + "-" + JYCODE;
            return UNIFIED_DEAL_CODE_LAST;
        }

        /// <summary>
        /// 添加完整的项目、招标项目以及标段信息
        /// </summary>
        /// <param name="project"></param>
        /// <param name="tender_project"></param>
        /// <param name="sections"></param>
        /// <returns></returns>
        public GeneralResult AddProject(TENDER_PROJECT tender_project, List<SECTION> sections)
        {
            var r = new GeneralResult();
            var now = ServicesFactory.GGZYJD.CommonService.GetDBDateTime();

            var project = Jd.ProjectService.FirstOrNull(PROJECT._.CONSTRUCTION_ID == tender_project.CONSTRUCTION_ID);
            var bjModel = Jd.TAfcLogService.FirstOrNull(T_AFC_LOG._.ISNEW == 1 && T_AFC_LOG._.CODE == tender_project.CONSTRUCTION_ID);
            if (null == bjModel)
            {
                r.SetFail("报建编号错误/报建信息已被删除");
                return r;
            }

            var sysDic = Jd.ProjectService.FromSql(string.Format("SELECT * FROM SYS_DIC WHERE TYPE='63' AND VALUE='{0}'", bjModel.PROJECT_TYPE)).ToFirstDefault<SYS_DIC>();


            var isExists = Jd.TenderProjectService.CheckIsExists(tender_project.TENDER_PROJECT_NAME, tender_project.TENDER_PROJECT_CODE);
            if (isExists)
            {
                r.SetFail("招标项目名称/招标项目代码已存在");
                return r;
            }
            if (!sections.Any())
            {
                r.SetFail("标段信息不能为空");
                return r;
            }

            var TENDER_PROJECT_CLASSIFY_CODE = sections.First()?.TENDER_PROJECT_CLASSIFY_CODE;
            using (var tran = GetDbSession().BeginTransaction())
            {

                try
                {
                    if (project == null)
                    {
                        //获取行业分类
                        var INDUSTRIES_TYPE = sysDic.VALUE1;
                        project = new PROJECT(bjModel, INDUSTRIES_TYPE, null);

                        //生成项目编号
                        var project_code_seq = Jd.TenderProjectService.Generate_PROJECT_CODE_SEQ(now, tran);
                        project.AttachAll();
                        project.M_CREATOR = Identity?.JdUser()?.ID;
                        project.DATA_TIMESTAMP = now;
                        project.M_CREATE_TM = now;
                        project.CONSTRUCTION_ID = bjModel.CODE;
                        project.PROJECT_CODE = String.Concat(project.INDUSTRIES_TYPE, project.REGION_CODE, project_code_seq);
                        tran.Insert<PROJECT>(project);
                    }

                    var model_tender_project = new TENDER_PROJECT(tender_project);
                    model_tender_project.PROJECT_CODE = project.PROJECT_CODE;
                    model_tender_project.UNIFIED_DEAL_CODE = Generate_UNIFIED_DEAL_CODE(project.INDUSTRIES_TYPE);
                    model_tender_project.M_CREATOR = Identity?.JdUser()?.ID;
                    model_tender_project.DATA_TIMESTAMP = now;
                    model_tender_project.M_CREATE_TM = now;
                    model_tender_project.TENDER_PROJECT_CODE = Jd.TenderProjectService.Generate_TENDER_PROJECT_CODE(project.PROJECT_CODE);
                    model_tender_project.RTYPE = Jd.TenderProjectService.GetRType(model_tender_project.TENDER_PROJECT_TYPE,TENDER_PROJECT_CLASSIFY_CODE);
                    model_tender_project.CONSTRUCTION_ID = bjModel.CODE;
                    tran.Insert<TENDER_PROJECT>(model_tender_project);

                    int section_seq =Jd.SectionService.Generate_BID_CODE_SEQ(model_tender_project.TENDER_PROJECT_CODE);
                    sections.ForEach(sec =>
                    {
                        //防止客户端非法赋值
                        var section = new SECTION(sec);
                        section.TENDER_PROJECT_CODE = model_tender_project.TENDER_PROJECT_CODE;
                        section.BID_SECTION_CODE = String.Concat(model_tender_project.TENDER_PROJECT_CODE,
                            section_seq.ToString().PadLeft(3,'0'));
                        section.UNIFIED_DEAL_CODE = model_tender_project.UNIFIED_DEAL_CODE;
                        section.PLATFORM_CODE = model_tender_project.PLATFORM_CODE;
                        section.PUB_SERVICE_PLAT_CODE = model_tender_project.PUB_SERVICE_PLAT_CODE;
                        tran.Insert<SECTION>(section);
                        section_seq++;
                    });
                    tran.Commit();
                    r.SetSuccess();
                    return r;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    GGZY.Core.Log.LoggerR.Error(String.Concat("添加项目信息失败:", ex.Message), ex);
                    r.SetException(String.Concat("添加项目信息失败:", ex.Message), ex);
                    return r;
                }
            }
        }

        /// <summary>
        /// 根据招标项目编号，查询项目信息/招标项目信息/标段信息
        /// </summary>
        /// <param name="tender_project_code">招标项目编号</param>
        /// <param name="type">查询数据类型:project/tender_project/section</param>
        /// <returns></returns>
        public GeneralResult View(string tender_project_code,string type,string bid_section_code="")
        {
           var r = new GeneralResult();
            var conditionTenderProject = new WhereClipBuilder();
            conditionTenderProject.And(TENDER_PROJECT._.TENDER_PROJECT_CODE == tender_project_code);
            var tender_project = Jd.TenderProjectService.FirstOrNull(conditionTenderProject);
            var dic = new Dictionary<string, object>();
            if(null == tender_project_code)
            {
                r.SetFail("招标项目信息不存在或已被删除");
                return r;
            }
            dic.Add("TENDER_PROJECT_NAME", tender_project.TENDER_PROJECT_NAME);
            dic.Add("TENDERER_NAME", tender_project.TENDERER_NAME);
            dic.Add("TENDERER_CONTRACT", tender_project.TENDERER_CONTRACT);
            dic.Add("TENDERER_PHONE", tender_project.TENDERER_PHONE);
            dic.Add("TENDER_AGENCY_NAME", tender_project.TENDER_AGENCY_NAME);
            dic.Add("TENDER_AGENCY_CODE", tender_project.TENDER_AGENCY_CODE);
            dic.Add("TENDER_PROJECT_CODE_OLD1", tender_project.TENDER_PROJECT_CODE_OLD1);
            dic.Add("TENDER_PROJECT_CODE", tender_project.TENDER_PROJECT_CODE);
            dic.Add("TYPE", type);
            dic.Add("RTYPE", tender_project.RTYPE);

            var conditionProject = new WhereClipBuilder();
            conditionProject.And(PROJECT._.PROJECT_CODE == tender_project.PROJECT_CODE);
            var project = FirstOrNull(conditionProject);
            if (null == project)
            {
                r.SetFail("项目信息不存在或已被删除");
                return r;
            }
            if (type == "project")
            {
                var dicProject = project.ToBindDicDictionary();
                dicProject.Add("AREA",Fw.SysAreaQuanguoService.GetRegionNames(project.REGION_CODE));
                var platformcode = project.PLATFORM_CODE;
                var platFormEntity = Jd.TUserTradeplatformService.FirstOrNull(T_USER_TRADEPLATFORM._.PLATFORM_CODE == platformcode);
                dicProject.Add("PLATFORM_CODE_TEXT", platFormEntity?.SYSTEM_NAME);
                dicProject.Add("M_ATT_LICENSE_FILE_ATTACHMENT", Jd.CommonService.Attachments(project.M_ATT_LICENSE_FILE, "Sys",
                    true));
                dicProject.Add("M_ATT_PROJECT_APPROVAL_FILE_ATTACHMENT", Jd.CommonService.Attachments(project.M_ATT_PROJECT_APPROVAL_FILE, "Sys",true));
                dic.Add("DATA", dicProject);
                r.SetSuccess(dic);
                return r;
            }
            if(type == "tender_project")
            {
                var data = tender_project.ToBindDicDictionary();
                data.Add("PROJECT_NAME", project.PROJECT_NAME);
                var dept = Jd.TUserDepartmentService.FirstOrNull(T_USER_DEPARTMENT._.DEPID == tender_project.RECORD_DEPID);
                data.Add("DNAME", dept?.DNAME);
                data.Add("AREA", String.Join(" ",Fw.SysAreaQuanguoService.GetRegionNames(tender_project.REGION_CODE)));
                data.Add("AREA_CODE",(String.IsNullOrWhiteSpace(tender_project.REGION_CODE) || tender_project.REGION_CODE.Length !=6)?new List<string>():new List<string>{
                    tender_project.REGION_CODE.Substring(0,2).PadRight(6,'0'),
                    tender_project.REGION_CODE.Substring(0,4).PadRight(6,'0'),
                    tender_project.REGION_CODE
                }.Distinct());
                var platformcode = tender_project.PLATFORM_CODE;
                var platFormEntity = Jd.TUserTradeplatformService.FirstOrNull(T_USER_TRADEPLATFORM._.PLATFORM_CODE == platformcode);
                data.Add("PLATFORM_CODE_TEXT", platFormEntity?.SYSTEM_NAME);

                dic.Add("DATA", data);
                r.SetSuccess(dic);
                return r;
            }

            if (type == "section")
            {
                var conditionSection = new WhereClipBuilder();
                conditionSection.And(SECTION._.TENDER_PROJECT_CODE == tender_project.TENDER_PROJECT_CODE);
                if(! String.IsNullOrEmpty(bid_section_code))
                {
                    conditionSection.And(SECTION._.BID_SECTION_CODE == bid_section_code);
                    var section = Jd.SectionService.FirstOrNull(conditionSection);
                    if (null == section)
                    {
                        r.SetFail("标段信息不存在或已被删除");
                        return r;
                    }

                    var data = section.ToBindDicDictionary();
                    var platformcode = section.PLATFORM_CODE;
                    var platFormEntity = Jd.TUserTradeplatformService.FirstOrNull(T_USER_TRADEPLATFORM._.PLATFORM_CODE == platformcode);
                    data.Add("PLATFORM_CODE_TEXT", platFormEntity?.SYSTEM_NAME);
                    dic.Add("DATA", data);
                    r.SetSuccess(dic);
                    return r;
                }


                var sections = Jd.SectionService.FindList(conditionSection);
                if (!sections.Any())
                {
                    r.SetFail("标段信息不存在或已被删除");
                    return r;
                }

                List<Dictionary<string, object>> datas = new List<Dictionary<string, object>>();
                foreach(var section in sections)
                {
                    var data = section.ToBindDicDictionary();
                    var platformcode = section.PLATFORM_CODE;
                    var platFormEntity = Jd.TUserTradeplatformService.FirstOrNull(T_USER_TRADEPLATFORM._.PLATFORM_CODE == platformcode);
                    data.Add("PLATFORM_CODE_TEXT", platFormEntity?.SYSTEM_NAME);
                    //dic.Add("DATA", section);
                    datas.Add(data);
                }

                dic.Add("DATA", datas);
                r.SetSuccess(dic);
                return r;
            }
            r.SetFail("type值错误");
            return r;
        }
    }
}