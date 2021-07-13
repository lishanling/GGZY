using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类PURCHASE_CONTRACT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PURCHASE_CONTRACT")]
    [Serializable]
    public partial class PURCHASE_CONTRACT : FwEntity
    {
        #region Model
		private string _PURCHASE_PROJECT_CODE;
		private string _PURCHASE_PROJECT_NAME;
		private string _PURCHASE_SECTION_CODE;
		private string _UNIFIED_DEAL_CODE;
		private string _PURCHASER_NAME;
		private string _PURCHASER_CODE;
		private string _LEGAL_ROLE;
		private string _SUPPLIER_NAME;
		private string _SUPPLIER_CODE;
		private decimal? _CONTRACT_AMOUNT;
		private string _CURRENCY_CODE;
		private string _PRICE_UNIT;
		private decimal? _CONTRACT_TERM;
		private DateTime? _SIGNING_TIME;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _CONTRACT_NAME;
		private string _URL;
		private decimal? _M_ID;
		private string _M_ATT_CONTRACT;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
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
		/// 采购人名称
		/// </summary>
		public string PURCHASER_NAME
		{
			get{ return _PURCHASER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASER_NAME, _PURCHASER_NAME, value);
				this._PURCHASER_NAME = value;
			}
		}
		/// <summary>
		/// 采购人代码
		/// </summary>
		public string PURCHASER_CODE
		{
			get{ return _PURCHASER_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PURCHASER_CODE, _PURCHASER_CODE, value);
				this._PURCHASER_CODE = value;
			}
		}
		/// <summary>
		/// 采购人角色
		/// </summary>
		public string LEGAL_ROLE
		{
			get{ return _LEGAL_ROLE; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_ROLE, _LEGAL_ROLE, value);
				this._LEGAL_ROLE = value;
			}
		}
		/// <summary>
		/// 中标（成交）供应商名称
		/// </summary>
		public string SUPPLIER_NAME
		{
			get{ return _SUPPLIER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SUPPLIER_NAME, _SUPPLIER_NAME, value);
				this._SUPPLIER_NAME = value;
			}
		}
		/// <summary>
		/// 中标（成交）供应商代码
		/// </summary>
		public string SUPPLIER_CODE
		{
			get{ return _SUPPLIER_CODE; }
			set
			{
				this.OnPropertyValueChange(_.SUPPLIER_CODE, _SUPPLIER_CODE, value);
				this._SUPPLIER_CODE = value;
			}
		}
		/// <summary>
		/// 合同金额
		/// </summary>
		public decimal? CONTRACT_AMOUNT
		{
			get{ return _CONTRACT_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_AMOUNT, _CONTRACT_AMOUNT, value);
				this._CONTRACT_AMOUNT = value;
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
		/// 金额单位
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
		/// 合同期限
		/// </summary>
		public decimal? CONTRACT_TERM
		{
			get{ return _CONTRACT_TERM; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_TERM, _CONTRACT_TERM, value);
				this._CONTRACT_TERM = value;
			}
		}
		/// <summary>
		/// 合同签署时间
		/// </summary>
		public DateTime? SIGNING_TIME
		{
			get{ return _SIGNING_TIME; }
			set
			{
				this.OnPropertyValueChange(_.SIGNING_TIME, _SIGNING_TIME, value);
				this._SIGNING_TIME = value;
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
		/// 合同名称
		/// </summary>
		public string CONTRACT_NAME
		{
			get{ return _CONTRACT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_NAME, _CONTRACT_NAME, value);
				this._CONTRACT_NAME = value;
			}
		}
		/// <summary>
		/// 合同源URL
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
		/// 合同
		/// </summary>
		public string M_ATT_CONTRACT
		{
			get{ return _M_ATT_CONTRACT; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_CONTRACT, _M_ATT_CONTRACT, value);
				this._M_ATT_CONTRACT = value;
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
		/// 优惠率或其它类型合同价格
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
				_.PURCHASER_NAME,
				_.PURCHASER_CODE,
				_.LEGAL_ROLE,
				_.SUPPLIER_NAME,
				_.SUPPLIER_CODE,
				_.CONTRACT_AMOUNT,
				_.CURRENCY_CODE,
				_.PRICE_UNIT,
				_.CONTRACT_TERM,
				_.SIGNING_TIME,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.CONTRACT_NAME,
				_.URL,
				_.M_ID,
				_.M_ATT_CONTRACT,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
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
				this._PURCHASER_NAME,
				this._PURCHASER_CODE,
				this._LEGAL_ROLE,
				this._SUPPLIER_NAME,
				this._SUPPLIER_CODE,
				this._CONTRACT_AMOUNT,
				this._CURRENCY_CODE,
				this._PRICE_UNIT,
				this._CONTRACT_TERM,
				this._SIGNING_TIME,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._CONTRACT_NAME,
				this._URL,
				this._M_ID,
				this._M_ATT_CONTRACT,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
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
			public readonly static Field All = new Field("*", "PURCHASE_CONTRACT");
            /// <summary>
			/// 采购项目编号
			/// </summary>
			public readonly static Field PURCHASE_PROJECT_CODE = new Field("PURCHASE_PROJECT_CODE", "PURCHASE_CONTRACT", "采购项目编号");
            /// <summary>
			/// 采购项目名称
			/// </summary>
			public readonly static Field PURCHASE_PROJECT_NAME = new Field("PURCHASE_PROJECT_NAME", "PURCHASE_CONTRACT", "采购项目名称");
            /// <summary>
			/// 采购项目子包编号
			/// </summary>
			public readonly static Field PURCHASE_SECTION_CODE = new Field("PURCHASE_SECTION_CODE", "PURCHASE_CONTRACT", "采购项目子包编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "PURCHASE_CONTRACT", "统一交易标识码");
            /// <summary>
			/// 采购人名称
			/// </summary>
			public readonly static Field PURCHASER_NAME = new Field("PURCHASER_NAME", "PURCHASE_CONTRACT", "采购人名称");
            /// <summary>
			/// 采购人代码
			/// </summary>
			public readonly static Field PURCHASER_CODE = new Field("PURCHASER_CODE", "PURCHASE_CONTRACT", "采购人代码");
            /// <summary>
			/// 采购人角色
			/// </summary>
			public readonly static Field LEGAL_ROLE = new Field("LEGAL_ROLE", "PURCHASE_CONTRACT", "采购人角色");
            /// <summary>
			/// 中标（成交）供应商名称
			/// </summary>
			public readonly static Field SUPPLIER_NAME = new Field("SUPPLIER_NAME", "PURCHASE_CONTRACT", "中标（成交）供应商名称");
            /// <summary>
			/// 中标（成交）供应商代码
			/// </summary>
			public readonly static Field SUPPLIER_CODE = new Field("SUPPLIER_CODE", "PURCHASE_CONTRACT", "中标（成交）供应商代码");
            /// <summary>
			/// 合同金额
			/// </summary>
			public readonly static Field CONTRACT_AMOUNT = new Field("CONTRACT_AMOUNT", "PURCHASE_CONTRACT", "合同金额");
            /// <summary>
			/// 价格币种代码
			/// </summary>
			public readonly static Field CURRENCY_CODE = new Field("CURRENCY_CODE", "PURCHASE_CONTRACT", "价格币种代码");
            /// <summary>
			/// 金额单位
			/// </summary>
			public readonly static Field PRICE_UNIT = new Field("PRICE_UNIT", "PURCHASE_CONTRACT", "金额单位");
            /// <summary>
			/// 合同期限
			/// </summary>
			public readonly static Field CONTRACT_TERM = new Field("CONTRACT_TERM", "PURCHASE_CONTRACT", "合同期限");
            /// <summary>
			/// 合同签署时间
			/// </summary>
			public readonly static Field SIGNING_TIME = new Field("SIGNING_TIME", "PURCHASE_CONTRACT", "合同签署时间");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "PURCHASE_CONTRACT", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "PURCHASE_CONTRACT", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "PURCHASE_CONTRACT", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "PURCHASE_CONTRACT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "PURCHASE_CONTRACT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "PURCHASE_CONTRACT", "");
            /// <summary>
			/// 合同名称
			/// </summary>
			public readonly static Field CONTRACT_NAME = new Field("CONTRACT_NAME", "PURCHASE_CONTRACT", "合同名称");
            /// <summary>
			/// 合同源URL
			/// </summary>
			public readonly static Field URL = new Field("URL", "PURCHASE_CONTRACT", "合同源URL");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "PURCHASE_CONTRACT", "");
            /// <summary>
			/// 合同
			/// </summary>
			public readonly static Field M_ATT_CONTRACT = new Field("M_ATT_CONTRACT", "PURCHASE_CONTRACT", "合同");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "PURCHASE_CONTRACT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "PURCHASE_CONTRACT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "PURCHASE_CONTRACT", "");
            /// <summary>
			/// 价款形式代码
			/// </summary>
			public readonly static Field PRICE_FORM_CODE = new Field("PRICE_FORM_CODE", "PURCHASE_CONTRACT", "价款形式代码");
            /// <summary>
			/// 优惠率或其它类型合同价格
			/// </summary>
			public readonly static Field WIN_BID_RATE = new Field("WIN_BID_RATE", "PURCHASE_CONTRACT", "优惠率或其它类型合同价格");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "PURCHASE_CONTRACT", "");
        }
        #endregion
	}
}