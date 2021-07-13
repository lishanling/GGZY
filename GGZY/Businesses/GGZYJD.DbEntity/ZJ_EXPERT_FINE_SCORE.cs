using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类ZJ_EXPERT_FINE_SCORE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJ_EXPERT_FINE_SCORE")]
    [Serializable]
    public partial class ZJ_EXPERT_FINE_SCORE : JdEntity
    {
        #region Model
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private string _UNIFIED_DEAL_CODE;
		private DateTime? _BEGIN_TIME;
		private DateTime? _END_TIME;
		private string _EXPERT_ID_CARD;
		private string _BIDDER_NAME;
		private string _BIDDER_ORG_CODE;
		private string _BIDDER_CREDIT_CODE;
		private string _EVALUATION_TECH_ITEM_NAME;
		private decimal? _EVALUATION_TECH_ITEM_SCORE;
		private string _EVALUATION_TECH_ITEM_WEIGHT;
		private decimal? _EVALUATION_BIDDER_SCORE;
		private string _REASON_SUB_REVIEW;
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
		/// 技术文件评审子项名称
		/// </summary>
		public string EVALUATION_TECH_ITEM_NAME
		{
			get{ return _EVALUATION_TECH_ITEM_NAME; }
			set
			{
				this.OnPropertyValueChange(_.EVALUATION_TECH_ITEM_NAME, _EVALUATION_TECH_ITEM_NAME, value);
				this._EVALUATION_TECH_ITEM_NAME = value;
			}
		}
		/// <summary>
		/// 技术文件评审子项得分
		/// </summary>
		public decimal? EVALUATION_TECH_ITEM_SCORE
		{
			get{ return _EVALUATION_TECH_ITEM_SCORE; }
			set
			{
				this.OnPropertyValueChange(_.EVALUATION_TECH_ITEM_SCORE, _EVALUATION_TECH_ITEM_SCORE, value);
				this._EVALUATION_TECH_ITEM_SCORE = value;
			}
		}
		/// <summary>
		/// 技术文件评审子项权重
		/// </summary>
		public string EVALUATION_TECH_ITEM_WEIGHT
		{
			get{ return _EVALUATION_TECH_ITEM_WEIGHT; }
			set
			{
				this.OnPropertyValueChange(_.EVALUATION_TECH_ITEM_WEIGHT, _EVALUATION_TECH_ITEM_WEIGHT, value);
				this._EVALUATION_TECH_ITEM_WEIGHT = value;
			}
		}
		/// <summary>
		/// 技术文件的总评分
		/// </summary>
		public decimal? EVALUATION_BIDDER_SCORE
		{
			get{ return _EVALUATION_BIDDER_SCORE; }
			set
			{
				this.OnPropertyValueChange(_.EVALUATION_BIDDER_SCORE, _EVALUATION_BIDDER_SCORE, value);
				this._EVALUATION_BIDDER_SCORE = value;
			}
		}
		/// <summary>
		/// 子项评审申述理由（如有）
		/// </summary>
		public string REASON_SUB_REVIEW
		{
			get{ return _REASON_SUB_REVIEW; }
			set
			{
				this.OnPropertyValueChange(_.REASON_SUB_REVIEW, _REASON_SUB_REVIEW, value);
				this._REASON_SUB_REVIEW = value;
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
				_.BEGIN_TIME,
				_.END_TIME,
				_.EXPERT_ID_CARD,
				_.BIDDER_NAME,
				_.BIDDER_ORG_CODE,
				_.BIDDER_CREDIT_CODE,
				_.EVALUATION_TECH_ITEM_NAME,
				_.EVALUATION_TECH_ITEM_SCORE,
				_.EVALUATION_TECH_ITEM_WEIGHT,
				_.EVALUATION_BIDDER_SCORE,
				_.REASON_SUB_REVIEW,
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
				this._BEGIN_TIME,
				this._END_TIME,
				this._EXPERT_ID_CARD,
				this._BIDDER_NAME,
				this._BIDDER_ORG_CODE,
				this._BIDDER_CREDIT_CODE,
				this._EVALUATION_TECH_ITEM_NAME,
				this._EVALUATION_TECH_ITEM_SCORE,
				this._EVALUATION_TECH_ITEM_WEIGHT,
				this._EVALUATION_BIDDER_SCORE,
				this._REASON_SUB_REVIEW,
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
			public readonly static Field All = new Field("*", "ZJ_EXPERT_FINE_SCORE");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "ZJ_EXPERT_FINE_SCORE", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "ZJ_EXPERT_FINE_SCORE", "标段（包）编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "ZJ_EXPERT_FINE_SCORE", "统一交易标识码");
            /// <summary>
			/// 评审开始时间
			/// </summary>
			public readonly static Field BEGIN_TIME = new Field("BEGIN_TIME", "ZJ_EXPERT_FINE_SCORE", "评审开始时间");
            /// <summary>
			/// 评审结束时间
			/// </summary>
			public readonly static Field END_TIME = new Field("END_TIME", "ZJ_EXPERT_FINE_SCORE", "评审结束时间");
            /// <summary>
			/// 评标专家身份证
			/// </summary>
			public readonly static Field EXPERT_ID_CARD = new Field("EXPERT_ID_CARD", "ZJ_EXPERT_FINE_SCORE", "评标专家身份证");
            /// <summary>
			/// 投标人名称
			/// </summary>
			public readonly static Field BIDDER_NAME = new Field("BIDDER_NAME", "ZJ_EXPERT_FINE_SCORE", "投标人名称");
            /// <summary>
			/// 投标人组织机构代码
			/// </summary>
			public readonly static Field BIDDER_ORG_CODE = new Field("BIDDER_ORG_CODE", "ZJ_EXPERT_FINE_SCORE", "投标人组织机构代码");
            /// <summary>
			/// 投标人社会统一信用代码
			/// </summary>
			public readonly static Field BIDDER_CREDIT_CODE = new Field("BIDDER_CREDIT_CODE", "ZJ_EXPERT_FINE_SCORE", "投标人社会统一信用代码");
            /// <summary>
			/// 技术文件评审子项名称
			/// </summary>
			public readonly static Field EVALUATION_TECH_ITEM_NAME = new Field("EVALUATION_TECH_ITEM_NAME", "ZJ_EXPERT_FINE_SCORE", "技术文件评审子项名称");
            /// <summary>
			/// 技术文件评审子项得分
			/// </summary>
			public readonly static Field EVALUATION_TECH_ITEM_SCORE = new Field("EVALUATION_TECH_ITEM_SCORE", "ZJ_EXPERT_FINE_SCORE", "技术文件评审子项得分");
            /// <summary>
			/// 技术文件评审子项权重
			/// </summary>
			public readonly static Field EVALUATION_TECH_ITEM_WEIGHT = new Field("EVALUATION_TECH_ITEM_WEIGHT", "ZJ_EXPERT_FINE_SCORE", "技术文件评审子项权重");
            /// <summary>
			/// 技术文件的总评分
			/// </summary>
			public readonly static Field EVALUATION_BIDDER_SCORE = new Field("EVALUATION_BIDDER_SCORE", "ZJ_EXPERT_FINE_SCORE", "技术文件的总评分");
            /// <summary>
			/// 子项评审申述理由（如有）
			/// </summary>
			public readonly static Field REASON_SUB_REVIEW = new Field("REASON_SUB_REVIEW", "ZJ_EXPERT_FINE_SCORE",DbType.AnsiString, null, "子项评审申述理由（如有）");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "ZJ_EXPERT_FINE_SCORE", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "ZJ_EXPERT_FINE_SCORE", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "ZJ_EXPERT_FINE_SCORE", "数据时间戳");
            /// <summary>
			/// 数据自增长ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "ZJ_EXPERT_FINE_SCORE", "数据自增长ID");
            /// <summary>
			/// 数据DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "ZJ_EXPERT_FINE_SCORE", "数据DATA_KEY");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "ZJ_EXPERT_FINE_SCORE", "数据来源");
            /// <summary>
			/// M_CREATEBY
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "ZJ_EXPERT_FINE_SCORE", "M_CREATEBY");
            /// <summary>
			/// M_TM
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "ZJ_EXPERT_FINE_SCORE", "M_TM");
            /// <summary>
			/// M_CREATE_TM
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "ZJ_EXPERT_FINE_SCORE", "M_CREATE_TM");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "ZJ_EXPERT_FINE_SCORE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "ZJ_EXPERT_FINE_SCORE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "ZJ_EXPERT_FINE_SCORE", "");
        }
        #endregion
	}
}