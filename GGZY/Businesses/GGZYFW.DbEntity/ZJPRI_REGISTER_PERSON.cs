using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ZJPRI_REGISTER_PERSON。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJPRI_REGISTER_PERSON")]
    [Serializable]
    public partial class ZJPRI_REGISTER_PERSON : FwEntity
    {
        #region Model
		private decimal? _PERSONID;
		private string _NAME;
		private string _IDENTITYCARDNUMBER;
		private decimal? _SPECIALTYPEID;
		private string _SPECIALTYPENAME;
		private string _CERTNUM;
		private string _AWARDDEPT;
		private DateTime? _AWARDDATE;
		private string _STAMPNUM;
		private DateTime? _EFFECTDATE;
		private string _REGNUM;
		private decimal? _COMPANYMAINID;
		private string _COMPANYMAINNAME;
		private string _SPECIALTY;
		private string _YXQQ;
		private string _YXQZ;
		private decimal? _BUSINESSSYSTEMTYPEID;
		private string _BUSINESSSYSTEMTYPENAME;
		private decimal? _AREA;
		private string _COUNTRYWIDENAME;
		private string _GUID;
		private DateTime? _CREATE_TIME;
		private string _VERSION;
		private string _DATA_SOURCE;
		private string _CERT_FILE;

		/// <summary>
		/// 人员ID
		/// </summary>
		public decimal? PERSONID
		{
			get{ return _PERSONID; }
			set
			{
				this.OnPropertyValueChange(_.PERSONID, _PERSONID, value);
				this._PERSONID = value;
			}
		}
		/// <summary>
		/// 姓名
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
		/// 注册类型ID
		/// </summary>
		public decimal? SPECIALTYPEID
		{
			get{ return _SPECIALTYPEID; }
			set
			{
				this.OnPropertyValueChange(_.SPECIALTYPEID, _SPECIALTYPEID, value);
				this._SPECIALTYPEID = value;
			}
		}
		/// <summary>
		/// 注册类型名称
		/// </summary>
		public string SPECIALTYPENAME
		{
			get{ return _SPECIALTYPENAME; }
			set
			{
				this.OnPropertyValueChange(_.SPECIALTYPENAME, _SPECIALTYPENAME, value);
				this._SPECIALTYPENAME = value;
			}
		}
		/// <summary>
		/// 注册证书编号
		/// </summary>
		public string CERTNUM
		{
			get{ return _CERTNUM; }
			set
			{
				this.OnPropertyValueChange(_.CERTNUM, _CERTNUM, value);
				this._CERTNUM = value;
			}
		}
		/// <summary>
		/// 发证机关
		/// </summary>
		public string AWARDDEPT
		{
			get{ return _AWARDDEPT; }
			set
			{
				this.OnPropertyValueChange(_.AWARDDEPT, _AWARDDEPT, value);
				this._AWARDDEPT = value;
			}
		}
		/// <summary>
		/// 发证日期
		/// </summary>
		public DateTime? AWARDDATE
		{
			get{ return _AWARDDATE; }
			set
			{
				this.OnPropertyValueChange(_.AWARDDATE, _AWARDDATE, value);
				this._AWARDDATE = value;
			}
		}
		/// <summary>
		/// 执业印章号
		/// </summary>
		public string STAMPNUM
		{
			get{ return _STAMPNUM; }
			set
			{
				this.OnPropertyValueChange(_.STAMPNUM, _STAMPNUM, value);
				this._STAMPNUM = value;
			}
		}
		/// <summary>
		/// 注册有效期
		/// </summary>
		public DateTime? EFFECTDATE
		{
			get{ return _EFFECTDATE; }
			set
			{
				this.OnPropertyValueChange(_.EFFECTDATE, _EFFECTDATE, value);
				this._EFFECTDATE = value;
			}
		}
		/// <summary>
		/// 注册编号
		/// </summary>
		public string REGNUM
		{
			get{ return _REGNUM; }
			set
			{
				this.OnPropertyValueChange(_.REGNUM, _REGNUM, value);
				this._REGNUM = value;
			}
		}
		/// <summary>
		/// 企业ID
		/// </summary>
		public decimal? COMPANYMAINID
		{
			get{ return _COMPANYMAINID; }
			set
			{
				this.OnPropertyValueChange(_.COMPANYMAINID, _COMPANYMAINID, value);
				this._COMPANYMAINID = value;
			}
		}
		/// <summary>
		/// 企业名称
		/// </summary>
		public string COMPANYMAINNAME
		{
			get{ return _COMPANYMAINNAME; }
			set
			{
				this.OnPropertyValueChange(_.COMPANYMAINNAME, _COMPANYMAINNAME, value);
				this._COMPANYMAINNAME = value;
			}
		}
		/// <summary>
		/// 注册专业
		/// </summary>
		public string SPECIALTY
		{
			get{ return _SPECIALTY; }
			set
			{
				this.OnPropertyValueChange(_.SPECIALTY, _SPECIALTY, value);
				this._SPECIALTY = value;
			}
		}
		/// <summary>
		/// 注册专业有效期起始
		/// </summary>
		public string YXQQ
		{
			get{ return _YXQQ; }
			set
			{
				this.OnPropertyValueChange(_.YXQQ, _YXQQ, value);
				this._YXQQ = value;
			}
		}
		/// <summary>
		/// 注册专业有效期截止
		/// </summary>
		public string YXQZ
		{
			get{ return _YXQZ; }
			set
			{
				this.OnPropertyValueChange(_.YXQZ, _YXQZ, value);
				this._YXQZ = value;
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
		/// <summary>
		/// 注册证书附件
		/// </summary>
		public string CERT_FILE
		{
			get{ return _CERT_FILE; }
			set
			{
				this.OnPropertyValueChange(_.CERT_FILE, _CERT_FILE, value);
				this._CERT_FILE = value;
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
				_.CERTNUM,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.PERSONID,
				_.NAME,
				_.IDENTITYCARDNUMBER,
				_.SPECIALTYPEID,
				_.SPECIALTYPENAME,
				_.CERTNUM,
				_.AWARDDEPT,
				_.AWARDDATE,
				_.STAMPNUM,
				_.EFFECTDATE,
				_.REGNUM,
				_.COMPANYMAINID,
				_.COMPANYMAINNAME,
				_.SPECIALTY,
				_.YXQQ,
				_.YXQZ,
				_.BUSINESSSYSTEMTYPEID,
				_.BUSINESSSYSTEMTYPENAME,
				_.AREA,
				_.COUNTRYWIDENAME,
				_.GUID,
				_.CREATE_TIME,
				_.VERSION,
				_.DATA_SOURCE,
				_.CERT_FILE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._PERSONID,
				this._NAME,
				this._IDENTITYCARDNUMBER,
				this._SPECIALTYPEID,
				this._SPECIALTYPENAME,
				this._CERTNUM,
				this._AWARDDEPT,
				this._AWARDDATE,
				this._STAMPNUM,
				this._EFFECTDATE,
				this._REGNUM,
				this._COMPANYMAINID,
				this._COMPANYMAINNAME,
				this._SPECIALTY,
				this._YXQQ,
				this._YXQZ,
				this._BUSINESSSYSTEMTYPEID,
				this._BUSINESSSYSTEMTYPENAME,
				this._AREA,
				this._COUNTRYWIDENAME,
				this._GUID,
				this._CREATE_TIME,
				this._VERSION,
				this._DATA_SOURCE,
				this._CERT_FILE,
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
			public readonly static Field All = new Field("*", "ZJPRI_REGISTER_PERSON");
            /// <summary>
			/// 人员ID
			/// </summary>
			public readonly static Field PERSONID = new Field("PERSONID", "ZJPRI_REGISTER_PERSON", "人员ID");
            /// <summary>
			/// 姓名
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "ZJPRI_REGISTER_PERSON", "姓名");
            /// <summary>
			/// 身份证号码
			/// </summary>
			public readonly static Field IDENTITYCARDNUMBER = new Field("IDENTITYCARDNUMBER", "ZJPRI_REGISTER_PERSON", "身份证号码");
            /// <summary>
			/// 注册类型ID
			/// </summary>
			public readonly static Field SPECIALTYPEID = new Field("SPECIALTYPEID", "ZJPRI_REGISTER_PERSON", "注册类型ID");
            /// <summary>
			/// 注册类型名称
			/// </summary>
			public readonly static Field SPECIALTYPENAME = new Field("SPECIALTYPENAME", "ZJPRI_REGISTER_PERSON", "注册类型名称");
            /// <summary>
			/// 注册证书编号
			/// </summary>
			public readonly static Field CERTNUM = new Field("CERTNUM", "ZJPRI_REGISTER_PERSON", "注册证书编号");
            /// <summary>
			/// 发证机关
			/// </summary>
			public readonly static Field AWARDDEPT = new Field("AWARDDEPT", "ZJPRI_REGISTER_PERSON", "发证机关");
            /// <summary>
			/// 发证日期
			/// </summary>
			public readonly static Field AWARDDATE = new Field("AWARDDATE", "ZJPRI_REGISTER_PERSON", "发证日期");
            /// <summary>
			/// 执业印章号
			/// </summary>
			public readonly static Field STAMPNUM = new Field("STAMPNUM", "ZJPRI_REGISTER_PERSON", "执业印章号");
            /// <summary>
			/// 注册有效期
			/// </summary>
			public readonly static Field EFFECTDATE = new Field("EFFECTDATE", "ZJPRI_REGISTER_PERSON", "注册有效期");
            /// <summary>
			/// 注册编号
			/// </summary>
			public readonly static Field REGNUM = new Field("REGNUM", "ZJPRI_REGISTER_PERSON", "注册编号");
            /// <summary>
			/// 企业ID
			/// </summary>
			public readonly static Field COMPANYMAINID = new Field("COMPANYMAINID", "ZJPRI_REGISTER_PERSON", "企业ID");
            /// <summary>
			/// 企业名称
			/// </summary>
			public readonly static Field COMPANYMAINNAME = new Field("COMPANYMAINNAME", "ZJPRI_REGISTER_PERSON", "企业名称");
            /// <summary>
			/// 注册专业
			/// </summary>
			public readonly static Field SPECIALTY = new Field("SPECIALTY", "ZJPRI_REGISTER_PERSON", "注册专业");
            /// <summary>
			/// 注册专业有效期起始
			/// </summary>
			public readonly static Field YXQQ = new Field("YXQQ", "ZJPRI_REGISTER_PERSON", "注册专业有效期起始");
            /// <summary>
			/// 注册专业有效期截止
			/// </summary>
			public readonly static Field YXQZ = new Field("YXQZ", "ZJPRI_REGISTER_PERSON", "注册专业有效期截止");
            /// <summary>
			/// 企业所属业务系统ID
			/// </summary>
			public readonly static Field BUSINESSSYSTEMTYPEID = new Field("BUSINESSSYSTEMTYPEID", "ZJPRI_REGISTER_PERSON", "企业所属业务系统ID");
            /// <summary>
			/// 企业所属业务系统名称
			/// </summary>
			public readonly static Field BUSINESSSYSTEMTYPENAME = new Field("BUSINESSSYSTEMTYPENAME", "ZJPRI_REGISTER_PERSON", "企业所属业务系统名称");
            /// <summary>
			/// 企业所在地ID
			/// </summary>
			public readonly static Field AREA = new Field("AREA", "ZJPRI_REGISTER_PERSON", "企业所在地ID");
            /// <summary>
			/// 企业所在地名称
			/// </summary>
			public readonly static Field COUNTRYWIDENAME = new Field("COUNTRYWIDENAME", "ZJPRI_REGISTER_PERSON", "企业所在地名称");
            /// <summary>
			/// 全局唯一标识符
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "ZJPRI_REGISTER_PERSON", "全局唯一标识符");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "ZJPRI_REGISTER_PERSON", "创建时间");
            /// <summary>
			/// 版本号
			/// </summary>
			public readonly static Field VERSION = new Field("VERSION", "ZJPRI_REGISTER_PERSON", "版本号");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field DATA_SOURCE = new Field("DATA_SOURCE", "ZJPRI_REGISTER_PERSON", "数据来源");
            /// <summary>
			/// 注册证书附件
			/// </summary>
			public readonly static Field CERT_FILE = new Field("CERT_FILE", "ZJPRI_REGISTER_PERSON", "注册证书附件");
        }
        #endregion
	}
}