using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_FR_BASE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_FR_BASE")]
    [Serializable]
    public partial class T_FR_BASE : JdEntity
    {
        #region Model
		private string _ORGANNO;
		private string _LEGALNAME;
		private string _LICENSENO;
		private DateTime? _LICENSEENDDATE;
		private string _TAXCERTNO;
		private string _LOCALTAXCERTNO;
		private DateTime? _TAXCERTENDDATE;
		private DateTime? _LOCALTAXCERTENDDATE;
		private string _BEFOREORGANNO;
		private DateTime? _ORGANCERTENDDATE;
		private string _LEGALREPRESENT;
		private string _LEGALTYPE;
		private string _REPRESENTPHONE;
		private string _LEGALINDUSTRY;
		private string _CREDITRATE;
		private string _COUNTRYREGION;
		private string _LEGALADDRESS;
		private string _REGIONCODE;
		private string _BASICBANK;
		private string _BASICBRANCHBANK;
		private string _BASICACCOUNTNO;
		private string _BASICACCOUNTNAME;
		private string _BASICACCOUNTLICENSENO;
		private decimal? _REGCAPITAL;
		private string _REGCAPCURRENCY;
		private string _REGUNIT;
		private string _LEGALCONTACT;
		private string _LEGALCONTACTPHONE;
		private string _LEGALWEB;
		private string _LEGALZIPCODE;
		private string _LEGALEMAIL;
		private string _LEGALROLE;
		private DateTime? _REGISTERDATE;
		private string _REGISTERADDRESS;
		private string _LEGALSTATUS;
		private string _DATASOURCENAME;
		private string _DATASOURCECODE;
		private DateTime? _DATATIMESTAMP;

		/// <summary>
		/// 法人机构代码
		/// </summary>
		public string ORGANNO
		{
			get{ return _ORGANNO; }
			set
			{
				this.OnPropertyValueChange(_.ORGANNO, _ORGANNO, value);
				this._ORGANNO = value;
			}
		}
		/// <summary>
		/// 法人机构名称
		/// </summary>
		public string LEGALNAME
		{
			get{ return _LEGALNAME; }
			set
			{
				this.OnPropertyValueChange(_.LEGALNAME, _LEGALNAME, value);
				this._LEGALNAME = value;
			}
		}
		/// <summary>
		/// 营业执照号码
		/// </summary>
		public string LICENSENO
		{
			get{ return _LICENSENO; }
			set
			{
				this.OnPropertyValueChange(_.LICENSENO, _LICENSENO, value);
				this._LICENSENO = value;
			}
		}
		/// <summary>
		/// 营业执照失效日期
		/// </summary>
		public DateTime? LICENSEENDDATE
		{
			get{ return _LICENSEENDDATE; }
			set
			{
				this.OnPropertyValueChange(_.LICENSEENDDATE, _LICENSEENDDATE, value);
				this._LICENSEENDDATE = value;
			}
		}
		/// <summary>
		/// 国税税务登记证证号
		/// </summary>
		public string TAXCERTNO
		{
			get{ return _TAXCERTNO; }
			set
			{
				this.OnPropertyValueChange(_.TAXCERTNO, _TAXCERTNO, value);
				this._TAXCERTNO = value;
			}
		}
		/// <summary>
		/// 地税税务登记证证号
		/// </summary>
		public string LOCALTAXCERTNO
		{
			get{ return _LOCALTAXCERTNO; }
			set
			{
				this.OnPropertyValueChange(_.LOCALTAXCERTNO, _LOCALTAXCERTNO, value);
				this._LOCALTAXCERTNO = value;
			}
		}
		/// <summary>
		/// 国税税务登记证失效日期
		/// </summary>
		public DateTime? TAXCERTENDDATE
		{
			get{ return _TAXCERTENDDATE; }
			set
			{
				this.OnPropertyValueChange(_.TAXCERTENDDATE, _TAXCERTENDDATE, value);
				this._TAXCERTENDDATE = value;
			}
		}
		/// <summary>
		/// 地税税务登记证失效日期
		/// </summary>
		public DateTime? LOCALTAXCERTENDDATE
		{
			get{ return _LOCALTAXCERTENDDATE; }
			set
			{
				this.OnPropertyValueChange(_.LOCALTAXCERTENDDATE, _LOCALTAXCERTENDDATE, value);
				this._LOCALTAXCERTENDDATE = value;
			}
		}
		/// <summary>
		/// 组织机构代码
		/// </summary>
		public string BEFOREORGANNO
		{
			get{ return _BEFOREORGANNO; }
			set
			{
				this.OnPropertyValueChange(_.BEFOREORGANNO, _BEFOREORGANNO, value);
				this._BEFOREORGANNO = value;
			}
		}
		/// <summary>
		/// 组织机构代码证失效日期
		/// </summary>
		public DateTime? ORGANCERTENDDATE
		{
			get{ return _ORGANCERTENDDATE; }
			set
			{
				this.OnPropertyValueChange(_.ORGANCERTENDDATE, _ORGANCERTENDDATE, value);
				this._ORGANCERTENDDATE = value;
			}
		}
		/// <summary>
		/// 法定代表人姓名
		/// </summary>
		public string LEGALREPRESENT
		{
			get{ return _LEGALREPRESENT; }
			set
			{
				this.OnPropertyValueChange(_.LEGALREPRESENT, _LEGALREPRESENT, value);
				this._LEGALREPRESENT = value;
			}
		}
		/// <summary>
		/// 法人机构类别
		/// </summary>
		public string LEGALTYPE
		{
			get{ return _LEGALTYPE; }
			set
			{
				this.OnPropertyValueChange(_.LEGALTYPE, _LEGALTYPE, value);
				this._LEGALTYPE = value;
			}
		}
		/// <summary>
		/// 法人代表联系电话
		/// </summary>
		public string REPRESENTPHONE
		{
			get{ return _REPRESENTPHONE; }
			set
			{
				this.OnPropertyValueChange(_.REPRESENTPHONE, _REPRESENTPHONE, value);
				this._REPRESENTPHONE = value;
			}
		}
		/// <summary>
		/// 法人机构行业代码
		/// </summary>
		public string LEGALINDUSTRY
		{
			get{ return _LEGALINDUSTRY; }
			set
			{
				this.OnPropertyValueChange(_.LEGALINDUSTRY, _LEGALINDUSTRY, value);
				this._LEGALINDUSTRY = value;
			}
		}
		/// <summary>
		/// 资信等级
		/// </summary>
		public string CREDITRATE
		{
			get{ return _CREDITRATE; }
			set
			{
				this.OnPropertyValueChange(_.CREDITRATE, _CREDITRATE, value);
				this._CREDITRATE = value;
			}
		}
		/// <summary>
		/// 国别/地区
		/// </summary>
		public string COUNTRYREGION
		{
			get{ return _COUNTRYREGION; }
			set
			{
				this.OnPropertyValueChange(_.COUNTRYREGION, _COUNTRYREGION, value);
				this._COUNTRYREGION = value;
			}
		}
		/// <summary>
		/// 法人机构地址
		/// </summary>
		public string LEGALADDRESS
		{
			get{ return _LEGALADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.LEGALADDRESS, _LEGALADDRESS, value);
				this._LEGALADDRESS = value;
			}
		}
		/// <summary>
		/// 行政区域代码
		/// </summary>
		public string REGIONCODE
		{
			get{ return _REGIONCODE; }
			set
			{
				this.OnPropertyValueChange(_.REGIONCODE, _REGIONCODE, value);
				this._REGIONCODE = value;
			}
		}
		/// <summary>
		/// 基本户开户银行
		/// </summary>
		public string BASICBANK
		{
			get{ return _BASICBANK; }
			set
			{
				this.OnPropertyValueChange(_.BASICBANK, _BASICBANK, value);
				this._BASICBANK = value;
			}
		}
		/// <summary>
		/// 基本户开户支行号
		/// </summary>
		public string BASICBRANCHBANK
		{
			get{ return _BASICBRANCHBANK; }
			set
			{
				this.OnPropertyValueChange(_.BASICBRANCHBANK, _BASICBRANCHBANK, value);
				this._BASICBRANCHBANK = value;
			}
		}
		/// <summary>
		/// 基本户账号
		/// </summary>
		public string BASICACCOUNTNO
		{
			get{ return _BASICACCOUNTNO; }
			set
			{
				this.OnPropertyValueChange(_.BASICACCOUNTNO, _BASICACCOUNTNO, value);
				this._BASICACCOUNTNO = value;
			}
		}
		/// <summary>
		/// 基本户账户名称
		/// </summary>
		public string BASICACCOUNTNAME
		{
			get{ return _BASICACCOUNTNAME; }
			set
			{
				this.OnPropertyValueChange(_.BASICACCOUNTNAME, _BASICACCOUNTNAME, value);
				this._BASICACCOUNTNAME = value;
			}
		}
		/// <summary>
		/// 企业基本户开户许可证证号
		/// </summary>
		public string BASICACCOUNTLICENSENO
		{
			get{ return _BASICACCOUNTLICENSENO; }
			set
			{
				this.OnPropertyValueChange(_.BASICACCOUNTLICENSENO, _BASICACCOUNTLICENSENO, value);
				this._BASICACCOUNTLICENSENO = value;
			}
		}
		/// <summary>
		/// 注册资本
		/// </summary>
		public decimal? REGCAPITAL
		{
			get{ return _REGCAPITAL; }
			set
			{
				this.OnPropertyValueChange(_.REGCAPITAL, _REGCAPITAL, value);
				this._REGCAPITAL = value;
			}
		}
		/// <summary>
		/// 注册资本币种
		/// </summary>
		public string REGCAPCURRENCY
		{
			get{ return _REGCAPCURRENCY; }
			set
			{
				this.OnPropertyValueChange(_.REGCAPCURRENCY, _REGCAPCURRENCY, value);
				this._REGCAPCURRENCY = value;
			}
		}
		/// <summary>
		/// 注册资本单位
		/// </summary>
		public string REGUNIT
		{
			get{ return _REGUNIT; }
			set
			{
				this.OnPropertyValueChange(_.REGUNIT, _REGUNIT, value);
				this._REGUNIT = value;
			}
		}
		/// <summary>
		/// 联系人
		/// </summary>
		public string LEGALCONTACT
		{
			get{ return _LEGALCONTACT; }
			set
			{
				this.OnPropertyValueChange(_.LEGALCONTACT, _LEGALCONTACT, value);
				this._LEGALCONTACT = value;
			}
		}
		/// <summary>
		/// 联系人电话
		/// </summary>
		public string LEGALCONTACTPHONE
		{
			get{ return _LEGALCONTACTPHONE; }
			set
			{
				this.OnPropertyValueChange(_.LEGALCONTACTPHONE, _LEGALCONTACTPHONE, value);
				this._LEGALCONTACTPHONE = value;
			}
		}
		/// <summary>
		/// 单位网站
		/// </summary>
		public string LEGALWEB
		{
			get{ return _LEGALWEB; }
			set
			{
				this.OnPropertyValueChange(_.LEGALWEB, _LEGALWEB, value);
				this._LEGALWEB = value;
			}
		}
		/// <summary>
		/// 邮政编码
		/// </summary>
		public string LEGALZIPCODE
		{
			get{ return _LEGALZIPCODE; }
			set
			{
				this.OnPropertyValueChange(_.LEGALZIPCODE, _LEGALZIPCODE, value);
				this._LEGALZIPCODE = value;
			}
		}
		/// <summary>
		/// 电子邮箱
		/// </summary>
		public string LEGALEMAIL
		{
			get{ return _LEGALEMAIL; }
			set
			{
				this.OnPropertyValueChange(_.LEGALEMAIL, _LEGALEMAIL, value);
				this._LEGALEMAIL = value;
			}
		}
		/// <summary>
		/// 法人机构角色
		/// </summary>
		public string LEGALROLE
		{
			get{ return _LEGALROLE; }
			set
			{
				this.OnPropertyValueChange(_.LEGALROLE, _LEGALROLE, value);
				this._LEGALROLE = value;
			}
		}
		/// <summary>
		/// 登记日期
		/// </summary>
		public DateTime? REGISTERDATE
		{
			get{ return _REGISTERDATE; }
			set
			{
				this.OnPropertyValueChange(_.REGISTERDATE, _REGISTERDATE, value);
				this._REGISTERDATE = value;
			}
		}
		/// <summary>
		/// 登记地点
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
		/// 法人业务状态
		/// </summary>
		public string LEGALSTATUS
		{
			get{ return _LEGALSTATUS; }
			set
			{
				this.OnPropertyValueChange(_.LEGALSTATUS, _LEGALSTATUS, value);
				this._LEGALSTATUS = value;
			}
		}
		/// <summary>
		/// 数据来源名称
		/// </summary>
		public string DATASOURCENAME
		{
			get{ return _DATASOURCENAME; }
			set
			{
				this.OnPropertyValueChange(_.DATASOURCENAME, _DATASOURCENAME, value);
				this._DATASOURCENAME = value;
			}
		}
		/// <summary>
		/// 数据来源编码
		/// </summary>
		public string DATASOURCECODE
		{
			get{ return _DATASOURCECODE; }
			set
			{
				this.OnPropertyValueChange(_.DATASOURCECODE, _DATASOURCECODE, value);
				this._DATASOURCECODE = value;
			}
		}
		/// <summary>
		/// 数据时间戳
		/// </summary>
		public DateTime? DATATIMESTAMP
		{
			get{ return _DATATIMESTAMP; }
			set
			{
				this.OnPropertyValueChange(_.DATATIMESTAMP, _DATATIMESTAMP, value);
				this._DATATIMESTAMP = value;
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
				_.ORGANNO,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ORGANNO,
				_.LEGALNAME,
				_.LICENSENO,
				_.LICENSEENDDATE,
				_.TAXCERTNO,
				_.LOCALTAXCERTNO,
				_.TAXCERTENDDATE,
				_.LOCALTAXCERTENDDATE,
				_.BEFOREORGANNO,
				_.ORGANCERTENDDATE,
				_.LEGALREPRESENT,
				_.LEGALTYPE,
				_.REPRESENTPHONE,
				_.LEGALINDUSTRY,
				_.CREDITRATE,
				_.COUNTRYREGION,
				_.LEGALADDRESS,
				_.REGIONCODE,
				_.BASICBANK,
				_.BASICBRANCHBANK,
				_.BASICACCOUNTNO,
				_.BASICACCOUNTNAME,
				_.BASICACCOUNTLICENSENO,
				_.REGCAPITAL,
				_.REGCAPCURRENCY,
				_.REGUNIT,
				_.LEGALCONTACT,
				_.LEGALCONTACTPHONE,
				_.LEGALWEB,
				_.LEGALZIPCODE,
				_.LEGALEMAIL,
				_.LEGALROLE,
				_.REGISTERDATE,
				_.REGISTERADDRESS,
				_.LEGALSTATUS,
				_.DATASOURCENAME,
				_.DATASOURCECODE,
				_.DATATIMESTAMP,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ORGANNO,
				this._LEGALNAME,
				this._LICENSENO,
				this._LICENSEENDDATE,
				this._TAXCERTNO,
				this._LOCALTAXCERTNO,
				this._TAXCERTENDDATE,
				this._LOCALTAXCERTENDDATE,
				this._BEFOREORGANNO,
				this._ORGANCERTENDDATE,
				this._LEGALREPRESENT,
				this._LEGALTYPE,
				this._REPRESENTPHONE,
				this._LEGALINDUSTRY,
				this._CREDITRATE,
				this._COUNTRYREGION,
				this._LEGALADDRESS,
				this._REGIONCODE,
				this._BASICBANK,
				this._BASICBRANCHBANK,
				this._BASICACCOUNTNO,
				this._BASICACCOUNTNAME,
				this._BASICACCOUNTLICENSENO,
				this._REGCAPITAL,
				this._REGCAPCURRENCY,
				this._REGUNIT,
				this._LEGALCONTACT,
				this._LEGALCONTACTPHONE,
				this._LEGALWEB,
				this._LEGALZIPCODE,
				this._LEGALEMAIL,
				this._LEGALROLE,
				this._REGISTERDATE,
				this._REGISTERADDRESS,
				this._LEGALSTATUS,
				this._DATASOURCENAME,
				this._DATASOURCECODE,
				this._DATATIMESTAMP,
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
			public readonly static Field All = new Field("*", "T_FR_BASE");
            /// <summary>
			/// 法人机构代码
			/// </summary>
			public readonly static Field ORGANNO = new Field("ORGANNO", "T_FR_BASE", "法人机构代码");
            /// <summary>
			/// 法人机构名称
			/// </summary>
			public readonly static Field LEGALNAME = new Field("LEGALNAME", "T_FR_BASE", "法人机构名称");
            /// <summary>
			/// 营业执照号码
			/// </summary>
			public readonly static Field LICENSENO = new Field("LICENSENO", "T_FR_BASE", "营业执照号码");
            /// <summary>
			/// 营业执照失效日期
			/// </summary>
			public readonly static Field LICENSEENDDATE = new Field("LICENSEENDDATE", "T_FR_BASE", "营业执照失效日期");
            /// <summary>
			/// 国税税务登记证证号
			/// </summary>
			public readonly static Field TAXCERTNO = new Field("TAXCERTNO", "T_FR_BASE", "国税税务登记证证号");
            /// <summary>
			/// 地税税务登记证证号
			/// </summary>
			public readonly static Field LOCALTAXCERTNO = new Field("LOCALTAXCERTNO", "T_FR_BASE", "地税税务登记证证号");
            /// <summary>
			/// 国税税务登记证失效日期
			/// </summary>
			public readonly static Field TAXCERTENDDATE = new Field("TAXCERTENDDATE", "T_FR_BASE", "国税税务登记证失效日期");
            /// <summary>
			/// 地税税务登记证失效日期
			/// </summary>
			public readonly static Field LOCALTAXCERTENDDATE = new Field("LOCALTAXCERTENDDATE", "T_FR_BASE", "地税税务登记证失效日期");
            /// <summary>
			/// 组织机构代码
			/// </summary>
			public readonly static Field BEFOREORGANNO = new Field("BEFOREORGANNO", "T_FR_BASE", "组织机构代码");
            /// <summary>
			/// 组织机构代码证失效日期
			/// </summary>
			public readonly static Field ORGANCERTENDDATE = new Field("ORGANCERTENDDATE", "T_FR_BASE", "组织机构代码证失效日期");
            /// <summary>
			/// 法定代表人姓名
			/// </summary>
			public readonly static Field LEGALREPRESENT = new Field("LEGALREPRESENT", "T_FR_BASE", "法定代表人姓名");
            /// <summary>
			/// 法人机构类别
			/// </summary>
			public readonly static Field LEGALTYPE = new Field("LEGALTYPE", "T_FR_BASE", "法人机构类别");
            /// <summary>
			/// 法人代表联系电话
			/// </summary>
			public readonly static Field REPRESENTPHONE = new Field("REPRESENTPHONE", "T_FR_BASE", "法人代表联系电话");
            /// <summary>
			/// 法人机构行业代码
			/// </summary>
			public readonly static Field LEGALINDUSTRY = new Field("LEGALINDUSTRY", "T_FR_BASE", "法人机构行业代码");
            /// <summary>
			/// 资信等级
			/// </summary>
			public readonly static Field CREDITRATE = new Field("CREDITRATE", "T_FR_BASE", "资信等级");
            /// <summary>
			/// 国别/地区
			/// </summary>
			public readonly static Field COUNTRYREGION = new Field("COUNTRYREGION", "T_FR_BASE", "国别/地区");
            /// <summary>
			/// 法人机构地址
			/// </summary>
			public readonly static Field LEGALADDRESS = new Field("LEGALADDRESS", "T_FR_BASE", "法人机构地址");
            /// <summary>
			/// 行政区域代码
			/// </summary>
			public readonly static Field REGIONCODE = new Field("REGIONCODE", "T_FR_BASE", "行政区域代码");
            /// <summary>
			/// 基本户开户银行
			/// </summary>
			public readonly static Field BASICBANK = new Field("BASICBANK", "T_FR_BASE", "基本户开户银行");
            /// <summary>
			/// 基本户开户支行号
			/// </summary>
			public readonly static Field BASICBRANCHBANK = new Field("BASICBRANCHBANK", "T_FR_BASE", "基本户开户支行号");
            /// <summary>
			/// 基本户账号
			/// </summary>
			public readonly static Field BASICACCOUNTNO = new Field("BASICACCOUNTNO", "T_FR_BASE", "基本户账号");
            /// <summary>
			/// 基本户账户名称
			/// </summary>
			public readonly static Field BASICACCOUNTNAME = new Field("BASICACCOUNTNAME", "T_FR_BASE", "基本户账户名称");
            /// <summary>
			/// 企业基本户开户许可证证号
			/// </summary>
			public readonly static Field BASICACCOUNTLICENSENO = new Field("BASICACCOUNTLICENSENO", "T_FR_BASE", "企业基本户开户许可证证号");
            /// <summary>
			/// 注册资本
			/// </summary>
			public readonly static Field REGCAPITAL = new Field("REGCAPITAL", "T_FR_BASE", "注册资本");
            /// <summary>
			/// 注册资本币种
			/// </summary>
			public readonly static Field REGCAPCURRENCY = new Field("REGCAPCURRENCY", "T_FR_BASE", "注册资本币种");
            /// <summary>
			/// 注册资本单位
			/// </summary>
			public readonly static Field REGUNIT = new Field("REGUNIT", "T_FR_BASE", "注册资本单位");
            /// <summary>
			/// 联系人
			/// </summary>
			public readonly static Field LEGALCONTACT = new Field("LEGALCONTACT", "T_FR_BASE", "联系人");
            /// <summary>
			/// 联系人电话
			/// </summary>
			public readonly static Field LEGALCONTACTPHONE = new Field("LEGALCONTACTPHONE", "T_FR_BASE", "联系人电话");
            /// <summary>
			/// 单位网站
			/// </summary>
			public readonly static Field LEGALWEB = new Field("LEGALWEB", "T_FR_BASE", "单位网站");
            /// <summary>
			/// 邮政编码
			/// </summary>
			public readonly static Field LEGALZIPCODE = new Field("LEGALZIPCODE", "T_FR_BASE", "邮政编码");
            /// <summary>
			/// 电子邮箱
			/// </summary>
			public readonly static Field LEGALEMAIL = new Field("LEGALEMAIL", "T_FR_BASE", "电子邮箱");
            /// <summary>
			/// 法人机构角色
			/// </summary>
			public readonly static Field LEGALROLE = new Field("LEGALROLE", "T_FR_BASE", "法人机构角色");
            /// <summary>
			/// 登记日期
			/// </summary>
			public readonly static Field REGISTERDATE = new Field("REGISTERDATE", "T_FR_BASE", "登记日期");
            /// <summary>
			/// 登记地点
			/// </summary>
			public readonly static Field REGISTERADDRESS = new Field("REGISTERADDRESS", "T_FR_BASE", "登记地点");
            /// <summary>
			/// 法人业务状态
			/// </summary>
			public readonly static Field LEGALSTATUS = new Field("LEGALSTATUS", "T_FR_BASE", "法人业务状态");
            /// <summary>
			/// 数据来源名称
			/// </summary>
			public readonly static Field DATASOURCENAME = new Field("DATASOURCENAME", "T_FR_BASE", "数据来源名称");
            /// <summary>
			/// 数据来源编码
			/// </summary>
			public readonly static Field DATASOURCECODE = new Field("DATASOURCECODE", "T_FR_BASE", "数据来源编码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATATIMESTAMP = new Field("DATATIMESTAMP", "T_FR_BASE", "数据时间戳");
        }
        #endregion
	}
}