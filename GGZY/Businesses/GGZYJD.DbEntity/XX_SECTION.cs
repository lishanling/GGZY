using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类XX_SECTION。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("XX_SECTION")]
    [Serializable]
    public partial class XX_SECTION : JdEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _M_VERSION;
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private string _BID_SECTION_NAME;
		private decimal? _BID_ECTION_NUM;
		private string _UNIFIED_DEAL_CODE;
		private string _BID_TENDER_MODE;
		private string _REGION_CODE;
		private string _TRA_PLACE_CODE;
		private string _BID_SECTION_CONTENT;
		private string _TENDER_PROJECT_CLASSIFY_CODE;
		private decimal? _CONTRACT_RECKON_PRICE;
		private string _CURRENCY_CODE;
		private string _PRICE_UNIT;
		private string _BID_QUALIFICATION;
		private DateTime? _BEGIN_DATE;
		private decimal? _LIMITE_TIME;
		private DateTime? _CREATE_TIME;
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
		/// 标段（包）名称
		/// </summary>
		public string BID_SECTION_NAME
		{
			get{ return _BID_SECTION_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_NAME, _BID_SECTION_NAME, value);
				this._BID_SECTION_NAME = value;
			}
		}
		/// <summary>
		/// 标段（包）招标次数
		/// </summary>
		public decimal? BID_ECTION_NUM
		{
			get{ return _BID_ECTION_NUM; }
			set
			{
				this.OnPropertyValueChange(_.BID_ECTION_NUM, _BID_ECTION_NUM, value);
				this._BID_ECTION_NUM = value;
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
		/// 标段（包）招标方式
		/// </summary>
		public string BID_TENDER_MODE
		{
			get{ return _BID_TENDER_MODE; }
			set
			{
				this.OnPropertyValueChange(_.BID_TENDER_MODE, _BID_TENDER_MODE, value);
				this._BID_TENDER_MODE = value;
			}
		}
		/// <summary>
		/// 标段（包）所在行政区域代码
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
		/// 标段（包）内容
		/// </summary>
		public string BID_SECTION_CONTENT
		{
			get{ return _BID_SECTION_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_CONTENT, _BID_SECTION_CONTENT, value);
				this._BID_SECTION_CONTENT = value;
			}
		}
		/// <summary>
		/// 标段（包）分类代码
		/// </summary>
		public string TENDER_PROJECT_CLASSIFY_CODE
		{
			get{ return _TENDER_PROJECT_CLASSIFY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_CLASSIFY_CODE, _TENDER_PROJECT_CLASSIFY_CODE, value);
				this._TENDER_PROJECT_CLASSIFY_CODE = value;
			}
		}
		/// <summary>
		/// 标段合同估算价
		/// </summary>
		public decimal? CONTRACT_RECKON_PRICE
		{
			get{ return _CONTRACT_RECKON_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_RECKON_PRICE, _CONTRACT_RECKON_PRICE, value);
				this._CONTRACT_RECKON_PRICE = value;
			}
		}
		/// <summary>
		/// 标段合同估算价币种代码
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
		/// 标段合同估算价单位
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
		/// 投标人资格条件
		/// </summary>
		public string BID_QUALIFICATION
		{
			get{ return _BID_QUALIFICATION; }
			set
			{
				this.OnPropertyValueChange(_.BID_QUALIFICATION, _BID_QUALIFICATION, value);
				this._BID_QUALIFICATION = value;
			}
		}
		/// <summary>
		/// 计划开工日期
		/// </summary>
		public DateTime? BEGIN_DATE
		{
			get{ return _BEGIN_DATE; }
			set
			{
				this.OnPropertyValueChange(_.BEGIN_DATE, _BEGIN_DATE, value);
				this._BEGIN_DATE = value;
			}
		}
		/// <summary>
		/// 工期
		/// </summary>
		public decimal? LIMITE_TIME
		{
			get{ return _LIMITE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.LIMITE_TIME, _LIMITE_TIME, value);
				this._LIMITE_TIME = value;
			}
		}
		/// <summary>
		/// 标段(包)建立时间
		/// </summary>
		public DateTime? CREATE_TIME
		{
			get{ return _CREATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
				this._CREATE_TIME = value;
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
				_.BID_SECTION_NAME,
				_.BID_ECTION_NUM,
				_.UNIFIED_DEAL_CODE,
				_.BID_TENDER_MODE,
				_.REGION_CODE,
				_.TRA_PLACE_CODE,
				_.BID_SECTION_CONTENT,
				_.TENDER_PROJECT_CLASSIFY_CODE,
				_.CONTRACT_RECKON_PRICE,
				_.CURRENCY_CODE,
				_.PRICE_UNIT,
				_.BID_QUALIFICATION,
				_.BEGIN_DATE,
				_.LIMITE_TIME,
				_.CREATE_TIME,
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
				this._BID_SECTION_NAME,
				this._BID_ECTION_NUM,
				this._UNIFIED_DEAL_CODE,
				this._BID_TENDER_MODE,
				this._REGION_CODE,
				this._TRA_PLACE_CODE,
				this._BID_SECTION_CONTENT,
				this._TENDER_PROJECT_CLASSIFY_CODE,
				this._CONTRACT_RECKON_PRICE,
				this._CURRENCY_CODE,
				this._PRICE_UNIT,
				this._BID_QUALIFICATION,
				this._BEGIN_DATE,
				this._LIMITE_TIME,
				this._CREATE_TIME,
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
			public readonly static Field All = new Field("*", "XX_SECTION");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "XX_SECTION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "XX_SECTION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "XX_SECTION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "XX_SECTION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "XX_SECTION", "");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "XX_SECTION", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "XX_SECTION", "标段（包）编号");
            /// <summary>
			/// 标段（包）名称
			/// </summary>
			public readonly static Field BID_SECTION_NAME = new Field("BID_SECTION_NAME", "XX_SECTION", "标段（包）名称");
            /// <summary>
			/// 标段（包）招标次数
			/// </summary>
			public readonly static Field BID_ECTION_NUM = new Field("BID_ECTION_NUM", "XX_SECTION", "标段（包）招标次数");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "XX_SECTION", "统一交易标识码");
            /// <summary>
			/// 标段（包）招标方式
			/// </summary>
			public readonly static Field BID_TENDER_MODE = new Field("BID_TENDER_MODE", "XX_SECTION", "标段（包）招标方式");
            /// <summary>
			/// 标段（包）所在行政区域代码
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "XX_SECTION", "标段（包）所在行政区域代码");
            /// <summary>
			/// 交易发生行政区域代码
			/// </summary>
			public readonly static Field TRA_PLACE_CODE = new Field("TRA_PLACE_CODE", "XX_SECTION", "交易发生行政区域代码");
            /// <summary>
			/// 标段（包）内容
			/// </summary>
			public readonly static Field BID_SECTION_CONTENT = new Field("BID_SECTION_CONTENT", "XX_SECTION",DbType.AnsiString, null, "标段（包）内容");
            /// <summary>
			/// 标段（包）分类代码
			/// </summary>
			public readonly static Field TENDER_PROJECT_CLASSIFY_CODE = new Field("TENDER_PROJECT_CLASSIFY_CODE", "XX_SECTION", "标段（包）分类代码");
            /// <summary>
			/// 标段合同估算价
			/// </summary>
			public readonly static Field CONTRACT_RECKON_PRICE = new Field("CONTRACT_RECKON_PRICE", "XX_SECTION", "标段合同估算价");
            /// <summary>
			/// 标段合同估算价币种代码
			/// </summary>
			public readonly static Field CURRENCY_CODE = new Field("CURRENCY_CODE", "XX_SECTION", "标段合同估算价币种代码");
            /// <summary>
			/// 标段合同估算价单位
			/// </summary>
			public readonly static Field PRICE_UNIT = new Field("PRICE_UNIT", "XX_SECTION", "标段合同估算价单位");
            /// <summary>
			/// 投标人资格条件
			/// </summary>
			public readonly static Field BID_QUALIFICATION = new Field("BID_QUALIFICATION", "XX_SECTION",DbType.AnsiString, null, "投标人资格条件");
            /// <summary>
			/// 计划开工日期
			/// </summary>
			public readonly static Field BEGIN_DATE = new Field("BEGIN_DATE", "XX_SECTION", "计划开工日期");
            /// <summary>
			/// 工期
			/// </summary>
			public readonly static Field LIMITE_TIME = new Field("LIMITE_TIME", "XX_SECTION", "工期");
            /// <summary>
			/// 标段(包)建立时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "XX_SECTION", "标段(包)建立时间");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "XX_SECTION", "交易系统标识码");
            /// <summary>
			/// 交易服务系统标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "XX_SECTION", "交易服务系统标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "XX_SECTION", "数据时间戳");
            /// <summary>
			/// 交易平台或发布工具标识码
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "XX_SECTION", "交易平台或发布工具标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "XX_SECTION", "公共服务平台标识码");
        }
        #endregion
	}
}