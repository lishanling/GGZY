using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类DEAL_LAND_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("DEAL_LAND_INFO")]
    [Serializable]
    public partial class DEAL_LAND_INFO : FwEntity
    {
        #region Model
		private string _DEAL_LAND_CODE;
		private string _DEAL_ANNOUNCEMENT_GUID;
		private string _UNIFIED_DEAL_CODE;
		private string _INVEST_PROJECT_CODE;
		private string _LAND_PROJECT_NAME;
		private string _LAND_CODE;
		private decimal? _LAND_AREA;
		private string _LAND_USAGE;
		private string _LEND_AGE_LIMIT;
		private string _LAND_POSITION;
		private decimal? _DEAL_PRICE;
		private string _LENDING_NAME;
		private string _LAND_BZ;
		private string _LAND_URL;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _CURRENCY_CODE;
		private string _PRICE_UNIT;
		private DateTime? _PUBLISHING_TIME;
		private decimal? _M_ID;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _RELATE_CODE;
		private string _REGION_CODE;
		private string _TRA_PLACE_CODE;
		private string _TRA_AGENCY_NAME;
		private string _TRA_AGENCY_CODE;
		private string _LENDING_TYPE;
		private string _LENDING_CODE;
		private string _ANNOUNCEMENT_TITLE;
		private string _ANNOUNCEMENT_CONNECT;
		private string _M_VERSION;

		/// <summary>
		/// 成交宗地标示
		/// </summary>
		public string DEAL_LAND_CODE
		{
			get{ return _DEAL_LAND_CODE; }
			set
			{
				this.OnPropertyValueChange(_.DEAL_LAND_CODE, _DEAL_LAND_CODE, value);
				this._DEAL_LAND_CODE = value;
			}
		}
		/// <summary>
		/// 成交公示GUID
		/// </summary>
		public string DEAL_ANNOUNCEMENT_GUID
		{
			get{ return _DEAL_ANNOUNCEMENT_GUID; }
			set
			{
				this.OnPropertyValueChange(_.DEAL_ANNOUNCEMENT_GUID, _DEAL_ANNOUNCEMENT_GUID, value);
				this._DEAL_ANNOUNCEMENT_GUID = value;
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
		/// 投资项目统一代码
		/// </summary>
		public string INVEST_PROJECT_CODE
		{
			get{ return _INVEST_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.INVEST_PROJECT_CODE, _INVEST_PROJECT_CODE, value);
				this._INVEST_PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 项目名称
		/// </summary>
		public string LAND_PROJECT_NAME
		{
			get{ return _LAND_PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.LAND_PROJECT_NAME, _LAND_PROJECT_NAME, value);
				this._LAND_PROJECT_NAME = value;
			}
		}
		/// <summary>
		/// 宗地编号
		/// </summary>
		public string LAND_CODE
		{
			get{ return _LAND_CODE; }
			set
			{
				this.OnPropertyValueChange(_.LAND_CODE, _LAND_CODE, value);
				this._LAND_CODE = value;
			}
		}
		/// <summary>
		/// 土地面积
		/// </summary>
		public decimal? LAND_AREA
		{
			get{ return _LAND_AREA; }
			set
			{
				this.OnPropertyValueChange(_.LAND_AREA, _LAND_AREA, value);
				this._LAND_AREA = value;
			}
		}
		/// <summary>
		/// 土地用途
		/// </summary>
		public string LAND_USAGE
		{
			get{ return _LAND_USAGE; }
			set
			{
				this.OnPropertyValueChange(_.LAND_USAGE, _LAND_USAGE, value);
				this._LAND_USAGE = value;
			}
		}
		/// <summary>
		/// 出让年限
		/// </summary>
		public string LEND_AGE_LIMIT
		{
			get{ return _LEND_AGE_LIMIT; }
			set
			{
				this.OnPropertyValueChange(_.LEND_AGE_LIMIT, _LEND_AGE_LIMIT, value);
				this._LEND_AGE_LIMIT = value;
			}
		}
		/// <summary>
		/// 土地坐落
		/// </summary>
		public string LAND_POSITION
		{
			get{ return _LAND_POSITION; }
			set
			{
				this.OnPropertyValueChange(_.LAND_POSITION, _LAND_POSITION, value);
				this._LAND_POSITION = value;
			}
		}
		/// <summary>
		/// 成交价格
		/// </summary>
		public decimal? DEAL_PRICE
		{
			get{ return _DEAL_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.DEAL_PRICE, _DEAL_PRICE, value);
				this._DEAL_PRICE = value;
			}
		}
		/// <summary>
		/// 受让人名称
		/// </summary>
		public string LENDING_NAME
		{
			get{ return _LENDING_NAME; }
			set
			{
				this.OnPropertyValueChange(_.LENDING_NAME, _LENDING_NAME, value);
				this._LENDING_NAME = value;
			}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string LAND_BZ
		{
			get{ return _LAND_BZ; }
			set
			{
				this.OnPropertyValueChange(_.LAND_BZ, _LAND_BZ, value);
				this._LAND_BZ = value;
			}
		}
		/// <summary>
		/// 成交宗地公示URL
		/// </summary>
		public string LAND_URL
		{
			get{ return _LAND_URL; }
			set
			{
				this.OnPropertyValueChange(_.LAND_URL, _LAND_URL, value);
				this._LAND_URL = value;
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
		/// 公示发布时间
		/// </summary>
		public DateTime? PUBLISHING_TIME
		{
			get{ return _PUBLISHING_TIME; }
			set
			{
				this.OnPropertyValueChange(_.PUBLISHING_TIME, _PUBLISHING_TIME, value);
				this._PUBLISHING_TIME = value;
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
		/// 项目类别关联代码
		/// </summary>
		public string RELATE_CODE
		{
			get{ return _RELATE_CODE; }
			set
			{
				this.OnPropertyValueChange(_.RELATE_CODE, _RELATE_CODE, value);
				this._RELATE_CODE = value;
			}
		}
		/// <summary>
		/// 项目所在行政区划代码
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
		/// 受让人类别
		/// </summary>
		public string LENDING_TYPE
		{
			get{ return _LENDING_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.LENDING_TYPE, _LENDING_TYPE, value);
				this._LENDING_TYPE = value;
			}
		}
		/// <summary>
		/// 受让人代码
		/// </summary>
		public string LENDING_CODE
		{
			get{ return _LENDING_CODE; }
			set
			{
				this.OnPropertyValueChange(_.LENDING_CODE, _LENDING_CODE, value);
				this._LENDING_CODE = value;
			}
		}
		/// <summary>
		/// 成交公示标题
		/// </summary>
		public string ANNOUNCEMENT_TITLE
		{
			get{ return _ANNOUNCEMENT_TITLE; }
			set
			{
				this.OnPropertyValueChange(_.ANNOUNCEMENT_TITLE, _ANNOUNCEMENT_TITLE, value);
				this._ANNOUNCEMENT_TITLE = value;
			}
		}
		/// <summary>
		/// 成交公示内容
		/// </summary>
		public string ANNOUNCEMENT_CONNECT
		{
			get{ return _ANNOUNCEMENT_CONNECT; }
			set
			{
				this.OnPropertyValueChange(_.ANNOUNCEMENT_CONNECT, _ANNOUNCEMENT_CONNECT, value);
				this._ANNOUNCEMENT_CONNECT = value;
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
				_.DEAL_LAND_CODE,
				_.DEAL_ANNOUNCEMENT_GUID,
				_.UNIFIED_DEAL_CODE,
				_.INVEST_PROJECT_CODE,
				_.LAND_PROJECT_NAME,
				_.LAND_CODE,
				_.LAND_AREA,
				_.LAND_USAGE,
				_.LEND_AGE_LIMIT,
				_.LAND_POSITION,
				_.DEAL_PRICE,
				_.LENDING_NAME,
				_.LAND_BZ,
				_.LAND_URL,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.CURRENCY_CODE,
				_.PRICE_UNIT,
				_.PUBLISHING_TIME,
				_.M_ID,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.RELATE_CODE,
				_.REGION_CODE,
				_.TRA_PLACE_CODE,
				_.TRA_AGENCY_NAME,
				_.TRA_AGENCY_CODE,
				_.LENDING_TYPE,
				_.LENDING_CODE,
				_.ANNOUNCEMENT_TITLE,
				_.ANNOUNCEMENT_CONNECT,
				_.M_VERSION,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._DEAL_LAND_CODE,
				this._DEAL_ANNOUNCEMENT_GUID,
				this._UNIFIED_DEAL_CODE,
				this._INVEST_PROJECT_CODE,
				this._LAND_PROJECT_NAME,
				this._LAND_CODE,
				this._LAND_AREA,
				this._LAND_USAGE,
				this._LEND_AGE_LIMIT,
				this._LAND_POSITION,
				this._DEAL_PRICE,
				this._LENDING_NAME,
				this._LAND_BZ,
				this._LAND_URL,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._CURRENCY_CODE,
				this._PRICE_UNIT,
				this._PUBLISHING_TIME,
				this._M_ID,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._RELATE_CODE,
				this._REGION_CODE,
				this._TRA_PLACE_CODE,
				this._TRA_AGENCY_NAME,
				this._TRA_AGENCY_CODE,
				this._LENDING_TYPE,
				this._LENDING_CODE,
				this._ANNOUNCEMENT_TITLE,
				this._ANNOUNCEMENT_CONNECT,
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
			public readonly static Field All = new Field("*", "DEAL_LAND_INFO");
            /// <summary>
			/// 成交宗地标示
			/// </summary>
			public readonly static Field DEAL_LAND_CODE = new Field("DEAL_LAND_CODE", "DEAL_LAND_INFO", "成交宗地标示");
            /// <summary>
			/// 成交公示GUID
			/// </summary>
			public readonly static Field DEAL_ANNOUNCEMENT_GUID = new Field("DEAL_ANNOUNCEMENT_GUID", "DEAL_LAND_INFO", "成交公示GUID");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "DEAL_LAND_INFO", "统一交易标识码");
            /// <summary>
			/// 投资项目统一代码
			/// </summary>
			public readonly static Field INVEST_PROJECT_CODE = new Field("INVEST_PROJECT_CODE", "DEAL_LAND_INFO", "投资项目统一代码");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field LAND_PROJECT_NAME = new Field("LAND_PROJECT_NAME", "DEAL_LAND_INFO", "项目名称");
            /// <summary>
			/// 宗地编号
			/// </summary>
			public readonly static Field LAND_CODE = new Field("LAND_CODE", "DEAL_LAND_INFO", "宗地编号");
            /// <summary>
			/// 土地面积
			/// </summary>
			public readonly static Field LAND_AREA = new Field("LAND_AREA", "DEAL_LAND_INFO", "土地面积");
            /// <summary>
			/// 土地用途
			/// </summary>
			public readonly static Field LAND_USAGE = new Field("LAND_USAGE", "DEAL_LAND_INFO", "土地用途");
            /// <summary>
			/// 出让年限
			/// </summary>
			public readonly static Field LEND_AGE_LIMIT = new Field("LEND_AGE_LIMIT", "DEAL_LAND_INFO", "出让年限");
            /// <summary>
			/// 土地坐落
			/// </summary>
			public readonly static Field LAND_POSITION = new Field("LAND_POSITION", "DEAL_LAND_INFO", "土地坐落");
            /// <summary>
			/// 成交价格
			/// </summary>
			public readonly static Field DEAL_PRICE = new Field("DEAL_PRICE", "DEAL_LAND_INFO", "成交价格");
            /// <summary>
			/// 受让人名称
			/// </summary>
			public readonly static Field LENDING_NAME = new Field("LENDING_NAME", "DEAL_LAND_INFO", "受让人名称");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field LAND_BZ = new Field("LAND_BZ", "DEAL_LAND_INFO",DbType.AnsiString, null, "备注");
            /// <summary>
			/// 成交宗地公示URL
			/// </summary>
			public readonly static Field LAND_URL = new Field("LAND_URL", "DEAL_LAND_INFO", "成交宗地公示URL");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "DEAL_LAND_INFO", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "DEAL_LAND_INFO", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "DEAL_LAND_INFO", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "DEAL_LAND_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "DEAL_LAND_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "DEAL_LAND_INFO", "");
            /// <summary>
			/// 价格币种代码
			/// </summary>
			public readonly static Field CURRENCY_CODE = new Field("CURRENCY_CODE", "DEAL_LAND_INFO", "价格币种代码");
            /// <summary>
			/// 价格单位
			/// </summary>
			public readonly static Field PRICE_UNIT = new Field("PRICE_UNIT", "DEAL_LAND_INFO", "价格单位");
            /// <summary>
			/// 公示发布时间
			/// </summary>
			public readonly static Field PUBLISHING_TIME = new Field("PUBLISHING_TIME", "DEAL_LAND_INFO", "公示发布时间");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "DEAL_LAND_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "DEAL_LAND_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "DEAL_LAND_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "DEAL_LAND_INFO", "");
            /// <summary>
			/// 项目类别关联代码
			/// </summary>
			public readonly static Field RELATE_CODE = new Field("RELATE_CODE", "DEAL_LAND_INFO", "项目类别关联代码");
            /// <summary>
			/// 项目所在行政区划代码
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "DEAL_LAND_INFO", "项目所在行政区划代码");
            /// <summary>
			/// 交易发生行政区域代码
			/// </summary>
			public readonly static Field TRA_PLACE_CODE = new Field("TRA_PLACE_CODE", "DEAL_LAND_INFO", "交易发生行政区域代码");
            /// <summary>
			/// 交易机构名称
			/// </summary>
			public readonly static Field TRA_AGENCY_NAME = new Field("TRA_AGENCY_NAME", "DEAL_LAND_INFO", "交易机构名称");
            /// <summary>
			/// 交易机构代码
			/// </summary>
			public readonly static Field TRA_AGENCY_CODE = new Field("TRA_AGENCY_CODE", "DEAL_LAND_INFO", "交易机构代码");
            /// <summary>
			/// 受让人类别
			/// </summary>
			public readonly static Field LENDING_TYPE = new Field("LENDING_TYPE", "DEAL_LAND_INFO", "受让人类别");
            /// <summary>
			/// 受让人代码
			/// </summary>
			public readonly static Field LENDING_CODE = new Field("LENDING_CODE", "DEAL_LAND_INFO", "受让人代码");
            /// <summary>
			/// 成交公示标题
			/// </summary>
			public readonly static Field ANNOUNCEMENT_TITLE = new Field("ANNOUNCEMENT_TITLE", "DEAL_LAND_INFO", "成交公示标题");
            /// <summary>
			/// 成交公示内容
			/// </summary>
			public readonly static Field ANNOUNCEMENT_CONNECT = new Field("ANNOUNCEMENT_CONNECT", "DEAL_LAND_INFO",DbType.AnsiString, null, "成交公示内容");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "DEAL_LAND_INFO", "");
        }
        #endregion
	}
}