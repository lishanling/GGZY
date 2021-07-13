using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ZJPRI_CONSTRUCT_QUALI_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJPRI_CONSTRUCT_QUALI_INFO")]
    [Serializable]
    public partial class ZJPRI_CONSTRUCT_QUALI_INFO : FwEntity
    {
        #region Model
		private decimal? _QUALIFYID;
		private decimal? _COMPANYID;
		private string _NAME;
		private decimal? _QUALIFYSEQUENCEID;
		private string _QUALIFYSEQUENCENAME;
		private decimal? _QUALIFYTYPEID;
		private string _QUALIFYTYPENAME;
		private decimal? _QUALIFYLEVELID;
		private string _QUALIFYLEVELNAME;
		private DateTime? _APPROVETIME;
		private string _APPROVEDOCNUM;
		private decimal? _QUALIFYALLOWSTATE;
		private decimal? _KIND;
		private decimal? _BUSINESSSYSTEMTYPEID;
		private string _BUSINESSSYSTEMTYPENAME;
		private decimal? _AREA;
		private string _COUNTRYWIDENAME;
		private string _GUID;
		private DateTime? _CREATE_TIME;
		private string _VERSION;
		private string _DATA_SOURCE;

		/// <summary>
		/// 资质信息主键
		/// </summary>
		public decimal? QUALIFYID
		{
			get{ return _QUALIFYID; }
			set
			{
				this.OnPropertyValueChange(_.QUALIFYID, _QUALIFYID, value);
				this._QUALIFYID = value;
			}
		}
		/// <summary>
		/// 企业ID
		/// </summary>
		public decimal? COMPANYID
		{
			get{ return _COMPANYID; }
			set
			{
				this.OnPropertyValueChange(_.COMPANYID, _COMPANYID, value);
				this._COMPANYID = value;
			}
		}
		/// <summary>
		/// 企业名称
		/// </summary>
		public string NAME
		{
			get{ return _NAME; }
			set
			{
				this.OnPropertyValueChange(_.NAME, _NAME, value);
				this._NAME = value;
			}
		}
		/// <summary>
		/// 资质序列ID
		/// </summary>
		public decimal? QUALIFYSEQUENCEID
		{
			get{ return _QUALIFYSEQUENCEID; }
			set
			{
				this.OnPropertyValueChange(_.QUALIFYSEQUENCEID, _QUALIFYSEQUENCEID, value);
				this._QUALIFYSEQUENCEID = value;
			}
		}
		/// <summary>
		/// 资质序列名称
		/// </summary>
		public string QUALIFYSEQUENCENAME
		{
			get{ return _QUALIFYSEQUENCENAME; }
			set
			{
				this.OnPropertyValueChange(_.QUALIFYSEQUENCENAME, _QUALIFYSEQUENCENAME, value);
				this._QUALIFYSEQUENCENAME = value;
			}
		}
		/// <summary>
		/// 资质类别ID
		/// </summary>
		public decimal? QUALIFYTYPEID
		{
			get{ return _QUALIFYTYPEID; }
			set
			{
				this.OnPropertyValueChange(_.QUALIFYTYPEID, _QUALIFYTYPEID, value);
				this._QUALIFYTYPEID = value;
			}
		}
		/// <summary>
		/// 资质类别名称
		/// </summary>
		public string QUALIFYTYPENAME
		{
			get{ return _QUALIFYTYPENAME; }
			set
			{
				this.OnPropertyValueChange(_.QUALIFYTYPENAME, _QUALIFYTYPENAME, value);
				this._QUALIFYTYPENAME = value;
			}
		}
		/// <summary>
		/// 资质等级ID
		/// </summary>
		public decimal? QUALIFYLEVELID
		{
			get{ return _QUALIFYLEVELID; }
			set
			{
				this.OnPropertyValueChange(_.QUALIFYLEVELID, _QUALIFYLEVELID, value);
				this._QUALIFYLEVELID = value;
			}
		}
		/// <summary>
		/// 资质等级名称
		/// </summary>
		public string QUALIFYLEVELNAME
		{
			get{ return _QUALIFYLEVELNAME; }
			set
			{
				this.OnPropertyValueChange(_.QUALIFYLEVELNAME, _QUALIFYLEVELNAME, value);
				this._QUALIFYLEVELNAME = value;
			}
		}
		/// <summary>
		/// 批准时间
		/// </summary>
		public DateTime? APPROVETIME
		{
			get{ return _APPROVETIME; }
			set
			{
				this.OnPropertyValueChange(_.APPROVETIME, _APPROVETIME, value);
				this._APPROVETIME = value;
			}
		}
		/// <summary>
		/// 批准文号
		/// </summary>
		public string APPROVEDOCNUM
		{
			get{ return _APPROVEDOCNUM; }
			set
			{
				this.OnPropertyValueChange(_.APPROVEDOCNUM, _APPROVEDOCNUM, value);
				this._APPROVEDOCNUM = value;
			}
		}
		/// <summary>
		/// 资质状态
		/// </summary>
		public decimal? QUALIFYALLOWSTATE
		{
			get{ return _QUALIFYALLOWSTATE; }
			set
			{
				this.OnPropertyValueChange(_.QUALIFYALLOWSTATE, _QUALIFYALLOWSTATE, value);
				this._QUALIFYALLOWSTATE = value;
			}
		}
		/// <summary>
		/// 资质种类
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
		/// 企业所属业务系统ID
		/// </summary>
		public decimal? BUSINESSSYSTEMTYPEID
		{
			get{ return _BUSINESSSYSTEMTYPEID; }
			set
			{
				this.OnPropertyValueChange(_.BUSINESSSYSTEMTYPEID, _BUSINESSSYSTEMTYPEID, value);
				this._BUSINESSSYSTEMTYPEID = value;
			}
		}
		/// <summary>
		/// 企业所属业务系统名称
		/// </summary>
		public string BUSINESSSYSTEMTYPENAME
		{
			get{ return _BUSINESSSYSTEMTYPENAME; }
			set
			{
				this.OnPropertyValueChange(_.BUSINESSSYSTEMTYPENAME, _BUSINESSSYSTEMTYPENAME, value);
				this._BUSINESSSYSTEMTYPENAME = value;
			}
		}
		/// <summary>
		/// 企业所在地ID
		/// </summary>
		public decimal? AREA
		{
			get{ return _AREA; }
			set
			{
				this.OnPropertyValueChange(_.AREA, _AREA, value);
				this._AREA = value;
			}
		}
		/// <summary>
		/// 企业所在地名称
		/// </summary>
		public string COUNTRYWIDENAME
		{
			get{ return _COUNTRYWIDENAME; }
			set
			{
				this.OnPropertyValueChange(_.COUNTRYWIDENAME, _COUNTRYWIDENAME, value);
				this._COUNTRYWIDENAME = value;
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
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.QUALIFYID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.QUALIFYID,
				_.COMPANYID,
				_.NAME,
				_.QUALIFYSEQUENCEID,
				_.QUALIFYSEQUENCENAME,
				_.QUALIFYTYPEID,
				_.QUALIFYTYPENAME,
				_.QUALIFYLEVELID,
				_.QUALIFYLEVELNAME,
				_.APPROVETIME,
				_.APPROVEDOCNUM,
				_.QUALIFYALLOWSTATE,
				_.KIND,
				_.BUSINESSSYSTEMTYPEID,
				_.BUSINESSSYSTEMTYPENAME,
				_.AREA,
				_.COUNTRYWIDENAME,
				_.GUID,
				_.CREATE_TIME,
				_.VERSION,
				_.DATA_SOURCE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._QUALIFYID,
				this._COMPANYID,
				this._NAME,
				this._QUALIFYSEQUENCEID,
				this._QUALIFYSEQUENCENAME,
				this._QUALIFYTYPEID,
				this._QUALIFYTYPENAME,
				this._QUALIFYLEVELID,
				this._QUALIFYLEVELNAME,
				this._APPROVETIME,
				this._APPROVEDOCNUM,
				this._QUALIFYALLOWSTATE,
				this._KIND,
				this._BUSINESSSYSTEMTYPEID,
				this._BUSINESSSYSTEMTYPENAME,
				this._AREA,
				this._COUNTRYWIDENAME,
				this._GUID,
				this._CREATE_TIME,
				this._VERSION,
				this._DATA_SOURCE,
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
			public readonly static Field All = new Field("*", "ZJPRI_CONSTRUCT_QUALI_INFO");
            /// <summary>
			/// 资质信息主键
			/// </summary>
			public readonly static Field QUALIFYID = new Field("QUALIFYID", "ZJPRI_CONSTRUCT_QUALI_INFO", "资质信息主键");
            /// <summary>
			/// 企业ID
			/// </summary>
			public readonly static Field COMPANYID = new Field("COMPANYID", "ZJPRI_CONSTRUCT_QUALI_INFO", "企业ID");
            /// <summary>
			/// 企业名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "ZJPRI_CONSTRUCT_QUALI_INFO", "企业名称");
            /// <summary>
			/// 资质序列ID
			/// </summary>
			public readonly static Field QUALIFYSEQUENCEID = new Field("QUALIFYSEQUENCEID", "ZJPRI_CONSTRUCT_QUALI_INFO", "资质序列ID");
            /// <summary>
			/// 资质序列名称
			/// </summary>
			public readonly static Field QUALIFYSEQUENCENAME = new Field("QUALIFYSEQUENCENAME", "ZJPRI_CONSTRUCT_QUALI_INFO", "资质序列名称");
            /// <summary>
			/// 资质类别ID
			/// </summary>
			public readonly static Field QUALIFYTYPEID = new Field("QUALIFYTYPEID", "ZJPRI_CONSTRUCT_QUALI_INFO", "资质类别ID");
            /// <summary>
			/// 资质类别名称
			/// </summary>
			public readonly static Field QUALIFYTYPENAME = new Field("QUALIFYTYPENAME", "ZJPRI_CONSTRUCT_QUALI_INFO", "资质类别名称");
            /// <summary>
			/// 资质等级ID
			/// </summary>
			public readonly static Field QUALIFYLEVELID = new Field("QUALIFYLEVELID", "ZJPRI_CONSTRUCT_QUALI_INFO", "资质等级ID");
            /// <summary>
			/// 资质等级名称
			/// </summary>
			public readonly static Field QUALIFYLEVELNAME = new Field("QUALIFYLEVELNAME", "ZJPRI_CONSTRUCT_QUALI_INFO", "资质等级名称");
            /// <summary>
			/// 批准时间
			/// </summary>
			public readonly static Field APPROVETIME = new Field("APPROVETIME", "ZJPRI_CONSTRUCT_QUALI_INFO", "批准时间");
            /// <summary>
			/// 批准文号
			/// </summary>
			public readonly static Field APPROVEDOCNUM = new Field("APPROVEDOCNUM", "ZJPRI_CONSTRUCT_QUALI_INFO", "批准文号");
            /// <summary>
			/// 资质状态
			/// </summary>
			public readonly static Field QUALIFYALLOWSTATE = new Field("QUALIFYALLOWSTATE", "ZJPRI_CONSTRUCT_QUALI_INFO", "资质状态");
            /// <summary>
			/// 资质种类
			/// </summary>
			public readonly static Field KIND = new Field("KIND", "ZJPRI_CONSTRUCT_QUALI_INFO", "资质种类");
            /// <summary>
			/// 企业所属业务系统ID
			/// </summary>
			public readonly static Field BUSINESSSYSTEMTYPEID = new Field("BUSINESSSYSTEMTYPEID", "ZJPRI_CONSTRUCT_QUALI_INFO", "企业所属业务系统ID");
            /// <summary>
			/// 企业所属业务系统名称
			/// </summary>
			public readonly static Field BUSINESSSYSTEMTYPENAME = new Field("BUSINESSSYSTEMTYPENAME", "ZJPRI_CONSTRUCT_QUALI_INFO", "企业所属业务系统名称");
            /// <summary>
			/// 企业所在地ID
			/// </summary>
			public readonly static Field AREA = new Field("AREA", "ZJPRI_CONSTRUCT_QUALI_INFO", "企业所在地ID");
            /// <summary>
			/// 企业所在地名称
			/// </summary>
			public readonly static Field COUNTRYWIDENAME = new Field("COUNTRYWIDENAME", "ZJPRI_CONSTRUCT_QUALI_INFO", "企业所在地名称");
            /// <summary>
			/// 全局唯一标识符
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "ZJPRI_CONSTRUCT_QUALI_INFO", "全局唯一标识符");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "ZJPRI_CONSTRUCT_QUALI_INFO", "创建时间");
            /// <summary>
			/// 版本号
			/// </summary>
			public readonly static Field VERSION = new Field("VERSION", "ZJPRI_CONSTRUCT_QUALI_INFO", "版本号");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field DATA_SOURCE = new Field("DATA_SOURCE", "ZJPRI_CONSTRUCT_QUALI_INFO", "数据来源");
        }
        #endregion
	}
}