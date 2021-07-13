using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类YG_TENDER_CANDIDATE_ANN。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("YG_TENDER_CANDIDATE_ANN")]
    [Serializable]
    public partial class YG_TENDER_CANDIDATE_ANN : JdEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _M_VERSION;
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODES;
		private string _UNIFIED_DEAL_CODE;
		private string _PUBLICITY_NAME;
		private string _PUBLICITY_CONTENT;
		private DateTime? _PUBLICITY_REFER_TIME;
		private string _NOTICE_MEDIA;
		private string _URL;
		private string _PUBLICITY_TYPE;
		private DateTime? _PUBLICITY_START_TIME;
		private DateTime? _PUBLICITY_END_TIME;
		private string _OBJECTION_METHOD;
		private string _OTHER_CONTENT;
		private string _FIRST_BIDDER_NAME;
		private string _FIRST_BIDDER_CODE;
		private string _SECOND_BIDDER_NAME;
		private string _SECOND_BIDDER_CODE;
		private string _THIRD_BIDDER_NAME;
		private string _THIRD_BIDDER_CODE;
		private string _BULLETIN_DUTY;
		private string _EXAMINER_NAME;
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
		/// 相关统一交易标识码
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
		/// 公示标题
		/// </summary>
		public string PUBLICITY_NAME
		{
			get{ return _PUBLICITY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PUBLICITY_NAME, _PUBLICITY_NAME, value);
				this._PUBLICITY_NAME = value;
			}
		}
		/// <summary>
		/// 公示内容
		/// </summary>
		public string PUBLICITY_CONTENT
		{
			get{ return _PUBLICITY_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.PUBLICITY_CONTENT, _PUBLICITY_CONTENT, value);
				this._PUBLICITY_CONTENT = value;
			}
		}
		/// <summary>
		/// 公示提交时间
		/// </summary>
		public DateTime? PUBLICITY_REFER_TIME
		{
			get{ return _PUBLICITY_REFER_TIME; }
			set
			{
				this.OnPropertyValueChange(_.PUBLICITY_REFER_TIME, _PUBLICITY_REFER_TIME, value);
				this._PUBLICITY_REFER_TIME = value;
			}
		}
		/// <summary>
		/// 公示发布媒体
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
		/// 公示源URL
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
		/// 公示类型
		/// </summary>
		public string PUBLICITY_TYPE
		{
			get{ return _PUBLICITY_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.PUBLICITY_TYPE, _PUBLICITY_TYPE, value);
				this._PUBLICITY_TYPE = value;
			}
		}
		/// <summary>
		/// 公示开始时间
		/// </summary>
		public DateTime? PUBLICITY_START_TIME
		{
			get{ return _PUBLICITY_START_TIME; }
			set
			{
				this.OnPropertyValueChange(_.PUBLICITY_START_TIME, _PUBLICITY_START_TIME, value);
				this._PUBLICITY_START_TIME = value;
			}
		}
		/// <summary>
		/// 公示结束时间
		/// </summary>
		public DateTime? PUBLICITY_END_TIME
		{
			get{ return _PUBLICITY_END_TIME; }
			set
			{
				this.OnPropertyValueChange(_.PUBLICITY_END_TIME, _PUBLICITY_END_TIME, value);
				this._PUBLICITY_END_TIME = value;
			}
		}
		/// <summary>
		/// 提出异议的渠道和方式
		/// </summary>
		public string OBJECTION_METHOD
		{
			get{ return _OBJECTION_METHOD; }
			set
			{
				this.OnPropertyValueChange(_.OBJECTION_METHOD, _OBJECTION_METHOD, value);
				this._OBJECTION_METHOD = value;
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
		/// 第一中标候选人名称
		/// </summary>
		public string FIRST_BIDDER_NAME
		{
			get{ return _FIRST_BIDDER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.FIRST_BIDDER_NAME, _FIRST_BIDDER_NAME, value);
				this._FIRST_BIDDER_NAME = value;
			}
		}
		/// <summary>
		/// 第一中标候选人统一社会信用代码
		/// </summary>
		public string FIRST_BIDDER_CODE
		{
			get{ return _FIRST_BIDDER_CODE; }
			set
			{
				this.OnPropertyValueChange(_.FIRST_BIDDER_CODE, _FIRST_BIDDER_CODE, value);
				this._FIRST_BIDDER_CODE = value;
			}
		}
		/// <summary>
		/// 第二中标候选人名称
		/// </summary>
		public string SECOND_BIDDER_NAME
		{
			get{ return _SECOND_BIDDER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SECOND_BIDDER_NAME, _SECOND_BIDDER_NAME, value);
				this._SECOND_BIDDER_NAME = value;
			}
		}
		/// <summary>
		/// 第二中标候选人统一社会信用代码
		/// </summary>
		public string SECOND_BIDDER_CODE
		{
			get{ return _SECOND_BIDDER_CODE; }
			set
			{
				this.OnPropertyValueChange(_.SECOND_BIDDER_CODE, _SECOND_BIDDER_CODE, value);
				this._SECOND_BIDDER_CODE = value;
			}
		}
		/// <summary>
		/// 第三中标候选人名称
		/// </summary>
		public string THIRD_BIDDER_NAME
		{
			get{ return _THIRD_BIDDER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.THIRD_BIDDER_NAME, _THIRD_BIDDER_NAME, value);
				this._THIRD_BIDDER_NAME = value;
			}
		}
		/// <summary>
		/// 第三中标候选人统一社会信用代码
		/// </summary>
		public string THIRD_BIDDER_CODE
		{
			get{ return _THIRD_BIDDER_CODE; }
			set
			{
				this.OnPropertyValueChange(_.THIRD_BIDDER_CODE, _THIRD_BIDDER_CODE, value);
				this._THIRD_BIDDER_CODE = value;
			}
		}
		/// <summary>
		/// 公示发布责任人
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
		/// 交易平台数据验证责任人姓名
		/// </summary>
		public string EXAMINER_NAME
		{
			get{ return _EXAMINER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.EXAMINER_NAME, _EXAMINER_NAME, value);
				this._EXAMINER_NAME = value;
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
				_.BID_SECTION_CODES,
				_.UNIFIED_DEAL_CODE,
				_.PUBLICITY_NAME,
				_.PUBLICITY_CONTENT,
				_.PUBLICITY_REFER_TIME,
				_.NOTICE_MEDIA,
				_.URL,
				_.PUBLICITY_TYPE,
				_.PUBLICITY_START_TIME,
				_.PUBLICITY_END_TIME,
				_.OBJECTION_METHOD,
				_.OTHER_CONTENT,
				_.FIRST_BIDDER_NAME,
				_.FIRST_BIDDER_CODE,
				_.SECOND_BIDDER_NAME,
				_.SECOND_BIDDER_CODE,
				_.THIRD_BIDDER_NAME,
				_.THIRD_BIDDER_CODE,
				_.BULLETIN_DUTY,
				_.EXAMINER_NAME,
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
				this._BID_SECTION_CODES,
				this._UNIFIED_DEAL_CODE,
				this._PUBLICITY_NAME,
				this._PUBLICITY_CONTENT,
				this._PUBLICITY_REFER_TIME,
				this._NOTICE_MEDIA,
				this._URL,
				this._PUBLICITY_TYPE,
				this._PUBLICITY_START_TIME,
				this._PUBLICITY_END_TIME,
				this._OBJECTION_METHOD,
				this._OTHER_CONTENT,
				this._FIRST_BIDDER_NAME,
				this._FIRST_BIDDER_CODE,
				this._SECOND_BIDDER_NAME,
				this._SECOND_BIDDER_CODE,
				this._THIRD_BIDDER_NAME,
				this._THIRD_BIDDER_CODE,
				this._BULLETIN_DUTY,
				this._EXAMINER_NAME,
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
			public readonly static Field All = new Field("*", "YG_TENDER_CANDIDATE_ANN");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "YG_TENDER_CANDIDATE_ANN", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "YG_TENDER_CANDIDATE_ANN", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "YG_TENDER_CANDIDATE_ANN", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "YG_TENDER_CANDIDATE_ANN", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "YG_TENDER_CANDIDATE_ANN", "");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "YG_TENDER_CANDIDATE_ANN", "招标项目编号");
            /// <summary>
			/// 相关标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODES = new Field("BID_SECTION_CODES", "YG_TENDER_CANDIDATE_ANN",DbType.AnsiString, null, "相关标段（包）编号");
            /// <summary>
			/// 相关统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "YG_TENDER_CANDIDATE_ANN",DbType.AnsiString, null, "相关统一交易标识码");
            /// <summary>
			/// 公示标题
			/// </summary>
			public readonly static Field PUBLICITY_NAME = new Field("PUBLICITY_NAME", "YG_TENDER_CANDIDATE_ANN", "公示标题");
            /// <summary>
			/// 公示内容
			/// </summary>
			public readonly static Field PUBLICITY_CONTENT = new Field("PUBLICITY_CONTENT", "YG_TENDER_CANDIDATE_ANN",DbType.AnsiString, null, "公示内容");
            /// <summary>
			/// 公示提交时间
			/// </summary>
			public readonly static Field PUBLICITY_REFER_TIME = new Field("PUBLICITY_REFER_TIME", "YG_TENDER_CANDIDATE_ANN", "公示提交时间");
            /// <summary>
			/// 公示发布媒体
			/// </summary>
			public readonly static Field NOTICE_MEDIA = new Field("NOTICE_MEDIA", "YG_TENDER_CANDIDATE_ANN", "公示发布媒体");
            /// <summary>
			/// 公示源URL
			/// </summary>
			public readonly static Field URL = new Field("URL", "YG_TENDER_CANDIDATE_ANN", "公示源URL");
            /// <summary>
			/// 公示类型
			/// </summary>
			public readonly static Field PUBLICITY_TYPE = new Field("PUBLICITY_TYPE", "YG_TENDER_CANDIDATE_ANN", "公示类型");
            /// <summary>
			/// 公示开始时间
			/// </summary>
			public readonly static Field PUBLICITY_START_TIME = new Field("PUBLICITY_START_TIME", "YG_TENDER_CANDIDATE_ANN", "公示开始时间");
            /// <summary>
			/// 公示结束时间
			/// </summary>
			public readonly static Field PUBLICITY_END_TIME = new Field("PUBLICITY_END_TIME", "YG_TENDER_CANDIDATE_ANN", "公示结束时间");
            /// <summary>
			/// 提出异议的渠道和方式
			/// </summary>
			public readonly static Field OBJECTION_METHOD = new Field("OBJECTION_METHOD", "YG_TENDER_CANDIDATE_ANN",DbType.AnsiString, null, "提出异议的渠道和方式");
            /// <summary>
			/// 其他内容
			/// </summary>
			public readonly static Field OTHER_CONTENT = new Field("OTHER_CONTENT", "YG_TENDER_CANDIDATE_ANN",DbType.AnsiString, null, "其他内容");
            /// <summary>
			/// 第一中标候选人名称
			/// </summary>
			public readonly static Field FIRST_BIDDER_NAME = new Field("FIRST_BIDDER_NAME", "YG_TENDER_CANDIDATE_ANN", "第一中标候选人名称");
            /// <summary>
			/// 第一中标候选人统一社会信用代码
			/// </summary>
			public readonly static Field FIRST_BIDDER_CODE = new Field("FIRST_BIDDER_CODE", "YG_TENDER_CANDIDATE_ANN", "第一中标候选人统一社会信用代码");
            /// <summary>
			/// 第二中标候选人名称
			/// </summary>
			public readonly static Field SECOND_BIDDER_NAME = new Field("SECOND_BIDDER_NAME", "YG_TENDER_CANDIDATE_ANN", "第二中标候选人名称");
            /// <summary>
			/// 第二中标候选人统一社会信用代码
			/// </summary>
			public readonly static Field SECOND_BIDDER_CODE = new Field("SECOND_BIDDER_CODE", "YG_TENDER_CANDIDATE_ANN", "第二中标候选人统一社会信用代码");
            /// <summary>
			/// 第三中标候选人名称
			/// </summary>
			public readonly static Field THIRD_BIDDER_NAME = new Field("THIRD_BIDDER_NAME", "YG_TENDER_CANDIDATE_ANN", "第三中标候选人名称");
            /// <summary>
			/// 第三中标候选人统一社会信用代码
			/// </summary>
			public readonly static Field THIRD_BIDDER_CODE = new Field("THIRD_BIDDER_CODE", "YG_TENDER_CANDIDATE_ANN", "第三中标候选人统一社会信用代码");
            /// <summary>
			/// 公示发布责任人
			/// </summary>
			public readonly static Field BULLETIN_DUTY = new Field("BULLETIN_DUTY", "YG_TENDER_CANDIDATE_ANN", "公示发布责任人");
            /// <summary>
			/// 交易平台数据验证责任人姓名
			/// </summary>
			public readonly static Field EXAMINER_NAME = new Field("EXAMINER_NAME", "YG_TENDER_CANDIDATE_ANN", "交易平台数据验证责任人姓名");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "YG_TENDER_CANDIDATE_ANN", "交易系统标识码");
            /// <summary>
			/// 交易服务系统标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "YG_TENDER_CANDIDATE_ANN", "交易服务系统标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "YG_TENDER_CANDIDATE_ANN", "数据时间戳");
            /// <summary>
			/// 交易平台或发布工具标识码
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "YG_TENDER_CANDIDATE_ANN", "交易平台或发布工具标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "YG_TENDER_CANDIDATE_ANN", "公共服务平台标识码");
        }
        #endregion
	}
}