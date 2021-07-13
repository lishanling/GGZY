using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类PURCHASE_QUALI_INQUERY_ANN。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PURCHASE_QUALI_INQUERY_ANN")]
    [Serializable]
    public partial class PURCHASE_QUALI_INQUERY_ANN : FwEntity
    {
        #region Model
		private string _PURCHASE_PROJECT_CODE;
		private string _PURCHASE_PROJECT_NAME;
		private string _PURCHASE_SECTION_CODE;
		private string _UNIFIED_DEAL_CODE;
		private string _BULLETIN_TITLE;
		private string _BULLETIN_CONTENT;
		private DateTime? _BULLETIN_START_TIME;
		private string _BULLETIN_MEDIA;
		private string _URL;
		private DateTime? _BID_CLOSING_TIME;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_ID;
		private string _M_ATT_PURCHASE_FILE;
		private string _M_ATT_PURCHASE_NOTICE;
		private string _M_ATT_QUALIFI_PREVIEW_FILE;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private decimal? _BULLETIN_BID_NUM;
		private string _M_VERSION;

		/// <summary>
		/// 采购项目编号
		/// </summary>
		public string PURCHASE_PROJECT_CODE
		{
			get{ return _PURCHASE_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASE_PROJECT_CODE, _PURCHASE_PROJECT_CODE, value);
				this._PURCHASE_PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 采购项目名称
		/// </summary>
		public string PURCHASE_PROJECT_NAME
		{
			get{ return _PURCHASE_PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASE_PROJECT_NAME, _PURCHASE_PROJECT_NAME, value);
				this._PURCHASE_PROJECT_NAME = value;
			}
		}
		/// <summary>
		/// 采购项目子包编号
		/// </summary>
		public string PURCHASE_SECTION_CODE
		{
			get{ return _PURCHASE_SECTION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASE_SECTION_CODE, _PURCHASE_SECTION_CODE, value);
				this._PURCHASE_SECTION_CODE = value;
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
		public string BULLETIN_TITLE
		{
			get{ return _BULLETIN_TITLE; }
			set
			{
				this.OnPropertyValueChange(_.BULLETIN_TITLE, _BULLETIN_TITLE, value);
				this._BULLETIN_TITLE = value;
			}
		}
		/// <summary>
		/// 公告内容
		/// </summary>
		public string BULLETIN_CONTENT
		{
			get{ return _BULLETIN_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.BULLETIN_CONTENT, _BULLETIN_CONTENT, value);
				this._BULLETIN_CONTENT = value;
			}
		}
		/// <summary>
		/// 公告发布时间
		/// </summary>
		public DateTime? BULLETIN_START_TIME
		{
			get{ return _BULLETIN_START_TIME; }
			set
			{
				this.OnPropertyValueChange(_.BULLETIN_START_TIME, _BULLETIN_START_TIME, value);
				this._BULLETIN_START_TIME = value;
			}
		}
		/// <summary>
		/// 公告发布媒体
		/// </summary>
		public string BULLETIN_MEDIA
		{
			get{ return _BULLETIN_MEDIA; }
			set
			{
				this.OnPropertyValueChange(_.BULLETIN_MEDIA, _BULLETIN_MEDIA, value);
				this._BULLETIN_MEDIA = value;
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
		/// 投标（提交响应文件）截止时间
		/// </summary>
		public DateTime? BID_CLOSING_TIME
		{
			get{ return _BID_CLOSING_TIME; }
			set
			{
				this.OnPropertyValueChange(_.BID_CLOSING_TIME, _BID_CLOSING_TIME, value);
				this._BID_CLOSING_TIME = value;
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
		/// 采购文件
		/// </summary>
		public string M_ATT_PURCHASE_FILE
		{
			get{ return _M_ATT_PURCHASE_FILE; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_PURCHASE_FILE, _M_ATT_PURCHASE_FILE, value);
				this._M_ATT_PURCHASE_FILE = value;
			}
		}
		/// <summary>
		/// 采购公告
		/// </summary>
		public string M_ATT_PURCHASE_NOTICE
		{
			get{ return _M_ATT_PURCHASE_NOTICE; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_PURCHASE_NOTICE, _M_ATT_PURCHASE_NOTICE, value);
				this._M_ATT_PURCHASE_NOTICE = value;
			}
		}
		/// <summary>
		/// 资格预审文件
		/// </summary>
		public string M_ATT_QUALIFI_PREVIEW_FILE
		{
			get{ return _M_ATT_QUALIFI_PREVIEW_FILE; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_QUALIFI_PREVIEW_FILE, _M_ATT_QUALIFI_PREVIEW_FILE, value);
				this._M_ATT_QUALIFI_PREVIEW_FILE = value;
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
		/// 公告子包数量
		/// </summary>
		public decimal? BULLETIN_BID_NUM
		{
			get{ return _BULLETIN_BID_NUM; }
			set
			{
				this.OnPropertyValueChange(_.BULLETIN_BID_NUM, _BULLETIN_BID_NUM, value);
				this._BULLETIN_BID_NUM = value;
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
				_.PURCHASE_PROJECT_CODE,
				_.PURCHASE_PROJECT_NAME,
				_.PURCHASE_SECTION_CODE,
				_.UNIFIED_DEAL_CODE,
				_.BULLETIN_TITLE,
				_.BULLETIN_CONTENT,
				_.BULLETIN_START_TIME,
				_.BULLETIN_MEDIA,
				_.URL,
				_.BID_CLOSING_TIME,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_ID,
				_.M_ATT_PURCHASE_FILE,
				_.M_ATT_PURCHASE_NOTICE,
				_.M_ATT_QUALIFI_PREVIEW_FILE,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.BULLETIN_BID_NUM,
				_.M_VERSION,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._PURCHASE_PROJECT_CODE,
				this._PURCHASE_PROJECT_NAME,
				this._PURCHASE_SECTION_CODE,
				this._UNIFIED_DEAL_CODE,
				this._BULLETIN_TITLE,
				this._BULLETIN_CONTENT,
				this._BULLETIN_START_TIME,
				this._BULLETIN_MEDIA,
				this._URL,
				this._BID_CLOSING_TIME,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_ID,
				this._M_ATT_PURCHASE_FILE,
				this._M_ATT_PURCHASE_NOTICE,
				this._M_ATT_QUALIFI_PREVIEW_FILE,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._BULLETIN_BID_NUM,
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
			public readonly static Field All = new Field("*", "PURCHASE_QUALI_INQUERY_ANN");
            /// <summary>
			/// 采购项目编号
			/// </summary>
			public readonly static Field PURCHASE_PROJECT_CODE = new Field("PURCHASE_PROJECT_CODE", "PURCHASE_QUALI_INQUERY_ANN", "采购项目编号");
            /// <summary>
			/// 采购项目名称
			/// </summary>
			public readonly static Field PURCHASE_PROJECT_NAME = new Field("PURCHASE_PROJECT_NAME", "PURCHASE_QUALI_INQUERY_ANN", "采购项目名称");
            /// <summary>
			/// 采购项目子包编号
			/// </summary>
			public readonly static Field PURCHASE_SECTION_CODE = new Field("PURCHASE_SECTION_CODE", "PURCHASE_QUALI_INQUERY_ANN", "采购项目子包编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "PURCHASE_QUALI_INQUERY_ANN", "统一交易标识码");
            /// <summary>
			/// 公告标题
			/// </summary>
			public readonly static Field BULLETIN_TITLE = new Field("BULLETIN_TITLE", "PURCHASE_QUALI_INQUERY_ANN", "公告标题");
            /// <summary>
			/// 公告内容
			/// </summary>
			public readonly static Field BULLETIN_CONTENT = new Field("BULLETIN_CONTENT", "PURCHASE_QUALI_INQUERY_ANN",DbType.AnsiString, null, "公告内容");
            /// <summary>
			/// 公告发布时间
			/// </summary>
			public readonly static Field BULLETIN_START_TIME = new Field("BULLETIN_START_TIME", "PURCHASE_QUALI_INQUERY_ANN", "公告发布时间");
            /// <summary>
			/// 公告发布媒体
			/// </summary>
			public readonly static Field BULLETIN_MEDIA = new Field("BULLETIN_MEDIA", "PURCHASE_QUALI_INQUERY_ANN", "公告发布媒体");
            /// <summary>
			/// 公告源URL
			/// </summary>
			public readonly static Field URL = new Field("URL", "PURCHASE_QUALI_INQUERY_ANN", "公告源URL");
            /// <summary>
			/// 投标（提交响应文件）截止时间
			/// </summary>
			public readonly static Field BID_CLOSING_TIME = new Field("BID_CLOSING_TIME", "PURCHASE_QUALI_INQUERY_ANN", "投标（提交响应文件）截止时间");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "PURCHASE_QUALI_INQUERY_ANN", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "PURCHASE_QUALI_INQUERY_ANN", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "PURCHASE_QUALI_INQUERY_ANN", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "PURCHASE_QUALI_INQUERY_ANN", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "PURCHASE_QUALI_INQUERY_ANN", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "PURCHASE_QUALI_INQUERY_ANN", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "PURCHASE_QUALI_INQUERY_ANN", "");
            /// <summary>
			/// 采购文件
			/// </summary>
			public readonly static Field M_ATT_PURCHASE_FILE = new Field("M_ATT_PURCHASE_FILE", "PURCHASE_QUALI_INQUERY_ANN", "采购文件");
            /// <summary>
			/// 采购公告
			/// </summary>
			public readonly static Field M_ATT_PURCHASE_NOTICE = new Field("M_ATT_PURCHASE_NOTICE", "PURCHASE_QUALI_INQUERY_ANN", "采购公告");
            /// <summary>
			/// 资格预审文件
			/// </summary>
			public readonly static Field M_ATT_QUALIFI_PREVIEW_FILE = new Field("M_ATT_QUALIFI_PREVIEW_FILE", "PURCHASE_QUALI_INQUERY_ANN", "资格预审文件");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "PURCHASE_QUALI_INQUERY_ANN", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "PURCHASE_QUALI_INQUERY_ANN", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "PURCHASE_QUALI_INQUERY_ANN", "");
            /// <summary>
			/// 公告子包数量
			/// </summary>
			public readonly static Field BULLETIN_BID_NUM = new Field("BULLETIN_BID_NUM", "PURCHASE_QUALI_INQUERY_ANN", "公告子包数量");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "PURCHASE_QUALI_INQUERY_ANN", "");
        }
        #endregion
	}
}