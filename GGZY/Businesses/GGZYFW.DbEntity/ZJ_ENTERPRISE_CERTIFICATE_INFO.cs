using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ZJ_ENTERPRISE_CERTIFICATE_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJ_ENTERPRISE_CERTIFICATE_INFO")]
    [Serializable]
    public partial class ZJ_ENTERPRISE_CERTIFICATE_INFO : FwEntity
    {
        #region Model
		private decimal? _QUALIFYCERTIFICATEID;
		private decimal? _COMPANYID;
		private string _COMPANYNAME;
		private string _CERTIFICATIONTYPE;
		private string _ISSUEDEPARTMENT;
		private string _QUALIFYNUMBER;
		private DateTime? _ISSUEDATETIME;
		private DateTime? _ISSUEDATE;
		private DateTime? _ISSUEEXPIREDATETIME;
		private string _APPROVEDOCNUM;
		private decimal? _REPLACESTATUS;
		private decimal? _STATUS;
		private string _FLOWNUMBER;
		private decimal? _BUSINESSSYSTEMTYPEID;
		private string _BUSINESSSYSTEMTYPENAME;
		private decimal? _AREA;
		private string _COUNTRYWIDENAME;
		private string _GUID;
		private decimal? _M_ID;

		/// <summary>
		/// 资质证书ID
		/// </summary>
		public decimal? QUALIFYCERTIFICATEID
		{
			get{ return _QUALIFYCERTIFICATEID; }
			set
			{
				this.OnPropertyValueChange(_.QUALIFYCERTIFICATEID, _QUALIFYCERTIFICATEID, value);
				this._QUALIFYCERTIFICATEID = value;
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
		public string COMPANYNAME
		{
			get{ return _COMPANYNAME; }
			set
			{
				this.OnPropertyValueChange(_.COMPANYNAME, _COMPANYNAME, value);
				this._COMPANYNAME = value;
			}
		}
		/// <summary>
		/// 证书类型
		/// </summary>
		public string CERTIFICATIONTYPE
		{
			get{ return _CERTIFICATIONTYPE; }
			set
			{
				this.OnPropertyValueChange(_.CERTIFICATIONTYPE, _CERTIFICATIONTYPE, value);
				this._CERTIFICATIONTYPE = value;
			}
		}
		/// <summary>
		/// 证书发证机关
		/// </summary>
		public string ISSUEDEPARTMENT
		{
			get{ return _ISSUEDEPARTMENT; }
			set
			{
				this.OnPropertyValueChange(_.ISSUEDEPARTMENT, _ISSUEDEPARTMENT, value);
				this._ISSUEDEPARTMENT = value;
			}
		}
		/// <summary>
		/// 资质证书编号
		/// </summary>
		public string QUALIFYNUMBER
		{
			get{ return _QUALIFYNUMBER; }
			set
			{
				this.OnPropertyValueChange(_.QUALIFYNUMBER, _QUALIFYNUMBER, value);
				this._QUALIFYNUMBER = value;
			}
		}
		/// <summary>
		/// 资质证书发证日期
		/// </summary>
		public DateTime? ISSUEDATETIME
		{
			get{ return _ISSUEDATETIME; }
			set
			{
				this.OnPropertyValueChange(_.ISSUEDATETIME, _ISSUEDATETIME, value);
				this._ISSUEDATETIME = value;
			}
		}
		/// <summary>
		/// 资质证书有效期开始时间
		/// </summary>
		public DateTime? ISSUEDATE
		{
			get{ return _ISSUEDATE; }
			set
			{
				this.OnPropertyValueChange(_.ISSUEDATE, _ISSUEDATE, value);
				this._ISSUEDATE = value;
			}
		}
		/// <summary>
		/// 资质证书有效期结束时间
		/// </summary>
		public DateTime? ISSUEEXPIREDATETIME
		{
			get{ return _ISSUEEXPIREDATETIME; }
			set
			{
				this.OnPropertyValueChange(_.ISSUEEXPIREDATETIME, _ISSUEEXPIREDATETIME, value);
				this._ISSUEEXPIREDATETIME = value;
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
		/// 换证状态
		/// </summary>
		public decimal? REPLACESTATUS
		{
			get{ return _REPLACESTATUS; }
			set
			{
				this.OnPropertyValueChange(_.REPLACESTATUS, _REPLACESTATUS, value);
				this._REPLACESTATUS = value;
			}
		}
		/// <summary>
		/// 证书状态
		/// </summary>
		public decimal? STATUS
		{
			get{ return _STATUS; }
			set
			{
				this.OnPropertyValueChange(_.STATUS, _STATUS, value);
				this._STATUS = value;
			}
		}
		/// <summary>
		/// 流水号
		/// </summary>
		public string FLOWNUMBER
		{
			get{ return _FLOWNUMBER; }
			set
			{
				this.OnPropertyValueChange(_.FLOWNUMBER, _FLOWNUMBER, value);
				this._FLOWNUMBER = value;
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
				_.QUALIFYCERTIFICATEID,
				_.COMPANYID,
				_.COMPANYNAME,
				_.CERTIFICATIONTYPE,
				_.ISSUEDEPARTMENT,
				_.QUALIFYNUMBER,
				_.ISSUEDATETIME,
				_.ISSUEDATE,
				_.ISSUEEXPIREDATETIME,
				_.APPROVEDOCNUM,
				_.REPLACESTATUS,
				_.STATUS,
				_.FLOWNUMBER,
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
				this._QUALIFYCERTIFICATEID,
				this._COMPANYID,
				this._COMPANYNAME,
				this._CERTIFICATIONTYPE,
				this._ISSUEDEPARTMENT,
				this._QUALIFYNUMBER,
				this._ISSUEDATETIME,
				this._ISSUEDATE,
				this._ISSUEEXPIREDATETIME,
				this._APPROVEDOCNUM,
				this._REPLACESTATUS,
				this._STATUS,
				this._FLOWNUMBER,
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
			public readonly static Field All = new Field("*", "ZJ_ENTERPRISE_CERTIFICATE_INFO");
            /// <summary>
			/// 资质证书ID
			/// </summary>
			public readonly static Field QUALIFYCERTIFICATEID = new Field("QUALIFYCERTIFICATEID", "ZJ_ENTERPRISE_CERTIFICATE_INFO", "资质证书ID");
            /// <summary>
			/// 企业ID
			/// </summary>
			public readonly static Field COMPANYID = new Field("COMPANYID", "ZJ_ENTERPRISE_CERTIFICATE_INFO", "企业ID");
            /// <summary>
			/// 企业名称
			/// </summary>
			public readonly static Field COMPANYNAME = new Field("COMPANYNAME", "ZJ_ENTERPRISE_CERTIFICATE_INFO", "企业名称");
            /// <summary>
			/// 证书类型
			/// </summary>
			public readonly static Field CERTIFICATIONTYPE = new Field("CERTIFICATIONTYPE", "ZJ_ENTERPRISE_CERTIFICATE_INFO", "证书类型");
            /// <summary>
			/// 证书发证机关
			/// </summary>
			public readonly static Field ISSUEDEPARTMENT = new Field("ISSUEDEPARTMENT", "ZJ_ENTERPRISE_CERTIFICATE_INFO", "证书发证机关");
            /// <summary>
			/// 资质证书编号
			/// </summary>
			public readonly static Field QUALIFYNUMBER = new Field("QUALIFYNUMBER", "ZJ_ENTERPRISE_CERTIFICATE_INFO", "资质证书编号");
            /// <summary>
			/// 资质证书发证日期
			/// </summary>
			public readonly static Field ISSUEDATETIME = new Field("ISSUEDATETIME", "ZJ_ENTERPRISE_CERTIFICATE_INFO", "资质证书发证日期");
            /// <summary>
			/// 资质证书有效期开始时间
			/// </summary>
			public readonly static Field ISSUEDATE = new Field("ISSUEDATE", "ZJ_ENTERPRISE_CERTIFICATE_INFO", "资质证书有效期开始时间");
            /// <summary>
			/// 资质证书有效期结束时间
			/// </summary>
			public readonly static Field ISSUEEXPIREDATETIME = new Field("ISSUEEXPIREDATETIME", "ZJ_ENTERPRISE_CERTIFICATE_INFO", "资质证书有效期结束时间");
            /// <summary>
			/// 批准文号
			/// </summary>
			public readonly static Field APPROVEDOCNUM = new Field("APPROVEDOCNUM", "ZJ_ENTERPRISE_CERTIFICATE_INFO", "批准文号");
            /// <summary>
			/// 换证状态
			/// </summary>
			public readonly static Field REPLACESTATUS = new Field("REPLACESTATUS", "ZJ_ENTERPRISE_CERTIFICATE_INFO", "换证状态");
            /// <summary>
			/// 证书状态
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "ZJ_ENTERPRISE_CERTIFICATE_INFO", "证书状态");
            /// <summary>
			/// 流水号
			/// </summary>
			public readonly static Field FLOWNUMBER = new Field("FLOWNUMBER", "ZJ_ENTERPRISE_CERTIFICATE_INFO", "流水号");
            /// <summary>
			/// 企业所属业务系统ID
			/// </summary>
			public readonly static Field BUSINESSSYSTEMTYPEID = new Field("BUSINESSSYSTEMTYPEID", "ZJ_ENTERPRISE_CERTIFICATE_INFO", "企业所属业务系统ID");
            /// <summary>
			/// 企业所属业务系统名称
			/// </summary>
			public readonly static Field BUSINESSSYSTEMTYPENAME = new Field("BUSINESSSYSTEMTYPENAME", "ZJ_ENTERPRISE_CERTIFICATE_INFO", "企业所属业务系统名称");
            /// <summary>
			/// 企业所在地ID
			/// </summary>
			public readonly static Field AREA = new Field("AREA", "ZJ_ENTERPRISE_CERTIFICATE_INFO", "企业所在地ID");
            /// <summary>
			/// 企业所在地名称
			/// </summary>
			public readonly static Field COUNTRYWIDENAME = new Field("COUNTRYWIDENAME", "ZJ_ENTERPRISE_CERTIFICATE_INFO", "企业所在地名称");
            /// <summary>
			/// 全局唯一标识符
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "ZJ_ENTERPRISE_CERTIFICATE_INFO", "全局唯一标识符");
            /// <summary>
			/// M_ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "ZJ_ENTERPRISE_CERTIFICATE_INFO", "M_ID");
        }
        #endregion
	}
}