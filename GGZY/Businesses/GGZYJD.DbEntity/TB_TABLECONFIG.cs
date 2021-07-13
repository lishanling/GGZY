using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类TB_TABLECONFIG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TB_TABLECONFIG")]
    [Serializable]
    public partial class TB_TABLECONFIG : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _PTID;
		private string _TBNAME;
		private string _DBCONFIG;
		private string _TBSAVETBNAME;
		private decimal? _PAGESIZE;
		private string _HEADHTML;
		private decimal? _SELECTSQLTYPE;
		private string _SELECTSQL;
		private decimal? _INSERTSQLTYPE;
		private string _INSERTSQL;
		private decimal? _UPDATESQLTYPE;
		private string _UPDATESQL;
		private decimal? _DELETESQLTYPE;
		private string _DELETESQL;
		private string _FIELDIDS;
		private decimal? _TABLETYPE;
		private decimal? _ISADD;
		private decimal? _ISDELETE;
		private decimal? _ISEDIT;
		private decimal? _ISUPDATE;
		private decimal? _ISSORT;
		private string _SORTFIELD;
		private decimal? _ISIMPORT;
		private decimal? _IMPORTBEGINROW;
		private string _ISIMPORTXLSTEMP;
		private decimal? _ISEXPORT;
		private decimal? _EMPORTBEGINROW;
		private string _EMPORTXLSTEMP;
		private decimal? _ISHASROWNUM;
		private string _REMARK;
		private decimal? _EDITFORMWIDTH;
		private decimal? _EDITFORMHEIGHT;
		private string _ORDERFIELD;
		private decimal? _IMPORTSQLTYPE;
		private string _IMPORTSQL;
		private decimal? _EXPORTSQLTYPE;
		private string _EXPORTSQL;
		private string _LOGFIELDIDS;
		private decimal? _GETMODELSQLTYPE;
		private string _GETMODELSQL;
		private string _MODELTYPE;
		private string _PREVIEWADDRESS;

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
		public decimal? PTID
		{
			get{ return _PTID; }
			set
			{
				this.OnPropertyValueChange(_.PTID, _PTID, value);
				this._PTID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TBNAME
		{
			get{ return _TBNAME; }
			set
			{
				this.OnPropertyValueChange(_.TBNAME, _TBNAME, value);
				this._TBNAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DBCONFIG
		{
			get{ return _DBCONFIG; }
			set
			{
				this.OnPropertyValueChange(_.DBCONFIG, _DBCONFIG, value);
				this._DBCONFIG = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TBSAVETBNAME
		{
			get{ return _TBSAVETBNAME; }
			set
			{
				this.OnPropertyValueChange(_.TBSAVETBNAME, _TBSAVETBNAME, value);
				this._TBSAVETBNAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PAGESIZE
		{
			get{ return _PAGESIZE; }
			set
			{
				this.OnPropertyValueChange(_.PAGESIZE, _PAGESIZE, value);
				this._PAGESIZE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HEADHTML
		{
			get{ return _HEADHTML; }
			set
			{
				this.OnPropertyValueChange(_.HEADHTML, _HEADHTML, value);
				this._HEADHTML = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SELECTSQLTYPE
		{
			get{ return _SELECTSQLTYPE; }
			set
			{
				this.OnPropertyValueChange(_.SELECTSQLTYPE, _SELECTSQLTYPE, value);
				this._SELECTSQLTYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SELECTSQL
		{
			get{ return _SELECTSQL; }
			set
			{
				this.OnPropertyValueChange(_.SELECTSQL, _SELECTSQL, value);
				this._SELECTSQL = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? INSERTSQLTYPE
		{
			get{ return _INSERTSQLTYPE; }
			set
			{
				this.OnPropertyValueChange(_.INSERTSQLTYPE, _INSERTSQLTYPE, value);
				this._INSERTSQLTYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INSERTSQL
		{
			get{ return _INSERTSQL; }
			set
			{
				this.OnPropertyValueChange(_.INSERTSQL, _INSERTSQL, value);
				this._INSERTSQL = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? UPDATESQLTYPE
		{
			get{ return _UPDATESQLTYPE; }
			set
			{
				this.OnPropertyValueChange(_.UPDATESQLTYPE, _UPDATESQLTYPE, value);
				this._UPDATESQLTYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UPDATESQL
		{
			get{ return _UPDATESQL; }
			set
			{
				this.OnPropertyValueChange(_.UPDATESQL, _UPDATESQL, value);
				this._UPDATESQL = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DELETESQLTYPE
		{
			get{ return _DELETESQLTYPE; }
			set
			{
				this.OnPropertyValueChange(_.DELETESQLTYPE, _DELETESQLTYPE, value);
				this._DELETESQLTYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DELETESQL
		{
			get{ return _DELETESQL; }
			set
			{
				this.OnPropertyValueChange(_.DELETESQL, _DELETESQL, value);
				this._DELETESQL = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELDIDS
		{
			get{ return _FIELDIDS; }
			set
			{
				this.OnPropertyValueChange(_.FIELDIDS, _FIELDIDS, value);
				this._FIELDIDS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TABLETYPE
		{
			get{ return _TABLETYPE; }
			set
			{
				this.OnPropertyValueChange(_.TABLETYPE, _TABLETYPE, value);
				this._TABLETYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISADD
		{
			get{ return _ISADD; }
			set
			{
				this.OnPropertyValueChange(_.ISADD, _ISADD, value);
				this._ISADD = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISDELETE
		{
			get{ return _ISDELETE; }
			set
			{
				this.OnPropertyValueChange(_.ISDELETE, _ISDELETE, value);
				this._ISDELETE = value;
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
		public decimal? ISUPDATE
		{
			get{ return _ISUPDATE; }
			set
			{
				this.OnPropertyValueChange(_.ISUPDATE, _ISUPDATE, value);
				this._ISUPDATE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISSORT
		{
			get{ return _ISSORT; }
			set
			{
				this.OnPropertyValueChange(_.ISSORT, _ISSORT, value);
				this._ISSORT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SORTFIELD
		{
			get{ return _SORTFIELD; }
			set
			{
				this.OnPropertyValueChange(_.SORTFIELD, _SORTFIELD, value);
				this._SORTFIELD = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISIMPORT
		{
			get{ return _ISIMPORT; }
			set
			{
				this.OnPropertyValueChange(_.ISIMPORT, _ISIMPORT, value);
				this._ISIMPORT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? IMPORTBEGINROW
		{
			get{ return _IMPORTBEGINROW; }
			set
			{
				this.OnPropertyValueChange(_.IMPORTBEGINROW, _IMPORTBEGINROW, value);
				this._IMPORTBEGINROW = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ISIMPORTXLSTEMP
		{
			get{ return _ISIMPORTXLSTEMP; }
			set
			{
				this.OnPropertyValueChange(_.ISIMPORTXLSTEMP, _ISIMPORTXLSTEMP, value);
				this._ISIMPORTXLSTEMP = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISEXPORT
		{
			get{ return _ISEXPORT; }
			set
			{
				this.OnPropertyValueChange(_.ISEXPORT, _ISEXPORT, value);
				this._ISEXPORT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? EMPORTBEGINROW
		{
			get{ return _EMPORTBEGINROW; }
			set
			{
				this.OnPropertyValueChange(_.EMPORTBEGINROW, _EMPORTBEGINROW, value);
				this._EMPORTBEGINROW = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EMPORTXLSTEMP
		{
			get{ return _EMPORTXLSTEMP; }
			set
			{
				this.OnPropertyValueChange(_.EMPORTXLSTEMP, _EMPORTXLSTEMP, value);
				this._EMPORTXLSTEMP = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISHASROWNUM
		{
			get{ return _ISHASROWNUM; }
			set
			{
				this.OnPropertyValueChange(_.ISHASROWNUM, _ISHASROWNUM, value);
				this._ISHASROWNUM = value;
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
		public decimal? EDITFORMWIDTH
		{
			get{ return _EDITFORMWIDTH; }
			set
			{
				this.OnPropertyValueChange(_.EDITFORMWIDTH, _EDITFORMWIDTH, value);
				this._EDITFORMWIDTH = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? EDITFORMHEIGHT
		{
			get{ return _EDITFORMHEIGHT; }
			set
			{
				this.OnPropertyValueChange(_.EDITFORMHEIGHT, _EDITFORMHEIGHT, value);
				this._EDITFORMHEIGHT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ORDERFIELD
		{
			get{ return _ORDERFIELD; }
			set
			{
				this.OnPropertyValueChange(_.ORDERFIELD, _ORDERFIELD, value);
				this._ORDERFIELD = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? IMPORTSQLTYPE
		{
			get{ return _IMPORTSQLTYPE; }
			set
			{
				this.OnPropertyValueChange(_.IMPORTSQLTYPE, _IMPORTSQLTYPE, value);
				this._IMPORTSQLTYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IMPORTSQL
		{
			get{ return _IMPORTSQL; }
			set
			{
				this.OnPropertyValueChange(_.IMPORTSQL, _IMPORTSQL, value);
				this._IMPORTSQL = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? EXPORTSQLTYPE
		{
			get{ return _EXPORTSQLTYPE; }
			set
			{
				this.OnPropertyValueChange(_.EXPORTSQLTYPE, _EXPORTSQLTYPE, value);
				this._EXPORTSQLTYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EXPORTSQL
		{
			get{ return _EXPORTSQL; }
			set
			{
				this.OnPropertyValueChange(_.EXPORTSQL, _EXPORTSQL, value);
				this._EXPORTSQL = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LOGFIELDIDS
		{
			get{ return _LOGFIELDIDS; }
			set
			{
				this.OnPropertyValueChange(_.LOGFIELDIDS, _LOGFIELDIDS, value);
				this._LOGFIELDIDS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? GETMODELSQLTYPE
		{
			get{ return _GETMODELSQLTYPE; }
			set
			{
				this.OnPropertyValueChange(_.GETMODELSQLTYPE, _GETMODELSQLTYPE, value);
				this._GETMODELSQLTYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GETMODELSQL
		{
			get{ return _GETMODELSQL; }
			set
			{
				this.OnPropertyValueChange(_.GETMODELSQL, _GETMODELSQL, value);
				this._GETMODELSQL = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MODELTYPE
		{
			get{ return _MODELTYPE; }
			set
			{
				this.OnPropertyValueChange(_.MODELTYPE, _MODELTYPE, value);
				this._MODELTYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PREVIEWADDRESS
		{
			get{ return _PREVIEWADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.PREVIEWADDRESS, _PREVIEWADDRESS, value);
				this._PREVIEWADDRESS = value;
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
				_.PTID,
				_.TBNAME,
				_.DBCONFIG,
				_.TBSAVETBNAME,
				_.PAGESIZE,
				_.HEADHTML,
				_.SELECTSQLTYPE,
				_.SELECTSQL,
				_.INSERTSQLTYPE,
				_.INSERTSQL,
				_.UPDATESQLTYPE,
				_.UPDATESQL,
				_.DELETESQLTYPE,
				_.DELETESQL,
				_.FIELDIDS,
				_.TABLETYPE,
				_.ISADD,
				_.ISDELETE,
				_.ISEDIT,
				_.ISUPDATE,
				_.ISSORT,
				_.SORTFIELD,
				_.ISIMPORT,
				_.IMPORTBEGINROW,
				_.ISIMPORTXLSTEMP,
				_.ISEXPORT,
				_.EMPORTBEGINROW,
				_.EMPORTXLSTEMP,
				_.ISHASROWNUM,
				_.REMARK,
				_.EDITFORMWIDTH,
				_.EDITFORMHEIGHT,
				_.ORDERFIELD,
				_.IMPORTSQLTYPE,
				_.IMPORTSQL,
				_.EXPORTSQLTYPE,
				_.EXPORTSQL,
				_.LOGFIELDIDS,
				_.GETMODELSQLTYPE,
				_.GETMODELSQL,
				_.MODELTYPE,
				_.PREVIEWADDRESS,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._PTID,
				this._TBNAME,
				this._DBCONFIG,
				this._TBSAVETBNAME,
				this._PAGESIZE,
				this._HEADHTML,
				this._SELECTSQLTYPE,
				this._SELECTSQL,
				this._INSERTSQLTYPE,
				this._INSERTSQL,
				this._UPDATESQLTYPE,
				this._UPDATESQL,
				this._DELETESQLTYPE,
				this._DELETESQL,
				this._FIELDIDS,
				this._TABLETYPE,
				this._ISADD,
				this._ISDELETE,
				this._ISEDIT,
				this._ISUPDATE,
				this._ISSORT,
				this._SORTFIELD,
				this._ISIMPORT,
				this._IMPORTBEGINROW,
				this._ISIMPORTXLSTEMP,
				this._ISEXPORT,
				this._EMPORTBEGINROW,
				this._EMPORTXLSTEMP,
				this._ISHASROWNUM,
				this._REMARK,
				this._EDITFORMWIDTH,
				this._EDITFORMHEIGHT,
				this._ORDERFIELD,
				this._IMPORTSQLTYPE,
				this._IMPORTSQL,
				this._EXPORTSQLTYPE,
				this._EXPORTSQL,
				this._LOGFIELDIDS,
				this._GETMODELSQLTYPE,
				this._GETMODELSQL,
				this._MODELTYPE,
				this._PREVIEWADDRESS,
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
			public readonly static Field All = new Field("*", "TB_TABLECONFIG");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PTID = new Field("PTID", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TBNAME = new Field("TBNAME", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DBCONFIG = new Field("DBCONFIG", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TBSAVETBNAME = new Field("TBSAVETBNAME", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PAGESIZE = new Field("PAGESIZE", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field HEADHTML = new Field("HEADHTML", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SELECTSQLTYPE = new Field("SELECTSQLTYPE", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SELECTSQL = new Field("SELECTSQL", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field INSERTSQLTYPE = new Field("INSERTSQLTYPE", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field INSERTSQL = new Field("INSERTSQL", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UPDATESQLTYPE = new Field("UPDATESQLTYPE", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UPDATESQL = new Field("UPDATESQL", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DELETESQLTYPE = new Field("DELETESQLTYPE", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DELETESQL = new Field("DELETESQL", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELDIDS = new Field("FIELDIDS", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TABLETYPE = new Field("TABLETYPE", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISADD = new Field("ISADD", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISDELETE = new Field("ISDELETE", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISEDIT = new Field("ISEDIT", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISUPDATE = new Field("ISUPDATE", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISSORT = new Field("ISSORT", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SORTFIELD = new Field("SORTFIELD", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISIMPORT = new Field("ISIMPORT", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IMPORTBEGINROW = new Field("IMPORTBEGINROW", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISIMPORTXLSTEMP = new Field("ISIMPORTXLSTEMP", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISEXPORT = new Field("ISEXPORT", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field EMPORTBEGINROW = new Field("EMPORTBEGINROW", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field EMPORTXLSTEMP = new Field("EMPORTXLSTEMP", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISHASROWNUM = new Field("ISHASROWNUM", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field EDITFORMWIDTH = new Field("EDITFORMWIDTH", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field EDITFORMHEIGHT = new Field("EDITFORMHEIGHT", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ORDERFIELD = new Field("ORDERFIELD", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IMPORTSQLTYPE = new Field("IMPORTSQLTYPE", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IMPORTSQL = new Field("IMPORTSQL", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field EXPORTSQLTYPE = new Field("EXPORTSQLTYPE", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field EXPORTSQL = new Field("EXPORTSQL", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LOGFIELDIDS = new Field("LOGFIELDIDS", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GETMODELSQLTYPE = new Field("GETMODELSQLTYPE", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GETMODELSQL = new Field("GETMODELSQL", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MODELTYPE = new Field("MODELTYPE", "TB_TABLECONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PREVIEWADDRESS = new Field("PREVIEWADDRESS", "TB_TABLECONFIG", "");
        }
        #endregion
	}
}