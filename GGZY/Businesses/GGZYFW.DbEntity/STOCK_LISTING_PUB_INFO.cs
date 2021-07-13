using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类STOCK_LISTING_PUB_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("STOCK_LISTING_PUB_INFO")]
    [Serializable]
    public partial class STOCK_LISTING_PUB_INFO : FwEntity
    {
        #region Model
		private string _PROJECT_NAME;
		private string _PROJECT_CODE;
		private string _UNIFIED_DEAL_CODE;
		private string _PROJECT_CLASSIFY_CODE;
		private string _SELLER_NAME;
		private string _SELLER_TYPE;
		private string _SELLER_CODE;
		private string _SELLER_ROLE;
		private string _AUTHORIZE_UNIT;
		private decimal? _TOTAL_PERCENT;
		private decimal? _PROJECT_PRICE;
		private decimal? _PUBLISH_DURATION;
		private DateTime? _PUBLISH_DATE;
		private string _POST_PONE;
		private string _PRE_EXCHANGE_TYPE;
		private string _MANAGEMENT_INTENT;
		private string _GIVEUP_PRIORITY;
		private string _IMPORTANT_INFO;
		private string _BUYER_POSTULATE;
		private string _OTHER_CONDITIONS;
		private string _PROJECT_URL;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _CURRENCY_CODE;
		private string _PRICE_UNIT;
		private decimal? _M_ID;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private decimal? _M_IS_PRE;
		private decimal? _M_ESTIMATE;
		private decimal? _M_IS_CUTPRICE;
		private string _M_ATTACHMENT;
		private decimal? _M_PRE_ID;
		private string _M_TRANSFER_RESULT;
		private string _M_ZONE;
		private string _M_OTHER_MATTER;
		private string _BID_CODE;
		private string _BID_NAME;
		private string _REGION_CODE;
		private string _TRA_PLACE_CODE;
		private string _TRA_AGENCY_NAME;
		private string _TRA_AGENCY_CODE;
		private string _M_VERSION;

		/// <summary>
		/// 项目名称
		/// </summary>
		public string PROJECT_NAME
		{
			get{ return _PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_NAME, _PROJECT_NAME, value);
				this._PROJECT_NAME = value;
			}
		}
		/// <summary>
		/// 项目编号
		/// </summary>
		public string PROJECT_CODE
		{
			get{ return _PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_CODE, _PROJECT_CODE, value);
				this._PROJECT_CODE = value;
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
		/// 项目分类代码
		/// </summary>
		public string PROJECT_CLASSIFY_CODE
		{
			get{ return _PROJECT_CLASSIFY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_CLASSIFY_CODE, _PROJECT_CLASSIFY_CODE, value);
				this._PROJECT_CLASSIFY_CODE = value;
			}
		}
		/// <summary>
		/// 转让方名称
		/// </summary>
		public string SELLER_NAME
		{
			get{ return _SELLER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SELLER_NAME, _SELLER_NAME, value);
				this._SELLER_NAME = value;
			}
		}
		/// <summary>
		/// 转让方类别
		/// </summary>
		public string SELLER_TYPE
		{
			get{ return _SELLER_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.SELLER_TYPE, _SELLER_TYPE, value);
				this._SELLER_TYPE = value;
			}
		}
		/// <summary>
		/// 转让方代码
		/// </summary>
		public string SELLER_CODE
		{
			get{ return _SELLER_CODE; }
			set
			{
				this.OnPropertyValueChange(_.SELLER_CODE, _SELLER_CODE, value);
				this._SELLER_CODE = value;
			}
		}
		/// <summary>
		/// 转让方角色
		/// </summary>
		public string SELLER_ROLE
		{
			get{ return _SELLER_ROLE; }
			set
			{
				this.OnPropertyValueChange(_.SELLER_ROLE, _SELLER_ROLE, value);
				this._SELLER_ROLE = value;
			}
		}
		/// <summary>
		/// 转让行为批准单位
		/// </summary>
		public string AUTHORIZE_UNIT
		{
			get{ return _AUTHORIZE_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.AUTHORIZE_UNIT, _AUTHORIZE_UNIT, value);
				this._AUTHORIZE_UNIT = value;
			}
		}
		/// <summary>
		/// 转让比例
		/// </summary>
		public decimal? TOTAL_PERCENT
		{
			get{ return _TOTAL_PERCENT; }
			set
			{
				this.OnPropertyValueChange(_.TOTAL_PERCENT, _TOTAL_PERCENT, value);
				this._TOTAL_PERCENT = value;
			}
		}
		/// <summary>
		/// 挂牌价格
		/// </summary>
		public decimal? PROJECT_PRICE
		{
			get{ return _PROJECT_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_PRICE, _PROJECT_PRICE, value);
				this._PROJECT_PRICE = value;
			}
		}
		/// <summary>
		/// 挂牌期间
		/// </summary>
		public decimal? PUBLISH_DURATION
		{
			get{ return _PUBLISH_DURATION; }
			set
			{
				this.OnPropertyValueChange(_.PUBLISH_DURATION, _PUBLISH_DURATION, value);
				this._PUBLISH_DURATION = value;
			}
		}
		/// <summary>
		/// 挂牌日期
		/// </summary>
		public DateTime? PUBLISH_DATE
		{
			get{ return _PUBLISH_DATE; }
			set
			{
				this.OnPropertyValueChange(_.PUBLISH_DATE, _PUBLISH_DATE, value);
				this._PUBLISH_DATE = value;
			}
		}
		/// <summary>
		/// 是否自动延期
		/// </summary>
		public string POST_PONE
		{
			get{ return _POST_PONE; }
			set
			{
				this.OnPropertyValueChange(_.POST_PONE, _POST_PONE, value);
				this._POST_PONE = value;
			}
		}
		/// <summary>
		/// 选择的竞价交易方式
		/// </summary>
		public string PRE_EXCHANGE_TYPE
		{
			get{ return _PRE_EXCHANGE_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.PRE_EXCHANGE_TYPE, _PRE_EXCHANGE_TYPE, value);
				this._PRE_EXCHANGE_TYPE = value;
			}
		}
		/// <summary>
		/// 管理层是否有收购意向
		/// </summary>
		public string MANAGEMENT_INTENT
		{
			get{ return _MANAGEMENT_INTENT; }
			set
			{
				this.OnPropertyValueChange(_.MANAGEMENT_INTENT, _MANAGEMENT_INTENT, value);
				this._MANAGEMENT_INTENT = value;
			}
		}
		/// <summary>
		/// 标的企业原股东是否放弃行使优先购买权
		/// </summary>
		public string GIVEUP_PRIORITY
		{
			get{ return _GIVEUP_PRIORITY; }
			set
			{
				this.OnPropertyValueChange(_.GIVEUP_PRIORITY, _GIVEUP_PRIORITY, value);
				this._GIVEUP_PRIORITY = value;
			}
		}
		/// <summary>
		/// 重要信息披露
		/// </summary>
		public string IMPORTANT_INFO
		{
			get{ return _IMPORTANT_INFO; }
			set
			{
				this.OnPropertyValueChange(_.IMPORTANT_INFO, _IMPORTANT_INFO, value);
				this._IMPORTANT_INFO = value;
			}
		}
		/// <summary>
		/// 受让方资格条件
		/// </summary>
		public string BUYER_POSTULATE
		{
			get{ return _BUYER_POSTULATE; }
			set
			{
				this.OnPropertyValueChange(_.BUYER_POSTULATE, _BUYER_POSTULATE, value);
				this._BUYER_POSTULATE = value;
			}
		}
		/// <summary>
		/// 与转让相关的其他条件
		/// </summary>
		public string OTHER_CONDITIONS
		{
			get{ return _OTHER_CONDITIONS; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_CONDITIONS, _OTHER_CONDITIONS, value);
				this._OTHER_CONDITIONS = value;
			}
		}
		/// <summary>
		/// 在交易机构网站进行挂牌信息披露的链接
		/// </summary>
		public string PROJECT_URL
		{
			get{ return _PROJECT_URL; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_URL, _PROJECT_URL, value);
				this._PROJECT_URL = value;
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
		/// 
		/// </summary>
		public string M_KEY
		{
			get{ return _M_KEY; }
			set
			{
				this.OnPropertyValueChange(_.M_KEY, _M_KEY, value);
				this._M_KEY = value;
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
		/// 价格币种代码
		/// </summary>
		public string CURRENCY_CODE
		{
			get{ return _CURRENCY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CURRENCY_CODE, _CURRENCY_CODE, value);
				this._CURRENCY_CODE = value;
			}
		}
		/// <summary>
		/// 价格单位
		/// </summary>
		public string PRICE_UNIT
		{
			get{ return _PRICE_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.PRICE_UNIT, _PRICE_UNIT, value);
				this._PRICE_UNIT = value;
			}
		}
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
		/// 是否有预披露
		/// </summary>
		public decimal? M_IS_PRE
		{
			get{ return _M_IS_PRE; }
			set
			{
				this.OnPropertyValueChange(_.M_IS_PRE, _M_IS_PRE, value);
				this._M_IS_PRE = value;
			}
		}
		/// <summary>
		/// 转让标的评估值
		/// </summary>
		public decimal? M_ESTIMATE
		{
			get{ return _M_ESTIMATE; }
			set
			{
				this.OnPropertyValueChange(_.M_ESTIMATE, _M_ESTIMATE, value);
				this._M_ESTIMATE = value;
			}
		}
		/// <summary>
		/// 是否降低转让底价
		/// </summary>
		public decimal? M_IS_CUTPRICE
		{
			get{ return _M_IS_CUTPRICE; }
			set
			{
				this.OnPropertyValueChange(_.M_IS_CUTPRICE, _M_IS_CUTPRICE, value);
				this._M_IS_CUTPRICE = value;
			}
		}
		/// <summary>
		/// 附件
		/// </summary>
		public string M_ATTACHMENT
		{
			get{ return _M_ATTACHMENT; }
			set
			{
				this.OnPropertyValueChange(_.M_ATTACHMENT, _M_ATTACHMENT, value);
				this._M_ATTACHMENT = value;
			}
		}
		/// <summary>
		/// 预披露ID
		/// </summary>
		public decimal? M_PRE_ID
		{
			get{ return _M_PRE_ID; }
			set
			{
				this.OnPropertyValueChange(_.M_PRE_ID, _M_PRE_ID, value);
				this._M_PRE_ID = value;
			}
		}
		/// <summary>
		/// 产权转让行为的决策及批准情况
		/// </summary>
		public string M_TRANSFER_RESULT
		{
			get{ return _M_TRANSFER_RESULT; }
			set
			{
				this.OnPropertyValueChange(_.M_TRANSFER_RESULT, _M_TRANSFER_RESULT, value);
				this._M_TRANSFER_RESULT = value;
			}
		}
		/// <summary>
		/// 转让标的所在地区
		/// </summary>
		public string M_ZONE
		{
			get{ return _M_ZONE; }
			set
			{
				this.OnPropertyValueChange(_.M_ZONE, _M_ZONE, value);
				this._M_ZONE = value;
			}
		}
		/// <summary>
		/// 其他需要披露的事项
		/// </summary>
		public string M_OTHER_MATTER
		{
			get{ return _M_OTHER_MATTER; }
			set
			{
				this.OnPropertyValueChange(_.M_OTHER_MATTER, _M_OTHER_MATTER, value);
				this._M_OTHER_MATTER = value;
			}
		}
		/// <summary>
		/// 标的编号
		/// </summary>
		public string BID_CODE
		{
			get{ return _BID_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BID_CODE, _BID_CODE, value);
				this._BID_CODE = value;
			}
		}
		/// <summary>
		/// 标的名称
		/// </summary>
		public string BID_NAME
		{
			get{ return _BID_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BID_NAME, _BID_NAME, value);
				this._BID_NAME = value;
			}
		}
		/// <summary>
		/// 标的所在行政区域代码
		/// </summary>
		public string REGION_CODE
		{
			get{ return _REGION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.REGION_CODE, _REGION_CODE, value);
				this._REGION_CODE = value;
			}
		}
		/// <summary>
		/// 交易发生行政区域代码
		/// </summary>
		public string TRA_PLACE_CODE
		{
			get{ return _TRA_PLACE_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TRA_PLACE_CODE, _TRA_PLACE_CODE, value);
				this._TRA_PLACE_CODE = value;
			}
		}
		/// <summary>
		/// 交易机构名称
		/// </summary>
		public string TRA_AGENCY_NAME
		{
			get{ return _TRA_AGENCY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TRA_AGENCY_NAME, _TRA_AGENCY_NAME, value);
				this._TRA_AGENCY_NAME = value;
			}
		}
		/// <summary>
		/// 交易机构代码
		/// </summary>
		public string TRA_AGENCY_CODE
		{
			get{ return _TRA_AGENCY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TRA_AGENCY_CODE, _TRA_AGENCY_CODE, value);
				this._TRA_AGENCY_CODE = value;
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
				_.PROJECT_NAME,
				_.PROJECT_CODE,
				_.UNIFIED_DEAL_CODE,
				_.PROJECT_CLASSIFY_CODE,
				_.SELLER_NAME,
				_.SELLER_TYPE,
				_.SELLER_CODE,
				_.SELLER_ROLE,
				_.AUTHORIZE_UNIT,
				_.TOTAL_PERCENT,
				_.PROJECT_PRICE,
				_.PUBLISH_DURATION,
				_.PUBLISH_DATE,
				_.POST_PONE,
				_.PRE_EXCHANGE_TYPE,
				_.MANAGEMENT_INTENT,
				_.GIVEUP_PRIORITY,
				_.IMPORTANT_INFO,
				_.BUYER_POSTULATE,
				_.OTHER_CONDITIONS,
				_.PROJECT_URL,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.CURRENCY_CODE,
				_.PRICE_UNIT,
				_.M_ID,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_IS_PRE,
				_.M_ESTIMATE,
				_.M_IS_CUTPRICE,
				_.M_ATTACHMENT,
				_.M_PRE_ID,
				_.M_TRANSFER_RESULT,
				_.M_ZONE,
				_.M_OTHER_MATTER,
				_.BID_CODE,
				_.BID_NAME,
				_.REGION_CODE,
				_.TRA_PLACE_CODE,
				_.TRA_AGENCY_NAME,
				_.TRA_AGENCY_CODE,
				_.M_VERSION,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._PROJECT_NAME,
				this._PROJECT_CODE,
				this._UNIFIED_DEAL_CODE,
				this._PROJECT_CLASSIFY_CODE,
				this._SELLER_NAME,
				this._SELLER_TYPE,
				this._SELLER_CODE,
				this._SELLER_ROLE,
				this._AUTHORIZE_UNIT,
				this._TOTAL_PERCENT,
				this._PROJECT_PRICE,
				this._PUBLISH_DURATION,
				this._PUBLISH_DATE,
				this._POST_PONE,
				this._PRE_EXCHANGE_TYPE,
				this._MANAGEMENT_INTENT,
				this._GIVEUP_PRIORITY,
				this._IMPORTANT_INFO,
				this._BUYER_POSTULATE,
				this._OTHER_CONDITIONS,
				this._PROJECT_URL,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._CURRENCY_CODE,
				this._PRICE_UNIT,
				this._M_ID,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._M_IS_PRE,
				this._M_ESTIMATE,
				this._M_IS_CUTPRICE,
				this._M_ATTACHMENT,
				this._M_PRE_ID,
				this._M_TRANSFER_RESULT,
				this._M_ZONE,
				this._M_OTHER_MATTER,
				this._BID_CODE,
				this._BID_NAME,
				this._REGION_CODE,
				this._TRA_PLACE_CODE,
				this._TRA_AGENCY_NAME,
				this._TRA_AGENCY_CODE,
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
			public readonly static Field All = new Field("*", "STOCK_LISTING_PUB_INFO");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field PROJECT_NAME = new Field("PROJECT_NAME", "STOCK_LISTING_PUB_INFO", "项目名称");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "STOCK_LISTING_PUB_INFO", "项目编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "STOCK_LISTING_PUB_INFO", "统一交易标识码");
            /// <summary>
			/// 项目分类代码
			/// </summary>
			public readonly static Field PROJECT_CLASSIFY_CODE = new Field("PROJECT_CLASSIFY_CODE", "STOCK_LISTING_PUB_INFO", "项目分类代码");
            /// <summary>
			/// 转让方名称
			/// </summary>
			public readonly static Field SELLER_NAME = new Field("SELLER_NAME", "STOCK_LISTING_PUB_INFO", "转让方名称");
            /// <summary>
			/// 转让方类别
			/// </summary>
			public readonly static Field SELLER_TYPE = new Field("SELLER_TYPE", "STOCK_LISTING_PUB_INFO", "转让方类别");
            /// <summary>
			/// 转让方代码
			/// </summary>
			public readonly static Field SELLER_CODE = new Field("SELLER_CODE", "STOCK_LISTING_PUB_INFO", "转让方代码");
            /// <summary>
			/// 转让方角色
			/// </summary>
			public readonly static Field SELLER_ROLE = new Field("SELLER_ROLE", "STOCK_LISTING_PUB_INFO", "转让方角色");
            /// <summary>
			/// 转让行为批准单位
			/// </summary>
			public readonly static Field AUTHORIZE_UNIT = new Field("AUTHORIZE_UNIT", "STOCK_LISTING_PUB_INFO", "转让行为批准单位");
            /// <summary>
			/// 转让比例
			/// </summary>
			public readonly static Field TOTAL_PERCENT = new Field("TOTAL_PERCENT", "STOCK_LISTING_PUB_INFO", "转让比例");
            /// <summary>
			/// 挂牌价格
			/// </summary>
			public readonly static Field PROJECT_PRICE = new Field("PROJECT_PRICE", "STOCK_LISTING_PUB_INFO", "挂牌价格");
            /// <summary>
			/// 挂牌期间
			/// </summary>
			public readonly static Field PUBLISH_DURATION = new Field("PUBLISH_DURATION", "STOCK_LISTING_PUB_INFO", "挂牌期间");
            /// <summary>
			/// 挂牌日期
			/// </summary>
			public readonly static Field PUBLISH_DATE = new Field("PUBLISH_DATE", "STOCK_LISTING_PUB_INFO", "挂牌日期");
            /// <summary>
			/// 是否自动延期
			/// </summary>
			public readonly static Field POST_PONE = new Field("POST_PONE", "STOCK_LISTING_PUB_INFO", "是否自动延期");
            /// <summary>
			/// 选择的竞价交易方式
			/// </summary>
			public readonly static Field PRE_EXCHANGE_TYPE = new Field("PRE_EXCHANGE_TYPE", "STOCK_LISTING_PUB_INFO", "选择的竞价交易方式");
            /// <summary>
			/// 管理层是否有收购意向
			/// </summary>
			public readonly static Field MANAGEMENT_INTENT = new Field("MANAGEMENT_INTENT", "STOCK_LISTING_PUB_INFO", "管理层是否有收购意向");
            /// <summary>
			/// 标的企业原股东是否放弃行使优先购买权
			/// </summary>
			public readonly static Field GIVEUP_PRIORITY = new Field("GIVEUP_PRIORITY", "STOCK_LISTING_PUB_INFO", "标的企业原股东是否放弃行使优先购买权");
            /// <summary>
			/// 重要信息披露
			/// </summary>
			public readonly static Field IMPORTANT_INFO = new Field("IMPORTANT_INFO", "STOCK_LISTING_PUB_INFO",DbType.AnsiString, null, "重要信息披露");
            /// <summary>
			/// 受让方资格条件
			/// </summary>
			public readonly static Field BUYER_POSTULATE = new Field("BUYER_POSTULATE", "STOCK_LISTING_PUB_INFO",DbType.AnsiString, null, "受让方资格条件");
            /// <summary>
			/// 与转让相关的其他条件
			/// </summary>
			public readonly static Field OTHER_CONDITIONS = new Field("OTHER_CONDITIONS", "STOCK_LISTING_PUB_INFO",DbType.AnsiString, null, "与转让相关的其他条件");
            /// <summary>
			/// 在交易机构网站进行挂牌信息披露的链接
			/// </summary>
			public readonly static Field PROJECT_URL = new Field("PROJECT_URL", "STOCK_LISTING_PUB_INFO",DbType.AnsiString, null, "在交易机构网站进行挂牌信息披露的链接");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "STOCK_LISTING_PUB_INFO", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "STOCK_LISTING_PUB_INFO", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "STOCK_LISTING_PUB_INFO", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "STOCK_LISTING_PUB_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "STOCK_LISTING_PUB_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "STOCK_LISTING_PUB_INFO", "");
            /// <summary>
			/// 价格币种代码
			/// </summary>
			public readonly static Field CURRENCY_CODE = new Field("CURRENCY_CODE", "STOCK_LISTING_PUB_INFO", "价格币种代码");
            /// <summary>
			/// 价格单位
			/// </summary>
			public readonly static Field PRICE_UNIT = new Field("PRICE_UNIT", "STOCK_LISTING_PUB_INFO", "价格单位");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "STOCK_LISTING_PUB_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "STOCK_LISTING_PUB_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "STOCK_LISTING_PUB_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "STOCK_LISTING_PUB_INFO", "");
            /// <summary>
			/// 是否有预披露
			/// </summary>
			public readonly static Field M_IS_PRE = new Field("M_IS_PRE", "STOCK_LISTING_PUB_INFO", "是否有预披露");
            /// <summary>
			/// 转让标的评估值
			/// </summary>
			public readonly static Field M_ESTIMATE = new Field("M_ESTIMATE", "STOCK_LISTING_PUB_INFO", "转让标的评估值");
            /// <summary>
			/// 是否降低转让底价
			/// </summary>
			public readonly static Field M_IS_CUTPRICE = new Field("M_IS_CUTPRICE", "STOCK_LISTING_PUB_INFO", "是否降低转让底价");
            /// <summary>
			/// 附件
			/// </summary>
			public readonly static Field M_ATTACHMENT = new Field("M_ATTACHMENT", "STOCK_LISTING_PUB_INFO", "附件");
            /// <summary>
			/// 预披露ID
			/// </summary>
			public readonly static Field M_PRE_ID = new Field("M_PRE_ID", "STOCK_LISTING_PUB_INFO", "预披露ID");
            /// <summary>
			/// 产权转让行为的决策及批准情况
			/// </summary>
			public readonly static Field M_TRANSFER_RESULT = new Field("M_TRANSFER_RESULT", "STOCK_LISTING_PUB_INFO", "产权转让行为的决策及批准情况");
            /// <summary>
			/// 转让标的所在地区
			/// </summary>
			public readonly static Field M_ZONE = new Field("M_ZONE", "STOCK_LISTING_PUB_INFO", "转让标的所在地区");
            /// <summary>
			/// 其他需要披露的事项
			/// </summary>
			public readonly static Field M_OTHER_MATTER = new Field("M_OTHER_MATTER", "STOCK_LISTING_PUB_INFO", "其他需要披露的事项");
            /// <summary>
			/// 标的编号
			/// </summary>
			public readonly static Field BID_CODE = new Field("BID_CODE", "STOCK_LISTING_PUB_INFO", "标的编号");
            /// <summary>
			/// 标的名称
			/// </summary>
			public readonly static Field BID_NAME = new Field("BID_NAME", "STOCK_LISTING_PUB_INFO", "标的名称");
            /// <summary>
			/// 标的所在行政区域代码
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "STOCK_LISTING_PUB_INFO", "标的所在行政区域代码");
            /// <summary>
			/// 交易发生行政区域代码
			/// </summary>
			public readonly static Field TRA_PLACE_CODE = new Field("TRA_PLACE_CODE", "STOCK_LISTING_PUB_INFO", "交易发生行政区域代码");
            /// <summary>
			/// 交易机构名称
			/// </summary>
			public readonly static Field TRA_AGENCY_NAME = new Field("TRA_AGENCY_NAME", "STOCK_LISTING_PUB_INFO", "交易机构名称");
            /// <summary>
			/// 交易机构代码
			/// </summary>
			public readonly static Field TRA_AGENCY_CODE = new Field("TRA_AGENCY_CODE", "STOCK_LISTING_PUB_INFO", "交易机构代码");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "STOCK_LISTING_PUB_INFO", "");
        }
        #endregion
	}
}