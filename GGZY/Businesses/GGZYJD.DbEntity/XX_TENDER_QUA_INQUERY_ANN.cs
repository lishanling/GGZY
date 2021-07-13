using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类XX_TENDER_QUA_INQUERY_ANN。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("XX_TENDER_QUA_INQUERY_ANN")]
    [Serializable]
    public partial class XX_TENDER_QUA_INQUERY_ANN : JdEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _M_VERSION;
		private string _TENDER_PROJECT_CODE;
		private decimal? _NOTICE_BID_NUM;
		private string _BID_SECTION_CODES;
		private string _TRAD_CENTER_NAME;
		private string _UNIFIED_DEAL_CODES;
		private string _TENDER_SELF_CODE;
		private string _NOTICE_NAME;
		private string _NOTICE_CONTENT;
		private DateTime? _NOTICE_SEND_TIME;
		private string _NOTICE_MEDIA;
		private string _URL;
		private string _NOTICE_NATURE;
		private string _BULLETIN_TYPE;
		private DateTime? _DOC_GET_START_TIME;
		private DateTime? _DOC_GET_END_TIME;
		private string _TENDER_DOC_GET_METHOD;
		private DateTime? _BID_DOC_REFER_END_TIME;
		private string _IS_POSTPONE;
		private DateTime? _BID_OPEN_TIME;
		private string _BID_OPEN_METHOD;
		private string _QUAL_TYPE;
		private decimal? _DOC_PRICE;
		private string _DOC_PRICE_CURRENCY;
		private string _DOC_PRICE_UNIT;
		private string _BID_DOC_REFER_METHOD;
		private string _SYNDICATED_FLAG;
		private string _TENDERER_CODE;
		private string _TENDERER_NAME;
		private string _TENDERER_ADDRESS;
		private string _TENDERER_CONTACTOR;
		private string _TENDERER_PHONE_NUMBER;
		private string _TENDERER_EMAIL;
		private string _TENDER_AGENCY_CODE;
		private string _TENDER_AGENCY_NAME;
		private string _TENDER_AGENCY_ADDRESS;
		private string _TENDER_AGENCY_CONTACTOR;
		private string _TENDER_AGENCY_PHONE_NUMBER;
		private string _TENDER_AGENCY_EMAIL;
		private string _OTHER_CONTENT;
		private string _BULLETIN_DUTY;
		private string _BULLETIN_DUTY_CODE_TYPE;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;

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
		/// 公告标段（包）数量
		/// </summary>
		public decimal? NOTICE_BID_NUM
		{
			get{ return _NOTICE_BID_NUM; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE_BID_NUM, _NOTICE_BID_NUM, value);
				this._NOTICE_BID_NUM = value;
			}
		}
		/// <summary>
		/// 相关标段（包）编号
		/// </summary>
		public string BID_SECTION_CODES
		{
			get{ return _BID_SECTION_CODES; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_CODES, _BID_SECTION_CODES, value);
				this._BID_SECTION_CODES = value;
			}
		}
		/// <summary>
		/// 交易中心名称
		/// </summary>
		public string TRAD_CENTER_NAME
		{
			get{ return _TRAD_CENTER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TRAD_CENTER_NAME, _TRAD_CENTER_NAME, value);
				this._TRAD_CENTER_NAME = value;
			}
		}
		/// <summary>
		/// 统一交易标识码
		/// </summary>
		public string UNIFIED_DEAL_CODES
		{
			get{ return _UNIFIED_DEAL_CODES; }
			set
			{
				this.OnPropertyValueChange(_.UNIFIED_DEAL_CODES, _UNIFIED_DEAL_CODES, value);
				this._UNIFIED_DEAL_CODES = value;
			}
		}
		/// <summary>
		/// 招标编号
		/// </summary>
		public string TENDER_SELF_CODE
		{
			get{ return _TENDER_SELF_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_SELF_CODE, _TENDER_SELF_CODE, value);
				this._TENDER_SELF_CODE = value;
			}
		}
		/// <summary>
		/// 公告标题
		/// </summary>
		public string NOTICE_NAME
		{
			get{ return _NOTICE_NAME; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE_NAME, _NOTICE_NAME, value);
				this._NOTICE_NAME = value;
			}
		}
		/// <summary>
		/// 公告内容
		/// </summary>
		public string NOTICE_CONTENT
		{
			get{ return _NOTICE_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE_CONTENT, _NOTICE_CONTENT, value);
				this._NOTICE_CONTENT = value;
			}
		}
		/// <summary>
		/// 公告发布时间
		/// </summary>
		public DateTime? NOTICE_SEND_TIME
		{
			get{ return _NOTICE_SEND_TIME; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE_SEND_TIME, _NOTICE_SEND_TIME, value);
				this._NOTICE_SEND_TIME = value;
			}
		}
		/// <summary>
		/// 公告发布媒体
		/// </summary>
		public string NOTICE_MEDIA
		{
			get{ return _NOTICE_MEDIA; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE_MEDIA, _NOTICE_MEDIA, value);
				this._NOTICE_MEDIA = value;
			}
		}
		/// <summary>
		/// 公告源URL
		/// </summary>
		public string URL
		{
			get{ return _URL; }
			set
			{
				this.OnPropertyValueChange(_.URL, _URL, value);
				this._URL = value;
			}
		}
		/// <summary>
		/// 公告性质
		/// </summary>
		public string NOTICE_NATURE
		{
			get{ return _NOTICE_NATURE; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE_NATURE, _NOTICE_NATURE, value);
				this._NOTICE_NATURE = value;
			}
		}
		/// <summary>
		/// 公告类型
		/// </summary>
		public string BULLETIN_TYPE
		{
			get{ return _BULLETIN_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.BULLETIN_TYPE, _BULLETIN_TYPE, value);
				this._BULLETIN_TYPE = value;
			}
		}
		/// <summary>
		/// 招标文件/资格预审文件获取时间
		/// </summary>
		public DateTime? DOC_GET_START_TIME
		{
			get{ return _DOC_GET_START_TIME; }
			set
			{
				this.OnPropertyValueChange(_.DOC_GET_START_TIME, _DOC_GET_START_TIME, value);
				this._DOC_GET_START_TIME = value;
			}
		}
		/// <summary>
		/// 招标文件/资格预审文件获取截至时间
		/// </summary>
		public DateTime? DOC_GET_END_TIME
		{
			get{ return _DOC_GET_END_TIME; }
			set
			{
				this.OnPropertyValueChange(_.DOC_GET_END_TIME, _DOC_GET_END_TIME, value);
				this._DOC_GET_END_TIME = value;
			}
		}
		/// <summary>
		/// 招标文件/资格预审文件获取方法
		/// </summary>
		public string TENDER_DOC_GET_METHOD
		{
			get{ return _TENDER_DOC_GET_METHOD; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_DOC_GET_METHOD, _TENDER_DOC_GET_METHOD, value);
				this._TENDER_DOC_GET_METHOD = value;
			}
		}
		/// <summary>
		/// 投标文件/资格预审申请文件递交截止时间
		/// </summary>
		public DateTime? BID_DOC_REFER_END_TIME
		{
			get{ return _BID_DOC_REFER_END_TIME; }
			set
			{
				this.OnPropertyValueChange(_.BID_DOC_REFER_END_TIME, _BID_DOC_REFER_END_TIME, value);
				this._BID_DOC_REFER_END_TIME = value;
			}
		}
		/// <summary>
		/// 是否延期开标
		/// </summary>
		public string IS_POSTPONE
		{
			get{ return _IS_POSTPONE; }
			set
			{
				this.OnPropertyValueChange(_.IS_POSTPONE, _IS_POSTPONE, value);
				this._IS_POSTPONE = value;
			}
		}
		/// <summary>
		/// 开标时间/开启时间
		/// </summary>
		public DateTime? BID_OPEN_TIME
		{
			get{ return _BID_OPEN_TIME; }
			set
			{
				this.OnPropertyValueChange(_.BID_OPEN_TIME, _BID_OPEN_TIME, value);
				this._BID_OPEN_TIME = value;
			}
		}
		/// <summary>
		/// 开标方式/文件开启方式
		/// </summary>
		public string BID_OPEN_METHOD
		{
			get{ return _BID_OPEN_METHOD; }
			set
			{
				this.OnPropertyValueChange(_.BID_OPEN_METHOD, _BID_OPEN_METHOD, value);
				this._BID_OPEN_METHOD = value;
			}
		}
		/// <summary>
		/// 评审办法
		/// </summary>
		public string QUAL_TYPE
		{
			get{ return _QUAL_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.QUAL_TYPE, _QUAL_TYPE, value);
				this._QUAL_TYPE = value;
			}
		}
		/// <summary>
		/// 文件售价
		/// </summary>
		public decimal? DOC_PRICE
		{
			get{ return _DOC_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.DOC_PRICE, _DOC_PRICE, value);
				this._DOC_PRICE = value;
			}
		}
		/// <summary>
		/// 文件售价币种
		/// </summary>
		public string DOC_PRICE_CURRENCY
		{
			get{ return _DOC_PRICE_CURRENCY; }
			set
			{
				this.OnPropertyValueChange(_.DOC_PRICE_CURRENCY, _DOC_PRICE_CURRENCY, value);
				this._DOC_PRICE_CURRENCY = value;
			}
		}
		/// <summary>
		/// 文件售价单位
		/// </summary>
		public string DOC_PRICE_UNIT
		{
			get{ return _DOC_PRICE_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.DOC_PRICE_UNIT, _DOC_PRICE_UNIT, value);
				this._DOC_PRICE_UNIT = value;
			}
		}
		/// <summary>
		/// 投标文件/资格预审申请文件递交方法
		/// </summary>
		public string BID_DOC_REFER_METHOD
		{
			get{ return _BID_DOC_REFER_METHOD; }
			set
			{
				this.OnPropertyValueChange(_.BID_DOC_REFER_METHOD, _BID_DOC_REFER_METHOD, value);
				this._BID_DOC_REFER_METHOD = value;
			}
		}
		/// <summary>
		/// 是否允许联合体投标
		/// </summary>
		public string SYNDICATED_FLAG
		{
			get{ return _SYNDICATED_FLAG; }
			set
			{
				this.OnPropertyValueChange(_.SYNDICATED_FLAG, _SYNDICATED_FLAG, value);
				this._SYNDICATED_FLAG = value;
			}
		}
		/// <summary>
		/// 招标人代码
		/// </summary>
		public string TENDERER_CODE
		{
			get{ return _TENDERER_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_CODE, _TENDERER_CODE, value);
				this._TENDERER_CODE = value;
			}
		}
		/// <summary>
		/// 招标人名称
		/// </summary>
		public string TENDERER_NAME
		{
			get{ return _TENDERER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_NAME, _TENDERER_NAME, value);
				this._TENDERER_NAME = value;
			}
		}
		/// <summary>
		/// 招标人地址
		/// </summary>
		public string TENDERER_ADDRESS
		{
			get{ return _TENDERER_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_ADDRESS, _TENDERER_ADDRESS, value);
				this._TENDERER_ADDRESS = value;
			}
		}
		/// <summary>
		/// 招标人联系人
		/// </summary>
		public string TENDERER_CONTACTOR
		{
			get{ return _TENDERER_CONTACTOR; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_CONTACTOR, _TENDERER_CONTACTOR, value);
				this._TENDERER_CONTACTOR = value;
			}
		}
		/// <summary>
		/// 招标人联系电话
		/// </summary>
		public string TENDERER_PHONE_NUMBER
		{
			get{ return _TENDERER_PHONE_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_PHONE_NUMBER, _TENDERER_PHONE_NUMBER, value);
				this._TENDERER_PHONE_NUMBER = value;
			}
		}
		/// <summary>
		/// 招标人电子邮箱
		/// </summary>
		public string TENDERER_EMAIL
		{
			get{ return _TENDERER_EMAIL; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_EMAIL, _TENDERER_EMAIL, value);
				this._TENDERER_EMAIL = value;
			}
		}
		/// <summary>
		/// 招标代理机构代码
		/// </summary>
		public string TENDER_AGENCY_CODE
		{
			get{ return _TENDER_AGENCY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_CODE, _TENDER_AGENCY_CODE, value);
				this._TENDER_AGENCY_CODE = value;
			}
		}
		/// <summary>
		/// 招标代理机构名称
		/// </summary>
		public string TENDER_AGENCY_NAME
		{
			get{ return _TENDER_AGENCY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_NAME, _TENDER_AGENCY_NAME, value);
				this._TENDER_AGENCY_NAME = value;
			}
		}
		/// <summary>
		/// 招标代理机构地址
		/// </summary>
		public string TENDER_AGENCY_ADDRESS
		{
			get{ return _TENDER_AGENCY_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_ADDRESS, _TENDER_AGENCY_ADDRESS, value);
				this._TENDER_AGENCY_ADDRESS = value;
			}
		}
		/// <summary>
		/// 招标代理机构联系人
		/// </summary>
		public string TENDER_AGENCY_CONTACTOR
		{
			get{ return _TENDER_AGENCY_CONTACTOR; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_CONTACTOR, _TENDER_AGENCY_CONTACTOR, value);
				this._TENDER_AGENCY_CONTACTOR = value;
			}
		}
		/// <summary>
		/// 招标代理机构联系电话
		/// </summary>
		public string TENDER_AGENCY_PHONE_NUMBER
		{
			get{ return _TENDER_AGENCY_PHONE_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_PHONE_NUMBER, _TENDER_AGENCY_PHONE_NUMBER, value);
				this._TENDER_AGENCY_PHONE_NUMBER = value;
			}
		}
		/// <summary>
		/// 招标代理机构电子邮箱
		/// </summary>
		public string TENDER_AGENCY_EMAIL
		{
			get{ return _TENDER_AGENCY_EMAIL; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_EMAIL, _TENDER_AGENCY_EMAIL, value);
				this._TENDER_AGENCY_EMAIL = value;
			}
		}
		/// <summary>
		/// 其他内容
		/// </summary>
		public string OTHER_CONTENT
		{
			get{ return _OTHER_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_CONTENT, _OTHER_CONTENT, value);
				this._OTHER_CONTENT = value;
			}
		}
		/// <summary>
		/// 公告发布责任人
		/// </summary>
		public string BULLETIN_DUTY
		{
			get{ return _BULLETIN_DUTY; }
			set
			{
				this.OnPropertyValueChange(_.BULLETIN_DUTY, _BULLETIN_DUTY, value);
				this._BULLETIN_DUTY = value;
			}
		}
		/// <summary>
		/// 交易平台验证责任人
		/// </summary>
		public string BULLETIN_DUTY_CODE_TYPE
		{
			get{ return _BULLETIN_DUTY_CODE_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.BULLETIN_DUTY_CODE_TYPE, _BULLETIN_DUTY_CODE_TYPE, value);
				this._BULLETIN_DUTY_CODE_TYPE = value;
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
		/// 交易平台或发布工具标识码
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
		/// 公共服务平台标识码
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
				_.DATA_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_VERSION,
				_.TENDER_PROJECT_CODE,
				_.NOTICE_BID_NUM,
				_.BID_SECTION_CODES,
				_.TRAD_CENTER_NAME,
				_.UNIFIED_DEAL_CODES,
				_.TENDER_SELF_CODE,
				_.NOTICE_NAME,
				_.NOTICE_CONTENT,
				_.NOTICE_SEND_TIME,
				_.NOTICE_MEDIA,
				_.URL,
				_.NOTICE_NATURE,
				_.BULLETIN_TYPE,
				_.DOC_GET_START_TIME,
				_.DOC_GET_END_TIME,
				_.TENDER_DOC_GET_METHOD,
				_.BID_DOC_REFER_END_TIME,
				_.IS_POSTPONE,
				_.BID_OPEN_TIME,
				_.BID_OPEN_METHOD,
				_.QUAL_TYPE,
				_.DOC_PRICE,
				_.DOC_PRICE_CURRENCY,
				_.DOC_PRICE_UNIT,
				_.BID_DOC_REFER_METHOD,
				_.SYNDICATED_FLAG,
				_.TENDERER_CODE,
				_.TENDERER_NAME,
				_.TENDERER_ADDRESS,
				_.TENDERER_CONTACTOR,
				_.TENDERER_PHONE_NUMBER,
				_.TENDERER_EMAIL,
				_.TENDER_AGENCY_CODE,
				_.TENDER_AGENCY_NAME,
				_.TENDER_AGENCY_ADDRESS,
				_.TENDER_AGENCY_CONTACTOR,
				_.TENDER_AGENCY_PHONE_NUMBER,
				_.TENDER_AGENCY_EMAIL,
				_.OTHER_CONTENT,
				_.BULLETIN_DUTY,
				_.BULLETIN_DUTY_CODE_TYPE,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.TRADE_PLAT,
				_.PUB_SERVICE_PLAT,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._M_ID,
				this._DATA_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_VERSION,
				this._TENDER_PROJECT_CODE,
				this._NOTICE_BID_NUM,
				this._BID_SECTION_CODES,
				this._TRAD_CENTER_NAME,
				this._UNIFIED_DEAL_CODES,
				this._TENDER_SELF_CODE,
				this._NOTICE_NAME,
				this._NOTICE_CONTENT,
				this._NOTICE_SEND_TIME,
				this._NOTICE_MEDIA,
				this._URL,
				this._NOTICE_NATURE,
				this._BULLETIN_TYPE,
				this._DOC_GET_START_TIME,
				this._DOC_GET_END_TIME,
				this._TENDER_DOC_GET_METHOD,
				this._BID_DOC_REFER_END_TIME,
				this._IS_POSTPONE,
				this._BID_OPEN_TIME,
				this._BID_OPEN_METHOD,
				this._QUAL_TYPE,
				this._DOC_PRICE,
				this._DOC_PRICE_CURRENCY,
				this._DOC_PRICE_UNIT,
				this._BID_DOC_REFER_METHOD,
				this._SYNDICATED_FLAG,
				this._TENDERER_CODE,
				this._TENDERER_NAME,
				this._TENDERER_ADDRESS,
				this._TENDERER_CONTACTOR,
				this._TENDERER_PHONE_NUMBER,
				this._TENDERER_EMAIL,
				this._TENDER_AGENCY_CODE,
				this._TENDER_AGENCY_NAME,
				this._TENDER_AGENCY_ADDRESS,
				this._TENDER_AGENCY_CONTACTOR,
				this._TENDER_AGENCY_PHONE_NUMBER,
				this._TENDER_AGENCY_EMAIL,
				this._OTHER_CONTENT,
				this._BULLETIN_DUTY,
				this._BULLETIN_DUTY_CODE_TYPE,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._TRADE_PLAT,
				this._PUB_SERVICE_PLAT,
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
			public readonly static Field All = new Field("*", "XX_TENDER_QUA_INQUERY_ANN");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "XX_TENDER_QUA_INQUERY_ANN", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "XX_TENDER_QUA_INQUERY_ANN", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "XX_TENDER_QUA_INQUERY_ANN", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "XX_TENDER_QUA_INQUERY_ANN", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "XX_TENDER_QUA_INQUERY_ANN", "");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "XX_TENDER_QUA_INQUERY_ANN", "招标项目编号");
            /// <summary>
			/// 公告标段（包）数量
			/// </summary>
			public readonly static Field NOTICE_BID_NUM = new Field("NOTICE_BID_NUM", "XX_TENDER_QUA_INQUERY_ANN", "公告标段（包）数量");
            /// <summary>
			/// 相关标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODES = new Field("BID_SECTION_CODES", "XX_TENDER_QUA_INQUERY_ANN",DbType.AnsiString, null, "相关标段（包）编号");
            /// <summary>
			/// 交易中心名称
			/// </summary>
			public readonly static Field TRAD_CENTER_NAME = new Field("TRAD_CENTER_NAME", "XX_TENDER_QUA_INQUERY_ANN", "交易中心名称");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODES = new Field("UNIFIED_DEAL_CODES", "XX_TENDER_QUA_INQUERY_ANN",DbType.AnsiString, null, "统一交易标识码");
            /// <summary>
			/// 招标编号
			/// </summary>
			public readonly static Field TENDER_SELF_CODE = new Field("TENDER_SELF_CODE", "XX_TENDER_QUA_INQUERY_ANN", "招标编号");
            /// <summary>
			/// 公告标题
			/// </summary>
			public readonly static Field NOTICE_NAME = new Field("NOTICE_NAME", "XX_TENDER_QUA_INQUERY_ANN", "公告标题");
            /// <summary>
			/// 公告内容
			/// </summary>
			public readonly static Field NOTICE_CONTENT = new Field("NOTICE_CONTENT", "XX_TENDER_QUA_INQUERY_ANN",DbType.AnsiString, null, "公告内容");
            /// <summary>
			/// 公告发布时间
			/// </summary>
			public readonly static Field NOTICE_SEND_TIME = new Field("NOTICE_SEND_TIME", "XX_TENDER_QUA_INQUERY_ANN", "公告发布时间");
            /// <summary>
			/// 公告发布媒体
			/// </summary>
			public readonly static Field NOTICE_MEDIA = new Field("NOTICE_MEDIA", "XX_TENDER_QUA_INQUERY_ANN", "公告发布媒体");
            /// <summary>
			/// 公告源URL
			/// </summary>
			public readonly static Field URL = new Field("URL", "XX_TENDER_QUA_INQUERY_ANN", "公告源URL");
            /// <summary>
			/// 公告性质
			/// </summary>
			public readonly static Field NOTICE_NATURE = new Field("NOTICE_NATURE", "XX_TENDER_QUA_INQUERY_ANN", "公告性质");
            /// <summary>
			/// 公告类型
			/// </summary>
			public readonly static Field BULLETIN_TYPE = new Field("BULLETIN_TYPE", "XX_TENDER_QUA_INQUERY_ANN", "公告类型");
            /// <summary>
			/// 招标文件/资格预审文件获取时间
			/// </summary>
			public readonly static Field DOC_GET_START_TIME = new Field("DOC_GET_START_TIME", "XX_TENDER_QUA_INQUERY_ANN", "招标文件/资格预审文件获取时间");
            /// <summary>
			/// 招标文件/资格预审文件获取截至时间
			/// </summary>
			public readonly static Field DOC_GET_END_TIME = new Field("DOC_GET_END_TIME", "XX_TENDER_QUA_INQUERY_ANN", "招标文件/资格预审文件获取截至时间");
            /// <summary>
			/// 招标文件/资格预审文件获取方法
			/// </summary>
			public readonly static Field TENDER_DOC_GET_METHOD = new Field("TENDER_DOC_GET_METHOD", "XX_TENDER_QUA_INQUERY_ANN", "招标文件/资格预审文件获取方法");
            /// <summary>
			/// 投标文件/资格预审申请文件递交截止时间
			/// </summary>
			public readonly static Field BID_DOC_REFER_END_TIME = new Field("BID_DOC_REFER_END_TIME", "XX_TENDER_QUA_INQUERY_ANN", "投标文件/资格预审申请文件递交截止时间");
            /// <summary>
			/// 是否延期开标
			/// </summary>
			public readonly static Field IS_POSTPONE = new Field("IS_POSTPONE", "XX_TENDER_QUA_INQUERY_ANN", "是否延期开标");
            /// <summary>
			/// 开标时间/开启时间
			/// </summary>
			public readonly static Field BID_OPEN_TIME = new Field("BID_OPEN_TIME", "XX_TENDER_QUA_INQUERY_ANN", "开标时间/开启时间");
            /// <summary>
			/// 开标方式/文件开启方式
			/// </summary>
			public readonly static Field BID_OPEN_METHOD = new Field("BID_OPEN_METHOD", "XX_TENDER_QUA_INQUERY_ANN",DbType.AnsiString, null, "开标方式/文件开启方式");
            /// <summary>
			/// 评审办法
			/// </summary>
			public readonly static Field QUAL_TYPE = new Field("QUAL_TYPE", "XX_TENDER_QUA_INQUERY_ANN",DbType.AnsiString, null, "评审办法");
            /// <summary>
			/// 文件售价
			/// </summary>
			public readonly static Field DOC_PRICE = new Field("DOC_PRICE", "XX_TENDER_QUA_INQUERY_ANN", "文件售价");
            /// <summary>
			/// 文件售价币种
			/// </summary>
			public readonly static Field DOC_PRICE_CURRENCY = new Field("DOC_PRICE_CURRENCY", "XX_TENDER_QUA_INQUERY_ANN", "文件售价币种");
            /// <summary>
			/// 文件售价单位
			/// </summary>
			public readonly static Field DOC_PRICE_UNIT = new Field("DOC_PRICE_UNIT", "XX_TENDER_QUA_INQUERY_ANN", "文件售价单位");
            /// <summary>
			/// 投标文件/资格预审申请文件递交方法
			/// </summary>
			public readonly static Field BID_DOC_REFER_METHOD = new Field("BID_DOC_REFER_METHOD", "XX_TENDER_QUA_INQUERY_ANN", "投标文件/资格预审申请文件递交方法");
            /// <summary>
			/// 是否允许联合体投标
			/// </summary>
			public readonly static Field SYNDICATED_FLAG = new Field("SYNDICATED_FLAG", "XX_TENDER_QUA_INQUERY_ANN", "是否允许联合体投标");
            /// <summary>
			/// 招标人代码
			/// </summary>
			public readonly static Field TENDERER_CODE = new Field("TENDERER_CODE", "XX_TENDER_QUA_INQUERY_ANN", "招标人代码");
            /// <summary>
			/// 招标人名称
			/// </summary>
			public readonly static Field TENDERER_NAME = new Field("TENDERER_NAME", "XX_TENDER_QUA_INQUERY_ANN", "招标人名称");
            /// <summary>
			/// 招标人地址
			/// </summary>
			public readonly static Field TENDERER_ADDRESS = new Field("TENDERER_ADDRESS", "XX_TENDER_QUA_INQUERY_ANN", "招标人地址");
            /// <summary>
			/// 招标人联系人
			/// </summary>
			public readonly static Field TENDERER_CONTACTOR = new Field("TENDERER_CONTACTOR", "XX_TENDER_QUA_INQUERY_ANN", "招标人联系人");
            /// <summary>
			/// 招标人联系电话
			/// </summary>
			public readonly static Field TENDERER_PHONE_NUMBER = new Field("TENDERER_PHONE_NUMBER", "XX_TENDER_QUA_INQUERY_ANN", "招标人联系电话");
            /// <summary>
			/// 招标人电子邮箱
			/// </summary>
			public readonly static Field TENDERER_EMAIL = new Field("TENDERER_EMAIL", "XX_TENDER_QUA_INQUERY_ANN", "招标人电子邮箱");
            /// <summary>
			/// 招标代理机构代码
			/// </summary>
			public readonly static Field TENDER_AGENCY_CODE = new Field("TENDER_AGENCY_CODE", "XX_TENDER_QUA_INQUERY_ANN", "招标代理机构代码");
            /// <summary>
			/// 招标代理机构名称
			/// </summary>
			public readonly static Field TENDER_AGENCY_NAME = new Field("TENDER_AGENCY_NAME", "XX_TENDER_QUA_INQUERY_ANN", "招标代理机构名称");
            /// <summary>
			/// 招标代理机构地址
			/// </summary>
			public readonly static Field TENDER_AGENCY_ADDRESS = new Field("TENDER_AGENCY_ADDRESS", "XX_TENDER_QUA_INQUERY_ANN", "招标代理机构地址");
            /// <summary>
			/// 招标代理机构联系人
			/// </summary>
			public readonly static Field TENDER_AGENCY_CONTACTOR = new Field("TENDER_AGENCY_CONTACTOR", "XX_TENDER_QUA_INQUERY_ANN", "招标代理机构联系人");
            /// <summary>
			/// 招标代理机构联系电话
			/// </summary>
			public readonly static Field TENDER_AGENCY_PHONE_NUMBER = new Field("TENDER_AGENCY_PHONE_NUMBER", "XX_TENDER_QUA_INQUERY_ANN", "招标代理机构联系电话");
            /// <summary>
			/// 招标代理机构电子邮箱
			/// </summary>
			public readonly static Field TENDER_AGENCY_EMAIL = new Field("TENDER_AGENCY_EMAIL", "XX_TENDER_QUA_INQUERY_ANN", "招标代理机构电子邮箱");
            /// <summary>
			/// 其他内容
			/// </summary>
			public readonly static Field OTHER_CONTENT = new Field("OTHER_CONTENT", "XX_TENDER_QUA_INQUERY_ANN",DbType.AnsiString, null, "其他内容");
            /// <summary>
			/// 公告发布责任人
			/// </summary>
			public readonly static Field BULLETIN_DUTY = new Field("BULLETIN_DUTY", "XX_TENDER_QUA_INQUERY_ANN", "公告发布责任人");
            /// <summary>
			/// 交易平台验证责任人
			/// </summary>
			public readonly static Field BULLETIN_DUTY_CODE_TYPE = new Field("BULLETIN_DUTY_CODE_TYPE", "XX_TENDER_QUA_INQUERY_ANN", "交易平台验证责任人");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "XX_TENDER_QUA_INQUERY_ANN", "交易系统标识码");
            /// <summary>
			/// 交易服务系统标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "XX_TENDER_QUA_INQUERY_ANN", "交易服务系统标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "XX_TENDER_QUA_INQUERY_ANN", "数据时间戳");
            /// <summary>
			/// 交易平台或发布工具标识码
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "XX_TENDER_QUA_INQUERY_ANN", "交易平台或发布工具标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "XX_TENDER_QUA_INQUERY_ANN", "公共服务平台标识码");
        }
        #endregion
	}
}