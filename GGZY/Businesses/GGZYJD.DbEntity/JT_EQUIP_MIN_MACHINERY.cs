using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类JT_EQUIP_MIN_MACHINERY。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("JT_EQUIP_MIN_MACHINERY")]
    [Serializable]
    public partial class JT_EQUIP_MIN_MACHINERY : JdEntity
    {
        #region Model
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODES;
		private string _TEST_ITEM;
		private string _EQUIPMENT_NAME;
		private string _EQUIPMENT_FUNCTION;
		private string _EQUIPMENT_UNIT;
		private string _EQUIPMENT_NUMBER;
		private string _REMARK;
		private string _EQUIPMENT_TYPE;
		private string _MAIN_EQUIPMENT;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private string _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private DateTime? _M_TM;
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
		/// 试验、检测项目
		/// </summary>
		public string TEST_ITEM
		{
			get{ return _TEST_ITEM; }
			set
			{
				this.OnPropertyValueChange(_.TEST_ITEM, _TEST_ITEM, value);
				this._TEST_ITEM = value;
			}
		}
		/// <summary>
		/// 设备名称
		/// </summary>
		public string EQUIPMENT_NAME
		{
			get{ return _EQUIPMENT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.EQUIPMENT_NAME, _EQUIPMENT_NAME, value);
				this._EQUIPMENT_NAME = value;
			}
		}
		/// <summary>
		/// 规格、功率及容量
		/// </summary>
		public string EQUIPMENT_FUNCTION
		{
			get{ return _EQUIPMENT_FUNCTION; }
			set
			{
				this.OnPropertyValueChange(_.EQUIPMENT_FUNCTION, _EQUIPMENT_FUNCTION, value);
				this._EQUIPMENT_FUNCTION = value;
			}
		}
		/// <summary>
		/// 单位
		/// </summary>
		public string EQUIPMENT_UNIT
		{
			get{ return _EQUIPMENT_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.EQUIPMENT_UNIT, _EQUIPMENT_UNIT, value);
				this._EQUIPMENT_UNIT = value;
			}
		}
		/// <summary>
		/// 数量要求
		/// </summary>
		public string EQUIPMENT_NUMBER
		{
			get{ return _EQUIPMENT_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.EQUIPMENT_NUMBER, _EQUIPMENT_NUMBER, value);
				this._EQUIPMENT_NUMBER = value;
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
		/// 分类
		/// </summary>
		public string EQUIPMENT_TYPE
		{
			get{ return _EQUIPMENT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.EQUIPMENT_TYPE, _EQUIPMENT_TYPE, value);
				this._EQUIPMENT_TYPE = value;
			}
		}
		/// <summary>
		/// 主要仪器设备
		/// </summary>
		public string MAIN_EQUIPMENT
		{
			get{ return _MAIN_EQUIPMENT; }
			set
			{
				this.OnPropertyValueChange(_.MAIN_EQUIPMENT, _MAIN_EQUIPMENT, value);
				this._MAIN_EQUIPMENT = value;
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
				_.BID_SECTION_CODES,
				_.TEST_ITEM,
				_.EQUIPMENT_NAME,
				_.EQUIPMENT_FUNCTION,
				_.EQUIPMENT_UNIT,
				_.EQUIPMENT_NUMBER,
				_.REMARK,
				_.EQUIPMENT_TYPE,
				_.MAIN_EQUIPMENT,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.M_ID,
				_.DATA_KEY,
				_.M_DATA_SOURCE,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_TM,
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
				this._BID_SECTION_CODES,
				this._TEST_ITEM,
				this._EQUIPMENT_NAME,
				this._EQUIPMENT_FUNCTION,
				this._EQUIPMENT_UNIT,
				this._EQUIPMENT_NUMBER,
				this._REMARK,
				this._EQUIPMENT_TYPE,
				this._MAIN_EQUIPMENT,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._M_ID,
				this._DATA_KEY,
				this._M_DATA_SOURCE,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._M_TM,
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
			public readonly static Field All = new Field("*", "JT_EQUIP_MIN_MACHINERY");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "JT_EQUIP_MIN_MACHINERY", "招标项目编号");
            /// <summary>
			/// 相关标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODES = new Field("BID_SECTION_CODES", "JT_EQUIP_MIN_MACHINERY",DbType.AnsiString, null, "相关标段（包）编号");
            /// <summary>
			/// 试验、检测项目
			/// </summary>
			public readonly static Field TEST_ITEM = new Field("TEST_ITEM", "JT_EQUIP_MIN_MACHINERY", "试验、检测项目");
            /// <summary>
			/// 设备名称
			/// </summary>
			public readonly static Field EQUIPMENT_NAME = new Field("EQUIPMENT_NAME", "JT_EQUIP_MIN_MACHINERY", "设备名称");
            /// <summary>
			/// 规格、功率及容量
			/// </summary>
			public readonly static Field EQUIPMENT_FUNCTION = new Field("EQUIPMENT_FUNCTION", "JT_EQUIP_MIN_MACHINERY", "规格、功率及容量");
            /// <summary>
			/// 单位
			/// </summary>
			public readonly static Field EQUIPMENT_UNIT = new Field("EQUIPMENT_UNIT", "JT_EQUIP_MIN_MACHINERY", "单位");
            /// <summary>
			/// 数量要求
			/// </summary>
			public readonly static Field EQUIPMENT_NUMBER = new Field("EQUIPMENT_NUMBER", "JT_EQUIP_MIN_MACHINERY", "数量要求");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "JT_EQUIP_MIN_MACHINERY",DbType.AnsiString, null, "备注");
            /// <summary>
			/// 分类
			/// </summary>
			public readonly static Field EQUIPMENT_TYPE = new Field("EQUIPMENT_TYPE", "JT_EQUIP_MIN_MACHINERY", "分类");
            /// <summary>
			/// 主要仪器设备
			/// </summary>
			public readonly static Field MAIN_EQUIPMENT = new Field("MAIN_EQUIPMENT", "JT_EQUIP_MIN_MACHINERY",DbType.AnsiString, null, "主要仪器设备");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "JT_EQUIP_MIN_MACHINERY", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "JT_EQUIP_MIN_MACHINERY", "公共服务平台标识码");
            /// <summary>
			/// 数据自增长ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "JT_EQUIP_MIN_MACHINERY", "数据自增长ID");
            /// <summary>
			/// 数据DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "JT_EQUIP_MIN_MACHINERY", "数据DATA_KEY");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "JT_EQUIP_MIN_MACHINERY", "数据来源");
            /// <summary>
			/// M_CREATEBY
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "JT_EQUIP_MIN_MACHINERY", "M_CREATEBY");
            /// <summary>
			/// M_CREATE_TM
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "JT_EQUIP_MIN_MACHINERY", "M_CREATE_TM");
            /// <summary>
			/// M_TM
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "JT_EQUIP_MIN_MACHINERY", "M_TM");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "JT_EQUIP_MIN_MACHINERY", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "JT_EQUIP_MIN_MACHINERY", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "JT_EQUIP_MIN_MACHINERY", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "JT_EQUIP_MIN_MACHINERY", "");
        }
        #endregion
	}
}