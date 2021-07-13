using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类JT_OBJECTION_REPLY。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("JT_OBJECTION_REPLY")]
    [Serializable]
    public partial class JT_OBJECTION_REPLY : JdEntity
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
		private string _OBJECTIONG_GUID;
		private string _RESPONSE_TITTLE;
		private string _RESPONSE_CONTENT;
		private DateTime? _RESPONSE_SUBMIT_TIME;
		private string _RESPONSE_CREATOR;
		private string _RESPONSE_CREATOR_TYPE;
		private string _RESPONSE_CREATOR_ROLE;
		private string _RESPONSE_CREATOR_CODE;
		private string _RESPONSE_CREATOR_CONTACT;
		private string _RESPONSE_STATUS;
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
		/// 异议唯一标识
		/// </summary>
		public string OBJECTIONG_GUID
		{
			get{ return _OBJECTIONG_GUID; }
			set
			{
				this.OnPropertyValueChange(_.OBJECTIONG_GUID, _OBJECTIONG_GUID, value);
				this._OBJECTIONG_GUID = value;
			}
		}
		/// <summary>
		/// 异议回复标题
		/// </summary>
		public string RESPONSE_TITTLE
		{
			get{ return _RESPONSE_TITTLE; }
			set
			{
				this.OnPropertyValueChange(_.RESPONSE_TITTLE, _RESPONSE_TITTLE, value);
				this._RESPONSE_TITTLE = value;
			}
		}
		/// <summary>
		/// 异议回复内容
		/// </summary>
		public string RESPONSE_CONTENT
		{
			get{ return _RESPONSE_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.RESPONSE_CONTENT, _RESPONSE_CONTENT, value);
				this._RESPONSE_CONTENT = value;
			}
		}
		/// <summary>
		/// 回复提交时间
		/// </summary>
		public DateTime? RESPONSE_SUBMIT_TIME
		{
			get{ return _RESPONSE_SUBMIT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.RESPONSE_SUBMIT_TIME, _RESPONSE_SUBMIT_TIME, value);
				this._RESPONSE_SUBMIT_TIME = value;
			}
		}
		/// <summary>
		/// 异议回复人
		/// </summary>
		public string RESPONSE_CREATOR
		{
			get{ return _RESPONSE_CREATOR; }
			set
			{
				this.OnPropertyValueChange(_.RESPONSE_CREATOR, _RESPONSE_CREATOR, value);
				this._RESPONSE_CREATOR = value;
			}
		}
		/// <summary>
		/// 异议回复人类别
		/// </summary>
		public string RESPONSE_CREATOR_TYPE
		{
			get{ return _RESPONSE_CREATOR_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.RESPONSE_CREATOR_TYPE, _RESPONSE_CREATOR_TYPE, value);
				this._RESPONSE_CREATOR_TYPE = value;
			}
		}
		/// <summary>
		/// 异议回复人角色
		/// </summary>
		public string RESPONSE_CREATOR_ROLE
		{
			get{ return _RESPONSE_CREATOR_ROLE; }
			set
			{
				this.OnPropertyValueChange(_.RESPONSE_CREATOR_ROLE, _RESPONSE_CREATOR_ROLE, value);
				this._RESPONSE_CREATOR_ROLE = value;
			}
		}
		/// <summary>
		/// 异议回复人代码
		/// </summary>
		public string RESPONSE_CREATOR_CODE
		{
			get{ return _RESPONSE_CREATOR_CODE; }
			set
			{
				this.OnPropertyValueChange(_.RESPONSE_CREATOR_CODE, _RESPONSE_CREATOR_CODE, value);
				this._RESPONSE_CREATOR_CODE = value;
			}
		}
		/// <summary>
		/// 异议回复人联系方式
		/// </summary>
		public string RESPONSE_CREATOR_CONTACT
		{
			get{ return _RESPONSE_CREATOR_CONTACT; }
			set
			{
				this.OnPropertyValueChange(_.RESPONSE_CREATOR_CONTACT, _RESPONSE_CREATOR_CONTACT, value);
				this._RESPONSE_CREATOR_CONTACT = value;
			}
		}
		/// <summary>
		/// 异议处理状态
		/// </summary>
		public string RESPONSE_STATUS
		{
			get{ return _RESPONSE_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.RESPONSE_STATUS, _RESPONSE_STATUS, value);
				this._RESPONSE_STATUS = value;
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
				_.OBJECTIONG_GUID,
				_.RESPONSE_TITTLE,
				_.RESPONSE_CONTENT,
				_.RESPONSE_SUBMIT_TIME,
				_.RESPONSE_CREATOR,
				_.RESPONSE_CREATOR_TYPE,
				_.RESPONSE_CREATOR_ROLE,
				_.RESPONSE_CREATOR_CODE,
				_.RESPONSE_CREATOR_CONTACT,
				_.RESPONSE_STATUS,
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
				this._OBJECTIONG_GUID,
				this._RESPONSE_TITTLE,
				this._RESPONSE_CONTENT,
				this._RESPONSE_SUBMIT_TIME,
				this._RESPONSE_CREATOR,
				this._RESPONSE_CREATOR_TYPE,
				this._RESPONSE_CREATOR_ROLE,
				this._RESPONSE_CREATOR_CODE,
				this._RESPONSE_CREATOR_CONTACT,
				this._RESPONSE_STATUS,
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
			public readonly static Field All = new Field("*", "JT_OBJECTION_REPLY");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "JT_OBJECTION_REPLY", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "JT_OBJECTION_REPLY", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "JT_OBJECTION_REPLY", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "JT_OBJECTION_REPLY", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "JT_OBJECTION_REPLY", "");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "JT_OBJECTION_REPLY", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "JT_OBJECTION_REPLY", "标段（包）编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "JT_OBJECTION_REPLY", "统一交易标识码");
            /// <summary>
			/// 异议唯一标识
			/// </summary>
			public readonly static Field OBJECTIONG_GUID = new Field("OBJECTIONG_GUID", "JT_OBJECTION_REPLY", "异议唯一标识");
            /// <summary>
			/// 异议回复标题
			/// </summary>
			public readonly static Field RESPONSE_TITTLE = new Field("RESPONSE_TITTLE", "JT_OBJECTION_REPLY", "异议回复标题");
            /// <summary>
			/// 异议回复内容
			/// </summary>
			public readonly static Field RESPONSE_CONTENT = new Field("RESPONSE_CONTENT", "JT_OBJECTION_REPLY", "异议回复内容");
            /// <summary>
			/// 回复提交时间
			/// </summary>
			public readonly static Field RESPONSE_SUBMIT_TIME = new Field("RESPONSE_SUBMIT_TIME", "JT_OBJECTION_REPLY", "回复提交时间");
            /// <summary>
			/// 异议回复人
			/// </summary>
			public readonly static Field RESPONSE_CREATOR = new Field("RESPONSE_CREATOR", "JT_OBJECTION_REPLY", "异议回复人");
            /// <summary>
			/// 异议回复人类别
			/// </summary>
			public readonly static Field RESPONSE_CREATOR_TYPE = new Field("RESPONSE_CREATOR_TYPE", "JT_OBJECTION_REPLY", "异议回复人类别");
            /// <summary>
			/// 异议回复人角色
			/// </summary>
			public readonly static Field RESPONSE_CREATOR_ROLE = new Field("RESPONSE_CREATOR_ROLE", "JT_OBJECTION_REPLY", "异议回复人角色");
            /// <summary>
			/// 异议回复人代码
			/// </summary>
			public readonly static Field RESPONSE_CREATOR_CODE = new Field("RESPONSE_CREATOR_CODE", "JT_OBJECTION_REPLY", "异议回复人代码");
            /// <summary>
			/// 异议回复人联系方式
			/// </summary>
			public readonly static Field RESPONSE_CREATOR_CONTACT = new Field("RESPONSE_CREATOR_CONTACT", "JT_OBJECTION_REPLY", "异议回复人联系方式");
            /// <summary>
			/// 异议处理状态
			/// </summary>
			public readonly static Field RESPONSE_STATUS = new Field("RESPONSE_STATUS", "JT_OBJECTION_REPLY", "异议处理状态");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "JT_OBJECTION_REPLY", "交易系统标识码");
            /// <summary>
			/// 交易服务系统标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "JT_OBJECTION_REPLY", "交易服务系统标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "JT_OBJECTION_REPLY", "数据时间戳");
            /// <summary>
			/// 交易平台或发布工具标识码
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "JT_OBJECTION_REPLY", "交易平台或发布工具标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "JT_OBJECTION_REPLY", "公共服务平台标识码");
        }
        #endregion
	}
}