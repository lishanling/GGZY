using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYFW.DbEntity;
using GGZYJD.DbEntity;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PROJECT = GGZYJD.DbEntity.PROJECT;
using SYS_DIC = GGZYFW.DbEntity.SYS_DIC;
using TENDER_PROJECT = GGZYFW.DbEntity.TENDER_PROJECT;

namespace GGZY.Services.JianDu
{
    public partial class TAfcFixedService
    {
        #region 监督平台门户联动监管 标前 标中 标后

        #region 标前

        public PageTableResult BeforeList(SearchCondition search)
        {
            var condition = new WhereClipBuilder();
            var guid = new Field("GUID");
            var tzCode = new Field("TZ_CODE");
            var projectName = new Field("PROJECT_NAME");
            var applyDate = new Field("APPLY_DATE");
            if (!string.IsNullOrWhiteSpace(search.KeyWord))
            {
                condition.And(tzCode.Contain(search.KeyWord) || projectName.Contain(search.KeyWord));
            }

            if (search.BeginTime.HasValue)
            {
                condition.And(applyDate >= search.BeginTime.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            }
            if (search.EndTime.HasValue)
            {
                condition.And(applyDate <= search.EndTime.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            }

            var query = FromWhere<T_AFC_FIXED_RECORD>().Select(guid, T_AFC_FIXED_RECORD._.PROJECT_CODE.As("TZ_CODE"),
                    T_AFC_FIXED_RECORD._.PROJECT_NAME, T_AFC_FIXED_RECORD._.APPLY_DATE,
                    T_AFC_FIXED_RECORD._.TOTAL_MONEY, T_AFC_FIXED_RECORD._.PROJECT_TYPE,
                    new Field("'FIXED'").As("AFC_TYPE"))
                .UnionAll(FromWhere<T_AFC_SECONDARY_PROJECT>().Select(guid,
                    T_AFC_SECONDARY_PROJECT._.PROJECT_CODE.As("TZ_CODE"), T_AFC_SECONDARY_PROJECT._.PROJECT_NAME,
                    T_AFC_SECONDARY_PROJECT._.APPLY_DATE_TIME.ToChar("yyyy-mm-dd hh24:mi:ss", "APPLY_DATE"),
                    T_AFC_SECONDARY_PROJECT._.TOTAL_MONEY, T_AFC_SECONDARY_PROJECT._.PROJECT_TYPE,
                    new Field("'SECONDARY'").As("AFC_TYPE")))
                .UnionAll(FromWhere<T_AFC_XMCODE_RECORD>().Select(guid, T_AFC_XMCODE_RECORD._.PROJECTCODE.As("TZ_CODE"),
                    T_AFC_XMCODE_RECORD._.PROJECTNAME.As("PROJECT_NAME"),
                    T_AFC_XMCODE_RECORD._.MODIFYTIME.ToChar("yyyy-mm-dd hh24:mi:ss", "APPLY_DATE"),
                    new Field("''").As("TOTAL_MONEY"), T_AFC_XMCODE_RECORD._.PROJECTTYPE.As("PROJECT_TYPE"),
                    new Field("'XMCODE'").As("AFC_TYPE")))
                .Where(condition.ToWhereClip());

            var count = query.Count();
            var page = query
                .Page(search.PageSize, search.PageNo)
                .OrderBy(applyDate.Desc)
                .ToList<BeforeListModel>().ToPageTableResult(search, count);
            return page;
        }
        /// <summary>
        /// 标前详情
        /// </summary>
        /// <param name="guid"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public GeneralResult<BeforeDetailModel> BeforeDetail(string guid, string type)
        {
            var r = new GeneralResult<BeforeDetailModel>();
            var detail = new BeforeDetailModel();
            if (string.Compare(type, "FIXED", StringComparison.CurrentCultureIgnoreCase) == 0)
            {
                detail = FixedDetail(guid);

            }
            else if (string.Compare(type, "SECONDARY", StringComparison.CurrentCultureIgnoreCase) == 0)
            {
                detail = SecondaryDetail(guid);
            }
            else if (string.Compare(type, "XMCODE", StringComparison.CurrentCultureIgnoreCase) == 0)
            {
                detail = XmCodeDetail(guid);
            }
            else
            {
                r.SetFail("参数type错误");
            }

            if (detail != null)
            {
                detail.SetProjectEnterprise();
                r.SetSuccessT(detail);
            }
            else
            {
                r.SetFail("暂无数据");
            }

            return r;

        }

        #region BeforeDetailModel

        public BeforeDetailModel FixedDetail(string guid)
        {
            BeforeDetailModel detail = null;
            var entity = FromWhere<T_AFC_FIXED_RECORD>(T_AFC_FIXED_RECORD._.GUID == guid || T_AFC_FIXED_RECORD._.PROJECT_CODE == guid || T_AFC_FIXED_RECORD._.REPORT_CODE == guid).ToFirst();
            if (entity != null)
            {
                detail = new BeforeDetailModel();
                #region 申报项目基本信息

                detail.Project.XMDM = entity.PROJECT_CODE;
                detail.Project.XMMC = entity.PROJECT_NAME;
                detail.Project.SBSJ = entity.APPLY_DATE;
                detail.Project.TZXM = String.Empty;
                detail.Project.XMLX = entity.PROJECT_TYPE_NAME;
                detail.Project.REGION = entity.PLACE_CODE_NAME;
                detail.Project.BJBH = entity.REPORT_CODE;
                detail.Project.GCLB = String.Empty;
                detail.Project.GCTZXZ = String.Empty;
                detail.Project.GCJSXZ = String.Empty;
                detail.Project.SFZDXM = entity.IS_MAJOR;
                detail.Project.GCYT = Jd.SysDicService.FindTextValue("78", entity.PROJECT_FUNCTION);
                detail.Project.GBHY = entity.INDUSTRY;//todo
                detail.Project.XMSSHY = entity.THE_INDUSTRY_NAME;
                detail.Project.JSXZ = Jd.SysDicService.FindTextValue("77", entity.HOUSE_PROJECT_NATURE.TrimStart('0').Replace("99", "7"));
                detail.Project.XMSX = String.Empty;
                detail.Project.KGNF = entity.START_YEAR;
                detail.Project.JCNF = entity.END_YEAR;
                detail.Project.XMZTZ = entity.TOTAL_MONEY;
                detail.Project.SM = String.Empty;
                detail.Project.ZDLX = String.Empty;
                detail.Project.ZDML = String.Empty;
                detail.Project.XXDZ = entity.PLACE_CODE_DETAIL_NAME;
                detail.Project.NRGM = entity.SCALE_CONTENT;
                #endregion

                #region 企业法人信息

                var enterprise = FromWhere<T_AFC_FIXED_ENTERPRISE>(T_AFC_FIXED_ENTERPRISE._.PROJECT_CODE == entity.PROJECT_CODE).ToList();
                if (enterprise != null && enterprise.Any())
                {
                    detail.Enterprise = enterprise.Select(c =>
                    {
                        var m = new BeforeEnterpriseDetail
                        {
                            QYMC = c.ENTERPRISE_NAME,
                            QYZCLX = c.LEREP_CERTTYPE_NAME, //todo
                            XMFRZZLX = c.LEREP_CERTTYPE_NAME,
                            XMFRZZHM = $"{c.LEREP_CERTNO.MaxSubString(4)}****{c.LEREP_CERTNO.MaxSubString(4, false)}",
                            FRXM = c.ENTERPRISE_NAME,
                            FRSFZJLX = c.LEREP_CERTTYPE_NAME,
                            FRSFZJHM = $"{c.LEREP_CERTNO.MaxSubString(4)}****{c.LEREP_CERTNO.MaxSubString(4, false)}",
                            LXRXM = c.CONTACT_NAME,
                            LXRSFZJLX = c.CONTACT_TYPE_NAME,
                            LXRSFZJHM = c.ENTERPRISE_NATURE,
                            LXRGH = c.CONTACT_PHONE,
                            LXRYX = c.CONTACT_EMAIL,
                            LXRSJ = c.CONTACT_TEL,
                            CZ = c.CONTACT_FAX,
                        };
                        return m;
                    }).ToList();

                    #endregion
                }
            }
            return detail;
        }
        public BeforeDetailModel SecondaryDetail(string guid)
        {
            BeforeDetailModel detail = null;
            var entity = FromWhere<T_AFC_SECONDARY_PROJECT>(T_AFC_SECONDARY_PROJECT._.GUID == guid || T_AFC_SECONDARY_PROJECT._.PROJECT_CODE == guid || T_AFC_SECONDARY_PROJECT._.REPORT_CODE == guid).ToFirst();
            if (entity != null)
            {
                detail = new BeforeDetailModel();
                #region 申报项目基本信息

                detail.Project.XMDM = entity.PROJECT_CODE;
                detail.Project.XMMC = entity.PROJECT_NAME;
                detail.Project.SBSJ = entity.APPLY_DATE;
                detail.Project.TZXM = String.Empty;
                detail.Project.XMLX = entity.PROJECT_TYPE_NAME;
                detail.Project.REGION = entity.AREA_NAME;
                detail.Project.BJBH = entity.REPORT_CODE;
                detail.Project.GCLB = String.Empty;
                detail.Project.GCTZXZ = String.Empty;
                detail.Project.GCJSXZ = String.Empty;
                detail.Project.SFZDXM = entity.IS_MAJOR;
                detail.Project.GCYT = Jd.SysDicService.FindTextValue("78", entity.PROJECT_FUNCTION);
                detail.Project.GBHY = entity.INDUSTRY_NAME;
                detail.Project.XMSSHY = entity.THE_INDUSTRY_NAME;
                detail.Project.JSXZ = Jd.SysDicService.FindTextValue("77", entity.HOUSE_PROJECT_NATURE.TrimStart('0').Replace("99", "7"));
                detail.Project.XMSX = entity.PROJECT_ATTRIBUTE_NAME;
                detail.Project.KGNF = entity.START_YEAR;
                detail.Project.JCNF = entity.END_YEAR;
                detail.Project.XMZTZ = entity.TOTAL_MONEY;
                detail.Project.SM = String.Empty;
                detail.Project.ZDLX = String.Empty;
                detail.Project.ZDML = String.Empty;
                detail.Project.XXDZ = entity.PLACE_CODE_DETAIL_NAME;
                detail.Project.NRGM = entity.SCALE_CONTENT;
                #endregion

                #region 企业法人信息

                var enterprise = FromWhere<T_AFC_SECONDARY_ENTERPRISE>(T_AFC_SECONDARY_ENTERPRISE._.PROJECT_CODE == entity.PROJECT_CODE).ToList();
                if (enterprise != null && enterprise.Any())
                {
                    detail.Enterprise = enterprise.Select(c =>
                    {
                        var m = new BeforeEnterpriseDetail
                        {
                            QYMC = c.ENTERPRISE_NAME,
                            QYZCLX = c.LEREP_CERTTYPE_NAME,
                            XMFRZZLX = c.LEREP_CERTTYPE_NAME,
                            XMFRZZHM = $"{c.LEREP_CERTNO.MaxSubString(4)}****{c.LEREP_CERTNO.MaxSubString(4, false)}",
                            FRXM = c.LEREP_REPRESENTATIVE,
                            FRSFZJLX = c.LEREP_REPRESENTATIVE_CERTTYPE_NAME,
                            FRSFZJHM = $"{c.LEREP_REPRESENTATIVE_CERTNO.MaxSubString(4)}****{c.LEREP_REPRESENTATIVE_CERTNO.MaxSubString(4, false)}",
                            LXRXM = c.CONTACT_NAME,
                            LXRSFZJLX = c.CONTACT_TYPE_NAME,
                            LXRSFZJHM = $"{c.CONTACT_CERTNO.MaxSubString(4)}****{c.CONTACT_CERTNO.MaxSubString(4, false)}",
                            LXRGH = c.CONTACT_PHONE,
                            LXRYX = c.CONTACT_EMAIL,
                            LXRSJ = c.CONTACT_TEL,
                            CZ = string.Empty
                        };
                        return m;
                    }).ToList();

                    #endregion
                }
            }
            return detail;
        }
        public BeforeDetailModel XmCodeDetail(string guid)
        {
            BeforeDetailModel detail = null;
            var entity = FromWhere<T_AFC_XMCODE_RECORD>(T_AFC_XMCODE_RECORD._.GUID == guid || T_AFC_XMCODE_RECORD._.PROJECTCODE == guid || T_AFC_XMCODE_RECORD._.REPORTBUILDINGNUMBER == guid).ToFirst();
            if (entity != null)
            {
                detail = new BeforeDetailModel();
                #region 申报项目基本信息
                var natureDict = new Dictionary<string, string>()
                {
                    {"0","1" },
                    {"1","3" },
                    {"2","5" },
                    {"3","2" },
                    {"4","7" },
                };
                var nature = natureDict.ContainsKey(entity.PROJECTNATURE)
                    ? natureDict[entity.PROJECTNATURE]
                    : "4";
                detail.Project.XMDM = entity.PROJECTCODE;
                detail.Project.XMMC = entity.PROJECTNAME;
                detail.Project.SBSJ = entity.MODIFYTIME?.ToString("yyyy-MM-dd HH:mm:ss");
                detail.Project.TZXM = String.Empty;
                detail.Project.XMLX = entity.PROJECT_TYPE_NAME;
                detail.Project.REGION = Jd.SysAreaQuanguoService.FirstOrNull(GGZYJD.DbEntity.SYS_AREA_QUANGUO._.AREACODE == entity.DIVISIONCODE)?.AREANAME;
                detail.Project.BJBH = entity.REPORTBUILDINGNUMBER;
                detail.Project.GCLB = String.Empty;
                detail.Project.GCTZXZ = String.Empty;
                detail.Project.GCJSXZ = String.Empty;
                detail.Project.SFZDXM = string.IsNullOrEmpty(entity.MAJOR) && entity.MAJOR != "09" ? "是" : "否";
                detail.Project.GCYT = entity.PROJECTCLASSIFY;
                detail.Project.GBHY = String.Empty;//todo entity.INDUSTRY_NAME;
                detail.Project.XMSSHY = entity.THE_INDUSTRY_NAME;
                detail.Project.JSXZ = Jd.SysDicService.FindTextValue("77", nature);
                detail.Project.XMSX = entity.PROJECT_ATTRIBUTE_NAME;
                detail.Project.KGNF = entity.STARTTIME?.Split('-').FirstOrDefault();
                detail.Project.JCNF = String.Empty;
                detail.Project.XMZTZ = entity.TOTALINVESTMENT;
                detail.Project.SM = String.Empty;
                detail.Project.ZDLX = String.Empty;
                detail.Project.ZDML = String.Empty;
                detail.Project.XXDZ = entity.PLACEDETAILADDRESS;
                detail.Project.NRGM = entity.SCALECONTENT;
                #endregion

                #region 企业法人信息

                var enterprise = FromWhere<T_AFC_XMCODE_ENTERPRISE>(T_AFC_XMCODE_ENTERPRISE._.PROJECT_CODE == entity.PROJECTCODE).ToList();
                if (enterprise != null && enterprise.Any())
                {
                    detail.Enterprise = enterprise.Select(c =>
                    {
                        var m = new BeforeEnterpriseDetail
                        {
                            QYMC = c.ENTERPRISENAME,
                            QYZCLX = c.ENTERPRISELICENCETYPE_NAME,
                            XMFRZZLX = c.ENTERPRISELICENCETYPE_NAME,
                            XMFRZZHM = $"{c.ENTERPRISELICENCENO.MaxSubString(4)}****{c.ENTERPRISELICENCENO.MaxSubString(4, false)}",
                            FRXM = c.LEGALREPRESENTATIVENAME,
                            FRSFZJLX = c.LEREP_REPRESENTATIVE_CERTTYPE_NAME,
                            FRSFZJHM = $"{c.LEGALREPRESENTATIVEIDNO.MaxSubString(4)}****{c.LEGALREPRESENTATIVEIDNO.MaxSubString(4, false)}",
                            LXRXM = c.CONTACTNAME,
                            LXRSFZJLX = String.Empty,
                            LXRSFZJHM = String.Empty,
                            LXRGH = c.CONTACTPHONE,
                            LXRYX = c.CONTACTEMAIL,
                            LXRSJ = c.CONTACTPHONE,
                            CZ = string.Empty,// c.ENTERPRISEFAX
                        };
                        return m;
                    }).ToList();

                    #endregion
                }
            }
            return detail;
        }
        #endregion
        #endregion

        #region 标中

        #endregion

        #region 标后

        public PageTableResult AfterList(SearchCondition search)
        {
            var condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(search.KeyWord))
            {
                condition.And(TENDER_PROJECT._.TENDER_PROJECT_CODE.Contain(search.KeyWord) || TENDER_PROJECT._.TENDER_PROJECT_NAME.Contain(search.KeyWord));
            }

            if (search.BeginTime.HasValue)
            {
                condition.And(CONTRACT_PERFORMANCE._.CONTRACT_SIGN_TIME >= search.BeginTime);
            }
            if (search.EndTime.HasValue)
            {
                condition.And(CONTRACT_PERFORMANCE._.CONTRACT_SIGN_TIME <= search.EndTime);
            }
            var query = Fw.TenderProjectService.FromWhere()
                .InnerJoin<CONTRACT_PERFORMANCE>(TENDER_PROJECT._.TENDER_PROJECT_CODE ==
                                                 CONTRACT_PERFORMANCE._.TENDER_PROJECT_CODE)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "10" && SYS_DIC._.VALUE == TENDER_PROJECT._.TENDER_PROJECT_TYPE)
                .Where(condition.ToWhereClip());
            var total = query.Count();
            var pageList = query.OrderBy(CONTRACT_PERFORMANCE._.CONTRACT_SIGN_TIME.Desc)
                .Page(search.PageSize, search.PageNo)
                .Select(TENDER_PROJECT._.M_ID.As("GUID"), TENDER_PROJECT._.TENDER_PROJECT_CODE, TENDER_PROJECT._.TENDER_PROJECT_NAME, CONTRACT_PERFORMANCE._.CONTRACT_SIGN_TIME,
                    SYS_DIC._.TEXT.As("TENDER_PROJECT_TYPE_NAME"), TENDER_PROJECT._.TENDER_PROJECT_TYPE)
                .ToList<dynamic>()
                .ToPageTableResult(search, total, c => { c.Type = ""; return c; });
            return pageList;
        }

        public object AfterDetail(string guid, string type)
        {
            //return AfterDetailMock(guid);
            var tenderProject =
                Fw.TenderProjectService.FromWhere(TENDER_PROJECT._.M_ID == guid)
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "10" && SYS_DIC._.VALUE == TENDER_PROJECT._.TENDER_PROJECT_TYPE)
                    .LeftJoin<CONTRACT_PERFORMANCE>(TENDER_PROJECT._.TENDER_PROJECT_CODE ==
                                                    CONTRACT_PERFORMANCE._.TENDER_PROJECT_CODE)
                    .Select(SYS_DIC._.TEXT.As("TENDER_PROJECT_TYPE_NAME"), TENDER_PROJECT._.All)
                    .ToFirst<dynamic>();//项目基本情况
            var tenderProjectCode = tenderProject.TENDER_PROJECT_CODE;
            var projectCode = tenderProject.PROJECT_CODE;
            var sgxk = Fw.CommonService.FromWhere<BHXX_CONSTRUCT_PERMITS>(
                BHXX_CONSTRUCT_PERMITS._.PROJECT_CODE == projectCode).ToList();//施工许可信息
            var jgys = Fw.CommonService.FromWhere<BHXX_COMPLETE_ACCEPT>(
                BHXX_COMPLETE_ACCEPT._.PROJECT_CODE == projectCode).ToList();//竣工验收信息
            var htxmzcy = Fw.CommonService.FromWhere<BHXX_CONTRACT_MEMBER>(
                BHXX_CONTRACT_MEMBER._.TENDER_PROJECT_CODE == tenderProjectCode).ToList();//合同项目组成员
            return new
            {
                TenderProject = tenderProject,
                ContractMember = htxmzcy,
                ConstructPermits = sgxk,
                CompleteAccept = jgys,
            };
        }
        #endregion

        #endregion

        #region 监督服务-标前标中标后监督-多平台综合查询

        /// <summary>
        /// 标前详情
        /// </summary>
        /// <param name="tenderProjectCode"></param>
        /// <returns></returns>
        public GeneralResult<BeforeDetailModel> BeforeDetail(string tenderProjectCode)
        {
            var r = new GeneralResult<BeforeDetailModel>();
            var detail = new BeforeDetailModel();
            var reportCode = Jd.TenderProjectService.FromWhere(TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1 == tenderProjectCode)
                 .InnerJoin<PROJECT>(PROJECT._.PROJECT_CODE == TENDER_PROJECT._.PROJECT_CODE)
                 .InnerJoin<T_AFC_PROJECT>(T_AFC_PROJECT._.CODE == PROJECT._.CONSTRUCTION_ID)
                 .Select(T_AFC_PROJECT._.CODE).ToScalar<string>();
            if (!string.IsNullOrWhiteSpace(reportCode))
            {
                detail = FixedDetail(reportCode) ?? SecondaryDetail(reportCode) ?? XmCodeDetail(reportCode);
            }
            if (detail != null)
            {
                detail.SetProjectEnterprise();
                r.SetSuccessT(detail);
            }
            else
            {
                r.SetFail("暂无数据");
            }

            return r;

        }
        /// <summary>
        /// 标后详情
        /// </summary>
        /// <param name="tenderProjectCode"></param>
        /// <returns></returns>
        public object AfterDetail(string tenderProjectCode)
        {
            //return AfterDetailMock(tenderProjectCode);
            var tenderProject =
                Fw.TenderProjectService.FromWhere(TENDER_PROJECT._.TENDER_PROJECT_CODE == tenderProjectCode)
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "10" && SYS_DIC._.VALUE == TENDER_PROJECT._.TENDER_PROJECT_TYPE)
                    .LeftJoin<CONTRACT_PERFORMANCE>(TENDER_PROJECT._.TENDER_PROJECT_CODE ==
                                                    CONTRACT_PERFORMANCE._.TENDER_PROJECT_CODE)
                    .Select(SYS_DIC._.TEXT.As("TENDER_PROJECT_TYPE_NAME"), TENDER_PROJECT._.All)
                    .ToFirst<dynamic>();//项目基本情况
           
            var projectCode = tenderProject.PROJECT_CODE;
            var sgxk = Fw.CommonService.FromWhere<BHXX_CONSTRUCT_PERMITS>(
                BHXX_CONSTRUCT_PERMITS._.PROJECT_CODE == projectCode).ToList();//施工许可信息
            var jgys = Fw.CommonService.FromWhere<BHXX_COMPLETE_ACCEPT>(
                BHXX_COMPLETE_ACCEPT._.PROJECT_CODE == projectCode).ToList();//竣工验收信息
            var htxmzcy = Fw.CommonService.FromWhere<BHXX_CONTRACT_MEMBER>(
                BHXX_CONTRACT_MEMBER._.TENDER_PROJECT_CODE == tenderProjectCode).OrderBy(BHXX_CONTRACT_MEMBER._.M_TM.Desc).ToList();//合同项目组成员

            var contracts =Fw.ContractPerformanceService.FindList(
                CONTRACT_PERFORMANCE._.TENDER_PROJECT_CODE == projectCode,
                CONTRACT_PERFORMANCE._.CONTRACT_SIGN_TIME.Desc);//合同

            var performances = Fw.PerformanceService.FindList(PERFORMANCE._.TENDER_PROJECT_CODE == projectCode, PERFORMANCE._.M_TM.Desc);

            return new
            {
                TenderProject = tenderProject,//项目基本情况
                ContractMember = htxmzcy,//合同项目组成员
                ConstructPermits = sgxk,//施工许可信息
                CompleteAccept = jgys,//竣工验收信息
                Contracts =contracts,//合同
                Performances =performances,//履约
            };
        }

        public object AfterDetailMock(string tenderProjectCode)
        {
            #region JSON

            var json = @" {""TenderProject"": {
    ""TENDER_PROJECT_TYPE_NAME"": ""水利水电"",
    ""PROJECT_CODE"": ""E3505050602100001"",
    ""TENDER_PROJECT_CODE"": ""E3505050602100001001"",
    ""UNIFIED_DEAL_CODE"": ""xxxxxxx"",
    ""TENDER_PROJECT_NAME"": ""2019-3-7xkw水利项目测试一"",
    ""TENDER_PROJECT_TYPE"": ""G07"",
    ""REGION_CODE"": ""350505"",
    ""TENDER_CONTENT"": ""111"",
    ""OWNER_NAME"": ""筑龙测试企业419"",
    ""TENDERER_NAME"": ""筑龙测试企业419"",
    ""TENDERER_CODE_TYPE"": ""2"",
    ""TENDERER_CODE"": ""576107994"",
    ""TENDERER_ROLE"": ""01"",
    ""TENDER_AGENCY_NAME"": ""xxxxxxx"",
    ""TENDER_AGENCY_CODE_TYPE"": ""2"",
    ""TENDER_AGENCY_CODE"": ""576107994"",
    ""TENDER_AGENCY_ROLE"": ""02"",
    ""TENDER_MODE"": ""1"",
    ""TENDER_ORGANIZE_FORM"": ""1"",
    ""CREATE_TIME"": ""2019-03-07 16:05:33"",
    ""SUPERVISE_DEPT_NAME"": ""11"",
    ""SUPERVISE_DEPT_CODE"": ""xxxxxxx"",
    ""APPROVE_DEPT_NAME"": ""11"",
    ""APPROVE_DEPT_CODE"": ""xxxxxxx"",
    ""PLATFORM_CODE"": ""911100001000003904"",
    ""PUB_SERVICE_PLAT_CODE"": ""123500004880012255"",
    ""DATA_TIMESTAMP"": ""2019-03-07 16:07:38"",
    ""M_KEY"": ""0602831201903070000245"",
    ""M_DATA_SOURCE"": ""0602"",
    ""M_TM"": ""2019-03-07 16:07:38"",
    ""M_CREATOR"": ""xxxxxxx"",
    ""M_ID"": 113813,
    ""M_ATT_PROJECT_REG"": ""xxxxxxx"",
    ""M_ATT_AGENT_COMMIT"": ""xxxxxxx"",
    ""M_ATT_OTHER_FILE"": ""xxxxxxx"",
    ""M_ATT_PROJECT_REG_APPROVE"": ""xxxxxxx"",
    ""M_ATT_TENDER_AGENT_CONTRACT"": ""xxxxxxx"",
    ""TENDER_PROJECT_CODE_OLD1"": ""xxxxxxx"",
    ""M_IS_HISTORY"": 0,
    ""M_CREATEBY"": ""xxxxxxx"",
    ""M_CREATE_TM"": ""2019-03-07 16:07:38"",
    ""TENDER_SELF_CODE"": ""xxxxxxx"",
    ""ISUNION"": ""0"",
    ""REPORT_DUTY"": ""1111"",
    ""M_ATT_COR_AUTHORITY_FILE"": ""xxxxxxx"",
    ""M_ATT_FUND_SOURCE_CERTIFY_FILE"": ""xxxxxxx"",
    ""OTHER_UPDATE_TIME"": ""2019-03-07 17:10:05"",
    ""IS_TO_LAW"": ""xxxxxxx"",
    ""TRADE_PLAT"": ""xxxxxxx"",
    ""PUB_SERVICE_PLAT"": ""xxxxxxx"",
    ""M_VERSION"": ""xxxxxxx"",
    ""TENDERER_REGION_CODE"": ""xxxxxxx"",
    ""TENDERER_PROPERTY"": ""xxxxxxx"",
    ""TENDER_AGENCY_REGION_CODE"": ""xxxxxxx"",
    ""TENDER_AGENCY_PROPERTY"": ""xxxxxxx"",
    ""OPERATION_NAME"": ""xxxxxxx"",
    ""TRADE_SYSTEM_NO"": ""xxxxxxx"",
    ""TRADE_SYSTEM_FEE"": ""xxxxxxx"",
    ""RN"": 1
  },
  ""ContractMember"": [
    {
      ""M_ID"": ""xxxxxxx"",
      ""M_KEY"": ""xxxxxxx"",
      ""M_DATA_SOURCE"": ""xxxxxxx"",
      ""M_TM"": ""xxxxxxx"",
      ""M_VERSION"": ""xxxxxxx"",
      ""TENDER_PROJECT_CODE"": ""xxxxxxx"",
      ""BID_SECTION_CODE"": ""xxxxxxx"",
      ""UNIFIED_DEAL_CODE"": ""xxxxxxx"",
      ""CONTRACT_CODE"": ""xxxxxxx"",
      ""NAME"": ""xxxxxxx"",
      ""PHONE"": ""xxxxxxx"",
      ""ID_CARD_NO"": ""xxxxxxx"",
      ""POSITION"": ""xxxxxxx"",
      ""TECHNICAL_POST"": ""xxxxxxx"",
      ""CERTIFICATE_NO"": ""xxxxxxx"",
      ""CERTIFICATE_TYPE"": ""xxxxxxx"",
      ""CERTIFICATE_FULL_NAME"": ""xxxxxxx"",
      ""CERTIFICATE_LEVLE"": ""xxxxxxx"",
      ""YEARS_OF_WORKING"": ""xxxxxxx"",
      ""CREDIT_SCORE"": ""xxxxxxx"",
      ""GRADUATE_SCHOOL"": ""xxxxxxx"",
      ""PLATFORM_CODE"": ""xxxxxxx"",
      ""PUB_SERVICE_PLAT_CODE"": ""xxxxxxx"",
      ""DATA_TIMESTAMP"": ""xxxxxxx"",
      ""TRADE_PLAT"": ""xxxxxxx"",
      ""PUB_SERVICE_PLAT"": ""xxxxxxx""
    }
  ],
  ""ConstructPermits"": [
    {
      ""M_ID"": ""xxxxxxx"",
      ""M_KEY"": ""xxxxxxx"",
      ""M_DATA_SOURCE"": ""xxxxxxx"",
      ""M_TM"": ""xxxxxxx"",
      ""M_VERSION"": ""xxxxxxx"",
      ""PROJECT_CODE"": ""xxxxxxx"",
      ""PROJECT_NAME"": ""xxxxxxx"",
      ""INVEST_PROJECT_CODE"": ""xxxxxxx"",
      ""BUILDER_LICENCE_NUM"": ""xxxxxxx"",
      ""BUILD_PLAN_NUM"": ""xxxxxxx"",
      ""PROJECT_PLAN_NUM"": ""xxxxxxx"",
      ""TENDER_NUM"": ""xxxxxxx"",
      ""CENSOR_NUM"": ""xxxxxxx"",
      ""BARGAIN_DAYS"": ""xxxxxxx"",
      ""CONTRACT_MONEY"": ""xxxxxxx"",
      ""AREA"": ""xxxxxxx"",
      ""LENGTH"": ""xxxxxxx"",
      ""SPAN"": ""xxxxxxx"",
      ""PROJECT_SIZE"": ""xxxxxxx"",
      ""RELEASE_DATE"": ""xxxxxxx"",
      ""TWO_DIM_CODE"": ""xxxxxxx"",
      ""CREATE_DATE"": ""xxxxxxx"",
      ""CHECK_DEPART_NAME"": ""xxxxxxx"",
      ""CHECK_PERSON_NAME"": ""xxxxxxx"",
      ""DATA_SOURCE"": ""xxxxxxx"",
      ""DATA_LEVEL"": ""xxxxxxx""
    }
  ],
  ""CompleteAccept"": [
    {
      ""M_ID"": ""xxxxxxx"",
      ""M_KEY"": ""xxxxxxx"",
      ""M_DATA_SOURCE"": ""xxxxxxx"",
      ""M_TM"": ""xxxxxxx"",
      ""M_VERSION"": ""xxxxxxx"",
      ""PROJECT_CODE"": ""xxxxxxx"",
      ""PROJECT_NAME"": ""xxxxxxx"",
      ""INVEST_PROJECT_CODE"": ""xxxxxxx"",
      ""PROJECT_FINISH_CHECK_NUM"": ""xxxxxxx"",
      ""BUILDER_LICENCE_NUM"": ""xxxxxxx"",
      ""FACT_COST"": ""xxxxxxx"",
      ""FACT_AREA"": ""xxxxxxx"",
      ""LENGTH"": ""xxxxxxx"",
      ""SPAN"": ""xxxxxxx"",
      ""FACT_SIZE"": ""xxxxxxx"",
      ""PROJECT_STRUCTURE_TYPE_NUM"": ""xxxxxxx"",
      ""BEGIN_DATE"": ""xxxxxxx"",
      ""END_DATE"": ""xxxxxxx"",
      ""REMARK"": ""xxxxxxx"",
      ""CREATE_DATE"": ""xxxxxxx"",
      ""CHECK_DEPART_NAME"": ""xxxxxxx"",
      ""CHECK_PERSON_NAME"": ""xxxxxxx"",
      ""DATA_SOURCE"": ""xxxxxxx"",
      ""DATA_LEVEL"": ""xxxxxxx""
    }
  ],
  ""Contracts"": [
    {
      ""BID_SECTION_CODE"": ""xxxxxxx"",
      ""UNIFIED_DEAL_CODE"": ""xxxxxxx"",
      ""TENDERER_NAME"": ""xxxxxxx"",
      ""TENDER_CODE"": ""xxxxxxx"",
      ""BIDDER_NAME"": ""xxxxxxx"",
      ""BIDDER_CODE"": ""xxxxxxx"",
      ""CONTRACT_PRICE"": ""xxxxxxx"",
      ""SETTLE_PRICE"": ""xxxxxxx"",
      ""PRICE_CURRENCY"": ""xxxxxxx"",
      ""PRICE_UNIT"": ""xxxxxxx"",
      ""CONTRACT_CONTENT"": ""xxxxxxx"",
      ""LIMITE_TIME"": ""xxxxxxx"",
      ""QUALITY_REQUIRE"": ""xxxxxxx"",
      ""PERFORM_CHANGE_CONTENT"": ""xxxxxxx"",
      ""FINISH_TIME"": ""xxxxxxx"",
      ""ACTUALLY_PERIOD"": ""xxxxxxx"",
      ""PERFORM_INFO"": ""xxxxxxx"",
      ""SUBMIT_TIME"": ""xxxxxxx"",
      ""CONTRACT_SIGN_TIME"": ""xxxxxxx"",
      ""PLATFORM_CODE"": ""xxxxxxx"",
      ""PUB_SERVICE_PLAT_CODE"": ""xxxxxxx"",
      ""DATA_TIMESTAMP"": ""xxxxxxx"",
      ""M_KEY"": ""xxxxxxx"",
      ""M_DATA_SOURCE"": ""xxxxxxx"",
      ""M_TM"": ""xxxxxxx"",
      ""CONTRACT_NAME"": ""xxxxxxx"",
      ""M_ID"": ""xxxxxxx"",
      ""M_CREATOR"": ""xxxxxxx"",
      ""M_IS_HISTORY"": ""xxxxxxx"",
      ""M_CREATEBY"": ""xxxxxxx"",
      ""M_CREATE_TM"": ""xxxxxxx"",
      ""M_MONEY_UPDATE"": ""xxxxxxx"",
      ""TENDER_PROJECT_CODE"": ""xxxxxxx"",
      ""PRICE_FORM_CODE"": ""xxxxxxx"",
      ""OTHER_CONTRACT_PRICE"": ""xxxxxxx"",
      ""TRADE_PLAT"": ""xxxxxxx"",
      ""PUB_SERVICE_PLAT"": ""xxxxxxx"",
      ""M_VERSION"": ""xxxxxxx"",
      ""CONTRACT_CODE"": ""xxxxxxx""
    }
  ],
  ""Performances"": [
    {
      ""M_ID"": ""xxxxxxx"",
      ""TENDER_PROJECT_CODE"": ""xxxxxxx"",
      ""BID_SECTION_CODE"": ""xxxxxxx"",
      ""UNIFIED_DEAL_CODE"": ""xxxxxxx"",
      ""PERFORMANCE_REPORT_NAME"": ""xxxxxxx"",
      ""TENDERER_NAME"": ""xxxxxxx"",
      ""TENDERER_CODE"": ""xxxxxxx"",
      ""PERFORMANCE_PARTY_NAME"": ""xxxxxxx"",
      ""PERFORMANCE_PARTY_CODE"": ""xxxxxxx"",
      ""SETTLE_PRICE"": ""xxxxxxx"",
      ""FINISH_TIME"": ""xxxxxxx"",
      ""CONTRACT_CHANGE_CONTENT"": ""xxxxxxx"",
      ""ACTUALLY_PERIOD"": ""xxxxxxx"",
      ""PERFORMANCE_CONTENT"": ""xxxxxxx"",
      ""REPORT_ISSUE_TIME"": ""xxxxxxx"",
      ""PLATFORM_CODE"": ""xxxxxxx"",
      ""PUB_SERVICE_PLAT_CODE"": ""xxxxxxx"",
      ""DATA_TIMESTAMP"": ""xxxxxxx"",
      ""TRADE_PLAT"": ""xxxxxxx"",
      ""PUB_SERVICE_PLAT"": ""xxxxxxx"",
      ""M_VERSION"": ""xxxxxxx"",
      ""M_KEY"": ""xxxxxxx"",
      ""M_DATA_SOURCE"": ""xxxxxxx"",
      ""M_TM"": ""xxxxxxx"",
      ""M_CREATOR"": ""xxxxxxx"",
      ""M_IS_HISTORY"": ""xxxxxxx"",
      ""M_CREATEBY"": ""xxxxxxx"",
      ""M_CREATE_TM"": ""xxxxxxx""
    }
  ]
}";


            #endregion
            var r= json.Replace("'", "\"");
            JObject.Parse(json);
            var obj = JsonConvert.DeserializeObject(r);
            return obj;
        }
        #endregion
    }
}