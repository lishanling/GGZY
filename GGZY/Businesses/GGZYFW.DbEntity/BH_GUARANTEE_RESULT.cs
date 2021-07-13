using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
	/// <summary>
	/// 实体类BH_GUARANTEE_RESULT。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("BH_GUARANTEE_RESULT")]
	[Serializable]
	public partial class BH_GUARANTEE_RESULT : FwEntity
	{
		#region Model
		private int _ID;
		private string _ORDER_ID;
		private DateTime _SERVICE_BEGIN_TIME;
		private DateTime _SERVICE_END_TIME;
		private decimal? _BID_BOND;
		private decimal? _AMOUNT;
		private decimal? _RATE;
		private string _GUARANTEE_NO;
		private string _PAY_ACCOUNT;
		private string _PAY_TYPE;
		private decimal? _AUDIT_TYPE;
		private string _AUDIT_REMARK;
		private string _GUARANTEE_FILE_NAME;
		private string _GUARANTEE_PDF_MD5;
		private string _GUARANTEE_PDF_URL;
		private string _SECRET;
		private string _M_DATA_KEY;
		private string _GUARANTEE_SOURCE_URL;
		private string _GUARANTEE_SOURCE_MD5;
		private string _GUARANTEE_SOURCE_CATYPE;
		private DateTime _CREATE_TIME;
		private string _GUARANTEE_URL;
		private string _GUARANTEE_MD5;
		private string _WARRANTY_URL;
		private string _WARRANTY_MD5;
		private string _WARRANTY_FILE_NAME;
		private string _WARRANTY_PDF_URL;
		private string _WARRANTY_PDF_MD5;
		private string _GUARANTEE_XML_URL;
		private string _GUARANTEE_XML_MD5;

		/// <summary>
		/// 自增长
		/// </summary>
		public int ID
		{
			get { return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
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
		/// 保函开始日期(默认为开标日期)
		/// </summary>
		public DateTime SERVICE_BEGIN_TIME
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
		public DateTime SERVICE_END_TIME
		{
			get { return _SERVICE_END_TIME; }
			set
			{
				this.OnPropertyValueChange(_.SERVICE_END_TIME, _SERVICE_END_TIME, value);
				this._SERVICE_END_TIME = value;
			}
		}
		/// <summary>
		/// 担保额度（保证金要求数额）(元)
		/// </summary>
		public decimal? BID_BOND
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
		public decimal? AMOUNT
		{
			get { return _AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.AMOUNT, _AMOUNT, value);
				this._AMOUNT = value;
			}
		}
		/// <summary>
		/// 费率（百分号）
		/// </summary>
		public decimal? RATE
		{
			get { return _RATE; }
			set
			{
				this.OnPropertyValueChange(_.RATE, _RATE, value);
				this._RATE = value;
			}
		}
		/// <summary>
		/// 保函单号，审核不通过可不填
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
		/// 支付账号
		/// </summary>
		public string PAY_ACCOUNT
		{
			get { return _PAY_ACCOUNT; }
			set
			{
				this.OnPropertyValueChange(_.PAY_ACCOUNT, _PAY_ACCOUNT, value);
				this._PAY_ACCOUNT = value;
			}
		}
		/// <summary>
		/// 支付方式,见字典5.2
		/// </summary>
		public string PAY_TYPE
		{
			get { return _PAY_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.PAY_TYPE, _PAY_TYPE, value);
				this._PAY_TYPE = value;
			}
		}
		/// <summary>
		/// _1通过 0不通过
		/// </summary>
		public decimal? AUDIT_TYPE
		{
			get { return _AUDIT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.AUDIT_TYPE, _AUDIT_TYPE, value);
				this._AUDIT_TYPE = value;
			}
		}
		/// <summary>
		/// 审核结果说明，如为何不通过
		/// </summary>
		public string AUDIT_REMARK
		{
			get { return _AUDIT_REMARK; }
			set
			{
				this.OnPropertyValueChange(_.AUDIT_REMARK, _AUDIT_REMARK, value);
				this._AUDIT_REMARK = value;
			}
		}
		/// <summary>
		/// 电子保函文件名
		/// </summary>
		public string GUARANTEE_FILE_NAME
		{
			get { return _GUARANTEE_FILE_NAME; }
			set
			{
				this.OnPropertyValueChange(_.GUARANTEE_FILE_NAME, _GUARANTEE_FILE_NAME, value);
				this._GUARANTEE_FILE_NAME = value;
			}
		}
		/// <summary>
		/// 电子保函原件pdf文件大写MD5
		/// </summary>
		public string GUARANTEE_PDF_MD5
		{
			get { return _GUARANTEE_PDF_MD5; }
			set
			{
				this.OnPropertyValueChange(_.GUARANTEE_PDF_MD5, _GUARANTEE_PDF_MD5, value);
				this._GUARANTEE_PDF_MD5 = value;
			}
		}
		/// <summary>
		/// 电子保函pdf文件下载地址
		/// </summary>
		public string GUARANTEE_PDF_URL
		{
			get { return _GUARANTEE_PDF_URL; }
			set
			{
				this.OnPropertyValueChange(_.GUARANTEE_PDF_URL, _GUARANTEE_PDF_URL, value);
				this._GUARANTEE_PDF_URL = value;
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
		/// 数据唯一标识
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
		/// 电子保函原文件下载地址
		/// </summary>
		public string GUARANTEE_SOURCE_URL
		{
			get { return _GUARANTEE_SOURCE_URL; }
			set
			{
				this.OnPropertyValueChange(_.GUARANTEE_SOURCE_URL, _GUARANTEE_SOURCE_URL, value);
				this._GUARANTEE_SOURCE_URL = value;
			}
		}
		/// <summary>
		/// 电子保函原文件md5
		/// </summary>
		public string GUARANTEE_SOURCE_MD5
		{
			get { return _GUARANTEE_SOURCE_MD5; }
			set
			{
				this.OnPropertyValueChange(_.GUARANTEE_SOURCE_MD5, _GUARANTEE_SOURCE_MD5, value);
				this._GUARANTEE_SOURCE_MD5 = value;
			}
		}
		/// <summary>
		/// 电子保函原文件下载
		/// </summary>
		public string GUARANTEE_SOURCE_CATYPE
		{
			get { return _GUARANTEE_SOURCE_CATYPE; }
			set
			{
				this.OnPropertyValueChange(_.GUARANTEE_SOURCE_CATYPE, _GUARANTEE_SOURCE_CATYPE, value);
				this._GUARANTEE_SOURCE_CATYPE = value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime CREATE_TIME
		{
			get { return _CREATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
				this._CREATE_TIME = value;
			}
		}
		/// <summary>
		/// 电子保函原文件下载地址
		/// </summary>
		public string GUARANTEE_URL
		{
			get { return _GUARANTEE_URL; }
			set
			{
				this.OnPropertyValueChange(_.GUARANTEE_URL, _GUARANTEE_URL, value);
				this._GUARANTEE_URL = value;
			}
		}
		/// <summary>
		/// 电子保函原文件大写MD5
		/// </summary>
		public string GUARANTEE_MD5
		{
			get { return _GUARANTEE_MD5; }
			set
			{
				this.OnPropertyValueChange(_.GUARANTEE_MD5, _GUARANTEE_MD5, value);
				this._GUARANTEE_MD5 = value;
			}
		}
		/// <summary>
		/// 电子保单原文件下载地址
		/// </summary>
		public string WARRANTY_URL
		{
			get { return _WARRANTY_URL; }
			set
			{
				this.OnPropertyValueChange(_.WARRANTY_URL, _WARRANTY_URL, value);
				this._WARRANTY_URL = value;
			}
		}
		/// <summary>
		/// 电子保单原文件大写MD5
		/// </summary>
		public string WARRANTY_MD5
		{
			get { return _WARRANTY_MD5; }
			set
			{
				this.OnPropertyValueChange(_.WARRANTY_MD5, _WARRANTY_MD5, value);
				this._WARRANTY_MD5 = value;
			}
		}
		/// <summary>
		/// 电子保单原文件名
		/// </summary>
		public string WARRANTY_FILE_NAME
		{
			get { return _WARRANTY_FILE_NAME; }
			set
			{
				this.OnPropertyValueChange(_.WARRANTY_FILE_NAME, _WARRANTY_FILE_NAME, value);
				this._WARRANTY_FILE_NAME = value;
			}
		}
		/// <summary>
		/// 电子保单pdf文件名
		/// </summary>
		public string WARRANTY_PDF_URL
		{
			get { return _WARRANTY_PDF_URL; }
			set
			{
				this.OnPropertyValueChange(_.WARRANTY_PDF_URL, _WARRANTY_PDF_URL, value);
				this._WARRANTY_PDF_URL = value;
			}
		}
		/// <summary>
		/// 电子保单pdf文件大写MD5
		/// </summary>
		public string WARRANTY_PDF_MD5
		{
			get { return _WARRANTY_PDF_MD5; }
			set
			{
				this.OnPropertyValueChange(_.WARRANTY_PDF_MD5, _WARRANTY_PDF_MD5, value);
				this._WARRANTY_PDF_MD5 = value;
			}
		}
		/// <summary>
		/// XML数据下载地址
		/// </summary>
		public string GUARANTEE_XML_URL
		{
			get { return _GUARANTEE_XML_URL; }
			set
			{
				this.OnPropertyValueChange(_.GUARANTEE_XML_URL, _GUARANTEE_XML_URL, value);
				this._GUARANTEE_XML_URL = value;
			}
		}
		/// <summary>
		/// XML数据md5
		/// </summary>
		public string GUARANTEE_XML_MD5
		{
			get { return _GUARANTEE_XML_MD5; }
			set
			{
				this.OnPropertyValueChange(_.GUARANTEE_XML_MD5, _GUARANTEE_XML_MD5, value);
				this._GUARANTEE_XML_MD5 = value;
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
				_.ID,
				_.ORDER_ID,
				_.SERVICE_BEGIN_TIME,
				_.SERVICE_END_TIME,
				_.BID_BOND,
				_.AMOUNT,
				_.RATE,
				_.GUARANTEE_NO,
				_.PAY_ACCOUNT,
				_.PAY_TYPE,
				_.AUDIT_TYPE,
				_.AUDIT_REMARK,
				_.GUARANTEE_FILE_NAME,
				_.GUARANTEE_PDF_MD5,
				_.GUARANTEE_PDF_URL,
				_.SECRET,
				_.M_DATA_KEY,
				_.GUARANTEE_SOURCE_URL,
				_.GUARANTEE_SOURCE_MD5,
				_.GUARANTEE_SOURCE_CATYPE,
				_.CREATE_TIME,
				_.GUARANTEE_URL,
				_.GUARANTEE_MD5,
				_.WARRANTY_URL,
				_.WARRANTY_MD5,
				_.WARRANTY_FILE_NAME,
				_.WARRANTY_PDF_URL,
				_.WARRANTY_PDF_MD5,
				_.GUARANTEE_XML_URL,
				_.GUARANTEE_XML_MD5,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ID,
				this._ORDER_ID,
				this._SERVICE_BEGIN_TIME,
				this._SERVICE_END_TIME,
				this._BID_BOND,
				this._AMOUNT,
				this._RATE,
				this._GUARANTEE_NO,
				this._PAY_ACCOUNT,
				this._PAY_TYPE,
				this._AUDIT_TYPE,
				this._AUDIT_REMARK,
				this._GUARANTEE_FILE_NAME,
				this._GUARANTEE_PDF_MD5,
				this._GUARANTEE_PDF_URL,
				this._SECRET,
				this._M_DATA_KEY,
				this._GUARANTEE_SOURCE_URL,
				this._GUARANTEE_SOURCE_MD5,
				this._GUARANTEE_SOURCE_CATYPE,
				this._CREATE_TIME,
				this._GUARANTEE_URL,
				this._GUARANTEE_MD5,
				this._WARRANTY_URL,
				this._WARRANTY_MD5,
				this._WARRANTY_FILE_NAME,
				this._WARRANTY_PDF_URL,
				this._WARRANTY_PDF_MD5,
				this._GUARANTEE_XML_URL,
				this._GUARANTEE_XML_MD5,
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
			public readonly static Field All = new Field("*", "BH_GUARANTEE_RESULT");
			/// <summary>
			/// 自增长
			/// </summary>
			public readonly static Field ID = new Field("ID", "BH_GUARANTEE_RESULT", "自增长");
			/// <summary>
			/// 订单号(唯一)
			/// </summary>
			public readonly static Field ORDER_ID = new Field("ORDER_ID", "BH_GUARANTEE_RESULT", "订单号(唯一)");
			/// <summary>
			/// 保函开始日期(默认为开标日期)
			/// </summary>
			public readonly static Field SERVICE_BEGIN_TIME = new Field("SERVICE_BEGIN_TIME", "BH_GUARANTEE_RESULT", "保函开始日期(默认为开标日期)");
			/// <summary>
			/// 保函截止日期(默认为开标日期后顺延28日历天)
			/// </summary>
			public readonly static Field SERVICE_END_TIME = new Field("SERVICE_END_TIME", "BH_GUARANTEE_RESULT", "保函截止日期(默认为开标日期后顺延28日历天)");
			/// <summary>
			/// 担保额度（保证金要求数额）(元)
			/// </summary>
			public readonly static Field BID_BOND = new Field("BID_BOND", "BH_GUARANTEE_RESULT", "担保额度（保证金要求数额）(元)");
			/// <summary>
			/// 保费（元）
			/// </summary>
			public readonly static Field AMOUNT = new Field("AMOUNT", "BH_GUARANTEE_RESULT", "保费（元）");
			/// <summary>
			/// 费率（百分号）
			/// </summary>
			public readonly static Field RATE = new Field("RATE", "BH_GUARANTEE_RESULT", "费率（百分号）");
			/// <summary>
			/// 保函单号，审核不通过可不填
			/// </summary>
			public readonly static Field GUARANTEE_NO = new Field("GUARANTEE_NO", "BH_GUARANTEE_RESULT", "保函单号，审核不通过可不填");
			/// <summary>
			/// 支付账号
			/// </summary>
			public readonly static Field PAY_ACCOUNT = new Field("PAY_ACCOUNT", "BH_GUARANTEE_RESULT", "支付账号");
			/// <summary>
			/// 支付方式,见字典5.2
			/// </summary>
			public readonly static Field PAY_TYPE = new Field("PAY_TYPE", "BH_GUARANTEE_RESULT", "支付方式,见字典5.2");
			/// <summary>
			/// _1通过 0不通过
			/// </summary>
			public readonly static Field AUDIT_TYPE = new Field("AUDIT_TYPE", "BH_GUARANTEE_RESULT", "_1通过 0不通过");
			/// <summary>
			/// 审核结果说明，如为何不通过
			/// </summary>
			public readonly static Field AUDIT_REMARK = new Field("AUDIT_REMARK", "BH_GUARANTEE_RESULT", "审核结果说明，如为何不通过");
			/// <summary>
			/// 电子保函文件名
			/// </summary>
			public readonly static Field GUARANTEE_FILE_NAME = new Field("GUARANTEE_FILE_NAME", "BH_GUARANTEE_RESULT", "电子保函文件名");
			/// <summary>
			/// 电子保函原件pdf文件大写MD5
			/// </summary>
			public readonly static Field GUARANTEE_PDF_MD5 = new Field("GUARANTEE_PDF_MD5", "BH_GUARANTEE_RESULT", "电子保函原件pdf文件大写MD5");
			/// <summary>
			/// 电子保函pdf文件下载地址
			/// </summary>
			public readonly static Field GUARANTEE_PDF_URL = new Field("GUARANTEE_PDF_URL", "BH_GUARANTEE_RESULT", "电子保函pdf文件下载地址");
			/// <summary>
			/// 数字信封
			/// </summary>
			public readonly static Field SECRET = new Field("SECRET", "BH_GUARANTEE_RESULT", "数字信封");
			/// <summary>
			/// 数据唯一标识
			/// </summary>
			public readonly static Field M_DATA_KEY = new Field("M_DATA_KEY", "BH_GUARANTEE_RESULT", "数据唯一标识");
			/// <summary>
			/// 电子保函原文件下载地址
			/// </summary>
			public readonly static Field GUARANTEE_SOURCE_URL = new Field("GUARANTEE_SOURCE_URL", "BH_GUARANTEE_RESULT", "电子保函原文件下载地址");
			/// <summary>
			/// 电子保函原文件md5
			/// </summary>
			public readonly static Field GUARANTEE_SOURCE_MD5 = new Field("GUARANTEE_SOURCE_MD5", "BH_GUARANTEE_RESULT", "电子保函原文件md5");
			/// <summary>
			/// 电子保函原文件下载
			/// </summary>
			public readonly static Field GUARANTEE_SOURCE_CATYPE = new Field("GUARANTEE_SOURCE_CATYPE", "BH_GUARANTEE_RESULT", "电子保函原文件下载");
			/// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "BH_GUARANTEE_RESULT", "创建时间");
			/// <summary>
			/// 电子保函原文件下载地址
			/// </summary>
			public readonly static Field GUARANTEE_URL = new Field("GUARANTEE_URL", "BH_GUARANTEE_RESULT", "电子保函原文件下载地址");
			/// <summary>
			/// 电子保函原文件大写MD5
			/// </summary>
			public readonly static Field GUARANTEE_MD5 = new Field("GUARANTEE_MD5", "BH_GUARANTEE_RESULT", "电子保函原文件大写MD5");
			/// <summary>
			/// 电子保单原文件下载地址
			/// </summary>
			public readonly static Field WARRANTY_URL = new Field("WARRANTY_URL", "BH_GUARANTEE_RESULT", "电子保单原文件下载地址");
			/// <summary>
			/// 电子保单原文件大写MD5
			/// </summary>
			public readonly static Field WARRANTY_MD5 = new Field("WARRANTY_MD5", "BH_GUARANTEE_RESULT", "电子保单原文件大写MD5");
			/// <summary>
			/// 电子保单原文件名
			/// </summary>
			public readonly static Field WARRANTY_FILE_NAME = new Field("WARRANTY_FILE_NAME", "BH_GUARANTEE_RESULT", "电子保单原文件名");
			/// <summary>
			/// 电子保单pdf文件名
			/// </summary>
			public readonly static Field WARRANTY_PDF_URL = new Field("WARRANTY_PDF_URL", "BH_GUARANTEE_RESULT", "电子保单pdf文件名");
			/// <summary>
			/// 电子保单pdf文件大写MD5
			/// </summary>
			public readonly static Field WARRANTY_PDF_MD5 = new Field("WARRANTY_PDF_MD5", "BH_GUARANTEE_RESULT", "电子保单pdf文件大写MD5");
			/// <summary>
			/// XML数据下载地址
			/// </summary>
			public readonly static Field GUARANTEE_XML_URL = new Field("GUARANTEE_XML_URL", "BH_GUARANTEE_RESULT", "XML数据下载地址");
			/// <summary>
			/// XML数据md5
			/// </summary>
			public readonly static Field GUARANTEE_XML_MD5 = new Field("GUARANTEE_XML_MD5", "BH_GUARANTEE_RESULT", "XML数据md5");
		}
		#endregion

		public override string GetSequence()
        {
            return "SEQ_BH_RECEIVE_GUARANTEE_RES";
        }

        public override Field GetIdentityField()
        {
            return _.ID;
        }
    }
}