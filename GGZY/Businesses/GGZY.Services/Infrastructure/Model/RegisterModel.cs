using System;
using System.Collections.Generic;
using System.Linq;
using GGZY.Core.Cache;
using GGZY.Core.Models;
using GGZY.Services.Infrastructure.Helper;
using GGZYFW.DbEntity;

namespace GGZY.Services.Infrastructure.Model
{
    public class RegisterModel
    {
        /// <summary>
        /// 1 服务平台 个人用户
        /// </summary>
        public const string FW_PERSON = "1";
        /// <summary>
        /// 2 服务平台 投标单位注册(CA注册)
        /// </summary>
        public const string FW_COMPANY = "2";
        /// <summary>
        /// 3 服务平台 招标人/招标代理注册
        /// </summary>
        public const string FW_AGENCY = "3";
        /// <summary>
        /// 4 监督平台 注册
        /// </summary>
        public const string JD_MEMBER = "4";

        /// <summary>
        /// 注册账号类型
        /// 1 个人用户
        /// 2 投标单位注册(CA注册)
        /// 3 招标人/招标代理注册
        /// 4 监督平台注册
        /// </summary>
        public string RegisterType { get; set; }
        #region 监督平台注册数据

        /// <summary>
        /// 账号类型
        /// </summary>
        public List<string> AccountType { get; set; }
        /// <summary>
        /// 账号名称
        /// 企业名称  CA读取出来的: SGD_GET_CERT_SUBJECT_CN
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 电子邮箱
        /// </summary>
        public string Email { get; set; }
       
        /// <summary>
        /// 登录密码
        /// </summary>
        public string Pwd { get; set; }
        /// <summary>
        /// 确认密码
        /// </summary>
        public string ConfirmPwd { get; set; }
        /// <summary>
        /// 单位名称
        /// </summary>
        public string OrgName { get; set; }
        /// <summary>
        /// 单位性质
        /// </summary>
        public string OrgType { get; set; }
        /// <summary>
        /// 单位所在地
        /// </summary>
        public string Province { get; set; }
        /// <summary>
        /// 单位所在地
        /// </summary>

        public string City { get; set; }
        /// <summary>
        /// 单位所在地
        /// </summary>

        public string County { get; set; }
        /// <summary>
        /// 临时信用代码
        /// </summary>

        public bool TempCode { get; set; }
        /// <summary>
        /// 临时信用代码类型
        /// </summary>

        public string TempCodeType { get; set; }
        /// <summary>
        /// 个人身份证号码
        /// </summary>
        public string IdCardNo { get; set; }
        /// <summary>
        /// 统一信用代码证
        /// 企业代码  统一信用代码
        /// </summary>
        public string UnifiedCreditCode { get; set; }
        /// <summary>
        /// 统一信用代码证电子档
        /// </summary>
        public string UnifiedCreditCodeImg { get; set; }
        public List<UploadResData> UnifiedCreditCodeImg_ATTACHMENTS { get; set; }
        public List<UploadResData> OrgCodeImg_ATTACHMENTS { get; set; }
        /// <summary>
        /// 组织机构代码证
        /// SGD_EXT_ORGANIZATIONCODE 企业代码  统一信用代码 CA读取出来的
        /// </summary>
        public string OrgCode { get; set; }
        /// <summary>
        /// 组织机构代码证电子档
        /// </summary>
        public string OrgCodeImg { get; set; }
        /// <summary>
        /// 邮政编码
        /// </summary>
        public string PostalCode { get; set; }
        /// <summary>
        /// 单位地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>
        public string Contract { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string ContractPhone { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 短信验证码
        /// </summary>
        public string MobileValidateCode { get; set; }

        public string ImgCode { get; set; }
        #endregion

        public GeneralResult Validate()
        {
            var r = new GeneralResult();
            if (RegisterType != FW_AGENCY)
            {
                r = SmsModel.ValidateMobileCode(Mobile, MobileValidateCode, ImgCode,SmsModel.DEFAULT_KEY);
            }
            else
            {
                r.SetSuccess();
            }
            return r;
        }

        /// <summary>
        /// 监督平台注册账号信息
        /// </summary>
        /// <returns></returns>
        public GGZYJD.DbEntity.T_USER ToRegisterUser()
        {
            return new GGZYJD.DbEntity.T_USER
            {
                ID=0,
                USERNAME=UserName,
                PASSWORD=Pwd,
                EMAIL=Email,
                MANAGE_NAME=ManageName,
                TELPHONE=Mobile,
            };
        }

        /// <summary>
        /// 监督平台注册扩展信息
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public GGZYJD.DbEntity.T_USER_EXTEND ToUserExtend(decimal? uid)
        {
            return new GGZYJD.DbEntity.T_USER_EXTEND
            {

                ID = 0,
                U_ID=uid,
                DEP_NAME=OrgName,
                DEP_KIND = OrgType,
                UNIFIED_CREDIT_CODE=UnifiedCreditCode,
                ORGAN_CODE=OrgCode,
                PROV_CODE=Province,
                CITY_CODE=City,
                COUNTY_CODE=County,
                POSTAL_CODE=PostalCode,
                ADDRESS=Address,
                CONTACTS=Contract,
                CONTACTS_PHONE=ContractPhone,
                AIDS_UCC = UnifiedCreditCodeImg,
                AIDS_OC = OrgCodeImg,
                ACCOUNT_TYPE=string.Join(",", AccountType),
                IDCARD=IdCardNo,
            };
        }
        /// <summary>
        /// 无统一社会信用代码的单位或个人请勾选此处使用临时统一信用代码，并上传无统一信用代码证明或个人身份证复印件
        /// </summary>
        /// <returns></returns>
        public GeneralResult JianDuUserValidate()
        {
            var r=new GeneralResult();
            if (TempCode && TempCodeType == "G" && string.IsNullOrWhiteSpace(IdCardNo))
            {
                r.SetFail("身份证号码不能为空");
            }
            else if(string.IsNullOrWhiteSpace(OrgName))
            {
                r.SetFail("单位名称不能为空");
            }
            else if (string.IsNullOrWhiteSpace(OrgType))
            {
                r.SetFail("单位性质不能为空");
            }
            else if (string.IsNullOrWhiteSpace(UnifiedCreditCode))
            {
                r.SetFail("统一信用代码证不能为空");
            }
            else if (string.IsNullOrWhiteSpace(Province))
            {
                r.SetFail("省份不能为空");
            }
            else if (string.IsNullOrWhiteSpace(City))
            {
                r.SetFail("城市不能为空");
            }
            else if (string.IsNullOrWhiteSpace(PostalCode))
            {
                r.SetFail("邮政编码不能为空");
            }
            else if (string.IsNullOrWhiteSpace(Address))
            {
                r.SetFail("单位地址不能为空");
            }
            else if (string.IsNullOrWhiteSpace(ContractPhone))
            {
                r.SetFail("联系电话不能为空");
            }
            else if (string.IsNullOrWhiteSpace(Contract))
            {
                r.SetFail("联系人不能为空");
            }
            else if (UnifiedCreditCodeImg_ATTACHMENTS==null|| !UnifiedCreditCodeImg_ATTACHMENTS.Any())
            {
                r.SetFail("请上传统一信用代码证");
            }
            else if (OrgCodeImg_ATTACHMENTS == null|| !OrgCodeImg_ATTACHMENTS.Any())
            {
                r.SetFail("请上传组织机构代码证");
            }
            else
            {
                this.UnifiedCreditCodeImg = string.Join(",", UnifiedCreditCodeImg_ATTACHMENTS.Select(c => c.Id));
                this.OrgCodeImg = string.Join(",", OrgCodeImg_ATTACHMENTS.Select(c => c.Id));
                r.SetSuccess();
            }

            return r;
        }
        /// <summary>
        /// 昵称
        /// </summary>
        public string ManageName { get; set; }

        public string IdCardType { get; set; } = "01";//默认 居民身份证

        /// <summary>
        /// 公共资源服务-个人注册
        /// </summary>
        /// <returns></returns>
        public GGZYFW.DbEntity.T_USER ToPersonalUser()
        {
            //IdCardType
            //IdCardNo
            return new GGZYFW.DbEntity.T_USER
            {
                //ID = 0,
                USERNAME=this.UserName,
                PASSWORD=this.Pwd,
                EMAIL=this.Email,
                MANAGE_NAME=this.ManageName,
                ZP_PHONE=this.Mobile,
                
            };
        }

        public List<UploadResData> ZCZM_ATTACHMENTS { get; set; }
        public string ZCZM { get; set; }
        /// <summary>
        /// 公共资源服务-企业注册
        /// </summary>
        /// <returns></returns>
        public GGZYFW.DbEntity.T_USER ToCompanyUser()
        {//TODO 注册证明附件
            return new GGZYFW.DbEntity.T_USER
            {
                USERNAME = this.UserName,
                //PASSWORD = this.OrgCode,
                EMAIL = this.Email,
                MANAGE_NAME = this.Contract,
                ZP_PHONE = this.Mobile,
                ZP_UNIT = this.UserName,
                ID = 0,
                TYPE=2,
                IS_ENABLE = 1,
                ROLEIDS = ConfigHelper.AppSettings.COMPANY_ROLEID,//企业账号
                REG_TM = DateTime.Now,
                COMPANY_CODE=this.OrgCode
            };
        }

        public GGZYFW.DbEntity.LEGAL_PERSON_BASE ToLegalPersonBase(decimal? companyUserId)
        {
            return new LEGAL_PERSON_BASE
            {
                M_ID = 0,
                LEGAL_NAME = UserName,
                LEGAL_CODE = OrgCode,
                LEGAL_EMAIL = Email,
                M_USER_ID = companyUserId,
            };
        }

        public string Pid { get; set; }
        public string AREACODE { get; set; }
        /// <summary>
        /// 公共资源服务-代理注册
        /// </summary>
        /// <returns></returns>
        public GGZYFW.DbEntity.T_USER ToAgencyUser()
        {
            return new GGZYFW.DbEntity.T_USER
            {
                //ID = 0,
                USERNAME = $"{this.UserName}_DLJG",
                PASSWORD = this.Pwd,
                EMAIL = this.Email,
                MANAGE_NAME = this.ManageName,
                //ZP_PHONE = this.Mobile,
                ZP_UNIT = this.OrgName,
                //P_ID=Pid,
                AREACODE =this.AREACODE,//!string.IsNullOrWhiteSpace(this.Province)?this.Province:this.City
            };
        }
        /// <summary>
        /// 证明材料附件
        /// </summary>
        public string Files { get; set; }
        public GGZYFW.DbEntity.T_USER_QYZC ToCompanyRegisterUser()
        {
            return new GGZYFW.DbEntity.T_USER_QYZC
            {
                CODE_TYPE = "社会统一信用代码",
                CREATETIME = DateTime.Now,
                EMAIL = this.Email,
                LXR = this.Contract,
                QY_CODE = this.UnifiedCreditCode,
                STATUS = 0,
                TEL_PHONE=Mobile,
                UNAME=UserName,
                FILES = Files,
            };
        }





    }
}