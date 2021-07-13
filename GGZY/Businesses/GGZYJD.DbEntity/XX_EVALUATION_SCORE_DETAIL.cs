using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类XX_EVALUATION_SCORE_DETAIL。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("XX_EVALUATION_SCORE_DETAIL")]
    [Serializable]
    public partial class XX_EVALUATION_SCORE_DETAIL : JdEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _M_VERSION;
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private string _UNIFIED_DEAL_CODE;
		private string _BIDDER_NAME;
		private string _BIDDER_CODE_TYPE;
		private string _BIDDER_ORG_CODE;
		private string _BIDDER_ROLE;
		private string _UNION_ENTERPRISE_NAME;
		private string _UNION_ORGAN_SET_CODE;
		private string _UNION_CONTACT_NAME;
		private string _UNION_CONTACT_PHONE;
		private string _EXPERT_NAME;
		private string _ID_CARD;
		private decimal? _PRICE_POINTS;
		private decimal? _QUALIFICATION_POINTS;
		private decimal? _BUSINESS_POINTS;
		private decimal? _TECHNICAL_POINTS;
		private decimal? _RESPONSE_POINTS;
		private decimal? _OTHER_POINTS;
		private string _QUALIFICATION_DETAIL;
		private string _BUSINESS_DETAIL;
		private string _TECHNICAL_DETAIL;
		private string _RESPONSE_DETAIL;
		private string _OTHER_DETAIL;
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
		/// 投标人类别
		/// </summary>
		public string BIDDER_CODE_TYPE
		{
			get{ return _BIDDER_CODE_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_CODE_TYPE, _BIDDER_CODE_TYPE, value);
				this._BIDDER_CODE_TYPE = value;
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
		/// 投标人角色
		/// </summary>
		public string BIDDER_ROLE
		{
			get{ return _BIDDER_ROLE; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_ROLE, _BIDDER_ROLE, value);
				this._BIDDER_ROLE = value;
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
		/// 联合体联系人（如有）
		/// </summary>
		public string UNION_CONTACT_NAME
		{
			get{ return _UNION_CONTACT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.UNION_CONTACT_NAME, _UNION_CONTACT_NAME, value);
				this._UNION_CONTACT_NAME = value;
			}
		}
		/// <summary>
		/// 联合体联系电话（如有）
		/// </summary>
		public string UNION_CONTACT_PHONE
		{
			get{ return _UNION_CONTACT_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.UNION_CONTACT_PHONE, _UNION_CONTACT_PHONE, value);
				this._UNION_CONTACT_PHONE = value;
			}
		}
		/// <summary>
		/// 评标专家名称
		/// </summary>
		public string EXPERT_NAME
		{
			get{ return _EXPERT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.EXPERT_NAME, _EXPERT_NAME, value);
				this._EXPERT_NAME = value;
			}
		}
		/// <summary>
		/// 评标专家身份证号
		/// </summary>
		public string ID_CARD
		{
			get{ return _ID_CARD; }
			set
			{
				this.OnPropertyValueChange(_.ID_CARD, _ID_CARD, value);
				this._ID_CARD = value;
			}
		}
		/// <summary>
		/// 报价分
		/// </summary>
		public decimal? PRICE_POINTS
		{
			get{ return _PRICE_POINTS; }
			set
			{
				this.OnPropertyValueChange(_.PRICE_POINTS, _PRICE_POINTS, value);
				this._PRICE_POINTS = value;
			}
		}
		/// <summary>
		/// 资格分
		/// </summary>
		public decimal? QUALIFICATION_POINTS
		{
			get{ return _QUALIFICATION_POINTS; }
			set
			{
				this.OnPropertyValueChange(_.QUALIFICATION_POINTS, _QUALIFICATION_POINTS, value);
				this._QUALIFICATION_POINTS = value;
			}
		}
		/// <summary>
		/// 商务分
		/// </summary>
		public decimal? BUSINESS_POINTS
		{
			get{ return _BUSINESS_POINTS; }
			set
			{
				this.OnPropertyValueChange(_.BUSINESS_POINTS, _BUSINESS_POINTS, value);
				this._BUSINESS_POINTS = value;
			}
		}
		/// <summary>
		/// 技术分
		/// </summary>
		public decimal? TECHNICAL_POINTS
		{
			get{ return _TECHNICAL_POINTS; }
			set
			{
				this.OnPropertyValueChange(_.TECHNICAL_POINTS, _TECHNICAL_POINTS, value);
				this._TECHNICAL_POINTS = value;
			}
		}
		/// <summary>
		/// 响应性评审
		/// </summary>
		public decimal? RESPONSE_POINTS
		{
			get{ return _RESPONSE_POINTS; }
			set
			{
				this.OnPropertyValueChange(_.RESPONSE_POINTS, _RESPONSE_POINTS, value);
				this._RESPONSE_POINTS = value;
			}
		}
		/// <summary>
		/// 其他分
		/// </summary>
		public decimal? OTHER_POINTS
		{
			get{ return _OTHER_POINTS; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_POINTS, _OTHER_POINTS, value);
				this._OTHER_POINTS = value;
			}
		}
		/// <summary>
		/// 资格分明细
		/// </summary>
		public string QUALIFICATION_DETAIL
		{
			get{ return _QUALIFICATION_DETAIL; }
			set
			{
				this.OnPropertyValueChange(_.QUALIFICATION_DETAIL, _QUALIFICATION_DETAIL, value);
				this._QUALIFICATION_DETAIL = value;
			}
		}
		/// <summary>
		/// 商务分明细
		/// </summary>
		public string BUSINESS_DETAIL
		{
			get{ return _BUSINESS_DETAIL; }
			set
			{
				this.OnPropertyValueChange(_.BUSINESS_DETAIL, _BUSINESS_DETAIL, value);
				this._BUSINESS_DETAIL = value;
			}
		}
		/// <summary>
		/// 技术分明细
		/// </summary>
		public string TECHNICAL_DETAIL
		{
			get{ return _TECHNICAL_DETAIL; }
			set
			{
				this.OnPropertyValueChange(_.TECHNICAL_DETAIL, _TECHNICAL_DETAIL, value);
				this._TECHNICAL_DETAIL = value;
			}
		}
		/// <summary>
		/// 响应性评审
		/// </summary>
		public string RESPONSE_DETAIL
		{
			get{ return _RESPONSE_DETAIL; }
			set
			{
				this.OnPropertyValueChange(_.RESPONSE_DETAIL, _RESPONSE_DETAIL, value);
				this._RESPONSE_DETAIL = value;
			}
		}
		/// <summary>
		/// 其他文件
		/// </summary>
		public string OTHER_DETAIL
		{
			get{ return _OTHER_DETAIL; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_DETAIL, _OTHER_DETAIL, value);
				this._OTHER_DETAIL = value;
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
				_.BID_SECTION_CODE,
				_.UNIFIED_DEAL_CODE,
				_.BIDDER_NAME,
				_.BIDDER_CODE_TYPE,
				_.BIDDER_ORG_CODE,
				_.BIDDER_ROLE,
				_.UNION_ENTERPRISE_NAME,
				_.UNION_ORGAN_SET_CODE,
				_.UNION_CONTACT_NAME,
				_.UNION_CONTACT_PHONE,
				_.EXPERT_NAME,
				_.ID_CARD,
				_.PRICE_POINTS,
				_.QUALIFICATION_POINTS,
				_.BUSINESS_POINTS,
				_.TECHNICAL_POINTS,
				_.RESPONSE_POINTS,
				_.OTHER_POINTS,
				_.QUALIFICATION_DETAIL,
				_.BUSINESS_DETAIL,
				_.TECHNICAL_DETAIL,
				_.RESPONSE_DETAIL,
				_.OTHER_DETAIL,
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
				this._BID_SECTION_CODE,
				this._UNIFIED_DEAL_CODE,
				this._BIDDER_NAME,
				this._BIDDER_CODE_TYPE,
				this._BIDDER_ORG_CODE,
				this._BIDDER_ROLE,
				this._UNION_ENTERPRISE_NAME,
				this._UNION_ORGAN_SET_CODE,
				this._UNION_CONTACT_NAME,
				this._UNION_CONTACT_PHONE,
				this._EXPERT_NAME,
				this._ID_CARD,
				this._PRICE_POINTS,
				this._QUALIFICATION_POINTS,
				this._BUSINESS_POINTS,
				this._TECHNICAL_POINTS,
				this._RESPONSE_POINTS,
				this._OTHER_POINTS,
				this._QUALIFICATION_DETAIL,
				this._BUSINESS_DETAIL,
				this._TECHNICAL_DETAIL,
				this._RESPONSE_DETAIL,
				this._OTHER_DETAIL,
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
			public readonly static Field All = new Field("*", "XX_EVALUATION_SCORE_DETAIL");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "XX_EVALUATION_SCORE_DETAIL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "XX_EVALUATION_SCORE_DETAIL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "XX_EVALUATION_SCORE_DETAIL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "XX_EVALUATION_SCORE_DETAIL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "XX_EVALUATION_SCORE_DETAIL", "");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "XX_EVALUATION_SCORE_DETAIL", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "XX_EVALUATION_SCORE_DETAIL", "标段（包）编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "XX_EVALUATION_SCORE_DETAIL", "统一交易标识码");
            /// <summary>
			/// 投标人名称
			/// </summary>
			public readonly static Field BIDDER_NAME = new Field("BIDDER_NAME", "XX_EVALUATION_SCORE_DETAIL", "投标人名称");
            /// <summary>
			/// 投标人类别
			/// </summary>
			public readonly static Field BIDDER_CODE_TYPE = new Field("BIDDER_CODE_TYPE", "XX_EVALUATION_SCORE_DETAIL", "投标人类别");
            /// <summary>
			/// 投标人代码
			/// </summary>
			public readonly static Field BIDDER_ORG_CODE = new Field("BIDDER_ORG_CODE", "XX_EVALUATION_SCORE_DETAIL", "投标人代码");
            /// <summary>
			/// 投标人角色
			/// </summary>
			public readonly static Field BIDDER_ROLE = new Field("BIDDER_ROLE", "XX_EVALUATION_SCORE_DETAIL", "投标人角色");
            /// <summary>
			/// 联合体名称（如有）
			/// </summary>
			public readonly static Field UNION_ENTERPRISE_NAME = new Field("UNION_ENTERPRISE_NAME", "XX_EVALUATION_SCORE_DETAIL", "联合体名称（如有）");
            /// <summary>
			/// 联合体组织机构代码证（联合体招标时填写）
			/// </summary>
			public readonly static Field UNION_ORGAN_SET_CODE = new Field("UNION_ORGAN_SET_CODE", "XX_EVALUATION_SCORE_DETAIL", "联合体组织机构代码证（联合体招标时填写）");
            /// <summary>
			/// 联合体联系人（如有）
			/// </summary>
			public readonly static Field UNION_CONTACT_NAME = new Field("UNION_CONTACT_NAME", "XX_EVALUATION_SCORE_DETAIL", "联合体联系人（如有）");
            /// <summary>
			/// 联合体联系电话（如有）
			/// </summary>
			public readonly static Field UNION_CONTACT_PHONE = new Field("UNION_CONTACT_PHONE", "XX_EVALUATION_SCORE_DETAIL", "联合体联系电话（如有）");
            /// <summary>
			/// 评标专家名称
			/// </summary>
			public readonly static Field EXPERT_NAME = new Field("EXPERT_NAME", "XX_EVALUATION_SCORE_DETAIL", "评标专家名称");
            /// <summary>
			/// 评标专家身份证号
			/// </summary>
			public readonly static Field ID_CARD = new Field("ID_CARD", "XX_EVALUATION_SCORE_DETAIL", "评标专家身份证号");
            /// <summary>
			/// 报价分
			/// </summary>
			public readonly static Field PRICE_POINTS = new Field("PRICE_POINTS", "XX_EVALUATION_SCORE_DETAIL", "报价分");
            /// <summary>
			/// 资格分
			/// </summary>
			public readonly static Field QUALIFICATION_POINTS = new Field("QUALIFICATION_POINTS", "XX_EVALUATION_SCORE_DETAIL", "资格分");
            /// <summary>
			/// 商务分
			/// </summary>
			public readonly static Field BUSINESS_POINTS = new Field("BUSINESS_POINTS", "XX_EVALUATION_SCORE_DETAIL", "商务分");
            /// <summary>
			/// 技术分
			/// </summary>
			public readonly static Field TECHNICAL_POINTS = new Field("TECHNICAL_POINTS", "XX_EVALUATION_SCORE_DETAIL", "技术分");
            /// <summary>
			/// 响应性评审
			/// </summary>
			public readonly static Field RESPONSE_POINTS = new Field("RESPONSE_POINTS", "XX_EVALUATION_SCORE_DETAIL", "响应性评审");
            /// <summary>
			/// 其他分
			/// </summary>
			public readonly static Field OTHER_POINTS = new Field("OTHER_POINTS", "XX_EVALUATION_SCORE_DETAIL", "其他分");
            /// <summary>
			/// 资格分明细
			/// </summary>
			public readonly static Field QUALIFICATION_DETAIL = new Field("QUALIFICATION_DETAIL", "XX_EVALUATION_SCORE_DETAIL",DbType.AnsiString, null, "资格分明细");
            /// <summary>
			/// 商务分明细
			/// </summary>
			public readonly static Field BUSINESS_DETAIL = new Field("BUSINESS_DETAIL", "XX_EVALUATION_SCORE_DETAIL",DbType.AnsiString, null, "商务分明细");
            /// <summary>
			/// 技术分明细
			/// </summary>
			public readonly static Field TECHNICAL_DETAIL = new Field("TECHNICAL_DETAIL", "XX_EVALUATION_SCORE_DETAIL",DbType.AnsiString, null, "技术分明细");
            /// <summary>
			/// 响应性评审
			/// </summary>
			public readonly static Field RESPONSE_DETAIL = new Field("RESPONSE_DETAIL", "XX_EVALUATION_SCORE_DETAIL",DbType.AnsiString, null, "响应性评审");
            /// <summary>
			/// 其他文件
			/// </summary>
			public readonly static Field OTHER_DETAIL = new Field("OTHER_DETAIL", "XX_EVALUATION_SCORE_DETAIL",DbType.AnsiString, null, "其他文件");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "XX_EVALUATION_SCORE_DETAIL", "交易系统标识码");
            /// <summary>
			/// 交易服务系统标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "XX_EVALUATION_SCORE_DETAIL", "交易服务系统标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "XX_EVALUATION_SCORE_DETAIL", "数据时间戳");
            /// <summary>
			/// 交易平台或发布工具标识码
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "XX_EVALUATION_SCORE_DETAIL", "交易平台或发布工具标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "XX_EVALUATION_SCORE_DETAIL", "公共服务平台标识码");
        }
        #endregion
	}
}