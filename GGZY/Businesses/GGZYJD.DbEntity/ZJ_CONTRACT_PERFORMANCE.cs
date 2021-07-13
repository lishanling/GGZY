using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类ZJ_CONTRACT_PERFORMANCE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJ_CONTRACT_PERFORMANCE")]
    [Serializable]
    public partial class ZJ_CONTRACT_PERFORMANCE : JdEntity
    {
        #region Model
		private string _BID_SECTION_CODE;
		private string _CONTRACT_RECORD_CODE;
		private string _CONTRACT_CODE;
		private string _UNIFIED_DEAL_CODE;
		private string _TENDERER_NAME;
		private string _TENDER_CODE;
		private string _BIDDER_NAME;
		private string _BIDDER_CODE;
		private decimal? _CONTRACT_PRICE;
		private decimal? _SETTLE_PRICE;
		private string _PRICE_CURRENCY;
		private string _PRICE_UNIT;
		private string _CONTRACT_CONTENT;
		private decimal? _LIMITE_TIME;
		private string _QUALITY_REQUIRE;
		private string _PERFORM_CHANGE_CONTENT;
		private DateTime? _FINISH_TIME;
		private decimal? _ACTUALLY_PERIOD;
		private string _PERFORM_INFO;
		private DateTime? _SUBMIT_TIME;
		private DateTime? _CONTRACT_SIGN_TIME;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private string _M_CREATEBY;
		private DateTime? _M_TM;
		private DateTime? _M_CREATE_TM;
		private string _TENDER_PROJECT_CODE;
		private string _CONTRACT_NAME;
		private string _PRICE_FORM_CODE;
		private string _OTHER_CONTRACT_PRICE;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;
		private string _M_VERSION;

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
		/// 合同备案编号
		/// </summary>
		public string CONTRACT_RECORD_CODE
		{
			get{ return _CONTRACT_RECORD_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_RECORD_CODE, _CONTRACT_RECORD_CODE, value);
				this._CONTRACT_RECORD_CODE = value;
			}
		}
		/// <summary>
		/// 合同编号
		/// </summary>
		public string CONTRACT_CODE
		{
			get{ return _CONTRACT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_CODE, _CONTRACT_CODE, value);
				this._CONTRACT_CODE = value;
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
		/// 招标人名称
		/// </summary>
		public string TENDERER_NAME
		{
			get{ return _TENDERER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_NAME, _TENDERER_NAME, value);
				this._TENDERER_NAME = value;
			}
		}
		/// <summary>
		/// 招标人代码
		/// </summary>
		public string TENDER_CODE
		{
			get{ return _TENDER_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_CODE, _TENDER_CODE, value);
				this._TENDER_CODE = value;
			}
		}
		/// <summary>
		/// 中标人名称
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
		/// 中标人代码
		/// </summary>
		public string BIDDER_CODE
		{
			get{ return _BIDDER_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_CODE, _BIDDER_CODE, value);
				this._BIDDER_CODE = value;
			}
		}
		/// <summary>
		/// 合同金额
		/// </summary>
		public decimal? CONTRACT_PRICE
		{
			get{ return _CONTRACT_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_PRICE, _CONTRACT_PRICE, value);
				this._CONTRACT_PRICE = value;
			}
		}
		/// <summary>
		/// 合同结算金额
		/// </summary>
		public decimal? SETTLE_PRICE
		{
			get{ return _SETTLE_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.SETTLE_PRICE, _SETTLE_PRICE, value);
				this._SETTLE_PRICE = value;
			}
		}
		/// <summary>
		/// 金额币种代码
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
		/// 金额单位
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
		/// 合同主要内容
		/// </summary>
		public string CONTRACT_CONTENT
		{
			get{ return _CONTRACT_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_CONTENT, _CONTRACT_CONTENT, value);
				this._CONTRACT_CONTENT = value;
			}
		}
		/// <summary>
		/// 合同期限
		/// </summary>
		public decimal? LIMITE_TIME
		{
			get{ return _LIMITE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.LIMITE_TIME, _LIMITE_TIME, value);
				this._LIMITE_TIME = value;
			}
		}
		/// <summary>
		/// 质量要求
		/// </summary>
		public string QUALITY_REQUIRE
		{
			get{ return _QUALITY_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.QUALITY_REQUIRE, _QUALITY_REQUIRE, value);
				this._QUALITY_REQUIRE = value;
			}
		}
		/// <summary>
		/// 履约变更内容
		/// </summary>
		public string PERFORM_CHANGE_CONTENT
		{
			get{ return _PERFORM_CHANGE_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.PERFORM_CHANGE_CONTENT, _PERFORM_CHANGE_CONTENT, value);
				this._PERFORM_CHANGE_CONTENT = value;
			}
		}
		/// <summary>
		/// 合同完成时间
		/// </summary>
		public DateTime? FINISH_TIME
		{
			get{ return _FINISH_TIME; }
			set
			{
				this.OnPropertyValueChange(_.FINISH_TIME, _FINISH_TIME, value);
				this._FINISH_TIME = value;
			}
		}
		/// <summary>
		/// 实际履约期限
		/// </summary>
		public decimal? ACTUALLY_PERIOD
		{
			get{ return _ACTUALLY_PERIOD; }
			set
			{
				this.OnPropertyValueChange(_.ACTUALLY_PERIOD, _ACTUALLY_PERIOD, value);
				this._ACTUALLY_PERIOD = value;
			}
		}
		/// <summary>
		/// 履约信息
		/// </summary>
		public string PERFORM_INFO
		{
			get{ return _PERFORM_INFO; }
			set
			{
				this.OnPropertyValueChange(_.PERFORM_INFO, _PERFORM_INFO, value);
				this._PERFORM_INFO = value;
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
		/// 合同签署时间
		/// </summary>
		public DateTime? CONTRACT_SIGN_TIME
		{
			get{ return _CONTRACT_SIGN_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_SIGN_TIME, _CONTRACT_SIGN_TIME, value);
				this._CONTRACT_SIGN_TIME = value;
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
		/// 合同名称
		/// </summary>
		public string CONTRACT_NAME
		{
			get{ return _CONTRACT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_NAME, _CONTRACT_NAME, value);
				this._CONTRACT_NAME = value;
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
		/// 其它形式合同报价
		/// </summary>
		public string OTHER_CONTRACT_PRICE
		{
			get{ return _OTHER_CONTRACT_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_CONTRACT_PRICE, _OTHER_CONTRACT_PRICE, value);
				this._OTHER_CONTRACT_PRICE = value;
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
				_.BID_SECTION_CODE,
				_.CONTRACT_RECORD_CODE,
				_.CONTRACT_CODE,
				_.UNIFIED_DEAL_CODE,
				_.TENDERER_NAME,
				_.TENDER_CODE,
				_.BIDDER_NAME,
				_.BIDDER_CODE,
				_.CONTRACT_PRICE,
				_.SETTLE_PRICE,
				_.PRICE_CURRENCY,
				_.PRICE_UNIT,
				_.CONTRACT_CONTENT,
				_.LIMITE_TIME,
				_.QUALITY_REQUIRE,
				_.PERFORM_CHANGE_CONTENT,
				_.FINISH_TIME,
				_.ACTUALLY_PERIOD,
				_.PERFORM_INFO,
				_.SUBMIT_TIME,
				_.CONTRACT_SIGN_TIME,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_ID,
				_.DATA_KEY,
				_.M_DATA_SOURCE,
				_.M_CREATEBY,
				_.M_TM,
				_.M_CREATE_TM,
				_.TENDER_PROJECT_CODE,
				_.CONTRACT_NAME,
				_.PRICE_FORM_CODE,
				_.OTHER_CONTRACT_PRICE,
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
				this._BID_SECTION_CODE,
				this._CONTRACT_RECORD_CODE,
				this._CONTRACT_CODE,
				this._UNIFIED_DEAL_CODE,
				this._TENDERER_NAME,
				this._TENDER_CODE,
				this._BIDDER_NAME,
				this._BIDDER_CODE,
				this._CONTRACT_PRICE,
				this._SETTLE_PRICE,
				this._PRICE_CURRENCY,
				this._PRICE_UNIT,
				this._CONTRACT_CONTENT,
				this._LIMITE_TIME,
				this._QUALITY_REQUIRE,
				this._PERFORM_CHANGE_CONTENT,
				this._FINISH_TIME,
				this._ACTUALLY_PERIOD,
				this._PERFORM_INFO,
				this._SUBMIT_TIME,
				this._CONTRACT_SIGN_TIME,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_ID,
				this._DATA_KEY,
				this._M_DATA_SOURCE,
				this._M_CREATEBY,
				this._M_TM,
				this._M_CREATE_TM,
				this._TENDER_PROJECT_CODE,
				this._CONTRACT_NAME,
				this._PRICE_FORM_CODE,
				this._OTHER_CONTRACT_PRICE,
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
			public readonly static Field All = new Field("*", "ZJ_CONTRACT_PERFORMANCE");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "ZJ_CONTRACT_PERFORMANCE", "标段（包）编号");
            /// <summary>
			/// 合同备案编号
			/// </summary>
			public readonly static Field CONTRACT_RECORD_CODE = new Field("CONTRACT_RECORD_CODE", "ZJ_CONTRACT_PERFORMANCE", "合同备案编号");
            /// <summary>
			/// 合同编号
			/// </summary>
			public readonly static Field CONTRACT_CODE = new Field("CONTRACT_CODE", "ZJ_CONTRACT_PERFORMANCE", "合同编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "ZJ_CONTRACT_PERFORMANCE", "统一交易标识码");
            /// <summary>
			/// 招标人名称
			/// </summary>
			public readonly static Field TENDERER_NAME = new Field("TENDERER_NAME", "ZJ_CONTRACT_PERFORMANCE", "招标人名称");
            /// <summary>
			/// 招标人代码
			/// </summary>
			public readonly static Field TENDER_CODE = new Field("TENDER_CODE", "ZJ_CONTRACT_PERFORMANCE", "招标人代码");
            /// <summary>
			/// 中标人名称
			/// </summary>
			public readonly static Field BIDDER_NAME = new Field("BIDDER_NAME", "ZJ_CONTRACT_PERFORMANCE", "中标人名称");
            /// <summary>
			/// 中标人代码
			/// </summary>
			public readonly static Field BIDDER_CODE = new Field("BIDDER_CODE", "ZJ_CONTRACT_PERFORMANCE", "中标人代码");
            /// <summary>
			/// 合同金额
			/// </summary>
			public readonly static Field CONTRACT_PRICE = new Field("CONTRACT_PRICE", "ZJ_CONTRACT_PERFORMANCE", "合同金额");
            /// <summary>
			/// 合同结算金额
			/// </summary>
			public readonly static Field SETTLE_PRICE = new Field("SETTLE_PRICE", "ZJ_CONTRACT_PERFORMANCE", "合同结算金额");
            /// <summary>
			/// 金额币种代码
			/// </summary>
			public readonly static Field PRICE_CURRENCY = new Field("PRICE_CURRENCY", "ZJ_CONTRACT_PERFORMANCE", "金额币种代码");
            /// <summary>
			/// 金额单位
			/// </summary>
			public readonly static Field PRICE_UNIT = new Field("PRICE_UNIT", "ZJ_CONTRACT_PERFORMANCE", "金额单位");
            /// <summary>
			/// 合同主要内容
			/// </summary>
			public readonly static Field CONTRACT_CONTENT = new Field("CONTRACT_CONTENT", "ZJ_CONTRACT_PERFORMANCE",DbType.AnsiString, null, "合同主要内容");
            /// <summary>
			/// 合同期限
			/// </summary>
			public readonly static Field LIMITE_TIME = new Field("LIMITE_TIME", "ZJ_CONTRACT_PERFORMANCE", "合同期限");
            /// <summary>
			/// 质量要求
			/// </summary>
			public readonly static Field QUALITY_REQUIRE = new Field("QUALITY_REQUIRE", "ZJ_CONTRACT_PERFORMANCE",DbType.AnsiString, null, "质量要求");
            /// <summary>
			/// 履约变更内容
			/// </summary>
			public readonly static Field PERFORM_CHANGE_CONTENT = new Field("PERFORM_CHANGE_CONTENT", "ZJ_CONTRACT_PERFORMANCE",DbType.AnsiString, null, "履约变更内容");
            /// <summary>
			/// 合同完成时间
			/// </summary>
			public readonly static Field FINISH_TIME = new Field("FINISH_TIME", "ZJ_CONTRACT_PERFORMANCE", "合同完成时间");
            /// <summary>
			/// 实际履约期限
			/// </summary>
			public readonly static Field ACTUALLY_PERIOD = new Field("ACTUALLY_PERIOD", "ZJ_CONTRACT_PERFORMANCE", "实际履约期限");
            /// <summary>
			/// 履约信息
			/// </summary>
			public readonly static Field PERFORM_INFO = new Field("PERFORM_INFO", "ZJ_CONTRACT_PERFORMANCE",DbType.AnsiString, null, "履约信息");
            /// <summary>
			/// 递交时间
			/// </summary>
			public readonly static Field SUBMIT_TIME = new Field("SUBMIT_TIME", "ZJ_CONTRACT_PERFORMANCE", "递交时间");
            /// <summary>
			/// 合同签署时间
			/// </summary>
			public readonly static Field CONTRACT_SIGN_TIME = new Field("CONTRACT_SIGN_TIME", "ZJ_CONTRACT_PERFORMANCE", "合同签署时间");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "ZJ_CONTRACT_PERFORMANCE", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "ZJ_CONTRACT_PERFORMANCE", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "ZJ_CONTRACT_PERFORMANCE", "数据时间戳");
            /// <summary>
			/// 数据自增长ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "ZJ_CONTRACT_PERFORMANCE", "数据自增长ID");
            /// <summary>
			/// 数据DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "ZJ_CONTRACT_PERFORMANCE", "数据DATA_KEY");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "ZJ_CONTRACT_PERFORMANCE", "数据来源");
            /// <summary>
			/// M_CREATEBY
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "ZJ_CONTRACT_PERFORMANCE", "M_CREATEBY");
            /// <summary>
			/// M_TM
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "ZJ_CONTRACT_PERFORMANCE", "M_TM");
            /// <summary>
			/// M_CREATE_TM
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "ZJ_CONTRACT_PERFORMANCE", "M_CREATE_TM");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "ZJ_CONTRACT_PERFORMANCE", "招标项目编号");
            /// <summary>
			/// 合同名称
			/// </summary>
			public readonly static Field CONTRACT_NAME = new Field("CONTRACT_NAME", "ZJ_CONTRACT_PERFORMANCE", "合同名称");
            /// <summary>
			/// 价款形式代码
			/// </summary>
			public readonly static Field PRICE_FORM_CODE = new Field("PRICE_FORM_CODE", "ZJ_CONTRACT_PERFORMANCE", "价款形式代码");
            /// <summary>
			/// 其它形式合同报价
			/// </summary>
			public readonly static Field OTHER_CONTRACT_PRICE = new Field("OTHER_CONTRACT_PRICE", "ZJ_CONTRACT_PERFORMANCE", "其它形式合同报价");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "ZJ_CONTRACT_PERFORMANCE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "ZJ_CONTRACT_PERFORMANCE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "ZJ_CONTRACT_PERFORMANCE", "");
        }
        #endregion
	}
}