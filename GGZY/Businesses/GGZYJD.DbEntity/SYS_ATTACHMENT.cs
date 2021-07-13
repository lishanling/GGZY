using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类SYS_ATTACHMENT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("SYS_ATTACHMENT")]
    [Serializable]
    public partial class SYS_ATTACHMENT : JdEntity
    {
        #region Model
		private decimal? _AID;
		private decimal? _AOBJID;
		private string _FILETYPE;
		private string _FILEPATH;
		private string _FILETILE;
		private string _CREATEID;
		private DateTime? _CREATETIME;
		private string _UPDATEID;
		private DateTime? _UPDATETIME;
		private string _REMARK;
		private string _AOBJTYPE;
		private decimal? _ORDERID;
		private string _FILENUMBER;
		private decimal? _ISCONVERTTOSWF;
		private DateTime? _CONVERTDATETIME;
		private string _CONVERTREMARK;
		private decimal? _CONVERTSTATUS;
		private decimal? _FILECLASS;
		private decimal? _ISPRIVATE;
		private decimal? _ISEDIT;
		private string _PREVIEWPATH;
		private string _GUID;
		private string _SIGN_INFO1;
		private string _MD5;
		private string _SIGN_INFO;

		/// <summary>
		/// 
		/// </summary>
		public decimal? AID
		{
			get{ return _AID; }
			set
			{
				this.OnPropertyValueChange(_.AID, _AID, value);
				this._AID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? AOBJID
		{
			get{ return _AOBJID; }
			set
			{
				this.OnPropertyValueChange(_.AOBJID, _AOBJID, value);
				this._AOBJID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FILETYPE
		{
			get{ return _FILETYPE; }
			set
			{
				this.OnPropertyValueChange(_.FILETYPE, _FILETYPE, value);
				this._FILETYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FILEPATH
		{
			get{ return _FILEPATH; }
			set
			{
				this.OnPropertyValueChange(_.FILEPATH, _FILEPATH, value);
				this._FILEPATH = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FILETILE
		{
			get{ return _FILETILE; }
			set
			{
				this.OnPropertyValueChange(_.FILETILE, _FILETILE, value);
				this._FILETILE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CREATEID
		{
			get{ return _CREATEID; }
			set
			{
				this.OnPropertyValueChange(_.CREATEID, _CREATEID, value);
				this._CREATEID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CREATETIME
		{
			get{ return _CREATETIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATETIME, _CREATETIME, value);
				this._CREATETIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UPDATEID
		{
			get{ return _UPDATEID; }
			set
			{
				this.OnPropertyValueChange(_.UPDATEID, _UPDATEID, value);
				this._UPDATEID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UPDATETIME
		{
			get{ return _UPDATETIME; }
			set
			{
				this.OnPropertyValueChange(_.UPDATETIME, _UPDATETIME, value);
				this._UPDATETIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string REMARK
		{
			get{ return _REMARK; }
			set
			{
				this.OnPropertyValueChange(_.REMARK, _REMARK, value);
				this._REMARK = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AOBJTYPE
		{
			get{ return _AOBJTYPE; }
			set
			{
				this.OnPropertyValueChange(_.AOBJTYPE, _AOBJTYPE, value);
				this._AOBJTYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ORDERID
		{
			get{ return _ORDERID; }
			set
			{
				this.OnPropertyValueChange(_.ORDERID, _ORDERID, value);
				this._ORDERID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FILENUMBER
		{
			get{ return _FILENUMBER; }
			set
			{
				this.OnPropertyValueChange(_.FILENUMBER, _FILENUMBER, value);
				this._FILENUMBER = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISCONVERTTOSWF
		{
			get{ return _ISCONVERTTOSWF; }
			set
			{
				this.OnPropertyValueChange(_.ISCONVERTTOSWF, _ISCONVERTTOSWF, value);
				this._ISCONVERTTOSWF = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CONVERTDATETIME
		{
			get{ return _CONVERTDATETIME; }
			set
			{
				this.OnPropertyValueChange(_.CONVERTDATETIME, _CONVERTDATETIME, value);
				this._CONVERTDATETIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CONVERTREMARK
		{
			get{ return _CONVERTREMARK; }
			set
			{
				this.OnPropertyValueChange(_.CONVERTREMARK, _CONVERTREMARK, value);
				this._CONVERTREMARK = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CONVERTSTATUS
		{
			get{ return _CONVERTSTATUS; }
			set
			{
				this.OnPropertyValueChange(_.CONVERTSTATUS, _CONVERTSTATUS, value);
				this._CONVERTSTATUS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FILECLASS
		{
			get{ return _FILECLASS; }
			set
			{
				this.OnPropertyValueChange(_.FILECLASS, _FILECLASS, value);
				this._FILECLASS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISPRIVATE
		{
			get{ return _ISPRIVATE; }
			set
			{
				this.OnPropertyValueChange(_.ISPRIVATE, _ISPRIVATE, value);
				this._ISPRIVATE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISEDIT
		{
			get{ return _ISEDIT; }
			set
			{
				this.OnPropertyValueChange(_.ISEDIT, _ISEDIT, value);
				this._ISEDIT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PREVIEWPATH
		{
			get{ return _PREVIEWPATH; }
			set
			{
				this.OnPropertyValueChange(_.PREVIEWPATH, _PREVIEWPATH, value);
				this._PREVIEWPATH = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GUID
		{
			get{ return _GUID; }
			set
			{
				this.OnPropertyValueChange(_.GUID, _GUID, value);
				this._GUID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SIGN_INFO1
		{
			get{ return _SIGN_INFO1; }
			set
			{
				this.OnPropertyValueChange(_.SIGN_INFO1, _SIGN_INFO1, value);
				this._SIGN_INFO1 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MD5
		{
			get{ return _MD5; }
			set
			{
				this.OnPropertyValueChange(_.MD5, _MD5, value);
				this._MD5 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SIGN_INFO
		{
			get{ return _SIGN_INFO; }
			set
			{
				this.OnPropertyValueChange(_.SIGN_INFO, _SIGN_INFO, value);
				this._SIGN_INFO = value;
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
				_.AID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.AID,
				_.AOBJID,
				_.FILETYPE,
				_.FILEPATH,
				_.FILETILE,
				_.CREATEID,
				_.CREATETIME,
				_.UPDATEID,
				_.UPDATETIME,
				_.REMARK,
				_.AOBJTYPE,
				_.ORDERID,
				_.FILENUMBER,
				_.ISCONVERTTOSWF,
				_.CONVERTDATETIME,
				_.CONVERTREMARK,
				_.CONVERTSTATUS,
				_.FILECLASS,
				_.ISPRIVATE,
				_.ISEDIT,
				_.PREVIEWPATH,
				_.GUID,
				_.SIGN_INFO1,
				_.MD5,
				_.SIGN_INFO,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._AID,
				this._AOBJID,
				this._FILETYPE,
				this._FILEPATH,
				this._FILETILE,
				this._CREATEID,
				this._CREATETIME,
				this._UPDATEID,
				this._UPDATETIME,
				this._REMARK,
				this._AOBJTYPE,
				this._ORDERID,
				this._FILENUMBER,
				this._ISCONVERTTOSWF,
				this._CONVERTDATETIME,
				this._CONVERTREMARK,
				this._CONVERTSTATUS,
				this._FILECLASS,
				this._ISPRIVATE,
				this._ISEDIT,
				this._PREVIEWPATH,
				this._GUID,
				this._SIGN_INFO1,
				this._MD5,
				this._SIGN_INFO,
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
			public readonly static Field All = new Field("*", "SYS_ATTACHMENT");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AID = new Field("AID", "SYS_ATTACHMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AOBJID = new Field("AOBJID", "SYS_ATTACHMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FILETYPE = new Field("FILETYPE", "SYS_ATTACHMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FILEPATH = new Field("FILEPATH", "SYS_ATTACHMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FILETILE = new Field("FILETILE", "SYS_ATTACHMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATEID = new Field("CREATEID", "SYS_ATTACHMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATETIME = new Field("CREATETIME", "SYS_ATTACHMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UPDATEID = new Field("UPDATEID", "SYS_ATTACHMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UPDATETIME = new Field("UPDATETIME", "SYS_ATTACHMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "SYS_ATTACHMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AOBJTYPE = new Field("AOBJTYPE", "SYS_ATTACHMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ORDERID = new Field("ORDERID", "SYS_ATTACHMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FILENUMBER = new Field("FILENUMBER", "SYS_ATTACHMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISCONVERTTOSWF = new Field("ISCONVERTTOSWF", "SYS_ATTACHMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONVERTDATETIME = new Field("CONVERTDATETIME", "SYS_ATTACHMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONVERTREMARK = new Field("CONVERTREMARK", "SYS_ATTACHMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONVERTSTATUS = new Field("CONVERTSTATUS", "SYS_ATTACHMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FILECLASS = new Field("FILECLASS", "SYS_ATTACHMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISPRIVATE = new Field("ISPRIVATE", "SYS_ATTACHMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISEDIT = new Field("ISEDIT", "SYS_ATTACHMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PREVIEWPATH = new Field("PREVIEWPATH", "SYS_ATTACHMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "SYS_ATTACHMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SIGN_INFO1 = new Field("SIGN_INFO1", "SYS_ATTACHMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MD5 = new Field("MD5", "SYS_ATTACHMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SIGN_INFO = new Field("SIGN_INFO", "SYS_ATTACHMENT",DbType.AnsiString, null, "");
        }
        #endregion
	}
}