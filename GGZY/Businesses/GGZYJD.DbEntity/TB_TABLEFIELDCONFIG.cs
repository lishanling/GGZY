using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类TB_TABLEFIELDCONFIG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TB_TABLEFIELDCONFIG")]
    [Serializable]
    public partial class TB_TABLEFIELDCONFIG : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _TCID;
		private string _FNAME;
		private string _FVALUE;
		private string _PHYSICALCOLNAME;
		private string _FTYPE;
		private decimal? _ISKEY;
		private decimal? _ISNULL;
		private decimal? _ISSTATISTICS;
		private string _FROEIGNTB;
		private string _FROEIGNNAME;
		private string _FROEIGNVALUE;
		private string _FROEIGNSQL;
		private decimal? _ISSEARCHFIELD;
		private decimal? _SEARCHTYPE;
		private string _SEARCHSQL;
		private decimal? _SEARCHORDER;
		private decimal? _MINLEN;
		private decimal? _MAXLEN;
		private decimal? _SIGNIFICANTDIGIT;
		private decimal? _DECIMALCOUNT;
		private string _REGULAR;
		private decimal? _ORDERID;
		private decimal? _FIELDWIDTH;
		private decimal? _ISVISIABLE;
		private decimal? _ISSELFADD;
		private string _DEFAULTVALUE;
		private string _TEXTALGIN;
		private string _SQLFORMAT;
		private decimal? _ISMUST;
		private string _UNIT;
		private decimal? _CONTROLTYPE;
		private decimal? _EDITPAGEORDERID;
		private decimal? _COLSPAN;
		private string _CONTROLHEIGHT;
		private string _CONTROLWIDTH;
		private decimal? _ISIDENTITY;
		private decimal? _ISADD;
		private string _ADDINITTYPE;
		private decimal? _ISEMPORT;
		private decimal? _FIELDTAG;
		private string _FIELDPAR;
		private string _REMARK;
		private string _FORMATMETHOD;
		private string _FORMATPAR;
		private string _LINKID;
		private string _LINKSQL;
		private string _FROEIGNSQLFORAUDIT;
		private string _VALIMSG;
		private decimal? _ISIMPORT;

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
		public decimal? TCID
		{
			get{ return _TCID; }
			set
			{
				this.OnPropertyValueChange(_.TCID, _TCID, value);
				this._TCID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FNAME
		{
			get{ return _FNAME; }
			set
			{
				this.OnPropertyValueChange(_.FNAME, _FNAME, value);
				this._FNAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FVALUE
		{
			get{ return _FVALUE; }
			set
			{
				this.OnPropertyValueChange(_.FVALUE, _FVALUE, value);
				this._FVALUE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PHYSICALCOLNAME
		{
			get{ return _PHYSICALCOLNAME; }
			set
			{
				this.OnPropertyValueChange(_.PHYSICALCOLNAME, _PHYSICALCOLNAME, value);
				this._PHYSICALCOLNAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FTYPE
		{
			get{ return _FTYPE; }
			set
			{
				this.OnPropertyValueChange(_.FTYPE, _FTYPE, value);
				this._FTYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISKEY
		{
			get{ return _ISKEY; }
			set
			{
				this.OnPropertyValueChange(_.ISKEY, _ISKEY, value);
				this._ISKEY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISNULL
		{
			get{ return _ISNULL; }
			set
			{
				this.OnPropertyValueChange(_.ISNULL, _ISNULL, value);
				this._ISNULL = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISSTATISTICS
		{
			get{ return _ISSTATISTICS; }
			set
			{
				this.OnPropertyValueChange(_.ISSTATISTICS, _ISSTATISTICS, value);
				this._ISSTATISTICS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FROEIGNTB
		{
			get{ return _FROEIGNTB; }
			set
			{
				this.OnPropertyValueChange(_.FROEIGNTB, _FROEIGNTB, value);
				this._FROEIGNTB = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FROEIGNNAME
		{
			get{ return _FROEIGNNAME; }
			set
			{
				this.OnPropertyValueChange(_.FROEIGNNAME, _FROEIGNNAME, value);
				this._FROEIGNNAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FROEIGNVALUE
		{
			get{ return _FROEIGNVALUE; }
			set
			{
				this.OnPropertyValueChange(_.FROEIGNVALUE, _FROEIGNVALUE, value);
				this._FROEIGNVALUE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FROEIGNSQL
		{
			get{ return _FROEIGNSQL; }
			set
			{
				this.OnPropertyValueChange(_.FROEIGNSQL, _FROEIGNSQL, value);
				this._FROEIGNSQL = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISSEARCHFIELD
		{
			get{ return _ISSEARCHFIELD; }
			set
			{
				this.OnPropertyValueChange(_.ISSEARCHFIELD, _ISSEARCHFIELD, value);
				this._ISSEARCHFIELD = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SEARCHTYPE
		{
			get{ return _SEARCHTYPE; }
			set
			{
				this.OnPropertyValueChange(_.SEARCHTYPE, _SEARCHTYPE, value);
				this._SEARCHTYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SEARCHSQL
		{
			get{ return _SEARCHSQL; }
			set
			{
				this.OnPropertyValueChange(_.SEARCHSQL, _SEARCHSQL, value);
				this._SEARCHSQL = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SEARCHORDER
		{
			get{ return _SEARCHORDER; }
			set
			{
				this.OnPropertyValueChange(_.SEARCHORDER, _SEARCHORDER, value);
				this._SEARCHORDER = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? MINLEN
		{
			get{ return _MINLEN; }
			set
			{
				this.OnPropertyValueChange(_.MINLEN, _MINLEN, value);
				this._MINLEN = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? MAXLEN
		{
			get{ return _MAXLEN; }
			set
			{
				this.OnPropertyValueChange(_.MAXLEN, _MAXLEN, value);
				this._MAXLEN = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SIGNIFICANTDIGIT
		{
			get{ return _SIGNIFICANTDIGIT; }
			set
			{
				this.OnPropertyValueChange(_.SIGNIFICANTDIGIT, _SIGNIFICANTDIGIT, value);
				this._SIGNIFICANTDIGIT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DECIMALCOUNT
		{
			get{ return _DECIMALCOUNT; }
			set
			{
				this.OnPropertyValueChange(_.DECIMALCOUNT, _DECIMALCOUNT, value);
				this._DECIMALCOUNT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string REGULAR
		{
			get{ return _REGULAR; }
			set
			{
				this.OnPropertyValueChange(_.REGULAR, _REGULAR, value);
				this._REGULAR = value;
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
		public decimal? FIELDWIDTH
		{
			get{ return _FIELDWIDTH; }
			set
			{
				this.OnPropertyValueChange(_.FIELDWIDTH, _FIELDWIDTH, value);
				this._FIELDWIDTH = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISVISIABLE
		{
			get{ return _ISVISIABLE; }
			set
			{
				this.OnPropertyValueChange(_.ISVISIABLE, _ISVISIABLE, value);
				this._ISVISIABLE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISSELFADD
		{
			get{ return _ISSELFADD; }
			set
			{
				this.OnPropertyValueChange(_.ISSELFADD, _ISSELFADD, value);
				this._ISSELFADD = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DEFAULTVALUE
		{
			get{ return _DEFAULTVALUE; }
			set
			{
				this.OnPropertyValueChange(_.DEFAULTVALUE, _DEFAULTVALUE, value);
				this._DEFAULTVALUE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TEXTALGIN
		{
			get{ return _TEXTALGIN; }
			set
			{
				this.OnPropertyValueChange(_.TEXTALGIN, _TEXTALGIN, value);
				this._TEXTALGIN = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SQLFORMAT
		{
			get{ return _SQLFORMAT; }
			set
			{
				this.OnPropertyValueChange(_.SQLFORMAT, _SQLFORMAT, value);
				this._SQLFORMAT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISMUST
		{
			get{ return _ISMUST; }
			set
			{
				this.OnPropertyValueChange(_.ISMUST, _ISMUST, value);
				this._ISMUST = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UNIT
		{
			get{ return _UNIT; }
			set
			{
				this.OnPropertyValueChange(_.UNIT, _UNIT, value);
				this._UNIT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CONTROLTYPE
		{
			get{ return _CONTROLTYPE; }
			set
			{
				this.OnPropertyValueChange(_.CONTROLTYPE, _CONTROLTYPE, value);
				this._CONTROLTYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? EDITPAGEORDERID
		{
			get{ return _EDITPAGEORDERID; }
			set
			{
				this.OnPropertyValueChange(_.EDITPAGEORDERID, _EDITPAGEORDERID, value);
				this._EDITPAGEORDERID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? COLSPAN
		{
			get{ return _COLSPAN; }
			set
			{
				this.OnPropertyValueChange(_.COLSPAN, _COLSPAN, value);
				this._COLSPAN = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CONTROLHEIGHT
		{
			get{ return _CONTROLHEIGHT; }
			set
			{
				this.OnPropertyValueChange(_.CONTROLHEIGHT, _CONTROLHEIGHT, value);
				this._CONTROLHEIGHT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CONTROLWIDTH
		{
			get{ return _CONTROLWIDTH; }
			set
			{
				this.OnPropertyValueChange(_.CONTROLWIDTH, _CONTROLWIDTH, value);
				this._CONTROLWIDTH = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISIDENTITY
		{
			get{ return _ISIDENTITY; }
			set
			{
				this.OnPropertyValueChange(_.ISIDENTITY, _ISIDENTITY, value);
				this._ISIDENTITY = value;
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
		public string ADDINITTYPE
		{
			get{ return _ADDINITTYPE; }
			set
			{
				this.OnPropertyValueChange(_.ADDINITTYPE, _ADDINITTYPE, value);
				this._ADDINITTYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISEMPORT
		{
			get{ return _ISEMPORT; }
			set
			{
				this.OnPropertyValueChange(_.ISEMPORT, _ISEMPORT, value);
				this._ISEMPORT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FIELDTAG
		{
			get{ return _FIELDTAG; }
			set
			{
				this.OnPropertyValueChange(_.FIELDTAG, _FIELDTAG, value);
				this._FIELDTAG = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELDPAR
		{
			get{ return _FIELDPAR; }
			set
			{
				this.OnPropertyValueChange(_.FIELDPAR, _FIELDPAR, value);
				this._FIELDPAR = value;
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
		public string FORMATMETHOD
		{
			get{ return _FORMATMETHOD; }
			set
			{
				this.OnPropertyValueChange(_.FORMATMETHOD, _FORMATMETHOD, value);
				this._FORMATMETHOD = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FORMATPAR
		{
			get{ return _FORMATPAR; }
			set
			{
				this.OnPropertyValueChange(_.FORMATPAR, _FORMATPAR, value);
				this._FORMATPAR = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LINKID
		{
			get{ return _LINKID; }
			set
			{
				this.OnPropertyValueChange(_.LINKID, _LINKID, value);
				this._LINKID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LINKSQL
		{
			get{ return _LINKSQL; }
			set
			{
				this.OnPropertyValueChange(_.LINKSQL, _LINKSQL, value);
				this._LINKSQL = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FROEIGNSQLFORAUDIT
		{
			get{ return _FROEIGNSQLFORAUDIT; }
			set
			{
				this.OnPropertyValueChange(_.FROEIGNSQLFORAUDIT, _FROEIGNSQLFORAUDIT, value);
				this._FROEIGNSQLFORAUDIT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VALIMSG
		{
			get{ return _VALIMSG; }
			set
			{
				this.OnPropertyValueChange(_.VALIMSG, _VALIMSG, value);
				this._VALIMSG = value;
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
				_.TCID,
				_.FNAME,
				_.FVALUE,
				_.PHYSICALCOLNAME,
				_.FTYPE,
				_.ISKEY,
				_.ISNULL,
				_.ISSTATISTICS,
				_.FROEIGNTB,
				_.FROEIGNNAME,
				_.FROEIGNVALUE,
				_.FROEIGNSQL,
				_.ISSEARCHFIELD,
				_.SEARCHTYPE,
				_.SEARCHSQL,
				_.SEARCHORDER,
				_.MINLEN,
				_.MAXLEN,
				_.SIGNIFICANTDIGIT,
				_.DECIMALCOUNT,
				_.REGULAR,
				_.ORDERID,
				_.FIELDWIDTH,
				_.ISVISIABLE,
				_.ISSELFADD,
				_.DEFAULTVALUE,
				_.TEXTALGIN,
				_.SQLFORMAT,
				_.ISMUST,
				_.UNIT,
				_.CONTROLTYPE,
				_.EDITPAGEORDERID,
				_.COLSPAN,
				_.CONTROLHEIGHT,
				_.CONTROLWIDTH,
				_.ISIDENTITY,
				_.ISADD,
				_.ADDINITTYPE,
				_.ISEMPORT,
				_.FIELDTAG,
				_.FIELDPAR,
				_.REMARK,
				_.FORMATMETHOD,
				_.FORMATPAR,
				_.LINKID,
				_.LINKSQL,
				_.FROEIGNSQLFORAUDIT,
				_.VALIMSG,
				_.ISIMPORT,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._TCID,
				this._FNAME,
				this._FVALUE,
				this._PHYSICALCOLNAME,
				this._FTYPE,
				this._ISKEY,
				this._ISNULL,
				this._ISSTATISTICS,
				this._FROEIGNTB,
				this._FROEIGNNAME,
				this._FROEIGNVALUE,
				this._FROEIGNSQL,
				this._ISSEARCHFIELD,
				this._SEARCHTYPE,
				this._SEARCHSQL,
				this._SEARCHORDER,
				this._MINLEN,
				this._MAXLEN,
				this._SIGNIFICANTDIGIT,
				this._DECIMALCOUNT,
				this._REGULAR,
				this._ORDERID,
				this._FIELDWIDTH,
				this._ISVISIABLE,
				this._ISSELFADD,
				this._DEFAULTVALUE,
				this._TEXTALGIN,
				this._SQLFORMAT,
				this._ISMUST,
				this._UNIT,
				this._CONTROLTYPE,
				this._EDITPAGEORDERID,
				this._COLSPAN,
				this._CONTROLHEIGHT,
				this._CONTROLWIDTH,
				this._ISIDENTITY,
				this._ISADD,
				this._ADDINITTYPE,
				this._ISEMPORT,
				this._FIELDTAG,
				this._FIELDPAR,
				this._REMARK,
				this._FORMATMETHOD,
				this._FORMATPAR,
				this._LINKID,
				this._LINKSQL,
				this._FROEIGNSQLFORAUDIT,
				this._VALIMSG,
				this._ISIMPORT,
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
			public readonly static Field All = new Field("*", "TB_TABLEFIELDCONFIG");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TCID = new Field("TCID", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FNAME = new Field("FNAME", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FVALUE = new Field("FVALUE", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PHYSICALCOLNAME = new Field("PHYSICALCOLNAME", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FTYPE = new Field("FTYPE", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISKEY = new Field("ISKEY", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISNULL = new Field("ISNULL", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISSTATISTICS = new Field("ISSTATISTICS", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FROEIGNTB = new Field("FROEIGNTB", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FROEIGNNAME = new Field("FROEIGNNAME", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FROEIGNVALUE = new Field("FROEIGNVALUE", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FROEIGNSQL = new Field("FROEIGNSQL", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISSEARCHFIELD = new Field("ISSEARCHFIELD", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SEARCHTYPE = new Field("SEARCHTYPE", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SEARCHSQL = new Field("SEARCHSQL", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SEARCHORDER = new Field("SEARCHORDER", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MINLEN = new Field("MINLEN", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MAXLEN = new Field("MAXLEN", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SIGNIFICANTDIGIT = new Field("SIGNIFICANTDIGIT", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DECIMALCOUNT = new Field("DECIMALCOUNT", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REGULAR = new Field("REGULAR", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ORDERID = new Field("ORDERID", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELDWIDTH = new Field("FIELDWIDTH", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISVISIABLE = new Field("ISVISIABLE", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISSELFADD = new Field("ISSELFADD", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DEFAULTVALUE = new Field("DEFAULTVALUE", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TEXTALGIN = new Field("TEXTALGIN", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SQLFORMAT = new Field("SQLFORMAT", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISMUST = new Field("ISMUST", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UNIT = new Field("UNIT", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONTROLTYPE = new Field("CONTROLTYPE", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field EDITPAGEORDERID = new Field("EDITPAGEORDERID", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field COLSPAN = new Field("COLSPAN", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONTROLHEIGHT = new Field("CONTROLHEIGHT", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONTROLWIDTH = new Field("CONTROLWIDTH", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISIDENTITY = new Field("ISIDENTITY", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISADD = new Field("ISADD", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ADDINITTYPE = new Field("ADDINITTYPE", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISEMPORT = new Field("ISEMPORT", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELDTAG = new Field("FIELDTAG", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELDPAR = new Field("FIELDPAR", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FORMATMETHOD = new Field("FORMATMETHOD", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FORMATPAR = new Field("FORMATPAR", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LINKID = new Field("LINKID", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LINKSQL = new Field("LINKSQL", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FROEIGNSQLFORAUDIT = new Field("FROEIGNSQLFORAUDIT", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field VALIMSG = new Field("VALIMSG", "TB_TABLEFIELDCONFIG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISIMPORT = new Field("ISIMPORT", "TB_TABLEFIELDCONFIG", "");
        }
        #endregion
	}
}