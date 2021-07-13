using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类ZJ_REVIEW_CONTENT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJ_REVIEW_CONTENT")]
    [Serializable]
    public partial class ZJ_REVIEW_CONTENT : JdEntity
    {
        #region Model
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private string _UNIFIED_DEAL_CODE;
		private string _BIDDER_NAME;
		private string _BIDDER_ORG_CODE;
		private string _BIDDER_CREDIT_CODE;
		private decimal? _TECHNICAL_DOC_SCORE;
		private string _EVALUAT_EXPERT_NAME;
		private string _EXPERT_ID_CARD;
		private decimal? _EVALUATION_DOC_SCORE;
		private decimal? _TENDER_OFFER_SCORE;
		private decimal? _CREDIT_SCORE;
		private decimal? _OTHER_FACTOR_SCORE;
		private decimal? _TOTAL_SCORE;
		private decimal? _SORT;
		private DateTime? _BEGIN_TIME;
		private DateTime? _END_TIME;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private string _M_CREATEBY;
		private DateTime? _M_TM;
		private DateTime? _M_CREATE_TM;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;
		private string _M_VERSION;

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
		/// 投标人组织机构代码
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
		/// 投标人社会统一信用代码
		/// </summary>
		public string BIDDER_CREDIT_CODE
		{
			get{ return _BIDDER_CREDIT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_CREDIT_CODE, _BIDDER_CREDIT_CODE, value);
				this._BIDDER_CREDIT_CODE = value;
			}
		}
		/// <summary>
		/// 技术文件得分
		/// </summary>
		public decimal? TECHNICAL_DOC_SCORE
		{
			get{ return _TECHNICAL_DOC_SCORE; }
			set
			{
				this.OnPropertyValueChange(_.TECHNICAL_DOC_SCORE, _TECHNICAL_DOC_SCORE, value);
				this._TECHNICAL_DOC_SCORE = value;
			}
		}
		/// <summary>
		/// 评标专家名称
		/// </summary>
		public string EVALUAT_EXPERT_NAME
		{
			get{ return _EVALUAT_EXPERT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.EVALUAT_EXPERT_NAME, _EVALUAT_EXPERT_NAME, value);
				this._EVALUAT_EXPERT_NAME = value;
			}
		}
		/// <summary>
		/// 评标专家身份证
		/// </summary>
		public string EXPERT_ID_CARD
		{
			get{ return _EXPERT_ID_CARD; }
			set
			{
				this.OnPropertyValueChange(_.EXPERT_ID_CARD, _EXPERT_ID_CARD, value);
				this._EXPERT_ID_CARD = value;
			}
		}
		/// <summary>
		/// 评标专家对技术文件的评分
		/// </summary>
		public decimal? EVALUATION_DOC_SCORE
		{
			get{ return _EVALUATION_DOC_SCORE; }
			set
			{
				this.OnPropertyValueChange(_.EVALUATION_DOC_SCORE, _EVALUATION_DOC_SCORE, value);
				this._EVALUATION_DOC_SCORE = value;
			}
		}
		/// <summary>
		/// 投标报价得分
		/// </summary>
		public decimal? TENDER_OFFER_SCORE
		{
			get{ return _TENDER_OFFER_SCORE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_OFFER_SCORE, _TENDER_OFFER_SCORE, value);
				this._TENDER_OFFER_SCORE = value;
			}
		}
		/// <summary>
		/// 信用分（如有）
		/// </summary>
		public decimal? CREDIT_SCORE
		{
			get{ return _CREDIT_SCORE; }
			set
			{
				this.OnPropertyValueChange(_.CREDIT_SCORE, _CREDIT_SCORE, value);
				this._CREDIT_SCORE = value;
			}
		}
		/// <summary>
		/// 其它因素得分（如有）
		/// </summary>
		public decimal? OTHER_FACTOR_SCORE
		{
			get{ return _OTHER_FACTOR_SCORE; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_FACTOR_SCORE, _OTHER_FACTOR_SCORE, value);
				this._OTHER_FACTOR_SCORE = value;
			}
		}
		/// <summary>
		/// 总得分
		/// </summary>
		public decimal? TOTAL_SCORE
		{
			get{ return _TOTAL_SCORE; }
			set
			{
				this.OnPropertyValueChange(_.TOTAL_SCORE, _TOTAL_SCORE, value);
				this._TOTAL_SCORE = value;
			}
		}
		/// <summary>
		/// 排序
		/// </summary>
		public decimal? SORT
		{
			get{ return _SORT; }
			set
			{
				this.OnPropertyValueChange(_.SORT, _SORT, value);
				this._SORT = value;
			}
		}
		/// <summary>
		/// 评审开始时间
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
		/// 评审结束时间
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
		/// 公共服务平台标识码
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
		/// 数据自增长ID
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
		/// 数据DATA_KEY
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
		/// 数据来源
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
		/// M_CREATEBY
		/// </summary>
		public string M_CREATEBY
		{
			get{ return _M_CREATEBY; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATEBY, _M_CREATEBY, value);
				this._M_CREATEBY = value;
			}
		}
		/// <summary>
		/// M_TM
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
		/// M_CREATE_TM
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
				_.TENDER_PROJECT_CODE,
				_.BID_SECTION_CODE,
				_.UNIFIED_DEAL_CODE,
				_.BIDDER_NAME,
				_.BIDDER_ORG_CODE,
				_.BIDDER_CREDIT_CODE,
				_.TECHNICAL_DOC_SCORE,
				_.EVALUAT_EXPERT_NAME,
				_.EXPERT_ID_CARD,
				_.EVALUATION_DOC_SCORE,
				_.TENDER_OFFER_SCORE,
				_.CREDIT_SCORE,
				_.OTHER_FACTOR_SCORE,
				_.TOTAL_SCORE,
				_.SORT,
				_.BEGIN_TIME,
				_.END_TIME,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_ID,
				_.DATA_KEY,
				_.M_DATA_SOURCE,
				_.M_CREATEBY,
				_.M_TM,
				_.M_CREATE_TM,
				_.TRADE_PLAT,
				_.PUB_SERVICE_PLAT,
				_.M_VERSION,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._TENDER_PROJECT_CODE,
				this._BID_SECTION_CODE,
				this._UNIFIED_DEAL_CODE,
				this._BIDDER_NAME,
				this._BIDDER_ORG_CODE,
				this._BIDDER_CREDIT_CODE,
				this._TECHNICAL_DOC_SCORE,
				this._EVALUAT_EXPERT_NAME,
				this._EXPERT_ID_CARD,
				this._EVALUATION_DOC_SCORE,
				this._TENDER_OFFER_SCORE,
				this._CREDIT_SCORE,
				this._OTHER_FACTOR_SCORE,
				this._TOTAL_SCORE,
				this._SORT,
				this._BEGIN_TIME,
				this._END_TIME,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_ID,
				this._DATA_KEY,
				this._M_DATA_SOURCE,
				this._M_CREATEBY,
				this._M_TM,
				this._M_CREATE_TM,
				this._TRADE_PLAT,
				this._PUB_SERVICE_PLAT,
				this._M_VERSION,
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
			public readonly static Field All = new Field("*", "ZJ_REVIEW_CONTENT");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "ZJ_REVIEW_CONTENT", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "ZJ_REVIEW_CONTENT", "标段（包）编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "ZJ_REVIEW_CONTENT", "统一交易标识码");
            /// <summary>
			/// 投标人名称
			/// </summary>
			public readonly static Field BIDDER_NAME = new Field("BIDDER_NAME", "ZJ_REVIEW_CONTENT", "投标人名称");
            /// <summary>
			/// 投标人组织机构代码
			/// </summary>
			public readonly static Field BIDDER_ORG_CODE = new Field("BIDDER_ORG_CODE", "ZJ_REVIEW_CONTENT", "投标人组织机构代码");
            /// <summary>
			/// 投标人社会统一信用代码
			/// </summary>
			public readonly static Field BIDDER_CREDIT_CODE = new Field("BIDDER_CREDIT_CODE", "ZJ_REVIEW_CONTENT", "投标人社会统一信用代码");
            /// <summary>
			/// 技术文件得分
			/// </summary>
			public readonly static Field TECHNICAL_DOC_SCORE = new Field("TECHNICAL_DOC_SCORE", "ZJ_REVIEW_CONTENT", "技术文件得分");
            /// <summary>
			/// 评标专家名称
			/// </summary>
			public readonly static Field EVALUAT_EXPERT_NAME = new Field("EVALUAT_EXPERT_NAME", "ZJ_REVIEW_CONTENT", "评标专家名称");
            /// <summary>
			/// 评标专家身份证
			/// </summary>
			public readonly static Field EXPERT_ID_CARD = new Field("EXPERT_ID_CARD", "ZJ_REVIEW_CONTENT", "评标专家身份证");
            /// <summary>
			/// 评标专家对技术文件的评分
			/// </summary>
			public readonly static Field EVALUATION_DOC_SCORE = new Field("EVALUATION_DOC_SCORE", "ZJ_REVIEW_CONTENT", "评标专家对技术文件的评分");
            /// <summary>
			/// 投标报价得分
			/// </summary>
			public readonly static Field TENDER_OFFER_SCORE = new Field("TENDER_OFFER_SCORE", "ZJ_REVIEW_CONTENT", "投标报价得分");
            /// <summary>
			/// 信用分（如有）
			/// </summary>
			public readonly static Field CREDIT_SCORE = new Field("CREDIT_SCORE", "ZJ_REVIEW_CONTENT", "信用分（如有）");
            /// <summary>
			/// 其它因素得分（如有）
			/// </summary>
			public readonly static Field OTHER_FACTOR_SCORE = new Field("OTHER_FACTOR_SCORE", "ZJ_REVIEW_CONTENT", "其它因素得分（如有）");
            /// <summary>
			/// 总得分
			/// </summary>
			public readonly static Field TOTAL_SCORE = new Field("TOTAL_SCORE", "ZJ_REVIEW_CONTENT", "总得分");
            /// <summary>
			/// 排序
			/// </summary>
			public readonly static Field SORT = new Field("SORT", "ZJ_REVIEW_CONTENT", "排序");
            /// <summary>
			/// 评审开始时间
			/// </summary>
			public readonly static Field BEGIN_TIME = new Field("BEGIN_TIME", "ZJ_REVIEW_CONTENT", "评审开始时间");
            /// <summary>
			/// 评审结束时间
			/// </summary>
			public readonly static Field END_TIME = new Field("END_TIME", "ZJ_REVIEW_CONTENT", "评审结束时间");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "ZJ_REVIEW_CONTENT", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "ZJ_REVIEW_CONTENT", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "ZJ_REVIEW_CONTENT", "数据时间戳");
            /// <summary>
			/// 数据自增长ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "ZJ_REVIEW_CONTENT", "数据自增长ID");
            /// <summary>
			/// 数据DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "ZJ_REVIEW_CONTENT", "数据DATA_KEY");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "ZJ_REVIEW_CONTENT", "数据来源");
            /// <summary>
			/// M_CREATEBY
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "ZJ_REVIEW_CONTENT", "M_CREATEBY");
            /// <summary>
			/// M_TM
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "ZJ_REVIEW_CONTENT", "M_TM");
            /// <summary>
			/// M_CREATE_TM
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "ZJ_REVIEW_CONTENT", "M_CREATE_TM");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "ZJ_REVIEW_CONTENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "ZJ_REVIEW_CONTENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "ZJ_REVIEW_CONTENT", "");
        }
        #endregion
	}
}