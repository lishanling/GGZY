using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类BHXX_PERFORMANCE_CONDITION。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("BHXX_PERFORMANCE_CONDITION")]
    [Serializable]
    public partial class BHXX_PERFORMANCE_CONDITION : FwEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _M_VERSION;
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
			public readonly static Field All = new Field("*", "BHXX_PERFORMANCE_CONDITION");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "BHXX_PERFORMANCE_CONDITION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "BHXX_PERFORMANCE_CONDITION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "BHXX_PERFORMANCE_CONDITION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "BHXX_PERFORMANCE_CONDITION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "BHXX_PERFORMANCE_CONDITION", "");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "BHXX_PERFORMANCE_CONDITION", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "BHXX_PERFORMANCE_CONDITION", "标段（包）编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "BHXX_PERFORMANCE_CONDITION", "统一交易标识码");
            /// <summary>
			/// 履约情况报告名称
			/// </summary>
			public readonly static Field PERFORMANCE_REPORT_NAME = new Field("PERFORMANCE_REPORT_NAME", "BHXX_PERFORMANCE_CONDITION", "履约情况报告名称");
            /// <summary>
			/// 业主/招标人名称
			/// </summary>
			public readonly static Field TENDERER_NAME = new Field("TENDERER_NAME", "BHXX_PERFORMANCE_CONDITION", "业主/招标人名称");
            /// <summary>
			/// 业主/招标人代码
			/// </summary>
			public readonly static Field TENDERER_CODE = new Field("TENDERER_CODE", "BHXX_PERFORMANCE_CONDITION", "业主/招标人代码");
            /// <summary>
			/// 履约人名称
			/// </summary>
			public readonly static Field PERFORMANCE_PARTY_NAME = new Field("PERFORMANCE_PARTY_NAME", "BHXX_PERFORMANCE_CONDITION", "履约人名称");
            /// <summary>
			/// 履约人代码
			/// </summary>
			public readonly static Field PERFORMANCE_PARTY_CODE = new Field("PERFORMANCE_PARTY_CODE", "BHXX_PERFORMANCE_CONDITION", "履约人代码");
            /// <summary>
			/// 合同结算金额
			/// </summary>
			public readonly static Field SETTLE_PRICE = new Field("SETTLE_PRICE", "BHXX_PERFORMANCE_CONDITION", "合同结算金额");
            /// <summary>
			/// 合同完成时间
			/// </summary>
			public readonly static Field FINISH_TIME = new Field("FINISH_TIME", "BHXX_PERFORMANCE_CONDITION", "合同完成时间");
            /// <summary>
			/// 合同变更内容
			/// </summary>
			public readonly static Field CONTRACT_CHANGE_CONTENT = new Field("CONTRACT_CHANGE_CONTENT", "BHXX_PERFORMANCE_CONDITION",DbType.AnsiString, null, "合同变更内容");
            /// <summary>
			/// 实际履约期限
			/// </summary>
			public readonly static Field ACTUALLY_PERIOD = new Field("ACTUALLY_PERIOD", "BHXX_PERFORMANCE_CONDITION", "实际履约期限");
            /// <summary>
			/// 履约内容
			/// </summary>
			public readonly static Field PERFORMANCE_CONTENT = new Field("PERFORMANCE_CONTENT", "BHXX_PERFORMANCE_CONDITION",DbType.AnsiString, null, "履约内容");
            /// <summary>
			/// 履约报告出具时间
			/// </summary>
			public readonly static Field REPORT_ISSUE_TIME = new Field("REPORT_ISSUE_TIME", "BHXX_PERFORMANCE_CONDITION", "履约报告出具时间");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "BHXX_PERFORMANCE_CONDITION", "交易系统标识码");
            /// <summary>
			/// 交易服务系统标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "BHXX_PERFORMANCE_CONDITION", "交易服务系统标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "BHXX_PERFORMANCE_CONDITION", "数据时间戳");
            /// <summary>
			/// 交易平台或发布工具标识码
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "BHXX_PERFORMANCE_CONDITION", "交易平台或发布工具标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "BHXX_PERFORMANCE_CONDITION", "公共服务平台标识码");
        }
        #endregion
	}
}