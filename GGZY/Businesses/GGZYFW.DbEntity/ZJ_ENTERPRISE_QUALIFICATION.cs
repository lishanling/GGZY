using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ZJ_ENTERPRISE_QUALIFICATION。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJ_ENTERPRISE_QUALIFICATION")]
    [Serializable]
    public partial class ZJ_ENTERPRISE_QUALIFICATION : FwEntity
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
		private decimal? _M_ID;

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
		/// M_ID
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
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
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
				_.M_ID,
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
				this._M_ID,
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
			public readonly static Field All = new Field("*", "ZJ_ENTERPRISE_QUALIFICATION");
            /// <summary>
			/// 资质信息主键
			/// </summary>
			public readonly static Field QUALIFYID = new Field("QUALIFYID", "ZJ_ENTERPRISE_QUALIFICATION", "资质信息主键");
            /// <summary>
			/// 企业ID
			/// </summary>
			public readonly static Field COMPANYID = new Field("COMPANYID", "ZJ_ENTERPRISE_QUALIFICATION", "企业ID");
            /// <summary>
			/// 企业名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "ZJ_ENTERPRISE_QUALIFICATION", "企业名称");
            /// <summary>
			/// 资质序列ID
			/// </summary>
			public readonly static Field QUALIFYSEQUENCEID = new Field("QUALIFYSEQUENCEID", "ZJ_ENTERPRISE_QUALIFICATION", "资质序列ID");
            /// <summary>
			/// 资质序列名称
			/// </summary>
			public readonly static Field QUALIFYSEQUENCENAME = new Field("QUALIFYSEQUENCENAME", "ZJ_ENTERPRISE_QUALIFICATION", "资质序列名称");
            /// <summary>
			/// 资质类别ID
			/// </summary>
			public readonly static Field QUALIFYTYPEID = new Field("QUALIFYTYPEID", "ZJ_ENTERPRISE_QUALIFICATION", "资质类别ID");
            /// <summary>
			/// 资质类别名称
			/// </summary>
			public readonly static Field QUALIFYTYPENAME = new Field("QUALIFYTYPENAME", "ZJ_ENTERPRISE_QUALIFICATION", "资质类别名称");
            /// <summary>
			/// 资质等级ID
			/// </summary>
			public readonly static Field QUALIFYLEVELID = new Field("QUALIFYLEVELID", "ZJ_ENTERPRISE_QUALIFICATION", "资质等级ID");
            /// <summary>
			/// 资质等级名称
			/// </summary>
			public readonly static Field QUALIFYLEVELNAME = new Field("QUALIFYLEVELNAME", "ZJ_ENTERPRISE_QUALIFICATION", "资质等级名称");
            /// <summary>
			/// 批准时间
			/// </summary>
			public readonly static Field APPROVETIME = new Field("APPROVETIME", "ZJ_ENTERPRISE_QUALIFICATION", "批准时间");
            /// <summary>
			/// 批准文号
			/// </summary>
			public readonly static Field APPROVEDOCNUM = new Field("APPROVEDOCNUM", "ZJ_ENTERPRISE_QUALIFICATION", "批准文号");
            /// <summary>
			/// 资质状态
			/// </summary>
			public readonly static Field QUALIFYALLOWSTATE = new Field("QUALIFYALLOWSTATE", "ZJ_ENTERPRISE_QUALIFICATION", "资质状态");
            /// <summary>
			/// 资质种类
			/// </summary>
			public readonly static Field KIND = new Field("KIND", "ZJ_ENTERPRISE_QUALIFICATION", "资质种类");
            /// <summary>
			/// 企业所属业务系统ID
			/// </summary>
			public readonly static Field BUSINESSSYSTEMTYPEID = new Field("BUSINESSSYSTEMTYPEID", "ZJ_ENTERPRISE_QUALIFICATION", "企业所属业务系统ID");
            /// <summary>
			/// 企业所属业务系统名称
			/// </summary>
			public readonly static Field BUSINESSSYSTEMTYPENAME = new Field("BUSINESSSYSTEMTYPENAME", "ZJ_ENTERPRISE_QUALIFICATION", "企业所属业务系统名称");
            /// <summary>
			/// 企业所在地ID
			/// </summary>
			public readonly static Field AREA = new Field("AREA", "ZJ_ENTERPRISE_QUALIFICATION", "企业所在地ID");
            /// <summary>
			/// 企业所在地名称
			/// </summary>
			public readonly static Field COUNTRYWIDENAME = new Field("COUNTRYWIDENAME", "ZJ_ENTERPRISE_QUALIFICATION", "企业所在地名称");
            /// <summary>
			/// 全局唯一标识符
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "ZJ_ENTERPRISE_QUALIFICATION", "全局唯一标识符");
            /// <summary>
			/// M_ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "ZJ_ENTERPRISE_QUALIFICATION", "M_ID");
        }
        #endregion
	}
}