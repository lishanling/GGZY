using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类STOCK_TRADE_RESULT_PRE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("STOCK_TRADE_RESULT_PRE")]
    [Serializable]
    public partial class STOCK_TRADE_RESULT_PRE : FwEntity
    {
        #region Model
		private string _PROJECT_NAME;
		private string _PROJECT_CODE;
		private string _UNIFIED_DEAL_CODE;
		private string _EXCHANGE_TYPE;
		private string _SELLER_NAME;
		private string _SELLER_CODE;
		private string _SELLER_TYPE;
		private string _SELLER_ROLE;
		private decimal? _OBJECT_EVALUATE_VALUE;
		private decimal? _TRADE_VALUE;
		private DateTime? _TRADE_DATE;
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
		/// 交易方式
		/// </summary>
		public string EXCHANGE_TYPE
		{
			get{ return _EXCHANGE_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.EXCHANGE_TYPE, _EXCHANGE_TYPE, value);
				this._EXCHANGE_TYPE = value;
			}
		}
		/// <summary>
		/// 受让方名称
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
		/// 受让方代码
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
		/// 受让方类别
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
		/// 受让方角色
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
		/// 转让标的评估值
		/// </summary>
		public decimal? OBJECT_EVALUATE_VALUE
		{
			get{ return _OBJECT_EVALUATE_VALUE; }
			set
			{
				this.OnPropertyValueChange(_.OBJECT_EVALUATE_VALUE, _OBJECT_EVALUATE_VALUE, value);
				this._OBJECT_EVALUATE_VALUE = value;
			}
		}
		/// <summary>
		/// 成交金额
		/// </summary>
		public decimal? TRADE_VALUE
		{
			get{ return _TRADE_VALUE; }
			set
			{
				this.OnPropertyValueChange(_.TRADE_VALUE, _TRADE_VALUE, value);
				this._TRADE_VALUE = value;
			}
		}
		/// <summary>
		/// 成交日期
		/// </summary>
		public DateTime? TRADE_DATE
		{
			get{ return _TRADE_DATE; }
			set
			{
				this.OnPropertyValueChange(_.TRADE_DATE, _TRADE_DATE, value);
				this._TRADE_DATE = value;
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
		/// 成交金额币种代码
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
		/// 成交金额单位
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
				_.EXCHANGE_TYPE,
				_.SELLER_NAME,
				_.SELLER_CODE,
				_.SELLER_TYPE,
				_.SELLER_ROLE,
				_.OBJECT_EVALUATE_VALUE,
				_.TRADE_VALUE,
				_.TRADE_DATE,
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
				this._EXCHANGE_TYPE,
				this._SELLER_NAME,
				this._SELLER_CODE,
				this._SELLER_TYPE,
				this._SELLER_ROLE,
				this._OBJECT_EVALUATE_VALUE,
				this._TRADE_VALUE,
				this._TRADE_DATE,
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
			public readonly static Field All = new Field("*", "STOCK_TRADE_RESULT_PRE");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field PROJECT_NAME = new Field("PROJECT_NAME", "STOCK_TRADE_RESULT_PRE", "项目名称");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "STOCK_TRADE_RESULT_PRE", "项目编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "STOCK_TRADE_RESULT_PRE", "统一交易标识码");
            /// <summary>
			/// 交易方式
			/// </summary>
			public readonly static Field EXCHANGE_TYPE = new Field("EXCHANGE_TYPE", "STOCK_TRADE_RESULT_PRE", "交易方式");
            /// <summary>
			/// 受让方名称
			/// </summary>
			public readonly static Field SELLER_NAME = new Field("SELLER_NAME", "STOCK_TRADE_RESULT_PRE", "受让方名称");
            /// <summary>
			/// 受让方代码
			/// </summary>
			public readonly static Field SELLER_CODE = new Field("SELLER_CODE", "STOCK_TRADE_RESULT_PRE", "受让方代码");
            /// <summary>
			/// 受让方类别
			/// </summary>
			public readonly static Field SELLER_TYPE = new Field("SELLER_TYPE", "STOCK_TRADE_RESULT_PRE", "受让方类别");
            /// <summary>
			/// 受让方角色
			/// </summary>
			public readonly static Field SELLER_ROLE = new Field("SELLER_ROLE", "STOCK_TRADE_RESULT_PRE", "受让方角色");
            /// <summary>
			/// 转让标的评估值
			/// </summary>
			public readonly static Field OBJECT_EVALUATE_VALUE = new Field("OBJECT_EVALUATE_VALUE", "STOCK_TRADE_RESULT_PRE", "转让标的评估值");
            /// <summary>
			/// 成交金额
			/// </summary>
			public readonly static Field TRADE_VALUE = new Field("TRADE_VALUE", "STOCK_TRADE_RESULT_PRE", "成交金额");
            /// <summary>
			/// 成交日期
			/// </summary>
			public readonly static Field TRADE_DATE = new Field("TRADE_DATE", "STOCK_TRADE_RESULT_PRE", "成交日期");
            /// <summary>
			/// 在交易机构网站进行挂牌信息披露的链接
			/// </summary>
			public readonly static Field PROJECT_URL = new Field("PROJECT_URL", "STOCK_TRADE_RESULT_PRE", "在交易机构网站进行挂牌信息披露的链接");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "STOCK_TRADE_RESULT_PRE", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "STOCK_TRADE_RESULT_PRE", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "STOCK_TRADE_RESULT_PRE", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "STOCK_TRADE_RESULT_PRE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "STOCK_TRADE_RESULT_PRE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "STOCK_TRADE_RESULT_PRE", "");
            /// <summary>
			/// 成交金额币种代码
			/// </summary>
			public readonly static Field CURRENCY_CODE = new Field("CURRENCY_CODE", "STOCK_TRADE_RESULT_PRE", "成交金额币种代码");
            /// <summary>
			/// 成交金额单位
			/// </summary>
			public readonly static Field PRICE_UNIT = new Field("PRICE_UNIT", "STOCK_TRADE_RESULT_PRE", "成交金额单位");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "STOCK_TRADE_RESULT_PRE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "STOCK_TRADE_RESULT_PRE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "STOCK_TRADE_RESULT_PRE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "STOCK_TRADE_RESULT_PRE", "");
        }
        #endregion
	}
}