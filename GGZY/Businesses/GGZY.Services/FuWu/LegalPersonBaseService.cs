using System;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Infrastructure.Model;
using GGZY.Services.Infrastructure.Model.FuWu;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class LegalPersonBaseService
    {
        /// <summary>
        /// 查找已经绑定了企业用户信息的法人信息
        /// </summary>
        /// <param name="legalCode">企业代码  统一信用代码 CA读取出来的</param>
        /// <returns></returns>
        public LEGAL_PERSON_BASE LegalPersonBound(string legalCode)
        {

            var legalPerson = FirstOrNull(LEGAL_PERSON_BASE._.LEGAL_CODE == legalCode &&
                                           LEGAL_PERSON_BASE._.M_USER_ID.IsNotNull() &&
                                           LEGAL_PERSON_BASE._.M_USER_ID != 0);
            return legalPerson;
        }
        /// <summary>
        /// 查找法人信息
        /// </summary>
        /// <param name="legalCode">企业代码  统一信用代码 CA读取出来的 或者 统一信用代码</param>
        /// <returns></returns>
        public LEGAL_PERSON_BASE LegalPerson(string legalCode)
        {

            var legalPerson = FirstOrNull(LEGAL_PERSON_BASE._.LEGAL_CODE == legalCode);
            return legalPerson;
        }
        /// <summary>
        /// 查找绑定企业用户到法人信息
        /// </summary>
        /// <param name="user">企业用户</param>
        /// <param name="legalCode">企业代码  统一信用代码 CA读取出来的</param>
        /// <returns></returns>
        public GeneralResult BindCompanyUser(T_USER user, string legalCode)
        {
            var r = new GeneralResult();
            var legalPerson = LegalPersonBound(legalCode);
            if (legalPerson != null)
            {
                r.SetFail($"该企业已注册过了。");
            }
            else
            {
                legalPerson = LegalPerson(legalCode);
                if (legalPerson == null)
                {
                    legalPerson = new LEGAL_PERSON_BASE
                    {
                        LEGAL_NAME = user.USERNAME,
                        LEGAL_CODE = legalCode,
                        LEGAL_EMAIL = user.EMAIL,
                        M_USER_ID = user.ID,
                    };
                    Insert(legalPerson);
                    r.SetSuccess();
                }
                else if (legalPerson.M_USER_ID == 0)
                {
                    legalPerson.Attach();
                    legalPerson.LEGAL_NAME = user.USERNAME;
                    legalPerson.LEGAL_EMAIL = user.EMAIL;
                    legalPerson.M_USER_ID = user.ID;
                    Update(legalPerson);
                    r.SetSuccess();
                }
                else
                {
                    r.SetFail($"企业注册失败！法人代码{legalCode}已经注册过。");
                }
            }
            return r;
        }

        /// <summary>
        /// 查找已经绑定了企业用户信息的法人信息
        /// </summary>
        /// <param name="legalCode">组织机构代码证</param>
        /// <param name="legalName">企业名称</param>
        /// <returns></returns>
        public LEGAL_PERSON_BASE LegalPerson(string legalCode, string legalName)
        {
           
            var legalPerson = FirstOrNull(LEGAL_PERSON_BASE._.M_USER_ID.IsNotNull() 
                                          &&(LEGAL_PERSON_BASE._.LEGAL_CODE == legalCode || LEGAL_PERSON_BASE._.LEGAL_CODE == legalName || LEGAL_PERSON_BASE._.LEGAL_NAME == legalName)
                                          && LEGAL_PERSON_BASE._.M_USER_ID != 0);
            return legalPerson;

        }
        /// <summary>
        /// 添加法人信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult AddLegalPerson(RegisterModel model)
        {
            var r = new GeneralResult();
            var legalPerson = LegalPersonBound(model.UnifiedCreditCode);
            if (legalPerson != null)
            {
                r.SetFail($"企业注册失败！法人代码{model.UnifiedCreditCode}已经注册过。");
            }
            else
            {
                legalPerson = LegalPerson(model.UnifiedCreditCode);
                if (legalPerson == null)
                {
                    legalPerson = new LEGAL_PERSON_BASE
                    {
                        LEGAL_NAME = model.UserName,
                        LEGAL_CODE = model.UnifiedCreditCode,
                        LEGAL_EMAIL = model.Email,
                    };
                    Insert(legalPerson);
                }
                else
                {
                    legalPerson.Attach();
                    legalPerson.LEGAL_NAME = model.UserName;
                    legalPerson.LEGAL_EMAIL = model.Email;
                    Update(legalPerson);
                }
                r.SetSuccess();
            }
            return r;
        }

        /// <summary>
        /// 全文检索-法人信息
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public object LegalPersonKeywordSearch(SearchCondition search)
        {
            var condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(search.KeyWord))
            {
                condition.And(LEGAL_PERSON_BASE._.LEGAL_NAME.Contain(search.KeyWord));
            }

            if (search.BeginTime.HasValue && search.EndTime.HasValue)
            {
                condition.And(LEGAL_PERSON_BASE._.M_IS_HISTORY == 0);
            }
            var count = Count(condition);
            var pageList = FromWhere(condition.ToWhereClip())
                .Page(search.PageSize,search.PageNo)
                .Select(
                    LEGAL_PERSON_BASE._.M_ID.As("Id"),
                    LEGAL_PERSON_BASE._.LEGAL_NAME.As("Title"),
                    LEGAL_PERSON_BASE._.DATA_TIMESTAMP.As("Tm"),
                    new Field("'LEGALPERSON'").As("Kind")
                ).OrderBy(LEGAL_PERSON_BASE._.DATA_TIMESTAMP.Desc).ToList<PortalSearchModel>()
                .ToPageTableResult(search, count);
            //var pageList = PageList(condition, search, LEGAL_PERSON_BASE._.DATA_TIMESTAMP.Desc)
            //    .Select(c => new {Id = c.M_ID, Title = c.LEGAL_NAME, Tm = c.DATA_TIMESTAMP, Kind = "LEGALPERSON"})
            //    .ToDataTable(search, count);
            return pageList;
        }

        /// <summary>
        /// 主体资信内容页面：获取基本信息表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="roleType"></param>
        /// <returns></returns>
        public LEGAL_PERSON_BASE LegalPersonBaseInfo(string id, string roleType = "01")
        {
            var entity = FromWhere(LEGAL_PERSON_BASE._.M_ID == id)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "2001" && SYS_DIC._.VALUE == LEGAL_PERSON_BASE._.BIDDER_CODE_TYPE)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "26" && SYS_DIC._.VALUE == LEGAL_PERSON_BASE._.LEGAL_ROLE)//roleType
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "25" && SYS_DIC._.VALUE == LEGAL_PERSON_BASE._.LEGAL_TYPE)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "4" && SYS_DIC._.VALUE == LEGAL_PERSON_BASE._.REG_CAP_CURRENCY)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "18" && SYS_DIC._.VALUE == LEGAL_PERSON_BASE._.REG_UNIT)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "1101" && SYS_DIC._.VALUE == LEGAL_PERSON_BASE._.LEGAL_STATUS)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "9016" && SYS_DIC._.VALUE == LEGAL_PERSON_BASE._.COUNTRY_REGION)
                .Select(
                    LEGAL_PERSON_BASE._.LEGAL_NAME,
                    SYS_DIC._.TEXT.As("BIDDER_CODE_TYPE"),
                    new Field("TEXT", "SYS_DIC2").As("LEGAL_ROLE"),
                    new Field("TEXT", "SYS_DIC3").As("LEGAL_TYPE"),
                    new Field("TEXT", "SYS_DIC4").As("REG_CAP_CURRENCY"),
                    new Field("TEXT", "SYS_DIC5").As("REG_UNIT"),
                    new Field("TEXT", "SYS_DIC6").As("LEGAL_STATUS"),
                    new Field("TEXT", "SYS_DIC7").As("COUNTRY_REGION"),
                    LEGAL_PERSON_BASE._.LEGAL_CODE,
                    LEGAL_PERSON_BASE._.ORGAN_CERT_END_DATE,
                    LEGAL_PERSON_BASE._.LICENSE_NO,
                    LEGAL_PERSON_BASE._.LICENSE_END_DATE,
                    LEGAL_PERSON_BASE._.TAX_CERT_NO,
                    LEGAL_PERSON_BASE._.TAX_CERT_END_DATE,
                    LEGAL_PERSON_BASE._.LOCAL_TAX_CERT_NO,
                    LEGAL_PERSON_BASE._.LOCAL_TAX_CERT_END_DATE,
                    LEGAL_PERSON_BASE._.LEGAL_REPRESENT,
                    LEGAL_PERSON_BASE._.LEGAL_INDUSTRY,
                    LEGAL_PERSON_BASE._.CREDIT_RATE,
                    LEGAL_PERSON_BASE._.LEGAL_ZIP_CODE,
                    LEGAL_PERSON_BASE._.LEGAL_CONTACT,
                    LEGAL_PERSON_BASE._.LEGAL_CONTACT_PHONE,
                    LEGAL_PERSON_BASE._.LEGAL_CONTACT_ADDRESS,
                    LEGAL_PERSON_BASE._.LEGAL_EMAIL,
                    LEGAL_PERSON_BASE._.LEGAL_REPRESENT,
                    new Field("case when LEGAL_WEB is not null then '<a href=''http://'||LEGAL_WEB||''' target=''_blank''>'||LEGAL_WEB||'</a>' end").As("LEGAL_WEB")
                ).ToFirst();
            return entity;
        }

        /// <summary>
        /// 交易诚信 主体资信列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public object CreditPageList(LEGAL_PERSON_BASE model, SearchCondition search)
        {
            var clip = CreditPageListConditionBuilder(model, search).ToWhereClip();
            var count = CreditCount(model, search);
            var pageList = FromWhere(clip && LEGAL_PERSON_BASE._.M_ID
                                         .SubQueryIn(
                                             FromWhere(LEGAL_PERSON_BASE._.LEGAL_CODE.Len() > 9)
                                                 .Select(LEGAL_PERSON_BASE._.M_ID.Max())
                                                 .GroupBy(LEGAL_PERSON_BASE._.LEGAL_CODE)
                                                 )
                ).Page(search.PageSize, search.PageNo)
                .Select(
                    LEGAL_PERSON_BASE._.M_ID.As("ID"),
                    LEGAL_PERSON_BASE._.LEGAL_CODE.As("ORGANNO"),
                    LEGAL_PERSON_BASE._.LEGAL_NAME.As("LEGALNAME"),
                    LEGAL_PERSON_BASE._.LEGAL_CONTACT.As("LEGALCONTACT"),
                    new Field($"'{model.LEGAL_ROLE}'").As("RoleType")
                        )
                .OrderBy(LEGAL_PERSON_BASE._.ORGAN_NO).ToList<object>()
                .ToPageTableResult(search, count);
            return pageList;

        }

        public int CreditCount(LEGAL_PERSON_BASE model, SearchCondition search)
        {
            var clip = CreditPageListConditionBuilder(model, search).ToWhereClip();
            var count = FromWhere(clip && LEGAL_PERSON_BASE._.M_ID
                                      .SubQueryIn(
                                          FromWhere(LEGAL_PERSON_BASE._.LEGAL_CODE.Len() > 9)
                                              .Select(LEGAL_PERSON_BASE._.M_ID.Max())
                                              .GroupBy(LEGAL_PERSON_BASE._.LEGAL_CODE)
                                      )
            ).Count();
            return count;
        }
        protected WhereClipBuilder CreditPageListConditionBuilder(LEGAL_PERSON_BASE model, SearchCondition search)
        {
            var c = new WhereClipBuilder(LEGAL_PERSON_BASE._.LEGAL_ROLE.Contain(model.LEGAL_ROLE));
            if (!string.IsNullOrWhiteSpace(search.KeyWord))
            {
                c.And(LEGAL_PERSON_BASE._.LEGAL_CODE.Contain(search.KeyWord) || LEGAL_PERSON_BASE._.LEGAL_NAME.Contain(search.KeyWord));
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(model.LEGAL_CODE))
                {
                    c.And(LEGAL_PERSON_BASE._.LEGAL_CODE.Contain(model.LEGAL_CODE));
                }
                if (!string.IsNullOrWhiteSpace(model.LEGAL_NAME))
                {
                    c.And(LEGAL_PERSON_BASE._.LEGAL_NAME.Contain(model.LEGAL_NAME));
                }
            }

            return c;
        }
        /// <summary>
        /// 通过用户信息查找法人信息
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public LEGAL_PERSON_BASE LegalPersonByUid(decimal? uid)
        {
            return FirstOrNull(LEGAL_PERSON_BASE._.M_USER_ID == uid);
        }
        /// <summary>
        /// 公共服务平台 主体信息列表(用于弹框选择)
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult PageTable(LEGAL_PERSON_BASE model, SearchCondition search)
        {
            var r = new GeneralResult();
            var condition = new WhereClipBuilder();

            if (!String.IsNullOrWhiteSpace(model.LEGAL_CODE))
            {
                condition.And(LEGAL_PERSON_BASE._.LEGAL_CODE == model.LEGAL_CODE);
            }
            if (!String.IsNullOrWhiteSpace(model.LEGAL_NAME))
            {
                condition.And(LEGAL_PERSON_BASE._.LEGAL_NAME.Contain(model.LEGAL_NAME));
            }

            var count = Count<LEGAL_PERSON_BASE>(condition.ToWhereClip());

            var datas = FromWhere<LEGAL_PERSON_BASE>()
                .InnerJoin<SYS_AREA_QUANGUO>(LEGAL_PERSON_BASE._.REGION_CODE == SYS_AREA_QUANGUO._.AREACODE)
                .Where(condition.ToWhereClip())
                .Page(search.PageSize, search.PageNo)
                .Select(
                LEGAL_PERSON_BASE._.LEGAL_NAME,
                LEGAL_PERSON_BASE._.LEGAL_CODE,
                SYS_AREA_QUANGUO._.AREANAME,
                SYS_AREA_QUANGUO._.AREACODE
                )
                .ToList<dynamic>();

            return new PageTableResult
            {
                PageNo = search.PageNo,
                PageSize = search.PageSize,
                Total = count,
                Table = datas
            };
        }
    }
}