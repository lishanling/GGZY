using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类SYS_DOCUMENTS。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("SYS_DOCUMENTS")]
    [Serializable]
    public partial class SYS_DOCUMENTS : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _FILEORFOLDER;
		private string _FOLDERNAME;
		private decimal? _PID;
		private decimal? _ORDERID;
		private decimal? _ISPRIVATE;
		private decimal? _ISEDIT;
		private decimal? _MODULEID;
		private string _SSJDID;
		private decimal? _ATTACHMENTID;
		private decimal? _CREATEID;
		private DateTime? _CREATETIME;
		private string _REMARK;

		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public decimal? FILEORFOLDER
		{
			get{ return _FILEORFOLDER; }
			set
			{
				this.OnPropertyValueChange(_.FILEORFOLDER, _FILEORFOLDER, value);
				this._FILEORFOLDER = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FOLDERNAME
		{
			get{ return _FOLDERNAME; }
			set
			{
				this.OnPropertyValueChange(_.FOLDERNAME, _FOLDERNAME, value);
				this._FOLDERNAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PID
		{
			get{ return _PID; }
			set
			{
				this.OnPropertyValueChange(_.PID, _PID, value);
				this._PID = value;
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
		public decimal? MODULEID
		{
			get{ return _MODULEID; }
			set
			{
				this.OnPropertyValueChange(_.MODULEID, _MODULEID, value);
				this._MODULEID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SSJDID
		{
			get{ return _SSJDID; }
			set
			{
				this.OnPropertyValueChange(_.SSJDID, _SSJDID, value);
				this._SSJDID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ATTACHMENTID
		{
			get{ return _ATTACHMENTID; }
			set
			{
				this.OnPropertyValueChange(_.ATTACHMENTID, _ATTACHMENTID, value);
				this._ATTACHMENTID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CREATEID
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
		public string REMARK
		{
			get{ return _REMARK; }
			set
			{
				this.OnPropertyValueChange(_.REMARK, _REMARK, value);
				this._REMARK = value;
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
				_.FILEORFOLDER,
				_.FOLDERNAME,
				_.PID,
				_.ORDERID,
				_.ISPRIVATE,
				_.ISEDIT,
				_.MODULEID,
				_.SSJDID,
				_.ATTACHMENTID,
				_.CREATEID,
				_.CREATETIME,
				_.REMARK,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._FILEORFOLDER,
				this._FOLDERNAME,
				this._PID,
				this._ORDERID,
				this._ISPRIVATE,
				this._ISEDIT,
				this._MODULEID,
				this._SSJDID,
				this._ATTACHMENTID,
				this._CREATEID,
				this._CREATETIME,
				this._REMARK,
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
			public readonly static Field All = new Field("*", "SYS_DOCUMENTS");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "SYS_DOCUMENTS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FILEORFOLDER = new Field("FILEORFOLDER", "SYS_DOCUMENTS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FOLDERNAME = new Field("FOLDERNAME", "SYS_DOCUMENTS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PID = new Field("PID", "SYS_DOCUMENTS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ORDERID = new Field("ORDERID", "SYS_DOCUMENTS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISPRIVATE = new Field("ISPRIVATE", "SYS_DOCUMENTS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISEDIT = new Field("ISEDIT", "SYS_DOCUMENTS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MODULEID = new Field("MODULEID", "SYS_DOCUMENTS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SSJDID = new Field("SSJDID", "SYS_DOCUMENTS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ATTACHMENTID = new Field("ATTACHMENTID", "SYS_DOCUMENTS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATEID = new Field("CREATEID", "SYS_DOCUMENTS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATETIME = new Field("CREATETIME", "SYS_DOCUMENTS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "SYS_DOCUMENTS", "");
        }
        #endregion
	}
}