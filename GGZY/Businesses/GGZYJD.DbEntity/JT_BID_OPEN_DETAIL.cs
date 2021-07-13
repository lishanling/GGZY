using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类JT_BID_OPEN_DETAIL。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("JT_BID_OPEN_DETAIL")]
    [Serializable]
    public partial class JT_BID_OPEN_DETAIL : JdEntity
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
		private string _NOTARY;
		private decimal? _ROUND;
		private string _ROLL_BALL_LIST;
		private string _VALUE_RESULT;
		private string _CONTENT;
		private string _SEND_COMPANY_LIST;
		private string _SEND_COMPANY_CODE_LIST;
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
		/// 摇球公证人
		/// </summary>
		public string NOTARY
		{
			get{ return _NOTARY; }
			set
			{
				this.OnPropertyValueChange(_.NOTARY, _NOTARY, value);
				this._NOTARY = value;
			}
		}
		/// <summary>
		/// 轮次
		/// </summary>
		public decimal? ROUND
		{
			get{ return _ROUND; }
			set
			{
				this.OnPropertyValueChange(_.ROUND, _ROUND, value);
				this._ROUND = value;
			}
		}
		/// <summary>
		/// 摇球列表
		/// </summary>
		public string ROLL_BALL_LIST
		{
			get{ return _ROLL_BALL_LIST; }
			set
			{
				this.OnPropertyValueChange(_.ROLL_BALL_LIST, _ROLL_BALL_LIST, value);
				this._ROLL_BALL_LIST = value;
			}
		}
		/// <summary>
		/// 各项取值结果
		/// </summary>
		public string VALUE_RESULT
		{
			get{ return _VALUE_RESULT; }
			set
			{
				this.OnPropertyValueChange(_.VALUE_RESULT, _VALUE_RESULT, value);
				this._VALUE_RESULT = value;
			}
		}
		/// <summary>
		/// 开标明细
		/// </summary>
		public string CONTENT
		{
			get{ return _CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.CONTENT, _CONTENT, value);
				this._CONTENT = value;
			}
		}
		/// <summary>
		/// 送评企业列表
		/// </summary>
		public string SEND_COMPANY_LIST
		{
			get{ return _SEND_COMPANY_LIST; }
			set
			{
				this.OnPropertyValueChange(_.SEND_COMPANY_LIST, _SEND_COMPANY_LIST, value);
				this._SEND_COMPANY_LIST = value;
			}
		}
		/// <summary>
		/// 送评企业代码列表
		/// </summary>
		public string SEND_COMPANY_CODE_LIST
		{
			get{ return _SEND_COMPANY_CODE_LIST; }
			set
			{
				this.OnPropertyValueChange(_.SEND_COMPANY_CODE_LIST, _SEND_COMPANY_CODE_LIST, value);
				this._SEND_COMPANY_CODE_LIST = value;
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
				_.NOTARY,
				_.ROUND,
				_.ROLL_BALL_LIST,
				_.VALUE_RESULT,
				_.CONTENT,
				_.SEND_COMPANY_LIST,
				_.SEND_COMPANY_CODE_LIST,
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
				this._NOTARY,
				this._ROUND,
				this._ROLL_BALL_LIST,
				this._VALUE_RESULT,
				this._CONTENT,
				this._SEND_COMPANY_LIST,
				this._SEND_COMPANY_CODE_LIST,
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
			public readonly static Field All = new Field("*", "JT_BID_OPEN_DETAIL");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "JT_BID_OPEN_DETAIL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "JT_BID_OPEN_DETAIL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "JT_BID_OPEN_DETAIL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "JT_BID_OPEN_DETAIL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "JT_BID_OPEN_DETAIL", "");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "JT_BID_OPEN_DETAIL", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "JT_BID_OPEN_DETAIL", "标段（包）编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "JT_BID_OPEN_DETAIL", "统一交易标识码");
            /// <summary>
			/// 摇球公证人
			/// </summary>
			public readonly static Field NOTARY = new Field("NOTARY", "JT_BID_OPEN_DETAIL", "摇球公证人");
            /// <summary>
			/// 轮次
			/// </summary>
			public readonly static Field ROUND = new Field("ROUND", "JT_BID_OPEN_DETAIL", "轮次");
            /// <summary>
			/// 摇球列表
			/// </summary>
			public readonly static Field ROLL_BALL_LIST = new Field("ROLL_BALL_LIST", "JT_BID_OPEN_DETAIL", "摇球列表");
            /// <summary>
			/// 各项取值结果
			/// </summary>
			public readonly static Field VALUE_RESULT = new Field("VALUE_RESULT", "JT_BID_OPEN_DETAIL",DbType.AnsiString, null, "各项取值结果");
            /// <summary>
			/// 开标明细
			/// </summary>
			public readonly static Field CONTENT = new Field("CONTENT", "JT_BID_OPEN_DETAIL",DbType.AnsiString, null, "开标明细");
            /// <summary>
			/// 送评企业列表
			/// </summary>
			public readonly static Field SEND_COMPANY_LIST = new Field("SEND_COMPANY_LIST", "JT_BID_OPEN_DETAIL", "送评企业列表");
            /// <summary>
			/// 送评企业代码列表
			/// </summary>
			public readonly static Field SEND_COMPANY_CODE_LIST = new Field("SEND_COMPANY_CODE_LIST", "JT_BID_OPEN_DETAIL", "送评企业代码列表");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "JT_BID_OPEN_DETAIL", "交易系统标识码");
            /// <summary>
			/// 交易服务系统标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "JT_BID_OPEN_DETAIL", "交易服务系统标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "JT_BID_OPEN_DETAIL", "数据时间戳");
            /// <summary>
			/// 交易平台或发布工具标识码
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "JT_BID_OPEN_DETAIL", "交易平台或发布工具标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "JT_BID_OPEN_DETAIL", "公共服务平台标识码");
        }
        #endregion
	}
}