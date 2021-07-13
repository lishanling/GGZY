using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_UPLOAD_OK_LOG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_UPLOAD_OK_LOG")]
    [Serializable]
    public partial class T_UPLOAD_OK_LOG : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _DATA_KEY;
		private string _TB_NAME;
		private string _DATA_PATH;
		private decimal? _IS_FILE;
		private DateTime? _CREATE_TIME;
		private decimal? _UPLOAD_STATUS;
		private DateTime? _UPLOAD_TIME;
		private decimal? _IS_DATA_UPLOAD;
		private decimal? _IS_FILE_UPLOAD;
		private string _M_DATA_SOURCE;
		private string _SEND_RES;
		private decimal? _TYPE;
		private decimal? _TB_MID;
		private decimal? _OPTYPE;

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
		/// 
		/// </summary>
		public string DATA_PATH
		{
			get{ return _DATA_PATH; }
			set
			{
				this.OnPropertyValueChange(_.DATA_PATH, _DATA_PATH, value);
				this._DATA_PATH = value;
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
		/// <summary>
		/// _0(空):未上传, 1:已上传.  -1:忽略不上传
		/// </summary>
		public decimal? UPLOAD_STATUS
		{
			get{ return _UPLOAD_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.UPLOAD_STATUS, _UPLOAD_STATUS, value);
				this._UPLOAD_STATUS = value;
			}
		}
		/// <summary>
		/// 上传国家时间
		/// </summary>
		public DateTime? UPLOAD_TIME
		{
			get{ return _UPLOAD_TIME; }
			set
			{
				this.OnPropertyValueChange(_.UPLOAD_TIME, _UPLOAD_TIME, value);
				this._UPLOAD_TIME = value;
			}
		}
		/// <summary>
		/// _0(空): 未上传 1:上传完成
		/// </summary>
		public decimal? IS_DATA_UPLOAD
		{
			get{ return _IS_DATA_UPLOAD; }
			set
			{
				this.OnPropertyValueChange(_.IS_DATA_UPLOAD, _IS_DATA_UPLOAD, value);
				this._IS_DATA_UPLOAD = value;
			}
		}
		/// <summary>
		/// _0(空): 未上传 1:上传完成
		/// </summary>
		public decimal? IS_FILE_UPLOAD
		{
			get{ return _IS_FILE_UPLOAD; }
			set
			{
				this.OnPropertyValueChange(_.IS_FILE_UPLOAD, _IS_FILE_UPLOAD, value);
				this._IS_FILE_UPLOAD = value;
			}
		}
		/// <summary>
		/// 交易平台编码
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
		/// 返回值
		/// </summary>
		public string SEND_RES
		{
			get{ return _SEND_RES; }
			set
			{
				this.OnPropertyValueChange(_.SEND_RES, _SEND_RES, value);
				this._SEND_RES = value;
			}
		}
		/// <summary>
		/// _1:接口上报  2:EXCEL  3:系统录入
		/// </summary>
		public decimal? TYPE
		{
			get{ return _TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TYPE, _TYPE, value);
				this._TYPE = value;
			}
		}
		/// <summary>
		/// 对应表的MID值
		/// </summary>
		public decimal? TB_MID
		{
			get{ return _TB_MID; }
			set
			{
				this.OnPropertyValueChange(_.TB_MID, _TB_MID, value);
				this._TB_MID = value;
			}
		}
		/// <summary>
		/// _1:添加 2:修改 3:删除
		/// </summary>
		public decimal? OPTYPE
		{
			get{ return _OPTYPE; }
			set
			{
				this.OnPropertyValueChange(_.OPTYPE, _OPTYPE, value);
				this._OPTYPE = value;
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
				_.DATA_PATH,
				_.IS_FILE,
				_.CREATE_TIME,
				_.UPLOAD_STATUS,
				_.UPLOAD_TIME,
				_.IS_DATA_UPLOAD,
				_.IS_FILE_UPLOAD,
				_.M_DATA_SOURCE,
				_.SEND_RES,
				_.TYPE,
				_.TB_MID,
				_.OPTYPE,
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
				this._DATA_PATH,
				this._IS_FILE,
				this._CREATE_TIME,
				this._UPLOAD_STATUS,
				this._UPLOAD_TIME,
				this._IS_DATA_UPLOAD,
				this._IS_FILE_UPLOAD,
				this._M_DATA_SOURCE,
				this._SEND_RES,
				this._TYPE,
				this._TB_MID,
				this._OPTYPE,
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
			public readonly static Field All = new Field("*", "T_UPLOAD_OK_LOG");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_UPLOAD_OK_LOG", "ID");
            /// <summary>
			/// DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "T_UPLOAD_OK_LOG", "DATA_KEY");
            /// <summary>
			/// 表名
			/// </summary>
			public readonly static Field TB_NAME = new Field("TB_NAME", "T_UPLOAD_OK_LOG", "表名");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_PATH = new Field("DATA_PATH", "T_UPLOAD_OK_LOG", "");
            /// <summary>
			/// 是否有附件
			/// </summary>
			public readonly static Field IS_FILE = new Field("IS_FILE", "T_UPLOAD_OK_LOG", "是否有附件");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "T_UPLOAD_OK_LOG", "创建时间");
            /// <summary>
			/// _0(空):未上传, 1:已上传.  -1:忽略不上传
			/// </summary>
			public readonly static Field UPLOAD_STATUS = new Field("UPLOAD_STATUS", "T_UPLOAD_OK_LOG", "_0(空):未上传, 1:已上传.  -1:忽略不上传");
            /// <summary>
			/// 上传国家时间
			/// </summary>
			public readonly static Field UPLOAD_TIME = new Field("UPLOAD_TIME", "T_UPLOAD_OK_LOG", "上传国家时间");
            /// <summary>
			/// _0(空): 未上传 1:上传完成
			/// </summary>
			public readonly static Field IS_DATA_UPLOAD = new Field("IS_DATA_UPLOAD", "T_UPLOAD_OK_LOG", "_0(空): 未上传 1:上传完成");
            /// <summary>
			/// _0(空): 未上传 1:上传完成
			/// </summary>
			public readonly static Field IS_FILE_UPLOAD = new Field("IS_FILE_UPLOAD", "T_UPLOAD_OK_LOG", "_0(空): 未上传 1:上传完成");
            /// <summary>
			/// 交易平台编码
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "T_UPLOAD_OK_LOG", "交易平台编码");
            /// <summary>
			/// 返回值
			/// </summary>
			public readonly static Field SEND_RES = new Field("SEND_RES", "T_UPLOAD_OK_LOG", "返回值");
            /// <summary>
			/// _1:接口上报  2:EXCEL  3:系统录入
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "T_UPLOAD_OK_LOG", "_1:接口上报  2:EXCEL  3:系统录入");
            /// <summary>
			/// 对应表的MID值
			/// </summary>
			public readonly static Field TB_MID = new Field("TB_MID", "T_UPLOAD_OK_LOG", "对应表的MID值");
            /// <summary>
			/// _1:添加 2:修改 3:删除
			/// </summary>
			public readonly static Field OPTYPE = new Field("OPTYPE", "T_UPLOAD_OK_LOG", "_1:添加 2:修改 3:删除");
        }
        #endregion
	}
}