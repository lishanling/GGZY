using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类ZJ_LETTER_OF_GUARANTEE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJ_LETTER_OF_GUARANTEE")]
    [Serializable]
    public partial class ZJ_LETTER_OF_GUARANTEE : JdEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private string _UNIFIED_DEAL_CODE;
		private string _BIDDER_NAME;
		private string _BIDDER_ORG_CODE;
		private string _UNION_ENTERPRISE_NAME;
		private string _UNION_ORGAN_SET_CODE;
		private decimal? _GUARANTEE_FORM;
		private decimal? _GUARANTEE_TYPE;
		private string _GUARANTEE_NO;
		private string _GUARANTEE_STATUS;
		private string _BENEFICIARY;
		private string _INSURER;
		private decimal? _GUARANTEE_AMOUNT;
		private decimal? _GUARANTEE_COST;
		private DateTime? _CREATE_TIME;
		private DateTime? _BEGIN_TIME;
		private DateTime? _END_TIME;
		private string _PAYMENT_METHOD;
		private DateTime? _PAYMENT_TIME;
		private DateTime? _LETTER_TIME;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;
		private string _M_VERSION;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_CREATOR;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _M_ATT_GUARANTEE_FILE;
		private string _PROPOSER;
		private string _PROPOSER_PHONE;
		private string _PROPOSER_CARD_TYPE;
		private string _PROPOSER_CODE;
		private string _PURCHASE_ACCOUN;
		private decimal? _RATE;
		private string _GUARANTEE_URL;
		private string _GUARANTEE_MD5;

		/// <summary>
		/// 
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
		/// <summary>
		/// 招标项目编号
		/// </summary>
		public string TENDER_PROJECT_CODE
		{
			get{ return _TENDER_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_CODE, _TENDER_PROJECT_CODE, value);
				this._TENDER_PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 标段（包）编号
		/// </summary>
		public string BID_SECTION_CODE
		{
			get{ return _BID_SECTION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_CODE, _BID_SECTION_CODE, value);
				this._BID_SECTION_CODE = value;
			}
		}
		/// <summary>
		/// 统一交易标识码
		/// </summary>
		public string UNIFIED_DEAL_CODE
		{
			get{ return _UNIFIED_DEAL_CODE; }
			set
			{
				this.OnPropertyValueChange(_.UNIFIED_DEAL_CODE, _UNIFIED_DEAL_CODE, value);
				this._UNIFIED_DEAL_CODE = value;
			}
		}
		/// <summary>
		/// 投标人名称
		/// </summary>
		public string BIDDER_NAME
		{
			get{ return _BIDDER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_NAME, _BIDDER_NAME, value);
				this._BIDDER_NAME = value;
			}
		}
		/// <summary>
		/// 投标人代码
		/// </summary>
		public string BIDDER_ORG_CODE
		{
			get{ return _BIDDER_ORG_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_ORG_CODE, _BIDDER_ORG_CODE, value);
				this._BIDDER_ORG_CODE = value;
			}
		}
		/// <summary>
		/// 联合体名称（如有）
		/// </summary>
		public string UNION_ENTERPRISE_NAME
		{
			get{ return _UNION_ENTERPRISE_NAME; }
			set
			{
				this.OnPropertyValueChange(_.UNION_ENTERPRISE_NAME, _UNION_ENTERPRISE_NAME, value);
				this._UNION_ENTERPRISE_NAME = value;
			}
		}
		/// <summary>
		/// 联合体组织机构代码证（联合体招标时填写）
		/// </summary>
		public string UNION_ORGAN_SET_CODE
		{
			get{ return _UNION_ORGAN_SET_CODE; }
			set
			{
				this.OnPropertyValueChange(_.UNION_ORGAN_SET_CODE, _UNION_ORGAN_SET_CODE, value);
				this._UNION_ORGAN_SET_CODE = value;
			}
		}
		/// <summary>
		/// 保函形式
		/// </summary>
		public decimal? GUARANTEE_FORM
		{
			get{ return _GUARANTEE_FORM; }
			set
			{
				this.OnPropertyValueChange(_.GUARANTEE_FORM, _GUARANTEE_FORM, value);
				this._GUARANTEE_FORM = value;
			}
		}
		/// <summary>
		/// 保函类型
		/// </summary>
		public decimal? GUARANTEE_TYPE
		{
			get{ return _GUARANTEE_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.GUARANTEE_TYPE, _GUARANTEE_TYPE, value);
				this._GUARANTEE_TYPE = value;
			}
		}
		/// <summary>
		/// 保函编号
		/// </summary>
		public string GUARANTEE_NO
		{
			get{ return _GUARANTEE_NO; }
			set
			{
				this.OnPropertyValueChange(_.GUARANTEE_NO, _GUARANTEE_NO, value);
				this._GUARANTEE_NO = value;
			}
		}
		/// <summary>
		/// 保函状态
		/// </summary>
		public string GUARANTEE_STATUS
		{
			get{ return _GUARANTEE_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.GUARANTEE_STATUS, _GUARANTEE_STATUS, value);
				this._GUARANTEE_STATUS = value;
			}
		}
		/// <summary>
		/// 受益人
		/// </summary>
		public string BENEFICIARY
		{
			get{ return _BENEFICIARY; }
			set
			{
				this.OnPropertyValueChange(_.BENEFICIARY, _BENEFICIARY, value);
				this._BENEFICIARY = value;
			}
		}
		/// <summary>
		/// 承保人
		/// </summary>
		public string INSURER
		{
			get{ return _INSURER; }
			set
			{
				this.OnPropertyValueChange(_.INSURER, _INSURER, value);
				this._INSURER = value;
			}
		}
		/// <summary>
		/// 担保金额
		/// </summary>
		public decimal? GUARANTEE_AMOUNT
		{
			get{ return _GUARANTEE_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.GUARANTEE_AMOUNT, _GUARANTEE_AMOUNT, value);
				this._GUARANTEE_AMOUNT = value;
			}
		}
		/// <summary>
		/// 担保费用
		/// </summary>
		public decimal? GUARANTEE_COST
		{
			get{ return _GUARANTEE_COST; }
			set
			{
				this.OnPropertyValueChange(_.GUARANTEE_COST, _GUARANTEE_COST, value);
				this._GUARANTEE_COST = value;
			}
		}
		/// <summary>
		/// 保函创建时间
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
		/// 担保开始时间
		/// </summary>
		public DateTime? BEGIN_TIME
		{
			get{ return _BEGIN_TIME; }
			set
			{
				this.OnPropertyValueChange(_.BEGIN_TIME, _BEGIN_TIME, value);
				this._BEGIN_TIME = value;
			}
		}
		/// <summary>
		/// 担保结束时间
		/// </summary>
		public DateTime? END_TIME
		{
			get{ return _END_TIME; }
			set
			{
				this.OnPropertyValueChange(_.END_TIME, _END_TIME, value);
				this._END_TIME = value;
			}
		}
		/// <summary>
		/// 支付方式
		/// </summary>
		public string PAYMENT_METHOD
		{
			get{ return _PAYMENT_METHOD; }
			set
			{
				this.OnPropertyValueChange(_.PAYMENT_METHOD, _PAYMENT_METHOD, value);
				this._PAYMENT_METHOD = value;
			}
		}
		/// <summary>
		/// 支付时间
		/// </summary>
		public DateTime? PAYMENT_TIME
		{
			get{ return _PAYMENT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.PAYMENT_TIME, _PAYMENT_TIME, value);
				this._PAYMENT_TIME = value;
			}
		}
		/// <summary>
		/// 出函时间
		/// </summary>
		public DateTime? LETTER_TIME
		{
			get{ return _LETTER_TIME; }
			set
			{
				this.OnPropertyValueChange(_.LETTER_TIME, _LETTER_TIME, value);
				this._LETTER_TIME = value;
			}
		}
		/// <summary>
		/// 交易系统标识码
		/// </summary>
		public string PLATFORM_CODE
		{
			get{ return _PLATFORM_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PLATFORM_CODE, _PLATFORM_CODE, value);
				this._PLATFORM_CODE = value;
			}
		}
		/// <summary>
		/// 交易服务系统标识码
		/// </summary>
		public string PUB_SERVICE_PLAT_CODE
		{
			get{ return _PUB_SERVICE_PLAT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PUB_SERVICE_PLAT_CODE, _PUB_SERVICE_PLAT_CODE, value);
				this._PUB_SERVICE_PLAT_CODE = value;
			}
		}
		/// <summary>
		/// 数据时间戳
		/// </summary>
		public DateTime? DATA_TIMESTAMP
		{
			get{ return _DATA_TIMESTAMP; }
			set
			{
				this.OnPropertyValueChange(_.DATA_TIMESTAMP, _DATA_TIMESTAMP, value);
				this._DATA_TIMESTAMP = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TRADE_PLAT
		{
			get{ return _TRADE_PLAT; }
			set
			{
				this.OnPropertyValueChange(_.TRADE_PLAT, _TRADE_PLAT, value);
				this._TRADE_PLAT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PUB_SERVICE_PLAT
		{
			get{ return _PUB_SERVICE_PLAT; }
			set
			{
				this.OnPropertyValueChange(_.PUB_SERVICE_PLAT, _PUB_SERVICE_PLAT, value);
				this._PUB_SERVICE_PLAT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_VERSION
		{
			get{ return _M_VERSION; }
			set
			{
				this.OnPropertyValueChange(_.M_VERSION, _M_VERSION, value);
				this._M_VERSION = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DATA_KEY
		{
			get{ return _DATA_KEY; }
			set
			{
				this.OnPropertyValueChange(_.DATA_KEY, _DATA_KEY, value);
				this._DATA_KEY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_DATA_SOURCE
		{
			get{ return _M_DATA_SOURCE; }
			set
			{
				this.OnPropertyValueChange(_.M_DATA_SOURCE, _M_DATA_SOURCE, value);
				this._M_DATA_SOURCE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? M_TM
		{
			get{ return _M_TM; }
			set
			{
				this.OnPropertyValueChange(_.M_TM, _M_TM, value);
				this._M_TM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? M_CREATOR
		{
			get{ return _M_CREATOR; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATOR, _M_CREATOR, value);
				this._M_CREATOR = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? M_IS_HISTORY
		{
			get{ return _M_IS_HISTORY; }
			set
			{
				this.OnPropertyValueChange(_.M_IS_HISTORY, _M_IS_HISTORY, value);
				this._M_IS_HISTORY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? M_CREATEBY
		{
			get{ return _M_CREATEBY; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATEBY, _M_CREATEBY, value);
				this._M_CREATEBY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? M_CREATE_TM
		{
			get{ return _M_CREATE_TM; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATE_TM, _M_CREATE_TM, value);
				this._M_CREATE_TM = value;
			}
		}
		/// <summary>
		/// 电子保函附件
		/// </summary>
		public string M_ATT_GUARANTEE_FILE
		{
			get{ return _M_ATT_GUARANTEE_FILE; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_GUARANTEE_FILE, _M_ATT_GUARANTEE_FILE, value);
				this._M_ATT_GUARANTEE_FILE = value;
			}
		}
		/// <summary>
		/// 申请人员
		/// </summary>
		public string PROPOSER
		{
			get{ return _PROPOSER; }
			set
			{
				this.OnPropertyValueChange(_.PROPOSER, _PROPOSER, value);
				this._PROPOSER = value;
			}
		}
		/// <summary>
		/// 申请人员联系方式
		/// </summary>
		public string PROPOSER_PHONE
		{
			get{ return _PROPOSER_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.PROPOSER_PHONE, _PROPOSER_PHONE, value);
				this._PROPOSER_PHONE = value;
			}
		}
		/// <summary>
		/// 证件类型
		/// </summary>
		public string PROPOSER_CARD_TYPE
		{
			get{ return _PROPOSER_CARD_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.PROPOSER_CARD_TYPE, _PROPOSER_CARD_TYPE, value);
				this._PROPOSER_CARD_TYPE = value;
			}
		}
		/// <summary>
		/// 证件号码
		/// </summary>
		public string PROPOSER_CODE
		{
			get{ return _PROPOSER_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PROPOSER_CODE, _PROPOSER_CODE, value);
				this._PROPOSER_CODE = value;
			}
		}
		/// <summary>
		/// 支付账号
		/// </summary>
		public string PURCHASE_ACCOUN
		{
			get{ return _PURCHASE_ACCOUN; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASE_ACCOUN, _PURCHASE_ACCOUN, value);
				this._PURCHASE_ACCOUN = value;
			}
		}
		/// <summary>
		/// 费率
		/// </summary>
		public decimal? RATE
		{
			get{ return _RATE; }
			set
			{
				this.OnPropertyValueChange(_.RATE, _RATE, value);
				this._RATE = value;
			}
		}
		/// <summary>
		/// 电子保单文件下载地址
		/// </summary>
		public string GUARANTEE_URL
		{
			get{ return _GUARANTEE_URL; }
			set
			{
				this.OnPropertyValueChange(_.GUARANTEE_URL, _GUARANTEE_URL, value);
				this._GUARANTEE_URL = value;
			}
		}
		/// <summary>
		/// 电子保单文件md5码
		/// </summary>
		public string GUARANTEE_MD5
		{
			get{ return _GUARANTEE_MD5; }
			set
			{
				this.OnPropertyValueChange(_.GUARANTEE_MD5, _GUARANTEE_MD5, value);
				this._GUARANTEE_MD5 = value;
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
				_.TENDER_PROJECT_CODE,
				_.BID_SECTION_CODE,
				_.UNIFIED_DEAL_CODE,
				_.BIDDER_NAME,
				_.BIDDER_ORG_CODE,
				_.UNION_ENTERPRISE_NAME,
				_.UNION_ORGAN_SET_CODE,
				_.GUARANTEE_FORM,
				_.GUARANTEE_TYPE,
				_.GUARANTEE_NO,
				_.GUARANTEE_STATUS,
				_.BENEFICIARY,
				_.INSURER,
				_.GUARANTEE_AMOUNT,
				_.GUARANTEE_COST,
				_.CREATE_TIME,
				_.BEGIN_TIME,
				_.END_TIME,
				_.PAYMENT_METHOD,
				_.PAYMENT_TIME,
				_.LETTER_TIME,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.TRADE_PLAT,
				_.PUB_SERVICE_PLAT,
				_.M_VERSION,
				_.DATA_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_CREATOR,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_ATT_GUARANTEE_FILE,
				_.PROPOSER,
				_.PROPOSER_PHONE,
				_.PROPOSER_CARD_TYPE,
				_.PROPOSER_CODE,
				_.PURCHASE_ACCOUN,
				_.RATE,
				_.GUARANTEE_URL,
				_.GUARANTEE_MD5,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._M_ID,
				this._TENDER_PROJECT_CODE,
				this._BID_SECTION_CODE,
				this._UNIFIED_DEAL_CODE,
				this._BIDDER_NAME,
				this._BIDDER_ORG_CODE,
				this._UNION_ENTERPRISE_NAME,
				this._UNION_ORGAN_SET_CODE,
				this._GUARANTEE_FORM,
				this._GUARANTEE_TYPE,
				this._GUARANTEE_NO,
				this._GUARANTEE_STATUS,
				this._BENEFICIARY,
				this._INSURER,
				this._GUARANTEE_AMOUNT,
				this._GUARANTEE_COST,
				this._CREATE_TIME,
				this._BEGIN_TIME,
				this._END_TIME,
				this._PAYMENT_METHOD,
				this._PAYMENT_TIME,
				this._LETTER_TIME,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._TRADE_PLAT,
				this._PUB_SERVICE_PLAT,
				this._M_VERSION,
				this._DATA_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_CREATOR,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._M_ATT_GUARANTEE_FILE,
				this._PROPOSER,
				this._PROPOSER_PHONE,
				this._PROPOSER_CARD_TYPE,
				this._PROPOSER_CODE,
				this._PURCHASE_ACCOUN,
				this._RATE,
				this._GUARANTEE_URL,
				this._GUARANTEE_MD5,
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
			public readonly static Field All = new Field("*", "ZJ_LETTER_OF_GUARANTEE");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "ZJ_LETTER_OF_GUARANTEE", "");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "ZJ_LETTER_OF_GUARANTEE", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "ZJ_LETTER_OF_GUARANTEE", "标段（包）编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "ZJ_LETTER_OF_GUARANTEE", "统一交易标识码");
            /// <summary>
			/// 投标人名称
			/// </summary>
			public readonly static Field BIDDER_NAME = new Field("BIDDER_NAME", "ZJ_LETTER_OF_GUARANTEE", "投标人名称");
            /// <summary>
			/// 投标人代码
			/// </summary>
			public readonly static Field BIDDER_ORG_CODE = new Field("BIDDER_ORG_CODE", "ZJ_LETTER_OF_GUARANTEE", "投标人代码");
            /// <summary>
			/// 联合体名称（如有）
			/// </summary>
			public readonly static Field UNION_ENTERPRISE_NAME = new Field("UNION_ENTERPRISE_NAME", "ZJ_LETTER_OF_GUARANTEE", "联合体名称（如有）");
            /// <summary>
			/// 联合体组织机构代码证（联合体招标时填写）
			/// </summary>
			public readonly static Field UNION_ORGAN_SET_CODE = new Field("UNION_ORGAN_SET_CODE", "ZJ_LETTER_OF_GUARANTEE", "联合体组织机构代码证（联合体招标时填写）");
            /// <summary>
			/// 保函形式
			/// </summary>
			public readonly static Field GUARANTEE_FORM = new Field("GUARANTEE_FORM", "ZJ_LETTER_OF_GUARANTEE", "保函形式");
            /// <summary>
			/// 保函类型
			/// </summary>
			public readonly static Field GUARANTEE_TYPE = new Field("GUARANTEE_TYPE", "ZJ_LETTER_OF_GUARANTEE", "保函类型");
            /// <summary>
			/// 保函编号
			/// </summary>
			public readonly static Field GUARANTEE_NO = new Field("GUARANTEE_NO", "ZJ_LETTER_OF_GUARANTEE", "保函编号");
            /// <summary>
			/// 保函状态
			/// </summary>
			public readonly static Field GUARANTEE_STATUS = new Field("GUARANTEE_STATUS", "ZJ_LETTER_OF_GUARANTEE", "保函状态");
            /// <summary>
			/// 受益人
			/// </summary>
			public readonly static Field BENEFICIARY = new Field("BENEFICIARY", "ZJ_LETTER_OF_GUARANTEE", "受益人");
            /// <summary>
			/// 承保人
			/// </summary>
			public readonly static Field INSURER = new Field("INSURER", "ZJ_LETTER_OF_GUARANTEE", "承保人");
            /// <summary>
			/// 担保金额
			/// </summary>
			public readonly static Field GUARANTEE_AMOUNT = new Field("GUARANTEE_AMOUNT", "ZJ_LETTER_OF_GUARANTEE", "担保金额");
            /// <summary>
			/// 担保费用
			/// </summary>
			public readonly static Field GUARANTEE_COST = new Field("GUARANTEE_COST", "ZJ_LETTER_OF_GUARANTEE", "担保费用");
            /// <summary>
			/// 保函创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "ZJ_LETTER_OF_GUARANTEE", "保函创建时间");
            /// <summary>
			/// 担保开始时间
			/// </summary>
			public readonly static Field BEGIN_TIME = new Field("BEGIN_TIME", "ZJ_LETTER_OF_GUARANTEE", "担保开始时间");
            /// <summary>
			/// 担保结束时间
			/// </summary>
			public readonly static Field END_TIME = new Field("END_TIME", "ZJ_LETTER_OF_GUARANTEE", "担保结束时间");
            /// <summary>
			/// 支付方式
			/// </summary>
			public readonly static Field PAYMENT_METHOD = new Field("PAYMENT_METHOD", "ZJ_LETTER_OF_GUARANTEE", "支付方式");
            /// <summary>
			/// 支付时间
			/// </summary>
			public readonly static Field PAYMENT_TIME = new Field("PAYMENT_TIME", "ZJ_LETTER_OF_GUARANTEE", "支付时间");
            /// <summary>
			/// 出函时间
			/// </summary>
			public readonly static Field LETTER_TIME = new Field("LETTER_TIME", "ZJ_LETTER_OF_GUARANTEE", "出函时间");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "ZJ_LETTER_OF_GUARANTEE", "交易系统标识码");
            /// <summary>
			/// 交易服务系统标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "ZJ_LETTER_OF_GUARANTEE", "交易服务系统标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "ZJ_LETTER_OF_GUARANTEE", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "ZJ_LETTER_OF_GUARANTEE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "ZJ_LETTER_OF_GUARANTEE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "ZJ_LETTER_OF_GUARANTEE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "ZJ_LETTER_OF_GUARANTEE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "ZJ_LETTER_OF_GUARANTEE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "ZJ_LETTER_OF_GUARANTEE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATOR = new Field("M_CREATOR", "ZJ_LETTER_OF_GUARANTEE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "ZJ_LETTER_OF_GUARANTEE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "ZJ_LETTER_OF_GUARANTEE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "ZJ_LETTER_OF_GUARANTEE", "");
            /// <summary>
			/// 电子保函附件
			/// </summary>
			public readonly static Field M_ATT_GUARANTEE_FILE = new Field("M_ATT_GUARANTEE_FILE", "ZJ_LETTER_OF_GUARANTEE", "电子保函附件");
            /// <summary>
			/// 申请人员
			/// </summary>
			public readonly static Field PROPOSER = new Field("PROPOSER", "ZJ_LETTER_OF_GUARANTEE", "申请人员");
            /// <summary>
			/// 申请人员联系方式
			/// </summary>
			public readonly static Field PROPOSER_PHONE = new Field("PROPOSER_PHONE", "ZJ_LETTER_OF_GUARANTEE", "申请人员联系方式");
            /// <summary>
			/// 证件类型
			/// </summary>
			public readonly static Field PROPOSER_CARD_TYPE = new Field("PROPOSER_CARD_TYPE", "ZJ_LETTER_OF_GUARANTEE", "证件类型");
            /// <summary>
			/// 证件号码
			/// </summary>
			public readonly static Field PROPOSER_CODE = new Field("PROPOSER_CODE", "ZJ_LETTER_OF_GUARANTEE", "证件号码");
            /// <summary>
			/// 支付账号
			/// </summary>
			public readonly static Field PURCHASE_ACCOUN = new Field("PURCHASE_ACCOUN", "ZJ_LETTER_OF_GUARANTEE", "支付账号");
            /// <summary>
			/// 费率
			/// </summary>
			public readonly static Field RATE = new Field("RATE", "ZJ_LETTER_OF_GUARANTEE", "费率");
            /// <summary>
			/// 电子保单文件下载地址
			/// </summary>
			public readonly static Field GUARANTEE_URL = new Field("GUARANTEE_URL", "ZJ_LETTER_OF_GUARANTEE", "电子保单文件下载地址");
            /// <summary>
			/// 电子保单文件md5码
			/// </summary>
			public readonly static Field GUARANTEE_MD5 = new Field("GUARANTEE_MD5", "ZJ_LETTER_OF_GUARANTEE", "电子保单文件md5码");
        }
        #endregion
	}
}