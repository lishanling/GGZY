using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类ZJ_BID_OPENING_RECORD。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJ_BID_OPENING_RECORD")]
    [Serializable]
    public partial class ZJ_BID_OPENING_RECORD : JdEntity
    {
        #region Model
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODES;
		private string _UNIFIED_DEAL_CODES;
		private string _BID_OPENING_ACTOR;
		private string _BID_OPENING_CONTENT;
		private string _BID_OPENING_ADDRESS;
		private DateTime? _BID_OPENING_TIME;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private string _M_CREATEBY;
		private DateTime? _M_TM;
		private DateTime? _M_CREATE_TM;
		private string _NOTICE_NAME;
		private string _URL;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;
		private string _M_VERSION;
		private string _OPEN_COMPERE;
		private string _TENDER_AGENCY_PERSON;
		private string _TENDERER_PERSON;

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
		/// 相关标段（包）编号
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
		/// 相关统一交易标识码
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
		/// 开标参与人
		/// </summary>
		public string BID_OPENING_ACTOR
		{
			get{ return _BID_OPENING_ACTOR; }
			set
			{
				this.OnPropertyValueChange(_.BID_OPENING_ACTOR, _BID_OPENING_ACTOR, value);
				this._BID_OPENING_ACTOR = value;
			}
		}
		/// <summary>
		/// 开标记录内容
		/// </summary>
		public string BID_OPENING_CONTENT
		{
			get{ return _BID_OPENING_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.BID_OPENING_CONTENT, _BID_OPENING_CONTENT, value);
				this._BID_OPENING_CONTENT = value;
			}
		}
		/// <summary>
		/// 开标地点
		/// </summary>
		public string BID_OPENING_ADDRESS
		{
			get{ return _BID_OPENING_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.BID_OPENING_ADDRESS, _BID_OPENING_ADDRESS, value);
				this._BID_OPENING_ADDRESS = value;
			}
		}
		/// <summary>
		/// 开标时间
		/// </summary>
		public DateTime? BID_OPENING_TIME
		{
			get{ return _BID_OPENING_TIME; }
			set
			{
				this.OnPropertyValueChange(_.BID_OPENING_TIME, _BID_OPENING_TIME, value);
				this._BID_OPENING_TIME = value;
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
		/// 开标记录标题
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
		/// 开标记录源URL
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
		/// 开标主持人
		/// </summary>
		public string OPEN_COMPERE
		{
			get{ return _OPEN_COMPERE; }
			set
			{
				this.OnPropertyValueChange(_.OPEN_COMPERE, _OPEN_COMPERE, value);
				this._OPEN_COMPERE = value;
			}
		}
		/// <summary>
		/// 开标代理机构代表
		/// </summary>
		public string TENDER_AGENCY_PERSON
		{
			get{ return _TENDER_AGENCY_PERSON; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_PERSON, _TENDER_AGENCY_PERSON, value);
				this._TENDER_AGENCY_PERSON = value;
			}
		}
		/// <summary>
		/// 开标招标人代表
		/// </summary>
		public string TENDERER_PERSON
		{
			get{ return _TENDERER_PERSON; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_PERSON, _TENDERER_PERSON, value);
				this._TENDERER_PERSON = value;
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
				_.BID_SECTION_CODES,
				_.UNIFIED_DEAL_CODES,
				_.BID_OPENING_ACTOR,
				_.BID_OPENING_CONTENT,
				_.BID_OPENING_ADDRESS,
				_.BID_OPENING_TIME,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_ID,
				_.DATA_KEY,
				_.M_DATA_SOURCE,
				_.M_CREATEBY,
				_.M_TM,
				_.M_CREATE_TM,
				_.NOTICE_NAME,
				_.URL,
				_.TRADE_PLAT,
				_.PUB_SERVICE_PLAT,
				_.M_VERSION,
				_.OPEN_COMPERE,
				_.TENDER_AGENCY_PERSON,
				_.TENDERER_PERSON,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._TENDER_PROJECT_CODE,
				this._BID_SECTION_CODES,
				this._UNIFIED_DEAL_CODES,
				this._BID_OPENING_ACTOR,
				this._BID_OPENING_CONTENT,
				this._BID_OPENING_ADDRESS,
				this._BID_OPENING_TIME,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_ID,
				this._DATA_KEY,
				this._M_DATA_SOURCE,
				this._M_CREATEBY,
				this._M_TM,
				this._M_CREATE_TM,
				this._NOTICE_NAME,
				this._URL,
				this._TRADE_PLAT,
				this._PUB_SERVICE_PLAT,
				this._M_VERSION,
				this._OPEN_COMPERE,
				this._TENDER_AGENCY_PERSON,
				this._TENDERER_PERSON,
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
			public readonly static Field All = new Field("*", "ZJ_BID_OPENING_RECORD");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "ZJ_BID_OPENING_RECORD", "招标项目编号");
            /// <summary>
			/// 相关标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODES = new Field("BID_SECTION_CODES", "ZJ_BID_OPENING_RECORD",DbType.AnsiString, null, "相关标段（包）编号");
            /// <summary>
			/// 相关统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODES = new Field("UNIFIED_DEAL_CODES", "ZJ_BID_OPENING_RECORD",DbType.AnsiString, null, "相关统一交易标识码");
            /// <summary>
			/// 开标参与人
			/// </summary>
			public readonly static Field BID_OPENING_ACTOR = new Field("BID_OPENING_ACTOR", "ZJ_BID_OPENING_RECORD", "开标参与人");
            /// <summary>
			/// 开标记录内容
			/// </summary>
			public readonly static Field BID_OPENING_CONTENT = new Field("BID_OPENING_CONTENT", "ZJ_BID_OPENING_RECORD",DbType.AnsiString, null, "开标记录内容");
            /// <summary>
			/// 开标地点
			/// </summary>
			public readonly static Field BID_OPENING_ADDRESS = new Field("BID_OPENING_ADDRESS", "ZJ_BID_OPENING_RECORD", "开标地点");
            /// <summary>
			/// 开标时间
			/// </summary>
			public readonly static Field BID_OPENING_TIME = new Field("BID_OPENING_TIME", "ZJ_BID_OPENING_RECORD", "开标时间");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "ZJ_BID_OPENING_RECORD", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "ZJ_BID_OPENING_RECORD", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "ZJ_BID_OPENING_RECORD", "数据时间戳");
            /// <summary>
			/// 数据自增长ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "ZJ_BID_OPENING_RECORD", "数据自增长ID");
            /// <summary>
			/// 数据DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "ZJ_BID_OPENING_RECORD", "数据DATA_KEY");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "ZJ_BID_OPENING_RECORD", "数据来源");
            /// <summary>
			/// M_CREATEBY
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "ZJ_BID_OPENING_RECORD", "M_CREATEBY");
            /// <summary>
			/// M_TM
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "ZJ_BID_OPENING_RECORD", "M_TM");
            /// <summary>
			/// M_CREATE_TM
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "ZJ_BID_OPENING_RECORD", "M_CREATE_TM");
            /// <summary>
			/// 开标记录标题
			/// </summary>
			public readonly static Field NOTICE_NAME = new Field("NOTICE_NAME", "ZJ_BID_OPENING_RECORD", "开标记录标题");
            /// <summary>
			/// 开标记录源URL
			/// </summary>
			public readonly static Field URL = new Field("URL", "ZJ_BID_OPENING_RECORD", "开标记录源URL");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "ZJ_BID_OPENING_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "ZJ_BID_OPENING_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "ZJ_BID_OPENING_RECORD", "");
            /// <summary>
			/// 开标主持人
			/// </summary>
			public readonly static Field OPEN_COMPERE = new Field("OPEN_COMPERE", "ZJ_BID_OPENING_RECORD", "开标主持人");
            /// <summary>
			/// 开标代理机构代表
			/// </summary>
			public readonly static Field TENDER_AGENCY_PERSON = new Field("TENDER_AGENCY_PERSON", "ZJ_BID_OPENING_RECORD", "开标代理机构代表");
            /// <summary>
			/// 开标招标人代表
			/// </summary>
			public readonly static Field TENDERER_PERSON = new Field("TENDERER_PERSON", "ZJ_BID_OPENING_RECORD", "开标招标人代表");
        }
        #endregion
	}
}