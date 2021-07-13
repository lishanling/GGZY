using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类DEA_MEDI_FIXED_PURCHASE_ANNO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("DEA_MEDI_FIXED_PURCHASE_ANNO")]
    [Serializable]
    public partial class DEA_MEDI_FIXED_PURCHASE_ANNO : FwEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_CREATOR;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _PROJECT_CODE;
		private string _PROJNAME;
		private string _DRUGGROUP;
		private string _NOTICE_NAME;
		private string _NOTICE_CONTENT;
		private DateTime? _NOTICE_SEND_TIME;
		private string _NOTICE_MEDIA;
		private string _URL;
		private string _NA_AREA;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
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
		/// 项目名称
		/// </summary>
		public string PROJNAME
		{
			get{ return _PROJNAME; }
			set
			{
				this.OnPropertyValueChange(_.PROJNAME, _PROJNAME, value);
				this._PROJNAME = value;
			}
		}
		/// <summary>
		/// 采购类别
		/// </summary>
		public string DRUGGROUP
		{
			get{ return _DRUGGROUP; }
			set
			{
				this.OnPropertyValueChange(_.DRUGGROUP, _DRUGGROUP, value);
				this._DRUGGROUP = value;
			}
		}
		/// <summary>
		/// 公告标题
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
		/// 公告内容
		/// </summary>
		public string NOTICE_CONTENT
		{
			get{ return _NOTICE_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE_CONTENT, _NOTICE_CONTENT, value);
				this._NOTICE_CONTENT = value;
			}
		}
		/// <summary>
		/// 公告发布时间
		/// </summary>
		public DateTime? NOTICE_SEND_TIME
		{
			get{ return _NOTICE_SEND_TIME; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE_SEND_TIME, _NOTICE_SEND_TIME, value);
				this._NOTICE_SEND_TIME = value;
			}
		}
		/// <summary>
		/// 公告发布媒体
		/// </summary>
		public string NOTICE_MEDIA
		{
			get{ return _NOTICE_MEDIA; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE_MEDIA, _NOTICE_MEDIA, value);
				this._NOTICE_MEDIA = value;
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
		/// 采购区域
		/// </summary>
		public string NA_AREA
		{
			get{ return _NA_AREA; }
			set
			{
				this.OnPropertyValueChange(_.NA_AREA, _NA_AREA, value);
				this._NA_AREA = value;
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
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_CREATOR,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.PROJECT_CODE,
				_.PROJNAME,
				_.DRUGGROUP,
				_.NOTICE_NAME,
				_.NOTICE_CONTENT,
				_.NOTICE_SEND_TIME,
				_.NOTICE_MEDIA,
				_.URL,
				_.NA_AREA,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
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
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_CREATOR,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._PROJECT_CODE,
				this._PROJNAME,
				this._DRUGGROUP,
				this._NOTICE_NAME,
				this._NOTICE_CONTENT,
				this._NOTICE_SEND_TIME,
				this._NOTICE_MEDIA,
				this._URL,
				this._NA_AREA,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
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
			public readonly static Field All = new Field("*", "DEA_MEDI_FIXED_PURCHASE_ANNO");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "DEA_MEDI_FIXED_PURCHASE_ANNO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "DEA_MEDI_FIXED_PURCHASE_ANNO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "DEA_MEDI_FIXED_PURCHASE_ANNO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "DEA_MEDI_FIXED_PURCHASE_ANNO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATOR = new Field("M_CREATOR", "DEA_MEDI_FIXED_PURCHASE_ANNO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "DEA_MEDI_FIXED_PURCHASE_ANNO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "DEA_MEDI_FIXED_PURCHASE_ANNO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "DEA_MEDI_FIXED_PURCHASE_ANNO", "");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "DEA_MEDI_FIXED_PURCHASE_ANNO", "项目编号");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field PROJNAME = new Field("PROJNAME", "DEA_MEDI_FIXED_PURCHASE_ANNO", "项目名称");
            /// <summary>
			/// 采购类别
			/// </summary>
			public readonly static Field DRUGGROUP = new Field("DRUGGROUP", "DEA_MEDI_FIXED_PURCHASE_ANNO", "采购类别");
            /// <summary>
			/// 公告标题
			/// </summary>
			public readonly static Field NOTICE_NAME = new Field("NOTICE_NAME", "DEA_MEDI_FIXED_PURCHASE_ANNO", "公告标题");
            /// <summary>
			/// 公告内容
			/// </summary>
			public readonly static Field NOTICE_CONTENT = new Field("NOTICE_CONTENT", "DEA_MEDI_FIXED_PURCHASE_ANNO",DbType.AnsiString, null, "公告内容");
            /// <summary>
			/// 公告发布时间
			/// </summary>
			public readonly static Field NOTICE_SEND_TIME = new Field("NOTICE_SEND_TIME", "DEA_MEDI_FIXED_PURCHASE_ANNO", "公告发布时间");
            /// <summary>
			/// 公告发布媒体
			/// </summary>
			public readonly static Field NOTICE_MEDIA = new Field("NOTICE_MEDIA", "DEA_MEDI_FIXED_PURCHASE_ANNO", "公告发布媒体");
            /// <summary>
			/// 公告源URL
			/// </summary>
			public readonly static Field URL = new Field("URL", "DEA_MEDI_FIXED_PURCHASE_ANNO", "公告源URL");
            /// <summary>
			/// 采购区域
			/// </summary>
			public readonly static Field NA_AREA = new Field("NA_AREA", "DEA_MEDI_FIXED_PURCHASE_ANNO", "采购区域");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "DEA_MEDI_FIXED_PURCHASE_ANNO", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "DEA_MEDI_FIXED_PURCHASE_ANNO", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "DEA_MEDI_FIXED_PURCHASE_ANNO", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "DEA_MEDI_FIXED_PURCHASE_ANNO", "");
        }
        #endregion
	}
}