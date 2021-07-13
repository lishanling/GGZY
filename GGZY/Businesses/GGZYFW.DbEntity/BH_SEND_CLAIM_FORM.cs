using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
	/// <summary>
	/// 实体类BH_SEND_CLAIM_FORM。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("BH_SEND_CLAIM_FORM")]
	[Serializable]
	public partial class BH_SEND_CLAIM_FORM : FwEntity
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
		private decimal _AMOUNT;
		private decimal _RATE;
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
		private string _CLAIM_NAME;
		private string _CLAIM_CREDIT_CODE;
		private string _CLAIM_TEL;
		private string _CLAIM_EMAIL;
		private decimal _CLAIM_AMOUNT;
		private string _CLAIM_REASON;
		private string _GUARANTEE_NO;
		private string _BIDDER_EAMIL;
		private string _LEGAL_PERSON_IDCARD;
		private string _CLIAM_ATTACHMENT_URL;
		private string _CLIAM_ATTACHMENT_MD5;
		private string _CLIAM_ATTACHMENT_AID;
		private DateTime? _CREATE_TIME;
		private decimal? _USER_ID;

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
		/// 保费（元）
		/// </summary>
		public decimal AMOUNT
		{
			get { return _AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.AMOUNT, _AMOUNT, value);
				this._AMOUNT = value;
			}
		}
		/// <summary>
		/// 费率（百分号）如千分五填0.5
		/// </summary>
		public decimal RATE
		{
			get { return _RATE; }
			set
			{
				this.OnPropertyValueChange(_.RATE, _RATE, value);
				this._RATE = value;
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
		/// 索赔人名称
		/// </summary>
		public string CLAIM_NAME
		{
			get { return _CLAIM_NAME; }
			set
			{
				this.OnPropertyValueChange(_.CLAIM_NAME, _CLAIM_NAME, value);
				this._CLAIM_NAME = value;
			}
		}
		/// <summary>
		/// 索赔人统一社会信用代码证号
		/// </summary>
		public string CLAIM_CREDIT_CODE
		{
			get { return _CLAIM_CREDIT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CLAIM_CREDIT_CODE, _CLAIM_CREDIT_CODE, value);
				this._CLAIM_CREDIT_CODE = value;
			}
		}
		/// <summary>
		/// 索赔人手机号
		/// </summary>
		public string CLAIM_TEL
		{
			get { return _CLAIM_TEL; }
			set
			{
				this.OnPropertyValueChange(_.CLAIM_TEL, _CLAIM_TEL, value);
				this._CLAIM_TEL = value;
			}
		}
		/// <summary>
		/// 索赔人邮箱
		/// </summary>
		public string CLAIM_EMAIL
		{
			get { return _CLAIM_EMAIL; }
			set
			{
				this.OnPropertyValueChange(_.CLAIM_EMAIL, _CLAIM_EMAIL, value);
				this._CLAIM_EMAIL = value;
			}
		}
		/// <summary>
		/// 索赔金额
		/// </summary>
		public decimal CLAIM_AMOUNT
		{
			get { return _CLAIM_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.CLAIM_AMOUNT, _CLAIM_AMOUNT, value);
				this._CLAIM_AMOUNT = value;
			}
		}
		/// <summary>
		/// 索赔理由
		/// </summary>
		public string CLAIM_REASON
		{
			get { return _CLAIM_REASON; }
			set
			{
				this.OnPropertyValueChange(_.CLAIM_REASON, _CLAIM_REASON, value);
				this._CLAIM_REASON = value;
			}
		}
		/// <summary>
		/// 保函单号
		/// </summary>
		public string GUARANTEE_NO
		{
			get { return _GUARANTEE_NO; }
			set
			{
				this.OnPropertyValueChange(_.GUARANTEE_NO, _GUARANTEE_NO, value);
				this._GUARANTEE_NO = value;
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
		/// 附件下载地址，此文件为压缩包
		/// </summary>
		public string CLIAM_ATTACHMENT_URL
		{
			get { return _CLIAM_ATTACHMENT_URL; }
			set
			{
				this.OnPropertyValueChange(_.CLIAM_ATTACHMENT_URL, _CLIAM_ATTACHMENT_URL, value);
				this._CLIAM_ATTACHMENT_URL = value;
			}
		}
		/// <summary>
		/// 附件md5
		/// </summary>
		public string CLIAM_ATTACHMENT_MD5
		{
			get { return _CLIAM_ATTACHMENT_MD5; }
			set
			{
				this.OnPropertyValueChange(_.CLIAM_ATTACHMENT_MD5, _CLIAM_ATTACHMENT_MD5, value);
				this._CLIAM_ATTACHMENT_MD5 = value;
			}
		}
		/// <summary>
		/// 附件id
		/// </summary>
		public string CLIAM_ATTACHMENT_AID
		{
			get { return _CLIAM_ATTACHMENT_AID; }
			set
			{
				this.OnPropertyValueChange(_.CLIAM_ATTACHMENT_AID, _CLIAM_ATTACHMENT_AID, value);
				this._CLIAM_ATTACHMENT_AID = value;
			}
		}
		/// <summary>
		/// 创建时间
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
		/// 创建用户id
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
				_.AMOUNT,
				_.RATE,
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
				_.CLAIM_NAME,
				_.CLAIM_CREDIT_CODE,
				_.CLAIM_TEL,
				_.CLAIM_EMAIL,
				_.CLAIM_AMOUNT,
				_.CLAIM_REASON,
				_.GUARANTEE_NO,
				_.BIDDER_EAMIL,
				_.LEGAL_PERSON_IDCARD,
				_.CLIAM_ATTACHMENT_URL,
				_.CLIAM_ATTACHMENT_MD5,
				_.CLIAM_ATTACHMENT_AID,
				_.CREATE_TIME,
				_.USER_ID,
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
				this._AMOUNT,
				this._RATE,
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
				this._CLAIM_NAME,
				this._CLAIM_CREDIT_CODE,
				this._CLAIM_TEL,
				this._CLAIM_EMAIL,
				this._CLAIM_AMOUNT,
				this._CLAIM_REASON,
				this._GUARANTEE_NO,
				this._BIDDER_EAMIL,
				this._LEGAL_PERSON_IDCARD,
				this._CLIAM_ATTACHMENT_URL,
				this._CLIAM_ATTACHMENT_MD5,
				this._CLIAM_ATTACHMENT_AID,
				this._CREATE_TIME,
				this._USER_ID,
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
			public readonly static Field All = new Field("*", "BH_SEND_CLAIM_FORM");
			/// <summary>
			/// 自增长ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "BH_SEND_CLAIM_FORM", "自增长ID");
			/// <summary>
			/// 数据唯一识别
			/// </summary>
			public readonly static Field M_DATA_KEY = new Field("M_DATA_KEY", "BH_SEND_CLAIM_FORM", "数据唯一识别");
			/// <summary>
			/// 订单号(唯一)
			/// </summary>
			public readonly static Field ORDER_ID = new Field("ORDER_ID", "BH_SEND_CLAIM_FORM", "订单号(唯一)");
			/// <summary>
			/// 立项批文号
			/// </summary>
			public readonly static Field APPROVAL_CODE = new Field("APPROVAL_CODE", "BH_SEND_CLAIM_FORM", "立项批文号");
			/// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "BH_SEND_CLAIM_FORM", "招标项目编号");
			/// <summary>
			/// 招标项目名称
			/// </summary>
			public readonly static Field TENDER_PROJECT_NAME = new Field("TENDER_PROJECT_NAME", "BH_SEND_CLAIM_FORM", "招标项目名称");
			/// <summary>
			/// 标段编号
			/// </summary>
			public readonly static Field SECTION_CODE = new Field("SECTION_CODE", "BH_SEND_CLAIM_FORM", "标段编号");
			/// <summary>
			/// 标段名称
			/// </summary>
			public readonly static Field SECTION_NAME = new Field("SECTION_NAME", "BH_SEND_CLAIM_FORM", "标段名称");
			/// <summary>
			/// 合同估算价
			/// </summary>
			public readonly static Field CONTRACT_RECKON_PRICE = new Field("CONTRACT_RECKON_PRICE", "BH_SEND_CLAIM_FORM", "合同估算价");
			/// <summary>
			/// 招标人
			/// </summary>
			public readonly static Field TENDERER = new Field("TENDERER", "BH_SEND_CLAIM_FORM", "招标人");
			/// <summary>
			/// 招标人统一社会信用代码
			/// </summary>
			public readonly static Field TENDERER_CREDIT_CODE = new Field("TENDERER_CREDIT_CODE", "BH_SEND_CLAIM_FORM", "招标人统一社会信用代码");
			/// <summary>
			/// 招标人银行账号
			/// </summary>
			public readonly static Field TENDERER_BANK_CODE = new Field("TENDERER_BANK_CODE", "BH_SEND_CLAIM_FORM", "招标人银行账号");
			/// <summary>
			/// 招标人银行开户行
			/// </summary>
			public readonly static Field TENDERER_BANK_OPENBANK = new Field("TENDERER_BANK_OPENBANK", "BH_SEND_CLAIM_FORM", "招标人银行开户行");
			/// <summary>
			/// 项目所在地(行政区划代码)
			/// </summary>
			public readonly static Field CITY_CODE = new Field("CITY_CODE", "BH_SEND_CLAIM_FORM", "项目所在地(行政区划代码)");
			/// <summary>
			/// 招标项目类别（字典5.1）
			/// </summary>
			public readonly static Field TENDER_PROJECT_TYPE = new Field("TENDER_PROJECT_TYPE", "BH_SEND_CLAIM_FORM", "招标项目类别（字典5.1）");
			/// <summary>
			/// 开标时间（YYYYMMDDHHMMSS）
			/// </summary>
			public readonly static Field BID_OPEN_TIME = new Field("BID_OPEN_TIME", "BH_SEND_CLAIM_FORM", "开标时间（YYYYMMDDHHMMSS）");
			/// <summary>
			/// 保函开始日期(默认为开标日期)
			/// </summary>
			public readonly static Field SERVICE_BEGIN_TIME = new Field("SERVICE_BEGIN_TIME", "BH_SEND_CLAIM_FORM", "保函开始日期(默认为开标日期)");
			/// <summary>
			/// 保函截止日期(默认为开标日期后顺延28日历天)
			/// </summary>
			public readonly static Field SERVICE_END_TIME = new Field("SERVICE_END_TIME", "BH_SEND_CLAIM_FORM", "保函截止日期(默认为开标日期后顺延28日历天)");
			/// <summary>
			/// 担保额度（保证金要求数额）（元）
			/// </summary>
			public readonly static Field BID_BOND = new Field("BID_BOND", "BH_SEND_CLAIM_FORM", "担保额度（保证金要求数额）（元）");
			/// <summary>
			/// 保费（元）
			/// </summary>
			public readonly static Field AMOUNT = new Field("AMOUNT", "BH_SEND_CLAIM_FORM", "保费（元）");
			/// <summary>
			/// 费率（百分号）如千分五填0.5
			/// </summary>
			public readonly static Field RATE = new Field("RATE", "BH_SEND_CLAIM_FORM", "费率（百分号）如千分五填0.5");
			/// <summary>
			/// 承保人名称
			/// </summary>
			public readonly static Field GUARANTOR_NAME = new Field("GUARANTOR_NAME", "BH_SEND_CLAIM_FORM", "承保人名称");
			/// <summary>
			/// 承保人统一社会信用代码证号
			/// </summary>
			public readonly static Field GUARANTOR_CREDIT_CODE = new Field("GUARANTOR_CREDIT_CODE", "BH_SEND_CLAIM_FORM", "承保人统一社会信用代码证号");
			/// <summary>
			/// 承保人联系人
			/// </summary>
			public readonly static Field GUARANTOR_CONTACT_NAME = new Field("GUARANTOR_CONTACT_NAME", "BH_SEND_CLAIM_FORM", "承保人联系人");
			/// <summary>
			/// 承保人联系电话
			/// </summary>
			public readonly static Field GUARANTOR_CONTACT_TEL = new Field("GUARANTOR_CONTACT_TEL", "BH_SEND_CLAIM_FORM", "承保人联系电话");
			/// <summary>
			/// 投标人名称
			/// </summary>
			public readonly static Field BIDDER_NAME = new Field("BIDDER_NAME", "BH_SEND_CLAIM_FORM", "投标人名称");
			/// <summary>
			/// 投标人统一社会信用代码证号
			/// </summary>
			public readonly static Field BIDDER_CREDIT_CODE = new Field("BIDDER_CREDIT_CODE", "BH_SEND_CLAIM_FORM", "投标人统一社会信用代码证号");
			/// <summary>
			/// 投标人联系人
			/// </summary>
			public readonly static Field BIDDER_CONTACT_NAME = new Field("BIDDER_CONTACT_NAME", "BH_SEND_CLAIM_FORM", "投标人联系人");
			/// <summary>
			/// 投标人联系电话
			/// </summary>
			public readonly static Field BIDDER_CONTACT_TEL = new Field("BIDDER_CONTACT_TEL", "BH_SEND_CLAIM_FORM", "投标人联系电话");
			/// <summary>
			/// 投标人地址
			/// </summary>
			public readonly static Field BIDDER_ADDRESS = new Field("BIDDER_ADDRESS", "BH_SEND_CLAIM_FORM", "投标人地址");
			/// <summary>
			/// 投标人纳税人识别号
			/// </summary>
			public readonly static Field BIDDER_TAXPAYER_CODE = new Field("BIDDER_TAXPAYER_CODE", "BH_SEND_CLAIM_FORM", "投标人纳税人识别号");
			/// <summary>
			/// 投标人法人姓名
			/// </summary>
			public readonly static Field LEGAL_PERSON_NAME = new Field("LEGAL_PERSON_NAME", "BH_SEND_CLAIM_FORM", "投标人法人姓名");
			/// <summary>
			/// 投标人法人联系方式
			/// </summary>
			public readonly static Field LEGAL_PERSON_TEL = new Field("LEGAL_PERSON_TEL", "BH_SEND_CLAIM_FORM", "投标人法人联系方式");
			/// <summary>
			/// 索赔人名称
			/// </summary>
			public readonly static Field CLAIM_NAME = new Field("CLAIM_NAME", "BH_SEND_CLAIM_FORM", "索赔人名称");
			/// <summary>
			/// 索赔人统一社会信用代码证号
			/// </summary>
			public readonly static Field CLAIM_CREDIT_CODE = new Field("CLAIM_CREDIT_CODE", "BH_SEND_CLAIM_FORM", "索赔人统一社会信用代码证号");
			/// <summary>
			/// 索赔人手机号
			/// </summary>
			public readonly static Field CLAIM_TEL = new Field("CLAIM_TEL", "BH_SEND_CLAIM_FORM", "索赔人手机号");
			/// <summary>
			/// 索赔人邮箱
			/// </summary>
			public readonly static Field CLAIM_EMAIL = new Field("CLAIM_EMAIL", "BH_SEND_CLAIM_FORM", "索赔人邮箱");
			/// <summary>
			/// 索赔金额
			/// </summary>
			public readonly static Field CLAIM_AMOUNT = new Field("CLAIM_AMOUNT", "BH_SEND_CLAIM_FORM", "索赔金额");
			/// <summary>
			/// 索赔理由
			/// </summary>
			public readonly static Field CLAIM_REASON = new Field("CLAIM_REASON", "BH_SEND_CLAIM_FORM", "索赔理由");
			/// <summary>
			/// 保函单号
			/// </summary>
			public readonly static Field GUARANTEE_NO = new Field("GUARANTEE_NO", "BH_SEND_CLAIM_FORM", "保函单号");
			/// <summary>
			/// 投保人邮箱
			/// </summary>
			public readonly static Field BIDDER_EAMIL = new Field("BIDDER_EAMIL", "BH_SEND_CLAIM_FORM", "投保人邮箱");
			/// <summary>
			/// 投保人法人身份证号
			/// </summary>
			public readonly static Field LEGAL_PERSON_IDCARD = new Field("LEGAL_PERSON_IDCARD", "BH_SEND_CLAIM_FORM", "投保人法人身份证号");
			/// <summary>
			/// 附件下载地址，此文件为压缩包
			/// </summary>
			public readonly static Field CLIAM_ATTACHMENT_URL = new Field("CLIAM_ATTACHMENT_URL", "BH_SEND_CLAIM_FORM", "附件下载地址，此文件为压缩包");
			/// <summary>
			/// 附件md5
			/// </summary>
			public readonly static Field CLIAM_ATTACHMENT_MD5 = new Field("CLIAM_ATTACHMENT_MD5", "BH_SEND_CLAIM_FORM", "附件md5");
			/// <summary>
			/// 附件id
			/// </summary>
			public readonly static Field CLIAM_ATTACHMENT_AID = new Field("CLIAM_ATTACHMENT_AID", "BH_SEND_CLAIM_FORM", "附件id");
			/// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "BH_SEND_CLAIM_FORM", "创建时间");
			/// <summary>
			/// 创建用户id
			/// </summary>
			public readonly static Field USER_ID = new Field("USER_ID", "BH_SEND_CLAIM_FORM", "创建用户id");
		}
		#endregion

        public override string GetSequence()
        {
            return "SEQ_BH_SEND_CLAIM_FORM";
        }

        public override Field GetIdentityField()
        {
            return _.M_ID;
        }
	}
}