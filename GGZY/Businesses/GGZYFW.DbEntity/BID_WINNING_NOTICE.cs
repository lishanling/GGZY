using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类BID_WINNING_NOTICE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("BID_WINNING_NOTICE")]
    [Serializable]
    public partial class BID_WINNING_NOTICE : FwEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _M_VERSION;
		private string _PROJECT_CODE;
		private string _TENDER_PROJECT_CODE;
		private string _TENDER_PROJECT_NAME;
		private string _BID_SECTION_CODES;
		private string _UNIFIED_DEAL_CODE;
		private string _WIN_NOTICE_CODE_ENTP;
		private string _WIN_NOTICE_CODE;
		private string _WIN_BIDDER_NAME;
		private string _WIN_BIDDER_CODE;
		private DateTime? _BID_TIME;
		private string _TENDER_NOTICE_CONTENT;
		private decimal? _TIME_LIMIT;
		private decimal? _BID_AMOUNT;
		private string _BID_CURRENCY;
		private string _PRICE_UNIT;
		private string _PRICE_FORM_CODE;
		private string _OTHER_BID_PRICE;
		private string _PROJECT_LEAD;
		private string _PROJECT_LEAD_ID;
		private string _PROJECT_LEAD_CERTITY_NO;
		private string _WIN_NOTICE_CONTENT;
		private DateTime? _WIN_NOTICE_SEND_TIME;
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
		/// 招标项目名称
		/// </summary>
		public string TENDER_PROJECT_NAME
		{
			get{ return _TENDER_PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_NAME, _TENDER_PROJECT_NAME, value);
				this._TENDER_PROJECT_NAME = value;
			}
		}
		/// <summary>
		/// 标段（包）编号
		/// </summary>
		public string BID_SECTION_CODES
		{
			get{ return _BID_SECTION_CODES; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_CODES, _BID_SECTION_CODES, value);
				this._BID_SECTION_CODES = value;
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
		/// 中标通知书编号（企业）
		/// </summary>
		public string WIN_NOTICE_CODE_ENTP
		{
			get{ return _WIN_NOTICE_CODE_ENTP; }
			set
			{
				this.OnPropertyValueChange(_.WIN_NOTICE_CODE_ENTP, _WIN_NOTICE_CODE_ENTP, value);
				this._WIN_NOTICE_CODE_ENTP = value;
			}
		}
		/// <summary>
		/// 中标通知书编号（主管部门）
		/// </summary>
		public string WIN_NOTICE_CODE
		{
			get{ return _WIN_NOTICE_CODE; }
			set
			{
				this.OnPropertyValueChange(_.WIN_NOTICE_CODE, _WIN_NOTICE_CODE, value);
				this._WIN_NOTICE_CODE = value;
			}
		}
		/// <summary>
		/// 中标人名称
		/// </summary>
		public string WIN_BIDDER_NAME
		{
			get{ return _WIN_BIDDER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.WIN_BIDDER_NAME, _WIN_BIDDER_NAME, value);
				this._WIN_BIDDER_NAME = value;
			}
		}
		/// <summary>
		/// 中标人统一社会信用代码
		/// </summary>
		public string WIN_BIDDER_CODE
		{
			get{ return _WIN_BIDDER_CODE; }
			set
			{
				this.OnPropertyValueChange(_.WIN_BIDDER_CODE, _WIN_BIDDER_CODE, value);
				this._WIN_BIDDER_CODE = value;
			}
		}
		/// <summary>
		/// 投标日期
		/// </summary>
		public DateTime? BID_TIME
		{
			get{ return _BID_TIME; }
			set
			{
				this.OnPropertyValueChange(_.BID_TIME, _BID_TIME, value);
				this._BID_TIME = value;
			}
		}
		/// <summary>
		/// 招标范围和内容
		/// </summary>
		public string TENDER_NOTICE_CONTENT
		{
			get{ return _TENDER_NOTICE_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_NOTICE_CONTENT, _TENDER_NOTICE_CONTENT, value);
				this._TENDER_NOTICE_CONTENT = value;
			}
		}
		/// <summary>
		/// 工期
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
		/// 中标价
		/// </summary>
		public decimal? BID_AMOUNT
		{
			get{ return _BID_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.BID_AMOUNT, _BID_AMOUNT, value);
				this._BID_AMOUNT = value;
			}
		}
		/// <summary>
		/// 价格币种代码
		/// </summary>
		public string BID_CURRENCY
		{
			get{ return _BID_CURRENCY; }
			set
			{
				this.OnPropertyValueChange(_.BID_CURRENCY, _BID_CURRENCY, value);
				this._BID_CURRENCY = value;
			}
		}
		/// <summary>
		/// 价格单位
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
		/// 费率或其它类型结果
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
		/// 项目负责人
		/// </summary>
		public string PROJECT_LEAD
		{
			get{ return _PROJECT_LEAD; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_LEAD, _PROJECT_LEAD, value);
				this._PROJECT_LEAD = value;
			}
		}
		/// <summary>
		/// 项目负责人身份证号码
		/// </summary>
		public string PROJECT_LEAD_ID
		{
			get{ return _PROJECT_LEAD_ID; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_LEAD_ID, _PROJECT_LEAD_ID, value);
				this._PROJECT_LEAD_ID = value;
			}
		}
		/// <summary>
		/// 项目负责人注册证书类别及注册证书号
		/// </summary>
		public string PROJECT_LEAD_CERTITY_NO
		{
			get{ return _PROJECT_LEAD_CERTITY_NO; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_LEAD_CERTITY_NO, _PROJECT_LEAD_CERTITY_NO, value);
				this._PROJECT_LEAD_CERTITY_NO = value;
			}
		}
		/// <summary>
		/// 中标通知书的文本内容
		/// </summary>
		public string WIN_NOTICE_CONTENT
		{
			get{ return _WIN_NOTICE_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.WIN_NOTICE_CONTENT, _WIN_NOTICE_CONTENT, value);
				this._WIN_NOTICE_CONTENT = value;
			}
		}
		/// <summary>
		/// 中标通知书发出日期
		/// </summary>
		public DateTime? WIN_NOTICE_SEND_TIME
		{
			get{ return _WIN_NOTICE_SEND_TIME; }
			set
			{
				this.OnPropertyValueChange(_.WIN_NOTICE_SEND_TIME, _WIN_NOTICE_SEND_TIME, value);
				this._WIN_NOTICE_SEND_TIME = value;
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
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_VERSION,
				_.PROJECT_CODE,
				_.TENDER_PROJECT_CODE,
				_.TENDER_PROJECT_NAME,
				_.BID_SECTION_CODES,
				_.UNIFIED_DEAL_CODE,
				_.WIN_NOTICE_CODE_ENTP,
				_.WIN_NOTICE_CODE,
				_.WIN_BIDDER_NAME,
				_.WIN_BIDDER_CODE,
				_.BID_TIME,
				_.TENDER_NOTICE_CONTENT,
				_.TIME_LIMIT,
				_.BID_AMOUNT,
				_.BID_CURRENCY,
				_.PRICE_UNIT,
				_.PRICE_FORM_CODE,
				_.OTHER_BID_PRICE,
				_.PROJECT_LEAD,
				_.PROJECT_LEAD_ID,
				_.PROJECT_LEAD_CERTITY_NO,
				_.WIN_NOTICE_CONTENT,
				_.WIN_NOTICE_SEND_TIME,
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
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_VERSION,
				this._PROJECT_CODE,
				this._TENDER_PROJECT_CODE,
				this._TENDER_PROJECT_NAME,
				this._BID_SECTION_CODES,
				this._UNIFIED_DEAL_CODE,
				this._WIN_NOTICE_CODE_ENTP,
				this._WIN_NOTICE_CODE,
				this._WIN_BIDDER_NAME,
				this._WIN_BIDDER_CODE,
				this._BID_TIME,
				this._TENDER_NOTICE_CONTENT,
				this._TIME_LIMIT,
				this._BID_AMOUNT,
				this._BID_CURRENCY,
				this._PRICE_UNIT,
				this._PRICE_FORM_CODE,
				this._OTHER_BID_PRICE,
				this._PROJECT_LEAD,
				this._PROJECT_LEAD_ID,
				this._PROJECT_LEAD_CERTITY_NO,
				this._WIN_NOTICE_CONTENT,
				this._WIN_NOTICE_SEND_TIME,
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
			public readonly static Field All = new Field("*", "BID_WINNING_NOTICE");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "BID_WINNING_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "BID_WINNING_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "BID_WINNING_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "BID_WINNING_NOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "BID_WINNING_NOTICE", "");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "BID_WINNING_NOTICE", "项目编号");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "BID_WINNING_NOTICE", "招标项目编号");
            /// <summary>
			/// 招标项目名称
			/// </summary>
			public readonly static Field TENDER_PROJECT_NAME = new Field("TENDER_PROJECT_NAME", "BID_WINNING_NOTICE", "招标项目名称");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODES = new Field("BID_SECTION_CODES", "BID_WINNING_NOTICE",DbType.AnsiString, null, "标段（包）编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "BID_WINNING_NOTICE", "统一交易标识码");
            /// <summary>
			/// 中标通知书编号（企业）
			/// </summary>
			public readonly static Field WIN_NOTICE_CODE_ENTP = new Field("WIN_NOTICE_CODE_ENTP", "BID_WINNING_NOTICE", "中标通知书编号（企业）");
            /// <summary>
			/// 中标通知书编号（主管部门）
			/// </summary>
			public readonly static Field WIN_NOTICE_CODE = new Field("WIN_NOTICE_CODE", "BID_WINNING_NOTICE", "中标通知书编号（主管部门）");
            /// <summary>
			/// 中标人名称
			/// </summary>
			public readonly static Field WIN_BIDDER_NAME = new Field("WIN_BIDDER_NAME", "BID_WINNING_NOTICE", "中标人名称");
            /// <summary>
			/// 中标人统一社会信用代码
			/// </summary>
			public readonly static Field WIN_BIDDER_CODE = new Field("WIN_BIDDER_CODE", "BID_WINNING_NOTICE", "中标人统一社会信用代码");
            /// <summary>
			/// 投标日期
			/// </summary>
			public readonly static Field BID_TIME = new Field("BID_TIME", "BID_WINNING_NOTICE", "投标日期");
            /// <summary>
			/// 招标范围和内容
			/// </summary>
			public readonly static Field TENDER_NOTICE_CONTENT = new Field("TENDER_NOTICE_CONTENT", "BID_WINNING_NOTICE",DbType.AnsiString, null, "招标范围和内容");
            /// <summary>
			/// 工期
			/// </summary>
			public readonly static Field TIME_LIMIT = new Field("TIME_LIMIT", "BID_WINNING_NOTICE", "工期");
            /// <summary>
			/// 中标价
			/// </summary>
			public readonly static Field BID_AMOUNT = new Field("BID_AMOUNT", "BID_WINNING_NOTICE", "中标价");
            /// <summary>
			/// 价格币种代码
			/// </summary>
			public readonly static Field BID_CURRENCY = new Field("BID_CURRENCY", "BID_WINNING_NOTICE", "价格币种代码");
            /// <summary>
			/// 价格单位
			/// </summary>
			public readonly static Field PRICE_UNIT = new Field("PRICE_UNIT", "BID_WINNING_NOTICE", "价格单位");
            /// <summary>
			/// 价款形式代码
			/// </summary>
			public readonly static Field PRICE_FORM_CODE = new Field("PRICE_FORM_CODE", "BID_WINNING_NOTICE", "价款形式代码");
            /// <summary>
			/// 费率或其它类型结果
			/// </summary>
			public readonly static Field OTHER_BID_PRICE = new Field("OTHER_BID_PRICE", "BID_WINNING_NOTICE",DbType.AnsiString, null, "费率或其它类型结果");
            /// <summary>
			/// 项目负责人
			/// </summary>
			public readonly static Field PROJECT_LEAD = new Field("PROJECT_LEAD", "BID_WINNING_NOTICE",DbType.AnsiString, null, "项目负责人");
            /// <summary>
			/// 项目负责人身份证号码
			/// </summary>
			public readonly static Field PROJECT_LEAD_ID = new Field("PROJECT_LEAD_ID", "BID_WINNING_NOTICE", "项目负责人身份证号码");
            /// <summary>
			/// 项目负责人注册证书类别及注册证书号
			/// </summary>
			public readonly static Field PROJECT_LEAD_CERTITY_NO = new Field("PROJECT_LEAD_CERTITY_NO", "BID_WINNING_NOTICE", "项目负责人注册证书类别及注册证书号");
            /// <summary>
			/// 中标通知书的文本内容
			/// </summary>
			public readonly static Field WIN_NOTICE_CONTENT = new Field("WIN_NOTICE_CONTENT", "BID_WINNING_NOTICE",DbType.AnsiString, null, "中标通知书的文本内容");
            /// <summary>
			/// 中标通知书发出日期
			/// </summary>
			public readonly static Field WIN_NOTICE_SEND_TIME = new Field("WIN_NOTICE_SEND_TIME", "BID_WINNING_NOTICE", "中标通知书发出日期");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "BID_WINNING_NOTICE", "交易系统标识码");
            /// <summary>
			/// 交易服务系统标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "BID_WINNING_NOTICE", "交易服务系统标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "BID_WINNING_NOTICE", "数据时间戳");
            /// <summary>
			/// 交易平台或发布工具标识码
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "BID_WINNING_NOTICE", "交易平台或发布工具标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "BID_WINNING_NOTICE", "公共服务平台标识码");
        }
        #endregion
	}
}