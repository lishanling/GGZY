using System;
using Newtonsoft.Json;

namespace GGZY.Services.Infrastructure.Model.FuWu
{
    /// <summary>
    /// 服务平台用户信息+法人信息
    /// </summary>
    public class FwUserModel
    {
        #region T_USER
        private decimal? _ID;
        private string _USERNAME;
        private string _PASSWORD;
        private string _EMAIL;
        private decimal? _TYPE;
        private string _CA_CODE;
        private DateTime? _REG_TM;
        private string _API_CODE;
        private string _API_KEY;
        private string _ROLEIDS;
        private string _SESSION_ID;
        private decimal? _P_ID;
        private decimal? _GENDER;
        private decimal? _IS_ENABLE;
        private string _COMPANY_CODE;
        private string _MANAGE_NAME;
        private string _AREACODE;
        private string _ZP_FAX;
        private string _ZP_UNIT;
        private string _ZP_ADDRESS;
        private decimal? _ZP_ID;
        private string _ZP_PHONE;
        private string _CHECK_CODE;
        private decimal? _IS_CHECK_PHONE;
        private DateTime? _EFECTIVE_TIME;
        private decimal? _IS_AUDIT;
        private decimal? _AUDIT_BY;
        private DateTime? _AUDIT_TM;
        private string _AAAA;
        private string _CA_INFO;

        /// <summary>
        /// ID
        /// </summary>
        public decimal? ID
        {
            get { return _ID; }
            set
            {
                this._ID = value;
            }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string USERNAME
        {
            get { return _USERNAME; }
            set
            {
                this._USERNAME = value;
            }
        }
        /// <summary>
        /// 登录密码
        /// </summary>
        [JsonIgnore]
        public string PASSWORD
        {
            get { return _PASSWORD; }
            set
            {
                this._PASSWORD = value;
            }
        }
        /// <summary>
        /// Email
        /// </summary>
        public string EMAIL
        {
            get { return _EMAIL; }
            set
            {
                this._EMAIL = value;
            }
        }
        /// <summary>
        /// 账号类别 0:游客 1:个人用户 2:企业用户
        /// </summary>
        public decimal? TYPE
        {
            get { return _TYPE; }
            set
            {
                this._TYPE = value;
            }
        }
        /// <summary>
        /// CA编码
        /// </summary>
        public string CA_CODE
        {
            get { return _CA_CODE; }
            set
            {
                this._CA_CODE = value;
            }
        }
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime? REG_TM
        {
            get { return _REG_TM; }
            set
            {
                this._REG_TM = value;
            }
        }
        /// <summary>
        /// 交易平台编码
        /// </summary>
        public string API_CODE
        {
            get { return _API_CODE; }
            set
            {
                this._API_CODE = value;
            }
        }
        /// <summary>
        /// 交易平台密钥
        /// </summary>
        public string API_KEY
        {
            get { return _API_KEY; }
            set
            {
                this._API_KEY = value;
            }
        }
        /// <summary>
        /// 用户角色ID
        /// </summary>
        public string ROLEIDS
        {
            get { return _ROLEIDS; }
            set
            {
                this._ROLEIDS = value;
            }
        }
        /// <summary>
        /// 登陆后生成的一个guid用于判断登陆状态
        /// </summary>
        public string SESSION_ID
        {
            get { return _SESSION_ID; }
            set
            {
                this._SESSION_ID = value;
            }
        }
        /// <summary>
        /// 父账号ID
        /// </summary>
        public decimal? P_ID
        {
            get { return _P_ID; }
            set
            {
                this._P_ID = value;
            }
        }
        /// <summary>
        /// 性别 1：男，0：女
        /// </summary>
        public decimal? GENDER
        {
            get { return _GENDER; }
            set
            {
                this._GENDER = value;
            }
        }
        /// <summary>
        /// 是否启用注册完需要后台审核通过后才启用
        /// </summary>
        public decimal? IS_ENABLE
        {
            get { return _IS_ENABLE; }
            set
            {
                this._IS_ENABLE = value;
            }
        }
        /// <summary>
        /// 企业代码
        /// </summary>
        public string COMPANY_CODE
        {
            get { return _COMPANY_CODE; }
            set
            {
                this._COMPANY_CODE = value;
            }
        }
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string MANAGE_NAME
        {
            get { return _MANAGE_NAME; }
            set
            {
                this._MANAGE_NAME = value;
            }
        }
        /// <summary>
        /// 行政区划
        /// </summary>
        public string AREACODE
        {
            get { return _AREACODE; }
            set
            {
                this._AREACODE = value;
            }
        }
        /// <summary>
        /// 传真
        /// </summary>
        public string ZP_FAX
        {
            get { return _ZP_FAX; }
            set
            {
                this._ZP_FAX = value;
            }
        }
        /// <summary>
        /// 单位名称
        /// </summary>
        public string ZP_UNIT
        {
            get { return _ZP_UNIT; }
            set
            {
                this._ZP_UNIT = value;
            }
        }
        /// <summary>
        /// 单位地址
        /// </summary>
        public string ZP_ADDRESS
        {
            get { return _ZP_ADDRESS; }
            set
            {
                this._ZP_ADDRESS = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ZP_ID
        {
            get { return _ZP_ID; }
            set
            {
                this._ZP_ID = value;
            }
        }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string ZP_PHONE
        {
            get { return _ZP_PHONE; }
            set
            {
                this._ZP_PHONE = value;
            }
        }
        /// <summary>
        /// 验证码
        /// </summary>
        public string CHECK_CODE
        {
            get { return _CHECK_CODE; }
            set
            {
                this._CHECK_CODE = value;
            }
        }
        /// <summary>
        /// 是否通过手机验证
        /// </summary>
        public decimal? IS_CHECK_PHONE
        {
            get { return _IS_CHECK_PHONE; }
            set
            {
                this._IS_CHECK_PHONE = value;
            }
        }
        /// <summary>
        /// 验证码有效时间
        /// </summary>
        public DateTime? EFECTIVE_TIME
        {
            get { return _EFECTIVE_TIME; }
            set
            {
                this._EFECTIVE_TIME = value;
            }
        }
        /// <summary>
        /// 是否审核
        /// </summary>
        public decimal? IS_AUDIT
        {
            get { return _IS_AUDIT; }
            set
            {
                this._IS_AUDIT = value;
            }
        }
        /// <summary>
        /// 审核人
        /// </summary>
        public decimal? AUDIT_BY
        {
            get { return _AUDIT_BY; }
            set
            {
                this._AUDIT_BY = value;
            }
        }
        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime? AUDIT_TM
        {
            get { return _AUDIT_TM; }
            set
            {
                this._AUDIT_TM = value;
            }
        }
        ///// <summary>
        ///// 
        ///// </summary>
        [JsonIgnore]
        public string AAAA
        {
            get { return _AAAA; }
            set
            {
                this._AAAA = value;
            }
        }
        /// <summary>
        /// 用CA登陆的CA信息
        /// </summary>
        public string CA_INFO
        {
            get { return _CA_INFO; }
            set
            {
                this._CA_INFO = value;
            }
        }
        #endregion

        #region LEGAL_PERSON_BASE
        private string _LEGAL_NAME;
        private string _BIDDER_CODE_TYPE;
        private string _LEGAL_CODE;
        private string _LEGAL_ROLE;
        private string _LICENSE_NO;
        private DateTime? _LICENSE_END_DATE;
        private string _TAX_CERT_NO;
        private DateTime? _TAX_CERT_END_DATE;
        private string _LOCAL_TAX_CERT_NO;
        private DateTime? _LOCAL_TAX_CERT_END_DATE;
        private string _ORGAN_NO;
        private DateTime? _ORGAN_CERT_END_DATE;
        private string _LEGAL_REPRESENT;
        private string _LEGAL_TYPE;
        private string _REPRESENT_PHONE;
        private string _LEGAL_INDUSTRY;
        private string _CREDIT_RATE;
        private string _COUNTRY_REGION;
        private string _LEGAL_UNIT_ADDRESS;
        private string _REGION_CODE;
        private string _REGISTER_PROVINCE;
        private string _REGISTER_CITY;
        private string _BASIC_BANK;
        private string _BASIC_BRANCH_BANK;
        private string _BASIC_ACCOUNT_NO;
        private string _BASIC_ACCOUNT_NAME;
        private decimal? _REG_CAPITAL;
        private string _REG_CAP_CURRENCY;
        private string _REG_UNIT;
        private string _LEGAL_CONTACT;
        private string _LEGAL_CONTACT_PHONE;
        private string _LEGAL_CONTACT_ADDRESS;
        private string _LEGAL_WEB;
        private string _LEGAL_ZIP_CODE;
        private string _LEGAL_EMAIL;
        private string _LEGAL_STATUS;
        private string _PLATFORM_CODE;
        private string _PUB_SERVICE_PLAT_CODE;
        private DateTime? _DATA_TIMESTAMP;
        private string _M_KEY;
        private string _M_DATA_SOURCE;
        private DateTime? _M_TM;
        private decimal? _M_ID;
        private decimal? _M_USER_ID;
        private string _M_ATT_LICENSE_CERT_DOC;
        private string _M_ATT_ORGAN_CERT_DOC;
        private string _M_ATT_TAX_CERT_DOC;
        private string _M_ATT_BASE_ACCOUNT_DOC;
        private string _M_ATT_QUAL_CART_DOC;
        private decimal? _M_IS_HISTORY;
        private decimal? _M_CREATEBY;
        private DateTime? _M_CREATE_TM;
        private string _M_VERSION;

        /// <summary>
        /// 法人名称
        /// </summary>
        public string LEGAL_NAME
        {
            get { return _LEGAL_NAME; }
            set
            {
                this._LEGAL_NAME = value;
            }
        }
        /// <summary>
        /// 法人类别
        /// </summary>
        public string BIDDER_CODE_TYPE
        {
            get { return _BIDDER_CODE_TYPE; }
            set
            {
                this._BIDDER_CODE_TYPE = value;
            }
        }
        /// <summary>
        /// 法人代码
        /// </summary>
        public string LEGAL_CODE
        {
            get { return _LEGAL_CODE; }
            set
            {
                this._LEGAL_CODE = value;
            }
        }
        /// <summary>
        /// 法人角色
        /// </summary>
        public string LEGAL_ROLE
        {
            get { return _LEGAL_ROLE; }
            set
            {
                this._LEGAL_ROLE = value;
            }
        }
        /// <summary>
        /// 营业执照号码
        /// </summary>
        public string LICENSE_NO
        {
            get { return _LICENSE_NO; }
            set
            {
                this._LICENSE_NO = value;
            }
        }
        /// <summary>
        /// 营业执照失效日期
        /// </summary>
        public DateTime? LICENSE_END_DATE
        {
            get { return _LICENSE_END_DATE; }
            set
            {
                this._LICENSE_END_DATE = value;
            }
        }
        /// <summary>
        /// 国税税务登记证证号
        /// </summary>
        public string TAX_CERT_NO
        {
            get { return _TAX_CERT_NO; }
            set
            {
                this._TAX_CERT_NO = value;
            }
        }
        /// <summary>
        /// 国税税务登记证失效日期
        /// </summary>
        public DateTime? TAX_CERT_END_DATE
        {
            get { return _TAX_CERT_END_DATE; }
            set
            {
                this._TAX_CERT_END_DATE = value;
            }
        }
        /// <summary>
        /// 地税税务登记证证号
        /// </summary>
        public string LOCAL_TAX_CERT_NO
        {
            get { return _LOCAL_TAX_CERT_NO; }
            set
            {
                this._LOCAL_TAX_CERT_NO = value;
            }
        }
        /// <summary>
        /// 地税税务登记证失效日期
        /// </summary>
        public DateTime? LOCAL_TAX_CERT_END_DATE
        {
            get { return _LOCAL_TAX_CERT_END_DATE; }
            set
            {
                this._LOCAL_TAX_CERT_END_DATE = value;
            }
        }
        /// <summary>
        /// 组织机构代码
        /// </summary>
        public string ORGAN_NO
        {
            get { return _ORGAN_NO; }
            set
            {
                this._ORGAN_NO = value;
            }
        }
        /// <summary>
        /// 组织机构代码证失效日期
        /// </summary>
        public DateTime? ORGAN_CERT_END_DATE
        {
            get { return _ORGAN_CERT_END_DATE; }
            set
            {
                this._ORGAN_CERT_END_DATE = value;
            }
        }
        /// <summary>
        /// 法定代表人姓名
        /// </summary>
        public string LEGAL_REPRESENT
        {
            get { return _LEGAL_REPRESENT; }
            set
            {
                this._LEGAL_REPRESENT = value;
            }
        }
        /// <summary>
        /// 法人机构类别
        /// </summary>
        public string LEGAL_TYPE
        {
            get { return _LEGAL_TYPE; }
            set
            {
                this._LEGAL_TYPE = value;
            }
        }
        /// <summary>
        /// 法人代表联系电话
        /// </summary>
        public string REPRESENT_PHONE
        {
            get { return _REPRESENT_PHONE; }
            set
            {
                this._REPRESENT_PHONE = value;
            }
        }
        /// <summary>
        /// 法人机构行业代码
        /// </summary>
        public string LEGAL_INDUSTRY
        {
            get { return _LEGAL_INDUSTRY; }
            set
            {
                this._LEGAL_INDUSTRY = value;
            }
        }
        /// <summary>
        /// 资信等级
        /// </summary>
        public string CREDIT_RATE
        {
            get { return _CREDIT_RATE; }
            set
            {
                this._CREDIT_RATE = value;
            }
        }
        /// <summary>
        /// 国别/地区
        /// </summary>
        public string COUNTRY_REGION
        {
            get { return _COUNTRY_REGION; }
            set
            {
                this._COUNTRY_REGION = value;
            }
        }
        /// <summary>
        /// 法人机构地址
        /// </summary>
        public string LEGAL_UNIT_ADDRESS
        {
            get { return _LEGAL_UNIT_ADDRESS; }
            set
            {
                this._LEGAL_UNIT_ADDRESS = value;
            }
        }
        /// <summary>
        /// 行政区域代码
        /// </summary>
        public string REGION_CODE
        {
            get { return _REGION_CODE; }
            set
            {
                this._REGION_CODE = value;
            }
        }
        /// <summary>
        /// 注册地-省
        /// </summary>
        public string REGISTER_PROVINCE
        {
            get { return _REGISTER_PROVINCE; }
            set
            {
                this._REGISTER_PROVINCE = value;
            }
        }
        /// <summary>
        /// 注册地-市
        /// </summary>
        public string REGISTER_CITY
        {
            get { return _REGISTER_CITY; }
            set
            {
                this._REGISTER_CITY = value;
            }
        }
        /// <summary>
        /// 基本户开户银行
        /// </summary>
        public string BASIC_BANK
        {
            get { return _BASIC_BANK; }
            set
            {
                this._BASIC_BANK = value;
            }
        }
        /// <summary>
        /// 基本户开户支行号
        /// </summary>
        public string BASIC_BRANCH_BANK
        {
            get { return _BASIC_BRANCH_BANK; }
            set
            {
                this._BASIC_BRANCH_BANK = value;
            }
        }
        /// <summary>
        /// 基本户账号
        /// </summary>
        public string BASIC_ACCOUNT_NO
        {
            get { return _BASIC_ACCOUNT_NO; }
            set
            {
                this._BASIC_ACCOUNT_NO = value;
            }
        }
        /// <summary>
        /// 基本户账户名称
        /// </summary>
        public string BASIC_ACCOUNT_NAME
        {
            get { return _BASIC_ACCOUNT_NAME; }
            set
            {
                this._BASIC_ACCOUNT_NAME = value;
            }
        }
        /// <summary>
        /// 注册资本
        /// </summary>
        public decimal? REG_CAPITAL
        {
            get { return _REG_CAPITAL; }
            set
            {
                this._REG_CAPITAL = value;
            }
        }
        /// <summary>
        /// 注册资本币种
        /// </summary>
        public string REG_CAP_CURRENCY
        {
            get { return _REG_CAP_CURRENCY; }
            set
            {
                this._REG_CAP_CURRENCY = value;
            }
        }
        /// <summary>
        /// 注册资本单位
        /// </summary>
        public string REG_UNIT
        {
            get { return _REG_UNIT; }
            set
            {
                this._REG_UNIT = value;
            }
        }
        /// <summary>
        /// 联系人
        /// </summary>
        public string LEGAL_CONTACT
        {
            get { return _LEGAL_CONTACT; }
            set
            {
                this._LEGAL_CONTACT = value;
            }
        }
        /// <summary>
        /// 联系人电话
        /// </summary>
        public string LEGAL_CONTACT_PHONE
        {
            get { return _LEGAL_CONTACT_PHONE; }
            set
            {
                this._LEGAL_CONTACT_PHONE = value;
            }
        }
        /// <summary>
        /// 联系人地址
        /// </summary>
        public string LEGAL_CONTACT_ADDRESS
        {
            get { return _LEGAL_CONTACT_ADDRESS; }
            set
            {
                this._LEGAL_CONTACT_ADDRESS = value;
            }
        }
        /// <summary>
        /// 单位网站
        /// </summary>
        public string LEGAL_WEB
        {
            get { return _LEGAL_WEB; }
            set
            {
                this._LEGAL_WEB = value;
            }
        }
        /// <summary>
        /// 邮政编码
        /// </summary>
        public string LEGAL_ZIP_CODE
        {
            get { return _LEGAL_ZIP_CODE; }
            set
            {
                this._LEGAL_ZIP_CODE = value;
            }
        }
        /// <summary>
        /// 电子邮箱
        /// </summary>
        public string LEGAL_EMAIL
        {
            get { return _LEGAL_EMAIL; }
            set
            {
                this._LEGAL_EMAIL = value;
            }
        }
        /// <summary>
        /// 法人业务状态
        /// </summary>
        public string LEGAL_STATUS
        {
            get { return _LEGAL_STATUS; }
            set
            {
                this._LEGAL_STATUS = value;
            }
        }
        /// <summary>
        /// 交易系统标识码
        /// </summary>
        public string PLATFORM_CODE
        {
            get { return _PLATFORM_CODE; }
            set
            {
                this._PLATFORM_CODE = value;
            }
        }
        /// <summary>
        /// 公共服务平台标识码
        /// </summary>
        public string PUB_SERVICE_PLAT_CODE
        {
            get { return _PUB_SERVICE_PLAT_CODE; }
            set
            {
                this._PUB_SERVICE_PLAT_CODE = value;
            }
        }
        /// <summary>
        /// 数据时间戳
        /// </summary>
        public DateTime? DATA_TIMESTAMP
        {
            get { return _DATA_TIMESTAMP; }
            set
            {
                this._DATA_TIMESTAMP = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string M_KEY
        {
            get { return _M_KEY; }
            set
            {
                this._M_KEY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string M_DATA_SOURCE
        {
            get { return _M_DATA_SOURCE; }
            set
            {
                this._M_DATA_SOURCE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? M_TM
        {
            get { return _M_TM; }
            set
            {
                this._M_TM = value;
            }
        }
        /// <summary>
        /// 主键ID 自增
        /// </summary>
        public decimal? M_ID
        {
            get { return _M_ID; }
            set
            {
                this._M_ID = value;
            }
        }
        /// <summary>
        /// 用户关联ID
        /// </summary>
        public decimal? M_USER_ID
        {
            get { return _M_USER_ID; }
            set
            {
                this._M_USER_ID = value;
            }
        }
        /// <summary>
        /// 营业执照副本扫描件
        /// </summary>
        public string M_ATT_LICENSE_CERT_DOC
        {
            get { return _M_ATT_LICENSE_CERT_DOC; }
            set
            {
                this._M_ATT_LICENSE_CERT_DOC = value;
            }
        }
        /// <summary>
        /// 组织机构代码证扫描件
        /// </summary>
        public string M_ATT_ORGAN_CERT_DOC
        {
            get { return _M_ATT_ORGAN_CERT_DOC; }
            set
            {
                this._M_ATT_ORGAN_CERT_DOC = value;
            }
        }
        /// <summary>
        /// 税务登记证（国税和地税）扫描件
        /// </summary>
        public string M_ATT_TAX_CERT_DOC
        {
            get { return _M_ATT_TAX_CERT_DOC; }
            set
            {
                this._M_ATT_TAX_CERT_DOC = value;
            }
        }
        /// <summary>
        /// 基本户开户许可证扫描件
        /// </summary>
        public string M_ATT_BASE_ACCOUNT_DOC
        {
            get { return _M_ATT_BASE_ACCOUNT_DOC; }
            set
            {
                this._M_ATT_BASE_ACCOUNT_DOC = value;
            }
        }
        /// <summary>
        /// 资质证书副本扫描件
        /// </summary>
        public string M_ATT_QUAL_CART_DOC
        {
            get { return _M_ATT_QUAL_CART_DOC; }
            set
            {
                this._M_ATT_QUAL_CART_DOC = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? M_IS_HISTORY
        {
            get { return _M_IS_HISTORY; }
            set
            {
                this._M_IS_HISTORY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? M_CREATEBY
        {
            get { return _M_CREATEBY; }
            set
            {
                this._M_CREATEBY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? M_CREATE_TM
        {
            get { return _M_CREATE_TM; }
            set
            {
                this._M_CREATE_TM = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string M_VERSION
        {
            get { return _M_VERSION; }
            set
            {
                this._M_VERSION = value;
            }
        }
        #endregion
    }
}