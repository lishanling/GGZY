using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类DEA_SEWAGE_PAID_TRANSFER_ANNO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("DEA_SEWAGE_PAID_TRANSFER_ANNO")]
    [Serializable]
    public partial class DEA_SEWAGE_PAID_TRANSFER_ANNO : FwEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_CREATOR;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _PROJECT_CODE;
		private string _NOTICE_NAME;
		private DateTime? _NOTICE_SEND_TIME;
		private string _UNIFIED_DEAL_CODES;
		private string _BID_NAME;
		private decimal? _BID_NUM;
		private string _BID_SOURCE;
		private decimal? _POLLUTION_RIGHTS_PERIOD;
		private decimal? _LISTING_PRICE;
		private decimal? _INITIAL_EXPENSE;
		private string _TRANSACTION_MODE;
		private DateTime? _NOTICE_START_TIME;
		private DateTime? _NOTICE_END_TIME;
		private DateTime? _TRADING_START_TIME;
		private string _NOTICE_CONTENT;
		private string _BID_REGION_CODE;
		private string _MARGIN_PAY_ACCOUNT;
		private decimal? _MARGIN_PAY_PROPORTION;
		private string _MARGIN_CURRENCY;
		private DateTime? _MARGIN_RECEIVE_END_TIME;
		private string _SELL_COMM_NAME;
		private string _SELL_ORG_CODE;
		private string _URL;
		private string _TRADING_CENTER_NAME;
		private string _TRADING_CENTER_CODE;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_VERSION;

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
		/// 
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
		/// 项目编号
		/// </summary>
		public string PROJECT_CODE
		{
			get{ return _PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_CODE, _PROJECT_CODE, value);
				this._PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 公告标题
		/// </summary>
		public string NOTICE_NAME
		{
			get{ return _NOTICE_NAME; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE_NAME, _NOTICE_NAME, value);
				this._NOTICE_NAME = value;
			}
		}
		/// <summary>
		/// 公告发布时间
		/// </summary>
		public DateTime? NOTICE_SEND_TIME
		{
			get{ return _NOTICE_SEND_TIME; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE_SEND_TIME, _NOTICE_SEND_TIME, value);
				this._NOTICE_SEND_TIME = value;
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
		/// 标的名称(sys_dic type=9541)
		/// </summary>
		public string BID_NAME
		{
			get{ return _BID_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BID_NAME, _BID_NAME, value);
				this._BID_NAME = value;
			}
		}
		/// <summary>
		/// 标的数量
		/// </summary>
		public decimal? BID_NUM
		{
			get{ return _BID_NUM; }
			set
			{
				this.OnPropertyValueChange(_.BID_NUM, _BID_NUM, value);
				this._BID_NUM = value;
			}
		}
		/// <summary>
		/// 标的来源(sys_dic type=9542)
		/// </summary>
		public string BID_SOURCE
		{
			get{ return _BID_SOURCE; }
			set
			{
				this.OnPropertyValueChange(_.BID_SOURCE, _BID_SOURCE, value);
				this._BID_SOURCE = value;
			}
		}
		/// <summary>
		/// 排污权期限
		/// </summary>
		public decimal? POLLUTION_RIGHTS_PERIOD
		{
			get{ return _POLLUTION_RIGHTS_PERIOD; }
			set
			{
				this.OnPropertyValueChange(_.POLLUTION_RIGHTS_PERIOD, _POLLUTION_RIGHTS_PERIOD, value);
				this._POLLUTION_RIGHTS_PERIOD = value;
			}
		}
		/// <summary>
		/// 挂牌价格
		/// </summary>
		public decimal? LISTING_PRICE
		{
			get{ return _LISTING_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.LISTING_PRICE, _LISTING_PRICE, value);
				this._LISTING_PRICE = value;
			}
		}
		/// <summary>
		/// 初始排污权有偿使用费
		/// </summary>
		public decimal? INITIAL_EXPENSE
		{
			get{ return _INITIAL_EXPENSE; }
			set
			{
				this.OnPropertyValueChange(_.INITIAL_EXPENSE, _INITIAL_EXPENSE, value);
				this._INITIAL_EXPENSE = value;
			}
		}
		/// <summary>
		/// 交易方式(sys_dic type=9543)
		/// </summary>
		public string TRANSACTION_MODE
		{
			get{ return _TRANSACTION_MODE; }
			set
			{
				this.OnPropertyValueChange(_.TRANSACTION_MODE, _TRANSACTION_MODE, value);
				this._TRANSACTION_MODE = value;
			}
		}
		/// <summary>
		/// 公告开始时间
		/// </summary>
		public DateTime? NOTICE_START_TIME
		{
			get{ return _NOTICE_START_TIME; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE_START_TIME, _NOTICE_START_TIME, value);
				this._NOTICE_START_TIME = value;
			}
		}
		/// <summary>
		/// 公告结束时间
		/// </summary>
		public DateTime? NOTICE_END_TIME
		{
			get{ return _NOTICE_END_TIME; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE_END_TIME, _NOTICE_END_TIME, value);
				this._NOTICE_END_TIME = value;
			}
		}
		/// <summary>
		/// 竞价时间
		/// </summary>
		public DateTime? TRADING_START_TIME
		{
			get{ return _TRADING_START_TIME; }
			set
			{
				this.OnPropertyValueChange(_.TRADING_START_TIME, _TRADING_START_TIME, value);
				this._TRADING_START_TIME = value;
			}
		}
		/// <summary>
		/// 公告内容
		/// </summary>
		public string NOTICE_CONTENT
		{
			get{ return _NOTICE_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE_CONTENT, _NOTICE_CONTENT, value);
				this._NOTICE_CONTENT = value;
			}
		}
		/// <summary>
		/// 标的所在行政区域代码,采用GB/T 2260-2007《中华人民共和国行政区划代码》的代码
		/// </summary>
		public string BID_REGION_CODE
		{
			get{ return _BID_REGION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BID_REGION_CODE, _BID_REGION_CODE, value);
				this._BID_REGION_CODE = value;
			}
		}
		/// <summary>
		/// 保证金缴纳账户
		/// </summary>
		public string MARGIN_PAY_ACCOUNT
		{
			get{ return _MARGIN_PAY_ACCOUNT; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_PAY_ACCOUNT, _MARGIN_PAY_ACCOUNT, value);
				this._MARGIN_PAY_ACCOUNT = value;
			}
		}
		/// <summary>
		/// 保证金缴纳比例
		/// </summary>
		public decimal? MARGIN_PAY_PROPORTION
		{
			get{ return _MARGIN_PAY_PROPORTION; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_PAY_PROPORTION, _MARGIN_PAY_PROPORTION, value);
				this._MARGIN_PAY_PROPORTION = value;
			}
		}
		/// <summary>
		/// 保证金币种代码,采用GB/T 12406-2008《表示货币和资金的代码》的数字码，例如，人民币是156
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
		/// 保证金缴纳截止时间
		/// </summary>
		public DateTime? MARGIN_RECEIVE_END_TIME
		{
			get{ return _MARGIN_RECEIVE_END_TIME; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_RECEIVE_END_TIME, _MARGIN_RECEIVE_END_TIME, value);
				this._MARGIN_RECEIVE_END_TIME = value;
			}
		}
		/// <summary>
		/// 出让方
		/// </summary>
		public string SELL_COMM_NAME
		{
			get{ return _SELL_COMM_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SELL_COMM_NAME, _SELL_COMM_NAME, value);
				this._SELL_COMM_NAME = value;
			}
		}
		/// <summary>
		/// 出让方统一社会信用代码,采用GB11714 -1997《全国组织机构代码编制规则》或GB 32100-2015 《法人和其他组织统一社会信用代码编码规则》或GB 11643－1999《公民身份号码》
		/// </summary>
		public string SELL_ORG_CODE
		{
			get{ return _SELL_ORG_CODE; }
			set
			{
				this.OnPropertyValueChange(_.SELL_ORG_CODE, _SELL_ORG_CODE, value);
				this._SELL_ORG_CODE = value;
			}
		}
		/// <summary>
		/// 公告源URL
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
		/// 交易中心名称
		/// </summary>
		public string TRADING_CENTER_NAME
		{
			get{ return _TRADING_CENTER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TRADING_CENTER_NAME, _TRADING_CENTER_NAME, value);
				this._TRADING_CENTER_NAME = value;
			}
		}
		/// <summary>
		/// 交易中心统一社会信用代码
		/// </summary>
		public string TRADING_CENTER_CODE
		{
			get{ return _TRADING_CENTER_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TRADING_CENTER_CODE, _TRADING_CENTER_CODE, value);
				this._TRADING_CENTER_CODE = value;
			}
		}
		/// <summary>
		/// 交易系统标识码,采用GB 32100-2015 《法人和其他组织统一社会信用代码编码规则》
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
		/// 公共服务平台标识码,采用GB 32100-2015 《法人和其他组织统一社会信用代码编码规则》
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
		/// 数据时间戳，采用组合码，编码长度为14位数时间戳，由省级服务平台生成
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
				_.M_ID,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_CREATOR,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.PROJECT_CODE,
				_.NOTICE_NAME,
				_.NOTICE_SEND_TIME,
				_.UNIFIED_DEAL_CODES,
				_.BID_NAME,
				_.BID_NUM,
				_.BID_SOURCE,
				_.POLLUTION_RIGHTS_PERIOD,
				_.LISTING_PRICE,
				_.INITIAL_EXPENSE,
				_.TRANSACTION_MODE,
				_.NOTICE_START_TIME,
				_.NOTICE_END_TIME,
				_.TRADING_START_TIME,
				_.NOTICE_CONTENT,
				_.BID_REGION_CODE,
				_.MARGIN_PAY_ACCOUNT,
				_.MARGIN_PAY_PROPORTION,
				_.MARGIN_CURRENCY,
				_.MARGIN_RECEIVE_END_TIME,
				_.SELL_COMM_NAME,
				_.SELL_ORG_CODE,
				_.URL,
				_.TRADING_CENTER_NAME,
				_.TRADING_CENTER_CODE,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_VERSION,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._M_ID,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_CREATOR,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._PROJECT_CODE,
				this._NOTICE_NAME,
				this._NOTICE_SEND_TIME,
				this._UNIFIED_DEAL_CODES,
				this._BID_NAME,
				this._BID_NUM,
				this._BID_SOURCE,
				this._POLLUTION_RIGHTS_PERIOD,
				this._LISTING_PRICE,
				this._INITIAL_EXPENSE,
				this._TRANSACTION_MODE,
				this._NOTICE_START_TIME,
				this._NOTICE_END_TIME,
				this._TRADING_START_TIME,
				this._NOTICE_CONTENT,
				this._BID_REGION_CODE,
				this._MARGIN_PAY_ACCOUNT,
				this._MARGIN_PAY_PROPORTION,
				this._MARGIN_CURRENCY,
				this._MARGIN_RECEIVE_END_TIME,
				this._SELL_COMM_NAME,
				this._SELL_ORG_CODE,
				this._URL,
				this._TRADING_CENTER_NAME,
				this._TRADING_CENTER_CODE,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
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
			public readonly static Field All = new Field("*", "DEA_SEWAGE_PAID_TRANSFER_ANNO");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATOR = new Field("M_CREATOR", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "项目编号");
            /// <summary>
			/// 公告标题
			/// </summary>
			public readonly static Field NOTICE_NAME = new Field("NOTICE_NAME", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "公告标题");
            /// <summary>
			/// 公告发布时间
			/// </summary>
			public readonly static Field NOTICE_SEND_TIME = new Field("NOTICE_SEND_TIME", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "公告发布时间");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODES = new Field("UNIFIED_DEAL_CODES", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "统一交易标识码");
            /// <summary>
			/// 标的名称(sys_dic type=9541)
			/// </summary>
			public readonly static Field BID_NAME = new Field("BID_NAME", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "标的名称(sys_dic type=9541)");
            /// <summary>
			/// 标的数量
			/// </summary>
			public readonly static Field BID_NUM = new Field("BID_NUM", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "标的数量");
            /// <summary>
			/// 标的来源(sys_dic type=9542)
			/// </summary>
			public readonly static Field BID_SOURCE = new Field("BID_SOURCE", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "标的来源(sys_dic type=9542)");
            /// <summary>
			/// 排污权期限
			/// </summary>
			public readonly static Field POLLUTION_RIGHTS_PERIOD = new Field("POLLUTION_RIGHTS_PERIOD", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "排污权期限");
            /// <summary>
			/// 挂牌价格
			/// </summary>
			public readonly static Field LISTING_PRICE = new Field("LISTING_PRICE", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "挂牌价格");
            /// <summary>
			/// 初始排污权有偿使用费
			/// </summary>
			public readonly static Field INITIAL_EXPENSE = new Field("INITIAL_EXPENSE", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "初始排污权有偿使用费");
            /// <summary>
			/// 交易方式(sys_dic type=9543)
			/// </summary>
			public readonly static Field TRANSACTION_MODE = new Field("TRANSACTION_MODE", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "交易方式(sys_dic type=9543)");
            /// <summary>
			/// 公告开始时间
			/// </summary>
			public readonly static Field NOTICE_START_TIME = new Field("NOTICE_START_TIME", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "公告开始时间");
            /// <summary>
			/// 公告结束时间
			/// </summary>
			public readonly static Field NOTICE_END_TIME = new Field("NOTICE_END_TIME", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "公告结束时间");
            /// <summary>
			/// 竞价时间
			/// </summary>
			public readonly static Field TRADING_START_TIME = new Field("TRADING_START_TIME", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "竞价时间");
            /// <summary>
			/// 公告内容
			/// </summary>
			public readonly static Field NOTICE_CONTENT = new Field("NOTICE_CONTENT", "DEA_SEWAGE_PAID_TRANSFER_ANNO",DbType.AnsiString, null, "公告内容");
            /// <summary>
			/// 标的所在行政区域代码,采用GB/T 2260-2007《中华人民共和国行政区划代码》的代码
			/// </summary>
			public readonly static Field BID_REGION_CODE = new Field("BID_REGION_CODE", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "标的所在行政区域代码,采用GB/T 2260-2007《中华人民共和国行政区划代码》的代码");
            /// <summary>
			/// 保证金缴纳账户
			/// </summary>
			public readonly static Field MARGIN_PAY_ACCOUNT = new Field("MARGIN_PAY_ACCOUNT", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "保证金缴纳账户");
            /// <summary>
			/// 保证金缴纳比例
			/// </summary>
			public readonly static Field MARGIN_PAY_PROPORTION = new Field("MARGIN_PAY_PROPORTION", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "保证金缴纳比例");
            /// <summary>
			/// 保证金币种代码,采用GB/T 12406-2008《表示货币和资金的代码》的数字码，例如，人民币是156
			/// </summary>
			public readonly static Field MARGIN_CURRENCY = new Field("MARGIN_CURRENCY", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "保证金币种代码,采用GB/T 12406-2008《表示货币和资金的代码》的数字码，例如，人民币是156");
            /// <summary>
			/// 保证金缴纳截止时间
			/// </summary>
			public readonly static Field MARGIN_RECEIVE_END_TIME = new Field("MARGIN_RECEIVE_END_TIME", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "保证金缴纳截止时间");
            /// <summary>
			/// 出让方
			/// </summary>
			public readonly static Field SELL_COMM_NAME = new Field("SELL_COMM_NAME", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "出让方");
            /// <summary>
			/// 出让方统一社会信用代码,采用GB11714 -1997《全国组织机构代码编制规则》或GB 32100-2015 《法人和其他组织统一社会信用代码编码规则》或GB 11643－1999《公民身份号码》
			/// </summary>
			public readonly static Field SELL_ORG_CODE = new Field("SELL_ORG_CODE", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "出让方统一社会信用代码,采用GB11714 -1997《全国组织机构代码编制规则》或GB 32100-2015 《法人和其他组织统一社会信用代码编码规则》或GB 11643－1999《公民身份号码》");
            /// <summary>
			/// 公告源URL
			/// </summary>
			public readonly static Field URL = new Field("URL", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "公告源URL");
            /// <summary>
			/// 交易中心名称
			/// </summary>
			public readonly static Field TRADING_CENTER_NAME = new Field("TRADING_CENTER_NAME", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "交易中心名称");
            /// <summary>
			/// 交易中心统一社会信用代码
			/// </summary>
			public readonly static Field TRADING_CENTER_CODE = new Field("TRADING_CENTER_CODE", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "交易中心统一社会信用代码");
            /// <summary>
			/// 交易系统标识码,采用GB 32100-2015 《法人和其他组织统一社会信用代码编码规则》
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "交易系统标识码,采用GB 32100-2015 《法人和其他组织统一社会信用代码编码规则》");
            /// <summary>
			/// 公共服务平台标识码,采用GB 32100-2015 《法人和其他组织统一社会信用代码编码规则》
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "公共服务平台标识码,采用GB 32100-2015 《法人和其他组织统一社会信用代码编码规则》");
            /// <summary>
			/// 数据时间戳，采用组合码，编码长度为14位数时间戳，由省级服务平台生成
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "数据时间戳，采用组合码，编码长度为14位数时间戳，由省级服务平台生成");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "DEA_SEWAGE_PAID_TRANSFER_ANNO", "");
        }
        #endregion
	}
}