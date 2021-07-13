using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ZJ_LEGAL_PERSON_BASE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJ_LEGAL_PERSON_BASE")]
    [Serializable]
    public partial class ZJ_LEGAL_PERSON_BASE : FwEntity
    {
        #region Model
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
		private string _M_DATA_SOURCE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _VERSION;
		private decimal? _M_ID;

		/// <summary>
		/// 法人名称
		/// </summary>
		public string LEGAL_NAME
		{
			get{ return _LEGAL_NAME; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_NAME, _LEGAL_NAME, value);
				this._LEGAL_NAME = value;
			}
		}
		/// <summary>
		/// 法人类别
		/// </summary>
		public string BIDDER_CODE_TYPE
		{
			get{ return _BIDDER_CODE_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_CODE_TYPE, _BIDDER_CODE_TYPE, value);
				this._BIDDER_CODE_TYPE = value;
			}
		}
		/// <summary>
		/// 法人代码
		/// </summary>
		public string LEGAL_CODE
		{
			get{ return _LEGAL_CODE; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_CODE, _LEGAL_CODE, value);
				this._LEGAL_CODE = value;
			}
		}
		/// <summary>
		/// 法人角色
		/// </summary>
		public string LEGAL_ROLE
		{
			get{ return _LEGAL_ROLE; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_ROLE, _LEGAL_ROLE, value);
				this._LEGAL_ROLE = value;
			}
		}
		/// <summary>
		/// 营业执照号码
		/// </summary>
		public string LICENSE_NO
		{
			get{ return _LICENSE_NO; }
			set
			{
				this.OnPropertyValueChange(_.LICENSE_NO, _LICENSE_NO, value);
				this._LICENSE_NO = value;
			}
		}
		/// <summary>
		/// 营业执照失效日期
		/// </summary>
		public DateTime? LICENSE_END_DATE
		{
			get{ return _LICENSE_END_DATE; }
			set
			{
				this.OnPropertyValueChange(_.LICENSE_END_DATE, _LICENSE_END_DATE, value);
				this._LICENSE_END_DATE = value;
			}
		}
		/// <summary>
		/// 国税税务登记证证号
		/// </summary>
		public string TAX_CERT_NO
		{
			get{ return _TAX_CERT_NO; }
			set
			{
				this.OnPropertyValueChange(_.TAX_CERT_NO, _TAX_CERT_NO, value);
				this._TAX_CERT_NO = value;
			}
		}
		/// <summary>
		/// 国税税务登记证失效日期
		/// </summary>
		public DateTime? TAX_CERT_END_DATE
		{
			get{ return _TAX_CERT_END_DATE; }
			set
			{
				this.OnPropertyValueChange(_.TAX_CERT_END_DATE, _TAX_CERT_END_DATE, value);
				this._TAX_CERT_END_DATE = value;
			}
		}
		/// <summary>
		/// 地税税务登记证证号
		/// </summary>
		public string LOCAL_TAX_CERT_NO
		{
			get{ return _LOCAL_TAX_CERT_NO; }
			set
			{
				this.OnPropertyValueChange(_.LOCAL_TAX_CERT_NO, _LOCAL_TAX_CERT_NO, value);
				this._LOCAL_TAX_CERT_NO = value;
			}
		}
		/// <summary>
		/// 地税税务登记证失效日期
		/// </summary>
		public DateTime? LOCAL_TAX_CERT_END_DATE
		{
			get{ return _LOCAL_TAX_CERT_END_DATE; }
			set
			{
				this.OnPropertyValueChange(_.LOCAL_TAX_CERT_END_DATE, _LOCAL_TAX_CERT_END_DATE, value);
				this._LOCAL_TAX_CERT_END_DATE = value;
			}
		}
		/// <summary>
		/// 组织机构代码
		/// </summary>
		public string ORGAN_NO
		{
			get{ return _ORGAN_NO; }
			set
			{
				this.OnPropertyValueChange(_.ORGAN_NO, _ORGAN_NO, value);
				this._ORGAN_NO = value;
			}
		}
		/// <summary>
		/// 组织机构代码证失效日期
		/// </summary>
		public DateTime? ORGAN_CERT_END_DATE
		{
			get{ return _ORGAN_CERT_END_DATE; }
			set
			{
				this.OnPropertyValueChange(_.ORGAN_CERT_END_DATE, _ORGAN_CERT_END_DATE, value);
				this._ORGAN_CERT_END_DATE = value;
			}
		}
		/// <summary>
		/// 法定代表人姓名
		/// </summary>
		public string LEGAL_REPRESENT
		{
			get{ return _LEGAL_REPRESENT; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_REPRESENT, _LEGAL_REPRESENT, value);
				this._LEGAL_REPRESENT = value;
			}
		}
		/// <summary>
		/// 法人机构类别
		/// </summary>
		public string LEGAL_TYPE
		{
			get{ return _LEGAL_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_TYPE, _LEGAL_TYPE, value);
				this._LEGAL_TYPE = value;
			}
		}
		/// <summary>
		/// 法人代表联系电话
		/// </summary>
		public string REPRESENT_PHONE
		{
			get{ return _REPRESENT_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.REPRESENT_PHONE, _REPRESENT_PHONE, value);
				this._REPRESENT_PHONE = value;
			}
		}
		/// <summary>
		/// 法人机构行业代码
		/// </summary>
		public string LEGAL_INDUSTRY
		{
			get{ return _LEGAL_INDUSTRY; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_INDUSTRY, _LEGAL_INDUSTRY, value);
				this._LEGAL_INDUSTRY = value;
			}
		}
		/// <summary>
		/// 资信等级
		/// </summary>
		public string CREDIT_RATE
		{
			get{ return _CREDIT_RATE; }
			set
			{
				this.OnPropertyValueChange(_.CREDIT_RATE, _CREDIT_RATE, value);
				this._CREDIT_RATE = value;
			}
		}
		/// <summary>
		/// 国别/地区
		/// </summary>
		public string COUNTRY_REGION
		{
			get{ return _COUNTRY_REGION; }
			set
			{
				this.OnPropertyValueChange(_.COUNTRY_REGION, _COUNTRY_REGION, value);
				this._COUNTRY_REGION = value;
			}
		}
		/// <summary>
		/// 法人机构地址
		/// </summary>
		public string LEGAL_UNIT_ADDRESS
		{
			get{ return _LEGAL_UNIT_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_UNIT_ADDRESS, _LEGAL_UNIT_ADDRESS, value);
				this._LEGAL_UNIT_ADDRESS = value;
			}
		}
		/// <summary>
		/// 行政区域代码
		/// </summary>
		public string REGION_CODE
		{
			get{ return _REGION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.REGION_CODE, _REGION_CODE, value);
				this._REGION_CODE = value;
			}
		}
		/// <summary>
		/// 注册地-省
		/// </summary>
		public string REGISTER_PROVINCE
		{
			get{ return _REGISTER_PROVINCE; }
			set
			{
				this.OnPropertyValueChange(_.REGISTER_PROVINCE, _REGISTER_PROVINCE, value);
				this._REGISTER_PROVINCE = value;
			}
		}
		/// <summary>
		/// 注册地-市
		/// </summary>
		public string REGISTER_CITY
		{
			get{ return _REGISTER_CITY; }
			set
			{
				this.OnPropertyValueChange(_.REGISTER_CITY, _REGISTER_CITY, value);
				this._REGISTER_CITY = value;
			}
		}
		/// <summary>
		/// 基本户开户银行
		/// </summary>
		public string BASIC_BANK
		{
			get{ return _BASIC_BANK; }
			set
			{
				this.OnPropertyValueChange(_.BASIC_BANK, _BASIC_BANK, value);
				this._BASIC_BANK = value;
			}
		}
		/// <summary>
		/// 基本户开户支行号
		/// </summary>
		public string BASIC_BRANCH_BANK
		{
			get{ return _BASIC_BRANCH_BANK; }
			set
			{
				this.OnPropertyValueChange(_.BASIC_BRANCH_BANK, _BASIC_BRANCH_BANK, value);
				this._BASIC_BRANCH_BANK = value;
			}
		}
		/// <summary>
		/// 基本户账号
		/// </summary>
		public string BASIC_ACCOUNT_NO
		{
			get{ return _BASIC_ACCOUNT_NO; }
			set
			{
				this.OnPropertyValueChange(_.BASIC_ACCOUNT_NO, _BASIC_ACCOUNT_NO, value);
				this._BASIC_ACCOUNT_NO = value;
			}
		}
		/// <summary>
		/// 基本户账户名称
		/// </summary>
		public string BASIC_ACCOUNT_NAME
		{
			get{ return _BASIC_ACCOUNT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BASIC_ACCOUNT_NAME, _BASIC_ACCOUNT_NAME, value);
				this._BASIC_ACCOUNT_NAME = value;
			}
		}
		/// <summary>
		/// 注册资本
		/// </summary>
		public decimal? REG_CAPITAL
		{
			get{ return _REG_CAPITAL; }
			set
			{
				this.OnPropertyValueChange(_.REG_CAPITAL, _REG_CAPITAL, value);
				this._REG_CAPITAL = value;
			}
		}
		/// <summary>
		/// 注册资本币种
		/// </summary>
		public string REG_CAP_CURRENCY
		{
			get{ return _REG_CAP_CURRENCY; }
			set
			{
				this.OnPropertyValueChange(_.REG_CAP_CURRENCY, _REG_CAP_CURRENCY, value);
				this._REG_CAP_CURRENCY = value;
			}
		}
		/// <summary>
		/// 注册资本单位
		/// </summary>
		public string REG_UNIT
		{
			get{ return _REG_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.REG_UNIT, _REG_UNIT, value);
				this._REG_UNIT = value;
			}
		}
		/// <summary>
		/// 联系人
		/// </summary>
		public string LEGAL_CONTACT
		{
			get{ return _LEGAL_CONTACT; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_CONTACT, _LEGAL_CONTACT, value);
				this._LEGAL_CONTACT = value;
			}
		}
		/// <summary>
		/// 联系人电话
		/// </summary>
		public string LEGAL_CONTACT_PHONE
		{
			get{ return _LEGAL_CONTACT_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_CONTACT_PHONE, _LEGAL_CONTACT_PHONE, value);
				this._LEGAL_CONTACT_PHONE = value;
			}
		}
		/// <summary>
		/// 联系人地址
		/// </summary>
		public string LEGAL_CONTACT_ADDRESS
		{
			get{ return _LEGAL_CONTACT_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_CONTACT_ADDRESS, _LEGAL_CONTACT_ADDRESS, value);
				this._LEGAL_CONTACT_ADDRESS = value;
			}
		}
		/// <summary>
		/// 单位网站
		/// </summary>
		public string LEGAL_WEB
		{
			get{ return _LEGAL_WEB; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_WEB, _LEGAL_WEB, value);
				this._LEGAL_WEB = value;
			}
		}
		/// <summary>
		/// 邮政编码
		/// </summary>
		public string LEGAL_ZIP_CODE
		{
			get{ return _LEGAL_ZIP_CODE; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_ZIP_CODE, _LEGAL_ZIP_CODE, value);
				this._LEGAL_ZIP_CODE = value;
			}
		}
		/// <summary>
		/// 电子邮箱
		/// </summary>
		public string LEGAL_EMAIL
		{
			get{ return _LEGAL_EMAIL; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_EMAIL, _LEGAL_EMAIL, value);
				this._LEGAL_EMAIL = value;
			}
		}
		/// <summary>
		/// 法人业务状态
		/// </summary>
		public string LEGAL_STATUS
		{
			get{ return _LEGAL_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_STATUS, _LEGAL_STATUS, value);
				this._LEGAL_STATUS = value;
			}
		}
		/// <summary>
		/// 数据来源
		/// </summary>
		public string M_DATA_SOURCE
		{
			get{ return _M_DATA_SOURCE; }
			set
			{
				this.OnPropertyValueChange(_.M_DATA_SOURCE, _M_DATA_SOURCE, value);
				this._M_DATA_SOURCE = value;
			}
		}
		/// <summary>
		/// 公共服务平台标识码
		/// </summary>
		public string PUB_SERVICE_PLAT_CODE
		{
			get{ return _PUB_SERVICE_PLAT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PUB_SERVICE_PLAT_CODE, _PUB_SERVICE_PLAT_CODE, value);
				this._PUB_SERVICE_PLAT_CODE = value;
			}
		}
		/// <summary>
		/// 数据时间戳
		/// </summary>
		public DateTime? DATA_TIMESTAMP
		{
			get{ return _DATA_TIMESTAMP; }
			set
			{
				this.OnPropertyValueChange(_.DATA_TIMESTAMP, _DATA_TIMESTAMP, value);
				this._DATA_TIMESTAMP = value;
			}
		}
		/// <summary>
		/// 版本号
		/// </summary>
		public string VERSION
		{
			get{ return _VERSION; }
			set
			{
				this.OnPropertyValueChange(_.VERSION, _VERSION, value);
				this._VERSION = value;
			}
		}
		/// <summary>
		/// M_ID
		/// </summary>
		public decimal? M_ID
		{
			get{ return _M_ID; }
			set
			{
				this.OnPropertyValueChange(_.M_ID, _M_ID, value);
				this._M_ID = value;
			}
		}
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.LEGAL_NAME,
				_.BIDDER_CODE_TYPE,
				_.LEGAL_CODE,
				_.LEGAL_ROLE,
				_.LICENSE_NO,
				_.LICENSE_END_DATE,
				_.TAX_CERT_NO,
				_.TAX_CERT_END_DATE,
				_.LOCAL_TAX_CERT_NO,
				_.LOCAL_TAX_CERT_END_DATE,
				_.ORGAN_NO,
				_.ORGAN_CERT_END_DATE,
				_.LEGAL_REPRESENT,
				_.LEGAL_TYPE,
				_.REPRESENT_PHONE,
				_.LEGAL_INDUSTRY,
				_.CREDIT_RATE,
				_.COUNTRY_REGION,
				_.LEGAL_UNIT_ADDRESS,
				_.REGION_CODE,
				_.REGISTER_PROVINCE,
				_.REGISTER_CITY,
				_.BASIC_BANK,
				_.BASIC_BRANCH_BANK,
				_.BASIC_ACCOUNT_NO,
				_.BASIC_ACCOUNT_NAME,
				_.REG_CAPITAL,
				_.REG_CAP_CURRENCY,
				_.REG_UNIT,
				_.LEGAL_CONTACT,
				_.LEGAL_CONTACT_PHONE,
				_.LEGAL_CONTACT_ADDRESS,
				_.LEGAL_WEB,
				_.LEGAL_ZIP_CODE,
				_.LEGAL_EMAIL,
				_.LEGAL_STATUS,
				_.M_DATA_SOURCE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.VERSION,
				_.M_ID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._LEGAL_NAME,
				this._BIDDER_CODE_TYPE,
				this._LEGAL_CODE,
				this._LEGAL_ROLE,
				this._LICENSE_NO,
				this._LICENSE_END_DATE,
				this._TAX_CERT_NO,
				this._TAX_CERT_END_DATE,
				this._LOCAL_TAX_CERT_NO,
				this._LOCAL_TAX_CERT_END_DATE,
				this._ORGAN_NO,
				this._ORGAN_CERT_END_DATE,
				this._LEGAL_REPRESENT,
				this._LEGAL_TYPE,
				this._REPRESENT_PHONE,
				this._LEGAL_INDUSTRY,
				this._CREDIT_RATE,
				this._COUNTRY_REGION,
				this._LEGAL_UNIT_ADDRESS,
				this._REGION_CODE,
				this._REGISTER_PROVINCE,
				this._REGISTER_CITY,
				this._BASIC_BANK,
				this._BASIC_BRANCH_BANK,
				this._BASIC_ACCOUNT_NO,
				this._BASIC_ACCOUNT_NAME,
				this._REG_CAPITAL,
				this._REG_CAP_CURRENCY,
				this._REG_UNIT,
				this._LEGAL_CONTACT,
				this._LEGAL_CONTACT_PHONE,
				this._LEGAL_CONTACT_ADDRESS,
				this._LEGAL_WEB,
				this._LEGAL_ZIP_CODE,
				this._LEGAL_EMAIL,
				this._LEGAL_STATUS,
				this._M_DATA_SOURCE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._VERSION,
				this._M_ID,
			};
        }
        #endregion

		#region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
			/// <summary>
			/// * 
			/// </summary>
			public readonly static Field All = new Field("*", "ZJ_LEGAL_PERSON_BASE");
            /// <summary>
			/// 法人名称
			/// </summary>
			public readonly static Field LEGAL_NAME = new Field("LEGAL_NAME", "ZJ_LEGAL_PERSON_BASE", "法人名称");
            /// <summary>
			/// 法人类别
			/// </summary>
			public readonly static Field BIDDER_CODE_TYPE = new Field("BIDDER_CODE_TYPE", "ZJ_LEGAL_PERSON_BASE", "法人类别");
            /// <summary>
			/// 法人代码
			/// </summary>
			public readonly static Field LEGAL_CODE = new Field("LEGAL_CODE", "ZJ_LEGAL_PERSON_BASE", "法人代码");
            /// <summary>
			/// 法人角色
			/// </summary>
			public readonly static Field LEGAL_ROLE = new Field("LEGAL_ROLE", "ZJ_LEGAL_PERSON_BASE", "法人角色");
            /// <summary>
			/// 营业执照号码
			/// </summary>
			public readonly static Field LICENSE_NO = new Field("LICENSE_NO", "ZJ_LEGAL_PERSON_BASE", "营业执照号码");
            /// <summary>
			/// 营业执照失效日期
			/// </summary>
			public readonly static Field LICENSE_END_DATE = new Field("LICENSE_END_DATE", "ZJ_LEGAL_PERSON_BASE", "营业执照失效日期");
            /// <summary>
			/// 国税税务登记证证号
			/// </summary>
			public readonly static Field TAX_CERT_NO = new Field("TAX_CERT_NO", "ZJ_LEGAL_PERSON_BASE", "国税税务登记证证号");
            /// <summary>
			/// 国税税务登记证失效日期
			/// </summary>
			public readonly static Field TAX_CERT_END_DATE = new Field("TAX_CERT_END_DATE", "ZJ_LEGAL_PERSON_BASE", "国税税务登记证失效日期");
            /// <summary>
			/// 地税税务登记证证号
			/// </summary>
			public readonly static Field LOCAL_TAX_CERT_NO = new Field("LOCAL_TAX_CERT_NO", "ZJ_LEGAL_PERSON_BASE", "地税税务登记证证号");
            /// <summary>
			/// 地税税务登记证失效日期
			/// </summary>
			public readonly static Field LOCAL_TAX_CERT_END_DATE = new Field("LOCAL_TAX_CERT_END_DATE", "ZJ_LEGAL_PERSON_BASE", "地税税务登记证失效日期");
            /// <summary>
			/// 组织机构代码
			/// </summary>
			public readonly static Field ORGAN_NO = new Field("ORGAN_NO", "ZJ_LEGAL_PERSON_BASE", "组织机构代码");
            /// <summary>
			/// 组织机构代码证失效日期
			/// </summary>
			public readonly static Field ORGAN_CERT_END_DATE = new Field("ORGAN_CERT_END_DATE", "ZJ_LEGAL_PERSON_BASE", "组织机构代码证失效日期");
            /// <summary>
			/// 法定代表人姓名
			/// </summary>
			public readonly static Field LEGAL_REPRESENT = new Field("LEGAL_REPRESENT", "ZJ_LEGAL_PERSON_BASE", "法定代表人姓名");
            /// <summary>
			/// 法人机构类别
			/// </summary>
			public readonly static Field LEGAL_TYPE = new Field("LEGAL_TYPE", "ZJ_LEGAL_PERSON_BASE", "法人机构类别");
            /// <summary>
			/// 法人代表联系电话
			/// </summary>
			public readonly static Field REPRESENT_PHONE = new Field("REPRESENT_PHONE", "ZJ_LEGAL_PERSON_BASE", "法人代表联系电话");
            /// <summary>
			/// 法人机构行业代码
			/// </summary>
			public readonly static Field LEGAL_INDUSTRY = new Field("LEGAL_INDUSTRY", "ZJ_LEGAL_PERSON_BASE", "法人机构行业代码");
            /// <summary>
			/// 资信等级
			/// </summary>
			public readonly static Field CREDIT_RATE = new Field("CREDIT_RATE", "ZJ_LEGAL_PERSON_BASE", "资信等级");
            /// <summary>
			/// 国别/地区
			/// </summary>
			public readonly static Field COUNTRY_REGION = new Field("COUNTRY_REGION", "ZJ_LEGAL_PERSON_BASE", "国别/地区");
            /// <summary>
			/// 法人机构地址
			/// </summary>
			public readonly static Field LEGAL_UNIT_ADDRESS = new Field("LEGAL_UNIT_ADDRESS", "ZJ_LEGAL_PERSON_BASE", "法人机构地址");
            /// <summary>
			/// 行政区域代码
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "ZJ_LEGAL_PERSON_BASE", "行政区域代码");
            /// <summary>
			/// 注册地-省
			/// </summary>
			public readonly static Field REGISTER_PROVINCE = new Field("REGISTER_PROVINCE", "ZJ_LEGAL_PERSON_BASE", "注册地-省");
            /// <summary>
			/// 注册地-市
			/// </summary>
			public readonly static Field REGISTER_CITY = new Field("REGISTER_CITY", "ZJ_LEGAL_PERSON_BASE", "注册地-市");
            /// <summary>
			/// 基本户开户银行
			/// </summary>
			public readonly static Field BASIC_BANK = new Field("BASIC_BANK", "ZJ_LEGAL_PERSON_BASE", "基本户开户银行");
            /// <summary>
			/// 基本户开户支行号
			/// </summary>
			public readonly static Field BASIC_BRANCH_BANK = new Field("BASIC_BRANCH_BANK", "ZJ_LEGAL_PERSON_BASE", "基本户开户支行号");
            /// <summary>
			/// 基本户账号
			/// </summary>
			public readonly static Field BASIC_ACCOUNT_NO = new Field("BASIC_ACCOUNT_NO", "ZJ_LEGAL_PERSON_BASE", "基本户账号");
            /// <summary>
			/// 基本户账户名称
			/// </summary>
			public readonly static Field BASIC_ACCOUNT_NAME = new Field("BASIC_ACCOUNT_NAME", "ZJ_LEGAL_PERSON_BASE", "基本户账户名称");
            /// <summary>
			/// 注册资本
			/// </summary>
			public readonly static Field REG_CAPITAL = new Field("REG_CAPITAL", "ZJ_LEGAL_PERSON_BASE", "注册资本");
            /// <summary>
			/// 注册资本币种
			/// </summary>
			public readonly static Field REG_CAP_CURRENCY = new Field("REG_CAP_CURRENCY", "ZJ_LEGAL_PERSON_BASE", "注册资本币种");
            /// <summary>
			/// 注册资本单位
			/// </summary>
			public readonly static Field REG_UNIT = new Field("REG_UNIT", "ZJ_LEGAL_PERSON_BASE", "注册资本单位");
            /// <summary>
			/// 联系人
			/// </summary>
			public readonly static Field LEGAL_CONTACT = new Field("LEGAL_CONTACT", "ZJ_LEGAL_PERSON_BASE", "联系人");
            /// <summary>
			/// 联系人电话
			/// </summary>
			public readonly static Field LEGAL_CONTACT_PHONE = new Field("LEGAL_CONTACT_PHONE", "ZJ_LEGAL_PERSON_BASE", "联系人电话");
            /// <summary>
			/// 联系人地址
			/// </summary>
			public readonly static Field LEGAL_CONTACT_ADDRESS = new Field("LEGAL_CONTACT_ADDRESS", "ZJ_LEGAL_PERSON_BASE", "联系人地址");
            /// <summary>
			/// 单位网站
			/// </summary>
			public readonly static Field LEGAL_WEB = new Field("LEGAL_WEB", "ZJ_LEGAL_PERSON_BASE", "单位网站");
            /// <summary>
			/// 邮政编码
			/// </summary>
			public readonly static Field LEGAL_ZIP_CODE = new Field("LEGAL_ZIP_CODE", "ZJ_LEGAL_PERSON_BASE", "邮政编码");
            /// <summary>
			/// 电子邮箱
			/// </summary>
			public readonly static Field LEGAL_EMAIL = new Field("LEGAL_EMAIL", "ZJ_LEGAL_PERSON_BASE", "电子邮箱");
            /// <summary>
			/// 法人业务状态
			/// </summary>
			public readonly static Field LEGAL_STATUS = new Field("LEGAL_STATUS", "ZJ_LEGAL_PERSON_BASE", "法人业务状态");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "ZJ_LEGAL_PERSON_BASE", "数据来源");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "ZJ_LEGAL_PERSON_BASE", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "ZJ_LEGAL_PERSON_BASE", "数据时间戳");
            /// <summary>
			/// 版本号
			/// </summary>
			public readonly static Field VERSION = new Field("VERSION", "ZJ_LEGAL_PERSON_BASE", "版本号");
            /// <summary>
			/// M_ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "ZJ_LEGAL_PERSON_BASE", "M_ID");
        }
        #endregion
	}
}