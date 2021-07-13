using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类SL_ITEM_CONTROL_PRICE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("SL_ITEM_CONTROL_PRICE")]
    [Serializable]
    public partial class SL_ITEM_CONTROL_PRICE : JdEntity
    {
        #region Model
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private string _PROJECT_NUMBER;
		private string _PROJECT_LIST_NAME;
		private string _UNIT;
		private string _QUANTITIES;
		private decimal? _UNIVALENT;
		private string _UNIVALENT_PRICE_UNIT;
		private decimal? _TOTLE;
		private string _TOTLE_PRICE_UNIT;
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private string _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private DateTime? _M_TM;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
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
		/// 编号
		/// </summary>
		public string PROJECT_NUMBER
		{
			get{ return _PROJECT_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_NUMBER, _PROJECT_NUMBER, value);
				this._PROJECT_NUMBER = value;
			}
		}
		/// <summary>
		/// 项目名称
		/// </summary>
		public string PROJECT_LIST_NAME
		{
			get{ return _PROJECT_LIST_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_LIST_NAME, _PROJECT_LIST_NAME, value);
				this._PROJECT_LIST_NAME = value;
			}
		}
		/// <summary>
		/// 单位
		/// </summary>
		public string UNIT
		{
			get{ return _UNIT; }
			set
			{
				this.OnPropertyValueChange(_.UNIT, _UNIT, value);
				this._UNIT = value;
			}
		}
		/// <summary>
		/// 工程量
		/// </summary>
		public string QUANTITIES
		{
			get{ return _QUANTITIES; }
			set
			{
				this.OnPropertyValueChange(_.QUANTITIES, _QUANTITIES, value);
				this._QUANTITIES = value;
			}
		}
		/// <summary>
		/// 单价
		/// </summary>
		public decimal? UNIVALENT
		{
			get{ return _UNIVALENT; }
			set
			{
				this.OnPropertyValueChange(_.UNIVALENT, _UNIVALENT, value);
				this._UNIVALENT = value;
			}
		}
		/// <summary>
		/// 单价金额单位
		/// </summary>
		public string UNIVALENT_PRICE_UNIT
		{
			get{ return _UNIVALENT_PRICE_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.UNIVALENT_PRICE_UNIT, _UNIVALENT_PRICE_UNIT, value);
				this._UNIVALENT_PRICE_UNIT = value;
			}
		}
		/// <summary>
		/// 合价
		/// </summary>
		public decimal? TOTLE
		{
			get{ return _TOTLE; }
			set
			{
				this.OnPropertyValueChange(_.TOTLE, _TOTLE, value);
				this._TOTLE = value;
			}
		}
		/// <summary>
		/// 合价金额单位
		/// </summary>
		public string TOTLE_PRICE_UNIT
		{
			get{ return _TOTLE_PRICE_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.TOTLE_PRICE_UNIT, _TOTLE_PRICE_UNIT, value);
				this._TOTLE_PRICE_UNIT = value;
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
				_.PROJECT_NUMBER,
				_.PROJECT_LIST_NAME,
				_.UNIT,
				_.QUANTITIES,
				_.UNIVALENT,
				_.UNIVALENT_PRICE_UNIT,
				_.TOTLE,
				_.TOTLE_PRICE_UNIT,
				_.M_ID,
				_.DATA_KEY,
				_.M_DATA_SOURCE,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_TM,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
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
				this._PROJECT_NUMBER,
				this._PROJECT_LIST_NAME,
				this._UNIT,
				this._QUANTITIES,
				this._UNIVALENT,
				this._UNIVALENT_PRICE_UNIT,
				this._TOTLE,
				this._TOTLE_PRICE_UNIT,
				this._M_ID,
				this._DATA_KEY,
				this._M_DATA_SOURCE,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._M_TM,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
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
			public readonly static Field All = new Field("*", "SL_ITEM_CONTROL_PRICE");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "SL_ITEM_CONTROL_PRICE", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "SL_ITEM_CONTROL_PRICE", "标段（包）编号");
            /// <summary>
			/// 编号
			/// </summary>
			public readonly static Field PROJECT_NUMBER = new Field("PROJECT_NUMBER", "SL_ITEM_CONTROL_PRICE", "编号");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field PROJECT_LIST_NAME = new Field("PROJECT_LIST_NAME", "SL_ITEM_CONTROL_PRICE", "项目名称");
            /// <summary>
			/// 单位
			/// </summary>
			public readonly static Field UNIT = new Field("UNIT", "SL_ITEM_CONTROL_PRICE", "单位");
            /// <summary>
			/// 工程量
			/// </summary>
			public readonly static Field QUANTITIES = new Field("QUANTITIES", "SL_ITEM_CONTROL_PRICE", "工程量");
            /// <summary>
			/// 单价
			/// </summary>
			public readonly static Field UNIVALENT = new Field("UNIVALENT", "SL_ITEM_CONTROL_PRICE", "单价");
            /// <summary>
			/// 单价金额单位
			/// </summary>
			public readonly static Field UNIVALENT_PRICE_UNIT = new Field("UNIVALENT_PRICE_UNIT", "SL_ITEM_CONTROL_PRICE", "单价金额单位");
            /// <summary>
			/// 合价
			/// </summary>
			public readonly static Field TOTLE = new Field("TOTLE", "SL_ITEM_CONTROL_PRICE", "合价");
            /// <summary>
			/// 合价金额单位
			/// </summary>
			public readonly static Field TOTLE_PRICE_UNIT = new Field("TOTLE_PRICE_UNIT", "SL_ITEM_CONTROL_PRICE", "合价金额单位");
            /// <summary>
			/// 数据自增长ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "SL_ITEM_CONTROL_PRICE", "数据自增长ID");
            /// <summary>
			/// 数据DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "SL_ITEM_CONTROL_PRICE", "数据DATA_KEY");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "SL_ITEM_CONTROL_PRICE", "数据来源");
            /// <summary>
			/// M_CREATEBY
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "SL_ITEM_CONTROL_PRICE", "M_CREATEBY");
            /// <summary>
			/// M_CREATE_TM
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "SL_ITEM_CONTROL_PRICE", "M_CREATE_TM");
            /// <summary>
			/// M_TM
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "SL_ITEM_CONTROL_PRICE", "M_TM");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "SL_ITEM_CONTROL_PRICE", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "SL_ITEM_CONTROL_PRICE", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "SL_ITEM_CONTROL_PRICE", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "SL_ITEM_CONTROL_PRICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "SL_ITEM_CONTROL_PRICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "SL_ITEM_CONTROL_PRICE", "");
        }
        #endregion
	}
}