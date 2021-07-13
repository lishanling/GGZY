using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类GY_QUALI_INQUERY_APP_FILE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("GY_QUALI_INQUERY_APP_FILE")]
    [Serializable]
    public partial class GY_QUALI_INQUERY_APP_FILE : JdEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _M_VERSION;
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODES;
		private string _UNIFIED_DEAL_CODES;
		private string _APPLICANTION_NAME;
		private string _APPLICANTION_CODE;
		private string _QUALIFICATION_ELEMENT;
		private string _BID_MANAGER;
		private DateTime? _APPLY_SUBMIT_TIME;
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
		/// 申请人名称
		/// </summary>
		public string APPLICANTION_NAME
		{
			get{ return _APPLICANTION_NAME; }
			set
			{
				this.OnPropertyValueChange(_.APPLICANTION_NAME, _APPLICANTION_NAME, value);
				this._APPLICANTION_NAME = value;
			}
		}
		/// <summary>
		/// 申请人代码
		/// </summary>
		public string APPLICANTION_CODE
		{
			get{ return _APPLICANTION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.APPLICANTION_CODE, _APPLICANTION_CODE, value);
				this._APPLICANTION_CODE = value;
			}
		}
		/// <summary>
		/// 投标资格条件
		/// </summary>
		public string QUALIFICATION_ELEMENT
		{
			get{ return _QUALIFICATION_ELEMENT; }
			set
			{
				this.OnPropertyValueChange(_.QUALIFICATION_ELEMENT, _QUALIFICATION_ELEMENT, value);
				this._QUALIFICATION_ELEMENT = value;
			}
		}
		/// <summary>
		/// 投标单位项目负责人
		/// </summary>
		public string BID_MANAGER
		{
			get{ return _BID_MANAGER; }
			set
			{
				this.OnPropertyValueChange(_.BID_MANAGER, _BID_MANAGER, value);
				this._BID_MANAGER = value;
			}
		}
		/// <summary>
		/// 申请递交时间
		/// </summary>
		public DateTime? APPLY_SUBMIT_TIME
		{
			get{ return _APPLY_SUBMIT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.APPLY_SUBMIT_TIME, _APPLY_SUBMIT_TIME, value);
				this._APPLY_SUBMIT_TIME = value;
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
				_.BID_SECTION_CODES,
				_.UNIFIED_DEAL_CODES,
				_.APPLICANTION_NAME,
				_.APPLICANTION_CODE,
				_.QUALIFICATION_ELEMENT,
				_.BID_MANAGER,
				_.APPLY_SUBMIT_TIME,
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
				this._BID_SECTION_CODES,
				this._UNIFIED_DEAL_CODES,
				this._APPLICANTION_NAME,
				this._APPLICANTION_CODE,
				this._QUALIFICATION_ELEMENT,
				this._BID_MANAGER,
				this._APPLY_SUBMIT_TIME,
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
			public readonly static Field All = new Field("*", "GY_QUALI_INQUERY_APP_FILE");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "GY_QUALI_INQUERY_APP_FILE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "GY_QUALI_INQUERY_APP_FILE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "GY_QUALI_INQUERY_APP_FILE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "GY_QUALI_INQUERY_APP_FILE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "GY_QUALI_INQUERY_APP_FILE", "");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "GY_QUALI_INQUERY_APP_FILE", "招标项目编号");
            /// <summary>
			/// 相关标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODES = new Field("BID_SECTION_CODES", "GY_QUALI_INQUERY_APP_FILE",DbType.AnsiString, null, "相关标段（包）编号");
            /// <summary>
			/// 相关统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODES = new Field("UNIFIED_DEAL_CODES", "GY_QUALI_INQUERY_APP_FILE",DbType.AnsiString, null, "相关统一交易标识码");
            /// <summary>
			/// 申请人名称
			/// </summary>
			public readonly static Field APPLICANTION_NAME = new Field("APPLICANTION_NAME", "GY_QUALI_INQUERY_APP_FILE", "申请人名称");
            /// <summary>
			/// 申请人代码
			/// </summary>
			public readonly static Field APPLICANTION_CODE = new Field("APPLICANTION_CODE", "GY_QUALI_INQUERY_APP_FILE", "申请人代码");
            /// <summary>
			/// 投标资格条件
			/// </summary>
			public readonly static Field QUALIFICATION_ELEMENT = new Field("QUALIFICATION_ELEMENT", "GY_QUALI_INQUERY_APP_FILE",DbType.AnsiString, null, "投标资格条件");
            /// <summary>
			/// 投标单位项目负责人
			/// </summary>
			public readonly static Field BID_MANAGER = new Field("BID_MANAGER", "GY_QUALI_INQUERY_APP_FILE", "投标单位项目负责人");
            /// <summary>
			/// 申请递交时间
			/// </summary>
			public readonly static Field APPLY_SUBMIT_TIME = new Field("APPLY_SUBMIT_TIME", "GY_QUALI_INQUERY_APP_FILE", "申请递交时间");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "GY_QUALI_INQUERY_APP_FILE", "交易系统标识码");
            /// <summary>
			/// 交易服务系统标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "GY_QUALI_INQUERY_APP_FILE", "交易服务系统标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "GY_QUALI_INQUERY_APP_FILE", "数据时间戳");
            /// <summary>
			/// 交易平台或发布工具标识码
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "GY_QUALI_INQUERY_APP_FILE", "交易平台或发布工具标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "GY_QUALI_INQUERY_APP_FILE", "公共服务平台标识码");
        }
        #endregion
	}
}