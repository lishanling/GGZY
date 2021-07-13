using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_UPLOAD。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_UPLOAD")]
    [Serializable]
    public partial class T_UPLOAD : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _DATA_KEY;
		private string _TB_NAME;
		private DateTime? _SEND_DATE;
		private string _SEND_CONTENT;
		private string _RES_CONTENT;
		private decimal? _IS_FILE;
		private decimal? _FILE_IS_UPLOAD;
		private decimal? _DATA_IS_UPLOAD;
		private decimal? _IS_SENDED;
		private decimal? _PRE_STATUS;
		private decimal? _NOW_STATUS;
		private decimal? _IS_HISTORY;
		private string _ERROR_INFO;
		private string _M_DATA_SOURCE;
		private DateTime? _UPDATE_TIME;
		private DateTime? _LAST_SEND_TIME;
		private DateTime? _CREATE_TIME;

		/// <summary>
		/// ID
		/// </summary>
		public decimal? ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// DATA_KEY
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
		/// 表名
		/// </summary>
		public string TB_NAME
		{
			get{ return _TB_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TB_NAME, _TB_NAME, value);
				this._TB_NAME = value;
			}
		}
		/// <summary>
		/// 发送时间
		/// </summary>
		public DateTime? SEND_DATE
		{
			get{ return _SEND_DATE; }
			set
			{
				this.OnPropertyValueChange(_.SEND_DATE, _SEND_DATE, value);
				this._SEND_DATE = value;
			}
		}
		/// <summary>
		/// 发送内容
		/// </summary>
		public string SEND_CONTENT
		{
			get{ return _SEND_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.SEND_CONTENT, _SEND_CONTENT, value);
				this._SEND_CONTENT = value;
			}
		}
		/// <summary>
		/// 接收信息
		/// </summary>
		public string RES_CONTENT
		{
			get{ return _RES_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.RES_CONTENT, _RES_CONTENT, value);
				this._RES_CONTENT = value;
			}
		}
		/// <summary>
		/// 是否有附件
		/// </summary>
		public decimal? IS_FILE
		{
			get{ return _IS_FILE; }
			set
			{
				this.OnPropertyValueChange(_.IS_FILE, _IS_FILE, value);
				this._IS_FILE = value;
			}
		}
		/// <summary>
		/// 附件是否上传
		/// </summary>
		public decimal? FILE_IS_UPLOAD
		{
			get{ return _FILE_IS_UPLOAD; }
			set
			{
				this.OnPropertyValueChange(_.FILE_IS_UPLOAD, _FILE_IS_UPLOAD, value);
				this._FILE_IS_UPLOAD = value;
			}
		}
		/// <summary>
		/// 报文是否上传
		/// </summary>
		public decimal? DATA_IS_UPLOAD
		{
			get{ return _DATA_IS_UPLOAD; }
			set
			{
				this.OnPropertyValueChange(_.DATA_IS_UPLOAD, _DATA_IS_UPLOAD, value);
				this._DATA_IS_UPLOAD = value;
			}
		}
		/// <summary>
		/// 是否已发送 0:数据已修改 1:已上报
		/// </summary>
		public decimal? IS_SENDED
		{
			get{ return _IS_SENDED; }
			set
			{
				this.OnPropertyValueChange(_.IS_SENDED, _IS_SENDED, value);
				this._IS_SENDED = value;
			}
		}
		/// <summary>
		/// 上次上报的状态
		/// </summary>
		public decimal? PRE_STATUS
		{
			get{ return _PRE_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.PRE_STATUS, _PRE_STATUS, value);
				this._PRE_STATUS = value;
			}
		}
		/// <summary>
		/// 现在上报状态
		/// </summary>
		public decimal? NOW_STATUS
		{
			get{ return _NOW_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.NOW_STATUS, _NOW_STATUS, value);
				this._NOW_STATUS = value;
			}
		}
		/// <summary>
		/// 是否为历史数据
		/// </summary>
		public decimal? IS_HISTORY
		{
			get{ return _IS_HISTORY; }
			set
			{
				this.OnPropertyValueChange(_.IS_HISTORY, _IS_HISTORY, value);
				this._IS_HISTORY = value;
			}
		}
		/// <summary>
		/// 异常信息
		/// </summary>
		public string ERROR_INFO
		{
			get{ return _ERROR_INFO; }
			set
			{
				this.OnPropertyValueChange(_.ERROR_INFO, _ERROR_INFO, value);
				this._ERROR_INFO = value;
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
		/// 更新时间
		/// </summary>
		public DateTime? UPDATE_TIME
		{
			get{ return _UPDATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.UPDATE_TIME, _UPDATE_TIME, value);
				this._UPDATE_TIME = value;
			}
		}
		/// <summary>
		/// 最后发送时间
		/// </summary>
		public DateTime? LAST_SEND_TIME
		{
			get{ return _LAST_SEND_TIME; }
			set
			{
				this.OnPropertyValueChange(_.LAST_SEND_TIME, _LAST_SEND_TIME, value);
				this._LAST_SEND_TIME = value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CREATE_TIME
		{
			get{ return _CREATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
				this._CREATE_TIME = value;
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
				_.ID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ID,
				_.DATA_KEY,
				_.TB_NAME,
				_.SEND_DATE,
				_.SEND_CONTENT,
				_.RES_CONTENT,
				_.IS_FILE,
				_.FILE_IS_UPLOAD,
				_.DATA_IS_UPLOAD,
				_.IS_SENDED,
				_.PRE_STATUS,
				_.NOW_STATUS,
				_.IS_HISTORY,
				_.ERROR_INFO,
				_.M_DATA_SOURCE,
				_.UPDATE_TIME,
				_.LAST_SEND_TIME,
				_.CREATE_TIME,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._DATA_KEY,
				this._TB_NAME,
				this._SEND_DATE,
				this._SEND_CONTENT,
				this._RES_CONTENT,
				this._IS_FILE,
				this._FILE_IS_UPLOAD,
				this._DATA_IS_UPLOAD,
				this._IS_SENDED,
				this._PRE_STATUS,
				this._NOW_STATUS,
				this._IS_HISTORY,
				this._ERROR_INFO,
				this._M_DATA_SOURCE,
				this._UPDATE_TIME,
				this._LAST_SEND_TIME,
				this._CREATE_TIME,
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
			public readonly static Field All = new Field("*", "T_UPLOAD");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_UPLOAD", "ID");
            /// <summary>
			/// DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "T_UPLOAD", "DATA_KEY");
            /// <summary>
			/// 表名
			/// </summary>
			public readonly static Field TB_NAME = new Field("TB_NAME", "T_UPLOAD", "表名");
            /// <summary>
			/// 发送时间
			/// </summary>
			public readonly static Field SEND_DATE = new Field("SEND_DATE", "T_UPLOAD", "发送时间");
            /// <summary>
			/// 发送内容
			/// </summary>
			public readonly static Field SEND_CONTENT = new Field("SEND_CONTENT", "T_UPLOAD", "发送内容");
            /// <summary>
			/// 接收信息
			/// </summary>
			public readonly static Field RES_CONTENT = new Field("RES_CONTENT", "T_UPLOAD", "接收信息");
            /// <summary>
			/// 是否有附件
			/// </summary>
			public readonly static Field IS_FILE = new Field("IS_FILE", "T_UPLOAD", "是否有附件");
            /// <summary>
			/// 附件是否上传
			/// </summary>
			public readonly static Field FILE_IS_UPLOAD = new Field("FILE_IS_UPLOAD", "T_UPLOAD", "附件是否上传");
            /// <summary>
			/// 报文是否上传
			/// </summary>
			public readonly static Field DATA_IS_UPLOAD = new Field("DATA_IS_UPLOAD", "T_UPLOAD", "报文是否上传");
            /// <summary>
			/// 是否已发送 0:数据已修改 1:已上报
			/// </summary>
			public readonly static Field IS_SENDED = new Field("IS_SENDED", "T_UPLOAD", "是否已发送 0:数据已修改 1:已上报");
            /// <summary>
			/// 上次上报的状态
			/// </summary>
			public readonly static Field PRE_STATUS = new Field("PRE_STATUS", "T_UPLOAD", "上次上报的状态");
            /// <summary>
			/// 现在上报状态
			/// </summary>
			public readonly static Field NOW_STATUS = new Field("NOW_STATUS", "T_UPLOAD", "现在上报状态");
            /// <summary>
			/// 是否为历史数据
			/// </summary>
			public readonly static Field IS_HISTORY = new Field("IS_HISTORY", "T_UPLOAD", "是否为历史数据");
            /// <summary>
			/// 异常信息
			/// </summary>
			public readonly static Field ERROR_INFO = new Field("ERROR_INFO", "T_UPLOAD", "异常信息");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "T_UPLOAD", "");
            /// <summary>
			/// 更新时间
			/// </summary>
			public readonly static Field UPDATE_TIME = new Field("UPDATE_TIME", "T_UPLOAD", "更新时间");
            /// <summary>
			/// 最后发送时间
			/// </summary>
			public readonly static Field LAST_SEND_TIME = new Field("LAST_SEND_TIME", "T_UPLOAD", "最后发送时间");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "T_UPLOAD", "创建时间");
        }
        #endregion
	}
}