using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类OTHER_TRADE_RESULT_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("OTHER_TRADE_RESULT_INFO")]
    [Serializable]
    public partial class OTHER_TRADE_RESULT_INFO : FwEntity
    {
        #region Model
		private string _PROJECT_NAME;
		private string _PROJECT_CODE;
		private DateTime? _PUBLISHING_TIME;
		private string _UNIFIED_DEAL_CODE;
		private string _ANNOUNCEMENT_TITLE;
		private string _ANNOUNCEMENT_CONNECT;
		private string _URL;
		private DateTime? _TRADE_DATE;
		private string _CLASSIFY_CODE;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_ID;
		private string _M_ATT_WIN_NOTICE;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _M_VERSION;
		private string _REGION_CODE;
		private string _TRA_PLACE_CODE;
		private string _TRA_AGENCY_NAME;
		private string _TRA_AGENCY_CODE;
		private decimal? _BID_AMOUNT;

		/// <summary>
		/// 项目名称
		/// </summary>
		public string PROJECT_NAME
		{
			get{ return _PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_NAME, _PROJECT_NAME, value);
				this._PROJECT_NAME = value;
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
		/// 公告发布时间
		/// </summary>
		public DateTime? PUBLISHING_TIME
		{
			get{ return _PUBLISHING_TIME; }
			set
			{
				this.OnPropertyValueChange(_.PUBLISHING_TIME, _PUBLISHING_TIME, value);
				this._PUBLISHING_TIME = value;
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
		/// 公告标题
		/// </summary>
		public string ANNOUNCEMENT_TITLE
		{
			get{ return _ANNOUNCEMENT_TITLE; }
			set
			{
				this.OnPropertyValueChange(_.ANNOUNCEMENT_TITLE, _ANNOUNCEMENT_TITLE, value);
				this._ANNOUNCEMENT_TITLE = value;
			}
		}
		/// <summary>
		/// 公告内容
		/// </summary>
		public string ANNOUNCEMENT_CONNECT
		{
			get{ return _ANNOUNCEMENT_CONNECT; }
			set
			{
				this.OnPropertyValueChange(_.ANNOUNCEMENT_CONNECT, _ANNOUNCEMENT_CONNECT, value);
				this._ANNOUNCEMENT_CONNECT = value;
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
		/// 成交日期
		/// </summary>
		public DateTime? TRADE_DATE
		{
			get{ return _TRADE_DATE; }
			set
			{
				this.OnPropertyValueChange(_.TRADE_DATE, _TRADE_DATE, value);
				this._TRADE_DATE = value;
			}
		}
		/// <summary>
		/// 交易业务类型代码
		/// </summary>
		public string CLASSIFY_CODE
		{
			get{ return _CLASSIFY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CLASSIFY_CODE, _CLASSIFY_CODE, value);
				this._CLASSIFY_CODE = value;
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
		/// 成交公示信息
		/// </summary>
		public string M_ATT_WIN_NOTICE
		{
			get{ return _M_ATT_WIN_NOTICE; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_WIN_NOTICE, _M_ATT_WIN_NOTICE, value);
				this._M_ATT_WIN_NOTICE = value;
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
		/// <summary>
		/// 
		/// </summary>
		public string REGION_CODE
		{
			get{ return _REGION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.REGION_CODE, _REGION_CODE, value);
				this._REGION_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TRA_PLACE_CODE
		{
			get{ return _TRA_PLACE_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TRA_PLACE_CODE, _TRA_PLACE_CODE, value);
				this._TRA_PLACE_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TRA_AGENCY_NAME
		{
			get{ return _TRA_AGENCY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TRA_AGENCY_NAME, _TRA_AGENCY_NAME, value);
				this._TRA_AGENCY_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TRA_AGENCY_CODE
		{
			get{ return _TRA_AGENCY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TRA_AGENCY_CODE, _TRA_AGENCY_CODE, value);
				this._TRA_AGENCY_CODE = value;
			}
		}
		/// <summary>
		/// 
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
				_.PROJECT_NAME,
				_.PROJECT_CODE,
				_.PUBLISHING_TIME,
				_.UNIFIED_DEAL_CODE,
				_.ANNOUNCEMENT_TITLE,
				_.ANNOUNCEMENT_CONNECT,
				_.URL,
				_.TRADE_DATE,
				_.CLASSIFY_CODE,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_ID,
				_.M_ATT_WIN_NOTICE,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_VERSION,
				_.REGION_CODE,
				_.TRA_PLACE_CODE,
				_.TRA_AGENCY_NAME,
				_.TRA_AGENCY_CODE,
				_.BID_AMOUNT,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._PROJECT_NAME,
				this._PROJECT_CODE,
				this._PUBLISHING_TIME,
				this._UNIFIED_DEAL_CODE,
				this._ANNOUNCEMENT_TITLE,
				this._ANNOUNCEMENT_CONNECT,
				this._URL,
				this._TRADE_DATE,
				this._CLASSIFY_CODE,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_ID,
				this._M_ATT_WIN_NOTICE,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._M_VERSION,
				this._REGION_CODE,
				this._TRA_PLACE_CODE,
				this._TRA_AGENCY_NAME,
				this._TRA_AGENCY_CODE,
				this._BID_AMOUNT,
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
			public readonly static Field All = new Field("*", "OTHER_TRADE_RESULT_INFO");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field PROJECT_NAME = new Field("PROJECT_NAME", "OTHER_TRADE_RESULT_INFO", "项目名称");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "OTHER_TRADE_RESULT_INFO", "项目编号");
            /// <summary>
			/// 公告发布时间
			/// </summary>
			public readonly static Field PUBLISHING_TIME = new Field("PUBLISHING_TIME", "OTHER_TRADE_RESULT_INFO", "公告发布时间");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "OTHER_TRADE_RESULT_INFO", "统一交易标识码");
            /// <summary>
			/// 公告标题
			/// </summary>
			public readonly static Field ANNOUNCEMENT_TITLE = new Field("ANNOUNCEMENT_TITLE", "OTHER_TRADE_RESULT_INFO", "公告标题");
            /// <summary>
			/// 公告内容
			/// </summary>
			public readonly static Field ANNOUNCEMENT_CONNECT = new Field("ANNOUNCEMENT_CONNECT", "OTHER_TRADE_RESULT_INFO",DbType.AnsiString, null, "公告内容");
            /// <summary>
			/// 公告源URL
			/// </summary>
			public readonly static Field URL = new Field("URL", "OTHER_TRADE_RESULT_INFO", "公告源URL");
            /// <summary>
			/// 成交日期
			/// </summary>
			public readonly static Field TRADE_DATE = new Field("TRADE_DATE", "OTHER_TRADE_RESULT_INFO", "成交日期");
            /// <summary>
			/// 交易业务类型代码
			/// </summary>
			public readonly static Field CLASSIFY_CODE = new Field("CLASSIFY_CODE", "OTHER_TRADE_RESULT_INFO", "交易业务类型代码");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "OTHER_TRADE_RESULT_INFO", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "OTHER_TRADE_RESULT_INFO", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "OTHER_TRADE_RESULT_INFO", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "OTHER_TRADE_RESULT_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "OTHER_TRADE_RESULT_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "OTHER_TRADE_RESULT_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "OTHER_TRADE_RESULT_INFO", "");
            /// <summary>
			/// 成交公示信息
			/// </summary>
			public readonly static Field M_ATT_WIN_NOTICE = new Field("M_ATT_WIN_NOTICE", "OTHER_TRADE_RESULT_INFO", "成交公示信息");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "OTHER_TRADE_RESULT_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "OTHER_TRADE_RESULT_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "OTHER_TRADE_RESULT_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "OTHER_TRADE_RESULT_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "OTHER_TRADE_RESULT_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRA_PLACE_CODE = new Field("TRA_PLACE_CODE", "OTHER_TRADE_RESULT_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRA_AGENCY_NAME = new Field("TRA_AGENCY_NAME", "OTHER_TRADE_RESULT_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRA_AGENCY_CODE = new Field("TRA_AGENCY_CODE", "OTHER_TRADE_RESULT_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BID_AMOUNT = new Field("BID_AMOUNT", "OTHER_TRADE_RESULT_INFO", "");
        }
        #endregion
	}
}