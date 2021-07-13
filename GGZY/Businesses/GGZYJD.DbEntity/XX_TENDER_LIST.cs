using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类XX_TENDER_LIST。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("XX_TENDER_LIST")]
    [Serializable]
    public partial class XX_TENDER_LIST : JdEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _M_VERSION;
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private string _UNIFIED_DEAL_CODE;
		private string _BIDDER_NAME;
		private string _BIDDER_CODE_TYPE;
		private string _BIDDER_ORG_CODE;
		private string _BIDDER_ROLE;
		private string _BIDDER_REGION_CODE;
		private string _BIDDER_PROPERTY;
		private decimal? _BIDDER_CREDIT_SCORE;
		private string _IS_LOST;
		private string _BIDDER_OPERATION_PERSON;
		private string _BIDDER_OPERATION_PERSON_ID;
		private string _BIDDER_OPERATION_PERSON_CON;
		private string _BID_MANAGER;
		private string _ID_CARD;
		private string _REGIST_CERTIFICATE;
		private string _MARGIN_PAY_FORM;
		private string _IS_COMMIT_MARGIN;
		private DateTime? _MARGIN_RECEIVE_TIME;
		private string _UNION_ENTERPRISE_NAME;
		private string _UNION_ORGAN_SET_CODE;
		private string _UNION_CONTACT_NAME;
		private string _UNION_CONTACT_PHONE;
		private DateTime? _BIDDER_INFO_VERSION;
		private string _PRICE_FORM_CODE;
		private string _OTHER_BID_PRICE;
		private decimal? _BID_PRICE;
		private string _PRICE_CURRENCY;
		private string _PRICE_UNIT;
		private decimal? _TIME_LIMIT;
		private string _PURCHASE_ORDER_NUMBER;
		private string _IS_REVIEW_SHORTLISTED;
		private DateTime? _CHECKIN_TIME;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;

		/// <summary>
		/// 
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
		/// <summary>
		/// 
		/// </summary>
		public string DATA_KEY
		{
			get{ return _DATA_KEY; }
			set
			{
				this.OnPropertyValueChange(_.DATA_KEY, _DATA_KEY, value);
				this._DATA_KEY = value;
			}
		}
		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public DateTime? M_TM
		{
			get{ return _M_TM; }
			set
			{
				this.OnPropertyValueChange(_.M_TM, _M_TM, value);
				this._M_TM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_VERSION
		{
			get{ return _M_VERSION; }
			set
			{
				this.OnPropertyValueChange(_.M_VERSION, _M_VERSION, value);
				this._M_VERSION = value;
			}
		}
		/// <summary>
		/// 招标项目编号
		/// </summary>
		public string TENDER_PROJECT_CODE
		{
			get{ return _TENDER_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_CODE, _TENDER_PROJECT_CODE, value);
				this._TENDER_PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 标段（包）编号
		/// </summary>
		public string BID_SECTION_CODE
		{
			get{ return _BID_SECTION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_CODE, _BID_SECTION_CODE, value);
				this._BID_SECTION_CODE = value;
			}
		}
		/// <summary>
		/// 统一交易标识码
		/// </summary>
		public string UNIFIED_DEAL_CODE
		{
			get{ return _UNIFIED_DEAL_CODE; }
			set
			{
				this.OnPropertyValueChange(_.UNIFIED_DEAL_CODE, _UNIFIED_DEAL_CODE, value);
				this._UNIFIED_DEAL_CODE = value;
			}
		}
		/// <summary>
		/// 投标人名称
		/// </summary>
		public string BIDDER_NAME
		{
			get{ return _BIDDER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_NAME, _BIDDER_NAME, value);
				this._BIDDER_NAME = value;
			}
		}
		/// <summary>
		/// 投标人类别
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
		/// 投标人代码
		/// </summary>
		public string BIDDER_ORG_CODE
		{
			get{ return _BIDDER_ORG_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_ORG_CODE, _BIDDER_ORG_CODE, value);
				this._BIDDER_ORG_CODE = value;
			}
		}
		/// <summary>
		/// 投标人角色
		/// </summary>
		public string BIDDER_ROLE
		{
			get{ return _BIDDER_ROLE; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_ROLE, _BIDDER_ROLE, value);
				this._BIDDER_ROLE = value;
			}
		}
		/// <summary>
		/// 投标人企业注册所在地
		/// </summary>
		public string BIDDER_REGION_CODE
		{
			get{ return _BIDDER_REGION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_REGION_CODE, _BIDDER_REGION_CODE, value);
				this._BIDDER_REGION_CODE = value;
			}
		}
		/// <summary>
		/// 投标人企业性质
		/// </summary>
		public string BIDDER_PROPERTY
		{
			get{ return _BIDDER_PROPERTY; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_PROPERTY, _BIDDER_PROPERTY, value);
				this._BIDDER_PROPERTY = value;
			}
		}
		/// <summary>
		/// 投标人信用分
		/// </summary>
		public decimal? BIDDER_CREDIT_SCORE
		{
			get{ return _BIDDER_CREDIT_SCORE; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_CREDIT_SCORE, _BIDDER_CREDIT_SCORE, value);
				this._BIDDER_CREDIT_SCORE = value;
			}
		}
		/// <summary>
		/// 是否失信人
		/// </summary>
		public string IS_LOST
		{
			get{ return _IS_LOST; }
			set
			{
				this.OnPropertyValueChange(_.IS_LOST, _IS_LOST, value);
				this._IS_LOST = value;
			}
		}
		/// <summary>
		/// 投标操作人员
		/// </summary>
		public string BIDDER_OPERATION_PERSON
		{
			get{ return _BIDDER_OPERATION_PERSON; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_OPERATION_PERSON, _BIDDER_OPERATION_PERSON, value);
				this._BIDDER_OPERATION_PERSON = value;
			}
		}
		/// <summary>
		/// 投标操作人员身份证
		/// </summary>
		public string BIDDER_OPERATION_PERSON_ID
		{
			get{ return _BIDDER_OPERATION_PERSON_ID; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_OPERATION_PERSON_ID, _BIDDER_OPERATION_PERSON_ID, value);
				this._BIDDER_OPERATION_PERSON_ID = value;
			}
		}
		/// <summary>
		/// 投标操作人联系方式
		/// </summary>
		public string BIDDER_OPERATION_PERSON_CON
		{
			get{ return _BIDDER_OPERATION_PERSON_CON; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_OPERATION_PERSON_CON, _BIDDER_OPERATION_PERSON_CON, value);
				this._BIDDER_OPERATION_PERSON_CON = value;
			}
		}
		/// <summary>
		/// 投标单位项目负责人
		/// </summary>
		public string BID_MANAGER
		{
			get{ return _BID_MANAGER; }
			set
			{
				this.OnPropertyValueChange(_.BID_MANAGER, _BID_MANAGER, value);
				this._BID_MANAGER = value;
			}
		}
		/// <summary>
		/// 投标单位项目负责人身份证号
		/// </summary>
		public string ID_CARD
		{
			get{ return _ID_CARD; }
			set
			{
				this.OnPropertyValueChange(_.ID_CARD, _ID_CARD, value);
				this._ID_CARD = value;
			}
		}
		/// <summary>
		/// 注册证书类别及注册证书号
		/// </summary>
		public string REGIST_CERTIFICATE
		{
			get{ return _REGIST_CERTIFICATE; }
			set
			{
				this.OnPropertyValueChange(_.REGIST_CERTIFICATE, _REGIST_CERTIFICATE, value);
				this._REGIST_CERTIFICATE = value;
			}
		}
		/// <summary>
		/// 保证金递交方式
		/// </summary>
		public string MARGIN_PAY_FORM
		{
			get{ return _MARGIN_PAY_FORM; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_PAY_FORM, _MARGIN_PAY_FORM, value);
				this._MARGIN_PAY_FORM = value;
			}
		}
		/// <summary>
		/// 是否提交保证金
		/// </summary>
		public string IS_COMMIT_MARGIN
		{
			get{ return _IS_COMMIT_MARGIN; }
			set
			{
				this.OnPropertyValueChange(_.IS_COMMIT_MARGIN, _IS_COMMIT_MARGIN, value);
				this._IS_COMMIT_MARGIN = value;
			}
		}
		/// <summary>
		/// 保证金递交时间
		/// </summary>
		public DateTime? MARGIN_RECEIVE_TIME
		{
			get{ return _MARGIN_RECEIVE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_RECEIVE_TIME, _MARGIN_RECEIVE_TIME, value);
				this._MARGIN_RECEIVE_TIME = value;
			}
		}
		/// <summary>
		/// 联合体名称（如有）
		/// </summary>
		public string UNION_ENTERPRISE_NAME
		{
			get{ return _UNION_ENTERPRISE_NAME; }
			set
			{
				this.OnPropertyValueChange(_.UNION_ENTERPRISE_NAME, _UNION_ENTERPRISE_NAME, value);
				this._UNION_ENTERPRISE_NAME = value;
			}
		}
		/// <summary>
		/// 联合体组织机构代码证（联合体招标时填写）
		/// </summary>
		public string UNION_ORGAN_SET_CODE
		{
			get{ return _UNION_ORGAN_SET_CODE; }
			set
			{
				this.OnPropertyValueChange(_.UNION_ORGAN_SET_CODE, _UNION_ORGAN_SET_CODE, value);
				this._UNION_ORGAN_SET_CODE = value;
			}
		}
		/// <summary>
		/// 联合体联系人（如有）
		/// </summary>
		public string UNION_CONTACT_NAME
		{
			get{ return _UNION_CONTACT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.UNION_CONTACT_NAME, _UNION_CONTACT_NAME, value);
				this._UNION_CONTACT_NAME = value;
			}
		}
		/// <summary>
		/// 联合体联系电话（如有）
		/// </summary>
		public string UNION_CONTACT_PHONE
		{
			get{ return _UNION_CONTACT_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.UNION_CONTACT_PHONE, _UNION_CONTACT_PHONE, value);
				this._UNION_CONTACT_PHONE = value;
			}
		}
		/// <summary>
		/// 投标人信息版本
		/// </summary>
		public DateTime? BIDDER_INFO_VERSION
		{
			get{ return _BIDDER_INFO_VERSION; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_INFO_VERSION, _BIDDER_INFO_VERSION, value);
				this._BIDDER_INFO_VERSION = value;
			}
		}
		/// <summary>
		/// 价款形式代码
		/// </summary>
		public string PRICE_FORM_CODE
		{
			get{ return _PRICE_FORM_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PRICE_FORM_CODE, _PRICE_FORM_CODE, value);
				this._PRICE_FORM_CODE = value;
			}
		}
		/// <summary>
		/// 费率或其它类型报价
		/// </summary>
		public string OTHER_BID_PRICE
		{
			get{ return _OTHER_BID_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_BID_PRICE, _OTHER_BID_PRICE, value);
				this._OTHER_BID_PRICE = value;
			}
		}
		/// <summary>
		/// 投标报价金额
		/// </summary>
		public decimal? BID_PRICE
		{
			get{ return _BID_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.BID_PRICE, _BID_PRICE, value);
				this._BID_PRICE = value;
			}
		}
		/// <summary>
		/// 投标报价币种
		/// </summary>
		public string PRICE_CURRENCY
		{
			get{ return _PRICE_CURRENCY; }
			set
			{
				this.OnPropertyValueChange(_.PRICE_CURRENCY, _PRICE_CURRENCY, value);
				this._PRICE_CURRENCY = value;
			}
		}
		/// <summary>
		/// 投标报价单位
		/// </summary>
		public string PRICE_UNIT
		{
			get{ return _PRICE_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.PRICE_UNIT, _PRICE_UNIT, value);
				this._PRICE_UNIT = value;
			}
		}
		/// <summary>
		/// 投标工期
		/// </summary>
		public decimal? TIME_LIMIT
		{
			get{ return _TIME_LIMIT; }
			set
			{
				this.OnPropertyValueChange(_.TIME_LIMIT, _TIME_LIMIT, value);
				this._TIME_LIMIT = value;
			}
		}
		/// <summary>
		/// 招标文件购买订单号
		/// </summary>
		public string PURCHASE_ORDER_NUMBER
		{
			get{ return _PURCHASE_ORDER_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASE_ORDER_NUMBER, _PURCHASE_ORDER_NUMBER, value);
				this._PURCHASE_ORDER_NUMBER = value;
			}
		}
		/// <summary>
		/// 投标人是否入围评审
		/// </summary>
		public string IS_REVIEW_SHORTLISTED
		{
			get{ return _IS_REVIEW_SHORTLISTED; }
			set
			{
				this.OnPropertyValueChange(_.IS_REVIEW_SHORTLISTED, _IS_REVIEW_SHORTLISTED, value);
				this._IS_REVIEW_SHORTLISTED = value;
			}
		}
		/// <summary>
		/// 投标文件递交时间
		/// </summary>
		public DateTime? CHECKIN_TIME
		{
			get{ return _CHECKIN_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CHECKIN_TIME, _CHECKIN_TIME, value);
				this._CHECKIN_TIME = value;
			}
		}
		/// <summary>
		/// 交易系统标识码
		/// </summary>
		public string PLATFORM_CODE
		{
			get{ return _PLATFORM_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PLATFORM_CODE, _PLATFORM_CODE, value);
				this._PLATFORM_CODE = value;
			}
		}
		/// <summary>
		/// 交易服务系统标识码
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
		/// 交易平台或发布工具标识码
		/// </summary>
		public string TRADE_PLAT
		{
			get{ return _TRADE_PLAT; }
			set
			{
				this.OnPropertyValueChange(_.TRADE_PLAT, _TRADE_PLAT, value);
				this._TRADE_PLAT = value;
			}
		}
		/// <summary>
		/// 公共服务平台标识码
		/// </summary>
		public string PUB_SERVICE_PLAT
		{
			get{ return _PUB_SERVICE_PLAT; }
			set
			{
				this.OnPropertyValueChange(_.PUB_SERVICE_PLAT, _PUB_SERVICE_PLAT, value);
				this._PUB_SERVICE_PLAT = value;
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
				_.M_ID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.M_ID,
				_.DATA_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_VERSION,
				_.TENDER_PROJECT_CODE,
				_.BID_SECTION_CODE,
				_.UNIFIED_DEAL_CODE,
				_.BIDDER_NAME,
				_.BIDDER_CODE_TYPE,
				_.BIDDER_ORG_CODE,
				_.BIDDER_ROLE,
				_.BIDDER_REGION_CODE,
				_.BIDDER_PROPERTY,
				_.BIDDER_CREDIT_SCORE,
				_.IS_LOST,
				_.BIDDER_OPERATION_PERSON,
				_.BIDDER_OPERATION_PERSON_ID,
				_.BIDDER_OPERATION_PERSON_CON,
				_.BID_MANAGER,
				_.ID_CARD,
				_.REGIST_CERTIFICATE,
				_.MARGIN_PAY_FORM,
				_.IS_COMMIT_MARGIN,
				_.MARGIN_RECEIVE_TIME,
				_.UNION_ENTERPRISE_NAME,
				_.UNION_ORGAN_SET_CODE,
				_.UNION_CONTACT_NAME,
				_.UNION_CONTACT_PHONE,
				_.BIDDER_INFO_VERSION,
				_.PRICE_FORM_CODE,
				_.OTHER_BID_PRICE,
				_.BID_PRICE,
				_.PRICE_CURRENCY,
				_.PRICE_UNIT,
				_.TIME_LIMIT,
				_.PURCHASE_ORDER_NUMBER,
				_.IS_REVIEW_SHORTLISTED,
				_.CHECKIN_TIME,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.TRADE_PLAT,
				_.PUB_SERVICE_PLAT,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._M_ID,
				this._DATA_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_VERSION,
				this._TENDER_PROJECT_CODE,
				this._BID_SECTION_CODE,
				this._UNIFIED_DEAL_CODE,
				this._BIDDER_NAME,
				this._BIDDER_CODE_TYPE,
				this._BIDDER_ORG_CODE,
				this._BIDDER_ROLE,
				this._BIDDER_REGION_CODE,
				this._BIDDER_PROPERTY,
				this._BIDDER_CREDIT_SCORE,
				this._IS_LOST,
				this._BIDDER_OPERATION_PERSON,
				this._BIDDER_OPERATION_PERSON_ID,
				this._BIDDER_OPERATION_PERSON_CON,
				this._BID_MANAGER,
				this._ID_CARD,
				this._REGIST_CERTIFICATE,
				this._MARGIN_PAY_FORM,
				this._IS_COMMIT_MARGIN,
				this._MARGIN_RECEIVE_TIME,
				this._UNION_ENTERPRISE_NAME,
				this._UNION_ORGAN_SET_CODE,
				this._UNION_CONTACT_NAME,
				this._UNION_CONTACT_PHONE,
				this._BIDDER_INFO_VERSION,
				this._PRICE_FORM_CODE,
				this._OTHER_BID_PRICE,
				this._BID_PRICE,
				this._PRICE_CURRENCY,
				this._PRICE_UNIT,
				this._TIME_LIMIT,
				this._PURCHASE_ORDER_NUMBER,
				this._IS_REVIEW_SHORTLISTED,
				this._CHECKIN_TIME,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._TRADE_PLAT,
				this._PUB_SERVICE_PLAT,
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
			public readonly static Field All = new Field("*", "XX_TENDER_LIST");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "XX_TENDER_LIST", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "XX_TENDER_LIST", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "XX_TENDER_LIST", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "XX_TENDER_LIST", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "XX_TENDER_LIST", "");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "XX_TENDER_LIST", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "XX_TENDER_LIST", "标段（包）编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "XX_TENDER_LIST", "统一交易标识码");
            /// <summary>
			/// 投标人名称
			/// </summary>
			public readonly static Field BIDDER_NAME = new Field("BIDDER_NAME", "XX_TENDER_LIST", "投标人名称");
            /// <summary>
			/// 投标人类别
			/// </summary>
			public readonly static Field BIDDER_CODE_TYPE = new Field("BIDDER_CODE_TYPE", "XX_TENDER_LIST", "投标人类别");
            /// <summary>
			/// 投标人代码
			/// </summary>
			public readonly static Field BIDDER_ORG_CODE = new Field("BIDDER_ORG_CODE", "XX_TENDER_LIST", "投标人代码");
            /// <summary>
			/// 投标人角色
			/// </summary>
			public readonly static Field BIDDER_ROLE = new Field("BIDDER_ROLE", "XX_TENDER_LIST", "投标人角色");
            /// <summary>
			/// 投标人企业注册所在地
			/// </summary>
			public readonly static Field BIDDER_REGION_CODE = new Field("BIDDER_REGION_CODE", "XX_TENDER_LIST", "投标人企业注册所在地");
            /// <summary>
			/// 投标人企业性质
			/// </summary>
			public readonly static Field BIDDER_PROPERTY = new Field("BIDDER_PROPERTY", "XX_TENDER_LIST", "投标人企业性质");
            /// <summary>
			/// 投标人信用分
			/// </summary>
			public readonly static Field BIDDER_CREDIT_SCORE = new Field("BIDDER_CREDIT_SCORE", "XX_TENDER_LIST", "投标人信用分");
            /// <summary>
			/// 是否失信人
			/// </summary>
			public readonly static Field IS_LOST = new Field("IS_LOST", "XX_TENDER_LIST", "是否失信人");
            /// <summary>
			/// 投标操作人员
			/// </summary>
			public readonly static Field BIDDER_OPERATION_PERSON = new Field("BIDDER_OPERATION_PERSON", "XX_TENDER_LIST", "投标操作人员");
            /// <summary>
			/// 投标操作人员身份证
			/// </summary>
			public readonly static Field BIDDER_OPERATION_PERSON_ID = new Field("BIDDER_OPERATION_PERSON_ID", "XX_TENDER_LIST", "投标操作人员身份证");
            /// <summary>
			/// 投标操作人联系方式
			/// </summary>
			public readonly static Field BIDDER_OPERATION_PERSON_CON = new Field("BIDDER_OPERATION_PERSON_CON", "XX_TENDER_LIST", "投标操作人联系方式");
            /// <summary>
			/// 投标单位项目负责人
			/// </summary>
			public readonly static Field BID_MANAGER = new Field("BID_MANAGER", "XX_TENDER_LIST", "投标单位项目负责人");
            /// <summary>
			/// 投标单位项目负责人身份证号
			/// </summary>
			public readonly static Field ID_CARD = new Field("ID_CARD", "XX_TENDER_LIST", "投标单位项目负责人身份证号");
            /// <summary>
			/// 注册证书类别及注册证书号
			/// </summary>
			public readonly static Field REGIST_CERTIFICATE = new Field("REGIST_CERTIFICATE", "XX_TENDER_LIST",DbType.AnsiString, null, "注册证书类别及注册证书号");
            /// <summary>
			/// 保证金递交方式
			/// </summary>
			public readonly static Field MARGIN_PAY_FORM = new Field("MARGIN_PAY_FORM", "XX_TENDER_LIST", "保证金递交方式");
            /// <summary>
			/// 是否提交保证金
			/// </summary>
			public readonly static Field IS_COMMIT_MARGIN = new Field("IS_COMMIT_MARGIN", "XX_TENDER_LIST", "是否提交保证金");
            /// <summary>
			/// 保证金递交时间
			/// </summary>
			public readonly static Field MARGIN_RECEIVE_TIME = new Field("MARGIN_RECEIVE_TIME", "XX_TENDER_LIST", "保证金递交时间");
            /// <summary>
			/// 联合体名称（如有）
			/// </summary>
			public readonly static Field UNION_ENTERPRISE_NAME = new Field("UNION_ENTERPRISE_NAME", "XX_TENDER_LIST", "联合体名称（如有）");
            /// <summary>
			/// 联合体组织机构代码证（联合体招标时填写）
			/// </summary>
			public readonly static Field UNION_ORGAN_SET_CODE = new Field("UNION_ORGAN_SET_CODE", "XX_TENDER_LIST", "联合体组织机构代码证（联合体招标时填写）");
            /// <summary>
			/// 联合体联系人（如有）
			/// </summary>
			public readonly static Field UNION_CONTACT_NAME = new Field("UNION_CONTACT_NAME", "XX_TENDER_LIST", "联合体联系人（如有）");
            /// <summary>
			/// 联合体联系电话（如有）
			/// </summary>
			public readonly static Field UNION_CONTACT_PHONE = new Field("UNION_CONTACT_PHONE", "XX_TENDER_LIST", "联合体联系电话（如有）");
            /// <summary>
			/// 投标人信息版本
			/// </summary>
			public readonly static Field BIDDER_INFO_VERSION = new Field("BIDDER_INFO_VERSION", "XX_TENDER_LIST", "投标人信息版本");
            /// <summary>
			/// 价款形式代码
			/// </summary>
			public readonly static Field PRICE_FORM_CODE = new Field("PRICE_FORM_CODE", "XX_TENDER_LIST", "价款形式代码");
            /// <summary>
			/// 费率或其它类型报价
			/// </summary>
			public readonly static Field OTHER_BID_PRICE = new Field("OTHER_BID_PRICE", "XX_TENDER_LIST", "费率或其它类型报价");
            /// <summary>
			/// 投标报价金额
			/// </summary>
			public readonly static Field BID_PRICE = new Field("BID_PRICE", "XX_TENDER_LIST", "投标报价金额");
            /// <summary>
			/// 投标报价币种
			/// </summary>
			public readonly static Field PRICE_CURRENCY = new Field("PRICE_CURRENCY", "XX_TENDER_LIST", "投标报价币种");
            /// <summary>
			/// 投标报价单位
			/// </summary>
			public readonly static Field PRICE_UNIT = new Field("PRICE_UNIT", "XX_TENDER_LIST", "投标报价单位");
            /// <summary>
			/// 投标工期
			/// </summary>
			public readonly static Field TIME_LIMIT = new Field("TIME_LIMIT", "XX_TENDER_LIST", "投标工期");
            /// <summary>
			/// 招标文件购买订单号
			/// </summary>
			public readonly static Field PURCHASE_ORDER_NUMBER = new Field("PURCHASE_ORDER_NUMBER", "XX_TENDER_LIST", "招标文件购买订单号");
            /// <summary>
			/// 投标人是否入围评审
			/// </summary>
			public readonly static Field IS_REVIEW_SHORTLISTED = new Field("IS_REVIEW_SHORTLISTED", "XX_TENDER_LIST", "投标人是否入围评审");
            /// <summary>
			/// 投标文件递交时间
			/// </summary>
			public readonly static Field CHECKIN_TIME = new Field("CHECKIN_TIME", "XX_TENDER_LIST", "投标文件递交时间");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "XX_TENDER_LIST", "交易系统标识码");
            /// <summary>
			/// 交易服务系统标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "XX_TENDER_LIST", "交易服务系统标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "XX_TENDER_LIST", "数据时间戳");
            /// <summary>
			/// 交易平台或发布工具标识码
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "XX_TENDER_LIST", "交易平台或发布工具标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "XX_TENDER_LIST", "公共服务平台标识码");
        }
        #endregion
	}
}