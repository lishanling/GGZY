using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类BID_DEAL_ANNOUNCE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("BID_DEAL_ANNOUNCE")]
    [Serializable]
    public partial class BID_DEAL_ANNOUNCE : FwEntity
    {
        #region Model
		private string _PURCHASE_PROJECT_CODE;
		private string _PURCHASE_PROJECT_NAME;
		private string _PURCHASE_SECTION_CODE;
		private string _UNIFIED_DEAL_CODE;
		private string _WIN_BID_BULLETIN_TITLE;
		private string _WIN_BID_BULLETIN_CONTENT;
		private DateTime? _WIN_BID_BULLETIN_START_TIME;
		private string _URL;
		private string _WINNINGBIDDER_NAME;
		private string _WINNINGBIDDER_CODE;
		private decimal? _WIN_BID_PRICE;
		private string _CURRENCY_CODE;
		private string _PRICE_UNIT;
		private string _CREATOR;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_ID;
		private string _M_ATT_WIN_BID_NOTICE;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _REGION_CODE;
		private string _TRA_PLACE_CODE;
		private string _PURCHASER_AGENCY_NAME;
		private string _PURCHASER_AGENCY_CODE;
		private string _WINNINGBIDDER_TYPE;
		private string _PRICE_FORM_CODE;
		private string _WIN_BID_RATE;
		private string _M_VERSION;

		/// <summary>
		/// 采购项目编号
		/// </summary>
		public string PURCHASE_PROJECT_CODE
		{
			get{ return _PURCHASE_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASE_PROJECT_CODE, _PURCHASE_PROJECT_CODE, value);
				this._PURCHASE_PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 采购项目名称
		/// </summary>
		public string PURCHASE_PROJECT_NAME
		{
			get{ return _PURCHASE_PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASE_PROJECT_NAME, _PURCHASE_PROJECT_NAME, value);
				this._PURCHASE_PROJECT_NAME = value;
			}
		}
		/// <summary>
		/// 采购项目子包编号
		/// </summary>
		public string PURCHASE_SECTION_CODE
		{
			get{ return _PURCHASE_SECTION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASE_SECTION_CODE, _PURCHASE_SECTION_CODE, value);
				this._PURCHASE_SECTION_CODE = value;
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
		/// 公告标题
		/// </summary>
		public string WIN_BID_BULLETIN_TITLE
		{
			get{ return _WIN_BID_BULLETIN_TITLE; }
			set
			{
				this.OnPropertyValueChange(_.WIN_BID_BULLETIN_TITLE, _WIN_BID_BULLETIN_TITLE, value);
				this._WIN_BID_BULLETIN_TITLE = value;
			}
		}
		/// <summary>
		/// 公告内容
		/// </summary>
		public string WIN_BID_BULLETIN_CONTENT
		{
			get{ return _WIN_BID_BULLETIN_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.WIN_BID_BULLETIN_CONTENT, _WIN_BID_BULLETIN_CONTENT, value);
				this._WIN_BID_BULLETIN_CONTENT = value;
			}
		}
		/// <summary>
		/// 首次公告时间
		/// </summary>
		public DateTime? WIN_BID_BULLETIN_START_TIME
		{
			get{ return _WIN_BID_BULLETIN_START_TIME; }
			set
			{
				this.OnPropertyValueChange(_.WIN_BID_BULLETIN_START_TIME, _WIN_BID_BULLETIN_START_TIME, value);
				this._WIN_BID_BULLETIN_START_TIME = value;
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
		/// 中标（成交）供应商名称
		/// </summary>
		public string WINNINGBIDDER_NAME
		{
			get{ return _WINNINGBIDDER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.WINNINGBIDDER_NAME, _WINNINGBIDDER_NAME, value);
				this._WINNINGBIDDER_NAME = value;
			}
		}
		/// <summary>
		/// 中标（成交）供应商代码
		/// </summary>
		public string WINNINGBIDDER_CODE
		{
			get{ return _WINNINGBIDDER_CODE; }
			set
			{
				this.OnPropertyValueChange(_.WINNINGBIDDER_CODE, _WINNINGBIDDER_CODE, value);
				this._WINNINGBIDDER_CODE = value;
			}
		}
		/// <summary>
		/// 中标（成交）价格
		/// </summary>
		public decimal? WIN_BID_PRICE
		{
			get{ return _WIN_BID_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.WIN_BID_PRICE, _WIN_BID_PRICE, value);
				this._WIN_BID_PRICE = value;
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
		/// 创建人
		/// </summary>
		public string CREATOR
		{
			get{ return _CREATOR; }
			set
			{
				this.OnPropertyValueChange(_.CREATOR, _CREATOR, value);
				this._CREATOR = value;
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
		/// 中标结果公告
		/// </summary>
		public string M_ATT_WIN_BID_NOTICE
		{
			get{ return _M_ATT_WIN_BID_NOTICE; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_WIN_BID_NOTICE, _M_ATT_WIN_BID_NOTICE, value);
				this._M_ATT_WIN_BID_NOTICE = value;
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
		/// 采购项目子包所在行政区域代码
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
		/// 采购代理机构名称
		/// </summary>
		public string PURCHASER_AGENCY_NAME
		{
			get{ return _PURCHASER_AGENCY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASER_AGENCY_NAME, _PURCHASER_AGENCY_NAME, value);
				this._PURCHASER_AGENCY_NAME = value;
			}
		}
		/// <summary>
		/// 采购代理机构代码
		/// </summary>
		public string PURCHASER_AGENCY_CODE
		{
			get{ return _PURCHASER_AGENCY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASER_AGENCY_CODE, _PURCHASER_AGENCY_CODE, value);
				this._PURCHASER_AGENCY_CODE = value;
			}
		}
		/// <summary>
		/// 中标（成交）供应商类别
		/// </summary>
		public string WINNINGBIDDER_TYPE
		{
			get{ return _WINNINGBIDDER_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.WINNINGBIDDER_TYPE, _WINNINGBIDDER_TYPE, value);
				this._WINNINGBIDDER_TYPE = value;
			}
		}
		/// <summary>
		/// 价款形式代码
		/// </summary>
		public string PRICE_FORM_CODE
		{
			get{ return _PRICE_FORM_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PRICE_FORM_CODE, _PRICE_FORM_CODE, value);
				this._PRICE_FORM_CODE = value;
			}
		}
		/// <summary>
		/// 中标优惠率或其它类型价格
		/// </summary>
		public string WIN_BID_RATE
		{
			get{ return _WIN_BID_RATE; }
			set
			{
				this.OnPropertyValueChange(_.WIN_BID_RATE, _WIN_BID_RATE, value);
				this._WIN_BID_RATE = value;
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
				_.PURCHASE_PROJECT_CODE,
				_.PURCHASE_PROJECT_NAME,
				_.PURCHASE_SECTION_CODE,
				_.UNIFIED_DEAL_CODE,
				_.WIN_BID_BULLETIN_TITLE,
				_.WIN_BID_BULLETIN_CONTENT,
				_.WIN_BID_BULLETIN_START_TIME,
				_.URL,
				_.WINNINGBIDDER_NAME,
				_.WINNINGBIDDER_CODE,
				_.WIN_BID_PRICE,
				_.CURRENCY_CODE,
				_.PRICE_UNIT,
				_.CREATOR,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_ID,
				_.M_ATT_WIN_BID_NOTICE,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.REGION_CODE,
				_.TRA_PLACE_CODE,
				_.PURCHASER_AGENCY_NAME,
				_.PURCHASER_AGENCY_CODE,
				_.WINNINGBIDDER_TYPE,
				_.PRICE_FORM_CODE,
				_.WIN_BID_RATE,
				_.M_VERSION,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._PURCHASE_PROJECT_CODE,
				this._PURCHASE_PROJECT_NAME,
				this._PURCHASE_SECTION_CODE,
				this._UNIFIED_DEAL_CODE,
				this._WIN_BID_BULLETIN_TITLE,
				this._WIN_BID_BULLETIN_CONTENT,
				this._WIN_BID_BULLETIN_START_TIME,
				this._URL,
				this._WINNINGBIDDER_NAME,
				this._WINNINGBIDDER_CODE,
				this._WIN_BID_PRICE,
				this._CURRENCY_CODE,
				this._PRICE_UNIT,
				this._CREATOR,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_ID,
				this._M_ATT_WIN_BID_NOTICE,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._REGION_CODE,
				this._TRA_PLACE_CODE,
				this._PURCHASER_AGENCY_NAME,
				this._PURCHASER_AGENCY_CODE,
				this._WINNINGBIDDER_TYPE,
				this._PRICE_FORM_CODE,
				this._WIN_BID_RATE,
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
			public readonly static Field All = new Field("*", "BID_DEAL_ANNOUNCE");
            /// <summary>
			/// 采购项目编号
			/// </summary>
			public readonly static Field PURCHASE_PROJECT_CODE = new Field("PURCHASE_PROJECT_CODE", "BID_DEAL_ANNOUNCE", "采购项目编号");
            /// <summary>
			/// 采购项目名称
			/// </summary>
			public readonly static Field PURCHASE_PROJECT_NAME = new Field("PURCHASE_PROJECT_NAME", "BID_DEAL_ANNOUNCE", "采购项目名称");
            /// <summary>
			/// 采购项目子包编号
			/// </summary>
			public readonly static Field PURCHASE_SECTION_CODE = new Field("PURCHASE_SECTION_CODE", "BID_DEAL_ANNOUNCE", "采购项目子包编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "BID_DEAL_ANNOUNCE", "统一交易标识码");
            /// <summary>
			/// 公告标题
			/// </summary>
			public readonly static Field WIN_BID_BULLETIN_TITLE = new Field("WIN_BID_BULLETIN_TITLE", "BID_DEAL_ANNOUNCE", "公告标题");
            /// <summary>
			/// 公告内容
			/// </summary>
			public readonly static Field WIN_BID_BULLETIN_CONTENT = new Field("WIN_BID_BULLETIN_CONTENT", "BID_DEAL_ANNOUNCE",DbType.AnsiString, null, "公告内容");
            /// <summary>
			/// 首次公告时间
			/// </summary>
			public readonly static Field WIN_BID_BULLETIN_START_TIME = new Field("WIN_BID_BULLETIN_START_TIME", "BID_DEAL_ANNOUNCE", "首次公告时间");
            /// <summary>
			/// 公告源URL
			/// </summary>
			public readonly static Field URL = new Field("URL", "BID_DEAL_ANNOUNCE", "公告源URL");
            /// <summary>
			/// 中标（成交）供应商名称
			/// </summary>
			public readonly static Field WINNINGBIDDER_NAME = new Field("WINNINGBIDDER_NAME", "BID_DEAL_ANNOUNCE", "中标（成交）供应商名称");
            /// <summary>
			/// 中标（成交）供应商代码
			/// </summary>
			public readonly static Field WINNINGBIDDER_CODE = new Field("WINNINGBIDDER_CODE", "BID_DEAL_ANNOUNCE", "中标（成交）供应商代码");
            /// <summary>
			/// 中标（成交）价格
			/// </summary>
			public readonly static Field WIN_BID_PRICE = new Field("WIN_BID_PRICE", "BID_DEAL_ANNOUNCE", "中标（成交）价格");
            /// <summary>
			/// 价格币种代码
			/// </summary>
			public readonly static Field CURRENCY_CODE = new Field("CURRENCY_CODE", "BID_DEAL_ANNOUNCE", "价格币种代码");
            /// <summary>
			/// 价格单位
			/// </summary>
			public readonly static Field PRICE_UNIT = new Field("PRICE_UNIT", "BID_DEAL_ANNOUNCE", "价格单位");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATOR = new Field("CREATOR", "BID_DEAL_ANNOUNCE", "创建人");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "BID_DEAL_ANNOUNCE", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "BID_DEAL_ANNOUNCE", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "BID_DEAL_ANNOUNCE", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "BID_DEAL_ANNOUNCE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "BID_DEAL_ANNOUNCE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "BID_DEAL_ANNOUNCE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "BID_DEAL_ANNOUNCE", "");
            /// <summary>
			/// 中标结果公告
			/// </summary>
			public readonly static Field M_ATT_WIN_BID_NOTICE = new Field("M_ATT_WIN_BID_NOTICE", "BID_DEAL_ANNOUNCE", "中标结果公告");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "BID_DEAL_ANNOUNCE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "BID_DEAL_ANNOUNCE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "BID_DEAL_ANNOUNCE", "");
            /// <summary>
			/// 采购项目子包所在行政区域代码
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "BID_DEAL_ANNOUNCE", "采购项目子包所在行政区域代码");
            /// <summary>
			/// 交易发生行政区域代码
			/// </summary>
			public readonly static Field TRA_PLACE_CODE = new Field("TRA_PLACE_CODE", "BID_DEAL_ANNOUNCE", "交易发生行政区域代码");
            /// <summary>
			/// 采购代理机构名称
			/// </summary>
			public readonly static Field PURCHASER_AGENCY_NAME = new Field("PURCHASER_AGENCY_NAME", "BID_DEAL_ANNOUNCE", "采购代理机构名称");
            /// <summary>
			/// 采购代理机构代码
			/// </summary>
			public readonly static Field PURCHASER_AGENCY_CODE = new Field("PURCHASER_AGENCY_CODE", "BID_DEAL_ANNOUNCE", "采购代理机构代码");
            /// <summary>
			/// 中标（成交）供应商类别
			/// </summary>
			public readonly static Field WINNINGBIDDER_TYPE = new Field("WINNINGBIDDER_TYPE", "BID_DEAL_ANNOUNCE", "中标（成交）供应商类别");
            /// <summary>
			/// 价款形式代码
			/// </summary>
			public readonly static Field PRICE_FORM_CODE = new Field("PRICE_FORM_CODE", "BID_DEAL_ANNOUNCE", "价款形式代码");
            /// <summary>
			/// 中标优惠率或其它类型价格
			/// </summary>
			public readonly static Field WIN_BID_RATE = new Field("WIN_BID_RATE", "BID_DEAL_ANNOUNCE", "中标优惠率或其它类型价格");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "BID_DEAL_ANNOUNCE", "");
        }
        #endregion
	}
}