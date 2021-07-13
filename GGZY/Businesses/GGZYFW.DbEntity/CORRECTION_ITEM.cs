﻿using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类CORRECTION_ITEM。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("CORRECTION_ITEM")]
    [Serializable]
    public partial class CORRECTION_ITEM : FwEntity
    {
        #region Model
		private string _PURCHASE_PROJECT_CODE;
		private string _PURCHASE_PROJECT_NAME;
		private string _PURCHASE_SECTION_CODE;
		private string _UNIFIED_DEAL_CODE;
		private string _TERMINATION_BULLETIN_TITLE;
		private string _TERMINATION_BULLETIN_CONTENT;
		private DateTime? _MODIFICATION_START_TIME;
		private string _URL;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_ID;
		private string _M_ATT_MODIFICATION_ITEM;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _IS_POSTPONE;
		private string _M_VERSION;
		private DateTime? _POST_BID_CLOSING_TIME;

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
		public string TERMINATION_BULLETIN_TITLE
		{
			get{ return _TERMINATION_BULLETIN_TITLE; }
			set
			{
				this.OnPropertyValueChange(_.TERMINATION_BULLETIN_TITLE, _TERMINATION_BULLETIN_TITLE, value);
				this._TERMINATION_BULLETIN_TITLE = value;
			}
		}
		/// <summary>
		/// 公告内容
		/// </summary>
		public string TERMINATION_BULLETIN_CONTENT
		{
			get{ return _TERMINATION_BULLETIN_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.TERMINATION_BULLETIN_CONTENT, _TERMINATION_BULLETIN_CONTENT, value);
				this._TERMINATION_BULLETIN_CONTENT = value;
			}
		}
		/// <summary>
		/// 发布时间
		/// </summary>
		public DateTime? MODIFICATION_START_TIME
		{
			get{ return _MODIFICATION_START_TIME; }
			set
			{
				this.OnPropertyValueChange(_.MODIFICATION_START_TIME, _MODIFICATION_START_TIME, value);
				this._MODIFICATION_START_TIME = value;
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
		/// 更正事项
		/// </summary>
		public string M_ATT_MODIFICATION_ITEM
		{
			get{ return _M_ATT_MODIFICATION_ITEM; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_MODIFICATION_ITEM, _M_ATT_MODIFICATION_ITEM, value);
				this._M_ATT_MODIFICATION_ITEM = value;
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
		/// 是否延期
		/// </summary>
		public string IS_POSTPONE
		{
			get{ return _IS_POSTPONE; }
			set
			{
				this.OnPropertyValueChange(_.IS_POSTPONE, _IS_POSTPONE, value);
				this._IS_POSTPONE = value;
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
		/// 延期后投标（提交响应文件）截止时间
		/// </summary>
		public DateTime? POST_BID_CLOSING_TIME
		{
			get{ return _POST_BID_CLOSING_TIME; }
			set
			{
				this.OnPropertyValueChange(_.POST_BID_CLOSING_TIME, _POST_BID_CLOSING_TIME, value);
				this._POST_BID_CLOSING_TIME = value;
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
				_.TERMINATION_BULLETIN_TITLE,
				_.TERMINATION_BULLETIN_CONTENT,
				_.MODIFICATION_START_TIME,
				_.URL,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_ID,
				_.M_ATT_MODIFICATION_ITEM,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.IS_POSTPONE,
				_.M_VERSION,
				_.POST_BID_CLOSING_TIME,
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
				this._TERMINATION_BULLETIN_TITLE,
				this._TERMINATION_BULLETIN_CONTENT,
				this._MODIFICATION_START_TIME,
				this._URL,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_ID,
				this._M_ATT_MODIFICATION_ITEM,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._IS_POSTPONE,
				this._M_VERSION,
				this._POST_BID_CLOSING_TIME,
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
			public readonly static Field All = new Field("*", "CORRECTION_ITEM");
            /// <summary>
			/// 采购项目编号
			/// </summary>
			public readonly static Field PURCHASE_PROJECT_CODE = new Field("PURCHASE_PROJECT_CODE", "CORRECTION_ITEM", "采购项目编号");
            /// <summary>
			/// 采购项目名称
			/// </summary>
			public readonly static Field PURCHASE_PROJECT_NAME = new Field("PURCHASE_PROJECT_NAME", "CORRECTION_ITEM", "采购项目名称");
            /// <summary>
			/// 采购项目子包编号
			/// </summary>
			public readonly static Field PURCHASE_SECTION_CODE = new Field("PURCHASE_SECTION_CODE", "CORRECTION_ITEM", "采购项目子包编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "CORRECTION_ITEM", "统一交易标识码");
            /// <summary>
			/// 公告标题
			/// </summary>
			public readonly static Field TERMINATION_BULLETIN_TITLE = new Field("TERMINATION_BULLETIN_TITLE", "CORRECTION_ITEM", "公告标题");
            /// <summary>
			/// 公告内容
			/// </summary>
			public readonly static Field TERMINATION_BULLETIN_CONTENT = new Field("TERMINATION_BULLETIN_CONTENT", "CORRECTION_ITEM",DbType.AnsiString, null, "公告内容");
            /// <summary>
			/// 发布时间
			/// </summary>
			public readonly static Field MODIFICATION_START_TIME = new Field("MODIFICATION_START_TIME", "CORRECTION_ITEM", "发布时间");
            /// <summary>
			/// 公告源URL
			/// </summary>
			public readonly static Field URL = new Field("URL", "CORRECTION_ITEM", "公告源URL");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "CORRECTION_ITEM", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "CORRECTION_ITEM", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "CORRECTION_ITEM", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "CORRECTION_ITEM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "CORRECTION_ITEM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "CORRECTION_ITEM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "CORRECTION_ITEM", "");
            /// <summary>
			/// 更正事项
			/// </summary>
			public readonly static Field M_ATT_MODIFICATION_ITEM = new Field("M_ATT_MODIFICATION_ITEM", "CORRECTION_ITEM", "更正事项");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "CORRECTION_ITEM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "CORRECTION_ITEM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "CORRECTION_ITEM", "");
            /// <summary>
			/// 是否延期
			/// </summary>
			public readonly static Field IS_POSTPONE = new Field("IS_POSTPONE", "CORRECTION_ITEM", "是否延期");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "CORRECTION_ITEM", "");
            /// <summary>
			/// 延期后投标（提交响应文件）截止时间
			/// </summary>
			public readonly static Field POST_BID_CLOSING_TIME = new Field("POST_BID_CLOSING_TIME", "CORRECTION_ITEM", "延期后投标（提交响应文件）截止时间");
        }
        #endregion
	}
}