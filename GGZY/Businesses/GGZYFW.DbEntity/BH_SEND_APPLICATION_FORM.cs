using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
	/// <summary>
	/// 实体类BH_SEND_APPLICATION_FORM。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("BH_SEND_APPLICATION_FORM")]
	[Serializable]
	public partial class BH_SEND_APPLICATION_FORM : Entity
	{
		#region Model
		private int _M_ID;
		private string _M_DATA_KEY;
		private string _ORDER_ID;
		private string _APPROVAL_CODE;
		private string _TENDER_PROJECT_CODE;
		private string _TENDER_PROJECT_NAME;
		private string _SECTION_CODE;
		private string _SECTION_NAME;
		private decimal _CONTRACT_RECKON_PRICE;
		private string _TENDERER;
		private string _TENDERER_CREDIT_CODE;
		private string _TENDERER_BANK_CODE;
		private string _TENDERER_BANK_OPENBANK;
		private string _CITY_CODE;
		private string _TENDER_PROJECT_TYPE;
		private DateTime? _BID_OPEN_TIME;
		private DateTime? _SERVICE_BEGIN_TIME;
		private DateTime? _SERVICE_END_TIME;
		private decimal _BID_BOND;
		private string _GUARANTOR_NAME;
		private string _GUARANTOR_CREDIT_CODE;
		private string _GUARANTOR_CONTACT_NAME;
		private string _GUARANTOR_CONTACT_TEL;
		private string _BIDDER_NAME;
		private string _BIDDER_CREDIT_CODE;
		private string _BIDDER_CONTACT_NAME;
		private string _BIDDER_CONTACT_TEL;
		private string _BIDDER_ADDRESS;
		private string _BIDDER_TAXPAYER_CODE;
		private string _LEGAL_PERSON_NAME;
		private string _LEGAL_PERSON_TEL;
		private string _ORDER_URL;
		private string _TENDER_FILE_URL;
		private string _QUALFICATION_FILE_URL;
		private string _SECRET;
		private string _BUSINESS_LICENSE_URL;
		private string _BIDDER_EAMIL;
		private string _LEGAL_PERSON_IDCARD;
		private string _ORDER_MD5;
		private string _TENDER_FILE_MD5;
		private string _QUALFICATION_FILE_MD5;
		private string _BUSINESS_LICENSE_MD5;
		private string _RECEIVE_URL;
		private decimal? _USER_ID;
		private string _STATUS;
		private string _SYSTEM_NO;
		private DateTime? _CREATE_TIME;
		private string _SIGN_GUID;
		private string _ORDER_AIDS;
		private string _TENDER_FILE_AIDS;
		private string _QUALFICATION_FILE_AIDS;
		private string _BUSINESS_LICENSE_AIDS;
		private string _STATUS_REMARK;
		private string _LEGAL_PERSON_IDCARD_TYPE;
		private string _TENDERER_BANK_ACCOUNT;
		private string _TENDERER_CONTACT;
		private string _TENDERER_CONTACT_TEL;
		private string _INVEST_PROJECT_CODE;
		private decimal _VALID_PERIOD;
		private string _BIDDER_CONTACT_IDCARD;
		private string _BIDDER_CONTACT_IDCARD_TYPE;

		/// <summary>
		/// 自增长ID
		/// </summary>
		public int M_ID
		{
			get { return _M_ID; }
			set
			{
				this.OnPropertyValueChange(_.M_ID, _M_ID, value);
				this._M_ID = value;
			}
		}
		/// <summary>
		/// 数据唯一识别
		/// </summary>
		public string M_DATA_KEY
		{
			get { return _M_DATA_KEY; }
			set
			{
				this.OnPropertyValueChange(_.M_DATA_KEY, _M_DATA_KEY, value);
				this._M_DATA_KEY = value;
			}
		}
		/// <summary>
		/// 订单号(唯一)
		/// </summary>
		public string ORDER_ID
		{
			get { return _ORDER_ID; }
			set
			{
				this.OnPropertyValueChange(_.ORDER_ID, _ORDER_ID, value);
				this._ORDER_ID = value;
			}
		}
		/// <summary>
		/// 立项批文号
		/// </summary>
		public string APPROVAL_CODE
		{
			get { return _APPROVAL_CODE; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_CODE, _APPROVAL_CODE, value);
				this._APPROVAL_CODE = value;
			}
		}
		/// <summary>
		/// 招标项目编号
		/// </summary>
		public string TENDER_PROJECT_CODE
		{
			get { return _TENDER_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_CODE, _TENDER_PROJECT_CODE, value);
				this._TENDER_PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 招标项目名称
		/// </summary>
		public string TENDER_PROJECT_NAME
		{
			get { return _TENDER_PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_NAME, _TENDER_PROJECT_NAME, value);
				this._TENDER_PROJECT_NAME = value;
			}
		}
		/// <summary>
		/// 标段编号
		/// </summary>
		public string SECTION_CODE
		{
			get { return _SECTION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.SECTION_CODE, _SECTION_CODE, value);
				this._SECTION_CODE = value;
			}
		}
		/// <summary>
		/// 标段名称
		/// </summary>
		public string SECTION_NAME
		{
			get { return _SECTION_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SECTION_NAME, _SECTION_NAME, value);
				this._SECTION_NAME = value;
			}
		}
		/// <summary>
		/// 合同估算价
		/// </summary>
		public decimal CONTRACT_RECKON_PRICE
		{
			get { return _CONTRACT_RECKON_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_RECKON_PRICE, _CONTRACT_RECKON_PRICE, value);
				this._CONTRACT_RECKON_PRICE = value;
			}
		}
		/// <summary>
		/// 招标人
		/// </summary>
		public string TENDERER
		{
			get { return _TENDERER; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER, _TENDERER, value);
				this._TENDERER = value;
			}
		}
		/// <summary>
		/// 招标人统一社会信用代码
		/// </summary>
		public string TENDERER_CREDIT_CODE
		{
			get { return _TENDERER_CREDIT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_CREDIT_CODE, _TENDERER_CREDIT_CODE, value);
				this._TENDERER_CREDIT_CODE = value;
			}
		}
		/// <summary>
		/// 招标人银行账号
		/// </summary>
		public string TENDERER_BANK_CODE
		{
			get { return _TENDERER_BANK_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_BANK_CODE, _TENDERER_BANK_CODE, value);
				this._TENDERER_BANK_CODE = value;
			}
		}
		/// <summary>
		/// 招标人银行开户行
		/// </summary>
		public string TENDERER_BANK_OPENBANK
		{
			get { return _TENDERER_BANK_OPENBANK; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_BANK_OPENBANK, _TENDERER_BANK_OPENBANK, value);
				this._TENDERER_BANK_OPENBANK = value;
			}
		}
		/// <summary>
		/// 项目所在地(行政区划代码)
		/// </summary>
		public string CITY_CODE
		{
			get { return _CITY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CITY_CODE, _CITY_CODE, value);
				this._CITY_CODE = value;
			}
		}
		/// <summary>
		/// 招标项目类别（字典5.1）
		/// </summary>
		public string TENDER_PROJECT_TYPE
		{
			get { return _TENDER_PROJECT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_TYPE, _TENDER_PROJECT_TYPE, value);
				this._TENDER_PROJECT_TYPE = value;
			}
		}
		/// <summary>
		/// 开标时间（YYYYMMDDHHMMSS）
		/// </summary>
		public DateTime? BID_OPEN_TIME
		{
			get { return _BID_OPEN_TIME; }
			set
			{
				this.OnPropertyValueChange(_.BID_OPEN_TIME, _BID_OPEN_TIME, value);
				this._BID_OPEN_TIME = value;
			}
		}
		/// <summary>
		/// 保函开始日期(默认为开标日期)
		/// </summary>
		public DateTime? SERVICE_BEGIN_TIME
		{
			get { return _SERVICE_BEGIN_TIME; }
			set
			{
				this.OnPropertyValueChange(_.SERVICE_BEGIN_TIME, _SERVICE_BEGIN_TIME, value);
				this._SERVICE_BEGIN_TIME = value;
			}
		}
		/// <summary>
		/// 保函截止日期(默认为开标日期后顺延28日历天)
		/// </summary>
		public DateTime? SERVICE_END_TIME
		{
			get { return _SERVICE_END_TIME; }
			set
			{
				this.OnPropertyValueChange(_.SERVICE_END_TIME, _SERVICE_END_TIME, value);
				this._SERVICE_END_TIME = value;
			}
		}
		/// <summary>
		/// 担保额度（保证金要求数额）（元）
		/// </summary>
		public decimal BID_BOND
		{
			get { return _BID_BOND; }
			set
			{
				this.OnPropertyValueChange(_.BID_BOND, _BID_BOND, value);
				this._BID_BOND = value;
			}
		}
		/// <summary>
		/// 承保人名称
		/// </summary>
		public string GUARANTOR_NAME
		{
			get { return _GUARANTOR_NAME; }
			set
			{
				this.OnPropertyValueChange(_.GUARANTOR_NAME, _GUARANTOR_NAME, value);
				this._GUARANTOR_NAME = value;
			}
		}
		/// <summary>
		/// 承保人统一社会信用代码证号
		/// </summary>
		public string GUARANTOR_CREDIT_CODE
		{
			get { return _GUARANTOR_CREDIT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.GUARANTOR_CREDIT_CODE, _GUARANTOR_CREDIT_CODE, value);
				this._GUARANTOR_CREDIT_CODE = value;
			}
		}
		/// <summary>
		/// 承保人联系人
		/// </summary>
		public string GUARANTOR_CONTACT_NAME
		{
			get { return _GUARANTOR_CONTACT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.GUARANTOR_CONTACT_NAME, _GUARANTOR_CONTACT_NAME, value);
				this._GUARANTOR_CONTACT_NAME = value;
			}
		}
		/// <summary>
		/// 承保人联系电话
		/// </summary>
		public string GUARANTOR_CONTACT_TEL
		{
			get { return _GUARANTOR_CONTACT_TEL; }
			set
			{
				this.OnPropertyValueChange(_.GUARANTOR_CONTACT_TEL, _GUARANTOR_CONTACT_TEL, value);
				this._GUARANTOR_CONTACT_TEL = value;
			}
		}
		/// <summary>
		/// 投标人名称
		/// </summary>
		public string BIDDER_NAME
		{
			get { return _BIDDER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_NAME, _BIDDER_NAME, value);
				this._BIDDER_NAME = value;
			}
		}
		/// <summary>
		/// 投标人统一社会信用代码证号
		/// </summary>
		public string BIDDER_CREDIT_CODE
		{
			get { return _BIDDER_CREDIT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_CREDIT_CODE, _BIDDER_CREDIT_CODE, value);
				this._BIDDER_CREDIT_CODE = value;
			}
		}
		/// <summary>
		/// 投标人联系人
		/// </summary>
		public string BIDDER_CONTACT_NAME
		{
			get { return _BIDDER_CONTACT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_CONTACT_NAME, _BIDDER_CONTACT_NAME, value);
				this._BIDDER_CONTACT_NAME = value;
			}
		}
		/// <summary>
		/// 投标人联系电话
		/// </summary>
		public string BIDDER_CONTACT_TEL
		{
			get { return _BIDDER_CONTACT_TEL; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_CONTACT_TEL, _BIDDER_CONTACT_TEL, value);
				this._BIDDER_CONTACT_TEL = value;
			}
		}
		/// <summary>
		/// 投标人地址
		/// </summary>
		public string BIDDER_ADDRESS
		{
			get { return _BIDDER_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_ADDRESS, _BIDDER_ADDRESS, value);
				this._BIDDER_ADDRESS = value;
			}
		}
		/// <summary>
		/// 投标人纳税人识别号
		/// </summary>
		public string BIDDER_TAXPAYER_CODE
		{
			get { return _BIDDER_TAXPAYER_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_TAXPAYER_CODE, _BIDDER_TAXPAYER_CODE, value);
				this._BIDDER_TAXPAYER_CODE = value;
			}
		}
		/// <summary>
		/// 投标人法人姓名
		/// </summary>
		public string LEGAL_PERSON_NAME
		{
			get { return _LEGAL_PERSON_NAME; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_PERSON_NAME, _LEGAL_PERSON_NAME, value);
				this._LEGAL_PERSON_NAME = value;
			}
		}
		/// <summary>
		/// 投标人法人联系方式
		/// </summary>
		public string LEGAL_PERSON_TEL
		{
			get { return _LEGAL_PERSON_TEL; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_PERSON_TEL, _LEGAL_PERSON_TEL, value);
				this._LEGAL_PERSON_TEL = value;
			}
		}
		/// <summary>
		/// 电子申请单文件下载地址
		/// </summary>
		public string ORDER_URL
		{
			get { return _ORDER_URL; }
			set
			{
				this.OnPropertyValueChange(_.ORDER_URL, _ORDER_URL, value);
				this._ORDER_URL = value;
			}
		}
		/// <summary>
		/// 招标文件下载地址
		/// </summary>
		public string TENDER_FILE_URL
		{
			get { return _TENDER_FILE_URL; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_FILE_URL, _TENDER_FILE_URL, value);
				this._TENDER_FILE_URL = value;
			}
		}
		/// <summary>
		/// 企业资质文件下载地址
		/// </summary>
		public string QUALFICATION_FILE_URL
		{
			get { return _QUALFICATION_FILE_URL; }
			set
			{
				this.OnPropertyValueChange(_.QUALFICATION_FILE_URL, _QUALFICATION_FILE_URL, value);
				this._QUALFICATION_FILE_URL = value;
			}
		}
		/// <summary>
		/// 数字信封
		/// </summary>
		public string SECRET
		{
			get { return _SECRET; }
			set
			{
				this.OnPropertyValueChange(_.SECRET, _SECRET, value);
				this._SECRET = value;
			}
		}
		/// <summary>
		/// 企业营业执照下载地址
		/// </summary>
		public string BUSINESS_LICENSE_URL
		{
			get { return _BUSINESS_LICENSE_URL; }
			set
			{
				this.OnPropertyValueChange(_.BUSINESS_LICENSE_URL, _BUSINESS_LICENSE_URL, value);
				this._BUSINESS_LICENSE_URL = value;
			}
		}
		/// <summary>
		/// 投保人邮箱
		/// </summary>
		public string BIDDER_EAMIL
		{
			get { return _BIDDER_EAMIL; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_EAMIL, _BIDDER_EAMIL, value);
				this._BIDDER_EAMIL = value;
			}
		}
		/// <summary>
		/// 投保人法人身份证号
		/// </summary>
		public string LEGAL_PERSON_IDCARD
		{
			get { return _LEGAL_PERSON_IDCARD; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_PERSON_IDCARD, _LEGAL_PERSON_IDCARD, value);
				this._LEGAL_PERSON_IDCARD = value;
			}
		}
		/// <summary>
		/// 电子申请单文件MD5码
		/// </summary>
		public string ORDER_MD5
		{
			get { return _ORDER_MD5; }
			set
			{
				this.OnPropertyValueChange(_.ORDER_MD5, _ORDER_MD5, value);
				this._ORDER_MD5 = value;
			}
		}
		/// <summary>
		/// 招标文件MD5码
		/// </summary>
		public string TENDER_FILE_MD5
		{
			get { return _TENDER_FILE_MD5; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_FILE_MD5, _TENDER_FILE_MD5, value);
				this._TENDER_FILE_MD5 = value;
			}
		}
		/// <summary>
		/// 企业资质文件大写MD5码
		/// </summary>
		public string QUALFICATION_FILE_MD5
		{
			get { return _QUALFICATION_FILE_MD5; }
			set
			{
				this.OnPropertyValueChange(_.QUALFICATION_FILE_MD5, _QUALFICATION_FILE_MD5, value);
				this._QUALFICATION_FILE_MD5 = value;
			}
		}
		/// <summary>
		/// 企业营业执照大写MD5码
		/// </summary>
		public string BUSINESS_LICENSE_MD5
		{
			get { return _BUSINESS_LICENSE_MD5; }
			set
			{
				this.OnPropertyValueChange(_.BUSINESS_LICENSE_MD5, _BUSINESS_LICENSE_MD5, value);
				this._BUSINESS_LICENSE_MD5 = value;
			}
		}
		/// <summary>
		/// 保函系统返回的url
		/// </summary>
		public string RECEIVE_URL
		{
			get { return _RECEIVE_URL; }
			set
			{
				this.OnPropertyValueChange(_.RECEIVE_URL, _RECEIVE_URL, value);
				this._RECEIVE_URL = value;
			}
		}
		/// <summary>
		/// 用户id
		/// </summary>
		public decimal? USER_ID
		{
			get { return _USER_ID; }
			set
			{
				this.OnPropertyValueChange(_.USER_ID, _USER_ID, value);
				this._USER_ID = value;
			}
		}
		/// <summary>
		/// _1暂存 2待审核 3待支付 4审核不通过 5投保合同待签订 6保函待开具 9其他 10完成
		/// </summary>
		public string STATUS
		{
			get { return _STATUS; }
			set
			{
				this.OnPropertyValueChange(_.STATUS, _STATUS, value);
				this._STATUS = value;
			}
		}
		/// <summary>
		/// 系统编号
		/// </summary>
		public string SYSTEM_NO
		{
			get { return _SYSTEM_NO; }
			set
			{
				this.OnPropertyValueChange(_.SYSTEM_NO, _SYSTEM_NO, value);
				this._SYSTEM_NO = value;
			}
		}
		/// <summary>
		/// 申请时间
		/// </summary>
		public DateTime? CREATE_TIME
		{
			get { return _CREATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
				this._CREATE_TIME = value;
			}
		}
		/// <summary>
		/// 对应签章表的guid
		/// </summary>
		public string SIGN_GUID
		{
			get { return _SIGN_GUID; }
			set
			{
				this.OnPropertyValueChange(_.SIGN_GUID, _SIGN_GUID, value);
				this._SIGN_GUID = value;
			}
		}
		/// <summary>
		/// 申请单文件附件id
		/// </summary>
		public string ORDER_AIDS
		{
			get { return _ORDER_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.ORDER_AIDS, _ORDER_AIDS, value);
				this._ORDER_AIDS = value;
			}
		}
		/// <summary>
		/// 招标文件附件id
		/// </summary>
		public string TENDER_FILE_AIDS
		{
			get { return _TENDER_FILE_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_FILE_AIDS, _TENDER_FILE_AIDS, value);
				this._TENDER_FILE_AIDS = value;
			}
		}
		/// <summary>
		/// 资质文件附件id
		/// </summary>
		public string QUALFICATION_FILE_AIDS
		{
			get { return _QUALFICATION_FILE_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.QUALFICATION_FILE_AIDS, _QUALFICATION_FILE_AIDS, value);
				this._QUALFICATION_FILE_AIDS = value;
			}
		}
		/// <summary>
		/// 营业执照附件id
		/// </summary>
		public string BUSINESS_LICENSE_AIDS
		{
			get { return _BUSINESS_LICENSE_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.BUSINESS_LICENSE_AIDS, _BUSINESS_LICENSE_AIDS, value);
				this._BUSINESS_LICENSE_AIDS = value;
			}
		}
		/// <summary>
		/// 状态备注
		/// </summary>
		public string STATUS_REMARK
		{
			get { return _STATUS_REMARK; }
			set
			{
				this.OnPropertyValueChange(_.STATUS_REMARK, _STATUS_REMARK, value);
				this._STATUS_REMARK = value;
			}
		}
		/// <summary>
		/// 投保人法定代表人身份证件类型
		/// </summary>
		public string LEGAL_PERSON_IDCARD_TYPE
		{
			get { return _LEGAL_PERSON_IDCARD_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_PERSON_IDCARD_TYPE, _LEGAL_PERSON_IDCARD_TYPE, value);
				this._LEGAL_PERSON_IDCARD_TYPE = value;
			}
		}
		/// <summary>
		/// 招标人银行账户名称
		/// </summary>
		public string TENDERER_BANK_ACCOUNT
		{
			get { return _TENDERER_BANK_ACCOUNT; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_BANK_ACCOUNT, _TENDERER_BANK_ACCOUNT, value);
				this._TENDERER_BANK_ACCOUNT = value;
			}
		}
		/// <summary>
		/// 招标人联系人
		/// </summary>
		public string TENDERER_CONTACT
		{
			get { return _TENDERER_CONTACT; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_CONTACT, _TENDERER_CONTACT, value);
				this._TENDERER_CONTACT = value;
			}
		}
		/// <summary>
		/// 招标人联系人联系方式
		/// </summary>
		public string TENDERER_CONTACT_TEL
		{
			get { return _TENDERER_CONTACT_TEL; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_CONTACT_TEL, _TENDERER_CONTACT_TEL, value);
				this._TENDERER_CONTACT_TEL = value;
			}
		}
		/// <summary>
		/// 投资项目统一代码
		/// </summary>
		public string INVEST_PROJECT_CODE
		{
			get { return _INVEST_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.INVEST_PROJECT_CODE, _INVEST_PROJECT_CODE, value);
				this._INVEST_PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 投标有效期，单位天
		/// </summary>
		public decimal VALID_PERIOD
		{
			get { return _VALID_PERIOD; }
			set
			{
				this.OnPropertyValueChange(_.VALID_PERIOD, _VALID_PERIOD, value);
				this._VALID_PERIOD = value;
			}
		}
		/// <summary>
		/// 投保人联系人身份证件号码
		/// </summary>
		public string BIDDER_CONTACT_IDCARD
		{
			get { return _BIDDER_CONTACT_IDCARD; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_CONTACT_IDCARD, _BIDDER_CONTACT_IDCARD, value);
				this._BIDDER_CONTACT_IDCARD = value;
			}
		}
		/// <summary>
		/// 投保人联系人身份证件类型,见字典5.3身份证件类型
		/// </summary>
		public string BIDDER_CONTACT_IDCARD_TYPE
		{
			get { return _BIDDER_CONTACT_IDCARD_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_CONTACT_IDCARD_TYPE, _BIDDER_CONTACT_IDCARD_TYPE, value);
				this._BIDDER_CONTACT_IDCARD_TYPE = value;
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
				_.M_ID,
			};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.M_ID,
				_.M_DATA_KEY,
				_.ORDER_ID,
				_.APPROVAL_CODE,
				_.TENDER_PROJECT_CODE,
				_.TENDER_PROJECT_NAME,
				_.SECTION_CODE,
				_.SECTION_NAME,
				_.CONTRACT_RECKON_PRICE,
				_.TENDERER,
				_.TENDERER_CREDIT_CODE,
				_.TENDERER_BANK_CODE,
				_.TENDERER_BANK_OPENBANK,
				_.CITY_CODE,
				_.TENDER_PROJECT_TYPE,
				_.BID_OPEN_TIME,
				_.SERVICE_BEGIN_TIME,
				_.SERVICE_END_TIME,
				_.BID_BOND,
				_.GUARANTOR_NAME,
				_.GUARANTOR_CREDIT_CODE,
				_.GUARANTOR_CONTACT_NAME,
				_.GUARANTOR_CONTACT_TEL,
				_.BIDDER_NAME,
				_.BIDDER_CREDIT_CODE,
				_.BIDDER_CONTACT_NAME,
				_.BIDDER_CONTACT_TEL,
				_.BIDDER_ADDRESS,
				_.BIDDER_TAXPAYER_CODE,
				_.LEGAL_PERSON_NAME,
				_.LEGAL_PERSON_TEL,
				_.ORDER_URL,
				_.TENDER_FILE_URL,
				_.QUALFICATION_FILE_URL,
				_.SECRET,
				_.BUSINESS_LICENSE_URL,
				_.BIDDER_EAMIL,
				_.LEGAL_PERSON_IDCARD,
				_.ORDER_MD5,
				_.TENDER_FILE_MD5,
				_.QUALFICATION_FILE_MD5,
				_.BUSINESS_LICENSE_MD5,
				_.RECEIVE_URL,
				_.USER_ID,
				_.STATUS,
				_.SYSTEM_NO,
				_.CREATE_TIME,
				_.SIGN_GUID,
				_.ORDER_AIDS,
				_.TENDER_FILE_AIDS,
				_.QUALFICATION_FILE_AIDS,
				_.BUSINESS_LICENSE_AIDS,
				_.STATUS_REMARK,
				_.LEGAL_PERSON_IDCARD_TYPE,
				_.TENDERER_BANK_ACCOUNT,
				_.TENDERER_CONTACT,
				_.TENDERER_CONTACT_TEL,
				_.INVEST_PROJECT_CODE,
				_.VALID_PERIOD,
				_.BIDDER_CONTACT_IDCARD,
				_.BIDDER_CONTACT_IDCARD_TYPE,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._M_ID,
				this._M_DATA_KEY,
				this._ORDER_ID,
				this._APPROVAL_CODE,
				this._TENDER_PROJECT_CODE,
				this._TENDER_PROJECT_NAME,
				this._SECTION_CODE,
				this._SECTION_NAME,
				this._CONTRACT_RECKON_PRICE,
				this._TENDERER,
				this._TENDERER_CREDIT_CODE,
				this._TENDERER_BANK_CODE,
				this._TENDERER_BANK_OPENBANK,
				this._CITY_CODE,
				this._TENDER_PROJECT_TYPE,
				this._BID_OPEN_TIME,
				this._SERVICE_BEGIN_TIME,
				this._SERVICE_END_TIME,
				this._BID_BOND,
				this._GUARANTOR_NAME,
				this._GUARANTOR_CREDIT_CODE,
				this._GUARANTOR_CONTACT_NAME,
				this._GUARANTOR_CONTACT_TEL,
				this._BIDDER_NAME,
				this._BIDDER_CREDIT_CODE,
				this._BIDDER_CONTACT_NAME,
				this._BIDDER_CONTACT_TEL,
				this._BIDDER_ADDRESS,
				this._BIDDER_TAXPAYER_CODE,
				this._LEGAL_PERSON_NAME,
				this._LEGAL_PERSON_TEL,
				this._ORDER_URL,
				this._TENDER_FILE_URL,
				this._QUALFICATION_FILE_URL,
				this._SECRET,
				this._BUSINESS_LICENSE_URL,
				this._BIDDER_EAMIL,
				this._LEGAL_PERSON_IDCARD,
				this._ORDER_MD5,
				this._TENDER_FILE_MD5,
				this._QUALFICATION_FILE_MD5,
				this._BUSINESS_LICENSE_MD5,
				this._RECEIVE_URL,
				this._USER_ID,
				this._STATUS,
				this._SYSTEM_NO,
				this._CREATE_TIME,
				this._SIGN_GUID,
				this._ORDER_AIDS,
				this._TENDER_FILE_AIDS,
				this._QUALFICATION_FILE_AIDS,
				this._BUSINESS_LICENSE_AIDS,
				this._STATUS_REMARK,
				this._LEGAL_PERSON_IDCARD_TYPE,
				this._TENDERER_BANK_ACCOUNT,
				this._TENDERER_CONTACT,
				this._TENDERER_CONTACT_TEL,
				this._INVEST_PROJECT_CODE,
				this._VALID_PERIOD,
				this._BIDDER_CONTACT_IDCARD,
				this._BIDDER_CONTACT_IDCARD_TYPE,
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
			public readonly static Field All = new Field("*", "BH_SEND_APPLICATION_FORM");
			/// <summary>
			/// 自增长ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "BH_SEND_APPLICATION_FORM", "自增长ID");
			/// <summary>
			/// 数据唯一识别
			/// </summary>
			public readonly static Field M_DATA_KEY = new Field("M_DATA_KEY", "BH_SEND_APPLICATION_FORM", "数据唯一识别");
			/// <summary>
			/// 订单号(唯一)
			/// </summary>
			public readonly static Field ORDER_ID = new Field("ORDER_ID", "BH_SEND_APPLICATION_FORM", "订单号(唯一)");
			/// <summary>
			/// 立项批文号
			/// </summary>
			public readonly static Field APPROVAL_CODE = new Field("APPROVAL_CODE", "BH_SEND_APPLICATION_FORM", "立项批文号");
			/// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "BH_SEND_APPLICATION_FORM", "招标项目编号");
			/// <summary>
			/// 招标项目名称
			/// </summary>
			public readonly static Field TENDER_PROJECT_NAME = new Field("TENDER_PROJECT_NAME", "BH_SEND_APPLICATION_FORM", "招标项目名称");
			/// <summary>
			/// 标段编号
			/// </summary>
			public readonly static Field SECTION_CODE = new Field("SECTION_CODE", "BH_SEND_APPLICATION_FORM", "标段编号");
			/// <summary>
			/// 标段名称
			/// </summary>
			public readonly static Field SECTION_NAME = new Field("SECTION_NAME", "BH_SEND_APPLICATION_FORM", "标段名称");
			/// <summary>
			/// 合同估算价
			/// </summary>
			public readonly static Field CONTRACT_RECKON_PRICE = new Field("CONTRACT_RECKON_PRICE", "BH_SEND_APPLICATION_FORM", "合同估算价");
			/// <summary>
			/// 招标人
			/// </summary>
			public readonly static Field TENDERER = new Field("TENDERER", "BH_SEND_APPLICATION_FORM", "招标人");
			/// <summary>
			/// 招标人统一社会信用代码
			/// </summary>
			public readonly static Field TENDERER_CREDIT_CODE = new Field("TENDERER_CREDIT_CODE", "BH_SEND_APPLICATION_FORM", "招标人统一社会信用代码");
			/// <summary>
			/// 招标人银行账号
			/// </summary>
			public readonly static Field TENDERER_BANK_CODE = new Field("TENDERER_BANK_CODE", "BH_SEND_APPLICATION_FORM", "招标人银行账号");
			/// <summary>
			/// 招标人银行开户行
			/// </summary>
			public readonly static Field TENDERER_BANK_OPENBANK = new Field("TENDERER_BANK_OPENBANK", "BH_SEND_APPLICATION_FORM", "招标人银行开户行");
			/// <summary>
			/// 项目所在地(行政区划代码)
			/// </summary>
			public readonly static Field CITY_CODE = new Field("CITY_CODE", "BH_SEND_APPLICATION_FORM", "项目所在地(行政区划代码)");
			/// <summary>
			/// 招标项目类别（字典5.1）
			/// </summary>
			public readonly static Field TENDER_PROJECT_TYPE = new Field("TENDER_PROJECT_TYPE", "BH_SEND_APPLICATION_FORM", "招标项目类别（字典5.1）");
			/// <summary>
			/// 开标时间（YYYYMMDDHHMMSS）
			/// </summary>
			public readonly static Field BID_OPEN_TIME = new Field("BID_OPEN_TIME", "BH_SEND_APPLICATION_FORM", "开标时间（YYYYMMDDHHMMSS）");
			/// <summary>
			/// 保函开始日期(默认为开标日期)
			/// </summary>
			public readonly static Field SERVICE_BEGIN_TIME = new Field("SERVICE_BEGIN_TIME", "BH_SEND_APPLICATION_FORM", "保函开始日期(默认为开标日期)");
			/// <summary>
			/// 保函截止日期(默认为开标日期后顺延28日历天)
			/// </summary>
			public readonly static Field SERVICE_END_TIME = new Field("SERVICE_END_TIME", "BH_SEND_APPLICATION_FORM", "保函截止日期(默认为开标日期后顺延28日历天)");
			/// <summary>
			/// 担保额度（保证金要求数额）（元）
			/// </summary>
			public readonly static Field BID_BOND = new Field("BID_BOND", "BH_SEND_APPLICATION_FORM", "担保额度（保证金要求数额）（元）");
			/// <summary>
			/// 承保人名称
			/// </summary>
			public readonly static Field GUARANTOR_NAME = new Field("GUARANTOR_NAME", "BH_SEND_APPLICATION_FORM", "承保人名称");
			/// <summary>
			/// 承保人统一社会信用代码证号
			/// </summary>
			public readonly static Field GUARANTOR_CREDIT_CODE = new Field("GUARANTOR_CREDIT_CODE", "BH_SEND_APPLICATION_FORM", "承保人统一社会信用代码证号");
			/// <summary>
			/// 承保人联系人
			/// </summary>
			public readonly static Field GUARANTOR_CONTACT_NAME = new Field("GUARANTOR_CONTACT_NAME", "BH_SEND_APPLICATION_FORM", "承保人联系人");
			/// <summary>
			/// 承保人联系电话
			/// </summary>
			public readonly static Field GUARANTOR_CONTACT_TEL = new Field("GUARANTOR_CONTACT_TEL", "BH_SEND_APPLICATION_FORM", "承保人联系电话");
			/// <summary>
			/// 投标人名称
			/// </summary>
			public readonly static Field BIDDER_NAME = new Field("BIDDER_NAME", "BH_SEND_APPLICATION_FORM", "投标人名称");
			/// <summary>
			/// 投标人统一社会信用代码证号
			/// </summary>
			public readonly static Field BIDDER_CREDIT_CODE = new Field("BIDDER_CREDIT_CODE", "BH_SEND_APPLICATION_FORM", "投标人统一社会信用代码证号");
			/// <summary>
			/// 投标人联系人
			/// </summary>
			public readonly static Field BIDDER_CONTACT_NAME = new Field("BIDDER_CONTACT_NAME", "BH_SEND_APPLICATION_FORM", "投标人联系人");
			/// <summary>
			/// 投标人联系电话
			/// </summary>
			public readonly static Field BIDDER_CONTACT_TEL = new Field("BIDDER_CONTACT_TEL", "BH_SEND_APPLICATION_FORM", "投标人联系电话");
			/// <summary>
			/// 投标人地址
			/// </summary>
			public readonly static Field BIDDER_ADDRESS = new Field("BIDDER_ADDRESS", "BH_SEND_APPLICATION_FORM", "投标人地址");
			/// <summary>
			/// 投标人纳税人识别号
			/// </summary>
			public readonly static Field BIDDER_TAXPAYER_CODE = new Field("BIDDER_TAXPAYER_CODE", "BH_SEND_APPLICATION_FORM", "投标人纳税人识别号");
			/// <summary>
			/// 投标人法人姓名
			/// </summary>
			public readonly static Field LEGAL_PERSON_NAME = new Field("LEGAL_PERSON_NAME", "BH_SEND_APPLICATION_FORM", "投标人法人姓名");
			/// <summary>
			/// 投标人法人联系方式
			/// </summary>
			public readonly static Field LEGAL_PERSON_TEL = new Field("LEGAL_PERSON_TEL", "BH_SEND_APPLICATION_FORM", "投标人法人联系方式");
			/// <summary>
			/// 电子申请单文件下载地址
			/// </summary>
			public readonly static Field ORDER_URL = new Field("ORDER_URL", "BH_SEND_APPLICATION_FORM", "电子申请单文件下载地址");
			/// <summary>
			/// 招标文件下载地址
			/// </summary>
			public readonly static Field TENDER_FILE_URL = new Field("TENDER_FILE_URL", "BH_SEND_APPLICATION_FORM", "招标文件下载地址");
			/// <summary>
			/// 企业资质文件下载地址
			/// </summary>
			public readonly static Field QUALFICATION_FILE_URL = new Field("QUALFICATION_FILE_URL", "BH_SEND_APPLICATION_FORM", "企业资质文件下载地址");
			/// <summary>
			/// 数字信封
			/// </summary>
			public readonly static Field SECRET = new Field("SECRET", "BH_SEND_APPLICATION_FORM", "数字信封");
			/// <summary>
			/// 企业营业执照下载地址
			/// </summary>
			public readonly static Field BUSINESS_LICENSE_URL = new Field("BUSINESS_LICENSE_URL", "BH_SEND_APPLICATION_FORM", "企业营业执照下载地址");
			/// <summary>
			/// 投保人邮箱
			/// </summary>
			public readonly static Field BIDDER_EAMIL = new Field("BIDDER_EAMIL", "BH_SEND_APPLICATION_FORM", "投保人邮箱");
			/// <summary>
			/// 投保人法人身份证号
			/// </summary>
			public readonly static Field LEGAL_PERSON_IDCARD = new Field("LEGAL_PERSON_IDCARD", "BH_SEND_APPLICATION_FORM", "投保人法人身份证号");
			/// <summary>
			/// 电子申请单文件MD5码
			/// </summary>
			public readonly static Field ORDER_MD5 = new Field("ORDER_MD5", "BH_SEND_APPLICATION_FORM", "电子申请单文件MD5码");
			/// <summary>
			/// 招标文件MD5码
			/// </summary>
			public readonly static Field TENDER_FILE_MD5 = new Field("TENDER_FILE_MD5", "BH_SEND_APPLICATION_FORM", "招标文件MD5码");
			/// <summary>
			/// 企业资质文件大写MD5码
			/// </summary>
			public readonly static Field QUALFICATION_FILE_MD5 = new Field("QUALFICATION_FILE_MD5", "BH_SEND_APPLICATION_FORM", "企业资质文件大写MD5码");
			/// <summary>
			/// 企业营业执照大写MD5码
			/// </summary>
			public readonly static Field BUSINESS_LICENSE_MD5 = new Field("BUSINESS_LICENSE_MD5", "BH_SEND_APPLICATION_FORM", "企业营业执照大写MD5码");
			/// <summary>
			/// 保函系统返回的url
			/// </summary>
			public readonly static Field RECEIVE_URL = new Field("RECEIVE_URL", "BH_SEND_APPLICATION_FORM", "保函系统返回的url");
			/// <summary>
			/// 用户id
			/// </summary>
			public readonly static Field USER_ID = new Field("USER_ID", "BH_SEND_APPLICATION_FORM", "用户id");
			/// <summary>
			/// _1暂存 2待审核 3待支付 4审核不通过 5投保合同待签订 6保函待开具 9其他 10完成
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "BH_SEND_APPLICATION_FORM", "_1暂存 2待审核 3待支付 4审核不通过 5投保合同待签订 6保函待开具 9其他 10完成");
			/// <summary>
			/// 系统编号
			/// </summary>
			public readonly static Field SYSTEM_NO = new Field("SYSTEM_NO", "BH_SEND_APPLICATION_FORM", "系统编号");
			/// <summary>
			/// 申请时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "BH_SEND_APPLICATION_FORM", "申请时间");
			/// <summary>
			/// 对应签章表的guid
			/// </summary>
			public readonly static Field SIGN_GUID = new Field("SIGN_GUID", "BH_SEND_APPLICATION_FORM", "对应签章表的guid");
			/// <summary>
			/// 申请单文件附件id
			/// </summary>
			public readonly static Field ORDER_AIDS = new Field("ORDER_AIDS", "BH_SEND_APPLICATION_FORM", "申请单文件附件id");
			/// <summary>
			/// 招标文件附件id
			/// </summary>
			public readonly static Field TENDER_FILE_AIDS = new Field("TENDER_FILE_AIDS", "BH_SEND_APPLICATION_FORM", "招标文件附件id");
			/// <summary>
			/// 资质文件附件id
			/// </summary>
			public readonly static Field QUALFICATION_FILE_AIDS = new Field("QUALFICATION_FILE_AIDS", "BH_SEND_APPLICATION_FORM", "资质文件附件id");
			/// <summary>
			/// 营业执照附件id
			/// </summary>
			public readonly static Field BUSINESS_LICENSE_AIDS = new Field("BUSINESS_LICENSE_AIDS", "BH_SEND_APPLICATION_FORM", "营业执照附件id");
			/// <summary>
			/// 状态备注
			/// </summary>
			public readonly static Field STATUS_REMARK = new Field("STATUS_REMARK", "BH_SEND_APPLICATION_FORM", "状态备注");
			/// <summary>
			/// 投保人法定代表人身份证件类型
			/// </summary>
			public readonly static Field LEGAL_PERSON_IDCARD_TYPE = new Field("LEGAL_PERSON_IDCARD_TYPE", "BH_SEND_APPLICATION_FORM", "投保人法定代表人身份证件类型");
			/// <summary>
			/// 招标人银行账户名称
			/// </summary>
			public readonly static Field TENDERER_BANK_ACCOUNT = new Field("TENDERER_BANK_ACCOUNT", "BH_SEND_APPLICATION_FORM", "招标人银行账户名称");
			/// <summary>
			/// 招标人联系人
			/// </summary>
			public readonly static Field TENDERER_CONTACT = new Field("TENDERER_CONTACT", "BH_SEND_APPLICATION_FORM", "招标人联系人");
			/// <summary>
			/// 招标人联系人联系方式
			/// </summary>
			public readonly static Field TENDERER_CONTACT_TEL = new Field("TENDERER_CONTACT_TEL", "BH_SEND_APPLICATION_FORM", "招标人联系人联系方式");
			/// <summary>
			/// 投资项目统一代码
			/// </summary>
			public readonly static Field INVEST_PROJECT_CODE = new Field("INVEST_PROJECT_CODE", "BH_SEND_APPLICATION_FORM", "投资项目统一代码");
			/// <summary>
			/// 投标有效期，单位天
			/// </summary>
			public readonly static Field VALID_PERIOD = new Field("VALID_PERIOD", "BH_SEND_APPLICATION_FORM", "投标有效期，单位天");
			/// <summary>
			/// 投保人联系人身份证件号码
			/// </summary>
			public readonly static Field BIDDER_CONTACT_IDCARD = new Field("BIDDER_CONTACT_IDCARD", "BH_SEND_APPLICATION_FORM", "投保人联系人身份证件号码");
			/// <summary>
			/// 投保人联系人身份证件类型,见字典5.3身份证件类型
			/// </summary>
			public readonly static Field BIDDER_CONTACT_IDCARD_TYPE = new Field("BIDDER_CONTACT_IDCARD_TYPE", "BH_SEND_APPLICATION_FORM", "投保人联系人身份证件类型,见字典5.3身份证件类型");
		}
		#endregion


		public override string GetSequence()
        {
            return "SEQ_BH_SEND_APPLICATION_FORM";
        }

        public override Field GetIdentityField()
        {
            return _.M_ID;
        }
    }
}