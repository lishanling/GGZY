using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ZJPRI_EMPLOYEES_QUALI。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJPRI_EMPLOYEES_QUALI")]
    [Serializable]
    public partial class ZJPRI_EMPLOYEES_QUALI : FwEntity
    {
        #region Model
		private decimal? _CERTIFICATEID;
		private string _BASEPERSONNAME;
		private string _IDENTITYCARDNUMBER;
		private string _CERTIFICATEORGAN;
		private DateTime? _CERTIFICATETIME;
		private string _CERTIFICATENUMBER;
		private DateTime? _PERIODTIME;
		private string _WORKUNIT;
		private decimal? _CERTIFICATETYPEID;
		private string _CERTIFICATETYPENAME;
		private decimal? _ISCANCEL;
		private decimal? _KIND;
		private string _KINDNAME;
		private string _GUID;
		private decimal? _BASEID;
		private DateTime? _CREATE_TIME;
		private string _VERSION;
		private string _DATA_SOURCE;
		private string _CERTIFICATE_FILE;

		/// <summary>
		/// 证书ID
		/// </summary>
		public decimal? CERTIFICATEID
		{
			get{ return _CERTIFICATEID; }
			set
			{
				this.OnPropertyValueChange(_.CERTIFICATEID, _CERTIFICATEID, value);
				this._CERTIFICATEID = value;
			}
		}
		/// <summary>
		/// 姓名
		/// </summary>
		public string BASEPERSONNAME
		{
			get{ return _BASEPERSONNAME; }
			set
			{
				this.OnPropertyValueChange(_.BASEPERSONNAME, _BASEPERSONNAME, value);
				this._BASEPERSONNAME = value;
			}
		}
		/// <summary>
		/// 身份证号码
		/// </summary>
		public string IDENTITYCARDNUMBER
		{
			get{ return _IDENTITYCARDNUMBER; }
			set
			{
				this.OnPropertyValueChange(_.IDENTITYCARDNUMBER, _IDENTITYCARDNUMBER, value);
				this._IDENTITYCARDNUMBER = value;
			}
		}
		/// <summary>
		/// 发证单位
		/// </summary>
		public string CERTIFICATEORGAN
		{
			get{ return _CERTIFICATEORGAN; }
			set
			{
				this.OnPropertyValueChange(_.CERTIFICATEORGAN, _CERTIFICATEORGAN, value);
				this._CERTIFICATEORGAN = value;
			}
		}
		/// <summary>
		/// 发证时间
		/// </summary>
		public DateTime? CERTIFICATETIME
		{
			get{ return _CERTIFICATETIME; }
			set
			{
				this.OnPropertyValueChange(_.CERTIFICATETIME, _CERTIFICATETIME, value);
				this._CERTIFICATETIME = value;
			}
		}
		/// <summary>
		/// 证书编号
		/// </summary>
		public string CERTIFICATENUMBER
		{
			get{ return _CERTIFICATENUMBER; }
			set
			{
				this.OnPropertyValueChange(_.CERTIFICATENUMBER, _CERTIFICATENUMBER, value);
				this._CERTIFICATENUMBER = value;
			}
		}
		/// <summary>
		/// 证书有效期
		/// </summary>
		public DateTime? PERIODTIME
		{
			get{ return _PERIODTIME; }
			set
			{
				this.OnPropertyValueChange(_.PERIODTIME, _PERIODTIME, value);
				this._PERIODTIME = value;
			}
		}
		/// <summary>
		/// 持证单位
		/// </summary>
		public string WORKUNIT
		{
			get{ return _WORKUNIT; }
			set
			{
				this.OnPropertyValueChange(_.WORKUNIT, _WORKUNIT, value);
				this._WORKUNIT = value;
			}
		}
		/// <summary>
		/// 证书类型ID
		/// </summary>
		public decimal? CERTIFICATETYPEID
		{
			get{ return _CERTIFICATETYPEID; }
			set
			{
				this.OnPropertyValueChange(_.CERTIFICATETYPEID, _CERTIFICATETYPEID, value);
				this._CERTIFICATETYPEID = value;
			}
		}
		/// <summary>
		/// 证书类型名称
		/// </summary>
		public string CERTIFICATETYPENAME
		{
			get{ return _CERTIFICATETYPENAME; }
			set
			{
				this.OnPropertyValueChange(_.CERTIFICATETYPENAME, _CERTIFICATETYPENAME, value);
				this._CERTIFICATETYPENAME = value;
			}
		}
		/// <summary>
		/// 证书状态
		/// </summary>
		public decimal? ISCANCEL
		{
			get{ return _ISCANCEL; }
			set
			{
				this.OnPropertyValueChange(_.ISCANCEL, _ISCANCEL, value);
				this._ISCANCEL = value;
			}
		}
		/// <summary>
		/// 证书类别主键
		/// </summary>
		public decimal? KIND
		{
			get{ return _KIND; }
			set
			{
				this.OnPropertyValueChange(_.KIND, _KIND, value);
				this._KIND = value;
			}
		}
		/// <summary>
		/// 证书类别名称
		/// </summary>
		public string KINDNAME
		{
			get{ return _KINDNAME; }
			set
			{
				this.OnPropertyValueChange(_.KINDNAME, _KINDNAME, value);
				this._KINDNAME = value;
			}
		}
		/// <summary>
		/// 全局唯一标识符
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
		/// 人员ID
		/// </summary>
		public decimal? BASEID
		{
			get{ return _BASEID; }
			set
			{
				this.OnPropertyValueChange(_.BASEID, _BASEID, value);
				this._BASEID = value;
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
		/// 版本号
		/// </summary>
		public string VERSION
		{
			get{ return _VERSION; }
			set
			{
				this.OnPropertyValueChange(_.VERSION, _VERSION, value);
				this._VERSION = value;
			}
		}
		/// <summary>
		/// 数据来源
		/// </summary>
		public string DATA_SOURCE
		{
			get{ return _DATA_SOURCE; }
			set
			{
				this.OnPropertyValueChange(_.DATA_SOURCE, _DATA_SOURCE, value);
				this._DATA_SOURCE = value;
			}
		}
		/// <summary>
		/// 从业证书
		/// </summary>
		public string CERTIFICATE_FILE
		{
			get{ return _CERTIFICATE_FILE; }
			set
			{
				this.OnPropertyValueChange(_.CERTIFICATE_FILE, _CERTIFICATE_FILE, value);
				this._CERTIFICATE_FILE = value;
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
				_.CERTIFICATEID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.CERTIFICATEID,
				_.BASEPERSONNAME,
				_.IDENTITYCARDNUMBER,
				_.CERTIFICATEORGAN,
				_.CERTIFICATETIME,
				_.CERTIFICATENUMBER,
				_.PERIODTIME,
				_.WORKUNIT,
				_.CERTIFICATETYPEID,
				_.CERTIFICATETYPENAME,
				_.ISCANCEL,
				_.KIND,
				_.KINDNAME,
				_.GUID,
				_.BASEID,
				_.CREATE_TIME,
				_.VERSION,
				_.DATA_SOURCE,
				_.CERTIFICATE_FILE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._CERTIFICATEID,
				this._BASEPERSONNAME,
				this._IDENTITYCARDNUMBER,
				this._CERTIFICATEORGAN,
				this._CERTIFICATETIME,
				this._CERTIFICATENUMBER,
				this._PERIODTIME,
				this._WORKUNIT,
				this._CERTIFICATETYPEID,
				this._CERTIFICATETYPENAME,
				this._ISCANCEL,
				this._KIND,
				this._KINDNAME,
				this._GUID,
				this._BASEID,
				this._CREATE_TIME,
				this._VERSION,
				this._DATA_SOURCE,
				this._CERTIFICATE_FILE,
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
			public readonly static Field All = new Field("*", "ZJPRI_EMPLOYEES_QUALI");
            /// <summary>
			/// 证书ID
			/// </summary>
			public readonly static Field CERTIFICATEID = new Field("CERTIFICATEID", "ZJPRI_EMPLOYEES_QUALI", "证书ID");
            /// <summary>
			/// 姓名
			/// </summary>
			public readonly static Field BASEPERSONNAME = new Field("BASEPERSONNAME", "ZJPRI_EMPLOYEES_QUALI", "姓名");
            /// <summary>
			/// 身份证号码
			/// </summary>
			public readonly static Field IDENTITYCARDNUMBER = new Field("IDENTITYCARDNUMBER", "ZJPRI_EMPLOYEES_QUALI", "身份证号码");
            /// <summary>
			/// 发证单位
			/// </summary>
			public readonly static Field CERTIFICATEORGAN = new Field("CERTIFICATEORGAN", "ZJPRI_EMPLOYEES_QUALI", "发证单位");
            /// <summary>
			/// 发证时间
			/// </summary>
			public readonly static Field CERTIFICATETIME = new Field("CERTIFICATETIME", "ZJPRI_EMPLOYEES_QUALI", "发证时间");
            /// <summary>
			/// 证书编号
			/// </summary>
			public readonly static Field CERTIFICATENUMBER = new Field("CERTIFICATENUMBER", "ZJPRI_EMPLOYEES_QUALI", "证书编号");
            /// <summary>
			/// 证书有效期
			/// </summary>
			public readonly static Field PERIODTIME = new Field("PERIODTIME", "ZJPRI_EMPLOYEES_QUALI", "证书有效期");
            /// <summary>
			/// 持证单位
			/// </summary>
			public readonly static Field WORKUNIT = new Field("WORKUNIT", "ZJPRI_EMPLOYEES_QUALI", "持证单位");
            /// <summary>
			/// 证书类型ID
			/// </summary>
			public readonly static Field CERTIFICATETYPEID = new Field("CERTIFICATETYPEID", "ZJPRI_EMPLOYEES_QUALI", "证书类型ID");
            /// <summary>
			/// 证书类型名称
			/// </summary>
			public readonly static Field CERTIFICATETYPENAME = new Field("CERTIFICATETYPENAME", "ZJPRI_EMPLOYEES_QUALI", "证书类型名称");
            /// <summary>
			/// 证书状态
			/// </summary>
			public readonly static Field ISCANCEL = new Field("ISCANCEL", "ZJPRI_EMPLOYEES_QUALI", "证书状态");
            /// <summary>
			/// 证书类别主键
			/// </summary>
			public readonly static Field KIND = new Field("KIND", "ZJPRI_EMPLOYEES_QUALI", "证书类别主键");
            /// <summary>
			/// 证书类别名称
			/// </summary>
			public readonly static Field KINDNAME = new Field("KINDNAME", "ZJPRI_EMPLOYEES_QUALI", "证书类别名称");
            /// <summary>
			/// 全局唯一标识符
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "ZJPRI_EMPLOYEES_QUALI", "全局唯一标识符");
            /// <summary>
			/// 人员ID
			/// </summary>
			public readonly static Field BASEID = new Field("BASEID", "ZJPRI_EMPLOYEES_QUALI", "人员ID");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "ZJPRI_EMPLOYEES_QUALI", "创建时间");
            /// <summary>
			/// 版本号
			/// </summary>
			public readonly static Field VERSION = new Field("VERSION", "ZJPRI_EMPLOYEES_QUALI", "版本号");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field DATA_SOURCE = new Field("DATA_SOURCE", "ZJPRI_EMPLOYEES_QUALI", "数据来源");
            /// <summary>
			/// 从业证书
			/// </summary>
			public readonly static Field CERTIFICATE_FILE = new Field("CERTIFICATE_FILE", "ZJPRI_EMPLOYEES_QUALI", "从业证书");
        }
        #endregion
	}
}