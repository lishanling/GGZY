using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ZJPRI_CONSTRUCT_ENTER_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJPRI_CONSTRUCT_ENTER_INFO")]
    [Serializable]
    public partial class ZJPRI_CONSTRUCT_ENTER_INFO : FwEntity
    {
        #region Model
		private decimal? _COMPANYID;
		private string _COMPANYMAINNAME;
		private string _USEDNAME;
		private decimal? _OFFICERID;
		private string _OFFICERNAME;
		private decimal? _AREA;
		private string _COUNTRYWIDENAME;
		private string _CODE;
		private string _REGISTERADDRESS;
		private string _REGISTERPOSTCODE;
		private string _DETAILADDRESS;
		private string _DETAILREGISTERPOSTCODE;
		private string _BUSSINESSCHARTER;
		private string _CORPORATIONNUMBER;
		private string _SOCIALCREDITCODE;
		private decimal? _PRINCIPAL;
		private decimal? _MONETARYUNITID;
		private string _MONETARYUNITNAME;
		private decimal? _ECONOMYTYPEID;
		private string _ECONOMYTYPENAME;
		private DateTime? _BUSSINESSDATESTART;
		private string _FAX;
		private string _PHONE;
		private string _LINKMANMOBILE;
		private string _EMAIL;
		private string _WEBSITE;
		private string _LINKMAN;
		private string _LINKMANTELEPHONE;
		private decimal? _BUSINESSSYSTEMTYPEID;
		private string _BUSINESSSYSTEMTYPENAME;
		private string _GUID;
		private DateTime? _CREATE_TIME;
		private string _VERSION;
		private string _DATA_SOURCE;
		private decimal? _ZZ_TYPE;
		private DateTime? _ZZJGDMZ_SXTM;
		private string _ZZJGDMZ_FILE;
		private DateTime? _YYZZ_SXTM;
		private string _YYZZ_FILE;
		private string _SWDJZ_TYPE;
		private string _SWDJZ_NO;
		private DateTime? _SWDJZ_SXTM;
		private string _SWDJZ_FILE;
		private string _ID;
		private string _SOCIALCREDITCODE_FILE;
		private string _LEGAL_CODE;

		/// <summary>
		/// 企业主键ID
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
		/// 企业曾用名
		/// </summary>
		public string USEDNAME
		{
			get{ return _USEDNAME; }
			set
			{
				this.OnPropertyValueChange(_.USEDNAME, _USEDNAME, value);
				this._USEDNAME = value;
			}
		}
		/// <summary>
		/// 初审部门ID
		/// </summary>
		public decimal? OFFICERID
		{
			get{ return _OFFICERID; }
			set
			{
				this.OnPropertyValueChange(_.OFFICERID, _OFFICERID, value);
				this._OFFICERID = value;
			}
		}
		/// <summary>
		/// 初审部门名称
		/// </summary>
		public string OFFICERNAME
		{
			get{ return _OFFICERNAME; }
			set
			{
				this.OnPropertyValueChange(_.OFFICERNAME, _OFFICERNAME, value);
				this._OFFICERNAME = value;
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
		/// 区划编码
		/// </summary>
		public string CODE
		{
			get{ return _CODE; }
			set
			{
				this.OnPropertyValueChange(_.CODE, _CODE, value);
				this._CODE = value;
			}
		}
		/// <summary>
		/// 企业注册地址
		/// </summary>
		public string REGISTERADDRESS
		{
			get{ return _REGISTERADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.REGISTERADDRESS, _REGISTERADDRESS, value);
				this._REGISTERADDRESS = value;
			}
		}
		/// <summary>
		/// 注册地址邮政编码
		/// </summary>
		public string REGISTERPOSTCODE
		{
			get{ return _REGISTERPOSTCODE; }
			set
			{
				this.OnPropertyValueChange(_.REGISTERPOSTCODE, _REGISTERPOSTCODE, value);
				this._REGISTERPOSTCODE = value;
			}
		}
		/// <summary>
		/// 企业详细地址
		/// </summary>
		public string DETAILADDRESS
		{
			get{ return _DETAILADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.DETAILADDRESS, _DETAILADDRESS, value);
				this._DETAILADDRESS = value;
			}
		}
		/// <summary>
		/// 详细地址邮政编码
		/// </summary>
		public string DETAILREGISTERPOSTCODE
		{
			get{ return _DETAILREGISTERPOSTCODE; }
			set
			{
				this.OnPropertyValueChange(_.DETAILREGISTERPOSTCODE, _DETAILREGISTERPOSTCODE, value);
				this._DETAILREGISTERPOSTCODE = value;
			}
		}
		/// <summary>
		/// 营业执照注册号
		/// </summary>
		public string BUSSINESSCHARTER
		{
			get{ return _BUSSINESSCHARTER; }
			set
			{
				this.OnPropertyValueChange(_.BUSSINESSCHARTER, _BUSSINESSCHARTER, value);
				this._BUSSINESSCHARTER = value;
			}
		}
		/// <summary>
		/// 组织机构代码
		/// </summary>
		public string CORPORATIONNUMBER
		{
			get{ return _CORPORATIONNUMBER; }
			set
			{
				this.OnPropertyValueChange(_.CORPORATIONNUMBER, _CORPORATIONNUMBER, value);
				this._CORPORATIONNUMBER = value;
			}
		}
		/// <summary>
		/// 统一社会信用代码
		/// </summary>
		public string SOCIALCREDITCODE
		{
			get{ return _SOCIALCREDITCODE; }
			set
			{
				this.OnPropertyValueChange(_.SOCIALCREDITCODE, _SOCIALCREDITCODE, value);
				this._SOCIALCREDITCODE = value;
			}
		}
		/// <summary>
		/// 注册资本（万元）
		/// </summary>
		public decimal? PRINCIPAL
		{
			get{ return _PRINCIPAL; }
			set
			{
				this.OnPropertyValueChange(_.PRINCIPAL, _PRINCIPAL, value);
				this._PRINCIPAL = value;
			}
		}
		/// <summary>
		/// 注册资本金币种ID
		/// </summary>
		public decimal? MONETARYUNITID
		{
			get{ return _MONETARYUNITID; }
			set
			{
				this.OnPropertyValueChange(_.MONETARYUNITID, _MONETARYUNITID, value);
				this._MONETARYUNITID = value;
			}
		}
		/// <summary>
		/// 注册资本金币种名称
		/// </summary>
		public string MONETARYUNITNAME
		{
			get{ return _MONETARYUNITNAME; }
			set
			{
				this.OnPropertyValueChange(_.MONETARYUNITNAME, _MONETARYUNITNAME, value);
				this._MONETARYUNITNAME = value;
			}
		}
		/// <summary>
		/// 企业经济类别ID
		/// </summary>
		public decimal? ECONOMYTYPEID
		{
			get{ return _ECONOMYTYPEID; }
			set
			{
				this.OnPropertyValueChange(_.ECONOMYTYPEID, _ECONOMYTYPEID, value);
				this._ECONOMYTYPEID = value;
			}
		}
		/// <summary>
		/// 企业经济类别名称
		/// </summary>
		public string ECONOMYTYPENAME
		{
			get{ return _ECONOMYTYPENAME; }
			set
			{
				this.OnPropertyValueChange(_.ECONOMYTYPENAME, _ECONOMYTYPENAME, value);
				this._ECONOMYTYPENAME = value;
			}
		}
		/// <summary>
		/// 建立时间
		/// </summary>
		public DateTime? BUSSINESSDATESTART
		{
			get{ return _BUSSINESSDATESTART; }
			set
			{
				this.OnPropertyValueChange(_.BUSSINESSDATESTART, _BUSSINESSDATESTART, value);
				this._BUSSINESSDATESTART = value;
			}
		}
		/// <summary>
		/// 传真
		/// </summary>
		public string FAX
		{
			get{ return _FAX; }
			set
			{
				this.OnPropertyValueChange(_.FAX, _FAX, value);
				this._FAX = value;
			}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string PHONE
		{
			get{ return _PHONE; }
			set
			{
				this.OnPropertyValueChange(_.PHONE, _PHONE, value);
				this._PHONE = value;
			}
		}
		/// <summary>
		/// 联系手机
		/// </summary>
		public string LINKMANMOBILE
		{
			get{ return _LINKMANMOBILE; }
			set
			{
				this.OnPropertyValueChange(_.LINKMANMOBILE, _LINKMANMOBILE, value);
				this._LINKMANMOBILE = value;
			}
		}
		/// <summary>
		/// 电子邮箱
		/// </summary>
		public string EMAIL
		{
			get{ return _EMAIL; }
			set
			{
				this.OnPropertyValueChange(_.EMAIL, _EMAIL, value);
				this._EMAIL = value;
			}
		}
		/// <summary>
		/// 企业网址
		/// </summary>
		public string WEBSITE
		{
			get{ return _WEBSITE; }
			set
			{
				this.OnPropertyValueChange(_.WEBSITE, _WEBSITE, value);
				this._WEBSITE = value;
			}
		}
		/// <summary>
		/// 联系人姓名
		/// </summary>
		public string LINKMAN
		{
			get{ return _LINKMAN; }
			set
			{
				this.OnPropertyValueChange(_.LINKMAN, _LINKMAN, value);
				this._LINKMAN = value;
			}
		}
		/// <summary>
		/// 联系人办公电话
		/// </summary>
		public string LINKMANTELEPHONE
		{
			get{ return _LINKMANTELEPHONE; }
			set
			{
				this.OnPropertyValueChange(_.LINKMANTELEPHONE, _LINKMANTELEPHONE, value);
				this._LINKMANTELEPHONE = value;
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
		/// 证照选择类型 1、社会信用统一代码证2、其他证照
		/// </summary>
		public decimal? ZZ_TYPE
		{
			get{ return _ZZ_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.ZZ_TYPE, _ZZ_TYPE, value);
				this._ZZ_TYPE = value;
			}
		}
		/// <summary>
		/// 组织机构代码证失效日期
		/// </summary>
		public DateTime? ZZJGDMZ_SXTM
		{
			get{ return _ZZJGDMZ_SXTM; }
			set
			{
				this.OnPropertyValueChange(_.ZZJGDMZ_SXTM, _ZZJGDMZ_SXTM, value);
				this._ZZJGDMZ_SXTM = value;
			}
		}
		/// <summary>
		/// 组织机构代码证附件
		/// </summary>
		public string ZZJGDMZ_FILE
		{
			get{ return _ZZJGDMZ_FILE; }
			set
			{
				this.OnPropertyValueChange(_.ZZJGDMZ_FILE, _ZZJGDMZ_FILE, value);
				this._ZZJGDMZ_FILE = value;
			}
		}
		/// <summary>
		/// 营业执照失效日期
		/// </summary>
		public DateTime? YYZZ_SXTM
		{
			get{ return _YYZZ_SXTM; }
			set
			{
				this.OnPropertyValueChange(_.YYZZ_SXTM, _YYZZ_SXTM, value);
				this._YYZZ_SXTM = value;
			}
		}
		/// <summary>
		/// 营业执照附件
		/// </summary>
		public string YYZZ_FILE
		{
			get{ return _YYZZ_FILE; }
			set
			{
				this.OnPropertyValueChange(_.YYZZ_FILE, _YYZZ_FILE, value);
				this._YYZZ_FILE = value;
			}
		}
		/// <summary>
		/// 税务登记证类型
		/// </summary>
		public string SWDJZ_TYPE
		{
			get{ return _SWDJZ_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.SWDJZ_TYPE, _SWDJZ_TYPE, value);
				this._SWDJZ_TYPE = value;
			}
		}
		/// <summary>
		/// 税务登记证编号
		/// </summary>
		public string SWDJZ_NO
		{
			get{ return _SWDJZ_NO; }
			set
			{
				this.OnPropertyValueChange(_.SWDJZ_NO, _SWDJZ_NO, value);
				this._SWDJZ_NO = value;
			}
		}
		/// <summary>
		/// 税务登记证失效日期
		/// </summary>
		public DateTime? SWDJZ_SXTM
		{
			get{ return _SWDJZ_SXTM; }
			set
			{
				this.OnPropertyValueChange(_.SWDJZ_SXTM, _SWDJZ_SXTM, value);
				this._SWDJZ_SXTM = value;
			}
		}
		/// <summary>
		/// 税务登记证附件
		/// </summary>
		public string SWDJZ_FILE
		{
			get{ return _SWDJZ_FILE; }
			set
			{
				this.OnPropertyValueChange(_.SWDJZ_FILE, _SWDJZ_FILE, value);
				this._SWDJZ_FILE = value;
			}
		}
		/// <summary>
		/// 主键GUID默认生成
		/// </summary>
		public string ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 社会统一信用代码附件
		/// </summary>
		public string SOCIALCREDITCODE_FILE
		{
			get{ return _SOCIALCREDITCODE_FILE; }
			set
			{
				this.OnPropertyValueChange(_.SOCIALCREDITCODE_FILE, _SOCIALCREDITCODE_FILE, value);
				this._SOCIALCREDITCODE_FILE = value;
			}
		}
		/// <summary>
		/// 同步投标人名单中的法人代码
		/// </summary>
		public string LEGAL_CODE
		{
			get{ return _LEGAL_CODE; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_CODE, _LEGAL_CODE, value);
				this._LEGAL_CODE = value;
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
				_.COMPANYID,
				_.COMPANYMAINNAME,
				_.USEDNAME,
				_.OFFICERID,
				_.OFFICERNAME,
				_.AREA,
				_.COUNTRYWIDENAME,
				_.CODE,
				_.REGISTERADDRESS,
				_.REGISTERPOSTCODE,
				_.DETAILADDRESS,
				_.DETAILREGISTERPOSTCODE,
				_.BUSSINESSCHARTER,
				_.CORPORATIONNUMBER,
				_.SOCIALCREDITCODE,
				_.PRINCIPAL,
				_.MONETARYUNITID,
				_.MONETARYUNITNAME,
				_.ECONOMYTYPEID,
				_.ECONOMYTYPENAME,
				_.BUSSINESSDATESTART,
				_.FAX,
				_.PHONE,
				_.LINKMANMOBILE,
				_.EMAIL,
				_.WEBSITE,
				_.LINKMAN,
				_.LINKMANTELEPHONE,
				_.BUSINESSSYSTEMTYPEID,
				_.BUSINESSSYSTEMTYPENAME,
				_.GUID,
				_.CREATE_TIME,
				_.VERSION,
				_.DATA_SOURCE,
				_.ZZ_TYPE,
				_.ZZJGDMZ_SXTM,
				_.ZZJGDMZ_FILE,
				_.YYZZ_SXTM,
				_.YYZZ_FILE,
				_.SWDJZ_TYPE,
				_.SWDJZ_NO,
				_.SWDJZ_SXTM,
				_.SWDJZ_FILE,
				_.ID,
				_.SOCIALCREDITCODE_FILE,
				_.LEGAL_CODE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._COMPANYID,
				this._COMPANYMAINNAME,
				this._USEDNAME,
				this._OFFICERID,
				this._OFFICERNAME,
				this._AREA,
				this._COUNTRYWIDENAME,
				this._CODE,
				this._REGISTERADDRESS,
				this._REGISTERPOSTCODE,
				this._DETAILADDRESS,
				this._DETAILREGISTERPOSTCODE,
				this._BUSSINESSCHARTER,
				this._CORPORATIONNUMBER,
				this._SOCIALCREDITCODE,
				this._PRINCIPAL,
				this._MONETARYUNITID,
				this._MONETARYUNITNAME,
				this._ECONOMYTYPEID,
				this._ECONOMYTYPENAME,
				this._BUSSINESSDATESTART,
				this._FAX,
				this._PHONE,
				this._LINKMANMOBILE,
				this._EMAIL,
				this._WEBSITE,
				this._LINKMAN,
				this._LINKMANTELEPHONE,
				this._BUSINESSSYSTEMTYPEID,
				this._BUSINESSSYSTEMTYPENAME,
				this._GUID,
				this._CREATE_TIME,
				this._VERSION,
				this._DATA_SOURCE,
				this._ZZ_TYPE,
				this._ZZJGDMZ_SXTM,
				this._ZZJGDMZ_FILE,
				this._YYZZ_SXTM,
				this._YYZZ_FILE,
				this._SWDJZ_TYPE,
				this._SWDJZ_NO,
				this._SWDJZ_SXTM,
				this._SWDJZ_FILE,
				this._ID,
				this._SOCIALCREDITCODE_FILE,
				this._LEGAL_CODE,
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
			public readonly static Field All = new Field("*", "ZJPRI_CONSTRUCT_ENTER_INFO");
            /// <summary>
			/// 企业主键ID
			/// </summary>
			public readonly static Field COMPANYID = new Field("COMPANYID", "ZJPRI_CONSTRUCT_ENTER_INFO", "企业主键ID");
            /// <summary>
			/// 企业名称
			/// </summary>
			public readonly static Field COMPANYMAINNAME = new Field("COMPANYMAINNAME", "ZJPRI_CONSTRUCT_ENTER_INFO", "企业名称");
            /// <summary>
			/// 企业曾用名
			/// </summary>
			public readonly static Field USEDNAME = new Field("USEDNAME", "ZJPRI_CONSTRUCT_ENTER_INFO", "企业曾用名");
            /// <summary>
			/// 初审部门ID
			/// </summary>
			public readonly static Field OFFICERID = new Field("OFFICERID", "ZJPRI_CONSTRUCT_ENTER_INFO", "初审部门ID");
            /// <summary>
			/// 初审部门名称
			/// </summary>
			public readonly static Field OFFICERNAME = new Field("OFFICERNAME", "ZJPRI_CONSTRUCT_ENTER_INFO", "初审部门名称");
            /// <summary>
			/// 企业所在地ID
			/// </summary>
			public readonly static Field AREA = new Field("AREA", "ZJPRI_CONSTRUCT_ENTER_INFO", "企业所在地ID");
            /// <summary>
			/// 企业所在地名称
			/// </summary>
			public readonly static Field COUNTRYWIDENAME = new Field("COUNTRYWIDENAME", "ZJPRI_CONSTRUCT_ENTER_INFO", "企业所在地名称");
            /// <summary>
			/// 区划编码
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "ZJPRI_CONSTRUCT_ENTER_INFO", "区划编码");
            /// <summary>
			/// 企业注册地址
			/// </summary>
			public readonly static Field REGISTERADDRESS = new Field("REGISTERADDRESS", "ZJPRI_CONSTRUCT_ENTER_INFO", "企业注册地址");
            /// <summary>
			/// 注册地址邮政编码
			/// </summary>
			public readonly static Field REGISTERPOSTCODE = new Field("REGISTERPOSTCODE", "ZJPRI_CONSTRUCT_ENTER_INFO", "注册地址邮政编码");
            /// <summary>
			/// 企业详细地址
			/// </summary>
			public readonly static Field DETAILADDRESS = new Field("DETAILADDRESS", "ZJPRI_CONSTRUCT_ENTER_INFO", "企业详细地址");
            /// <summary>
			/// 详细地址邮政编码
			/// </summary>
			public readonly static Field DETAILREGISTERPOSTCODE = new Field("DETAILREGISTERPOSTCODE", "ZJPRI_CONSTRUCT_ENTER_INFO", "详细地址邮政编码");
            /// <summary>
			/// 营业执照注册号
			/// </summary>
			public readonly static Field BUSSINESSCHARTER = new Field("BUSSINESSCHARTER", "ZJPRI_CONSTRUCT_ENTER_INFO", "营业执照注册号");
            /// <summary>
			/// 组织机构代码
			/// </summary>
			public readonly static Field CORPORATIONNUMBER = new Field("CORPORATIONNUMBER", "ZJPRI_CONSTRUCT_ENTER_INFO", "组织机构代码");
            /// <summary>
			/// 统一社会信用代码
			/// </summary>
			public readonly static Field SOCIALCREDITCODE = new Field("SOCIALCREDITCODE", "ZJPRI_CONSTRUCT_ENTER_INFO", "统一社会信用代码");
            /// <summary>
			/// 注册资本（万元）
			/// </summary>
			public readonly static Field PRINCIPAL = new Field("PRINCIPAL", "ZJPRI_CONSTRUCT_ENTER_INFO", "注册资本（万元）");
            /// <summary>
			/// 注册资本金币种ID
			/// </summary>
			public readonly static Field MONETARYUNITID = new Field("MONETARYUNITID", "ZJPRI_CONSTRUCT_ENTER_INFO", "注册资本金币种ID");
            /// <summary>
			/// 注册资本金币种名称
			/// </summary>
			public readonly static Field MONETARYUNITNAME = new Field("MONETARYUNITNAME", "ZJPRI_CONSTRUCT_ENTER_INFO", "注册资本金币种名称");
            /// <summary>
			/// 企业经济类别ID
			/// </summary>
			public readonly static Field ECONOMYTYPEID = new Field("ECONOMYTYPEID", "ZJPRI_CONSTRUCT_ENTER_INFO", "企业经济类别ID");
            /// <summary>
			/// 企业经济类别名称
			/// </summary>
			public readonly static Field ECONOMYTYPENAME = new Field("ECONOMYTYPENAME", "ZJPRI_CONSTRUCT_ENTER_INFO", "企业经济类别名称");
            /// <summary>
			/// 建立时间
			/// </summary>
			public readonly static Field BUSSINESSDATESTART = new Field("BUSSINESSDATESTART", "ZJPRI_CONSTRUCT_ENTER_INFO", "建立时间");
            /// <summary>
			/// 传真
			/// </summary>
			public readonly static Field FAX = new Field("FAX", "ZJPRI_CONSTRUCT_ENTER_INFO", "传真");
            /// <summary>
			/// 联系电话
			/// </summary>
			public readonly static Field PHONE = new Field("PHONE", "ZJPRI_CONSTRUCT_ENTER_INFO", "联系电话");
            /// <summary>
			/// 联系手机
			/// </summary>
			public readonly static Field LINKMANMOBILE = new Field("LINKMANMOBILE", "ZJPRI_CONSTRUCT_ENTER_INFO", "联系手机");
            /// <summary>
			/// 电子邮箱
			/// </summary>
			public readonly static Field EMAIL = new Field("EMAIL", "ZJPRI_CONSTRUCT_ENTER_INFO", "电子邮箱");
            /// <summary>
			/// 企业网址
			/// </summary>
			public readonly static Field WEBSITE = new Field("WEBSITE", "ZJPRI_CONSTRUCT_ENTER_INFO", "企业网址");
            /// <summary>
			/// 联系人姓名
			/// </summary>
			public readonly static Field LINKMAN = new Field("LINKMAN", "ZJPRI_CONSTRUCT_ENTER_INFO", "联系人姓名");
            /// <summary>
			/// 联系人办公电话
			/// </summary>
			public readonly static Field LINKMANTELEPHONE = new Field("LINKMANTELEPHONE", "ZJPRI_CONSTRUCT_ENTER_INFO", "联系人办公电话");
            /// <summary>
			/// 企业所属业务系统ID
			/// </summary>
			public readonly static Field BUSINESSSYSTEMTYPEID = new Field("BUSINESSSYSTEMTYPEID", "ZJPRI_CONSTRUCT_ENTER_INFO", "企业所属业务系统ID");
            /// <summary>
			/// 企业所属业务系统名称
			/// </summary>
			public readonly static Field BUSINESSSYSTEMTYPENAME = new Field("BUSINESSSYSTEMTYPENAME", "ZJPRI_CONSTRUCT_ENTER_INFO", "企业所属业务系统名称");
            /// <summary>
			/// 全局唯一标识符
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "ZJPRI_CONSTRUCT_ENTER_INFO", "全局唯一标识符");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "ZJPRI_CONSTRUCT_ENTER_INFO", "创建时间");
            /// <summary>
			/// 版本号
			/// </summary>
			public readonly static Field VERSION = new Field("VERSION", "ZJPRI_CONSTRUCT_ENTER_INFO", "版本号");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field DATA_SOURCE = new Field("DATA_SOURCE", "ZJPRI_CONSTRUCT_ENTER_INFO", "数据来源");
            /// <summary>
			/// 证照选择类型 1、社会信用统一代码证2、其他证照
			/// </summary>
			public readonly static Field ZZ_TYPE = new Field("ZZ_TYPE", "ZJPRI_CONSTRUCT_ENTER_INFO", "证照选择类型 1、社会信用统一代码证2、其他证照");
            /// <summary>
			/// 组织机构代码证失效日期
			/// </summary>
			public readonly static Field ZZJGDMZ_SXTM = new Field("ZZJGDMZ_SXTM", "ZJPRI_CONSTRUCT_ENTER_INFO", "组织机构代码证失效日期");
            /// <summary>
			/// 组织机构代码证附件
			/// </summary>
			public readonly static Field ZZJGDMZ_FILE = new Field("ZZJGDMZ_FILE", "ZJPRI_CONSTRUCT_ENTER_INFO", "组织机构代码证附件");
            /// <summary>
			/// 营业执照失效日期
			/// </summary>
			public readonly static Field YYZZ_SXTM = new Field("YYZZ_SXTM", "ZJPRI_CONSTRUCT_ENTER_INFO", "营业执照失效日期");
            /// <summary>
			/// 营业执照附件
			/// </summary>
			public readonly static Field YYZZ_FILE = new Field("YYZZ_FILE", "ZJPRI_CONSTRUCT_ENTER_INFO", "营业执照附件");
            /// <summary>
			/// 税务登记证类型
			/// </summary>
			public readonly static Field SWDJZ_TYPE = new Field("SWDJZ_TYPE", "ZJPRI_CONSTRUCT_ENTER_INFO", "税务登记证类型");
            /// <summary>
			/// 税务登记证编号
			/// </summary>
			public readonly static Field SWDJZ_NO = new Field("SWDJZ_NO", "ZJPRI_CONSTRUCT_ENTER_INFO", "税务登记证编号");
            /// <summary>
			/// 税务登记证失效日期
			/// </summary>
			public readonly static Field SWDJZ_SXTM = new Field("SWDJZ_SXTM", "ZJPRI_CONSTRUCT_ENTER_INFO", "税务登记证失效日期");
            /// <summary>
			/// 税务登记证附件
			/// </summary>
			public readonly static Field SWDJZ_FILE = new Field("SWDJZ_FILE", "ZJPRI_CONSTRUCT_ENTER_INFO", "税务登记证附件");
            /// <summary>
			/// 主键GUID默认生成
			/// </summary>
			public readonly static Field ID = new Field("ID", "ZJPRI_CONSTRUCT_ENTER_INFO", "主键GUID默认生成");
            /// <summary>
			/// 社会统一信用代码附件
			/// </summary>
			public readonly static Field SOCIALCREDITCODE_FILE = new Field("SOCIALCREDITCODE_FILE", "ZJPRI_CONSTRUCT_ENTER_INFO", "社会统一信用代码附件");
            /// <summary>
			/// 同步投标人名单中的法人代码
			/// </summary>
			public readonly static Field LEGAL_CODE = new Field("LEGAL_CODE", "ZJPRI_CONSTRUCT_ENTER_INFO", "同步投标人名单中的法人代码");
        }
        #endregion
	}
}