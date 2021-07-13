using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_EC2_TENDERERINFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_EC2_TENDERERINFO")]
    [Serializable]
    public partial class T_EC2_TENDERERINFO : FwEntity
    {
        #region Model
		private string _TENDERERCODETYPE;
		private string _TENDERERCODE;
		private string _TENDERERNAME;
		private string _BIDSECTIONCODE;
		private string _ARTIFICIALPERSON;
		private string _ARTIFICIALPERSONCODETYPE;
		private string _ARTIFICIALPERSONCODE;
		private string _CONTACTNUMBER;
		private string _PARTICIPANTTYPE;
		private string _COUNTRYREGION;
		private string _UNITNATURE;
		private string _REGIONCODE;
		private string _INDUSTRYCODE;
		private string _LICNUMBER;
		private string _CACODE;
		private string _TAXNUMBER;
		private string _CREDITRATE;
		private string _OPENINGBANK;
		private string _BASICACCOUNT;
		private decimal? _REGCAPITAL;
		private string _REGCAPCURRENCY;
		private string _REGUNIT;
		private string _INFOREPORTERNAME;
		private string _INFOREPORTERCODETYPE;
		private string _INFOREPORTERCODE;
		private string _INFOREPORTERCONTACTNUMBER;
		private string _CONTACTADDRESS;
		private string _ZIPCODE;
		private string _EMAIL;
		private string _PLATFVERIFIER;
		private DateTime? _PLATFVERIFIERTIME;
		private DateTime? _VERIFYTIME;
		private string _PLATFORMCODE;
		private string _PLATFORMNAME;
		private string _EXAMINERNAME;
		private string _EXAMINERCODETYPE;
		private string _EXAMINERCODE;
		private string _ORGANIZATIONATTACHMENTCODE;
		private string _LICATTACHMENTCODE;
		private string _TAXATTACHMENTCODE;
		private DateTime? _VERSION;
		private string _DATA_SOURCE;
		private DateTime? _CREATE_TIME;

		/// <summary>
		/// 招标人代码类型
		/// </summary>
		public string TENDERERCODETYPE
		{
			get{ return _TENDERERCODETYPE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERERCODETYPE, _TENDERERCODETYPE, value);
				this._TENDERERCODETYPE = value;
			}
		}
		/// <summary>
		/// 招标人代码
		/// </summary>
		public string TENDERERCODE
		{
			get{ return _TENDERERCODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERERCODE, _TENDERERCODE, value);
				this._TENDERERCODE = value;
			}
		}
		/// <summary>
		/// 招标人名称
		/// </summary>
		public string TENDERERNAME
		{
			get{ return _TENDERERNAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDERERNAME, _TENDERERNAME, value);
				this._TENDERERNAME = value;
			}
		}
		/// <summary>
		/// 标段（包）编号
		/// </summary>
		public string BIDSECTIONCODE
		{
			get{ return _BIDSECTIONCODE; }
			set
			{
				this.OnPropertyValueChange(_.BIDSECTIONCODE, _BIDSECTIONCODE, value);
				this._BIDSECTIONCODE = value;
			}
		}
		/// <summary>
		/// 法人代表/负责人姓名
		/// </summary>
		public string ARTIFICIALPERSON
		{
			get{ return _ARTIFICIALPERSON; }
			set
			{
				this.OnPropertyValueChange(_.ARTIFICIALPERSON, _ARTIFICIALPERSON, value);
				this._ARTIFICIALPERSON = value;
			}
		}
		/// <summary>
		/// 法人代表/负责人证件类型
		/// </summary>
		public string ARTIFICIALPERSONCODETYPE
		{
			get{ return _ARTIFICIALPERSONCODETYPE; }
			set
			{
				this.OnPropertyValueChange(_.ARTIFICIALPERSONCODETYPE, _ARTIFICIALPERSONCODETYPE, value);
				this._ARTIFICIALPERSONCODETYPE = value;
			}
		}
		/// <summary>
		/// 法人代表/负责人身份证件号
		/// </summary>
		public string ARTIFICIALPERSONCODE
		{
			get{ return _ARTIFICIALPERSONCODE; }
			set
			{
				this.OnPropertyValueChange(_.ARTIFICIALPERSONCODE, _ARTIFICIALPERSONCODE, value);
				this._ARTIFICIALPERSONCODE = value;
			}
		}
		/// <summary>
		/// 机构联系电话
		/// </summary>
		public string CONTACTNUMBER
		{
			get{ return _CONTACTNUMBER; }
			set
			{
				this.OnPropertyValueChange(_.CONTACTNUMBER, _CONTACTNUMBER, value);
				this._CONTACTNUMBER = value;
			}
		}
		/// <summary>
		/// 招投标交易主体类型
		/// </summary>
		public string PARTICIPANTTYPE
		{
			get{ return _PARTICIPANTTYPE; }
			set
			{
				this.OnPropertyValueChange(_.PARTICIPANTTYPE, _PARTICIPANTTYPE, value);
				this._PARTICIPANTTYPE = value;
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
		/// 单位性质
		/// </summary>
		public string UNITNATURE
		{
			get{ return _UNITNATURE; }
			set
			{
				this.OnPropertyValueChange(_.UNITNATURE, _UNITNATURE, value);
				this._UNITNATURE = value;
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
		/// 行业代码
		/// </summary>
		public string INDUSTRYCODE
		{
			get{ return _INDUSTRYCODE; }
			set
			{
				this.OnPropertyValueChange(_.INDUSTRYCODE, _INDUSTRYCODE, value);
				this._INDUSTRYCODE = value;
			}
		}
		/// <summary>
		/// 营业执照号码
		/// </summary>
		public string LICNUMBER
		{
			get{ return _LICNUMBER; }
			set
			{
				this.OnPropertyValueChange(_.LICNUMBER, _LICNUMBER, value);
				this._LICNUMBER = value;
			}
		}
		/// <summary>
		/// CA证书编号
		/// </summary>
		public string CACODE
		{
			get{ return _CACODE; }
			set
			{
				this.OnPropertyValueChange(_.CACODE, _CACODE, value);
				this._CACODE = value;
			}
		}
		/// <summary>
		/// 税务登记号
		/// </summary>
		public string TAXNUMBER
		{
			get{ return _TAXNUMBER; }
			set
			{
				this.OnPropertyValueChange(_.TAXNUMBER, _TAXNUMBER, value);
				this._TAXNUMBER = value;
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
		/// 开户银行
		/// </summary>
		public string OPENINGBANK
		{
			get{ return _OPENINGBANK; }
			set
			{
				this.OnPropertyValueChange(_.OPENINGBANK, _OPENINGBANK, value);
				this._OPENINGBANK = value;
			}
		}
		/// <summary>
		/// 基本账户账号
		/// </summary>
		public string BASICACCOUNT
		{
			get{ return _BASICACCOUNT; }
			set
			{
				this.OnPropertyValueChange(_.BASICACCOUNT, _BASICACCOUNT, value);
				this._BASICACCOUNT = value;
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
		/// 信息申报责任人姓名
		/// </summary>
		public string INFOREPORTERNAME
		{
			get{ return _INFOREPORTERNAME; }
			set
			{
				this.OnPropertyValueChange(_.INFOREPORTERNAME, _INFOREPORTERNAME, value);
				this._INFOREPORTERNAME = value;
			}
		}
		/// <summary>
		/// 信息申报责任人证件类型
		/// </summary>
		public string INFOREPORTERCODETYPE
		{
			get{ return _INFOREPORTERCODETYPE; }
			set
			{
				this.OnPropertyValueChange(_.INFOREPORTERCODETYPE, _INFOREPORTERCODETYPE, value);
				this._INFOREPORTERCODETYPE = value;
			}
		}
		/// <summary>
		/// 信息申报责任人证件号码
		/// </summary>
		public string INFOREPORTERCODE
		{
			get{ return _INFOREPORTERCODE; }
			set
			{
				this.OnPropertyValueChange(_.INFOREPORTERCODE, _INFOREPORTERCODE, value);
				this._INFOREPORTERCODE = value;
			}
		}
		/// <summary>
		/// 信息申报责任人联系电话
		/// </summary>
		public string INFOREPORTERCONTACTNUMBER
		{
			get{ return _INFOREPORTERCONTACTNUMBER; }
			set
			{
				this.OnPropertyValueChange(_.INFOREPORTERCONTACTNUMBER, _INFOREPORTERCONTACTNUMBER, value);
				this._INFOREPORTERCONTACTNUMBER = value;
			}
		}
		/// <summary>
		/// 联系地址
		/// </summary>
		public string CONTACTADDRESS
		{
			get{ return _CONTACTADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.CONTACTADDRESS, _CONTACTADDRESS, value);
				this._CONTACTADDRESS = value;
			}
		}
		/// <summary>
		/// 邮政编码
		/// </summary>
		public string ZIPCODE
		{
			get{ return _ZIPCODE; }
			set
			{
				this.OnPropertyValueChange(_.ZIPCODE, _ZIPCODE, value);
				this._ZIPCODE = value;
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
		/// 交易平台验证人员
		/// </summary>
		public string PLATFVERIFIER
		{
			get{ return _PLATFVERIFIER; }
			set
			{
				this.OnPropertyValueChange(_.PLATFVERIFIER, _PLATFVERIFIER, value);
				this._PLATFVERIFIER = value;
			}
		}
		/// <summary>
		/// 交易平台验证时间
		/// </summary>
		public DateTime? PLATFVERIFIERTIME
		{
			get{ return _PLATFVERIFIERTIME; }
			set
			{
				this.OnPropertyValueChange(_.PLATFVERIFIERTIME, _PLATFVERIFIERTIME, value);
				this._PLATFVERIFIERTIME = value;
			}
		}
		/// <summary>
		/// 交易平台数据验证时间
		/// </summary>
		public DateTime? VERIFYTIME
		{
			get{ return _VERIFYTIME; }
			set
			{
				this.OnPropertyValueChange(_.VERIFYTIME, _VERIFYTIME, value);
				this._VERIFYTIME = value;
			}
		}
		/// <summary>
		/// 交易平台标识码
		/// </summary>
		public string PLATFORMCODE
		{
			get{ return _PLATFORMCODE; }
			set
			{
				this.OnPropertyValueChange(_.PLATFORMCODE, _PLATFORMCODE, value);
				this._PLATFORMCODE = value;
			}
		}
		/// <summary>
		/// 交易平台名称
		/// </summary>
		public string PLATFORMNAME
		{
			get{ return _PLATFORMNAME; }
			set
			{
				this.OnPropertyValueChange(_.PLATFORMNAME, _PLATFORMNAME, value);
				this._PLATFORMNAME = value;
			}
		}
		/// <summary>
		/// 交易平台数据验证责任人姓名
		/// </summary>
		public string EXAMINERNAME
		{
			get{ return _EXAMINERNAME; }
			set
			{
				this.OnPropertyValueChange(_.EXAMINERNAME, _EXAMINERNAME, value);
				this._EXAMINERNAME = value;
			}
		}
		/// <summary>
		/// 交易平台数据验证责任人证件类型
		/// </summary>
		public string EXAMINERCODETYPE
		{
			get{ return _EXAMINERCODETYPE; }
			set
			{
				this.OnPropertyValueChange(_.EXAMINERCODETYPE, _EXAMINERCODETYPE, value);
				this._EXAMINERCODETYPE = value;
			}
		}
		/// <summary>
		/// 交易平台数据验证责任人证件号码
		/// </summary>
		public string EXAMINERCODE
		{
			get{ return _EXAMINERCODE; }
			set
			{
				this.OnPropertyValueChange(_.EXAMINERCODE, _EXAMINERCODE, value);
				this._EXAMINERCODE = value;
			}
		}
		/// <summary>
		/// 组织机构证书附件
		/// </summary>
		public string ORGANIZATIONATTACHMENTCODE
		{
			get{ return _ORGANIZATIONATTACHMENTCODE; }
			set
			{
				this.OnPropertyValueChange(_.ORGANIZATIONATTACHMENTCODE, _ORGANIZATIONATTACHMENTCODE, value);
				this._ORGANIZATIONATTACHMENTCODE = value;
			}
		}
		/// <summary>
		/// 营业执照附件
		/// </summary>
		public string LICATTACHMENTCODE
		{
			get{ return _LICATTACHMENTCODE; }
			set
			{
				this.OnPropertyValueChange(_.LICATTACHMENTCODE, _LICATTACHMENTCODE, value);
				this._LICATTACHMENTCODE = value;
			}
		}
		/// <summary>
		/// 税务登记附件
		/// </summary>
		public string TAXATTACHMENTCODE
		{
			get{ return _TAXATTACHMENTCODE; }
			set
			{
				this.OnPropertyValueChange(_.TAXATTACHMENTCODE, _TAXATTACHMENTCODE, value);
				this._TAXATTACHMENTCODE = value;
			}
		}
		/// <summary>
		/// 版本号
		/// </summary>
		public DateTime? VERSION
		{
			get{ return _VERSION; }
			set
			{
				this.OnPropertyValueChange(_.VERSION, _VERSION, value);
				this._VERSION = value;
			}
		}
		/// <summary>
		/// 数据源
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
		/// 数据时间
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
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.TENDERERCODE,
				_.BIDSECTIONCODE,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.TENDERERCODETYPE,
				_.TENDERERCODE,
				_.TENDERERNAME,
				_.BIDSECTIONCODE,
				_.ARTIFICIALPERSON,
				_.ARTIFICIALPERSONCODETYPE,
				_.ARTIFICIALPERSONCODE,
				_.CONTACTNUMBER,
				_.PARTICIPANTTYPE,
				_.COUNTRYREGION,
				_.UNITNATURE,
				_.REGIONCODE,
				_.INDUSTRYCODE,
				_.LICNUMBER,
				_.CACODE,
				_.TAXNUMBER,
				_.CREDITRATE,
				_.OPENINGBANK,
				_.BASICACCOUNT,
				_.REGCAPITAL,
				_.REGCAPCURRENCY,
				_.REGUNIT,
				_.INFOREPORTERNAME,
				_.INFOREPORTERCODETYPE,
				_.INFOREPORTERCODE,
				_.INFOREPORTERCONTACTNUMBER,
				_.CONTACTADDRESS,
				_.ZIPCODE,
				_.EMAIL,
				_.PLATFVERIFIER,
				_.PLATFVERIFIERTIME,
				_.VERIFYTIME,
				_.PLATFORMCODE,
				_.PLATFORMNAME,
				_.EXAMINERNAME,
				_.EXAMINERCODETYPE,
				_.EXAMINERCODE,
				_.ORGANIZATIONATTACHMENTCODE,
				_.LICATTACHMENTCODE,
				_.TAXATTACHMENTCODE,
				_.VERSION,
				_.DATA_SOURCE,
				_.CREATE_TIME,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._TENDERERCODETYPE,
				this._TENDERERCODE,
				this._TENDERERNAME,
				this._BIDSECTIONCODE,
				this._ARTIFICIALPERSON,
				this._ARTIFICIALPERSONCODETYPE,
				this._ARTIFICIALPERSONCODE,
				this._CONTACTNUMBER,
				this._PARTICIPANTTYPE,
				this._COUNTRYREGION,
				this._UNITNATURE,
				this._REGIONCODE,
				this._INDUSTRYCODE,
				this._LICNUMBER,
				this._CACODE,
				this._TAXNUMBER,
				this._CREDITRATE,
				this._OPENINGBANK,
				this._BASICACCOUNT,
				this._REGCAPITAL,
				this._REGCAPCURRENCY,
				this._REGUNIT,
				this._INFOREPORTERNAME,
				this._INFOREPORTERCODETYPE,
				this._INFOREPORTERCODE,
				this._INFOREPORTERCONTACTNUMBER,
				this._CONTACTADDRESS,
				this._ZIPCODE,
				this._EMAIL,
				this._PLATFVERIFIER,
				this._PLATFVERIFIERTIME,
				this._VERIFYTIME,
				this._PLATFORMCODE,
				this._PLATFORMNAME,
				this._EXAMINERNAME,
				this._EXAMINERCODETYPE,
				this._EXAMINERCODE,
				this._ORGANIZATIONATTACHMENTCODE,
				this._LICATTACHMENTCODE,
				this._TAXATTACHMENTCODE,
				this._VERSION,
				this._DATA_SOURCE,
				this._CREATE_TIME,
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
			public readonly static Field All = new Field("*", "T_EC2_TENDERERINFO");
            /// <summary>
			/// 招标人代码类型
			/// </summary>
			public readonly static Field TENDERERCODETYPE = new Field("TENDERERCODETYPE", "T_EC2_TENDERERINFO", "招标人代码类型");
            /// <summary>
			/// 招标人代码
			/// </summary>
			public readonly static Field TENDERERCODE = new Field("TENDERERCODE", "T_EC2_TENDERERINFO", "招标人代码");
            /// <summary>
			/// 招标人名称
			/// </summary>
			public readonly static Field TENDERERNAME = new Field("TENDERERNAME", "T_EC2_TENDERERINFO", "招标人名称");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BIDSECTIONCODE = new Field("BIDSECTIONCODE", "T_EC2_TENDERERINFO", "标段（包）编号");
            /// <summary>
			/// 法人代表/负责人姓名
			/// </summary>
			public readonly static Field ARTIFICIALPERSON = new Field("ARTIFICIALPERSON", "T_EC2_TENDERERINFO", "法人代表/负责人姓名");
            /// <summary>
			/// 法人代表/负责人证件类型
			/// </summary>
			public readonly static Field ARTIFICIALPERSONCODETYPE = new Field("ARTIFICIALPERSONCODETYPE", "T_EC2_TENDERERINFO", "法人代表/负责人证件类型");
            /// <summary>
			/// 法人代表/负责人身份证件号
			/// </summary>
			public readonly static Field ARTIFICIALPERSONCODE = new Field("ARTIFICIALPERSONCODE", "T_EC2_TENDERERINFO", "法人代表/负责人身份证件号");
            /// <summary>
			/// 机构联系电话
			/// </summary>
			public readonly static Field CONTACTNUMBER = new Field("CONTACTNUMBER", "T_EC2_TENDERERINFO", "机构联系电话");
            /// <summary>
			/// 招投标交易主体类型
			/// </summary>
			public readonly static Field PARTICIPANTTYPE = new Field("PARTICIPANTTYPE", "T_EC2_TENDERERINFO", "招投标交易主体类型");
            /// <summary>
			/// 国别/地区
			/// </summary>
			public readonly static Field COUNTRYREGION = new Field("COUNTRYREGION", "T_EC2_TENDERERINFO", "国别/地区");
            /// <summary>
			/// 单位性质
			/// </summary>
			public readonly static Field UNITNATURE = new Field("UNITNATURE", "T_EC2_TENDERERINFO", "单位性质");
            /// <summary>
			/// 行政区域代码
			/// </summary>
			public readonly static Field REGIONCODE = new Field("REGIONCODE", "T_EC2_TENDERERINFO", "行政区域代码");
            /// <summary>
			/// 行业代码
			/// </summary>
			public readonly static Field INDUSTRYCODE = new Field("INDUSTRYCODE", "T_EC2_TENDERERINFO", "行业代码");
            /// <summary>
			/// 营业执照号码
			/// </summary>
			public readonly static Field LICNUMBER = new Field("LICNUMBER", "T_EC2_TENDERERINFO", "营业执照号码");
            /// <summary>
			/// CA证书编号
			/// </summary>
			public readonly static Field CACODE = new Field("CACODE", "T_EC2_TENDERERINFO", "CA证书编号");
            /// <summary>
			/// 税务登记号
			/// </summary>
			public readonly static Field TAXNUMBER = new Field("TAXNUMBER", "T_EC2_TENDERERINFO", "税务登记号");
            /// <summary>
			/// 资信等级
			/// </summary>
			public readonly static Field CREDITRATE = new Field("CREDITRATE", "T_EC2_TENDERERINFO", "资信等级");
            /// <summary>
			/// 开户银行
			/// </summary>
			public readonly static Field OPENINGBANK = new Field("OPENINGBANK", "T_EC2_TENDERERINFO", "开户银行");
            /// <summary>
			/// 基本账户账号
			/// </summary>
			public readonly static Field BASICACCOUNT = new Field("BASICACCOUNT", "T_EC2_TENDERERINFO", "基本账户账号");
            /// <summary>
			/// 注册资本
			/// </summary>
			public readonly static Field REGCAPITAL = new Field("REGCAPITAL", "T_EC2_TENDERERINFO", "注册资本");
            /// <summary>
			/// 注册资本币种
			/// </summary>
			public readonly static Field REGCAPCURRENCY = new Field("REGCAPCURRENCY", "T_EC2_TENDERERINFO", "注册资本币种");
            /// <summary>
			/// 注册资本单位
			/// </summary>
			public readonly static Field REGUNIT = new Field("REGUNIT", "T_EC2_TENDERERINFO", "注册资本单位");
            /// <summary>
			/// 信息申报责任人姓名
			/// </summary>
			public readonly static Field INFOREPORTERNAME = new Field("INFOREPORTERNAME", "T_EC2_TENDERERINFO", "信息申报责任人姓名");
            /// <summary>
			/// 信息申报责任人证件类型
			/// </summary>
			public readonly static Field INFOREPORTERCODETYPE = new Field("INFOREPORTERCODETYPE", "T_EC2_TENDERERINFO", "信息申报责任人证件类型");
            /// <summary>
			/// 信息申报责任人证件号码
			/// </summary>
			public readonly static Field INFOREPORTERCODE = new Field("INFOREPORTERCODE", "T_EC2_TENDERERINFO", "信息申报责任人证件号码");
            /// <summary>
			/// 信息申报责任人联系电话
			/// </summary>
			public readonly static Field INFOREPORTERCONTACTNUMBER = new Field("INFOREPORTERCONTACTNUMBER", "T_EC2_TENDERERINFO", "信息申报责任人联系电话");
            /// <summary>
			/// 联系地址
			/// </summary>
			public readonly static Field CONTACTADDRESS = new Field("CONTACTADDRESS", "T_EC2_TENDERERINFO", "联系地址");
            /// <summary>
			/// 邮政编码
			/// </summary>
			public readonly static Field ZIPCODE = new Field("ZIPCODE", "T_EC2_TENDERERINFO", "邮政编码");
            /// <summary>
			/// 电子邮箱
			/// </summary>
			public readonly static Field EMAIL = new Field("EMAIL", "T_EC2_TENDERERINFO", "电子邮箱");
            /// <summary>
			/// 交易平台验证人员
			/// </summary>
			public readonly static Field PLATFVERIFIER = new Field("PLATFVERIFIER", "T_EC2_TENDERERINFO", "交易平台验证人员");
            /// <summary>
			/// 交易平台验证时间
			/// </summary>
			public readonly static Field PLATFVERIFIERTIME = new Field("PLATFVERIFIERTIME", "T_EC2_TENDERERINFO", "交易平台验证时间");
            /// <summary>
			/// 交易平台数据验证时间
			/// </summary>
			public readonly static Field VERIFYTIME = new Field("VERIFYTIME", "T_EC2_TENDERERINFO", "交易平台数据验证时间");
            /// <summary>
			/// 交易平台标识码
			/// </summary>
			public readonly static Field PLATFORMCODE = new Field("PLATFORMCODE", "T_EC2_TENDERERINFO", "交易平台标识码");
            /// <summary>
			/// 交易平台名称
			/// </summary>
			public readonly static Field PLATFORMNAME = new Field("PLATFORMNAME", "T_EC2_TENDERERINFO", "交易平台名称");
            /// <summary>
			/// 交易平台数据验证责任人姓名
			/// </summary>
			public readonly static Field EXAMINERNAME = new Field("EXAMINERNAME", "T_EC2_TENDERERINFO", "交易平台数据验证责任人姓名");
            /// <summary>
			/// 交易平台数据验证责任人证件类型
			/// </summary>
			public readonly static Field EXAMINERCODETYPE = new Field("EXAMINERCODETYPE", "T_EC2_TENDERERINFO", "交易平台数据验证责任人证件类型");
            /// <summary>
			/// 交易平台数据验证责任人证件号码
			/// </summary>
			public readonly static Field EXAMINERCODE = new Field("EXAMINERCODE", "T_EC2_TENDERERINFO", "交易平台数据验证责任人证件号码");
            /// <summary>
			/// 组织机构证书附件
			/// </summary>
			public readonly static Field ORGANIZATIONATTACHMENTCODE = new Field("ORGANIZATIONATTACHMENTCODE", "T_EC2_TENDERERINFO",DbType.AnsiString, null, "组织机构证书附件");
            /// <summary>
			/// 营业执照附件
			/// </summary>
			public readonly static Field LICATTACHMENTCODE = new Field("LICATTACHMENTCODE", "T_EC2_TENDERERINFO",DbType.AnsiString, null, "营业执照附件");
            /// <summary>
			/// 税务登记附件
			/// </summary>
			public readonly static Field TAXATTACHMENTCODE = new Field("TAXATTACHMENTCODE", "T_EC2_TENDERERINFO",DbType.AnsiString, null, "税务登记附件");
            /// <summary>
			/// 版本号
			/// </summary>
			public readonly static Field VERSION = new Field("VERSION", "T_EC2_TENDERERINFO", "版本号");
            /// <summary>
			/// 数据源
			/// </summary>
			public readonly static Field DATA_SOURCE = new Field("DATA_SOURCE", "T_EC2_TENDERERINFO", "数据源");
            /// <summary>
			/// 数据时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "T_EC2_TENDERERINFO", "数据时间");
        }
        #endregion
	}
}