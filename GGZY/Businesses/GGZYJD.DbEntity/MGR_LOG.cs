using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类MGR_LOG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("MGR_LOG")]
    [Serializable]
    public partial class MGR_LOG : JdEntity
    {
        #region Model
		private string _ID;
		private string _LOGLEVEL;
		private DateTime? _LOGTIME;
		private string _MESSAGE;
		private string _ACCOUNT;
		private string _URL;
		private string _URLREFERRER;
		private string _BROWSER;
		private string _IP;
		private string _HOST;
		private string _SYSTEM;
		private string _TYPE;
		private string _LOGFROM;
		private string _METHOD;
		private string _LOGGER;
		private string _THREADID;
		private string _LOCATE;
		private string _MAC;
		private string _EX;

		/// <summary>
		/// 主键
		/// </summary>
		public string ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 日志级别
		/// </summary>
		public string LOGLEVEL
		{
			get{ return _LOGLEVEL; }
			set
			{
				this.OnPropertyValueChange(_.LOGLEVEL, _LOGLEVEL, value);
				this._LOGLEVEL = value;
			}
		}
		/// <summary>
		/// 记录时间
		/// </summary>
		public DateTime? LOGTIME
		{
			get{ return _LOGTIME; }
			set
			{
				this.OnPropertyValueChange(_.LOGTIME, _LOGTIME, value);
				this._LOGTIME = value;
			}
		}
		/// <summary>
		/// 日志信息
		/// </summary>
		public string MESSAGE
		{
			get{ return _MESSAGE; }
			set
			{
				this.OnPropertyValueChange(_.MESSAGE, _MESSAGE, value);
				this._MESSAGE = value;
			}
		}
		/// <summary>
		/// 当前用户
		/// </summary>
		public string ACCOUNT
		{
			get{ return _ACCOUNT; }
			set
			{
				this.OnPropertyValueChange(_.ACCOUNT, _ACCOUNT, value);
				this._ACCOUNT = value;
			}
		}
		/// <summary>
		/// 链接
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
		/// 链接来源
		/// </summary>
		public string URLREFERRER
		{
			get{ return _URLREFERRER; }
			set
			{
				this.OnPropertyValueChange(_.URLREFERRER, _URLREFERRER, value);
				this._URLREFERRER = value;
			}
		}
		/// <summary>
		/// 浏览器
		/// </summary>
		public string BROWSER
		{
			get{ return _BROWSER; }
			set
			{
				this.OnPropertyValueChange(_.BROWSER, _BROWSER, value);
				this._BROWSER = value;
			}
		}
		/// <summary>
		/// ip
		/// </summary>
		public string IP
		{
			get{ return _IP; }
			set
			{
				this.OnPropertyValueChange(_.IP, _IP, value);
				this._IP = value;
			}
		}
		/// <summary>
		/// 主机
		/// </summary>
		public string HOST
		{
			get{ return _HOST; }
			set
			{
				this.OnPropertyValueChange(_.HOST, _HOST, value);
				this._HOST = value;
			}
		}
		/// <summary>
		/// 系统
		/// </summary>
		public string SYSTEM
		{
			get{ return _SYSTEM; }
			set
			{
				this.OnPropertyValueChange(_.SYSTEM, _SYSTEM, value);
				this._SYSTEM = value;
			}
		}
		/// <summary>
		/// 类型
		/// </summary>
		public string TYPE
		{
			get{ return _TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TYPE, _TYPE, value);
				this._TYPE = value;
			}
		}
		/// <summary>
		/// 来源
		/// </summary>
		public string LOGFROM
		{
			get{ return _LOGFROM; }
			set
			{
				this.OnPropertyValueChange(_.LOGFROM, _LOGFROM, value);
				this._LOGFROM = value;
			}
		}
		/// <summary>
		/// 方法
		/// </summary>
		public string METHOD
		{
			get{ return _METHOD; }
			set
			{
				this.OnPropertyValueChange(_.METHOD, _METHOD, value);
				this._METHOD = value;
			}
		}
		/// <summary>
		/// 日志记录器
		/// </summary>
		public string LOGGER
		{
			get{ return _LOGGER; }
			set
			{
				this.OnPropertyValueChange(_.LOGGER, _LOGGER, value);
				this._LOGGER = value;
			}
		}
		/// <summary>
		/// 线程
		/// </summary>
		public string THREADID
		{
			get{ return _THREADID; }
			set
			{
				this.OnPropertyValueChange(_.THREADID, _THREADID, value);
				this._THREADID = value;
			}
		}
		/// <summary>
		/// 位置
		/// </summary>
		public string LOCATE
		{
			get{ return _LOCATE; }
			set
			{
				this.OnPropertyValueChange(_.LOCATE, _LOCATE, value);
				this._LOCATE = value;
			}
		}
		/// <summary>
		/// MAC
		/// </summary>
		public string MAC
		{
			get{ return _MAC; }
			set
			{
				this.OnPropertyValueChange(_.MAC, _MAC, value);
				this._MAC = value;
			}
		}
		/// <summary>
		/// 异常
		/// </summary>
		public string EX
		{
			get{ return _EX; }
			set
			{
				this.OnPropertyValueChange(_.EX, _EX, value);
				this._EX = value;
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
				_.LOGLEVEL,
				_.LOGTIME,
				_.MESSAGE,
				_.ACCOUNT,
				_.URL,
				_.URLREFERRER,
				_.BROWSER,
				_.IP,
				_.HOST,
				_.SYSTEM,
				_.TYPE,
				_.LOGFROM,
				_.METHOD,
				_.LOGGER,
				_.THREADID,
				_.LOCATE,
				_.MAC,
				_.EX,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._LOGLEVEL,
				this._LOGTIME,
				this._MESSAGE,
				this._ACCOUNT,
				this._URL,
				this._URLREFERRER,
				this._BROWSER,
				this._IP,
				this._HOST,
				this._SYSTEM,
				this._TYPE,
				this._LOGFROM,
				this._METHOD,
				this._LOGGER,
				this._THREADID,
				this._LOCATE,
				this._MAC,
				this._EX,
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
			public readonly static Field All = new Field("*", "MGR_LOG");
            /// <summary>
			/// 主键
			/// </summary>
			public readonly static Field ID = new Field("ID", "MGR_LOG", "主键");
            /// <summary>
			/// 日志级别
			/// </summary>
			public readonly static Field LOGLEVEL = new Field("LOGLEVEL", "MGR_LOG", "日志级别");
            /// <summary>
			/// 记录时间
			/// </summary>
			public readonly static Field LOGTIME = new Field("LOGTIME", "MGR_LOG", "记录时间");
            /// <summary>
			/// 日志信息
			/// </summary>
			public readonly static Field MESSAGE = new Field("MESSAGE", "MGR_LOG", "日志信息");
            /// <summary>
			/// 当前用户
			/// </summary>
			public readonly static Field ACCOUNT = new Field("ACCOUNT", "MGR_LOG", "当前用户");
            /// <summary>
			/// 链接
			/// </summary>
			public readonly static Field URL = new Field("URL", "MGR_LOG", "链接");
            /// <summary>
			/// 链接来源
			/// </summary>
			public readonly static Field URLREFERRER = new Field("URLREFERRER", "MGR_LOG", "链接来源");
            /// <summary>
			/// 浏览器
			/// </summary>
			public readonly static Field BROWSER = new Field("BROWSER", "MGR_LOG", "浏览器");
            /// <summary>
			/// ip
			/// </summary>
			public readonly static Field IP = new Field("IP", "MGR_LOG", "ip");
            /// <summary>
			/// 主机
			/// </summary>
			public readonly static Field HOST = new Field("HOST", "MGR_LOG", "主机");
            /// <summary>
			/// 系统
			/// </summary>
			public readonly static Field SYSTEM = new Field("SYSTEM", "MGR_LOG", "系统");
            /// <summary>
			/// 类型
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "MGR_LOG", "类型");
            /// <summary>
			/// 来源
			/// </summary>
			public readonly static Field LOGFROM = new Field("LOGFROM", "MGR_LOG", "来源");
            /// <summary>
			/// 方法
			/// </summary>
			public readonly static Field METHOD = new Field("METHOD", "MGR_LOG", "方法");
            /// <summary>
			/// 日志记录器
			/// </summary>
			public readonly static Field LOGGER = new Field("LOGGER", "MGR_LOG", "日志记录器");
            /// <summary>
			/// 线程
			/// </summary>
			public readonly static Field THREADID = new Field("THREADID", "MGR_LOG", "线程");
            /// <summary>
			/// 位置
			/// </summary>
			public readonly static Field LOCATE = new Field("LOCATE", "MGR_LOG", "位置");
            /// <summary>
			/// MAC
			/// </summary>
			public readonly static Field MAC = new Field("MAC", "MGR_LOG", "MAC");
            /// <summary>
			/// 异常
			/// </summary>
			public readonly static Field EX = new Field("EX", "MGR_LOG", "异常");
        }
        #endregion
	}
}