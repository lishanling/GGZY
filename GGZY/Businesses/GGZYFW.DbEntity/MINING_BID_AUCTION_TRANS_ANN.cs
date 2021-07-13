using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类MINING_BID_AUCTION_TRANS_ANN。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("MINING_BID_AUCTION_TRANS_ANN")]
    [Serializable]
    public partial class MINING_BID_AUCTION_TRANS_ANN : FwEntity
    {
        #region Model
		private string _NA_APP_NAME;
		private DateTime? _PUBLISHING_TIME;
		private string _UNIFIED_DEAL_CODE;
		private string _URL;
		private decimal? _IN_BUY_KIND;
		private decimal? _IN_MINE_COME;
		private decimal? _QT_PLAN_YEARS;
		private decimal? _QT_TOTAL_AREA;
		private string _NA_GEOGRAPHY_POSITION;
		private string _NA_AREA_COORDINATE;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_ID;
		private string _M_ATT_MINING_TRANSFER_ANNOUCE;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _REGION_CODE;
		private string _TRA_PLACE_CODE;
		private string _TRA_AGENCY_NAME;
		private string _TRA_AGENCY_CODE;
		private string _M_VERSION;

		/// <summary>
		/// 矿山名称
		/// </summary>
		public string NA_APP_NAME
		{
			get{ return _NA_APP_NAME; }
			set
			{
				this.OnPropertyValueChange(_.NA_APP_NAME, _NA_APP_NAME, value);
				this._NA_APP_NAME = value;
			}
		}
		/// <summary>
		/// 发布时间
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
		/// 出让方式
		/// </summary>
		public decimal? IN_BUY_KIND
		{
			get{ return _IN_BUY_KIND; }
			set
			{
				this.OnPropertyValueChange(_.IN_BUY_KIND, _IN_BUY_KIND, value);
				this._IN_BUY_KIND = value;
			}
		}
		/// <summary>
		/// 矿种
		/// </summary>
		public decimal? IN_MINE_COME
		{
			get{ return _IN_MINE_COME; }
			set
			{
				this.OnPropertyValueChange(_.IN_MINE_COME, _IN_MINE_COME, value);
				this._IN_MINE_COME = value;
			}
		}
		/// <summary>
		/// 出让年限
		/// </summary>
		public decimal? QT_PLAN_YEARS
		{
			get{ return _QT_PLAN_YEARS; }
			set
			{
				this.OnPropertyValueChange(_.QT_PLAN_YEARS, _QT_PLAN_YEARS, value);
				this._QT_PLAN_YEARS = value;
			}
		}
		/// <summary>
		/// 面积
		/// </summary>
		public decimal? QT_TOTAL_AREA
		{
			get{ return _QT_TOTAL_AREA; }
			set
			{
				this.OnPropertyValueChange(_.QT_TOTAL_AREA, _QT_TOTAL_AREA, value);
				this._QT_TOTAL_AREA = value;
			}
		}
		/// <summary>
		/// 地理位置
		/// </summary>
		public string NA_GEOGRAPHY_POSITION
		{
			get{ return _NA_GEOGRAPHY_POSITION; }
			set
			{
				this.OnPropertyValueChange(_.NA_GEOGRAPHY_POSITION, _NA_GEOGRAPHY_POSITION, value);
				this._NA_GEOGRAPHY_POSITION = value;
			}
		}
		/// <summary>
		/// 区域坐标
		/// </summary>
		public string NA_AREA_COORDINATE
		{
			get{ return _NA_AREA_COORDINATE; }
			set
			{
				this.OnPropertyValueChange(_.NA_AREA_COORDINATE, _NA_AREA_COORDINATE, value);
				this._NA_AREA_COORDINATE = value;
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
		/// 采矿权招拍挂出让公告信息
		/// </summary>
		public string M_ATT_MINING_TRANSFER_ANNOUCE
		{
			get{ return _M_ATT_MINING_TRANSFER_ANNOUCE; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_MINING_TRANSFER_ANNOUCE, _M_ATT_MINING_TRANSFER_ANNOUCE, value);
				this._M_ATT_MINING_TRANSFER_ANNOUCE = value;
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
		/// 项目所在行政区域代码
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
				_.NA_APP_NAME,
				_.PUBLISHING_TIME,
				_.UNIFIED_DEAL_CODE,
				_.URL,
				_.IN_BUY_KIND,
				_.IN_MINE_COME,
				_.QT_PLAN_YEARS,
				_.QT_TOTAL_AREA,
				_.NA_GEOGRAPHY_POSITION,
				_.NA_AREA_COORDINATE,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_ID,
				_.M_ATT_MINING_TRANSFER_ANNOUCE,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
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
				this._NA_APP_NAME,
				this._PUBLISHING_TIME,
				this._UNIFIED_DEAL_CODE,
				this._URL,
				this._IN_BUY_KIND,
				this._IN_MINE_COME,
				this._QT_PLAN_YEARS,
				this._QT_TOTAL_AREA,
				this._NA_GEOGRAPHY_POSITION,
				this._NA_AREA_COORDINATE,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_ID,
				this._M_ATT_MINING_TRANSFER_ANNOUCE,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
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
			public readonly static Field All = new Field("*", "MINING_BID_AUCTION_TRANS_ANN");
            /// <summary>
			/// 矿山名称
			/// </summary>
			public readonly static Field NA_APP_NAME = new Field("NA_APP_NAME", "MINING_BID_AUCTION_TRANS_ANN", "矿山名称");
            /// <summary>
			/// 发布时间
			/// </summary>
			public readonly static Field PUBLISHING_TIME = new Field("PUBLISHING_TIME", "MINING_BID_AUCTION_TRANS_ANN", "发布时间");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "MINING_BID_AUCTION_TRANS_ANN", "统一交易标识码");
            /// <summary>
			/// 公告源URL
			/// </summary>
			public readonly static Field URL = new Field("URL", "MINING_BID_AUCTION_TRANS_ANN", "公告源URL");
            /// <summary>
			/// 出让方式
			/// </summary>
			public readonly static Field IN_BUY_KIND = new Field("IN_BUY_KIND", "MINING_BID_AUCTION_TRANS_ANN", "出让方式");
            /// <summary>
			/// 矿种
			/// </summary>
			public readonly static Field IN_MINE_COME = new Field("IN_MINE_COME", "MINING_BID_AUCTION_TRANS_ANN", "矿种");
            /// <summary>
			/// 出让年限
			/// </summary>
			public readonly static Field QT_PLAN_YEARS = new Field("QT_PLAN_YEARS", "MINING_BID_AUCTION_TRANS_ANN", "出让年限");
            /// <summary>
			/// 面积
			/// </summary>
			public readonly static Field QT_TOTAL_AREA = new Field("QT_TOTAL_AREA", "MINING_BID_AUCTION_TRANS_ANN", "面积");
            /// <summary>
			/// 地理位置
			/// </summary>
			public readonly static Field NA_GEOGRAPHY_POSITION = new Field("NA_GEOGRAPHY_POSITION", "MINING_BID_AUCTION_TRANS_ANN", "地理位置");
            /// <summary>
			/// 区域坐标
			/// </summary>
			public readonly static Field NA_AREA_COORDINATE = new Field("NA_AREA_COORDINATE", "MINING_BID_AUCTION_TRANS_ANN",DbType.AnsiString, null, "区域坐标");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "MINING_BID_AUCTION_TRANS_ANN", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "MINING_BID_AUCTION_TRANS_ANN", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "MINING_BID_AUCTION_TRANS_ANN", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "MINING_BID_AUCTION_TRANS_ANN", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "MINING_BID_AUCTION_TRANS_ANN", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "MINING_BID_AUCTION_TRANS_ANN", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "MINING_BID_AUCTION_TRANS_ANN", "");
            /// <summary>
			/// 采矿权招拍挂出让公告信息
			/// </summary>
			public readonly static Field M_ATT_MINING_TRANSFER_ANNOUCE = new Field("M_ATT_MINING_TRANSFER_ANNOUCE", "MINING_BID_AUCTION_TRANS_ANN", "采矿权招拍挂出让公告信息");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "MINING_BID_AUCTION_TRANS_ANN", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "MINING_BID_AUCTION_TRANS_ANN", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "MINING_BID_AUCTION_TRANS_ANN", "");
            /// <summary>
			/// 项目所在行政区域代码
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "MINING_BID_AUCTION_TRANS_ANN", "项目所在行政区域代码");
            /// <summary>
			/// 交易发生行政区域代码
			/// </summary>
			public readonly static Field TRA_PLACE_CODE = new Field("TRA_PLACE_CODE", "MINING_BID_AUCTION_TRANS_ANN", "交易发生行政区域代码");
            /// <summary>
			/// 交易机构名称
			/// </summary>
			public readonly static Field TRA_AGENCY_NAME = new Field("TRA_AGENCY_NAME", "MINING_BID_AUCTION_TRANS_ANN", "交易机构名称");
            /// <summary>
			/// 交易机构代码
			/// </summary>
			public readonly static Field TRA_AGENCY_CODE = new Field("TRA_AGENCY_CODE", "MINING_BID_AUCTION_TRANS_ANN", "交易机构代码");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "MINING_BID_AUCTION_TRANS_ANN", "");
        }
        #endregion
	}
}