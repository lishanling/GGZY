using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ZJPRI_CONSTRUCT_KEYPERSON。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJPRI_CONSTRUCT_KEYPERSON")]
    [Serializable]
    public partial class ZJPRI_CONSTRUCT_KEYPERSON : FwEntity
    {
        #region Model
		private decimal? _MAINPERSONID;
		private decimal? _BASEID;
		private string _NAME;
		private decimal? _SEX;
		private decimal? _TYPEID;
		private string _TYPENAME;
		private DateTime? _BIRTHDAY;
		private string _POSITION;
		private decimal? _TITLEID;
		private string _TITLENAME;
		private string _HIGHESTEDUCATION;
		private DateTime? _GRADUATIONTIME;
		private string _GRADUATESCHOOL;
		private string _SPECIALITY;
		private decimal? _CAREERYEAR;
		private string _TELEPHONE;
		private string _MOBILEPHONE;
		private string _IDENTITYCARDNUMBER;
		private decimal? _COMPANYID;
		private string _COMPANYMAINNAME;
		private string _ETHNIC;
		private string _DEGREE;
		private string _QUALIFICATION;
		private decimal? _BUSINESSSYSTEMTYPEID;
		private string _BUSINESSSYSTEMTYPENAME;
		private decimal? _AREA;
		private string _COUNTRYWIDENAME;
		private string _GUID;
		private DateTime? _CREATE_TIME;
		private string _VERSION;
		private string _DATA_SOURCE;

		/// <summary>
		/// 主要人员ID
		/// </summary>
		public decimal? MAINPERSONID
		{
			get{ return _MAINPERSONID; }
			set
			{
				this.OnPropertyValueChange(_.MAINPERSONID, _MAINPERSONID, value);
				this._MAINPERSONID = value;
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
		/// 性别
		/// </summary>
		public decimal? SEX
		{
			get{ return _SEX; }
			set
			{
				this.OnPropertyValueChange(_.SEX, _SEX, value);
				this._SEX = value;
			}
		}
		/// <summary>
		/// 人员类型
		/// </summary>
		public decimal? TYPEID
		{
			get{ return _TYPEID; }
			set
			{
				this.OnPropertyValueChange(_.TYPEID, _TYPEID, value);
				this._TYPEID = value;
			}
		}
		/// <summary>
		/// 人员类型名称
		/// </summary>
		public string TYPENAME
		{
			get{ return _TYPENAME; }
			set
			{
				this.OnPropertyValueChange(_.TYPENAME, _TYPENAME, value);
				this._TYPENAME = value;
			}
		}
		/// <summary>
		/// 出生年月
		/// </summary>
		public DateTime? BIRTHDAY
		{
			get{ return _BIRTHDAY; }
			set
			{
				this.OnPropertyValueChange(_.BIRTHDAY, _BIRTHDAY, value);
				this._BIRTHDAY = value;
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
		/// 最高学历
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
		/// 毕业时间
		/// </summary>
		public DateTime? GRADUATIONTIME
		{
			get{ return _GRADUATIONTIME; }
			set
			{
				this.OnPropertyValueChange(_.GRADUATIONTIME, _GRADUATIONTIME, value);
				this._GRADUATIONTIME = value;
			}
		}
		/// <summary>
		/// 毕业院校
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
		/// 专业
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
		/// 工程管理资历
		/// </summary>
		public decimal? CAREERYEAR
		{
			get{ return _CAREERYEAR; }
			set
			{
				this.OnPropertyValueChange(_.CAREERYEAR, _CAREERYEAR, value);
				this._CAREERYEAR = value;
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
		/// 民族
		/// </summary>
		public string ETHNIC
		{
			get{ return _ETHNIC; }
			set
			{
				this.OnPropertyValueChange(_.ETHNIC, _ETHNIC, value);
				this._ETHNIC = value;
			}
		}
		/// <summary>
		/// 学位
		/// </summary>
		public string DEGREE
		{
			get{ return _DEGREE; }
			set
			{
				this.OnPropertyValueChange(_.DEGREE, _DEGREE, value);
				this._DEGREE = value;
			}
		}
		/// <summary>
		/// 执业资格
		/// </summary>
		public string QUALIFICATION
		{
			get{ return _QUALIFICATION; }
			set
			{
				this.OnPropertyValueChange(_.QUALIFICATION, _QUALIFICATION, value);
				this._QUALIFICATION = value;
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
				_.MAINPERSONID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.MAINPERSONID,
				_.BASEID,
				_.NAME,
				_.SEX,
				_.TYPEID,
				_.TYPENAME,
				_.BIRTHDAY,
				_.POSITION,
				_.TITLEID,
				_.TITLENAME,
				_.HIGHESTEDUCATION,
				_.GRADUATIONTIME,
				_.GRADUATESCHOOL,
				_.SPECIALITY,
				_.CAREERYEAR,
				_.TELEPHONE,
				_.MOBILEPHONE,
				_.IDENTITYCARDNUMBER,
				_.COMPANYID,
				_.COMPANYMAINNAME,
				_.ETHNIC,
				_.DEGREE,
				_.QUALIFICATION,
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
				this._MAINPERSONID,
				this._BASEID,
				this._NAME,
				this._SEX,
				this._TYPEID,
				this._TYPENAME,
				this._BIRTHDAY,
				this._POSITION,
				this._TITLEID,
				this._TITLENAME,
				this._HIGHESTEDUCATION,
				this._GRADUATIONTIME,
				this._GRADUATESCHOOL,
				this._SPECIALITY,
				this._CAREERYEAR,
				this._TELEPHONE,
				this._MOBILEPHONE,
				this._IDENTITYCARDNUMBER,
				this._COMPANYID,
				this._COMPANYMAINNAME,
				this._ETHNIC,
				this._DEGREE,
				this._QUALIFICATION,
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
			public readonly static Field All = new Field("*", "ZJPRI_CONSTRUCT_KEYPERSON");
            /// <summary>
			/// 主要人员ID
			/// </summary>
			public readonly static Field MAINPERSONID = new Field("MAINPERSONID", "ZJPRI_CONSTRUCT_KEYPERSON", "主要人员ID");
            /// <summary>
			/// 基础人员ID
			/// </summary>
			public readonly static Field BASEID = new Field("BASEID", "ZJPRI_CONSTRUCT_KEYPERSON", "基础人员ID");
            /// <summary>
			/// 姓名
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "ZJPRI_CONSTRUCT_KEYPERSON", "姓名");
            /// <summary>
			/// 性别
			/// </summary>
			public readonly static Field SEX = new Field("SEX", "ZJPRI_CONSTRUCT_KEYPERSON", "性别");
            /// <summary>
			/// 人员类型
			/// </summary>
			public readonly static Field TYPEID = new Field("TYPEID", "ZJPRI_CONSTRUCT_KEYPERSON", "人员类型");
            /// <summary>
			/// 人员类型名称
			/// </summary>
			public readonly static Field TYPENAME = new Field("TYPENAME", "ZJPRI_CONSTRUCT_KEYPERSON", "人员类型名称");
            /// <summary>
			/// 出生年月
			/// </summary>
			public readonly static Field BIRTHDAY = new Field("BIRTHDAY", "ZJPRI_CONSTRUCT_KEYPERSON", "出生年月");
            /// <summary>
			/// 职务
			/// </summary>
			public readonly static Field POSITION = new Field("POSITION", "ZJPRI_CONSTRUCT_KEYPERSON", "职务");
            /// <summary>
			/// 职称ID
			/// </summary>
			public readonly static Field TITLEID = new Field("TITLEID", "ZJPRI_CONSTRUCT_KEYPERSON", "职称ID");
            /// <summary>
			/// 职称名称
			/// </summary>
			public readonly static Field TITLENAME = new Field("TITLENAME", "ZJPRI_CONSTRUCT_KEYPERSON", "职称名称");
            /// <summary>
			/// 最高学历
			/// </summary>
			public readonly static Field HIGHESTEDUCATION = new Field("HIGHESTEDUCATION", "ZJPRI_CONSTRUCT_KEYPERSON", "最高学历");
            /// <summary>
			/// 毕业时间
			/// </summary>
			public readonly static Field GRADUATIONTIME = new Field("GRADUATIONTIME", "ZJPRI_CONSTRUCT_KEYPERSON", "毕业时间");
            /// <summary>
			/// 毕业院校
			/// </summary>
			public readonly static Field GRADUATESCHOOL = new Field("GRADUATESCHOOL", "ZJPRI_CONSTRUCT_KEYPERSON", "毕业院校");
            /// <summary>
			/// 专业
			/// </summary>
			public readonly static Field SPECIALITY = new Field("SPECIALITY", "ZJPRI_CONSTRUCT_KEYPERSON", "专业");
            /// <summary>
			/// 工程管理资历
			/// </summary>
			public readonly static Field CAREERYEAR = new Field("CAREERYEAR", "ZJPRI_CONSTRUCT_KEYPERSON", "工程管理资历");
            /// <summary>
			/// 电话
			/// </summary>
			public readonly static Field TELEPHONE = new Field("TELEPHONE", "ZJPRI_CONSTRUCT_KEYPERSON", "电话");
            /// <summary>
			/// 移动电话
			/// </summary>
			public readonly static Field MOBILEPHONE = new Field("MOBILEPHONE", "ZJPRI_CONSTRUCT_KEYPERSON", "移动电话");
            /// <summary>
			/// 身份证号码
			/// </summary>
			public readonly static Field IDENTITYCARDNUMBER = new Field("IDENTITYCARDNUMBER", "ZJPRI_CONSTRUCT_KEYPERSON", "身份证号码");
            /// <summary>
			/// 企业ID
			/// </summary>
			public readonly static Field COMPANYID = new Field("COMPANYID", "ZJPRI_CONSTRUCT_KEYPERSON", "企业ID");
            /// <summary>
			/// 企业名称
			/// </summary>
			public readonly static Field COMPANYMAINNAME = new Field("COMPANYMAINNAME", "ZJPRI_CONSTRUCT_KEYPERSON", "企业名称");
            /// <summary>
			/// 民族
			/// </summary>
			public readonly static Field ETHNIC = new Field("ETHNIC", "ZJPRI_CONSTRUCT_KEYPERSON", "民族");
            /// <summary>
			/// 学位
			/// </summary>
			public readonly static Field DEGREE = new Field("DEGREE", "ZJPRI_CONSTRUCT_KEYPERSON", "学位");
            /// <summary>
			/// 执业资格
			/// </summary>
			public readonly static Field QUALIFICATION = new Field("QUALIFICATION", "ZJPRI_CONSTRUCT_KEYPERSON", "执业资格");
            /// <summary>
			/// 企业所属业务系统ID
			/// </summary>
			public readonly static Field BUSINESSSYSTEMTYPEID = new Field("BUSINESSSYSTEMTYPEID", "ZJPRI_CONSTRUCT_KEYPERSON", "企业所属业务系统ID");
            /// <summary>
			/// 企业所属业务系统名称
			/// </summary>
			public readonly static Field BUSINESSSYSTEMTYPENAME = new Field("BUSINESSSYSTEMTYPENAME", "ZJPRI_CONSTRUCT_KEYPERSON", "企业所属业务系统名称");
            /// <summary>
			/// 企业所在地ID
			/// </summary>
			public readonly static Field AREA = new Field("AREA", "ZJPRI_CONSTRUCT_KEYPERSON", "企业所在地ID");
            /// <summary>
			/// 企业所在地名称
			/// </summary>
			public readonly static Field COUNTRYWIDENAME = new Field("COUNTRYWIDENAME", "ZJPRI_CONSTRUCT_KEYPERSON", "企业所在地名称");
            /// <summary>
			/// 全局唯一标识符
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "ZJPRI_CONSTRUCT_KEYPERSON", "全局唯一标识符");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "ZJPRI_CONSTRUCT_KEYPERSON", "创建时间");
            /// <summary>
			/// 版本号
			/// </summary>
			public readonly static Field VERSION = new Field("VERSION", "ZJPRI_CONSTRUCT_KEYPERSON", "版本号");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field DATA_SOURCE = new Field("DATA_SOURCE", "ZJPRI_CONSTRUCT_KEYPERSON", "数据来源");
        }
        #endregion
	}
}