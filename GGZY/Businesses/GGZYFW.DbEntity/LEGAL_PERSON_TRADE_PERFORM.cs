using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类LEGAL_PERSON_TRADE_PERFORM。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("LEGAL_PERSON_TRADE_PERFORM")]
    [Serializable]
    public partial class LEGAL_PERSON_TRADE_PERFORM : FwEntity
    {
        #region Model
		private string _BIDDER_NO;
		private string _SECTION_NO;
		private string _BID_SECTION_CODE;
		private string _SECTION_NAME;
		private string _BID_SECTION_NAME;
		private string _TENDER_NO;
		private string _TENDER_NAME;
		private decimal? _BID_AMOUNT;
		private string _TRADE_TYPE;
		private string _CURRENCY;
		private string _MONEY_UNIT;
		private DateTime? _CONTRACT_SIGN_DATE;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_ID;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _M_VERSION;

		/// <summary>
		/// 主体代码
		/// </summary>
		public string BIDDER_NO
		{
			get{ return _BIDDER_NO; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_NO, _BIDDER_NO, value);
				this._BIDDER_NO = value;
			}
		}
		/// <summary>
		/// 招标项目编号
		/// </summary>
		public string SECTION_NO
		{
			get{ return _SECTION_NO; }
			set
			{
				this.OnPropertyValueChange(_.SECTION_NO, _SECTION_NO, value);
				this._SECTION_NO = value;
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
		/// 招标项目名称
		/// </summary>
		public string SECTION_NAME
		{
			get{ return _SECTION_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SECTION_NAME, _SECTION_NAME, value);
				this._SECTION_NAME = value;
			}
		}
		/// <summary>
		/// 标段（包）名称
		/// </summary>
		public string BID_SECTION_NAME
		{
			get{ return _BID_SECTION_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_NAME, _BID_SECTION_NAME, value);
				this._BID_SECTION_NAME = value;
			}
		}
		/// <summary>
		/// 招标人（采购人/出让人）代码
		/// </summary>
		public string TENDER_NO
		{
			get{ return _TENDER_NO; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_NO, _TENDER_NO, value);
				this._TENDER_NO = value;
			}
		}
		/// <summary>
		/// 招标人（采购人/出让人）名称
		/// </summary>
		public string TENDER_NAME
		{
			get{ return _TENDER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_NAME, _TENDER_NAME, value);
				this._TENDER_NAME = value;
			}
		}
		/// <summary>
		/// 中标（成交/竞得）金额
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
		/// 交易分类
		/// </summary>
		public string TRADE_TYPE
		{
			get{ return _TRADE_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TRADE_TYPE, _TRADE_TYPE, value);
				this._TRADE_TYPE = value;
			}
		}
		/// <summary>
		/// 金额币种代码
		/// </summary>
		public string CURRENCY
		{
			get{ return _CURRENCY; }
			set
			{
				this.OnPropertyValueChange(_.CURRENCY, _CURRENCY, value);
				this._CURRENCY = value;
			}
		}
		/// <summary>
		/// 金额单位
		/// </summary>
		public string MONEY_UNIT
		{
			get{ return _MONEY_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.MONEY_UNIT, _MONEY_UNIT, value);
				this._MONEY_UNIT = value;
			}
		}
		/// <summary>
		/// 合同签署时间
		/// </summary>
		public DateTime? CONTRACT_SIGN_DATE
		{
			get{ return _CONTRACT_SIGN_DATE; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_SIGN_DATE, _CONTRACT_SIGN_DATE, value);
				this._CONTRACT_SIGN_DATE = value;
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
				_.BIDDER_NO,
				_.SECTION_NO,
				_.BID_SECTION_CODE,
				_.SECTION_NAME,
				_.BID_SECTION_NAME,
				_.TENDER_NO,
				_.TENDER_NAME,
				_.BID_AMOUNT,
				_.TRADE_TYPE,
				_.CURRENCY,
				_.MONEY_UNIT,
				_.CONTRACT_SIGN_DATE,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_ID,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_VERSION,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._BIDDER_NO,
				this._SECTION_NO,
				this._BID_SECTION_CODE,
				this._SECTION_NAME,
				this._BID_SECTION_NAME,
				this._TENDER_NO,
				this._TENDER_NAME,
				this._BID_AMOUNT,
				this._TRADE_TYPE,
				this._CURRENCY,
				this._MONEY_UNIT,
				this._CONTRACT_SIGN_DATE,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_ID,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
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
			public readonly static Field All = new Field("*", "LEGAL_PERSON_TRADE_PERFORM");
            /// <summary>
			/// 主体代码
			/// </summary>
			public readonly static Field BIDDER_NO = new Field("BIDDER_NO", "LEGAL_PERSON_TRADE_PERFORM", "主体代码");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field SECTION_NO = new Field("SECTION_NO", "LEGAL_PERSON_TRADE_PERFORM", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "LEGAL_PERSON_TRADE_PERFORM", "标段（包）编号");
            /// <summary>
			/// 招标项目名称
			/// </summary>
			public readonly static Field SECTION_NAME = new Field("SECTION_NAME", "LEGAL_PERSON_TRADE_PERFORM", "招标项目名称");
            /// <summary>
			/// 标段（包）名称
			/// </summary>
			public readonly static Field BID_SECTION_NAME = new Field("BID_SECTION_NAME", "LEGAL_PERSON_TRADE_PERFORM", "标段（包）名称");
            /// <summary>
			/// 招标人（采购人/出让人）代码
			/// </summary>
			public readonly static Field TENDER_NO = new Field("TENDER_NO", "LEGAL_PERSON_TRADE_PERFORM", "招标人（采购人/出让人）代码");
            /// <summary>
			/// 招标人（采购人/出让人）名称
			/// </summary>
			public readonly static Field TENDER_NAME = new Field("TENDER_NAME", "LEGAL_PERSON_TRADE_PERFORM", "招标人（采购人/出让人）名称");
            /// <summary>
			/// 中标（成交/竞得）金额
			/// </summary>
			public readonly static Field BID_AMOUNT = new Field("BID_AMOUNT", "LEGAL_PERSON_TRADE_PERFORM", "中标（成交/竞得）金额");
            /// <summary>
			/// 交易分类
			/// </summary>
			public readonly static Field TRADE_TYPE = new Field("TRADE_TYPE", "LEGAL_PERSON_TRADE_PERFORM", "交易分类");
            /// <summary>
			/// 金额币种代码
			/// </summary>
			public readonly static Field CURRENCY = new Field("CURRENCY", "LEGAL_PERSON_TRADE_PERFORM", "金额币种代码");
            /// <summary>
			/// 金额单位
			/// </summary>
			public readonly static Field MONEY_UNIT = new Field("MONEY_UNIT", "LEGAL_PERSON_TRADE_PERFORM", "金额单位");
            /// <summary>
			/// 合同签署时间
			/// </summary>
			public readonly static Field CONTRACT_SIGN_DATE = new Field("CONTRACT_SIGN_DATE", "LEGAL_PERSON_TRADE_PERFORM", "合同签署时间");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "LEGAL_PERSON_TRADE_PERFORM", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "LEGAL_PERSON_TRADE_PERFORM", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "LEGAL_PERSON_TRADE_PERFORM", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "LEGAL_PERSON_TRADE_PERFORM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "LEGAL_PERSON_TRADE_PERFORM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "LEGAL_PERSON_TRADE_PERFORM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "LEGAL_PERSON_TRADE_PERFORM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "LEGAL_PERSON_TRADE_PERFORM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "LEGAL_PERSON_TRADE_PERFORM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "LEGAL_PERSON_TRADE_PERFORM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "LEGAL_PERSON_TRADE_PERFORM", "");
        }
        #endregion
	}
}