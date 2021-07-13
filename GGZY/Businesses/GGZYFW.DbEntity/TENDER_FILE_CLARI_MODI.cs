using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类TENDER_FILE_CLARI_MODI。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TENDER_FILE_CLARI_MODI")]
    [Serializable]
    public partial class TENDER_FILE_CLARI_MODI : FwEntity
    {
        #region Model
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private string _UNIFIED_DEAL_CODES;
		private string _DOC_NO;
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
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _DOC_NAME;
		private string _URL;
		private decimal? _M_ID;
		private decimal? _M_CREATOR;
		private string _M_ATT_TENDER_FILE;
		private string _M_ATT_TENDER_FILE_ATTACHS;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _M_MONEY_UPDATE;
		private string _PRICE_FORM_CODE;
		private string _MARGIN_PERCENT;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;
		private string _M_VERSION;

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
		/// 控制价（最高限价）（如有）
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
		/// 控制价币种代码（如有）
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
		/// 控制价单位（如有）
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
		/// 
		/// </summary>
		public string M_KEY
		{
			get{ return _M_KEY; }
			set
			{
				this.OnPropertyValueChange(_.M_KEY, _M_KEY, value);
				this._M_KEY = value;
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
		/// 创建人
		/// </summary>
		public decimal? M_CREATOR
		{
			get{ return _M_CREATOR; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATOR, _M_CREATOR, value);
				this._M_CREATOR = value;
			}
		}
		/// <summary>
		/// ????
		/// </summary>
		public string M_ATT_TENDER_FILE
		{
			get{ return _M_ATT_TENDER_FILE; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_TENDER_FILE, _M_ATT_TENDER_FILE, value);
				this._M_ATT_TENDER_FILE = value;
			}
		}
		/// <summary>
		/// ??????
		/// </summary>
		public string M_ATT_TENDER_FILE_ATTACHS
		{
			get{ return _M_ATT_TENDER_FILE_ATTACHS; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_TENDER_FILE_ATTACHS, _M_ATT_TENDER_FILE_ATTACHS, value);
				this._M_ATT_TENDER_FILE_ATTACHS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? M_IS_HISTORY
		{
			get{ return _M_IS_HISTORY; }
			set
			{
				this.OnPropertyValueChange(_.M_IS_HISTORY, _M_IS_HISTORY, value);
				this._M_IS_HISTORY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? M_CREATEBY
		{
			get{ return _M_CREATEBY; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATEBY, _M_CREATEBY, value);
				this._M_CREATEBY = value;
			}
		}
		/// <summary>
		/// 
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
		/// 标注金额单位是否被更新过，1表示更新过
		/// </summary>
		public string M_MONEY_UPDATE
		{
			get{ return _M_MONEY_UPDATE; }
			set
			{
				this.OnPropertyValueChange(_.M_MONEY_UPDATE, _M_MONEY_UPDATE, value);
				this._M_MONEY_UPDATE = value;
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
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.DOC_NAME,
				_.URL,
				_.M_ID,
				_.M_CREATOR,
				_.M_ATT_TENDER_FILE,
				_.M_ATT_TENDER_FILE_ATTACHS,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_MONEY_UPDATE,
				_.PRICE_FORM_CODE,
				_.MARGIN_PERCENT,
				_.TRADE_PLAT,
				_.PUB_SERVICE_PLAT,
				_.M_VERSION,
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
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._DOC_NAME,
				this._URL,
				this._M_ID,
				this._M_CREATOR,
				this._M_ATT_TENDER_FILE,
				this._M_ATT_TENDER_FILE_ATTACHS,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._M_MONEY_UPDATE,
				this._PRICE_FORM_CODE,
				this._MARGIN_PERCENT,
				this._TRADE_PLAT,
				this._PUB_SERVICE_PLAT,
				this._M_VERSION,
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
			public readonly static Field All = new Field("*", "TENDER_FILE_CLARI_MODI");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "TENDER_FILE_CLARI_MODI", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "TENDER_FILE_CLARI_MODI", "标段（包）编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODES = new Field("UNIFIED_DEAL_CODES", "TENDER_FILE_CLARI_MODI", "统一交易标识码");
            /// <summary>
			/// 文件编号
			/// </summary>
			public readonly static Field DOC_NO = new Field("DOC_NO", "TENDER_FILE_CLARI_MODI", "文件编号");
            /// <summary>
			/// 投标资格
			/// </summary>
			public readonly static Field BID_QUALIFICATION = new Field("BID_QUALIFICATION", "TENDER_FILE_CLARI_MODI",DbType.AnsiString, null, "投标资格");
            /// <summary>
			/// 投标文件递交截止时间
			/// </summary>
			public readonly static Field BID_DOC_REFER_END_TIME = new Field("BID_DOC_REFER_END_TIME", "TENDER_FILE_CLARI_MODI", "投标文件递交截止时间");
            /// <summary>
			/// 投标有效期
			/// </summary>
			public readonly static Field VALID_PERIOD = new Field("VALID_PERIOD", "TENDER_FILE_CLARI_MODI", "投标有效期");
            /// <summary>
			/// 投标文件递交方法
			/// </summary>
			public readonly static Field BID_DOC_REFER_METHOD = new Field("BID_DOC_REFER_METHOD", "TENDER_FILE_CLARI_MODI",DbType.AnsiString, null, "投标文件递交方法");
            /// <summary>
			/// 投标保证金缴纳方式
			/// </summary>
			public readonly static Field MARGIN_PAY_TYPE = new Field("MARGIN_PAY_TYPE", "TENDER_FILE_CLARI_MODI", "投标保证金缴纳方式");
            /// <summary>
			/// 投标保证金金额
			/// </summary>
			public readonly static Field MARGIN_AMOUNT = new Field("MARGIN_AMOUNT", "TENDER_FILE_CLARI_MODI", "投标保证金金额");
            /// <summary>
			/// 投标保证金币种代码
			/// </summary>
			public readonly static Field MARGIN_CURRENCY = new Field("MARGIN_CURRENCY", "TENDER_FILE_CLARI_MODI", "投标保证金币种代码");
            /// <summary>
			/// 投标保证金单位
			/// </summary>
			public readonly static Field MARGIN_AMOUNT_UNIT = new Field("MARGIN_AMOUNT_UNIT", "TENDER_FILE_CLARI_MODI", "投标保证金单位");
            /// <summary>
			/// 控制价（最高限价）（如有）
			/// </summary>
			public readonly static Field CONTROL_PRICE = new Field("CONTROL_PRICE", "TENDER_FILE_CLARI_MODI", "控制价（最高限价）（如有）");
            /// <summary>
			/// 控制价币种代码（如有）
			/// </summary>
			public readonly static Field CONTROL_PRICE_CURRENCY = new Field("CONTROL_PRICE_CURRENCY", "TENDER_FILE_CLARI_MODI", "控制价币种代码（如有）");
            /// <summary>
			/// 控制价单位（如有）
			/// </summary>
			public readonly static Field CONTROL_PRICE_UNIT = new Field("CONTROL_PRICE_UNIT", "TENDER_FILE_CLARI_MODI", "控制价单位（如有）");
            /// <summary>
			/// 评标办法
			/// </summary>
			public readonly static Field EVALUATING_METHOD = new Field("EVALUATING_METHOD", "TENDER_FILE_CLARI_MODI",DbType.AnsiString, null, "评标办法");
            /// <summary>
			/// 开标时间
			/// </summary>
			public readonly static Field BID_OPEN_TIME = new Field("BID_OPEN_TIME", "TENDER_FILE_CLARI_MODI", "开标时间");
            /// <summary>
			/// 开标地点
			/// </summary>
			public readonly static Field BID_OPEN_PLACE = new Field("BID_OPEN_PLACE", "TENDER_FILE_CLARI_MODI", "开标地点");
            /// <summary>
			/// 开标方式
			/// </summary>
			public readonly static Field BID_OPEN_TYPE = new Field("BID_OPEN_TYPE", "TENDER_FILE_CLARI_MODI",DbType.AnsiString, null, "开标方式");
            /// <summary>
			/// 资格审查方式
			/// </summary>
			public readonly static Field QUAL_TYPE = new Field("QUAL_TYPE", "TENDER_FILE_CLARI_MODI", "资格审查方式");
            /// <summary>
			/// 答疑澄清时间
			/// </summary>
			public readonly static Field CLARIFY_TIME = new Field("CLARIFY_TIME", "TENDER_FILE_CLARI_MODI", "答疑澄清时间");
            /// <summary>
			/// 是否延期
			/// </summary>
			public readonly static Field IS_POSTPONE = new Field("IS_POSTPONE", "TENDER_FILE_CLARI_MODI", "是否延期");
            /// <summary>
			/// 延期后开标时间
			/// </summary>
			public readonly static Field POST_OPEN_TIME = new Field("POST_OPEN_TIME", "TENDER_FILE_CLARI_MODI", "延期后开标时间");
            /// <summary>
			/// 延期后开标地点
			/// </summary>
			public readonly static Field POST_OPEN_ADDRESS = new Field("POST_OPEN_ADDRESS", "TENDER_FILE_CLARI_MODI", "延期后开标地点");
            /// <summary>
			/// 对文件澄清与修改的主要内容
			/// </summary>
			public readonly static Field CLARIFY_CONTENT = new Field("CLARIFY_CONTENT", "TENDER_FILE_CLARI_MODI",DbType.AnsiString, null, "对文件澄清与修改的主要内容");
            /// <summary>
			/// 递交时间
			/// </summary>
			public readonly static Field SUBMIT_TIME = new Field("SUBMIT_TIME", "TENDER_FILE_CLARI_MODI", "递交时间");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "TENDER_FILE_CLARI_MODI", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "TENDER_FILE_CLARI_MODI", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "TENDER_FILE_CLARI_MODI", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "TENDER_FILE_CLARI_MODI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "TENDER_FILE_CLARI_MODI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "TENDER_FILE_CLARI_MODI", "");
            /// <summary>
			/// 文件名称
			/// </summary>
			public readonly static Field DOC_NAME = new Field("DOC_NAME", "TENDER_FILE_CLARI_MODI", "文件名称");
            /// <summary>
			/// 文件源URL
			/// </summary>
			public readonly static Field URL = new Field("URL", "TENDER_FILE_CLARI_MODI", "文件源URL");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "TENDER_FILE_CLARI_MODI", "");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field M_CREATOR = new Field("M_CREATOR", "TENDER_FILE_CLARI_MODI", "创建人");
            /// <summary>
			/// ????
			/// </summary>
			public readonly static Field M_ATT_TENDER_FILE = new Field("M_ATT_TENDER_FILE", "TENDER_FILE_CLARI_MODI", "????");
            /// <summary>
			/// ??????
			/// </summary>
			public readonly static Field M_ATT_TENDER_FILE_ATTACHS = new Field("M_ATT_TENDER_FILE_ATTACHS", "TENDER_FILE_CLARI_MODI", "??????");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "TENDER_FILE_CLARI_MODI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "TENDER_FILE_CLARI_MODI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "TENDER_FILE_CLARI_MODI", "");
            /// <summary>
			/// 标注金额单位是否被更新过，1表示更新过
			/// </summary>
			public readonly static Field M_MONEY_UPDATE = new Field("M_MONEY_UPDATE", "TENDER_FILE_CLARI_MODI", "标注金额单位是否被更新过，1表示更新过");
            /// <summary>
			/// 价款形式代码
			/// </summary>
			public readonly static Field PRICE_FORM_CODE = new Field("PRICE_FORM_CODE", "TENDER_FILE_CLARI_MODI", "价款形式代码");
            /// <summary>
			/// 投标保证金比率或其他
			/// </summary>
			public readonly static Field MARGIN_PERCENT = new Field("MARGIN_PERCENT", "TENDER_FILE_CLARI_MODI", "投标保证金比率或其他");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "TENDER_FILE_CLARI_MODI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "TENDER_FILE_CLARI_MODI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "TENDER_FILE_CLARI_MODI", "");
        }
        #endregion
	}
}