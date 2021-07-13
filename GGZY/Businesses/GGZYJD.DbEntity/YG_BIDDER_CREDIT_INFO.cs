using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类YG_BIDDER_CREDIT_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("YG_BIDDER_CREDIT_INFO")]
    [Serializable]
    public partial class YG_BIDDER_CREDIT_INFO : JdEntity
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
		private string _SCORE_SYSTEM_NAME;
		private decimal? _SCORE_YEAR;
		private decimal? _SCORE_QUARTER;
		private decimal? _SCORE_MONTH;
		private decimal? _SCORE_DAY;
		private decimal? _SCORE;
		private decimal? _PROJECT_RANK;
		private decimal? _PROVINCE_RANK;
		private string _REMARK;
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
		/// 应用信用分系统名称
		/// </summary>
		public string SCORE_SYSTEM_NAME
		{
			get{ return _SCORE_SYSTEM_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SCORE_SYSTEM_NAME, _SCORE_SYSTEM_NAME, value);
				this._SCORE_SYSTEM_NAME = value;
			}
		}
		/// <summary>
		/// 应用信用分年份
		/// </summary>
		public decimal? SCORE_YEAR
		{
			get{ return _SCORE_YEAR; }
			set
			{
				this.OnPropertyValueChange(_.SCORE_YEAR, _SCORE_YEAR, value);
				this._SCORE_YEAR = value;
			}
		}
		/// <summary>
		/// 应用信用分季度
		/// </summary>
		public decimal? SCORE_QUARTER
		{
			get{ return _SCORE_QUARTER; }
			set
			{
				this.OnPropertyValueChange(_.SCORE_QUARTER, _SCORE_QUARTER, value);
				this._SCORE_QUARTER = value;
			}
		}
		/// <summary>
		/// 应用信用分月份
		/// </summary>
		public decimal? SCORE_MONTH
		{
			get{ return _SCORE_MONTH; }
			set
			{
				this.OnPropertyValueChange(_.SCORE_MONTH, _SCORE_MONTH, value);
				this._SCORE_MONTH = value;
			}
		}
		/// <summary>
		/// 应用信用分天
		/// </summary>
		public decimal? SCORE_DAY
		{
			get{ return _SCORE_DAY; }
			set
			{
				this.OnPropertyValueChange(_.SCORE_DAY, _SCORE_DAY, value);
				this._SCORE_DAY = value;
			}
		}
		/// <summary>
		/// 信用分数
		/// </summary>
		public decimal? SCORE
		{
			get{ return _SCORE; }
			set
			{
				this.OnPropertyValueChange(_.SCORE, _SCORE, value);
				this._SCORE = value;
			}
		}
		/// <summary>
		/// 信用排名(本项目所有投标人)
		/// </summary>
		public decimal? PROJECT_RANK
		{
			get{ return _PROJECT_RANK; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_RANK, _PROJECT_RANK, value);
				this._PROJECT_RANK = value;
			}
		}
		/// <summary>
		/// 信用排名(全省企业)
		/// </summary>
		public decimal? PROVINCE_RANK
		{
			get{ return _PROVINCE_RANK; }
			set
			{
				this.OnPropertyValueChange(_.PROVINCE_RANK, _PROVINCE_RANK, value);
				this._PROVINCE_RANK = value;
			}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string REMARK
		{
			get{ return _REMARK; }
			set
			{
				this.OnPropertyValueChange(_.REMARK, _REMARK, value);
				this._REMARK = value;
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
				_.SCORE_SYSTEM_NAME,
				_.SCORE_YEAR,
				_.SCORE_QUARTER,
				_.SCORE_MONTH,
				_.SCORE_DAY,
				_.SCORE,
				_.PROJECT_RANK,
				_.PROVINCE_RANK,
				_.REMARK,
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
				this._SCORE_SYSTEM_NAME,
				this._SCORE_YEAR,
				this._SCORE_QUARTER,
				this._SCORE_MONTH,
				this._SCORE_DAY,
				this._SCORE,
				this._PROJECT_RANK,
				this._PROVINCE_RANK,
				this._REMARK,
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
			public readonly static Field All = new Field("*", "YG_BIDDER_CREDIT_INFO");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "YG_BIDDER_CREDIT_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "YG_BIDDER_CREDIT_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "YG_BIDDER_CREDIT_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "YG_BIDDER_CREDIT_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "YG_BIDDER_CREDIT_INFO", "");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "YG_BIDDER_CREDIT_INFO", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "YG_BIDDER_CREDIT_INFO", "标段（包）编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "YG_BIDDER_CREDIT_INFO", "统一交易标识码");
            /// <summary>
			/// 投标人名称
			/// </summary>
			public readonly static Field BIDDER_NAME = new Field("BIDDER_NAME", "YG_BIDDER_CREDIT_INFO", "投标人名称");
            /// <summary>
			/// 投标人类别
			/// </summary>
			public readonly static Field BIDDER_CODE_TYPE = new Field("BIDDER_CODE_TYPE", "YG_BIDDER_CREDIT_INFO", "投标人类别");
            /// <summary>
			/// 投标人代码
			/// </summary>
			public readonly static Field BIDDER_ORG_CODE = new Field("BIDDER_ORG_CODE", "YG_BIDDER_CREDIT_INFO", "投标人代码");
            /// <summary>
			/// 投标人角色
			/// </summary>
			public readonly static Field BIDDER_ROLE = new Field("BIDDER_ROLE", "YG_BIDDER_CREDIT_INFO", "投标人角色");
            /// <summary>
			/// 联合体名称（如有）
			/// </summary>
			public readonly static Field UNION_ENTERPRISE_NAME = new Field("UNION_ENTERPRISE_NAME", "YG_BIDDER_CREDIT_INFO", "联合体名称（如有）");
            /// <summary>
			/// 联合体组织机构代码证（联合体招标时填写）
			/// </summary>
			public readonly static Field UNION_ORGAN_SET_CODE = new Field("UNION_ORGAN_SET_CODE", "YG_BIDDER_CREDIT_INFO", "联合体组织机构代码证（联合体招标时填写）");
            /// <summary>
			/// 联合体联系人（如有）
			/// </summary>
			public readonly static Field UNION_CONTACT_NAME = new Field("UNION_CONTACT_NAME", "YG_BIDDER_CREDIT_INFO", "联合体联系人（如有）");
            /// <summary>
			/// 联合体联系电话（如有）
			/// </summary>
			public readonly static Field UNION_CONTACT_PHONE = new Field("UNION_CONTACT_PHONE", "YG_BIDDER_CREDIT_INFO", "联合体联系电话（如有）");
            /// <summary>
			/// 应用信用分系统名称
			/// </summary>
			public readonly static Field SCORE_SYSTEM_NAME = new Field("SCORE_SYSTEM_NAME", "YG_BIDDER_CREDIT_INFO", "应用信用分系统名称");
            /// <summary>
			/// 应用信用分年份
			/// </summary>
			public readonly static Field SCORE_YEAR = new Field("SCORE_YEAR", "YG_BIDDER_CREDIT_INFO", "应用信用分年份");
            /// <summary>
			/// 应用信用分季度
			/// </summary>
			public readonly static Field SCORE_QUARTER = new Field("SCORE_QUARTER", "YG_BIDDER_CREDIT_INFO", "应用信用分季度");
            /// <summary>
			/// 应用信用分月份
			/// </summary>
			public readonly static Field SCORE_MONTH = new Field("SCORE_MONTH", "YG_BIDDER_CREDIT_INFO", "应用信用分月份");
            /// <summary>
			/// 应用信用分天
			/// </summary>
			public readonly static Field SCORE_DAY = new Field("SCORE_DAY", "YG_BIDDER_CREDIT_INFO", "应用信用分天");
            /// <summary>
			/// 信用分数
			/// </summary>
			public readonly static Field SCORE = new Field("SCORE", "YG_BIDDER_CREDIT_INFO", "信用分数");
            /// <summary>
			/// 信用排名(本项目所有投标人)
			/// </summary>
			public readonly static Field PROJECT_RANK = new Field("PROJECT_RANK", "YG_BIDDER_CREDIT_INFO", "信用排名(本项目所有投标人)");
            /// <summary>
			/// 信用排名(全省企业)
			/// </summary>
			public readonly static Field PROVINCE_RANK = new Field("PROVINCE_RANK", "YG_BIDDER_CREDIT_INFO", "信用排名(全省企业)");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "YG_BIDDER_CREDIT_INFO",DbType.AnsiString, null, "备注");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "YG_BIDDER_CREDIT_INFO", "交易系统标识码");
            /// <summary>
			/// 交易服务系统标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "YG_BIDDER_CREDIT_INFO", "交易服务系统标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "YG_BIDDER_CREDIT_INFO", "数据时间戳");
            /// <summary>
			/// 交易平台或发布工具标识码
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "YG_BIDDER_CREDIT_INFO", "交易平台或发布工具标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "YG_BIDDER_CREDIT_INFO", "公共服务平台标识码");
        }
        #endregion
	}
}