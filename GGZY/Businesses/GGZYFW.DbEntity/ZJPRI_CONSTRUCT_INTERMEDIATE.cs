using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ZJPRI_CONSTRUCT_INTERMEDIATE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJPRI_CONSTRUCT_INTERMEDIATE")]
    [Serializable]
    public partial class ZJPRI_CONSTRUCT_INTERMEDIATE : FwEntity
    {
        #region Model
		private decimal? _TITLEPERSONID;
		private decimal? _BASEID;
		private string _NAME;
		private string _IDENTITYCARDNUMBER;
		private string _HIGHESTEDUCATION;
		private decimal? _TITLEID;
		private string _TITLENAME;
		private string _TITLESPECIALITY;
		private string _SPECIALITY;
		private DateTime? _GRADUATETIME;
		private string _GRADUATESCHOOL;
		private decimal? _COMPANYID;
		private string _COMPANYMAINNAME;
		private string _POSITION;
		private string _TELEPHONE;
		private string _MOBILEPHONE;
		private string _TITLENO;
		private string _TITLEURL;
		private string _TITLEUNIT;
		private decimal? _BUSINESSSYSTEMTYPEID;
		private string _BUSINESSSYSTEMTYPENAME;
		private decimal? _AREA;
		private string _COUNTRYWIDENAME;
		private string _GUID;
		private DateTime? _CREATE_TIME;
		private string _VERSION;
		private string _TITLE_FILE;
		private string _DATA_SOURCE;

		/// <summary>
		/// 职称人员ID
		/// </summary>
		public decimal? TITLEPERSONID
		{
			get{ return _TITLEPERSONID; }
			set
			{
				this.OnPropertyValueChange(_.TITLEPERSONID, _TITLEPERSONID, value);
				this._TITLEPERSONID = value;
			}
		}
		/// <summary>
		/// 基础人员ID
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
		/// 学历
		/// </summary>
		public string HIGHESTEDUCATION
		{
			get{ return _HIGHESTEDUCATION; }
			set
			{
				this.OnPropertyValueChange(_.HIGHESTEDUCATION, _HIGHESTEDUCATION, value);
				this._HIGHESTEDUCATION = value;
			}
		}
		/// <summary>
		/// 职称ID
		/// </summary>
		public decimal? TITLEID
		{
			get{ return _TITLEID; }
			set
			{
				this.OnPropertyValueChange(_.TITLEID, _TITLEID, value);
				this._TITLEID = value;
			}
		}
		/// <summary>
		/// 职称名称
		/// </summary>
		public string TITLENAME
		{
			get{ return _TITLENAME; }
			set
			{
				this.OnPropertyValueChange(_.TITLENAME, _TITLENAME, value);
				this._TITLENAME = value;
			}
		}
		/// <summary>
		/// 职称专业
		/// </summary>
		public string TITLESPECIALITY
		{
			get{ return _TITLESPECIALITY; }
			set
			{
				this.OnPropertyValueChange(_.TITLESPECIALITY, _TITLESPECIALITY, value);
				this._TITLESPECIALITY = value;
			}
		}
		/// <summary>
		/// 所学专业
		/// </summary>
		public string SPECIALITY
		{
			get{ return _SPECIALITY; }
			set
			{
				this.OnPropertyValueChange(_.SPECIALITY, _SPECIALITY, value);
				this._SPECIALITY = value;
			}
		}
		/// <summary>
		/// 毕业时间
		/// </summary>
		public DateTime? GRADUATETIME
		{
			get{ return _GRADUATETIME; }
			set
			{
				this.OnPropertyValueChange(_.GRADUATETIME, _GRADUATETIME, value);
				this._GRADUATETIME = value;
			}
		}
		/// <summary>
		/// 毕业学校
		/// </summary>
		public string GRADUATESCHOOL
		{
			get{ return _GRADUATESCHOOL; }
			set
			{
				this.OnPropertyValueChange(_.GRADUATESCHOOL, _GRADUATESCHOOL, value);
				this._GRADUATESCHOOL = value;
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
		/// 职务
		/// </summary>
		public string POSITION
		{
			get{ return _POSITION; }
			set
			{
				this.OnPropertyValueChange(_.POSITION, _POSITION, value);
				this._POSITION = value;
			}
		}
		/// <summary>
		/// 电话
		/// </summary>
		public string TELEPHONE
		{
			get{ return _TELEPHONE; }
			set
			{
				this.OnPropertyValueChange(_.TELEPHONE, _TELEPHONE, value);
				this._TELEPHONE = value;
			}
		}
		/// <summary>
		/// 移动电话
		/// </summary>
		public string MOBILEPHONE
		{
			get{ return _MOBILEPHONE; }
			set
			{
				this.OnPropertyValueChange(_.MOBILEPHONE, _MOBILEPHONE, value);
				this._MOBILEPHONE = value;
			}
		}
		/// <summary>
		/// 职称证书编号
		/// </summary>
		public string TITLENO
		{
			get{ return _TITLENO; }
			set
			{
				this.OnPropertyValueChange(_.TITLENO, _TITLENO, value);
				this._TITLENO = value;
			}
		}
		/// <summary>
		/// 官方验证网址
		/// </summary>
		public string TITLEURL
		{
			get{ return _TITLEURL; }
			set
			{
				this.OnPropertyValueChange(_.TITLEURL, _TITLEURL, value);
				this._TITLEURL = value;
			}
		}
		/// <summary>
		/// 发证机关
		/// </summary>
		public string TITLEUNIT
		{
			get{ return _TITLEUNIT; }
			set
			{
				this.OnPropertyValueChange(_.TITLEUNIT, _TITLEUNIT, value);
				this._TITLEUNIT = value;
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
		/// 职称证书附件
		/// </summary>
		public string TITLE_FILE
		{
			get{ return _TITLE_FILE; }
			set
			{
				this.OnPropertyValueChange(_.TITLE_FILE, _TITLE_FILE, value);
				this._TITLE_FILE = value;
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
				_.TITLEPERSONID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.TITLEPERSONID,
				_.BASEID,
				_.NAME,
				_.IDENTITYCARDNUMBER,
				_.HIGHESTEDUCATION,
				_.TITLEID,
				_.TITLENAME,
				_.TITLESPECIALITY,
				_.SPECIALITY,
				_.GRADUATETIME,
				_.GRADUATESCHOOL,
				_.COMPANYID,
				_.COMPANYMAINNAME,
				_.POSITION,
				_.TELEPHONE,
				_.MOBILEPHONE,
				_.TITLENO,
				_.TITLEURL,
				_.TITLEUNIT,
				_.BUSINESSSYSTEMTYPEID,
				_.BUSINESSSYSTEMTYPENAME,
				_.AREA,
				_.COUNTRYWIDENAME,
				_.GUID,
				_.CREATE_TIME,
				_.VERSION,
				_.TITLE_FILE,
				_.DATA_SOURCE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._TITLEPERSONID,
				this._BASEID,
				this._NAME,
				this._IDENTITYCARDNUMBER,
				this._HIGHESTEDUCATION,
				this._TITLEID,
				this._TITLENAME,
				this._TITLESPECIALITY,
				this._SPECIALITY,
				this._GRADUATETIME,
				this._GRADUATESCHOOL,
				this._COMPANYID,
				this._COMPANYMAINNAME,
				this._POSITION,
				this._TELEPHONE,
				this._MOBILEPHONE,
				this._TITLENO,
				this._TITLEURL,
				this._TITLEUNIT,
				this._BUSINESSSYSTEMTYPEID,
				this._BUSINESSSYSTEMTYPENAME,
				this._AREA,
				this._COUNTRYWIDENAME,
				this._GUID,
				this._CREATE_TIME,
				this._VERSION,
				this._TITLE_FILE,
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
			public readonly static Field All = new Field("*", "ZJPRI_CONSTRUCT_INTERMEDIATE");
            /// <summary>
			/// 职称人员ID
			/// </summary>
			public readonly static Field TITLEPERSONID = new Field("TITLEPERSONID", "ZJPRI_CONSTRUCT_INTERMEDIATE", "职称人员ID");
            /// <summary>
			/// 基础人员ID
			/// </summary>
			public readonly static Field BASEID = new Field("BASEID", "ZJPRI_CONSTRUCT_INTERMEDIATE", "基础人员ID");
            /// <summary>
			/// 姓名
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "ZJPRI_CONSTRUCT_INTERMEDIATE", "姓名");
            /// <summary>
			/// 身份证号码
			/// </summary>
			public readonly static Field IDENTITYCARDNUMBER = new Field("IDENTITYCARDNUMBER", "ZJPRI_CONSTRUCT_INTERMEDIATE", "身份证号码");
            /// <summary>
			/// 学历
			/// </summary>
			public readonly static Field HIGHESTEDUCATION = new Field("HIGHESTEDUCATION", "ZJPRI_CONSTRUCT_INTERMEDIATE", "学历");
            /// <summary>
			/// 职称ID
			/// </summary>
			public readonly static Field TITLEID = new Field("TITLEID", "ZJPRI_CONSTRUCT_INTERMEDIATE", "职称ID");
            /// <summary>
			/// 职称名称
			/// </summary>
			public readonly static Field TITLENAME = new Field("TITLENAME", "ZJPRI_CONSTRUCT_INTERMEDIATE", "职称名称");
            /// <summary>
			/// 职称专业
			/// </summary>
			public readonly static Field TITLESPECIALITY = new Field("TITLESPECIALITY", "ZJPRI_CONSTRUCT_INTERMEDIATE", "职称专业");
            /// <summary>
			/// 所学专业
			/// </summary>
			public readonly static Field SPECIALITY = new Field("SPECIALITY", "ZJPRI_CONSTRUCT_INTERMEDIATE", "所学专业");
            /// <summary>
			/// 毕业时间
			/// </summary>
			public readonly static Field GRADUATETIME = new Field("GRADUATETIME", "ZJPRI_CONSTRUCT_INTERMEDIATE", "毕业时间");
            /// <summary>
			/// 毕业学校
			/// </summary>
			public readonly static Field GRADUATESCHOOL = new Field("GRADUATESCHOOL", "ZJPRI_CONSTRUCT_INTERMEDIATE", "毕业学校");
            /// <summary>
			/// 企业ID
			/// </summary>
			public readonly static Field COMPANYID = new Field("COMPANYID", "ZJPRI_CONSTRUCT_INTERMEDIATE", "企业ID");
            /// <summary>
			/// 企业名称
			/// </summary>
			public readonly static Field COMPANYMAINNAME = new Field("COMPANYMAINNAME", "ZJPRI_CONSTRUCT_INTERMEDIATE", "企业名称");
            /// <summary>
			/// 职务
			/// </summary>
			public readonly static Field POSITION = new Field("POSITION", "ZJPRI_CONSTRUCT_INTERMEDIATE", "职务");
            /// <summary>
			/// 电话
			/// </summary>
			public readonly static Field TELEPHONE = new Field("TELEPHONE", "ZJPRI_CONSTRUCT_INTERMEDIATE", "电话");
            /// <summary>
			/// 移动电话
			/// </summary>
			public readonly static Field MOBILEPHONE = new Field("MOBILEPHONE", "ZJPRI_CONSTRUCT_INTERMEDIATE", "移动电话");
            /// <summary>
			/// 职称证书编号
			/// </summary>
			public readonly static Field TITLENO = new Field("TITLENO", "ZJPRI_CONSTRUCT_INTERMEDIATE", "职称证书编号");
            /// <summary>
			/// 官方验证网址
			/// </summary>
			public readonly static Field TITLEURL = new Field("TITLEURL", "ZJPRI_CONSTRUCT_INTERMEDIATE", "官方验证网址");
            /// <summary>
			/// 发证机关
			/// </summary>
			public readonly static Field TITLEUNIT = new Field("TITLEUNIT", "ZJPRI_CONSTRUCT_INTERMEDIATE", "发证机关");
            /// <summary>
			/// 企业所属业务系统ID
			/// </summary>
			public readonly static Field BUSINESSSYSTEMTYPEID = new Field("BUSINESSSYSTEMTYPEID", "ZJPRI_CONSTRUCT_INTERMEDIATE", "企业所属业务系统ID");
            /// <summary>
			/// 企业所属业务系统名称
			/// </summary>
			public readonly static Field BUSINESSSYSTEMTYPENAME = new Field("BUSINESSSYSTEMTYPENAME", "ZJPRI_CONSTRUCT_INTERMEDIATE", "企业所属业务系统名称");
            /// <summary>
			/// 企业所在地ID
			/// </summary>
			public readonly static Field AREA = new Field("AREA", "ZJPRI_CONSTRUCT_INTERMEDIATE", "企业所在地ID");
            /// <summary>
			/// 企业所在地名称
			/// </summary>
			public readonly static Field COUNTRYWIDENAME = new Field("COUNTRYWIDENAME", "ZJPRI_CONSTRUCT_INTERMEDIATE", "企业所在地名称");
            /// <summary>
			/// 全局唯一标识符
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "ZJPRI_CONSTRUCT_INTERMEDIATE", "全局唯一标识符");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "ZJPRI_CONSTRUCT_INTERMEDIATE", "创建时间");
            /// <summary>
			/// 版本号
			/// </summary>
			public readonly static Field VERSION = new Field("VERSION", "ZJPRI_CONSTRUCT_INTERMEDIATE", "版本号");
            /// <summary>
			/// 职称证书附件
			/// </summary>
			public readonly static Field TITLE_FILE = new Field("TITLE_FILE", "ZJPRI_CONSTRUCT_INTERMEDIATE", "职称证书附件");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field DATA_SOURCE = new Field("DATA_SOURCE", "ZJPRI_CONSTRUCT_INTERMEDIATE", "数据来源");
        }
        #endregion
	}
}