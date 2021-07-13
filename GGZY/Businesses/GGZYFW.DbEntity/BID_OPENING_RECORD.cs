﻿using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类BID_OPENING_RECORD。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("BID_OPENING_RECORD")]
    [Serializable]
    public partial class BID_OPENING_RECORD : FwEntity
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
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _NOTICE_NAME;
		private string _URL;
		private decimal? _M_ID;
		private decimal? _M_CREATOR;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
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
		/// ID
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
		/// ??????
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
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.NOTICE_NAME,
				_.URL,
				_.M_ID,
				_.M_CREATOR,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
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
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._NOTICE_NAME,
				this._URL,
				this._M_ID,
				this._M_CREATOR,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
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
			public readonly static Field All = new Field("*", "BID_OPENING_RECORD");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "BID_OPENING_RECORD", "招标项目编号");
            /// <summary>
			/// 相关标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODES = new Field("BID_SECTION_CODES", "BID_OPENING_RECORD",DbType.AnsiString, null, "相关标段（包）编号");
            /// <summary>
			/// 相关统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODES = new Field("UNIFIED_DEAL_CODES", "BID_OPENING_RECORD",DbType.AnsiString, null, "相关统一交易标识码");
            /// <summary>
			/// 开标参与人
			/// </summary>
			public readonly static Field BID_OPENING_ACTOR = new Field("BID_OPENING_ACTOR", "BID_OPENING_RECORD", "开标参与人");
            /// <summary>
			/// 开标记录内容
			/// </summary>
			public readonly static Field BID_OPENING_CONTENT = new Field("BID_OPENING_CONTENT", "BID_OPENING_RECORD",DbType.AnsiString, null, "开标记录内容");
            /// <summary>
			/// 开标地点
			/// </summary>
			public readonly static Field BID_OPENING_ADDRESS = new Field("BID_OPENING_ADDRESS", "BID_OPENING_RECORD", "开标地点");
            /// <summary>
			/// 开标时间
			/// </summary>
			public readonly static Field BID_OPENING_TIME = new Field("BID_OPENING_TIME", "BID_OPENING_RECORD", "开标时间");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "BID_OPENING_RECORD", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "BID_OPENING_RECORD", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "BID_OPENING_RECORD", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "BID_OPENING_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "BID_OPENING_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "BID_OPENING_RECORD", "");
            /// <summary>
			/// 开标记录标题
			/// </summary>
			public readonly static Field NOTICE_NAME = new Field("NOTICE_NAME", "BID_OPENING_RECORD", "开标记录标题");
            /// <summary>
			/// 开标记录源URL
			/// </summary>
			public readonly static Field URL = new Field("URL", "BID_OPENING_RECORD", "开标记录源URL");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "BID_OPENING_RECORD", "ID");
            /// <summary>
			/// ??????
			/// </summary>
			public readonly static Field M_CREATOR = new Field("M_CREATOR", "BID_OPENING_RECORD", "??????");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "BID_OPENING_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "BID_OPENING_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "BID_OPENING_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "BID_OPENING_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "BID_OPENING_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "BID_OPENING_RECORD", "");
            /// <summary>
			/// 开标主持人
			/// </summary>
			public readonly static Field OPEN_COMPERE = new Field("OPEN_COMPERE", "BID_OPENING_RECORD", "开标主持人");
            /// <summary>
			/// 开标代理机构代表
			/// </summary>
			public readonly static Field TENDER_AGENCY_PERSON = new Field("TENDER_AGENCY_PERSON", "BID_OPENING_RECORD", "开标代理机构代表");
            /// <summary>
			/// 开标招标人代表
			/// </summary>
			public readonly static Field TENDERER_PERSON = new Field("TENDERER_PERSON", "BID_OPENING_RECORD", "开标招标人代表");
        }
        #endregion
	}
}