using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类JT_TENDER_FILE_CLARI_MODI。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("JT_TENDER_FILE_CLARI_MODI")]
    [Serializable]
    public partial class JT_TENDER_FILE_CLARI_MODI : JdEntity
    {
        #region Model
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private string _UNIFIED_DEAL_CODES;
		private string _DOC_NO;
		private string _DOC_NAME;
		private string _BID_QUALIFICATION;
		private DateTime? _BID_DOC_REFER_END_TIME;
		private decimal? _VALID_PERIOD;
		private string _BID_DOC_REFER_METHOD;
		private string _MARGIN_PAY_TYPE;
		private decimal? _MARGIN_AMOUNT;
		private string _MARGIN_CURRENCY;
		private string _MARGIN_AMOUNT_UNIT;
		private decimal? _CONTROL_PRICE;
		private string _CONTROL_PRICE_CURRENCY;
		private string _CONTROL_PRICE_UNIT;
		private string _EVALUATING_METHOD;
		private DateTime? _BID_OPEN_TIME;
		private string _BID_OPEN_PLACE;
		private string _BID_OPEN_TYPE;
		private string _QUAL_TYPE;
		private DateTime? _CLARIFY_TIME;
		private string _IS_POSTPONE;
		private DateTime? _POST_OPEN_TIME;
		private string _POST_OPEN_ADDRESS;
		private string _CLARIFY_CONTENT;
		private DateTime? _SUBMIT_TIME;
		private string _TRADE_PLATFORM_NAME;
		private string _TRADING_PLATFORM_ADDRESS;
		private string _CUSTOMER_SERVICE_PHONE;
		private string _QUAL_LEVEL;
		private string _URL;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private string _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private DateTime? _M_TM;
		private DateTime? _DATA_TIMESTAMP;
		private string _PRICE_FORM_CODE;
		private string _MARGIN_PERCENT;
		private decimal? _LIMIT_PRICE;
		private string _QUESTION_TYPE;
		private DateTime? _QUESTION_TIME;
		private string _ANSWER_TYPE;
		private string _ADJUST_OF_CONTRACT;
		private string _ADJUST_OF_SUPERVISION;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;
		private string _M_VERSION;
		private string _TEMPLATE_NO;

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
		public string UNIFIED_DEAL_CODES
		{
			get{ return _UNIFIED_DEAL_CODES; }
			set
			{
				this.OnPropertyValueChange(_.UNIFIED_DEAL_CODES, _UNIFIED_DEAL_CODES, value);
				this._UNIFIED_DEAL_CODES = value;
			}
		}
		/// <summary>
		/// 文件编号
		/// </summary>
		public string DOC_NO
		{
			get{ return _DOC_NO; }
			set
			{
				this.OnPropertyValueChange(_.DOC_NO, _DOC_NO, value);
				this._DOC_NO = value;
			}
		}
		/// <summary>
		/// 文件名称
		/// </summary>
		public string DOC_NAME
		{
			get{ return _DOC_NAME; }
			set
			{
				this.OnPropertyValueChange(_.DOC_NAME, _DOC_NAME, value);
				this._DOC_NAME = value;
			}
		}
		/// <summary>
		/// 投标资格
		/// </summary>
		public string BID_QUALIFICATION
		{
			get{ return _BID_QUALIFICATION; }
			set
			{
				this.OnPropertyValueChange(_.BID_QUALIFICATION, _BID_QUALIFICATION, value);
				this._BID_QUALIFICATION = value;
			}
		}
		/// <summary>
		/// 投标文件递交截止时间
		/// </summary>
		public DateTime? BID_DOC_REFER_END_TIME
		{
			get{ return _BID_DOC_REFER_END_TIME; }
			set
			{
				this.OnPropertyValueChange(_.BID_DOC_REFER_END_TIME, _BID_DOC_REFER_END_TIME, value);
				this._BID_DOC_REFER_END_TIME = value;
			}
		}
		/// <summary>
		/// 投标有效期
		/// </summary>
		public decimal? VALID_PERIOD
		{
			get{ return _VALID_PERIOD; }
			set
			{
				this.OnPropertyValueChange(_.VALID_PERIOD, _VALID_PERIOD, value);
				this._VALID_PERIOD = value;
			}
		}
		/// <summary>
		/// 投标文件递交方法
		/// </summary>
		public string BID_DOC_REFER_METHOD
		{
			get{ return _BID_DOC_REFER_METHOD; }
			set
			{
				this.OnPropertyValueChange(_.BID_DOC_REFER_METHOD, _BID_DOC_REFER_METHOD, value);
				this._BID_DOC_REFER_METHOD = value;
			}
		}
		/// <summary>
		/// 投标保证金缴纳方式
		/// </summary>
		public string MARGIN_PAY_TYPE
		{
			get{ return _MARGIN_PAY_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_PAY_TYPE, _MARGIN_PAY_TYPE, value);
				this._MARGIN_PAY_TYPE = value;
			}
		}
		/// <summary>
		/// 投标保证金金额
		/// </summary>
		public decimal? MARGIN_AMOUNT
		{
			get{ return _MARGIN_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_AMOUNT, _MARGIN_AMOUNT, value);
				this._MARGIN_AMOUNT = value;
			}
		}
		/// <summary>
		/// 投标保证金币种代码
		/// </summary>
		public string MARGIN_CURRENCY
		{
			get{ return _MARGIN_CURRENCY; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_CURRENCY, _MARGIN_CURRENCY, value);
				this._MARGIN_CURRENCY = value;
			}
		}
		/// <summary>
		/// 投标保证金单位
		/// </summary>
		public string MARGIN_AMOUNT_UNIT
		{
			get{ return _MARGIN_AMOUNT_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_AMOUNT_UNIT, _MARGIN_AMOUNT_UNIT, value);
				this._MARGIN_AMOUNT_UNIT = value;
			}
		}
		/// <summary>
		/// 控制价（最高限价）
		/// </summary>
		public decimal? CONTROL_PRICE
		{
			get{ return _CONTROL_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.CONTROL_PRICE, _CONTROL_PRICE, value);
				this._CONTROL_PRICE = value;
			}
		}
		/// <summary>
		/// 控制价币种代码
		/// </summary>
		public string CONTROL_PRICE_CURRENCY
		{
			get{ return _CONTROL_PRICE_CURRENCY; }
			set
			{
				this.OnPropertyValueChange(_.CONTROL_PRICE_CURRENCY, _CONTROL_PRICE_CURRENCY, value);
				this._CONTROL_PRICE_CURRENCY = value;
			}
		}
		/// <summary>
		/// 控制价单位
		/// </summary>
		public string CONTROL_PRICE_UNIT
		{
			get{ return _CONTROL_PRICE_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.CONTROL_PRICE_UNIT, _CONTROL_PRICE_UNIT, value);
				this._CONTROL_PRICE_UNIT = value;
			}
		}
		/// <summary>
		/// 评标办法
		/// </summary>
		public string EVALUATING_METHOD
		{
			get{ return _EVALUATING_METHOD; }
			set
			{
				this.OnPropertyValueChange(_.EVALUATING_METHOD, _EVALUATING_METHOD, value);
				this._EVALUATING_METHOD = value;
			}
		}
		/// <summary>
		/// 开标时间
		/// </summary>
		public DateTime? BID_OPEN_TIME
		{
			get{ return _BID_OPEN_TIME; }
			set
			{
				this.OnPropertyValueChange(_.BID_OPEN_TIME, _BID_OPEN_TIME, value);
				this._BID_OPEN_TIME = value;
			}
		}
		/// <summary>
		/// 开标地点
		/// </summary>
		public string BID_OPEN_PLACE
		{
			get{ return _BID_OPEN_PLACE; }
			set
			{
				this.OnPropertyValueChange(_.BID_OPEN_PLACE, _BID_OPEN_PLACE, value);
				this._BID_OPEN_PLACE = value;
			}
		}
		/// <summary>
		/// 开标方式
		/// </summary>
		public string BID_OPEN_TYPE
		{
			get{ return _BID_OPEN_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.BID_OPEN_TYPE, _BID_OPEN_TYPE, value);
				this._BID_OPEN_TYPE = value;
			}
		}
		/// <summary>
		/// 资格审查方式
		/// </summary>
		public string QUAL_TYPE
		{
			get{ return _QUAL_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.QUAL_TYPE, _QUAL_TYPE, value);
				this._QUAL_TYPE = value;
			}
		}
		/// <summary>
		/// 答疑澄清时间
		/// </summary>
		public DateTime? CLARIFY_TIME
		{
			get{ return _CLARIFY_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CLARIFY_TIME, _CLARIFY_TIME, value);
				this._CLARIFY_TIME = value;
			}
		}
		/// <summary>
		/// 是否延期
		/// </summary>
		public string IS_POSTPONE
		{
			get{ return _IS_POSTPONE; }
			set
			{
				this.OnPropertyValueChange(_.IS_POSTPONE, _IS_POSTPONE, value);
				this._IS_POSTPONE = value;
			}
		}
		/// <summary>
		/// 延期后开标时间
		/// </summary>
		public DateTime? POST_OPEN_TIME
		{
			get{ return _POST_OPEN_TIME; }
			set
			{
				this.OnPropertyValueChange(_.POST_OPEN_TIME, _POST_OPEN_TIME, value);
				this._POST_OPEN_TIME = value;
			}
		}
		/// <summary>
		/// 延期后开标地点
		/// </summary>
		public string POST_OPEN_ADDRESS
		{
			get{ return _POST_OPEN_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.POST_OPEN_ADDRESS, _POST_OPEN_ADDRESS, value);
				this._POST_OPEN_ADDRESS = value;
			}
		}
		/// <summary>
		/// 对文件澄清与修改的主要内容
		/// </summary>
		public string CLARIFY_CONTENT
		{
			get{ return _CLARIFY_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.CLARIFY_CONTENT, _CLARIFY_CONTENT, value);
				this._CLARIFY_CONTENT = value;
			}
		}
		/// <summary>
		/// 递交时间
		/// </summary>
		public DateTime? SUBMIT_TIME
		{
			get{ return _SUBMIT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.SUBMIT_TIME, _SUBMIT_TIME, value);
				this._SUBMIT_TIME = value;
			}
		}
		/// <summary>
		/// 交易平台名称
		/// </summary>
		public string TRADE_PLATFORM_NAME
		{
			get{ return _TRADE_PLATFORM_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TRADE_PLATFORM_NAME, _TRADE_PLATFORM_NAME, value);
				this._TRADE_PLATFORM_NAME = value;
			}
		}
		/// <summary>
		/// 招标投标交易平台网址
		/// </summary>
		public string TRADING_PLATFORM_ADDRESS
		{
			get{ return _TRADING_PLATFORM_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.TRADING_PLATFORM_ADDRESS, _TRADING_PLATFORM_ADDRESS, value);
				this._TRADING_PLATFORM_ADDRESS = value;
			}
		}
		/// <summary>
		/// 交易平台联系电话
		/// </summary>
		public string CUSTOMER_SERVICE_PHONE
		{
			get{ return _CUSTOMER_SERVICE_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.CUSTOMER_SERVICE_PHONE, _CUSTOMER_SERVICE_PHONE, value);
				this._CUSTOMER_SERVICE_PHONE = value;
			}
		}
		/// <summary>
		/// 资质名称及等级
		/// </summary>
		public string QUAL_LEVEL
		{
			get{ return _QUAL_LEVEL; }
			set
			{
				this.OnPropertyValueChange(_.QUAL_LEVEL, _QUAL_LEVEL, value);
				this._QUAL_LEVEL = value;
			}
		}
		/// <summary>
		/// 文件源URL
		/// </summary>
		public string URL
		{
			get{ return _URL; }
			set
			{
				this.OnPropertyValueChange(_.URL, _URL, value);
				this._URL = value;
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
		/// 数据自增长ID
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
		/// 数据DATA_KEY
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
		/// M_CREATEBY
		/// </summary>
		public string M_CREATEBY
		{
			get{ return _M_CREATEBY; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATEBY, _M_CREATEBY, value);
				this._M_CREATEBY = value;
			}
		}
		/// <summary>
		/// M_CREATE_TM
		/// </summary>
		public DateTime? M_CREATE_TM
		{
			get{ return _M_CREATE_TM; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATE_TM, _M_CREATE_TM, value);
				this._M_CREATE_TM = value;
			}
		}
		/// <summary>
		/// M_TM
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
		/// 投标保证金比率或其他
		/// </summary>
		public string MARGIN_PERCENT
		{
			get{ return _MARGIN_PERCENT; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_PERCENT, _MARGIN_PERCENT, value);
				this._MARGIN_PERCENT = value;
			}
		}
		/// <summary>
		/// 进入评标基准价计算的下限
		/// </summary>
		public decimal? LIMIT_PRICE
		{
			get{ return _LIMIT_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.LIMIT_PRICE, _LIMIT_PRICE, value);
				this._LIMIT_PRICE = value;
			}
		}
		/// <summary>
		/// 投标人要求澄清招标文件的方式
		/// </summary>
		public string QUESTION_TYPE
		{
			get{ return _QUESTION_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.QUESTION_TYPE, _QUESTION_TYPE, value);
				this._QUESTION_TYPE = value;
			}
		}
		/// <summary>
		/// 投标人要求澄清招标文件的截止时间
		/// </summary>
		public DateTime? QUESTION_TIME
		{
			get{ return _QUESTION_TIME; }
			set
			{
				this.OnPropertyValueChange(_.QUESTION_TIME, _QUESTION_TIME, value);
				this._QUESTION_TIME = value;
			}
		}
		/// <summary>
		/// 招标人澄清的方式
		/// </summary>
		public string ANSWER_TYPE
		{
			get{ return _ANSWER_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.ANSWER_TYPE, _ANSWER_TYPE, value);
				this._ANSWER_TYPE = value;
			}
		}
		/// <summary>
		/// 合同是否接受调价
		/// </summary>
		public string ADJUST_OF_CONTRACT
		{
			get{ return _ADJUST_OF_CONTRACT; }
			set
			{
				this.OnPropertyValueChange(_.ADJUST_OF_CONTRACT, _ADJUST_OF_CONTRACT, value);
				this._ADJUST_OF_CONTRACT = value;
			}
		}
		/// <summary>
		/// 监理服务费是否调整
		/// </summary>
		public string ADJUST_OF_SUPERVISION
		{
			get{ return _ADJUST_OF_SUPERVISION; }
			set
			{
				this.OnPropertyValueChange(_.ADJUST_OF_SUPERVISION, _ADJUST_OF_SUPERVISION, value);
				this._ADJUST_OF_SUPERVISION = value;
			}
		}
		/// <summary>
		/// 
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
		/// 
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
		/// 范本编号
		/// </summary>
		public string TEMPLATE_NO
		{
			get{ return _TEMPLATE_NO; }
			set
			{
				this.OnPropertyValueChange(_.TEMPLATE_NO, _TEMPLATE_NO, value);
				this._TEMPLATE_NO = value;
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
				_.TENDER_PROJECT_CODE,
				_.BID_SECTION_CODE,
				_.UNIFIED_DEAL_CODES,
				_.DOC_NO,
				_.DOC_NAME,
				_.BID_QUALIFICATION,
				_.BID_DOC_REFER_END_TIME,
				_.VALID_PERIOD,
				_.BID_DOC_REFER_METHOD,
				_.MARGIN_PAY_TYPE,
				_.MARGIN_AMOUNT,
				_.MARGIN_CURRENCY,
				_.MARGIN_AMOUNT_UNIT,
				_.CONTROL_PRICE,
				_.CONTROL_PRICE_CURRENCY,
				_.CONTROL_PRICE_UNIT,
				_.EVALUATING_METHOD,
				_.BID_OPEN_TIME,
				_.BID_OPEN_PLACE,
				_.BID_OPEN_TYPE,
				_.QUAL_TYPE,
				_.CLARIFY_TIME,
				_.IS_POSTPONE,
				_.POST_OPEN_TIME,
				_.POST_OPEN_ADDRESS,
				_.CLARIFY_CONTENT,
				_.SUBMIT_TIME,
				_.TRADE_PLATFORM_NAME,
				_.TRADING_PLATFORM_ADDRESS,
				_.CUSTOMER_SERVICE_PHONE,
				_.QUAL_LEVEL,
				_.URL,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.M_ID,
				_.DATA_KEY,
				_.M_DATA_SOURCE,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_TM,
				_.DATA_TIMESTAMP,
				_.PRICE_FORM_CODE,
				_.MARGIN_PERCENT,
				_.LIMIT_PRICE,
				_.QUESTION_TYPE,
				_.QUESTION_TIME,
				_.ANSWER_TYPE,
				_.ADJUST_OF_CONTRACT,
				_.ADJUST_OF_SUPERVISION,
				_.TRADE_PLAT,
				_.PUB_SERVICE_PLAT,
				_.M_VERSION,
				_.TEMPLATE_NO,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._TENDER_PROJECT_CODE,
				this._BID_SECTION_CODE,
				this._UNIFIED_DEAL_CODES,
				this._DOC_NO,
				this._DOC_NAME,
				this._BID_QUALIFICATION,
				this._BID_DOC_REFER_END_TIME,
				this._VALID_PERIOD,
				this._BID_DOC_REFER_METHOD,
				this._MARGIN_PAY_TYPE,
				this._MARGIN_AMOUNT,
				this._MARGIN_CURRENCY,
				this._MARGIN_AMOUNT_UNIT,
				this._CONTROL_PRICE,
				this._CONTROL_PRICE_CURRENCY,
				this._CONTROL_PRICE_UNIT,
				this._EVALUATING_METHOD,
				this._BID_OPEN_TIME,
				this._BID_OPEN_PLACE,
				this._BID_OPEN_TYPE,
				this._QUAL_TYPE,
				this._CLARIFY_TIME,
				this._IS_POSTPONE,
				this._POST_OPEN_TIME,
				this._POST_OPEN_ADDRESS,
				this._CLARIFY_CONTENT,
				this._SUBMIT_TIME,
				this._TRADE_PLATFORM_NAME,
				this._TRADING_PLATFORM_ADDRESS,
				this._CUSTOMER_SERVICE_PHONE,
				this._QUAL_LEVEL,
				this._URL,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._M_ID,
				this._DATA_KEY,
				this._M_DATA_SOURCE,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._M_TM,
				this._DATA_TIMESTAMP,
				this._PRICE_FORM_CODE,
				this._MARGIN_PERCENT,
				this._LIMIT_PRICE,
				this._QUESTION_TYPE,
				this._QUESTION_TIME,
				this._ANSWER_TYPE,
				this._ADJUST_OF_CONTRACT,
				this._ADJUST_OF_SUPERVISION,
				this._TRADE_PLAT,
				this._PUB_SERVICE_PLAT,
				this._M_VERSION,
				this._TEMPLATE_NO,
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
			public readonly static Field All = new Field("*", "JT_TENDER_FILE_CLARI_MODI");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "JT_TENDER_FILE_CLARI_MODI", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "JT_TENDER_FILE_CLARI_MODI", "标段（包）编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODES = new Field("UNIFIED_DEAL_CODES", "JT_TENDER_FILE_CLARI_MODI", "统一交易标识码");
            /// <summary>
			/// 文件编号
			/// </summary>
			public readonly static Field DOC_NO = new Field("DOC_NO", "JT_TENDER_FILE_CLARI_MODI", "文件编号");
            /// <summary>
			/// 文件名称
			/// </summary>
			public readonly static Field DOC_NAME = new Field("DOC_NAME", "JT_TENDER_FILE_CLARI_MODI", "文件名称");
            /// <summary>
			/// 投标资格
			/// </summary>
			public readonly static Field BID_QUALIFICATION = new Field("BID_QUALIFICATION", "JT_TENDER_FILE_CLARI_MODI",DbType.AnsiString, null, "投标资格");
            /// <summary>
			/// 投标文件递交截止时间
			/// </summary>
			public readonly static Field BID_DOC_REFER_END_TIME = new Field("BID_DOC_REFER_END_TIME", "JT_TENDER_FILE_CLARI_MODI", "投标文件递交截止时间");
            /// <summary>
			/// 投标有效期
			/// </summary>
			public readonly static Field VALID_PERIOD = new Field("VALID_PERIOD", "JT_TENDER_FILE_CLARI_MODI", "投标有效期");
            /// <summary>
			/// 投标文件递交方法
			/// </summary>
			public readonly static Field BID_DOC_REFER_METHOD = new Field("BID_DOC_REFER_METHOD", "JT_TENDER_FILE_CLARI_MODI",DbType.AnsiString, null, "投标文件递交方法");
            /// <summary>
			/// 投标保证金缴纳方式
			/// </summary>
			public readonly static Field MARGIN_PAY_TYPE = new Field("MARGIN_PAY_TYPE", "JT_TENDER_FILE_CLARI_MODI", "投标保证金缴纳方式");
            /// <summary>
			/// 投标保证金金额
			/// </summary>
			public readonly static Field MARGIN_AMOUNT = new Field("MARGIN_AMOUNT", "JT_TENDER_FILE_CLARI_MODI", "投标保证金金额");
            /// <summary>
			/// 投标保证金币种代码
			/// </summary>
			public readonly static Field MARGIN_CURRENCY = new Field("MARGIN_CURRENCY", "JT_TENDER_FILE_CLARI_MODI", "投标保证金币种代码");
            /// <summary>
			/// 投标保证金单位
			/// </summary>
			public readonly static Field MARGIN_AMOUNT_UNIT = new Field("MARGIN_AMOUNT_UNIT", "JT_TENDER_FILE_CLARI_MODI", "投标保证金单位");
            /// <summary>
			/// 控制价（最高限价）
			/// </summary>
			public readonly static Field CONTROL_PRICE = new Field("CONTROL_PRICE", "JT_TENDER_FILE_CLARI_MODI", "控制价（最高限价）");
            /// <summary>
			/// 控制价币种代码
			/// </summary>
			public readonly static Field CONTROL_PRICE_CURRENCY = new Field("CONTROL_PRICE_CURRENCY", "JT_TENDER_FILE_CLARI_MODI", "控制价币种代码");
            /// <summary>
			/// 控制价单位
			/// </summary>
			public readonly static Field CONTROL_PRICE_UNIT = new Field("CONTROL_PRICE_UNIT", "JT_TENDER_FILE_CLARI_MODI", "控制价单位");
            /// <summary>
			/// 评标办法
			/// </summary>
			public readonly static Field EVALUATING_METHOD = new Field("EVALUATING_METHOD", "JT_TENDER_FILE_CLARI_MODI",DbType.AnsiString, null, "评标办法");
            /// <summary>
			/// 开标时间
			/// </summary>
			public readonly static Field BID_OPEN_TIME = new Field("BID_OPEN_TIME", "JT_TENDER_FILE_CLARI_MODI", "开标时间");
            /// <summary>
			/// 开标地点
			/// </summary>
			public readonly static Field BID_OPEN_PLACE = new Field("BID_OPEN_PLACE", "JT_TENDER_FILE_CLARI_MODI", "开标地点");
            /// <summary>
			/// 开标方式
			/// </summary>
			public readonly static Field BID_OPEN_TYPE = new Field("BID_OPEN_TYPE", "JT_TENDER_FILE_CLARI_MODI",DbType.AnsiString, null, "开标方式");
            /// <summary>
			/// 资格审查方式
			/// </summary>
			public readonly static Field QUAL_TYPE = new Field("QUAL_TYPE", "JT_TENDER_FILE_CLARI_MODI", "资格审查方式");
            /// <summary>
			/// 答疑澄清时间
			/// </summary>
			public readonly static Field CLARIFY_TIME = new Field("CLARIFY_TIME", "JT_TENDER_FILE_CLARI_MODI", "答疑澄清时间");
            /// <summary>
			/// 是否延期
			/// </summary>
			public readonly static Field IS_POSTPONE = new Field("IS_POSTPONE", "JT_TENDER_FILE_CLARI_MODI", "是否延期");
            /// <summary>
			/// 延期后开标时间
			/// </summary>
			public readonly static Field POST_OPEN_TIME = new Field("POST_OPEN_TIME", "JT_TENDER_FILE_CLARI_MODI", "延期后开标时间");
            /// <summary>
			/// 延期后开标地点
			/// </summary>
			public readonly static Field POST_OPEN_ADDRESS = new Field("POST_OPEN_ADDRESS", "JT_TENDER_FILE_CLARI_MODI", "延期后开标地点");
            /// <summary>
			/// 对文件澄清与修改的主要内容
			/// </summary>
			public readonly static Field CLARIFY_CONTENT = new Field("CLARIFY_CONTENT", "JT_TENDER_FILE_CLARI_MODI",DbType.AnsiString, null, "对文件澄清与修改的主要内容");
            /// <summary>
			/// 递交时间
			/// </summary>
			public readonly static Field SUBMIT_TIME = new Field("SUBMIT_TIME", "JT_TENDER_FILE_CLARI_MODI", "递交时间");
            /// <summary>
			/// 交易平台名称
			/// </summary>
			public readonly static Field TRADE_PLATFORM_NAME = new Field("TRADE_PLATFORM_NAME", "JT_TENDER_FILE_CLARI_MODI", "交易平台名称");
            /// <summary>
			/// 招标投标交易平台网址
			/// </summary>
			public readonly static Field TRADING_PLATFORM_ADDRESS = new Field("TRADING_PLATFORM_ADDRESS", "JT_TENDER_FILE_CLARI_MODI", "招标投标交易平台网址");
            /// <summary>
			/// 交易平台联系电话
			/// </summary>
			public readonly static Field CUSTOMER_SERVICE_PHONE = new Field("CUSTOMER_SERVICE_PHONE", "JT_TENDER_FILE_CLARI_MODI", "交易平台联系电话");
            /// <summary>
			/// 资质名称及等级
			/// </summary>
			public readonly static Field QUAL_LEVEL = new Field("QUAL_LEVEL", "JT_TENDER_FILE_CLARI_MODI", "资质名称及等级");
            /// <summary>
			/// 文件源URL
			/// </summary>
			public readonly static Field URL = new Field("URL", "JT_TENDER_FILE_CLARI_MODI", "文件源URL");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "JT_TENDER_FILE_CLARI_MODI", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "JT_TENDER_FILE_CLARI_MODI", "公共服务平台标识码");
            /// <summary>
			/// 数据自增长ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "JT_TENDER_FILE_CLARI_MODI", "数据自增长ID");
            /// <summary>
			/// 数据DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "JT_TENDER_FILE_CLARI_MODI", "数据DATA_KEY");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "JT_TENDER_FILE_CLARI_MODI", "数据来源");
            /// <summary>
			/// M_CREATEBY
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "JT_TENDER_FILE_CLARI_MODI", "M_CREATEBY");
            /// <summary>
			/// M_CREATE_TM
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "JT_TENDER_FILE_CLARI_MODI", "M_CREATE_TM");
            /// <summary>
			/// M_TM
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "JT_TENDER_FILE_CLARI_MODI", "M_TM");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "JT_TENDER_FILE_CLARI_MODI", "数据时间戳");
            /// <summary>
			/// 价款形式代码
			/// </summary>
			public readonly static Field PRICE_FORM_CODE = new Field("PRICE_FORM_CODE", "JT_TENDER_FILE_CLARI_MODI", "价款形式代码");
            /// <summary>
			/// 投标保证金比率或其他
			/// </summary>
			public readonly static Field MARGIN_PERCENT = new Field("MARGIN_PERCENT", "JT_TENDER_FILE_CLARI_MODI", "投标保证金比率或其他");
            /// <summary>
			/// 进入评标基准价计算的下限
			/// </summary>
			public readonly static Field LIMIT_PRICE = new Field("LIMIT_PRICE", "JT_TENDER_FILE_CLARI_MODI", "进入评标基准价计算的下限");
            /// <summary>
			/// 投标人要求澄清招标文件的方式
			/// </summary>
			public readonly static Field QUESTION_TYPE = new Field("QUESTION_TYPE", "JT_TENDER_FILE_CLARI_MODI",DbType.AnsiString, null, "投标人要求澄清招标文件的方式");
            /// <summary>
			/// 投标人要求澄清招标文件的截止时间
			/// </summary>
			public readonly static Field QUESTION_TIME = new Field("QUESTION_TIME", "JT_TENDER_FILE_CLARI_MODI", "投标人要求澄清招标文件的截止时间");
            /// <summary>
			/// 招标人澄清的方式
			/// </summary>
			public readonly static Field ANSWER_TYPE = new Field("ANSWER_TYPE", "JT_TENDER_FILE_CLARI_MODI",DbType.AnsiString, null, "招标人澄清的方式");
            /// <summary>
			/// 合同是否接受调价
			/// </summary>
			public readonly static Field ADJUST_OF_CONTRACT = new Field("ADJUST_OF_CONTRACT", "JT_TENDER_FILE_CLARI_MODI", "合同是否接受调价");
            /// <summary>
			/// 监理服务费是否调整
			/// </summary>
			public readonly static Field ADJUST_OF_SUPERVISION = new Field("ADJUST_OF_SUPERVISION", "JT_TENDER_FILE_CLARI_MODI", "监理服务费是否调整");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "JT_TENDER_FILE_CLARI_MODI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "JT_TENDER_FILE_CLARI_MODI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "JT_TENDER_FILE_CLARI_MODI", "");
            /// <summary>
			/// 范本编号
			/// </summary>
			public readonly static Field TEMPLATE_NO = new Field("TEMPLATE_NO", "JT_TENDER_FILE_CLARI_MODI", "范本编号");
        }
        #endregion
	}
}