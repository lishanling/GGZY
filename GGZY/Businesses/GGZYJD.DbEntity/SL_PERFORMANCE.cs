using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类SL_PERFORMANCE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("SL_PERFORMANCE")]
    [Serializable]
    public partial class SL_PERFORMANCE : JdEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_CREATOR;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private string _UNIFIED_DEAL_CODE;
		private string _PERFORMANCE_REPORT_NAME;
		private string _TENDERER_NAME;
		private string _TENDERER_CODE;
		private string _PERFORMANCE_PARTY_NAME;
		private string _PERFORMANCE_PARTY_CODE;
		private decimal? _SETTLE_PRICE;
		private DateTime? _FINISH_TIME;
		private string _CONTRACT_CHANGE_CONTENT;
		private decimal? _ACTUALLY_PERIOD;
		private string _PERFORMANCE_CONTENT;
		private DateTime? _REPORT_ISSUE_TIME;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;
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
		/// 履约情况报告名称
		/// </summary>
		public string PERFORMANCE_REPORT_NAME
		{
			get{ return _PERFORMANCE_REPORT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PERFORMANCE_REPORT_NAME, _PERFORMANCE_REPORT_NAME, value);
				this._PERFORMANCE_REPORT_NAME = value;
			}
		}
		/// <summary>
		/// 业主/招标人名称
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
		/// 业主/招标人代码
		/// </summary>
		public string TENDERER_CODE
		{
			get{ return _TENDERER_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_CODE, _TENDERER_CODE, value);
				this._TENDERER_CODE = value;
			}
		}
		/// <summary>
		/// 履约人名称
		/// </summary>
		public string PERFORMANCE_PARTY_NAME
		{
			get{ return _PERFORMANCE_PARTY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PERFORMANCE_PARTY_NAME, _PERFORMANCE_PARTY_NAME, value);
				this._PERFORMANCE_PARTY_NAME = value;
			}
		}
		/// <summary>
		/// 履约人代码
		/// </summary>
		public string PERFORMANCE_PARTY_CODE
		{
			get{ return _PERFORMANCE_PARTY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PERFORMANCE_PARTY_CODE, _PERFORMANCE_PARTY_CODE, value);
				this._PERFORMANCE_PARTY_CODE = value;
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
		/// 合同变更内容
		/// </summary>
		public string CONTRACT_CHANGE_CONTENT
		{
			get{ return _CONTRACT_CHANGE_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_CHANGE_CONTENT, _CONTRACT_CHANGE_CONTENT, value);
				this._CONTRACT_CHANGE_CONTENT = value;
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
		/// 履约内容
		/// </summary>
		public string PERFORMANCE_CONTENT
		{
			get{ return _PERFORMANCE_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.PERFORMANCE_CONTENT, _PERFORMANCE_CONTENT, value);
				this._PERFORMANCE_CONTENT = value;
			}
		}
		/// <summary>
		/// 履约报告出具时间
		/// </summary>
		public DateTime? REPORT_ISSUE_TIME
		{
			get{ return _REPORT_ISSUE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.REPORT_ISSUE_TIME, _REPORT_ISSUE_TIME, value);
				this._REPORT_ISSUE_TIME = value;
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
				_.M_ID,
				_.DATA_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_CREATOR,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.TENDER_PROJECT_CODE,
				_.BID_SECTION_CODE,
				_.UNIFIED_DEAL_CODE,
				_.PERFORMANCE_REPORT_NAME,
				_.TENDERER_NAME,
				_.TENDERER_CODE,
				_.PERFORMANCE_PARTY_NAME,
				_.PERFORMANCE_PARTY_CODE,
				_.SETTLE_PRICE,
				_.FINISH_TIME,
				_.CONTRACT_CHANGE_CONTENT,
				_.ACTUALLY_PERIOD,
				_.PERFORMANCE_CONTENT,
				_.REPORT_ISSUE_TIME,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
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
				this._M_ID,
				this._DATA_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_CREATOR,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._TENDER_PROJECT_CODE,
				this._BID_SECTION_CODE,
				this._UNIFIED_DEAL_CODE,
				this._PERFORMANCE_REPORT_NAME,
				this._TENDERER_NAME,
				this._TENDERER_CODE,
				this._PERFORMANCE_PARTY_NAME,
				this._PERFORMANCE_PARTY_CODE,
				this._SETTLE_PRICE,
				this._FINISH_TIME,
				this._CONTRACT_CHANGE_CONTENT,
				this._ACTUALLY_PERIOD,
				this._PERFORMANCE_CONTENT,
				this._REPORT_ISSUE_TIME,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
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
			public readonly static Field All = new Field("*", "SL_PERFORMANCE");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "SL_PERFORMANCE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "SL_PERFORMANCE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "SL_PERFORMANCE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "SL_PERFORMANCE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATOR = new Field("M_CREATOR", "SL_PERFORMANCE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "SL_PERFORMANCE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "SL_PERFORMANCE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "SL_PERFORMANCE", "");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "SL_PERFORMANCE", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "SL_PERFORMANCE", "标段（包）编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "SL_PERFORMANCE", "统一交易标识码");
            /// <summary>
			/// 履约情况报告名称
			/// </summary>
			public readonly static Field PERFORMANCE_REPORT_NAME = new Field("PERFORMANCE_REPORT_NAME", "SL_PERFORMANCE", "履约情况报告名称");
            /// <summary>
			/// 业主/招标人名称
			/// </summary>
			public readonly static Field TENDERER_NAME = new Field("TENDERER_NAME", "SL_PERFORMANCE", "业主/招标人名称");
            /// <summary>
			/// 业主/招标人代码
			/// </summary>
			public readonly static Field TENDERER_CODE = new Field("TENDERER_CODE", "SL_PERFORMANCE", "业主/招标人代码");
            /// <summary>
			/// 履约人名称
			/// </summary>
			public readonly static Field PERFORMANCE_PARTY_NAME = new Field("PERFORMANCE_PARTY_NAME", "SL_PERFORMANCE", "履约人名称");
            /// <summary>
			/// 履约人代码
			/// </summary>
			public readonly static Field PERFORMANCE_PARTY_CODE = new Field("PERFORMANCE_PARTY_CODE", "SL_PERFORMANCE", "履约人代码");
            /// <summary>
			/// 合同结算金额
			/// </summary>
			public readonly static Field SETTLE_PRICE = new Field("SETTLE_PRICE", "SL_PERFORMANCE", "合同结算金额");
            /// <summary>
			/// 合同完成时间
			/// </summary>
			public readonly static Field FINISH_TIME = new Field("FINISH_TIME", "SL_PERFORMANCE", "合同完成时间");
            /// <summary>
			/// 合同变更内容
			/// </summary>
			public readonly static Field CONTRACT_CHANGE_CONTENT = new Field("CONTRACT_CHANGE_CONTENT", "SL_PERFORMANCE",DbType.AnsiString, null, "合同变更内容");
            /// <summary>
			/// 实际履约期限
			/// </summary>
			public readonly static Field ACTUALLY_PERIOD = new Field("ACTUALLY_PERIOD", "SL_PERFORMANCE", "实际履约期限");
            /// <summary>
			/// 履约内容
			/// </summary>
			public readonly static Field PERFORMANCE_CONTENT = new Field("PERFORMANCE_CONTENT", "SL_PERFORMANCE",DbType.AnsiString, null, "履约内容");
            /// <summary>
			/// 履约报告出具时间
			/// </summary>
			public readonly static Field REPORT_ISSUE_TIME = new Field("REPORT_ISSUE_TIME", "SL_PERFORMANCE", "履约报告出具时间");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "SL_PERFORMANCE", "交易系统标识码");
            /// <summary>
			/// 交易服务系统标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "SL_PERFORMANCE", "交易服务系统标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "SL_PERFORMANCE", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "SL_PERFORMANCE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "SL_PERFORMANCE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "SL_PERFORMANCE", "");
        }
        #endregion
	}
}